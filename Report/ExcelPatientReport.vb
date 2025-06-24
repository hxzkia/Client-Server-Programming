Imports Microsoft.Office.Interop.Excel
Imports System.IO

Public Class ExcelPatientReport

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

    Sub Generate(PatientReport As Data.DataTable)
        Dim XLApp As New Application
        Dim XLWorkBook As Workbook
        Dim Sheet1 As Worksheet

        Try
            XLWorkBook = XLApp.Workbooks.Open(Path & "\Report\PatientReport.xltx")
            Sheet1 = XLWorkBook.Sheets("Sheet1")

            Dim i As Integer = 2
            For Each row As DataRow In PatientReport.Rows
                Sheet1.Range("A" & i).Value = row.Item("PatientName")
                Sheet1.Range("B" & i).Value = row.Item("PatientEmail")
                Sheet1.Range("C" & i).Value = row.Item("PatientPhone")

                Sheet1.Range("A" & i & ":C" & i).BorderAround2(ColorIndex:=3, Weight:=XlBorderWeight.xlThick, LineStyle:=XlLineStyle.xlDashDotDot)
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
