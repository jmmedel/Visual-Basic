Public Class Form1
    Private Sub 終了ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 終了ToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub なわとび犬ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles なわとび犬ToolStripMenuItem.Click
        PictureBox1.Image = My.Resources.dog01
    End Sub

    Private Sub 拍手犬ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 拍手犬ToolStripMenuItem.Click
        PictureBox1.Image = My.Resources.dog02
    End Sub

    Private Sub マラカス犬ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles マラカス犬ToolStripMenuItem.Click
        PictureBox1.Image = My.Resources.dog08
    End Sub

    Private Sub 太鼓犬ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 太鼓犬ToolStripMenuItem.Click
        PictureBox1.Image = My.Resources.inu03
    End Sub

    Private Sub ジャンプ犬ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ジャンプ犬ToolStripMenuItem.Click
        PictureBox1.Image = My.Resources.inu04
    End Sub
End Class
