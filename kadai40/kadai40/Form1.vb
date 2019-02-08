Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim string1 As String = TextBox1.Text
        Dim num1 As Integer = string1.Length

        Dim string2 As String = TextBox2.Text
        Dim num2 As Integer = string2.Length

        Dim combinewords As String = string1 + string2
        Label3.Text = combinewords

        Dim total As String = num1 + num2
        Label4.Text += total + "です"
    End Sub
End Class
