' Module:       frmMultC.vb

Option Explicit On

Public Class frmMultC

    Private Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        frmMain.Visible = True
        Me.Visible = False
    End Sub

    Private Sub frmMultC_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Visible = True
        frmFormC = Nothing
    End Sub

    Private Sub frmMultC_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick
        frmMain.Visible = True
        frmFormC = Nothing
        Me.Visible = False
    End Sub

    Private Sub frmMultC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMain.Click
        frmMain.Visible = True
        frmFormC = Nothing
        Me.Visible = False
    End Sub

    Private Sub btnMultA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultA.Click
        If frmFormA Is Nothing Then
            frmFormA = New frmMultA()
            frmFormA.Show()
        End If
        frmFormA.Visible = True
        frmFormC = Nothing
        Me.Visible = False
    End Sub

    Private Sub btnMultB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultB.Click
        If frmFormB Is Nothing Then
            frmFormB = New frmMultB()
            frmFormB.Show()
        End If
        frmFormB.Visible = True
        frmFormC = Nothing
        Me.Visible = False
    End Sub

End Class
