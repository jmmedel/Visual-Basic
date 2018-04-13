Module Projection

    Sub SelectDemo()
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

        Dim productSequence = From prod In products
                              Select New With {.ID = prod.ProductID,
                              .Name = prod.ProductName}

        'IEnumerable(Of String)
        Dim prodSequence = products.Select(Function(p) p.ProductName)

    End Sub

    Sub SelectManyDemo()

    End Sub

    Sub PopulateObjects()
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

        Dim shipPlan1 As New ShippingPlan With {.ProductID = 0,
                                                .ShipDate = New Date(2010, 1, 1)}
        Dim shipPlan2 As New ShippingPlan With {.ProductID = 1,
                                                .ShipDate = New Date(2010, 2, 1)}
        Dim shipPlan3 As New ShippingPlan With {.ProductID = 2,
                                                .ShipDate = New Date(2010, 3, 1)}
        Dim shipPlan4 As New ShippingPlan With {.ProductID = 3,
                                                .ShipDate = New Date(2010, 4, 1)}

        Dim shipPlans As New List(Of ShippingPlan) From {
                                                         shipPlan1,
                                                         shipPlan2,
                                                         shipPlan3,
                                                         shipPlan4}

        Dim query = From prod In products
                    From ship In shipPlans
                    Where prod.ProductID = ship.ProductID
                    Select prod.ProductName, ship.ShipDate

    End Sub

End Module
