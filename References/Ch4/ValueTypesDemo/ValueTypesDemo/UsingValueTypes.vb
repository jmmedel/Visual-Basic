Imports System.Runtime.CompilerServices

Module UsingValueTypes

    Sub Main()

        'Declares an Integer
        Dim anInteger As Integer = 2

        'Declares a double and stores the result of a calculation
        Dim calculation As Double = 74.6 * 834.1

        'Declares one byte storing an hexadecimal value
        Dim oneByte As Byte = &H0

        'Declares a single character
        Dim oneCharacter As Char = "a"c

        'Declares a decimal number
        Dim sampleDecimal As Decimal = 8743341.353531135D

        'Declares a Boolean variable
        Dim isTrueOrFalse As Boolean = True

        'Declares a BigInteger
        Dim arbitraryInteger As New System.Numerics.BigInteger(800000)

        Console.WriteLine(anInteger)
        Console.WriteLine(calculation)
        Console.WriteLine(oneByte)
        Console.WriteLine(oneCharacter)
        Console.WriteLine(isTrueOrFalse)
        Console.WriteLine(arbitraryInteger)

        Console.WriteLine(Integer.MinValue)
        Console.WriteLine(Char.MaxValue)
        Console.WriteLine(Date.MaxValue)

        Console.ReadLine()

    End Sub

End Module
