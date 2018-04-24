

'The Type Conversion Functions In VB.Net
'VB.Net provides the following in-line type conversion functions

'S.N  Functions & Description
'1   
'CBool(expression)

'Converts the expression To Boolean data type.

'2   
'CByte(expression)

'Converts the expression To Byte data type.

'3   
'CChar(expression)

'Converts the expression To Char data type.

'4   
'CDate(expression)

'Converts the expression To Date data type

'5   
'CDbl(expression)

'Converts the expression To Double data type.

'6   
'CDec(expression)

'Converts the expression To Decimal data type.

'7   
'CInt(expression)

'Converts the expression To Integer data type.

'8   
'CLng(expression)

'Converts the expression To Long data type.

'9   
'CObj(expression)

'Converts the expression To Object type.

'10  
'CSByte(expression)

'Converts the expression To SByte data type.

'11  
'CShort(expression)

'Converts the expression To Short data type.

'12  
'CSng(expression)

'Converts the expression To Single data type.

'13  
'CStr(expression)

'Converts the expression To String data type.

'14  
'CUInt(expression)

'Converts the expression To UInt data type.

'15  
'CULng(expression)

'Converts the expression To ULng data type.

'16  
'CUShort(expression)

'Converts the expression To UShort data type.




Module Module1

    Sub Main()
        Dim n As Integer
        Dim da As Date
        Dim bl As Boolean = True
        n = 1234567
        da = Today
        Console.WriteLine(bl)
        Console.WriteLine(CSByte(bl))
        Console.WriteLine(CStr(bl))
        Console.WriteLine(CStr(da))
        Console.WriteLine(CChar(CChar(CStr(n))))
        Console.WriteLine(CChar(CStr(da)))
        Console.ReadKey()
    End Sub

End Module
