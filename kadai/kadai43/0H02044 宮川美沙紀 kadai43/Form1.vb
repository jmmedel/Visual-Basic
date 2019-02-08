Public Class Form1
    Dim flg1, flg2, flg3, flg4, flg5 As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If flg1 = 0 Then
            flg1 = 1
        Else
            flg1 = 0
        End If
        Dim Gr As Graphics = PictureBox1.CreateGraphics
        Gr.FillEllipse(Brushes.Tomato, 150, 50, 180, 180)

        If flg1 = 1 And flg2 = 1 And flg3 = 1 And flg4 = 1 And flg5 = 1 Then
            Me.Button7.Visible = True
        Else
            Me.Button7.Hide()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If flg2 = 0 Then
            flg2 = 1
        Else
            flg2 = 0
        End If
        Dim Gr As Graphics = PictureBox1.CreateGraphics
        Gr.FillEllipse(Brushes.RoyalBlue, 30, 230, 180, 180)

        If flg1 = 1 And flg2 = 1 And flg3 = 1 And flg4 = 1 And flg5 = 1 Then
            Me.Button7.Visible = True
        Else
            Me.Button7.Hide()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If flg3 = 0 Then
            flg3 = 1
        Else
            flg3 = 0
        End If
        Dim Gr As Graphics = PictureBox1.CreateGraphics
        Gr.FillEllipse(Brushes.Gold, 270, 230, 180, 180)

        If flg1 = 1 And flg2 = 1 And flg3 = 1 And flg4 = 1 And flg5 = 1 Then
            Me.Button7.Visible = True
        Else
            Me.Button7.Hide()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If flg4 = 0 Then
            flg4 = 1
        Else
            flg4 = 0
        End If
        Dim Gr As Graphics = PictureBox1.CreateGraphics
        Gr.FillEllipse(Brushes.White, 167, 85, 75, 75)
        Gr.FillEllipse(Brushes.White, 239, 85, 75, 75)

        Gr.FillEllipse(Brushes.White, 43, 275, 80, 80)
        Gr.FillEllipse(Brushes.White, 117, 275, 80, 80)

        Gr.FillEllipse(Brushes.White, 283, 275, 80, 80)
        Gr.FillEllipse(Brushes.White, 357, 275, 80, 80)

        If flg1 = 1 And flg2 = 1 And flg3 = 1 And flg4 = 1 And flg5 = 1 Then
            Me.Button7.Visible = True
        Else
            Me.Button7.Hide()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If flg5 = 0 Then
            flg5 = 1
        Else
            flg5 = 0
        End If
        Dim Gr As Graphics = PictureBox1.CreateGraphics
        Gr.FillEllipse(Brushes.Orange, 205, 132, 70, 73)
        Gr.FillEllipse(Brushes.Black, 190, 100, 38, 38)
        Gr.FillEllipse(Brushes.Black, 253, 100, 38, 38)

        Gr.FillEllipse(Brushes.Black, 70, 303, 40, 40)
        Gr.FillEllipse(Brushes.Black, 128, 290, 40, 40)

        Gr.FillEllipse(Brushes.Pink, 283, 275, 80, 80)
        Gr.FillEllipse(Brushes.Pink, 357, 275, 80, 80)
        Gr.FillPie(Brushes.SkyBlue, 282, 282, 100, 100, 178, 125)
        Gr.FillPie(Brushes.SkyBlue, 338, 282, 100, 100, 215, 150)
        Gr.FillPie(Brushes.White, 283, 275, 80, 80, 330, 180)
        Gr.FillPie(Brushes.White, 357, 275, 80, 80, 30, 180)
        Gr.FillPie(Brushes.White, 289, 290, 90, 90, 175, 165)
        Gr.FillPie(Brushes.White, 341, 290, 90, 90, 215, 150)
        Gr.FillEllipse(Brushes.Black, 310, 303, 38, 38)
        Gr.FillEllipse(Brushes.Black, 372, 303, 38, 38)

        If flg1 = 1 And flg2 = 1 And flg3 = 1 And flg4 = 1 And flg5 = 1 Then
            Me.Button7.Visible = True
        Else
            Me.Button7.Hide()
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PictureBox1.Refresh()
        flg1 = 0
        flg2 = 0
        flg3 = 0
        flg4 = 0
        flg5 = 0
        Me.Button7.Hide()
    End Sub
End Class
