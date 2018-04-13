Module Module1


    Sub Main()

        BitwiseDemo()
        Console.ReadLine()
    End Sub

End Module

Module ArithmeticOperators

    Dim firstNumber As Double = 3.45
    Dim secondNumber As Double = 4.56
    Dim result As Double = 0

    Sub MathOperators()

        'Sum
        result = firstNumber + secondNumber

        'Subtraction
        result = secondNumber - firstNumber

        'Multiplication
        result = firstNumber * secondNumber

        'Division between double: returns 2.5
        Dim dblResult As Double = 10 / 4
        'Division between integers: returns 2
        Dim intResult As Integer = 10 \ 4

        'Division between Single and Double
        Dim singleValue As Single = 987.654
        Dim doubleValue As Double = 654.321
        Dim division As Single = singleValue / CSng(doubleValue)

        'Pow (same as System.Math.Pow)
        result = 2 ^ 4
        result = System.Math.Pow(2, 4)

        'Mod: returns 0
        Dim remainder As Integer = 10 Mod 2
        'Mod: returns 1
        Dim remainder2 As Integer = 9 Mod 2
        'Double remainder
        Dim dblRemainder As Double = System.Math.IEEERemainder(10.42, 5.12)

    End Sub

    Sub IncrementOperators()
        Dim value As Double = 1

        value += 1 'Same as value = value + 1

        value -= 1 'Same as value = value - 1

        value *= 2 'Same as value = value * 2

        value /= 2 'Same as value = value / 2

        value ^= 2 'Same as value = value ^ 2

        Dim test As String = "This is"
        test &= " a string" 'same as test = test & "a string"
    End Sub
End Module




Module ConcatenationOperators
    Sub ConcatenationDemo()

        Dim firstString As String = "Alessandro"
        Dim secondString As String = "Del Sole"

        Dim completeString As String = firstString & secondString

        'The following still works but should be avoided
        'Dim completeString As String = firstString + secondString

    End Sub
End Module
