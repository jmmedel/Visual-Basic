Imports System.IO

Module Module1

    Sub Main()

        Console.WriteLine("Specify the file name:")
        Dim name As String = Console.ReadLine

        Dim throwTest As New TestThrow.TestThrow

        Try
            throwTest.TestAccessFile(name)

        Catch ex As ArgumentNullException
            Console.WriteLine(ex.ToString & Environment.NewLine &
                   "You passed an invalid argument")
        Catch ex As FileNotFoundException
            Console.WriteLine(ex.Message)
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        Finally
            Console.ReadLine()
        End Try

    End Sub

End Module