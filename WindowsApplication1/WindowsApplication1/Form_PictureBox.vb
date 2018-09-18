Imports Microsoft.Win32
Public Class Form_PictureBox
    Private _originalSize As Size = Nothing
    Private _scale As Single = 1
    Private _scaleDelta As Single = 0.0005
    Dim str As String
    Dim ch As Boolean
    Dim i As Integer = 0
    Dim M_down As New Point
    Dim M_up As New Point


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


    End Sub
    Private Sub DrawRect(ByVal loc_x As Integer, ByVal loc_y As Integer, ByVal width_x As Integer, ByVal height_y As Integer)

        Dim g As Graphics = PictureBox4.CreateGraphics()
        Dim GreenPen As New Pen(Brushes.Green, 2)
        Dim rect As New Rectangle(loc_x, loc_y, width_x, height_y)
        PictureBox4.Refresh()
        g.DrawRectangle(GreenPen, rect)
        g.Dispose()

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
        Debug.Print(_scale)
        If e.Delta <> 0 Then
            PictureBox3.Size = New Size(CInt(Math.Round(_originalSize.Width * _scale)), _
                                        CInt(Math.Round(_originalSize.Height * _scale)))
            DrawRect(0, 0, PictureBox4.Size.Width * (1 / _scale), PictureBox4.Size.Height * (1 / _scale))
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PictureBox3.Image = Nothing
        PictureBox4.Image = Nothing
    End Sub

    Private Sub PictureBox3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseDown
        Debug.Print(e.Location().ToString)
        M_down.X = e.X
        M_down.Y = e.Y
        ch = True
    End Sub

    Private Sub PictureBox3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseMove
        If ch = True Then
            PictureBox3.Refresh()
            Dim g As Graphics = PictureBox3.CreateGraphics
            Dim fnt As New Font("Arial", 16)
            'M_down.X, M_down.Y + (e.Y - M_down.Y) + 3
            If e.X - M_down.X >= 0 And e.Y - M_down.Y >= 0 Then
                g.DrawRectangle(Pens.Crimson, M_down.X, M_down.Y, e.X - M_down.X, e.Y - M_down.Y)
                g.DrawString("X:" & e.X - M_down.X & " Y:" & e.Y - M_down.Y, fnt, Brushes.Black, M_down)
            ElseIf e.X - M_down.X <= 0 And e.Y - M_down.Y < 0 Then
                g.DrawRectangle(Pens.Crimson, M_down.X + (e.X - M_down.X), M_down.Y + (e.Y - M_down.Y), -(e.X - M_down.X), -(e.Y - M_down.Y))
                g.DrawString("X:" & -(e.X - M_down.X) & " Y:" & -(e.Y - M_down.Y), fnt, Brushes.Black, M_down.X + (e.X - M_down.X), M_down.Y + (e.Y - M_down.Y))
            ElseIf e.X - M_down.X <= 0 Then
                g.DrawRectangle(Pens.Crimson, M_down.X + (e.X - M_down.X), M_down.Y, -(e.X - M_down.X), e.Y - M_down.Y)
                g.DrawString("X:" & -(e.X - M_down.X) & " Y:" & e.Y - M_down.Y, fnt, Brushes.Black, M_down.X + (e.X - M_down.X), M_down.Y)
            ElseIf e.Y - M_down.Y <= 0 Then
                g.DrawRectangle(Pens.Crimson, M_down.X, M_down.Y + (e.Y - M_down.Y), e.X - M_down.X, -(e.Y - M_down.Y))
                g.DrawString("X:" & e.X - M_down.X & " Y:" & -(e.Y - M_down.Y), fnt, Brushes.Black, M_down.X, M_down.Y + (e.Y - M_down.Y))
            End If
            Debug.Print(e.X - M_down.X)
            Debug.Print(e.Y - M_down.Y)
        End If
    End Sub

    Private Sub PictureBox3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseUp
        ch = False
        M_up.X = e.X
        M_up.Y = e.Y
        PictureBox3.Refresh()
        Dim g As Graphics = PictureBox3.CreateGraphics
        If e.X - M_down.X >= 0 And e.Y - M_down.Y >= 0 Then
            g.FillRectangle(Brushes.Crimson, M_down.X, M_down.Y, e.X - M_down.X, e.Y - M_down.Y)
        ElseIf e.X - M_down.X <= 0 And e.Y - M_down.Y <= 0 Then
            g.FillRectangle(Brushes.Crimson, M_down.X + (e.X - M_down.X), M_down.Y + (e.Y - M_down.Y), -(e.X - M_down.X), -(e.Y - M_down.Y))
        ElseIf e.X - M_down.X <= 0 Then
            g.FillRectangle(Brushes.Crimson, M_down.X + (e.X - M_down.X), M_down.Y, -(e.X - M_down.X), e.Y - M_down.Y)
        ElseIf e.Y - M_down.Y <= 0 Then
            g.FillRectangle(Brushes.Crimson, M_down.X, M_down.Y + (e.Y - M_down.Y), e.X - M_down.X, -(e.Y - M_down.Y))

        End If


    End Sub
End Class