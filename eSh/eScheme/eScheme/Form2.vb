Imports System.ComponentModel

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            Form1.f.format = "A4"
        Else
            Form1.f.format = "A3"
        End If
        If RadioButton4.Checked Then
            Form1.f.format &= "1"
        Else
            Form1.f.format &= "2"
        End If
        Me.Close()

    End Sub

    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Enabled = True
        Form1.CreateFormat()
    End Sub
End Class