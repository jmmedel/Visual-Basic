Imports System.ComponentModel

Module Querying

    Friend northwind As New NorthwindDataContext

    Sub Main()

        DirectSqlDemo()

        'northwind.Log = Console.Out

        AddProduct(northwind.Categories.
                           Single(Function(cat) cat.CategoryName = "Grains/Cereals"))

        Try
            UpdateProduct(northwind.Products.
                          Single(Function(prod) prod.
                          ProductName = "Italian spaghetti"))

            'The specified product does not exists
        Catch ex As InvalidOperationException

        End Try

        Try
            DeleteProduct(northwind.Products.
                          Single(Function(prod) prod.
                          ProductName = "Italian spaghetti"))

            'The specified product does not exists
        Catch ex As InvalidOperationException

        End Try

        'StoredProcDemo()

        Console.ReadLine()

    End Sub

    Sub ComplexQueriesDemo()
        Dim productsList = QueryByCategoryName("Seafood")

        For Each prod In productsList
            Debug.WriteLine("Product name: {0}, unit price: {1}",
                              prod.ProductName,
                              prod.UnitPrice)
        Next

        Dim customQuery = From prod In northwind.Products
                          Join cat In northwind.Categories On
                          prod.CategoryID Equals cat.CategoryID
                          Order By cat.CategoryID
                          Select New CustomObject _
                                 With {.CategoryName = cat.CategoryName,
                                       .ProductName = prod.ProductName,
                                       .UnitPrice = prod.UnitPrice,
                                       .Discontinued = prod.Discontinued}


        For Each obj In customQuery
            Console.WriteLine("Category name: {0}, Product name: {1}, Unit price: {2}, Discontinued: {3}",
                              obj.CategoryName, obj.ProductName,
                              obj.UnitPrice, obj.Discontinued)
        Next
    End Sub

    Function QueryByCategoryName(ByVal categoryName As String) _
             As System.ComponentModel.BindingList(Of Product)

        Dim query = From categories In northwind.Categories
                    Where categories.CategoryName = categoryName
                    Join prod In northwind.Products
                    On prod.CategoryID Equals categories.CategoryID
                    Where prod.Discontinued = False
                    Order By prod.UnitsInStock
                    Select prod

        Return New System.ComponentModel.
                   BindingList(Of Product)(query.ToList)
    End Function

    Sub SimpleQueriesDemo()
        'Returns Table(Of Product)
        Dim allProduct = northwind.Products

        'Returns IQueryable(Of Product)
        Dim queryByPrice = From prod In northwind.Products
                           Where prod.UnitPrice > 10
                           Select prod

        'Query is executed now
        For Each prod In queryByPrice
            Console.WriteLine(prod.ProductName)
        Next
    End Sub

    Sub StoredProcDemo()

        'Gets the list of the ten most expensive
        'products from the Products table into
        'a List(Of T)
        Dim result = northwind.Ten_Most_Expensive_Products.ToList

        For i = 0 To 2
            For Each r In result
                Debug.WriteLine(r.UnitPrice)
            Next
        Next

    End Sub

End Module


Class CustomObject
    Property CategoryName As String
    Property ProductName As String
    Property UnitPrice As Decimal?
    Property Discontinued As Boolean?
End Class