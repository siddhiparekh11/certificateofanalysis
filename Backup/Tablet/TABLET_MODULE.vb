'database connectivity details for tablet_module
Imports System.Data.OleDb
Module TABLET_MODULE
    Public tablet_connection As OleDbConnection
    Public tablet_dataset As DataSet
    Public tablet_adapter_master As OleDbDataAdapter
    Public tablet_adapter_detail As OleDbDataAdapter
    Public tablet_adapter_ingredient As OleDbDataAdapter
    Public tablet_command_builder As OleDbCommandBuilder
    Public tablet_data_column() As DataColumn
   Public Sub tablet_open_connection()
        Try
            tablet_connection = New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\coa_and_sop.mdb")
            tablet_connection.Open()
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub tablet_close_connection()
        Try
            tablet_connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub tablet_filldataset_master()
        Try
            tablet_adapter_master = New OleDbDataAdapter("select * from TABLET_MASTER", tablet_connection)
            tablet_dataset = New DataSet
            tablet_adapter_master.Fill(tablet_dataset, "TABLET_MASTER")
            ReDim tablet_data_column(1)
            tablet_data_column(0) = tablet_dataset.Tables("TABLET_MASTER").Columns(1)
            tablet_dataset.Tables("TABLET_MASTER").PrimaryKey = tablet_data_column
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub

    Public Sub tablet_updatedatabase_master()
        Try
            tablet_command_builder = New OleDbCommandBuilder(tablet_adapter_master)
            tablet_adapter_master.Update(tablet_dataset, "TABLET_MASTER")
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub tablet_filldataset_detail()
        Try
            tablet_adapter_detail = New OleDbDataAdapter("select * from TABLET_DETAIL", tablet_connection)
            tablet_dataset = New DataSet
            tablet_adapter_detail.Fill(tablet_dataset, "TABLET_DETAIL")
            tablet_dataset.Tables("TABLET_DETAIL").Columns(1).Unique = True
            'tablet_dataset.Tables("TABLET_DETAIL").Columns(4).Unique = True
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub tablet_updatedatabase_detail()
        Try
            tablet_command_builder = New OleDbCommandBuilder(tablet_adapter_detail)
            tablet_adapter_detail.Update(tablet_dataset, "TABLET_DETAIL")
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub tablet_filldataset_ingredient()
        Try
            tablet_adapter_ingredient = New OleDbDataAdapter("select * from TABLET_INGREDIENT", tablet_connection)
            tablet_dataset = New DataSet
            tablet_adapter_ingredient.Fill(tablet_dataset, "TABLET_INGREDIENT")
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Public Sub tablet_updatedatabase_ingredient()
        Try
            tablet_command_builder = New OleDbCommandBuilder(tablet_adapter_ingredient)
            tablet_adapter_ingredient.Update(tablet_dataset, "TABLET_INGREDIENT")
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
End Module
