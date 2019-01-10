Public Class Form1
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        PictureBox1.BackColor = Color.Red
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        PictureBox1.BackColor = Color.Green
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        PictureBox1.BackColor = Color.Black
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        PictureBox1.BackColor = Color.Purple
    End Sub

    Private Sub 終了ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 終了ToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.BackColor = Color.White
    End Sub
End Class
