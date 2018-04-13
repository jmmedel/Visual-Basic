Module Module1

    Sub Main()
        Console.ReadLine()
    End Sub

    Sub IfThenElseDemo()
        Console.WriteLine("Type a number")
        'Assumes users type a valid number
        Dim number As Double = CDbl(Console.ReadLine)

        If number >= 100 Then
            Console.WriteLine("Your number is greater than 100")
        ElseIf number < 100 AndAlso number > 50 Then
            Console.WriteLine("Your number is less than 100 and greater than 50")
        Else
            'General action
            Console.WriteLine("Your number is: {0}", number)
        End If

        If Not number >= 100 Then
            'Number is False          
        End If

        Dim p As Person  'p is actually null

        'You can check with IsNot
        If p IsNot Nothing Then
            'p is not null
        Else
            'p is null
        End If
    End Sub

    Sub SelectCaseDemo()
        Console.WriteLine("Type a file extension (without dot):")
        Dim fileExtension As String = Console.ReadLine

        Select Case fileExtension.ToLower
            Case Is = "txt"
                Console.WriteLine("Is a text file")
            Case Is = "exe"
                Console.WriteLine("Is an executable")
            Case Is = "doc"
                Console.WriteLine("Is a Microsoft Word document")
            Case Else
                Console.WriteLine("Is something else")
        End Select

        Console.WriteLine("Enter a number from 1 to 50:")
        Dim result As Integer = CInt(Console.ReadLine)
        Select Case result
            'The user entered a number in the range from 1 to 25
            Case 1 To 25
                Console.WriteLine("You entered {0} which is a small number",
                                  result.ToString)
                'The user entered a number in the range from 26 to 50
            Case 26 To 50
                Console.WriteLine("You entered {0} which is a high number",
                                  result.ToString)
                'The user entered a number < 1 or > 50
            Case Else
                Console.WriteLine("You entered a number which is out of range")
        End Select
    End Sub

End Module
