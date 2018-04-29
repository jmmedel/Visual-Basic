Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim answer As Double = solveMath()
        MessageBox.Show(solveMath())
    End Sub

    Private Function solveMath() As Double
        Dim num1 As Integer = 23
        Dim num2 As Integer = 5
        Return num1 / num2
    End Function

End Class
