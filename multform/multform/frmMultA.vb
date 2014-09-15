' Module:       frmMultA.vb

Option Explicit On

Public Class frmMultA

    Private Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        frmMain.Visible = True
        Me.Visible = False
    End Sub

    Private Sub frmMultA_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Visible = True
        frmFormA = Nothing
    End Sub

End Class
