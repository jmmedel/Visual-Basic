Imports System.Runtime.InteropServices

Module Module1
    'Requires an
    'Imports System.Runtime.InteropServices directive
    <DllImport("shlwapi.dll", entrypoint:="PathIsURLA")>
    Function PathIsURL(ByVal path As String) As System.Int32
    End Function

    Sub Main()
        Dim testUrl As String = "http://www.visual-basic.it"
        Dim result As Integer = UsefulMethods.CheckIfPathIsUrl(testUrl)

        Try
            'Add your P/Invoke here..
        Catch ex As SEHException
            Console.WriteLine(ex.ErrorCode.ToString)
        Catch ex As Exception

        End Try
        Dim beepResult = NativeMethods.Beep(100, 100)
        If beepResult = 0 Then
            Console.WriteLine(Marshal.GetLastWin32Error())
        End If
        Console.ReadLine()
    End Sub

End Module

Friend Class NativeMethods
    <DllImport("shlwapi.dll", entrypoint:="PathIsURLA")>
    Shared Function PathIsURL(ByVal path As String) As System.Int32
    End Function

    <DllImport("kernel32.dll", entrypoint:="Beep", SetLastError:=True)>
    Public Shared Function Beep(ByVal frequency As UInteger,
                                ByVal duration As UInteger) As Integer
    End Function

    Private Sub New()

    End Sub
End Class

Public Class UsefulMethods

    Public Shared Function CheckIfPathIsUrl(ByVal path As String) _
           As Integer
        Return NativeMethods.PathIsURL(path)
    End Function

End Class