﻿Public Class Buttons
    Private _userControlList As New List(Of ucButton)
    Private WithEvents _board As BoardInterface
    Public Sub New(board As BoardInterface)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _board = board
    End Sub
    Private Sub Buttons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 5
            Dim userControl As New ucButton(i)
            userControl.Location = New Point(1, i * 25 + 50)
            Me.Controls.Add(userControl)
            _userControlList.Add(userControl)
        Next
        For i As Integer = 0 To 5
            Dim userControl As New ucButton(i + 6)
            userControl.Location = New Point(60, i * 25 + 50)
            Me.Controls.Add(userControl)
            _userControlList.Add(userControl)
        Next
        For i As Integer = 0 To 5
            Dim userControl As New ucButton(i + 12)
            userControl.Location = New Point(120, i * 25 + 50)
            Me.Controls.Add(userControl)
            _userControlList.Add(userControl)
        Next
        For i As Integer = 0 To 5
            Dim userControl As New ucButton(i + 18)
            userControl.Location = New Point(180, i * 25 + 50)
            Me.Controls.Add(userControl)
            _userControlList.Add(userControl)
        Next
        Try
            _board.enableAdminFunction(ADMIN.BUTTONS)
        Catch ex As Exception
            MessageBox.Show("Unable to set to button mode")
        End Try


    End Sub
    Private Sub _board_BoardChanged(sender As Object, e As BoardChangedArgs) Handles _board.BoardChanged
        Try
            If e.type = MESSAGE_TYPE.BUTTONS Then
                For i As Integer = 0 To 23
                    _userControlList.Item(i).setButtonValue(e.buttons(i))
                Next
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Outputs_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            _board.enableAdminFunction(ADMIN.OFF)
        Catch ex As Exception
            MessageBox.Show("Unable to set turn off button mode, maybe board is disconnected?")
        End Try

    End Sub
End Class