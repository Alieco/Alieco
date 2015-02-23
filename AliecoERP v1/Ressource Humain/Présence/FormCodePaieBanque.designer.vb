<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCodePaieBanque
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
        Me.libelle1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.code1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.BtnSave = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.CPdg = New DevExpress.XtraGrid.GridControl()
        Me.Menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModifierCetteBanqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerCetteBanqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CPdg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.libelle1)
        Me.GroupBox1.Controls.Add(Me.code1)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1003, 81)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ajouter le code de Banque :"
        '
        'libelle1
        '
        Me.libelle1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.libelle1.Border.Class = "TextBoxBorder"
        Me.libelle1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.libelle1.ForeColor = System.Drawing.Color.Black
        Me.libelle1.Location = New System.Drawing.Point(261, 32)
        Me.libelle1.Name = "libelle1"
        Me.libelle1.Size = New System.Drawing.Size(434, 25)
        Me.libelle1.TabIndex = 7
        '
        'code1
        '
        Me.code1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.code1.Border.Class = "TextBoxBorder"
        Me.code1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.code1.ForeColor = System.Drawing.Color.Black
        Me.code1.Location = New System.Drawing.Point(55, 31)
        Me.code1.Name = "code1"
        Me.code1.Size = New System.Drawing.Size(95, 25)
        Me.code1.TabIndex = 6
        '
        'BtnSave
        '
        Me.BtnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnSave.Location = New System.Drawing.Point(701, 31)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(239, 26)
        Me.BtnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnSave.TabIndex = 5
        Me.BtnSave.Text = "Ajouter"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(201, 32)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(54, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Libellé :"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(6, 31)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(43, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Code :"
        '
        'CPdg
        '
        Me.CPdg.ContextMenuStrip = Me.Menu
        Me.CPdg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CPdg.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White
        Me.CPdg.EmbeddedNavigator.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CPdg.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.CPdg.EmbeddedNavigator.Appearance.Options.UseForeColor = True
        Me.CPdg.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.CPdg.Location = New System.Drawing.Point(0, 81)
        Me.CPdg.LookAndFeel.SkinName = "Office 2013"
        Me.CPdg.LookAndFeel.UseDefaultLookAndFeel = False
        Me.CPdg.MainView = Me.GridView1
        Me.CPdg.Name = "CPdg"
        Me.CPdg.Size = New System.Drawing.Size(1003, 601)
        Me.CPdg.TabIndex = 10
        Me.CPdg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModifierCetteBanqueToolStripMenuItem, Me.SupprimerCetteBanqueToolStripMenuItem})
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(220, 48)
        '
        'ModifierCetteBanqueToolStripMenuItem
        '
        Me.ModifierCetteBanqueToolStripMenuItem.Name = "ModifierCetteBanqueToolStripMenuItem"
        Me.ModifierCetteBanqueToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ModifierCetteBanqueToolStripMenuItem.Text = "   Modifier cette banque   "
        '
        'SupprimerCetteBanqueToolStripMenuItem
        '
        Me.SupprimerCetteBanqueToolStripMenuItem.Name = "SupprimerCetteBanqueToolStripMenuItem"
        Me.SupprimerCetteBanqueToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.SupprimerCetteBanqueToolStripMenuItem.Text = "   Supprimer cette banque   "
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.CPdg
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'FormCodePaieBanque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 682)
        Me.Controls.Add(Me.CPdg)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCodePaieBanque"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Code Banque"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.CPdg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents libelle1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents code1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BtnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CPdg As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Menu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ModifierCetteBanqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerCetteBanqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
