' Module:       frmMultform.vb

Option Explicit On

Public Class frmMain

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnForm1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnForm1.Click
        If frmFormA Is Nothing Then
            frmFormA = New frmMult1()
            frmFormA.Show()
        Else
            frmFormA.Visible = True
        End If
        Me.Visible = False
    End Sub

    Private Sub btnForm2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnForm2.Click
        If frmFormB Is Nothing Then
            frmFormB = New frmMult2()
            frmFormB.Show()
        Else
            If frmFormA IsNot Nothing Then
                frmFormA.Visible = False
                frmFormA = Nothing
            End If
            frmFormB.Visible = True
        End If
    End Sub

    Private Sub btnFrm3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrm3.Click
        If frmFormB Is Nothing Then
            frmFormB = New frmMult2()
            frmFormB.Show()
        Else
            If frmFormA IsNot Nothing Then
                frmFormA.Visible = False
                frmFormA = Nothing
            End If
            frmFormB.Visible = True
        End If
    End Sub
End Class
