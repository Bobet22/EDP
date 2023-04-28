Public Class f_report

    Private Sub f_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lv1_users()
        opencon()
        reload_report()
    End Sub

    Sub lv1_users()
        ListView1.View = View.Details
        ListView1.GridLines = False
        ListView1.FullRowSelect = True
        ListView1.HeaderStyle = ColumnHeaderStyle.Nonclickable
        ListView1.Columns.Clear()
        ListView1.Columns.Add("#", 0)
        ListView1.Columns.Add("PRODUCT ID", 100)
        ListView1.Columns.Add("PRODUCT NAME", 150)
        ListView1.Columns.Add("QUANTITY", 100)
        ListView1.Columns.Add("PRICE", 100)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        f_dashboard.GroupBox1.Visible = True
        For Each ChildForm As Form In Form1.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub Label6_MouseEnter(sender As Object, e As EventArgs) Handles Label6.MouseEnter
        Label6.BackColor = Color.Black
    End Sub

    Private Sub Label6_MouseLeave(sender As Object, e As EventArgs) Handles Label6.MouseLeave
        Label6.BackColor = Color.DodgerBlue
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub

    Private Sub Button9_MouseEnter(sender As Object, e As EventArgs) Handles Button9.MouseEnter
        Button9.BackColor = Color.Black
    End Sub

    Private Sub Button9_MouseLeave(sender As Object, e As EventArgs) Handles Button9.MouseLeave
        Button9.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim xlApp As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer
            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")
            xlWorkSheet.Columns.AutoFit()
            For i = 0 To ListView1.Items.Count - 1
                For j = 1 To ListView1.Columns.Count - 1
                    For k As Integer = 2 To ListView1.Columns.Count
                        xlWorkSheet.Cells(1, k) = ListView1.Columns(k - 1).Text
                        xlWorkSheet.Cells(i + 2, j + 1) = ListView1.Items(i).SubItems(j).Text
                    Next
                Next
            Next
            Dim fName As String = "Data Export"
            Using sfd As New SaveFileDialog
                sfd.Title = "Save As"
                sfd.OverwritePrompt = True
                sfd.FileName = fName
                sfd.DefaultExt = ".xlsx"
                sfd.Filter = "Excel Workbook(*.xlsx)|"
                sfd.AddExtension = True
                If sfd.ShowDialog() = DialogResult.OK Then
                    xlWorkSheet.SaveAs(sfd.FileName)
                    xlWorkBook.Close()
                    xlApp.Quit()
                    releaseObject(xlApp)
                    releaseObject(xlWorkBook)
                    releaseObject(xlWorkSheet)
                    MsgBox("Your data has been exported!")
                End If
            End Using
        Catch ex As Exception
            con.Close()
            MsgBox("Error! " & vbCrLf & "Error Code: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.Black
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class