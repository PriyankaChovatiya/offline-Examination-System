Imports System.Data
Imports System.Data.SqlClient

Public Class frmEditQuestion
    Private Sub frmEditQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecord()
    End Sub

    Public Sub LoadRecord()
        DataGridView1.Rows.Clear()
        con.Close()
        cmd = New SqlCommand("select * from tbl_Question with(nolock)", con)
        con.Open()
        dr = cmd.ExecuteReader
        Dim i As Integer = 0

        While dr.Read
            i += 1
            DataGridView1.Rows.Add(dr.Item("q_no").ToString, i, dr.Item("course").ToString, dr.Item("subject").ToString, dr.Item("question").ToString, dr.Item("op_A").ToString, dr.Item("op_B").ToString, dr.Item("op_C").ToString, dr.Item("op_D").ToString, dr.Item("answer").ToString)

        End While
        dr.Close()

        con.Close()
        lblcount.Text = "(" & DataGridView1.RowCount & ") Records found."

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colname = "Column11" Then
            With frmUpdateQuestion

                _id = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                MsgBox(_id)
                .cmbCourse.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .cmbSubject.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                .txtQno.Text = _id
                .txtQus.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                .txtOptionA.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
                .txtOptionB.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
                .txtOptionC.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
                .txtOptionD.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString
                .cmbcorrectAns.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString



                .txtQno.ReadOnly = True
                .ShowDialog()



            End With
        ElseIf colName = "column12" Then
            If (MsgBox("Are you sure want to delete record?", vbYesNo + vbQuestion) = vbYes) Then
                qry = "Delete from tbl_Question where q_no=" & DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString & ""
                i = InsertData(qry)
                If (i > 0) Then
                    MsgBox("Question Deleted successful", MsgBoxStyle.Information)
                    LoadRecord()
                Else
                    MsgBox("Question not Deleted", MsgBoxStyle.Exclamation)

                End If

            End If

            End If
    End Sub
End Class