Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Public Class sop_report_viewer
    Dim sop_report_adapter As OleDb.OleDbDataAdapter
    Dim sop_report_dataset As DataSet
    Dim sop_report_document As ReportDocument
    Dim sop_report_path As String

    Private Sub sop_report_viewer_DISPOSE(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        Call sop_module.sop_close_connection()
        frm_mdi.Show()
    End Sub
    Private Sub powder_report_viewer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim count As Integer
        Call sop_module.sop_open_connection()
        Call sop_module.sop_fill_dataset_detail()
        For count = 0 To sop_module.sop_dataset.Tables("SOP_DETAIL").Rows.Count - 1
            Me.cmb_product_code.Items.Add(sop_module.sop_dataset.Tables("SOP_DETAIL").Rows(count).Item("Sop_No"))
        Next
    End Sub
    Private Sub btn_go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_go.Click
        Try
            If Me.cmb_product_code.Text <> "" Then
                sop_report_adapter = New OleDb.OleDbDataAdapter("SELECT a.Sop_Name,b.Sop_Count,b.Sop_Supersedes,b.Review_Date,b.Issue_Date,b.Effective_Date from SOP_MASTER a,SOP_DETAIL b where a.Sop_No=b.Sop_No and a.Sop_No=' " & Me.cmb_product_code.Text & "'", sop_module.sop_connection)
                sop_report_dataset = New DataSet
                sop_report_adapter.Fill(sop_report_dataset)
                sop_report_path = "C:\Documents and Settings\Administrator\Desktop\Tablet\Tablet\sop_report.rpt"
                sop_report_document = New ReportDocument
                sop_report_document.Load(sop_report_path)
                sop_report_document.SetDataSource(sop_report_dataset)
                Me.sop_report_view.ReportSource = sop_report_document
            Else
                MsgBox("SELECT SOP Number", MsgBoxStyle.Information, "SOP Report")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Sub cmb_product_code_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_product_code.KeyPress
        If e.KeyChar <> vbBack Then
            e.KeyChar = ""
        End If
    End Sub
End Class