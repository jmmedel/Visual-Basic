Module Restriction

    Sub WhereDemo()
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
                    Where prod.Discontinued = False
                    Select prod

        Dim result = products.Where(Function(p) p.Discontinued = False).
                     Select(Function(p) p)

        Dim fileList = From item In My.Computer.FileSystem.
                                    GetDirectoryInfo("C:\").GetFiles
                     Where item.LastAccessTime < Date.Today _
                     AndAlso item.LastAccessTime > New Date(2009, 9, 10) _
                     AndAlso item.FullName Like "*.exe"
                     Select item

    End Sub
End Module
