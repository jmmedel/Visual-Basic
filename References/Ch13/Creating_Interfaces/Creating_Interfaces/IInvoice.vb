Public Interface IInvoice
    Inherits IDocument

    'New members
    Property InvoiceNumber As Integer
    Function CalculateDiscount(ByVal price As Decimal,
                               ByVal percent As Single) As Decimal

End Interface

