Public Class Form_webBrowser

    Private Sub btn_go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_go.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                WebBrowser1.Navigate(TextBox1.Text)
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
End Class