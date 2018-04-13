Imports Microsoft.Win32

Namespace My

    Partial Friend Class MyApplication

        Public Function AssociateExtension(ByVal extension As String,
                                           ByVal mimeType As String) As Boolean
            Try
                'Creates a registry entry for the extension
                My.Computer.Registry.ClassesRoot.
                CreateSubKey(extension).SetValue("",
                mimeType, RegistryValueKind.String)

                'Creates a registry entry for the Mime type
                'Environment.GetCommandLineArgs(0) returns
                'the executable name for Console applications
                My.Computer.Registry.ClassesRoot.
                CreateSubKey(mimeType & "\shell\open\command").
                SetValue("", Environment.GetCommandLineArgs(0) & " ""%l"" ",
                RegistryValueKind.String)

                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function
    End Class
End Namespace