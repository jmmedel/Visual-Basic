Public Class Form1
    Dim Str, s1, s2, s3, s4, Ctr As String
    Dim cnt, i, a As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        s1 = ""
        s2 = ""
        Str = TextBox1.Text
        cnt = Str.Length

        For i = 0 To cnt - 1
            a = i Mod 2
            Select Case a
                Case 0
                    s1 = Str.Chars(i) & s1
                Case 1
                    s2 = Str.Chars(i) & s2
            End Select
        Next

        TextBox2.Text = s2 & s1
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Ctr = ""
        s3 = ""
        s4 = ""
        Str = TextBox2.Text
        cnt = Str.Length

        If cnt Mod 2 = 0 Then
            For i = 0 To cnt \ 2 - 1
                s3 = Str.Chars(i) & s3
            Next
            For i = cnt \ 2 To cnt - 1
                s4 = Str.Chars(i) & s4
            Next
            For i = 0 To cnt \ 2 - 1
                Ctr = Ctr & s4.Chars(i) & s3.Chars(i)
            Next
        Else
            For i = 0 To cnt \ 2 - 1
                s3 = Str.Chars(i) & s3
            Next
            For i = cnt \ 2 To cnt - 1
                s4 = Str.Chars(i) & s4
            Next

            For i = 0 To cnt \ 2 - 1
                Ctr = Ctr & s4.Chars(i) & s3.Chars(i)
            Next
            Ctr &= s4.Chars(cnt \ 2)
        End If

        TextBox3.Text = Ctr

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Focus()
    End Sub

End Class
