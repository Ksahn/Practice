Public Class Form_BookMark

    Private Sub Form_BookMark_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_addG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addG.Click
        Pnl_grup.Visible = True
    End Sub

    Private Sub btn_Grupcsl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Grupcsl.Click
        Pnl_grup.Visible = False
    End Sub

    Private Sub btn_Grupadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Grupadd.Click
        If Not TextBox3.Text = "" Then
            TreeView1.SelectedNode.Nodes.Add(TextBox3.Text)
        End If
        Pnl_grup.Visible = False
    End Sub

   
End Class