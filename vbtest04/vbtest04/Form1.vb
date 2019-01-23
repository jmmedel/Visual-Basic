Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If (CheckBox1.Checked) Then

        ElseIf (CheckBox2.Checked) Then

        ElseIf (CheckBox3.Checked) Then

        End If



    End Sub
End Class
