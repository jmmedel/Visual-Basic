Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim year As Integer = TextBox1.Text
        year = year / 100
        Label2.Text = year & "世紀"
    End Sub
End Class
