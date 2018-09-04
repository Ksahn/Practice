Public Class Form_Treeview
    Private NodeDataFile As String = IO.Path.Combine(Application.StartupPath, "NodeData.dat")
    Private Sub btn_addG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addG.Click
        Pnl_grup.Visible = True
    End Sub

    Private Sub btn_Grupcsl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Grupcsl.Click
        Pnl_grup.Visible = False
    End Sub

    Private Sub btn_Grupadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Grupadd.Click

        addtxt()
    End Sub
    Private Sub btn_delG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delG.Click
        Dim Activenode As TreeNode
        Try
            Activenode = TreeView1.SelectedNode
            TreeView1.SelectedNode.Nodes.Remove(Activenode)
        Catch
        End Try
    End Sub

    Private Sub txt_addG_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_addG.KeyDown
        If e.KeyCode = Keys.Enter Then
            addtxt()
        End If
    End Sub
    Private Sub addtxt()
        If Not txt_addG.Text = "" Then
            If TreeView1.Nodes.Count = 0 Then
                TreeView1.Nodes.Add(txt_addG.Text)
            Else
                TreeView1.SelectedNode.Nodes.Add(txt_addG.Text)
            End If
        End If
        Pnl_grup.Visible = False
    End Sub
#Region "save load node"
    Private Sub Form_Treeview_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SaveNodes(NodeDataFile)
    End Sub

    Private Sub Form_Treeview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initial()
        LoadNodes(NodeDataFile)
    End Sub

    Private Sub SaveNodes(ByVal filePath As String)

        Dim tmp As New List(Of TNode)

        For Each n As TreeNode In TreeView1.Nodes

            Dim tninfo As New TNode

            tninfo.tn = n

            tmp.Add(tninfo)

        Next

        Using fs As IO.FileStream = IO.File.Open(filePath, IO.FileMode.Create)

            Dim bf As New Runtime.Serialization.Formatters.Binary.BinaryFormatter

            bf.Serialize(fs, tmp)

        End Using

    End Sub

    Private Sub LoadNodes(ByVal filePath As String)
        TreeView1.Nodes.Clear()
        Dim tmp As New List(Of TNode)
        Try

            Using fs As IO.FileStream = IO.File.Open(filePath, IO.FileMode.Open)

                Dim bf As New Runtime.Serialization.Formatters.Binary.BinaryFormatter

                tmp = CType(bf.Deserialize(fs), List(Of TNode))

            End Using

            For Each n As TNode In tmp

                TreeView1.Nodes.Add(n.tn)

            Next
        Catch
        End Try
    End Sub

#End Region
    Public Sub initial()
        Dim MyImages As New ImageList()
        MyImages.ImageSize = New Size(16, 16)
        MyImages.Images.Add(Image.FromFile _
                (Application.StartupPath & "\folder_close.png"))
        MyImages.Images.Add(Image.FromFile _
                (Application.StartupPath & "\folder_open.png"))
        TreeView1.ImageList = MyImages
        TreeView1.ImageIndex = 0
    End Sub

    Private Sub TreeView1_AfterCollapse(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterCollapse
        TreeView1.BeginUpdate()
        TreeView1.SelectedImageIndex = 0
        TreeView1.EndUpdate()
    End Sub

    Private Sub TreeView1_AfterExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterExpand
        TreeView1.BeginUpdate()
        e.Node.ImageIndex = 1
        TreeView1.EndUpdate()
    End Sub
End Class


<Serializable()> _
Public Class TNode

    Public tn As TreeNode

End Class
