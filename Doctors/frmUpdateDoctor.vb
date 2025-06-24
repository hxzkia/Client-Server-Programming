Public Class frmUpdateDoctor

    Dim MyParent As frmDoctorsList
    Dim DTSpecialization As DataTable

    Dim doctor As New Doctor

    Public Sub New(myParent As frmDoctorsList, doctor As Doctor)
        InitializeComponent()
        Me.MyParent = myParent
        Me.doctor = doctor

        DTSpecialization = My.Application.DBA.SpecializationsList()

        With specializationCB
            .DataSource = DTSpecialization
            .DisplayMember = "SpecializationName"
            .ValueMember = "SpecializationId"
            .SelectedValue = doctor.DoctorSpecialization
        End With

        idTB.Text = doctor.DoctorId
        nameTB.Text = doctor.DoctorName
        emailTB.Text = doctor.DoctorEmail
        phoneTB.Text = doctor.DoctorPhone
        roomTB.Text = doctor.DoctorRoom
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Close()
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        Dim result As String

        doctor.DoctorId = Trim(idTB.Text)
        doctor.DoctorName = Trim(nameTB.Text)
        doctor.DoctorSpecialization = Trim(specializationCB.SelectedValue)
        doctor.DoctorEmail = Trim(emailTB.Text)
        doctor.DoctorPhone = Trim(phoneTB.Text)
        doctor.DoctorRoom = Trim(roomTB.Text)

        If Not String.IsNullOrEmpty(nameTB.Text) And Not String.IsNullOrWhiteSpace(nameTB.Text) And Not String.IsNullOrEmpty(emailTB.Text) And Not String.IsNullOrWhiteSpace(emailTB.Text) And Not String.IsNullOrEmpty(roomTB.Text) And Not String.IsNullOrWhiteSpace(roomTB.Text) Then
            result = My.Application.DBA.UpdateDoctor(doctor)
            If result = "Success" Then
                MessageBox.Show("Doctor info updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MyParent.RefreshData()
                Close()
            Else
                MessageBox.Show("Failed updating doctor info.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Make sure you fill all the required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class