Imports System.Security.Cryptography
Imports System.Text

Public Class Security

    Public Function GetHash(ByVal PlainText As String) As String
        Try
            Dim encoder As Encoder = Encoding.Unicode.GetEncoder()
            Dim PlainByte() As Byte = New Byte(PlainText.Length * 2) {}
            encoder.GetBytes(PlainText.ToCharArray(), 0, PlainText.Length, PlainByte, 0, True)
            Dim SHA256 As New SHA256Managed
            Dim CipherText As Byte() = SHA256.ComputeHash(PlainByte)

            Dim SB As New StringBuilder
            For i As Integer = 0 To CipherText.Length - 1
                SB.Append(CipherText(i).ToString("X2"))
            Next
            Return SB.ToString
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
