Module Module1

    Sub Main()

        WorkingWithArrays()

        Console.ReadLine()
    End Sub

    Sub ArrayDemo()
        Dim anArrayOfString() As String
        If anArrayOfString Is Nothing Then
            'The array is not initialized
        End If

        'Alternative syntax
        'Dim anArrayOfString As String()

        'Can store three items
        'Dim anArrayOfThreeStrings(2) As String

        'Inline initialization, only with not explicit bounds
        Dim anArrayOfThreeStrings() As String = New String() {"One", "Two", "Three"}

        Dim anArrayOfChar() As Char = New Char() {"a"c, "b"c, "c"c}

        Dim anArrayOfByte() As Byte = New Byte() {1, 2, 3}

        Dim anExplicitBoundArrayOfByte(2) As Byte
        anExplicitBoundArrayOfByte(0) = 1
        anExplicitBoundArrayOfByte(1) = 2
        anExplicitBoundArrayOfByte(2) = 3

        Console.WriteLine(anExplicitBoundArrayOfByte(1).ToString)

        For Each value As Byte In anExplicitBoundArrayOfByte
            Console.WriteLine(value)
        Next

        ReDim Preserve anExplicitBoundArrayOfByte(3)
        anExplicitBoundArrayOfByte(3) = 4

        For Each value As Byte In anExplicitBoundArrayOfByte
            Console.WriteLine(value)
        Next

        For Each value As String In anArrayOfThreeStrings
            Console.WriteLine(value)
        Next
    End Sub

    Sub MultiDimArrays()
        Dim multiArray(,) As Integer = {{1, 2}, {3, 4}}

        Dim multiArrayWithExplicitBounds(5, 1) As Integer
        multiArrayWithExplicitBounds(1, 0) = 1
        multiArrayWithExplicitBounds(2, 0) = 2
        multiArrayWithExplicitBounds(1, 1) = 3
    End Sub

    Sub JaggedArrays()
        'A 9-entry array on the left and 
        'an unbound array on the right
        Dim firstJaggedArray(8)() As Integer

        Dim unboundJaggedArray()() As Integer _
                                   = {New Integer() {1, 2, 3}, New Integer() {4, 5, 6}}
        Dim oneIntArray() As Integer = {1, 2, 3}
        Dim twoIntArray() As Integer = {4, 5, 6}
        unboundJaggedArray = {oneIntArray, twoIntArray}

        For Each arr As Integer() In unboundJaggedArray
            For Each item As Integer In arr
                Console.WriteLine(item.ToString)
            Next
        Next
    End Sub

    Sub WorkingWithArrays()

        Dim anArrayOfByte() As Byte = New Byte() {1, 2, 3}

        'Returns 0 and 2
        Console.WriteLine("Lower bound {0}, upper bound {1}",
                          anArrayOfByte.GetLowerBound(0).ToString,
                          anArrayOfByte.GetUpperBound(0).ToString)

        'Array now contains 3, 2, 1
        Array.Reverse(anArrayOfByte)
        Array.Sort(anArrayOfByte)

        Dim runTimeArray As Array = Array.CreateInstance(GetType(String), 2)
        runTimeArray.SetValue(CStr("Test string"), 0)
        'Returns "Test string"
        Console.WriteLine(runTimeArray.GetValue(0))

        'A conversion to Byte is required
        'Both return 1
        Dim position As Integer = Array.IndexOf(anArrayOfByte, CByte(2))
        Dim position2 As Integer = Array.BinarySearch(anArrayOfByte, CByte(2))

        'Declares an array to copy to, 
        'with bounds equals to the source array
        Dim targetArray(anArrayOfByte.GetUpperBound(0)) As Byte

        'Copies the original array into the target,
        'using the original length
        Array.Copy(anArrayOfByte, targetArray, anArrayOfByte.Length)

        anArrayOfByte.CopyTo(targetArray, 0)

    End Sub

End Module
Public Structure myType
    Public Shared Operator IsFalse(ByVal w As myType) As Boolean
        Dim result As Boolean
        ' Insert code to calculate IsFalse of w.
        Return result
    End Operator
    Public Shared Operator IsTrue(ByVal w As myType) As Boolean
        Dim result As Boolean
        ' Insert code to calculate IsTrue of w.
        Return result
    End Operator
End Structure
