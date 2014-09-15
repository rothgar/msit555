<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMultform
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
        Me.btnFormA = New System.Windows.Forms.Button()
        Me.btnFormB = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFormA
        '
        Me.btnFormA.Location = New System.Drawing.Point(12, 57)
        Me.btnFormA.Name = "btnFormA"
        Me.btnFormA.Size = New System.Drawing.Size(75, 23)
        Me.btnFormA.TabIndex = 0
        Me.btnFormA.Text = "Form A"
        Me.btnFormA.UseVisualStyleBackColor = True
        '
        'btnFormB
        '
        Me.btnFormB.Location = New System.Drawing.Point(12, 110)
        Me.btnFormB.Name = "btnFormB"
        Me.btnFormB.Size = New System.Drawing.Size(75, 23)
        Me.btnFormB.TabIndex = 1
        Me.btnFormB.Text = "Form B"
        Me.btnFormB.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 170)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMultform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnFormB)
        Me.Controls.Add(Me.btnFormA)
        Me.Name = "frmMultform"
        Me.Text = "Main Form"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFormA As System.Windows.Forms.Button
    Friend WithEvents btnFormB As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
