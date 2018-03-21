Public Class Form1

    '79 '
    Private myCustumer As New ArrayList


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

        Public Overrides Function ToString() As String
            Return Name & "(" & Email & ")"
        End Function

    End Structure

    Private objcustomer As Customer
    Private objnewcustomer As Customer
    Private Sub AddCustomer(ByVal firstname As String, ByVal lastname As String, ByVal email As String)
        Dim objnewCustomer As Customer

        objnewCustomer.Firstname = firstname
        objnewCustomer.lastname = lastname
        objnewCustomer.Email = email

        myCustumer.Add(objnewCustomer)
        ListBox1.Items.Add(objnewCustomer.ToString())
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        objcustomer.Firstname = "Jim"
        objcustomer.lastname = "Jones"
        objcustomer.Email = "jm_sasuke25@yahoo.com"
        objnewcustomer.Firstname = "Kagaya"
        objcustomer.lastname = "medel"
        objcustomer.Email = "jm.kagaya@gmail.com"

        DisplayCustomer(objnewcustomer)
        DisplayCustomer(objcustomer)
        AddCustomer("Sam", "Heelo", "Sam.hqweqwhei.com")
        AddCustomer("_DEqw", "Heelo", "Sam.hqweqwhei.com")
        AddCustomer("JAW", "Heelo", "Sam.hqweqwhei.com")
    End Sub

    Private Sub DisplayCustomer(ByVal cust As Customer)
        txtFirstname.Text = cust.Firstname
        txtLastName.Text = cust.lastname
        txtEmail.Text = cust.Email
        txtName.Text = cust.Name
    End Sub

End Class
