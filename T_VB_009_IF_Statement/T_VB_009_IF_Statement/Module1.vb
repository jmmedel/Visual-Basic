Module Module1

    Sub Main()

        Console.WriteLine("What is your name_")
        Dim username As String = Console.ReadLine()
        Console.WriteLine("What is your password")
        Dim password As String = Console.ReadLine()
        If username = "Sam" Then
            Console.WriteLine("Welcome sam!")
        End If
        If password = "123456789" Then
            Console.WriteLine("You enter rhe corred password")
        End If
        Console.ReadLine()
    End Sub

End Module
