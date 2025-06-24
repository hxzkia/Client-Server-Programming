<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddAppointment
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
        Me.addAppointmentGB = New System.Windows.Forms.GroupBox()
        Me.descriptionLabel = New System.Windows.Forms.Label()
        Me.descriptionTB = New System.Windows.Forms.TextBox()
        Me.doctorNameCB = New System.Windows.Forms.ComboBox()
        Me.roomTB = New System.Windows.Forms.TextBox()
        Me.roomLabel = New System.Windows.Forms.Label()
        Me.patientNameCB = New System.Windows.Forms.ComboBox()
        Me.patientNameLabel = New System.Windows.Forms.Label()
        Me.timeLabel = New System.Windows.Forms.Label()
        Me.doctorNameLabel = New System.Windows.Forms.Label()
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.datePicker = New System.Windows.Forms.DateTimePicker()
        Me.timePicker = New System.Windows.Forms.DateTimePicker()
        Me.addAppointmentGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'addAppointmentGB
        '
        Me.addAppointmentGB.Controls.Add(Me.timePicker)
        Me.addAppointmentGB.Controls.Add(Me.datePicker)
        Me.addAppointmentGB.Controls.Add(Me.descriptionLabel)
        Me.addAppointmentGB.Controls.Add(Me.descriptionTB)
        Me.addAppointmentGB.Controls.Add(Me.doctorNameCB)
        Me.addAppointmentGB.Controls.Add(Me.roomTB)
        Me.addAppointmentGB.Controls.Add(Me.roomLabel)
        Me.addAppointmentGB.Controls.Add(Me.patientNameCB)
        Me.addAppointmentGB.Controls.Add(Me.patientNameLabel)
        Me.addAppointmentGB.Controls.Add(Me.timeLabel)
        Me.addAppointmentGB.Controls.Add(Me.doctorNameLabel)
        Me.addAppointmentGB.Controls.Add(Me.dateLabel)
        Me.addAppointmentGB.Controls.Add(Me.addBtn)
        Me.addAppointmentGB.Controls.Add(Me.cancelBtn)
        Me.addAppointmentGB.Location = New System.Drawing.Point(16, 16)
        Me.addAppointmentGB.Margin = New System.Windows.Forms.Padding(5)
        Me.addAppointmentGB.Name = "addAppointmentGB"
        Me.addAppointmentGB.Padding = New System.Windows.Forms.Padding(5)
        Me.addAppointmentGB.Size = New System.Drawing.Size(439, 438)
        Me.addAppointmentGB.TabIndex = 5
        Me.addAppointmentGB.TabStop = False
        Me.addAppointmentGB.Text = "Add Appointment"
        '
        'descriptionLabel
        '
        Me.descriptionLabel.AutoSize = True
        Me.descriptionLabel.Location = New System.Drawing.Point(64, 302)
        Me.descriptionLabel.Name = "descriptionLabel"
        Me.descriptionLabel.Size = New System.Drawing.Size(100, 20)
        Me.descriptionLabel.TabIndex = 24
        Me.descriptionLabel.Text = "Description:"
        '
        'descriptionTB
        '
        Me.descriptionTB.Location = New System.Drawing.Point(170, 301)
        Me.descriptionTB.Margin = New System.Windows.Forms.Padding(4)
        Me.descriptionTB.Multiline = True
        Me.descriptionTB.Name = "descriptionTB"
        Me.descriptionTB.Size = New System.Drawing.Size(222, 70)
        Me.descriptionTB.TabIndex = 6
        '
        'doctorNameCB
        '
        Me.doctorNameCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.doctorNameCB.FormattingEnabled = True
        Me.doctorNameCB.Location = New System.Drawing.Point(170, 39)
        Me.doctorNameCB.Name = "doctorNameCB"
        Me.doctorNameCB.Size = New System.Drawing.Size(222, 28)
        Me.doctorNameCB.TabIndex = 1
        '
        'roomTB
        '
        Me.roomTB.Enabled = False
        Me.roomTB.Location = New System.Drawing.Point(170, 249)
        Me.roomTB.Name = "roomTB"
        Me.roomTB.Size = New System.Drawing.Size(222, 27)
        Me.roomTB.TabIndex = 5
        '
        'roomLabel
        '
        Me.roomLabel.AutoSize = True
        Me.roomLabel.Location = New System.Drawing.Point(106, 250)
        Me.roomLabel.Name = "roomLabel"
        Me.roomLabel.Size = New System.Drawing.Size(58, 20)
        Me.roomLabel.TabIndex = 21
        Me.roomLabel.Text = "Room:"
        '
        'patientNameCB
        '
        Me.patientNameCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.patientNameCB.FormattingEnabled = True
        Me.patientNameCB.Location = New System.Drawing.Point(170, 92)
        Me.patientNameCB.Name = "patientNameCB"
        Me.patientNameCB.Size = New System.Drawing.Size(222, 28)
        Me.patientNameCB.TabIndex = 2
        '
        'patientNameLabel
        '
        Me.patientNameLabel.AutoSize = True
        Me.patientNameLabel.Location = New System.Drawing.Point(49, 94)
        Me.patientNameLabel.Name = "patientNameLabel"
        Me.patientNameLabel.Size = New System.Drawing.Size(115, 20)
        Me.patientNameLabel.TabIndex = 20
        Me.patientNameLabel.Text = "Patient Name:"
        '
        'timeLabel
        '
        Me.timeLabel.AutoSize = True
        Me.timeLabel.Location = New System.Drawing.Point(113, 198)
        Me.timeLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(51, 20)
        Me.timeLabel.TabIndex = 18
        Me.timeLabel.Text = "Time:"
        '
        'doctorNameLabel
        '
        Me.doctorNameLabel.AutoSize = True
        Me.doctorNameLabel.Location = New System.Drawing.Point(50, 42)
        Me.doctorNameLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.doctorNameLabel.Name = "doctorNameLabel"
        Me.doctorNameLabel.Size = New System.Drawing.Size(114, 20)
        Me.doctorNameLabel.TabIndex = 14
        Me.doctorNameLabel.Text = "Doctor Name:"
        '
        'dateLabel
        '
        Me.dateLabel.AutoSize = True
        Me.dateLabel.Location = New System.Drawing.Point(114, 146)
        Me.dateLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(50, 20)
        Me.dateLabel.TabIndex = 16
        Me.dateLabel.Text = "Date:"
        '
        'addBtn
        '
        Me.addBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBtn.Location = New System.Drawing.Point(231, 388)
        Me.addBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(94, 40)
        Me.addBtn.TabIndex = 7
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
        Me.cancelBtn.TabIndex = 8
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'datePicker
        '
        Me.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datePicker.Location = New System.Drawing.Point(172, 145)
        Me.datePicker.Name = "datePicker"
        Me.datePicker.Size = New System.Drawing.Size(222, 27)
        Me.datePicker.TabIndex = 3
        Me.datePicker.Value = New Date(2024, 11, 26, 0, 0, 0, 0)
        '
        'timePicker
        '
        Me.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timePicker.Location = New System.Drawing.Point(170, 197)
        Me.timePicker.Name = "timePicker"
        Me.timePicker.Size = New System.Drawing.Size(222, 27)
        Me.timePicker.TabIndex = 4
        Me.timePicker.Value = New Date(2024, 11, 26, 12, 0, 0, 0)
        '
        'frmAddAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(471, 470)
        Me.Controls.Add(Me.addAppointmentGB)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddAppointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Appointment"
        Me.addAppointmentGB.ResumeLayout(False)
        Me.addAppointmentGB.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents addAppointmentGB As GroupBox
    Friend WithEvents doctorNameCB As ComboBox
    Friend WithEvents roomTB As TextBox
    Friend WithEvents roomLabel As Label
    Friend WithEvents patientNameCB As ComboBox
    Friend WithEvents patientNameLabel As Label
    Friend WithEvents timeLabel As Label
    Friend WithEvents doctorNameLabel As Label
    Friend WithEvents dateLabel As Label
    Friend WithEvents addBtn As Button
    Friend WithEvents cancelBtn As Button
    Friend WithEvents descriptionLabel As Label
    Friend WithEvents descriptionTB As TextBox
    Friend WithEvents timePicker As DateTimePicker
    Friend WithEvents datePicker As DateTimePicker
End Class
