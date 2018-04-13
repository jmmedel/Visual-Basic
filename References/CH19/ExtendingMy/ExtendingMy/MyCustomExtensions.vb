Imports System.Collections.ObjectModel

Namespace My

    <Global.Microsoft.VisualBasic.HideModuleName(),
     Global.System.Diagnostics.DebuggerNonUserCode()>
    Module MyCollectionsUtils

        Private helper As New  _
                ThreadSafeObjectProvider(Of ObservableCollectionHelper)

        Friend ReadOnly Property CollectionsUtils _
               As ObservableCollectionHelper
            Get
                Return helper.GetInstance
                helper = Nothing
            End Get
        End Property
    End Module

End Namespace

Class ObservableCollectionHelper

    Public Function ConvertToObservableCollection(Of T) _
                           (ByVal collection As ICollection(Of T)) _
                           As ObservableCollection(Of T)
        Return New ObservableCollection(Of T)(collection)
    End Function
End Class
