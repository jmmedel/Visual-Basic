Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox2.Items.Add(ListBox1.Items(a))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("情報処理")
        ListBox1.Items.Add("情報処理")
        ListBox1.Items.Add("情報処理")
        ListBox1.Items.Add("情報処理")
        ListBox1.Items.Add("情報処理")
        ListBox1.Items.Add("情報処理")

    End Sub
End Class
