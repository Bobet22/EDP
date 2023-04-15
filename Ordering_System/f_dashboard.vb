Imports CsvHelper
Imports System.IO
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Utilities

Public Class f_dashboard
    Public Sub f_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsMdiContainer = True
        opencon()
        reload_user()
        reload_sales()
        reload_products()
        reload_report()
        reload_items()
        reload_orders()
        reload_customer_orders()
        reload_customers()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Label11_MouseEnter(sender As Object, e As EventArgs) Handles Label11.MouseEnter
        Label11.BackColor = Color.Black
    End Sub

    Private Sub Label11_MouseLeave(sender As Object, e As EventArgs) Handles Label11.MouseLeave
        Label11.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label10_MouseEnter(sender As Object, e As EventArgs) Handles Label10.MouseEnter
        Label10.BackColor = Color.Black
    End Sub

    Private Sub Label10_MouseLeave(sender As Object, e As EventArgs) Handles Label10.MouseLeave
        Label10.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label9_MouseEnter(sender As Object, e As EventArgs) Handles Label9.MouseEnter
        Label9.BackColor = Color.Black
    End Sub

    Private Sub Label9_MouseLeave(sender As Object, e As EventArgs) Handles Label9.MouseLeave
        Label9.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label8_MouseEnter(sender As Object, e As EventArgs) Handles Label8.MouseEnter
        Label8.BackColor = Color.Black
    End Sub

    Private Sub Label8_MouseLeave(sender As Object, e As EventArgs) Handles Label8.MouseLeave
        Label8.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label7_MouseEnter(sender As Object, e As EventArgs) Handles Label7.MouseEnter
        Label7.BackColor = Color.Black
    End Sub

    Private Sub Label7_MouseLeave(sender As Object, e As EventArgs) Handles Label7.MouseLeave
        Label7.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label5_MouseEnter(sender As Object, e As EventArgs) Handles Label5.MouseEnter
        Label5.BackColor = Color.Black
    End Sub

    Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) Handles Label5.MouseLeave
        Label5.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        Label4.BackColor = Color.Black
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        Label3.BackColor = Color.Black
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Label3.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button11_MouseEnter(sender As Object, e As EventArgs) Handles Button11.MouseEnter
        Button11.BackColor = Color.Black
    End Sub

    Private Sub Button11_MouseLeave(sender As Object, e As EventArgs) Handles Button11.MouseLeave
        Button11.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        End
    End Sub

    Private Sub Label6_MouseEnter(sender As Object, e As EventArgs) Handles Label6.MouseEnter
        Label6.BackColor = Color.Black
    End Sub

    Private Sub Label6_MouseLeave(sender As Object, e As EventArgs) Handles Label6.MouseLeave
        Label6.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox1.Visible = True
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GroupBox1.Visible = False
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        f_customers.MdiParent = Me
        f_customers.Show()
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.Black
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.BackColor = Color.Black
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GroupBox1.Visible = False
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        f_customerorders.MdiParent = Me
        f_customerorders.Show()
    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Button3.BackColor = Color.Black
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        GroupBox1.Visible = False
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        f_users.MdiParent = Me
        f_users.Show()
    End Sub

    Private Sub Button9_MouseEnter(sender As Object, e As EventArgs) Handles Button9.MouseEnter
        Button9.BackColor = Color.Black
    End Sub

    Private Sub Button9_MouseLeave(sender As Object, e As EventArgs) Handles Button9.MouseLeave
        Button9.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        GroupBox1.Visible = False
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        f_sales.MdiParent = Me
        f_sales.Show()
    End Sub

    Private Sub Button8_MouseEnter(sender As Object, e As EventArgs) Handles Button8.MouseEnter
        Button8.BackColor = Color.Black
    End Sub

    Private Sub Button8_MouseLeave(sender As Object, e As EventArgs) Handles Button8.MouseLeave
        Button8.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        GroupBox1.Visible = False
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        f_products.MdiParent = Me
        f_products.Show()
    End Sub

    Private Sub Button7_MouseEnter(sender As Object, e As EventArgs) Handles Button7.MouseEnter
        Button7.BackColor = Color.Black
    End Sub

    Private Sub Button7_MouseLeave(sender As Object, e As EventArgs) Handles Button7.MouseLeave
        Button7.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        GroupBox1.Visible = False
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        f_report.MdiParent = Me
        f_report.Show()
    End Sub

    Private Sub Button6_MouseEnter(sender As Object, e As EventArgs) Handles Button6.MouseEnter
        Button6.BackColor = Color.Black
    End Sub

    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs) Handles Button6.MouseLeave
        Button6.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GroupBox1.Visible = False
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        f_items.MdiParent = Me
        f_items.Show()
    End Sub

    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs) Handles Button5.MouseEnter
        Button5.BackColor = Color.Black
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Button5.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GroupBox1.Visible = False
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        f_orders.MdiParent = Me
        f_orders.Show()
    End Sub

    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        Button4.BackColor = Color.Black
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Button4.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Button10_MouseEnter(sender As Object, e As EventArgs) Handles Button10.MouseEnter
        Button10.BackColor = Color.Black
    End Sub

    Private Sub Button10_MouseLeave(sender As Object, e As EventArgs) Handles Button10.MouseLeave
        Button10.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btnbackup_MouseEnter(sender As Object, e As EventArgs) Handles btnbackup.MouseEnter
        btnbackup.BackColor = Color.Black
    End Sub

    Private Sub btnbackup_MouseLeave(sender As Object, e As EventArgs) Handles btnbackup.MouseLeave
        btnbackup.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btnbackup_Click(sender As Object, e As EventArgs) Handles btnbackup.Click
        Dim Backup As New SaveFileDialog
        Backup.InitialDirectory = "C:\Users\LENOVO\Downloads\Ordering_System"
        Backup.Title = "Database Backup"
        Backup.CheckFileExists = False
        Backup.CheckPathExists = False
        Backup.DefaultExt = "sql"
        Backup.FileName = "backup"
        Backup.Filter = "SQL files (*.sql)| *.sql"
        Backup.RestoreDirectory = True

        If Backup.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = con
            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            mb.ExportToFile(Backup.FileName)
            MessageBox.Show("Database backup sucessfully at " & Backup.FileName)
        End If
    End Sub
    Private Sub btnupload_MouseEnter(sender As Object, e As EventArgs) Handles btnupload.MouseEnter
        btnupload.BackColor = Color.Black
    End Sub

    Private Sub btnupload_MouseLeave(sender As Object, e As EventArgs) Handles btnupload.MouseLeave
        btnupload.BackColor = Color.DodgerBlue
    End Sub
    Private Sub btnupload_Click(sender As Object, e As EventArgs) Handles btnupload.Click
        f_upload.Show()
    End Sub

End Class