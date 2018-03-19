Module Module1

    Sub Main()

        Dim userString As String = Nothing
        Dim compString As String = "OnlineGamer"
        Console.WriteLine("Pleaase enter a string")
        userString = Console.ReadLine()
        Console.WriteLine(String.Compare(userString, compString))
        Console.ReadLine()

    End Sub

End Module
