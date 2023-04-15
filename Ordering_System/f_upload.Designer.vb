<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class f_upload
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnupload = New System.Windows.Forms.Button()
        Me.tbFileDir = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgrid1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(722, -2)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 41)
        Me.Label6.TabIndex = 10
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
        Me.Label1.Location = New System.Drawing.Point(-1, -2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(762, 75)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "UPLOAD"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.btnupload)
        Me.GroupBox1.Controls.Add(Me.tbFileDir)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(737, 534)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'btnupload
        '
        Me.btnupload.Location = New System.Drawing.Point(556, 45)
        Me.btnupload.Name = "btnupload"
        Me.btnupload.Size = New System.Drawing.Size(132, 32)
        Me.btnupload.TabIndex = 3
        Me.btnupload.Text = "Upload CSV"
        Me.btnupload.UseVisualStyleBackColor = True
        '
        'tbFileDir
        '
        Me.tbFileDir.Location = New System.Drawing.Point(28, 45)
        Me.tbFileDir.Name = "tbFileDir"
        Me.tbFileDir.ReadOnly = True
        Me.tbFileDir.Size = New System.Drawing.Size(522, 29)
        Me.tbFileDir.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgrid1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 112)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(725, 416)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "USERS LIST"
        '
        'dgrid1
        '
        Me.dgrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgrid1.Location = New System.Drawing.Point(3, 25)
        Me.dgrid1.Name = "dgrid1"
        Me.dgrid1.Size = New System.Drawing.Size(719, 388)
        Me.dgrid1.TabIndex = 26
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
        'f_upload
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
        Me.Name = "f_upload"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "f_upload"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents dgrid1 As DataGridView
    Friend WithEvents tbFileDir As TextBox
    Friend WithEvents btnupload As Button
End Class
