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


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_select.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        str = ""
        OpenFileDialog1.Title = "Open File..."
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.Filter = "All Files|*.*"
        OpenFileDialog1.ShowDialog()
        str = OpenFileDialog1.FileName
        PictureBox3.ImageLocation = str



    End Sub
    Private Sub DrawRect(ByVal loc_x As Double, ByVal loc_y As Double, ByVal width_x As Double, ByVal height_y As Double)

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

        PictureBox3.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        'init this from here or a method depending on your needs
        'PictureBox3.Size = Panel1.Size
        '_originalSize = Panel1.Size
        'PictureBox3.MinimumSize = Panel1.Size
        TrackBar_R.Maximum = 255
        TrackBar_R.Minimum = -255
        TrackBar_G.Maximum = 255
        TrackBar_G.Minimum = -255
        TrackBar_B.Maximum = 255
        TrackBar_B.Minimum = -255

    End Sub
    'Private Sub Form_PictureBox_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel

    '    _scaleDelta = Math.Sqrt(PictureBox3.Width * PictureBox3.Height) * 0.00005

    '    If e.Delta < 0 Then
    '        If _scale >= 1 Then
    '            _scale -= _scaleDelta

    '        End If
    '    ElseIf e.Delta > 0 Then
    '        _scale += _scaleDelta

    '    End If
    '    Debug.Print(_scale)
    '    If e.Delta <> 0 Then
    '        PictureBox3.Size = New Size(CInt(Math.Round(_originalSize.Width * _scale)), _
    '                                    CInt(Math.Round(_originalSize.Height * _scale)))
    '        DrawRect(0, 0, PictureBox4.Size.Width * (PictureBox3.Size.Width / PictureBox3.Image.Width) * (1 / _scale), PictureBox4.Size.Height * (PictureBox3.Size.Height / PictureBox3.Image.Height) * (1 / _scale))
    '    End If

    'End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_claer.Click
        PictureBox3.Image = Nothing
        PictureBox4.Image = Nothing
    End Sub


    Private Sub PictureBox3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseDown

        PictureBox3.ImageLocation = str
        'Debug.Print(e.Location().ToString)
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
        PictureBox3.Invalidate()

        ch = False
        M_up.X = e.X
        M_up.Y = e.Y

        'PictureBox3.CreateGraphics

        Dim g As Graphics = Graphics.FromImage(PictureBox3.Image)

        Dim tempBitmap As Bitmap = New Bitmap(PictureBox3.ClientSize.Width, PictureBox3.ClientSize.Height)
        PictureBox3.DrawToBitmap(tempBitmap, PictureBox3.ClientRectangle)
        Dim size As Size
        Dim Save_image As Image
        size.Height = Math.Abs(e.Y - M_down.Y)
        size.Width = Math.Abs(e.X - M_down.X)

        Try
            Dim target As New Bitmap(Math.Abs(e.X - M_down.X), Math.Abs(e.Y - M_down.Y))
        
        ''선택된 공간 빨간 네모 채움
        'If e.X - M_down.X >= 0 And e.Y - M_down.Y >= 0 Then
        '    g.FillRectangle(Brushes.Crimson, M_down.X, M_down.Y, e.X - M_down.X, e.Y - M_down.Y)
        'ElseIf e.X - M_down.X <= 0 And e.Y - M_down.Y <= 0 Then
        '    g.FillRectangle(Brushes.Crimson, M_down.X + (e.X - M_down.X), M_down.Y + (e.Y - M_down.Y), -(e.X - M_down.X), -(e.Y - M_down.Y))
        'ElseIf e.X - M_down.X <= 0 Then
        '    g.FillRectangle(Brushes.Crimson, M_down.X + (e.X - M_down.X), M_down.Y, -(e.X - M_down.X), e.Y - M_down.Y)
        'ElseIf e.Y - M_down.Y <= 0 Then
        '    g.FillRectangle(Brushes.Crimson, M_down.X, M_down.Y + (e.Y - M_down.Y), e.X - M_down.X, -(e.Y - M_down.Y))
        'End If

        '선택한 이미지 변환

        If e.X - M_down.X >= 0 And e.Y - M_down.Y >= 0 Then

            Using g2 As Graphics = Graphics.FromImage(target)
                Dim selecrect As New Rectangle(M_down, size)
                    g2.DrawImage(tempBitmap, target.GetBounds(1), selecrect, GraphicsUnit.Pixel)
                    Save_image = Cls_RGBFilter.RGBFiltering(target, TrackBar_R.Value, TrackBar_G.Value, TrackBar_B.Value)
                End Using
                g.DrawImage(Save_image, M_down)
        ElseIf e.X - M_down.X <= 0 And e.Y - M_down.Y <= 0 Then

            Using g2 As Graphics = Graphics.FromImage(target)
                Dim selecrect As New Rectangle(M_down.X + (e.X - M_down.X), M_down.Y + (e.Y - M_down.Y), -(e.X - M_down.X), -(e.Y - M_down.Y))
                g2.DrawImage(tempBitmap, target.GetBounds(0), selecrect, GraphicsUnit.Pixel)
                    Save_image = Cls_RGBFilter.RGBFiltering(target, TrackBar_R.Value, TrackBar_G.Value, TrackBar_B.Value)

            End Using
                g.DrawImage(Save_image, M_down.X + (e.X - M_down.X), M_down.Y + (e.Y - M_down.Y))
        ElseIf e.X - M_down.X <= 0 Then

            Using g2 As Graphics = Graphics.FromImage(target)
                Dim selecrect As New Rectangle(M_down.X + (e.X - M_down.X), M_down.Y, -(e.X - M_down.X), e.Y - M_down.Y)
                g2.DrawImage(tempBitmap, target.GetBounds(0), selecrect, GraphicsUnit.Pixel)
                    Save_image = Cls_RGBFilter.RGBFiltering(target, TrackBar_R.Value, TrackBar_G.Value, TrackBar_B.Value)
                End Using
                g.DrawImage(Save_image, M_down.X + (e.X - M_down.X), M_down.Y)
        ElseIf e.Y - M_down.Y <= 0 Then

            Using g2 As Graphics = Graphics.FromImage(target)
                Dim selecrect As New Rectangle(M_down.X, M_down.Y + (e.Y - M_down.Y), e.X - M_down.X, -(e.Y - M_down.Y))
                g2.DrawImage(tempBitmap, target.GetBounds(0), selecrect, GraphicsUnit.Pixel)
                    Save_image = Cls_RGBFilter.RGBFiltering(target, TrackBar_R.Value, TrackBar_G.Value, TrackBar_B.Value)
                End Using
                g.DrawImage(Save_image, M_down.X, M_down.Y + (e.Y - M_down.Y))
            End If
            PictureBox4.Image = PictureBox3.Image.Clone
            move_nevi()
            tempBitmap.Dispose()

        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
    End Sub

    Private Sub PictureBox3_LoadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles PictureBox3.LoadCompleted
        PictureBox4.Image = PictureBox3.Image.Clone
        'DrawRect(0, 0, PictureBox4.Size.Width * ((Panel1.Width - 20) / PictureBox3.Image.Width), PictureBox4.Size.Height * ((Panel1.Height - 20) / PictureBox3.Image.Height))
        move_nevi()
    End Sub

    Private Sub Panel1_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles Panel1.Scroll
        Debug.Print(Panel1.HorizontalScroll.Maximum)
        'Dim x As Double
        'x = (PictureBox4.Size.Width - (PictureBox4.Size.Width * ((Panel1.Width - 20) / PictureBox3.Image.Width))) / (Panel1.HorizontalScroll.Maximum - Panel1.Size.Width)
        'Dim y As Double
        'y = (PictureBox4.Size.Height - (PictureBox4.Size.Height * ((Panel1.Height - 20) / PictureBox3.Image.Height))) / (Panel1.VerticalScroll.Maximum - Panel1.Size.Height)
        'PictureBox4.Refresh()
        'DrawRect(Panel1.HorizontalScroll.Value * x, Panel1.VerticalScroll.Value * y, PictureBox4.Size.Width * ((Panel1.Width - 20) / PictureBox3.Image.Width), PictureBox4.Size.Height * ((Panel1.Height - 20) / PictureBox3.Image.Height))
        move_nevi()
    End Sub
    Public Sub move_nevi()
        Dim x As Double
        x = (PictureBox4.Size.Width - (PictureBox4.Size.Width * ((Panel1.Width - 20) / PictureBox3.Image.Width))) / (Panel1.HorizontalScroll.Maximum - Panel1.Size.Width)
        Dim y As Double
        y = (PictureBox4.Size.Height - (PictureBox4.Size.Height * ((Panel1.Height - 20) / PictureBox3.Image.Height))) / (Panel1.VerticalScroll.Maximum - Panel1.Size.Height)
        PictureBox4.Refresh()
        DrawRect(Panel1.HorizontalScroll.Value * x, Panel1.VerticalScroll.Value * y, PictureBox4.Size.Width * ((Panel1.Width - 20) / PictureBox3.Image.Width), PictureBox4.Size.Height * ((Panel1.Height - 20) / PictureBox3.Image.Height))
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If Not PictureBox3.Image Is Nothing Then
            PictureBox3.Image.Save(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location) & "\default.jpg")
        End If
    End Sub
End Class