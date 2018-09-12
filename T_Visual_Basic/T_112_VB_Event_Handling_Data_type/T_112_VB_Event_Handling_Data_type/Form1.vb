Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtID_KeyUP(sender As Object, e As KeyEventArgs) Handles txtID.KeyUp

        If (Not Char.IsNumber(ChrW(e.KeyCode))) Then
            MessageBox.Show("Enter numbers for your Customer ID")
            txtID.Text = " "
        End If
    End Sub

    Private Sub txtAge_KeyUP(sender As Object, e As KeyEventArgs) _
   Handles TxtAge.KeyUp

        If (Not Char.IsNumber(ChrW(e.KeyCode))) Then
            MessageBox.Show("Enter numbers for age")
            TxtAge.Text = " "
        End If
    End Sub

End Class

