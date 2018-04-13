Module Nullables

    Sub NullableDemo()

        Dim nullInt As Nullable(Of Integer) = Nothing

        'Has no value, so WriteLine is not executed
        If nullInt.HasValue Then
            Console.WriteLine(nullInt.Value)
        End If

        Dim nullBool As Boolean? = False
        If nullBool.HasValue Then
            Console.WriteLine(nullBool.Value)
        End If
    End Sub

    Sub NullPropagatingOperatorDemo()
        'onePerson is null
        Dim onePerson As Person = Nothing

        'The ?. operator returns nullable types
        Dim age As Integer? = onePerson?.Age
        Dim [date] As Date? = onePerson?.DateOfBirth

        If onePerson?.Age > 35 Then
            'Take the age only if onePerson
            'is not null and Age is > 35
            Dim age1 As Integer = onePerson.Age
        End If
        Dim firstChar As Char? = onePerson?.FirstName?.First

    End Sub
End Module


Public Class Person
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Age As Integer
    Public Property DateOfBirth As Date
End Class
