<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsersList
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
        Me.dgvUser = New System.Windows.Forms.DataGridView()
        Me.UserIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserRoleCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserRoleStrCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStatusCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStatusStrCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.searchGB = New System.Windows.Forms.GroupBox()
        Me.searchTB = New System.Windows.Forms.TextBox()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.newUserBtn = New System.Windows.Forms.Button()
        Me.userCMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.reportBtn = New System.Windows.Forms.Button()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.searchGB.SuspendLayout()
        Me.userCMS.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvUser
        '
        Me.dgvUser.AllowUserToAddRows = False
        Me.dgvUser.AllowUserToDeleteRows = False
        Me.dgvUser.AllowUserToResizeColumns = False
        Me.dgvUser.AllowUserToResizeRows = False
        Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserIdCol, Me.UserNameCol, Me.UNameCol, Me.UserRoleCol, Me.UserRoleStrCol, Me.UserStatusCol, Me.UserStatusStrCol})
        Me.dgvUser.Location = New System.Drawing.Point(15, 109)
        Me.dgvUser.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvUser.MultiSelect = False
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.ReadOnly = True
        Me.dgvUser.RowHeadersVisible = False
        Me.dgvUser.RowHeadersWidth = 51
        Me.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUser.Size = New System.Drawing.Size(835, 394)
        Me.dgvUser.TabIndex = 0
        '
        'UserIdCol
        '
        Me.UserIdCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UserIdCol.DataPropertyName = "UserID"
        Me.UserIdCol.HeaderText = "ID"
        Me.UserIdCol.MinimumWidth = 6
        Me.UserIdCol.Name = "UserIdCol"
        Me.UserIdCol.ReadOnly = True
        Me.UserIdCol.Width = 55
        '
        'UserNameCol
        '
        Me.UserNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UserNameCol.DataPropertyName = "UserName"
        Me.UserNameCol.HeaderText = "Name"
        Me.UserNameCol.MinimumWidth = 6
        Me.UserNameCol.Name = "UserNameCol"
        Me.UserNameCol.ReadOnly = True
        '
        'UNameCol
        '
        Me.UNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UNameCol.DataPropertyName = "UName"
        Me.UNameCol.HeaderText = "Username"
        Me.UNameCol.MinimumWidth = 6
        Me.UNameCol.Name = "UNameCol"
        Me.UNameCol.ReadOnly = True
        Me.UNameCol.Width = 115
        '
        'UserRoleCol
        '
        Me.UserRoleCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UserRoleCol.DataPropertyName = "UserRole"
        Me.UserRoleCol.HeaderText = "UserRole"
        Me.UserRoleCol.MinimumWidth = 6
        Me.UserRoleCol.Name = "UserRoleCol"
        Me.UserRoleCol.ReadOnly = True
        Me.UserRoleCol.Visible = False
        Me.UserRoleCol.Width = 125
        '
        'UserRoleStrCol
        '
        Me.UserRoleStrCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UserRoleStrCol.DataPropertyName = "UserRoleStr"
        Me.UserRoleStrCol.HeaderText = "Role"
        Me.UserRoleStrCol.MinimumWidth = 6
        Me.UserRoleStrCol.Name = "UserRoleStrCol"
        Me.UserRoleStrCol.ReadOnly = True
        Me.UserRoleStrCol.Width = 72
        '
        'UserStatusCol
        '
        Me.UserStatusCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UserStatusCol.DataPropertyName = "UserStatus"
        Me.UserStatusCol.HeaderText = "UserStatus"
        Me.UserStatusCol.MinimumWidth = 6
        Me.UserStatusCol.Name = "UserStatusCol"
        Me.UserStatusCol.ReadOnly = True
        Me.UserStatusCol.Visible = False
        Me.UserStatusCol.Width = 125
        '
        'UserStatusStrCol
        '
        Me.UserStatusStrCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UserStatusStrCol.DataPropertyName = "UserStatusStr"
        Me.UserStatusStrCol.HeaderText = "Status"
        Me.UserStatusStrCol.MinimumWidth = 6
        Me.UserStatusStrCol.Name = "UserStatusStrCol"
        Me.UserStatusStrCol.ReadOnly = True
        Me.UserStatusStrCol.Width = 86
        '
        'searchGB
        '
        Me.searchGB.Controls.Add(Me.searchTB)
        Me.searchGB.Location = New System.Drawing.Point(15, 15)
        Me.searchGB.Margin = New System.Windows.Forms.Padding(4)
        Me.searchGB.Name = "searchGB"
        Me.searchGB.Padding = New System.Windows.Forms.Padding(4)
        Me.searchGB.Size = New System.Drawing.Size(399, 86)
        Me.searchGB.TabIndex = 1
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
        'closeBtn
        '
        Me.closeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.Location = New System.Drawing.Point(711, 511)
        Me.closeBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(139, 40)
        Me.closeBtn.TabIndex = 6
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'newUserBtn
        '
        Me.newUserBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newUserBtn.Location = New System.Drawing.Point(15, 511)
        Me.newUserBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.newUserBtn.Name = "newUserBtn"
        Me.newUserBtn.Size = New System.Drawing.Size(139, 40)
        Me.newUserBtn.TabIndex = 7
        Me.newUserBtn.Text = "New User"
        Me.newUserBtn.UseVisualStyleBackColor = True
        '
        'userCMS
        '
        Me.userCMS.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.userCMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteUserToolStripMenuItem})
        Me.userCMS.Name = "userCMS"
        Me.userCMS.Size = New System.Drawing.Size(156, 28)
        '
        'DeleteUserToolStripMenuItem
        '
        Me.DeleteUserToolStripMenuItem.Name = "DeleteUserToolStripMenuItem"
        Me.DeleteUserToolStripMenuItem.Size = New System.Drawing.Size(155, 24)
        Me.DeleteUserToolStripMenuItem.Text = "Delete User"
        '
        'reportBtn
        '
        Me.reportBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportBtn.Location = New System.Drawing.Point(526, 512)
        Me.reportBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.reportBtn.Name = "reportBtn"
        Me.reportBtn.Size = New System.Drawing.Size(175, 40)
        Me.reportBtn.TabIndex = 19
        Me.reportBtn.Text = "Generate Report"
        Me.reportBtn.UseVisualStyleBackColor = True
        '
        'frmUsersList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(865, 564)
        Me.Controls.Add(Me.reportBtn)
        Me.Controls.Add(Me.newUserBtn)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.searchGB)
        Me.Controls.Add(Me.dgvUser)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsersList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Users List"
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.searchGB.ResumeLayout(False)
        Me.searchGB.PerformLayout()
        Me.userCMS.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvUser As DataGridView
    Friend WithEvents searchGB As GroupBox
    Friend WithEvents closeBtn As Button
    Friend WithEvents newUserBtn As Button
    Friend WithEvents userCMS As ContextMenuStrip
    Friend WithEvents DeleteUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserIdCol As DataGridViewTextBoxColumn
    Friend WithEvents UserNameCol As DataGridViewTextBoxColumn
    Friend WithEvents UNameCol As DataGridViewTextBoxColumn
    Friend WithEvents UserRoleCol As DataGridViewTextBoxColumn
    Friend WithEvents UserRoleStrCol As DataGridViewTextBoxColumn
    Friend WithEvents UserStatusCol As DataGridViewTextBoxColumn
    Friend WithEvents UserStatusStrCol As DataGridViewTextBoxColumn
    Friend WithEvents searchTB As TextBox
    Friend WithEvents reportBtn As Button
End Class
