Imports VisualDesign

Public MustInherit Class Person
    Implements IPerson

    Public Property FirstName As String Implements IPerson.FirstName
    Public Property LastName As String Implements IPerson.LastName
    Public MustOverride Function FullName() As String Implements IPerson.FullName
End Class
