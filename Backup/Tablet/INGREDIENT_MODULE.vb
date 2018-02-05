Imports System.Data.OleDb
Module INGREDIENT_MODULE
    Public ingredient_connection As OleDbConnection
    Public ingredient_adapter_non_descriptive As OleDbDataAdapter
    Public ingredient_command_builder As OleDbCommandBuilder
    Public ingredient_adapter_descriptive As OleDbDataAdapter
    Public ingredient_dataset As DataSet
    Public ingredient_data_column_non_descriptive() As DataColumn
    Public ingredient_data_column_descriptive() As DataColumn
    Public ingredient_list_show As Boolean
    Public Sub ingredient_open_connection()
        Try
            ingredient_connection = New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\coa_and_sop.mdb")
            ingredient_connection.Open()
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub ingredient_close_connection()
        Try
            ingredient_connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub ingredient_filldataset_nondescriptive()
        Try
            ingredient_adapter_non_descriptive = New OleDbDataAdapter("select * from NON_DESCRIPTIVE_INGREDIENT", ingredient_connection)
            ingredient_dataset = New DataSet
            ingredient_adapter_non_descriptive.Fill(ingredient_dataset, "NON_DESCRIPTIVE_INGREDIENT")
            ReDim ingredient_data_column_non_descriptive(1)
            ingredient_data_column_non_descriptive(0) = ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Columns(0)
            ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").PrimaryKey = ingredient_data_column_non_descriptive
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub ingredient_updatabase_nondescriptive()
        Try
            ingredient_command_builder = New OleDbCommandBuilder(ingredient_adapter_non_descriptive)
            ingredient_adapter_non_descriptive.Update(ingredient_dataset, "NON_DESCRIPTIVE_INGREDIENT")
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub ingredient_filldataset_descriptive()
        Try
            ingredient_adapter_descriptive = New OleDbDataAdapter("select * from DESCRIPTIVE_INGREDIENT", ingredient_connection)
            ingredient_dataset = New DataSet
            ingredient_adapter_descriptive.Fill(ingredient_dataset, "DESCRIPTIVE_INGREDIENT")
            ReDim ingredient_data_column_descriptive(1)
            ingredient_data_column_descriptive(0) = ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Columns(0)
            ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").PrimaryKey = ingredient_data_column_descriptive
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub ingredient_updatabase_descriptive()
        Try
            ingredient_command_builder = New OleDbCommandBuilder(ingredient_adapter_descriptive)
            ingredient_adapter_descriptive.Update(ingredient_dataset, "DESCRIPTIVE_INGREDIENT")
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
End Module
