Imports System.Data
Imports System.Data.SqlClient

Public Class frmfees
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()

    End Sub

    Private Sub frmfees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showgv()

    End Sub

    Public Sub showgv()
        Try
            If con.State = 1 Then con.Close()
            con.Open()
            cmd = New SqlCommand("select course,fees from tbl_course_fee ", con)
            da = New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                dgvfees.DataSource = dt
            Else
                MsgBox("Record Not Found or table is empty")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        If con.State = 1 Then con.Close()
    End Sub
End Class