Imports System.IO
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim stream As StreamReader = File.OpenText(OpenFileDialog1.FileName)
            Dim c As Integer = stream.Peek()
            While c <> -1
                Label1.Text += vbCr + stream.ReadLine()
                c = stream.Peek()
            End While
            stream.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim stream As StreamReader = File.OpenText(OpenFileDialog1.FileName)
            Dim c = stream.Peek()
            Do Until c = -1
                Label1.Text += vbCr + stream.ReadLine()
                c = stream.Peek()
            Loop
            stream.Close()
        End If
    End Sub
End Class
