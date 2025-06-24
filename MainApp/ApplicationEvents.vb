Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    Partial Friend Class MyApplication

        Public CRW As ConfigRW
        Public DBA As DBAccess
        Public User As User

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            CRW = New ConfigRW
            DBA = New DBAccess(CRW.ServerAddress, CRW.DBInstance, CRW.DBName, CRW.UserDB, CRW.PassDB)
        End Sub
    End Class
End Namespace