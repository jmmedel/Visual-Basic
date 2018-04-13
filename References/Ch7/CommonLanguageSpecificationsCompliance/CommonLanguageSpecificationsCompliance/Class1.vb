<Assembly: CLSCompliant(True)> 

<CLSCompliant(True)> Public NotInheritable Class GzipCompress

    'Empty private constructor
    'for a class exposing only shared members
    Private Sub New()

    End Sub



    Public Shared Sub Compress(ByVal fileName As String,
                               ByVal target As String)

    End Sub

    Public Shared Sub Decompress(ByVal fileName As String,
                                 ByVal source As String)

    End Sub
End Class

'Public members of an assembly
'are pascal cased
Public Class NamingConventionsDemo

    'private fields are camel-cased
    Private documentCounter As Integer = 0

    'public properties are pascal-cased
    Public Property FirstName As String

    'public methods are pascal-cased
    'arguments are camel-cased
    Public Function CompressFile(ByVal sourceFile As String,
                                 ByVal targetFile As String) As Boolean

    End Function

    'private methods are camel-cased
    'arguments are camel-cased
    Private Sub checkForFileExistance(ByVal fileName As String)

    End Sub

End Class