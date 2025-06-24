Public Class frmDoctorsList

    Dim DTDoctor As New DataTable
    Dim DTSpecialization As New DataTable

    Dim doctor As Doctor

    Sub New()
        InitializeComponent()
        RefreshData()

        If My.Application.User.UserRole = 0 Then
            newDoctorBtn.Visible = False
            UpdateDoctorToolStripMenuItem.Visible = False
            DeleteDoctorToolStripMenuItem.Visible = False
        End If

        DTSpecialization = My.Application.DBA.SpecializationsList()
        Dim DRow As DataRow = DTSpecialization.NewRow()
        DRow("SpecializationID") = 0
        DRow("SpecializationName") = "All Specialization"
        DTSpecialization.Rows.Add(DRow)

        With specializationCB
            .DataSource = DTSpecialization
            .DisplayMember = "SpecializationName"
            .ValueMember = "SpecializationID"
            .SelectedValue = 0
        End With
    End Sub

    Public Sub RefreshData()
        DTDoctor = My.Application.DBA.DoctorsList()
        dgvDoctor.DataSource = DTDoctor
    End Sub

    Private Sub Search()
        If specializationCB.SelectedValue > 0 Then
            If Not String.IsNullOrEmpty(searchTB.Text) And Not String.IsNullOrWhiteSpace(searchTB.Text) Then
                DTDoctor.DefaultView.RowFilter = "Specialization = " & specializationCB.SelectedValue & " AND (DoctorName Like '%" & searchTB.Text & "%')"
            Else
                DTDoctor.DefaultView.RowFilter = "Specialization = " & specializationCB.SelectedValue
            End If
        Else
            If Not String.IsNullOrEmpty(searchTB.Text) And Not String.IsNullOrWhiteSpace(searchTB.Text) Then
                DTDoctor.DefaultView.RowFilter = "DoctorName LIKE '%" & searchTB.Text & "%'"
            Else
                DTDoctor.DefaultView.RowFilter = ""
            End If
        End If
    End Sub

    Private Sub searchTB_KeyUp(sender As Object, e As KeyEventArgs) Handles searchTB.KeyUp
        Search()
    End Sub

    Private Sub specializationCB_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles specializationCB.SelectionChangeCommitted
        Search()
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Close()
    End Sub

    Private Sub dgvDoctor_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvDoctor.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim HT As DataGridView.HitTestInfo
            HT = Me.dgvDoctor.HitTest(e.X, e.Y)

            If HT.Type = DataGridViewHitTestType.Cell Then
                doctor.DoctorId = Me.dgvDoctor.Item("DoctorIdCol", HT.RowIndex).Value
                doctor.DoctorName = Me.dgvDoctor.Item("DoctorNameCol", HT.RowIndex).Value
                doctor.DoctorSpecialization = Me.dgvDoctor.Item("SpecializationIdCol", HT.RowIndex).Value
                doctor.DoctorEmail = Me.dgvDoctor.Item("DoctorEmailCol", HT.RowIndex).Value
                If IsDBNull(Me.dgvDoctor.Item("DoctorPhoneCol", HT.RowIndex).Value) Then
                    doctor.DoctorPhone = ""
                Else
                    doctor.DoctorPhone = Me.dgvDoctor.Item("DoctorPhoneCol", HT.RowIndex).Value
                End If
                doctor.DoctorRoom = Me.dgvDoctor.Item("DoctorRoomCol", HT.RowIndex).Value
                doctor.DoctorStatus = Me.dgvDoctor.Item("DoctorStatusCol", HT.RowIndex).Value

                Me.dgvDoctor.Rows(HT.RowIndex).Selected = True
                Me.dgvDoctor.ContextMenuStrip = doctorCMS
            Else
                Me.dgvDoctor.ContextMenuStrip = Nothing
            End If
        Else
            Me.dgvDoctor.ContextMenuStrip = Nothing
        End If
    End Sub

    Private Sub UpdateDoctorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateDoctorToolStripMenuItem.Click
        Dim fUpdateDoctor As New frmUpdateDoctor(Me, doctor)
        fUpdateDoctor.ShowDialog()
    End Sub

    Private Sub newDoctorBtn_Click(sender As Object, e As EventArgs) Handles newDoctorBtn.Click
        Dim fAddDoctor As New frmAddDoctor(Me)
        fAddDoctor.ShowDialog()
    End Sub

    Private Sub DeleteDoctorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteDoctorToolStripMenuItem.Click
        Dim result As String
        Dim i As DialogResult
        i = MessageBox.Show($"Delete Doctor {doctor.DoctorName}?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If i = DialogResult.Yes Then
            result = My.Application.DBA.DeleteDoctor(doctor.DoctorId)
            If result = "Success" Then
                Me.RefreshData()
            Else
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub reportBtn_Click(sender As Object, e As EventArgs) Handles reportBtn.Click
        Dim Report As New ExcelDoctorReport()
        Report.Generate(DTDoctor)
    End Sub
End Class