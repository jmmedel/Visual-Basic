Module ComparisonOperators

    Sub NumericOperators()

        Dim firstNumber As Double = 3
        Dim secondNumber As Double = 4
        Dim comparisonResult As Boolean = False

        'False
        comparisonResult = (firstNumber = secondNumber)
        'True
        comparisonResult = (secondNumber > firstNumber)
        'False
        comparisonResult = (secondNumber <= firstNumber)
        'True
        comparisonResult = (secondNumber <> firstNumber)
    End Sub

    Sub ObjectsOperators()

        Dim firstPerson As New Person
        Dim secondPerson As New Person

        'Returns True, not same instance
        If firstPerson IsNot secondPerson Then

        End If

        'Returns False, not same instance
        If firstPerson Is secondPerson Then

        End If

        'Returns True, same instance
        Dim onePerson As Person = secondPerson
        If secondPerson Is onePerson Then

        End If

        'Returns True
        Dim anotherPerson As Object = New Person
        If TypeOf anotherPerson Is Person Then

        End If
    End Sub
End Module