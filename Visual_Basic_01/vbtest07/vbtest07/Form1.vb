Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number As Integer

        If (TextBox1.Text = 1) Then
            Label3.Text = "One"
        ElseIf (TextBox1.Text = 2) Then
            Label3.Text = "Two"
        ElseIf (TextBox1.Text = 3) Then
            Label3.Text = "Three"
        ElseIf (TextBox1.Text = 4) Then
            Label3.Text = "Four"
        ElseIf (TextBox1.Text = 5) Then
            Label3.Text = "Five"
        ElseIf (TextBox1.Text = 6) Then
            Label3.Text = "Six"
        ElseIf (TextBox1.Text = 7) Then
            Label3.Text = "Seven"
        ElseIf (TextBox1.Text = 8) Then
            Label3.Text = "Eight"
        ElseIf (TextBox1.Text = 9) Then
            Label3.Text = "Nine"
        End If

    End Sub
End Class
