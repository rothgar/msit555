' Module:       frmHello.vb
' Author:       Richard A. Eckhart
' Organization: Azusa Pacific University
' Application:  MSIT555 – Graphical User Interfaces, hello programming project
' Prepared for: Dr. Richard Eckhart
' Description:  Form module for the Hello World! application
'
' Initial Coding:    1-1-2013 - RAE
' Revisions:

Option Explicit On

Public Class frmHello

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If radEnglish.Checked Then
            txtHello_World.Text = "Hello, world!"
        ElseIf Me.radFrench.Checked = CBool(1) Then
            Me.txtHello_World.Text = "Bonjour tout le monde!"
        ElseIf radItalian.Checked = True Then
            txtHello_World.Text = "Ciao, mondo!"
        End If
    End Sub

End Class