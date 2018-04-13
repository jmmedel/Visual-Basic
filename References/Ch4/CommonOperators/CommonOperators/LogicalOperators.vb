Module LogicalOperators

    Sub LogicalDemo()

        'Returns False
        Dim result As Boolean = (Not 43 > 10)

        Dim firstPerson As New Person
        Dim secondPerson As New Person
        'Returns True
        result = (Not firstPerson Is secondPerson)


        'Returns False
        result = 10 > 15 And 30 > 15
        'Returns True
        result = 20 > 15 And 30 > 15
        'Returns True
        result = 20 > 15 And 15 = 15

        If My.Computer.Info.OSVersion = "6.3.9600" And My.Computer.Info.AvailablePhysicalMemory > 3072000000 Then
            'And evaluates *both* conditions
        End If

        'Returns True
        result = 10 > 15 Or 30 > 15
        'Returns True
        result = 10 < 15 Or 30 > 15
        'Returns False
        result = 10 > 15 Or 30 < 15

        'Returns True
        result = 10 > 15 Xor 30 > 15
        'Returns False
        result = 20 > 15 Xor 30 > 15
        'Returns False
        result = 20 > 15 Xor 15 = 15

        If My.Computer.FileSystem.FileExists("C:\MyFile.txt") = True AndAlso
    My.Computer.FileSystem.ReadAllText("C:\MyFile.txt").Length > 0 Then
            'Valid file
        End If

    End Sub
End Module
