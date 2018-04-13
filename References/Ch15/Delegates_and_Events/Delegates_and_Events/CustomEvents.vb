Public Class Person
    Private _firstName As String
    Public Property FirstName As String

        Get
            Return _firstName
        End Get
        Set(ByVal value As String)
            If value <> _firstName Then
                _firstName = value
                RaiseEvent FirstNameChanged(FirstName)
            End If
        End Set
    End Property

    Private _lastName As String
    Public Property LastName As String

        Get
            Return _lastName
        End Get
        Set(ByVal value As String)
            If value <> _lastName Then
                _lastName = value
                RaiseEvent LastNameChanged(Me, EventArgs.Empty)
            End If
        End Set
    End Property

    Public Event LastNameChanged(ByVal sender As Object,
                                 ByVal e As EventArgs)


    Public Delegate Sub FirstNameChangedHandler(ByVal info As String)

    Dim handlersList As New List(Of FirstNameChangedHandler)

    Public Custom Event FirstNameChanged As FirstNameChangedHandler
        AddHandler(ByVal value As FirstNameChangedHandler)
            handlersList.Add(value)
            Debug.WriteLine("AddHandler invoked")
        End AddHandler

        RemoveHandler(ByVal value As FirstNameChangedHandler)
            If handlersList.Contains(value) Then
                handlersList.Remove(value)
                Debug.WriteLine("RemoveHandler invoked")
            End If
        End RemoveHandler

        RaiseEvent(ByVal info As String)
            'Performs the same action on all instances
            'of the Person class
            For Each del As FirstNameChangedHandler In handlersList
                'del.Invoke(info ......
            Next
        End RaiseEvent
    End Event

End Class