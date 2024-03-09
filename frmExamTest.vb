Imports System.Data
Imports System.Data.SqlClient

Public Class frmExamTest
    Dim d, diff As TimeSpan
    Dim d2 As DateTime

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If con.State = 1 Then con.Close()
        If (rdboA.Checked = False And rdboB.Checked = False And rdboC.Checked = False And rdboD.Checked = False) Then
            MsgBox("plz give the answer.....select any option", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            qnum = qnum + 1
            qry = "select max(q_no)as q_no from tbl_Question with (nolock) where course='" & lblcoursename.Text & "'and subject='" & subject & "'"
            cmd = New SqlCommand(qry, con)
            con.Open()
            Dim dr1 As SqlDataReader = cmd.ExecuteReader()
            If dr1.Read Then
                If qnum <= dr1.Item("q_no").ToString Then
                    lblqstn.Text = qnum
                Else
                    btnNext.Enabled = False
                    MsgBox("this is last question", MsgBoxStyle.Exclamation)
                End If
            End If



        End If
        If con.State = 1 Then con.Close()
    End Sub

    Private Sub lblqstn_TextChanged(sender As Object, e As EventArgs) Handles lblqstn.TextChanged
        If lblqstn.Text <> "" Then

            qry = "select q_no,question,op_A,op_B,op_C,op_D,answer from tbl_Question where course='" & lblcoursename.Text & "'and subject='" & lblsubject.Text & "' and q_no= '" & lblqstn.Text & "'"
            If con.State = 1 Then con.Close()
            cmd = New SqlCommand(qry, con)
            con.Open()
            Dim dr1 As SqlDataReader = cmd.ExecuteReader()
            If dr1.Read Then
                txtqstn.Text = dr1.Item("question").ToString
                rdboA.Text = dr1.Item("op_A").ToString
                rdboB.Text = dr1.Item("op_B").ToString
                rdboC.Text = dr1.Item("op_C").ToString
                rdboD.Text = dr1.Item("op_D").ToString
                lblAns.Text = dr1.Item("answer").ToString

                qnum = lblqstn.Text
                rdboA.Checked = False
                rdboB.Checked = False
                rdboC.Checked = False
                rdboD.Checked = False


            End If
            qry = "select answer from tbl_studentanswers  where Ex_regno='" & rg & "'and course='" & lblcoursename.Text & "'and subject='" & lblsubject.Text & "'and q_no='" & lblqstn.Text & "'"
            If con.State = 1 Then con.Close()
            cmd = New SqlCommand(qry, con)
            con.Open()
            dr1 = cmd.ExecuteReader()
            If dr1.Read Then
                If dr1.Item("answer").ToString = "A" Then
                    rdboA.Checked = True
                ElseIf dr1.Item("answer").ToString = "B" Then
                    rdboB.Checked = True
                ElseIf dr1.Item("answer").ToString = "C" Then
                    rdboC.Checked = True
                ElseIf dr1.Item("answer").ToString = "D" Then
                    rdboD.Checked = True

                End If
            End If
            If qnum <> 0 Then
                qry = "select max(q_no) as q_no from tbl_Question where course='" & lblcoursename.Text & "'and subject='" & lblsubject.Text & "'"
                If con.State = 1 Then con.Close()
                cmd = New SqlCommand(qry, con)
                con.Open()
                dr1 = cmd.ExecuteReader()
                If dr1.Read Then
                    If IsDBNull(Convert.ToInt32(dr1.Item("q_no").ToString)) = False Then
                        If qnum <= dr1.Item("q_no").ToString Then
                            btnNext.Enabled = True
                        Else
                            btnNext.Enabled = False
                            btnpreview.Enabled = True

                        End If
                    End If
                End If

                qry = "select min(q_no)as q_no from tbl_Question where course='" & lblcoursename.Text & "'and subject='" & lblsubject.Text & "'"
                If con.State = 1 Then con.Close()
                cmd = New SqlCommand(qry, con)
                con.Open()
                dr1 = cmd.ExecuteReader()
                If dr1.Read Then
                    If IsDBNull(Convert.ToInt32(dr1.Item("q_no").ToString)) = False Then
                        If qnum <= dr1.Item("q_no").ToString Then
                            btnpreview.Enabled = False
                        Else
                            btnpreview.Enabled = True
                        End If

                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnpreview_Click(sender As Object, e As EventArgs) Handles btnpreview.Click
        qnum = lblqstn.Text
        qnum = qnum - 1
        If qnum >= 1 Then
            lblqstn.Text = qnum
        Else
            btnpreview.Enabled = False
        End If
    End Sub

    Private Sub rdboA_CheckedChanged(sender As Object, e As EventArgs) Handles rdboA.CheckedChanged
        If rdboA.Checked = True Then
            answer()
            'delete duplicate
            qry = "delete from tbl_studentanswers where Ex_regno='" & rg & "'and course='" & lblcoursename.Text & "'and subject='" & lblsubject.Text & "'and q_no='" & lblqstn.Text & "'"
            InsertData(qry)
            'insert
            qry = "insert into tbl_studentanswers(Ex_regno,course,subject,q_no,answer,crc_ans)values('" & rg & "','" & lblcoursename.Text & "','" & lblsubject.Text & "','" & lblqstn.Text & "','" & ans & "','" & lblAns.Text & "')"
            InsertData(qry)
        End If
    End Sub
    Public Sub answer()
        If rdboA.Checked = True Then
            ans = "A"
        ElseIf rdboB.Checked = True Then
            ans = "B"
        ElseIf rdboC.Checked = True Then
            ans = "C"
        ElseIf rdboD.Checked = True Then
            ans = "D"
        Else
            MsgBox("Please Answer to Question", MsgBoxStyle.Exclamation)

        End If
    End Sub

    Private Sub rdboB_CheckedChanged(sender As Object, e As EventArgs) Handles rdboB.CheckedChanged
        If rdboB.Checked = True Then
            answer()
            'delete duplicate
            qry = "delete from tbl_studentanswers where Ex_regno='" & rg & "'and course='" & lblcoursename.Text & "'and subject='" & lblsubject.Text & "'and q_no='" & lblqstn.Text & "'"
            InsertData(qry)
            'insert
            qry = "insert into tbl_studentanswers(Ex_regno,course,subject,q_no,answer,crc_ans)values('" & rg & "','" & lblcoursename.Text & "','" & lblsubject.Text & "','" & lblqstn.Text & "','" & ans & "','" & lblAns.Text & "')"
            InsertData(qry)
        End If
    End Sub

    Private Sub rdboC_CheckedChanged(sender As Object, e As EventArgs) Handles rdboC.CheckedChanged
        If rdboC.Checked = True Then
            answer()
            'delete duplicate
            qry = "delete from tbl_studentanswers where Ex_regno='" & rg & "'and course='" & lblcoursename.Text & "'and subject='" & lblsubject.Text & "'and q_no='" & lblqstn.Text & "'"
            InsertData(qry)
            'insert
            qry = "insert into tbl_studentanswers(Ex_regno,course,subject,q_no,answer,crc_ans)values('" & rg & "','" & lblcoursename.Text & "','" & lblsubject.Text & "','" & lblqstn.Text & "','" & ans & "','" & lblAns.Text & "')"
            InsertData(qry)
        End If
    End Sub

    Private Sub rdboD_CheckedChanged(sender As Object, e As EventArgs) Handles rdboD.CheckedChanged
        If rdboD.Checked = True Then
            answer()
            'delete duplicate
            qry = "delete from tbl_studentanswers where Ex_regno='" & rg & "'and course='" & lblcoursename.Text & "'and subject='" & lblsubject.Text & "'and q_no='" & lblqstn.Text & "'"
            InsertData(qry)
            'insert
            qry = "insert into tbl_studentanswers(Ex_regno,course,subject,q_no,answer,crc_ans)values('" & rg & "','" & lblcoursename.Text & "','" & lblsubject.Text & "','" & lblqstn.Text & "','" & ans & "','" & lblAns.Text & "')"
            InsertData(qry)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltime1.Text = String.Format("{0:T}", System.DateTime.Now)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        d2 = Now
        If d2 > d1 Then
            frmExamResult.Show()
            Me.Close()

            Timer2.Enabled = False
            Timer2.Stop()

        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Me.Dispose()

        frmExamResult.Show()
    End Sub

    Private Sub frmExamTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        d1 = Now.AddSeconds(200)

        If con.State = 1 Then con.Close()
        qry = "select course from tbl_approve where Ex_regno='" & rg & "'"

        Try

            cmd = New SqlCommand(qry, con)
            con.Open()
            Dim dr1 As SqlDataReader = cmd.ExecuteReader()
            If dr1.Read() Then
                lblcoursename.Text = dr1.Item("course").ToString
                course = lblcoursename.Text
            End If
            If con.State = 1 Then con.Close()
            qry = "select subjects from tbl_course where course='" & lblcoursename.Text & "'and subjects='" & subject & "'and part='" & p & "'"
            cmd = New SqlCommand(qry, con)
            con.Open()
            dr1 = cmd.ExecuteReader()

            If dr1.Read() Then
                lblsubject.Text = dr1.Item("subjects").ToString
                subject = lblsubject.Text
            End If
            If con.State = 1 Then con.Close()
            'show question
            qry = "select q_no,question,op_A,op_B,op_C,op_D,answer from tbl_Question with (nolock)  where course='" & lblcoursename.Text & "'and subject ='" & lblsubject.Text & "' "
            cmd = New SqlCommand(qry, con)
            con.Open()
            dr1 = cmd.ExecuteReader()

            If dr1.Read() Then
                lblqstn.Text = dr1.Item("q_no").ToString
                txtqstn.Text = dr1.Item("question").ToString
                rdboA.Text = dr1.Item("op_A").ToString
                rdboB.Text = dr1.Item("op_B").ToString
                rdboC.Text = dr1.Item("op_C").ToString
                rdboD.Text = dr1.Item("op_D").ToString
                lblAns.Text = dr1.Item("answer").ToString
                qnum = lblqstn.Text
                lblstdname.Text = Module1.name1
                lblrollno.Text = Module1.roll1

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        If con.State = 1 Then con.Close()
    End Sub
End Class