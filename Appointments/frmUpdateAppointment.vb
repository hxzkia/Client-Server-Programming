Public Class frmUpdateAppointment

    Dim MyParent As frmAppointmentsList
    Dim DTDoctor As DataTable
    Dim DTPatient As DataTable
    Dim DTAppointment As DataTable

    Dim appointment As New Appointment

    Public Sub New(myParent As frmAppointmentsList, appointment As Appointment)
        InitializeComponent()
        Me.MyParent = myParent
        Me.appointment = appointment

        DTDoctor = My.Application.DBA.DoctorsList()
        DTPatient = My.Application.DBA.PatientsList()
        DTAppointment = My.Application.DBA.AppointmentsList()

        With doctorNameCB
            .DataSource = DTDoctor
            .DisplayMember = "DoctorName"
            .ValueMember = "DoctorID"
            .SelectedValue = appointment.DoctorId
        End With

        With patientNameCB
            .DataSource = DTPatient
            .DisplayMember = "PatientName"
            .ValueMember = "PatientID"
            .SelectedValue = appointment.PatientId
        End With

        datePicker.Value = DateTime.Parse(appointment.AppointmentDate)
        timePicker.Value = DateTime.Parse(appointment.AppointmentTime)
        setRoom()
        descriptionTB.Text = appointment.AppointmentDescription
        statusCB.SelectedIndex = appointment.AppointmentStatus
        statusCB_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub setRoom()
        Dim selectedDoctorID As Integer = doctorNameCB.SelectedValue
        Dim doctorRow As DataRow = DTDoctor.Rows.Cast(Of DataRow).FirstOrDefault(Function(row) CInt(row("DoctorID")) = selectedDoctorID)

        roomTB.Text = doctorRow("DoctorRoom").ToString()
    End Sub

    Private Sub doctorNameCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles doctorNameCB.SelectedIndexChanged
        If doctorNameCB.SelectedValue IsNot Nothing AndAlso TypeOf doctorNameCB.SelectedValue Is Integer Then
            setRoom()
        End If
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Close()
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        Dim result As String

        Dim updatedAppointmentDate As DateTime = datePicker.Value.Date
        Dim updatedAppointmentTime As TimeSpan = timePicker.Value.TimeOfDay
        Dim fullUpdatedAppointmentDateTime As DateTime = updatedAppointmentDate.Add(updatedAppointmentTime)

        Dim originalAppointmentDate As DateTime = DateTime.Parse(appointment.AppointmentDate)
        Dim originalAppointmentTime As TimeSpan = TimeSpan.Parse(appointment.AppointmentTime)
        Dim fullOriginalAppointmentDateTime As DateTime = originalAppointmentDate.Add(originalAppointmentTime)

        appointment.PatientId = Trim(patientNameCB.SelectedValue)
        appointment.DoctorId = Trim(doctorNameCB.SelectedValue)
        appointment.AppointmentDate = Trim(datePicker.Value.ToString("yyyy-MM-dd"))
        appointment.AppointmentTime = Trim(timePicker.Value.ToString("HH:mm:ss"))
        appointment.AppointmentRoom = Trim(roomTB.Text)
        appointment.AppointmentDescription = Trim(descriptionTB.Text)
        appointment.AppointmentStatus = Trim(statusCB.SelectedIndex)

        If fullUpdatedAppointmentDateTime < DateTime.Now Then
            If Not fullUpdatedAppointmentDateTime.Equals(fullOriginalAppointmentDateTime) Then
                MessageBox.Show("The appointment date and time cannot be in the past.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If

        ' Ensure required fields are filled
        If Not String.IsNullOrEmpty(roomTB.Text) AndAlso Not String.IsNullOrWhiteSpace(roomTB.Text) Then
            result = My.Application.DBA.UpdateAppointment(appointment)
            If result = "Success" Then
                MessageBox.Show("Appointment info updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MyParent.RefreshData()
                Close()
            Else
                MessageBox.Show("Failed updating appointment info.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Make sure you fill all the required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub statusCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles statusCB.SelectedIndexChanged
        If statusCB.SelectedItem.ToString() = "Completed" Then
            datePicker.Enabled = False
            timePicker.Enabled = False
        Else
            datePicker.Enabled = True
            timePicker.Enabled = True
        End If
    End Sub
End Class