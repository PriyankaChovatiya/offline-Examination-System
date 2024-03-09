Imports System.Data.SqlClient

Public Class frmaddstudimg
    Dim ofd As OpenFileDialog = New OpenFileDialog

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If ofd.ShowDialog = DialogResult.OK Then
            PictureBox2.Image = Image.FromFile(ofd.FileName)
        Else
            MsgBox("Please select A file", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If TextBox1.Text <> "" Then

            Dim fname As String = TextBox1.Text & ".jpg"
            Dim folder As String = "D:\pp"
            qry = "update tbl_registration set imagefile =@img where studno=@id"
            con.Open()
            Dim path As String = System.IO.Path.Combine(folder, fname)
            cmd = New SqlCommand(qry, con)
            cmd.Parameters.AddWithValue("@img", path)
            cmd.Parameters.AddWithValue("@id", TextBox1.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            Dim a As Image = PictureBox2.Image
            a.Save(path)
            MsgBox("Profile pic save successfully")



        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd = New SqlCommand("select imagefile from tbl_registration where studno='" & TextBox1.Text & "'", con)
        con.Open()
        dr = cmd.ExecuteReader()
        If dr.Read Then
            If dr.Item("imagefile").ToString = "" Then
                PictureBox2.Image = My.Resource.noimage_jpg

            Else
                PictureBox2.Image = Image.FromFile(dr.Item("imagefile").ToString)

            End If

        Else

        End If

        con.Close()

    End Sub
End Class