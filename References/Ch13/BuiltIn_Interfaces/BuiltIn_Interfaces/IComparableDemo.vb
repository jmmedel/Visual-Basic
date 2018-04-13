Public Class Person2
    Implements IComparable

    Public Property FirstName As String
    Public Property LastName As String
    Public Property Email As String


    Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
        If Not TypeOf (obj) Is Person2 Then
            Throw New ArgumentException
        Else

            Dim tempPerson As Person2 = DirectCast(obj, Person2)

            If Me.LastName.Length < tempPerson.LastName.Length Then
                Return -1
            ElseIf Me.LastName.Length = tempPerson.LastName.Length Then
                Return 0
            Else
                Return 1
            End If

        End If
    End Function
End Class

Public Class Person3
    Implements IComparable(Of Person3)

    Public Property FirstName As String
    Public Property LastName As String
    Public Property Email As String

    Public Function CompareTo(ByVal other As Person3) As Integer Implements System.IComparable(Of Person3).CompareTo
        If Me.LastName.Length < other.LastName.Length Then
            Return -1
        ElseIf Me.LastName.Length = other.LastName.Length Then
            Return 0
        Else
            Return 1
        End If
    End Function
End Class

