<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjoutArretTravail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AjoutArretTravail))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NSS = New DevComponents.DotNetBar.LabelX()
        Me.Date_entrée = New DevComponents.DotNetBar.LabelX()
        Me.Adresse = New DevComponents.DotNetBar.LabelX()
        Me.Lieux_de_Naissance = New DevComponents.DotNetBar.LabelX()
        Me.Fonction = New DevComponents.DotNetBar.LabelX()
        Me.Date_de_Naissance = New DevComponents.DotNetBar.LabelX()
        Me.prenom = New DevComponents.DotNetBar.LabelX()
        Me.nom = New DevComponents.DotNetBar.LabelX()
        Me.ListMatNom = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.obs = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.NDJ = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NC = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.Ajouter = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ndl = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.sdl = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.au = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.DR = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Du = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.StatImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ListMatNom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.au, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Du, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.NSS)
        Me.GroupBox1.Controls.Add(Me.Date_entrée)
        Me.GroupBox1.Controls.Add(Me.Adresse)
        Me.GroupBox1.Controls.Add(Me.Lieux_de_Naissance)
        Me.GroupBox1.Controls.Add(Me.Fonction)
        Me.GroupBox1.Controls.Add(Me.Date_de_Naissance)
        Me.GroupBox1.Controls.Add(Me.prenom)
        Me.GroupBox1.Controls.Add(Me.nom)
        Me.GroupBox1.Controls.Add(Me.ListMatNom)
        Me.GroupBox1.Controls.Add(Me.obs)
        Me.GroupBox1.Controls.Add(Me.NDJ)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.NC)
        Me.GroupBox1.Controls.Add(Me.Ajouter)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.au)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.DR)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Du)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1111, 458)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Remplissez les informations suivante pour ajouter l'arret de travail :"
        '
        'NSS
        '
        Me.NSS.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.NSS.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NSS.ForeColor = System.Drawing.Color.Black
        Me.NSS.Location = New System.Drawing.Point(603, 151)
        Me.NSS.Name = "NSS"
        Me.NSS.Size = New System.Drawing.Size(229, 23)
        Me.NSS.TabIndex = 286
        '
        'Date_entrée
        '
        Me.Date_entrée.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Date_entrée.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Date_entrée.ForeColor = System.Drawing.Color.Black
        Me.Date_entrée.Location = New System.Drawing.Point(603, 114)
        Me.Date_entrée.Name = "Date_entrée"
        Me.Date_entrée.Size = New System.Drawing.Size(229, 23)
        Me.Date_entrée.TabIndex = 285
        '
        'Adresse
        '
        Me.Adresse.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Adresse.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Adresse.ForeColor = System.Drawing.Color.Black
        Me.Adresse.Location = New System.Drawing.Point(603, 91)
        Me.Adresse.Name = "Adresse"
        Me.Adresse.Size = New System.Drawing.Size(229, 23)
        Me.Adresse.TabIndex = 284
        '
        'Lieux_de_Naissance
        '
        Me.Lieux_de_Naissance.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Lieux_de_Naissance.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Lieux_de_Naissance.ForeColor = System.Drawing.Color.Black
        Me.Lieux_de_Naissance.Location = New System.Drawing.Point(603, 54)
        Me.Lieux_de_Naissance.Name = "Lieux_de_Naissance"
        Me.Lieux_de_Naissance.Size = New System.Drawing.Size(229, 20)
        Me.Lieux_de_Naissance.TabIndex = 283
        '
        'Fonction
        '
        Me.Fonction.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Fonction.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Fonction.ForeColor = System.Drawing.Color.Black
        Me.Fonction.Location = New System.Drawing.Point(603, 25)
        Me.Fonction.Name = "Fonction"
        Me.Fonction.Size = New System.Drawing.Size(229, 23)
        Me.Fonction.TabIndex = 282
        '
        'Date_de_Naissance
        '
        Me.Date_de_Naissance.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Date_de_Naissance.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Date_de_Naissance.ForeColor = System.Drawing.Color.Black
        Me.Date_de_Naissance.Location = New System.Drawing.Point(191, 118)
        Me.Date_de_Naissance.Name = "Date_de_Naissance"
        Me.Date_de_Naissance.Size = New System.Drawing.Size(229, 23)
        Me.Date_de_Naissance.TabIndex = 281
        '
        'prenom
        '
        Me.prenom.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.prenom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.prenom.ForeColor = System.Drawing.Color.Black
        Me.prenom.Location = New System.Drawing.Point(193, 57)
        Me.prenom.Name = "prenom"
        Me.prenom.Size = New System.Drawing.Size(229, 23)
        Me.prenom.TabIndex = 280
        '
        'nom
        '
        Me.nom.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.nom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.nom.ForeColor = System.Drawing.Color.Black
        Me.nom.Location = New System.Drawing.Point(193, 85)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(229, 23)
        Me.nom.TabIndex = 279
        '
        'ListMatNom
        '
        Me.ListMatNom.Location = New System.Drawing.Point(191, 23)
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
        Me.ListMatNom.Size = New System.Drawing.Size(229, 22)
        Me.ListMatNom.TabIndex = 265
        '
        'obs
        '
        Me.obs.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.obs.Border.Class = "TextBoxBorder"
        Me.obs.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.obs.ForeColor = System.Drawing.Color.Black
        Me.obs.Location = New System.Drawing.Point(603, 222)
        Me.obs.Multiline = True
        Me.obs.Name = "obs"
        Me.obs.Size = New System.Drawing.Size(229, 56)
        Me.obs.TabIndex = 198
        '
        'NDJ
        '
        Me.NDJ.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.NDJ.Border.Class = "TextBoxBorder"
        Me.NDJ.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NDJ.ForeColor = System.Drawing.Color.Black
        Me.NDJ.Location = New System.Drawing.Point(191, 222)
        Me.NDJ.Name = "NDJ"
        Me.NDJ.Size = New System.Drawing.Size(229, 25)
        Me.NDJ.TabIndex = 197
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(429, 154)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(119, 17)
        Me.Label16.TabIndex = 195
        Me.Label16.Text = "N° Sécurite Sociale :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(429, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 17)
        Me.Label14.TabIndex = 193
        Me.Label14.Text = "Fonction :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(428, 124)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 17)
        Me.Label9.TabIndex = 189
        Me.Label9.Text = "Date d'entrée :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(428, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 17)
        Me.Label12.TabIndex = 188
        Me.Label12.Text = "Adresse :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(428, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 17)
        Me.Label13.TabIndex = 187
        Me.Label13.Text = "LIEU :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 17)
        Me.Label1.TabIndex = 182
        Me.Label1.Text = "Date de Naissance :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 181
        Me.Label2.Text = "Nom :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(16, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 180
        Me.Label6.Text = "Prénom :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(16, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 17)
        Me.Label8.TabIndex = 179
        Me.Label8.Text = "Matricule :"
        '
        'NC
        '
        Me.NC.DisplayMember = "Text"
        Me.NC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.NC.ForeColor = System.Drawing.Color.Black
        Me.NC.FormattingEnabled = True
        Me.NC.ItemHeight = 19
        Me.NC.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4, Me.ComboItem5, Me.ComboItem6, Me.ComboItem7})
        Me.NC.Location = New System.Drawing.Point(191, 151)
        Me.NC.Name = "NC"
        Me.NC.Size = New System.Drawing.Size(229, 25)
        Me.NC.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.NC.TabIndex = 178
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Congé de Maladie"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Accident de Travail"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Accident de la Circulation"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Hostpitalisation"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "Convalescence"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "Contre Visite médicale"
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "Maladie de longue Durée"
        '
        'Ajouter
        '
        Me.Ajouter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Ajouter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Ajouter.Image = Global.MBA.My.Resources.Resources.adde
        Me.Ajouter.Location = New System.Drawing.Point(343, 408)
        Me.Ajouter.Name = "Ajouter"
        Me.Ajouter.PressedImage = Global.MBA.My.Resources.Resources.adde
        Me.Ajouter.Size = New System.Drawing.Size(309, 24)
        Me.Ajouter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Ajouter.TabIndex = 177
        Me.Ajouter.Text = "Ajouter"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.ndl)
        Me.GroupBox2.Controls.Add(Me.sdl)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(16, 284)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(816, 105)
        Me.GroupBox2.TabIndex = 171
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Accident de travail : "
        '
        'ndl
        '
        Me.ndl.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.ndl.Border.Class = "TextBoxBorder"
        Me.ndl.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ndl.ForeColor = System.Drawing.Color.Black
        Me.ndl.Location = New System.Drawing.Point(564, 32)
        Me.ndl.Multiline = True
        Me.ndl.Name = "ndl"
        Me.ndl.Size = New System.Drawing.Size(241, 54)
        Me.ndl.TabIndex = 166
        '
        'sdl
        '
        Me.sdl.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.sdl.Border.Class = "TextBoxBorder"
        Me.sdl.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sdl.ForeColor = System.Drawing.Color.Black
        Me.sdl.Location = New System.Drawing.Point(157, 32)
        Me.sdl.Multiline = True
        Me.sdl.Name = "sdl"
        Me.sdl.Size = New System.Drawing.Size(241, 54)
        Me.sdl.TabIndex = 165
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 17)
        Me.Label5.TabIndex = 155
        Me.Label5.Text = "Siege des liaisions"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(415, 34)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(114, 17)
        Me.Label15.TabIndex = 159
        Me.Label15.Text = "Nature des liaisions"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(429, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 17)
        Me.Label3.TabIndex = 169
        Me.Label3.Text = "Au"
        '
        'au
        '
        Me.au.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.au.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.au.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.au.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.au.ButtonDropDown.Visible = True
        Me.au.ForeColor = System.Drawing.Color.Black
        Me.au.Format = DevComponents.Editors.eDateTimePickerFormat.[Long]
        Me.au.IsPopupCalendarOpen = False
        Me.au.Location = New System.Drawing.Point(603, 190)
        Me.au.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        '
        '
        '
        Me.au.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.au.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.au.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.au.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.au.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.au.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.au.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.au.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.au.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.au.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.au.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.au.MonthCalendar.DisplayMonth = New Date(2013, 12, 1, 0, 0, 0, 0)
        Me.au.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.au.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.au.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.au.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.au.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.au.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.au.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.au.MonthCalendar.TodayButtonVisible = True
        Me.au.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.au.Name = "au"
        Me.au.Size = New System.Drawing.Size(229, 25)
        Me.au.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.au.TabIndex = 168
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(429, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 154
        Me.Label4.Text = "Observation"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(16, 253)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(93, 17)
        Me.Label20.TabIndex = 150
        Me.Label20.Text = "Date de reprise"
        '
        'DR
        '
        Me.DR.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.DR.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DR.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DR.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DR.ButtonDropDown.Visible = True
        Me.DR.ForeColor = System.Drawing.Color.Black
        Me.DR.Format = DevComponents.Editors.eDateTimePickerFormat.[Long]
        Me.DR.IsPopupCalendarOpen = False
        Me.DR.Location = New System.Drawing.Point(191, 253)
        Me.DR.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        '
        '
        '
        Me.DR.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DR.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DR.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DR.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DR.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DR.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DR.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DR.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DR.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DR.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DR.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DR.MonthCalendar.DisplayMonth = New Date(2013, 12, 1, 0, 0, 0, 0)
        Me.DR.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.DR.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.DR.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DR.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DR.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DR.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DR.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DR.MonthCalendar.TodayButtonVisible = True
        Me.DR.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.DR.Name = "DR"
        Me.DR.Size = New System.Drawing.Size(229, 25)
        Me.DR.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DR.TabIndex = 149
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(16, 222)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(124, 17)
        Me.Label19.TabIndex = 148
        Me.Label19.Text = "Nombre de jours pris"
        '
        'Du
        '
        Me.Du.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Du.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Du.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Du.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.Du.ButtonDropDown.Visible = True
        Me.Du.ForeColor = System.Drawing.Color.Black
        Me.Du.Format = DevComponents.Editors.eDateTimePickerFormat.[Long]
        Me.Du.IsPopupCalendarOpen = False
        Me.Du.Location = New System.Drawing.Point(191, 190)
        Me.Du.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        '
        '
        '
        Me.Du.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.Du.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Du.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.Du.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.Du.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Du.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.Du.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Du.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Du.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.Du.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.Du.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Du.MonthCalendar.DisplayMonth = New Date(2013, 12, 1, 0, 0, 0, 0)
        Me.Du.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.Du.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.Du.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.Du.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Du.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.Du.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Du.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Du.MonthCalendar.TodayButtonVisible = True
        Me.Du.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.Du.Name = "Du"
        Me.Du.Size = New System.Drawing.Size(229, 25)
        Me.Du.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Du.TabIndex = 147
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(16, 157)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 17)
        Me.Label11.TabIndex = 145
        Me.Label11.Text = "Nature du congé"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(17, 190)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 17)
        Me.Label10.TabIndex = 144
        Me.Label10.Text = "Arret du "
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
        'AjoutArretTravail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1111, 578)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AjoutArretTravail"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajout Arret de Travail"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ListMatNom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.au, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Du, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents DR As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Du As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents au As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents sdl As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ndl As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Ajouter As DevComponents.DotNetBar.ButtonX
    Friend WithEvents NC As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents NDJ As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents obs As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ListMatNom As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents StatImageList As System.Windows.Forms.ImageList
    Friend WithEvents NSS As DevComponents.DotNetBar.LabelX
    Friend WithEvents Date_entrée As DevComponents.DotNetBar.LabelX
    Friend WithEvents Adresse As DevComponents.DotNetBar.LabelX
    Friend WithEvents Lieux_de_Naissance As DevComponents.DotNetBar.LabelX
    Friend WithEvents Fonction As DevComponents.DotNetBar.LabelX
    Friend WithEvents Date_de_Naissance As DevComponents.DotNetBar.LabelX
    Friend WithEvents prenom As DevComponents.DotNetBar.LabelX
    Friend WithEvents nom As DevComponents.DotNetBar.LabelX
End Class
