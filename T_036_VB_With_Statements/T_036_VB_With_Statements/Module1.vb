
'VB.Net - With... End With Statement
'It Is Not exactly a looping construct. It executes a series of statements that repeatedly refers to a single object Or structure.

'The syntax For this Loop construct Is

'With Object
'    [ statements ]
'End With


Module Module1

    Public Class Book
        Public Property Name As String
        Public Property Author As String
        Public Property Subject As String
    End Class
    Sub Main()
        Dim aBook As New Book
        With aBook
            .Name = "VB.Net Programming"
            .Author = "Kagaya john "
            .Subject = "Information Technology"
        End With
        With aBook
            Console.WriteLine(.Name)
            Console.WriteLine(.Author)
            Console.WriteLine(.Subject)
        End With
        Console.ReadLine()
    End Sub

End Module
