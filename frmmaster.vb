Imports System.Data.SqlClient

Public Class frmmaster
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmRegistration.ShowDialog()
    End Sub

    Private Sub frmmaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = Module1.name1
        Label3.Text = DateTime.Now.ToString()
    End Sub

    Private Sub ApprovalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApprovalToolStripMenuItem.Click
        With frmApprovalStudent
            .TopLevel = False
            Panel5.Controls.Add(frmApprovalStudent)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub StudentHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentHistoryToolStripMenuItem.Click
        With frmStudentHistory
            .TopLevel = False
            Panel5.Controls.Add(frmStudentHistory)

            .BringToFront()
            .Show()

        End With



    End Sub

    Private Sub AddExamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddExamToolStripMenuItem.Click
        With frmAddQuestion
            .TopLevel = False

            Panel5.Controls.Add(frmAddQuestion)

            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub ViewEditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewEditToolStripMenuItem.Click
        With frmEditQuestion
            .TopLevel = False

            Panel5.Controls.Add(frmEditQuestion)

            .BringToFront()
            .Show()

        End With


    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        With frmAddEmployee
            .TopLevel = False
            Panel5.Controls.Add(frmAddEmployee)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        With frmEmployeeViewList

            .TopLevel = False
            Panel5.Controls.Add(frmEmployeeViewList)

            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        With frmFeesPayment

            .TopLevel = False
            Panel5.Controls.Add(frmFeesPayment)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub AddImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddImageToolStripMenuItem.Click
        With frmaddstudimg
            .TopLevel = False
            Panel5.Controls.Add(frmaddstudimg)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ViewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem1.Click
        With frmFeesPaymentDatails
            .TopLevel = False
            Panel5.Controls.Add(frmFeesPaymentDatails)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub ADDNEWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDNEWToolStripMenuItem.Click
        With frmAddNewCourse

            .TopLevel = False
            Panel5.Controls.Add(frmAddNewCourse)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ResultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResultToolStripMenuItem.Click

    End Sub

    Private Sub ExamPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExamPasswordToolStripMenuItem.Click
        qry = "select * from tblpassword"
        con.Open()
        cmd = New SqlCommand(qry, con)
        dr = cmd.ExecuteReader()
        If dr.Read Then
            'open form password
            With frmExamPasschange
                .TopLevel = False
                Panel5.Controls.Add(frmExamPasschange)
                .BringToFront()
                .Show()
            End With


        Else

            With frmPassword
                .TopLevel = False
                Panel5.Controls.Add(frmPassword)
                .BringToFront()
                .Show()
            End With

        End If
        If con.State = 1 Then con.Close()
    End Sub
End Class