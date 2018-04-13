Imports System.Data.Entity

Partial Public Class Northwind
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=Northwind")
    End Sub

    Public Overridable Property Customers As DbSet(Of Customer)
    Public Overridable Property Orders As DbSet(Of Order)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of Customer)() _
            .Property(Function(e) e.CustomerID) _
            .IsFixedLength()

        modelBuilder.Entity(Of Order)() _
            .Property(Function(e) e.CustomerID) _
            .IsFixedLength()

        modelBuilder.Entity(Of Order)() _
            .Property(Function(e) e.Freight) _
            .HasPrecision(19, 4)
    End Sub
End Class
