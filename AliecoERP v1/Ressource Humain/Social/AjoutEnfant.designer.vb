<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjoutEnfant
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AjoutEnfant))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.datenaisenf = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.obsenf = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.prenomenf = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.enfantdgv = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ActualiserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.StatImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NSS = New DevComponents.DotNetBar.LabelX()
        Me.sb = New DevComponents.DotNetBar.LabelX()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Date_entrée = New DevComponents.DotNetBar.LabelX()
        Me.Adresse = New DevComponents.DotNetBar.LabelX()
        Me.Lieux_de_Naissance = New DevComponents.DotNetBar.LabelX()
        Me.Fonction = New DevComponents.DotNetBar.LabelX()
        Me.Date_de_Naissance = New DevComponents.DotNetBar.LabelX()
        Me.prenom = New DevComponents.DotNetBar.LabelX()
        Me.nom = New DevComponents.DotNetBar.LabelX()
        Me.ListMatNom = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datenaisenf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enfantdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ListMatNom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.ButtonX2)
        Me.GroupBox2.Controls.Add(Me.datenaisenf)
        Me.GroupBox2.Controls.Add(Me.obsenf)
        Me.GroupBox2.Controls.Add(Me.prenomenf)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(0, 156)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(1288, 105)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Enfant :"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = Global.MBA.My.Resources.Resources.add_button
        Me.ButtonX2.Location = New System.Drawing.Point(409, 76)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(221, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 206
        Me.ButtonX2.Text = "Ajouter"
        '
        'datenaisenf
        '
        Me.datenaisenf.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.datenaisenf.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.datenaisenf.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.datenaisenf.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.datenaisenf.ButtonDropDown.Visible = True
        Me.datenaisenf.ForeColor = System.Drawing.Color.Black
        Me.datenaisenf.Format = DevComponents.Editors.eDateTimePickerFormat.[Long]
        Me.datenaisenf.IsPopupCalendarOpen = False
        Me.datenaisenf.Location = New System.Drawing.Point(535, 33)
        '
        '
        '
        Me.datenaisenf.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.datenaisenf.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.datenaisenf.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.datenaisenf.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.datenaisenf.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.datenaisenf.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.datenaisenf.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.datenaisenf.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.datenaisenf.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.datenaisenf.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.datenaisenf.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.datenaisenf.MonthCalendar.DisplayMonth = New Date(2013, 12, 1, 0, 0, 0, 0)
        Me.datenaisenf.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.datenaisenf.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.datenaisenf.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.datenaisenf.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.datenaisenf.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.datenaisenf.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.datenaisenf.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.datenaisenf.MonthCalendar.TodayButtonVisible = True
        Me.datenaisenf.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.datenaisenf.Name = "datenaisenf"
        Me.datenaisenf.Size = New System.Drawing.Size(199, 25)
        Me.datenaisenf.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.datenaisenf.TabIndex = 203
        '
        'obsenf
        '
        Me.obsenf.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.obsenf.Border.Class = "TextBoxBorder"
        Me.obsenf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.obsenf.ForeColor = System.Drawing.Color.Black
        Me.obsenf.Location = New System.Drawing.Point(860, 18)
        Me.obsenf.Multiline = True
        Me.obsenf.Name = "obsenf"
        Me.obsenf.Size = New System.Drawing.Size(232, 40)
        Me.obsenf.TabIndex = 146
        '
        'prenomenf
        '
        Me.prenomenf.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.prenomenf.Border.Class = "TextBoxBorder"
        Me.prenomenf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.prenomenf.ForeColor = System.Drawing.Color.Black
        Me.prenomenf.Location = New System.Drawing.Point(154, 33)
        Me.prenomenf.Name = "prenomenf"
        Me.prenomenf.Size = New System.Drawing.Size(199, 25)
        Me.prenomenf.TabIndex = 143
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(764, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 17)
        Me.Label14.TabIndex = 142
        Me.Label14.Text = "Observations  :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(25, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 17)
        Me.Label12.TabIndex = 140
        Me.Label12.Text = "Prénom :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(383, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 17)
        Me.Label13.TabIndex = 139
        Me.Label13.Text = "Date de Naissance :"
        '
        'enfantdgv
        '
        Me.enfantdgv.ContextMenuStrip = Me.ContextMenuStrip1
        Me.enfantdgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.enfantdgv.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White
        Me.enfantdgv.EmbeddedNavigator.Appearance.ForeColor = System.Drawing.Color.Black
        Me.enfantdgv.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.enfantdgv.EmbeddedNavigator.Appearance.Options.UseForeColor = True
        Me.enfantdgv.Location = New System.Drawing.Point(0, 261)
        Me.enfantdgv.LookAndFeel.SkinName = "Office 2013"
        Me.enfantdgv.LookAndFeel.UseDefaultLookAndFeel = False
        Me.enfantdgv.MainView = Me.GridView1
        Me.enfantdgv.Name = "enfantdgv"
        Me.enfantdgv.Size = New System.Drawing.Size(1288, 434)
        Me.enfantdgv.TabIndex = 4
        Me.enfantdgv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActualiserToolStripMenuItem, Me.ModifierToolStripMenuItem, Me.SupprimerToolStripMenuItem, Me.AjouterToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(265, 92)
        '
        'ActualiserToolStripMenuItem
        '
        Me.ActualiserToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.ActualiserToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.refersh
        Me.ActualiserToolStripMenuItem.Name = "ActualiserToolStripMenuItem"
        Me.ActualiserToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.ActualiserToolStripMenuItem.Text = "     Actualiser la liste des fonctionners   "
        '
        'ModifierToolStripMenuItem
        '
        Me.ModifierToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.ModifierToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.edit
        Me.ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        Me.ModifierToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.ModifierToolStripMenuItem.Text = "     Modifier l'enfant selectionné"
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.SupprimerToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.delete
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.SupprimerToolStripMenuItem.Text = "     Supprimer  l'enfant"
        '
        'AjouterToolStripMenuItem
        '
        Me.AjouterToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.AjouterToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.add
        Me.AjouterToolStripMenuItem.Name = "AjouterToolStripMenuItem"
        Me.AjouterToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.AjouterToolStripMenuItem.Text = "     Ajouter un nouveau enfant"
        Me.AjouterToolStripMenuItem.Visible = False
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.enfantdgv
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'StatImageList
        '
        Me.StatImageList.ImageStream = CType(resources.GetObject("StatImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.StatImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.StatImageList.Images.SetKeyName(0, "favorite2.png")
        Me.StatImageList.Images.SetKeyName(1, "ok_button.png")
        Me.StatImageList.Images.SetKeyName(2, "remove_button.png")
        Me.StatImageList.Images.SetKeyName(3, "warning.png")
        Me.StatImageList.Images.SetKeyName(4, "user_id2.png")
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.NSS)
        Me.GroupBox1.Controls.Add(Me.sb)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Date_entrée)
        Me.GroupBox1.Controls.Add(Me.Adresse)
        Me.GroupBox1.Controls.Add(Me.Lieux_de_Naissance)
        Me.GroupBox1.Controls.Add(Me.Fonction)
        Me.GroupBox1.Controls.Add(Me.Date_de_Naissance)
        Me.GroupBox1.Controls.Add(Me.prenom)
        Me.GroupBox1.Controls.Add(Me.nom)
        Me.GroupBox1.Controls.Add(Me.ListMatNom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(1288, 156)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Assuré :"
        '
        'NSS
        '
        Me.NSS.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.NSS.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NSS.ForeColor = System.Drawing.Color.Black
        Me.NSS.Location = New System.Drawing.Point(582, 125)
        Me.NSS.Name = "NSS"
        Me.NSS.Size = New System.Drawing.Size(188, 23)
        Me.NSS.TabIndex = 298
        '
        'sb
        '
        Me.sb.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.sb.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sb.ForeColor = System.Drawing.Color.Black
        Me.sb.Location = New System.Drawing.Point(200, 127)
        Me.sb.Name = "sb"
        Me.sb.Size = New System.Drawing.Size(239, 23)
        Me.sb.TabIndex = 297
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(457, 125)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(119, 17)
        Me.Label16.TabIndex = 288
        Me.Label16.Text = "N° Sécurite Sociale :"
        '
        'Date_entrée
        '
        Me.Date_entrée.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Date_entrée.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Date_entrée.ForeColor = System.Drawing.Color.Black
        Me.Date_entrée.Location = New System.Drawing.Point(582, 95)
        Me.Date_entrée.Name = "Date_entrée"
        Me.Date_entrée.Size = New System.Drawing.Size(188, 23)
        Me.Date_entrée.TabIndex = 296
        '
        'Adresse
        '
        Me.Adresse.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Adresse.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Adresse.ForeColor = System.Drawing.Color.Black
        Me.Adresse.Location = New System.Drawing.Point(582, 69)
        Me.Adresse.Name = "Adresse"
        Me.Adresse.Size = New System.Drawing.Size(188, 23)
        Me.Adresse.TabIndex = 295
        '
        'Lieux_de_Naissance
        '
        Me.Lieux_de_Naissance.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Lieux_de_Naissance.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Lieux_de_Naissance.ForeColor = System.Drawing.Color.Black
        Me.Lieux_de_Naissance.Location = New System.Drawing.Point(582, 49)
        Me.Lieux_de_Naissance.Name = "Lieux_de_Naissance"
        Me.Lieux_de_Naissance.Size = New System.Drawing.Size(188, 20)
        Me.Lieux_de_Naissance.TabIndex = 294
        '
        'Fonction
        '
        Me.Fonction.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Fonction.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Fonction.ForeColor = System.Drawing.Color.Black
        Me.Fonction.Location = New System.Drawing.Point(582, 20)
        Me.Fonction.Name = "Fonction"
        Me.Fonction.Size = New System.Drawing.Size(188, 23)
        Me.Fonction.TabIndex = 293
        '
        'Date_de_Naissance
        '
        Me.Date_de_Naissance.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Date_de_Naissance.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Date_de_Naissance.ForeColor = System.Drawing.Color.Black
        Me.Date_de_Naissance.Location = New System.Drawing.Point(200, 98)
        Me.Date_de_Naissance.Name = "Date_de_Naissance"
        Me.Date_de_Naissance.Size = New System.Drawing.Size(239, 23)
        Me.Date_de_Naissance.TabIndex = 292
        '
        'prenom
        '
        Me.prenom.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.prenom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.prenom.ForeColor = System.Drawing.Color.Black
        Me.prenom.Location = New System.Drawing.Point(200, 50)
        Me.prenom.Name = "prenom"
        Me.prenom.Size = New System.Drawing.Size(239, 23)
        Me.prenom.TabIndex = 291
        '
        'nom
        '
        Me.nom.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.nom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.nom.ForeColor = System.Drawing.Color.Black
        Me.nom.Location = New System.Drawing.Point(200, 75)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(239, 23)
        Me.nom.TabIndex = 290
        '
        'ListMatNom
        '
        Me.ListMatNom.Location = New System.Drawing.Point(200, 22)
        Me.ListMatNom.Name = "ListMatNom"
        Me.ListMatNom.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.ListMatNom.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListMatNom.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ListMatNom.Properties.Appearance.Options.UseBackColor = True
        Me.ListMatNom.Properties.Appearance.Options.UseFont = True
        Me.ListMatNom.Properties.Appearance.Options.UseForeColor = True
        Me.ListMatNom.Properties.Appearance.Options.UseImage = True
        Me.ListMatNom.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.ListMatNom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ListMatNom.Properties.DropDownRows = 10
        Me.ListMatNom.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("dfdsf", "Gooooooooo", 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Google", "HOooooooooooo", 0)})
        Me.ListMatNom.Properties.LookAndFeel.SkinName = "Office 2013"
        Me.ListMatNom.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ListMatNom.Size = New System.Drawing.Size(239, 22)
        Me.ListMatNom.TabIndex = 289
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(455, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 287
        Me.Label1.Text = "Fonction :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(457, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 286
        Me.Label2.Text = "Date d'entrée :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(455, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 285
        Me.Label3.Text = "Adresse :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(455, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 284
        Me.Label4.Text = "LIEU :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(25, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 17)
        Me.Label5.TabIndex = 283
        Me.Label5.Text = "Date de Naissance :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(25, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 17)
        Me.Label6.TabIndex = 282
        Me.Label6.Text = "Nom :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(25, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 17)
        Me.Label10.TabIndex = 281
        Me.Label10.Text = "Prénom :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(25, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 17)
        Me.Label11.TabIndex = 280
        Me.Label11.Text = "Matricule :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(25, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 17)
        Me.Label7.TabIndex = 279
        Me.Label7.Text = "Salaire Brut et Montant S.S :"
        '
        'AjoutEnfant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1288, 695)
        Me.Controls.Add(Me.enfantdgv)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AjoutEnfant"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajouter un enfant au fonctionnaire"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datenaisenf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enfantdgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ListMatNom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents obsenf As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents prenomenf As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents datenaisenf As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents enfantdgv As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents StatImageList As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NSS As DevComponents.DotNetBar.LabelX
    Friend WithEvents sb As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Date_entrée As DevComponents.DotNetBar.LabelX
    Friend WithEvents Adresse As DevComponents.DotNetBar.LabelX
    Friend WithEvents Lieux_de_Naissance As DevComponents.DotNetBar.LabelX
    Friend WithEvents Fonction As DevComponents.DotNetBar.LabelX
    Friend WithEvents Date_de_Naissance As DevComponents.DotNetBar.LabelX
    Friend WithEvents prenom As DevComponents.DotNetBar.LabelX
    Friend WithEvents nom As DevComponents.DotNetBar.LabelX
    Friend WithEvents ListMatNom As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ActualiserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
