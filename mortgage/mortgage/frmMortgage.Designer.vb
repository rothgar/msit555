<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMortgage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtTerm = New System.Windows.Forms.TextBox()
        Me.lblTerm = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(14, 173)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(106, 13)
        Me.lblAmount.TabIndex = 0
        Me.lblAmount.Text = "Mortgage Amount ($)"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(13, 27)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(85, 13)
        Me.lblRate.TabIndex = 0
        Me.lblRate.Text = "Interest Rate (%)"
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New System.Drawing.Point(12, 240)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(103, 13)
        Me.lblPayment.TabIndex = 0
        Me.lblPayment.Text = "Monthly Payment ($)"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(17, 189)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(135, 20)
        Me.txtAmount.TabIndex = 3
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(17, 43)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(135, 20)
        Me.txtRate.TabIndex = 1
        '
        'txtPayment
        '
        Me.txtPayment.Location = New System.Drawing.Point(16, 256)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(135, 20)
        Me.txtPayment.TabIndex = 4
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(179, 47)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(179, 121)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(179, 199)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtTerm
        '
        Me.txtTerm.Location = New System.Drawing.Point(16, 117)
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.Size = New System.Drawing.Size(135, 20)
        Me.txtTerm.TabIndex = 2
        '
        'lblTerm
        '
        Me.lblTerm.AutoSize = True
        Me.lblTerm.Location = New System.Drawing.Point(12, 101)
        Me.lblTerm.Name = "lblTerm"
        Me.lblTerm.Size = New System.Drawing.Size(74, 13)
        Me.lblTerm.TabIndex = 0
        Me.lblTerm.Text = "Term (months)"
        '
        'frmMortgage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 313)
        Me.Controls.Add(Me.txtTerm)
        Me.Controls.Add(Me.lblTerm)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblPayment)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblAmount)
        Me.Name = "frmMortgage"
        Me.Text = "Mortgage Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents lblPayment As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents txtPayment As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtTerm As System.Windows.Forms.TextBox
    Friend WithEvents lblTerm As System.Windows.Forms.Label

End Class
