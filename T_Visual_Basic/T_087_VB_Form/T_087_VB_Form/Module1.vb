
'Let's start with creating a Window Forms Application by following the following steps in Microsoft Visual Studio: File -> New Project -> Windows Forms Applications

'Finally, Select OK, Microsoft Visual Studio creates your project And displays following window Form With a name Form1.
'    Visual Basic Form Is the container For all the controls that make up the user Interface. Every window you see In a running visual basic application Is a form, thus the terms form And window describe the same entity. Visual Studio creates a Default form For you When you create a Windows Forms Application.

'Every form will have title bar On which the form's caption is displayed and there will be buttons to close, maximize and minimize the form shown below:
'If you click the icon On the top left corner, it opens the control menu, which contains the various commands To control the form Like To move control from one place To another place, To maximize Or minimize the form Or To close the form.

'Form Properties
'Following table lists down various important properties related To a form. These properties can be Set Or read during application execution. You can refer To Microsoft documentation For a complete list Of properties associated With a Form control

'S.N  Properties	Description
'1   AcceptButton	The button that's automatically activated when you press Enter, no matter which control has the focus at the time. Usually the OK button on a form is set as AcceptButton for a form.
'2   CancelButton	
'The button that's automatically activated when you hit the Esc key.

'Usually, the Cancel button on a form Is set as CancelButton for a form.

'3   AutoScale	This Boolean property determines whether the controls you place on the form are automatically scaled to the height of the current font. The default value of this property Is True. This Is a property of the form, but it affects the controls on the form.
'4   AutoScroll	This Boolean property indicates whether scroll bars will be automatically attached to the form if it Is resized to a point that Not all its controls are visible.
'5   AutoScrollMinSize	This property lets you specify the minimum size of the form, before the scroll bars are attached.
'6   AutoScrollPosition	The AutoScrollPosition Is the number of pixels by which the two scroll bars were displaced from their initial locations.
'7   BackColor	Sets the form background color.
'8   BorderStyle	The BorderStyle property determines the style of the form's border and the appearance of the form:
'None: Borderless window that can't be resized.
'Sizable: This Is default value And will be used for resizable window that's used for displaying regular forms.
'Fixed3D: Window with a visible border, "raised" relative To the main area. In this Case, windows can't be resized.
'FixedDialog: A fixed window, used To create dialog boxes.
'FixedSingle: A fixed window With a Single line border.
'FixedToolWindow: A fixed window With a Close button only. It looks Like the toolbar displayed by the drawing And imaging applications.
'SizableToolWindow: Same as the FixedToolWindow but resizable. In addition, its caption font Is smaller than the usual.
'9   ControlBox	By default, this property Is True And you can set it to False to hide the icon And disable the Control menu.
'10  Enabled	If True, allows the form to respond to mouse And keyboard events; if False, disables form.
'11  Font	This property specify font type, style, size
'12  HelpButton	Determines whether a Help button should be displayed in the caption box of the form.
'13  Height	This Is the height of the Form in pixels.
'14  MinimizeBox	By default, this property Is True And you can set it to False to hide the Minimize button on the title bar.
'15  MaximizeBox	By default, this property Is True And you can set it to False to hide the Maximize button on the title bar.
'16  MinimumSize	This specifies the minimum height And width of the window you can minimize.
'17  MaximumSize	This specifies the maximum height And width of the window you maximize.
'18  Name	This Is the actual name of the form.
'19  StartPosition	This property determines the initial position of the form when it's first displayed. It will have any of the following values:
'CenterParent: The form Is centered In the area Of its parent form.
'CenterScreen: The form Is centered On the monitor.
'Manual: The location And size Of the form will determine its starting position.
'WindowsDefaultBounds: The form Is positioned at the Default location And size determined by Windows.
'WindowsDefaultLocation: The form Is positioned at the Windows Default location And has the dimensions you've set at design time.
'20  Text	The text, which will appear at the title bar of the form.
'21  Top, Left	These two properties set Or return the coordinates of the form's top-left corner in pixels.
'22  TopMost	This property Is a True/False value that lets you specify whether the form will remain on top of all other forms in your application. Its default property Is False.
'23  Width	This Is the width of the form in pixel.
'Form Methods
'The following are some Of the commonly used methods Of the Form Class.You can refer To Microsoft documentation For a complete list Of methods associated With forms control

'S.N.Method Name & Description
'1   
'Activate

'Activates the form And gives it focus.

'2   
'ActivateMdiChild

'Activates the MDI child Of a form.

'3   
'AddOwnedForm

'Adds an owned form To this form.

'4   
'BringToFront

'Brings the control To the front Of the z-order.

'5   
'CenterToParent

'Centers the position Of the form within the bounds Of the parent form.

'6   
'CenterToScreen

'Centers the form On the current screen.

'7   
'Close

'Closes the form.

'8   
'Contains

'Retrieves a value indicating whether the specified control Is a child Of the control.

'9   
'Focus

'Sets input focus To the control.

