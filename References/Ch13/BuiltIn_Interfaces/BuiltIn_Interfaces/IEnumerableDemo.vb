Public Class Contacts
    Implements IEnumerable, IEnumerator

    Public Function GetEnumerator() As System.Collections.IEnumerator _
        Implements System.Collections.IEnumerable.GetEnumerator
        Return CType(Me, IEnumerator)
    End Function

    Private position As Integer = -1

    Public ReadOnly Property Current As Object _
        Implements System.Collections.IEnumerator.Current
        Get
            Return Items(position)
        End Get
    End Property

    Public Function MoveNext() As Boolean _
        Implements System.Collections.IEnumerator.MoveNext
        position += 1
        Return (position < Items.Length)
    End Function

    Public Sub Reset() Implements System.Collections.IEnumerator.Reset
        position = -1
    End Sub

    Private Items() As Contact = New Contact() {New Contact With _
                                                {.FirstName = "Alessandro",
                                                .LastName = "Del Sole",
                                                .Email = "alessandro.delsole@visual-basic.it",
                                                .PhoneNumber = "000-0000-00"},
                                                New Contact With _
                                                {.FirstName = "Robert",
                                                .LastName = "Green",
                                                .Email = "email@something.com",
                                                .PhoneNumber = "000-0000-00"} _
                                                }

End Class

Public Class Contact

    Public Property FirstName As String
    Public Property LastName As String
    Public Property Email As String
    Public Property PhoneNumber As String

End Class
