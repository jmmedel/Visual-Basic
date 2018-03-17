Module Module1

    Sub Main()
        Console.WriteLine("What is your name?")
        Dim username As String = Console.ReadLine()
        Console.WriteLine("What is your password?")
        Dim password As String = Console.ReadLine()
        If username = "Kagaya" Then
            Console.WriteLine("Welcome " & username)
        ElseIf username = Nothing Then
            Console.WriteLine("You enter nothing")
        Else
            Console.WriteLine("You are not a valid user")
        End If
        Console.ReadLine()
    End Sub

End Module
