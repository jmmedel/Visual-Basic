Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' This code defines what happens with your form
    ' We define how to handle events like a mouse click on the button


    ' This is a subroutine that doesn't return a value
    ' This code runs every time the button is clicked
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

            ' & is used to join or concatenate strings
            ' txtName.Text returns the value stored in the Text Box
            ' You can also assign values using txtName.Text

            txtName.Text = "Hello " & txtName.Text
        End Sub

        Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

            ' Will close the program
            Me.Close()

        End Sub

        Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click

            ' Opens a message box and says hello to the user
            ' The text after the , is shown in the message box title bar
            MessageBox.Show("Hello " & txtName.Text,
                            "Hello " & txtName.Text)

        End Sub

        Private Sub btnAddValues_Click(sender As Object, e As EventArgs) Handles btnAddValues.Click

            ' If an error could occur surround the error causing code
            ' with a Try block
            Try

                ' Create an Integer variable and store the value
                ' Integers can hold values -2147483648 through +2147483647
                ' A Long holds -9,223,372,036,854,775,808 through 9,223,372,036,854,775,807 
                ' Decimal holds +/-79,228,162,514,264,337,593,543,950,335
                ' and is precise to 29 decimal places
                ' Doubles hold +/-1.79769313486231570E+308 but are not precise
                ' Booleans are True or False
                ' Use CInt() to convert a String into an Integer
                Dim firstNum As Integer = CInt(txtAddVal1.Text)
                Dim secondNum As Integer = CInt(txtAddVal2.Text)

                ' Sum the values
                Dim sum = firstNum + secondNum

                ' Convert the Integer into a String
                ' You could also use sum.ToString
                txtSumAnswer.Text = CStr(sum)

                ' Catch the likely error to avoid crashing your program
            Catch Exc As System.InvalidCastException
                MessageBox.Show("Please enter numbers to sum",
                            "Error")

                ' Print to the Output console
                Console.WriteLine("An error occurred")

            Catch Exc As Exception
                MessageBox.Show("An unknown error occurred",
                            "Error")

            End Try

            ' Other common cast options
            ' CBool : Convert to a Boolean
            ' CDbl : Convert to Double
            ' CDec : Convert to Decimal
            ' CLng : Convert to Long


        End Sub

        Private Sub btnDivideValues_Click(sender As Object, e As EventArgs) Handles btnDivideValues.Click

            ' Create Decimals and convert from String
            Dim firstNum As Decimal = CDec(txtDivideVal1.Text)
            Dim secondNum As Decimal = CDec(txtDivideVal2.Text)

            ' Divide Decimals and then convert the answer into an Integer
            Dim intSolution As Integer = CType(firstNum / secondNum, Integer)

            txtDivisionAnswer.Text = CStr(intSolution)

        End Sub


End Class
