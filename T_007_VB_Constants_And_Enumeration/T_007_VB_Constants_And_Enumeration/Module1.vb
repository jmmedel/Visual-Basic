
'The constants refer To fixed values that the program may Not alter during its execution. These fixed values are also called literals.

'Constants can be Of any Of the basic data types Like an Integer constant, a floating constant, a character constant, Or a String literal. There are also enumeration constants As well.

'The constants are treated just Like regular variables except that their values cannot be modified after their definition.

'An enumeration Is a Set Of named Integer constants.

'Declaring Constants
'In VB.Net, constants are declared using the Const statement. The Const statement Is used at module, class, structure, procedure, Or block level for use in place of literal values.

'The syntax For the Const statement Is:

'[ < attributelist> ] [ accessmodifier ] [ Shadows ] 
'Const constantlist

'Where,

'attributelist: specifies the list Of attributes applied To the constants; you can provide multiple attributes separated by commas. Optional.

'accessmodifier: specifies which code can access these constants. Optional. Values can be either Of the: Public, Protected, Friend, Protected Friend, Or Private.

'Shadows: this makes the constant hide a programming element Of identical name In a base Class. Optional.

'Constantlist: gives the list Of names Of constants declared. Required.

'Where, each constant name has the following syntax And parts

'constantname [ As datatype ] = initializer
'constantname: specifies the name Of the constant

'datatype: specifies the data type Of the constant

'initializer: specifies the value assigned To the constant

'For example,

''The following statements declare constants.'
'Const maxval As Long = 4999
'Public Const message As String = "HELLO"
'Private Const piValue As Double = 3.1415
'Example
'The following example demonstrates declaration And use Of a constant value




Module Module1

    Sub Main()
        Const PI = 3.14149
        Dim radius, area As Single
        radius = 7
        area = PI * radius * radius
        Console.WriteLine("Area = " & Str(area))
        Console.ReadKey()
    End Sub

End Module


'When the above code Is compiled And executed, it produces the following result

'Area = 153.933
'Print And Display Constants in VB.Net
'VB.Net provides the following print And display constants:

'Constant	Description
'vbCrLf	Carriage Return/linefeed character combination.
'vbCr	Carriage Return character.
'vbLf	Linefeed character.
'vbNewLine	Newline character.
'vbNullChar	Null character.
'vbNullString    Not the same as a zero-length string (""); used for calling external procedures.
'vbObjectError   Error number. User-defined error numbers should be greater than this value. For example 
'Err.Raise(Number) = vbObjectError + 1000
'vbTab	Tab character.
'vbBack	Backspace character.

