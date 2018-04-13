Imports LinqToDataSets.NorthwindDataSetTableAdapters

Module Module1
    Dim NwindDataSet As New NorthwindDataSet

    Dim NorthwindDataSetCustomersTableAdapter As CustomersTableAdapter _
        = New CustomersTableAdapter()
    Dim NorthwindDataSetOrdersTableAdapter As OrdersTableAdapter _
        = New OrdersTableAdapter()
    Dim NorthwindDataSetOrderDetailsTableAdapter As Order_DetailsTableAdapter _
        = New Order_DetailsTableAdapter


    Sub Main()
        NorthwindDataSetCustomersTableAdapter.Fill(NwindDataSet.Customers)
        NorthwindDataSetOrdersTableAdapter.Fill(NwindDataSet.Orders)
        NorthwindDataSetOrderDetailsTableAdapter.Fill(NwindDataSet.Order_Details)

        Console.WriteLine(QueryOrders("ALFKI"))
        Console.ReadLine()
    End Sub

    Private Function QueryOrders(ByVal CustomerID As String) As Integer

        Dim query = From ord In NwindDataSet.Orders
                    Where ord.CustomerID = CustomerID
                    Select ord

        Dim ordersByCustomer = Aggregate ord In NwindDataSet.Orders
                               Where ord.CustomerID = CustomerID
                               Into Count()

        For Each ord In query
            Console.WriteLine(ord.OrderID)
        Next

        Return ordersByCustomer
    End Function

    Private Sub QueryOrderDetails(ByVal CustomerID As String)

        Dim query = From ord In NwindDataSet.Orders
                    Where ord.CustomerID = CustomerID
                    Join det In NwindDataSet.Order_Details
                    On det.OrderID Equals ord.OrderID
                    Select New With {.OrderID = ord.OrderID,
                                      .OrderDate = ord.OrderDate,
                                      .ShippedDate = ord.ShippedDate,
                                      .ShipCity = ord.ShipCity,
                                      .ProductID = det.ProductID,
                                      .Quantity = det.Quantity,
                                      .UnitPrice = det.UnitPrice}

    End Sub

    Private Sub CopyToDataTableDemo()

        Dim query = (From ord In NwindDataSet.Orders
                     Where String.IsNullOrEmpty(ord.ShipCountry) = False
                     Select ord).CopyToDataTable

        query.TableName = "FilteredOrders"
        NwindDataSet.Tables.Add(query)


        Dim customTable As New DataTable("Custom orders")
        With customTable
            With .Columns
                .Add("OrderID", GetType(Integer))
                .Add("Quantity", GetType(Short))
                .Add("UnitPrice", GetType(Decimal))
            End With
        End With

        Dim query2 = From ord In NwindDataSet.Orders, det In NwindDataSet.Order_Details
                     Where det.Quantity > 50
                     Select New With {.OrderID = ord.OrderID,
                                    .Quantity = det.Quantity,
                                    .UnitPrice = det.UnitPrice}

        For Each item In query2

            customTable.Rows.Add(New Object() {item.OrderID,
                                                item.Quantity,
                                                item.UnitPrice})
        Next
    End Sub


    Private Function CreateCustomTable() As DataTable

        'Create a new table
        Dim customTable As New DataTable("Custom orders")

        'Add columns
        With customTable
            With .Columns
                .Add("OrderID", GetType(Integer))
                .Add("Quantity", GetType(Short))
                .Add("UnitPrice", GetType(Decimal))
            End With
        End With

        'Retrieve data from different sources
        Dim query2 = From ord In NwindDataSet.Orders,
                          det In NwindDataSet.Order_Details
                     Where det.Quantity > 50
                     Select New With {.OrderID = ord.OrderID,
                                      .Quantity = det.Quantity,
                                      .UnitPrice = det.UnitPrice}

        'Add rows
        For Each item In query2
            customTable.Rows.Add(New Object() {item.OrderID,
                                                item.Quantity,
                                                item.UnitPrice})
        Next

        Return customTable
    End Function

    Private Sub FieldDemo()

        Try
            Dim query = From ord In NwindDataSet.Orders
                        Where ord.Field(Of Date)("ShippedDate") < Date.Today
                        Select New With {
                                   .OrderID = ord.
                                              Field(Of Integer)("OrderID"),
                                   .OrderDate = ord.
                                              Field(Of Date)("OrderDate"),
                                   .ShipCountry = ord.
                                              Field(Of String)("ShipCountry")
                                    }
        Catch ex As InvalidCastException
            'Conversion failed

        Catch ex As NullReferenceException
            'Attempt to access to a non nullable
            'null object

        Catch ex As IndexOutOfRangeException
            'Wrong index

        Catch ex As Exception

        End Try
    End Sub

End Module
