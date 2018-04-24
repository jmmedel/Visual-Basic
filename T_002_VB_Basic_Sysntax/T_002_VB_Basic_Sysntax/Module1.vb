Imports System


'VB.Net Is an Object-oriented programming language. In Object-Oriented Programming methodology, a program consists Of various objects that interact With Each other by means Of actions. The actions that an Object may take are called methods. Objects Of the same kind are said To have the same type Or, more often, are said to be in the same class.

'When we consider a VB.Net program, it can be defined as a collection of objects that communicate via invoking each other's methods. Let us now briefly look into what do class, object, methods and instance variables mean.

'Object -Objects have states And behaviors. Example: A dog has states - color, name, breed As well As behaviors - wagging, barking, eating, etc. An Object Is an instance Of a Class.

'Class - A class can be defined as a template/blueprint that describes the behaviors/states that objects of its type support.

'Methods - A method Is basically a behavior. A class can contain many methods. It Is in methods where the logics are written, data Is manipulated And all the actions are executed.

'Instance Variables - Each Object has its unique Set Of instance variables. An Object's state is created by the values assigned to these instance variables.

'A Rectangle Class In VB.Net
'For example, let us consider a Rectangle object. It has attributes Like length And width. Depending upon the design, it may need ways for accepting the values of these attributes, calculating area And displaying details.

'Let us look at an implementation of a Rectangle class And discuss VB.Net basic syntax on the basis of our observations in it





Module Module1

    Public Class Rectangle
        Private length As Double
        Private width As Double

        'Public methods
        Public Sub AcceptDetails()
            length = 4.5
            width = 3.5
        End Sub

        Public Function GetArea() As Double
            GetArea = length * width
        End Function
        Public Sub Display()
            Console.WriteLine("Length: {0}", length)
            Console.WriteLine("Width: {0}", width)
            Console.WriteLine("Area: {0}", GetArea())

        End Sub


    End Class

    Sub Main()
        Dim r As New Rectangle()
        r.AcceptDetails()
        r.Display()
        Console.ReadLine()
    End Sub

End Module



'When the above code Is compiled And executed, it produces the following result

'Length: 4.5
'Width: 3.5
'Area: 15.75
'In previous chapter, we created a Visual Basic module that held the code. Sub Main indicates the entry point of VB.Net program. Here, we are using Class that contains both code And data. You use classes to create objects. For example, in the code, r Is a Rectangle object.

'An Object Is an instance of a class

'Dim r As New Rectangle()
'A Class may have members that can be accessible from outside Class, If so specified. Data members are called fields And procedure members are called methods.

'Shared methods Or Static methods can be invoked without creating an Object Of the Class. Instance methods are invoked through an Object Of the Class

'Shared Sub Main()
'        Dim r As New Rectangle()
'        r.AcceptDetails()
'        r.Display()
'        Console.ReadLine()
'    End Sub
'Identifiers


'An identifier is a name used to identify a class, variable, function, or any other user-defined item. The basic rules for naming classes in VB.Net are as follows:

'A name must begin with a letter that could be followed by a sequence of letters, digits (0 - 9) or underscore. The first character in an identifier cannot be a digit.

'It must not contain any embedded space or symbol like ? - +! @ # % ^ & * ( ) [ ] { } . ; : " ' / and \. However, an underscore ( _ ) can be used.

'It should not be a reserved keyword.

'VB.Net Keywords
'The following table lists the VB.Net reserved keywords:

'AddHandler	AddressOf	Alias	And	AndAlso	As	Boolean
'ByRef	Byte	ByVal	Call	Case	Catch	CBool
'CByte	CChar	CDate	CDec	CDbl	Char	CInt
'Class	CLng	CObj	Const	Continue	CSByte	CShort
'CSng	CStr	CType	CUInt	CULng	CUShort	Date
'Decimal	Declare	Default	Delegate	Dim	DirectCast	Do
'Double	Each	Else	ElseIf	End	End If	Enum
'Erase	Error	Event	Exit	False	Finally	For
'Friend	Function	Get	GetType	GetXML Namespace	Global	GoTo
'Handles	If	Implements	Imports	In	Inherits	Integer
'Interface	Is	IsNot	Let	Lib	Like	Long
'Loop	Me	Mod	Module	MustInherit	MustOverride	MyBase
'MyClass	Namespace	Narrowing	New	Next	Not	Nothing
'Not Inheritable	Not Overridable	Object	Of	On	Operator	Option
'Optional	Or	OrElse	Overloads	Overridable	Overrides	ParamArray
'Partial	Private	Property	Protected	Public	RaiseEvent	ReadOnly
'ReDim	REM	Remove Handler	Resume	Return	SByte	Select
'Set	Shadows	Shared	Short	Single	Static	Step
'Stop	String	Structure	Sub	SyncLock	Then	Throw
'To	True	Try	TryCast	TypeOf	UInteger	While
'Widening	With	WithEvents	WriteOnly	Xor

