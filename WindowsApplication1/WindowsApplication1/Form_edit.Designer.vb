<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_edit
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
        Me.btn_cnl = New System.Windows.Forms.Button()
        Me.btn_Modified = New System.Windows.Forms.Button()
        Me.txt_showname = New System.Windows.Forms.TextBox()
        Me.lbl_showname = New System.Windows.Forms.Label()
        Me.txt_department = New System.Windows.Forms.TextBox()
        Me.lbl_department = New System.Windows.Forms.Label()
        Me.lbl_company = New System.Windows.Forms.Label()
        Me.txt_company = New System.Windows.Forms.TextBox()
        Me.txt_endpn = New System.Windows.Forms.TextBox()
        Me.txt_midlpn = New System.Windows.Forms.TextBox()
        Me.txt_firstpn = New System.Windows.Forms.TextBox()
        Me.lbl_phone = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_firstname = New System.Windows.Forms.TextBox()
        Me.lbl_Email = New System.Windows.Forms.Label()
        Me.lbl_firstname = New System.Windows.Forms.Label()
        Me.lbl_lastname = New System.Windows.Forms.Label()
        Me.txt_lastname = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_cnl
        '
        Me.btn_cnl.Location = New System.Drawing.Point(174, 193)
        Me.btn_cnl.Name = "btn_cnl"
        Me.btn_cnl.Size = New System.Drawing.Size(75, 23)
        Me.btn_cnl.TabIndex = 53
        Me.btn_cnl.Text = "cancel"
        Me.btn_cnl.UseVisualStyleBackColor = True
        '
        'btn_Modified
        '
        Me.btn_Modified.Location = New System.Drawing.Point(78, 193)
        Me.btn_Modified.Name = "btn_Modified"
        Me.btn_Modified.Size = New System.Drawing.Size(75, 23)
        Me.btn_Modified.TabIndex = 52
        Me.btn_Modified.Text = "Modified"
        Me.btn_Modified.UseVisualStyleBackColor = True
        '
        'txt_showname
        '
        Me.txt_showname.Location = New System.Drawing.Point(70, 154)
        Me.txt_showname.Name = "txt_showname"
        Me.txt_showname.Size = New System.Drawing.Size(238, 21)
        Me.txt_showname.TabIndex = 51
        '
        'lbl_showname
        '
        Me.lbl_showname.AutoSize = True
        Me.lbl_showname.Location = New System.Drawing.Point(18, 157)
        Me.lbl_showname.Name = "lbl_showname"
        Me.lbl_showname.Size = New System.Drawing.Size(53, 12)
        Me.lbl_showname.TabIndex = 50
        Me.lbl_showname.Text = "표시이름"
        '
        'txt_department
        '
        Me.txt_department.Location = New System.Drawing.Point(208, 44)
        Me.txt_department.Name = "txt_department"
        Me.txt_department.Size = New System.Drawing.Size(100, 21)
        Me.txt_department.TabIndex = 49
        '
        'lbl_department
        '
        Me.lbl_department.AutoSize = True
        Me.lbl_department.Location = New System.Drawing.Point(173, 47)
        Me.lbl_department.Name = "lbl_department"
        Me.lbl_department.Size = New System.Drawing.Size(29, 12)
        Me.lbl_department.TabIndex = 48
        Me.lbl_department.Text = "부서"
        '
        'lbl_company
        '
        Me.lbl_company.AutoSize = True
        Me.lbl_company.Location = New System.Drawing.Point(21, 47)
        Me.lbl_company.Name = "lbl_company"
        Me.lbl_company.Size = New System.Drawing.Size(29, 12)
        Me.lbl_company.TabIndex = 47
        Me.lbl_company.Text = "회사"
        '
        'txt_company
        '
        Me.txt_company.Location = New System.Drawing.Point(54, 44)
        Me.txt_company.Name = "txt_company"
        Me.txt_company.Size = New System.Drawing.Size(100, 21)
        Me.txt_company.TabIndex = 46
        '
        'txt_endpn
        '
        Me.txt_endpn.Location = New System.Drawing.Point(190, 118)
        Me.txt_endpn.Name = "txt_endpn"
        Me.txt_endpn.Size = New System.Drawing.Size(68, 21)
        Me.txt_endpn.TabIndex = 45
        '
        'txt_midlpn
        '
        Me.txt_midlpn.Location = New System.Drawing.Point(116, 118)
        Me.txt_midlpn.Name = "txt_midlpn"
        Me.txt_midlpn.Size = New System.Drawing.Size(68, 21)
        Me.txt_midlpn.TabIndex = 44
        '
        'txt_firstpn
        '
        Me.txt_firstpn.Location = New System.Drawing.Point(70, 118)
        Me.txt_firstpn.Name = "txt_firstpn"
        Me.txt_firstpn.Size = New System.Drawing.Size(40, 21)
        Me.txt_firstpn.TabIndex = 43
        '
        'lbl_phone
        '
        Me.lbl_phone.AutoSize = True
        Me.lbl_phone.Location = New System.Drawing.Point(21, 121)
        Me.lbl_phone.Name = "lbl_phone"
        Me.lbl_phone.Size = New System.Drawing.Size(41, 12)
        Me.lbl_phone.TabIndex = 42
        Me.lbl_phone.Text = "Phone"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(70, 81)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(238, 21)
        Me.txt_email.TabIndex = 41
        '
        'txt_firstname
        '
        Me.txt_firstname.Location = New System.Drawing.Point(208, 17)
        Me.txt_firstname.Name = "txt_firstname"
        Me.txt_firstname.Size = New System.Drawing.Size(100, 21)
        Me.txt_firstname.TabIndex = 40
        '
        'lbl_Email
        '
        Me.lbl_Email.AutoSize = True
        Me.lbl_Email.Location = New System.Drawing.Point(21, 84)
        Me.lbl_Email.Name = "lbl_Email"
        Me.lbl_Email.Size = New System.Drawing.Size(43, 12)
        Me.lbl_Email.TabIndex = 39
        Me.lbl_Email.Text = "E-mail"
        '
        'lbl_firstname
        '
        Me.lbl_firstname.AutoSize = True
        Me.lbl_firstname.Location = New System.Drawing.Point(173, 20)
        Me.lbl_firstname.Name = "lbl_firstname"
        Me.lbl_firstname.Size = New System.Drawing.Size(29, 12)
        Me.lbl_firstname.TabIndex = 38
        Me.lbl_firstname.Text = "이름"
        '
        'lbl_lastname
        '
        Me.lbl_lastname.AutoSize = True
        Me.lbl_lastname.Location = New System.Drawing.Point(21, 20)
        Me.lbl_lastname.Name = "lbl_lastname"
        Me.lbl_lastname.Size = New System.Drawing.Size(17, 12)
        Me.lbl_lastname.TabIndex = 37
        Me.lbl_lastname.Text = "성"
        '
        'txt_lastname
        '
        Me.txt_lastname.Location = New System.Drawing.Point(54, 17)
        Me.txt_lastname.Name = "txt_lastname"
        Me.txt_lastname.Size = New System.Drawing.Size(100, 21)
        Me.txt_lastname.TabIndex = 36
        '
        'Form_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 238)
        Me.Controls.Add(Me.btn_cnl)
        Me.Controls.Add(Me.btn_Modified)
        Me.Controls.Add(Me.txt_showname)
        Me.Controls.Add(Me.lbl_showname)
        Me.Controls.Add(Me.txt_department)
        Me.Controls.Add(Me.lbl_department)
        Me.Controls.Add(Me.lbl_company)
        Me.Controls.Add(Me.txt_company)
        Me.Controls.Add(Me.txt_endpn)
        Me.Controls.Add(Me.txt_midlpn)
        Me.Controls.Add(Me.txt_firstpn)
        Me.Controls.Add(Me.lbl_phone)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_firstname)
        Me.Controls.Add(Me.lbl_Email)
        Me.Controls.Add(Me.lbl_firstname)
        Me.Controls.Add(Me.lbl_lastname)
        Me.Controls.Add(Me.txt_lastname)
        Me.Name = "Form_edit"
        Me.Text = "Form_"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_cnl As System.Windows.Forms.Button
    Friend WithEvents btn_Modified As System.Windows.Forms.Button
    Friend WithEvents txt_showname As System.Windows.Forms.TextBox
    Friend WithEvents lbl_showname As System.Windows.Forms.Label
    Friend WithEvents txt_department As System.Windows.Forms.TextBox
    Friend WithEvents lbl_department As System.Windows.Forms.Label
    Friend WithEvents lbl_company As System.Windows.Forms.Label
    Friend WithEvents txt_company As System.Windows.Forms.TextBox
    Friend WithEvents txt_endpn As System.Windows.Forms.TextBox
    Friend WithEvents txt_midlpn As System.Windows.Forms.TextBox
    Friend WithEvents txt_firstpn As System.Windows.Forms.TextBox
    Friend WithEvents lbl_phone As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_firstname As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Email As System.Windows.Forms.Label
    Friend WithEvents lbl_firstname As System.Windows.Forms.Label
    Friend WithEvents lbl_lastname As System.Windows.Forms.Label
    Friend WithEvents txt_lastname As System.Windows.Forms.TextBox
End Class
