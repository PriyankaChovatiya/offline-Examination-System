Imports System.Data
Imports System.Data.SqlClient

Public Class frmFeesPaymentDatails
    Private Sub frmFeesPaymentDatails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadApprovedStudent()
    End Sub
    Public Sub loadApprovedStudent()
        If con.State = 1 Then con.Close()
        con.Open()

        qry = "select f .recpt_no ,f.studno,f.course,f.fees,f.pdate From tbl_fees f join tbl_registration r On r .studno =f.studno where r.approve ='yes' "


        ds = FetchData(qry)
        If (ds.Tables(0).Rows.Count > 0) Then
            dgvASL.DataSource = ds.Tables(0)
        Else
            MsgBox("Record not found", vbCritical)

        End If
        If con.State = 1 Then con.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Val(TextBox1.Text.Trim()) > 0 Then
            loadfeesbyid()
        ElseIf (Val(TextBox1.Text.Trim()) = 0) Then

            loadApprovedStudent()

        ElseIf TextBox1.Text.Trim() = String.Empty Then
            loadApprovedStudent()
        End If

        loadfeesbyid()
    End Sub
    Public Sub loadfeesbyid()
        If con.State = 1 Then con.Close()
        con.Open()

        qry = "set nocount on  select f.recpt_no ,f.studno,f.course,f.fees,f.pdate From tbl_fees f with (nolock) join tbl_registration r On r .studno =f.studno where r.approve ='yes'and f.studno='" & Convert.ToDouble(TextBox1.Text) & "'"


        ds = FetchData(qry)
        If (ds.Tables(0).Rows.Count > 0) Then
            dgvASL.DataSource = ds.Tables(0)
        Else
            MsgBox("Record not found", vbCritical)

        End If
        If con.State = 1 Then con.Close()

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class