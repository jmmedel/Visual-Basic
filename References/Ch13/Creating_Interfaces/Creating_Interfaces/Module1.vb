Module Module1

    Sub Main()

        Dim d As IDocument = CType(New Document, IDocument)
        d.Load("C:\users\alessandro\documents\SomeDoc.txt")
        Console.WriteLine(d.Content)
        Console.Read()

    End Sub

End Module