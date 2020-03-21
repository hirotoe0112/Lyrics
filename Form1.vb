Imports System.Drawing
Imports System.IO

Public Class Form1

    Private sImportFileName As String '入力画像フルパス
    Private sTextFileName As String '歌詞ファイルフルパス
    Public iLyricsStartX As Integer '歌詞表示位置X
    Public iLyricsStartY As Integer '歌詞表示位置Y
    Public sFontFamily As Font 'フォント
    Public sFontColor As Color 'フォント色

#Region "ロード時処理"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        'ロード時は歌詞のドロップエリアとボタンは表示しない
        TextDrag.Visible = False
        Button1.Visible = False

    End Sub

#End Region

#Region "画像ドラッグ＆ドロップ"

    'ドラッグ受け入れイベントハンドラ
    Private Sub ImageDrag_DragEnter(sender As Object, e As DragEventArgs) Handles ImageDrag.DragEnter

        Try

            'コントロール内にドラッグされたとき実行される
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then

                'ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
                e.Effect = DragDropEffects.Copy

            Else

                'ファイル以外は受け付けない
                e.Effect = DragDropEffects.None

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    'ドロップ時処理
    Private Sub ImageDrag_DragDrop(sender As Object, e As DragEventArgs) Handles ImageDrag.DragDrop

        Try

            'ドラッグ＆ドロップされたファイルを取得
            Dim fileName As String() = CType(e.Data.GetData(DataFormats.FileDrop, False), String())

            '複数の場合はエラー
            If fileName.Count > 1 Then

                MsgBox("欲張んな")

                Exit Sub

            End If

            'PNGじゃない場合はエラー
            '現在は拡張子をチェックするだけのしょぼいチェック
            If Path.GetExtension(fileName(0).ToString.ToLower) <> ".png" Then

                MsgBox("このバージョンではpngのみ対応")

                Exit Sub

            End If

            'クラス変数にセット
            sImportFileName = fileName(0)

            '画像設定フォームに画像を設定
            Dim fmSettings As New Form2
            fmSettings.LyricsImage.ImageLocation = sImportFileName

            'フォームを開く
            fmSettings.ShowDialog(Me)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

#End Region

#Region "歌詞ドラッグ＆ドロップ"

    'ドラッグ受け入れイベントハンドラ
    Private Sub TextDrag_DragEnter(sender As Object, e As DragEventArgs) Handles TextDrag.DragEnter

        Try

            'コントロール内にドラッグされたとき実行される
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then

                'ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
                e.Effect = DragDropEffects.Copy

            Else

                'ファイル以外は受け付けない
                e.Effect = DragDropEffects.None

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    'ドロップ時処理
    Private Sub TextDrag_DragDrop(sender As Object, e As DragEventArgs) Handles TextDrag.DragDrop

        Try

            'ドラッグ＆ドロップされたファイルを取得
            Dim fileName As String() = CType(e.Data.GetData(DataFormats.FileDrop, False), String())

            '複数の場合はエラー
            If fileName.Count > 1 Then

                MsgBox("欲張んな")

                Exit Sub

            End If

            'TXTじゃない場合はエラー
            '現在は拡張子をチェックするだけのしょぼいチェック
            If Path.GetExtension(fileName(0).ToString.ToLower) <> ".txt" Then

                MsgBox("テキストファイル以外読めるわけないだろいい加減にしろ")

                Exit Sub

            End If

            'フルパスをクラス変数にセット
            sTextFileName = fileName(0)

            '生成ボタンを表示
            Button1.Visible = True

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

#End Region

#Region "生成"

    'ボタン押下時処理
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            'ファイルの存在チェック
            If Not IO.File.Exists(sTextFileName) Then

                MsgBox("ファイルねーよ")

                Exit Sub

            End If

            'ファイル読み込み
            Dim cReader As New StreamReader(sTextFileName, System.Text.Encoding.GetEncoding("shift_jis"))

            '出力画像ファイル名格納用変数
            Dim sImageFileName As String = ""

            '出力文字列格納用変数
            Dim sLyrics As String = ""

            '読み込み一時変数
            Dim sReadLine As String = ""

            '1行ずつ読み込む
            While (cReader.Peek() >= 0)

                '読み込み
                sReadLine = ""
                sReadLine = cReader.ReadLine()

                '先頭が:であるかチェック
                If Mid(sReadLine, 1, 1) = ":" Then

                    ':であったら出力画像ファイル名をセット
                    sImageFileName = Mid(sReadLine, 2, sReadLine.Length - 1) & ".png"

                    '画像生成
                    fncOutputImage(sImageFileName, sLyrics)

                    '変数を初期化
                    sImageFileName = ""
                    sLyrics = ""

                Else

                    ':でない場合は出力文字列に追加
                    sLyrics = sLyrics & sReadLine & vbCrLf

                End If

            End While

            MsgBox("おわたよ")

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    '画像生成
    Private Sub fncOutputImage(ByVal sOutputImageFile As String, ByVal sLyrics As String)

        '画像ファイルを読み込んでBitmap型にキャストする
        Dim img As Image = Image.FromFile(sImportFileName)
        Dim bmpOriginalFile As Bitmap = DirectCast(img, Bitmap)

        '出力画像フルパスをセット
        Dim sOutputFullPath As String = Path.Combine(Path.GetDirectoryName(sImportFileName), sOutputImageFile)

        '品質
        Dim quality As Integer = 85

        'Graphicsオブジェクトを取得
        Dim grp As Graphics = Graphics.FromImage(bmpOriginalFile)

        '画像を描画
        grp.DrawImage(bmpOriginalFile, 0, 0, bmpOriginalFile.Width, bmpOriginalFile.Height)

        '指定した色のブラシを作成
        Dim brs As Brush = New SolidBrush(sFontColor)

        '文字の領域サイズを取得
        Dim sf As StringFormat = New StringFormat()
        Dim stringSize As SizeF = grp.MeasureString(sLyrics, sFontFamily, bmpOriginalFile.Width, sf)

        '文字を描画
        grp.DrawString(sLyrics, sFontFamily, brs, iLyricsStartX, iLyricsStartY)

        '品質を指定
        Dim eps As Imaging.EncoderParameters = New Imaging.EncoderParameters(1)
        eps.Param(0) = New Imaging.EncoderParameter(Imaging.Encoder.Quality, quality)

        'エンコーダを取得
        Dim ici As Imaging.ImageCodecInfo = GetEncoderInfo("image/png")

        'PNG形式で画像を保存
        bmpOriginalFile.Save(sOutputFullPath, ici, eps)

        '解放
        bmpOriginalFile.Dispose()

    End Sub

    'エンコーダを取得
    Private Shared Function GetEncoderInfo(mimeType As String) As System.Drawing.Imaging.ImageCodecInfo

        'GDI+ に組み込まれたイメージ エンコーダに関する情報をすべて取得
        Dim encs As System.Drawing.Imaging.ImageCodecInfo() = Imaging.ImageCodecInfo.GetImageEncoders()

        '指定されたMimeTypeを探して見つかれば返す
        Dim enc As System.Drawing.Imaging.ImageCodecInfo

        For Each enc In encs

            If enc.MimeType = mimeType Then

                Return enc

            End If

        Next

        Return Nothing

    End Function

#End Region

End Class
