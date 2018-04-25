
'VB.Net -BitArray
'    The BitArray Class manages a compact array Of bit values, which are represented As Booleans, where True indicates that the bit Is On (1) And False indicates the bit Is off (0).

'It Is used When you need To store the bits but Do Not know the number Of bits In advance. You can access items from the BitArray collection by Using an Integer index, which starts from zero.

'Properties And Methods of the BitArray Class
'The following table lists some Of the commonly used properties Of the BitArray Class

'Property Description
'Count	Gets the number Of elements contained In the BitArray.
'IsReadOnly	Gets a value indicating whether the BitArray Is read-only.
'Item	Gets Or sets the value Of the bit at a specific position In the BitArray.
'Length	Gets Or sets the number Of elements In the BitArray.
'The following table lists some Of the commonly used methods Of the BitArray Class

'S.N  Method Name & Purpose
'1   
'Public Function And(value As BitArray) As BitArray

'    Performs the bitwise And operation on the elements in the current BitArray against the corresponding elements in the specified BitArray.

'2   
'Public Function Get(index As Integer) As Boolean

'    Gets the value of the bit at a specific position in the BitArray.

'3   
'Public Function Not() As BitArray

'    Inverts all the bit values In the current BitArray, so that elements Set To True are changed To False, And elements set to false are changed to true.

'4   
'Public Function Or(value As BitArray) As BitArray

'    Performs the bitwise Or operation on the elements in the current BitArray against the corresponding elements in the specified BitArray.

'5   
'Public Sub Set(index As Integer, value As Boolean)

'    Sets the bit at a specific position in the BitArray to the specified value.

'6   
'Public Sub SetAll(value As Boolean)

'    Sets all bits in the BitArray to the specified value.

'7   
'Public Function Xor(value As BitArray) As BitArray

'    Performs the bitwise eXclusive Or operation on the elements in the current BitArray against the corresponding elements in the specified BitArray.

'Example:
'    The following example demonstrates the use of BitArray class:



Module Module1

    Sub Main()
        'creating two  bit arrays of size 8
        Dim ba1 As BitArray = New BitArray(8)
        Dim ba2 As BitArray = New BitArray(8)
        Dim a() As Byte = {60}
        Dim b() As Byte = {13}
        'storing the values 60, and 13 into the bit arrays
        ba1 = New BitArray(a)
        ba2 = New BitArray(b)
        'content of ba1
        Console.WriteLine("Bit array ba1: 60")
        Dim i As Integer
        For i = 0 To ba1.Count
            Console.Write("{0 } ", ba1(i))
        Next i
        Console.WriteLine()
        'content of ba2
        Console.WriteLine("Bit array ba2: 13")
        For i = 0 To ba2.Count
            Console.Write("{0 } ", ba2(i))
        Next i
        Console.WriteLine()
        Dim ba3 As BitArray = New BitArray(8)
        ba3 = ba1.And(ba2)
        'content of ba3
        Console.WriteLine("Bit array ba3 after AND operation: 12")
        For i = 0 To ba3.Count
            Console.Write("{0 } ", ba3(i))
        Next i
        Console.WriteLine()
        ba3 = ba1.Or(ba2)
        'content of ba3
        Console.WriteLine("Bit array ba3 after OR operation: 61")
        For i = 0 To ba3.Count
            Console.Write("{0 } ", ba3(i))
        Next i
        Console.WriteLine()
        Console.ReadKey()
    End Sub

End Module


'When the above code Is compiled And executed, it produces the following result:

'Bit array ba1: 60 
'False False True True True True False False 
'Bit array ba2: 13
'True False True True False False False False 
'Bit array ba3 after And operation: 12
'False False True True False False False False 
'Bit array ba3 after Or operation: 61
'True False True True False False False False 
