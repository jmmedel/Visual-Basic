Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim msg As String = textmesg.Text
        Dim tittle As String = Nothing
        If txttiitle.TextLength > 0 Then
            tittle = txttiitle.Text
            showmessage(msg, tittle)
        End If

    End Sub

    Private Sub showmessage(ByVal msg As String, Optional ByVal tiitle As String = "Efault title ")
        MessageBox.Show(msg, tiitle)

    End Sub

End Class
