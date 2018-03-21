Public Class Form1

    Private Structure Customer

        Public Firstname As String
        Public lastname As String
        Public Email As String


    End Structure

    Private objcustomer As Customer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        objcustomer.Firstname = "Jim"
        objcustomer.lastname = "Jones"
        objcustomer.Email = "jm_sasuke25@yahoo.com"
        DisplayCustomer(objcustomer)
    End Sub

    Private Sub DisplayCustomer(ByVal cust As Customer)
        txtFirstname.Text = cust.Firstname
        txtLastName.Text = cust.lastname
        txtEmail.Text = cust.Email
    End Sub

End Class
