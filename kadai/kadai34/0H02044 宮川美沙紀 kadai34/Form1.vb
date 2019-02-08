Public Class Form1
    Dim time, min, sec As Integer
    Dim flg As Integer = 0

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Label1.Text = "1:00"
        time = 60
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label1.Text = "3:00"
        time = 180
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Label1.Text = "5:00"
        time = 300
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "スタート" Then
            Button1.Text = "ストップ"
            GroupBox1.Enabled = False
            Timer1.Enabled = True

        ElseIf Button1.Text = "ストップ" Then
            Button1.Text = "リスタート"
            Button2.Enabled = True
            Timer1.Enabled = False

        ElseIf Button1.Text = "リスタート" Then
            Button1.Text = "ストップ"
            Button2.Enabled = False
            Timer1.Enabled = True
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time -= 1
        min = time \ 60
        sec = time Mod 60
        Label1.Text = min & ":" & Format(sec, "00")

        If time = 0 Then
            Timer1.Enabled = False
            Button1.Text = "スタート"
            Button1.Enabled = False
            Button2.Enabled = True
            Timer2.Enabled = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If flg = 0 Then
            Me.BackColor = Color.Black
            flg = 1
        Else
            Me.BackColor = SystemColors.Control
            flg = 0
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer2.Enabled = False
        GroupBox1.Enabled = True
        RadioButton2.Checked = True
        Label1.Text = "3:00"
        Me.BackColor = SystemColors.Control
        Button2.Enabled = False
        Button1.Text = "スタート"
        Button1.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

End Class
