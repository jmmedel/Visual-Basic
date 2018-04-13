Option Strict On
Module Generics

    Sub Main()

        Dim integerCollection As New CustomType(Of Integer)(2)
        integerCollection.Add(0)
        integerCollection.Add(1)
        'Writes 1
        'Console.WriteLine(integerCollection(1).ToString)

        Dim arr1() As Integer = {1, 2, 3}
        Dim arr2() As Integer = {4, 5, 6}
        integerCollection.Swap(Of Integer)(arr1, arr2)

        'Demonstrates that arr2 now
        'contains values previously
        'stored in arr1
        'For Each item In arr2
        '    Console.WriteLine(item)
        'Next

        Dim onePerson As New Person
        onePerson.FirstName = "Alessandro"
        onePerson.LastName = "Del Sole"

        Dim secondPerson As New Person
        secondPerson.FirstName = "Robert"
        secondPerson.LastName = "White"

        Dim personCollection As New CustomType(Of Person)(2)
        personCollection.Add(onePerson)
        personCollection.Add(secondPerson)

        'Returns 2
        Console.WriteLine("How many people are there?")
        Console.WriteLine("The answer is {0}", personCollection.Count)
        'NullableDemo()

        Console.ReadLine()
    End Sub

End Module

Public Class CustomType(Of T)

    Private items() As T

    Public Sub New(ByVal upperBound As Integer)
        ReDim items(upperBound - 1)
    End Sub

    Private _count As Integer = 0
    'Cannot provide auto-implemented properties when read-only
    Public ReadOnly Property Count As Integer
        Get
            Return _count
        End Get
    End Property

    Public Sub Add(ByVal newItem As T)
        If newItem IsNot Nothing Then
            Me.items(Me._count) = newItem
            Me._count += 1
        End If
    End Sub

    Default Public ReadOnly Property Item(ByVal index As Integer) As T
        Get
            If index < 0 OrElse index >= Me.
               Count Then Throw New IndexOutOfRangeException
            Return items(index)
        End Get
    End Property

    'Array are passed by reference in this case
    Public Sub Swap(Of T1)(ByRef array1() As T1, ByRef array2() As T1)
        Dim temp() As T1
        temp = array1
        array1 = array2
        array2 = temp
    End Sub

End Class

'UNCOMMENT THE FOLLOWING CLASS DEFINITION IF YOU WANT TO TEST
'GENERICS CONSTRAINTS. ENSURE TO COMMENT THE PREVIOUS CUSTOMTYPE(OF T) DEFINITION
'IN ORDER TO LET THE CODE WORK

'Public Class CustomType(Of T As {Class, ICloneable, New})

'    Public Sub TestConstraint()
'        Dim newObj As New T
'        Dim clonedObj As Object = newObj.Clone()
'    End Sub

'    Public Sub TestInstance()
'        Dim instance As New T
'    End Sub

'    Private items() As T

'    Public Sub New(ByVal upperBound As Integer)
'        ReDim items(upperBound - 1)
'    End Sub

'    Private _count As Integer = 0

'    Public ReadOnly Property Count As Integer
'        Get
'            Return _count
'        End Get
'    End Property

'    Public Sub Add(ByVal newItem As T)
'        If newItem IsNot Nothing Then
'            Me.items(Me._count) = newItem
'            Me._count += 1
'        End If
'    End Sub

'    Default Public ReadOnly Property Item(ByVal index As Integer) As T
'        Get
'            If index < 0 OrElse index >= Me.
'               Count Then Throw New IndexOutOfRangeException
'            Return items(index)
'        End Get
'    End Property

'    'Array are passed by reference in this case
'    Public Sub Swap(Of T)(ByRef array1() As T, ByRef array2() As T)
'        Dim temp() As T
'        temp = array1
'        array1 = array2
'        array2 = temp
'    End Sub

'    Public Function CompareItems(Of T As IComparable)(ByVal sourceArray() As T,
'                                                      ByVal index1 As Integer,
'                                                      ByVal index2 As Integer) As Integer

'        Dim result As Integer = sourceArray(index1).CompareTo(sourceArray(index2))

'        Return result
'    End Function
'End Class

Class CustomType

End Class

Class CustomType(Of TKey, TValue)

    Sub DoSomething(Of T1, T2)(ByVal argument1 As T1, ByVal argument2 As T2)

    End Sub

    Sub DoSomething(Of T)(ByVal argument As T)

    End Sub

End Class
