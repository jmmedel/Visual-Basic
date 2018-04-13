Module Module1

    Sub Main()

        Dim testContact As New Contact With _
            {.FirstName = "Alessandro",
             .LastName = "Del Sole",
             .Email = "Alessandro.delsole@visual-basic.it"}

        Console.WriteLine(testContact.FullName)
        Console.WriteLine(testContact.ToString)
        Console.ReadLine()
    End Sub

End Module
