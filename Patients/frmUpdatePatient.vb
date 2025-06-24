Public Class frmUpdatePatient

    Dim MyParent As frmPatientsList
    Dim DTPatient As DataTable

    Dim patient As New Patient

    Public Sub New(myParent As frmPatientsList, patient As Patient)
        InitializeComponent()
        Me.MyParent = myParent
        Me.patient = patient

        DTPatient = My.Application.DBA.PatientsList()

        idTB.Text = patient.PatientId
        nameTB.Text = patient.PatientName
        emailTB.Text = patient.PatientEmail
        phoneTB.Text = patient.PatientPhone
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Close()
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        Dim result As String

        patient.PatientId = Trim(idTB.Text)
        patient.PatientName = Trim(nameTB.Text)
        patient.PatientEmail = Trim(emailTB.Text)
        patient.PatientPhone = Trim(phoneTB.Text)

        If Not String.IsNullOrEmpty(nameTB.Text) And Not String.IsNullOrWhiteSpace(nameTB.Text) And Not String.IsNullOrEmpty(emailTB.Text) And Not String.IsNullOrWhiteSpace(emailTB.Text) Then
            result = My.Application.DBA.UpdatePatient(patient)
            If result = "Success" Then
                MessageBox.Show("Patient info updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MyParent.RefreshData()
                Close()
            Else
                MessageBox.Show("Failed updating patient info.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Make sure you fill all the required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class