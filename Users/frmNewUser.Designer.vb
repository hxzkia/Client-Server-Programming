<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewUser
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
        Me.newUserGB = New System.Windows.Forms.GroupBox()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.passwordTB = New System.Windows.Forms.TextBox()
        Me.roleCB = New System.Windows.Forms.ComboBox()
        Me.usernameTB = New System.Windows.Forms.TextBox()
        Me.retypeTB = New System.Windows.Forms.TextBox()
        Me.nameTB = New System.Windows.Forms.TextBox()
        Me.roleLabel = New System.Windows.Forms.Label()
        Me.retypeLabel = New System.Windows.Forms.Label()
        Me.usernameLabel = New System.Windows.Forms.Label()
        Me.passwordLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.newUserGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'newUserGB
        '
        Me.newUserGB.Controls.Add(Me.addBtn)
        Me.newUserGB.Controls.Add(Me.cancelBtn)
        Me.newUserGB.Controls.Add(Me.passwordTB)
        Me.newUserGB.Controls.Add(Me.roleCB)
        Me.newUserGB.Controls.Add(Me.usernameTB)
        Me.newUserGB.Controls.Add(Me.retypeTB)
        Me.newUserGB.Controls.Add(Me.nameTB)
        Me.newUserGB.Controls.Add(Me.roleLabel)
        Me.newUserGB.Controls.Add(Me.retypeLabel)
        Me.newUserGB.Controls.Add(Me.usernameLabel)
        Me.newUserGB.Controls.Add(Me.passwordLabel)
        Me.newUserGB.Controls.Add(Me.nameLabel)
        Me.newUserGB.Location = New System.Drawing.Point(16, 16)
        Me.newUserGB.Margin = New System.Windows.Forms.Padding(5)
        Me.newUserGB.Name = "newUserGB"
        Me.newUserGB.Padding = New System.Windows.Forms.Padding(5)
        Me.newUserGB.Size = New System.Drawing.Size(439, 438)
        Me.newUserGB.TabIndex = 2
        Me.newUserGB.TabStop = False
        Me.newUserGB.Text = "Add User"
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
        'passwordTB
        '
        Me.passwordTB.Location = New System.Drawing.Point(176, 186)
        Me.passwordTB.Margin = New System.Windows.Forms.Padding(5)
        Me.passwordTB.Name = "passwordTB"
        Me.passwordTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTB.Size = New System.Drawing.Size(219, 27)
        Me.passwordTB.TabIndex = 3
        '
        'roleCB
        '
        Me.roleCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.roleCB.FormattingEnabled = True
        Me.roleCB.Items.AddRange(New Object() {"Receptionist", "Admin"})
        Me.roleCB.Location = New System.Drawing.Point(176, 318)
        Me.roleCB.Margin = New System.Windows.Forms.Padding(5)
        Me.roleCB.Name = "roleCB"
        Me.roleCB.Size = New System.Drawing.Size(222, 28)
        Me.roleCB.TabIndex = 5
        '
        'usernameTB
        '
        Me.usernameTB.Location = New System.Drawing.Point(176, 119)
        Me.usernameTB.Margin = New System.Windows.Forms.Padding(5)
        Me.usernameTB.Name = "usernameTB"
        Me.usernameTB.Size = New System.Drawing.Size(222, 27)
        Me.usernameTB.TabIndex = 2
        '
        'retypeTB
        '
        Me.retypeTB.Location = New System.Drawing.Point(176, 254)
        Me.retypeTB.Margin = New System.Windows.Forms.Padding(5)
        Me.retypeTB.Name = "retypeTB"
        Me.retypeTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.retypeTB.Size = New System.Drawing.Size(222, 27)
        Me.retypeTB.TabIndex = 4
        '
        'nameTB
        '
        Me.nameTB.Location = New System.Drawing.Point(176, 51)
        Me.nameTB.Margin = New System.Windows.Forms.Padding(5)
        Me.nameTB.Name = "nameTB"
        Me.nameTB.Size = New System.Drawing.Size(222, 27)
        Me.nameTB.TabIndex = 1
        '
        'roleLabel
        '
        Me.roleLabel.AutoSize = True
        Me.roleLabel.Location = New System.Drawing.Point(78, 324)
        Me.roleLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.roleLabel.Name = "roleLabel"
        Me.roleLabel.Size = New System.Drawing.Size(89, 20)
        Me.roleLabel.TabIndex = 5
        Me.roleLabel.Text = "User Role:"
        '
        'retypeLabel
        '
        Me.retypeLabel.AutoSize = True
        Me.retypeLabel.Location = New System.Drawing.Point(20, 256)
        Me.retypeLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.retypeLabel.Name = "retypeLabel"
        Me.retypeLabel.Size = New System.Drawing.Size(145, 20)
        Me.retypeLabel.TabIndex = 4
        Me.retypeLabel.Text = "Retype Password:"
        '
        'usernameLabel
        '
        Me.usernameLabel.AutoSize = True
        Me.usernameLabel.Location = New System.Drawing.Point(75, 121)
        Me.usernameLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.usernameLabel.Name = "usernameLabel"
        Me.usernameLabel.Size = New System.Drawing.Size(91, 20)
        Me.usernameLabel.TabIndex = 2
        Me.usernameLabel.Text = "Username:"
        '
        'passwordLabel
        '
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.Location = New System.Drawing.Point(79, 189)
        Me.passwordLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(88, 20)
        Me.passwordLabel.TabIndex = 3
        Me.passwordLabel.Text = "Password:"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(108, 54)
        Me.nameLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(58, 20)
        Me.nameLabel.TabIndex = 1
        Me.nameLabel.Text = "Name:"
        '
        'frmNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(471, 470)
        Me.Controls.Add(Me.newUserGB)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New User"
        Me.newUserGB.ResumeLayout(False)
        Me.newUserGB.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents newUserGB As GroupBox
    Friend WithEvents roleLabel As Label
    Friend WithEvents retypeLabel As Label
    Friend WithEvents usernameLabel As Label
    Friend WithEvents passwordLabel As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents addBtn As Button
    Friend WithEvents cancelBtn As Button
    Friend WithEvents passwordTB As TextBox
    Friend WithEvents roleCB As ComboBox
    Friend WithEvents usernameTB As TextBox
    Friend WithEvents retypeTB As TextBox
    Friend WithEvents nameTB As TextBox
End Class
