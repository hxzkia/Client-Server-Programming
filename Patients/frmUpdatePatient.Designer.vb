<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdatePatient
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
        Me.updatePatientGB = New System.Windows.Forms.GroupBox()
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
        Me.updatePatientGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'updatePatientGB
        '
        Me.updatePatientGB.Controls.Add(Me.updateBtn)
        Me.updatePatientGB.Controls.Add(Me.cancelBtn)
        Me.updatePatientGB.Controls.Add(Me.emailTB)
        Me.updatePatientGB.Controls.Add(Me.nameTB)
        Me.updatePatientGB.Controls.Add(Me.phoneTB)
        Me.updatePatientGB.Controls.Add(Me.idTB)
        Me.updatePatientGB.Controls.Add(Me.phoneLabel)
        Me.updatePatientGB.Controls.Add(Me.nameLabel)
        Me.updatePatientGB.Controls.Add(Me.emailLabel)
        Me.updatePatientGB.Controls.Add(Me.idLabel)
        Me.updatePatientGB.Location = New System.Drawing.Point(16, 16)
        Me.updatePatientGB.Margin = New System.Windows.Forms.Padding(5)
        Me.updatePatientGB.Name = "updatePatientGB"
        Me.updatePatientGB.Padding = New System.Windows.Forms.Padding(5)
        Me.updatePatientGB.Size = New System.Drawing.Size(439, 438)
        Me.updatePatientGB.TabIndex = 3
        Me.updatePatientGB.TabStop = False
        Me.updatePatientGB.Text = "Update Patient"
        '
        'updateBtn
        '
        Me.updateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateBtn.Location = New System.Drawing.Point(231, 388)
        Me.updateBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(94, 40)
        Me.updateBtn.TabIndex = 5
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
        Me.cancelBtn.TabIndex = 6
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'emailTB
        '
        Me.emailTB.Location = New System.Drawing.Point(166, 239)
        Me.emailTB.Margin = New System.Windows.Forms.Padding(5)
        Me.emailTB.Name = "emailTB"
        Me.emailTB.Size = New System.Drawing.Size(222, 27)
        Me.emailTB.TabIndex = 3
        '
        'nameTB
        '
        Me.nameTB.Location = New System.Drawing.Point(166, 172)
        Me.nameTB.Margin = New System.Windows.Forms.Padding(5)
        Me.nameTB.Name = "nameTB"
        Me.nameTB.Size = New System.Drawing.Size(222, 27)
        Me.nameTB.TabIndex = 2
        '
        'phoneTB
        '
        Me.phoneTB.Location = New System.Drawing.Point(166, 306)
        Me.phoneTB.Margin = New System.Windows.Forms.Padding(5)
        Me.phoneTB.Name = "phoneTB"
        Me.phoneTB.Size = New System.Drawing.Size(222, 27)
        Me.phoneTB.TabIndex = 4
        '
        'idTB
        '
        Me.idTB.Location = New System.Drawing.Point(166, 105)
        Me.idTB.Margin = New System.Windows.Forms.Padding(5)
        Me.idTB.Name = "idTB"
        Me.idTB.ReadOnly = True
        Me.idTB.Size = New System.Drawing.Size(222, 27)
        Me.idTB.TabIndex = 0
        '
        'phoneLabel
        '
        Me.phoneLabel.AutoSize = True
        Me.phoneLabel.Location = New System.Drawing.Point(38, 309)
        Me.phoneLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.phoneLabel.Name = "phoneLabel"
        Me.phoneLabel.Size = New System.Drawing.Size(118, 20)
        Me.phoneLabel.TabIndex = 4
        Me.phoneLabel.Text = "Patient Phone:"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(41, 175)
        Me.nameLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(115, 20)
        Me.nameLabel.TabIndex = 2
        Me.nameLabel.Text = "Patient Name:"
        '
        'emailLabel
        '
        Me.emailLabel.AutoSize = True
        Me.emailLabel.Location = New System.Drawing.Point(43, 242)
        Me.emailLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(113, 20)
        Me.emailLabel.TabIndex = 3
        Me.emailLabel.Text = "Patient Email:"
        '
        'idLabel
        '
        Me.idLabel.AutoSize = True
        Me.idLabel.Location = New System.Drawing.Point(68, 108)
        Me.idLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.idLabel.Name = "idLabel"
        Me.idLabel.Size = New System.Drawing.Size(88, 20)
        Me.idLabel.TabIndex = 1
        Me.idLabel.Text = "Patient ID:"
        '
        'frmUpdatePatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(471, 470)
        Me.Controls.Add(Me.updatePatientGB)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdatePatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Patient"
        Me.updatePatientGB.ResumeLayout(False)
        Me.updatePatientGB.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents updatePatientGB As GroupBox
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
End Class
