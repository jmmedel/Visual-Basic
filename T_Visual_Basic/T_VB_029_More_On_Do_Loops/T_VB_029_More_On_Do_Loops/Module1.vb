Module Module1

    Sub Main()
        Console.WriteLine("Normal Do until Loop")
        Dim num1 As Integer = 0
        Do Until num1 = 5
            num1 += 1
            Console.WriteLine(num1)
        Loop
        Console.WriteLine()
        Console.WriteLine("Do until Variant ")
        num1 = 10
        Do
            Console.WriteLine(num1)
        Loop Until num1 = 10
        Console.ReadLine()
    End Sub

End Module
