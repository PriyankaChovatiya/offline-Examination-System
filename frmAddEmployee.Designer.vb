<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEmployee
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbfemale = New System.Windows.Forms.RadioButton()
        Me.rdbmale = New System.Windows.Forms.RadioButton()
        Me.dtpdob = New System.Windows.Forms.DateTimePicker()
        Me.dtpdoj = New System.Windows.Forms.DateTimePicker()
        Me.txtdesign = New System.Windows.Forms.TextBox()
        Me.txtcntct = New System.Windows.Forms.TextBox()
        Me.txtaddrs = New System.Windows.Forms.TextBox()
        Me.txtename = New System.Windows.Forms.TextBox()
        Me.txteno = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpswd = New System.Windows.Forms.TextBox()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(870, 66)
        Me.Panel1.TabIndex = 6
        '
        'PictureBox1
        '

        Me.PictureBox1.Location = New System.Drawing.Point(804, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(435, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMPLOYEE DETAILS"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox1.Controls.Add(Me.rdbfemale)
        Me.GroupBox1.Controls.Add(Me.rdbmale)
        Me.GroupBox1.Controls.Add(Me.dtpdob)
        Me.GroupBox1.Controls.Add(Me.dtpdoj)
        Me.GroupBox1.Controls.Add(Me.txtdesign)
        Me.GroupBox1.Controls.Add(Me.txtcntct)
        Me.GroupBox1.Controls.Add(Me.txtaddrs)
        Me.GroupBox1.Controls.Add(Me.txtename)
        Me.GroupBox1.Controls.Add(Me.txteno)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 400)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Details"
        '
        'rdbfemale
        '
        Me.rdbfemale.AutoSize = True
        Me.rdbfemale.Location = New System.Drawing.Point(306, 276)
        Me.rdbfemale.Name = "rdbfemale"
        Me.rdbfemale.Size = New System.Drawing.Size(112, 26)
        Me.rdbfemale.TabIndex = 17
        Me.rdbfemale.TabStop = True
        Me.rdbfemale.Text = "FEMALE"
        Me.rdbfemale.UseVisualStyleBackColor = True
        '
        'rdbmale
        '
        Me.rdbmale.AutoSize = True
        Me.rdbmale.Location = New System.Drawing.Point(193, 276)
        Me.rdbmale.Name = "rdbmale"
        Me.rdbmale.Size = New System.Drawing.Size(87, 26)
        Me.rdbmale.TabIndex = 16
        Me.rdbmale.TabStop = True
        Me.rdbmale.Text = "MALE"
        Me.rdbmale.UseVisualStyleBackColor = True
        '
        'dtpdob
        '
        Me.dtpdob.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdob.Location = New System.Drawing.Point(193, 177)
        Me.dtpdob.Name = "dtpdob"
        Me.dtpdob.Size = New System.Drawing.Size(200, 28)
        Me.dtpdob.TabIndex = 15
        '
        'dtpdoj
        '
        Me.dtpdoj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdoj.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdoj.Location = New System.Drawing.Point(193, 135)
        Me.dtpdoj.Name = "dtpdoj"
        Me.dtpdoj.Size = New System.Drawing.Size(200, 28)
        Me.dtpdoj.TabIndex = 14
        '
        'txtdesign
        '
        Me.txtdesign.Location = New System.Drawing.Point(193, 356)
        Me.txtdesign.Name = "txtdesign"
        Me.txtdesign.Size = New System.Drawing.Size(360, 28)
        Me.txtdesign.TabIndex = 13
        '
        'txtcntct
        '
        Me.txtcntct.Location = New System.Drawing.Point(193, 308)
        Me.txtcntct.Name = "txtcntct"
        Me.txtcntct.Size = New System.Drawing.Size(360, 28)
        Me.txtcntct.TabIndex = 12
        '
        'txtaddrs
        '
        Me.txtaddrs.Location = New System.Drawing.Point(193, 211)
        Me.txtaddrs.Multiline = True
        Me.txtaddrs.Name = "txtaddrs"
        Me.txtaddrs.Size = New System.Drawing.Size(360, 57)
        Me.txtaddrs.TabIndex = 11
        '
        'txtename
        '
        Me.txtename.Location = New System.Drawing.Point(193, 104)
        Me.txtename.Name = "txtename"
        Me.txtename.Size = New System.Drawing.Size(360, 28)
        Me.txtename.TabIndex = 10
        '
        'txteno
        '
        Me.txteno.Location = New System.Drawing.Point(193, 63)
        Me.txteno.Name = "txteno"
        Me.txteno.Size = New System.Drawing.Size(360, 28)
        Me.txteno.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 360)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 22)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "DESIGNATION:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 314)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 22)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "CONTACT NO:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 22)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "GENDER"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 22)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "ADDRESS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 22)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "DATE OF BIRTH"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 22)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "DATE OF JOIN:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 22)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "NAME:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "EMPLOYEE NO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(188, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "EMPLOYEE DETAILS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(604, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(187, 25)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "LOGIN DETAILS"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(655, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 22)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "USER NAME"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(655, 247)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 22)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "PASSWORD"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(609, 193)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(220, 26)
        Me.txtusername.TabIndex = 11
        '
        'txtpswd
        '
        Me.txtpswd.Location = New System.Drawing.Point(609, 283)
        Me.txtpswd.Name = "txtpswd"
        Me.txtpswd.Size = New System.Drawing.Size(220, 26)
        Me.txtpswd.TabIndex = 12
        '
        'btnsubmit
        '
        Me.btnsubmit.BackColor = System.Drawing.Color.Green
        Me.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsubmit.Location = New System.Drawing.Point(658, 340)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(118, 46)
        Me.btnsubmit.TabIndex = 13
        Me.btnsubmit.Text = "SUBMIT"
        Me.btnsubmit.UseVisualStyleBackColor = False
        '
        'btnreset
        '
        Me.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.ForeColor = System.Drawing.Color.Red
        Me.btnreset.Location = New System.Drawing.Point(659, 408)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(118, 46)
        Me.btnreset.TabIndex = 14
        Me.btnreset.Text = "RESET"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'frmAddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 484)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.txtpswd)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAddEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rdbfemale As RadioButton
    Friend WithEvents rdbmale As RadioButton
    Friend WithEvents dtpdob As DateTimePicker
    Friend WithEvents dtpdoj As DateTimePicker
    Friend WithEvents txtdesign As TextBox
    Friend WithEvents txtcntct As TextBox
    Friend WithEvents txtaddrs As TextBox
    Friend WithEvents txtename As TextBox
    Friend WithEvents txteno As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpswd As TextBox
    Friend WithEvents btnsubmit As Button
    Friend WithEvents btnreset As Button
End Class
