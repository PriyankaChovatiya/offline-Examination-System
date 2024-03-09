Imports System.Data
Imports System.Data.SqlClient



Public Class frmUpdateQuestion


    Private Sub frmUpdateQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bindcourse()
    End Sub
    Private Sub Bindcourse() '-----------show all courses in comboBox
        cmbCourse.Items.Clear()
        ds.Clear()
        If con.State = 1 Then con.Close()
        qry = "select distinct (course) from tbl_course with (nolock)"
        ds = FetchData(qry)

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

    Private Sub Bindsubject() '-----------show all subject in comboBox
        cmbSubject.Items.Clear()
        ds.Clear()
        If con.State = 1 Then con.Close()
        qry = "select distinct (subjects) from tbl_course with (nolock) where course='" & cmbCourse.Text & "' "
        ds = FetchData(qry)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim tblrow As Integer = ds.Tables(0).Rows.Count - 1
            Dim i As Integer = 0
            For i = 0 To tblrow
                cmbSubject.Items.Add(ds.Tables(0).Rows(i)(0).ToString())
            Next
        Else
            MsgBox("Course Not Found")
        End If
    End Sub





    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Dispose()

    End Sub



    Private Sub cmbCourse_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbCourse.SelectedIndexChanged
        Bindsubject()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'validation code
        If txtQno.Text.Trim() = "" Then
            txtQno.Focus() : Exit Sub
        ElseIf txtQus.Text.Trim() = "" Then
            txtQus.Focus() : Exit Sub
        ElseIf txtOptionA.Text.Trim() = "" Then
            txtOptionA.Focus() : Exit Sub
        ElseIf txtOptionB.Text.Trim() = "" Then
            txtOptionB.Focus() : Exit Sub
        ElseIf txtOptionC.Text.Trim() = "" Then
            txtOptionC.Focus() : Exit Sub
        ElseIf txtOptionD.Text.Trim() = "" Then
            txtOptionD.Focus() : Exit Sub
        ElseIf cmbcorrectAns.Text.Trim() = "" Then
            cmbcorrectAns.Focus() : Exit Sub
        ElseIf cmbCourse.Text.Trim() = "" Then
            cmbCourse.Focus() : Exit Sub
        ElseIf cmbSubject.Text.Trim() = "" Then
            cmbSubject.Focus() : Exit Sub

        End If
        Try
            qry = "Update tbl_Question set course='" & cmbCourse.Text & "',subject='" & cmbSubject.Text & "',question='" & txtQus.Text & "',op_A='" & txtOptionA.Text & "',op_B='" & txtOptionB.Text & "',op_C='" & txtOptionC.Text & "',op_D='" & txtOptionD.Text & "',answer='" & cmbcorrectAns.Text & "' where q_no =" & _id & " "
            i = InsertData(qry)
            If (i > 0) Then
                MsgBox("Question Updated successful", MsgBoxStyle.Information)






                With frmEditQuestion
                    .LoadRecord()
                End With
                Me.Dispose()
            Else
                MsgBox("Question  Not Added ", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()

    End Sub
End Class