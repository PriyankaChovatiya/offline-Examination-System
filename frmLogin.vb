Imports System.Data
Imports System.Data.SqlClient


Public Class frmLogin
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Hide()
        Form1.Show()


    End Sub

    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click
        Try

            'validation
            If Len(Trim(txtusername.Text)) = 0 Then
                MessageBox.Show("Please enter Username", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtusername.Focus()
                Exit Sub
            ElseIf (Len(Trim(txtpass.Text)) = 0) Then
                MessageBox.Show("Please enter Password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtpass.Focus()
                Exit Sub

            ElseIf (Len(Trim(cmbusertype.Text)) = 0) Then
                MessageBox.Show("Please select User type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If


            ' login code---------------------------------
            cmd = New SqlCommand("select * from tbl_login where username=@username and password=@password and usertype=@ut", con)
                Dim UParam As New SqlParameter("@username", Me.txtusername.Text)
                Dim PassParam As New SqlParameter("@password", Me.txtpass.Text)
                Dim type As New SqlParameter("@ut", Me.cmbusertype.Text)


                cmd.Parameters.Add(UParam)
                cmd.Parameters.Add(PassParam)
                cmd.Parameters.Add(type)
                cmd.Connection = con
                cmd.Connection.Open()
                'run cmd
                dr = cmd.ExecuteReader()


                If dr.HasRows Then
                    name1 = txtusername.Text
                utype = cmbusertype.Text
                userpass = txtpass.Text

                con.Close()

                    If (utype = "Admin") Then
                        Me.Hide()
                        frmMaster.Show()
                    ElseIf (utype = "Student") Then
                        Me.Hide()
                        frmExamQuestion.Show()
                    ElseIf (utype = "Staff") Then
                        Me.Hide()
                        frmMaster.Show()



                    End If
                    con.Close()
                Else
                    MsgBox("UserID & password not matched", MsgBoxStyle.Critical, MsgBoxStyle.OkOnly)


                End If






        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()


        End Try
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class