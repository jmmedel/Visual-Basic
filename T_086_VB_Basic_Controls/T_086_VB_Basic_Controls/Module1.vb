
'VB.Net -Basic Controls
'An Object Is a type Of user Interface element you create On a Visual Basic form by Using a toolbox control. In fact, in Visual Basic, the form itself Is an object. Every Visual Basic control consists of three important elements:

'Properties which describe the Object,

'Methods cause an Object To Do something And

'Events are what happens When an Object does something.

'Control Properties
'All the Visual Basic Objects can be moved, resized Or customized by setting their properties. A Property Is a value Or characteristic held by a Visual Basic Object, such As Caption Or Fore Color.

'Properties can be Set at design time by Using the Properties window Or at run time by Using statements In the program code.

'Object.Property = Value
'Where

'Object Is the name of the object you're customizing.

'Property is the characteristic you want To change.

'Value Is the New property setting.

'For example,

'Form1.Caption = "Hello"
'You can Set any Of the form properties Using Properties Window. Most Of the properties can be Set Or read during application execution. You can refer To Microsoft documentation For a complete list Of properties associated With different controls And restrictions applied To them.

'Control Methods
'A method Is a procedure created As a member Of a Class And they cause an Object To Do something. Methods are used To access Or manipulate the characteristics Of an Object Or a variable. There are mainly two categories Of methods you will use In your classes

'If you are Using a control such As one Of those provided by the Toolbox, you can Call any Of its Public methods. The requirements Of such a method depend On the Class being used.

'If none Of the existing methods can perform your desired task, you can add a method To a Class.

'For example, the MessageBox control has a method named Show, which Is called in the code snippet below

'Public Class Form1
'    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'	Handles Button1.Click
'        MessageBox.Show("Hello, World")
'    End Sub
'End Class
'Control Events
'An Event is() a signal that informs an application that something important has occurred. For example, When a user clicks a control On a form, the form can raise a Click Event And Call a procedure that Handles the Event. There are various types Of events associated With a Form Like click, Double click, close, load, resize, etc.

'Following Is the default structure of a form Load event handler subroutine. You can see this code by double clicking the code which will give you a complete list of the all events associated with Form control

'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'    'event handler code goes here
'End Sub
'Here, Handles MyBase.Load indicates that Form1_Load() subroutine handles Load event. Similar way, you can check stub code for click, double click. If you want to initialize some variables Like properties, etc., then you will keep such code inside Form1_Load() subroutine. Here, important point to note Is the name of the event handler, which Is by default Form1_Load, but you can change this name based on your naming convention you use in your application programming.

'Basic Controls
'VB.Net provides a huge variety of controls that help you to create rich user interface. Functionalities of all these controls are defined in the respective control classes. The control classes are defined in the System.Windows.Forms namespace.

'The following table lists some Of the commonly used controls

'S.N.Widget & Description
'1   
'Forms

'The container For all the controls that make up the user Interface.

'2   
'TextBox

'It represents a Windows text box control.

'3   
'Label

'It represents a standard Windows label.

'4   
'Button

'It represents a Windows button control.

'5   
'ListBox

'It represents a Windows control To display a list Of items.

'6   
'ComboBox

'It represents a Windows combo box control.

'7   
'RadioButton

'It enables the user To Select a Single Option from a group Of choices When paired With other RadioButton controls.

'8   
'CheckBox

'It represents a Windows CheckBox.

'9   
'PictureBox

'It represents a Windows picture box control For displaying an image.

'10  
'ProgressBar

'It represents a Windows progress bar control.

'11  
'ScrollBar

'It Implements the basic functionality of a scroll bar control.

'12  
'DateTimePicker

'It represents a Windows control that allows the user To Select a Date And a time And To display the Date And time With a specified format.

'13  
'TreeView

'It displays a hierarchical collection Of labeled items, Each represented by a TreeNode.

'14  
'ListView

'It represents a Windows list view control, which displays a collection Of items that can be displayed Using one Of four different views.

Module Module1

    Sub Main()

    End Sub

End Module
