'database connectivity details for powder_module
Imports System.Data.OleDb
Module POWDER_MODULE
    Public powder_connection As OleDbConnection
    Public powder_dataset As DataSet
    Public powder_adapter_master As OleDbDataAdapter
    Public powder_adapter_detail As OleDbDataAdapter
    Public powder_adapter_ingredient As OleDbDataAdapter
    Public powder_command_builder As OleDbCommandBuilder
    Public powder_data_column() As DataColumn
    Public Sub powder_open_connection()
        Try
            powder_connection = New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\coa_and_sop.mdb")
            powder_connection.Open()
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub powder_close_connection()
        Try
            powder_connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try

    End Sub
    Public Sub powder_filldataset_master()
        Try
            powder_adapter_master = New OleDbDataAdapter("select * from POWDER_MASTER", powder_connection)
            powder_dataset = New DataSet
            powder_adapter_master.Fill(powder_dataset, "POWDER_MASTER")
            ReDim powder_data_column(1)
            powder_data_column(0) = powder_dataset.Tables("POWDER_MASTER").Columns(1)
            powder_dataset.Tables("POWDER_MASTER").PrimaryKey = powder_data_column
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub powder_updatedatabase_master()
        Try
            powder_command_builder = New OleDbCommandBuilder(powder_adapter_master)
            powder_adapter_master.Update(powder_dataset, "POWDER_MASTER")
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub powder_filldataset_detail()
        Try
            powder_adapter_detail = New OleDbDataAdapter("select * from POWDER_DETAIL ", powder_connection)
            powder_dataset = New DataSet
            powder_adapter_detail.Fill(powder_dataset, "POWDER_DETAIL")
            powder_dataset.Tables("POWDER_DETAIL").Columns(1).Unique = True
            'powder_dataset.Tables("POWDER_DETAIL").Columns(4).Unique = True
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub powder_updatedatabase_detail()
        Try
            powder_command_builder = New OleDbCommandBuilder(powder_adapter_detail)
            powder_adapter_detail.Update(powder_dataset, "POWDER_DETAIL")
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub powder_filldataset_ingredient()
        Try
            powder_adapter_ingredient = New OleDbDataAdapter("select * from POWDER_INGREDIENT", powder_connection)
            powder_dataset = New DataSet
            powder_adapter_ingredient.Fill(powder_dataset, "POWDER_INGREDIENT")
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub powder_updatedatabase_ingredient()
        Try
            powder_command_builder = New OleDbCommandBuilder(powder_adapter_ingredient)
            powder_adapter_ingredient.Update(powder_dataset, "POWDER_INGREDIENT")
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
End Module


