Imports System.IO
Imports ImportsDirectives.People.Work
Imports System.IO.File

Module Module1

    Sub Main()
        Delete("C:\text.txt")
        Dim aFile As New FileStream("C:\test.txt", FileMode.Open)
        Dim onePerson As New Customer

        onePerson = Nothing
        aFile.Close()
    End Sub

End Module

Namespace People.Work

    Public MustInherit Class Person
        Public Property FirstName As String
        Public Property LastName As String

        Public Overrides Function ToString() As String
            Return FirstName & " " & LastName
        End Function
    End Class

    Public Class Customer
        Inherits Person

        Public Property CompanyName As String
        Public Overrides Function ToString() As String
            Return Me.LastName & " from " & Me.CompanyName
        End Function
    End Class
End Namespace