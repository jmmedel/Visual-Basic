Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim g As Graphics = PictureBox1.CreateGraphics()
        Dim Bpen As Pen = New Pen(Color.Blue, 4)
        g.DrawLine(Bpen, 4, 4, 300, 300)



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim g As Graphics = PictureBox1.CreateGraphics()
        Dim Rpen As Pen = New Pen(Color.Red, 4)
        g.DrawLine(Rpen, 180, 180, 600, 600)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim g As Graphics = PictureBox1.CreateGraphics()
        Dim Ypen As Pen = New Pen(Color.Yellow, 4)
        g.DrawLine(Ypen, 16, 16, 500, 500)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim g As Graphics = PictureBox1.CreateGraphics()
        Dim Gpen As Pen = New Pen(Color.Green, 4)
        g.DrawLine(Gpen, 100, 150, 5, 500)
    End Sub
End Class
