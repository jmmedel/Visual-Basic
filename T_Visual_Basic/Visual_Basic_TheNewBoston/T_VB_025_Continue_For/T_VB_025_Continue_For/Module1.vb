Module Module1

    Sub Main()
        Console.WriteLine("Normal for loop")
        For index = 1 To 10
            Console.WriteLine(index)
        Next
        Console.WriteLine()
        Console.WriteLine("Contiue Statement")
        For index = 1 To 10
            If index = 5 Then Continue For
            Console.WriteLine(index)
        Next
        Console.ReadLine()
    End Sub

End Module
