Imports System.Data.Entity.Core
Imports System.Data.Entity.Infrastructure
Imports EntityFramework

Module Module1
    Private northwindContext As NorthwindEntities

    Sub Main()
        northwindContext = New NorthwindEntities
        For Each prod In northwindContext.Ten_Most_Expensive_Products
            'Print the names of the ten most expensive products
            Console.WriteLine(prod.TenMostExpensiveProducts)
        Next
        Console.ReadLine()
    End Sub
    Sub EntitySQLDemo()
        Try
            Dim grainProducts = northwindContext.Products.
      SqlQuery("SELECT * FROM PRODUCTS WHERE " &
              "CATEGORYID='5' ORDER BY PRODUCTNAME")
            For Each prod In grainProducts
                Console.WriteLine(prod.ProductName)
            Next
        Catch ex As EntitySqlException
            Console.WriteLine("An error occurred in column: {0}",
                          ex.Column.ToString)
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Sub LINQtoEntitiesDemo(ByVal CategoryName As String)

        Dim query = From prod In northwindContext.Products.
                Include("Category")
                    Where prod.Category.CategoryName = CategoryName _
                And prod.Discontinued = False
                    Order By prod.UnitPrice
                    Select prod

        Console.WriteLine("Category: {0}",
                      CategoryName)

        For Each prod In query
            Console.WriteLine("Product name: {0}, Unit price: {1:c}",
                          prod.ProductName, prod.UnitPrice)
        Next
    End Sub

    Sub DeleteProduct()

        Try
            Dim check = northwindContext.Products.
                    Single(Function(p) p.
                    ProductName = "Italian spaghetti")

            northwindContext.Products.Remove(check)
            northwindContext.SaveChanges()

            'Does not exist
        Catch ex As InvalidOperationException

        End Try
    End Sub

    Sub AddProduct(ByVal categoryReference As Category)
        Try

            Dim check = northwindContext.Products.
                    Single(Function(p) p.
                    ProductName = "Italian spaghetti")

        Catch ex As InvalidOperationException

            Try
                Dim prod As New Product
                With prod
                    .ProductName = "Italian spaghetti"
                    .QuantityPerUnit = "10 packs"
                    .Discontinued = True
                    .SupplierID = 4
                    .UnitPrice = 0.5D
                    .UnitsInStock = 100
                    .UnitsOnOrder = 50

                    .Category = categoryReference
                End With

                northwindContext.Products.Add(prod)
                northwindContext.SaveChanges()

            Catch e As Exception
                'Exception handling when saving changes
            End Try

        Catch ex As Exception
            'Handle general exceptions here
        End Try
    End Sub
    Sub UpdateProduct()

        Try
            Dim check = northwindContext.Products.
                    Single(Function(p) p.
                    ProductName = "Italian spaghetti")

            check.Discontinued = True
            check.UnitsInStock = 30
            northwindContext.SaveChanges()

            'Product does not exist
        Catch ex As InvalidOperationException

            'Handle optimistic concurrency
        Catch ex As DbUpdateConcurrencyException
            ex.Entries.Single.Reload()
        Catch ex As UpdateException
        End Try
    End Sub

End Module
