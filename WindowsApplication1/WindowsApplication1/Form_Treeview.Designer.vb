<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Treeview
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
        Me.components = New System.ComponentModel.Container()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Pnl_grup = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_addG = New System.Windows.Forms.TextBox()
        Me.btn_Grupcsl = New System.Windows.Forms.Button()
        Me.btn_Grupadd = New System.Windows.Forms.Button()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip0 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txt_rename = New System.Windows.Forms.TextBox()
        Me.Pnl_grup.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.Location = New System.Drawing.Point(12, 12)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(354, 354)
        Me.TreeView1.TabIndex = 8
        '
        'Pnl_grup
        '
        Me.Pnl_grup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_grup.Controls.Add(Me.Label2)
        Me.Pnl_grup.Controls.Add(Me.txt_addG)
        Me.Pnl_grup.Controls.Add(Me.btn_Grupcsl)
        Me.Pnl_grup.Controls.Add(Me.btn_Grupadd)
        Me.Pnl_grup.Location = New System.Drawing.Point(12, 12)
        Me.Pnl_grup.Name = "Pnl_grup"
        Me.Pnl_grup.Size = New System.Drawing.Size(200, 84)
        Me.Pnl_grup.TabIndex = 11
        Me.Pnl_grup.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NAME"
        '
        'txt_addG
        '
        Me.txt_addG.Location = New System.Drawing.Point(45, 12)
        Me.txt_addG.Name = "txt_addG"
        Me.txt_addG.Size = New System.Drawing.Size(147, 21)
        Me.txt_addG.TabIndex = 2
        '
        'btn_Grupcsl
        '
        Me.btn_Grupcsl.Location = New System.Drawing.Point(111, 45)
        Me.btn_Grupcsl.Name = "btn_Grupcsl"
        Me.btn_Grupcsl.Size = New System.Drawing.Size(75, 23)
        Me.btn_Grupcsl.TabIndex = 0
        Me.btn_Grupcsl.Text = "Cansle"
        Me.btn_Grupcsl.UseVisualStyleBackColor = True
        '
        'btn_Grupadd
        '
        Me.btn_Grupadd.Location = New System.Drawing.Point(18, 45)
        Me.btn_Grupadd.Name = "btn_Grupadd"
        Me.btn_Grupadd.Size = New System.Drawing.Size(75, 23)
        Me.btn_Grupadd.TabIndex = 0
        Me.btn_Grupadd.Text = "Add"
        Me.btn_Grupadd.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip4"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip0
        '
        Me.ContextMenuStrip0.Name = "ContextMenuStrip4"
        Me.ContextMenuStrip0.Size = New System.Drawing.Size(61, 4)
        '
        'txt_rename
        '
        Me.txt_rename.Location = New System.Drawing.Point(218, 25)
        Me.txt_rename.Name = "txt_rename"
        Me.txt_rename.Size = New System.Drawing.Size(100, 21)
        Me.txt_rename.TabIndex = 12
        Me.txt_rename.TabStop = False
        Me.txt_rename.Visible = False
        '
        'Form_Treeview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 380)
        Me.Controls.Add(Me.txt_rename)
        Me.Controls.Add(Me.Pnl_grup)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "Form_Treeview"
        Me.Text = "BookMark"
        Me.Pnl_grup.ResumeLayout(False)
        Me.Pnl_grup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Pnl_grup As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_addG As System.Windows.Forms.TextBox
    Friend WithEvents btn_Grupcsl As System.Windows.Forms.Button
    Friend WithEvents btn_Grupadd As System.Windows.Forms.Button
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ContextMenuStrip0 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents txt_rename As System.Windows.Forms.TextBox
End Class
