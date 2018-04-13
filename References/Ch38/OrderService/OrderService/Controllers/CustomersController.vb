Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Net
Imports System.Threading.Tasks
Imports System.Web.Http
Imports System.Web.Http.Description
Imports System.Web.OData

Namespace Controllers
    Public Class CustomersController
        Inherits ODataController

        Private db As New Northwind

        ' GET: api/Customers
        <EnableQuery> Public Async Function [Get]() As Task(Of List(Of Customer))
            Return Await db.Customers.ToListAsync
        End Function

        <EnableQuery>
        Public Function [Get](<FromODataUri> key As String) As SingleResult(Of Customer)
            Dim result = db.Customers.Where(Function(c) c.CustomerID = key)
            Return SingleResult.Create(result)
        End Function

        ' PUT: api/Customers/5
        <ResponseType(GetType(Void))> <EnableQuery>
        Async Function Put(<FromODataUri> ByVal id As String,
                           ByVal customer As Customer) As Task(Of IHttpActionResult)

            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If
            If id <> customer.CustomerID Then
                Return BadRequest()
            End If
            db.Entry(customer).State = EntityState.Modified
            Try
                Await db.SaveChangesAsync()
            Catch generatedExceptionName As DbUpdateConcurrencyException
                If Not CustomerExists(id) Then
                    Return NotFound()
                Else
                    Throw
                End If
            End Try
            Return Updated(customer)
        End Function

        <ResponseType(GetType(Void))>
        Public Async Function Patch(<FromODataUri> key As String,
                                    Customer As Delta(Of Customer)) _
                                    As Task(Of IHttpActionResult)
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If
            Dim entity = Await db.Customers.FindAsync(key)
            If entity Is Nothing Then
                Return NotFound()
            End If
            Customer.Patch(entity)
            Try
                Await db.SaveChangesAsync()
            Catch generatedExceptionName As DbUpdateConcurrencyException
                If Not CustomerExists(key) Then
                    Return NotFound()
                Else
                    Throw
                End If
            End Try
            Return Updated(entity)
        End Function

        ' POST: api/Customers
        <ResponseType(GetType(Customer))>
        Async Function Post(ByVal customer As Customer) _
              As Task(Of IHttpActionResult)
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            db.Customers.Add(customer)

            Try
                Await db.SaveChangesAsync()
            Catch ex As DbUpdateException
                If (CustomerExists(customer.CustomerID)) Then
                    Return Conflict()
                Else
                    Throw
                End If
            End Try

            Return Created(customer)
        End Function

        ' DELETE: api/Customers/5
        <ResponseType(GetType(Customer))>
        Async Function Delete(<FromODataUri> ByVal id As String) As _
            Task(Of IHttpActionResult)
            Dim customer As Customer = Await db.Customers.FindAsync(id)
            If IsNothing(customer) Then
                Return NotFound()
            End If

            db.Customers.Remove(customer)
            Await db.SaveChangesAsync()

            Return StatusCode(HttpStatusCode.NoContent)
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Function CustomerExists(ByVal id As String) As Boolean
            Return db.Customers.Any(Function(e) e.CustomerID = id)
        End Function
    End Class
End Namespace