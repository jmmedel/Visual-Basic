Module Module1

    Sub Main()

        Dim myint As Integer = Nothing
        Console.WriteLine("Please enter an interger")
        myint = Console.ReadLine()
        Select Case myint
            Case 0
                Console.WriteLine("Heelo")
            Case 1
                Console.WriteLine("you selected number 1 ")
            Case 2
                Console.WriteLine("You selectd number 2 ")

        End Select
        Console.ReadLine()
    End Sub

End Module
