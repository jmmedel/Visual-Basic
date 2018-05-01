


'Declaring Enumerations
'An enumerated type Is declared Using the Enum statement. The Enum statement declares an enumeration And defines the values Of its members. The Enum statement can be used at the Module, Class, Structure, procedure, Or block level.

'The syntax For the Enum statement Is As follows:

'[ < attributelist > ] [ accessmodifier ]  [ Shadows ] 
'Enum enumerationname [ As datatype ] 
'   memberlist
'End Enum
'Where,

'attributelist: refers to the list of attributes applied to the variable. Optional.

'asscessmodifier: specifies which code can access these enumerations. Optional. Values can be either Of the: Public, Protected, Friend Or Private.

'Shadows: this makes the enumeration hide a programming element Of identical name In a base Class. Optional.

'enumerationname: name of the enumeration. Required

'datatype: specifies the data type Of the enumeration And all its members.

'memberlist: specifies the list Of member constants being declared In this statement. Required.

'Each member in the memberlist has the following syntax And parts

'[< attribute list>] member name [ = initializer ]
'Where,

'name: specifies the name Of the member. Required.

'initializer: value assigned To the enumeration member. Optional.

'For example,
'    Enum Colors
'    red = 1
'    orange = 2
'    yellow = 3
'    green = 4
'    azure = 5
'    blue = 6
'    violet = 7
'End Enum


Module Module1

    Enum Colors
        red = 1
        orange = 2
        yellow = 3
        green = 4
        azure = 5
        blue = 6
        violet = 7
    End Enum
    Sub Main()
        Console.WriteLine("The Color Red is : " & Colors.red)
        Console.WriteLine("The Color Yellow is : " & Colors.yellow)
        Console.WriteLine("The Color Blue is : " & Colors.blue)
        Console.WriteLine("The Color Green is : " & Colors.green)
        Console.ReadKey()
    End Sub

End Module

'When the above code Is compiled And executed, it produces the following result:

'The Color Red Is: 1
'The Color Yellow Is: 3
'The Color Blue Is: 6
'The Color Green Is: 4
