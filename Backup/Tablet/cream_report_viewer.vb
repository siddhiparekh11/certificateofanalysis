Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Public Class cream_report_viewer
    Dim cream_report_adapter As OleDb.OleDbDataAdapter
    Dim cream_report_dataset As DataSet
    Dim cream_report_document As ReportDocument
    Dim cream_report_path As String
    Private Sub cream_report_viewer_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Call CREAM_MODULE.cream_close_connection()
        frm_mdi.Show()
    End Sub
    Private Sub cream_report_viewer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim count As Integer
        Call CREAM_MODULE.cream_open_connection()
        Call CREAM_MODULE.cream_filldataset_master()
        For count = 0 To CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows.Count - 1
            Me.cmb_product_code.Items.Add(CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(count).Item("Cream_Code"))
        Next
        Call CREAM_MODULE.cream_filldataset_detail()
        For count = 0 To CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows.Count - 1
            Me.cmb_batch_no.Items.Add(CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(count).Item("Cream_Batch_No"))
        Next
    End Sub
    Private Sub btn_go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_go.Click
        Try
            If Me.cmb_batch_no.Text <> "" And Me.cmb_product_code.Text <> "" Then
                cream_report_adapter = New OleDb.OleDbDataAdapter("SELECT a.Cream_Name, a.Cream_Batch_Size, a.Cream_Description, a.Cream_Identification, a.Cream_Min_Uniformity_Weight, a.Cream_Max_Uniformity_Weight, a.Cream_Assay, a.Cream_Average_Weight,  a.Cream_Batch_Size_Unit, b.Cream_Batch_No, b.Cream_Sample_Quantity1, b.Cream_Sample_Quantity2, b.Cream_Sample_Quantity1_Unit, b.Cream_Sample_Quantity2_Unit, b.Cream_A_R_No, b.Cream_Manufacturing_Date, b.Cream_Expiry_Date,  b.Cream_Uniformity_Weight, b.Cream_Average_Weight, b.Cream_Released_Date, b.Cream_Received_Date, b.Cream_Identification, b.Cream_Specification_No, b.Cream_Description, c.Cream_Ingredient_Name, c.Cream_Label_Claim, c.Cream_Min_Limit, c.Cream_Max_Limit,c.Cream_Min_Limit_Percentage,c.Cream_Max_Limit_Percentage, c.Cream_Unit, c.Cream_Found, c.Cream_Percentage_Label_Claim FROM CREAM_MASTER AS a, CREAM_DETAIL AS b, CREAM_INGREDIENT AS c WHERE a.Cream_Code=b.Cream_Code and b.Cream_Batch_No = c.Cream_Batch_No And a.Cream_Code = '" & Me.cmb_product_code.Text & "' and b.Cream_Batch_No='" & Me.cmb_batch_no.Text & "'", CREAM_MODULE.cream_connection)
                cream_report_dataset = New DataSet
                cream_report_adapter.Fill(cream_report_dataset)
                cream_report_path = "C:\Documents and Settings\Administrator\Desktop\Tablet\Tablet\cream_report.rpt"
                cream_report_document = New ReportDocument
                cream_report_document.Load(cream_report_path)
                cream_report_document.SetDataSource(cream_report_dataset)
                Me.cream_report_view.ReportSource = cream_report_document
            Else
                MsgBox("SELECT BOTH THE BATCH NO AS WELL AS PRODUCT CODE", MsgBoxStyle.Information, "Cream Report")
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