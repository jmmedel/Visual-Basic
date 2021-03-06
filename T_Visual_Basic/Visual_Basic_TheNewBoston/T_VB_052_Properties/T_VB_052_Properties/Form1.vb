﻿Public Class Form1
    Private Enum DayAction As Integer
        Asleep = 0
        Wakingup = 1
        School = 2
        Lunch = 3
        Home = 4
        Programming = 5

    End Enum


    Private state As DayAction
    Private Property Hour() As Integer

        Get
            Return DateTimePicker1.Value.Hour
        End Get
        Set(ByVal value As Integer)
            DateTimePicker1.Value = New Date(Now.Year, Now.Month, Now.Day, value, 0, 0)
            If value >= 20 And value < 6 Then
                state = DayAction.Wakingup
            ElseIf value >= 8 And value < 15 Then
                state = DayAction.School
            ElseIf value >= 11 And value < 12 Then
                state = DayAction.Lunch
            ElseIf value > 16 And value < 18 Then
                state = DayAction.Home
            ElseIf value >= 18 And value < 20 Then
                state = DayAction.Home
            End If
            Label1.Text = "At" & value & ":00, Kagaya is " & state.ToString()
        End Set

    End Property


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Hour = Now.Hour

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Me.Hour = DateTimePicker1.Value.Hour
    End Sub
End Class
