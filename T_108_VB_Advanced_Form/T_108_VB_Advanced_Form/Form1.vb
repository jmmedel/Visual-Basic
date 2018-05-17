

'VB.Net -Advanced Form
'In this chapter, let us study the following concepts:

'Adding menus And Sub menus In an application

'Adding the cut, copy And paste functionalities In a form

'Anchoring And docking controls in a form

'Modal forms

'Adding Menus And Sub Menus In an Application
'Traditionally, the Menu, MainMenu, ContextMenu, And MenuItem classes were used For adding menus, Sub() - menus And context menus in a Windows application.

'Now, the MenuStrip, the ToolStripMenuItem, ToolStripDropDown And ToolStripDropDownMenu controls replace And add functionality To the Menu-related controls Of previous versions. However, the old control classes are retained for both backward compatibility And future use.

'Let us create a typical windows main menu bar And sub menus using the old version controls first since these controls are still much used in old applications.

'Following Is an example, which shows how we create a menu bar with menu items: File, Edit, View And Project.The File menu has the Sub menus New, Open And Save.

'Let's double click on the Form and put the following code in the opened window.


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'defining the main menu bar
        Dim mnuBar As New MainMenu()
        'defining the menu items for the main menu bar
        Dim myMenuItemFile As New MenuItem("&File")
        Dim myMenuItemEdit As New MenuItem("&Edit")
        Dim myMenuItemView As New MenuItem("&View")
        Dim myMenuItemProject As New MenuItem("&Project")

        'adding the menu items to the main menu bar
        mnuBar.MenuItems.Add(myMenuItemFile)
        mnuBar.MenuItems.Add(myMenuItemEdit)
        mnuBar.MenuItems.Add(myMenuItemView)
        mnuBar.MenuItems.Add(myMenuItemProject)

        ' defining some sub menus
        Dim myMenuItemNew As New MenuItem("&New")
        Dim myMenuItemOpen As New MenuItem("&Open")
        Dim myMenuItemSave As New MenuItem("&Save")

        'add sub menus to the File menu
        myMenuItemFile.MenuItems.Add(myMenuItemNew)
        myMenuItemFile.MenuItems.Add(myMenuItemOpen)
        myMenuItemFile.MenuItems.Add(myMenuItemSave)

        'add the main menu to the form
        Me.Menu = mnuBar

        ' Set the caption bar text of the form.  
        Me.Text = "tutorialspoint.com"

    End Sub

End Class
