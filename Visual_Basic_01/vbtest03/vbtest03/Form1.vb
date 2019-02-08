Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        Label3.Text = a + b
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a, b As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        Label3.Text = a - b
    End Sub
End Class
