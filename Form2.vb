Imports System.ComponentModel

Public Class Form2

    Private iTempPointerX As Integer 'マウスポインタX移動中
    Private iTempPointerY As Integer 'マウスポインタY移動中
    Private iPointerX As Integer '開始位置X
    Private iPointerY As Integer '開始位置Y
    Private iPointerSettingFlg As Integer = 0 '開始位置設定済みフラグ
    Private sFontFamily As Font 'フォント
    Private sFontColor As Color 'フォント色
    Private iFontSettingFlg As Integer = 0 'フォント設定済みフラグ

#Region "マウスポインタの位置を左下に表示"

    Private Sub LyricsImage_MouseEnter(sender As Object, e As EventArgs) Handles LyricsImage.MouseMove

        Try

            '画面座標でマウスポインタの位置を取得
            Dim sp As Point = Cursor.Position

            '画面座標をクライアント座標に変換する
            Dim cp As System.Drawing.Point = Me.PointToClient(sp)

            'X座標を取得する
            iTempPointerX = cp.X

            'Y座標を取得する
            iTempPointerY = cp.Y

            '今たぶん1ドットずれるバグがあるけどまぁ1ドットならいいだろ（適当）

            '位置を表示
            lblPositionX.Text = iTempPointerX
            lblPositionY.Text = iTempPointerY

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

#End Region

#Region "歌詞の入力開始位置を指定"

    Private Sub LyricsImage_Click(sender As Object, e As EventArgs) Handles LyricsImage.Click


        Try

            '開始位置を確定
            iPointerX = iTempPointerX
            iPointerY = iTempPointerY

            '設定済みフラグをON
            iPointerSettingFlg = 1

            '画面に表示
            StartPositionInfo.Text = iPointerX & ", " & iPointerY

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

#End Region

#Region "フォント設定"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            'フォントダイアログのインスタンスを生成
            Dim fd As New FontDialog()
            Dim cd As New ColorDialog()

            'ダイアログ表示
            If fd.ShowDialog() <> DialogResult.Cancel Then

                If cd.ShowDialog <> DialogResult.Cancel Then

                    '設定済みフラグをON
                    iFontSettingFlg = 1

                    'TextBox1のフォントと色を変える
                    sFontFamily = fd.Font
                    sFontColor = cd.Color

                    '画面に情報を表示
                    FontInfo.Text = sFontFamily.Name & ", " & sFontFamily.Size & ", " & sFontColor.Name

                    '画面にプレビュー表示
                    FontPreview.Font = sFontFamily
                    FontPreview.ForeColor = sFontColor
                    FontPreview.Text = "このように表示されます。"

                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

#End Region

#Region "フォーム閉じるときに値を元のフォームに設定"
    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Try

            '設定済みフラグがONの場合のみ元のフォームに値を設定
            If iPointerSettingFlg = 1 And iFontSettingFlg = 1 Then

                'フォームを取得
                Dim frm As Form1 = CType(Me.Owner, Form1)

                '値を設定
                frm.iLyricsStartX = iPointerX
                frm.iLyricsStartY = iPointerY
                frm.sFontFamily = sFontFamily
                frm.sFontColor = sFontColor

                '歌詞ドロップエリアを表示
                frm.TextDrag.Visible = True

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

#End Region

End Class