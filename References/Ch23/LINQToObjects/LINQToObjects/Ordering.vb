Module Ordering

    Sub OrderByDemo()
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

        Dim query = From prod In products
                  Order By prod.UnitPrice
                  Select prod

        Dim queryDescending = From prod In products
                            Order By prod.UnitPrice Descending
                            Select prod

        Dim query2 = products.OrderBy(Function(p) p.UnitPrice).ThenBy(Function(p) p.ProductName)
        Dim revertedQuery = query2.Reverse()
    End Sub

End Module
