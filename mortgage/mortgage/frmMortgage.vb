' Module:       frmMortgage.vb

Option Explicit On

Public Class frmMortgage

    Private Sub btnCalculate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        '
        'Retrieve principal and interest rate amounts from form's text boxes
        'Use Val function to convert text to values
        'Divide interest rate by 1200 to get monthly interest rate
        '
        Dim gsngPrincipal = Val(Me.txtAmount.Text)
        Dim gsngInterestRate = Val(Me.txtRate.Text) / 1200.0
        Dim gintYears = Val(Me.txtTerm.Text)
        Dim gsngPayment = Val(Me.txtPayment.Text)
        'MsgBox(gsngPrincipal * (gsngInterestRate / (1.0 - (gsngInterestRate + 1) ^ -gintYears)))
        '
        'If either amount is 0 or less, display error message,
        'clear input text boxes, and exit procedure to start over.
        '
        If gsngInterestRate <= 0.0 Then
            MsgBox("Interest rate value is invalid.", 0, "Input Error!")
            Call btnClear_Click(sender, e)
            Exit Sub
        ElseIf gintYears <= 0.0 Then
            MsgBox("Term must be > 0", 0, "Missing Term")
            Exit Sub
        ElseIf gsngPayment <= 0.0 And gsngPrincipal <= 0.0 Then
            MsgBox("Cannot leave Payment and Amount empty", 0, "Missing Input")
            Exit Sub
        ElseIf gsngPayment <= 0.0 Then
            gsngPayment = (gsngPrincipal * (gsngInterestRate / (1.0 - (gsngInterestRate + 1) ^ -gintYears)))
            Me.txtPayment.Text = Format(gsngPayment, "#####.##")
        ElseIf gsngPrincipal <= 0.0 Then
            gsngPrincipal = (gsngPayment * ((1.0 - (gsngInterestRate + 1) ^ -gintYears) / gsngInterestRate))
            Me.txtAmount.Text = Format(gsngPrincipal, "####.##")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        '
        'Clear all text boxes and set focus to Amount text box
        '
        Me.txtAmount.Clear()
        Me.txtPayment.Clear()
        Me.txtRate.Clear()
        Me.txtTerm.Clear()
        Me.ActiveControl = Me.txtAmount
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        '
        ' Exit the program
        '
        End
    End Sub

End Class
