Module Module1

    Sub Main()
        Dim Age As Integer = Nothing
        Dim hasInsurance As Boolean = Nothing
        Console.WriteLine("What is your age?")
        Age = Console.ReadLine()
        Console.WriteLine("Do you have insurance true or false")
        hasInsurance = Console.ReadLine()
        If Age = 16 Then
            If hasInsurance = True Then
                Console.WriteLine("You can drive legally")
            Else
                Console.WriteLine("You can drive but dont get crash")
            End If
        Else
            Console.WriteLine("You cannot drive")
        End If
        Console.ReadLine()


    End Sub

End Module
