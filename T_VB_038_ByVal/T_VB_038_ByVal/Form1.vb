Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(substractnumber(TextBox1.Text, TextBox2.Text))
    End Sub

    Private Function substractnumber(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 - num2
    End Function

End Class
