
'VB.Net -Data Types
'Data types refer To an extensive system used For declaring variables Or functions Of different types. The type Of a variable determines how much space it occupies In storage And how the bit pattern stored Is interpreted.

'Data Types Available In VB.Net
'VB.Net provides a wide range of data types. The following table shows all the data types available:

'Data Type	Storage Allocation	Value Range
'Boolean Depends on implementing platform	True Or False
'Byte    1 byte	0 through 255 (unsigned)
'Char    2 bytes	0 through 65535 (unsigned)
'Date    8 bytes	0: 00:00 (midnight) on January 1, 0001 through 11:59:59 PM on December 31, 9999
'Decimal 16 bytes	0 through +/-79, 228, 162, 514, 264, 337, 593, 543, 950, 335(+/ -7.9...E+28) with no decimal point; 0 through +/-7.9228162514264337593543950335 with 28 places to the right of the decimal
'Double  8 bytes	
'-1.79769313486231570E+308 through -4.94065645841246544E-324, for negative values

'4.94065645841246544E-324 through 1.79769313486231570E+308, for positive values

'Integer 4 bytes	-2, 147, 483, 648 through 2, 147, 483, 647(signed)
'Long    8 bytes	-9, 223, 372, 36, 854, 775, 808 through 9, 223, 372, 36, 854, 775, 807(signed)
'Object
'4 bytes on 32-bit platform

'8 bytes on 64-bit platform

'Any type can be stored In a variable Of type Object
'SByte   1 byte	-128 through 127 (signed)
'Short   2 bytes	-32, 768 through 32, 767(signed)
'Single  4 bytes	
'-3.4028235E+38 through -1.401298E-45 for negative values;

'1.401298E-45 through 3.4028235E+38 for positive values

'String  Depends on implementing platform	0 to approximately 2 billion Unicode characters
'UInteger    4 bytes	0 through 4, 294, 967, 295(unsigned)
'ULong   8 bytes	0 through 18, 446, 744, 73, 709, 551, 615(unsigned)
'User-Defined	Depends on implementing platform	Each member of the structure has a range determined by its data type And independent of the ranges of the other members
'UShort  2 bytes	0 through 65, 535(unsigned)

Module Module1


    Sub Main()
        Dim b As Byte
        Dim n As Integer
        Dim si As Single
        Dim d As Double
        Dim da As Date
        Dim c As Char
        Dim s As String
        Dim bl As Boolean
        b = 1
        n = 1234567
        si = 0.12345678901234566
        d = 0.12345678901234566
        da = Today
        c = "U"c
        s = "Me"
        If ScriptEngine = "VB" Then
            bl = True
        Else
            bl = False
        End If
        If bl Then
            'the oath taking
            Console.Write(c & " and," & s & vbCrLf)
            Console.WriteLine("declaring on the day of: {0}", da)
            Console.WriteLine("We will learn VB.Net seriously")
            Console.WriteLine("Lets see what happens to the floating point variables:")
            Console.WriteLine("The Single: {0}, The Double: {1}", si, d)
        End If
        Console.ReadKey()
    End Sub



End Module



'When the above code Is compiled And executed, it produces the following result

'U And, Me
'declaring on the day of: 12/4/2012 12:00:00 PM
'We will learn VB.Net seriously
'Lets see what happens To the floating point variables
'The Single: 0.1234568, The Double: 0.123456789012346
