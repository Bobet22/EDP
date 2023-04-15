Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
        opencon()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        finduser()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.MouseDown
        TextBox2.UseSystemPasswordChar = False
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.BackColor = Color.Black
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseUp
        Button2.BackColor = Color.DodgerBlue
        TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Please enter username or password.", vbExclamation, "Missing Username/Password")
            TextBox2.Clear()
        ElseIf Not TextBox1.Text = Label4.Text Then
            MsgBox("Username is not existed.", vbCritical, "Invalid Action")
        ElseIf Not TextBox2.Text = Label5.Text Then
            MsgBox("Invalid Password.", vbCritical, "Invalid Action")
            TextBox2.Clear()
        ElseIf Label4.Text = TextBox1.Text And Label5.Text = TextBox2.Text Then
            MsgBox("You are now logged on, click OK to  continue.", vbInformation, "Logged On")
            f_dashboard.Button11.Text = "Hi " & Label4.Text & ", How are you? You always welcome here."
            TextBox1.Clear()
            TextBox2.Clear()
            Me.Hide()
            f_dashboard.Show()
        End If
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.Black
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.DodgerBlue
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
