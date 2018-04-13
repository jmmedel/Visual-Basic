<DocumentProperties("Alessandro Del Sole",
                    "Robert White",
                    CObj("Good version!"), LastEdit:="12/31/2014")>
Public Class Document

    Public Property Text As String

    Public ReadOnly Property Length As Integer
        Get
            Return Text.Length
        End Get
    End Property

    <DocumentProperties("Alessandro Del Sole",
                        "Stephen Green", CObj("Good review!"))>
    Public Property DocumentName As String

    Public Sub SaveDocument(ByVal fileName As String)
        '...
    End Sub

    Public Sub LoadDocument(ByVal filneName As String)
        '...
    End Sub
End Class
