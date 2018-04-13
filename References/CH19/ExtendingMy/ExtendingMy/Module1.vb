Imports System.Collections.ObjectModel

Module Module1

    Sub Main()

        Dim someInts As New List(Of Integer) From {1, 2, 3}

        Dim obs As ObservableCollection(Of Integer) =
                   My.CollectionsUtils.ConvertToObservableCollection(someInts)

        For Each number As Integer In obs
            Console.WriteLine(number)
        Next

        Console.ReadLine()

        Dim succeeded As Boolean =
            My.Application.AssociateExtension(".ale",
            "AlessandroDelSole/document")

        Dim mimeType As String = My.Computer.MimeType("Testfile.txt")


    End Sub

End Module
