Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmSettings

    Sub New()
        InitializeComponent()
        ipServerTB.Text = My.Application.CRW.ServerAddress
        dbInstanceTB.Text = My.Application.CRW.DBInstance
        databaseTB.Text = My.Application.CRW.DBName
        usernameTB.Text = My.Application.CRW.UserDB
        passwordTB.Text = My.Application.CRW.PassDB
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Dim tAddress As String = Trim(ipServerTB.Text)
        Dim tDBI As String = Trim(dbInstanceTB.Text)
        Dim tDBN As String = Trim(databaseTB.Text)
        Dim tUser As String = Trim(usernameTB.Text)
        Dim tPass As String = Trim(passwordTB.Text)
        My.Application.CRW.WriteConfig(tAddress, tDBI, tDBN, tUser, tPass)
        Application.Restart()
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Close()
    End Sub
End Class