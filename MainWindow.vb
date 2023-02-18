﻿Public Class MainWindow
    Private WithEvents arduino As RS232
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each sp As String In My.Computer.Ports.SerialPortNames

            Dim testConnect As New RS232(sp)
            Try
                testConnect.open()

                Dim result As String = testConnect.read()
            Catch ex As Exception

            End Try


        Next
        arduino = New RS232("COM3")
        arduino.open()

    End Sub

    Private Sub arduino_RS232Changed(sender As Object, e As RS232ChangedArgs) Handles arduino.RS232Changed
        'TextBox1.Text = e.message
    End Sub
    Private Sub arduino_RS232Disconnected(sender As Object, e As RS232CompletedArgs) Handles arduino.RS232Completed
        MessageBox.Show("disconnected")
    End Sub
End Class
