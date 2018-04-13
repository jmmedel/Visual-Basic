Module Module1

    Sub Main()
        Dim client As New MyDataServiceClient(New Uri("http://localhost:18407"))

        For Each cust In client.Customers
            Console.WriteLine(cust.CompanyName)
            For Each ord In cust.Orders
                Console.WriteLine("     " + ord.OrderDate.ToString)
            Next
        Next

        Console.ReadLine()

        Dim aCustomer = client.Customers.Where(Function(c) c.CustomerID = "ALFKI").FirstOrDefault
        Dim query = From ord In aCustomer.Orders
                    Where ord.ShippedDate.HasValue = False
                    Select ord

        Console.WriteLine("Orders not shipped yet for customer " + aCustomer.CompanyName)
        For Each order In query
            Console.WriteLine(order.OrderID)
        Next
        Console.ReadLine()

        Console.WriteLine(client.MostRecentOrder)
        Console.ReadLine()

        Console.WriteLine("Adding new order...")
        Dim aCustomer1 = client.Customers.Where(Function(c) c.CustomerID = "ALFKI").FirstOrDefault
        Dim newOrder As New Order With {.CustomerID = "ALFKI", .Customer = aCustomer1, .OrderDate = DateTimeOffset.Now, .ShipCountry = "Italy"}

        client.AddObject("Orders", newOrder)
        client.SaveChanges()

        Console.WriteLine("Adding new order done.")
        Console.ReadLine()

        Console.WriteLine("Updating order...")
        Dim existingOrder = client.Orders.Where(Function(o) o.OrderID = "10052").FirstOrDefault
        If existingOrder IsNot Nothing Then
            existingOrder.ShippedDate = DateTimeOffset.Now
            client.UpdateObject(existingOrder)
            client.SaveChanges()
        End If
        Console.WriteLine("Updating done.")
        Console.ReadLine()

        Console.WriteLine("Deleting order...")
        client.DeleteObject(existingOrder)
        client.SaveChanges()
        Console.WriteLine("Deleting done.")
        Console.ReadLine()
    End Sub
End Module
