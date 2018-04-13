Module Elements

    Sub ElementsDemo()
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

        Dim products As New List(Of Product) From {prod1,
                                                   prod2,
                                                   prod3,
                                                   prod4}


        Try
            Dim uniqueElement = products.Single(Function(p) p.
                                                ProductName = "Mozzarella")

        Catch ex As InvalidOperationException
            'The item does not exist
        End Try

        Dim uniqueElement2 = products.SingleOrDefault(Function(p) p.ProductName = "Mozzarell")

        'Gets the first product in the list
        Dim firstAbsolute = products.First

        Try
            'Gets the first product where product name starts with P
            Dim firstElement = products.First(Function(p) p.ProductName.
                                                          StartsWith("P"))
        Catch ex As Exception
            'No item available
        End Try

    End Sub

End Module
