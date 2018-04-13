Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http
Imports System.Web.OData.Builder
Imports System.Web.OData.Extensions

Public Module WebApiConfig
    Public Sub Register(ByVal config As HttpConfiguration)
        Dim builder As New ODataConventionModelBuilder()
        builder.EntitySet(Of Customer)("Customers")
        builder.EntitySet(Of Order)("Orders").EntityType.HasKey(Function(o) o.OrderID)

        builder.Namespace = "OrderService"

        builder.EntityType(Of Order)().Collection.Function("MostRecentOrder").Returns(Of Integer)()

        config.MapODataServiceRoute("northwind", Nothing, builder.GetEdmModel())
    End Sub
End Module
