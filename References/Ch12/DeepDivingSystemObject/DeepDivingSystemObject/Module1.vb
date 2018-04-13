Module Module1

    Sub Main()

        Dim p As New Object

        Dim aPerson As New Person
        Dim anObject As Object = aPerson

        Dim hashCode As Integer = p.GetHashCode
        Debug.WriteLine(hashCode.ToString)
        p = Nothing

        'Two different instances
        Dim firstObject As New Object
        Dim secondObject As New Object

        'Returns False
        Dim test As Boolean = Object.ReferenceEquals(firstObject, secondObject)

        'Returns False
        Dim test3 As Boolean = Object.Equals(firstObject, secondObject)
        Console.WriteLine(firstObject.ToString)

        'Returns False
        Console.WriteLine(firstObject.Equals(secondObject))
        'Copies the reference to the instance
        Dim testObject As Object = firstObject
        'Returns True
        Console.WriteLine(testObject.Equals(firstObject))

        Console.ReadLine()

    End Sub

End Module

Public Class Person
    Public Property FirstName As String
    Public Property LastName As String
End Class

