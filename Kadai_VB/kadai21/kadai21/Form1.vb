Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ListBox1.Items.Add(ListBox2.SelectedItem)
        ListBox2.Items.Remove(ListBox2.SelectedItem)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox2.Items.Add(ListBox1.SelectedItem)
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("情報処理")
        ListBox1.Items.Add("基本情報")
        ListBox1.Items.Add("応用情報")
        ListBox1.Items.Add("Ｊ試験")
        ListBox1.Items.Add("ＶＢ")
        ListBox1.Items.Add("システム設計")

    End Sub
End Class
