Imports System.IO
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim stream As StreamReader = File.OpenText(OpenFileDialog1.FileName)
            While stream.Peek() <> -1
                Label1.Text += vbCr + stream.ReadLine()

            End While
            stream.Close()
        End If
    End Sub
End Class
