'P
'VB.Net - Event Handling
'Advertisements
' Previous Page Next Page  
'Events are basically a user action Like key press, clicks, mouse movements, etc., Or some occurrence Like system generated notifications. Applications need To respond To events When they occur.

'Clicking on a button, Or entering some text In a text box, Or clicking On a menu item, all are examples of events. An event Is an action that calls a function Or may cause another event. Event handlers are functions that tell how to respond to an event.

'VB.Net Is an event-driven language. There are mainly two types of events −

'Mouse events

'Keyboard events

'Handling Mouse Events
'Mouse events occur With mouse movements In forms And controls. Following are the various mouse events related With a Control Class −

'MouseDown − it occurs When a mouse button Is pressed

'MouseEnter − it occurs When the mouse pointer enters the control

'MouseHover − it occurs When the mouse pointer hovers over the control

'MouseLeave − it occurs When the mouse pointer leaves the control

'MouseMove − it occurs When the mouse pointer moves over the control

'MouseUp − it occurs When the mouse pointer Is over the control And the mouse button Is released

'MouseWheel − it occurs When the mouse wheel moves And the control has focus

'The Event handlers() Of the mouse events Get an argument Of type MouseEventArgs. The MouseEventArgs Object Is used For handling mouse events. It has the following properties −

'Buttons − indicates the mouse button pressed

'Clicks − indicates the number Of clicks

'Delta − indicates the number Of detents the mouse wheel rotated

'X − indicates the x-coordinate Of mouse click

'Y − indicates the y-coordinate Of mouse click

'Example
'Following Is an example, which shows how to handle mouse events. Take the following steps −

'Add three labels, three text boxes And a button control In the form.

'Change the text properties Of the labels To - Customer ID, Name And Address, respectively.

'Change the name properties Of the text boxes To txtID, txtName And txtAddress, respectively.

'Change the text Property Of the button To 'Submit'.

'Add the following code In the code editor window −

'Public Class Form1
'    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        ' Set the caption bar text of the form.   
'        Me.Text = "tutorialspont.com"
'    End Sub

'    Private Sub txtID_MouseEnter(sender As Object, e As EventArgs)_
'      Handles txtID.MouseEnter
'      'code for handling mouse enter on ID textbox
'      txtID.BackColor = Color.CornflowerBlue
'        txtID.ForeColor = Color.White
'    End Sub

'    Private Sub txtID_MouseLeave(sender As Object, e As EventArgs) _
'      Handles txtID.MouseLeave
'        'code for handling mouse leave on ID textbox
'        txtID.BackColor = Color.White
'        txtID.ForeColor = Color.Blue
'    End Sub

'    Private Sub txtName_MouseEnter(sender As Object, e As EventArgs) _
'      Handles txtName.MouseEnter
'        'code for handling mouse enter on Name textbox
'        txtName.BackColor = Color.CornflowerBlue
'        txtName.ForeColor = Color.White
'    End Sub

'    Private Sub txtName_MouseLeave(sender As Object, e As EventArgs) _
'      Handles txtName.MouseLeave
'        'code for handling mouse leave on Name textbox
'        txtName.BackColor = Color.White
'        txtName.ForeColor = Color.Blue
'    End Sub

'    Private Sub txtAddress_MouseEnter(sender As Object, e As EventArgs) _
'      Handles txtAddress.MouseEnter
'        'code for handling mouse enter on Address textbox
'        txtAddress.BackColor = Color.CornflowerBlue
'        txtAddress.ForeColor = Color.White
'    End Sub

'    Private Sub txtAddress_MouseLeave(sender As Object, e As EventArgs) _
'      Handles txtAddress.MouseLeave
'        'code for handling mouse leave on Address textbox
'        txtAddress.BackColor = Color.White
'        txtAddress.ForeColor = Color.Blue
'    End Sub

'    Private Sub Button1_Click(sender As Object, e As EventArgs) _
'      Handles Button1.Click
'        MsgBox("Thank you " & txtName.Text & ", for your kind cooperation")
'    End Sub
'End Class
'When the above code Is executed And run using Start button available at the Microsoft Visual Studio tool bar, it will show the following window −

'Event Handling() Example1
'Try To enter text In the text boxes And check the mouse events −

