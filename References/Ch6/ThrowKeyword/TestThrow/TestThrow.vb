Imports System.IO

Public Class TestThrow

    Public Sub TestAccessFile(ByVal FileName As String)

        If String.IsNullOrEmpty(FileName) Then
            Throw New ArgumentNullException("FileName", "You passed an invalid file name")
        End If

        Dim testFile As FileStream = Nothing

        Try
            testFile = New FileStream(FileName, FileMode.Open)
        Catch ex As FileNotFoundException
            Throw New FileNotFoundException("The supplied file name was not found")
        Catch ex As Exception
            Throw
        Finally
            If testFile IsNot Nothing Then
                testFile.Close()
            End If
        End Try

    End Sub
End Class
