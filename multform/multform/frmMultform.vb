' Module:       frmMultform.vb

Option Explicit On

Public Class frmMultform

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnFormA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFormA.Click
        If frmFormA Is Nothing Then
            frmFormA = New frmMultA()
            frmFormA.Show()
        Else
            If frmFormB IsNot Nothing Then
                frmFormB.Visible = False
                frmFormB = Nothing
            End If
            If frmFormC IsNot Nothing Then
                frmFormC.Visible = False
                frmFormC = Nothing
            End If
        End If
        frmFormA.Visible = True
        Me.Visible = False
    End Sub

    Private Sub btnFormB_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFormB.Click
        If frmFormB Is Nothing Then
            frmFormB = New frmMultB()
            frmFormB.Show()
        Else
            If frmFormA IsNot Nothing Then
                frmFormA.Visible = False
                frmFormA = Nothing
            End If
            If frmFormC IsNot Nothing Then
                frmFormC.Visible = False
                frmFormC = Nothing
            End If
            frmFormB.Visible = True
            Me.Visible = False
        End If
    End Sub

    Private Sub btnFormC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFormC.Click
        If frmFormC Is Nothing Then
            frmFormC = New frmMultC()
            frmFormC.Show()
        Else
            If frmFormA IsNot Nothing Then
                frmFormA.Visible = False
                frmFormA = Nothing
            End If
            If frmFormB IsNot Nothing Then
                frmFormB.Visible = False
                frmFormB = Nothing
            End If
            frmFormC.Visible = True
            Me.Visible = False
        End If
    End Sub

    Private Sub frmMultform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
