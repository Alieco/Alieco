<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportPresence
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.AuH = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.AuF = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.duR = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.auN = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.duN = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Grid1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.AuH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.duR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.auN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.duN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.ButtonX2)
        Me.GroupBox1.Controls.Add(Me.TextBoxX1)
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1222, 121)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selectionner le fichier de présence  :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelX7)
        Me.GroupBox3.Controls.Add(Me.LabelX6)
        Me.GroupBox3.Controls.Add(Me.LabelX5)
        Me.GroupBox3.Controls.Add(Me.AuH)
        Me.GroupBox3.Controls.Add(Me.RadioButton2)
        Me.GroupBox3.Controls.Add(Me.LabelX3)
        Me.GroupBox3.Controls.Add(Me.AuF)
        Me.GroupBox3.Controls.Add(Me.LabelX4)
        Me.GroupBox3.Controls.Add(Me.duR)
        Me.GroupBox3.Location = New System.Drawing.Point(758, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(342, 91)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Etat Ramadan"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.ForeColor = System.Drawing.Color.DimGray
        Me.LabelX7.Location = New System.Drawing.Point(270, 69)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(42, 15)
        Me.LabelX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.LabelX7.TabIndex = 8
        Me.LabelX7.Text = "Homme"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.ForeColor = System.Drawing.Color.DimGray
        Me.LabelX6.Location = New System.Drawing.Point(163, 69)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(42, 15)
        Me.LabelX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.LabelX6.TabIndex = 7
        Me.LabelX6.Text = "Femme"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(226, 41)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(23, 23)
        Me.LabelX5.TabIndex = 6
        Me.LabelX5.Text = "Au"
        '
        'AuH
        '
        '
        '
        '
        Me.AuH.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.AuH.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AuH.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.AuH.ButtonDropDown.Visible = True
        Me.AuH.Format = DevComponents.Editors.eDateTimePickerFormat.LongTime
        Me.AuH.IsPopupCalendarOpen = False
        Me.AuH.Location = New System.Drawing.Point(255, 41)
        '
        '
        '
        Me.AuH.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.AuH.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AuH.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.AuH.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.AuH.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.AuH.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.AuH.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.AuH.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.AuH.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.AuH.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.AuH.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AuH.MonthCalendar.DisplayMonth = New Date(2014, 6, 1, 0, 0, 0, 0)
        Me.AuH.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.AuH.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.AuH.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.AuH.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.AuH.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.AuH.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.AuH.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AuH.MonthCalendar.TodayButtonVisible = True
        Me.AuH.MonthCalendar.Visible = False
        Me.AuH.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.AuH.Name = "AuH"
        Me.AuH.Size = New System.Drawing.Size(71, 25)
        Me.AuH.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AuH.TabIndex = 5
        Me.AuH.Value = New Date(2014, 6, 21, 14, 30, 0, 0)
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RadioButton2.Location = New System.Drawing.Point(6, 17)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(142, 21)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.Text = "Activer l'etat Ramdan"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(120, 41)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(23, 23)
        Me.LabelX3.TabIndex = 3
        Me.LabelX3.Text = "Au"
        '
        'AuF
        '
        '
        '
        '
        Me.AuF.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.AuF.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AuF.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.AuF.ButtonDropDown.Visible = True
        Me.AuF.Format = DevComponents.Editors.eDateTimePickerFormat.LongTime
        Me.AuF.IsPopupCalendarOpen = False
        Me.AuF.Location = New System.Drawing.Point(149, 41)
        '
        '
        '
        Me.AuF.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.AuF.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AuF.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.AuF.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.AuF.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.AuF.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.AuF.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.AuF.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.AuF.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.AuF.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.AuF.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AuF.MonthCalendar.DisplayMonth = New Date(2014, 6, 1, 0, 0, 0, 0)
        Me.AuF.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.AuF.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.AuF.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.AuF.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.AuF.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.AuF.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.AuF.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AuF.MonthCalendar.TodayButtonVisible = True
        Me.AuF.MonthCalendar.Visible = False
        Me.AuF.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.AuF.Name = "AuF"
        Me.AuF.Size = New System.Drawing.Size(71, 25)
        Me.AuF.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AuF.TabIndex = 2
        Me.AuF.Value = New Date(2014, 6, 21, 13, 0, 0, 0)
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(6, 41)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(23, 23)
        Me.LabelX4.TabIndex = 1
        Me.LabelX4.Text = "Du"
        '
        'duR
        '
        '
        '
        '
        Me.duR.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.duR.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.duR.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.duR.ButtonDropDown.Visible = True
        Me.duR.Format = DevComponents.Editors.eDateTimePickerFormat.LongTime
        Me.duR.IsPopupCalendarOpen = False
        Me.duR.Location = New System.Drawing.Point(35, 41)
        '
        '
        '
        Me.duR.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.duR.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.duR.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.duR.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.duR.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.duR.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.duR.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.duR.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.duR.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.duR.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.duR.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.duR.MonthCalendar.DisplayMonth = New Date(2014, 6, 1, 0, 0, 0, 0)
        Me.duR.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.duR.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.duR.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.duR.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.duR.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.duR.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.duR.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.duR.MonthCalendar.TodayButtonVisible = True
        Me.duR.MonthCalendar.Visible = False
        Me.duR.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.duR.Name = "duR"
        Me.duR.Size = New System.Drawing.Size(71, 25)
        Me.duR.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.duR.TabIndex = 0
        Me.duR.Value = New Date(2014, 6, 21, 8, 0, 0, 0)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.LabelX2)
        Me.GroupBox2.Controls.Add(Me.auN)
        Me.GroupBox2.Controls.Add(Me.LabelX1)
        Me.GroupBox2.Controls.Add(Me.duN)
        Me.GroupBox2.Location = New System.Drawing.Point(511, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(226, 91)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Etat Normal"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RadioButton1.Location = New System.Drawing.Point(6, 17)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(136, 21)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Activer l'etat normal"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(120, 41)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(23, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Au"
        '
        'auN
        '
        '
        '
        '
        Me.auN.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.auN.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.auN.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.auN.ButtonDropDown.Visible = True
        Me.auN.Format = DevComponents.Editors.eDateTimePickerFormat.LongTime
        Me.auN.IsPopupCalendarOpen = False
        Me.auN.Location = New System.Drawing.Point(149, 41)
        '
        '
        '
        Me.auN.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.auN.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.auN.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.auN.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.auN.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.auN.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.auN.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.auN.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.auN.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.auN.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.auN.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.auN.MonthCalendar.DisplayMonth = New Date(2014, 6, 1, 0, 0, 0, 0)
        Me.auN.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.auN.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.auN.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.auN.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.auN.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.auN.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.auN.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.auN.MonthCalendar.TodayButtonVisible = True
        Me.auN.MonthCalendar.Visible = False
        Me.auN.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.auN.Name = "auN"
        Me.auN.Size = New System.Drawing.Size(71, 25)
        Me.auN.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.auN.TabIndex = 2
        Me.auN.Value = New Date(2014, 6, 21, 16, 15, 0, 0)
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(6, 41)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(23, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Du"
        '
        'duN
        '
        '
        '
        '
        Me.duN.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.duN.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.duN.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.duN.ButtonDropDown.Visible = True
        Me.duN.Format = DevComponents.Editors.eDateTimePickerFormat.LongTime
        Me.duN.IsPopupCalendarOpen = False
        Me.duN.Location = New System.Drawing.Point(35, 41)
        '
        '
        '
        Me.duN.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.duN.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.duN.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.duN.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.duN.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.duN.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.duN.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.duN.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.duN.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.duN.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.duN.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.duN.MonthCalendar.DisplayMonth = New Date(2014, 6, 1, 0, 0, 0, 0)
        Me.duN.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.duN.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.duN.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.duN.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.duN.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.duN.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.duN.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.duN.MonthCalendar.TodayButtonVisible = True
        Me.duN.MonthCalendar.Visible = False
        Me.duN.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.duN.Name = "duN"
        Me.duN.Size = New System.Drawing.Size(71, 25)
        Me.duN.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.duN.TabIndex = 0
        Me.duN.Value = New Date(2014, 6, 21, 8, 0, 0, 0)
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = Global.MBA.My.Resources.Resources.save
        Me.ButtonX2.Location = New System.Drawing.Point(142, 67)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(137, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 2
        Me.ButtonX2.Text = "Enregistrer"
        '
        'TextBoxX1
        '
        Me.TextBoxX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX1.Location = New System.Drawing.Point(37, 36)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.Size = New System.Drawing.Size(442, 25)
        Me.TextBoxX1.TabIndex = 1
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.MBA.My.Resources.Resources.nav_green_top
        Me.ButtonX1.Location = New System.Drawing.Point(285, 67)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(194, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 0
        Me.ButtonX1.Text = "Upload le fichier de présence"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Grid1
        '
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.Location = New System.Drawing.Point(0, 121)
        Me.Grid1.LookAndFeel.SkinName = "Office 2013"
        Me.Grid1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(1222, 486)
        Me.Grid1.TabIndex = 2
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        '
        'ImportPresence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1222, 607)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ImportPresence"
        Me.ShowIcon = False
        Me.Text = "Import un fichier de Présence"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.AuH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.duR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.auN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.duN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents AuH As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents AuF As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents duR As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents auN As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents duN As DevComponents.Editors.DateTimeAdv.DateTimeInput
End Class
