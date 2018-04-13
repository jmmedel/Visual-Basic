Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Module Module1

    Sub Main()
        Using northwind As New NorthwindEntities
            'Retrieves the first order, as an example
            Dim anOrder As Order = northwind.Orders.Include("Customer").First

            'Same as classic objects serialization
            Dim formatter As New BinaryFormatter
            Using stream As New FileStream("C:\temp\EFSerialization.dat",
                                FileMode.Create)
                formatter.Serialize(stream, anOrder)
            End Using

            Dim newOrder As Order
            Using source As New FileStream("C:\temp\EFSerialization.dat",
                                FileMode.Open)
                newOrder = CType(formatter.Deserialize(source), Order)
            End Using
        End Using

        Console.ReadLine()

    End Sub

End Module
