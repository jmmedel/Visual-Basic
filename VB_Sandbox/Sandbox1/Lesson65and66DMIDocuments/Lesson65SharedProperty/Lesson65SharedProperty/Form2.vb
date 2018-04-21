Public Class Form2
    Private Sub Form2_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        FormBorderStyle = FormBorderStyle.Fixed3D
    End Sub

    Private Sub Form2_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        FormBorderStyle = FormBorderStyle.Sizable
    End Sub
End Class