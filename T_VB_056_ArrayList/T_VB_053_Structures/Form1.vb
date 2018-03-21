Public Class Form1

    Private Structure Customer
        Private ReadOnly _Name As String
        Public Firstname As String
        Public lastname As String
        Public Email As String
        Public ReadOnly Property Name() As String
            Get
                Return Firstname & " " & lastname
            End Get
        End Property

    End Structure

    Private objcustomer As Customer
    Private objnewcustomer As Customer




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        objcustomer.Firstname = "Jim"
        objcustomer.lastname = "Jones"
        objcustomer.Email = "jm_sasuke25@yahoo.com"
        objnewcustomer.Firstname = "Kagaya"
        objcustomer.lastname = "medel"
        objcustomer.Email = "jm.kagaya@gmail.com"
        DisplayCustomer(objnewcustomer)
        DisplayCustomer(objcustomer)

    End Sub

    Private Sub DisplayCustomer(ByVal cust As Customer)
        txtFirstname.Text = cust.Firstname
        txtLastName.Text = cust.lastname
        txtEmail.Text = cust.Email
        txtName.Text = cust.Name
    End Sub

End Class
