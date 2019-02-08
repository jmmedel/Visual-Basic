Public Class Form1
    Dim x, y As Integer
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        PictureBox1.Image = My.Resources.Image_a1b108c
        x = PictureBox1.Image.Width * TrackBar1.Value / 100
        y = PictureBox1.Image.Height * TrackBar1.Value / 100
        PictureBox1.Size = New Size(x, y)
    End Sub
End Class
