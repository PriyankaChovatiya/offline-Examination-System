<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistration
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.Btnlogin = New System.Windows.Forms.Button()
        Me.cmbcrs = New System.Windows.Forms.ComboBox()
        Me.txtquli = New System.Windows.Forms.TextBox()
        Me.rdbtnfemale = New System.Windows.Forms.RadioButton()
        Me.rdbtnmale = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.txtadd = New System.Windows.Forms.TextBox()
        Me.txtstdtname = New System.Windows.Forms.TextBox()
        Me.txtstudtno = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1273, 135)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(319, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(529, 90)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STUDENT REGISTRATION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnclear)
        Me.GroupBox1.Controls.Add(Me.Btnlogin)
        Me.GroupBox1.Controls.Add(Me.cmbcrs)
        Me.GroupBox1.Controls.Add(Me.txtquli)
        Me.GroupBox1.Controls.Add(Me.rdbtnfemale)
        Me.GroupBox1.Controls.Add(Me.rdbtnmale)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.txtcontact)
        Me.GroupBox1.Controls.Add(Me.txtadd)
        Me.GroupBox1.Controls.Add(Me.txtstdtname)
        Me.GroupBox1.Controls.Add(Me.txtstudtno)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 154)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1249, 543)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registration form"
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(620, 460)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(191, 59)
        Me.btnclear.TabIndex = 11
        Me.btnclear.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.btnclear, "Clear All")
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'Btnlogin
        '
        Me.Btnlogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnlogin.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnlogin.Location = New System.Drawing.Point(398, 460)
        Me.Btnlogin.Name = "Btnlogin"
        Me.Btnlogin.Size = New System.Drawing.Size(191, 59)
        Me.Btnlogin.TabIndex = 10
        Me.Btnlogin.Text = "Register"
        Me.ToolTip1.SetToolTip(Me.Btnlogin, "For Register")
        Me.Btnlogin.UseVisualStyleBackColor = False
        '
        'cmbcrs
        '
        Me.cmbcrs.FormattingEnabled = True
        Me.cmbcrs.Location = New System.Drawing.Point(906, 302)
        Me.cmbcrs.Name = "cmbcrs"
        Me.cmbcrs.Size = New System.Drawing.Size(300, 33)
        Me.cmbcrs.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.cmbcrs, "choose Exam Course")
        '
        'txtquli
        '
        Me.txtquli.Location = New System.Drawing.Point(906, 220)
        Me.txtquli.Name = "txtquli"
        Me.txtquli.Size = New System.Drawing.Size(300, 33)
        Me.txtquli.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.txtquli, "Enter Qualification")
        '
        'rdbtnfemale
        '
        Me.rdbtnfemale.AutoSize = True
        Me.rdbtnfemale.Location = New System.Drawing.Point(1032, 83)
        Me.rdbtnfemale.Name = "rdbtnfemale"
        Me.rdbtnfemale.Size = New System.Drawing.Size(131, 29)
        Me.rdbtnfemale.TabIndex = 6
        Me.rdbtnfemale.TabStop = True
        Me.rdbtnfemale.Text = "FEMALE"
        Me.rdbtnfemale.UseVisualStyleBackColor = True
        '
        'rdbtnmale
        '
        Me.rdbtnmale.AutoSize = True
        Me.rdbtnmale.Location = New System.Drawing.Point(906, 83)
        Me.rdbtnmale.Name = "rdbtnmale"
        Me.rdbtnmale.Size = New System.Drawing.Size(102, 29)
        Me.rdbtnmale.TabIndex = 5
        Me.rdbtnmale.TabStop = True
        Me.rdbtnmale.Text = "MALE"
        Me.rdbtnmale.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(906, 151)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(300, 33)
        Me.DateTimePicker1.TabIndex = 7
        '
        'txtcontact
        '
        Me.txtcontact.Location = New System.Drawing.Point(285, 372)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(323, 33)
        Me.txtcontact.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txtcontact, "Enter contact number")
        '
        'txtadd
        '
        Me.txtadd.Location = New System.Drawing.Point(285, 225)
        Me.txtadd.Multiline = True
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(323, 102)
        Me.txtadd.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtadd, "Enter Address")
        '
        'txtstdtname
        '
        Me.txtstdtname.Location = New System.Drawing.Point(285, 149)
        Me.txtstdtname.Name = "txtstdtname"
        Me.txtstdtname.Size = New System.Drawing.Size(323, 33)
        Me.txtstdtname.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtstdtname, "Enter Student Name")
        '
        'txtstudtno
        '
        Me.txtstudtno.Location = New System.Drawing.Point(285, 77)
        Me.txtstudtno.Name = "txtstudtno"
        Me.txtstudtno.Size = New System.Drawing.Size(323, 33)
        Me.txtstudtno.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtstudtno, "Student Application Number")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(685, 302)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(174, 25)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "EXAM COURSE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(676, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(193, 25)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "QUALIFICATION"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(676, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(183, 25)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "DATE OF BIRTH"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(676, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 25)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "GENDER"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 372)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 25)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "CONTACT NO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "ADDRESS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "STUDENT NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "APPLICATION NO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 25)
        Me.Label2.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(1195, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Close")
        '
        'frmRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1273, 709)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtadd As TextBox
    Friend WithEvents txtstdtname As TextBox
    Friend WithEvents txtstudtno As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbcrs As ComboBox
    Friend WithEvents txtquli As TextBox
    Friend WithEvents rdbtnfemale As RadioButton
    Friend WithEvents rdbtnmale As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtcontact As TextBox
    Friend WithEvents Btnlogin As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
