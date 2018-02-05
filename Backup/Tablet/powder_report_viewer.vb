Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Public Class powder_report_viewer
    Dim powder_report_adapter As OleDb.OleDbDataAdapter
    Dim powder_report_dataset As DataSet
    Dim powder_report_document As ReportDocument
    Dim powder_report_path As String

    Private Sub powder_report_viewer_DISPOSE(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        Call POWDER_MODULE.powder_close_connection()
        frm_mdi.Show()
    End Sub
    Private Sub powder_report_viewer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim count As Integer
        Call POWDER_MODULE.powder_open_connection()
        Call POWDER_MODULE.powder_filldataset_master()
        For count = 0 To POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows.Count - 1
            Me.cmb_product_code.Items.Add(POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(count).Item("Powder_Code"))
        Next
        Call POWDER_MODULE.powder_filldataset_detail()
        For count = 0 To POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows.Count - 1
            Me.cmb_batch_no.Items.Add(POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(count).Item("Powder_Batch_No"))
        Next
    End Sub
    Private Sub btn_go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_go.Click
        Try
            If Me.cmb_batch_no.Text <> "" And Me.cmb_product_code.Text <> "" Then
                powder_report_adapter = New OleDb.OleDbDataAdapter("SELECT a.Powder_Name, a.Powder_Batch_Size, a.Powder_Description, a.Powder_Identification, a.Powder_Min_Uniformity_Weight, a.Powder_Max_Uniformity_Weight, a.Powder_Assay, a.Powder_Average_Weight,  a.Powder_Batch_Size_Unit,a.Powder_Min_Bulk_Density,a.Powder_Max_Bulk_Density,a.Powder_Fine_Ness, b.Powder_Batch_No, b.Powder_Sample_Quantity1, b.Powder_Sample_Quantity2, b.Powder_Sample_Quantity1_Unit, b.Powder_Sample_Quantity2_Unit, b.Powder_A_R_No, b.Powder_Manufacturing_Date, b.Powder_Expiry_Date,  b.Powder_Min_Uniformity_Weight,b.Powder_Max_Uniformity_Weight, b.Powder_Average_Weight, b.Powder_Fine_Ness,b.Powder_Bulk_Density,b.Powder_Released_Date, b.Powder_Received_Date, b.Powder_Identification, b.Powder_Specification_No, b.Powder_Description, c.Powder_Ingredient_Name, c.Powder_Label_Claim, c.Powder_Min_Limit, c.Powder_Max_Limit,c.Powder_Min_Limit_Percentage,c.Powder_Max_Limit_Percentage, c.Powder_Unit, c.Powder_Found, c.Powder_Percentage_Label_Claim FROM POWDER_MASTER AS a, POWDER_DETAIL AS b, POWDER_INGREDIENT AS c WHERE a.Powder_Code=b.Powder_Code and b.Powder_Batch_No = c.Powder_Batch_No And a.Powder_Code = '" & Me.cmb_product_code.Text & "' and b.Powder_Batch_No='" & Me.cmb_batch_no.Text & "'", POWDER_MODULE.powder_connection)
                powder_report_dataset = New DataSet
                powder_report_adapter.Fill(powder_report_dataset)
                powder_report_path = "C:\Documents and Settings\Administrator\Desktop\Tablet\Tablet\powder_report.rpt"
                powder_report_document = New ReportDocument
                powder_report_document.Load(powder_report_path)
                powder_report_document.SetDataSource(powder_report_dataset)
                Me.powder_report_view.ReportSource = powder_report_document
            Else
                MsgBox("SELECT BOTH THE BATCH NO AS WELL AS PRODUCT CODE", MsgBoxStyle.Information, "Powder Report")
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