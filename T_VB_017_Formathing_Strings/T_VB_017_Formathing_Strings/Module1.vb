Module Module1

    Sub Main()

        Dim mystring As String = Nothing
        Console.WriteLine("Please enter a string")
        mystring = Console.ReadLine()
        Console.WriteLine("Please enter a decimal value ")
        Dim mydouble As Double = Console.ReadLine()
        Console.WriteLine()
        Console.WriteLine(String.Format("{0:n2}", mydouble))
        Console.WriteLine(mystring.ToUpper())
        Console.ReadLine()

    End Sub

End Module
