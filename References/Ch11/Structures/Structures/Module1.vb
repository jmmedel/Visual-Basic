Module Module1


    Sub Main()
        Dim firstOrder As New Order(1, Date.Now, Date.Now, 1, 1)
        Dim secondOrder As New Order(2, Date.Now, Date.Now, 1, 1)

        'Creates a real copy of firstOrder
        Dim thirdOrder As New Order
        thirdOrder = firstOrder

        'Returns 2
        Console.WriteLine(Order.Count)
        ShowOrderInfo(firstOrder)
    End Sub

    Private Sub ShowOrderInfo(ByVal orderInstance As Order)
        Console.WriteLine("Order info:")
        Debug.WriteLine("ID: {0}, Date received: {1}",
                          orderInstance.OrderID,
                          orderInstance.OrderDate)
        Console.ReadLine()
    End Sub
End Module