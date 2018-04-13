Module Module1

    Sub Main()
        'Throws an ArgumentNullException
        EvaluatePerson(Nothing)
        'A message says that the LastName property is initialized
        EvaluatePerson(New Person With {.LastName = "Del Sole"})

        Console.ReadLine()
    End Sub


    Sub EvaluatePerson(ByVal p As Person)
        'Check if Person is Nothing
        'If it is Nothing, returns False else True
        'The result is returned as a delegate
        Dim checkIfNull = If(p Is Nothing, False, True)

        'If False, p is Nothing, therefore
        'throws an exception
        If checkIfNull = False Then
            Throw New ArgumentNullException("testPerson")
        End If

        Dim executeTest = If(String.IsNullOrEmpty(p.LastName) = True,
                          "LastName property is empty",
                          "LastName property is initialized")

        If String.IsNullOrEmpty(p.LastName) = True Then
            'LastName property is empty
        Else
            'LastName property is initialized
        End If

        'The compiler infers String
        Console.WriteLine(executeTest)
    End Sub

End Module
