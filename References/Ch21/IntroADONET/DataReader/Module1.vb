Imports System.Data.SqlClient

Module Module1

    Sub Main()
        'Requires SQL Server Express and the Northwind database
        Using myConnection As New  _
              SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;" &
                            "Integrated Security=True;MultipleActiveResultSets=True")

            myConnection.Open()

            Using addCustomer As New SqlCommand("INSERT INTO CUSTOMERS(CompanyName, " &
                                                "CustomerID) VALUES (@COMPANYNAME, @CUSTOMERID)",
                                                myConnection)
                addCustomer.Parameters.AddWithValue("@COMPANYNAME", "Del Sole")
                addCustomer.Parameters.AddWithValue("@CUSTOMERID", "DELSO")
                addCustomer.ExecuteNonQuery()
            End Using

            Using updateCustomer As New SqlCommand("UPDATE CUSTOMERS SET " &
                                                   "COMPANYNAME=@NAME WHERE CUSTOMERID=@ID",
                                                   myConnection)
                updateCustomer.Parameters.AddWithValue("@NAME", "Alessandro Del Sole")
                updateCustomer.Parameters.AddWithValue("@ID", "DELSO")
                updateCustomer.ExecuteNonQuery()
            End Using

            Using deleteCustomer As New SqlCommand("DELETE FROM WHERE CUSTOMERID=@ID",
                                                   myConnection)
                deleteCustomer.Parameters.AddWithValue("@ID", "DELSO")
                deleteCustomer.ExecuteNonQuery()
            End Using

            Using queryCustomers As New SqlCommand("SELECT * FROM CUSTOMERS",
                                                   myConnection)

                Dim reader As SqlDataReader = queryCustomers.ExecuteReader()

                While reader.Read
                    Console.WriteLine("Customer: {0}", reader("CompanyName"))
                End While

            End Using
        End Using
        Console.ReadLine()
    End Sub

End Module