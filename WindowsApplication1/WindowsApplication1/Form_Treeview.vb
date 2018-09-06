Public Class Form_Treeview
    Private NodeDataFile As String = IO.Path.Combine(Application.StartupPath, "NodeData.dat")
    Dim number As Integer

    Private Sub Form_Treeview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initial()
        LoadNodes(NodeDataFile)
    End Sub

    Public Sub initial()
        Dim MyImages As New ImageList()

        ContextMenuStrip1.Name = "ContextMenuStrip1.name"
        ContextMenuStrip1.Items.Clear()

        ContextMenuStrip0.Name = "ContextMenuStrip0"
        ContextMenuStrip0.Items.Clear()
        ContextMenuStrip0.Items.Add("New")
        TreeView1.ContextMenuStrip = ContextMenuStrip0

        MyImages.ImageSize = New Size(16, 16)
        MyImages.Images.Add(Image.FromFile _
                (Application.StartupPath & "\folder_close.png"))
        MyImages.Images.Add(Image.FromFile _
                (Application.StartupPath & "\folder_open.png"))
        MyImages.Images.Add(Image.FromFile _
                (Application.StartupPath & "\avatar.png"))
        TreeView1.ImageList = MyImages
    End Sub
#Region "save load node"
    Private Sub Form_Treeview_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SaveNodes(NodeDataFile)
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
            For i As Integer = 0 To TreeView1.Nodes.Count - 1
                TreeView1.Nodes(i).ContextMenuStrip = ContextMenuStrip1
                For j As Integer = 0 To TreeView1.Nodes(i).Nodes.Count - 1
                    TreeView1.Nodes(i).Nodes(j).ContextMenuStrip = ContextMenuStrip1
                    For k As Integer = 0 To TreeView1.Nodes(i).Nodes(j).Nodes.Count - 1
                        TreeView1.Nodes(i).Nodes(j).Nodes(k).ContextMenuStrip = ContextMenuStrip1
                        TreeView1.Nodes(i).Nodes(j).Nodes(k).ImageIndex = 2
                        TreeView1.Nodes(i).Nodes(j).Nodes(k).SelectedImageIndex = 2
                    Next
                Next
            Next
            
        Catch
        End Try
    End Sub

