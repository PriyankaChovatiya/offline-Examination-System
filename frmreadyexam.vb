Imports System.Data.SqlClient


Public Class frmreadyexam
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub

    Private Sub frmreadyexam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = 1 Then con.Close()
        cmbsubject1.Enabled = True
        txtcourse.Text = course
        Bindsubject()
        StuExNo()
    End Sub
    Private Sub Bindsubject()       '-----------show all subject in comboBox
        cmbsubject1.Items.Clear()
        ds.Clear()
        If con.State = 1 Then con.Close()
        qry = "select distinct (subjects) from tbl_course with (nolock) where course='" & txtcourse.Text & "' "
        ds = FetchData(qry)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim tblrow As Integer = ds.Tables(0).Rows.Count - 1
            Dim i As Integer = 0
            For i = 0 To tblrow
                cmbsubject1.Items.Add(ds.Tables(0).Rows(i)(0).ToString())
            Next
        Else

            cmbsubject1.Enabled = False
        End If
    End Sub

    Private Sub btnGO_Click(sender As Object, e As EventArgs) Handles btnGO.Click
        If txtcourse.Text = "" Then
            Exit Sub
        ElseIf txtexampass.Text = "" Then
            Exit Sub
        ElseIf cmbsubject1.Text = "" Then
            Exit Sub



        End If
        subject = cmbsubject1.Text
        qry = "select password from tblpassword where password='" & txtexampass.Text & "' "
        Try
            If con.State = 1 Then con.Close()
            cmd = New SqlCommand(qry, con)
            con.Open()
            Dim dr1 As SqlDataReader = cmd.ExecuteReader()
            If dr1.Read() Then
                'show exam start
                Me.Close()
                frmExamTest.Show()

            Else
                MsgBox("Record not found try again")


            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Public Sub StuExNo()
        qry = "select * from tbl_approve  with (nolock) where studno= '" & roll1 & "' "
        Try
            If con.State = 1 Then con.Close()
            cmd = New SqlCommand(qry, con)
            con.Open()
            Dim dr1 As SqlDataReader = cmd.ExecuteReader()
            If dr1.Read() Then
                rg = dr1.Item("Ex_regno").ToString
            Else
                MsgBox("Record not found try again")
                btnGO.Enabled = False
                Exit Sub

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        If con.State = 1 Then con.Close()
    End Sub
End Class