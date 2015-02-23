<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class maladie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(maladie))
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NSS = New DevComponents.DotNetBar.LabelX()
        Me.sb = New DevComponents.DotNetBar.LabelX()
        Me.Date_entrée = New DevComponents.DotNetBar.LabelX()
        Me.Adresse = New DevComponents.DotNetBar.LabelX()
        Me.Lieux_de_Naissance = New DevComponents.DotNetBar.LabelX()
        Me.Fonction = New DevComponents.DotNetBar.LabelX()
        Me.Date_de_Naissance = New DevComponents.DotNetBar.LabelX()
        Me.prenom = New DevComponents.DotNetBar.LabelX()
        Me.nom = New DevComponents.DotNetBar.LabelX()
        Me.ListMatNom = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Ajouter = New DevComponents.DotNetBar.ButtonX()
        Me.observation = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.b = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimeInput2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.DateTimeInput1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.prenomMalade = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.montant_consult = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.montant = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.medecin = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.StatImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.maladiedgv = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ActualiserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ListMatNom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DateTimeInput2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTimeInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maladiedgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(410, 149)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(108, 13)
        Me.Label16.TabIndex = 235
        Me.Label16.Text = "N° Sécurite Sociale :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(410, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 232
        Me.Label8.Text = "Fonction :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(409, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 228
        Me.Label9.Text = "Date d'entrée :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(409, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 227
        Me.Label12.Text = "Adresse :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(409, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 226
        Me.Label13.Text = "LIEU :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(12, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 13)
        Me.Label14.TabIndex = 221
        Me.Label14.Text = "Date de Naissance :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(12, 87)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 13)
        Me.Label15.TabIndex = 220
        Me.Label15.Text = "Nom :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(12, 53)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 13)
        Me.Label17.TabIndex = 219
        Me.Label17.Text = "Prénom :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(12, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 13)
        Me.Label18.TabIndex = 218
        Me.Label18.Text = "Matricule :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(12, 147)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(151, 13)
        Me.Label20.TabIndex = 214
        Me.Label20.Text = "Salaire Brut et Montant S.S :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.NSS)
        Me.GroupBox2.Controls.Add(Me.sb)
        Me.GroupBox2.Controls.Add(Me.Date_entrée)
        Me.GroupBox2.Controls.Add(Me.Adresse)
        Me.GroupBox2.Controls.Add(Me.Lieux_de_Naissance)
        Me.GroupBox2.Controls.Add(Me.Fonction)
        Me.GroupBox2.Controls.Add(Me.Date_de_Naissance)
        Me.GroupBox2.Controls.Add(Me.prenom)
        Me.GroupBox2.Controls.Add(Me.nom)
        Me.GroupBox2.Controls.Add(Me.ListMatNom)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1292, 180)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Assuré :"
        '
        'NSS
        '
        Me.NSS.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.NSS.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NSS.ForeColor = System.Drawing.Color.Black
        Me.NSS.Location = New System.Drawing.Point(547, 137)
        Me.NSS.Name = "NSS"
        Me.NSS.Size = New System.Drawing.Size(188, 23)
        Me.NSS.TabIndex = 308
        '
        'sb
        '
        Me.sb.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.sb.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sb.ForeColor = System.Drawing.Color.Black
        Me.sb.Location = New System.Drawing.Point(187, 142)
        Me.sb.Name = "sb"
        Me.sb.Size = New System.Drawing.Size(217, 23)
        Me.sb.TabIndex = 307
        '
        'Date_entrée
        '
        Me.Date_entrée.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Date_entrée.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Date_entrée.ForeColor = System.Drawing.Color.Black
        Me.Date_entrée.Location = New System.Drawing.Point(547, 110)
        Me.Date_entrée.Name = "Date_entrée"
        Me.Date_entrée.Size = New System.Drawing.Size(188, 23)
        Me.Date_entrée.TabIndex = 306
        '
        'Adresse
        '
        Me.Adresse.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Adresse.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Adresse.ForeColor = System.Drawing.Color.Black
        Me.Adresse.Location = New System.Drawing.Point(547, 77)
        Me.Adresse.Name = "Adresse"
        Me.Adresse.Size = New System.Drawing.Size(188, 23)
        Me.Adresse.TabIndex = 305
        '
        'Lieux_de_Naissance
        '
        Me.Lieux_de_Naissance.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Lieux_de_Naissance.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Lieux_de_Naissance.ForeColor = System.Drawing.Color.Black
        Me.Lieux_de_Naissance.Location = New System.Drawing.Point(547, 46)
        Me.Lieux_de_Naissance.Name = "Lieux_de_Naissance"
        Me.Lieux_de_Naissance.Size = New System.Drawing.Size(188, 20)
        Me.Lieux_de_Naissance.TabIndex = 304
        '
        'Fonction
        '
        Me.Fonction.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Fonction.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Fonction.ForeColor = System.Drawing.Color.Black
        Me.Fonction.Location = New System.Drawing.Point(547, 14)
        Me.Fonction.Name = "Fonction"
        Me.Fonction.Size = New System.Drawing.Size(188, 23)
        Me.Fonction.TabIndex = 303
        '
        'Date_de_Naissance
        '
        Me.Date_de_Naissance.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Date_de_Naissance.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Date_de_Naissance.ForeColor = System.Drawing.Color.Black
        Me.Date_de_Naissance.Location = New System.Drawing.Point(187, 116)
        Me.Date_de_Naissance.Name = "Date_de_Naissance"
        Me.Date_de_Naissance.Size = New System.Drawing.Size(217, 23)
        Me.Date_de_Naissance.TabIndex = 302
        '
        'prenom
        '
        Me.prenom.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.prenom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.prenom.ForeColor = System.Drawing.Color.Black
        Me.prenom.Location = New System.Drawing.Point(187, 53)
        Me.prenom.Name = "prenom"
        Me.prenom.Size = New System.Drawing.Size(217, 23)
        Me.prenom.TabIndex = 301
        '
        'nom
        '
        Me.nom.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.nom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.nom.ForeColor = System.Drawing.Color.Black
        Me.nom.Location = New System.Drawing.Point(187, 87)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(217, 23)
        Me.nom.TabIndex = 300
        '
        'ListMatNom
        '
        Me.ListMatNom.Location = New System.Drawing.Point(165, 21)
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
        Me.ListMatNom.TabIndex = 299
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Ajouter)
        Me.GroupBox1.Controls.Add(Me.observation)
        Me.GroupBox1.Controls.Add(Me.b)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.DateTimeInput2)
        Me.GroupBox1.Controls.Add(Me.DateTimeInput1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.prenomMalade)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.montant_consult)
        Me.GroupBox1.Controls.Add(Me.montant)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.medecin)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 180)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1292, 176)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Maladie :"
        '
        'Ajouter
        '
        Me.Ajouter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Ajouter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Ajouter.Image = Global.MBA.My.Resources.Resources.add_button
        Me.Ajouter.Location = New System.Drawing.Point(943, 130)
        Me.Ajouter.Name = "Ajouter"
        Me.Ajouter.Size = New System.Drawing.Size(221, 23)
        Me.Ajouter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Ajouter.TabIndex = 245
        Me.Ajouter.Text = "Ajouter"
        '
        'observation
        '
        Me.observation.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.observation.Border.Class = "TextBoxBorder"
        Me.observation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.observation.ForeColor = System.Drawing.Color.Black
        Me.observation.Location = New System.Drawing.Point(584, 111)
        Me.observation.Multiline = True
        Me.observation.Name = "observation"
        Me.observation.Size = New System.Drawing.Size(224, 51)
        Me.observation.TabIndex = 244
        '
        'b
        '
        Me.b.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.b.Border.Class = "TextBoxBorder"
        Me.b.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.b.ForeColor = System.Drawing.Color.Black
        Me.b.Location = New System.Drawing.Point(187, 128)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(199, 22)
        Me.b.TabIndex = 243
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 13)
        Me.Label7.TabIndex = 242
        Me.Label7.Text = "B :"
        '
        'DateTimeInput2
        '
        Me.DateTimeInput2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.DateTimeInput2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DateTimeInput2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput2.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DateTimeInput2.ButtonDropDown.Visible = True
        Me.DateTimeInput2.ForeColor = System.Drawing.Color.Black
        Me.DateTimeInput2.Format = DevComponents.Editors.eDateTimePickerFormat.[Long]
        Me.DateTimeInput2.IsPopupCalendarOpen = False
        Me.DateTimeInput2.Location = New System.Drawing.Point(187, 97)
        '
        '
        '
        Me.DateTimeInput2.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DateTimeInput2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput2.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DateTimeInput2.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DateTimeInput2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DateTimeInput2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput2.MonthCalendar.DisplayMonth = New Date(2013, 12, 1, 0, 0, 0, 0)
        Me.DateTimeInput2.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.DateTimeInput2.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.DateTimeInput2.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimeInput2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DateTimeInput2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput2.MonthCalendar.TodayButtonVisible = True
        Me.DateTimeInput2.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.DateTimeInput2.Name = "DateTimeInput2"
        Me.DateTimeInput2.Size = New System.Drawing.Size(199, 22)
        Me.DateTimeInput2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DateTimeInput2.TabIndex = 241
        '
        'DateTimeInput1
        '
        Me.DateTimeInput1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.DateTimeInput1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DateTimeInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DateTimeInput1.ButtonDropDown.Visible = True
        Me.DateTimeInput1.ForeColor = System.Drawing.Color.Black
        Me.DateTimeInput1.Format = DevComponents.Editors.eDateTimePickerFormat.[Long]
        Me.DateTimeInput1.IsPopupCalendarOpen = False
        Me.DateTimeInput1.Location = New System.Drawing.Point(187, 64)
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput1.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DateTimeInput1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput1.MonthCalendar.DisplayMonth = New Date(2013, 12, 1, 0, 0, 0, 0)
        Me.DateTimeInput1.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.DateTimeInput1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.DateTimeInput1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput1.MonthCalendar.TodayButtonVisible = True
        Me.DateTimeInput1.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.DateTimeInput1.Name = "DateTimeInput1"
        Me.DateTimeInput1.Size = New System.Drawing.Size(199, 22)
        Me.DateTimeInput1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DateTimeInput1.TabIndex = 240
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 239
        Me.Label5.Text = "Dates soins :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 238
        Me.Label6.Text = "Dates envoi :"
        '
        'prenomMalade
        '
        Me.prenomMalade.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.prenomMalade.Border.Class = "TextBoxBorder"
        Me.prenomMalade.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.prenomMalade.ForeColor = System.Drawing.Color.Black
        Me.prenomMalade.Location = New System.Drawing.Point(584, 27)
        Me.prenomMalade.Name = "prenomMalade"
        Me.prenomMalade.Size = New System.Drawing.Size(224, 22)
        Me.prenomMalade.TabIndex = 232
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(410, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 231
        Me.Label1.Text = "Prénom du malade :"
        '
        'montant_consult
        '
        Me.montant_consult.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.montant_consult.Border.Class = "TextBoxBorder"
        Me.montant_consult.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.montant_consult.ForeColor = System.Drawing.Color.Black
        Me.montant_consult.Location = New System.Drawing.Point(584, 85)
        Me.montant_consult.Name = "montant_consult"
        Me.montant_consult.Size = New System.Drawing.Size(224, 22)
        Me.montant_consult.TabIndex = 229
        '
        'montant
        '
        Me.montant.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.montant.Border.Class = "TextBoxBorder"
        Me.montant.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.montant.ForeColor = System.Drawing.Color.Black
        Me.montant.Location = New System.Drawing.Point(584, 56)
        Me.montant.Name = "montant"
        Me.montant.Size = New System.Drawing.Size(224, 22)
        Me.montant.TabIndex = 228
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(409, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 227
        Me.Label2.Text = "Observation :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(409, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 13)
        Me.Label3.TabIndex = 226
        Me.Label3.Text = "Montant consultation :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(409, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 225
        Me.Label4.Text = "Montant :"
        '
        'medecin
        '
        Me.medecin.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.medecin.Border.Class = "TextBoxBorder"
        Me.medecin.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.medecin.ForeColor = System.Drawing.Color.Black
        Me.medecin.Location = New System.Drawing.Point(187, 28)
        Me.medecin.Name = "medecin"
        Me.medecin.Size = New System.Drawing.Size(199, 22)
        Me.medecin.TabIndex = 221
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(12, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 218
        Me.Label10.Text = "Medecin :"
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
        'maladiedgv
        '
        Me.maladiedgv.ContextMenuStrip = Me.ContextMenuStrip1
        Me.maladiedgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.maladiedgv.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White
        Me.maladiedgv.EmbeddedNavigator.Appearance.ForeColor = System.Drawing.Color.Black
        Me.maladiedgv.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.maladiedgv.EmbeddedNavigator.Appearance.Options.UseForeColor = True
        Me.maladiedgv.Location = New System.Drawing.Point(0, 356)
        Me.maladiedgv.LookAndFeel.SkinName = "Office 2013"
        Me.maladiedgv.LookAndFeel.UseDefaultLookAndFeel = False
        Me.maladiedgv.MainView = Me.GridView1
        Me.maladiedgv.Name = "maladiedgv"
        Me.maladiedgv.Size = New System.Drawing.Size(1292, 357)
        Me.maladiedgv.TabIndex = 5
        Me.maladiedgv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActualiserToolStripMenuItem, Me.ModifierToolStripMenuItem, Me.SupprimerToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(265, 70)
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
        Me.ModifierToolStripMenuItem.Text = "     Modifier le soin selectionné"
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.SupprimerToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.delete
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.SupprimerToolStripMenuItem.Text = "     Supprimer  le soin"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.maladiedgv
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'maladie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1292, 713)
        Me.Controls.Add(Me.maladiedgv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "maladie"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dossier_maladie"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ListMatNom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DateTimeInput2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTimeInput1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maladiedgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents NSS As DevComponents.DotNetBar.LabelX
    Friend WithEvents sb As DevComponents.DotNetBar.LabelX
    Friend WithEvents Date_entrée As DevComponents.DotNetBar.LabelX
    Friend WithEvents Adresse As DevComponents.DotNetBar.LabelX
    Friend WithEvents Lieux_de_Naissance As DevComponents.DotNetBar.LabelX
    Friend WithEvents Fonction As DevComponents.DotNetBar.LabelX
    Friend WithEvents Date_de_Naissance As DevComponents.DotNetBar.LabelX
    Friend WithEvents prenom As DevComponents.DotNetBar.LabelX
    Friend WithEvents nom As DevComponents.DotNetBar.LabelX
    Friend WithEvents ListMatNom As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Ajouter As DevComponents.DotNetBar.ButtonX
    Friend WithEvents observation As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents b As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimeInput2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents DateTimeInput1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents prenomMalade As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents montant_consult As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents montant As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents medecin As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents StatImageList As System.Windows.Forms.ImageList
    Friend WithEvents maladiedgv As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ActualiserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
