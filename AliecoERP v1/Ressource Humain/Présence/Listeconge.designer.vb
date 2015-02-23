<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listeconge
    Inherits DevComponents.DotNetBar.OfficeForm

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
        Me.CDGV = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ChargerLesCongésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExporterLeResultatEnExcel2010xslxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExporterEnPDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.CDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CDGV
        '
        Me.CDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CDGV.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CDGV.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CDGV.Location = New System.Drawing.Point(0, 27)
        Me.CDGV.LookAndFeel.SkinName = "Office 2013"
        Me.CDGV.LookAndFeel.UseDefaultLookAndFeel = False
        Me.CDGV.MainView = Me.GridView1
        Me.CDGV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CDGV.Name = "CDGV"
        Me.CDGV.Size = New System.Drawing.Size(1660, 802)
        Me.CDGV.TabIndex = 0
        Me.CDGV.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.CDGV
        Me.GridView1.Name = "GridView1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChargerLesCongésToolStripMenuItem, Me.ExporterLeResultatEnExcel2010xslxToolStripMenuItem, Me.ExporterEnPDFToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1660, 27)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ChargerLesCongésToolStripMenuItem
        '
        Me.ChargerLesCongésToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.account_book
        Me.ChargerLesCongésToolStripMenuItem.Name = "ChargerLesCongésToolStripMenuItem"
        Me.ChargerLesCongésToolStripMenuItem.Size = New System.Drawing.Size(163, 21)
        Me.ChargerLesCongésToolStripMenuItem.Text = "  Charger les Congés   "
        '
        'ExporterLeResultatEnExcel2010xslxToolStripMenuItem
        '
        Me.ExporterLeResultatEnExcel2010xslxToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.Excel_2013
        Me.ExporterLeResultatEnExcel2010xslxToolStripMenuItem.Name = "ExporterLeResultatEnExcel2010xslxToolStripMenuItem"
        Me.ExporterLeResultatEnExcel2010xslxToolStripMenuItem.Size = New System.Drawing.Size(187, 21)
        Me.ExporterLeResultatEnExcel2010xslxToolStripMenuItem.Text = "  Exporter en Excel 2010    "
        '
        'ExporterEnPDFToolStripMenuItem
        '
        Me.ExporterEnPDFToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.pdf18
        Me.ExporterEnPDFToolStripMenuItem.Name = "ExporterEnPDFToolStripMenuItem"
        Me.ExporterEnPDFToolStripMenuItem.Size = New System.Drawing.Size(133, 21)
        Me.ExporterEnPDFToolStripMenuItem.Text = "  Exporter en PDF"
        '
        'Listeconge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1660, 829)
        Me.Controls.Add(Me.CDGV)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Listeconge"
        Me.ShowIcon = False
        Me.Text = "                                                                                 " & _
            "              Liste de congé"
        CType(Me.CDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CDGV As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ChargerLesCongésToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExporterLeResultatEnExcel2010xslxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExporterEnPDFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
