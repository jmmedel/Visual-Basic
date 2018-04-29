Module Module1

    Sub Main()
        Dim username As String = Nothing
        Dim userAge As Integer = Nothing
        Dim usersalary As Double = Nothing
        Console.WriteLine("What is your name?")
        username = Console.ReadLine()
        Console.WriteLine("What is your age")
        userAge = Console.ReadLine()
        Console.WriteLine("What is your salary?")
        usersalary = Console.ReadLine()
        Console.Write("   Youname is " & username)
        Console.Write("   You age is " & userAge)
        Console.Write("  You salary is " & usersalary)

        Console.ReadLine()
    End Sub

End Module
