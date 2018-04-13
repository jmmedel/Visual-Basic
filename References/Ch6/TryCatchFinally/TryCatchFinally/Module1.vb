Imports System.IO

Module Module1

    Sub Main()

        Console.WriteLine("Specify a file name:")
        Dim fileName As String = Console.ReadLine

        Dim myFile As FileStream = Nothing

        Try
            myFile = New FileStream(fileName, FileMode.Open)
            'Seek a specific position in the file.
            'Just for example
            myFile.Seek(5, SeekOrigin.Begin)
        Catch ex As FileNotFoundException
            Console.WriteLine("Error message: " & ex.Message & Environment.NewLine)
            Console.WriteLine("Object causing the exception: " & ex.Source & Environment.NewLine)
            Console.WriteLine("Method where the exception is thrown; " & ex.TargetSite.ToString & Environment.NewLine)
            Console.WriteLine("Call stack:" & ex.StackTrace & Environment.NewLine)

            Console.WriteLine("Other useful info:")
            For Each k As KeyValuePair(Of String, String) In ex.Data
                Console.WriteLine(k.Key & " " & k.Value)
            Next

        Catch ex As IOException
            Console.WriteLine("A general input/output error occurred")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            myFile?.Close()
        End Try

        Console.ReadLine()
    End Sub
End Module
