Module Module1

    Sub Main()

        Dim userstring As String = Nothing
        Console.WriteLine("Enter a string")
        userstring = Console.ReadLine()
        Console.WriteLine()
        Console.WriteLine(userstring.Length.ToString())
        Console.WriteLine(userstring.Substring(0, 3))
        Console.WriteLine(userstring.Substring(3, 3))
        Console.WriteLine(userstring.Substring(6))

        Console.ReadLine()
    End Sub

End Module
