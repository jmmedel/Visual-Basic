
'VB.Net -Label Control
'The Label control represents a standard Windows label. It Is generally used To display some informative text On the GUI which Is Not changed during runtime.

'Let's create a label by dragging a Label control from the Toolbox and dropping it on the form.

'Properties of the Label Control
'The following are some Of the commonly used properties Of the Label control

'S.N  Property	Description
'1   Autosize	Gets Or sets a value specifying if the control should be automatically resized to display all its contents.
'2   BorderStyle	Gets Or sets the border style for the control.
'3   FlatStyle	Gets Or sets the flat style appearance of the Label control
'4   Font	Gets Or sets the font of the text displayed by the control.
'5   FontHeight	Gets Or sets the height of the font of the control.
'6   ForeColor	Gets Or sets the foreground color of the control.
'7   PreferredHeight	Gets the preferred height of the control.
'8   PreferredWidth	Gets the preferred width of the control.
'9   TabStop	Gets Or sets a value indicating whether the user can tab to the Label. This property Is Not used by this class.
'10  Text	Gets Or sets the text associated with this control.
'11  TextAlign	Gets Or sets the alignment of text in the label.
'Methods of the Label Control
'The following are some Of the commonly used methods Of the Label control

'S.N  Method Name & Description
'1   
'GetPreferredSize

'Retrieves the size Of a rectangular area into which a control can be fitted.

'2   
'Refresh

'Forces the control To invalidate its client area And immediately redraw itself And any child controls.

'3   
'Select Case

'Activates the control.

'4   
'Show

'Displays the control To the user.

'5   
'ToString

'Returns a String that contains the name Of the control.

'Events of the Label Control
'The following are some Of the commonly used events Of the Label control

'S.N  Event	Description
'1   AutoSizeChanged	Occurs when the value of the AutoSize property changes.
'2   Click	Occurs when the control Is clicked.
'3   DoubleClick	Occurs when the control Is double-clicked.
'4   GotFocus	Occurs when the control receives focus.
'5   Leave	Occurs when the input focus leaves the control.
'6   LostFocus	Occurs when the control loses focus.
'7   TabIndexChanged	Occurs when the TabIndex property value changes.
'8   TabStopChanged	Occurs when the TabStop property changes.
'9   TextChanged	Occurs when the Text property value changes.
'Consult Microsoft documentation For detailed list Of properties, methods And events Of the Label control.

'Example
'Following Is an example, which shows how we can create two labels. Let us create the first label from the designer view tab And Set its properties from the properties window. We will use the Click And the DoubleClick events Of the label To move the first label And change its text And create the second label And add it To the form, respectively.

'Take the following steps

'Drag And drop a Label control on the form.

'Set the Text Property To provide the caption "This is a Label Control".

'Set the Font Property from the properties window.

'Click the label To add the Click Event In the code window And add the following codes.


Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) _
             Handles MyBase.Load
        ' Create two buttons to use as the accept and cancel buttons. 
        ' Set window width and height
        Me.Height = 300
        Me.Width = 560

        ' Set the caption bar text of the form.  
        Me.Text = "tutorialspont.com"
        ' Display a help button on the form.
        Me.HelpButton = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) _
             Handles Label1.Click
        Label1.Location = New Point(50, 50)
        Label1.Text = "You have just moved the label"
    End Sub
    Private Sub Label1_DoubleClick(sender As Object, e As EventArgs)

        Dim Label2 As New Label
        Label2.Text = "New Label"
        Label2.Location = New Point(Label1.Left, Label1.Height +
        Label1.Top + 25)
        Me.Controls.Add(Label2)
    End Sub
End Class
