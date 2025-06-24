<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.usernameLabel = New System.Windows.Forms.Label()
        Me.passwordLabel = New System.Windows.Forms.Label()
        Me.usernameTB = New System.Windows.Forms.TextBox()
        Me.passwordTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'usernameLabel
        '
        Me.usernameLabel.AutoSize = True
        Me.usernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameLabel.Location = New System.Drawing.Point(80, 117)
        Me.usernameLabel.Name = "usernameLabel"
        Me.usernameLabel.Size = New System.Drawing.Size(73, 16)
        Me.usernameLabel.TabIndex = 0
        Me.usernameLabel.Text = "Username:"
        '
        'passwordLabel
        '
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.Location = New System.Drawing.Point(83, 174)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(70, 16)
        Me.passwordLabel.TabIndex = 1
        Me.passwordLabel.Text = "Password:"
        '
        'usernameTB
        '
        Me.usernameTB.Location = New System.Drawing.Point(159, 114)
        Me.usernameTB.Name = "usernameTB"
        Me.usernameTB.Size = New System.Drawing.Size(230, 22)
        Me.usernameTB.TabIndex = 2
        '
        'passwordTB
        '
        Me.passwordTB.Location = New System.Drawing.Point(159, 171)
        Me.passwordTB.Name = "passwordTB"
        Me.passwordTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTB.Size = New System.Drawing.Size(230, 22)
        Me.passwordTB.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(186, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 31)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "LOGIN"
        '
        'loginBtn
        '
        Me.loginBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.Location = New System.Drawing.Point(314, 232)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(75, 32)
        Me.loginBtn.TabIndex = 5
        Me.loginBtn.Text = "Login"
        Me.loginBtn.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(476, 307)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.passwordTB)
        Me.Controls.Add(Me.usernameTB)
        Me.Controls.Add(Me.passwordLabel)
        Me.Controls.Add(Me.usernameLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents usernameLabel As Label
    Friend WithEvents passwordLabel As Label
    Friend WithEvents usernameTB As TextBox
    Friend WithEvents passwordTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents loginBtn As Button
End Class
