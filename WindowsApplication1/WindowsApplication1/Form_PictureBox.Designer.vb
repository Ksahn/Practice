<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_PictureBox
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TrackBar_R = New System.Windows.Forms.TrackBar()
        Me.TrackBar_G = New System.Windows.Forms.TrackBar()
        Me.TrackBar_B = New System.Windows.Forms.TrackBar()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_select = New System.Windows.Forms.Button()
        Me.btn_claer = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_save = New System.Windows.Forms.Button()
        CType(Me.TrackBar_R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar_G, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar_B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TrackBar_R
        '
        Me.TrackBar_R.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBar_R.Location = New System.Drawing.Point(660, 17)
        Me.TrackBar_R.Name = "TrackBar_R"
        Me.TrackBar_R.Size = New System.Drawing.Size(229, 45)
        Me.TrackBar_R.TabIndex = 4
        '
        'TrackBar_G
        '
        Me.TrackBar_G.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBar_G.Location = New System.Drawing.Point(660, 68)
        Me.TrackBar_G.Name = "TrackBar_G"
        Me.TrackBar_G.Size = New System.Drawing.Size(229, 45)
        Me.TrackBar_G.TabIndex = 5
        '
        'TrackBar_B
        '
        Me.TrackBar_B.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBar_B.Location = New System.Drawing.Point(660, 119)
        Me.TrackBar_B.Name = "TrackBar_B"
        Me.TrackBar_B.Size = New System.Drawing.Size(229, 45)
        Me.TrackBar_B.TabIndex = 6
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.Location = New System.Drawing.Point(617, 207)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(290, 195)
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(640, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 12)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "R"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(640, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 12)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "G"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(641, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 12)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "B"
        '
        'btn_select
        '
        Me.btn_select.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_select.Location = New System.Drawing.Point(226, 430)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(80, 33)
        Me.btn_select.TabIndex = 10
        Me.btn_select.Text = "Select Image"
        Me.btn_select.UseVisualStyleBackColor = True
        '
        'btn_claer
        '
        Me.btn_claer.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_claer.Location = New System.Drawing.Point(312, 430)
        Me.btn_claer.Name = "btn_claer"
        Me.btn_claer.Size = New System.Drawing.Size(80, 33)
        Me.btn_claer.TabIndex = 11
        Me.btn_claer.Text = "Clear Image"
        Me.btn_claer.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(580, 390)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 410)
        Me.Panel1.TabIndex = 12
        '
        'btn_save
        '
        Me.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_save.Location = New System.Drawing.Point(398, 430)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 33)
        Me.btn_save.TabIndex = 13
        Me.btn_save.Text = "Save Image"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Form_PictureBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 474)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_claer)
        Me.Controls.Add(Me.btn_select)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TrackBar_B)
        Me.Controls.Add(Me.TrackBar_G)
        Me.Controls.Add(Me.TrackBar_R)
        Me.Controls.Add(Me.PictureBox4)
        Me.Name = "Form_PictureBox"
        Me.Text = "Form_PictureBox"
        CType(Me.TrackBar_R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar_G, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar_B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TrackBar_R As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBar_G As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBar_B As System.Windows.Forms.TrackBar
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_select As System.Windows.Forms.Button
    Friend WithEvents btn_claer As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_save As System.Windows.Forms.Button
End Class
