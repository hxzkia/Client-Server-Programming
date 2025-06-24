<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientsList
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
        Me.addPatientBtn = New System.Windows.Forms.Button()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.searchGB = New System.Windows.Forms.GroupBox()
        Me.searchTB = New System.Windows.Forms.TextBox()
        Me.dgvPatient = New System.Windows.Forms.DataGridView()
        Me.PatientIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientEmailCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientPhoneCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.patientCMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UpdatePatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.reportBtn = New System.Windows.Forms.Button()
        Me.searchGB.SuspendLayout()
        CType(Me.dgvPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.patientCMS.SuspendLayout()
        Me.SuspendLayout()
        '
        'addPatientBtn
        '
        Me.addPatientBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addPatientBtn.Location = New System.Drawing.Point(15, 510)
        Me.addPatientBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.addPatientBtn.Name = "addPatientBtn"
        Me.addPatientBtn.Size = New System.Drawing.Size(139, 40)
        Me.addPatientBtn.TabIndex = 11
        Me.addPatientBtn.Text = "Add Patient"
        Me.addPatientBtn.UseVisualStyleBackColor = True
        '
        'closeBtn
        '
        Me.closeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.Location = New System.Drawing.Point(711, 510)
        Me.closeBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(139, 40)
        Me.closeBtn.TabIndex = 10
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'searchGB
        '
        Me.searchGB.Controls.Add(Me.searchTB)
        Me.searchGB.Location = New System.Drawing.Point(15, 14)
        Me.searchGB.Margin = New System.Windows.Forms.Padding(4)
        Me.searchGB.Name = "searchGB"
        Me.searchGB.Padding = New System.Windows.Forms.Padding(4)
        Me.searchGB.Size = New System.Drawing.Size(399, 86)
        Me.searchGB.TabIndex = 9
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
        'dgvPatient
        '
        Me.dgvPatient.AllowUserToAddRows = False
        Me.dgvPatient.AllowUserToDeleteRows = False
        Me.dgvPatient.AllowUserToResizeColumns = False
        Me.dgvPatient.AllowUserToResizeRows = False
        Me.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPatient.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientIdCol, Me.PatientNameCol, Me.PatientEmailCol, Me.PatientPhoneCol})
        Me.dgvPatient.Location = New System.Drawing.Point(15, 108)
        Me.dgvPatient.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvPatient.MultiSelect = False
        Me.dgvPatient.Name = "dgvPatient"
        Me.dgvPatient.ReadOnly = True
        Me.dgvPatient.RowHeadersVisible = False
        Me.dgvPatient.RowHeadersWidth = 51
        Me.dgvPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPatient.Size = New System.Drawing.Size(835, 394)
        Me.dgvPatient.TabIndex = 8
        '
        'PatientIdCol
        '
        Me.PatientIdCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PatientIdCol.DataPropertyName = "PatientID"
        Me.PatientIdCol.HeaderText = "ID"
        Me.PatientIdCol.MinimumWidth = 6
        Me.PatientIdCol.Name = "PatientIdCol"
        Me.PatientIdCol.ReadOnly = True
        Me.PatientIdCol.Width = 55
        '
        'PatientNameCol
        '
        Me.PatientNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PatientNameCol.DataPropertyName = "PatientName"
        Me.PatientNameCol.HeaderText = "Name"
        Me.PatientNameCol.MinimumWidth = 6
        Me.PatientNameCol.Name = "PatientNameCol"
        Me.PatientNameCol.ReadOnly = True
        '
        'PatientEmailCol
        '
        Me.PatientEmailCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PatientEmailCol.DataPropertyName = "PatientEmail"
        Me.PatientEmailCol.HeaderText = "Email"
        Me.PatientEmailCol.MinimumWidth = 6
        Me.PatientEmailCol.Name = "PatientEmailCol"
        Me.PatientEmailCol.ReadOnly = True
        Me.PatientEmailCol.Width = 80
        '
        'PatientPhoneCol
        '
        Me.PatientPhoneCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PatientPhoneCol.DataPropertyName = "PatientPhone"
        Me.PatientPhoneCol.HeaderText = "Phone"
        Me.PatientPhoneCol.MinimumWidth = 6
        Me.PatientPhoneCol.Name = "PatientPhoneCol"
        Me.PatientPhoneCol.ReadOnly = True
        Me.PatientPhoneCol.Width = 85
        '
        'patientCMS
        '
        Me.patientCMS.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.patientCMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdatePatientToolStripMenuItem})
        Me.patientCMS.Name = "patientCMS"
        Me.patientCMS.Size = New System.Drawing.Size(177, 28)
        '
        'UpdatePatientToolStripMenuItem
        '
        Me.UpdatePatientToolStripMenuItem.Name = "UpdatePatientToolStripMenuItem"
        Me.UpdatePatientToolStripMenuItem.Size = New System.Drawing.Size(176, 24)
        Me.UpdatePatientToolStripMenuItem.Text = "Update Patient"
        '
        'reportBtn
        '
        Me.reportBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportBtn.Location = New System.Drawing.Point(526, 510)
        Me.reportBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.reportBtn.Name = "reportBtn"
        Me.reportBtn.Size = New System.Drawing.Size(175, 40)
        Me.reportBtn.TabIndex = 20
        Me.reportBtn.Text = "Generate Report"
        Me.reportBtn.UseVisualStyleBackColor = True
        '
        'frmPatientsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(865, 564)
        Me.Controls.Add(Me.reportBtn)
        Me.Controls.Add(Me.addPatientBtn)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.searchGB)
        Me.Controls.Add(Me.dgvPatient)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPatientsList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patients List"
        Me.searchGB.ResumeLayout(False)
        Me.searchGB.PerformLayout()
        CType(Me.dgvPatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.patientCMS.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents addPatientBtn As Button
    Friend WithEvents closeBtn As Button
    Friend WithEvents searchGB As GroupBox
    Friend WithEvents searchTB As TextBox
    Friend WithEvents dgvPatient As DataGridView
    Friend WithEvents patientCMS As ContextMenuStrip
    Friend WithEvents UpdatePatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PatientIdCol As DataGridViewTextBoxColumn
    Friend WithEvents PatientNameCol As DataGridViewTextBoxColumn
    Friend WithEvents PatientEmailCol As DataGridViewTextBoxColumn
    Friend WithEvents PatientPhoneCol As DataGridViewTextBoxColumn
    Friend WithEvents reportBtn As Button
End Class
