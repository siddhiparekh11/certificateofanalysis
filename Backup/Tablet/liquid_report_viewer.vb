Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Public Class liquid_report_viewer
    Dim liquid_report_adapter As OleDb.OleDbDataAdapter
    Dim liquid_report_dataset As DataSet
    Dim liquid_report_document As ReportDocument
    Dim liquid_report_path As String
    Private Sub liquid_report_viewer_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Call LIQUID_MODULE.liquid_close_connection()
        frm_mdi.Show()
    End Sub
    Private Sub liquid_report_viewer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim count As Integer
        Call LIQUID_MODULE.liquid_open_connection()
        Call LIQUID_MODULE.liquid_filldataset_master()
        For count = 0 To LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows.Count - 1
            Me.cmb_product_code.Items.Add(LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(count).Item("Liquid_Code"))
        Next
        Call LIQUID_MODULE.liquid_filldataset_detail()
        For count = 0 To LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows.Count - 1
            Me.cmb_batch_no.Items.Add(LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(count).Item("Liquid_Batch_No"))
        Next
    End Sub
    Private Sub btn_go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_go.Click
        Try
            If Me.cmb_batch_no.Text <> "" And Me.cmb_product_code.Text <> "" Then
                liquid_report_adapter = New OleDb.OleDbDataAdapter("SELECT a.Liquid_Name, a.Liquid_Batch_Size, a.Liquid_Description, a.Liquid_Identification, a.Liquid_Min_Ph, a.Liquid_Max_Ph, a.Liquid_Assay, a.Liquid_Average_Volume, a.Liquid_Min_Uniformity_Volume, a.Liquid_Max_Uniformity_Volume, a.Liquid_Min_Weight, a.Liquid_Batch_Size_Unit, a.Liquid_Max_Weight, b.Liquid_Batch_No, b.Liquid_Sample_Quantity1, b.Liquid_Sample_Quantity2, b.Liquid_Sample_Quantity1_Unit, b.Liquid_Sample_Quantity2_Unit, b.Liquid_A_R_No, b.Liquid_Manufacturing_Date, b.Liquid_Expiry_Date, b.Liquid_Min_Uniformity, b.Liquid_Max_Uniformity, b.Liquid_Ph, b.Liquid_Weight, b.Liquid_Average, b.Liquid_Released_Date, b.Liquid_Received_Date, b.Liquid_Identification, b.Liquid_Specification_No, b.Liquid_Description, c.Liquid_Ingredient_Name, c.Liquid_Label_Claim, c.Liquid_Limit, c.Liquid_Limit_Percentage, c.Liquid_Unit, c.Liquid_Found, c.Liquid_Percentage_Label_Claim FROM LIQUID_MASTER AS a, LIQUID_DETAIL AS b, LIQUID_INGREDIENT AS c WHERE a.Liquid_Code=b.Liquid_Code and b.Liquid_Batch_No = c.Liquid_Batch_No And a.Liquid_Code = '" & Me.cmb_product_code.Text & "' and b.Liquid_Batch_No='" & Me.cmb_batch_no.Text & "'", LIQUID_MODULE.liquid_connection)
                liquid_report_dataset = New DataSet
                liquid_report_adapter.Fill(liquid_report_dataset)
                liquid_report_path = "C:\Documents and Settings\Administrator\Desktop\Tablet\Tablet\liquid_report.rpt"
                liquid_report_document = New ReportDocument
                liquid_report_document.Load(liquid_report_path)
                liquid_report_document.SetDataSource(liquid_report_dataset)
                Me.liquid_report_view.ReportSource = liquid_report_document
            Else
                MsgBox("SELECT BOTH THE BATCH NO AS WELL AS PRODUCT CODE", MsgBoxStyle.Information, "Liquid Report")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Sub cmb_batch_no_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_batch_no.KeyPress
        If e.KeyChar <> vbBack Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub cmb_product_code_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_product_code.KeyPress
        If e.KeyChar <> vbBack Then
            e.KeyChar = ""
        End If
    End Sub
End Class