Public Class Form_edit

    Private Sub Form_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initial()
        setting()
    End Sub
    Public Sub initial()
        Me.ControlBox = False
    End Sub
    Public Sub setting()
        txt_firstname.Text = Mid(Split(Form_Treeview.TreeView1.SelectedNode.Text)(0), 2, 3)
        txt_lastname.Text = Mid(Split(Form_Treeview.TreeView1.SelectedNode.Text)(0), 1, 1)
        txt_company.Text = Form_Treeview.TreeView1.SelectedNode.Parent.Parent.Text
        txt_department.Text = Form_Treeview.TreeView1.SelectedNode.Parent.Text
        txt_showname.Text = Form_Treeview.TreeView1.SelectedNode.Text
    End Sub

    Private Sub btn_cnl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cnl.Click
        Me.Close()
    End Sub
End Class