Module Module1

    Sub Main()

        Dim p As New Person With {.FirstName = "Alessandro", .LastName = "Del Sole", .Age = 37}

        Dim people As New List(Of Person) From {p}

        ' "people" is of type List(Of Person)
        Dim peopleQuery = From pers In people
                          Where pers.LastName.StartsWith("D")
                          Order By pers.Age Descending
                          Select pers


        Dim peopleQuery2 = people.Where(Function(pers) pers.LastName.
                                  StartsWith("D")).OrderBy(Function(pers) pers.Age).
                                  Select(Function(pers) pers)

    End Sub

End Module