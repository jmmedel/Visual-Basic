Module Module1

    Sub Main()
        'Sports.Climbing
        Dim mySport As Sports = CType(1, Sports)
        AnalyzeSports(mySport)

        Debug.WriteLine(mySport.ToString)

        For Each item As Integer In System.Enum.GetValues(GetType(Sports))
            Debug.WriteLine(item)
        Next

        For Each item As String In System.Enum.GetNames(GetType(Sports))
            Debug.WriteLine(item)
        Next

        'Returns True
        Debug.WriteLine(System.Enum.IsDefined(GetType(Sports), "Climbing"))
        'Returns False
        Debug.WriteLine(System.Enum.IsDefined(GetType(Sports), "Soccer"))

        'Returns Climbing
        Debug.WriteLine(System.Enum.GetName(GetType(Sports), 1))

        Console.WriteLine("Enter your favorite sport:")
        Dim sport As String = Console.ReadLine
        Dim result As Sports = CType(System.Enum.Parse(GetType(Sports), sport, True), Sports)
        'Returns 2
        Debug.WriteLine("The constant in the enumeration for {0} is {1}", sport.ToString, CInt(result))
        Console.ReadLine()
    End Sub

    Private Sub AnalyzeSports(ByVal sportsList As Sports)
        Select Case sportsList
            Case Is = Sports.Biking
                Console.WriteLine("So, do you really like biking my friend?")
            Case Is = Sports.Climbing
                Console.WriteLine("Oh guy, you're crazy!")
            Case Else
                Console.WriteLine("You're perhaps not so fond of sport :-)")
        End Select
    End Sub

    Public Enum Result
        Success = 0
        Failed = 1
        FileNotFound = 2
    End Enum

    Public Function ElaborateFile(ByVal fileName As String) As Result
        Try
            Dim text As String = My.Computer.FileSystem.ReadAllText(fileName)

            'Do some work here on your string

            Return Result.Success

        Catch ex As IO.FileNotFoundException
            Return Result.FileNotFound
        Catch ex As Exception
            Return Result.Failed
        End Try
    End Function

    Sub OpenFile()
        Dim res As Result = ElaborateFile("myfile.txt")
        'Success = 0
        If res = Result.Success Then
            Console.WriteLine("Success")
            'FileNotFound = 2
        ElseIf res = Result.FileNotFound Then
            Console.WriteLine("File not found")
            'Failed = 1
        ElseIf res = Result.Failed Then
            Console.WriteLine("The elaboration failed")
        End If
    End Sub
End Module