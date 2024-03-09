Imports System.Data.SqlClient


Public Class frmExamQuestion
    'Dim roll As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub

    Private Sub frmExamQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        roll1 = InputBox("Enter Student Roll No.")
        showprofile()
        feesdetail()
    End Sub
    Public Sub showprofile()
        qry = "(select * from tbl_registration with (nolock) where studno='" & Convert.ToInt32(roll1) & "' )"
        Try
            If con.State = 1 Then con.Close()
            cmd = New SqlCommand(qry, con)
            con.Open()
            Dim dr1 As SqlDataReader = cmd.ExecuteReader()
            If dr1.read() Then
                lblrollno.Text = dr1.Item("studno").ToString
                lblname.Text = dr1.Item("studname").ToString

                lblcourse.Text = dr1.Item("course").ToString
                lblgender.Text = dr1.Item("gender").ToString
                lbldob.Text = dr1.Item("dob").ToString
                showimg()
            Else
                MsgBox("Record not found try again")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Public Sub showimg()
        If con.State = 1 Then con.Close()

        cmd = New SqlCommand("select imagefile from tbl_registration where studno=" & Convert.ToInt32(roll1) & " ", con)
        con.Open()
        dr = cmd.ExecuteReader()
        If dr.Read Then
            If dr.Item("imagefile").ToString = "" Then
                PictureBox2.Image = My.Resources.noimage_jpg
            Else
                PictureBox2.Image = Image.FromFile(dr.Item("imagefile").ToString)

            End If

        Else

        End If

        con.Close()

    End Sub
    Public Sub feesdetail()
        qry = "select * from tbl_fees with (nolock) where studno=" & Convert.ToInt32(roll1) & ""
        Try
            If con.State = 1 Then con.Close()
            cmd = New SqlCommand(qry, con)
            con.Open()
            Dim dr1 As SqlDataReader = cmd.ExecuteReader()
            If dr1.Read() Then
                lblfees.Text = dr1.Item("fees").ToString


            Else
                MsgBox("your fees is not submit", MsgBoxStyle.Critical)
                Button1.Enabled = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        course = lblcourse.Text
        Me.Hide()
        frmreadyexam.Show()
    End Sub
End Class