Module Module1

    Sub Main()

        UnionDemo()

        Console.ReadLine()
    End Sub

    Sub QueryPlans()
        Dim plans = QueryObjectsDemo2()
        For Each plan In plans
            Console.WriteLine("Product name: {0} will be shipped on {1}",
                              plan.ProductName, plan.ShipDate)
        Next
        Console.ReadLine()

    End Sub

    Sub QueryObjectsDemo()
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

    End Sub

    Function QueryingObjectsDemo1() As IEnumerable(Of Product)

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
                    Where prod.UnitsInStock > 10 _
                    And prod.Discontinued = False
                    Order By prod.UnitPrice
                    Select prod

        Return query
    End Function

    Function QueryObjectsDemo2() As IEnumerable(Of CustomProduct)
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
                                                .ShipDate = #2015-1-1#}
        Dim shipPlan2 As New ShippingPlan With {.ProductID = 1,
                                                .ShipDate = #2015-2-1#}
        Dim shipPlan3 As New ShippingPlan With {.ProductID = 2,
                                                .ShipDate = #2015-3-1#}
        Dim shipPlan4 As New ShippingPlan With {.ProductID = 3,
                                                .ShipDate = #2015-4-1#}

        Dim shipPlans As New List(Of ShippingPlan) From {
                                                         shipPlan1,
                                                         shipPlan2,
                                                         shipPlan3,
                                                         shipPlan4}

        Dim queryPlans = From prod In products
                         Join plan In shipPlans On
                         plan.ProductID Equals prod.ProductID
                         Select New CustomProduct _
                         With {.ProductName = prod.ProductName,
                               .ShipDate = plan.ShipDate}

        Return queryPlans
    End Function
End Module

Class CustomProduct
    Property ProductName As String
    Property ShipDate As Date
End Class

Class Product
    Property ProductID As Integer
    Property ProductName As String
    Property UnitPrice As Decimal
    Property UnitsInStock As Integer
    Property Discontinued As Boolean
    Property CategoryID As Integer
End Class

Class Category
    Property CategoryID As Integer
    Property CategoryName As String
    Property Products As List(Of Product)
End Class

Class ShippingPlan
    Property ProductID As Integer
    Property ShipDate As Date
End Class