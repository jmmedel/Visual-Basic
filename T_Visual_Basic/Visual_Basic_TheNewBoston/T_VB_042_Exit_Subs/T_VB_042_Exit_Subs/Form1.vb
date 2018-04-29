Public Class Form1

    Private Sub btmExit_Click(sender As Object, e As EventArgs) Handles btmExit.Click
        Dim num As Integer = 10
        Count(num)
    End Sub

    Private Sub Count(ByVal num As Integer)

        While True
            num += 1
            ListNumber.Items.Add(num)
            If (num > 54) Then
                Exit Sub
            End If
        End While
    End Sub

End Class
