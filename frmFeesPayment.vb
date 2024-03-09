Imports System.Data
Imports System.Data.SqlClient
Public Class frmFeesPayment
    Dim regnum As String
    Dim recptnum As Integer
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()

    End Sub

    Private Sub txtrollno_TextChanged(sender As Object, e As EventArgs) Handles txtrollno.TextChanged
        If txtrollno.Text <> "" Then
            qry = "select course,fees from tbl_fees where studno='" & txtrollno.Text & "'"
            If con.State = 1 Then con.Close()
            Try
                cmd = New SqlCommand(qry, con)
                con.Open()
                dr = cmd.ExecuteReader()
                If dr.Read Then
                    MsgBox("payment Already done", MsgBoxStyle.Exclamation)
                    lblcourse.Text = dr.Item("course").ToString
                    lblfees.Text = dr.Item("fees").ToString
                    CheckBox1.Checked = True
                Else
                    qry = "select course from tbl_registration where studno='" & txtrollno.Text & "'"
                    Try
                        If con.State = 1 Then con.Close()
                        cmd = New SqlCommand(qry, con)
                        con.Open()
                        dr = cmd.ExecuteReader()
                        If dr.Read Then
                            lblcourse.Text = dr.Item("course").ToString
                        Else
                            lblcourse.Text = ""
                            lblfees.Text = ""
                            CheckBox1.Checked = False
                            MsgBox("Application Number is not found", MsgBoxStyle.Critical)
                            Exit Sub

                        End If

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    'select fees
                    If con.State = 1 Then con.Close()
                    qry = "select fees from tbl_course_fee where course='" & lblcourse.Text & "' "
                    cmd = New SqlCommand(qry, con)
                    con.Open()
                    dr = cmd.ExecuteReader()
                    If dr.Read Then
                        lblfees.Text = dr.Item("fees").ToString
                        CheckBox1.Checked = False
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

        End If
        If con.State = 1 Then con.Close()
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        'validation

        If txtrollno.Text = "" Or lblcourse.Text = "" Or lblfees.Text = "" Or CheckBox1.Checked = False Then
            MsgBox("Plz Enter The Required Details", MsgBoxStyle.Critical)
        Else
            qry = "select max(CAST(SUBSTRING (Ex_regno,2,Len(Ex_regno))+1 as int)) as roll from tbl_approve "
            If con.State = 1 Then con.Close()

            cmd = New SqlCommand(qry, con)
            con.Open()
            dr = cmd.ExecuteReader()
            If dr.Read Then
                If Val(dr.Item("roll").ToString) = 0 Then


                    regnum = "R1917609"
            Else
                regnum = "R" & dr.Item("roll").ToString
            End If
        End If
            'insert

            qry = "insert into tbl_approve(studno,Ex_regno,course)values('" & txtrollno.Text & "','" & regnum & "','" & lblcourse.Text & "')"
            InsertData(qry)
            qry = "select max(recpt_no)+1 as recpt_no from tbl_fees"
            If con.State = 1 Then con.Close()
            cmd = New SqlCommand(qry, con)
            con.Open()
            dr = cmd.ExecuteReader()
            If dr.Read Then
                If Val(dr.Item("recpt_no").ToString) = 0 Then
                    recptnum = 1001
                Else
                    recptnum = Val(dr.Item("recpt_no").ToString)
                End If
            End If
            Try
                qry = "insert into tbl_fees(recpt_no,studno,course,fees)values('" & recptnum & "','" & txtrollno.Text & "','" & lblcourse.Text & "','" & lblfees.Text & "')"

                i = InsertData(qry)
                If i > 0 Then
                    MsgBox("Payment Successfully Done", MsgBoxStyle.Information)
                Else
                    MsgBox("Payment Failed", MsgBoxStyle.Critical)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try



        End If
    End Sub

    Private Sub btncancle_Click(sender As Object, e As EventArgs) Handles btncancle.Click
        txtrollno.Clear()
        lblcourse.Text = ""
        lblfees.Text = ""
        CheckBox1.Checked = False
    End Sub
End Class