'10  
'Hide

'Conceals the control from the user.

'11  
'Refresh

'Forces the control To invalidate its client area And immediately redraw itself And any child controls.

'12  
'Scale(SizeF)

'Scales the control And all child controls by the specified scaling factor.

'13  
'ScaleControl

'Scales the location, size, padding, And margin Of a control.

'14  
'ScaleCore

'Performs scaling Of the form.

'15  
'Select Case

'Activates the control.

'16  
'SendToBack

'Sends the control To the back Of the z-order.

'17  
'SetAutoScrollMargin

'Sets the size Of the auto-scroll margins.

'18  
'SetDesktopBounds

'Sets the bounds Of the form In desktop coordinates.

'19  
'SetDesktopLocation

'Sets the location Of the form In desktop coordinates.

'20  
'SetDisplayRectLocation

'Positions the display window To the specified value.

'21  
'Show

'Displays the control To the user.

'22  
'ShowDialog

'Shows the form As a modal dialog box.

'Form Events
'Following table lists down various important events related To a form. You can refer To Microsoft documentation For a complete list Of events associated With forms control

'S.N  Event	Description
'1   Activated	Occurs when the form Is activated in code Or by the user.
'2   Click	Occurs when the form Is clicked.
'3   Closed	Occurs before the form Is closed.
'4   Closing	Occurs when the form Is closing.
'5   DoubleClick	Occurs when the form control Is double-clicked.
'6   DragDrop	Occurs when a drag-And-drop operation Is completed.
'7   Enter	Occurs when the form Is entered.
'8   GotFocus	Occurs when the form control receives focus.
'9   HelpButtonClicked	Occurs when the Help button Is clicked.
'10  KeyDown	Occurs when a key Is pressed while the form has focus.
'11  KeyPress	Occurs when a key Is pressed while the form has focus.
'12  KeyUp	Occurs when a key Is released while the form has focus.
'13  Load	Occurs before a form Is displayed for the first time.
'14  LostFocus	Occurs when the form loses focus.
'15  MouseDown	Occurs when the mouse pointer Is over the form And a mouse button Is pressed.
'16  MouseEnter	Occurs when the mouse pointer enters the form.
'17  MouseHover	Occurs when the mouse pointer rests on the form.
'18  MouseLeave	Occurs when the mouse pointer leaves the form.
'19  MouseMove	Occurs when the mouse pointer Is moved over the form.
'20  MouseUp	Occurs when the mouse pointer Is over the form And a mouse button Is released.
'21  MouseWheel	Occurs when the mouse wheel moves while the control has focus.
'22  Move	Occurs when the form Is moved.
'23  Resize	Occurs when the control Is resized.
'24  Scroll	Occurs when the user Or code scrolls through the client area.
'25  Shown	Occurs whenever the form Is first displayed.
'26  VisibleChanged	Occurs when the Visible property value changes.
'Example:
'Following Is an example, which shows how we create two buttons at the time of form load event And different properties are being set at the same time.

'Because Form1 Is being referenced within its own Event handler, so it will be written As Me instead Of Using its name, but If we access the same form inside any other control's event handler, then it will be accessed using its name Form1.

'Let's double click on the Form and put the follow code in the opened window.

'Public Class Form1

'    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        ' Create two buttons to use as the accept and cancel buttons. 
'        Dim button1 As New Button()
'        Dim button2 As New Button()
'        ' Set the text of button1 to "OK".
'        button1.Text = "OK"
'        ' Set the position of the button on the form.
'        button1.Location = New Point(10, 10)
'        ' Set the text of button2 to "Cancel".
'        button2.Text = "Cancel"
'        ' Set the position of the button based on the location of button1.
'        button2.Location =
'         New Point(button1.Left, button1.Height + button1.Top + 10)
'        ' Set the caption bar text of the form.   
'        Me.Text = "tutorialspoint.com"
'        ' Display a help button on the form.
'        Me.HelpButton = True
'        ' Define the border style of the form to a dialog box.
'        Me.FormBorderStyle = FormBorderStyle.FixedDialog
' Set the MaximizeBox to false to remove the maximize box.
'        Me.MaximizeBox = False
'        ' Set the MinimizeBox to false to remove the minimize box.
'        Me.MinimizeBox = False
'        ' Set the accept button of the form to button1.
'        Me.AcceptButton = button1
'        ' Set the cancel button of the form to button2.
'        Me.CancelButton = button2
'        ' Set the start position of the form to the center of the screen.
'        Me.StartPosition = FormStartPosition.CenterScreen
'        ' Set window width and height
'        Me.Height = 300
'        Me.Width = 560
'        ' Add button1 to the form.
'        Me.Controls.Add(button1)
'        ' Add button2 to the form.
'        Me.Controls.Add(button2)
'    End Sub
'End Class
'When the above code Is executed And run using Start button available at the Microsoft Visual Studio tool bar, it will show the following window


Module Module1

    Sub Main()

    End Sub

End Module
