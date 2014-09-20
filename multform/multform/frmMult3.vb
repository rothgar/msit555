' Module:       frmMultB.vb

Option Explicit On

Public Class frmMult2

    Private Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        frmMain.Visible = True
        Me.Visible = False
    End Sub

    Private Sub frmMultB_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Visible = True
        frmFormB = Nothing
    End Sub

End Class
