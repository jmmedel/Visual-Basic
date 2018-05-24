Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = ""
        Dim number As Integer = CInt(TextBox1.Text)
        For x As Integer = 3 To number Step 3
            Label2.Text += x.ToString + " "

        Next


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Text = ""
        Dim number As Integer = CInt(TextBox1.Text)
        For x As Integer = 7 To number Step 7
            Label2.Text += x.ToString + " "

        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label2.Text = ""
        Dim number As Integer = CInt(TextBox1.Text)
        For x As Integer = 3 To number Step 3
            Label2.Text += x.ToString + " "

        Next

        For x As Integer = 7 To number Step 7
            Label2.Text += x.ToString + " "

        Next

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label2.Text = ""

        Dim number As Integer = CInt(TextBox1.Text)
        For x As Integer = 3 To number Step 3


            For y As Integer = 7 To number Step 7
                If x = y Then
                    Label2.Text += x.ToString + " "
                Else
                    Label2.Text += ""
                End If

            Next

        Next



    End Sub

End Class
