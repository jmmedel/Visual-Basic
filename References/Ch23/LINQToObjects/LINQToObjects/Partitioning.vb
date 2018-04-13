Module Partitioning

    Private pageCount As Integer
    Private Products As List(Of Product)

    Sub PopulateProducts()
        Dim prod1 As New Product With {.ProductID = 0,
                                       .ProductName = "Pasta",
                                       .UnitPrice = 0.5D,
                                       .UnitsInStock = 10,
                                       .Discontinued = False}

        Dim prod2 As New Product With {.ProductID = 1,
                                       .ProductName = "Mozzarella",
                                       .UnitPrice = 1D,
                                       .UnitsInStock = 50,
                                       .Discontinued = False}

        Dim prod3 As New Product With {.ProductID = 2,
                                       .ProductName = "Crabs",
                                       .UnitPrice = 7D,
                                       .UnitsInStock = 20,
                                       .Discontinued = True}

        Dim prod4 As New Product With {.ProductID = 3,
                                       .ProductName = "Tofu",
                                       .UnitPrice = 3.5D,
                                       .UnitsInStock = 40,
                                       .Discontinued = False}

        Products = New List(Of Product) From {prod1,
                                                   prod2,
                                                   prod3,
                                                   prod4}
    End Sub

    Function QueryProducts() As IEnumerable(Of Product)

        Dim query As IEnumerable(Of Product)
        'Skips the already shown products
        'and takes next 10
        query = From prod In Products
                Order By prod.ProductID
                Skip pageCount Take 10

        'In real applications ensure that query is not null
        Return query
    End Function
End Module
