Module Module1

    Sub Main()

        Dim mystring As String = Nothing
        Console.WriteLine("Please enter a string ")
        mystring = Console.ReadLine()
        Select Case mystring.ToLower()

            Case "helo"
                Console.WriteLine("Goodbye")
            Case "goodbye"
                Console.WriteLine("Heelo")
            Case "fishing"
                Console.WriteLine("Boat")
            Case Else
                Console.WriteLine("i dont know whaat are you talking about ")
        End Select
        Console.ReadLine()
    End Sub

End Module
