Imports System.Data
Imports System.Data.SqlClient


Public Class frmEmployeeViewList
    Dim itemcoll(20) As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()

    End Sub

    Private Sub frmEmployeeViewList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmp()
    End Sub
    Public Sub LoadEmp()
        If con.State = 1 Then con.Close()
        con.Open()
        Me.ListView1.View = View.Details
        Me.ListView1.GridLines = True

        qry = "select * from tbl_Employee"
        cmd = New SqlCommand(qry, con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet

        da.Fill(ds, "Table")
        Dim i As Integer = 0
        Dim j As Integer = 0
        'adding the column in listview
        For i = 0 To ds.Tables(0).Columns.Count - 1
            Me.ListView1.Columns.Add(ds.Tables(0).Columns(i).ColumnName.ToString())

        Next
        ' now adding the item in listview
        For i = 0 To ds.Tables(0).Rows.Count - 1
            For j = 0 To ds.Tables(0).Columns.Count - 1
                itemcoll(j) = ds.Tables(0).Rows(i)(j).ToString()

            Next
            Dim lvi As New ListViewItem(itemcoll)
            Me.ListView1.Items.Add(lvi)
        Next




    End Sub
End Class