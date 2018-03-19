Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addnumber()
    End Sub

    Private Sub addnumber()
        Dim num1 As Integer = 23123
        Dim num2 As Integer = 51241
        MessageBox.Show(num1 + num2)

    End Sub

End Class
