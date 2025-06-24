<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSpecialization
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
        Me.addSpecializationGB = New System.Windows.Forms.GroupBox()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.nameTB = New System.Windows.Forms.TextBox()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.addSpecializationGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'addSpecializationGB
        '
        Me.addSpecializationGB.Controls.Add(Me.addBtn)
        Me.addSpecializationGB.Controls.Add(Me.cancelBtn)
        Me.addSpecializationGB.Controls.Add(Me.nameTB)
        Me.addSpecializationGB.Controls.Add(Me.nameLabel)
        Me.addSpecializationGB.Location = New System.Drawing.Point(16, 16)
        Me.addSpecializationGB.Margin = New System.Windows.Forms.Padding(5)
        Me.addSpecializationGB.Name = "addSpecializationGB"
        Me.addSpecializationGB.Padding = New System.Windows.Forms.Padding(5)
        Me.addSpecializationGB.Size = New System.Drawing.Size(439, 438)
        Me.addSpecializationGB.TabIndex = 4
        Me.addSpecializationGB.TabStop = False
        Me.addSpecializationGB.Text = "Add Specialization"
        '
        'addBtn
        '
        Me.addBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBtn.Location = New System.Drawing.Point(231, 388)
        Me.addBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(94, 40)
        Me.addBtn.TabIndex = 2
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
        Me.cancelBtn.TabIndex = 3
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'nameTB
        '
        Me.nameTB.Location = New System.Drawing.Point(194, 196)
        Me.nameTB.Margin = New System.Windows.Forms.Padding(5)
        Me.nameTB.Name = "nameTB"
        Me.nameTB.Size = New System.Drawing.Size(222, 27)
        Me.nameTB.TabIndex = 1
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(20, 199)
        Me.nameLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(167, 20)
        Me.nameLabel.TabIndex = 1
        Me.nameLabel.Text = "Specialization Name:"
        '
        'frmAddSpecialization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(471, 470)
        Me.Controls.Add(Me.addSpecializationGB)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddSpecialization"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Specialization"
        Me.addSpecializationGB.ResumeLayout(False)
        Me.addSpecializationGB.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents addSpecializationGB As GroupBox
    Friend WithEvents addBtn As Button
    Friend WithEvents cancelBtn As Button
    Friend WithEvents nameTB As TextBox
    Friend WithEvents nameLabel As Label
End Class
