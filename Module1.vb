Imports System.Data
Imports System.Data.SqlClient

Module Module1
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public da As New SqlDataAdapter
    Public strUser As String = "priya"
    Public connectionstring As String = "Data Source=.;Initial Catalog=DBExaminationSystem;Integrated Security=True"
    Public con As New SqlConnection(connectionstring)
    Public i As Integer = 0
    Public name1 As String = ""
    Public utype As String = ""
    Public userpass As String = ""
    Public str, gender As String
    Public ds As New DataSet
    Public qry As String = ""
    Public _id As String
    Public roll1 As String = ""
    Public rg As String = ""
    Public course, ans As String
    Public subject As String = ""
    Public p As Integer = 1
    Public qnum As Integer
    Public d1 As DateTime

    Public Function FetchData(ByVal qry As String) As DataSet
        da = New SqlDataAdapter(qry, con)
        ds = New DataSet
        da.Fill(ds)
        Return ds
    End Function

    'create a function for insert,next and update

    Public Function InsertData(ByVal qry As String) As Integer
        If con.State = 1 Then con.Close()
        cmd = New SqlCommand(qry, con)
        con.Open()
        i = cmd.ExecuteNonQuery()
        If con.State = 1 Then con.Close()
        Return i


    End Function



End Module
