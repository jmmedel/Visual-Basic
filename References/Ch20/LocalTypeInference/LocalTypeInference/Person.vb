'Both Option Strict and Option Infer are On
Class Person
    'Local type inference does not work with
    'class level variables. An error will be
    'thrown.
    'Private completeName

    Property LastName As String
    Property FirstName As String

    Function FullName() As String
        'Local variable: local type inference works
        Dim completeName = Me.LastName & " " & Me.FirstName
        Return completeName
    End Function
End Class