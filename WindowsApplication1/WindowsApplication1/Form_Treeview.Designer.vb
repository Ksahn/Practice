﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.btn_addG = New System.Windows.Forms.Button()
        Me.btn_delG = New System.Windows.Forms.Button()
        Me.Pnl_grup = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_addG = New System.Windows.Forms.TextBox()
        Me.btn_Grupcsl = New System.Windows.Forms.Button()
        Me.btn_Grupadd = New System.Windows.Forms.Button()
        Me.Pnl_grup.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(12, 12)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(354, 354)
        Me.TreeView1.TabIndex = 8
        '
        'btn_addG
        '
        Me.btn_addG.Location = New System.Drawing.Point(12, 382)
        Me.btn_addG.Name = "btn_addG"
        Me.btn_addG.Size = New System.Drawing.Size(75, 23)
        Me.btn_addG.TabIndex = 9
        Me.btn_addG.Text = "add_grup"
        Me.btn_addG.UseVisualStyleBackColor = True
        '
        'btn_delG
        '
        Me.btn_delG.Location = New System.Drawing.Point(94, 382)
        Me.btn_delG.Name = "btn_delG"
        Me.btn_delG.Size = New System.Drawing.Size(75, 23)
        Me.btn_delG.TabIndex = 10
        Me.btn_delG.Text = "Del_grup"
        Me.btn_delG.UseVisualStyleBackColor = True
        '
        'Pnl_grup
        '
        Me.Pnl_grup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_grup.Controls.Add(Me.Label2)
        Me.Pnl_grup.Controls.Add(Me.txt_addG)
        Me.Pnl_grup.Controls.Add(Me.btn_Grupcsl)
        Me.Pnl_grup.Controls.Add(Me.btn_Grupadd)
        Me.Pnl_grup.Location = New System.Drawing.Point(12, 291)
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
        'Form_Treeview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 427)
        Me.Controls.Add(Me.Pnl_grup)
        Me.Controls.Add(Me.btn_delG)
        Me.Controls.Add(Me.btn_addG)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "Form_Treeview"
        Me.Text = "BookMark"
        Me.Pnl_grup.ResumeLayout(False)
        Me.Pnl_grup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents btn_addG As System.Windows.Forms.Button
    Friend WithEvents btn_delG As System.Windows.Forms.Button
    Friend WithEvents Pnl_grup As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_addG As System.Windows.Forms.TextBox
    Friend WithEvents btn_Grupcsl As System.Windows.Forms.Button
    Friend WithEvents btn_Grupadd As System.Windows.Forms.Button
End Class