Module Module1

    Sub Main()

        'Widening conversion
        Dim i As Integer = 1
        Dim d As Double = i

        'Narrowing conversion
        Dim d1 As Double = 12345.678
        Dim i1 As Integer = CInt(d1)
        Dim s As String = CStr(i)

        Dim i2 As Integer = 123456
        Dim s2 As Short = CType(i2, Short)

        Dim p As Object = 1
        Dim result As Integer = CType(p, Integer)

        'Unboxing conversion
        Dim p1 As Object = New Person
        Dim result1 As Person = CType(p, Person)

        'In this example P is of type Object but stores a Person
        If TypeOf (p1) Is Person Then
            Dim result2 As Person = DirectCast(p1, Person)
        End If

        'In this example P is of type Object but stores a Person
        Dim result3 As Person = TryCast(p, Person)

        'The following succeeds
        Dim d3 As Double = 123.456
        Dim s3 As Short = CType(d, Short)

        'The following fails because SHort doesn't inherit from Double nor there is
        'a relationship in the implementation
        Dim d4 As Double = 123.456
        Dim s4 As Short = DirectCast(d4, Short)





    End Sub

End Module