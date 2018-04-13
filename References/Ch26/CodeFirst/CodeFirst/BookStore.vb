Imports System
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Linq

Public Class BookStore
    Inherits DbContext

    ' Your context has been configured to use a 'BookStore' connection string from your application's 
    ' configuration file (App.config or Web.config). By default, this connection string targets the 
    ' 'CodeFirst.BookStore' database on your LocalDb instance. 
    ' 
    ' If you wish to target a different database and/or database provider, modify the 'BookStore' 
    ' connection string in the application configuration file.
    Public Sub New()
        MyBase.New("name=BookStore")
    End Sub

    ' Add a DbSet for each entity type that you want to include in your model. For more information 
    ' on configuring and using a Code First model, see http:'go.microsoft.com/fwlink/?LinkId=390109.
    ' Public Overridable Property MyEntities() As DbSet(Of MyEntity)
    Public Property Books As DbSet(Of Book)
    Public Property Authors As DbSet(Of Author)

End Class

'Public Class MyEntity
'    Public Property Id() As Int32
'    Public Property Name() As String
'End Class
Public Class Author
    Public Property AuthorId As Integer
    Public Property FirstName As String
    Public Property LastName As String

    Public Property Books As ICollection(Of Book)
End Class

<Table("OneBook")>
Public Class Book
    'Primary key
    <Key> Public Property BookNumber As Integer

    'Forced to be mandatory,
    'minimum length is 20 characters,
    'maximum length is 150
    <Required> <MinLength(20)> <StringLength(150)>
    Public Property Title As String

    'Determine the name of the foreign key
    'for the relationship
    <ForeignKey("Books_Author")> Public Property Author As Author

    'Force the type in SQL Server to be 'char(10)'
    <Column(TypeName:="char"), StringLength(10)> Public Property ISBN As String

    'Force the type in SQL Server to be 'money'
    <Column(TypeName:="money")> Public Property Price As Decimal
End Class
