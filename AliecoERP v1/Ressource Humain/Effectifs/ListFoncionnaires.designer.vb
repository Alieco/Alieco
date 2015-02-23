<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListFoncionnaires
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
        Me.AjouterUnNouveauFonctionnaireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierLeFonctionnaireFonctionnaireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerLeFonctionnaireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TirageDesFonctionnairesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DépartDeFonctionnaireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartvolentaireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetraiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LicenciementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttestationEtCertificatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttestationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CertificatDeTravailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.DGFonc = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGFonc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoogleToolStripMenuItem, Me.AjouterUnNouveauFonctionnaireToolStripMenuItem, Me.ModifierLeFonctionnaireFonctionnaireToolStripMenuItem, Me.SupprimerLeFonctionnaireToolStripMenuItem, Me.TirageDesFonctionnairesToolStripMenuItem, Me.DépartDeFonctionnaireToolStripMenuItem, Me.AttestationEtCertificatToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(276, 158)
        '
        'GoogleToolStripMenuItem
        '
        Me.GoogleToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.GoogleToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.refersh
        Me.GoogleToolStripMenuItem.Name = "GoogleToolStripMenuItem"
        Me.GoogleToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.GoogleToolStripMenuItem.Text = "     Actualiser la liste des fonctionnaires    "
        '
        'AjouterUnNouveauFonctionnaireToolStripMenuItem
        '
        Me.AjouterUnNouveauFonctionnaireToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.AjouterUnNouveauFonctionnaireToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.add
        Me.AjouterUnNouveauFonctionnaireToolStripMenuItem.Name = "AjouterUnNouveauFonctionnaireToolStripMenuItem"
        Me.AjouterUnNouveauFonctionnaireToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.AjouterUnNouveauFonctionnaireToolStripMenuItem.Text = "     Ajouter un nouveau fonctionnaire"
        '
        'ModifierLeFonctionnaireFonctionnaireToolStripMenuItem
        '
        Me.ModifierLeFonctionnaireFonctionnaireToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.ModifierLeFonctionnaireFonctionnaireToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.edit
        Me.ModifierLeFonctionnaireFonctionnaireToolStripMenuItem.Name = "ModifierLeFonctionnaireFonctionnaireToolStripMenuItem"
        Me.ModifierLeFonctionnaireFonctionnaireToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.ModifierLeFonctionnaireFonctionnaireToolStripMenuItem.Text = "     Modifier le fonctionnaire selectionné"
        '
        'SupprimerLeFonctionnaireToolStripMenuItem
        '
        Me.SupprimerLeFonctionnaireToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.SupprimerLeFonctionnaireToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.delete
        Me.SupprimerLeFonctionnaireToolStripMenuItem.Name = "SupprimerLeFonctionnaireToolStripMenuItem"
        Me.SupprimerLeFonctionnaireToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.SupprimerLeFonctionnaireToolStripMenuItem.Text = "     Supprimer le fonctionnaire"
        '
        'TirageDesFonctionnairesToolStripMenuItem
        '
        Me.TirageDesFonctionnairesToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.TirageDesFonctionnairesToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.sort
        Me.TirageDesFonctionnairesToolStripMenuItem.Name = "TirageDesFonctionnairesToolStripMenuItem"
        Me.TirageDesFonctionnairesToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.TirageDesFonctionnairesToolStripMenuItem.Text = "     Plus de détail sur le fonctionnaire"
        '
        'DépartDeFonctionnaireToolStripMenuItem
        '
        Me.DépartDeFonctionnaireToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartvolentaireToolStripMenuItem, Me.RetraiteToolStripMenuItem, Me.LicenciementToolStripMenuItem})
        Me.DépartDeFonctionnaireToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.go1
        Me.DépartDeFonctionnaireToolStripMenuItem.Name = "DépartDeFonctionnaireToolStripMenuItem"
        Me.DépartDeFonctionnaireToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.DépartDeFonctionnaireToolStripMenuItem.Text = "     Départ de fonctionnaire"
        '
        'DepartvolentaireToolStripMenuItem
        '
        Me.DepartvolentaireToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.DepartvolentaireToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.volotaire
        Me.DepartvolentaireToolStripMenuItem.Name = "DepartvolentaireToolStripMenuItem"
        Me.DepartvolentaireToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.DepartvolentaireToolStripMenuItem.Text = "Depart volentaire"
        '
        'RetraiteToolStripMenuItem
        '
        Me.RetraiteToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.RetraiteToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.old
        Me.RetraiteToolStripMenuItem.Name = "RetraiteToolStripMenuItem"
        Me.RetraiteToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.RetraiteToolStripMenuItem.Text = "Retraite"
        '
        'LicenciementToolStripMenuItem
        '
        Me.LicenciementToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.LicenciementToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.go
        Me.LicenciementToolStripMenuItem.Name = "LicenciementToolStripMenuItem"
        Me.LicenciementToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.LicenciementToolStripMenuItem.Text = "Licenciement"
        '
        'AttestationEtCertificatToolStripMenuItem
        '
        Me.AttestationEtCertificatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AttestationToolStripMenuItem, Me.CertificatDeTravailToolStripMenuItem})
        Me.AttestationEtCertificatToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.certificat
        Me.AttestationEtCertificatToolStripMenuItem.Name = "AttestationEtCertificatToolStripMenuItem"
        Me.AttestationEtCertificatToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.AttestationEtCertificatToolStripMenuItem.Text = "     Attestation et Certificat"
        '
        'AttestationToolStripMenuItem
        '
        Me.AttestationToolStripMenuItem.Name = "AttestationToolStripMenuItem"
        Me.AttestationToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.AttestationToolStripMenuItem.Text = "  Attestation de travail "
        '
        'CertificatDeTravailToolStripMenuItem
        '
        Me.CertificatDeTravailToolStripMenuItem.Name = "CertificatDeTravailToolStripMenuItem"
        Me.CertificatDeTravailToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.CertificatDeTravailToolStripMenuItem.Text = "  Certificat de travail  "
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
        Me.GroupBox1.Size = New System.Drawing.Size(1354, 85)
        Me.GroupBox1.TabIndex = 116
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "La liste des Fonctionnaires :"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = Global.MBA.My.Resources.Resources.Excel_2013
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
        Me.ButtonX2.Image = Global.MBA.My.Resources.Resources.sort
        Me.ButtonX2.Location = New System.Drawing.Point(45, 31)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(209, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 8
        Me.ButtonX2.Text = "Afficher la liste des fonctionnaires"
        '
        'DGFonc
        '
        Me.DGFonc.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DGFonc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGFonc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGFonc.Location = New System.Drawing.Point(0, 85)
        Me.DGFonc.LookAndFeel.SkinName = "Office 2013"
        Me.DGFonc.LookAndFeel.UseDefaultLookAndFeel = False
        Me.DGFonc.MainView = Me.GridView1
        Me.DGFonc.Name = "DGFonc"
        Me.DGFonc.Size = New System.Drawing.Size(1354, 537)
        Me.DGFonc.TabIndex = 117
        Me.DGFonc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.DGFonc
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'ListFoncionnaires
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 622)
        Me.Controls.Add(Me.DGFonc)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Name = "ListFoncionnaires"
        Me.ShowIcon = False
        Me.Text = "Liste des fonctionnaires "
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGFonc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GoogleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterUnNouveauFonctionnaireToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierLeFonctionnaireFonctionnaireToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerLeFonctionnaireToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TirageDesFonctionnairesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DépartDeFonctionnaireToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartvolentaireToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RetraiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LicenciementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttestationEtCertificatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttestationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CertificatDeTravailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DGFonc As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
End Class
