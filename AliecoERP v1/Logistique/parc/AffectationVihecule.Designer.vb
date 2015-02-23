<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AffectationVihecule
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
        Me.Affectation = New System.Windows.Forms.GroupBox()
        Me.EffacerBtn = New DevComponents.DotNetBar.ButtonX()
        Me.afffectationBtn = New DevComponents.DotNetBar.ButtonX()
        Me.AuTime = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.AuDate = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.DuTime = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.duDate = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.ChauffeurCmb = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ViheculeImg = New DevExpress.XtraEditors.PictureEdit()
        Me.ViheculeCmb = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Affectation.SuspendLayout()
        CType(Me.AuTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DuTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.duDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ViheculeImg.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Affectation
        '
        Me.Affectation.BackColor = System.Drawing.Color.White
        Me.Affectation.Controls.Add(Me.ComboBoxEdit1)
        Me.Affectation.Controls.Add(Me.EffacerBtn)
        Me.Affectation.Controls.Add(Me.afffectationBtn)
        Me.Affectation.Controls.Add(Me.AuTime)
        Me.Affectation.Controls.Add(Me.AuDate)
        Me.Affectation.Controls.Add(Me.LabelX4)
        Me.Affectation.Controls.Add(Me.DuTime)
        Me.Affectation.Controls.Add(Me.duDate)
        Me.Affectation.Controls.Add(Me.LabelX3)
        Me.Affectation.Controls.Add(Me.LabelX2)
        Me.Affectation.Controls.Add(Me.ChauffeurCmb)
        Me.Affectation.Controls.Add(Me.LabelX1)
        Me.Affectation.Controls.Add(Me.GroupBox2)
        Me.Affectation.Controls.Add(Me.ViheculeCmb)
        Me.Affectation.Dock = System.Windows.Forms.DockStyle.Top
        Me.Affectation.ForeColor = System.Drawing.Color.Black
        Me.Affectation.Location = New System.Drawing.Point(0, 0)
        Me.Affectation.Name = "Affectation"
        Me.Affectation.Size = New System.Drawing.Size(697, 336)
        Me.Affectation.TabIndex = 0
        Me.Affectation.TabStop = False
        Me.Affectation.Text = "Affectation"
        '
        'EffacerBtn
        '
        Me.EffacerBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.EffacerBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.EffacerBtn.Image = Global.MBA.My.Resources.Resources.delete
        Me.EffacerBtn.Location = New System.Drawing.Point(12, 286)
        Me.EffacerBtn.Name = "EffacerBtn"
        Me.EffacerBtn.Size = New System.Drawing.Size(133, 23)
        Me.EffacerBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.EffacerBtn.TabIndex = 383
        Me.EffacerBtn.Text = "Effacer"
        '
        'afffectationBtn
        '
        Me.afffectationBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.afffectationBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.afffectationBtn.Image = Global.MBA.My.Resources.Resources.save
        Me.afffectationBtn.Location = New System.Drawing.Point(178, 286)
        Me.afffectationBtn.Name = "afffectationBtn"
        Me.afffectationBtn.Size = New System.Drawing.Size(151, 23)
        Me.afffectationBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.afffectationBtn.TabIndex = 382
        Me.afffectationBtn.Text = "Affectter"
        '
        'AuTime
        '
        Me.AuTime.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.AuTime.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.AuTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AuTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.AuTime.ButtonDropDown.Visible = True
        Me.AuTime.ForeColor = System.Drawing.Color.Black
        Me.AuTime.Format = DevComponents.Editors.eDateTimePickerFormat.LongTime
        Me.AuTime.IsPopupCalendarOpen = False
        Me.AuTime.Location = New System.Drawing.Point(210, 247)
        '
        '
        '
        Me.AuTime.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.AuTime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AuTime.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.AuTime.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.AuTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.AuTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.AuTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.AuTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.AuTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.AuTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.AuTime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AuTime.MonthCalendar.DisplayMonth = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.AuTime.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.AuTime.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.AuTime.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.AuTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.AuTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.AuTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.AuTime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AuTime.MonthCalendar.TodayButtonVisible = True
        Me.AuTime.MonthCalendar.Visible = False
        Me.AuTime.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.AuTime.Name = "AuTime"
        Me.AuTime.Size = New System.Drawing.Size(119, 23)
        Me.AuTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AuTime.TabIndex = 11
        '
        'AuDate
        '
        Me.AuDate.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.AuDate.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.AuDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AuDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.AuDate.ButtonDropDown.Visible = True
        Me.AuDate.ForeColor = System.Drawing.Color.Black
        Me.AuDate.Format = DevComponents.Editors.eDateTimePickerFormat.[Long]
        Me.AuDate.IsPopupCalendarOpen = False
        Me.AuDate.Location = New System.Drawing.Point(12, 247)
        '
        '
        '
        Me.AuDate.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.AuDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AuDate.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.AuDate.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.AuDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.AuDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.AuDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.AuDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.AuDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.AuDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.AuDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AuDate.MonthCalendar.DisplayMonth = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.AuDate.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.AuDate.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.AuDate.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.AuDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.AuDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.AuDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.AuDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AuDate.MonthCalendar.TodayButtonVisible = True
        Me.AuDate.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.AuDate.Name = "AuDate"
        Me.AuDate.Size = New System.Drawing.Size(192, 23)
        Me.AuDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AuDate.TabIndex = 10
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(15, 214)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(266, 27)
        Me.LabelX4.TabIndex = 9
        Me.LabelX4.Text = "au :"
        '
        'DuTime
        '
        Me.DuTime.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.DuTime.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DuTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DuTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DuTime.ButtonDropDown.Visible = True
        Me.DuTime.ForeColor = System.Drawing.Color.Black
        Me.DuTime.Format = DevComponents.Editors.eDateTimePickerFormat.LongTime
        Me.DuTime.IsPopupCalendarOpen = False
        Me.DuTime.Location = New System.Drawing.Point(210, 185)
        '
        '
        '
        Me.DuTime.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DuTime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DuTime.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DuTime.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DuTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DuTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DuTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DuTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DuTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DuTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DuTime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DuTime.MonthCalendar.DisplayMonth = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.DuTime.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.DuTime.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.DuTime.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DuTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DuTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DuTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DuTime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DuTime.MonthCalendar.TodayButtonVisible = True
        Me.DuTime.MonthCalendar.Visible = False
        Me.DuTime.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.DuTime.Name = "DuTime"
        Me.DuTime.Size = New System.Drawing.Size(119, 23)
        Me.DuTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DuTime.TabIndex = 8
        '
        'duDate
        '
        Me.duDate.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.duDate.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.duDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.duDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.duDate.ButtonDropDown.Visible = True
        Me.duDate.ForeColor = System.Drawing.Color.Black
        Me.duDate.Format = DevComponents.Editors.eDateTimePickerFormat.[Long]
        Me.duDate.IsPopupCalendarOpen = False
        Me.duDate.Location = New System.Drawing.Point(12, 185)
        '
        '
        '
        Me.duDate.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.duDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.duDate.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.duDate.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.duDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.duDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.duDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.duDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.duDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.duDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.duDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.duDate.MonthCalendar.DisplayMonth = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.duDate.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.duDate.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.duDate.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.duDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.duDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.duDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.duDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.duDate.MonthCalendar.TodayButtonVisible = True
        Me.duDate.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.duDate.Name = "duDate"
        Me.duDate.Size = New System.Drawing.Size(192, 23)
        Me.duDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.duDate.TabIndex = 7
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(15, 152)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(266, 27)
        Me.LabelX3.TabIndex = 6
        Me.LabelX3.Text = "Du :"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(15, 90)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(266, 27)
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = "Choisissez un chauffeur :"
        '
        'ChauffeurCmb
        '
        Me.ChauffeurCmb.DisplayMember = "Text"
        Me.ChauffeurCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ChauffeurCmb.ForeColor = System.Drawing.Color.Black
        Me.ChauffeurCmb.FormattingEnabled = True
        Me.ChauffeurCmb.ItemHeight = 17
        Me.ChauffeurCmb.Location = New System.Drawing.Point(12, 123)
        Me.ChauffeurCmb.Name = "ChauffeurCmb"
        Me.ChauffeurCmb.Size = New System.Drawing.Size(317, 23)
        Me.ChauffeurCmb.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ChauffeurCmb.TabIndex = 3
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(15, 28)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(266, 27)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "Choisissez un vihécule :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.LabelControl6)
        Me.GroupBox2.Controls.Add(Me.LabelControl5)
        Me.GroupBox2.Controls.Add(Me.LabelControl4)
        Me.GroupBox2.Controls.Add(Me.LabelControl3)
        Me.GroupBox2.Controls.Add(Me.LabelControl2)
        Me.GroupBox2.Controls.Add(Me.LabelControl1)
        Me.GroupBox2.Controls.Add(Me.ViheculeImg)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(446, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(248, 314)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informations :"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl6.Location = New System.Drawing.Point(6, 355)
        Me.LabelControl6.LookAndFeel.SkinName = "Office 2013"
        Me.LabelControl6.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl6.TabIndex = 6
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl5.Location = New System.Drawing.Point(6, 333)
        Me.LabelControl5.LookAndFeel.SkinName = "Office 2013"
        Me.LabelControl5.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(0, 15)
        Me.LabelControl5.TabIndex = 5
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl4.Location = New System.Drawing.Point(6, 292)
        Me.LabelControl4.LookAndFeel.SkinName = "Office 2013"
        Me.LabelControl4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(0, 15)
        Me.LabelControl4.TabIndex = 4
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl3.Location = New System.Drawing.Point(6, 270)
        Me.LabelControl3.LookAndFeel.SkinName = "Office 2013"
        Me.LabelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(0, 15)
        Me.LabelControl3.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl2.Location = New System.Drawing.Point(6, 249)
        Me.LabelControl2.LookAndFeel.SkinName = "Office 2013"
        Me.LabelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(0, 15)
        Me.LabelControl2.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl1.Location = New System.Drawing.Point(6, 227)
        Me.LabelControl1.LookAndFeel.SkinName = "Office 2013"
        Me.LabelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(0, 15)
        Me.LabelControl1.TabIndex = 1
        '
        'ViheculeImg
        '
        Me.ViheculeImg.Dock = System.Windows.Forms.DockStyle.Top
        Me.ViheculeImg.Location = New System.Drawing.Point(3, 19)
        Me.ViheculeImg.Name = "ViheculeImg"
        Me.ViheculeImg.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.ViheculeImg.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ViheculeImg.Properties.Appearance.Options.UseBackColor = True
        Me.ViheculeImg.Properties.Appearance.Options.UseForeColor = True
        Me.ViheculeImg.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.ViheculeImg.Size = New System.Drawing.Size(242, 201)
        Me.ViheculeImg.TabIndex = 0
        '
        'ViheculeCmb
        '
        Me.ViheculeCmb.DisplayMember = "Text"
        Me.ViheculeCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ViheculeCmb.ForeColor = System.Drawing.Color.Black
        Me.ViheculeCmb.FormattingEnabled = True
        Me.ViheculeCmb.ItemHeight = 17
        Me.ViheculeCmb.Location = New System.Drawing.Point(12, 61)
        Me.ViheculeCmb.Name = "ViheculeCmb"
        Me.ViheculeCmb.Size = New System.Drawing.Size(317, 23)
        Me.ViheculeCmb.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ViheculeCmb.TabIndex = 0
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(145, 32)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.LookAndFeel.SkinName = "Office 2013"
        Me.ComboBoxEdit1.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(184, 20)
        Me.ComboBoxEdit1.TabIndex = 384
        '
        'AffectationVihecule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 340)
        Me.Controls.Add(Me.Affectation)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AffectationVihecule"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Affectation des vihécules"
        Me.Affectation.ResumeLayout(False)
        CType(Me.AuTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DuTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.duDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ViheculeImg.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Affectation As System.Windows.Forms.GroupBox
    Friend WithEvents ViheculeCmb As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ViheculeImg As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents AuTime As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents AuDate As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DuTime As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents duDate As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ChauffeurCmb As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents EffacerBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents afffectationBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
End Class
