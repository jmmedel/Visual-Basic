Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (red_radio_btn.Checked) Then
            If (english_radiobtn.Checked) Then
                TextBox1.Text = "RED"
            ElseIf (france_radio_btn.Checked) Then
                TextBox1.Text = "ROUGE"
            ElseIf (spain_radio_btn.Checked) Then
                TextBox1.Text = "ROJO"
            End If
        ElseIf (white_radio_btn.Checked) Then
            If (english_radiobtn.Checked) Then
                TextBox1.Text = "White"
            ElseIf (france_radio_btn.Checked) Then
                TextBox1.Text = "BLANC"
            ElseIf (spain_radio_btn.Checked) Then
                TextBox1.Text = "BLANCO"
            End If
        ElseIf (green_radio_btn.Checked) Then
            If (english_radiobtn.Checked) Then
                TextBox1.Text = "GREEN"
            ElseIf (france_radio_btn.Checked) Then
                TextBox1.Text = "VERT"
            ElseIf (spain_radio_btn.Checked) Then
                TextBox1.Text = "VERDE"
            End If

        End If

    End Sub

End Class
