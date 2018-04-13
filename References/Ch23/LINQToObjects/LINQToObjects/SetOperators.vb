Module SetOperators

    Sub DistinctDemo()

        Dim someInt = {1, 2, 3, 3, 2, 4}
        'Returns {1, 2, 3, 4}
        Dim result = From number In someInt Distinct
                     Select number

    End Sub

    Sub UnionDemo()

        Dim someInt = {1, 2, 3, 4}
        Dim otherInt = {4, 5, 2, 1}
        'exclude duplicates
        Dim result = someInt.Union(otherInt)

    End Sub

    Sub IntersectDemo()

        Dim someInt = {1, 2, 3, 4}
        Dim otherInt = {1, 2, 5, 6}

        Dim result = someInt.Intersect(otherInt)

    End Sub

    Sub ExceptDemo()
        Dim someInt = {1, 2, 3, 4}
        Dim otherInt = {1, 2, 5, 6}
        Dim result = someInt.Except(otherInt)
    End Sub
End Module
