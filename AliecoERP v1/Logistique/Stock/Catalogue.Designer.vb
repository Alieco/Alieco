<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Catalogue
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.total = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.total11 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.quantite = New DevComponents.Editors.DoubleInput()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.prixunitaire = New DevComponents.Editors.DoubleInput()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.famille = New DevComponents.DotNetBar.LabelX()
        Me.rayon = New DevComponents.DotNetBar.LabelX()
        Me.um = New DevComponents.DotNetBar.LabelX()
        Me.sfamille = New DevComponents.DotNetBar.LabelX()
        Me.libelle = New DevComponents.DotNetBar.LabelX()
        Me.sousfamille = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.ajout = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.datenrg = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.compte = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.utilisateur = New DevComponents.DotNetBar.LabelX()
        Me.codearticle = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.DGcat = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GoogleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ModifierLeFonctionnaireFonctionnaireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ComboItem20 = New DevComponents.Editors.ComboItem()
        Me.ComboItem19 = New DevComponents.Editors.ComboItem()
        Me.ComboItem18 = New DevComponents.Editors.ComboItem()
        Me.ComboItem17 = New DevComponents.Editors.ComboItem()
        Me.ComboItem16 = New DevComponents.Editors.ComboItem()
        Me.ComboItem15 = New DevComponents.Editors.ComboItem()
        Me.ComboItem14 = New DevComponents.Editors.ComboItem()
        Me.ComboItem13 = New DevComponents.Editors.ComboItem()
        Me.ComboItem12 = New DevComponents.Editors.ComboItem()
        Me.ComboItem11 = New DevComponents.Editors.ComboItem()
        Me.ComboItem10 = New DevComponents.Editors.ComboItem()
        Me.ComboItem9 = New DevComponents.Editors.ComboItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.GroupBox4.SuspendLayout()
        CType(Me.quantite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prixunitaire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGcat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.total)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.total11)
        Me.GroupBox4.Controls.Add(Me.quantite)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.prixunitaire)
        Me.GroupBox4.Location = New System.Drawing.Point(525, 26)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(285, 115)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Prix d'acticle :"
        '
        'total
        '
        Me.total.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.total.Border.Class = "TextBoxBorder"
        Me.total.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.total.ForeColor = System.Drawing.Color.Black
        Me.total.Location = New System.Drawing.Point(80, 80)
        Me.total.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(190, 20)
        Me.total.TabIndex = 311
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 310
        Me.Label1.Text = "total :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(6, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 303
        Me.Label13.Text = "Quantité :"
        '
        'total11
        '
        Me.total11.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.total11.Border.Class = "TextBoxBorder"
        Me.total11.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.total11.ForeColor = System.Drawing.Color.Black
        Me.total11.Location = New System.Drawing.Point(725, 137)
        Me.total11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.total11.Name = "total11"
        Me.total11.Size = New System.Drawing.Size(117, 20)
        Me.total11.TabIndex = 308
        '
        'quantite
        '
        '
        '
        '
        Me.quantite.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.quantite.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.quantite.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.quantite.Increment = 1.0R
        Me.quantite.Location = New System.Drawing.Point(80, 21)
        Me.quantite.Name = "quantite"
        Me.quantite.ShowUpDown = True
        Me.quantite.Size = New System.Drawing.Size(190, 20)
        Me.quantite.TabIndex = 304
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(629, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 307
        Me.Label10.Text = "total :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(6, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 305
        Me.Label11.Text = "Prix unitaire  :"
        '
        'prixunitaire
        '
        '
        '
        '
        Me.prixunitaire.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.prixunitaire.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.prixunitaire.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.prixunitaire.Increment = 1.0R
        Me.prixunitaire.Location = New System.Drawing.Point(80, 51)
        Me.prixunitaire.Name = "prixunitaire"
        Me.prixunitaire.ShowUpDown = True
        Me.prixunitaire.Size = New System.Drawing.Size(190, 20)
        Me.prixunitaire.TabIndex = 306
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.famille)
        Me.GroupBox2.Controls.Add(Me.rayon)
        Me.GroupBox2.Controls.Add(Me.um)
        Me.GroupBox2.Controls.Add(Me.sfamille)
        Me.GroupBox2.Controls.Add(Me.libelle)
        Me.GroupBox2.Controls.Add(Me.sousfamille)
        Me.GroupBox2.Controls.Add(Me.ButtonX3)
        Me.GroupBox2.Controls.Add(Me.ajout)
        Me.GroupBox2.Controls.Add(Me.ButtonX2)
        Me.GroupBox2.Controls.Add(Me.ButtonX1)
        Me.GroupBox2.Controls.Add(Me.datenrg)
        Me.GroupBox2.Controls.Add(Me.LabelX3)
        Me.GroupBox2.Controls.Add(Me.compte)
        Me.GroupBox2.Controls.Add(Me.LabelX4)
        Me.GroupBox2.Controls.Add(Me.LabelX5)
        Me.GroupBox2.Controls.Add(Me.LabelX1)
        Me.GroupBox2.Controls.Add(Me.LabelX2)
        Me.GroupBox2.Controls.Add(Me.utilisateur)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.codearticle)
        Me.GroupBox2.Controls.Add(Me.LabelX12)
        Me.GroupBox2.Controls.Add(Me.LabelX10)
        Me.GroupBox2.Controls.Add(Me.LabelX9)
        Me.GroupBox2.Controls.Add(Me.LabelX8)
        Me.GroupBox2.Controls.Add(Me.LabelX7)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(862, 197)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Catalogue :"
        '
        'famille
        '
        '
        '
        '
        Me.famille.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.famille.Location = New System.Drawing.Point(357, 113)
        Me.famille.Name = "famille"
        Me.famille.Size = New System.Drawing.Size(151, 23)
        Me.famille.TabIndex = 47
        Me.famille.Text = "famille"
        '
        'rayon
        '
        '
        '
        '
        Me.rayon.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rayon.Location = New System.Drawing.Point(113, 167)
        Me.rayon.Name = "rayon"
        Me.rayon.Size = New System.Drawing.Size(151, 23)
        Me.rayon.TabIndex = 46
        Me.rayon.Text = "rayon"
        '
        'um
        '
        '
        '
        '
        Me.um.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.um.Location = New System.Drawing.Point(113, 139)
        Me.um.Name = "um"
        Me.um.Size = New System.Drawing.Size(151, 23)
        Me.um.TabIndex = 45
        Me.um.Text = "um"
        '
        'sfamille
        '
        '
        '
        '
        Me.sfamille.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sfamille.Location = New System.Drawing.Point(113, 108)
        Me.sfamille.Name = "sfamille"
        Me.sfamille.Size = New System.Drawing.Size(151, 23)
        Me.sfamille.TabIndex = 44
        Me.sfamille.Text = "sfamille"
        '
        'libelle
        '
        '
        '
        '
        Me.libelle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.libelle.Location = New System.Drawing.Point(113, 79)
        Me.libelle.Name = "libelle"
        Me.libelle.Size = New System.Drawing.Size(151, 23)
        Me.libelle.TabIndex = 43
        Me.libelle.Text = "libelle"
        '
        'sousfamille
        '
        '
        '
        '
        Me.sousfamille.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sousfamille.Location = New System.Drawing.Point(357, 84)
        Me.sousfamille.Name = "sousfamille"
        Me.sousfamille.Size = New System.Drawing.Size(151, 23)
        Me.sousfamille.TabIndex = 42
        Me.sousfamille.Text = "sousfamille"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX3.Image = Global.MBA.My.Resources.Resources.Excel_2013
        Me.ButtonX3.Location = New System.Drawing.Point(720, 155)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(136, 23)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 41
        Me.ButtonX3.Text = "Exporter vers Excel"
        '
        'ajout
        '
        Me.ajout.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ajout.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ajout.Image = Global.MBA.My.Resources.Resources.add_button
        Me.ajout.Location = New System.Drawing.Point(404, 155)
        Me.ajout.Name = "ajout"
        Me.ajout.Size = New System.Drawing.Size(124, 23)
        Me.ajout.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ajout.TabIndex = 40
        Me.ajout.Text = "Ajouter"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = Global.MBA.My.Resources.Resources.add1
        Me.ButtonX2.Location = New System.Drawing.Point(81, 52)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(28, 19)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 39
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.MBA.My.Resources.Resources.add1
        Me.ButtonX1.Location = New System.Drawing.Point(322, 55)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(32, 17)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 38
        '
        'datenrg
        '
        '
        '
        '
        Me.datenrg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.datenrg.Location = New System.Drawing.Point(93, 18)
        Me.datenrg.Name = "datenrg"
        Me.datenrg.Size = New System.Drawing.Size(151, 23)
        Me.datenrg.TabIndex = 37
        Me.datenrg.Text = "date"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(270, 52)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(46, 23)
        Me.LabelX3.TabIndex = 36
        Me.LabelX3.Text = "Compte :"
        '
        'compte
        '
        Me.compte.DisplayMember = "Text"
        Me.compte.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.compte.FormattingEnabled = True
        Me.compte.ItemHeight = 14
        Me.compte.Location = New System.Drawing.Point(357, 55)
        Me.compte.Name = "compte"
        Me.compte.Size = New System.Drawing.Size(151, 20)
        Me.compte.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.compte.TabIndex = 35
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(270, 84)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(81, 23)
        Me.LabelX4.TabIndex = 32
        Me.LabelX4.Text = "Sous famille :"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(270, 110)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(81, 28)
        Me.LabelX5.TabIndex = 30
        Me.LabelX5.Text = "Famille :"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(6, 167)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(81, 23)
        Me.LabelX1.TabIndex = 27
        Me.LabelX1.Text = "Rayon :"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(270, 23)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(81, 23)
        Me.LabelX2.TabIndex = 26
        Me.LabelX2.Text = "Utilisateur :"
        '
        'utilisateur
        '
        '
        '
        '
        Me.utilisateur.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.utilisateur.Location = New System.Drawing.Point(357, 23)
        Me.utilisateur.Name = "utilisateur"
        Me.utilisateur.Size = New System.Drawing.Size(151, 23)
        Me.utilisateur.TabIndex = 25
        Me.utilisateur.Text = "Ut"
        '
        'codearticle
        '
        Me.codearticle.DisplayMember = "Text"
        Me.codearticle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.codearticle.FormattingEnabled = True
        Me.codearticle.ItemHeight = 14
        Me.codearticle.Location = New System.Drawing.Point(113, 52)
        Me.codearticle.Name = "codearticle"
        Me.codearticle.Size = New System.Drawing.Size(151, 20)
        Me.codearticle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.codearticle.TabIndex = 24
        '
        'LabelX12
        '
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Location = New System.Drawing.Point(6, 139)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(81, 23)
        Me.LabelX12.TabIndex = 12
        Me.LabelX12.Text = "UM :"
        '
        'LabelX10
        '
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Location = New System.Drawing.Point(6, 47)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(69, 23)
        Me.LabelX10.TabIndex = 9
        Me.LabelX10.Text = "Code Article :"
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(6, 79)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(81, 23)
        Me.LabelX9.TabIndex = 7
        Me.LabelX9.Text = "Libellé :"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(6, 101)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(81, 28)
        Me.LabelX8.TabIndex = 5
        Me.LabelX8.Text = "S/famille :"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(6, 18)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(81, 23)
        Me.LabelX7.TabIndex = 3
        Me.LabelX7.Text = "Date  :"
        '
        'DGcat
        '
        Me.DGcat.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DGcat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGcat.Location = New System.Drawing.Point(0, 197)
        Me.DGcat.LookAndFeel.SkinName = "Office 2013"
        Me.DGcat.LookAndFeel.UseDefaultLookAndFeel = False
        Me.DGcat.MainView = Me.GridView1
        Me.DGcat.Name = "DGcat"
        Me.DGcat.Size = New System.Drawing.Size(862, 328)
        Me.DGcat.TabIndex = 6
        Me.DGcat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoogleToolStripMenuItem, Me.ToolStripMenuItem1, Me.ModifierLeFonctionnaireFonctionnaireToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(261, 92)
        '
        'GoogleToolStripMenuItem
        '
        Me.GoogleToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.GoogleToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.refersh
        Me.GoogleToolStripMenuItem.Name = "GoogleToolStripMenuItem"
        Me.GoogleToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.GoogleToolStripMenuItem.Text = "     Actualiser la liste des catalogues    "
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox2})
        Me.ToolStripMenuItem1.Image = Global.MBA.My.Resources.Resources.search
        Me.ToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.White
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(260, 22)
        Me.ToolStripMenuItem1.Text = "     Rechercher un catalogue"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 23)
        '
        'ModifierLeFonctionnaireFonctionnaireToolStripMenuItem
        '
        Me.ModifierLeFonctionnaireFonctionnaireToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.ModifierLeFonctionnaireFonctionnaireToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.edit
        Me.ModifierLeFonctionnaireFonctionnaireToolStripMenuItem.Name = "ModifierLeFonctionnaireFonctionnaireToolStripMenuItem"
        Me.ModifierLeFonctionnaireFonctionnaireToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.ModifierLeFonctionnaireFonctionnaireToolStripMenuItem.Text = "     Modifier le catalogue selectionné"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.DGcat
        Me.GridView1.Name = "GridView1"
        '
        'ComboItem20
        '
        Me.ComboItem20.Text = "Virement"
        '
        'ComboItem19
        '
        Me.ComboItem19.Text = "Versement"
        '
        'ComboItem18
        '
        Me.ComboItem18.Text = "Traite"
        '
        'ComboItem17
        '
        Me.ComboItem17.Text = "Remise documentaire"
        '
        'ComboItem16
        '
        Me.ComboItem16.Text = "Lettre de credit"
        '
        'ComboItem15
        '
        Me.ComboItem15.Text = "Cheque"
        '
        'ComboItem14
        '
        Me.ComboItem14.Text = "Espece bon pour"
        '
        'ComboItem13
        '
        Me.ComboItem13.Text = "Espece"
        '
        'ComboItem12
        '
        Me.ComboItem12.Text = "Bancaire"
        '
        'ComboItem11
        '
        Me.ComboItem11.Text = "Par train"
        '
        'ComboItem10
        '
        Me.ComboItem10.Text = "Par navire"
        '
        'ComboItem9
        '
        Me.ComboItem9.Text = "Par vos soin"
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "Par nos soin"
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "Par avion"
        '
        'Catalogue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 525)
        Me.Controls.Add(Me.DGcat)
        Me.Controls.Add(Me.GroupBox2)
        Me.DoubleBuffered = True
        Me.Name = "Catalogue"
        Me.ShowIcon = False
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.quantite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prixunitaire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGcat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DGcat As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents utilisateur As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents total11 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents quantite As DevComponents.Editors.DoubleInput
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents prixunitaire As DevComponents.Editors.DoubleInput
    Friend WithEvents ComboItem20 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem19 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem18 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem17 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem16 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem15 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem14 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem13 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem12 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem11 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem10 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents total As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents datenrg As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GoogleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierLeFonctionnaireFonctionnaireToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ajout As DevComponents.DotNetBar.ButtonX
    Friend WithEvents compte As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents codearticle As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents famille As DevComponents.DotNetBar.LabelX
    Friend WithEvents rayon As DevComponents.DotNetBar.LabelX
    Friend WithEvents um As DevComponents.DotNetBar.LabelX
    Friend WithEvents sfamille As DevComponents.DotNetBar.LabelX
    Friend WithEvents libelle As DevComponents.DotNetBar.LabelX
    Friend WithEvents sousfamille As DevComponents.DotNetBar.LabelX
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
End Class
