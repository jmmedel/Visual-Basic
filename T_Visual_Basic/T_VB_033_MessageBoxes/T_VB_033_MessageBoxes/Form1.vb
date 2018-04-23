Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MessageBox.Show("This is a bare messagebox")
        MessageBox.Show("This message is has a tiitle", "tiitle")
        MessageBox.Show("This has an icon,", "tiitle", MessageBoxButtons.OK)
        MsgBox("Heelo")
    End Sub
End Class
