<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statistiques
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title4 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim PieSeriesLabel1 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
        Dim PiePointOptions1 As DevExpress.XtraCharts.PiePointOptions = New DevExpress.XtraCharts.PiePointOptions()
        Dim PieSeriesView1 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim SplineSeriesView1 As DevExpress.XtraCharts.SplineSeriesView = New DevExpress.XtraCharts.SplineSeriesView()
        Dim RadarLineSeriesView1 As DevExpress.XtraCharts.RadarLineSeriesView = New DevExpress.XtraCharts.RadarLineSeriesView()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart4 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ChartControl2 = New DevExpress.XtraCharts.ChartControl()
        Me.ChartControl3 = New DevExpress.XtraCharts.ChartControl()
        Me.ChartControl4 = New DevExpress.XtraCharts.ChartControl()
        Me.ChartControl5 = New DevExpress.XtraCharts.ChartControl()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SplineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RadarLineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart2
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend1)
        Me.Chart2.Location = New System.Drawing.Point(1020, 19)
        Me.Chart2.Name = "Chart2"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Sexe"
        Me.Chart2.Series.Add(Series1)
        Me.Chart2.Size = New System.Drawing.Size(15, 12)
        Me.Chart2.TabIndex = 2
        Me.Chart2.Text = "Chart2"
        Title1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.Text = "Répartition par Sexe"
        Me.Chart2.Titles.Add(Title1)
        Me.Chart2.Visible = False
        '
        'Chart3
        '
        Me.Chart3.BorderlineWidth = 2
        ChartArea2.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend2)
        Me.Chart3.Location = New System.Drawing.Point(1022, 338)
        Me.Chart3.Name = "Chart3"
        Me.Chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire
        Series2.BorderWidth = 2
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Color = System.Drawing.Color.Gold
        Series2.Legend = "Legend1"
        Series2.Name = "Tranche Age"
        Series2.YValuesPerPoint = 2
        Me.Chart3.Series.Add(Series2)
        Me.Chart3.Size = New System.Drawing.Size(24, 18)
        Me.Chart3.TabIndex = 3
        Me.Chart3.Text = "Chart3"
        Title2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.Name = "Title1"
        Title2.Text = "Répartition par tranche d'age"
        Me.Chart3.Titles.Add(Title2)
        Me.Chart3.Visible = False
        '
        'Chart1
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(1022, 131)
        Me.Chart1.Name = "Chart1"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Situation Administratif"
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(13, 10)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        Title3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title3.Name = "Title1"
        Title3.Text = "Situation administrative"
        Me.Chart1.Titles.Add(Title3)
        Me.Chart1.Visible = False
        '
        'Chart4
        '
        ChartArea4.Name = "ChartArea1"
        Me.Chart4.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.Chart4.Legends.Add(Legend4)
        Me.Chart4.Location = New System.Drawing.Point(1027, 364)
        Me.Chart4.Name = "Chart4"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar
        Series4.Legend = "Legend1"
        Series4.Name = "Répartition par salaire"
        Series4.YValuesPerPoint = 2
        Me.Chart4.Series.Add(Series4)
        Me.Chart4.Size = New System.Drawing.Size(19, 28)
        Me.Chart4.TabIndex = 5
        Me.Chart4.Text = "Chart4"
        Title4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title4.Name = "Title1"
        Title4.Text = "Répartition par salaire"
        Me.Chart4.Titles.Add(Title4)
        Me.Chart4.Visible = False
        '
        'ChartControl2
        '
        Me.ChartControl2.Location = New System.Drawing.Point(12, 19)
        Me.ChartControl2.Name = "ChartControl2"
        Me.ChartControl2.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl2.Size = New System.Drawing.Size(531, 314)
        Me.ChartControl2.TabIndex = 7
        '
        'ChartControl3
        '
        Me.ChartControl3.Location = New System.Drawing.Point(569, 19)
        Me.ChartControl3.Name = "ChartControl3"
        Me.ChartControl3.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        PiePointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General
        PieSeriesLabel1.PointOptions = PiePointOptions1
        Me.ChartControl3.SeriesTemplate.Label = PieSeriesLabel1
        PieSeriesView1.RuntimeExploding = False
        Me.ChartControl3.SeriesTemplate.View = PieSeriesView1
        Me.ChartControl3.Size = New System.Drawing.Size(445, 314)
        Me.ChartControl3.TabIndex = 8
        '
        'ChartControl4
        '
        Me.ChartControl4.Location = New System.Drawing.Point(12, 350)
        Me.ChartControl4.Name = "ChartControl4"
        Me.ChartControl4.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl4.SeriesTemplate.View = SplineSeriesView1
        Me.ChartControl4.Size = New System.Drawing.Size(531, 300)
        Me.ChartControl4.TabIndex = 9
        '
        'ChartControl5
        '
        Me.ChartControl5.Location = New System.Drawing.Point(569, 350)
        Me.ChartControl5.Name = "ChartControl5"
        Me.ChartControl5.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl5.SeriesTemplate.View = RadarLineSeriesView1
        Me.ChartControl5.Size = New System.Drawing.Size(445, 300)
        Me.ChartControl5.TabIndex = 10
        '
        'Statistiques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 695)
        Me.Controls.Add(Me.ChartControl5)
        Me.Controls.Add(Me.ChartControl4)
        Me.Controls.Add(Me.ChartControl3)
        Me.Controls.Add(Me.ChartControl2)
        Me.Controls.Add(Me.Chart4)
        Me.Controls.Add(Me.Chart3)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Statistiques"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Statistiques"
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SplineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RadarLineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart3 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart4 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents ChartControl2 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents ChartControl3 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents ChartControl4 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents ChartControl5 As DevExpress.XtraCharts.ChartControl
End Class
