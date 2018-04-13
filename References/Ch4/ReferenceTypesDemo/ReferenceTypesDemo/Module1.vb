Module Module1

    Sub Main()

        Dim onePerson As New Person
        onePerson.FirstName = "Alessandro"
        onePerson.LastName = "Del Sole"
        onePerson.Age = 35


        Dim secondPerson As New Person
        secondPerson.FirstName = onePerson.FirstName
        secondPerson.LastName = onePerson.LastName

        Console.WriteLine(onePerson.FirstName)
        Console.WriteLine(onePerson.LastName)
        Console.ReadLine()

        Dim int As Boolean = Nothing

    End Sub

End Module

Class Person

    Property FirstName As String
    Property LastName As String
    Property Age As Integer
End Class