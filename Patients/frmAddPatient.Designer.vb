<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPatient
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
        Me.addPatientGB = New System.Windows.Forms.GroupBox()
        Me.phoneTB = New System.Windows.Forms.TextBox()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.emailTB = New System.Windows.Forms.TextBox()
        Me.nameTB = New System.Windows.Forms.TextBox()
        Me.phoneLabel = New System.Windows.Forms.Label()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.addPatientGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'addPatientGB
        '
        Me.addPatientGB.Controls.Add(Me.phoneTB)
        Me.addPatientGB.Controls.Add(Me.addBtn)
        Me.addPatientGB.Controls.Add(Me.cancelBtn)
        Me.addPatientGB.Controls.Add(Me.emailTB)
        Me.addPatientGB.Controls.Add(Me.nameTB)
        Me.addPatientGB.Controls.Add(Me.phoneLabel)
        Me.addPatientGB.Controls.Add(Me.emailLabel)
        Me.addPatientGB.Controls.Add(Me.nameLabel)
        Me.addPatientGB.Location = New System.Drawing.Point(16, 16)
        Me.addPatientGB.Margin = New System.Windows.Forms.Padding(5)
        Me.addPatientGB.Name = "addPatientGB"
        Me.addPatientGB.Padding = New System.Windows.Forms.Padding(5)
        Me.addPatientGB.Size = New System.Drawing.Size(439, 438)
        Me.addPatientGB.TabIndex = 3
        Me.addPatientGB.TabStop = False
        Me.addPatientGB.Text = "Add Patient"
        '
        'phoneTB
        '
        Me.phoneTB.Location = New System.Drawing.Point(172, 281)
        Me.phoneTB.Margin = New System.Windows.Forms.Padding(5)
        Me.phoneTB.Name = "phoneTB"
        Me.phoneTB.Size = New System.Drawing.Size(222, 27)
        Me.phoneTB.TabIndex = 3
        '
        'addBtn
        '
        Me.addBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBtn.Location = New System.Drawing.Point(231, 388)
        Me.addBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(94, 40)
        Me.addBtn.TabIndex = 4
        Me.addBtn.Text = "Add"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBtn.Location = New System.Drawing.Point(335, 388)
        Me.cancelBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(94, 40)
        Me.cancelBtn.TabIndex = 5
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'emailTB
        '
        Me.emailTB.Location = New System.Drawing.Point(172, 206)
        Me.emailTB.Margin = New System.Windows.Forms.Padding(5)
        Me.emailTB.Name = "emailTB"
        Me.emailTB.Size = New System.Drawing.Size(222, 27)
        Me.emailTB.TabIndex = 2
        '
        'nameTB
        '
        Me.nameTB.Location = New System.Drawing.Point(172, 131)
        Me.nameTB.Margin = New System.Windows.Forms.Padding(5)
        Me.nameTB.Name = "nameTB"
        Me.nameTB.Size = New System.Drawing.Size(222, 27)
        Me.nameTB.TabIndex = 1
        '
        'phoneLabel
        '
        Me.phoneLabel.AutoSize = True
        Me.phoneLabel.Location = New System.Drawing.Point(44, 283)
        Me.phoneLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.phoneLabel.Name = "phoneLabel"
        Me.phoneLabel.Size = New System.Drawing.Size(118, 20)
        Me.phoneLabel.TabIndex = 5
        Me.phoneLabel.Text = "Patient Phone:"
        '
        'emailLabel
        '
        Me.emailLabel.AutoSize = True
        Me.emailLabel.Location = New System.Drawing.Point(49, 209)
        Me.emailLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(113, 20)
        Me.emailLabel.TabIndex = 2
        Me.emailLabel.Text = "Patient Email:"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(47, 135)
        Me.nameLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(115, 20)
        Me.nameLabel.TabIndex = 1
        Me.nameLabel.Text = "Patient Name:"
        '
        'frmAddPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(471, 470)
        Me.Controls.Add(Me.addPatientGB)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddPatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Patient"
        Me.addPatientGB.ResumeLayout(False)
        Me.addPatientGB.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents addPatientGB As GroupBox
    Friend WithEvents phoneTB As TextBox
    Friend WithEvents addBtn As Button
    Friend WithEvents cancelBtn As Button
    Friend WithEvents emailTB As TextBox
    Friend WithEvents nameTB As TextBox
    Friend WithEvents phoneLabel As Label
    Friend WithEvents emailLabel As Label
    Friend WithEvents nameLabel As Label
End Class
