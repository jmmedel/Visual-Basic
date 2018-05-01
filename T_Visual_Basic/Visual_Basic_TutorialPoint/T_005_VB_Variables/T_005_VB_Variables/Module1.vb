
'VB.Net -Variables
'Advertisements
' Previous Page Next Page  
'A variable Is Nothing but a name given To a storage area that our programs can manipulate. Each variable In VB.Net has a specific type, which determines the size And layout Of the variable's memory; the range of values that can be stored within that memory; and the set of operations that can be applied to the variable.

'We have already discussed various data types. The basic value types provided In VB.Net can be categorized As:

'Type	Example
'Integral types	SByte, Byte, Short, UShort, Integer, UInteger, Long, ULong And Char
'Floating point types	Single And Double
'Decimal types	Decimal
'Boolean types	True Or False values, as assigned
'Date types	Date
'VB.Net also allows defining other value types of variable Like Enum And reference types of variables Like Class. We will discuss date types And Classes in subsequent chapters.

'Variable Declaration In VB.Net
'The Dim statement Is used For variable declaration And storage allocation For one Or more variables. The Dim statement Is used at Module, Class, Structure, procedure Or block level.

'Syntax for variable declaration in VB.Net Is:

'[ < attributelist> ] [ accessmodifier ] [[ Shared ] [ Shadows ] | [ Static ]]
'[ ReadOnly ] Dim [ WithEvents ] variablelist

'Where,

'attributelist Is a list of attributes that apply to the variable. Optional.

'accessmodifier defines the access levels Of the variables, it has values As - Public, Protected, Friend, Protected Friend And Private. Optional.

'Shared declares a Shared variable, which Is Not associated With any specific instance Of a Class Or Structure, rather available To all the instances Of the Class Or Structure. Optional.

'Shadows indicate that the variable re-declares And hides an identically named element, Or Set Of overloaded elements, In a base Class. Optional.

'Static indicates that the variable will retain its value, even When the after termination Of the procedure In which it Is declared. Optional.

'ReadOnly means the variable can be read, but Not written. Optional.

'WithEvents specifies that the variable Is used To respond To events raised by the instance assigned To the variable. Optional.

'Variablelist provides the list Of variables declared.

'Each variable in the variable list has the following syntax And parts

'variablename[ ( [ boundslist ] ) ] [ As [ New ] datatype ] [ = initializer ]
'    Where,

'variablename: Is the name of the variable

'boundslist: optional. It provides list of bounds of each dimension of an array variable.

'New optional. It creates a New instance of the class when the Dim statement runs.

'datatype: Required If Option Strict Is On. It specifies the data type of the variable.

'initializer: Optional if New Is Not specified. Expression that Is evaluated And assigned to the variable when it Is created.

'Some valid variable declarations along With their definition are shown here

'Dim StudentID As Integer
'Dim StudentName As String
'Dim Salary As Double
'Dim count1, count2 As Integer
'Dim status As Boolean
'Dim exitButton As New System.Windows.Forms.Button
'Dim lastTime, nextTime As Date
'Variable Initialization In VB.Net
'Variables are initialized (assigned a value) With an equal sign followed by a constant expression. The general form Of initialization Is

'variable_name = value;
'For example,

'Dim pi As Double
'pi = 3.14159
'You can initialize a variable at the time Of declaration As follows

'Dim StudentID As Integer = 100
'Dim StudentName As String = "Bill Smith"
'Example
'Try the following example which makes use Of various types Of variables



Module Module1

    Sub Main()
        Dim a As Short
        Dim b As Integer
        Dim c As Double
        a = 10
        b = 20
        c = a + b
        Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c)
        Console.ReadLine()
    End Sub


End Module
