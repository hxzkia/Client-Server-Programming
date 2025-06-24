Public Class frmAddSpecialization

    Dim MyParent As frmSpecializationsList
    Dim SpecializationName As String

    Sub New(MyParent As frmSpecializationsList)
        InitializeComponent()
        Me.MyParent = MyParent
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Dim result As String

        SpecializationName = Trim(nameTB.Text)

        If Not String.IsNullOrEmpty(nameTB.Text) And Not String.IsNullOrWhiteSpace(nameTB.Text) Then
            result = My.Application.DBA.AddSpecialization(SpecializationName)
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