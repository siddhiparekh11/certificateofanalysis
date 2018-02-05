'database connectivity details for liquid_module
Imports System.Data.OleDb
Module LIQUID_MODULE
    Public liquid_connection As OleDbConnection
    Public liquid_dataset As DataSet
    Public liquid_adapter_master As OleDbDataAdapter
    Public liquid_adapter_detail As OleDbDataAdapter
    Public liquid_adapter_ingredient As OleDbDataAdapter
    Public liquid_command_builder As OleDbCommandBuilder
    Public liquid_data_column() As DataColumn
    Public Sub liquid_open_connection()
        liquid_connection = New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\coa_and_sop.mdb")
        liquid_connection.Open()
    End Sub
    Public Sub liquid_close_connection()
        liquid_connection.Close()
    End Sub
    Public Sub liquid_filldataset_master()
        liquid_adapter_master = New OleDbDataAdapter("select * from LIQUID_MASTER", liquid_connection)
        liquid_dataset = New DataSet
        liquid_adapter_master.Fill(liquid_dataset, "LIQUID_MASTER")
        ReDim liquid_data_column(1)
        liquid_data_column(0) = liquid_dataset.Tables("LIQUID_MASTER").Columns(1)
        liquid_dataset.Tables("LIQUID_MASTER").PrimaryKey = liquid_data_column
    End Sub
    Public Sub liquid_updatedatabase_master()
        liquid_command_builder = New OleDbCommandBuilder(liquid_adapter_master)
        liquid_adapter_master.Update(liquid_dataset, "LIQUID_MASTER")
    End Sub
    Public Sub liquid_filldataset_detail()
        Try
            liquid_adapter_detail = New OleDbDataAdapter("select * from LIQUID_DETAIL", liquid_connection)
            liquid_dataset = New DataSet
            liquid_adapter_detail.Fill(liquid_dataset, "LIQUID_DETAIL")
            liquid_dataset.Tables("LIQUID_DETAIL").Columns(1).Unique = True
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub liquid_updatedatabase_detail()
        Try
            liquid_command_builder = New OleDbCommandBuilder(liquid_adapter_detail)
            liquid_adapter_detail.Update(liquid_dataset, "LIQUID_DETAIL")
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub liquid_filldataset_ingredient()
        Try
            liquid_adapter_ingredient = New OleDbDataAdapter("select * from LIQUID_INGREDIENT", liquid_connection)
            liquid_dataset = New DataSet
            liquid_adapter_ingredient.Fill(liquid_dataset, "LIQUID_INGREDIENT")
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub liquid_updatedatabase_ingredient()
        Try
            liquid_command_builder = New OleDbCommandBuilder(liquid_adapter_ingredient)
            liquid_adapter_ingredient.Update(liquid_dataset, "LIQUID_INGREDIENT")
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
End Module
