Public Class Form1

    Private Sub 赤ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 赤ToolStripMenuItem.Click
        PictureBox1.BackColor = Color.Red
    End Sub

    Private Sub 緑ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 緑ToolStripMenuItem.Click
        PictureBox1.BackColor = Color.Green
    End Sub

    Private Sub 黒ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 黒ToolStripMenuItem.Click
        PictureBox1.BackColor = Color.Black
    End Sub

    Private Sub 紫ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 紫ToolStripMenuItem.Click
        PictureBox1.BackColor = Color.Purple
    End Sub

    Private Sub 終了ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 終了ToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.BackColor = Color.Transparent
    End Sub
End Class
