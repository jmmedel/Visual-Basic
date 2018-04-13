Imports System.IO

Module Module1

    Sub Main()

        Console.WriteLine("Specify the file name:")
        Dim name As String = Console.ReadLine

        Dim throwTest As New TestThrow.TestThrow

        Try
            throwTest.TestAccessFile(name)

        Catch ex As ArgumentNullException When name Is Nothing
            Console.WriteLine("You provided a null parameter")
        Catch ex As ArgumentNullException When name Is String.Empty
            Console.WriteLine("You provided an empty string")
        Catch ex As FileNotFoundException
            Console.WriteLine(ex.Message)
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        Finally
            Console.ReadLine()
        End Try
    End Sub
End Module
