Imports System.Data.OleDb
Module CREAM_MODULE
    Public cream_connection As OleDbConnection
    Public cream_dataset As DataSet
    Public cream_adapter_master As OleDbDataAdapter
    Public cream_adapter_detail As OleDbDataAdapter
    Public cream_adapter_ingredient As OleDbDataAdapter
    Public cream_command_builder As OleDbCommandBuilder
    Public cream_data_column() As DataColumn
    Public cream_relation As DataRelation
    Public Sub cream_open_connection()
        Try
            cream_connection = New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\coa_and_sop.mdb")
            cream_connection.Open()
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub cream_close_connection()
        Try
            cream_connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub cream_filldataset_master()
        Try
            cream_adapter_master = New OleDbDataAdapter("select * from CREAM_MASTER", cream_connection)
            cream_dataset = New DataSet
            cream_adapter_master.Fill(cream_dataset, "CREAM_MASTER")

            ReDim cream_data_column(1)
            cream_data_column(0) = cream_dataset.Tables("CREAM_MASTER").Columns(1)
            cream_dataset.Tables("CREAM_MASTER").PrimaryKey = cream_data_column
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub cream_updatedatabase_master()
        Try
            cream_command_builder = New OleDbCommandBuilder(cream_adapter_master)
            cream_adapter_master.Update(cream_dataset, "CREAM_MASTER")
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub cream_filldataset_detail()
        Try
            cream_adapter_detail = New OleDbDataAdapter("select * from CREAM_DETAIL", cream_connection)
            cream_dataset = New DataSet
            cream_adapter_detail.Fill(cream_dataset, "CREAM_DETAIL")
            cream_dataset.Tables("CREAM_DETAIL").Columns(1).Unique = True
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub cream_updatedatabase_detail()
        Try
            cream_command_builder = New OleDbCommandBuilder(cream_adapter_detail)
            cream_adapter_detail.Update(cream_dataset, "CREAM_DETAIL")
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub cream_filldataset_ingredient()
        Try
            cream_adapter_ingredient = New OleDbDataAdapter("select * from CREAM_INGREDIENT", cream_connection)
            cream_dataset = New DataSet
            cream_adapter_ingredient.Fill(cream_dataset, "CREAM_INGREDIENT")
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub cream_updatedatabase_ingredient()
        Try
            cream_command_builder = New OleDbCommandBuilder(cream_adapter_ingredient)
            cream_adapter_detail.Update(cream_dataset, "CREAM_INGREDIENT")
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
End Module
