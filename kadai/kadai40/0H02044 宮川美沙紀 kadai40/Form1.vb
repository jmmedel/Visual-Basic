Public Class Form1
    Dim L, R, Str, cnt As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        L = TextBox1.Text
        R = TextBox2.Text
        Str = L & R
        Label3.Text = Str
        cnt = Str.Length
        Label4.Text = "結合された文字列の長さは" + cnt + "です。"
    End Sub
End Class
