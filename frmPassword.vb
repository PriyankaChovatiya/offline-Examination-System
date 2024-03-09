Public Class frmPassword
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtNEWExamPass.Text <> "" Then
            qry = "delete from tblpassword"
            InsertData(qry)
            qry = "insert into tblpassword (password) values('" & txtNEWExamPass.Text & "')"
            InsertData(qry)
            MsgBox("password saved successfully", MsgBoxStyle.Information)
            txtNEWExamPass.Clear()


        End If
    End Sub
End Class