Public Class Form1

    Private Enum Sports As Integer
        baseball = 0
        basketball = 1
        football = 2

    End Enum

    Private mySport As Sports

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each item As Integer In System.Enum.GetValues(GetType(Sports))
            listEnumValue.Items.Add(item.ToString())
        Next



        For Each item As String In System.Enum.GetNames(GetType(Sports))
            list_Enum_Name.Items.Add(item)
        Next
        analzsports(mySport)
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        If ComboBox1.SelectedIndex <> -1 Then
            mySport = ComboBox1.SelectedIndex
        End If
    End Sub

    Private Sub analzsports(ByVal sportsList As Sports)

        Select Case sportsList
            Case Is = Sports.baseball
                MessageBox.Show("Your Sport is baseball ")
            Case Is = Sports.football
                MessageBox.Show("Your sport is football ")
            Case Is = Sports.baseball
                MessageBox.Show("You sport is basketball")
            Case Else
                MsgBox("You dont have a  sport")
        End Select

    End Sub

    Private Sub clearlist()
        list_Enum_Name.Items.Clear()
        listEnumValue.Items.Clear()

    End Sub


End Class
