
' Create a TextBox named TextBox1 and change Multiline to True
' ScrollBars to Vertical and WordWrap to True
' Create a Button named BtnUpdate
' Change Text size to 18 for both

Public Class Form1
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click

        ' ---------- CONDITIONALS ----------
        Dim txtOutput As String = ""

        ' The If Statement is used to perform different actions
        ' depending on different conditions

        Dim intAge As Integer = 7

        ' You can compare values with =, <>, >, <, >=, <=

        ' Single line If statement
        ' If you want multiple statements separate them with a :
        If intAge < 18 Then txtOutput &= "You can't vote" & Environment.NewLine : 
        txtOutput &= "You can vote in " & 18 - intAge & " years" & Environment.NewLine

        If intAge < 5 Then
            txtOutput &= "To young for school" & Environment.NewLine

        ElseIf intAge = 5 Then
            txtOutput &= "Go to Kindergarten" & Environment.NewLine

            ' With logical operators Or and And you can check for
            ' multiple conditions
        ElseIf intAge > 5 And intAge < 18 Then
            Dim intGrade = intAge - 5
            txtOutput &= "Go to grade " & intGrade & Environment.NewLine

        Else
            txtOutput &= "Go to college" & Environment.NewLine

        End If

        ' You can compare strings and ignore case
        Dim strName As String = "Derek"

        ' Compare returns 0 if they match 
        If String.Compare("DEREK", strName, True) = 0 Then
            txtOutput &= "These Strings are Equal" & Environment.NewLine
        End If

        ' Select Case comparison operator
        Select Case intAge
            ' You can type single digits or multiple
            Case 1, 2, 3, 4
                txtOutput &= "To young for school" & Environment.NewLine
            Case 5
                txtOutput &= "Go to Kindergarten" & Environment.NewLine

            ' You can define a range
            Case 6 To 18
                Dim intGrade = intAge - 5
                txtOutput &= "Go to grade " & intGrade & Environment.NewLine

            Case Else
                ' This is the default action
                txtOutput &= "Go to college" & Environment.NewLine
        End Select

        ' The Ternary operator returns the 1st value if True
        ' and the 2nd if False
        Dim boolCanVote As Boolean = If(intAge >= 18, True, False)

        txtOutput &= "Can you vote : " & boolCanVote & Environment.NewLine

        ' ---------- LOOPING ----------
        txtOutput = ""

        ' For loops execute the code within them a set number of times
        For intNum = 1 To 10
            txtOutput &= intNum & Environment.NewLine
        Next

        ' The Step operator defines the increment amount
        ' You can also use a negative Step
        For intNum = 0 To 50 Step 10
            txtOutput &= intNum & Environment.NewLine

            ' Exit For allows you to exit early
            If intNum = 40 Then Exit For
        Next

        ' For Each can cycle through each item in an array
        ' Create and fill an array with Strings
        Dim employees = New String() {"Paul", "Sally", "Jack"}

        For Each employee As String In employees
            txtOutput &= employee & Environment.NewLine
        Next

        Dim numberGuessed = 0

        ' Generate Random Value
        Dim upperbound = 10
        Dim lowerbound = 1

        Dim randomValue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound

        ' Do Until loops are used when you must have the code 
        ' execute at least once
        ' The Do While loop continues looping as long as a condition
        ' is True
        Do Until numberGuessed = randomValue

            txtOutput &= "Computer Guessed " & numberGuessed & Environment.NewLine

            numberGuessed += 1

            ' You can exit a Do loop early
            If numberGuessed = 10 Then Exit Do

        Loop

        txtOutput &= "The Computer Guessed it" & Environment.NewLine

        ' ---------- ARRAYS ----------
        txtOutput = ""

        ' Define a fixed size array that can contain 3 elements
        Dim customers() As String = {"Bob", "Sally", "Manny"}

        ' Assign a value to the 3rd element 
        customers(2) = "Paul"

        ' Get the value in an array
        txtOutput &= "#1 Customer " & customers(0) & Environment.NewLine

        ' Sort an array
        Array.Sort(customers)

        ' Reverse the array order
        Array.Reverse(customers)

        ' Change the size of the array and preserve values
        ' Without Preserve the original values would be deleted
        ReDim Preserve customers(5)

        ' Cycle through values in array
        For Each customer As String In customers
            txtOutput &= customer & Environment.NewLine
        Next

        'Declare a multi-dimensional array and set values
        Dim matrix(4, 4) As String

        For i = 0 To 3
            For j = 1 To 3
                matrix(i, j) = i & j
            Next
        Next

        For i = 0 To 3
            For j = 1 To 3
                txtOutput &= matrix(i, j) & " "
            Next
            txtOutput &= Environment.NewLine
        Next


        TextBox1.Text = txtOutput
    End Sub

End Class