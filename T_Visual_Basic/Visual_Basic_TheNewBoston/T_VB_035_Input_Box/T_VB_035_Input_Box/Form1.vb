Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim username As String = Nothing
        username = InputBox("What is your name? ", "heelo",,,)
        Label1.Text = "Heelo " & username
    End Sub

End Class
