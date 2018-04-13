Public Class Contact
    Inherits Person

    Public Property Title As String

    Public Overrides Property FirstName As String
        Get
            Return MyBase.FirstName
        End Get
        Set(ByVal value As String)
            MyBase.FirstName = value
        End Set
    End Property

    Public Overrides Function FullInformation() As String
        Dim firstInfo As String = MyBase.FullInformation

        Dim newInfo As New Text.StringBuilder
        newInfo.Append(firstInfo)
        newInfo.Append(" Title: ")
        newInfo.Append(Me.Title)
        Return newInfo.ToString
    End Function

    Public Sub New(ByVal name As String,
                   ByVal surName As String,
                   ByVal age As Integer,
                   ByVal title As String)

        MyBase.New(name, surName, age)
        Me.Title = title

    End Sub
End Class
