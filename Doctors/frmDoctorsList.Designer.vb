<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDoctorsList
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
        Me.newDoctorBtn = New System.Windows.Forms.Button()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.searchGB = New System.Windows.Forms.GroupBox()
        Me.searchTB = New System.Windows.Forms.TextBox()
        Me.dgvDoctor = New System.Windows.Forms.DataGridView()
        Me.DoctorIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoctorNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecializationStrCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecializationIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoctorEmailCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoctorPhoneCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoctorRoomCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoctorStatusStrCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoctorStatusCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.doctorCMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UpdateDoctorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteDoctorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.specializationGB = New System.Windows.Forms.GroupBox()
        Me.specializationCB = New System.Windows.Forms.ComboBox()
        Me.reportBtn = New System.Windows.Forms.Button()
        Me.searchGB.SuspendLayout()
        CType(Me.dgvDoctor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.doctorCMS.SuspendLayout()
        Me.specializationGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'newDoctorBtn
        '
        Me.newDoctorBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newDoctorBtn.Location = New System.Drawing.Point(15, 510)
        Me.newDoctorBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.newDoctorBtn.Name = "newDoctorBtn"
        Me.newDoctorBtn.Size = New System.Drawing.Size(139, 40)
        Me.newDoctorBtn.TabIndex = 11
        Me.newDoctorBtn.Text = "New Doctor"
        Me.newDoctorBtn.UseVisualStyleBackColor = True
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
        'dgvDoctor
        '
        Me.dgvDoctor.AllowUserToAddRows = False
        Me.dgvDoctor.AllowUserToDeleteRows = False
        Me.dgvDoctor.AllowUserToResizeColumns = False
        Me.dgvDoctor.AllowUserToResizeRows = False
        Me.dgvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDoctor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DoctorIdCol, Me.DoctorNameCol, Me.SpecializationStrCol, Me.SpecializationIdCol, Me.DoctorEmailCol, Me.DoctorPhoneCol, Me.DoctorRoomCol, Me.DoctorStatusStrCol, Me.DoctorStatusCol})
        Me.dgvDoctor.Location = New System.Drawing.Point(15, 108)
        Me.dgvDoctor.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDoctor.MultiSelect = False
        Me.dgvDoctor.Name = "dgvDoctor"
        Me.dgvDoctor.ReadOnly = True
        Me.dgvDoctor.RowHeadersVisible = False
        Me.dgvDoctor.RowHeadersWidth = 51
        Me.dgvDoctor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDoctor.Size = New System.Drawing.Size(835, 394)
        Me.dgvDoctor.TabIndex = 8
        '
        'DoctorIdCol
        '
        Me.DoctorIdCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DoctorIdCol.DataPropertyName = "DoctorID"
        Me.DoctorIdCol.HeaderText = "ID"
        Me.DoctorIdCol.MinimumWidth = 6
        Me.DoctorIdCol.Name = "DoctorIdCol"
        Me.DoctorIdCol.ReadOnly = True
        Me.DoctorIdCol.Width = 55
        '
        'DoctorNameCol
        '
        Me.DoctorNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DoctorNameCol.DataPropertyName = "DoctorName"
        Me.DoctorNameCol.HeaderText = "Name"
        Me.DoctorNameCol.MinimumWidth = 6
        Me.DoctorNameCol.Name = "DoctorNameCol"
        Me.DoctorNameCol.ReadOnly = True
        Me.DoctorNameCol.Width = 82
        '
        'SpecializationStrCol
        '
        Me.SpecializationStrCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SpecializationStrCol.DataPropertyName = "SpecializationStr"
        Me.SpecializationStrCol.HeaderText = "Specialization"
        Me.SpecializationStrCol.MinimumWidth = 6
        Me.SpecializationStrCol.Name = "SpecializationStrCol"
        Me.SpecializationStrCol.ReadOnly = True
        Me.SpecializationStrCol.Width = 142
        '
        'SpecializationIdCol
        '
        Me.SpecializationIdCol.DataPropertyName = "Specialization"
        Me.SpecializationIdCol.HeaderText = "SpecializationId"
        Me.SpecializationIdCol.MinimumWidth = 6
        Me.SpecializationIdCol.Name = "SpecializationIdCol"
        Me.SpecializationIdCol.ReadOnly = True
        Me.SpecializationIdCol.Visible = False
        Me.SpecializationIdCol.Width = 125
        '
        'DoctorEmailCol
        '
        Me.DoctorEmailCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DoctorEmailCol.DataPropertyName = "DoctorEmail"
        Me.DoctorEmailCol.HeaderText = "Email"
        Me.DoctorEmailCol.MinimumWidth = 6
        Me.DoctorEmailCol.Name = "DoctorEmailCol"
        Me.DoctorEmailCol.ReadOnly = True
        Me.DoctorEmailCol.Width = 80
        '
        'DoctorPhoneCol
        '
        Me.DoctorPhoneCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DoctorPhoneCol.DataPropertyName = "DoctorPhone"
        Me.DoctorPhoneCol.HeaderText = "Phone"
        Me.DoctorPhoneCol.MinimumWidth = 6
        Me.DoctorPhoneCol.Name = "DoctorPhoneCol"
        Me.DoctorPhoneCol.ReadOnly = True
        Me.DoctorPhoneCol.Width = 85
        '
        'DoctorRoomCol
        '
        Me.DoctorRoomCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DoctorRoomCol.DataPropertyName = "DoctorRoom"
        Me.DoctorRoomCol.HeaderText = "Room"
        Me.DoctorRoomCol.MinimumWidth = 6
        Me.DoctorRoomCol.Name = "DoctorRoomCol"
        Me.DoctorRoomCol.ReadOnly = True
        Me.DoctorRoomCol.Width = 82
        '
        'DoctorStatusStrCol
        '
        Me.DoctorStatusStrCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DoctorStatusStrCol.DataPropertyName = "DoctorStatusStr"
        Me.DoctorStatusStrCol.HeaderText = "Status"
        Me.DoctorStatusStrCol.MinimumWidth = 6
        Me.DoctorStatusStrCol.Name = "DoctorStatusStrCol"
        Me.DoctorStatusStrCol.ReadOnly = True
        Me.DoctorStatusStrCol.Width = 86
        '
        'DoctorStatusCol
        '
        Me.DoctorStatusCol.DataPropertyName = "DoctorStatus"
        Me.DoctorStatusCol.HeaderText = "DoctorStatus"
        Me.DoctorStatusCol.MinimumWidth = 6
        Me.DoctorStatusCol.Name = "DoctorStatusCol"
        Me.DoctorStatusCol.ReadOnly = True
        Me.DoctorStatusCol.Visible = False
        Me.DoctorStatusCol.Width = 125
        '
        'doctorCMS
        '
        Me.doctorCMS.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.doctorCMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateDoctorToolStripMenuItem, Me.DeleteDoctorToolStripMenuItem})
        Me.doctorCMS.Name = "doctorCMS"
        Me.doctorCMS.Size = New System.Drawing.Size(178, 52)
        '
        'UpdateDoctorToolStripMenuItem
        '
        Me.UpdateDoctorToolStripMenuItem.Name = "UpdateDoctorToolStripMenuItem"
        Me.UpdateDoctorToolStripMenuItem.Size = New System.Drawing.Size(177, 24)
        Me.UpdateDoctorToolStripMenuItem.Text = "Update Doctor"
        '
        'DeleteDoctorToolStripMenuItem
        '
        Me.DeleteDoctorToolStripMenuItem.Name = "DeleteDoctorToolStripMenuItem"
        Me.DeleteDoctorToolStripMenuItem.Size = New System.Drawing.Size(177, 24)
        Me.DeleteDoctorToolStripMenuItem.Text = "Delete Doctor"
        '
        'specializationGB
        '
        Me.specializationGB.Controls.Add(Me.specializationCB)
        Me.specializationGB.Location = New System.Drawing.Point(453, 14)
        Me.specializationGB.Margin = New System.Windows.Forms.Padding(4)
        Me.specializationGB.Name = "specializationGB"
        Me.specializationGB.Padding = New System.Windows.Forms.Padding(4)
        Me.specializationGB.Size = New System.Drawing.Size(399, 86)
        Me.specializationGB.TabIndex = 10
        Me.specializationGB.TabStop = False
        Me.specializationGB.Text = "Specialization"
        '
        'specializationCB
        '
        Me.specializationCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.specializationCB.FormattingEnabled = True
        Me.specializationCB.Location = New System.Drawing.Point(7, 32)
        Me.specializationCB.Name = "specializationCB"
        Me.specializationCB.Size = New System.Drawing.Size(381, 28)
        Me.specializationCB.TabIndex = 9
        '
        'reportBtn
        '
        Me.reportBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportBtn.Location = New System.Drawing.Point(526, 511)
        Me.reportBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.reportBtn.Name = "reportBtn"
        Me.reportBtn.Size = New System.Drawing.Size(175, 40)
        Me.reportBtn.TabIndex = 21
        Me.reportBtn.Text = "Generate Report"
        Me.reportBtn.UseVisualStyleBackColor = True
        '
        'frmDoctorsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(865, 564)
        Me.Controls.Add(Me.reportBtn)
        Me.Controls.Add(Me.specializationGB)
        Me.Controls.Add(Me.newDoctorBtn)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.searchGB)
        Me.Controls.Add(Me.dgvDoctor)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDoctorsList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doctors List"
        Me.searchGB.ResumeLayout(False)
        Me.searchGB.PerformLayout()
        CType(Me.dgvDoctor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.doctorCMS.ResumeLayout(False)
        Me.specializationGB.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents newDoctorBtn As Button
    Friend WithEvents closeBtn As Button
    Friend WithEvents searchGB As GroupBox
    Friend WithEvents searchTB As TextBox
    Friend WithEvents dgvDoctor As DataGridView
    Friend WithEvents doctorCMS As ContextMenuStrip
    Friend WithEvents UpdateDoctorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DoctorIdCol As DataGridViewTextBoxColumn
    Friend WithEvents DoctorNameCol As DataGridViewTextBoxColumn
    Friend WithEvents SpecializationStrCol As DataGridViewTextBoxColumn
    Friend WithEvents SpecializationIdCol As DataGridViewTextBoxColumn
    Friend WithEvents DoctorEmailCol As DataGridViewTextBoxColumn
    Friend WithEvents DoctorPhoneCol As DataGridViewTextBoxColumn
    Friend WithEvents DoctorRoomCol As DataGridViewTextBoxColumn
    Friend WithEvents DoctorStatusStrCol As DataGridViewTextBoxColumn
    Friend WithEvents DoctorStatusCol As DataGridViewTextBoxColumn
    Friend WithEvents specializationGB As GroupBox
    Friend WithEvents specializationCB As ComboBox
    Friend WithEvents DeleteDoctorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents reportBtn As Button
End Class
