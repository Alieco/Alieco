<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAttendance
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.entry1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.sortie1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.entry2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.sortie2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Motif = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.entry3 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Fonction = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Adresse = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Lieux_de_Naissance = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.mat = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.nom = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.prenom = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sortie3 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Du = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.entry1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sortie1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.entry2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sortie2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.entry3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sortie3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Du, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.entry1)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.sortie1)
        Me.GroupBox1.Controls.Add(Me.entry2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.sortie2)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Motif)
        Me.GroupBox1.Controls.Add(Me.entry3)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Fonction)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Adresse)
        Me.GroupBox1.Controls.Add(Me.Lieux_de_Naissance)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.mat)
        Me.GroupBox1.Controls.Add(Me.nom)
        Me.GroupBox1.Controls.Add(Me.prenom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ButtonX2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.sortie3)
        Me.GroupBox1.Controls.Add(Me.Du)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(937, 565)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Remplissez les informations suivante pour ajouter l'arret de travail :"
        '
        'entry1
        '
        Me.entry1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.entry1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.entry1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.entry1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.entry1.ButtonDropDown.Visible = True
        Me.entry1.ForeColor = System.Drawing.Color.Black
        Me.entry1.Format = DevComponents.Editors.eDateTimePickerFormat.LongTime
        Me.entry1.IsPopupCalendarOpen = False
        Me.entry1.Location = New System.Drawing.Point(170, 258)
        Me.entry1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        '
        '
        '
        Me.entry1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.entry1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.entry1.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.entry1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.entry1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.entry1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.entry1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.entry1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.entry1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.entry1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.entry1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.entry1.MonthCalendar.DisplayMonth = New Date(2013, 12, 1, 0, 0, 0, 0)
        Me.entry1.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.entry1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.entry1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.entry1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.entry1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.entry1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.entry1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.entry1.MonthCalendar.TodayButtonVisible = True
        Me.entry1.MonthCalendar.Visible = False
        Me.entry1.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.entry1.Name = "entry1"
        Me.entry1.Size = New System.Drawing.Size(84, 25)
        Me.entry1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.entry1.TabIndex = 216
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(67, 258)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 17)
        Me.Label15.TabIndex = 215
        Me.Label15.Text = "Heure d'entrée :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(67, 291)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 17)
        Me.Label17.TabIndex = 213
        Me.Label17.Text = "Heure de sortie:"
        '
        'sortie1
        '
        Me.sortie1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.sortie1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.sortie1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sortie1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.sortie1.ButtonDropDown.Visible = True
        Me.sortie1.ForeColor = System.Drawing.Color.Black
        Me.sortie1.Format = DevComponents.Editors.eDateTimePickerFormat.LongTime
        Me.sortie1.IsPopupCalendarOpen = False
        Me.sortie1.Location = New System.Drawing.Point(168, 288)
        Me.sortie1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sortie1.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        '
        '
        '
        Me.sortie1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.sortie1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sortie1.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.sortie1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.sortie1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.sortie1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.sortie1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.sortie1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.sortie1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.sortie1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.sortie1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sortie1.MonthCalendar.DisplayMonth = New Date(2013, 12, 1, 0, 0, 0, 0)
        Me.sortie1.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.sortie1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.sortie1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.sortie1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.sortie1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.sortie1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.sortie1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sortie1.MonthCalendar.TodayButtonVisible = True
        Me.sortie1.MonthCalendar.Visible = False
        Me.sortie1.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.sortie1.Name = "sortie1"
        Me.sortie1.Size = New System.Drawing.Size(86, 25)
        Me.sortie1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.sortie1.TabIndex = 212
        '
        'entry2
        '
        Me.entry2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.entry2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.entry2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.entry2.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.entry2.ButtonDropDown.Visible = True
        Me.entry2.ForeColor = System.Drawing.Color.Black
        Me.entry2.Format = DevComponents.Editors.eDateTimePickerFormat.LongTime
        Me.entry2.IsPopupCalendarOpen = False
        Me.entry2.Location = New System.Drawing.Point(363, 261)
        Me.entry2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        '
        '
        '
        Me.entry2.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.entry2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.entry2.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.entry2.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.entry2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.entry2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.entry2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.entry2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.entry2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.entry2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.entry2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.entry2.MonthCalendar.DisplayMonth = New Date(2013, 12, 1, 0, 0, 0, 0)
        Me.entry2.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.entry2.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.entry2.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.entry2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.entry2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.entry2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.entry2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.entry2.MonthCalendar.TodayButtonVisible = True
        Me.entry2.MonthCalendar.Visible = False
        Me.entry2.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.entry2.Name = "entry2"
        Me.entry2.Size = New System.Drawing.Size(89, 25)
        Me.entry2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.entry2.TabIndex = 208
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(260, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 17)
        Me.Label4.TabIndex = 207
        Me.Label4.Text = "Heure d'entrée :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(238, 379)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 17)
        Me.Label5.TabIndex = 206
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(260, 294)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 17)
        Me.Label7.TabIndex = 205
        Me.Label7.Text = "Heure de sortie:"
        '
        'sortie2
        '
        Me.sortie2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.sortie2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.sortie2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sortie2.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.sortie2.ButtonDropDown.Visible = True
        Me.sortie2.ForeColor = System.Drawing.Color.Black
        Me.sortie2.Format = DevComponents.Editors.eDateTimePickerFormat.LongTime
        Me.sortie2.IsPopupCalendarOpen = False
        Me.sortie2.Location = New System.Drawing.Point(363, 291)
        Me.sortie2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sortie2.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        '
        '
        '
        Me.sortie2.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.sortie2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sortie2.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.sortie2.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.sortie2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.sortie2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.sortie2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.sortie2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.sortie2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.sortie2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.sortie2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sortie2.MonthCalendar.DisplayMonth = New Date(2013, 12, 1, 0, 0, 0, 0)
        Me.sortie2.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.sortie2.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.sortie2.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.sortie2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.sortie2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.sortie2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.sortie2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sortie2.MonthCalendar.TodayButtonVisible = True
        Me.sortie2.MonthCalendar.Visible = False
        Me.sortie2.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.sortie2.Name = "sortie2"
        Me.sortie2.Size = New System.Drawing.Size(89, 25)
        Me.sortie2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.sortie2.TabIndex = 204
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(145, 379)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 17)
        Me.Label11.TabIndex = 202
        Me.Label11.Text = "Absence :"
        '
        'Motif
        '
        Me.Motif.DisplayMember = "Text"
        Me.Motif.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Motif.ForeColor = System.Drawing.Color.Black
        Me.Motif.FormattingEnabled = True
        Me.Motif.ItemHeight = 19
        Me.Motif.Location = New System.Drawing.Point(465, 176)
        Me.Motif.Name = "Motif"
        Me.Motif.Size = New System.Drawing.Size(219, 25)
        Me.Motif.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Motif.TabIndex = 201
        '
        'entry3
        '
        Me.entry3.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.entry3.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.entry3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.entry3.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.entry3.ButtonDropDown.Visible = True
        Me.entry3.ForeColor = System.Drawing.Color.Black
        Me.entry3.Format = DevComponents.Editors.eDateTimePickerFormat.LongTime
        Me.entry3.IsPopupCalendarOpen = False
        Me.entry3.Location = New System.Drawing.Point(581, 258)
        Me.entry3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        '
        '
        '
        Me.entry3.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.entry3.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.entry3.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.entry3.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.entry3.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.entry3.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.entry3.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.entry3.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.entry3.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.entry3.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.entry3.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.entry3.MonthCalendar.DisplayMonth = New Date(2013, 12, 1, 0, 0, 0, 0)
        Me.entry3.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.entry3.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.entry3.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.entry3.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.entry3.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.entry3.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.entry3.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.entry3.MonthCalendar.TodayButtonVisible = True
        Me.entry3.MonthCalendar.Visible = False
        Me.entry3.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.entry3.Name = "entry3"
        Me.entry3.Size = New System.Drawing.Size(103, 25)
        Me.entry3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.entry3.TabIndex = 200
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(478, 258)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 17)
        Me.Label9.TabIndex = 199
        Me.Label9.Text = "Heure d'entrée :"
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
        Me.Fonction.Location = New System.Drawing.Point(465, 38)
        Me.Fonction.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Fonction.Name = "Fonction"
        Me.Fonction.Size = New System.Drawing.Size(219, 25)
        Me.Fonction.TabIndex = 194
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(340, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 17)
        Me.Label14.TabIndex = 193
        Me.Label14.Text = "Fonction :"
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
        Me.Adresse.Location = New System.Drawing.Point(465, 109)
        Me.Adresse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Adresse.Name = "Adresse"
        Me.Adresse.Size = New System.Drawing.Size(219, 25)
        Me.Adresse.TabIndex = 191
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
        Me.Lieux_de_Naissance.Location = New System.Drawing.Point(465, 76)
        Me.Lieux_de_Naissance.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Lieux_de_Naissance.Name = "Lieux_de_Naissance"
        Me.Lieux_de_Naissance.Size = New System.Drawing.Size(219, 25)
        Me.Lieux_de_Naissance.TabIndex = 190
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(339, 111)
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
        Me.Label13.Location = New System.Drawing.Point(339, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 17)
        Me.Label13.TabIndex = 187
        Me.Label13.Text = "LIEU :"
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
        Me.mat.Location = New System.Drawing.Point(148, 38)
        Me.mat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mat.Mask = "00000"
        Me.mat.Name = "mat"
        Me.mat.Size = New System.Drawing.Size(186, 26)
        Me.mat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.mat.TabIndex = 185
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
        Me.nom.Location = New System.Drawing.Point(148, 109)
        Me.nom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(186, 25)
        Me.nom.TabIndex = 184
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
        Me.prenom.Location = New System.Drawing.Point(148, 76)
        Me.prenom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.prenom.Name = "prenom"
        Me.prenom.Size = New System.Drawing.Size(185, 25)
        Me.prenom.TabIndex = 183
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(343, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 182
        Me.Label1.Text = "Motif:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 111)
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
        Me.Label6.Location = New System.Drawing.Point(19, 78)
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
        Me.Label8.Location = New System.Drawing.Point(19, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 17)
        Me.Label8.TabIndex = 179
        Me.Label8.Text = "Matricule :"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = Global.MBA.My.Resources.Resources.adde
        Me.ButtonX2.Location = New System.Drawing.Point(148, 438)
        Me.ButtonX2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.PressedImage = Global.MBA.My.Resources.Resources.adde
        Me.ButtonX2.Size = New System.Drawing.Size(536, 24)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 177
        Me.ButtonX2.Text = "Ajouter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(478, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 169
        Me.Label3.Text = "Heure de sortie:"
        '
        'sortie3
        '
        Me.sortie3.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.sortie3.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.sortie3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sortie3.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.sortie3.ButtonDropDown.Visible = True
        Me.sortie3.ForeColor = System.Drawing.Color.Black
        Me.sortie3.Format = DevComponents.Editors.eDateTimePickerFormat.LongTime
        Me.sortie3.IsPopupCalendarOpen = False
        Me.sortie3.Location = New System.Drawing.Point(581, 288)
        Me.sortie3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sortie3.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        '
        '
        '
        Me.sortie3.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.sortie3.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sortie3.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.sortie3.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.sortie3.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.sortie3.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.sortie3.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.sortie3.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.sortie3.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.sortie3.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.sortie3.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sortie3.MonthCalendar.DisplayMonth = New Date(2013, 12, 1, 0, 0, 0, 0)
        Me.sortie3.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.sortie3.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.sortie3.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.sortie3.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.sortie3.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.sortie3.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.sortie3.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sortie3.MonthCalendar.TodayButtonVisible = True
        Me.sortie3.MonthCalendar.Visible = False
        Me.sortie3.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.sortie3.Name = "sortie3"
        Me.sortie3.Size = New System.Drawing.Size(103, 25)
        Me.sortie3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.sortie3.TabIndex = 168
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
        Me.Du.Location = New System.Drawing.Point(148, 176)
        Me.Du.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
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
        Me.Du.Size = New System.Drawing.Size(186, 25)
        Me.Du.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Du.TabIndex = 147
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(15, 177)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 17)
        Me.Label10.TabIndex = 144
        Me.Label10.Text = "Date de pointage:"
        '
        'AddAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 565)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddAttendance"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ajouter-Modifier un pointage "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.entry1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sortie1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.entry2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sortie2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.entry3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sortie3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Du, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Fonction As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Adresse As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Lieux_de_Naissance As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents mat As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents nom As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents prenom As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents sortie3 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Du As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents entry3 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Motif As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents entry1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents sortie1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents entry2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents sortie2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
