
'Recursive Function
'A Function() can call itself. This Is known as recursion. Following Is an example that calculates factorial for a given number using a recursive function:


Module Module1

    Function factorial(ByVal num As Integer) As Integer
        ' local variable declaration */
        Dim result As Integer
        If (num = 1) Then
            Return 1
        Else
            result = factorial(num - 1) * num
            Return result
        End If
    End Function
    Sub Main()
        'calling the factorial method
        Console.WriteLine("Factorial of 6 is : {0}", factorial(6))
        Console.WriteLine("Factorial of 7 is : {0}", factorial(7))
        Console.WriteLine("Factorial of 8 is : {0}", factorial(8))
        Console.ReadLine()
    End Sub

End Module


'When the above code Is compiled And executed, it produces the following result

'Factorial of 6 Is: 720
'Factorial of 7 Is: 5040
'Factorial of 8 Is: 40320
