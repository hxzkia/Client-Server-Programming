Public Class frmUsersList

    Dim DTUser As New DataTable

    Dim UserId As Integer
    Dim UserName As String
    Dim UName As String
    Dim UserStatus As String

    Sub New()
        InitializeComponent()
        RefreshData()

        If My.Application.User.UserRole = 1 Then
            DeleteUserToolStripMenuItem.Visible = False
        End If
    End Sub

    Public Sub RefreshData()
        DTUser = My.Application.DBA.UsersList()
        dgvUser.DataSource = DTUser
    End Sub

    Private Sub dgvUser_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvUser.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim HT As DataGridView.HitTestInfo
            HT = Me.dgvUser.HitTest(e.X, e.Y)

            If HT.Type = DataGridViewHitTestType.Cell Then
                UserId = Me.dgvUser.Item("UserIdCol", HT.RowIndex).Value
                UserName = Me.dgvUser.Item("UserNameCol", HT.RowIndex).Value
                UName = Me.dgvUser.Item("UNameCol", HT.RowIndex).Value
                UserStatus = Me.dgvUser.Item("UserStatusCol", HT.RowIndex).Value


                Me.dgvUser.Rows(HT.RowIndex).Selected = True
                Me.dgvUser.ContextMenuStrip = userCMS
            Else
                Me.dgvUser.ContextMenuStrip = Nothing
            End If
        Else
            Me.dgvUser.ContextMenuStrip = Nothing
        End If
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Close()
    End Sub

    Private Sub newUserBtn_Click(sender As Object, e As EventArgs) Handles newUserBtn.Click
        Dim fAddUsers As New frmNewUser(Me)
        fAddUsers.ShowDialog()
    End Sub

    Private Sub DeleteUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteUserToolStripMenuItem.Click
        Dim result As String
        Dim i As DialogResult
        i = MessageBox.Show($"Delete User {Me.UserName}?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If i = DialogResult.Yes Then
            result = My.Application.DBA.DeleteUser(Me.UserId)
            If result = "Success" Then
                Me.RefreshData()
            Else
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub searchTB_KeyUp(sender As Object, e As KeyEventArgs) Handles searchTB.KeyUp
        If Not String.IsNullOrEmpty(searchTB.Text) And Not String.IsNullOrWhiteSpace(searchTB.Text) Then
            DTUser.DefaultView.RowFilter = "(UserName Like '%" & searchTB.Text & "%' OR UName LIKE '%" & searchTB.Text & "%')"
        Else
            DTUser.DefaultView.RowFilter = ""
        End If
    End Sub

    Private Sub reportBtn_Click(sender As Object, e As EventArgs) Handles reportBtn.Click
        Dim Report As New ExcelUserReport()
        Report.Generate(DTUser)
    End Sub
End Class