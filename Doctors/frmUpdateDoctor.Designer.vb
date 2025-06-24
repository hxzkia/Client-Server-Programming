<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateDoctor
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
        Me.updateDoctorGB = New System.Windows.Forms.GroupBox()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.emailTB = New System.Windows.Forms.TextBox()
        Me.nameTB = New System.Windows.Forms.TextBox()
        Me.phoneTB = New System.Windows.Forms.TextBox()
        Me.idTB = New System.Windows.Forms.TextBox()
        Me.phoneLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.idLabel = New System.Windows.Forms.Label()
        Me.specializationLabel = New System.Windows.Forms.Label()
        Me.specializationCB = New System.Windows.Forms.ComboBox()
        Me.roomLabel = New System.Windows.Forms.Label()
        Me.roomTB = New System.Windows.Forms.TextBox()
        Me.updateDoctorGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'updateDoctorGB
        '
        Me.updateDoctorGB.Controls.Add(Me.roomTB)
        Me.updateDoctorGB.Controls.Add(Me.roomLabel)
        Me.updateDoctorGB.Controls.Add(Me.specializationCB)
        Me.updateDoctorGB.Controls.Add(Me.specializationLabel)
        Me.updateDoctorGB.Controls.Add(Me.updateBtn)
        Me.updateDoctorGB.Controls.Add(Me.cancelBtn)
        Me.updateDoctorGB.Controls.Add(Me.emailTB)
        Me.updateDoctorGB.Controls.Add(Me.nameTB)
        Me.updateDoctorGB.Controls.Add(Me.phoneTB)
        Me.updateDoctorGB.Controls.Add(Me.idTB)
        Me.updateDoctorGB.Controls.Add(Me.phoneLabel)
        Me.updateDoctorGB.Controls.Add(Me.nameLabel)
        Me.updateDoctorGB.Controls.Add(Me.emailLabel)
        Me.updateDoctorGB.Controls.Add(Me.idLabel)
        Me.updateDoctorGB.Location = New System.Drawing.Point(16, 16)
        Me.updateDoctorGB.Margin = New System.Windows.Forms.Padding(5)
        Me.updateDoctorGB.Name = "updateDoctorGB"
        Me.updateDoctorGB.Padding = New System.Windows.Forms.Padding(5)
        Me.updateDoctorGB.Size = New System.Drawing.Size(439, 438)
        Me.updateDoctorGB.TabIndex = 4
        Me.updateDoctorGB.TabStop = False
        Me.updateDoctorGB.Text = "Update Doctor"
        '
        'updateBtn
        '
        Me.updateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateBtn.Location = New System.Drawing.Point(231, 388)
        Me.updateBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(94, 40)
        Me.updateBtn.TabIndex = 6
        Me.updateBtn.Text = "Update"
        Me.updateBtn.UseVisualStyleBackColor = True
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
        'emailTB
        '
        Me.emailTB.Location = New System.Drawing.Point(166, 224)
        Me.emailTB.Margin = New System.Windows.Forms.Padding(5)
        Me.emailTB.Name = "emailTB"
        Me.emailTB.Size = New System.Drawing.Size(222, 27)
        Me.emailTB.TabIndex = 3
        '
        'nameTB
        '
        Me.nameTB.Location = New System.Drawing.Point(166, 113)
        Me.nameTB.Margin = New System.Windows.Forms.Padding(5)
        Me.nameTB.Name = "nameTB"
        Me.nameTB.Size = New System.Drawing.Size(222, 27)
        Me.nameTB.TabIndex = 1
        '
        'phoneTB
        '
        Me.phoneTB.Location = New System.Drawing.Point(166, 279)
        Me.phoneTB.Margin = New System.Windows.Forms.Padding(5)
        Me.phoneTB.Name = "phoneTB"
        Me.phoneTB.Size = New System.Drawing.Size(222, 27)
        Me.phoneTB.TabIndex = 4
        '
        'idTB
        '
        Me.idTB.Location = New System.Drawing.Point(166, 58)
        Me.idTB.Margin = New System.Windows.Forms.Padding(5)
        Me.idTB.Name = "idTB"
        Me.idTB.ReadOnly = True
        Me.idTB.Size = New System.Drawing.Size(222, 27)
        Me.idTB.TabIndex = 0
        '
        'phoneLabel
        '
        Me.phoneLabel.AutoSize = True
        Me.phoneLabel.Location = New System.Drawing.Point(38, 281)
        Me.phoneLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.phoneLabel.Name = "phoneLabel"
        Me.phoneLabel.Size = New System.Drawing.Size(117, 20)
        Me.phoneLabel.TabIndex = 4
        Me.phoneLabel.Text = "Doctor Phone:"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(41, 116)
        Me.nameLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(114, 20)
        Me.nameLabel.TabIndex = 2
        Me.nameLabel.Text = "Doctor Name:"
        '
        'emailLabel
        '
        Me.emailLabel.AutoSize = True
        Me.emailLabel.Location = New System.Drawing.Point(43, 226)
        Me.emailLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(112, 20)
        Me.emailLabel.TabIndex = 3
        Me.emailLabel.Text = "Doctor Email:"
        '
        'idLabel
        '
        Me.idLabel.AutoSize = True
        Me.idLabel.Location = New System.Drawing.Point(68, 61)
        Me.idLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.idLabel.Name = "idLabel"
        Me.idLabel.Size = New System.Drawing.Size(87, 20)
        Me.idLabel.TabIndex = 1
        Me.idLabel.Text = "Doctor ID:"
        '
        'specializationLabel
        '
        Me.specializationLabel.AutoSize = True
        Me.specializationLabel.Location = New System.Drawing.Point(37, 171)
        Me.specializationLabel.Name = "specializationLabel"
        Me.specializationLabel.Size = New System.Drawing.Size(118, 20)
        Me.specializationLabel.TabIndex = 7
        Me.specializationLabel.Text = "Specialization:"
        '
        'specializationCB
        '
        Me.specializationCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.specializationCB.FormattingEnabled = True
        Me.specializationCB.Location = New System.Drawing.Point(166, 168)
        Me.specializationCB.Name = "specializationCB"
        Me.specializationCB.Size = New System.Drawing.Size(222, 28)
        Me.specializationCB.TabIndex = 2
        '
        'roomLabel
        '
        Me.roomLabel.AutoSize = True
        Me.roomLabel.Location = New System.Drawing.Point(41, 336)
        Me.roomLabel.Name = "roomLabel"
        Me.roomLabel.Size = New System.Drawing.Size(114, 20)
        Me.roomLabel.TabIndex = 9
        Me.roomLabel.Text = "Doctor Room:"
        '
        'roomTB
        '
        Me.roomTB.Location = New System.Drawing.Point(166, 334)
        Me.roomTB.Name = "roomTB"
        Me.roomTB.Size = New System.Drawing.Size(222, 27)
        Me.roomTB.TabIndex = 5
        '
        'frmUpdateDoctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(471, 470)
        Me.Controls.Add(Me.updateDoctorGB)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdateDoctor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Doctor"
        Me.updateDoctorGB.ResumeLayout(False)
        Me.updateDoctorGB.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents updateDoctorGB As GroupBox
    Friend WithEvents updateBtn As Button
    Friend WithEvents cancelBtn As Button
    Friend WithEvents emailTB As TextBox
    Friend WithEvents nameTB As TextBox
    Friend WithEvents phoneTB As TextBox
    Friend WithEvents idTB As TextBox
    Friend WithEvents phoneLabel As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents emailLabel As Label
    Friend WithEvents idLabel As Label
    Friend WithEvents roomTB As TextBox
    Friend WithEvents roomLabel As Label
    Friend WithEvents specializationCB As ComboBox
    Friend WithEvents specializationLabel As Label
End Class
