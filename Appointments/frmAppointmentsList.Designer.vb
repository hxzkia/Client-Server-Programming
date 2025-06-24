<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppointmentsList
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
        Me.components = New System.ComponentModel.Container()
        Me.keywordGB = New System.Windows.Forms.GroupBox()
        Me.keywordCB = New System.Windows.Forms.ComboBox()
        Me.newAppointmentBtn = New System.Windows.Forms.Button()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.searchGB = New System.Windows.Forms.GroupBox()
        Me.searchTB = New System.Windows.Forms.TextBox()
        Me.dgvAppointment = New System.Windows.Forms.DataGridView()
        Me.AppointmentIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppointmentCodeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoctorIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoctorNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppointmentDateCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppointmentTimeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppointmentDescriptionCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppointmentRoomCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppointmentStatusCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppointmentStatusStrCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.displayCheckBox = New System.Windows.Forms.CheckBox()
        Me.appointmentCMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UpdateAppointmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.reportBtn = New System.Windows.Forms.Button()
        Me.keywordGB.SuspendLayout()
        Me.searchGB.SuspendLayout()
        CType(Me.dgvAppointment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.appointmentCMS.SuspendLayout()
        Me.SuspendLayout()
        '
        'keywordGB
        '
        Me.keywordGB.Controls.Add(Me.keywordCB)
        Me.keywordGB.Location = New System.Drawing.Point(452, 14)
        Me.keywordGB.Margin = New System.Windows.Forms.Padding(4)
        Me.keywordGB.Name = "keywordGB"
        Me.keywordGB.Padding = New System.Windows.Forms.Padding(4)
        Me.keywordGB.Size = New System.Drawing.Size(399, 86)
        Me.keywordGB.TabIndex = 14
        Me.keywordGB.TabStop = False
        Me.keywordGB.Text = "Keyword"
        '
        'keywordCB
        '
        Me.keywordCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.keywordCB.FormattingEnabled = True
        Me.keywordCB.Items.AddRange(New Object() {"None", "Patient Name", "Doctor Name"})
        Me.keywordCB.Location = New System.Drawing.Point(7, 32)
        Me.keywordCB.Name = "keywordCB"
        Me.keywordCB.Size = New System.Drawing.Size(381, 28)
        Me.keywordCB.TabIndex = 9
        '
        'newAppointmentBtn
        '
        Me.newAppointmentBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newAppointmentBtn.Location = New System.Drawing.Point(14, 510)
        Me.newAppointmentBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.newAppointmentBtn.Name = "newAppointmentBtn"
        Me.newAppointmentBtn.Size = New System.Drawing.Size(188, 40)
        Me.newAppointmentBtn.TabIndex = 16
        Me.newAppointmentBtn.Text = "New Appointment"
        Me.newAppointmentBtn.UseVisualStyleBackColor = True
        '
        'closeBtn
        '
        Me.closeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.Location = New System.Drawing.Point(756, 510)
        Me.closeBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(95, 40)
        Me.closeBtn.TabIndex = 15
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'searchGB
        '
        Me.searchGB.Controls.Add(Me.searchTB)
        Me.searchGB.Location = New System.Drawing.Point(14, 14)
        Me.searchGB.Margin = New System.Windows.Forms.Padding(4)
        Me.searchGB.Name = "searchGB"
        Me.searchGB.Padding = New System.Windows.Forms.Padding(4)
        Me.searchGB.Size = New System.Drawing.Size(399, 86)
        Me.searchGB.TabIndex = 13
        Me.searchGB.TabStop = False
        Me.searchGB.Text = "Search"
        '
        'searchTB
        '
        Me.searchTB.Location = New System.Drawing.Point(6, 32)
        Me.searchTB.Name = "searchTB"
        Me.searchTB.Size = New System.Drawing.Size(383, 27)
        Me.searchTB.TabIndex = 8
        '
        'dgvAppointment
        '
        Me.dgvAppointment.AllowUserToAddRows = False
        Me.dgvAppointment.AllowUserToDeleteRows = False
        Me.dgvAppointment.AllowUserToResizeColumns = False
        Me.dgvAppointment.AllowUserToResizeRows = False
        Me.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAppointment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AppointmentIdCol, Me.AppointmentCodeCol, Me.PatientIdCol, Me.PatientNameCol, Me.DoctorIdCol, Me.DoctorNameCol, Me.AppointmentDateCol, Me.AppointmentTimeCol, Me.AppointmentDescriptionCol, Me.AppointmentRoomCol, Me.AppointmentStatusCol, Me.AppointmentStatusStrCol})
        Me.dgvAppointment.Location = New System.Drawing.Point(14, 108)
        Me.dgvAppointment.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvAppointment.MultiSelect = False
        Me.dgvAppointment.Name = "dgvAppointment"
        Me.dgvAppointment.ReadOnly = True
        Me.dgvAppointment.RowHeadersVisible = False
        Me.dgvAppointment.RowHeadersWidth = 51
        Me.dgvAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAppointment.Size = New System.Drawing.Size(835, 394)
        Me.dgvAppointment.TabIndex = 12
        '
        'AppointmentIdCol
        '
        Me.AppointmentIdCol.DataPropertyName = "AppointmentID"
        Me.AppointmentIdCol.HeaderText = "ID"
        Me.AppointmentIdCol.MinimumWidth = 6
        Me.AppointmentIdCol.Name = "AppointmentIdCol"
        Me.AppointmentIdCol.ReadOnly = True
        Me.AppointmentIdCol.Visible = False
        Me.AppointmentIdCol.Width = 125
        '
        'AppointmentCodeCol
        '
        Me.AppointmentCodeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.AppointmentCodeCol.DataPropertyName = "AppointmentCode"
        Me.AppointmentCodeCol.HeaderText = "Code"
        Me.AppointmentCodeCol.MinimumWidth = 6
        Me.AppointmentCodeCol.Name = "AppointmentCodeCol"
        Me.AppointmentCodeCol.ReadOnly = True
        Me.AppointmentCodeCol.Width = 77
        '
        'PatientIdCol
        '
        Me.PatientIdCol.DataPropertyName = "PatientID"
        Me.PatientIdCol.HeaderText = "PatientId"
        Me.PatientIdCol.MinimumWidth = 6
        Me.PatientIdCol.Name = "PatientIdCol"
        Me.PatientIdCol.ReadOnly = True
        Me.PatientIdCol.Visible = False
        Me.PatientIdCol.Width = 125
        '
        'PatientNameCol
        '
        Me.PatientNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PatientNameCol.DataPropertyName = "PatientName"
        Me.PatientNameCol.HeaderText = "Patient Name"
        Me.PatientNameCol.MinimumWidth = 6
        Me.PatientNameCol.Name = "PatientNameCol"
        Me.PatientNameCol.ReadOnly = True
        '
        'DoctorIdCol
        '
        Me.DoctorIdCol.DataPropertyName = "DoctorID"
        Me.DoctorIdCol.HeaderText = "DoctorId"
        Me.DoctorIdCol.MinimumWidth = 6
        Me.DoctorIdCol.Name = "DoctorIdCol"
        Me.DoctorIdCol.ReadOnly = True
        Me.DoctorIdCol.Visible = False
        Me.DoctorIdCol.Width = 125
        '
        'DoctorNameCol
        '
        Me.DoctorNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DoctorNameCol.DataPropertyName = "DoctorName"
        Me.DoctorNameCol.HeaderText = "Doctor Name"
        Me.DoctorNameCol.MinimumWidth = 6
        Me.DoctorNameCol.Name = "DoctorNameCol"
        Me.DoctorNameCol.ReadOnly = True
        Me.DoctorNameCol.Width = 138
        '
        'AppointmentDateCol
        '
        Me.AppointmentDateCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.AppointmentDateCol.DataPropertyName = "AppointmentDate"
        Me.AppointmentDateCol.HeaderText = "Date"
        Me.AppointmentDateCol.MinimumWidth = 6
        Me.AppointmentDateCol.Name = "AppointmentDateCol"
        Me.AppointmentDateCol.ReadOnly = True
        Me.AppointmentDateCol.Width = 74
        '
        'AppointmentTimeCol
        '
        Me.AppointmentTimeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.AppointmentTimeCol.DataPropertyName = "AppointmentTime"
        Me.AppointmentTimeCol.HeaderText = "Time"
        Me.AppointmentTimeCol.MinimumWidth = 6
        Me.AppointmentTimeCol.Name = "AppointmentTimeCol"
        Me.AppointmentTimeCol.ReadOnly = True
        Me.AppointmentTimeCol.Width = 75
        '
        'AppointmentDescriptionCol
        '
        Me.AppointmentDescriptionCol.DataPropertyName = "AppointmentDescription"
        Me.AppointmentDescriptionCol.HeaderText = "Description"
        Me.AppointmentDescriptionCol.MinimumWidth = 6
        Me.AppointmentDescriptionCol.Name = "AppointmentDescriptionCol"
        Me.AppointmentDescriptionCol.ReadOnly = True
        Me.AppointmentDescriptionCol.Visible = False
        Me.AppointmentDescriptionCol.Width = 125
        '
        'AppointmentRoomCol
        '
        Me.AppointmentRoomCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.AppointmentRoomCol.DataPropertyName = "AppointmentRoom"
        Me.AppointmentRoomCol.HeaderText = "Room"
        Me.AppointmentRoomCol.MinimumWidth = 6
        Me.AppointmentRoomCol.Name = "AppointmentRoomCol"
        Me.AppointmentRoomCol.ReadOnly = True
        Me.AppointmentRoomCol.Width = 82
        '
        'AppointmentStatusCol
        '
        Me.AppointmentStatusCol.DataPropertyName = "AppointmentStatus"
        Me.AppointmentStatusCol.HeaderText = "AppointmentStatus"
        Me.AppointmentStatusCol.MinimumWidth = 6
        Me.AppointmentStatusCol.Name = "AppointmentStatusCol"
        Me.AppointmentStatusCol.ReadOnly = True
        Me.AppointmentStatusCol.Visible = False
        Me.AppointmentStatusCol.Width = 125
        '
        'AppointmentStatusStrCol
        '
        Me.AppointmentStatusStrCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.AppointmentStatusStrCol.DataPropertyName = "AppointmentStatusStr"
        Me.AppointmentStatusStrCol.HeaderText = "Status"
        Me.AppointmentStatusStrCol.MinimumWidth = 6
        Me.AppointmentStatusStrCol.Name = "AppointmentStatusStrCol"
        Me.AppointmentStatusStrCol.ReadOnly = True
        Me.AppointmentStatusStrCol.Width = 86
        '
        'displayCheckBox
        '
        Me.displayCheckBox.AutoSize = True
        Me.displayCheckBox.Location = New System.Drawing.Point(241, 519)
        Me.displayCheckBox.Name = "displayCheckBox"
        Me.displayCheckBox.Size = New System.Drawing.Size(285, 24)
        Me.displayCheckBox.TabIndex = 17
        Me.displayCheckBox.Text = "Only display today's appointments"
        Me.displayCheckBox.UseVisualStyleBackColor = True
        '
        'appointmentCMS
        '
        Me.appointmentCMS.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.appointmentCMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateAppointmentToolStripMenuItem})
        Me.appointmentCMS.Name = "appointmentCMS"
        Me.appointmentCMS.Size = New System.Drawing.Size(220, 28)
        '
        'UpdateAppointmentToolStripMenuItem
        '
        Me.UpdateAppointmentToolStripMenuItem.Name = "UpdateAppointmentToolStripMenuItem"
        Me.UpdateAppointmentToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.UpdateAppointmentToolStripMenuItem.Text = "Update Appointment"
        '
        'reportBtn
        '
        Me.reportBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportBtn.Location = New System.Drawing.Point(571, 511)
        Me.reportBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.reportBtn.Name = "reportBtn"
        Me.reportBtn.Size = New System.Drawing.Size(175, 40)
        Me.reportBtn.TabIndex = 18
        Me.reportBtn.Text = "Generate Report"
        Me.reportBtn.UseVisualStyleBackColor = True
        '
        'frmAppointmentsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(865, 564)
        Me.Controls.Add(Me.reportBtn)
        Me.Controls.Add(Me.displayCheckBox)
        Me.Controls.Add(Me.keywordGB)
        Me.Controls.Add(Me.newAppointmentBtn)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.searchGB)
        Me.Controls.Add(Me.dgvAppointment)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAppointmentsList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Appointments List"
        Me.keywordGB.ResumeLayout(False)
        Me.searchGB.ResumeLayout(False)
        Me.searchGB.PerformLayout()
        CType(Me.dgvAppointment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.appointmentCMS.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents keywordGB As GroupBox
    Friend WithEvents keywordCB As ComboBox
    Friend WithEvents newAppointmentBtn As Button
    Friend WithEvents closeBtn As Button
    Friend WithEvents searchGB As GroupBox
    Friend WithEvents searchTB As TextBox
    Friend WithEvents dgvAppointment As DataGridView
    Friend WithEvents displayCheckBox As CheckBox
    Friend WithEvents AppointmentIdCol As DataGridViewTextBoxColumn
    Friend WithEvents AppointmentCodeCol As DataGridViewTextBoxColumn
    Friend WithEvents PatientIdCol As DataGridViewTextBoxColumn
    Friend WithEvents PatientNameCol As DataGridViewTextBoxColumn
    Friend WithEvents DoctorIdCol As DataGridViewTextBoxColumn
    Friend WithEvents DoctorNameCol As DataGridViewTextBoxColumn
    Friend WithEvents AppointmentDateCol As DataGridViewTextBoxColumn
    Friend WithEvents AppointmentTimeCol As DataGridViewTextBoxColumn
    Friend WithEvents AppointmentDescriptionCol As DataGridViewTextBoxColumn
    Friend WithEvents AppointmentRoomCol As DataGridViewTextBoxColumn
    Friend WithEvents AppointmentStatusCol As DataGridViewTextBoxColumn
    Friend WithEvents AppointmentStatusStrCol As DataGridViewTextBoxColumn
    Friend WithEvents appointmentCMS As ContextMenuStrip
    Friend WithEvents UpdateAppointmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents reportBtn As Button
End Class
