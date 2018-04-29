Module Module1

    Sub Main()
        Dim username As String = Nothing
        Console.WriteLine("What is your username?")
        username = Console.ReadLine()

        If username.Length.Equals(10) = 10 Then
            Console.WriteLine("You have benn granted access")
        Else
            Console.WriteLine("your username is the right length")
        End If
        Console.ReadLine()
    End Sub

End Module
