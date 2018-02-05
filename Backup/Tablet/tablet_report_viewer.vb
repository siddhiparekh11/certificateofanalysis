Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Public Class tablet_report_viewer
    Dim tablet_report_adapter As OleDb.OleDbDataAdapter
    Dim tablet_report_dataset As DataSet
    Dim tablet_report_document As ReportDocument
    Dim tablet_report_path As String
    Private Sub tablet_report_viewer_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Call TABLET_MODULE.tablet_close_connection()
        frm_mdi.Show()
    End Sub
    Private Sub tablet_report_viewer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim count As Integer
        Call TABLET_MODULE.tablet_open_connection()
        Call TABLET_MODULE.tablet_filldataset_master()
        For count = 0 To TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows.Count - 1
            Me.cmb_product_code.Items.Add(TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(count).Item("Tablet_Code"))
        Next
        Call TABLET_MODULE.tablet_filldataset_detail()
        For count = 0 To TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows.Count - 1
            Me.cmb_batch_no.Items.Add(TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(count).Item("Tablet_Batch_No"))
        Next
    End Sub
    Private Sub btn_go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_go.Click
        Try
            If Me.cmb_batch_no.Text <> "" And Me.cmb_product_code.Text <> "" Then
                tablet_report_adapter = New OleDb.OleDbDataAdapter("SELECT a.Tablet_Name, a.Tablet_Batch_Size, a.Tablet_Description, a.Tablet_Identification, a.Tablet_Disintegration_Time, a.Tablet_Dissolution, a.Tablet_Assay, a.Tablet_Average_Weight, a.Tablet_Average_Weight_Range, a.Tablet_Uniformity, a.Tablet_Batch_Size_Unit, b.Tablet_Batch_No, b.Tablet_Sample_Quantity1, b.Tablet_Sample_Quantity2, b.Tablet_Sample_Quantity1_Unit, b.Tablet_Sample_Quantity2_Unit, b.Tablet_A_R_No, b.Tablet_Manufacturing_Date, b.Tablet_Expiry_Date, b.Tablet_Min_Uniformity, b.Tablet_Max_Uniformity, b.Tablet_Max_Dissolution, b.Tablet_Min_Dissolution, b.Tablet_Average, b.Tablet_Disintegration_Time, b.Tablet_Released_Date, b.Tablet_Received_Date, b.Tablet_Identification, b.Tablet_Specification_No, b.Tablet_Description, c.Tablet_Ingredient_Name, c.Tablet_Label_Claim, c.Tablet_Min_Limit, c.Tablet_Max_Limit, c.Tablet_Max_Limit_Percentage, c.Tablet_Min_Limit_Percentage, c.Tablet_Unit, c.Tablet_Found, c.Tablet_Percentage_Label_Claim FROM TABLET_MASTER AS a, TABLET_DETAIL AS b, TABLET_INGREDIENT AS c WHERE a.Tablet_Code = b.Tablet_Code and b.Tablet_Batch_No = c.Tablet_Batch_No And a.Tablet_Code ='" & Me.cmb_product_code.Text & "' and b.Tablet_Batch_No = '" & Me.cmb_batch_no.Text & "'", TABLET_MODULE.tablet_connection)
                tablet_report_dataset = New DataSet
                tablet_report_adapter.Fill(tablet_report_dataset)
                tablet_report_path = "C:\Documents and Settings\Administrator\Desktop\Tablet\Tablet\tablet_report.rpt"
                tablet_report_document = New ReportDocument
                tablet_report_document.Load(tablet_report_path)
                tablet_report_document.SetDataSource(tablet_report_dataset)
                Me.tablet_report_view.ReportSource = tablet_report_document
            Else
                MsgBox("SELECT BOTH THE BATCH NO AS WELL AS PRODUCT CODE", MsgBoxStyle.Information, "Tablet Report")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information)
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
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class