Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim boysAge As Integer = 2
        Dim girlsAge As Integer = 4
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim year As Integer
        If TextBox1.Text = String.Empty Then
            MessageBox.Show("Please enter the data to save", "Data Entry Error")
            TextBox1.Focus()
        Else
            'Save your data here
            year = TextBox1.Text
        End If


        TextBox2.Text = year
    End Sub
End Class
