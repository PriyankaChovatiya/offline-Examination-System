Imports System.Data
Imports System.Data.SqlClient


Public Class frmApprovalStudent
    Private Sub frmApprovalStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadRecord()
    End Sub
    Public Sub loadRecord()
        Dim i As Integer = 0
        dgvApprove.Rows.Clear()
        con.Open()
        cmd = New SqlCommand("select * from tbl_registration  where approve not in  ('yes')", con)
        dr = cmd.ExecuteReader
        While dr.Read
            i += 1
            dgvApprove.Rows.Add(dr.Item("studno").ToString, i, dr.Item("studname").ToString, dr.Item("gender").ToString, dr.Item("course").ToString, dr.Item("qualification").ToString, dr.Item("dob").ToString, "yes")

        End While
        dr.Close()
        con.Close()
        lblcount.Text = "(" & dgvApprove.RowCount & ") Record Found."



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub

    Private Sub dgvApprove_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvApprove.CellContentClick
        Dim colname As String = dgvApprove.Columns(e.ColumnIndex).Name
        If (colname = "Column8") Then
            If (MsgBox("Are you Sure Want to Approve Student", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                cmd = New SqlCommand("Update tbl_registration set approve = 'yes'where studno='" + _id + "'", con)
                cmd.ExecuteNonQuery()

                con.Close()
                MsgBox("Student Approved Successfully", vbInformation)
                loadRecord()

            End If
        End If
    End Sub

    Private Sub dgvApprove_SelectionChanged(sender As Object, e As EventArgs) Handles dgvApprove.SelectionChanged
        i = dgvApprove.CurrentRow.Index
        _id = dgvApprove.Item(0, i).Value
    End Sub
End Class