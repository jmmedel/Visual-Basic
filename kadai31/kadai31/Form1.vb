Public Class Form1

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Dim x = PictureBox1.Image.Width * TrackBar1.Value / 10
        Dim y = PictureBox1.Image.Height * TrackBar1.Value / 10

        PictureBox1.Size = New Size(x, y)
    End Sub


End Class
