Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim num1 As Integer = 0
        MessageBox.Show(num1.ToString())
        Label1.Text = num1.ToString()
        increamentVariable(num1)
        MessageBox.Show(num1.ToString())
        Label1.Text = num1.ToString()
    End Sub

    Private Sub increamentVariable(ByRef x As Integer)
        x += 5

    End Sub


End Class
