Module Module1

    Sub Main()
        'A text message
        Dim message As String = "Hello Visual Basic 2015!"

        Console.WriteLine(message)
        'Attempt to read a file that does not exist
        Dim getSomeText As String =
            My.Computer.FileSystem.ReadAllText("FakeFile.txt")
        Console.WriteLine(getSomeText)
        Console.ReadLine()

    End Sub

End Module
