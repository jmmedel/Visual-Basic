Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b As Integer
        a = TextBox1.Text * 100
        b = TextBox2.Text * 110

        Label3.Text = "合計は" & a + b & "円です"

    End Sub


End Class
