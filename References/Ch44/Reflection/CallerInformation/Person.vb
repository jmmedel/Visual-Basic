Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class Person
    Implements INotifyPropertyChanged

    Private _fullName As String
    Public Property FullName As String
        Get
            Return _fullName
        End Get
        Set(value As String)
            Me._fullName = value
            NotifyChange(_fullName, value)
        End Set
    End Property

    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) _
      Implements INotifyPropertyChanged.PropertyChanged

    Private Sub NotifyChange(Of T As IEquatable(Of T))(
                                                      ByRef v1 As T, v2 As T,
                                                      <CallerMemberName()>
                                                      Optional prop As String = Nothing)
        If v1 IsNot Nothing AndAlso v1.Equals(v2) Then Return
        If v1 Is Nothing AndAlso v2 Is Nothing Then Return
        v1 = v2
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(prop))
    End Sub
End Class