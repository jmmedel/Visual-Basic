Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gr As Graphics = PictureBox1.CreateGraphics()
        Dim bp As Pen = New Pen(Color.Blue, 6)
        gr.DrawLine(bp, 0, 0, 360, 360)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim gr As Graphics = PictureBox1.CreateGraphics()
        Dim rp As Pen = New Pen(Color.Red, 6)
        gr.DrawLine(rp, 180, 0, 180, 360)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim gr As Graphics = PictureBox1.CreateGraphics()
        Dim yp As Pen = New Pen(Color.Yellow, 6)
        gr.DrawLine(yp, 0, 180, 360, 180)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim gr As Graphics = PictureBox1.CreateGraphics()
        Dim gp As Pen = New Pen(Color.Green, 6)
        gr.DrawLine(gp, 360, 0, 0, 360)
    End Sub
End Class
