Module Module1

    Sub Main()

        Dim mystring As String = Nothing
        Dim finalstring As String = Nothing
        Console.WriteLine("Please enter a string ")
        mystring = Console.ReadLine()
        finalstring = mystring.Replace("a", "n")
        Console.WriteLine(finalstring)
        Console.ReadLine()

    End Sub

End Module
