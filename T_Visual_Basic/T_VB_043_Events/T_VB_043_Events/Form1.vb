Public Class Form1

    Private Sub btmEvent_Click(sender As Object, e As EventArgs) Handles btmEvent.Click
        MessageBox.Show(sender.ToString())
        MessageBox.Show(e.ToString())
    End Sub

    Private Sub btmEvent_MouseHover(sender As Object, e As EventArgs) Handles btmEvent.MouseHover
        btmEvent.Text = "Text Changed"
        MessageBox.Show(e.ToString())
    End Sub

End Class
