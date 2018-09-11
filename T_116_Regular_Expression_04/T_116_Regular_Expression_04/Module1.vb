Imports System.Text.RegularExpressions
Module Module1
    Sub Main()
        Dim input As String = "Hello    World   "
        Dim pattern As String = "\\s+"
        Dim replacement As String = " "
        Dim rgx As Regex = New Regex(pattern)
        Dim result As String = rgx.Replace(input, replacement)

        Console.WriteLine("Original String: {0}", input)
        Console.WriteLine("Replacement String: {0}", result)
        Console.ReadKey()
    End Sub

    'Original String: Hello   World
    'Replacement String: Hello World
End Module