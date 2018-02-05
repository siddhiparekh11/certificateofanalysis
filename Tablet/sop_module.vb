Imports System.Data.OleDb
Module sop_module

    Public sop_connection As OleDbConnection
    Public sop_adapter_master As OleDbDataAdapter
    Public sop_adapter_detail As OleDbDataAdapter
    Public sop_adapter_alert As OleDbDataAdapter
    Public sop_dataset As DataSet
    Public sop_column() As DataColumn, sop_column1() As DataColumn
    Public sop_command_builder As Data.OleDb.OleDbCommandBuilder
    Public Sub sop_open_connection()
        Try
            sop_connection = New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\coa_and_sop.mdb")
            sop_connection.Open()
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub sop_close_connection()
        Try
            sop_connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub sop_fill_dataset_master()
        Try
            sop_adapter_master = New OleDbDataAdapter("select * from SOP_MASTER", sop_connection)
            sop_dataset = New DataSet
            sop_adapter_master.Fill(sop_dataset, "SOP_MASTER")
            ReDim sop_column(1)
            sop_column(0) = sop_module.sop_dataset.Tables("SOP_MASTER").Columns(0)
            sop_module.sop_dataset.Tables("SOP_MASTER").PrimaryKey = sop_column
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub sop_update_database_master()
        Try
            sop_command_builder = New OleDbCommandBuilder(sop_adapter_master)
            sop_adapter_master.Update(sop_dataset, "SOP_MASTER")
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub sop_fill_dataset_detail()
        Try
            sop_adapter_detail = New OleDbDataAdapter("select * from SOP_DETAIL", sop_connection)
            sop_dataset = New DataSet
            sop_adapter_detail.Fill(sop_dataset, "SOP_DETAIL")
            ReDim sop_column1(1)
            sop_column1(0) = sop_module.sop_dataset.Tables("SOP_DETAIL").Columns(1)
            sop_module.sop_dataset.Tables("SOP_DETAIL").PrimaryKey = sop_column1
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub sop_update_database_detail()
        Try
            sop_command_builder = New OleDbCommandBuilder(sop_adapter_detail)
            sop_adapter_detail.Update(sop_dataset, "SOP_DETAIL")
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try

    End Sub
    Public Sub sop_fill_dataset_alert(ByVal sop_sys_date As Date)
        Try
            sop_adapter_detail = New OleDbDataAdapter("select * from SOP_DETAIL where Review_Date=" & sop_sys_date, sop_connection)
            sop_dataset = New DataSet
            sop_adapter_detail.Fill(sop_dataset)
            Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
End Module

