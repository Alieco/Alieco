<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddVacation
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Fonction = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Date_entrée = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Adresse = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Lieux_de_Naissance = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Date_de_Naissance = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.mat = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.nom = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.prenom = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.typeconge = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ndj = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.au = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.du = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Date_entrée, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_de_Naissance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.au, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.du, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Fonction)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Date_entrée)
        Me.GroupBox1.Controls.Add(Me.Adresse)
        Me.GroupBox1.Controls.Add(Me.Lieux_de_Naissance)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Date_de_Naissance)
        Me.GroupBox1.Controls.Add(Me.mat)
        Me.GroupBox1.Controls.Add(Me.nom)
        Me.GroupBox1.Controls.Add(Me.prenom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(938, 163)
        Me.GroupBox1.TabIndex = 120
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identification d'un fonctionnaire :"
        '
        'Fonction
        '
        Me.Fonction.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Fonction.Border.Class = "TextBoxBorder"
        Me.Fonction.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Fonction.ForeColor = System.Drawing.Color.Black
        Me.Fonction.Location = New System.Drawing.Point(615, 31)
        Me.Fonction.Name = "Fonction"
        Me.Fonction.Size = New System.Drawing.Size(229, 25)
        Me.Fonction.TabIndex = 210
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(441, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 17)
        Me.Label14.TabIndex = 209
        Me.Label14.Text = "Fonction :"
        '
        'Date_entrée
        '
        Me.Date_entrée.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Date_entrée.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Date_entrée.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Date_entrée.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.Date_entrée.ButtonDropDown.Visible = True
        Me.Date_entrée.ForeColor = System.Drawing.Color.Black
        Me.Date_entrée.Format = DevComponents.Editors.eDateTimePickerFormat.[Long]
        Me.Date_entrée.IsPopupCalendarOpen = False
        Me.Date_entrée.Location = New System.Drawing.Point(615, 123)
        '
        '
        '
        Me.Date_entrée.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.Date_entrée.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Date_entrée.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.Date_entrée.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.Date_entrée.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Date_entrée.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.Date_entrée.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Date_entrée.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Date_entrée.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.Date_entrée.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.Date_entrée.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Date_entrée.MonthCalendar.DisplayMonth = New Date(2013, 12, 1, 0, 0, 0, 0)
        Me.Date_entrée.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.Date_entrée.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.Date_entrée.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.Date_entrée.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Date_entrée.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.Date_entrée.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Date_entrée.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Date_entrée.MonthCalendar.TodayButtonVisible = True
        Me.Date_entrée.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.Date_entrée.Name = "Date_entrée"
        Me.Date_entrée.Size = New System.Drawing.Size(229, 25)
        Me.Date_entrée.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Date_entrée.TabIndex = 208
        '
        'Adresse
        '
        Me.Adresse.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Adresse.Border.Class = "TextBoxBorder"
        Me.Adresse.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Adresse.ForeColor = System.Drawing.Color.Black
        Me.Adresse.Location = New System.Drawing.Point(615, 94)
        Me.Adresse.Name = "Adresse"
        Me.Adresse.Size = New System.Drawing.Size(229, 25)
        Me.Adresse.TabIndex = 207
        '
        'Lieux_de_Naissance
        '
        Me.Lieux_de_Naissance.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Lieux_de_Naissance.Border.Class = "TextBoxBorder"
        Me.Lieux_de_Naissance.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Lieux_de_Naissance.ForeColor = System.Drawing.Color.Black
        Me.Lieux_de_Naissance.Location = New System.Drawing.Point(615, 60)
        Me.Lieux_de_Naissance.Name = "Lieux_de_Naissance"
        Me.Lieux_de_Naissance.Size = New System.Drawing.Size(229, 25)
        Me.Lieux_de_Naissance.TabIndex = 206
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(440, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 17)
        Me.Label9.TabIndex = 205
        Me.Label9.Text = "Date d'entrée :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(440, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 17)
        Me.Label12.TabIndex = 204
        Me.Label12.Text = "Adresse :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(440, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 17)
        Me.Label13.TabIndex = 203
        Me.Label13.Text = "LIEU :"
        '
        'Date_de_Naissance
        '
        Me.Date_de_Naissance.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Date_de_Naissance.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Date_de_Naissance.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Date_de_Naissance.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.Date_de_Naissance.ButtonDropDown.Visible = True
        Me.Date_de_Naissance.ForeColor = System.Drawing.Color.Black
        Me.Date_de_Naissance.Format = DevComponents.Editors.eDateTimePickerFormat.[Long]
        Me.Date_de_Naissance.IsPopupCalendarOpen = False
        Me.Date_de_Naissance.Location = New System.Drawing.Point(203, 123)
        '
        '
        '
        Me.Date_de_Naissance.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.Date_de_Naissance.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Date_de_Naissance.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.Date_de_Naissance.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.Date_de_Naissance.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Date_de_Naissance.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.Date_de_Naissance.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Date_de_Naissance.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Date_de_Naissance.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.Date_de_Naissance.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.Date_de_Naissance.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Date_de_Naissance.MonthCalendar.DisplayMonth = New Date(2013, 12, 1, 0, 0, 0, 0)
        Me.Date_de_Naissance.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.Date_de_Naissance.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.Date_de_Naissance.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.Date_de_Naissance.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Date_de_Naissance.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.Date_de_Naissance.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Date_de_Naissance.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Date_de_Naissance.MonthCalendar.TodayButtonVisible = True
        Me.Date_de_Naissance.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.Date_de_Naissance.Name = "Date_de_Naissance"
        Me.Date_de_Naissance.Size = New System.Drawing.Size(229, 25)
        Me.Date_de_Naissance.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Date_de_Naissance.TabIndex = 202
        '
        'mat
        '
        Me.mat.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.mat.BackgroundStyle.Class = "TextBoxBorder"
        Me.mat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mat.ButtonClear.Visible = True
        Me.mat.ForeColor = System.Drawing.Color.Black
        Me.mat.Location = New System.Drawing.Point(203, 29)
        Me.mat.Mask = "00000"
        Me.mat.Name = "mat"
        Me.mat.Size = New System.Drawing.Size(229, 25)
        Me.mat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.mat.TabIndex = 201
        Me.mat.Text = ""
        '
        'nom
        '
        Me.nom.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.nom.Border.Class = "TextBoxBorder"
        Me.nom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.nom.ForeColor = System.Drawing.Color.Black
        Me.nom.Location = New System.Drawing.Point(203, 94)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(229, 25)
        Me.nom.TabIndex = 200
        '
        'prenom
        '
        Me.prenom.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.prenom.Border.Class = "TextBoxBorder"
        Me.prenom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.prenom.ForeColor = System.Drawing.Color.Black
        Me.prenom.Location = New System.Drawing.Point(203, 60)
        Me.prenom.Name = "prenom"
        Me.prenom.Size = New System.Drawing.Size(229, 25)
        Me.prenom.TabIndex = 199
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(28, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 17)
        Me.Label1.TabIndex = 198
        Me.Label1.Text = "Date de Naissance :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(28, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 197
        Me.Label2.Text = "Nom :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(28, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 196
        Me.Label6.Text = "Prénom :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(28, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 17)
        Me.Label8.TabIndex = 195
        Me.Label8.Text = "Matricule :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.ButtonX2)
        Me.GroupBox2.Controls.Add(Me.typeconge)
        Me.GroupBox2.Controls.Add(Me.ndj)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.au)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.du)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(12, 181)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(938, 146)
        Me.GroupBox2.TabIndex = 121
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Congé :"
        '
        'typeconge
        '
        Me.typeconge.DisplayMember = "Text"
        Me.typeconge.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.typeconge.FormattingEnabled = True
        Me.typeconge.ItemHeight = 19
        Me.typeconge.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4})
        Me.typeconge.Location = New System.Drawing.Point(615, 60)
        Me.typeconge.Name = "typeconge"
        Me.typeconge.Size = New System.Drawing.Size(229, 25)
        Me.typeconge.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.typeconge.TabIndex = 211
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Congé Annuel"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Congé Maladie"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Congé statutaire"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Recuperation"
        '
        'ndj
        '
        Me.ndj.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.ndj.Border.Class = "TextBoxBorder"
        Me.ndj.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ndj.ForeColor = System.Drawing.Color.Black
        Me.ndj.Location = New System.Drawing.Point(203, 60)
        Me.ndj.Name = "ndj"
        Me.ndj.Size = New System.Drawing.Size(229, 25)
        Me.ndj.TabIndex = 210
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(449, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 17)
        Me.Label3.TabIndex = 209
        Me.Label3.Text = "Au :"
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
        Me.au.Location = New System.Drawing.Point(615, 31)
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
        Me.au.TabIndex = 208
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(440, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 17)
        Me.Label7.TabIndex = 203
        Me.Label7.Text = "Type de Congé :"
        '
        'du
        '
        Me.du.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.du.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.du.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.du.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.du.ButtonDropDown.Visible = True
        Me.du.ForeColor = System.Drawing.Color.Black
        Me.du.Format = DevComponents.Editors.eDateTimePickerFormat.[Long]
        Me.du.IsPopupCalendarOpen = False
        Me.du.Location = New System.Drawing.Point(203, 31)
        '
        '
        '
        Me.du.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.du.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.du.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.du.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.du.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.du.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.du.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.du.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.du.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.du.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.du.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.du.MonthCalendar.DisplayMonth = New Date(2013, 12, 1, 0, 0, 0, 0)
        Me.du.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.du.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.du.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.du.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.du.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.du.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.du.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.du.MonthCalendar.TodayButtonVisible = True
        Me.du.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.du.Name = "du"
        Me.du.Size = New System.Drawing.Size(229, 25)
        Me.du.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.du.TabIndex = 202
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(28, 62)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(108, 17)
        Me.Label15.TabIndex = 196
        Me.Label15.Text = "Nombre du jours :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(28, 33)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 17)
        Me.Label16.TabIndex = 195
        Me.Label16.Text = "Du :"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = Global.MBA.My.Resources.Resources.adde
        Me.ButtonX2.Location = New System.Drawing.Point(685, 114)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.PressedImage = Global.MBA.My.Resources.Resources.adde
        Me.ButtonX2.Size = New System.Drawing.Size(229, 24)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 212
        Me.ButtonX2.Text = "Ajouter"
        '
        'AddVacation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 551)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AddVacation"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajouter un congé"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Date_entrée, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_de_Naissance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.au, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.du, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Fonction As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Date_entrée As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Adresse As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Lieux_de_Naissance As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Date_de_Naissance As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents mat As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents nom As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents prenom As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents au As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents du As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ndj As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents typeconge As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
End Class
