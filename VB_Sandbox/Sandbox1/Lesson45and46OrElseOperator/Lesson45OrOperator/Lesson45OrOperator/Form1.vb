Public Class Form1
    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        Dim text = txtInput.Text.ToLower()
        Dim count As Integer
        'This is the moment that counts.
        For Each c In text
            If c = "a" OrElse c = "e" OrElse c = "i" OrElse c = "o" OrElse c = "u" Then
                count += 1
            End If
        Next
        lblCount.Text = $"Count: {count}"
    End Sub
End Class
