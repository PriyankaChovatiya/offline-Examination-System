Imports System.Data.SqlClient


Public Class frmExamPasschange
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If LinkLabel1.Text = "show password" Then
            txtNEWpass.UseSystemPasswordChar = False
            txtConfirmpass.UseSystemPasswordChar = False
            LinkLabel1.Text = "Hide"
        ElseIf LinkLabel1.Text = "Hide" Then
            txtNEWpass.UseSystemPasswordChar = True
            txtConfirmpass.UseSystemPasswordChar = True
            LinkLabel1.Text = "show password"


        End If
    End Sub

    Private Sub frmExamPasschange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LinkLabel1.Text = "show password"
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If con.State = 1 Then con.Close()

        If txtAdminpass.Text = "" Then Exit Sub
        If txtConfirmpass.Text = "" Then Exit Sub
        If txtOldpass.Text = "" Then Exit Sub
        If txtNEWpass.Text = "" Then Exit Sub

        If txtAdminpass.Text <> Module1.userpass And Module1.utype <> "Admin" Then
            MsgBox("Invallid Admin Password,You Do Not have Permission")
            txtAdminpass.Text = ""
            txtConfirmpass.Text = ""
            txtOldpass.Text = ""
            txtNEWpass.Text = ""
            txtAdminpass.Focus()

        Else
            qry = "select * from tblpassword where password='" & txtOldpass.Text & "'"
            con.Open()
            cmd = New SqlCommand(qry, con)
            dr = cmd.ExecuteReader
            If dr.Read() Then
                If txtNEWpass.Text <> txtConfirmpass.Text Then
                    MsgBox("Please Confirm the password correct")
                    txtNEWpass.Clear()
                    txtConfirmpass.Clear()
                    txtNEWpass.Focus()
                Else
                    qry = ("Update tblpassword set password='" & txtNEWpass.Text & "'")
                    InsertData(qry)
                    MsgBox("Password Changed Sucessfully")
                    clr()
                End If


            Else
                MsgBox("Invalid Old Exam password", MsgBoxStyle.Critical)
                txtOldpass.Clear()
                txtOldpass.Focus()


            End If
        End If
        con.Close()

    End Sub
    Public Sub clr()
        txtAdminpass.Text = ""
        txtConfirmpass.Text = ""
        txtOldpass.Text = ""
        txtNEWpass.Text = ""
    End Sub
End Class