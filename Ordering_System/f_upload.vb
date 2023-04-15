Imports System.IO

Public Class f_upload



    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        f_dashboard.GroupBox1.Visible = False
        For Each ChildForm As Form In Form1.MdiChildren
            ChildForm.Close()
        Next
        Me.Close()
        f_dashboard.GroupBox1.Visible = True
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

    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.Black
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.DodgerBlue
    End Sub

    Private Sub dgrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrid1.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbFileDir.TextChanged

    End Sub

    Private Sub btnupload_Click(sender As Object, e As EventArgs) Handles btnupload.Click
        ' Display OpenFileDialog to allow user to select a CSV file
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "CSV files |*.csv"
        openFileDialog.RestoreDirectory = True
        openFileDialog.Title = "Select a CSV file"

        If openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim file As String = openFileDialog.FileName
            tbFileDir.Text = file
            Dim table As New DataTable()

            Try
                Using sr As New StreamReader(file)
                    Dim headers As String() = sr.ReadLine().Split(","c)
                    For Each header As String In headers
                        table.Columns.Add(header)
                    Next
                    While Not sr.EndOfStream
                        Dim rows As String() = sr.ReadLine().Split(","c)
                        Dim row As DataRow = table.NewRow()
                        For i As Integer = 0 To headers.Length - 1
                            row(i) = rows(i)
                        Next
                        table.Rows.Add(row)
                    End While
                End Using
                dgrid1.DataSource = table
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class