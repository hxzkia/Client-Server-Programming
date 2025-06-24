Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class frmSpecializationsList

    Dim DTSpecialization As New DataTable

    Dim SpecializationId As Integer
    Dim SpecializationName As String

    Sub New()
        InitializeComponent()
        RefreshData()

        If My.Application.User.UserRole = 0 Then
            newSpecializationBtn.Visible = False
            DeleteSpecializationToolStripMenuItem.Visible = False
        End If
    End Sub

    Public Sub RefreshData()
        DTSpecialization = My.Application.DBA.SpecializationsList()
        dgvSpecialization.DataSource = DTSpecialization
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Close()
    End Sub

    Private Sub newSpecializationBtn_Click(sender As Object, e As EventArgs) Handles newSpecializationBtn.Click
        Dim fAddSpecialization As New frmAddSpecialization(Me)
        fAddSpecialization.ShowDialog()
    End Sub

    Private Sub dgvSpecialization_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvSpecialization.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim HT As DataGridView.HitTestInfo
            HT = Me.dgvSpecialization.HitTest(e.X, e.Y)

            If HT.Type = DataGridViewHitTestType.Cell Then
                SpecializationId = Me.dgvSpecialization.Item("SpecializationIdCol", HT.RowIndex).Value
                SpecializationName = Me.dgvSpecialization.Item("SpecializationNameCol", HT.RowIndex).Value

                Me.dgvSpecialization.Rows(HT.RowIndex).Selected = True
                Me.dgvSpecialization.ContextMenuStrip = specializationCMS
            Else
                Me.dgvSpecialization.ContextMenuStrip = Nothing
            End If
        Else
            Me.dgvSpecialization.ContextMenuStrip = Nothing
        End If
    End Sub

    Private Sub DeleteSpecializationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSpecializationToolStripMenuItem.Click
        Dim result As String
        Dim i As DialogResult
        i = MessageBox.Show($"Delete {SpecializationName}?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If i = DialogResult.Yes Then
            result = My.Application.DBA.DeleteSpecialization(SpecializationId)
            If result = "Success" Then
                Me.RefreshData()
            Else
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub reportBtn_Click(sender As Object, e As EventArgs) Handles reportBtn.Click
        Dim Report As New ExcelSpecializationReport()
        Report.Generate(DTSpecialization)
    End Sub
End Class