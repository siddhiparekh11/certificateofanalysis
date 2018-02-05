Imports System.Data.OleDb
Module LOGIN_MODULE
    Public conn As OleDbConnection
    Public ds As DataSet
    Public adpt_master, adpt_detail As OleDbDataAdapter
    Public comm As OleDbCommandBuilder
    Public drow As DataRow
    Public drow1 As DataRow
    Public dcol() As DataColumn
    Public Sub open_login_conn()
        conn = New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\Database5.mdb")
        conn.Open()
    End Sub
    Public Sub fill_dataset_master()
        adpt_master = New OleDbDataAdapter("select * from LOGIN_MASTER", conn)
        ds = New DataSet
        adpt_master.Fill(ds, "LOGIN_MASTER")
        ReDim dcol(1)
        dcol(0) = ds.Tables("LOGIN_MASTER").Columns(0)
        ds.Tables("LOGIN_MASTER").PrimaryKey = dcol
        ds.CaseSensitive = True
    End Sub
    Public Sub update_database_master()
        comm = New OleDbCommandBuilder(adpt_master)
        adpt_master.Update(ds, "LOGIN_MASTER")
    End Sub
    Public Sub fill_dataset_detail()
        adpt_detail = New OleDbDataAdapter("select * from LOGIN_DETAIL", conn)
        ds = New DataSet
        adpt_detail.Fill(ds, "LOGIN_DETAIL")
    End Sub
    Public Sub update_database_detail()
        comm = New OleDbCommandBuilder(adpt_detail)
        adpt_detail.Update(ds, "LOGIN_DETAIL")
    End Sub

End Module
