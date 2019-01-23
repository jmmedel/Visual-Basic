Public Class Form1

    Dim a As ArrayList = New ArrayList
    Dim AllItem As Integer = 0
    Dim count As Integer = 0
    Dim center As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number As Integer = Convert.ToInt32(TextBox1.Text)
        a.Add(number)
        AllItem = a.Count()
        TextBox1.Text = ""
        count = AllItem.ToString
        Label2.Text = "データ数は" & count
        center = a.Item(AllItem / 2)
        Label3.Text = "中央値は" & center
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a.Clear()
        Label2.Text = "データ数は"
        center = 0
        Label3.Text = "中央値は"

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

End Class
