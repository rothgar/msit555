<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintdemo
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
        Me.btnPrinttext = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblPrinttext = New System.Windows.Forms.Label()
        Me.txtPrinttext = New System.Windows.Forms.TextBox()
        Me.dlgPageSetup = New System.Windows.Forms.PageSetupDialog()
        Me.dlgPrint = New System.Windows.Forms.PrintDialog()
        Me.docPrint = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'btnPrinttext
        '
        Me.btnPrinttext.Location = New System.Drawing.Point(93, 312)
        Me.btnPrinttext.Name = "btnPrinttext"
        Me.btnPrinttext.Size = New System.Drawing.Size(162, 28)
        Me.btnPrinttext.TabIndex = 1
        Me.btnPrinttext.Text = "Print contents of text box"
        Me.btnPrinttext.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(323, 315)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblPrinttext
        '
        Me.lblPrinttext.AutoSize = True
        Me.lblPrinttext.Location = New System.Drawing.Point(49, 9)
        Me.lblPrinttext.Name = "lblPrinttext"
        Me.lblPrinttext.Size = New System.Drawing.Size(450, 13)
        Me.lblPrinttext.TabIndex = 0
        Me.lblPrinttext.Text = "Enter any text in the text box.  Then press the ‘Print Contents of the Text Box’ " & _
            "button to print it."
        '
        'txtPrinttext
        '
        Me.txtPrinttext.Location = New System.Drawing.Point(25, 44)
        Me.txtPrinttext.Multiline = True
        Me.txtPrinttext.Name = "txtPrinttext"
        Me.txtPrinttext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPrinttext.Size = New System.Drawing.Size(496, 262)
        Me.txtPrinttext.TabIndex = 3
        '
        'dlgPrint
        '
        Me.dlgPrint.UseEXDialog = True
        '
        'docPrint
        '
        '
        'frmPrintdemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 352)
        Me.Controls.Add(Me.txtPrinttext)
        Me.Controls.Add(Me.lblPrinttext)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrinttext)
        Me.Name = "frmPrintdemo"
        Me.Text = "Print Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPrinttext As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblPrinttext As System.Windows.Forms.Label
    Friend WithEvents txtPrinttext As System.Windows.Forms.TextBox
    Friend WithEvents dlgPageSetup As System.Windows.Forms.PageSetupDialog
    Friend WithEvents dlgPrint As System.Windows.Forms.PrintDialog
    Friend WithEvents docPrint As System.Drawing.Printing.PrintDocument

End Class
