
'VB.Net -Button Control
'The Button control represents a standard Windows button. It Is generally used To generate a Click Event by providing a handler For the Click Event.

'Let's create a label by dragging a Button control from the Toolbox ad dropping it on the form.
'Properties of the Button Control
'The following are some Of the commonly used properties Of the Button control

'S.N  Property	Description
'1   AutoSizeMode	Gets Or sets the mode by which the Button automatically resizes itself.
'2   BackColor	Gets Or sets the background color of the control.
'3   BackgroundImage	Gets Or sets the background image displayed in the control.
'4   DialogResult	Gets Or sets a value that Is returned to the parent form when the button Is clicked. This Is used while creating dialog boxes.
'5   ForeColor	Gets Or sets the foreground color of the control.
'6   Image	Gets Or sets the image that Is displayed on a button control.
'7   Location	Gets Or sets the coordinates of the upper-left corner of the control relative to the upper-left corner of its container.
'8   TabIndex	Gets Or sets the tab order of the control within its container.
'9   Text	Gets Or sets the text associated with this control.
'Methods of the Button Control
'The following are some Of the commonly used methods Of the Button control

'S.N  Method Name & Description
'1   
'GetPreferredSize

'Retrieves the size Of a rectangular area into which a control can be fitted.

'2   
'NotifyDefault

'Notifies the Button whether it Is the Default button so that it can adjust its appearance accordingly.

'3   
'Select Case

'Activates the control.

'4   
'ToString

'Returns a String containing the name Of the Component, If any. This method should Not be overridden.

'Events of the Button Control
'The following are some Of the commonly used events Of the Button control

'S.N  Event	Description
'1   Click	Occurs when the control Is clicked.
'2   DoubleClick	Occurs when the user double-clicks the Button control.
'3   GotFocus	Occurs when the control receives focus.
'4   TabIndexChanged	Occurs when the TabIndex property value changes.
'5   TextChanged	Occurs when the Text property value changes.
'6   Validated	Occurs when the control Is finished validating.
'Consult Microsoft documentation For detailed list Of properties, methods And events Of the Button control.

'Example
'In the following example, we create three buttons. In this example, let us

'Set captions For the buttons

'Set some image For the button

'Handle the click events Of Each buttons

'Take following steps

'Drag And drop a Label control on the form.

'Set the Text Property To provide the caption "Tutorials Point".

'Drag And drop three buttons on the form.

'Using the properties window, change the Name properties Of the buttons To btnMoto, btnLogo And btnExit respectively.

'Using the properties window, change the Text properties Of the buttons To Show Moto, Show Logo And Exit respectively.

'Drag And Drop another button, using the properties window, set its Image property And name it btnImage.

'At this stage, the form looks Like

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the caption bar text of the form.  
        Me.Text = "tutorialspont.com"
        btnImage.Visible = False
    End Sub
    Private Sub btnMoto_Click(sender As Object, e As EventArgs) Handles btnMoto.Click
        btnImage.Visible = False
        Label1.Text = "Simple Easy Learning"
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click
        Label1.Visible = False
        btnImage.Visible = True
    End Sub
End Class
