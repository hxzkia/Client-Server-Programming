Public Class frmAddDoctor

    Dim MyParent As frmDoctorsList
    Dim DTSpecialization As DataTable

    Sub New(MyParent As frmDoctorsList)
        InitializeComponent()
        Me.MyParent = MyParent

        DTSpecialization = My.Application.DBA.SpecializationsList()

        With specializationCB
            .DataSource = DTSpecialization
            .DisplayMember = "SpecializationName"
            .ValueMember = "SpecializationID"
            .SelectedValue = 0
        End With
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Dim doctor As New Doctor
        Dim result As String

        If Not String.IsNullOrEmpty(nameTB.Text) And Not String.IsNullOrWhiteSpace(specializationCB.Text) And Not String.IsNullOrEmpty(specializationCB.Text) And Not String.IsNullOrWhiteSpace(emailTB.Text) And Not String.IsNullOrEmpty(emailTB.Text) And Not String.IsNullOrWhiteSpace(emailTB.Text) And Not String.IsNullOrEmpty(roomTB.Text) And Not String.IsNullOrWhiteSpace(roomTB.Text) Then
            doctor.DoctorName = Trim(nameTB.Text)
            doctor.DoctorSpecialization = Trim(specializationCB.SelectedValue)
            doctor.DoctorEmail = Trim(emailTB.Text)
            doctor.DoctorPhone = Trim(phoneTB.Text)
            doctor.DoctorRoom = Trim(roomTB.Text)
            result = My.Application.DBA.AddDoctor(doctor)
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