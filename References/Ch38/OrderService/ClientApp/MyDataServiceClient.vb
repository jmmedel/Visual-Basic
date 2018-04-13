Imports System.Net
Imports Microsoft.OData.Client
Imports Microsoft.OData.Edm

Public Class MyDataServiceClient
    Inherits DataServiceContext

    Private Shared model As IEdmModel = Nothing

    Public Sub New(serviceRoot As Uri)
        MyBase.New(serviceRoot)
        Me.Format.LoadServiceModel = AddressOf Me.LoadServiceModel
        Me.Format.UseJson()
    End Sub

    Private Function LoadServiceModel() As IEdmModel
        'If no model exists in memory
        If model Is Nothing Then
            'Get the service metadata's Uri
            'e.g. http://localhost:18470/$metadata
            Dim metadataUri = Me.GetMetadataUri()

            'Create an HTTP request to the metadata's Uri
            'in order to get a representation for the data model
            Dim request = WebRequest.CreateHttp(metadataUri)

            'Wait for a response
            Using response = request.GetResponse()
                'Translate the response into an in-memory stream
                Using stream = response.GetResponseStream()
                    'Convert the stream into an XML representation
                    Using reader = System.Xml.XmlReader.Create(stream)
                        'Parse the XML representation of the data model
                        'into an Entity Data Model that can be utilized
                        'by OData client libraries
                        model = Csdl.EdmxReader.Parse(reader)
                    End Using
                End Using
            End Using
        End If

        Return model
    End Function

    'data queries
    Public ReadOnly Property Customers As DataServiceQuery(Of Customer)
        Get
            Return CreateQuery(Of Customer)("Customers").
                Expand("Orders")
        End Get
    End Property

    Public ReadOnly Property Orders As DataServiceQuery(Of Order)
        Get
            Return CreateQuery(Of Order)("Orders")
        End Get
    End Property

    Public ReadOnly Property MostRecentOrder As Integer
        Get
            Dim query As Integer = Execute(Of Integer)(New Uri("/Orders/OrderService.MostRecentOrder",
                                                               UriKind.Relative)).FirstOrDefault
            Return query
        End Get
    End Property
End Class
