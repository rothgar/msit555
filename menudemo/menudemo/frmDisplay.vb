' Module:       frmDisplay.vb
' Author:       Justin Garrison
' Organization: Azusa Pacific University
' Application:  MSIT555 – Graphical User Interfaces, menudemo programming project
' Prepared for: Dr. Richard Eckhart
' Description:  Form module for the Menudemo application
'
' Initial Coding:    2014-09-29

Option Explicit On

Public Class frmDisplay

    Private Sub mnuClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuClose.Click

        'Hide the form
        Me.Hide()

    End Sub

    Private Sub SaveFileDialog2_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

    End Sub
End Class
