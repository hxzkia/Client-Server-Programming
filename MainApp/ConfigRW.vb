Imports System.IO

Public Class ConfigRW

    Private _ServerAddress As String
    Private _DBInstance As String
    Private _DBName As String
    Private _UserDB As String
    Private _PassDB As String

    Public Sub New()
        _ServerAddress = ""
        _DBInstance = ""
        _DBName = ""
        _UserDB = ""
        _PassDB = ""
        ReadConfig()
    End Sub

    Sub ReadConfig()
        Try
            If File.Exists(My.Application.Info.DirectoryPath & "\AppConfig.txt") Then
                Dim TempLine As String = ""
                Dim ConfigName As String = ""
                Dim ConfigValue As String = ""
                Using sr As New StreamReader(My.Application.Info.DirectoryPath & "\AppConfig.txt")
                    Do While sr.Peek >= 0
                        TempLine = sr.ReadLine
                        ConfigName = Trim(TempLine.Substring(0, TempLine.LastIndexOf("=") - 1))
                        ConfigValue = Trim(TempLine.Substring(TempLine.LastIndexOf("=") + 1, TempLine.Length - (TempLine.LastIndexOf("=") + 1)))
                        If ConfigName = "ServerAddress" Then
                            Me._ServerAddress = ConfigValue
                        ElseIf ConfigName = "DBInstance" Then
                            Me._DBInstance = ConfigValue
                        ElseIf ConfigName = "DBName" Then
                            Me._DBName = ConfigValue
                        ElseIf ConfigName = "UserDB" Then
                            Me._UserDB = ConfigValue
                        ElseIf ConfigName = "PassDB" Then
                            Me._PassDB = ConfigValue
                        End If
                    Loop
                    sr.Close()
                End Using
            Else
                Me._ServerAddress = "Failed"
            End If
        Catch ex As Exception
            MsgBox("Read Config Error : " & ex.Message)
        End Try
    End Sub

    Sub WriteConfig(ByVal ServerAddress As String, ByVal DBInstance As String, ByVal DBName As String, ByVal DBUser As String, ByVal DBPass As String)
        Try
            Dim Path As String = My.Application.Info.DirectoryPath & "\AppConfig.txt"
            If File.Exists(Path) Then
                File.Delete(Path)
                Dim sw As New StreamWriter(Path)
                sw.WriteLine("ServerAddress = " & ServerAddress)
                sw.WriteLine("DBInstance = " & DBInstance)
                sw.WriteLine("DBName = " & DBName)
                sw.WriteLine("UserDB = " & DBUser)
                sw.WriteLine("PassDB = " & DBPass)
                sw.Close()
            Else
                Dim sw As New StreamWriter(Path)
                sw.WriteLine("ServerAddress = " & ServerAddress)
                sw.WriteLine("DBInstance = " & DBInstance)
                sw.WriteLine("DBName = " & DBName)
                sw.WriteLine("UserDB = " & DBUser)
                sw.WriteLine("PassDB = " & DBPass)
                sw.Close()
            End If
        Catch ex As Exception
            MsgBox("Write Config Error : " & ex.Message)
        End Try
    End Sub

    Public Property PassDB() As String
        Get
            Return _PassDB
        End Get
        Set(ByVal value As String)
            _PassDB = value
        End Set
    End Property

    Public Property UserDB() As String
        Get
            Return _UserDB
        End Get
        Set(ByVal value As String)
            _UserDB = value
        End Set
    End Property

    Public Property DBName() As String
        Get
            Return _DBName
        End Get
        Set(ByVal value As String)
            _DBName = value
        End Set
    End Property

    Public Property DBInstance() As String
        Get
            Return _DBInstance
        End Get
        Set(ByVal value As String)
            _DBInstance = value
        End Set
    End Property

    Public ReadOnly Property ServerAddress() As String
        Get
            Return _ServerAddress
        End Get
    End Property
End Class