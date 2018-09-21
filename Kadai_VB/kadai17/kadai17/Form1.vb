Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim num1 As Integer = TextBox1.Text
        Dim num2 As Integer = TextBox2.Text
        Dim total As Integer = num1 * num2
        Label3.Text = "掛け算の結果はーー＞" & total
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
