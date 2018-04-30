Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NF As New Font("Impact", 36, FontStyle.Italic)
        Dim NB As New SolidBrush(Color.FromArgb(64, 192, 255, 255))
        NB.Color = Color.FromArgb(128, 0, 0, 0)
        PictureBox1.CreateGraphics.DrawString(TextBox1.Text, NF, NB, 15, 135)
    End Sub
End Class
