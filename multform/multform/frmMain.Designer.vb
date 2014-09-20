<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnForm1 = New System.Windows.Forms.Button()
        Me.btnForm2 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnFrm3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnForm1
        '
        Me.btnForm1.Location = New System.Drawing.Point(12, 57)
        Me.btnForm1.Name = "btnForm1"
        Me.btnForm1.Size = New System.Drawing.Size(75, 23)
        Me.btnForm1.TabIndex = 0
        Me.btnForm1.Text = "Form 1"
        Me.btnForm1.UseVisualStyleBackColor = True
        '
        'btnForm2
        '
        Me.btnForm2.Location = New System.Drawing.Point(12, 110)
        Me.btnForm2.Name = "btnForm2"
        Me.btnForm2.Size = New System.Drawing.Size(75, 23)
        Me.btnForm2.TabIndex = 1
        Me.btnForm2.Text = "Form 2"
        Me.btnForm2.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 213)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnFrm3
        '
        Me.btnFrm3.Location = New System.Drawing.Point(12, 161)
        Me.btnFrm3.Name = "btnFrm3"
        Me.btnFrm3.Size = New System.Drawing.Size(75, 23)
        Me.btnFrm3.TabIndex = 3
        Me.btnFrm3.Text = "Form 3"
        Me.btnFrm3.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnFrm3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnForm2)
        Me.Controls.Add(Me.btnForm1)
        Me.Name = "frmMain"
        Me.Text = "Main Form"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnForm1 As System.Windows.Forms.Button
    Friend WithEvents btnForm2 As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnFrm3 As System.Windows.Forms.Button

End Class
