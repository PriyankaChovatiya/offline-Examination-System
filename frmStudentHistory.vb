Imports System.Data
Imports System.Data.SqlClient


Public Class frmStudentHistory
    Private Sub frmStudentHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadApprovedStudent()
        loadNOTApprovedStudent()
    End Sub
    Public Sub loadApprovedStudent()
        If con.State = 1 Then con.Close()
        con.Open()

        qry = "select studno as Application_no,studname as [Student name],addr as [Address],gender as [Gender],course as [Course],dob as [Date Of Birth],approve as [Approved] from tbl_registration with (nolock) where approve='yes' "
        ds = FetchData(qry)
        If (ds.Tables(0).Rows.Count > 0) Then
            dgvASL.DataSource = ds.Tables(0)
        Else
            MsgBox("Record not found", vbCritical)

        End If
        If con.State = 1 Then con.Close()

    End Sub

    Public Sub loadNOTApprovedStudent()
        If con.State = 1 Then con.Close()
        con.Open()

        qry = "select studno as Application_no,studname as [Student name],addr as [Address],gender as [Gender],course as [Course],dob as [Date Of Birth],approve as [Approved] from tbl_registration with (nolock) where approve='No' "
        ds = FetchData(qry)
        If (ds.Tables(0).Rows.Count > 0) Then
            dgvNotA.DataSource = ds.Tables(0)
        Else
            MsgBox("Record not found", vbCritical)

        End If
        If con.State = 1 Then con.Close()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub
End Class