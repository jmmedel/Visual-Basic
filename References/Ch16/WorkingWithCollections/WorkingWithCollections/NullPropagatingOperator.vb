Module NullPropagatingOperator
    Function GetList() As List(Of Integer)
        Return New List(Of Integer) From {1, 2, 3}
    End Function

    Function GetDictionary() As Dictionary(Of String, Integer)
        Dim testDict As New Dictionary(Of String, Integer)
        testDict.Add("Alessandro", 37)
        testDict.Add("Robert", 40)
        Return testDict
    End Function

    Sub NullCheckDemo()
        Dim x As List(Of Integer) = GetList()
        'Return the first item in the collection
        'only if x is not Nothing
        Dim item1 As Integer? = x?(0)
    End Sub

    Sub NullDictCheckDemo()
        Dim x As Dictionary(Of String, Integer) = GetDictionary()
        'Return the Value part for the 
        'Key/value pair Alessandro/37
        Dim value As Integer? = x?!Alessandro
    End Sub
End Module
