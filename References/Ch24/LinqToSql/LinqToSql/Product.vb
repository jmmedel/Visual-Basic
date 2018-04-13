Public Class Product

    Private Sub OnQuantityPerUnitChanging(ByVal value As String)
        If value.Length > 20 Then Throw New  _
            ArgumentException("Quantity per unit must be no longer than 20 characters")
    End Sub

End Class
