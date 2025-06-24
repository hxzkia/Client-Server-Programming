Public Class frmMain

    Sub New()
        InitializeComponent()

        If My.Application.DBA.CheckDBConn Then
            statusSS.ForeColor = Color.Green
            statusSS.Text = "Status : Connected to Server"
        Else
            statusSS.ForeColor = Color.Red
            statusSS.Text = "Status : Not Connected to Server"
        End If

        timeSS.Text = Date.Now.ToString("ddddddd, dd MMMM yyyy - HH:mm:ss")

        Dim fLogin As New frmLogin(Me)
        fLogin.MdiParent = Me
        fLogin.Show()

        UsersToolStripMenuItem.Visible = False
        PatientsToolStripMenuItem.Visible = False
        DoctorsToolStripMenuItem.Visible = False
        AppointmentsToolStripMenuItem.Visible = False
        LogoutToolStripMenuItem.Visible = False
    End Sub

    Public Sub Login()
        LogoutToolStripMenuItem.Visible = True

        If My.Application.User.UserRoleStr = "Receptionist" Then
            PatientsToolStripMenuItem.Visible = True
            DoctorsToolStripMenuItem.Visible = True
            AppointmentsToolStripMenuItem.Visible = True
        ElseIf My.Application.User.UserRoleStr = "Admin" Or My.Application.User.UserRoleStr = "Super Admin" Then
            UsersToolStripMenuItem.Visible = True
            PatientsToolStripMenuItem.Visible = True
            DoctorsToolStripMenuItem.Visible = True
            AppointmentsToolStripMenuItem.Visible = True
        End If
    End Sub

    Public Sub Logout()
        UsersToolStripMenuItem.Visible = False
        PatientsToolStripMenuItem.Visible = False
        DoctorsToolStripMenuItem.Visible = False
        AppointmentsToolStripMenuItem.Visible = False
        LogoutToolStripMenuItem.Visible = False

        For Each cForm In MdiChildren
            cForm.Close()
        Next

        Dim fLogin As New frmLogin(Me)
        fLogin.MdiParent = Me
        fLogin.Show()
    End Sub

    Private Sub TimeSS_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        timeSS.Text = Date.Now.ToString("ddddddd, dd MMMM yyyy - HH:mm:ss")
    End Sub

    Private Sub DatabaseSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatabaseSettingsToolStripMenuItem.Click
        Dim fSettings As New frmSettings()
        fSettings.MdiParent = Me
        fSettings.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Logout()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub UsersListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersListToolStripMenuItem.Click
        Dim fUsersList As New frmUsersList()
        fUsersList.MdiParent = Me
        fUsersList.Show()
    End Sub

    Private Sub PatientListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientListToolStripMenuItem.Click
        Dim fPatientsList As New frmPatientsList()
        fPatientsList.MdiParent = Me
        fPatientsList.Show()
    End Sub

    Private Sub DoctorListsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoctorListsToolStripMenuItem.Click
        Dim fDoctorsList As New frmDoctorsList()
        fDoctorsList.MdiParent = Me
        fDoctorsList.Show()
    End Sub

    Private Sub AddSpecializationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSpecializationToolStripMenuItem.Click
        Dim fSpecializationsList As New frmSpecializationsList()
        fSpecializationsList.MdiParent = Me
        fSpecializationsList.Show()
    End Sub

    Private Sub ShowAppointmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowAppointmentsToolStripMenuItem.Click
        Dim fAppointmentsList As New frmAppointmentsList()
        fAppointmentsList.MdiParent = Me
        fAppointmentsList.Show()
    End Sub
End Class