<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_webBrowser
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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.txt_mainurl = New System.Windows.Forms.TextBox()
        Me.btn_go = New System.Windows.Forms.Button()
        Me.btn_goback = New System.Windows.Forms.Button()
        Me.btn_gofoward = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.Cbtn_BookMark = New System.Windows.Forms.CheckBox()
        Me.BookMP = New System.Windows.Forms.Panel()
        Me.btn_Bookad = New System.Windows.Forms.Button()
        Me.btn_Bookcsl = New System.Windows.Forms.Button()
        Me.txt_url = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_bookmark = New System.Windows.Forms.Button()
        Me.BookMP.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 78)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(838, 497)
        Me.WebBrowser1.TabIndex = 0
        '
        'txt_mainurl
        '
        Me.txt_mainurl.Location = New System.Drawing.Point(12, 12)
        Me.txt_mainurl.Name = "txt_mainurl"
        Me.txt_mainurl.Size = New System.Drawing.Size(757, 21)
        Me.txt_mainurl.TabIndex = 1
        '
        'btn_go
        '
        Me.btn_go.Location = New System.Drawing.Point(775, 10)
        Me.btn_go.Name = "btn_go"
        Me.btn_go.Size = New System.Drawing.Size(75, 23)
        Me.btn_go.TabIndex = 2
        Me.btn_go.Text = "Go"
        Me.btn_go.UseVisualStyleBackColor = True
        '
        'btn_goback
        '
        Me.btn_goback.Location = New System.Drawing.Point(12, 36)
        Me.btn_goback.Name = "btn_goback"
        Me.btn_goback.Size = New System.Drawing.Size(75, 23)
        Me.btn_goback.TabIndex = 3
        Me.btn_goback.Text = "GoBack"
        Me.btn_goback.UseVisualStyleBackColor = True
        '
        'btn_gofoward
        '
        Me.btn_gofoward.Location = New System.Drawing.Point(93, 36)
        Me.btn_gofoward.Name = "btn_gofoward"
        Me.btn_gofoward.Size = New System.Drawing.Size(75, 23)
        Me.btn_gofoward.TabIndex = 4
        Me.btn_gofoward.Text = "GoFoward"
        Me.btn_gofoward.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(174, 36)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(75, 23)
        Me.btn_refresh.TabIndex = 5
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'Cbtn_BookMark
        '
        Me.Cbtn_BookMark.AutoSize = True
        Me.Cbtn_BookMark.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Cbtn_BookMark.Location = New System.Drawing.Point(748, 15)
        Me.Cbtn_BookMark.Name = "Cbtn_BookMark"
        Me.Cbtn_BookMark.Size = New System.Drawing.Size(15, 14)
        Me.Cbtn_BookMark.TabIndex = 6
        Me.Cbtn_BookMark.UseVisualStyleBackColor = False
        '
        'BookMP
        '
        Me.BookMP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BookMP.Controls.Add(Me.Label2)
        Me.BookMP.Controls.Add(Me.Label1)
        Me.BookMP.Controls.Add(Me.txt_name)
        Me.BookMP.Controls.Add(Me.txt_url)
        Me.BookMP.Controls.Add(Me.btn_Bookcsl)
        Me.BookMP.Controls.Add(Me.btn_Bookad)
        Me.BookMP.Location = New System.Drawing.Point(650, 57)
        Me.BookMP.Name = "BookMP"
        Me.BookMP.Size = New System.Drawing.Size(200, 102)
        Me.BookMP.TabIndex = 7
        Me.BookMP.Visible = False
        '
        'btn_Bookad
        '
        Me.btn_Bookad.Location = New System.Drawing.Point(18, 65)
        Me.btn_Bookad.Name = "btn_Bookad"
        Me.btn_Bookad.Size = New System.Drawing.Size(75, 23)
        Me.btn_Bookad.TabIndex = 0
        Me.btn_Bookad.Text = "Add"
        Me.btn_Bookad.UseVisualStyleBackColor = True
        '
        'btn_Bookcsl
        '
        Me.btn_Bookcsl.Location = New System.Drawing.Point(111, 65)
        Me.btn_Bookcsl.Name = "btn_Bookcsl"
        Me.btn_Bookcsl.Size = New System.Drawing.Size(75, 23)
        Me.btn_Bookcsl.TabIndex = 0
        Me.btn_Bookcsl.Text = "Cansle"
        Me.btn_Bookcsl.UseVisualStyleBackColor = True
        '
        'txt_url
        '
        Me.txt_url.Location = New System.Drawing.Point(40, 38)
        Me.txt_url.Name = "txt_url"
        Me.txt_url.Size = New System.Drawing.Size(147, 21)
        Me.txt_url.TabIndex = 1
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(40, 12)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(147, 21)
        Me.txt_name.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "URL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-1, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NAME"
        '
        'btn_bookmark
        '
        Me.btn_bookmark.Location = New System.Drawing.Point(694, 43)
        Me.btn_bookmark.Name = "btn_bookmark"
        Me.btn_bookmark.Size = New System.Drawing.Size(75, 23)
        Me.btn_bookmark.TabIndex = 8
        Me.btn_bookmark.Text = "BookMark"
        Me.btn_bookmark.UseVisualStyleBackColor = True
        '
        'Form_webBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 573)
        Me.Controls.Add(Me.btn_bookmark)
        Me.Controls.Add(Me.BookMP)
        Me.Controls.Add(Me.Cbtn_BookMark)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btn_gofoward)
        Me.Controls.Add(Me.btn_goback)
        Me.Controls.Add(Me.btn_go)
        Me.Controls.Add(Me.txt_mainurl)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Name = "Form_webBrowser"
        Me.Text = "WebBrowser"
        Me.BookMP.ResumeLayout(False)
        Me.BookMP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents txt_mainurl As System.Windows.Forms.TextBox
    Friend WithEvents btn_go As System.Windows.Forms.Button
    Friend WithEvents btn_goback As System.Windows.Forms.Button
    Friend WithEvents btn_gofoward As System.Windows.Forms.Button
    Friend WithEvents btn_refresh As System.Windows.Forms.Button
    Friend WithEvents Cbtn_BookMark As System.Windows.Forms.CheckBox
    Friend WithEvents BookMP As System.Windows.Forms.Panel
    Friend WithEvents btn_Bookcsl As System.Windows.Forms.Button
    Friend WithEvents btn_Bookad As System.Windows.Forms.Button
    Friend WithEvents txt_url As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_bookmark As System.Windows.Forms.Button
End Class
