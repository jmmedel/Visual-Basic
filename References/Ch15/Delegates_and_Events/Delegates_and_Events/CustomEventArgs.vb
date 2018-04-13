Public Class LastNameChangedEventArgs
    Inherits EventArgs

    Private _lastName As String
    Public ReadOnly Property LastName As String
        Get
            Return _lastName
        End Get
    End Property

    Public ReadOnly Property ContainsBlank As Boolean
        Get
            Return Me.LastName.Contains(" ")
        End Get
    End Property

    Public Sub New(ByVal lastName As String)
        Me._lastName = lastName
    End Sub
End Class

Public Class Person2
    Private _lastName As String
    Public Property LastName As String

        Get
            Return _lastName
        End Get
        Set(ByVal value As String)
            If value <> _lastName Then
                _lastName = value
                Dim e As New LastNameChangedEventArgs(value)
                RaiseEvent LastNameChanged(Me, e)
            End If
        End Set
    End Property

    Public Event LastNameChanged(ByVal sender As Object,
                                 ByVal e As LastNameChangedEventArgs)

End Class