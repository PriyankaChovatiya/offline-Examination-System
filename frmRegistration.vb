Imports System.Data
Imports System.Data.SqlClient

Public Class frmRegistration


    Private Sub frmRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = 1 Then con.Close()
        LOAD_ANO()
        load_course()
    End Sub

    Public Sub LOAD_ANO()
        ds.clear()
        txtstudtno.Clear()
        If con.State = 1 Then con.Close()

        con.Open()
        str = "select * from tbl_registration"
        Dim cmd As SqlCommand = cmd
        cmd = New SqlCommand(str, con)
        da.SelectCommand = cmd
        da.Fill(ds, "tbl_registration")


        Dim LastNo As Integer
        LastNo = ds.Tables("tbl_registration").Rows.Count + 1
        If LastNo >= 0 Then
            txtstudtno.Text = LastNo
        Else
            txtstudtno.Text = "1"
        End If

        If con.State = 1 Then con.Close()


    End Sub

    Public Sub load_course()
        cmbcrs.Items.Clear()
        Dim ctr As Integer
        con.Open()
        str = "select distinct (course)from tbl_course"
        cmd = New SqlCommand(str, con)
        da.SelectCommand = cmd
        da.Fill(ds, "tbl_course")
        ctr = ds.Tables("tbl_course").Rows.Count - 1
        For i = 0 To ctr
            cmbcrs.Items.Add(ds.Tables("tbl_course").Rows(i)(0).ToString)
        Next
        con.Close()


    End Sub

    Public Sub radiogender()
        If rdbtnfemale.Checked = True Then
            gender = "female"
        Else
            gender = "male"
        End If
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()
        Form1.Show()


    End Sub

    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click
        If con.State = 1 Then con.Close()
        If txtstudtno.Text = "" Or txtstdtname.Text = "" Or txtadd.Text = "" Or txtcontact.Text = "" Or (rdbtnmale.Checked = False And rdbtnfemale.Checked = False) Or txtquli.Text = "" Then
            MsgBox("please enter all details")
            Exit Sub
        End If
        Try
            'check duplicate value

            ' qry = "select applicationnum form tbl_registration where applicationnum=' " & txtapplicationnum.Text & "'"
            cmd = New SqlCommand("select studno from tbl_registration where studno=@studno", con)
            Dim UParam As New SqlParameter("@studno", Me.txtstudtno.Text)
            cmd.Parameters.Add(UParam)
            cmd.Connection = con
            cmd.Connection.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If dr.HasRows Then
                MsgBox(" STUDENT NUMBER IS ALREADY EXIST")
                con.Close()
            Else
                'insert record
                If con.State = 1 Then con.Close()
                radiogender()
                qry = "insert into tbl_registration(studno,studname,addr,contact_no,gender,course,qualification,dob)values('" & txtstudtno.Text & "','" & txtstdtname.Text & "','" & txtadd.Text & "','" & txtcontact.Text & "','" & gender & "','" & cmbcrs.Text & "','" & txtquli.Text & "',CONVERT(DATE,'" & DateTimePicker1.Value & "',103))"
                cmd = New SqlCommand(qry, con)
                cmd.Connection = con
                cmd.Connection.Open()
                i = cmd.ExecuteNonQuery()
                If (i >= 1) Then
                    MsgBox("STUDENT REGISTRATION SUCCESSFUL")
                    con.Close()
                Else
                    MsgBox("Registration Failed")
                    con.Close()


                End If

            End If




        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()


        End Try
        If con.State = 1 Then con.Close()

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        reset()
    End Sub

    Public Sub reset()
        txtstudtno.Clear()
        txtstdtname.Clear()
        txtadd.Clear()
        txtcontact.Clear()
        txtquli.Clear()
        cmbcrs.SelectedIndex = -1
        LOAD_ANO()

    End Sub

    Private Sub txtstudtno_TextChanged(sender As Object, e As EventArgs) Handles txtstudtno.TextChanged

    End Sub
End Class


