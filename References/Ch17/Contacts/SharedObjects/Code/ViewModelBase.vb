'Generic View Model
Imports System.ComponentModel
Public MustInherit Class ViewModelBase
    Implements INotifyPropertyChanged

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    'Raise a property change notification
    Protected Overridable Sub OnPropertyChanged(propname As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propname))
    End Sub
End Class