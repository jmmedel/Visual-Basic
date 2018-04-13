'Attribute is not inherited
<AttributeUsage(AttributeTargets.Class Or AttributeTargets.Property, AllowMultiple:=True)>
Public Class DocumentPropertiesAttribute
    Inherits Attribute

    'Attributes can be inherited
    'therefore private fields are Protected
    Protected _author As String
    Protected _reviewer As String
    Protected _LastEdit As String
    Protected _metaData As Object
    Public Overridable ReadOnly Property Author As String
        Get
            Return Me._author
        End Get
    End Property

    Public Overridable ReadOnly Property Reviewer As String
        Get
            Return Me._reviewer
        End Get
    End Property

    Public Overridable Property LastEdit As String
        Get
            Return Me._LastEdit
        End Get
        Set(value As String)
            Me._LastEdit = value
        End Set
    End Property

    Public Overridable Property Metadata As Object
        Get
            Return Me._metaData
        End Get
        Set(value As Object)
            Me._metaData = value
        End Set
    End Property

    Public Sub New(ByVal author As String, ByVal reviewer As String, metaData As Object)
        Me._author = author
        Me._reviewer = reviewer
        Me._LastEdit = CStr(Date.Today)
        Me._metaData = metaData
    End Sub
End Class

