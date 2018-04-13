Module Grouping

    Sub GroupByDemo()

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

        Dim query = From prod In products
                    Group prod By ID = prod.CategoryID
                    Into Group
                    Select CategoryID = ID,
                           ProductsList = Group

        For Each prod In query
            Debug.Print("Category {0}", prod.CategoryID)

            For Each p In prod.ProductsList
                Debug.Print("     Product {0}, Discontinued: {1}",
                                  p.ProductName, p.Discontinued)
            Next
        Next

        Dim query2 = products.GroupBy(Function(prod) prod.CategoryID,
                                      Function(prod) prod.ProductName)

    End Sub


End Module
