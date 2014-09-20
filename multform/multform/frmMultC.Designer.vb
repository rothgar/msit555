<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMultC
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
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.btnMultA = New System.Windows.Forms.Button()
        Me.btnMultB = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(97, 185)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 23)
        Me.btnReturn.TabIndex = 0
        Me.btnReturn.Text = "Close"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnMain
        '
        Me.btnMain.Location = New System.Drawing.Point(97, 32)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(75, 23)
        Me.btnMain.TabIndex = 1
        Me.btnMain.Text = "Main"
        Me.btnMain.UseVisualStyleBackColor = True
        '
        'btnMultA
        '
        Me.btnMultA.Location = New System.Drawing.Point(97, 81)
        Me.btnMultA.Name = "btnMultA"
        Me.btnMultA.Size = New System.Drawing.Size(75, 23)
        Me.btnMultA.TabIndex = 2
        Me.btnMultA.Text = "Form 1"
        Me.btnMultA.UseVisualStyleBackColor = True
        '
        'btnMultB
        '
        Me.btnMultB.Location = New System.Drawing.Point(97, 135)
        Me.btnMultB.Name = "btnMultB"
        Me.btnMultB.Size = New System.Drawing.Size(75, 23)
        Me.btnMultB.TabIndex = 3
        Me.btnMultB.Text = "Form 2"
        Me.btnMultB.UseVisualStyleBackColor = True
        '
        'frmMultC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnMultB)
        Me.Controls.Add(Me.btnMultA)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.btnReturn)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMultC"
        Me.Text = "Form 3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnMain As System.Windows.Forms.Button
    Friend WithEvents btnMultA As System.Windows.Forms.Button
    Friend WithEvents btnMultB As System.Windows.Forms.Button
End Class
