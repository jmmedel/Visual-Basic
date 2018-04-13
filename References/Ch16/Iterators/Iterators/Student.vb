Module Demo
    Sub Demo()
        Dim bottles As New BottlesOfWine
        bottles.AddRedBottle("Chianti")
        bottles.AddRedBottle("Cabernet")

        'Result is returned via an iterator function
        For Each bottle As BottleOfWine In bottles
            Console.WriteLine(bottle.Brand)
        Next

        Console.Read()
    End Sub
End Module

Public Class BottleOfWine
    Property Brand As String
    Property Color As WineColor
End Class

Public Enum WineColor
    Red
    White
End Enum

'Implementing an Iterator class
Public Class BottlesOfWine
    Implements IEnumerable(Of BottleOfWine)

    Private _bottles As New List(Of BottleOfWine)

    Public Function GetEnumerator1() As IEnumerator Implements IEnumerable.GetEnumerator
        Return Me._bottles.GetEnumerator
    End Function

    Public Iterator Function GetEnumerator() As IEnumerator(Of BottleOfWine) Implements _
        IEnumerable(Of BottleOfWine).GetEnumerator

        'Use Yield instead of List.GetEnumerator
        For Each bottle As BottleOfWine In Me._bottles
            Yield bottle
        Next
    End Function

    Private Iterator Function BottlesByColor(ByVal color As WineColor) As IEnumerable(Of BottleOfWine)
        For Each bottle As BottleOfWine In Me._bottles
            If bottle.Color = color Then
                Yield bottle
            End If
        Next
    End Function

    Public ReadOnly Property RedBottles As IEnumerable(Of BottleOfWine)
        Get
            Return BottlesByColor(WineColor.Red)
        End Get
    End Property

    Public ReadOnly Property WhiteBottles As IEnumerable(Of BottleOfWine)
        Get
            Return BottlesByColor(WineColor.White)
        End Get
    End Property

    Public Sub AddRedBottle(ByVal name As String)
        Me._bottles.Add(New BottleOfWine With {.Brand = name, .Color = WineColor.Red})
    End Sub

    Public Sub AddWhiteBottle(ByVal name As String)
        Me._bottles.Add(New BottleOfWine With {.Brand = name, .Color = WineColor.White})
    End Sub
End Class


