<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class CertificatRP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CertificatRP))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.Text10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Picture1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.Text15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.CertificatDS1 = New MBA.CertificatDS()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me.CertificatDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.XrLabel1, Me.Text14})
        Me.Detail.HeightF = 621.0!
        Me.Detail.Name = "Detail"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!)
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(504.1666!, 435.4166!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(250.8333!, 33.41663!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Segoe UI Light", 14.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(358.3333!, 435.4166!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(131.25!, 33.41666!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "Hussein-Dey le "
        '
        'Text14
        '
        Me.Text14.BackColor = System.Drawing.Color.White
        Me.Text14.BorderColor = System.Drawing.Color.Black
        Me.Text14.CanGrow = False
        Me.Text14.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!)
        Me.Text14.ForeColor = System.Drawing.Color.Black
        Me.Text14.LocationFloat = New DevExpress.Utils.PointFloat(0.9999911!, 7.999992!)
        Me.Text14.Multiline = True
        Me.Text14.Name = "Text14"
        Me.Text14.SizeF = New System.Drawing.SizeF(754.0001!, 258.3333!)
        Me.Text14.StylePriority.UseFont = False
        Me.Text14.Text = resources.GetString("Text14.Text")
        Me.Text14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Certificat", New System.Data.Common.DataColumnMapping(-1) {})})
        '
        'OleDbCommand1
        '
        Me.OleDbCommand1.CommandText = "SELECT * FROM Certificat"
        Me.OleDbCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=CertificatDS"
        '
        'ReportHeader
        '
        Me.ReportHeader.HeightF = 0.0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Text10, Me.Text11, Me.Picture1})
        Me.PageHeader.HeightF = 348.8334!
        Me.PageHeader.Name = "PageHeader"
        '
        'Text10
        '
        Me.Text10.BackColor = System.Drawing.Color.Transparent
        Me.Text10.BorderColor = System.Drawing.Color.Black
        Me.Text10.CanGrow = False
        Me.Text10.Font = New System.Drawing.Font("Segoe UI Semibold", 26.0!, System.Drawing.FontStyle.Underline)
        Me.Text10.ForeColor = System.Drawing.Color.Black
        Me.Text10.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 154.7084!)
        Me.Text10.Multiline = True
        Me.Text10.Name = "Text10"
        Me.Text10.SizeF = New System.Drawing.SizeF(765.0001!, 68.04169!)
        Me.Text10.StylePriority.UseBackColor = False
        Me.Text10.StylePriority.UseFont = False
        Me.Text10.StylePriority.UseTextAlignment = False
        Me.Text10.Text = "" & Global.Microsoft.VisualBasic.ChrW(10) & "CERTIFICAT DE TRAVAIL"
        Me.Text10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text11
        '
        Me.Text11.BackColor = System.Drawing.Color.White
        Me.Text11.BorderColor = System.Drawing.Color.Black
        Me.Text11.CanGrow = False
        Me.Text11.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!)
        Me.Text11.ForeColor = System.Drawing.Color.Black
        Me.Text11.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 254.0!)
        Me.Text11.Multiline = True
        Me.Text11.Name = "Text11"
        Me.Text11.SizeF = New System.Drawing.SizeF(755.0001!, 94.83331!)
        Me.Text11.StylePriority.UseFont = False
        Me.Text11.Text = "Nous soussignés, ALGERIAN INDUSTRIAL EQUIPMENT COMPANY." & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    « ALIECO SPA » (Fil" & _
            "iale ENCC) COTE ROUGE  sise Rue Capitaine" & Global.Microsoft.VisualBasic.ChrW(10) & "AZIOUZ MOUZAOUI  BP.429  Hussein Dey  " & _
            "« Alger »"
        Me.Text11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.Color.White
        Me.Picture1.BorderColor = System.Drawing.Color.Black
        Me.Picture1.Image = CType(resources.GetObject("Picture1.Image"), System.Drawing.Image)
        Me.Picture1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 12.5!)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.SizeF = New System.Drawing.SizeF(755.0001!, 124.5!)
        Me.Picture1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'ReportFooter
        '
        Me.ReportFooter.HeightF = 0.0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Text15})
        Me.PageFooter.HeightF = 105.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'Text15
        '
        Me.Text15.BackColor = System.Drawing.Color.White
        Me.Text15.BorderColor = System.Drawing.Color.Black
        Me.Text15.CanGrow = False
        Me.Text15.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!)
        Me.Text15.ForeColor = System.Drawing.Color.Black
        Me.Text15.LocationFloat = New DevExpress.Utils.PointFloat(0.9999911!, 7.999929!)
        Me.Text15.Multiline = True
        Me.Text15.Name = "Text15"
        Me.Text15.SizeF = New System.Drawing.SizeF(753.9999!, 83.0!)
        Me.Text15.StylePriority.UseFont = False
        Me.Text15.StylePriority.UseTextAlignment = False
        Me.Text15.Text = "Rue du Capitaine AZIOUZ MOUZAOUI" & Global.Microsoft.VisualBasic.ChrW(10) & "B.P. 429 16040 Hussein Dey  Alger - Algérie" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "T" & _
            "él. : (021) 77.67.18  - 77.98.07 - 77.65.25   Tél. /Fax : (021)   77.13.68 - 77." & _
            "52.84"
        Me.Text15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'CertificatDS1
        '
        Me.CertificatDS1.DataSetName = "CertificatDS"
        Me.CertificatDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 16.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 16.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'CertificatRP
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.ReportHeader, Me.PageHeader, Me.ReportFooter, Me.PageFooter, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.DataAdapter = Me.OleDbDataAdapter1
        Me.DataMember = "Certificat"
        Me.DataSource = Me.CertificatDS1
        Me.Margins = New System.Drawing.Printing.Margins(28, 34, 16, 16)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "13.2"
        CType(Me.CertificatDS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents Text14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents Text15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Picture1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CertificatDS1 As MBA.CertificatDS
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
End Class
