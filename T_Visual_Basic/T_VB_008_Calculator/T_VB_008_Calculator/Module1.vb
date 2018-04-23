Module Module1
    '12'
    Sub Main()
        Console.WriteLine("Please enter the first number:")
        Dim num1 As Double = Console.ReadLine()
        Console.WriteLine("First number: " & num1)
        Console.WriteLine("Please enter the second number")
        Dim num2 As Double = Console.ReadLine()
        Console.WriteLine("Second number:" & num2)
        Console.WriteLine("Answer" & num1 * num2)
        Console.ReadLine()
    End Sub

End Module
