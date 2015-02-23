<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listVihecule
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SearchTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.linkControl6 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ViheculeImg = New DevExpress.XtraEditors.PictureEdit()
        Me.GridVihecules = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModifierCeVihéculeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerCeVihéculeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ViheculeImg.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridVihecules, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.SearchTxt)
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1047, 60)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "rechercher un vihécule :"
        '
        'SearchTxt
        '
        Me.SearchTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.SearchTxt.Border.Class = "TextBoxBorder"
        Me.SearchTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SearchTxt.ForeColor = System.Drawing.Color.Black
        Me.SearchTxt.Location = New System.Drawing.Point(12, 22)
        Me.SearchTxt.Name = "SearchTxt"
        Me.SearchTxt.Size = New System.Drawing.Size(826, 23)
        Me.SearchTxt.TabIndex = 389
        Me.SearchTxt.WatermarkText = "<b>nom</b> ou <b>matricule</b> d vihécule..."
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.MBA.My.Resources.Resources.table_save
        Me.ButtonX1.Location = New System.Drawing.Point(844, 22)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(151, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 381
        Me.ButtonX1.Text = "Exporter la liste"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.ForeColor = System.Drawing.Color.Black
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 60)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel1.ForeColor = System.Drawing.Color.Black
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.SplitContainer1.Panel2.Controls.Add(Me.GridVihecules)
        Me.SplitContainer1.Panel2.ForeColor = System.Drawing.Color.Black
        Me.SplitContainer1.Size = New System.Drawing.Size(1047, 451)
        Me.SplitContainer1.SplitterDistance = 225
        Me.SplitContainer1.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.linkControl6)
        Me.GroupBox2.Controls.Add(Me.LabelControl6)
        Me.GroupBox2.Controls.Add(Me.LabelControl5)
        Me.GroupBox2.Controls.Add(Me.LabelControl4)
        Me.GroupBox2.Controls.Add(Me.LabelControl3)
        Me.GroupBox2.Controls.Add(Me.LabelControl2)
        Me.GroupBox2.Controls.Add(Me.LabelControl1)
        Me.GroupBox2.Controls.Add(Me.ViheculeImg)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(225, 451)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informations :"
        '
        'linkControl6
        '
        Me.linkControl6.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.linkControl6.Border.Class = "TextBoxBorder"
        Me.linkControl6.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.linkControl6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.linkControl6.ForeColor = System.Drawing.Color.Black
        Me.linkControl6.Location = New System.Drawing.Point(3, 330)
        Me.linkControl6.Multiline = True
        Me.linkControl6.Name = "linkControl6"
        Me.linkControl6.Size = New System.Drawing.Size(219, 118)
        Me.linkControl6.TabIndex = 7
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl6.Location = New System.Drawing.Point(6, 308)
        Me.LabelControl6.LookAndFeel.SkinName = "Office 2013"
        Me.LabelControl6.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl6.TabIndex = 6
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl5.Location = New System.Drawing.Point(6, 289)
        Me.LabelControl5.LookAndFeel.SkinName = "Office 2013"
        Me.LabelControl5.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(0, 15)
        Me.LabelControl5.TabIndex = 5
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl4.Location = New System.Drawing.Point(6, 269)
        Me.LabelControl4.LookAndFeel.SkinName = "Office 2013"
        Me.LabelControl4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(0, 15)
        Me.LabelControl4.TabIndex = 4
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl3.Location = New System.Drawing.Point(6, 250)
        Me.LabelControl3.LookAndFeel.SkinName = "Office 2013"
        Me.LabelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(0, 15)
        Me.LabelControl3.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl2.Location = New System.Drawing.Point(6, 231)
        Me.LabelControl2.LookAndFeel.SkinName = "Office 2013"
        Me.LabelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(0, 15)
        Me.LabelControl2.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl1.Location = New System.Drawing.Point(6, 212)
        Me.LabelControl1.LookAndFeel.SkinName = "Office 2013"
        Me.LabelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(0, 15)
        Me.LabelControl1.TabIndex = 1
        '
        'ViheculeImg
        '
        Me.ViheculeImg.Dock = System.Windows.Forms.DockStyle.Top
        Me.ViheculeImg.Location = New System.Drawing.Point(3, 19)
        Me.ViheculeImg.Name = "ViheculeImg"
        Me.ViheculeImg.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.ViheculeImg.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ViheculeImg.Properties.Appearance.Options.UseBackColor = True
        Me.ViheculeImg.Properties.Appearance.Options.UseForeColor = True
        Me.ViheculeImg.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.ViheculeImg.Size = New System.Drawing.Size(219, 174)
        Me.ViheculeImg.TabIndex = 0
        '
        'GridVihecules
        '
        Me.GridVihecules.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridVihecules.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridVihecules.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White
        Me.GridVihecules.EmbeddedNavigator.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GridVihecules.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.GridVihecules.EmbeddedNavigator.Appearance.Options.UseForeColor = True
        Me.GridVihecules.Location = New System.Drawing.Point(0, 0)
        Me.GridVihecules.LookAndFeel.SkinName = "Office 2013"
        Me.GridVihecules.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridVihecules.MainView = Me.GridView1
        Me.GridVihecules.Name = "GridVihecules"
        Me.GridVihecules.Size = New System.Drawing.Size(818, 451)
        Me.GridVihecules.TabIndex = 3
        Me.GridVihecules.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModifierCeVihéculeToolStripMenuItem, Me.SupprimerCeVihéculeToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(204, 48)
        '
        'ModifierCeVihéculeToolStripMenuItem
        '
        Me.ModifierCeVihéculeToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.edit
        Me.ModifierCeVihéculeToolStripMenuItem.Name = "ModifierCeVihéculeToolStripMenuItem"
        Me.ModifierCeVihéculeToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ModifierCeVihéculeToolStripMenuItem.Text = "  Modifier ce vihécule   "
        '
        'SupprimerCeVihéculeToolStripMenuItem
        '
        Me.SupprimerCeVihéculeToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.delete
        Me.SupprimerCeVihéculeToolStripMenuItem.Name = "SupprimerCeVihéculeToolStripMenuItem"
        Me.SupprimerCeVihéculeToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.SupprimerCeVihéculeToolStripMenuItem.Text = "  Supprimer ce vihécule  "
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridVihecules
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'listVihecule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 511)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "listVihecule"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste des vihécules"
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ViheculeImg.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridVihecules, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SearchTxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridVihecules As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ViheculeImg As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents linkControl6 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ModifierCeVihéculeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerCeVihéculeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
