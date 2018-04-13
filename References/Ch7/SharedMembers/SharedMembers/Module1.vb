Module Module1

    Sub Main()

        CompressionHelper.Compress("Sourcefile.txt", "Compressedfile.gz")

        CompressionHelper.Decompress("Compressedfile.gz", "Sourcefile.txt")

    End Sub

End Module

Public Class Document

    Private Shared _documentCounter As Integer

    Public Property Text As String

    Public Shared Property DocumentCounter2 As Integer

    Public Shared ReadOnly Property DocumentCounter As Integer
        Get
            Return _documentCounter
        End Get
    End Property

    Public Sub New()
        _documentCounter += 1
    End Sub
End Class

Public Class CompressionHelper

    'Instance member
    Private Shared instanceField As Integer

    Public Shared Sub Compress(ByVal fileName As String,
                               ByVal target As String)
        'Code for compressing files here
    End Sub

    Public Shared Sub Decompress(ByVal fileName As String,
                                 ByVal uncompressed As String)
        'Code for decompressing files here
    End Sub

    'Cannot refer to an instance member
    Public Shared Function testSharedInstance() As Integer
        Return instanceField
    End Function

    Public Shared Function testSharedInstance(ByVal val As Integer) As Integer
        Return instanceField + val
    End Function


    Shared Sub New()
        'Initialization of shared
        'members
        instanceField = 10
    End Sub

    Sub New()

    End Sub
End Class
