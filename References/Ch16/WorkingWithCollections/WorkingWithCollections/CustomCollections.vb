Imports System.IO
Imports System.Collections.ObjectModel
Imports System.Text



Public Class FileInfoCollection
    Inherits List(Of FileInfo)


    Public Overridable Function ToObservableCollection() As ObservableCollection(Of FileInfo)
        Return New ObservableCollection(Of FileInfo)(Me)
    End Function

    Public Overrides Function ToString() As String
        Dim content As New StringBuilder

        For Each item As FileInfo In Me
            content.Append(item.Name)
        Next
        Return content.ToString
    End Function
End Class