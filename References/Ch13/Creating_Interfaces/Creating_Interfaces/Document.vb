Public Class Document
    Implements IDocument

    Public Property Content As String Implements IDocument.Content

    Public Property VersionNumber As Version Implements IDocument.VersionNumber
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Version)
            Throw New NotImplementedException()
        End Set
    End Property

    'Gets the content of a text document
    Public Sub Load(ByVal fileName As String) Implements IDocument.Load
        Try
            Content = My.Computer.FileSystem.ReadAllText(fileName)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    'Saves a text document to file
    Public Sub Save(ByVal fileName As String) Implements IDocument.Save
        Try
            My.Computer.FileSystem.WriteAllText(fileName,
                                                Content, False)
        Catch ex As Exception
            Throw
        End Try
    End Sub
End Class
