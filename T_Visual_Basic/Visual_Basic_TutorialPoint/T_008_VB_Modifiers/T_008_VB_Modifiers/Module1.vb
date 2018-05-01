

'VB.Net -Modifiers
'    The modifiers are keywords added With any programming element To give some especial emphasis On how the programming element will behave Or will be accessed In the program

'For example, the access modifiers: Public, Private, Protected, Friend, Protected Friend, etc., indicate the access level of a programming element Like a variable, constant, enumeration Or a class.

'List of Available Modifiers in VB.Net
'The following table provides the complete list Of VB.Net modifiers

'S.N  Modifier	Description
'1   Ansi	Specifies that Visual Basic should marshal all strings to American National Standards Institute (ANSI) values regardless of the name of the external procedure being declared.
'2   Assembly	Specifies that an attribute at the beginning of a source file applies to the entire assembly.
'3   Async	Indicates that the method Or lambda expression that it modifies Is asynchronous. Such methods are referred to as async methods. The caller of an async method can resume its work without waiting for the async method to finish.
'4   Auto	The charsetmodifier part in the Declare statement supplies the character set information for marshaling strings during a call to the external procedure. It also affects how Visual Basic searches the external file for the external procedure name. The Auto modifier specifies that Visual Basic should marshal strings according to .NET Framework rules.
'5   ByRef	Specifies that an argument Is passed by reference, i.e., the called procedure can change the value of a variable underlying the argument in the calling code. It Is used under the contexts of:
'Declare Statement()
'Function Statement()
'Sub Statement()
'6   ByVal	Specifies that an argument Is passed in such a way that the called procedure Or property cannot change the value of a variable underlying the argument in the calling code. It Is used under the contexts of:
'Declare Statement()
'Function Statement()
'Operator Statement
'Property Statement
'Sub Statement()
'7   Default	Identifies a property as the default property of its class, structure, Or interface.
'8   Friend	
'Specifies that one Or more declared programming elements are accessible from within the assembly that contains their declaration, Not only by the component that declares them.

'Friend access Is often the preferred level For an application's programming elements, and Friend is the default access level of an interface, a module, a class, or a structure.

'9   In	It Is used in generic interfaces And delegates.
'10  Iterator	Specifies that a function Or Get accessor Is an iterator. An iterator performs a custom iteration over a collection.
'11  Key	The Key keyword enables you to specify behavior for properties of anonymous types.
'12  Module	Specifies that an attribute at the beginning of a source file applies to the current assembly module. It Is Not same as the Module statement.
'13  MustInherit	Specifies that a class can be used only as a base class And that you cannot create an object directly from it.
'14  MustOverride	Specifies that a property Or procedure Is Not implemented in this class And must be overridden in a derived class before it can be used.
'15  Narrowing	Indicates that a conversion operator (CType) converts a class Or structure to a type that might Not be able to hold some of the possible values of the original class Or structure.
'16  NotInheritable	Specifies that a class cannot be used as a base class.
'17  NotOverridable	Specifies that a property Or procedure cannot be overridden in a derived class.
'18  Optional	Specifies that a procedure argument can be omitted when the procedure Is called.
'19  Out	For generic type parameters, the Out keyword specifies that the type Is covariant.
'20  Overloads	Specifies that a property Or procedure redeclares one Or more existing properties Or procedures with the same name.
'21  Overridable	Specifies that a property Or procedure can be overridden by an identically named property Or procedure in a derived class.
'22  Overrides	Specifies that a property Or procedure overrides an identically named property Or procedure inherited from a base class.
'23  ParamArray	ParamArray allows you to pass an arbitrary number of arguments to the procedure. A ParamArray parameter Is always declared using ByVal.
'24  Partial	Indicates that a class Or structure declaration Is a partial definition of the class Or structure.
'25  Private	Specifies that one Or more declared programming elements are accessible only from within their declaration context, including from within any contained types.
'26  Protected	Specifies that one Or more declared programming elements are accessible only from within their own class Or from a derived class.
'27  Public	Specifies that one Or more declared programming elements have no access restrictions.
'28  ReadOnly	Specifies that a variable Or property can be read but Not written.
'29  Shadows	Specifies that a declared programming element redeclares And hides an identically named element, Or set of overloaded elements, in a base class.
'30  Shared	Specifies that one Or more declared programming elements are associated with a class Or structure at large, And Not with a specific instance of the class Or structure.
'31  Static	Specifies that one Or more declared local variables are to continue to exist And retain their latest values after termination of the procedure in which they are declared.
'32  Unicode	Specifies that Visual Basic should marshal all strings to Unicode values regardless of the name of the external procedure being declared.
'33  Widening	Indicates that a conversion operator (CType) converts a class Or structure to a type that can hold all possible values of the original class Or structure.
'34  WithEvents	Specifies that one Or more declared member variables refer to an instance of a class that can raise events.
'35  WriteOnly	Specifies that a property can be written but Not read


Module Module1

    Sub Main()

    End Sub

End Module
