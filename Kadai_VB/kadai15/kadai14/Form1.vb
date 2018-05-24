Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = ""
        Dim number As Integer = CInt(TextBox1.Text)
        For x As Integer = 1 To number
            If x Mod 3 <> 0 Then
                Label2.Text += x.ToString + " "
            End If

        Next


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Text = ""
        Dim number As Integer = CInt(TextBox1.Text)
        For x As Integer = 1 To number
            If x Mod 7 <> 0 Then
                Label2.Text += x.ToString + " "
            End If

        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label2.Text = ""
        Dim number As Integer = CInt(TextBox1.Text)
        For x As Integer = 1 To number

            If x Mod 3 <> 0 Then
                Label2.Text += x.ToString + " "
            End If



        Next
        Label2.Text += "     "
        For x As Integer = 1 To number
            If x Mod 7 <> 0 Then
                Label2.Text += x.ToString + " "
            End If
        Next

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label2.Text = ""

        Dim number As Integer = CInt(TextBox1.Text)
        For x As Integer = 1 To number

            If x Mod 3 <> 0 And x Mod 7 <> 0 Then
                Label2.Text += x.ToString + " "
            End If
        Next



    End Sub

End Class
