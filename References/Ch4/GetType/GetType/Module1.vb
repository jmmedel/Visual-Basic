Module Module1

    Sub Main()

        'GetType here is related to the type
        Dim testType1 As Type = GetType(Integer)

        For Each method As System.Reflection.MethodInfo In testType1.GetMethods
            Console.WriteLine(method.Name)
        Next
        Console.ReadLine()

        'GetType here is related to an instance
        Dim testInt As Integer = 123456
        Dim testType As Type = testInt.GetType

        For Each method As System.Reflection.MethodInfo In testType.GetMethods
            Debug.WriteLine(method.Name)
        Next
        Console.ReadLine()

        'Comparing two types
        If testInt.GetType Is GetType(Integer) Then
            Console.WriteLine("TestInt is of type Integer")
        End If
        Console.ReadLine()
    End Sub

End Module