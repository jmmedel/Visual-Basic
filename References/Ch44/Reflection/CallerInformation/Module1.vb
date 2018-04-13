Imports System.Runtime.CompilerServices
Module Module1

    Sub Main()
        'Wait for the user input
        Console.WriteLine("Type something: ")
        Dim input = Console.ReadLine

        'Simply show what the user entered:
        Console.WriteLine("You entered: {0}", input)

        WriteLog()
        Console.ReadLine()
    End Sub

    'Declare optional arguments. These are decorated
    'with CallerFilePath and CallerLineNumber attributes
    Private Sub WriteLog(<CallerFilePath()> Optional ByVal file As String = Nothing,
                         <CallerLineNumber()> Optional ByVal line As Integer = 0)
        Console.WriteLine("File: {0}", file)
        Console.WriteLine("Line number: {0}", line)
    End Sub

End Module
