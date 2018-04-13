Imports System.Collections.ObjectModel
Imports System.Data.Entity

Class MainWindow

    Private northwindEntities As NorthwindEntities
    'Requires:
    'Imports System.Collections.ObjectModel
    'Imports System.Data.Entity
    Private Function GetCustomersQuery() _
        As ObservableCollection(Of Customer)

        'Load the collection of customers
        'This include associated orders
        northwindEntities.Customers.Load()

        'Return the collection of customers
        Return northwindEntities.Customers.Local
    End Function

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs) _
        Handles MyBase.Loaded

        Me.northwindEntities = New NorthwindEntities()
        'Load data into Customers. You can modify this code as needed.
        Dim CustomersViewSource As CollectionViewSource =
            CType(Me.FindResource("CustomerViewSource"),
            CollectionViewSource)

        CustomersViewSource.Source = GetCustomersQuery()
    End Sub
End Class
