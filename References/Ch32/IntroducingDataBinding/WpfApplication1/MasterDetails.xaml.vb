Imports System.Collections.ObjectModel
Imports System.Data.Entity

Public Class MasterDetails
    Private northwindEntities As NorthwindEntities
    Private CustomerViewSource As CollectionViewSource
    Private CustomerOrdersViewSource As CollectionViewSource
    Private WithEvents CustomerView As ListCollectionView
    Private CustomerOrdersView As ListCollectionView

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs) _
        Handles MyBase.Loaded

        Me.northwindEntities = New NorthwindEntities

        CustomerViewSource = CType(Me.FindResource("CustomerViewSource"),
            CollectionViewSource)

        CustomerOrdersViewSource = CType(Me.FindResource("CustomerOrdersViewSource"),
            CollectionViewSource)

        CustomerViewSource.Source = GetCustomersQuery()

        Me.CustomerView = CType(Me.CustomerViewSource.View,
         ListCollectionView)
        Me.CustomerOrdersView = CType(Me.CustomerOrdersViewSource.View,
         ListCollectionView)
    End Sub
    Private Function GetCustomersQuery() _
        As ObservableCollection(Of Customer)

        'Load the collection of customers
        'This include associated orders
        northwindEntities.Customers.Load()

        'Return the collection of customers
        Return northwindEntities.Customers.Local
    End Function

    Private Sub SaveButton_Click(sender As Object, e As RoutedEventArgs)
        'Handle your logic here, such as exceptions
        'and optimistic concurrency
        Try
            Me.northwindEntities.SaveChanges()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub AddButton_Click(sender As Object, e As RoutedEventArgs)
        'A new order
        Dim newOrder As Order

        'Adds a new order to the view and assigns the instance
        'to the newly declared order
        newOrder = CType(Me.CustomerOrdersView.AddNew(), Order)

        'If I need to assign properties to newOrder before
        'it is sent to the collection, then this is the place

        'Sends the new order to the view
        Me.CustomerOrdersView.CommitNew()

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As RoutedEventArgs)
        If Me.CustomerOrdersView.CurrentPosition > -1 Then

            Dim result = MessageBox.Show("Are you sure?",
                "", MessageBoxButton.YesNo)
            If result = MessageBoxResult.Yes Then
                Me.CustomerOrdersView.
         RemoveAt(Me.CustomerOrdersView.CurrentPosition)
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As RoutedEventArgs)
        If Me.CustomerOrdersViewSource.View.CurrentPosition > 0 Then
            Me.CustomerOrdersViewSource.View.MoveCurrentToPrevious()
        End If
    End Sub

    Private Sub NextButton_Click(sender As Object, e As RoutedEventArgs)
        If Me.CustomerOrdersViewSource.View.CurrentPosition <
           CType(Me.CustomerOrdersViewSource.View, CollectionView).
           Count - 1 Then
            Me.CustomerOrdersViewSource.View.MoveCurrentToNext()
        End If

    End Sub

    Private Sub CustomerView_CurrentChanged(sender As Object, e As EventArgs) Handles CustomerView.CurrentChanged
        Me.CustomerOrdersView = CType(Me.CustomerOrdersViewSource.View,
                                      ListCollectionView)
    End Sub
End Class
