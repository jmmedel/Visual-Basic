Public Class Invoice
    Implements IInvoice

    Public Property Content As String Implements IInvoice.Content

    Public Sub Load(ByVal fileName As String) Implements IInvoice.Load

    End Sub

    Public Sub Save(ByVal fileName As String) Implements IInvoice.Save

    End Sub

    Public Property InvoiceNumber As Integer Implements IInvoice.InvoiceNumber

    Public Function CalculateDiscount(ByVal price As Decimal,
                                      ByVal percent As Single) As Decimal Implements IInvoice.CalculateDiscount

    End Function
End Class