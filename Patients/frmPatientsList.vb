Imports System.Diagnostics.Tracing
Imports Microsoft.VisualBasic.ApplicationServices

Public Class frmPatientsList

    Dim DTPatient As New DataTable

    Dim patient As Patient

    Sub New()
        InitializeComponent()
        RefreshData()
    End Sub

    Public Sub RefreshData()
        DTPatient = My.Application.DBA.PatientsList()
        dgvPatient.DataSource = DTPatient
    End Sub

    Private Sub dgvPatient_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvPatient.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim HT As DataGridView.HitTestInfo
            HT = Me.dgvPatient.HitTest(e.X, e.Y)

            If HT.Type = DataGridViewHitTestType.Cell Then
                patient.PatientId = Me.dgvPatient.Item("PatientIdCol", HT.RowIndex).Value
                patient.PatientName = Me.dgvPatient.Item("PatientNameCol", HT.RowIndex).Value
                patient.PatientEmail = Me.dgvPatient.Item("PatientEmailCol", HT.RowIndex).Value
                If IsDBNull(Me.dgvPatient.Item("PatientPhoneCol", HT.RowIndex).Value) Then
                    patient.PatientPhone = ""
                Else
                    patient.PatientPhone = Me.dgvPatient.Item("PatientPhoneCol", HT.RowIndex).Value
                End If

                Me.dgvPatient.Rows(HT.RowIndex).Selected = True
                Me.dgvPatient.ContextMenuStrip = patientCMS
            Else
                Me.dgvPatient.ContextMenuStrip = Nothing
            End If
        Else
            Me.dgvPatient.ContextMenuStrip = Nothing
        End If
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Close()
    End Sub

    Private Sub searchTB_KeyUp(sender As Object, e As KeyEventArgs) Handles searchTB.KeyUp
        If Not String.IsNullOrEmpty(searchTB.Text) And Not String.IsNullOrWhiteSpace(searchTB.Text) Then
            DTPatient.DefaultView.RowFilter = "(PatientName Like '%" & searchTB.Text & "%')"
        Else
            DTPatient.DefaultView.RowFilter = ""
        End If
    End Sub

    Private Sub UpdatePatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdatePatientToolStripMenuItem.Click
        Dim fUpdatePatient As New frmUpdatePatient(Me, patient)
        fUpdatePatient.ShowDialog()
    End Sub

    Private Sub addPatientBtn_Click(sender As Object, e As EventArgs) Handles addPatientBtn.Click
        Dim fAddPatient As New frmAddPatient(Me)
        fAddPatient.ShowDialog()
    End Sub

    Private Sub reportBtn_Click(sender As Object, e As EventArgs) Handles reportBtn.Click
        Dim Report As New ExcelPatientReport()
        Report.Generate(DTPatient)
    End Sub
End Class