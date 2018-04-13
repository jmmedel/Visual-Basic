Module Union

    Sub JoinDemo()
        Dim cat1 As New Category With {.CategoryID = 1,
                                       .CategoryName = "Food"}

        Dim cat2 As New Category With {.CategoryID = 2,
                                       .CategoryName = "Beverages"}

        Dim categories As New List(Of Category) From {cat1,
                                                      cat2}


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

        Dim products As New List(Of Product) From {prod1,
                                                   prod2,
                                                   prod3,
                                                   prod4}


        'Cross Join
        Dim query = From prod In products
                    Join cat In categories On _
                    prod.CategoryID Equals cat.CategoryID
                    Select CategoryName = cat.CategoryName,
                           ProductName = prod.ProductName

        For Each obj In query
            Debug.Print("Category: {0}, Product name: {1}",
                              obj.CategoryName, obj.ProductName)
        Next

        'Group Join
        Dim query2 = From cat In categories
                     Group Join prod In products On _
                     prod.CategoryID Equals cat.CategoryID
                     Into Group
                     Select NewCategory = cat,
                            NewProducts = Group

        For Each obj In query2
            Debug.Print("Category: {0}", obj.NewCategory.CategoryName)

            For Each prod In obj.NewProducts
                Debug.Print("   Product name: {0}, Discontinued: {1}",
                                      prod.ProductName, prod.Discontinued)
            Next
        Next

        'Cross Group Join
        Dim query3 = From cat In categories
                     Group Join prod In products On _
                     prod.CategoryID Equals cat.CategoryID
                     Into Group
                    From p In Group
                    Select CategoryName = cat.CategoryName,
                           ProductName = p.ProductName

        For Each item In query3
            Debug.Print("Product {0} belongs to {1}",
                              item.ProductName,
                              item.CategoryName)
        Next

        'Left outer Join
        Dim query4 = From cat In categories
                     Group Join prod In products On _
                    prod.CategoryID Equals cat.CategoryID
                    Into Group
                    From p In Group.DefaultIfEmpty
                    Select CategoryName = cat.CategoryName,
                           ProductName = If(p IsNot Nothing,
                           p.ProductName, "No available product")
    End Sub

End Module
