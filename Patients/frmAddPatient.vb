Public Class frmAddPatient

    Dim MyParent As frmPatientsList

    Sub New(MyParent As frmPatientsList)
        InitializeComponent()
        Me.MyParent = MyParent
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Dim Patient As New Patient
        Dim result As String

        Patient.PatientName = Trim(nameTB.Text)
        Patient.PatientEmail = Trim(emailTB.Text)
        Patient.PatientPhone = Trim(phoneTB.Text)

        If Not String.IsNullOrEmpty(nameTB.Text) And Not String.IsNullOrWhiteSpace(nameTB.Text) And Not String.IsNullOrEmpty(emailTB.Text) And Not String.IsNullOrWhiteSpace(emailTB.Text) Then
            result = My.Application.DBA.AddPatient(Patient)
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