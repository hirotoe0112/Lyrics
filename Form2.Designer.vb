<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LyricsImage = New System.Windows.Forms.PictureBox()
        Me.lblPositionStringX = New System.Windows.Forms.Label()
        Me.lblPositionStringY = New System.Windows.Forms.Label()
        Me.lblPositionX = New System.Windows.Forms.Label()
        Me.lblPositionY = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StartPositionInfo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FontPreview = New System.Windows.Forms.Label()
        Me.FontInfo = New System.Windows.Forms.Label()
        CType(Me.LyricsImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LyricsImage
        '
        Me.LyricsImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LyricsImage.Location = New System.Drawing.Point(0, 0)
        Me.LyricsImage.Name = "LyricsImage"
        Me.LyricsImage.Size = New System.Drawing.Size(800, 600)
        Me.LyricsImage.TabIndex = 0
        Me.LyricsImage.TabStop = False
        '
        'lblPositionStringX
        '
        Me.lblPositionStringX.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPositionStringX.AutoSize = True
        Me.lblPositionStringX.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPositionStringX.Location = New System.Drawing.Point(-2, 603)
        Me.lblPositionStringX.Name = "lblPositionStringX"
        Me.lblPositionStringX.Size = New System.Drawing.Size(17, 12)
        Me.lblPositionStringX.TabIndex = 1
        Me.lblPositionStringX.Text = "X:"
        '
        'lblPositionStringY
        '
        Me.lblPositionStringY.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPositionStringY.AutoSize = True
        Me.lblPositionStringY.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPositionStringY.Location = New System.Drawing.Point(-2, 615)
        Me.lblPositionStringY.Name = "lblPositionStringY"
        Me.lblPositionStringY.Size = New System.Drawing.Size(17, 12)
        Me.lblPositionStringY.TabIndex = 1
        Me.lblPositionStringY.Text = "Y:"
        '
        'lblPositionX
        '
        Me.lblPositionX.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPositionX.AutoSize = True
        Me.lblPositionX.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPositionX.Location = New System.Drawing.Point(12, 603)
        Me.lblPositionX.Name = "lblPositionX"
        Me.lblPositionX.Size = New System.Drawing.Size(0, 12)
        Me.lblPositionX.TabIndex = 1
        '
        'lblPositionY
        '
        Me.lblPositionY.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPositionY.AutoSize = True
        Me.lblPositionY.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPositionY.Location = New System.Drawing.Point(12, 615)
        Me.lblPositionY.Name = "lblPositionY"
        Me.lblPositionY.Size = New System.Drawing.Size(0, 12)
        Me.lblPositionY.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(-2, 644)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "歌詞表示開始位置："
        '
        'StartPositionInfo
        '
        Me.StartPositionInfo.AutoSize = True
        Me.StartPositionInfo.Location = New System.Drawing.Point(117, 644)
        Me.StartPositionInfo.Name = "StartPositionInfo"
        Me.StartPositionInfo.Size = New System.Drawing.Size(0, 12)
        Me.StartPositionInfo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 664)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "フォント："
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(111, 659)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "設定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FontPreview
        '
        Me.FontPreview.AutoSize = True
        Me.FontPreview.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FontPreview.Location = New System.Drawing.Point(109, 685)
        Me.FontPreview.Name = "FontPreview"
        Me.FontPreview.Size = New System.Drawing.Size(0, 12)
        Me.FontPreview.TabIndex = 2
        '
        'FontInfo
        '
        Me.FontInfo.AutoSize = True
        Me.FontInfo.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FontInfo.Location = New System.Drawing.Point(160, 664)
        Me.FontInfo.Name = "FontInfo"
        Me.FontInfo.Size = New System.Drawing.Size(0, 12)
        Me.FontInfo.TabIndex = 2
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 761)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StartPositionInfo)
        Me.Controls.Add(Me.FontPreview)
        Me.Controls.Add(Me.FontInfo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPositionY)
        Me.Controls.Add(Me.lblPositionStringY)
        Me.Controls.Add(Me.lblPositionX)
        Me.Controls.Add(Me.lblPositionStringX)
        Me.Controls.Add(Me.LyricsImage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form2"
        Me.Text = "設定"
        CType(Me.LyricsImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LyricsImage As PictureBox
    Friend WithEvents lblPositionStringX As Label
    Friend WithEvents lblPositionStringY As Label
    Friend WithEvents lblPositionX As Label
    Friend WithEvents lblPositionY As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents StartPositionInfo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents FontPreview As Label
    Friend WithEvents FontInfo As Label
End Class
