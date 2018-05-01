

'VB.Net -Classes & Objects
'    When you define a class, you define a blueprint for a data type. This doesn't actually define any data, but it does define what the class name means, that is, what an object of the class will consist of and what operations can be performed on such an object.

'Objects are instances Of a Class. The methods And variables that constitute a Class are called members Of the Class.

'Class Definition
'A Class definition starts With the keyword Class followed by the Class name; And the Class body, ended by the End Class statement. Following Is the general form Of a Class definition:

'[ <attributelist> ] [ accessmodifier ] [ Shadows ] [ MustInherit | NotInheritable ] [ Partial ] _
'Class name [ ( Of typelist ) ]
'    [ Inherits classname ]
'    [ Implements interfacenames ]
'    [ statements ]
'End Class
'Where,

'attributelist Is a list of attributes that apply to the class. Optional.

'accessmodifier defines the access levels Of the Class, it has values As - Public, Protected, Friend, Protected Friend And Private. Optional.

'Shadows indicate that the variable re-declares And hides an identically named element, Or Set Of overloaded elements, In a base Class. Optional.

'MustInherit specifies that the Class can be used only As a base Class And that you cannot create an Object directly from it, i.e., an abstract Class. Optional.

'NotInheritable specifies that the Class cannot be used As a base Class.

'Partial indicates a Partial definition Of the Class.

'Inherits specifies the base Class it Is inheriting from.

'Implements specifies the interfaces the Class Is inheriting from.


'The following example demonstrates a Box Class, With three data members, length, breadth And height

Module Module1

    Class Box
        Public length As Double   ' Length of a box
        Public breadth As Double   ' Breadth of a box
        Public height As Double    ' Height of a box
    End Class
    Sub Main()
        Dim Box1 As Box = New Box()        ' Declare Box1 of type Box
        Dim Box2 As Box = New Box()        ' Declare Box2 of type Box
        Dim volume As Double = 0.0     ' Store the volume of a box here
        ' box 1 specification
        Box1.height = 5.0
        Box1.length = 6.0
        Box1.breadth = 7.0
        ' box 2 specification
        Box2.height = 10.0
        Box2.length = 12.0
        Box2.breadth = 13.0
        'volume of box 1
        volume = Box1.height * Box1.length * Box1.breadth
        Console.WriteLine("Volume of Box1 : {0}", volume)
        'volume of box 2
        volume = Box2.height * Box2.length * Box2.breadth
        Console.WriteLine("Volume of Box2 : {0}", volume)
        Console.ReadKey()
    End Sub

End Module

'When the above code Is compiled And executed, it produces the following result

'Volume of Box1 : 210
'Volume of Box2 : 1560

