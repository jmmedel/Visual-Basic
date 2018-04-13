Module Insert_Update_Delete

    Sub AddProduct(ByVal categoryReference As Category)
        Try
            Dim productCheck = northwind.Products.
                               Single(Function(prod) _
                               prod.ProductName = "Italian spaghetti")
            productCheck = Nothing

            'the Product does not exists, so add it
        Catch ex As InvalidOperationException

            Try
                Dim aProduct As New Product

                aProduct.ProductName = "Italian spaghetti"
                aProduct.Discontinued = False

                'The string is 22 characters long
                aProduct.QuantityPerUnit = "1000000000000000000000"
                aProduct.UnitPrice = 0.4D
                aProduct.CategoryID = categoryReference.CategoryID

                'Setting the relationship
                aProduct.Category = categoryReference

                'Adding the new product to the object model
                northwind.Products.InsertOnSubmit(aProduct)
                SaveChanges()

            Catch e As ArgumentException
                Console.WriteLine(e.Message.ToString)
                Exit Try
            Catch e As Exception

            End Try
        End Try
    End Sub

    Sub UpdateProduct(ByVal productInstance As Product)

        If productInstance Is Nothing Then
            Throw New NullReferenceException
        Else
            With productInstance
                .ProductName = "Italian Linguine"
                .UnitsInStock = 100
            End With
        End If

        SaveChanges()
    End Sub

    Sub DeleteProduct(ByVal productInstance As Product)

        If productInstance Is Nothing Then
            Throw New NullReferenceException
        Else
            northwind.Products.DeleteOnSubmit(productInstance)
            SaveChanges()
        End If
    End Sub

    Sub SaveChanges()
        Try
            northwind.SubmitChanges()

        Catch ex As System.Data.Linq.ChangeConflictException

            northwind.ChangeConflicts.ResolveAll(Data.Linq.RefreshMode.
                                                 KeepCurrentValues)
            northwind.SubmitChanges()
        Catch ex As SqlClient.SqlException

        Catch ex As Exception

        End Try

        'Use the DataContext.ChangeConflict property

        'Try
        '    northwind.SubmitChanges()

        'Catch ex As Data.Linq.ChangeConflictException
        '    Console.WriteLine("Optimistic concurrency error.")
        '    Console.WriteLine(ex.Message)
        '    For Each occ As Data.Linq.ObjectChangeConflict In northwind.ChangeConflicts
        '        Dim metatable As Data.Linq.Mapping.MetaTable = northwind.Mapping.GetTable(occ.Object.GetType())
        '        Dim entityInConflict = occ.Object

        '        Console.WriteLine("Table name: " & metatable.TableName)
        '        If TypeOf entityInConflict Is Product Then
        '            Dim prod = DirectCast(entityInConflict, Product)
        '            Console.WriteLine("Product ID: {0}", prod.ProductID)
        '        End If
        '        Console.ReadLine()
        '    Next
        'End Try
    End Sub

    Sub DirectSqlDemo()

        Dim products = northwind.ExecuteQuery(Of Product)("SELECT * FROM PRODUCTS WHERE " & _
                                                        "CATEGORYID='5' ORDER BY PRODUCTNAME")

        For Each prod In products
            Console.WriteLine(prod.ProductName)
        Next

        northwind.ExecuteCommand("UPDATE PRODUCTS SET " & _
                                 "PRODUCTNAME='Italian mozzarella' WHERE PRODUCTID='72'")

        Dim updatedProduct = northwind.Products.First(Function(prod) prod.ProductID = 72)

        'Returns "Italian mozzarella"
        Console.WriteLine(updatedProduct.ProductName)
        Console.ReadLine()
    End Sub
End Module
