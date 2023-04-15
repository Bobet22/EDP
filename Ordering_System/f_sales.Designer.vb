<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_sales
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(737, 534)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.ListView1)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 112)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(725, 416)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SALES LIST"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 392)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 21)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "ALL USERS: 0"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(550, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 39)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "PRINT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button9.FlatAppearance.BorderSize = 2
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(375, 28)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(169, 39)
        Me.Button9.TabIndex = 23
        Me.Button9.Text = "UPDATE"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(7, 73)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(712, 316)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(725, 78)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SEARCH"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(550, 38)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(169, 29)
        Me.DateTimePicker1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(537, 29)
        Me.TextBox1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(722, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 41)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "x"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-1, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(762, 75)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "SALES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'f_sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(761, 622)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Yu Gothic UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "f_sales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "f_sales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
