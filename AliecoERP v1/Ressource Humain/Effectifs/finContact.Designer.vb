<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class finContact
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.confirmationMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ConfirmerCetteEmployéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ColorCombControl4 = New DevComponents.DotNetBar.ColorPickers.ColorCombControl()
        Me.ColorCombControl3 = New DevComponents.DotNetBar.ColorPickers.ColorCombControl()
        Me.ColorCombControl2 = New DevComponents.DotNetBar.ColorPickers.ColorCombControl()
        Me.ColorCombControl1 = New DevComponents.DotNetBar.ColorPickers.ColorCombControl()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.confirmationMenu.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.confirmationMenu
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 76)
        Me.GridControl1.LookAndFeel.SkinName = "Office 2013"
        Me.GridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(943, 395)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'confirmationMenu
        '
        Me.confirmationMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfirmerCetteEmployéToolStripMenuItem})
        Me.confirmationMenu.Name = "confirmationMenu"
        Me.confirmationMenu.Size = New System.Drawing.Size(219, 26)
        '
        'ConfirmerCetteEmployéToolStripMenuItem
        '
        Me.ConfirmerCetteEmployéToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.contract_ok21
        Me.ConfirmerCetteEmployéToolStripMenuItem.Name = "ConfirmerCetteEmployéToolStripMenuItem"
        Me.ConfirmerCetteEmployéToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.ConfirmerCetteEmployéToolStripMenuItem.Text = "  Confirmer cette employé  "
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ColorCombControl4)
        Me.GroupBox1.Controls.Add(Me.ColorCombControl3)
        Me.GroupBox1.Controls.Add(Me.ColorCombControl2)
        Me.GroupBox1.Controls.Add(Me.ColorCombControl1)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(943, 76)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Infos"
        '
        'ColorCombControl4
        '
        Me.ColorCombControl4.Location = New System.Drawing.Point(439, 32)
        Me.ColorCombControl4.Name = "ColorCombControl4"
        Me.ColorCombControl4.Size = New System.Drawing.Size(36, 23)
        Me.ColorCombControl4.TabIndex = 8
        Me.ColorCombControl4.Text = "ColorCombControl4"
        '
        'ColorCombControl3
        '
        Me.ColorCombControl3.Location = New System.Drawing.Point(296, 32)
        Me.ColorCombControl3.Name = "ColorCombControl3"
        Me.ColorCombControl3.Size = New System.Drawing.Size(36, 23)
        Me.ColorCombControl3.TabIndex = 7
        Me.ColorCombControl3.Text = "ColorCombControl3"
        '
        'ColorCombControl2
        '
        Me.ColorCombControl2.Location = New System.Drawing.Point(157, 32)
        Me.ColorCombControl2.Name = "ColorCombControl2"
        Me.ColorCombControl2.Size = New System.Drawing.Size(36, 23)
        Me.ColorCombControl2.TabIndex = 6
        Me.ColorCombControl2.Text = "ColorCombControl2"
        '
        'ColorCombControl1
        '
        Me.ColorCombControl1.BackColor = System.Drawing.Color.Transparent
        Me.ColorCombControl1.Location = New System.Drawing.Point(16, 32)
        Me.ColorCombControl1.Name = "ColorCombControl1"
        Me.ColorCombControl1.Size = New System.Drawing.Size(32, 23)
        Me.ColorCombControl1.TabIndex = 5
        Me.ColorCombControl1.Text = "ColorCombControl1"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(481, 32)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(100, 23)
        Me.LabelX4.TabIndex = 4
        Me.LabelX4.Text = "Moins de 45 jours"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(338, 32)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(100, 23)
        Me.LabelX3.TabIndex = 3
        Me.LabelX3.Text = "moins de 30 jours"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(199, 32)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(100, 23)
        Me.LabelX2.TabIndex = 2
        Me.LabelX2.Text = "moins de 20 jours"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(54, 32)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(100, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Moins de 10 jours"
        '
        'finContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 471)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "finContact"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listes des employes qui ont une fin de contrat"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.confirmationMenu.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents confirmationMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ConfirmerCetteEmployéToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ColorCombControl1 As DevComponents.DotNetBar.ColorPickers.ColorCombControl
    Friend WithEvents ColorCombControl4 As DevComponents.DotNetBar.ColorPickers.ColorCombControl
    Friend WithEvents ColorCombControl3 As DevComponents.DotNetBar.ColorPickers.ColorCombControl
    Friend WithEvents ColorCombControl2 As DevComponents.DotNetBar.ColorPickers.ColorCombControl
End Class
