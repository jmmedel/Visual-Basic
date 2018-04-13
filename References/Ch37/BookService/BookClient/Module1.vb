Imports BookClient.BookServiceReference

Module Module1

    Sub Main()
        'Creates an instance of the proxy class
        'and automatically establishes a connection
        'to the service
        Dim client As New BookServiceClient

        'A new book
        'Note that the RegEx pattern requires to write the ISBN in the form
        'provided below, so like: 000-0-0000-0000-0 including the minus
        'character
        Dim myBook As New Book
        With myBook
            .Author = "Alessandro Del Sole"
            .Title = "Visual Studio LightSwitch Unleashed"
            .ISBN = "978-0-6723-3553-2"
            .DatePublished = Date.Today
        End With

        'Invokes the ValidateBook method from
        'the service
        Console.WriteLine(client.ValidateBook(myBook))
        Console.WriteLine("Done")
        Console.ReadLine()
        client.Close()

    End Sub

End Module
