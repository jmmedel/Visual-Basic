Public Class Form1

    Dim a As ArrayList = New ArrayList
    Dim AllItem As Integer = a.Count()


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number As Integer = Convert.ToInt32(TextBox1.Text)
        a.Add(number)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a.Clear()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim count As String = AllItem.ToString
        Label2.Text += count
    End Sub

End Class
