Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Click something", "Tiitle", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Abort Then
            MessageBox.Show("Aborted")
        End If



    End Sub

End Class
