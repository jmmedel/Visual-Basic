Imports System.Runtime.InteropServices

<ComVisible(True)>
Public Class COMContact

    <ComVisible(True)>
    Public Property FirstName As String
    <ComVisible(True)>
    Public Property LastName As String
    <ComVisible(True)>
    Public Property Email As String

    <ComVisible(False)>
    Public Property BirthDay As Date

    Public Sub New()

    End Sub
End Class
