Module Conversion

    Sub ConvertDemo()
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

        Dim query = (From prod In products
                    Where prod.Discontinued = False
                    Select prod).ToList

        'Returns Product()
        Dim productArray = query.ToArray

        'Returns List(Of Product)
        Dim productList = query.ToList

        'Returns Dictionary(Of Integer, Product)
        Dim productDictionary = query.ToDictionary(Function(p) _
                                                   p.ProductID)

        For Each prod In productDictionary
            Console.WriteLine("Product ID: {0}, name: {1}", prod.Key,
                              prod.Value.ProductName)
        Next

        Dim productLookup = query.ToLookup(Function(p) p.ProductID, _
                                         Function(p) p.ProductName & " has " & _
                                         p.UnitsInStock & " units in stock")

        For Each prod In productLookup
            Debug.Print("Product ID: {0}", prod.Key)

            For Each item In prod
                Debug.Print("     {0}", item)
            Next
        Next

        Dim newList As New List(Of Product)
        'Populate your collection here..

        Dim anEnumerable = newList.AsEnumerable
        Dim aQueryable = newList.AsQueryable

        Dim mixed() As Object = {"String1", 1, "String2", 2}
        Dim onlyInt = mixed.OfType(Of Integer)()


    End Sub
End Module
