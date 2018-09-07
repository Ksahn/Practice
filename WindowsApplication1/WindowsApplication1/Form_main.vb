Imports System.Diagnostics
Imports Microsoft.VisualBasic.Devices
Public Class Form_main
    Private Sub Initial()
        PerformanceCounter1.CategoryName = "Processor"
        PerformanceCounter1.CounterName = "% Processor Time"
        PerformanceCounter1.InstanceName = "_Total"
    End Sub
    Private Sub btn_WB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_WB.Click
        Form_webBrowser.ShowDialog()
    End Sub

    Private Sub Form_main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Initial()
        Timer1.Start()
    End Sub
    Private Sub mem()
        Dim ram As ULong = My.Computer.Info.TotalPhysicalMemory
        Dim ram2 As ULong = My.Computer.Info.AvailablePhysicalMemory
        Dim active As String = ((ram - ram2) / 1024).ToString
        Dim cpuvl As String
        cpuvl = Math.Truncate(PerformanceCounter1.NextValue())
        RichTextBox1.Text = "CPU : " & cpuvl & "%" & " MEMORY : " & active & "KB" & vbCrLf & RichTextBox1.Text
        CPUPB.Value = cpuvl
        If cpuvl > 50 Then

        End If
        MPB.Value = Math.Truncate(CDbl(CDbl(active * 1024) / ram) * 100)
        If RichTextBox1.Text.Length > 10000 Then
            RichTextBox1.Text = ""
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        mem()

    End Sub

    Private Sub btn_treeview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_treeview.Click
        Form_Treeview.ShowDialog()
    End Sub
End Class
