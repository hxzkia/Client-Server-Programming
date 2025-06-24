Imports Microsoft.Office.Interop.Excel

Public Class ExcelUserReport

    Dim Path As String

    Sub New()
        Path = My.Application.Info.DirectoryPath
    End Sub

    Public Sub ReleaseObject(obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Sub Generate(UserReport As Data.DataTable)
        Dim XLApp As New Application
        Dim XLWorkBook As Workbook
        Dim Sheet1 As Worksheet

        Try
            XLWorkBook = XLApp.Workbooks.Open(Path & "\Report\UserReport.xltx")
            Sheet1 = XLWorkBook.Sheets("Sheet1")

            Dim i As Integer = 2
            For Each row As DataRow In UserReport.Rows
                Sheet1.Range("A" & i).Value = row.Item("UserName")
                Sheet1.Range("B" & i).Value = row.Item("UName")
                Sheet1.Range("C" & i).Value = row.Item("UserRoleStr")
                Sheet1.Range("D" & i).Value = row.Item("UserStatusStr")

                Sheet1.Range("A" & i & ":D" & i).BorderAround2(ColorIndex:=3, Weight:=XlBorderWeight.xlThick, LineStyle:=XlLineStyle.xlDashDotDot)
                i = i + 1
            Next
            XLApp.WindowState = XlWindowState.xlMaximized
            XLApp.Visible = True

            ReleaseObject(Sheet1)
            ReleaseObject(XLWorkBook)
            ReleaseObject(XLApp)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
