Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Net
Imports System.Net.Http
Imports System.Threading.Tasks
Imports System.Web.Http
Imports System.Web.Http.Description
Imports System.Web.Http.Routing
Imports System.Web.OData
Imports System.Web.OData.Extensions
Imports System.Web.OData.Query
Imports System.Web.OData.Routing
Imports Microsoft.OData.Core
Imports Microsoft.OData.Core.UriParser

Namespace Controllers
    Public Class OrdersController
        Inherits ODataController

        Private db As New Northwind

        ' GET: api/Orders
        <EnableQuery> Public Async Function [Get]() As Task(Of List(Of Order))
            Return Await db.Orders.ToListAsync
        End Function

        ' GET: api/Orders/5
        <EnableQuery>
        Public Function [Get](<FromODataUri> key As Integer) As SingleResult(Of Order)
            Dim result = db.Orders.Where(Function(o) o.OrderID = key)
            Return SingleResult.Create(result)
        End Function

        ' PUT: api/Orders/5
        <ResponseType(GetType(Void))>
        Async Function Put(<FromODataUri> ByVal id As Integer, ByVal order As Order) As Task(Of IHttpActionResult)
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            If Not id = order.OrderID Then
                Return BadRequest()
            End If

            db.Entry(order).State = EntityState.Modified

            Try
                Await db.SaveChangesAsync()
            Catch ex As DbUpdateConcurrencyException
                If Not (OrderExists(id)) Then
                    Return NotFound()
                Else
                    Throw
                End If
            End Try

            Return Updated(order)
        End Function

        <ResponseType(GetType(Void))>
        Public Async Function Patch(<FromODataUri> key As Integer,
                                    order As Delta(Of Order)) _
                                    As Task(Of IHttpActionResult)
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If
            Dim entity = Await db.Orders.FindAsync(key)
            If entity Is Nothing Then
                Return NotFound()
            End If
            order.Patch(entity)
            Try
                Await db.SaveChangesAsync()
            Catch generatedExceptionName As DbUpdateConcurrencyException
                If Not OrderExists(key) Then
                    Return NotFound()
                Else
                    Throw
                End If
            End Try
            Return Updated(entity)
        End Function

        ' POST: api/Orders
        <ResponseType(GetType(Order))>
        Async Function Post(ByVal order As Order) _
              As Task(Of IHttpActionResult)
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            db.Orders.Add(order)
            Try
                Await db.SaveChangesAsync()
            Catch ex As DbUpdateException
                If (OrderExists(order.OrderID)) Then
                    Return Conflict()
                Else
                    Throw
                End If
            End Try

            Return Created(order)
        End Function

        ' DELETE: api/Orders/5
        <ResponseType(GetType(Order))>
        Async Function Delete(<FromODataUri> ByVal id As Integer) _
            As Task(Of IHttpActionResult)
            Dim order As Order = Await db.Orders.FindAsync(id)
            If IsNothing(order) Then
                Return NotFound()
            End If

            db.Orders.Remove(order)
            Await db.SaveChangesAsync()

            Return StatusCode(HttpStatusCode.NoContent)
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Function OrderExists(ByVal id As Integer) As Boolean
            Return db.Orders.Count(Function(e) e.OrderID = id) > 0
        End Function

        <AcceptVerbs("POST", "PUT")>
        Public Async Function CreateRef(<FromODataUri> key As Integer, navigationProperty As String,
                                        <FromBody> link As Uri) As Task(Of IHttpActionResult)
            'Get the instance of an order
            Dim order = Await db.Orders.
                SingleOrDefaultAsync(Function(o) o.OrderID = key)

            'If null, return Not Found
            If order Is Nothing Then
                Return NotFound()
            End If

            'Find the navigation property
            Select Case navigationProperty
                'If Customer...
                Case "Customer"
                    'Get the value of related Customer's CustomerID
                    Dim relatedKey = GetKeyFromUri(Of String)(Request, link)
                    'Get the Customer instance based on the CustomerID
                    Dim customer = Await db.Customers.
                        SingleOrDefaultAsync(Function(c) c.CustomerID = relatedKey)
                    If customer Is Nothing Then
                        Return NotFound()
                    End If

                    'Assign the customer instance to the Order.Customer property
                    'This establishes a relationship
                    order.Customer = customer
                    Exit Select
                Case Else

                    Return StatusCode(HttpStatusCode.NotImplemented)
            End Select
            Await db.SaveChangesAsync()
            Return StatusCode(HttpStatusCode.NoContent)
        End Function


        Public Shared Function GetKeyFromUri(Of TKey)(request As HttpRequestMessage,
                                                      uri As Uri) As TKey
            If uri Is Nothing Then
                Throw New ArgumentNullException("uri")
            End If

            Dim urlHelper = If(request.GetUrlHelper(),
                New UrlHelper(request))

            Dim serviceRoot As String = urlHelper.
                CreateODataLink(request.ODataProperties().RouteName,
                                request.ODataProperties().PathHandler,
                New List(Of ODataPathSegment)())
            Dim odataPath = request.ODataProperties().
                PathHandler.Parse(request.ODataProperties().Model,
                                  serviceRoot, uri.LocalPath)

            Dim keySegment = odataPath.Segments.
                OfType(Of KeyValuePathSegment)().FirstOrDefault()
            If keySegment Is Nothing Then
                Throw New InvalidOperationException("The link does not contain a key.")
            End If

            Dim value = ODataUriUtils.
                ConvertFromUriLiteral(keySegment.Value, ODataVersion.V4)
            Return value
        End Function

        <HttpGet> <EnableQuery>
        Public Function MostRecentOrder() As IHttpActionResult
            Dim maxDate = db.Orders.Max(Function(o) o.OrderDate)
            Dim query = db.Orders.Where(Function(o) o.OrderDate = maxDate).FirstOrDefault.OrderID

            Return Ok(query)
        End Function
    End Class
End Namespace