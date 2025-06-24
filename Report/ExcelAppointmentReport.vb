Imports Microsoft.Office.Interop.Excel

Public Class ExcelAppointmentReport

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

    Sub Generate(AppointmentReport As Data.DataTable)
        Dim XLApp As New Application
        Dim XLWorkBook As Workbook
        Dim Sheet1 As Worksheet

        Try
            XLWorkBook = XLApp.Workbooks.Open(Path & "\Report\AppointmentReport.xltx")
            Sheet1 = XLWorkBook.Sheets("Sheet1")

            Dim i As Integer = 2
            For Each row As DataRow In AppointmentReport.Rows
                Sheet1.Range("A" & i).Value = row.Item("AppointmentCode")
                Sheet1.Range("B" & i).Value = row.Item("PatientName")
                Sheet1.Range("C" & i).Value = row.Item("DoctorName")
                Dim appointmentDate As DateTime = Convert.ToDateTime(row.Item("AppointmentDate"))
                Dim appointmentTime As TimeSpan = CType(row.Item("AppointmentTime"), TimeSpan)
                Dim formattedTime As String = appointmentTime.ToString("hh\:mm\:ss")
                Sheet1.Range("D" & i).Value = appointmentDate.ToString("dd MMMM yyyy")
                Sheet1.Range("E" & i).Value = formattedTime
                Sheet1.Range("F" & i).Value = row.Item("AppointmentDescription")
                Sheet1.Range("G" & i).Value = row.Item("AppointmentStatusStr")

                Sheet1.Range("A" & i & ":G" & i).BorderAround2(ColorIndex:=3, Weight:=XlBorderWeight.xlThick, LineStyle:=XlLineStyle.xlDashDotDot)
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
