Imports Microsoft.VisualBasic.ApplicationServices

Public Class frmLogin

    Dim sec As New Security
    Dim PForm As frmMain

    Sub New(_PForm As frmMain)
        InitializeComponent()
        PForm = _PForm
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        If String.IsNullOrEmpty(usernameTB.Text) Or String.IsNullOrWhiteSpace(usernameTB.Text) Or String.IsNullOrEmpty(passwordTB.Text) Or String.IsNullOrWhiteSpace(passwordTB.Text) Then
            MessageBox.Show("Username/Password MUST be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            My.Application.User = My.Application.DBA.UserLogin(Trim(usernameTB.Text), sec.GetHash(Trim(passwordTB.Text)))
            If Not My.Application.User Is Nothing Then
                PForm.Login()
                Close()
            Else
                MessageBox.Show("Wrong Username/Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub usernameTB_KeyUp(sender As Object, e As KeyEventArgs) Handles usernameTB.KeyUp
        If e.KeyCode = Keys.Enter Then
            loginBtn_Click(sender, e)
        End If
    End Sub

    Private Sub passwordTB_KeyUp(sender As Object, e As KeyEventArgs) Handles passwordTB.KeyUp
        If e.KeyCode = Keys.Enter Then
            loginBtn_Click(sender, e)
        End If
    End Sub
End Class