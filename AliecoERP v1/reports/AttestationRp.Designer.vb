<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class AttestationRp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AttestationRp))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.Text3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.Text11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Text10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Picture1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.Text13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.AttestationDS1 = New MBA.AttestationDS()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me.AttestationDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.Text3, Me.Text12})
        Me.Detail.HeightF = 363.0!
        Me.Detail.Name = "Detail"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPageInfo1.Format = "{0:dddd d MMMM yyyy}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(554.2083!, 308.0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(240.7917!, 29.99997!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        '
        'Text3
        '
        Me.Text3.BackColor = System.Drawing.Color.White
        Me.Text3.BorderColor = System.Drawing.Color.Black
        Me.Text3.CanGrow = False
        Me.Text3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!)
        Me.Text3.ForeColor = System.Drawing.Color.Black
        Me.Text3.LocationFloat = New DevExpress.Utils.PointFloat(1.999998!, 20.00001!)
        Me.Text3.Multiline = True
        Me.Text3.Name = "Text3"
        Me.Text3.SizeF = New System.Drawing.SizeF(797.0001!, 213.0!)
        Me.Text3.StylePriority.UseFont = False
        Me.Text3.Text = resources.GetString("Text3.Text")
        Me.Text3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Text12
        '
        Me.Text12.BackColor = System.Drawing.Color.White
        Me.Text12.BorderColor = System.Drawing.Color.Black
        Me.Text12.CanGrow = False
        Me.Text12.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Underline)
        Me.Text12.ForeColor = System.Drawing.Color.Black
        Me.Text12.LocationFloat = New DevExpress.Utils.PointFloat(350.7083!, 308.0!)
        Me.Text12.Name = "Text12"
        Me.Text12.SizeF = New System.Drawing.SizeF(187.875!, 29.99997!)
        Me.Text12.Text = "Fait à Hussein Dey,  Le "
        Me.Text12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.HeightF = 0.0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Text11, Me.Text10, Me.Picture1})
        Me.PageHeader.HeightF = 462.6667!
        Me.PageHeader.Name = "PageHeader"
        '
        'Text11
        '
        Me.Text11.BackColor = System.Drawing.Color.White
        Me.Text11.BorderColor = System.Drawing.Color.Black
        Me.Text11.CanGrow = False
        Me.Text11.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!)
        Me.Text11.ForeColor = System.Drawing.Color.Black
        Me.Text11.LocationFloat = New DevExpress.Utils.PointFloat(1.999998!, 287.5!)
        Me.Text11.Multiline = True
        Me.Text11.Name = "Text11"
        Me.Text11.SizeF = New System.Drawing.SizeF(797.0001!, 94.83334!)
        Me.Text11.StylePriority.UseFont = False
        Me.Text11.Text = "Nous soussignés, ALGERIAN INDUSTRIAL EQUIPMENT COMPANY." & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    « ALIECO SPA » (Fil" & _
            "iale ENCC) COTE ROUGE  sise Rue Capitaine" & Global.Microsoft.VisualBasic.ChrW(10) & "AZIOUZ MOUZAOUI  BP.429  Hussein Dey  " & _
            "« Alger » attestons que :" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Text11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Text10
        '
        Me.Text10.BackColor = System.Drawing.Color.White
        Me.Text10.BorderColor = System.Drawing.Color.Black
        Me.Text10.CanGrow = False
        Me.Text10.Font = New System.Drawing.Font("Segoe UI Semibold", 26.0!, System.Drawing.FontStyle.Underline)
        Me.Text10.ForeColor = System.Drawing.Color.Black
        Me.Text10.LocationFloat = New DevExpress.Utils.PointFloat(1.999998!, 170.5!)
        Me.Text10.Multiline = True
        Me.Text10.Name = "Text10"
        Me.Text10.SizeF = New System.Drawing.SizeF(797.0001!, 53.83331!)
        Me.Text10.StylePriority.UseFont = False
        Me.Text10.StylePriority.UseTextAlignment = False
        Me.Text10.Text = "ATTESTATION DE TRAVAIL" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Text10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.Color.White
        Me.Picture1.BorderColor = System.Drawing.Color.Black
        Me.Picture1.Image = CType(resources.GetObject("Picture1.Image"), System.Drawing.Image)
        Me.Picture1.LocationFloat = New DevExpress.Utils.PointFloat(1.999998!, 0.0!)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.SizeF = New System.Drawing.SizeF(797.0001!, 127.0833!)
        Me.Picture1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'ReportFooter
        '
        Me.ReportFooter.HeightF = 15.0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Text13})
        Me.PageFooter.HeightF = 95.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'Text13
        '
        Me.Text13.BackColor = System.Drawing.Color.White
        Me.Text13.BorderColor = System.Drawing.Color.Black
        Me.Text13.CanGrow = False
        Me.Text13.Font = New System.Drawing.Font("Segoe UI Light", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Text13.ForeColor = System.Drawing.Color.Black
        Me.Text13.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 7.999992!)
        Me.Text13.Name = "Text13"
        Me.Text13.SizeF = New System.Drawing.SizeF(789.0001!, 66.0!)
        Me.Text13.Text = "Rue du Capitaine AZIOUZ MOUZAOUI" & Global.Microsoft.VisualBasic.ChrW(10) & "B.P. 429 16040 Hussein Dey  Alger - Algérie" & Global.Microsoft.VisualBasic.ChrW(10) & "Tél." & _
            " : (021) 77.67.18  - 77.98.07  - 77.65.25   Tél. /Fax : (021)   77.13.68 - 77.52" & _
            ".84" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Text13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'AttestationDS1
        '
        Me.AttestationDS1.DataSetName = "AttestationDS"
        Me.AttestationDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'AttestationRp
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.ReportHeader, Me.PageHeader, Me.ReportFooter, Me.PageFooter, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.DataMember = "AttestationTB"
        Me.DataSource = Me.AttestationDS1
        Me.Margins = New System.Drawing.Printing.Margins(11, 11, 11, 11)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "13.2"
        CType(Me.AttestationDS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents Text3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents Text11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Text10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Picture1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents Text13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents AttestationDS1 As MBA.AttestationDS
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
End Class
