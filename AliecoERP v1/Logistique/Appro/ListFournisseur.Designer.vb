<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListFournisseur
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
        Me.components = New System.ComponentModel.Container()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.DGfournisseur = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GoogleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierOffreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerOffreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGfournisseur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = Global.MBA.My.Resources.Resources.vendors_arrow_right
        Me.ButtonX1.Location = New System.Drawing.Point(288, 31)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(253, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 9
        Me.ButtonX1.Text = "Exporter vers Excel"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Controls.Add(Me.ButtonX2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(868, 73)
        Me.GroupBox1.TabIndex = 120
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "La Liste des Fournisseurs :"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Image = Global.MBA.My.Resources.Resources.vendors_database1
        Me.ButtonX2.Location = New System.Drawing.Point(45, 31)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(209, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 8
        Me.ButtonX2.Text = "Afficher la Liste des Fournisseurs"
        '
        'DGfournisseur
        '
        Me.DGfournisseur.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DGfournisseur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGfournisseur.Location = New System.Drawing.Point(0, 73)
        Me.DGfournisseur.LookAndFeel.SkinName = "Office 2013"
        Me.DGfournisseur.LookAndFeel.UseDefaultLookAndFeel = False
        Me.DGfournisseur.MainView = Me.GridView1
        Me.DGfournisseur.Name = "DGfournisseur"
        Me.DGfournisseur.Size = New System.Drawing.Size(868, 592)
        Me.DGfournisseur.TabIndex = 121
        Me.DGfournisseur.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoogleToolStripMenuItem, Me.AjouterToolStripMenuItem, Me.ModifierOffreToolStripMenuItem, Me.SupprimerOffreToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(266, 92)
        '
        'GoogleToolStripMenuItem
        '
        Me.GoogleToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.GoogleToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.vendors_database
        Me.GoogleToolStripMenuItem.Name = "GoogleToolStripMenuItem"
        Me.GoogleToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.GoogleToolStripMenuItem.Text = "     Actualiser la liste des fournisseurs    "
        '
        'AjouterToolStripMenuItem
        '
        Me.AjouterToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.AjouterToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.vendors_add1
        Me.AjouterToolStripMenuItem.Name = "AjouterToolStripMenuItem"
        Me.AjouterToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.AjouterToolStripMenuItem.Text = "     Ajouter un nouveau fournisseur"
        '
        'ModifierOffreToolStripMenuItem
        '
        Me.ModifierOffreToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.ModifierOffreToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.vendors_edit
        Me.ModifierOffreToolStripMenuItem.Name = "ModifierOffreToolStripMenuItem"
        Me.ModifierOffreToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.ModifierOffreToolStripMenuItem.Text = "     Modifier le fournisseur selectionné"
        '
        'SupprimerOffreToolStripMenuItem
        '
        Me.SupprimerOffreToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.SupprimerOffreToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.vendors_remove
        Me.SupprimerOffreToolStripMenuItem.Name = "SupprimerOffreToolStripMenuItem"
        Me.SupprimerOffreToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.SupprimerOffreToolStripMenuItem.Text = "     Supprimer le fournisseur"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.DGfournisseur
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'ListFournisseur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 665)
        Me.Controls.Add(Me.DGfournisseur)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Name = "ListFournisseur"
        Me.ShowIcon = False
        Me.Text = "Liste des Fournisseurs"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGfournisseur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DGfournisseur As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GoogleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierOffreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerOffreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
