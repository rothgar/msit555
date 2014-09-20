' Module:       frmMultB.vb

Option Explicit On

Public Class frmMultB

    Private Sub frmMultB_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Visible = True
        frmFormB = Nothing
    End Sub

    Private Sub btnReturn2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn2.Click
        frmMain.Visible = True
        Me.Visible = False
    End Sub

    Private Sub frmMultB_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick
        frmMain.Visible = True
        frmFormB = Nothing
        Me.Visible = False
    End Sub

    Private Sub frmMultB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
        frmFormB = Nothing
        Me.Visible = False
    End Sub

    Private Sub btnMultC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultC.Click
        If frmFormC Is Nothing Then
            frmFormC = New frmMultC()
            frmFormC.Show()
        End If
        frmFormC.Visible = True
        frmFormB = Nothing
        Me.Visible = False
    End Sub

End Class
