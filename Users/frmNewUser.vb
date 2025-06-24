Public Class frmNewUser

    Dim MyParent As frmUsersList

    Sub New(MyParent As frmUsersList)
        InitializeComponent()
        Me.MyParent = MyParent
        roleCB.SelectedIndex = 0

        If My.Application.User.UserRole = 1 Then
            roleCB.Enabled = False
        End If
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Dim sec As New Security
        Dim User As New User
        Dim result As String

        User.UserName = Trim(nameTB.Text)
        User.Uname = Trim(usernameTB.Text)
        User.Upass = Trim(sec.GetHash(passwordTB.Text))
        User.UserRole = roleCB.SelectedIndex


        If Not String.IsNullOrEmpty(nameTB.Text) And Not String.IsNullOrWhiteSpace(nameTB.Text) And Not String.IsNullOrEmpty(usernameTB.Text) And Not String.IsNullOrWhiteSpace(usernameTB.Text) And Not String.IsNullOrWhiteSpace(passwordTB.Text) And Not String.IsNullOrEmpty(passwordTB.Text) And Not String.IsNullOrWhiteSpace(retypeTB.Text) And Not String.IsNullOrEmpty(retypeTB.Text) Then
            If passwordTB.Text = retypeTB.Text Then
                result = My.Application.DBA.AddUser(User)
                If result = "Success" Then
                    MyParent.RefreshData()
                    Close()
                End If
            Else
                MessageBox.Show("Password and retype password fields are different!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Make sure you fill all the required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Close()
    End Sub
End Class