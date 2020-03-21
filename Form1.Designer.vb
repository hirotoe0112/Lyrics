<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageDrag = New System.Windows.Forms.Label()
        Me.TextDrag = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("ニコ角", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button1.Location = New System.Drawing.Point(12, 212)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(221, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "もう…世話が焼けるんだからっ！"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ImageDrag
        '
        Me.ImageDrag.AllowDrop = True
        Me.ImageDrag.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ImageDrag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImageDrag.Font = New System.Drawing.Font("源暎ラテミン", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ImageDrag.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ImageDrag.Location = New System.Drawing.Point(12, 40)
        Me.ImageDrag.Name = "ImageDrag"
        Me.ImageDrag.Size = New System.Drawing.Size(221, 70)
        Me.ImageDrag.TabIndex = 1
        Me.ImageDrag.Text = "画像ファイル（800×600）を" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ドラッグ＆ドロップしてください"
        Me.ImageDrag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextDrag
        '
        Me.TextDrag.AllowDrop = True
        Me.TextDrag.BackColor = System.Drawing.Color.Honeydew
        Me.TextDrag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextDrag.Font = New System.Drawing.Font("源暎ラテミン", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextDrag.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TextDrag.Location = New System.Drawing.Point(12, 126)
        Me.TextDrag.Name = "TextDrag"
        Me.TextDrag.Size = New System.Drawing.Size(221, 70)
        Me.TextDrag.TabIndex = 1
        Me.TextDrag.Text = "歌詞ファイルを" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ドラッグ＆ドロップしてください"
        Me.TextDrag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("07ロゴたいぷゴシック7", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(9, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "歌詞画像作る君(v1.0) byようか"
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 265)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextDrag)
        Me.Controls.Add(Me.ImageDrag)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "歌詞画像作る君"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ImageDrag As Label
    Friend WithEvents TextDrag As Label
    Friend WithEvents Label3 As Label
End Class
