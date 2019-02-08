Public Class Form1

    Dim total As Integer = 0
    Dim lunch As Integer = 900
    Dim cake As Integer = 400
    Dim cofee As Integer = 500
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        total = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If (CheckBox1.Checked) Then
            total += lunch
        ElseIf (CheckBox2.Checked) Then
            total += cake
        ElseIf (CheckBox3.Checked) Then
            total += cofee
        End If

        Label2.Text = total


    End Sub
End Class
