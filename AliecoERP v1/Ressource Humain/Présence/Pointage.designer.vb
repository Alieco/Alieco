<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pointage
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
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.au = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.du = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mat = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.fct = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.motif = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.departement = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.direction = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Pdgv = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.au, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.du, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Pdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(12, 60)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(34, 25)
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = "Au : "
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(12, 28)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(34, 25)
        Me.LabelX1.TabIndex = 3
        Me.LabelX1.Text = "Du :"
        '
        'au
        '
        '
        '
        '
        Me.au.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.au.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.au.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.au.ButtonDropDown.Visible = True
        Me.au.Format = DevComponents.Editors.eDateTimePickerFormat.[Long]
        Me.au.IsPopupCalendarOpen = False
        Me.au.Location = New System.Drawing.Point(52, 63)
        Me.au.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
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
        Me.au.MonthCalendar.DisplayMonth = New Date(2014, 6, 1, 0, 0, 0, 0)
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
        Me.au.Size = New System.Drawing.Size(198, 25)
        Me.au.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.au.TabIndex = 2
        '
        'du
        '
        '
        '
        '
        Me.du.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.du.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.du.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.du.ButtonDropDown.Visible = True
        Me.du.Format = DevComponents.Editors.eDateTimePickerFormat.[Long]
        Me.du.IsPopupCalendarOpen = False
        Me.du.Location = New System.Drawing.Point(52, 28)
        Me.du.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
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
        Me.du.MonthCalendar.DisplayMonth = New Date(2014, 6, 1, 0, 0, 0, 0)
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
        Me.du.Size = New System.Drawing.Size(198, 25)
        Me.du.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.du.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mat)
        Me.GroupBox1.Controls.Add(Me.ButtonX3)
        Me.GroupBox1.Controls.Add(Me.ButtonX2)
        Me.GroupBox1.Controls.Add(Me.fct)
        Me.GroupBox1.Controls.Add(Me.motif)
        Me.GroupBox1.Controls.Add(Me.departement)
        Me.GroupBox1.Controls.Add(Me.direction)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.au)
        Me.GroupBox1.Controls.Add(Me.du)
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1336, 109)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selectionner la date de debut et fin :"
        '
        'mat
        '
        Me.mat.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.mat.Border.Class = "TextBoxBorder"
        Me.mat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mat.ForeColor = System.Drawing.Color.Black
        Me.mat.Location = New System.Drawing.Point(658, 27)
        Me.mat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mat.Name = "mat"
        Me.mat.Size = New System.Drawing.Size(170, 25)
        Me.mat.TabIndex = 184
        Me.mat.WatermarkText = "Matricule"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Image = Global.MBA.My.Resources.Resources.clock_add3
        Me.ButtonX3.Location = New System.Drawing.Point(763, 61)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(27, 27)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 22
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = Global.MBA.My.Resources.Resources.save
        Me.ButtonX2.Location = New System.Drawing.Point(794, 61)
        Me.ButtonX2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(34, 27)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1, Me.ButtonItem3})
        Me.ButtonX2.TabIndex = 21
        '
        'ButtonItem1
        '
        Me.ButtonItem1.GlobalItem = False
        Me.ButtonItem1.Image = Global.MBA.My.Resources.Resources.excel
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "Enregistrer en <b>Excel 2010</b>"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.GlobalItem = False
        Me.ButtonItem3.Image = Global.MBA.My.Resources.Resources.pdf18
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.Text = "Enregistrer en <b>PDF</b>"
        '
        'fct
        '
        Me.fct.DisplayMember = "Text"
        Me.fct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.fct.FormattingEnabled = True
        Me.fct.ItemHeight = 19
        Me.fct.Location = New System.Drawing.Point(293, 63)
        Me.fct.Name = "fct"
        Me.fct.Size = New System.Drawing.Size(170, 25)
        Me.fct.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.fct.TabIndex = 19
        Me.fct.WatermarkText = "Fonction"
        '
        'motif
        '
        Me.motif.DisplayMember = "Text"
        Me.motif.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.motif.FormattingEnabled = True
        Me.motif.ItemHeight = 19
        Me.motif.Location = New System.Drawing.Point(482, 63)
        Me.motif.Name = "motif"
        Me.motif.Size = New System.Drawing.Size(170, 25)
        Me.motif.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.motif.TabIndex = 18
        Me.motif.WatermarkText = "Motif"
        '
        'departement
        '
        Me.departement.DisplayMember = "Text"
        Me.departement.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.departement.FormattingEnabled = True
        Me.departement.ItemHeight = 19
        Me.departement.Location = New System.Drawing.Point(482, 28)
        Me.departement.Name = "departement"
        Me.departement.Size = New System.Drawing.Size(170, 25)
        Me.departement.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.departement.TabIndex = 17
        Me.departement.WatermarkText = "Departement"
        '
        'direction
        '
        Me.direction.DisplayMember = "Text"
        Me.direction.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.direction.FormattingEnabled = True
        Me.direction.ItemHeight = 19
        Me.direction.Location = New System.Drawing.Point(293, 28)
        Me.direction.Name = "direction"
        Me.direction.Size = New System.Drawing.Size(170, 25)
        Me.direction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.direction.TabIndex = 16
        Me.direction.WatermarkText = "Direction"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.MBA.My.Resources.Resources.clock_import2
        Me.ButtonX1.Location = New System.Drawing.Point(658, 61)
        Me.ButtonX1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(101, 27)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 0
        Me.ButtonX1.Text = "Rechercher "
        '
        'Pdgv
        '
        Me.Pdgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pdgv.Location = New System.Drawing.Point(0, 109)
        Me.Pdgv.LookAndFeel.SkinName = "Office 2013"
        Me.Pdgv.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Pdgv.MainView = Me.GridView1
        Me.Pdgv.Name = "Pdgv"
        Me.Pdgv.Size = New System.Drawing.Size(1336, 641)
        Me.Pdgv.TabIndex = 10
        Me.Pdgv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Pdgv
        Me.GridView1.Name = "GridView1"
        '
        'Pointage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1336, 750)
        Me.Controls.Add(Me.Pdgv)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Pointage"
        Me.ShowIcon = False
        Me.Text = "Pointage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.au, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.du, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Pdgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents au As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents du As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents direction As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents fct As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents motif As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents departement As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Pdgv As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents mat As DevComponents.DotNetBar.Controls.TextBoxX
End Class