'Event Handling() Result Form
'Handling Keyboard Events
'Following are the various keyboard events related With a Control Class −

'KeyDown − occurs When a key Is pressed down And the control has focus

'KeyPress − occurs When a key Is pressed And the control has focus

'KeyUp − occurs When a key Is released While the control has focus

'The Event handlers() Of the KeyDown And KeyUp events Get an argument Of type KeyEventArgs. This Object has the following properties −

'Alt − it indicates whether the ALT key Is pressed

'Control − it indicates whether the CTRL key Is pressed

'Handled − it indicates whether the Event Is handled

'KeyCode − stores the keyboard code For the Event

'KeyData − stores the keyboard data For the Event

'KeyValue − stores the keyboard value For the Event

'Modifiers − it indicates which modifier keys (Ctrl, Shift, And/Or Alt) are pressed

'Shift − it indicates If the Shift key Is pressed

'The Event handlers() Of the KeyDown And KeyUp events Get an argument Of type KeyEventArgs. This Object has the following properties −

'Handled − indicates If the KeyPress Event Is handled

'KeyChar − stores the character corresponding To the key pressed

'Example
'Let us continue with the previous example to show how to handle keyboard events. The code will verify that the user enters some numbers for his customer ID And age.

'Add a label With text Property As 'Age' and add a corresponding text box named txtAge.

'Add the following codes For handling the KeyUP events Of the text box txtID.

'Private Sub txtID_KeyUP(sender As Object, e As KeyEventArgs) _
'   Handles txtID.KeyUp

'    If (Not Char.IsNumber(ChrW(e.KeyCode))) Then
'        MessageBox.Show("Enter numbers for your Customer ID")
'        txtID.Text = " "
'    End If
'End Sub
'Add the following codes For handling the KeyUP events Of the text box txtID.

'Private Sub txtAge_KeyUP(sender As Object, e As KeyEventArgs) _
'   Handles txtAge.KeyUp

'    If (Not Char.IsNumber(ChrW(e.KeyCode))) Then
'        MessageBox.Show("Enter numbers for age")
'        txtAge.Text = " "
'    End If
'End Sub
'When the above code Is executed And run using Start button available at the Microsoft Visual Studio tool bar, it will show the following window −

'VB.Net Event Example
'If you leave the text For age Or ID As blank Or enter some non-numeric data, it gives a warning message box And clears the respective text −




Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the caption bar text of the form.   
        Me.Text = "tutorialspont.com"
    End Sub

    Private Sub txtID_MouseEnter(sender As Object, e As EventArgs)_
      Handles txtID.MouseEnter
      'code for handling mouse enter on ID textbox
      txtID.BackColor = Color.CornflowerBlue
        txtID.ForeColor = Color.White
    End Sub

    Private Sub txtID_MouseLeave(sender As Object, e As EventArgs) _
      Handles txtID.MouseLeave
        'code for handling mouse leave on ID textbox
        txtID.BackColor = Color.White
        txtID.ForeColor = Color.Blue
    End Sub

    Private Sub txtName_MouseEnter(sender As Object, e As EventArgs) _
      Handles txtName.MouseEnter
        'code for handling mouse enter on Name textbox
        txtName.BackColor = Color.CornflowerBlue
        txtName.ForeColor = Color.White
    End Sub

    Private Sub txtName_MouseLeave(sender As Object, e As EventArgs) _
      Handles txtName.MouseLeave
        'code for handling mouse leave on Name textbox
        txtName.BackColor = Color.White
        txtName.ForeColor = Color.Blue
    End Sub

    Private Sub txtAddress_MouseEnter(sender As Object, e As EventArgs) _
      Handles txtAddress.MouseEnter
        'code for handling mouse enter on Address textbox
        txtAddress.BackColor = Color.CornflowerBlue
        txtAddress.ForeColor = Color.White
    End Sub

    Private Sub txtAddress_MouseLeave(sender As Object, e As EventArgs) _
      Handles txtAddress.MouseLeave
        'code for handling mouse leave on Address textbox
        txtAddress.BackColor = Color.White
        txtAddress.ForeColor = Color.Blue
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) _
      Handles Button1.Click
        MsgBox("Thank you " & txtName.Text & ", for your kind cooperation")
    End Sub
End Class