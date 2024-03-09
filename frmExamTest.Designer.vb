<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExamTest
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblsubject = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblcoursename = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblstdname = New System.Windows.Forms.Label()
        Me.lblrollno = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtqstn = New System.Windows.Forms.TextBox()
        Me.lblqstn = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rdboD = New System.Windows.Forms.RadioButton()
        Me.rdboC = New System.Windows.Forms.RadioButton()
        Me.rdboB = New System.Windows.Forms.RadioButton()
        Me.rdboA = New System.Windows.Forms.RadioButton()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnpreview = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblAns = New System.Windows.Forms.Label()
        Me.lbltime1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(388, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Start Your Exam Here"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1168, 66)
        Me.Panel1.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(1102, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(295, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(499, 45)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Offline Examination System"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox1.Controls.Add(Me.lblsubject)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblcoursename)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblstdname)
        Me.GroupBox1.Controls.Add(Me.lblrollno)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1144, 127)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Info"
        '
        'lblsubject
        '
        Me.lblsubject.AutoSize = True
        Me.lblsubject.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubject.ForeColor = System.Drawing.Color.White
        Me.lblsubject.Location = New System.Drawing.Point(895, 81)
        Me.lblsubject.Name = "lblsubject"
        Me.lblsubject.Size = New System.Drawing.Size(82, 25)
        Me.lblsubject.TabIndex = 9
        Me.lblsubject.Text = "Subject"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Firebrick
        Me.Label10.Location = New System.Drawing.Point(715, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 25)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Subject"
        '
        'lblcoursename
        '
        Me.lblcoursename.AutoSize = True
        Me.lblcoursename.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcoursename.ForeColor = System.Drawing.Color.White
        Me.lblcoursename.Location = New System.Drawing.Point(895, 38)
        Me.lblcoursename.Name = "lblcoursename"
        Me.lblcoursename.Size = New System.Drawing.Size(67, 25)
        Me.lblcoursename.TabIndex = 7
        Me.lblcoursename.Text = "Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Firebrick
        Me.Label8.Location = New System.Drawing.Point(715, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 25)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Course"
        '
        'lblstdname
        '
        Me.lblstdname.AutoSize = True
        Me.lblstdname.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstdname.ForeColor = System.Drawing.Color.White
        Me.lblstdname.Location = New System.Drawing.Point(215, 81)
        Me.lblstdname.Name = "lblstdname"
        Me.lblstdname.Size = New System.Drawing.Size(145, 25)
        Me.lblstdname.TabIndex = 5
        Me.lblstdname.Text = "Student Name"
        '
        'lblrollno
        '
        Me.lblrollno.AutoSize = True
        Me.lblrollno.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrollno.ForeColor = System.Drawing.Color.White
        Me.lblrollno.Location = New System.Drawing.Point(215, 38)
        Me.lblrollno.Name = "lblrollno"
        Me.lblrollno.Size = New System.Drawing.Size(161, 25)
        Me.lblrollno.TabIndex = 4
        Me.lblrollno.Text = "Student Roll No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Firebrick
        Me.Label3.Location = New System.Drawing.Point(35, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Student Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Firebrick
        Me.Label2.Location = New System.Drawing.Point(35, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Student Roll No"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox2.Controls.Add(Me.txtqstn)
        Me.GroupBox2.Controls.Add(Me.lblqstn)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 266)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1144, 122)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Question"
        '
        'txtqstn
        '
        Me.txtqstn.Location = New System.Drawing.Point(113, 23)
        Me.txtqstn.Multiline = True
        Me.txtqstn.Name = "txtqstn"
        Me.txtqstn.ReadOnly = True
        Me.txtqstn.Size = New System.Drawing.Size(1016, 81)
        Me.txtqstn.TabIndex = 8
        '
        'lblqstn
        '
        Me.lblqstn.AutoSize = True
        Me.lblqstn.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqstn.ForeColor = System.Drawing.Color.Firebrick
        Me.lblqstn.Location = New System.Drawing.Point(49, 39)
        Me.lblqstn.Name = "lblqstn"
        Me.lblqstn.Size = New System.Drawing.Size(23, 25)
        Me.lblqstn.TabIndex = 7
        Me.lblqstn.Text = "1"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Firebrick
        Me.Label12.Location = New System.Drawing.Point(17, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 25)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Q."
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.rdboD)
        Me.Panel2.Controls.Add(Me.rdboC)
        Me.Panel2.Controls.Add(Me.rdboB)
        Me.Panel2.Controls.Add(Me.rdboA)
        Me.Panel2.Location = New System.Drawing.Point(12, 394)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1144, 203)
        Me.Panel2.TabIndex = 13
        '
        'rdboD
        '
        Me.rdboD.AutoSize = True
        Me.rdboD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdboD.Location = New System.Drawing.Point(113, 154)
        Me.rdboD.Name = "rdboD"
        Me.rdboD.Size = New System.Drawing.Size(154, 29)
        Me.rdboD.TabIndex = 3
        Me.rdboD.TabStop = True
        Me.rdboD.Text = "RadioButton4"
        Me.rdboD.UseVisualStyleBackColor = True
        '
        'rdboC
        '
        Me.rdboC.AutoSize = True
        Me.rdboC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdboC.Location = New System.Drawing.Point(113, 109)
        Me.rdboC.Name = "rdboC"
        Me.rdboC.Size = New System.Drawing.Size(154, 29)
        Me.rdboC.TabIndex = 2
        Me.rdboC.TabStop = True
        Me.rdboC.Text = "RadioButton3"
        Me.rdboC.UseVisualStyleBackColor = True
        '
        'rdboB
        '
        Me.rdboB.AutoSize = True
        Me.rdboB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdboB.Location = New System.Drawing.Point(113, 67)
        Me.rdboB.Name = "rdboB"
        Me.rdboB.Size = New System.Drawing.Size(154, 29)
        Me.rdboB.TabIndex = 1
        Me.rdboB.TabStop = True
        Me.rdboB.Text = "RadioButton2"
        Me.rdboB.UseVisualStyleBackColor = True
        '
        'rdboA
        '
        Me.rdboA.AutoSize = True
        Me.rdboA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdboA.Location = New System.Drawing.Point(113, 22)
        Me.rdboA.Name = "rdboA"
        Me.rdboA.Size = New System.Drawing.Size(154, 29)
        Me.rdboA.TabIndex = 0
        Me.rdboA.TabStop = True
        Me.rdboA.Text = "RadioButton1"
        Me.rdboA.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(434, 620)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(185, 48)
        Me.btnNext.TabIndex = 14
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnpreview
        '
        Me.btnpreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnpreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpreview.Location = New System.Drawing.Point(232, 620)
        Me.btnpreview.Name = "btnpreview"
        Me.btnpreview.Size = New System.Drawing.Size(185, 48)
        Me.btnpreview.TabIndex = 15
        Me.btnpreview.Text = "PREVIEW"
        Me.btnpreview.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(639, 620)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(185, 48)
        Me.btnSubmit.TabIndex = 15
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblAns
        '
        Me.lblAns.AutoSize = True
        Me.lblAns.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAns.ForeColor = System.Drawing.Color.Black
        Me.lblAns.Location = New System.Drawing.Point(964, 600)
        Me.lblAns.Name = "lblAns"
        Me.lblAns.Size = New System.Drawing.Size(83, 25)
        Me.lblAns.TabIndex = 16
        Me.lblAns.Text = "Answer"
        Me.lblAns.Visible = False
        '
        'lbltime1
        '
        Me.lbltime1.AutoSize = True
        Me.lbltime1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime1.ForeColor = System.Drawing.Color.Black
        Me.lbltime1.Location = New System.Drawing.Point(879, 82)
        Me.lbltime1.Name = "lbltime1"
        Me.lbltime1.Size = New System.Drawing.Size(61, 25)
        Me.lbltime1.TabIndex = 17
        Me.lbltime1.Text = "Time"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(70, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "(A)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(70, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "(B)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(70, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 22)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "(C)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(70, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 22)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "(D)"
        '
        'frmExamTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 689)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbltime1)
        Me.Controls.Add(Me.lblAns)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnpreview)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmExamTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblsubject As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblcoursename As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblstdname As Label
    Friend WithEvents lblrollno As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblqstn As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtqstn As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rdboD As RadioButton
    Friend WithEvents rdboC As RadioButton
    Friend WithEvents rdboB As RadioButton
    Friend WithEvents rdboA As RadioButton
    Friend WithEvents btnNext As Button
    Friend WithEvents btnpreview As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblAns As Label
    Friend WithEvents lbltime1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
