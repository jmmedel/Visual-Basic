Module Aggregation

    Sub AggregateExample()
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

        'Returns the sum of product unit prices
        Dim totalAmount = Aggregate prod In products
                          Order By prod.UnitPrice 
                          Into Sum(prod.UnitPrice)

        'Returns the average price
        Dim averagePrice = Aggregate prod In products
                           Into Average(prod.UnitPrice)

        'Returns the number of products
        Dim numberOfItems = Aggregate prod In products
                            Into Count()

        'Returns the number of products as Long
        Dim longNumberOfItems = Aggregate prod In products
                                Into LongCount()


        'Returns the lowest value for the specified
        'sequence
        Dim minimumPrice = Aggregate prod In products
                           Into Min(prod.UnitPrice)

        'Returns the highest value for the specified 
        'sequence
        Dim maximumPrice = Aggregate prod In products
                           Into Max(prod.UnitPrice)

        Dim minimum = products.Min(Function(p) p.UnitPrice)
    End Sub

End Module
