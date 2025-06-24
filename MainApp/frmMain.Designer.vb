<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.mainMS = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PatientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DoctorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoctorListsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddSpecializationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AppointmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowAppointmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.mainSS = New System.Windows.Forms.StatusStrip()
        Me.statusSS = New System.Windows.Forms.ToolStripStatusLabel()
        Me.timeSS = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mainMS.SuspendLayout()
        Me.mainSS.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMS
        '
        Me.mainMS.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mainMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.UsersToolStripMenuItem, Me.PatientsToolStripMenuItem, Me.DoctorsToolStripMenuItem, Me.AppointmentsToolStripMenuItem})
        Me.mainMS.Location = New System.Drawing.Point(0, 0)
        Me.mainMS.Name = "mainMS"
        Me.mainMS.Size = New System.Drawing.Size(1000, 28)
        Me.mainMS.TabIndex = 1
        Me.mainMS.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatabaseSettingsToolStripMenuItem, Me.ToolStripSeparator1, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'DatabaseSettingsToolStripMenuItem
        '
        Me.DatabaseSettingsToolStripMenuItem.Name = "DatabaseSettingsToolStripMenuItem"
        Me.DatabaseSettingsToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.DatabaseSettingsToolStripMenuItem.Text = "Database Settings"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(209, 6)
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsersListToolStripMenuItem, Me.ToolStripSeparator2})
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'UsersListToolStripMenuItem
        '
        Me.UsersListToolStripMenuItem.Name = "UsersListToolStripMenuItem"
        Me.UsersListToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.UsersListToolStripMenuItem.Text = "Users List"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(150, 6)
        '
        'PatientsToolStripMenuItem
        '
        Me.PatientsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientListToolStripMenuItem, Me.ToolStripSeparator3})
        Me.PatientsToolStripMenuItem.Name = "PatientsToolStripMenuItem"
        Me.PatientsToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.PatientsToolStripMenuItem.Text = "Patients"
        '
        'PatientListToolStripMenuItem
        '
        Me.PatientListToolStripMenuItem.Name = "PatientListToolStripMenuItem"
        Me.PatientListToolStripMenuItem.Size = New System.Drawing.Size(183, 26)
        Me.PatientListToolStripMenuItem.Text = "Show Patients"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(180, 6)
        '
        'DoctorsToolStripMenuItem
        '
        Me.DoctorsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DoctorListsToolStripMenuItem, Me.ToolStripSeparator4, Me.AddSpecializationToolStripMenuItem, Me.ToolStripSeparator5})
        Me.DoctorsToolStripMenuItem.Name = "DoctorsToolStripMenuItem"
        Me.DoctorsToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.DoctorsToolStripMenuItem.Text = "Doctors"
        '
        'DoctorListsToolStripMenuItem
        '
        Me.DoctorListsToolStripMenuItem.Name = "DoctorListsToolStripMenuItem"
        Me.DoctorListsToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.DoctorListsToolStripMenuItem.Text = "Show Doctors"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(228, 6)
        '
        'AddSpecializationToolStripMenuItem
        '
        Me.AddSpecializationToolStripMenuItem.Name = "AddSpecializationToolStripMenuItem"
        Me.AddSpecializationToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.AddSpecializationToolStripMenuItem.Text = "Show Specializations"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(228, 6)
        '
        'AppointmentsToolStripMenuItem
        '
        Me.AppointmentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowAppointmentsToolStripMenuItem, Me.ToolStripSeparator6})
        Me.AppointmentsToolStripMenuItem.Name = "AppointmentsToolStripMenuItem"
        Me.AppointmentsToolStripMenuItem.Size = New System.Drawing.Size(117, 24)
        Me.AppointmentsToolStripMenuItem.Text = "Appointments"
        '
        'ShowAppointmentsToolStripMenuItem
        '
        Me.ShowAppointmentsToolStripMenuItem.Name = "ShowAppointmentsToolStripMenuItem"
        Me.ShowAppointmentsToolStripMenuItem.Size = New System.Drawing.Size(226, 26)
        Me.ShowAppointmentsToolStripMenuItem.Text = "Show Appointments"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(223, 6)
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'mainSS
        '
        Me.mainSS.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mainSS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusSS, Me.timeSS})
        Me.mainSS.Location = New System.Drawing.Point(0, 536)
        Me.mainSS.Name = "mainSS"
        Me.mainSS.Padding = New System.Windows.Forms.Padding(1, 0, 18, 0)
        Me.mainSS.Size = New System.Drawing.Size(1000, 26)
        Me.mainSS.TabIndex = 5
        Me.mainSS.Text = "-"
        '
        'statusSS
        '
        Me.statusSS.Name = "statusSS"
        Me.statusSS.Size = New System.Drawing.Size(56, 20)
        Me.statusSS.Text = "Status :"
        '
        'timeSS
        '
        Me.timeSS.Name = "timeSS"
        Me.timeSS.Size = New System.Drawing.Size(925, 20)
        Me.timeSS.Spring = True
        Me.timeSS.Text = "Waktu :"
        Me.timeSS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1000, 562)
        Me.Controls.Add(Me.mainSS)
        Me.Controls.Add(Me.mainMS)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mainMS
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Appointment System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mainMS.ResumeLayout(False)
        Me.mainMS.PerformLayout()
        Me.mainSS.ResumeLayout(False)
        Me.mainSS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainMS As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatabaseSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents PatientsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PatientListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents DoctorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AppointmentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DoctorListsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents AddSpecializationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ShowAppointmentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents Timer As Timer
    Friend WithEvents mainSS As StatusStrip
    Friend WithEvents statusSS As ToolStripStatusLabel
    Friend WithEvents timeSS As ToolStripStatusLabel
End Class
