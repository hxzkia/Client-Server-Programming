<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddDoctor
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
        Me.addDoctorGB = New System.Windows.Forms.GroupBox()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.roomTB = New System.Windows.Forms.TextBox()
        Me.roomLabel = New System.Windows.Forms.Label()
        Me.specializationCB = New System.Windows.Forms.ComboBox()
        Me.specializationLabel = New System.Windows.Forms.Label()
        Me.emailTB = New System.Windows.Forms.TextBox()
        Me.nameTB = New System.Windows.Forms.TextBox()
        Me.phoneTB = New System.Windows.Forms.TextBox()
        Me.phoneLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.addDoctorGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'addDoctorGB
        '
        Me.addDoctorGB.Controls.Add(Me.roomTB)
        Me.addDoctorGB.Controls.Add(Me.roomLabel)
        Me.addDoctorGB.Controls.Add(Me.specializationCB)
        Me.addDoctorGB.Controls.Add(Me.specializationLabel)
        Me.addDoctorGB.Controls.Add(Me.emailTB)
        Me.addDoctorGB.Controls.Add(Me.nameTB)
        Me.addDoctorGB.Controls.Add(Me.phoneTB)
        Me.addDoctorGB.Controls.Add(Me.phoneLabel)
        Me.addDoctorGB.Controls.Add(Me.nameLabel)
        Me.addDoctorGB.Controls.Add(Me.emailLabel)
        Me.addDoctorGB.Controls.Add(Me.addBtn)
        Me.addDoctorGB.Controls.Add(Me.cancelBtn)
        Me.addDoctorGB.Location = New System.Drawing.Point(16, 16)
        Me.addDoctorGB.Margin = New System.Windows.Forms.Padding(5)
        Me.addDoctorGB.Name = "addDoctorGB"
        Me.addDoctorGB.Padding = New System.Windows.Forms.Padding(5)
        Me.addDoctorGB.Size = New System.Drawing.Size(439, 438)
        Me.addDoctorGB.TabIndex = 4
        Me.addDoctorGB.TabStop = False
        Me.addDoctorGB.Text = "Add Doctor"
        '
        'addBtn
        '
        Me.addBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBtn.Location = New System.Drawing.Point(231, 388)
        Me.addBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(94, 40)
        Me.addBtn.TabIndex = 6
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
        Me.cancelBtn.TabIndex = 7
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'roomTB
        '
        Me.roomTB.Location = New System.Drawing.Point(173, 316)
        Me.roomTB.Name = "roomTB"
        Me.roomTB.Size = New System.Drawing.Size(222, 27)
        Me.roomTB.TabIndex = 5
        '
        'roomLabel
        '
        Me.roomLabel.AutoSize = True
        Me.roomLabel.Location = New System.Drawing.Point(48, 318)
        Me.roomLabel.Name = "roomLabel"
        Me.roomLabel.Size = New System.Drawing.Size(114, 20)
        Me.roomLabel.TabIndex = 21
        Me.roomLabel.Text = "Doctor Room:"
        '
        'specializationCB
        '
        Me.specializationCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.specializationCB.FormattingEnabled = True
        Me.specializationCB.Location = New System.Drawing.Point(173, 150)
        Me.specializationCB.Name = "specializationCB"
        Me.specializationCB.Size = New System.Drawing.Size(222, 28)
        Me.specializationCB.TabIndex = 2
        '
        'specializationLabel
        '
        Me.specializationLabel.AutoSize = True
        Me.specializationLabel.Location = New System.Drawing.Point(44, 153)
        Me.specializationLabel.Name = "specializationLabel"
        Me.specializationLabel.Size = New System.Drawing.Size(118, 20)
        Me.specializationLabel.TabIndex = 20
        Me.specializationLabel.Text = "Specialization:"
        '
        'emailTB
        '
        Me.emailTB.Location = New System.Drawing.Point(173, 206)
        Me.emailTB.Margin = New System.Windows.Forms.Padding(5)
        Me.emailTB.Name = "emailTB"
        Me.emailTB.Size = New System.Drawing.Size(222, 27)
        Me.emailTB.TabIndex = 3
        '
        'nameTB
        '
        Me.nameTB.Location = New System.Drawing.Point(173, 95)
        Me.nameTB.Margin = New System.Windows.Forms.Padding(5)
        Me.nameTB.Name = "nameTB"
        Me.nameTB.Size = New System.Drawing.Size(222, 27)
        Me.nameTB.TabIndex = 1
        '
        'phoneTB
        '
        Me.phoneTB.Location = New System.Drawing.Point(173, 261)
        Me.phoneTB.Margin = New System.Windows.Forms.Padding(5)
        Me.phoneTB.Name = "phoneTB"
        Me.phoneTB.Size = New System.Drawing.Size(222, 27)
        Me.phoneTB.TabIndex = 4
        '
        'phoneLabel
        '
        Me.phoneLabel.AutoSize = True
        Me.phoneLabel.Location = New System.Drawing.Point(45, 263)
        Me.phoneLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.phoneLabel.Name = "phoneLabel"
        Me.phoneLabel.Size = New System.Drawing.Size(117, 20)
        Me.phoneLabel.TabIndex = 18
        Me.phoneLabel.Text = "Doctor Phone:"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(48, 98)
        Me.nameLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(114, 20)
        Me.nameLabel.TabIndex = 14
        Me.nameLabel.Text = "Doctor Name:"
        '
        'emailLabel
        '
        Me.emailLabel.AutoSize = True
        Me.emailLabel.Location = New System.Drawing.Point(50, 208)
        Me.emailLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(112, 20)
        Me.emailLabel.TabIndex = 16
        Me.emailLabel.Text = "Doctor Email:"
        '
        'frmAddDoctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(471, 470)
        Me.Controls.Add(Me.addDoctorGB)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddDoctor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Doctor"
        Me.addDoctorGB.ResumeLayout(False)
        Me.addDoctorGB.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents addDoctorGB As GroupBox
    Friend WithEvents addBtn As Button
    Friend WithEvents cancelBtn As Button
    Friend WithEvents roomTB As TextBox
    Friend WithEvents roomLabel As Label
    Friend WithEvents specializationCB As ComboBox
    Friend WithEvents specializationLabel As Label
    Friend WithEvents emailTB As TextBox
    Friend WithEvents nameTB As TextBox
    Friend WithEvents phoneTB As TextBox
    Friend WithEvents phoneLabel As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents emailLabel As Label
End Class
