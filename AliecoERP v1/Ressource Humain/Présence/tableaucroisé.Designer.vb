<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tableaucroisé
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
        Me.AbsentéismeDS = New MBA.AbsentéismeDS()
        Me.AbsentéismeDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PointageAbsenceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AbsentéismeDS1 = New MBA.AbsentéismeDS()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.au = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.du = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AfficherLeDétailDuFonctionnaireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Decembre = New DevComponents.Editors.ComboItem()
        Me.Novembre = New DevComponents.Editors.ComboItem()
        Me.Octobre = New DevComponents.Editors.ComboItem()
        Me.Septembre = New DevComponents.Editors.ComboItem()
        Me.Aout = New DevComponents.Editors.ComboItem()
        Me.Juillet = New DevComponents.Editors.ComboItem()
        Me.Juin = New DevComponents.Editors.ComboItem()
        Me.Mai = New DevComponents.Editors.ComboItem()
        Me.Avril = New DevComponents.Editors.ComboItem()
        Me.Mars = New DevComponents.Editors.ComboItem()
        Me.Fevrier = New DevComponents.Editors.ComboItem()
        Me.Janvier = New DevComponents.Editors.ComboItem()
        CType(Me.AbsentéismeDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbsentéismeDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PointageAbsenceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbsentéismeDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.au, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.du, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AbsentéismeDS
        '
        Me.AbsentéismeDS.DataSetName = "AbsentéismeDS"
        Me.AbsentéismeDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AbsentéismeDSBindingSource
        '
        Me.AbsentéismeDSBindingSource.DataSource = Me.AbsentéismeDS
        Me.AbsentéismeDSBindingSource.Position = 0
        '
        'PointageAbsenceBindingSource
        '
        Me.PointageAbsenceBindingSource.DataMember = "PointageAbsence"
        Me.PointageAbsenceBindingSource.DataSource = Me.AbsentéismeDSBindingSource
        '
        'AbsentéismeDS1
        '
        Me.AbsentéismeDS1.DataSetName = "AbsentéismeDS"
        Me.AbsentéismeDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.ButtonX2)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.au)
        Me.GroupBox1.Controls.Add(Me.du)
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1081, 145)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liste des absences :"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Enabled = False
        Me.ButtonX2.Image = Global.MBA.My.Resources.Resources.Excel_2013
        Me.ButtonX2.Location = New System.Drawing.Point(665, 78)
        Me.ButtonX2.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(356, 25)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 30
        Me.ButtonX2.Text = "Exporter le resultat"
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(16, 78)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(3, 9, 3, 9)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(44, 33)
        Me.LabelX4.TabIndex = 29
        Me.LabelX4.Text = "Au : "
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(16, 30)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(3, 9, 3, 9)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(56, 33)
        Me.LabelX1.TabIndex = 28
        Me.LabelX1.Text = "Du :"
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
        Me.au.Location = New System.Drawing.Point(108, 78)
        Me.au.Margin = New System.Windows.Forms.Padding(3, 9, 3, 9)
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
        Me.au.Size = New System.Drawing.Size(269, 25)
        Me.au.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.au.TabIndex = 27
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
        Me.du.Location = New System.Drawing.Point(108, 30)
        Me.du.Margin = New System.Windows.Forms.Padding(3, 9, 3, 9)
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
        Me.du.Size = New System.Drawing.Size(269, 25)
        Me.du.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.du.TabIndex = 26
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.MBA.My.Resources.Resources.raport
        Me.ButtonX1.Location = New System.Drawing.Point(665, 31)
        Me.ButtonX1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(356, 24)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 5
        Me.ButtonX1.Text = "  Afficher le tableau"
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.BackColor = System.Drawing.Color.White
        Me.PivotGridControl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.ForeColor = System.Drawing.Color.Black
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 145)
        Me.PivotGridControl1.LookAndFeel.SkinName = "Office 2013"
        Me.PivotGridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PivotGridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.Size = New System.Drawing.Size(1081, 599)
        Me.PivotGridControl1.TabIndex = 7
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AfficherLeDétailDuFonctionnaireToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(331, 26)
        '
        'AfficherLeDétailDuFonctionnaireToolStripMenuItem
        '
        Me.AfficherLeDétailDuFonctionnaireToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.AfficherLeDétailDuFonctionnaireToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AfficherLeDétailDuFonctionnaireToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.query_lookup
        Me.AfficherLeDétailDuFonctionnaireToolStripMenuItem.Name = "AfficherLeDétailDuFonctionnaireToolStripMenuItem"
        Me.AfficherLeDétailDuFonctionnaireToolStripMenuItem.Size = New System.Drawing.Size(330, 22)
        Me.AfficherLeDétailDuFonctionnaireToolStripMenuItem.Text = "Afficher le détail du pointage de fonctionnaire"
        '
        'Decembre
        '
        Me.Decembre.Text = "ComboItem12"
        '
        'Novembre
        '
        Me.Novembre.Text = "ComboItem11"
        '
        'Octobre
        '
        Me.Octobre.Text = "ComboItem10"
        '
        'Septembre
        '
        Me.Septembre.Text = "ComboItem9"
        '
        'Aout
        '
        Me.Aout.Text = "ComboItem8"
        '
        'Juillet
        '
        Me.Juillet.Text = "ComboItem7"
        '
        'Juin
        '
        Me.Juin.Text = "ComboItem6"
        '
        'Mai
        '
        Me.Mai.Text = "ComboItem5"
        '
        'Avril
        '
        Me.Avril.Text = "ComboItem4"
        '
        'Mars
        '
        Me.Mars.Text = "ComboItem3"
        '
        'Fevrier
        '
        Me.Fevrier.Text = "ComboItem2"
        '
        'Janvier
        '
        Me.Janvier.Text = "ComboItem1"
        '
        'tableaucroisé
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1081, 744)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "tableaucroisé"
        Me.ShowIcon = False
        Me.Text = "Liste des absences"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AbsentéismeDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbsentéismeDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PointageAbsenceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbsentéismeDS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.au, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.du, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AbsentéismeDSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AbsentéismeDS As MBA.AbsentéismeDS
    Friend WithEvents AbsentéismeDS1 As MBA.AbsentéismeDS
    Friend WithEvents PointageAbsenceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents Decembre As DevComponents.Editors.ComboItem
    Friend WithEvents Novembre As DevComponents.Editors.ComboItem
    Friend WithEvents Octobre As DevComponents.Editors.ComboItem
    Friend WithEvents Septembre As DevComponents.Editors.ComboItem
    Friend WithEvents Aout As DevComponents.Editors.ComboItem
    Friend WithEvents Juillet As DevComponents.Editors.ComboItem
    Friend WithEvents Juin As DevComponents.Editors.ComboItem
    Friend WithEvents Mai As DevComponents.Editors.ComboItem
    Friend WithEvents Avril As DevComponents.Editors.ComboItem
    Friend WithEvents Mars As DevComponents.Editors.ComboItem
    Friend WithEvents Fevrier As DevComponents.Editors.ComboItem
    Friend WithEvents Janvier As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents au As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents du As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AfficherLeDétailDuFonctionnaireToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
End Class
