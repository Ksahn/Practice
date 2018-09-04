Imports System.IO
Public Class Form_webBrowser

    'Delegate Sub url(ByVal x As String)
    'Public Loc_Desktop As String = Application.StartupPath
    'Private Sub url_name(ByVal x As String)
    '    IO.File.AppendAllText(Loc_Desktop & "\Cookie", x & vbCrLf)
    'End Sub
    Private Sub btn_go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_go.Click
        WebBrowser1.Navigate(txt_mainurl.Text)

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_mainurl.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                WebBrowser1.Navigate(txt_mainurl.Text)
            Case Keys.F5
                WebBrowser1.Refresh()
        End Select
    End Sub

    Private Sub btn_goback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_goback.Click
        If WebBrowser1.CanGoBack = True Then
            WebBrowser1.GoBack()
        End If
    End Sub

    Private Sub btn_gofoward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gofoward.Click
        If WebBrowser1.CanGoForward = True Then
            WebBrowser1.GoForward()
        End If
    End Sub

    Private Sub btn_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_refresh.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub WebBrowser1_Navigated(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated

        txt_mainurl.Text = WebBrowser1.Url.ToString
        Me.Text = WebBrowser1.DocumentTitle

        If Form_BookMark.TreeView1.Nodes.Then Then
            Cbtn_BookMark.Checked = True
        Else
            Cbtn_BookMark.Checked = False
        End If



    End Sub

    Private Sub BookmarkCbtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbtn_BookMark.CheckedChanged
        If Cbtn_BookMark.Checked = True Then
            BookMP.Visible = True
            If txt_mainurl.Text = "" Then
            Else
                txt_url.Text = WebBrowser1.Url.ToString
                txt_name.Text = WebBrowser1.DocumentTitle
            End If
        End If
        If Cbtn_BookMark.Checked = False Then
            BookMP.Visible = False
        End If

    End Sub

    Private Sub btn_Bookcsl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Bookcsl.Click
        Cbtn_BookMark.Checked = False
        BookMP.Visible = False
    End Sub

    Private Sub btn_Bookad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Bookad.Click
        Form_BookMark.TreeView1.Nodes.Add(txt_name.Text)

        BookMP.Visible = False
    End Sub

    Private Sub btn_bookmark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bookmark.Click
        Form_BookMark.Show()
    End Sub
End Class