Module Module1

    Sub Main()
        Console.WriteLine("Normal for loop")
        For index = 1 To 10
            Console.WriteLine(index)
        Next
        Console.WriteLine()
        Console.WriteLine("Step by 2 ")
        For index = 1 To 10 Step 2
            Console.WriteLine(index)
        Next
        Console.WriteLine()
        Console.WriteLine("Step by -4 ")
        For index = 20 To 1 Step -4
            Console.WriteLine(index)
        Next

        Console.ReadLine()
    End Sub

End Module
