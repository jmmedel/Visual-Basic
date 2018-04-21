Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If chkDiet.Checked AndAlso chkExercise.Checked Then
            lblMessage.Text = "Discount: 10%"
        ElseIf chkDiet.Checked Then
            lblMessage.Text = "Discount: 5%"
        ElseIf chkExercise.Checked Then
            lblMessage.Text = "Discount: 6%"
        Else
            lblMessage.Text = "No Discount"
        End If
    End Sub
End Class
