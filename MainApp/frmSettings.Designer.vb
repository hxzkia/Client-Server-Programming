<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.databaseInfoGB = New System.Windows.Forms.GroupBox()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.passwordTB = New System.Windows.Forms.TextBox()
        Me.passwordLabel = New System.Windows.Forms.Label()
        Me.usernameTB = New System.Windows.Forms.TextBox()
        Me.usernameLabel = New System.Windows.Forms.Label()
        Me.databaseTB = New System.Windows.Forms.TextBox()
        Me.databaseLabel = New System.Windows.Forms.Label()
        Me.dbInstanceTB = New System.Windows.Forms.TextBox()
        Me.dbInstanceLabel = New System.Windows.Forms.Label()
        Me.ipServerTB = New System.Windows.Forms.TextBox()
        Me.ipServerLabel = New System.Windows.Forms.Label()
        Me.databaseInfoGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'databaseInfoGB
        '
        Me.databaseInfoGB.Controls.Add(Me.saveBtn)
        Me.databaseInfoGB.Controls.Add(Me.cancelBtn)
        Me.databaseInfoGB.Controls.Add(Me.passwordTB)
        Me.databaseInfoGB.Controls.Add(Me.passwordLabel)
        Me.databaseInfoGB.Controls.Add(Me.usernameTB)
        Me.databaseInfoGB.Controls.Add(Me.usernameLabel)
        Me.databaseInfoGB.Controls.Add(Me.databaseTB)
        Me.databaseInfoGB.Controls.Add(Me.databaseLabel)
        Me.databaseInfoGB.Controls.Add(Me.dbInstanceTB)
        Me.databaseInfoGB.Controls.Add(Me.dbInstanceLabel)
        Me.databaseInfoGB.Controls.Add(Me.ipServerTB)
        Me.databaseInfoGB.Controls.Add(Me.ipServerLabel)
        Me.databaseInfoGB.Location = New System.Drawing.Point(16, 16)
        Me.databaseInfoGB.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.databaseInfoGB.Name = "databaseInfoGB"
        Me.databaseInfoGB.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.databaseInfoGB.Size = New System.Drawing.Size(462, 514)
        Me.databaseInfoGB.TabIndex = 3
        Me.databaseInfoGB.TabStop = False
        Me.databaseInfoGB.Text = "Database Info"
        '
        'saveBtn
        '
        Me.saveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.Location = New System.Drawing.Point(231, 424)
        Me.saveBtn.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(94, 40)
        Me.saveBtn.TabIndex = 5
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBtn.Location = New System.Drawing.Point(335, 424)
        Me.cancelBtn.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(94, 40)
        Me.cancelBtn.TabIndex = 6
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'passwordTB
        '
        Me.passwordTB.Location = New System.Drawing.Point(165, 360)
        Me.passwordTB.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.passwordTB.Name = "passwordTB"
        Me.passwordTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTB.Size = New System.Drawing.Size(263, 27)
        Me.passwordTB.TabIndex = 4
        '
        'passwordLabel
        '
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.Location = New System.Drawing.Point(68, 364)
        Me.passwordLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(88, 20)
        Me.passwordLabel.TabIndex = 8
        Me.passwordLabel.Text = "Password:"
        '
        'usernameTB
        '
        Me.usernameTB.Location = New System.Drawing.Point(165, 289)
        Me.usernameTB.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.usernameTB.Name = "usernameTB"
        Me.usernameTB.Size = New System.Drawing.Size(263, 27)
        Me.usernameTB.TabIndex = 3
        '
        'usernameLabel
        '
        Me.usernameLabel.AutoSize = True
        Me.usernameLabel.Location = New System.Drawing.Point(64, 292)
        Me.usernameLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.usernameLabel.Name = "usernameLabel"
        Me.usernameLabel.Size = New System.Drawing.Size(91, 20)
        Me.usernameLabel.TabIndex = 6
        Me.usernameLabel.Text = "Username:"
        '
        'databaseTB
        '
        Me.databaseTB.Location = New System.Drawing.Point(165, 218)
        Me.databaseTB.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.databaseTB.Name = "databaseTB"
        Me.databaseTB.Size = New System.Drawing.Size(263, 27)
        Me.databaseTB.TabIndex = 2
        '
        'databaseLabel
        '
        Me.databaseLabel.AutoSize = True
        Me.databaseLabel.Location = New System.Drawing.Point(68, 221)
        Me.databaseLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.databaseLabel.Name = "databaseLabel"
        Me.databaseLabel.Size = New System.Drawing.Size(86, 20)
        Me.databaseLabel.TabIndex = 4
        Me.databaseLabel.Text = "Database:"
        '
        'dbInstanceTB
        '
        Me.dbInstanceTB.Location = New System.Drawing.Point(165, 146)
        Me.dbInstanceTB.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.dbInstanceTB.Name = "dbInstanceTB"
        Me.dbInstanceTB.Size = New System.Drawing.Size(263, 27)
        Me.dbInstanceTB.TabIndex = 1
        '
        'dbInstanceLabel
        '
        Me.dbInstanceLabel.AutoSize = True
        Me.dbInstanceLabel.Location = New System.Drawing.Point(52, 150)
        Me.dbInstanceLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.dbInstanceLabel.Name = "dbInstanceLabel"
        Me.dbInstanceLabel.Size = New System.Drawing.Size(107, 20)
        Me.dbInstanceLabel.TabIndex = 2
        Me.dbInstanceLabel.Text = "DB Instance:"
        '
        'ipServerTB
        '
        Me.ipServerTB.Location = New System.Drawing.Point(165, 75)
        Me.ipServerTB.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ipServerTB.Name = "ipServerTB"
        Me.ipServerTB.Size = New System.Drawing.Size(263, 27)
        Me.ipServerTB.TabIndex = 0
        '
        'ipServerLabel
        '
        Me.ipServerLabel.AutoSize = True
        Me.ipServerLabel.Location = New System.Drawing.Point(74, 79)
        Me.ipServerLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ipServerLabel.Name = "ipServerLabel"
        Me.ipServerLabel.Size = New System.Drawing.Size(83, 20)
        Me.ipServerLabel.TabIndex = 0
        Me.ipServerLabel.Text = "IP Server:"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(495, 546)
        Me.Controls.Add(Me.databaseInfoGB)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Settings"
        Me.databaseInfoGB.ResumeLayout(False)
        Me.databaseInfoGB.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents databaseInfoGB As GroupBox
    Friend WithEvents saveBtn As Button
    Friend WithEvents cancelBtn As Button
    Friend WithEvents passwordTB As TextBox
    Friend WithEvents passwordLabel As Label
    Friend WithEvents usernameTB As TextBox
    Friend WithEvents usernameLabel As Label
    Friend WithEvents databaseTB As TextBox
    Friend WithEvents databaseLabel As Label
    Friend WithEvents dbInstanceTB As TextBox
    Friend WithEvents dbInstanceLabel As Label
    Friend WithEvents ipServerTB As TextBox
    Friend WithEvents ipServerLabel As Label
End Class
