Public Class frmAddAppointment

    Dim MyParent As frmAppointmentsList

    Dim DTDoctor As New DataTable
    Dim DTPatient As New DataTable

    Sub New(MyParent As frmAppointmentsList)
        InitializeComponent()
        Me.MyParent = MyParent

        DTDoctor = My.Application.DBA.DoctorsList()
        DTPatient = My.Application.DBA.PatientsList()

        With doctorNameCB
            .DataSource = DTDoctor
            .DisplayMember = "DoctorName"
            .ValueMember = "DoctorID"
            .SelectedValue = 0
        End With

        With patientNameCB
            .DataSource = DTPatient
            .DisplayMember = "PatientName"
            .ValueMember = "PatientID"
            .SelectedValue = 0
        End With

        datePicker.CustomFormat = "dd MMMM yyyy"
    End Sub

    Private Sub doctorNameCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles doctorNameCB.SelectedIndexChanged
        If doctorNameCB.SelectedValue IsNot Nothing AndAlso TypeOf doctorNameCB.SelectedValue Is Integer Then
            Dim selectedDoctorID As Integer = doctorNameCB.SelectedValue
            Dim doctorRow As DataRow = DTDoctor.Rows.Cast(Of DataRow).FirstOrDefault(Function(row) CInt(row("DoctorID")) = selectedDoctorID)

            roomTB.Text = doctorRow("DoctorRoom").ToString()
        End If
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Dim appointment As New Appointment
        Dim patientID As Integer = patientNameCB.SelectedValue
        Dim doctorID As Integer = doctorNameCB.SelectedValue
        Dim appointmentDate As DateTime = datePicker.Value.Date
        Dim appointmentTime As TimeSpan = timePicker.Value.TimeOfDay
        Dim formattedAppointmentTime As String = appointmentTime.ToString("hh\:mm\:ss")
        Dim fullAppointmentDateTime As DateTime = appointmentDate.Add(appointmentTime)
        Dim result As String

        appointment.PatientId = Trim(patientID)
        appointment.DoctorId = Trim(doctorID)
        appointment.AppointmentDate = Trim(appointmentDate.ToString("dd MMMM yyyy"))
        appointment.AppointmentTime = formattedAppointmentTime
        appointment.AppointmentDescription = Trim(descriptionTB.Text)

        If fullAppointmentDateTime < DateTime.Now Then
            MessageBox.Show("The appointment date and time cannot be in the past.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not String.IsNullOrEmpty(doctorNameCB.Text) And Not String.IsNullOrWhiteSpace(doctorNameCB.Text) And Not String.IsNullOrEmpty(patientNameCB.Text) And Not String.IsNullOrWhiteSpace(patientNameCB.Text) And Not String.IsNullOrEmpty(roomTB.Text) And Not String.IsNullOrWhiteSpace(roomTB.Text) Then
            result = My.Application.DBA.AddAppointment(appointment)
            If result = "Success" Then
                MyParent.RefreshData()
                Close()
            End If
        Else
            MessageBox.Show("Make sure you fill all the required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Close()
    End Sub
End Class