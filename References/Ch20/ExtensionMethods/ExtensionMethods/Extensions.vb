Imports System.Runtime.CompilerServices
Imports System.Collections.ObjectModel
Imports System.Text.RegularExpressions

<Extension()> Public Module Extensions

    <Extension()> Public Function ToObservableCollection(Of T) _
                           (ByVal List As IEnumerable(Of T)) _
                           As ObservableCollection(Of T)
        Try
            Return New ObservableCollection(Of T)(List)
        Catch ex As Exception
            Throw
        End Try
    End Function

    <Extension()> Public Function IsValidEMail(ByVal EMailAddress As String) _
                  As Boolean
        Dim validateMail As String = _
        "^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.)" & _
        "|(([\w-]+\.)+))([a-zA-z]{2,4}|[0-9]{1,3})(\]?)$"

        Return Regex.IsMatch(EMailAddress, _
                              validateMail)

    End Function
End Module

Public NotInheritable Class MyCustomExtensions

    Private Sub New()

    End Sub
End Class