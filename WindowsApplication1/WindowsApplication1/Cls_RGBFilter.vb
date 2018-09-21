Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices
Public Class Cls_RGBFilter
    Public Shared Function RGBFiltering(ByVal Bitmap_Image As Bitmap, _
                                        ByVal RedChange As Double, _
                                        ByVal GreenChange As Double, _
                                        ByVal BlueChange As Double) As Bitmap

        Dim BMD As BitmapData = Bitmap_Image.LockBits(New Rectangle(0, 0, Bitmap_Image.Width, Bitmap_Image.Height), _
                                                      ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb)
        Dim scan0 As IntPtr = BMD.Scan0
        Dim pixels(Bitmap_Image.Width * Bitmap_Image.Height - 1) As Integer
        Marshal.Copy(scan0, pixels, 0, pixels.Length)
        Dim Red, Green, Blue As Integer

        For i As Integer = 0 To pixels.Length - 1

            Red = (pixels(i) >> 16) And &HFF
            Green = (pixels(i) >> 8) And &HFF
            Blue = pixels(i) And &HFF

            Red += RedChange
            Green += GreenChange
            Blue += BlueChange

            Red = Math.Min(Math.Max(Red, 0), 255)
            Green = Math.Min(Math.Max(Green, 0), 255)
            Blue = Math.Min(Math.Max(Blue, 0), 255)

            pixels(i) = (255 << 24) Or (Red << 16) Or (Green << 8) Or Blue
        Next
        Marshal.Copy(pixels, 0, scan0, pixels.Length)
        Bitmap_Image.UnlockBits(BMD)
        Return Bitmap_Image

    End Function
End Class
