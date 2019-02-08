Public Class Form1
    Dim time As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Left = 590
        PictureBox1.Top = 10
        PictureBox2.Left = 270
        PictureBox2.Top = 220
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "開 始" Then
            Timer1.Enabled = True
            Timer3.Enabled = True
            Button2.Text = "停 止"
            Button1.Enabled = True
            Label1.Text = "0"
            time = 30.0
            Label2.Text = Format(time, "00.0")
        ElseIf Button2.Text = "停 止" Then
            Timer1.Enabled = False
            Timer3.Enabled = False
            Button2.Text = "再 開"
        ElseIf Button2.Text = "再 開" Then
            Timer1.Enabled = True
            Timer3.Enabled = True
            Button2.Text = "停 止"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox2.Visible = True
        Timer2.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Left = PictureBox1.Left - 2
        If PictureBox1.Left < -40 Then
            PictureBox1.Left = 590
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox2.Top = PictureBox2.Top - 2
        If PictureBox2.Top < -20 Then
            PictureBox2.Top = 220
            Timer2.Enabled = False
        End If

        If 270 <= PictureBox1.Left And PictureBox1.Left <= 302 Then
            If 10 <= PictureBox2.Top And PictureBox2.Top <= 42 Then
                PictureBox1.Enabled = False
                PictureBox2.Enabled = False
                PictureBox1.Left = 590
                PictureBox1.Enabled = True
                Label1.Text += 1
            End If
        End If
        Timer1.Interval = Int(Rnd() * 20 + 1)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        time -= 0.1
        Label2.Text = Format(time, "00.0")
        If time < 0 Then
            Timer1.Enabled = False
            Timer1.Interval = 20
            Timer2.Enabled = False
            Timer3.Enabled = False
            Button1.Enabled = False
            Button2.Text = "開 始"
            PictureBox1.Left = 590
            PictureBox2.Top = 220
        End If

    End Sub
End Class
