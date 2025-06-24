Imports System.Net.NetworkInformation

Public Class frmAppointmentsList

    Dim DTAppointment As New DataTable

    Dim appointment As Appointment
    Dim today As DateTime = DateTime.Today
    Dim tomorrow As DateTime = today.AddDays(1)

    Sub New()
        InitializeComponent()
        RefreshData()

        keywordCB.SelectedIndex = 0
        searchTB.Enabled = False
        dgvAppointment.Columns(6).DefaultCellStyle.Format = "dd MMMM yyyy"
        displayCheckBox.Checked = CBState.DisplayTodaysAppointments
    End Sub

    Public Sub RefreshData()
        DTAppointment = My.Application.DBA.AppointmentsList()
        dgvAppointment.DataSource = DTAppointment
        Search()
        dgvAppointment.Columns("AppointmentIdCol").Visible = False
    End Sub

    Private Sub Search()
        Dim filter As String = ""

        If Not String.IsNullOrEmpty(searchTB.Text) And Not String.IsNullOrWhiteSpace(searchTB.Text) Then
            If keywordCB.SelectedIndex = 1 Then
                filter = "(PatientName Like '%" & searchTB.Text & "%')"
            ElseIf keywordCB.SelectedIndex = 2 Then
                filter = "(DoctorName Like '%" & searchTB.Text & "%')"
            End If
        End If

        If displayCheckBox.Checked Then
            Dim todayFilter As String = $"(AppointmentDate >= #{today:MM/dd/yyyy}# AND AppointmentDate < #{tomorrow:MM/dd/yyyy}#)"

            If Not String.IsNullOrEmpty(filter) Then
                filter &= " AND " & todayFilter
            Else
                filter = todayFilter
            End If
        End If

        DTAppointment.DefaultView.RowFilter = filter
    End Sub

    Private Sub newAppointmentBtn_Click(sender As Object, e As EventArgs) Handles newAppointmentBtn.Click
        Dim fAddAppointment As New frmAddAppointment(Me)
        fAddAppointment.ShowDialog()
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Close()
    End Sub

    Private Sub searchTB_KeyUp(sender As Object, e As KeyEventArgs) Handles searchTB.KeyUp
        Search()
    End Sub

    Private Sub keywordCB_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles keywordCB.SelectionChangeCommitted
        If keywordCB.SelectedIndex = 0 Then
            searchTB.Enabled = False
            searchTB.Clear()
        Else
            searchTB.Enabled = True
        End If
        Search()
    End Sub

    Private Sub displayCheckBox_CheckStateChanged(sender As Object, e As EventArgs) Handles displayCheckBox.CheckStateChanged
        Search()
        dgvAppointment.Columns("AppointmentDateCol").Visible = Not displayCheckBox.Checked
        CBState.DisplayTodaysAppointments = displayCheckBox.Checked
    End Sub

    Private Sub dgvAppointment_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvAppointment.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim HT As DataGridView.HitTestInfo
            Dim appointmentTimeValue As Object
            HT = Me.dgvAppointment.HitTest(e.X, e.Y)

            If HT.Type = DataGridViewHitTestType.Cell Then
                appointment.AppointmentId = Me.dgvAppointment.Item("AppointmentIdCol", HT.RowIndex).Value
                appointment.PatientId = Me.dgvAppointment.Item("PatientIdCol", HT.RowIndex).Value
                appointment.DoctorId = Me.dgvAppointment.Item("DoctorIdCol", HT.RowIndex).Value
                appointment.AppointmentDate = Me.dgvAppointment.Item("AppointmentDateCol", HT.RowIndex).Value
                appointmentTimeValue = Me.dgvAppointment.Item("AppointmentTimeCol", HT.RowIndex).Value
                appointment.AppointmentTime = CType(appointmentTimeValue, TimeSpan).ToString("hh\:mm\:ss")
                If IsDBNull(Me.dgvAppointment.Item("AppointmentDescriptionCol", HT.RowIndex).Value) Then
                    appointment.AppointmentDescription = ""
                Else
                    appointment.AppointmentDescription = Me.dgvAppointment.Item("AppointmentDescriptionCol", HT.RowIndex).Value
                End If
                appointment.AppointmentStatus = Me.dgvAppointment.Item("AppointmentStatusCol", HT.RowIndex).Value

                Me.dgvAppointment.Rows(HT.RowIndex).Selected = True
                Me.dgvAppointment.ContextMenuStrip = appointmentCMS
            Else
                Me.dgvAppointment.ContextMenuStrip = Nothing
            End If
        Else
            Me.dgvAppointment.ContextMenuStrip = Nothing
        End If
    End Sub

    Private Sub UpdateAppointmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateAppointmentToolStripMenuItem.Click
        Dim fUpdateAppointment As New frmUpdateAppointment(Me, appointment)
        fUpdateAppointment.ShowDialog()
    End Sub

    Private Sub reportBtn_Click(sender As Object, e As EventArgs) Handles reportBtn.Click
        Dim Report As New ExcelAppointmentReport()
        Report.Generate(DTAppointment)
    End Sub
End Class