Module Module1

    Sub Main()
        'implicit conversion
        'Dim anInt As Object = 10
        'Dim onePerson As Object = New Person

        'explicit conversion
        'Dim onePerson As Person = CType(New Object, Person)

        'Boxing
        'Dim calculation As Double = 14.4 + 32.12
        'Dim result As Object = calculation

        'Unboxing
        'Dim convertedResult As Double = CType(result, Double)


        'Widening conversion
        'Dim i As Integer = 1
        'Dim d As Double = i

        Dim p As Object = New Person

        'In this example P is of type Object but stores a Person
        Dim result As Person = TryCast(p, Person)

        Console.WriteLine(result.ToString)
        Console.ReadLine()
    End Sub

    Class Person

        Property FirstName As String
        Property LastName As String

    End Class


End Module