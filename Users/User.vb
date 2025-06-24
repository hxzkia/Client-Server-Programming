Public Class User

    Private _UserId As Integer
    Private _UserName As String
    Private _UserRole As String
    Private _UserRoleStr As String
    Private _Uname As String
    Private _Upass As String
    Private _UserStatus As Integer
    Private _UserStatusStr As String

    Sub New()

    End Sub

    Sub New(UserId As Integer, UserName As String, Role As String)
        Me.UserId = UserId
        Me.UserName = UserName
        UserRole = Role
    End Sub

    Public ReadOnly Property UserStatusStr() As String
        Get
            If UserStatus = 0 Then
                Return "Not Active"
            Else
                Return "Active"
            End If
        End Get
    End Property

    Public Property UserStatus() As Integer
        Get
            Return _UserStatus
        End Get
        Set(ByVal value As Integer)
            _UserStatus = value
        End Set
    End Property

    Public Property Upass() As String
        Get
            Return _Upass
        End Get
        Set(ByVal value As String)
            _Upass = value
        End Set
    End Property

    Public Property Uname() As String
        Get
            Return _Uname
        End Get
        Set(ByVal value As String)
            _Uname = value
        End Set
    End Property

    Public ReadOnly Property UserRoleStr() As String
        Get
            If UserRole = 0 Then
                Return "Receptionist"
            ElseIf UserRole = 1 Then
                Return "Admin"
            ElseIf UserRole = 2 Then
                Return "Super Admin"
            Else
                Return ""
            End If
        End Get
    End Property

    Public Property UserId() As Integer
        Get
            Return _UserId
        End Get
        Set(ByVal value As Integer)
            _UserId = value
        End Set
    End Property

    Public Property UserName() As String
        Get
            Return _UserName
        End Get
        Set(ByVal value As String)
            _UserName = value
        End Set
    End Property

    Public Property UserRole() As String
        Get
            Return _UserRole
        End Get
        Set(ByVal value As String)
            _UserRole = value
        End Set
    End Property
End Class