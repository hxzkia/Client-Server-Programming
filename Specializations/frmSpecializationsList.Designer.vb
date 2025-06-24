<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpecializationsList
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
        Me.newSpecializationBtn = New System.Windows.Forms.Button()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.dgvSpecialization = New System.Windows.Forms.DataGridView()
        Me.SpecializationIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecializationNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.specializationCMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteSpecializationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.reportBtn = New System.Windows.Forms.Button()
        CType(Me.dgvSpecialization, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.specializationCMS.SuspendLayout()
        Me.SuspendLayout()
        '
        'newSpecializationBtn
        '
        Me.newSpecializationBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newSpecializationBtn.Location = New System.Drawing.Point(13, 460)
        Me.newSpecializationBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.newSpecializationBtn.Name = "newSpecializationBtn"
        Me.newSpecializationBtn.Size = New System.Drawing.Size(196, 40)
        Me.newSpecializationBtn.TabIndex = 10
        Me.newSpecializationBtn.Text = "Add Specialization"
        Me.newSpecializationBtn.UseVisualStyleBackColor = True
        '
        'closeBtn
        '
        Me.closeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.Location = New System.Drawing.Point(454, 460)
        Me.closeBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(93, 40)
        Me.closeBtn.TabIndex = 9
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'dgvSpecialization
        '
        Me.dgvSpecialization.AllowUserToAddRows = False
        Me.dgvSpecialization.AllowUserToDeleteRows = False
        Me.dgvSpecialization.AllowUserToResizeColumns = False
        Me.dgvSpecialization.AllowUserToResizeRows = False
        Me.dgvSpecialization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSpecialization.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SpecializationIdCol, Me.SpecializationNameCol})
        Me.dgvSpecialization.Location = New System.Drawing.Point(13, 13)
        Me.dgvSpecialization.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvSpecialization.MultiSelect = False
        Me.dgvSpecialization.Name = "dgvSpecialization"
        Me.dgvSpecialization.ReadOnly = True
        Me.dgvSpecialization.RowHeadersVisible = False
        Me.dgvSpecialization.RowHeadersWidth = 51
        Me.dgvSpecialization.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSpecialization.Size = New System.Drawing.Size(534, 438)
        Me.dgvSpecialization.TabIndex = 8
        '
        'SpecializationIdCol
        '
        Me.SpecializationIdCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SpecializationIdCol.DataPropertyName = "SpecializationID"
        Me.SpecializationIdCol.HeaderText = "ID"
        Me.SpecializationIdCol.MinimumWidth = 6
        Me.SpecializationIdCol.Name = "SpecializationIdCol"
        Me.SpecializationIdCol.ReadOnly = True
        Me.SpecializationIdCol.Width = 55
        '
        'SpecializationNameCol
        '
        Me.SpecializationNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SpecializationNameCol.DataPropertyName = "SpecializationName"
        Me.SpecializationNameCol.HeaderText = "Name"
        Me.SpecializationNameCol.MinimumWidth = 6
        Me.SpecializationNameCol.Name = "SpecializationNameCol"
        Me.SpecializationNameCol.ReadOnly = True
        '
        'specializationCMS
        '
        Me.specializationCMS.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.specializationCMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteSpecializationToolStripMenuItem})
        Me.specializationCMS.Name = "specializationCMS"
        Me.specializationCMS.Size = New System.Drawing.Size(220, 28)
        '
        'DeleteSpecializationToolStripMenuItem
        '
        Me.DeleteSpecializationToolStripMenuItem.Name = "DeleteSpecializationToolStripMenuItem"
        Me.DeleteSpecializationToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.DeleteSpecializationToolStripMenuItem.Text = "Delete Specialization"
        '
        'reportBtn
        '
        Me.reportBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportBtn.Location = New System.Drawing.Point(269, 460)
        Me.reportBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.reportBtn.Name = "reportBtn"
        Me.reportBtn.Size = New System.Drawing.Size(175, 40)
        Me.reportBtn.TabIndex = 21
        Me.reportBtn.Text = "Generate Report"
        Me.reportBtn.UseVisualStyleBackColor = True
        '
        'frmSpecializationsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(560, 508)
        Me.Controls.Add(Me.reportBtn)
        Me.Controls.Add(Me.newSpecializationBtn)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.dgvSpecialization)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSpecializationsList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Specializations List"
        CType(Me.dgvSpecialization, System.ComponentModel.ISupportInitialize).EndInit()
        Me.specializationCMS.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents newSpecializationBtn As Button
    Friend WithEvents closeBtn As Button
    Friend WithEvents dgvSpecialization As DataGridView
    Friend WithEvents SpecializationIdCol As DataGridViewTextBoxColumn
    Friend WithEvents SpecializationNameCol As DataGridViewTextBoxColumn
    Friend WithEvents specializationCMS As ContextMenuStrip
    Friend WithEvents DeleteSpecializationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents reportBtn As Button
End Class
