Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.ApplicationServices

Public Class DBAccess

    Private SQLConn As SqlConnection
    Private ServerAddress As String
    Private DBInstance As String
    Private DBName As String
    Private UserDB As String
    Private PassDB As String

    Public Sub New(serverAddress As String, dBInstance As String, dBName As String, userDB As String, passDB As String)
        Me.ServerAddress = serverAddress
        Me.DBInstance = dBInstance
        Me.DBName = dBName
        Me.UserDB = userDB
        Me.PassDB = passDB
    End Sub

    Public Sub OpenSqlConn()
        SQLConn = New SqlConnection(
            "Data Source=" & ServerAddress & "\" & DBInstance & ";
            Database=" & DBName & ";
            User Id=" & UserDB & "; 
            Password=" & PassDB & ";"
        )

        If SQLConn.State = ConnectionState.Closed Then
            SQLConn.Open()
        ElseIf SQLConn.State = ConnectionState.Broken Then
            SQLConn.Close()
            SQLConn.Open()
        End If
    End Sub

    Public Sub CloseSqlConn()
        If SQLConn.State = ConnectionState.Open Then
            SQLConn.Close()
        ElseIf SQLConn.State = ConnectionState.Connecting Then
            SQLConn.Close()
        ElseIf SQLConn.State = ConnectionState.Broken Then
            SQLConn.Close()
        End If
    End Sub

    Public Function CheckDBConn() As Boolean
        Try
            OpenSqlConn()
            If SQLConn.State = ConnectionState.Open Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function UserLogin(Uname As String, ByVal PasswordCipher As String) As User
        Dim p As User
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_UserLogin", Me.SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@Uname", SqlDbType.NVarChar, 50)
            SQLCmd.Parameters("@Uname").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@Uname").Value = Uname

            SQLCmd.Parameters.Add("@Upass", SqlDbType.NVarChar, -1)
            SQLCmd.Parameters("@Upass").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@Upass").Value = PasswordCipher

            Dim reader As SqlDataReader
            reader = SQLCmd.ExecuteReader

            While reader.Read
                If reader.HasRows Then
                    p = New User(reader.Item("UserId"), reader.Item("UserName"), reader.Item("UserRole"))
                    Return p
                Else
                    p = Nothing
                End If
            End While
            reader.Close()
            Return Nothing
        Catch ex As Exception
            p = Nothing
            Return p
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function UsersList() As DataTable
        Dim DT As New DataTable
        Try
            Dim DA As New SqlDataAdapter("usp_UserList", Me.SQLConn)
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            DA.Fill(DT)
            Return DT
        Catch ex As Exception
            Return DT
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function AddUser(ByVal User As User) As String
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_AddUser", Me.SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 100)
            SQLCmd.Parameters("@UserName").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@UserName").Value = User.UserName

            SQLCmd.Parameters.Add("@Uname", SqlDbType.NVarChar, 50)
            SQLCmd.Parameters("@Uname").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@Uname").Value = User.Uname

            SQLCmd.Parameters.Add("@Upass", SqlDbType.NVarChar, -1)
            SQLCmd.Parameters("@Upass").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@Upass").Value = User.Upass

            SQLCmd.Parameters.Add("@UserRole", SqlDbType.Int)
            SQLCmd.Parameters("@UserRole").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@UserRole").Value = User.UserRole

            SQLCmd.ExecuteNonQuery()
            Return "Success"
        Catch ex As Exception
            MessageBox.Show("Error Inserting New User: " & ex.Message,
                           "ERROR DBA.AddUser()",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error)
            Return "Fail"
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function DeleteUser(UserId As Integer) As String
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_DeleteUser", SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@UserID", SqlDbType.Int)
            SQLCmd.Parameters("@UserID").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@UserID").Value = UserId

            SQLCmd.ExecuteNonQuery()
            Return "Success"
        Catch ex As Exception
            MessageBox.Show("Error Deleting User: " & ex.Message,
                           "ERROR DBA.DeleteUser()",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error)
            Return "Fail"
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function PatientsList() As DataTable
        Dim DT As New DataTable
        Try
            Dim DA As New SqlDataAdapter("usp_PatientList", Me.SQLConn)
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            DA.Fill(DT)
            Return DT
        Catch ex As Exception
            Return DT
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function UpdatePatient(patient As Patient) As String
        Try
            OpenSqlConn()

            Dim SQLCmd As New SqlCommand("usp_UpdatePatient", SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@PatientID", SqlDbType.Int)
            SQLCmd.Parameters("@PatientID").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@PatientID").Value = patient.PatientId

            SQLCmd.Parameters.Add("@PatientName", SqlDbType.VarChar, 100)
            SQLCmd.Parameters("@PatientName").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@PatientName").Value = patient.PatientName

            SQLCmd.Parameters.Add("@PatientEmail", SqlDbType.VarChar, 50)
            SQLCmd.Parameters("@PatientEmail").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@PatientEmail").Value = patient.PatientEmail

            SQLCmd.Parameters.Add("@PatientPhone", SqlDbType.VarChar, 20)
            SQLCmd.Parameters("@PatientPhone").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@PatientPhone").Value = patient.PatientPhone

            SQLCmd.ExecuteNonQuery()
            Return "Success"
        Catch ex As Exception
            MessageBox.Show("Error Updating Patient: " & ex.Message,
                            "ERROR DBA.UpdatePatient()",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return "Fail"
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function AddPatient(Patient As Patient) As String
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_AddPatient", Me.SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@PatientName", SqlDbType.NVarChar, 100)
            SQLCmd.Parameters("@PatientName").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@PatientName").Value = Patient.PatientName

            SQLCmd.Parameters.Add("@PatientEmail", SqlDbType.NVarChar, 50)
            SQLCmd.Parameters("@PatientEmail").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@PatientEmail").Value = Patient.PatientEmail

            SQLCmd.Parameters.Add("@PatientPhone", SqlDbType.NVarChar, 20)
            SQLCmd.Parameters("@PatientPhone").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@PatientPhone").Value = Patient.PatientPhone

            SQLCmd.ExecuteNonQuery()
            Return "Success"
        Catch ex As Exception
            MessageBox.Show("Error Inserting New Patient: " & ex.Message,
                           "ERROR DBA.AddPatient()",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error)
            Return "Fail"
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function DoctorsList() As DataTable
        Dim DT As New DataTable
        Try
            Dim DA As New SqlDataAdapter("usp_DoctorList", Me.SQLConn)
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            DA.Fill(DT)
            Return DT
        Catch ex As Exception
            Return DT
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function AddDoctor(doctor As Doctor) As String
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_AddDoctor", Me.SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@DoctorName", SqlDbType.NVarChar, 100)
            SQLCmd.Parameters("@DoctorName").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@DoctorName").Value = doctor.DoctorName

            SQLCmd.Parameters.Add("@DoctorSpecialization", SqlDbType.Int)
            SQLCmd.Parameters("@DoctorSpecialization").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@DoctorSpecialization").Value = doctor.DoctorSpecialization

            SQLCmd.Parameters.Add("@DoctorEmail", SqlDbType.NVarChar, 50)
            SQLCmd.Parameters("@DoctorEmail").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@DoctorEmail").Value = doctor.DoctorEmail

            SQLCmd.Parameters.Add("@DoctorPhone", SqlDbType.NVarChar, 20)
            SQLCmd.Parameters("@DoctorPhone").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@DoctorPhone").Value = doctor.DoctorPhone

            SQLCmd.Parameters.Add("@DoctorRoom", SqlDbType.NVarChar, 10)
            SQLCmd.Parameters("@DoctorRoom").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@DoctorRoom").Value = doctor.DoctorRoom

            SQLCmd.ExecuteNonQuery()
            Return "Success"
        Catch ex As Exception
            MessageBox.Show("Error Inserting New Doctor: " & ex.Message,
                           "ERROR DBA.AddDoctor()",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error)
            Return "Fail"
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function UpdateDoctor(doctor As Doctor) As String
        Try
            OpenSqlConn()

            Dim SQLCmd As New SqlCommand("usp_UpdateDoctor", SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@DoctorID", SqlDbType.Int)
            SQLCmd.Parameters("@DoctorID").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@DoctorID").Value = doctor.DoctorId

            SQLCmd.Parameters.Add("@DoctorName", SqlDbType.VarChar, 100)
            SQLCmd.Parameters("@DoctorName").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@DoctorName").Value = doctor.DoctorName

            SQLCmd.Parameters.Add("@DoctorSpecialization", SqlDbType.Int)
            SQLCmd.Parameters("@DoctorSpecialization").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@DoctorSpecialization").Value = doctor.DoctorSpecialization

            SQLCmd.Parameters.Add("@DoctorEmail", SqlDbType.VarChar, 50)
            SQLCmd.Parameters("@DoctorEmail").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@DoctorEmail").Value = doctor.DoctorEmail

            SQLCmd.Parameters.Add("@DoctorPhone", SqlDbType.VarChar, 20)
            SQLCmd.Parameters("@DoctorPhone").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@DoctorPhone").Value = doctor.DoctorPhone

            SQLCmd.Parameters.Add("@DoctorRoom", SqlDbType.VarChar, 10)
            SQLCmd.Parameters("@DoctorRoom").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@DoctorRoom").Value = doctor.DoctorRoom

            SQLCmd.ExecuteNonQuery()
            Return "Success"
        Catch ex As Exception
            MessageBox.Show("Error Updating Doctor: " & ex.Message,
                            "ERROR DBA.UpdateDoctor()",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return "Fail"
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function DeleteDoctor(DoctorId As Integer) As String
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_DeleteDoctor", SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@DoctorID", SqlDbType.Int)
            SQLCmd.Parameters("@DoctorID").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@DoctorID").Value = DoctorId

            SQLCmd.ExecuteNonQuery()
            Return "Success"
        Catch ex As Exception
            MessageBox.Show("Error Deleting Doctor: " & ex.Message,
                           "ERROR DBA.DeleteDoctor()",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error)
            Return "Fail"
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function SpecializationsList() As DataTable
        Dim DT As New DataTable
        Try
            Dim DA As New SqlDataAdapter("usp_SpecializationList", Me.SQLConn)
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            DA.Fill(DT)
            Return DT
        Catch ex As Exception
            Return DT
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function AddSpecialization(SpecializationName As String) As String
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_AddSpecialization", Me.SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@SpecializationName", SqlDbType.NVarChar, 20)
            SQLCmd.Parameters("@SpecializationName").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@SpecializationName").Value = SpecializationName

            SQLCmd.ExecuteNonQuery()
            Return "Success"
        Catch ex As Exception
            MessageBox.Show("Error Inserting New Doctor: " & ex.Message,
                           "ERROR DBA.AddDoctor()",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error)
            Return "Fail"
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function DeleteSpecialization(SpecializationId As Integer) As String
        Try
            OpenSqlConn()
            Dim SQLCmd As New SqlCommand("usp_DeleteSpecialization", SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@SpecializationID", SqlDbType.Int)
            SQLCmd.Parameters("@SpecializationID").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@SpecializationID").Value = SpecializationId

            SQLCmd.ExecuteNonQuery()
            Return "Success"
        Catch ex As Exception
            MessageBox.Show("Error Deleting Specialization: " & ex.Message,
                           "ERROR DBA.DeleteSpecialization()",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error)
            Return "Fail"
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function AppointmentsList() As DataTable
        Dim DT As New DataTable
        Try
            Dim DA As New SqlDataAdapter("usp_AppointmentList", Me.SQLConn)
            DA.SelectCommand.CommandType = CommandType.StoredProcedure
            DA.Fill(DT)
            Return DT
        Catch ex As Exception
            Return DT
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function AddAppointment(appointment As Appointment) As String
        Try
            OpenSqlConn()

            Dim SQLCmd As New SqlCommand("usp_AddAppointment", Me.SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@PatientID", SqlDbType.Int)
            SQLCmd.Parameters("@PatientID").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@PatientID").Value = appointment.PatientId

            SQLCmd.Parameters.Add("@DoctorID", SqlDbType.Int)
            SQLCmd.Parameters("@DoctorID").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@DoctorID").Value = appointment.DoctorId

            SQLCmd.Parameters.Add("@AppointmentDate", SqlDbType.Date)
            SQLCmd.Parameters("@AppointmentDate").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@AppointmentDate").Value = appointment.AppointmentDate

            SQLCmd.Parameters.Add("@AppointmentTime", SqlDbType.Time)
            SQLCmd.Parameters("@AppointmentTime").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@AppointmentTime").Value = appointment.AppointmentTime

            SQLCmd.Parameters.Add("@AppointmentDescription", SqlDbType.NVarChar, 100)
            SQLCmd.Parameters("@AppointmentDescription").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@AppointmentDescription").Value = appointment.AppointmentDescription

            SQLCmd.ExecuteNonQuery()
            Return "Success"
        Catch ex As Exception
            MessageBox.Show("Error Inserting New Appointment: " & ex.Message,
                           "ERROR DBA.AddAppointment()",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error)
            Return "Fail"
        Finally
            CloseSqlConn()
        End Try
    End Function

    Public Function UpdateAppointment(appointment As Appointment) As String
        Try
            OpenSqlConn()

            Dim SQLCmd As New SqlCommand("usp_UpdateAppointment", SQLConn)
            SQLCmd.CommandType = CommandType.StoredProcedure

            SQLCmd.Parameters.Add("@AppointmentID", SqlDbType.Int)
            SQLCmd.Parameters("@AppointmentID").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@AppointmentID").Value = appointment.AppointmentId

            SQLCmd.Parameters.Add("@PatientID", SqlDbType.Int)
            SQLCmd.Parameters("@PatientID").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@PatientID").Value = appointment.PatientId

            SQLCmd.Parameters.Add("@DoctorID", SqlDbType.Int)
            SQLCmd.Parameters("@DoctorID").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@DoctorID").Value = appointment.DoctorId

            SQLCmd.Parameters.Add("@AppointmentDate", SqlDbType.Date)
            SQLCmd.Parameters("@AppointmentDate").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@AppointmentDate").Value = appointment.AppointmentDate

            SQLCmd.Parameters.Add("@AppointmentTime", SqlDbType.Time)
            SQLCmd.Parameters("@AppointmentTime").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@AppointmentTime").Value = appointment.AppointmentTime

            SQLCmd.Parameters.Add("@AppointmentRoom", SqlDbType.NVarChar, 10)
            SQLCmd.Parameters("@AppointmentRoom").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@AppointmentRoom").Value = appointment.AppointmentRoom

            SQLCmd.Parameters.Add("@AppointmentDescription", SqlDbType.NVarChar, 100)
            SQLCmd.Parameters("@AppointmentDescription").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@AppointmentDescription").Value = appointment.AppointmentDescription

            SQLCmd.Parameters.Add("@AppointmentStatus", SqlDbType.Int)
            SQLCmd.Parameters("@AppointmentStatus").Direction = ParameterDirection.Input
            SQLCmd.Parameters("@AppointmentStatus").Value = appointment.AppointmentStatus

            SQLCmd.ExecuteNonQuery()
            Return "Success"
        Catch ex As Exception
            MessageBox.Show("Error Updating Appointment: " & ex.Message,
                            "ERROR DBA.UpdateAppointment()",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return "Fail"
        Finally
            CloseSqlConn()
        End Try
    End Function
End Class
