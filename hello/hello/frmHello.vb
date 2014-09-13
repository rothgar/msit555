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

    Private Sub radFrench_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radFrench.CheckedChanged
        Me.txtHello_World.Text = "Bonjour tout le monde!"
    End Sub

    Private Sub radItalian_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radItalian.CheckedChanged
        Me.txtHello_World.Text = "Ciao, mondo!"
    End Sub

    Private Sub radEnglish_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radEnglish.CheckedChanged
        Me.txtHello_World.Text = "Hello, World!"
    End Sub

    Private Sub radSpanish_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radSpanish.CheckedChanged
        Me.txtHello_World.Text = "Hola, mundo!"
    End Sub

    Private Sub radGerman_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGerman.CheckedChanged
        Me.txtHello_World.Text = "Hallo, welt!"
    End Sub
End Class