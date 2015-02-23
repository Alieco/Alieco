<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FichRenseignement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FichRenseignement))
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.datemarconj = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.datenaisconj = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.prenomconj = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.nomconj = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.StatImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Conjdg = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ActualiserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ListMatNom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datemarconj, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datenaisconj, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Conjdg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(1001, 159)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Assuré :"
        '
        'NSS
        '
        '
        '
        '
        Me.NSS.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NSS.Location = New System.Drawing.Point(569, 128)
        Me.NSS.Name = "NSS"
        Me.NSS.Size = New System.Drawing.Size(188, 23)
        Me.NSS.TabIndex = 278
        '
        'sb
        '
        '
        '
        '
        Me.sb.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sb.Location = New System.Drawing.Point(187, 130)
        Me.sb.Name = "sb"
        Me.sb.Size = New System.Drawing.Size(239, 23)
        Me.sb.TabIndex = 276
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(444, 128)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(119, 17)
        Me.Label16.TabIndex = 212
        Me.Label16.Text = "N° Sécurite Sociale :"
        '
        'Date_entrée
        '
        '
        '
        '
        Me.Date_entrée.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Date_entrée.Location = New System.Drawing.Point(569, 98)
        Me.Date_entrée.Name = "Date_entrée"
        Me.Date_entrée.Size = New System.Drawing.Size(188, 23)
        Me.Date_entrée.TabIndex = 275
        '
        'Adresse
        '
        '
        '
        '
        Me.Adresse.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Adresse.Location = New System.Drawing.Point(569, 72)
        Me.Adresse.Name = "Adresse"
        Me.Adresse.Size = New System.Drawing.Size(188, 23)
        Me.Adresse.TabIndex = 274
        '
        'Lieux_de_Naissance
        '
        '
        '
        '
        Me.Lieux_de_Naissance.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Lieux_de_Naissance.Location = New System.Drawing.Point(569, 52)
        Me.Lieux_de_Naissance.Name = "Lieux_de_Naissance"
        Me.Lieux_de_Naissance.Size = New System.Drawing.Size(188, 20)
        Me.Lieux_de_Naissance.TabIndex = 273
        '
        'Fonction
        '
        '
        '
        '
        Me.Fonction.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Fonction.Location = New System.Drawing.Point(569, 23)
        Me.Fonction.Name = "Fonction"
        Me.Fonction.Size = New System.Drawing.Size(188, 23)
        Me.Fonction.TabIndex = 272
        '
        'Date_de_Naissance
        '
        '
        '
        '
        Me.Date_de_Naissance.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Date_de_Naissance.Location = New System.Drawing.Point(187, 101)
        Me.Date_de_Naissance.Name = "Date_de_Naissance"
        Me.Date_de_Naissance.Size = New System.Drawing.Size(239, 23)
        Me.Date_de_Naissance.TabIndex = 271
        '
        'prenom
        '
        '
        '
        '
        Me.prenom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.prenom.Location = New System.Drawing.Point(187, 53)
        Me.prenom.Name = "prenom"
        Me.prenom.Size = New System.Drawing.Size(239, 23)
        Me.prenom.TabIndex = 270
        '
        'nom
        '
        '
        '
        '
        Me.nom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.nom.Location = New System.Drawing.Point(187, 78)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(239, 23)
        Me.nom.TabIndex = 269
        '
        'ListMatNom
        '
        Me.ListMatNom.Location = New System.Drawing.Point(187, 25)
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
        Me.ListMatNom.TabIndex = 267
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(442, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 209
        Me.Label1.Text = "Fonction :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(444, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 205
        Me.Label2.Text = "Date d'entrée :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(442, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 204
        Me.Label3.Text = "Adresse :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(442, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 203
        Me.Label4.Text = "LIEU :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 17)
        Me.Label5.TabIndex = 198
        Me.Label5.Text = "Date de Naissance :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 17)
        Me.Label6.TabIndex = 197
        Me.Label6.Text = "Nom :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(12, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 17)
        Me.Label10.TabIndex = 196
        Me.Label10.Text = "Prénom :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(12, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 17)
        Me.Label11.TabIndex = 195
        Me.Label11.Text = "Matricule :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 17)
        Me.Label7.TabIndex = 145
        Me.Label7.Text = "Salaire Brut et Montant S.S :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonX2)
        Me.GroupBox2.Controls.Add(Me.datemarconj)
        Me.GroupBox2.Controls.Add(Me.datenaisconj)
        Me.GroupBox2.Controls.Add(Me.prenomconj)
        Me.GroupBox2.Controls.Add(Me.nomconj)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 159)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(1001, 158)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Conjoint :"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = Global.MBA.My.Resources.Resources.add_button
        Me.ButtonX2.Location = New System.Drawing.Point(447, 124)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(221, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 205
        Me.ButtonX2.Text = "Ajouter"
        '
        'datemarconj
        '
        Me.datemarconj.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.datemarconj.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.datemarconj.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.datemarconj.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.datemarconj.ButtonDropDown.Visible = True
        Me.datemarconj.ForeColor = System.Drawing.Color.Black
        Me.datemarconj.Format = DevComponents.Editors.eDateTimePickerFormat.[Long]
        Me.datemarconj.IsPopupCalendarOpen = False
        Me.datemarconj.Location = New System.Drawing.Point(187, 124)
        '
        '
        '
        Me.datemarconj.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.datemarconj.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.datemarconj.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.datemarconj.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.datemarconj.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.datemarconj.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.datemarconj.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.datemarconj.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.datemarconj.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.datemarconj.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.datemarconj.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.datemarconj.MonthCalendar.DisplayMonth = New Date(2013, 12, 1, 0, 0, 0, 0)
        Me.datemarconj.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.datemarconj.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.datemarconj.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.datemarconj.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.datemarconj.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.datemarconj.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.datemarconj.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.datemarconj.MonthCalendar.TodayButtonVisible = True
        Me.datemarconj.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.datemarconj.Name = "datemarconj"
        Me.datemarconj.Size = New System.Drawing.Size(239, 25)
        Me.datemarconj.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.datemarconj.TabIndex = 204
        '
        'datenaisconj
        '
        Me.datenaisconj.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.datenaisconj.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.datenaisconj.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.datenaisconj.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.datenaisconj.ButtonDropDown.Visible = True
        Me.datenaisconj.ForeColor = System.Drawing.Color.Black
        Me.datenaisconj.Format = DevComponents.Editors.eDateTimePickerFormat.[Long]
        Me.datenaisconj.IsPopupCalendarOpen = False
        Me.datenaisconj.Location = New System.Drawing.Point(187, 93)
        '
        '
        '
        Me.datenaisconj.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.datenaisconj.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.datenaisconj.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.datenaisconj.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.datenaisconj.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.datenaisconj.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.datenaisconj.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.datenaisconj.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.datenaisconj.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.datenaisconj.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.datenaisconj.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.datenaisconj.MonthCalendar.DisplayMonth = New Date(2013, 12, 1, 0, 0, 0, 0)
        Me.datenaisconj.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.datenaisconj.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.datenaisconj.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.datenaisconj.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.datenaisconj.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.datenaisconj.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.datenaisconj.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.datenaisconj.MonthCalendar.TodayButtonVisible = True
        Me.datenaisconj.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.datenaisconj.Name = "datenaisconj"
        Me.datenaisconj.Size = New System.Drawing.Size(239, 25)
        Me.datenaisconj.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.datenaisconj.TabIndex = 203
        '
        'prenomconj
        '
        Me.prenomconj.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.prenomconj.Border.Class = "TextBoxBorder"
        Me.prenomconj.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.prenomconj.ForeColor = System.Drawing.Color.Black
        Me.prenomconj.Location = New System.Drawing.Point(187, 62)
        Me.prenomconj.Name = "prenomconj"
        Me.prenomconj.Size = New System.Drawing.Size(239, 25)
        Me.prenomconj.TabIndex = 145
        '
        'nomconj
        '
        Me.nomconj.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.nomconj.Border.Class = "TextBoxBorder"
        Me.nomconj.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.nomconj.ForeColor = System.Drawing.Color.Black
        Me.nomconj.Location = New System.Drawing.Point(187, 33)
        Me.nomconj.Name = "nomconj"
        Me.nomconj.Size = New System.Drawing.Size(239, 25)
        Me.nomconj.TabIndex = 143
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(12, 129)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(111, 17)
        Me.Label14.TabIndex = 142
        Me.Label14.Text = "Date de Mariage  :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(12, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 17)
        Me.Label9.TabIndex = 141
        Me.Label9.Text = "Nom :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(12, 68)
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
        Me.Label13.Location = New System.Drawing.Point(12, 99)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 17)
        Me.Label13.TabIndex = 139
        Me.Label13.Text = "Date de Naissance :"
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
        'Conjdg
        '
        Me.Conjdg.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Conjdg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Conjdg.Location = New System.Drawing.Point(0, 317)
        Me.Conjdg.LookAndFeel.SkinName = "Office 2013"
        Me.Conjdg.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Conjdg.MainView = Me.GridView1
        Me.Conjdg.Name = "Conjdg"
        Me.Conjdg.Size = New System.Drawing.Size(1001, 474)
        Me.Conjdg.TabIndex = 2
        Me.Conjdg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActualiserToolStripMenuItem, Me.ModifierToolStripMenuItem, Me.SupprimerToolStripMenuItem, Me.AjouterToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(299, 92)
        '
        'ActualiserToolStripMenuItem
        '
        Me.ActualiserToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.ActualiserToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.refersh
        Me.ActualiserToolStripMenuItem.Name = "ActualiserToolStripMenuItem"
        Me.ActualiserToolStripMenuItem.Size = New System.Drawing.Size(298, 22)
        Me.ActualiserToolStripMenuItem.Text = "     Actualiser la liste des fonctionners   "
        '
        'ModifierToolStripMenuItem
        '
        Me.ModifierToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.ModifierToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.edit
        Me.ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        Me.ModifierToolStripMenuItem.Size = New System.Drawing.Size(298, 22)
        Me.ModifierToolStripMenuItem.Text = "     Modifier la (le) conjoint (e) selectionné(e)"
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.SupprimerToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.delete
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(298, 22)
        Me.SupprimerToolStripMenuItem.Text = "     Supprimer le  (la) conjoint (e)"
        '
        'AjouterToolStripMenuItem
        '
        Me.AjouterToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.AjouterToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.add
        Me.AjouterToolStripMenuItem.Name = "AjouterToolStripMenuItem"
        Me.AjouterToolStripMenuItem.Size = New System.Drawing.Size(298, 22)
        Me.AjouterToolStripMenuItem.Text = "     Ajouter un(e) nouveau(nouvelle) conjoint(e)"
        Me.AjouterToolStripMenuItem.Visible = False
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Conjdg
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'FichRenseignement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 791)
        Me.Controls.Add(Me.Conjdg)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FichRenseignement"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fiche de Renseignement"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ListMatNom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datemarconj, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datenaisconj, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Conjdg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents prenomconj As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents nomconj As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents datemarconj As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents datenaisconj As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ListMatNom As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents StatImageList As System.Windows.Forms.ImageList
    Friend WithEvents NSS As DevComponents.DotNetBar.LabelX
    Friend WithEvents sb As DevComponents.DotNetBar.LabelX
    Friend WithEvents Date_entrée As DevComponents.DotNetBar.LabelX
    Friend WithEvents Adresse As DevComponents.DotNetBar.LabelX
    Friend WithEvents Lieux_de_Naissance As DevComponents.DotNetBar.LabelX
    Friend WithEvents Fonction As DevComponents.DotNetBar.LabelX
    Friend WithEvents Date_de_Naissance As DevComponents.DotNetBar.LabelX
    Friend WithEvents prenom As DevComponents.DotNetBar.LabelX
    Friend WithEvents nom As DevComponents.DotNetBar.LabelX
    Friend WithEvents Conjdg As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ActualiserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
