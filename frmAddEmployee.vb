Imports System.Data
Imports System.Data.SqlClient


Public Class frmAddEmployee
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()

    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        If con.State = 1 Then con.Close()

        If txteno.Text = "" Or txtename.Text = "" Or txtaddrs.Text = "" Or txtcntct.Text = "" Or (rdbmale.Checked = False And rdbfemale.Checked = False) Or txtdesign.Text = "" Or txtusername.Text = "" Or txtpswd.Text = "" Then
            MsgBox("please enter all details")
            Exit Sub
        End If
        If txtcntct.Text.Length < 10 Or txtcntct.Text.Length > 11 Then
            MsgBox("invalid phone number")
            Exit Sub
        End If


        Try
            cmd = New SqlCommand("select emp_no from tbl_Employee where emp_no=@d1 ", con)
            Dim UParam As New SqlParameter("@d1", Me.txteno.Text)
            cmd.Parameters.Add(UParam)
            cmd.Connection = con
            cmd.Connection.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If dr.HasRows Then
                MsgBox("EMPLOYEE NUMBER IS ALREADY EXIST")
                con.Close()
            Else
                'insert record
                If con.State = 1 Then con.Close()
                radiogender()
                qry = "insert into tbl_Employee(emp_no,emp_name,doj,dob,addr,contact,designation,username,password,gender)values('" & txteno.Text & "','" & txtename.Text & "','" & dtpdoj.Value & "','" & dtpdob.Value & "','" & txtaddrs.Text & "','" & txtcntct.Text & "','" & txtdesign.Text & "','" & txtusername.Text & "','" & txtpswd.Text & "','" & gender & "')"
                cmd = New SqlCommand(qry, con)
                cmd.Connection = con
                cmd.Connection.Open()
                i = cmd.ExecuteNonQuery()
                If (i >= 1) Then
                    MsgBox("EMPLOYEE REGISTRATION SUCCESSFULL")
                    con.Close()
                Else
                    MsgBox("Registration Failed")
                    con.Close()


                End If
                reset()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try




    End Sub


    Private Sub frmAddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOAD_EMPNO()
        txtename.Focus()
        dtpdob.MaxDate = Today.AddYears(-20)
        dtpdoj.MaxDate = Today.Date
    End Sub
    Public Sub LOAD_EMPNO()
        ds.Clear()
        txteno.Clear()
        If con.State = 1 Then con.Close()

        con.Open()
        str = "select * from tbl_Employee"

        cmd = New SqlCommand(str, con)
        da.SelectCommand = cmd
        da.Fill(ds, "tbl_Employee")


        Dim LastNo As Integer
        LastNo = ds.Tables("tbl_Employee").Rows.Count + 1
        If LastNo >= 0 Then
            txteno.Text = LastNo
        Else
            txteno.Text = "1"
        End If

        If con.State = 1 Then con.Close()
    End Sub

    Public Sub radiogender()
        If rdbfemale.Checked = True Then
            gender = "Female"
        Else
            gender = "Male"
        End If
    End Sub
    Private Sub txtcntct_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcntct.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub




    Private Sub txtename_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtename.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtdesign_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdesign.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        reset()
    End Sub
    Public Sub reset()
        txtename.Clear()
        txtaddrs.Clear()
        txtcntct.Clear()
        txtdesign.Clear()
        txtusername.Clear()
        txtpswd.Clear()
        LOAD_EMPNO()
    End Sub


End Class