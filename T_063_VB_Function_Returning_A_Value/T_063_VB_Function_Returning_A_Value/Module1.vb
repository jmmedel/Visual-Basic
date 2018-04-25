
'Function Returning() a Value
'In VB.Net, a function can return a value to the calling code in two ways

'By using the return statement

'By assigning the value to the function name

'The following example demonstrates using the FindMax function:


Module Module1

    Function FindMax(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        ' local variable declaration */
        Dim result As Integer
        If (num1 > num2) Then
            result = num1
        Else
            result = num2
        End If
        FindMax = result
    End Function
    Sub Main()
        Dim a As Integer = 100
        Dim b As Integer = 200
        Dim res As Integer
        res = FindMax(a, b)
        Console.WriteLine("Max value is : {0}", res)
        Console.ReadLine()
    End Sub

End Module
