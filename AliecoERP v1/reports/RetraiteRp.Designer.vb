<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RetraiteRp
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RetraiteRp))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.Text1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.Picture1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.RetraiteDSt1 = New MBA.RetraiteDSt()
        CType(Me.RetraiteDSt1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Text1})
        Me.Detail.HeightF = 4076.0!
        Me.Detail.Name = "Detail"
        '
        'Text1
        '
        Me.Text1.BackColor = System.Drawing.Color.White
        Me.Text1.BorderColor = System.Drawing.Color.Black
        Me.Text1.CanGrow = False
        Me.Text1.Font = New System.Drawing.Font("Segoe UI Light", 18.0!)
        Me.Text1.ForeColor = System.Drawing.Color.Black
        Me.Text1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.Text1.Multiline = True
        Me.Text1.Name = "Text1"
        Me.Text1.SizeF = New System.Drawing.SizeF(800.0!, 4041.0!)
        Me.Text1.StylePriority.UseFont = False
        Me.Text1.Text = resources.GetString("Text1.Text")
        Me.Text1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "retraiteTB", New System.Data.Common.DataColumnMapping(-1) {})})
        '
        'OleDbCommand1
        '
        Me.OleDbCommand1.CommandText = "SELECT * FROM retraiteTB"
        Me.OleDbCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RetraiteDSt"
        '
        'ReportHeader
        '
        Me.ReportHeader.HeightF = 0.0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Picture1})
        Me.PageHeader.HeightF = 161.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.Color.White
        Me.Picture1.BorderColor = System.Drawing.Color.Black
        Me.Picture1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 8.0!)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.SizeF = New System.Drawing.SizeF(796.0!, 136.0!)
        '
        'ReportFooter
        '
        Me.ReportFooter.HeightF = 41.0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 41.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 11.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 11.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'RetraiteDSt1
        '
        Me.RetraiteDSt1.DataSetName = "RetraiteDSt"
        Me.RetraiteDSt1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RetraiteRp
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.ReportHeader, Me.PageHeader, Me.ReportFooter, Me.PageFooter, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.DataAdapter = Me.OleDbDataAdapter1
        Me.DataMember = "retraiteTB"
        Me.DataSource = Me.RetraiteDSt1
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(11, 11, 11, 11)
        Me.PageHeight = 1098
        Me.PageWidth = 847
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "13.2"
        CType(Me.RetraiteDSt1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents Text1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents Picture1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents RetraiteDSt1 As MBA.RetraiteDSt
End Class
