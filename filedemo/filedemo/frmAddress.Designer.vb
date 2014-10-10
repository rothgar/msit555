<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddress
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.lblAdress = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.mnuAdress = New System.Windows.Forms.MenuStrip()
        Me.mnuAddressClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdress.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(393, 42)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(393, 117)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(393, 182)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(393, 240)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 3
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Location = New System.Drawing.Point(29, 42)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(57, 13)
        Me.lblFname.TabIndex = 4
        Me.lblFname.Text = "First Name"
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.Location = New System.Drawing.Point(28, 81)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(58, 13)
        Me.lblLname.TabIndex = 5
        Me.lblLname.Text = "Last Name"
        '
        'lblAdress
        '
        Me.lblAdress.AutoSize = True
        Me.lblAdress.Location = New System.Drawing.Point(28, 127)
        Me.lblAdress.Name = "lblAdress"
        Me.lblAdress.Size = New System.Drawing.Size(45, 13)
        Me.lblAdress.TabIndex = 6
        Me.lblAdress.Text = "Address"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(28, 169)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(24, 13)
        Me.lblCity.TabIndex = 7
        Me.lblCity.Text = "City"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(28, 208)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(32, 13)
        Me.lblState.TabIndex = 8
        Me.lblState.Text = "State"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(28, 245)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(22, 13)
        Me.lblZip.TabIndex = 9
        Me.lblZip.Text = "Zip"
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(102, 39)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(269, 20)
        Me.txtFname.TabIndex = 0
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(102, 78)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(269, 20)
        Me.txtLname.TabIndex = 1
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(102, 124)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(269, 20)
        Me.txtAddress.TabIndex = 2
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(102, 166)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(269, 20)
        Me.txtCity.TabIndex = 3
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(102, 205)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(269, 20)
        Me.txtState.TabIndex = 4
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(102, 242)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(269, 20)
        Me.txtZip.TabIndex = 5
        '
        'mnuAdress
        '
        Me.mnuAdress.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAddressClose})
        Me.mnuAdress.Location = New System.Drawing.Point(0, 0)
        Me.mnuAdress.Name = "mnuAdress"
        Me.mnuAdress.Size = New System.Drawing.Size(503, 24)
        Me.mnuAdress.TabIndex = 10
        Me.mnuAdress.Text = "Address Menu"
        '
        'mnuAddressClose
        '
        Me.mnuAddressClose.Name = "mnuAddressClose"
        Me.mnuAddressClose.Size = New System.Drawing.Size(48, 20)
        Me.mnuAddressClose.Text = "&Close"
        '
        'frmAddress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 298)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblAdress)
        Me.Controls.Add(Me.lblLname)
        Me.Controls.Add(Me.lblFname)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.mnuAdress)
        Me.MainMenuStrip = Me.mnuAdress
        Me.Name = "frmAddress"
        Me.Text = "Enter or Read Addresses"
        Me.mnuAdress.ResumeLayout(False)
        Me.mnuAdress.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents lblFname As System.Windows.Forms.Label
    Friend WithEvents lblLname As System.Windows.Forms.Label
    Friend WithEvents lblAdress As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents mnuAdress As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuAddressClose As System.Windows.Forms.ToolStripMenuItem
End Class
