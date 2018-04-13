Imports Microsoft.Win32

Namespace My
    Partial Friend Class MyComputer

        Public ReadOnly Property MimeType(ByVal fileName As String) As String
            Get
                Return getMimeType(fileName)
            End Get
        End Property

        Private Function getMimeType(ByVal fileName As String) As String

            Dim mimeType As String = String.Empty

            Dim fileExtension = System.IO.Path.
                                GetExtension(fileName).ToLower()
            Dim registryKey = Registry.ClassesRoot.
                              OpenSubKey(fileExtension)

            If registryKey IsNot Nothing And _
                           registryKey.GetValue("Content Type") _
                           IsNot Nothing Then

                mimeType = registryKey.
                           GetValue("Content Type").ToString
            Else
                mimeType = ""
            End If
            Return mimeType
        End Function

    End Class
End Namespace

Namespace My.Resources
    Friend Module MyResources
        'Your code here
    End Module
End Namespace

