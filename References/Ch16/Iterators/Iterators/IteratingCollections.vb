Public Class Person
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Age As Integer
End Class

Public Class People
    Inherits List(Of Person)


End Class

Module IteratingCollections
    Dim somePeople As New People

    Sub Main()
        'Populates the collection with a million items, for demo purposes
        For i As Integer = 1 To 1000000
            somePeople.Add(New Person With {.FirstName = "First Name: " & i.ToString,
                                            .LastName = "Last Name: " & i.ToString,
                                            .Age = i})
        Next

        For Each item In GetPeople()
            Console.WriteLine("{0}, {1} of age: {2}", item.FirstName,
                              item.LastName, item.Age.ToString)
        Next
        Console.ReadLine()
    End Sub

    Function MyPeople() As IEnumerable(Of Person)
        Dim p As New People
        For Each item In somePeople
            p.Add(item)
            Threading.Thread.Sleep(10)
        Next
        Return p
    End Function

    Iterator Function GetPeople() As IEnumerable(Of Person)
        For Each item In somePeople
            Yield item
            Threading.Thread.Sleep(10)
        Next
    End Function

End Module

