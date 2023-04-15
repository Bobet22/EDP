Public Class f_sales

    Private Sub f_sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lv1_users()
        opencon()
        reload_sales()
    End Sub

    Sub lv1_users()
        ListView1.View = View.Details
        ListView1.GridLines = False
        ListView1.FullRowSelect = True
        ListView1.HeaderStyle = ColumnHeaderStyle.Nonclickable
        ListView1.Columns.Clear()
        ListView1.Columns.Add("#", 0)
        ListView1.Columns.Add("PRODUCT NAME", 200)
        ListView1.Columns.Add("TOTAL SALES", 130)
        ListView1.Columns.Add("TOTAL REVENUE", 130)
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

    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.Black
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.DodgerBlue
    End Sub
End Class