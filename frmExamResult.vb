Imports System.Data.SqlClient



Public Class frmExamResult
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()

    End Sub

    Private Sub frmExamResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblRegno.Text = rg
        lblCourse.Text = course
        lblSubject.Text = subject
        If con.State = 1 Then con.Close()

        qry = "select count(*) as aa from tbl_studentanswers  where answer=crc_ans and Ex_regno='" & lblRegno.Text & "'and course='" & lblCourse.Text & "'and subject='" & lblSubject.Text & "' "
        cmd = New SqlCommand(qry, con)
        con.Open()
        dr = cmd.ExecuteReader()
        If dr.Read Then
            lblC.Text = dr.Item("aa").ToString

        End If
        'total Question

        qry = "select count(*) as totq from tbl_studentanswers where course='" & lblCourse.Text & "' and subject='" & lblSubject.Text & "' "
        cmd = New SqlCommand(qry, con)
        If con.State = 1 Then con.Close()

        con.Open()
        dr = cmd.ExecuteReader()
        If dr.Read Then
            lblTotal.Text = dr.Item("totq").ToString
        End If

        lblPercentage.Text = (Val(lblC.Text) * 100) / Val(lblTotal.Text)

        If Val(lblPercentage.Text) < 35 Then

            lblCount.Text = "Fail"
            lblStatus.Text = "Fail"
        ElseIf Val(lblPercentage.Text) < 50 Then
            lblStatus.Text = "Pass By 2nd Division"
        ElseIf Val(lblPercentage.Text) < 90 Then
            lblCount.Text = "Pass By First Division"
            lblStatus.Text = "First division"

        ElseIf Val(lblPercentage.Text) >= 90 Then
            lblCount.Text = "Super performance pass by First Division"
            lblStatus.Text = "Outstanding"


        End If

        qry = "insert into tbl_results(Ex_regno,course,subject,total_qstn,correct_qstn,perc,status)values('" & lblRegno.Text & "','" & lblCourse.Text & "','" & lblSubject.Text & "','" & lblTotal.Text & "','" & lblC.Text & "','" & lblPercentage.Text & "','" & lblStatus.text & "')"
        i = InsertData(qry)
        If i > 0 Then
            MsgBox("This your Report card", MsgBoxStyle.Information)
        Else
        End If

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        lblCourse.Text = ""
        lblC.Text = ""
        lblTotal.Text = ""
        lblStatus.Text = ""
        lblSubject.Text = ""
        lblRegno.Text = ""
        lblPercentage.Text = ""
        frmLogin.Show()
        Me.Close()
    End Sub
End Class