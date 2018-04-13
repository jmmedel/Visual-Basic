Module NullPropagating

    Sub QueryNonNullProducts()
        Dim prod1 As New Product With {.ProductID = 0,
                                       .ProductName = "Pasta",
                                       .UnitPrice = 0.5D,
                                       .UnitsInStock = 10,
                                       .Discontinued = False,
                                       .CategoryID = 1}

        Dim prod2 As New Product With {.ProductID = 1,
                                       .ProductName = "Wine",
                                       .UnitPrice = 1D,
                                       .UnitsInStock = 50,
                                       .Discontinued = False,
                                       .CategoryID = 2}

        Dim prod3 As New Product With {.ProductID = 2,
                                       .ProductName = "Water",
                                       .UnitPrice = 0.5D,
                                       .UnitsInStock = 20,
                                       .Discontinued = False,
                                       .CategoryID = 2}

        Dim prod4 As New Product With {.ProductID = 3,
                                       .ProductName = "Tofu",
                                       .UnitPrice = 3.5D,
                                       .UnitsInStock = 40,
                                       .Discontinued = True,
                                       .CategoryID = 1}

        Dim products As List(Of Product) = Nothing

        Dim oneProduct = products?.FirstOrDefault?.ProductName


    End Sub
End Module
