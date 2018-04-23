Module Module1

    Sub Main()

        Dim userstring As String = Nothing
        Dim programstring As String = "catfish"
        Console.WriteLine("Type anything you want")
        userstring = Console.ReadLine()
        Console.WriteLine(userstring)
        userstring = userstring + " " + programstring
        Console.WriteLine(userstring & " Hello youtube ")
        Console.ReadLine()

    End Sub

End Module
