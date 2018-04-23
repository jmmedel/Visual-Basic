Module Module1
    '16'
    Sub Main()
        Dim isinkindergaten As Boolean = Nothing
        Dim candrink As Boolean = Nothing
        Dim isseniorCitizen As Boolean = Nothing
        Console.WriteLine("What is your age?")
        Dim age As Integer = Console.ReadLine()
        Dim outComeKindergarten As String = Nothing
        Dim outComeSenior As String = Nothing
        Dim outComeDrink As String = Nothing

        If age <> 5 Then
            isinkindergaten = False
            outComeKindergarten = "You arent in kindergarten"
        Else
            isinkindergaten = True
            outComeKindergarten = "You are in kindergarten"
        End If
        ''
        If age >= 65 Then
            isseniorCitizen = True
            outComeSenior = "You are a senior citizen"
        Else
            isseniorCitizen = False
            outComeSenior = "You arent a senior citizen"
        End If

        If age >= 21 Then
            candrink = True
            outComeDrink = "You can drink"
        Else
            candrink = False
            outComeDrink = "You cannot drink"

        End If

        Console.WriteLine(outComeDrink & " " & outComeKindergarten & " " & outComeSenior)

        Console.ReadLine()

    End Sub

End Module
