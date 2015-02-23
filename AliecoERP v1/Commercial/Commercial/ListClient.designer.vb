<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListClientfr
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GoogleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterUnNouveauClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierLeClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerLeClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.dgcl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgcl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoogleToolStripMenuItem, Me.AjouterUnNouveauClientToolStripMenuItem, Me.ModifierLeClientToolStripMenuItem, Me.SupprimerLeClientToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(237, 114)
        '
        'GoogleToolStripMenuItem
        '
        Me.GoogleToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.GoogleToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.vendors_database
        Me.GoogleToolStripMenuItem.Name = "GoogleToolStripMenuItem"
        Me.GoogleToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.GoogleToolStripMenuItem.Text = "     Actualiser la liste des clients    "
        '
        'AjouterUnNouveauClientToolStripMenuItem
        '
        Me.AjouterUnNouveauClientToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.AjouterUnNouveauClientToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.vendors_add1
        Me.AjouterUnNouveauClientToolStripMenuItem.Name = "AjouterUnNouveauClientToolStripMenuItem"
        Me.AjouterUnNouveauClientToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.AjouterUnNouveauClientToolStripMenuItem.Text = "     Ajouter un nouveau client"
        '
        'ModifierLeClientToolStripMenuItem
        '
        Me.ModifierLeClientToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.ModifierLeClientToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.vendors_edit
        Me.ModifierLeClientToolStripMenuItem.Name = "ModifierLeClientToolStripMenuItem"
        Me.ModifierLeClientToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.ModifierLeClientToolStripMenuItem.Text = "     Modifier le client selectionné"
        '
        'SupprimerLeClientToolStripMenuItem
        '
        Me.SupprimerLeClientToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.SupprimerLeClientToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.vendors_remove
        Me.SupprimerLeClientToolStripMenuItem.Name = "SupprimerLeClientToolStripMenuItem"
        Me.SupprimerLeClientToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.SupprimerLeClientToolStripMenuItem.Text = "     Supprimer le client"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.MBA.My.Resources.Resources.vendor_print
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(236, 22)
        Me.ToolStripMenuItem1.Text = "     Imprimer la fiche de client"
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
        Me.GroupBox1.Size = New System.Drawing.Size(912, 73)
        Me.GroupBox1.TabIndex = 118
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "La liste des Clients :"
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
        Me.ButtonX2.Text = "Afficher la liste des clients"
        '
        'dgcl
        '
        Me.dgcl.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgcl.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgcl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgcl.Location = New System.Drawing.Point(0, 73)
        Me.dgcl.LookAndFeel.SkinName = "Office 2013"
        Me.dgcl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.dgcl.MainView = Me.GridView1
        Me.dgcl.Name = "dgcl"
        Me.dgcl.Size = New System.Drawing.Size(912, 506)
        Me.dgcl.TabIndex = 119
        Me.dgcl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.dgcl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'ListClientfr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 579)
        Me.Controls.Add(Me.dgcl)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "ListClientfr"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Liste des Clients"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgcl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GoogleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterUnNouveauClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierLeClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerLeClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgcl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
