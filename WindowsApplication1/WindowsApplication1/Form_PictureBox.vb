Imports Microsoft.Win32
Public Class Form_PictureBox
    Private _originalSize As Size = Nothing
    Private _scale As Single = 1
    Private _scaleDelta As Single = 0.0005
    Dim str As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        str = ""
        OpenFileDialog1.Title = "Open File..."
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.Filter = "All Files|*.*"
        OpenFileDialog1.ShowDialog()
        str = OpenFileDialog1.FileName
        PictureBox3.ImageLocation = str
        PictureBox4.ImageLocation = str
        'MsgBox(str)
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll

    End Sub

    Private Sub Form_PictureBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initial()
    End Sub
    Public Sub initial()

        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        'init this from here or a method depending on your needs
        PictureBox3.Size = Panel1.Size
        _originalSize = Panel1.Size
        PictureBox3.MinimumSize = Panel1.Size
        PictureBox4.Size = Panel2.Size
    End Sub
    Private Sub Form_PictureBox_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        _scaleDelta = Math.Sqrt(PictureBox3.Width * PictureBox3.Height) * 0.00005

        If e.Delta < 0 Then
            If _scale >= 1 Then
                _scale -= _scaleDelta
            End If
        ElseIf e.Delta > 0 Then
            _scale += _scaleDelta
        End If

        If e.Delta <> 0 Then _
        PictureBox3.Size = New Size(CInt(Math.Round(_originalSize.Width * _scale)), _
                                    CInt(Math.Round(_originalSize.Height * _scale)))

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PictureBox3.Image = Nothing
    End Sub
End Class