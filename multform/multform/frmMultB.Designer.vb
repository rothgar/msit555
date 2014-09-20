<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMultB
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
        Me.btnReturn2 = New System.Windows.Forms.Button()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.btnMultA = New System.Windows.Forms.Button()
        Me.btnMultC = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnReturn2
        '
        Me.btnReturn2.Location = New System.Drawing.Point(93, 203)
        Me.btnReturn2.Name = "btnReturn2"
        Me.btnReturn2.Size = New System.Drawing.Size(75, 23)
        Me.btnReturn2.TabIndex = 0
        Me.btnReturn2.Text = "Close"
        Me.btnReturn2.UseVisualStyleBackColor = True
        '
        'btnMain
        '
        Me.btnMain.Location = New System.Drawing.Point(93, 34)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(75, 23)
        Me.btnMain.TabIndex = 1
        Me.btnMain.Text = "Main"
        Me.btnMain.UseVisualStyleBackColor = True
        '
        'btnMultA
        '
        Me.btnMultA.Location = New System.Drawing.Point(93, 84)
        Me.btnMultA.Name = "btnMultA"
        Me.btnMultA.Size = New System.Drawing.Size(75, 23)
        Me.btnMultA.TabIndex = 2
        Me.btnMultA.Text = "Form 1"
        Me.btnMultA.UseVisualStyleBackColor = True
        '
        'btnMultC
        '
        Me.btnMultC.Location = New System.Drawing.Point(93, 144)
        Me.btnMultC.Name = "btnMultC"
        Me.btnMultC.Size = New System.Drawing.Size(75, 23)
        Me.btnMultC.TabIndex = 3
        Me.btnMultC.Text = "Form 3"
        Me.btnMultC.UseVisualStyleBackColor = True
        '
        'frmMultB
        '
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnMultC)
        Me.Controls.Add(Me.btnMultA)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.btnReturn2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMultB"
        Me.Text = "Form 2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnReturn2 As System.Windows.Forms.Button
    Friend WithEvents btnMain As System.Windows.Forms.Button
    Friend WithEvents btnMultA As System.Windows.Forms.Button
    Friend WithEvents btnMultC As System.Windows.Forms.Button
End Class