#End Region
#Region "Node events"
    
    Private Sub Add_item(ByVal Int_type As Integer)
        Select Case Int_type
            Case 0
                ContextMenuStrip1.Items.Add("Rename")
                ContextMenuStrip1.Items.Add("Delete")
                ContextMenuStrip1.Items.Add("-")
                ContextMenuStrip1.Items.Add("New")
            Case 1
                ContextMenuStrip1.Items.Add("Rename")
                ContextMenuStrip1.Items.Add("Delete")
                ContextMenuStrip1.Items.Add("-")
                ContextMenuStrip1.Items.Add("New")
            Case 2
                ContextMenuStrip1.Items.Add("Edit")
                ContextMenuStrip1.Items.Add("Copy")
                ContextMenuStrip1.Items.Add("Delete")
        End Select
    End Sub

    Private Sub TreeView1_AfterCollapse(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterCollapse
        e.Node.ImageIndex = 0
        e.Node.SelectedImageIndex = 0

        'For i As Integer = 0 To TreeView1.Nodes.Count - 1
        '    For j As Integer = 0 To TreeView1.Nodes(i).Nodes.Count - 1
        '        For k As Integer = 0 To TreeView1.Nodes(i).Nodes(j).Nodes.Count - 1
        '            TreeView1.Nodes(i).Nodes(j).Nodes(k).ImageIndex = 2
        '            TreeView1.Nodes(i).Nodes(j).Nodes(k).SelectedImageIndex = 2
        '        Next
        '    Next
        'Next
    End Sub

    Private Sub TreeView1_AfterExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterExpand
        e.Node.ImageIndex = 1
        e.Node.SelectedImageIndex = 1
    End Sub
    'Sub treeView1_NodeMouseClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
    '    If e.Node.IsExpanded = True Then
    '        e.Node.ImageIndex = 1
    '    Else
    '        e.Node.ImageIndex = 0
    '    End If
    'End Sub 'treeView1_NodeMouseClick

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    TreeView1.Nodes.Clear()

    '    'parent node 추가
    '    For i As Integer = 0 To 2
    '        TreeView1.Nodes.Add("M" & i + 1)
    '        TreeView1.Nodes(i).ContextMenuStrip = ContextMenuStrip1
    '        'Debug.Print(TreeView1.Nodes(i).Level.ToString)
    '    Next

    '    For i As Integer = 0 To 3
    '        TreeView1.Nodes(0).Nodes.Add("P" & i)
    '        TreeView1.Nodes(0).Nodes(i).ContextMenuStrip = ContextMenuStrip1
    '        TreeView1.Nodes(0).Nodes(0).Nodes.Add("P" & i)
    '        TreeView1.Nodes(0).Nodes(0).Nodes(i).ContextMenuStrip = ContextMenuStrip1
    '        'Debug.Print(TreeView1.Nodes(0).Nodes(0).Nodes(i).Level.ToString)
    '        'Debug.Print(TreeView1.Nodes(0).Nodes(i).Level.ToString)

    '    Next
    'End Sub
    Private Sub TreeView1_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        ContextMenuStrip1.Items.Clear()
        TreeView1.SelectedNode = e.Node
        Add_item(e.Node.Level)
    End Sub

    Private Sub ContextMenuStrip0_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ContextMenuStrip0.ItemClicked
        Pnl_grup.Location = Me.PointToClient(MousePosition)
        txt_addG.Text = ""
        Pnl_grup.Visible = True
        number = 0
    End Sub
    'Private Sub Form_Treeview_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
    '    Debug.Print(Me.PointToClient(MousePosition).ToString)
    'End Sub

    '    Private Sub TreeView1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeView1.MouseDown
    '        Debug.Print(sender.ToString)
    '    End Sub
    Private Sub ContextMenuStrip1_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
        Select Case e.ClickedItem.ToString
            Case "New"
                Pnl_grup.Location = Me.PointToClient(MousePosition)
                txt_addG.Text = ""
                Pnl_grup.Visible = True
                number = 1
            Case "Delete"
                Dim Activenode As TreeNode
                Activenode = TreeView1.SelectedNode
                TreeView1.SelectedNode.Nodes.Remove(Activenode)
        End Select
        
    End Sub

    Private Sub btn_Grupcsl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Grupcsl.Click, btn_Grupadd.Click
        Dim key() As String = Split(sender.ToString, " ", -1)
        If key(key.Count - 1) = "Add" Then
            addtxt(number)
        ElseIf key(key.Count - 1) = "Cansle" Then
            Pnl_grup.Visible = False
        End If

    End Sub

    'Private Sub btn_Grupadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 
    '    Debug.Print(e.ToString)
    '    Debug.Print(Split(sender.ToString, " ", -1)(Split(sender.ToString, " ", -1).Count - 1))
    '    '
    'End Sub

    Private Sub txt_addG_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_addG.KeyDown
        If e.KeyCode = Keys.Enter Then
            addtxt(number)
        End If
    End Sub
    Private Sub addtxt(ByVal num As Integer)
        Dim Nodes_Count As Integer

        If Not txt_addG.Text = "" Then
            If number = 0 Then

                TreeView1.Nodes.Add(txt_addG.Text)
                Nodes_Count = TreeView1.Nodes.Count
                TreeView1.Nodes(Nodes_Count - 1).ContextMenuStrip = ContextMenuStrip1

            Else
                TreeView1.SelectedNode.Nodes.Add(txt_addG.Text)
                Nodes_Count = TreeView1.SelectedNode.Nodes.Count
                TreeView1.SelectedNode.Nodes(Nodes_Count - 1).ContextMenuStrip = ContextMenuStrip1
                TreeView1.SelectedNode.Nodes(Nodes_Count - 1).ImageIndex = 2
                TreeView1.SelectedNode.Nodes(Nodes_Count - 1).SelectedImageIndex = 2
            End If
            number = Nothing
        End If
        Pnl_grup.Visible = False
    End Sub
#End Region
End Class



<Serializable()> _
Public Class TNode

    Public tn As TreeNode

End Class
