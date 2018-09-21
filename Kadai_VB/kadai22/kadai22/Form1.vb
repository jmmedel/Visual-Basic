Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            If (RadioButton1.Checked) Then
                Dim year As Integer = CInt(TextBox1.Text)
                Dim boyage1 As Integer = 2

                TextBox2.Text = year + boyage1 & "満" & boyage1 & "歳（男女とも）"
            ElseIf (RadioButton2.Checked) Then
                Dim year As Integer = CInt(TextBox1.Text)
                Dim girlage2 As Integer = 6

                TextBox2.Text = year + girlage2 & "満" & girlage2 & "歳（女子とも）"


            End If


        Catch ex As Exception

        End Try



    End Sub

End Class
