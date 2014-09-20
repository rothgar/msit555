' Module:       frmMultA.vb

Option Explicit On

Public Class frmMultA

    Private Sub frmMultA_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Visible = True
        frmFormA = Nothing
    End Sub

    Private Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        frmMain.Visible = True
        Me.Visible = False
    End Sub

    Private Sub frmMultA_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick
        frmMain.Visible = True
        frmFormA = Nothing
        Me.Visible = False
    End Sub

    Private Sub frmMultA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMain.Click
        frmMain.Visible = True
        frmFormA = Nothing
        Me.Visible = False
    End Sub

    Private Sub btnMultB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultB.Click
        If frmFormB Is Nothing Then
            frmFormB = New frmMultB()
            frmFormB.Show()
        End If
        frmFormB.Visible = True
        frmFormA = Nothing
        Me.Visible = False
    End Sub

    Private Sub btnMultC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultC.Click
        If frmFormC Is Nothing Then
            frmFormC = New frmMultC()
            frmFormC.Show()
        End If
        frmFormC.Visible = True
        frmFormA = Nothing
        Me.Visible = False
    End Sub
End Class
