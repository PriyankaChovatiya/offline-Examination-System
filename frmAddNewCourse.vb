Imports System.Data.SqlClient

Public Class frmAddNewCourse
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cmbCourse.Text = "" Or txtsubject.Text = "" Then
            MsgBox("Please enter the fields")
        Else
            qry = "select * from tbl_course where course='" & cmbCourse.Text & "'and subjects='" & txtsubject.Text & "'and part='" & cmbPart.Text & "'"

            cmd = New SqlCommand(qry, con)
            If con.State = 1 Then con.Close()
            con.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                MsgBox("course and subject already exist", MsgBoxStyle.Critical)
                cmbCourse.Text = ""
                txtsubject.Clear()
            Else
                qry = "insert into tbl_course (course,subjects,part)values('" & cmbCourse.Text & "','" & txtsubject.Text & "','" & cmbPart.Text & "')"
                If con.State = 1 Then con.Close()

                InsertData(qry)

                MsgBox("Record Added Successfully", MsgBoxStyle.Information)
                txtsubject.Clear()
                cmbCourse.Text = ""
                cmbPart.Text = ""
                Bindcourse()
            End If


        End If
    End Sub

    Private Sub frmAddNewCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bindcourse()

    End Sub
    Private Sub Bindcourse() '-----------show all courses in comboBox
        cmbCourse.Items.Clear()
        ds.Clear()
        If con.State = 1 Then con.Close()
        qry = "select distinct (course) from tbl_course with (nolock)"
        FetchData(qry)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim tblrow As Integer = ds.Tables(0).Rows.Count - 1
            Dim i As Integer = 0
            For i = 0 To tblrow
                cmbCourse.Items.Add(ds.Tables(0).Rows(i)(0).ToString())
            Next
        Else
            MsgBox("Course Not Found")
        End If
    End Sub
End Class