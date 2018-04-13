Module Module1

    Sub Main()

        'Declaring a Guid
        Dim uniqueIdentifier As Guid

        'A unique identifier
        uniqueIdentifier = Guid.NewGuid
        Debug.WriteLine(uniqueIdentifier.ToString)

        'Another unique identifier,
        'although to the same variable
        uniqueIdentifier = Guid.NewGuid
        Debug.WriteLine(uniqueIdentifier.ToString)

        'Specifying a Guid
        uniqueIdentifier = New Guid("f578c96b-5918-4f79-b690-6c463ffb2c3e")
        Console.ReadLine()

    End Sub

End Module
