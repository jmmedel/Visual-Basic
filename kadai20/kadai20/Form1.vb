Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer = 0
        Dim b As Integer = 1
        Dim fib As Integer = 0

        Do
            fib = a + b
            a = b
            b = fib
            TextBox2.Text = TextBox2.Text + fib.ToString & ControlChars.NewLine
        Loop While fib < TextBox1.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = ""
    End Sub


End Class
