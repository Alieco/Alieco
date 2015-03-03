<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListOE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListOE))
        Me.chargeaffaire = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MOERadio = New System.Windows.Forms.RadioButton()
        Me.OERadio = New System.Windows.Forms.RadioButton()
        Me.au = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.du = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.dgoe = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip()
        Me.GoogleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimerModifToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerLMOEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.au, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.du, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgoe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chargeaffaire
        '
        Me.chargeaffaire.DisplayMember = "Text"
        Me.chargeaffaire.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.chargeaffaire.ForeColor = System.Drawing.Color.Black
        Me.chargeaffaire.FormattingEnabled = True
        Me.chargeaffaire.ItemHeight = 17
        Me.chargeaffaire.Location = New System.Drawing.Point(571, 34)
        Me.chargeaffaire.Name = "chargeaffaire"
        Me.chargeaffaire.Size = New System.Drawing.Size(222, 23)
        Me.chargeaffaire.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chargeaffaire.TabIndex = 18
        Me.chargeaffaire.Visible = False
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(475, 34)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(90, 23)
        Me.LabelX3.TabIndex = 17
        Me.LabelX3.Text = "Chargé d'affaire :"
        Me.LabelX3.Visible = False
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(238, 30)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(28, 30)
        Me.LabelX2.TabIndex = 14
        Me.LabelX2.Text = "Au : "
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(6, 30)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(28, 30)
        Me.LabelX1.TabIndex = 13
        Me.LabelX1.Text = "Du :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.MOERadio)
        Me.GroupBox1.Controls.Add(Me.OERadio)
        Me.GroupBox1.Controls.Add(Me.chargeaffaire)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.au)
        Me.GroupBox1.Controls.Add(Me.du)
        Me.GroupBox1.Controls.Add(Me.ButtonX2)
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1382, 130)
        Me.GroupBox1.TabIndex = 124
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "La liste des Offres :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(279, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 21
        '
        'MOERadio
        '
        Me.MOERadio.AutoSize = True
        Me.MOERadio.BackColor = System.Drawing.Color.White
        Me.MOERadio.ForeColor = System.Drawing.Color.Black
        Me.MOERadio.Location = New System.Drawing.Point(881, 36)
        Me.MOERadio.Name = "MOERadio"
        Me.MOERadio.Size = New System.Drawing.Size(50, 19)
        Me.MOERadio.TabIndex = 20
        Me.MOERadio.Text = "MOE"
        Me.MOERadio.UseVisualStyleBackColor = False
        '
        'OERadio
        '
        Me.OERadio.AutoSize = True
        Me.OERadio.BackColor = System.Drawing.Color.White
        Me.OERadio.Checked = True
        Me.OERadio.ForeColor = System.Drawing.Color.Black
        Me.OERadio.Location = New System.Drawing.Point(812, 38)
        Me.OERadio.Name = "OERadio"
        Me.OERadio.Size = New System.Drawing.Size(40, 19)
        Me.OERadio.TabIndex = 19
        Me.OERadio.TabStop = True
        Me.OERadio.Text = "OE"
        Me.OERadio.UseVisualStyleBackColor = False
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
        Me.au.Location = New System.Drawing.Point(272, 34)
        Me.au.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
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
        Me.au.Size = New System.Drawing.Size(180, 23)
        Me.au.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.au.TabIndex = 12
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
        Me.du.Location = New System.Drawing.Point(60, 34)
        Me.du.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
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
        Me.du.Size = New System.Drawing.Size(172, 23)
        Me.du.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.du.TabIndex = 11
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Image = Global.MBA.My.Resources.Resources.vendors_database1
        Me.ButtonX2.Location = New System.Drawing.Point(604, 85)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(189, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 10
        Me.ButtonX2.Text = "Afficher la liste "
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = Global.MBA.My.Resources.Resources.vendors_arrow_right
        Me.ButtonX1.Location = New System.Drawing.Point(823, 85)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(189, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 9
        Me.ButtonX1.Text = "Exporter vers Excel"
        '
        'dgoe
        '
        Me.dgoe.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgoe.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgoe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgoe.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White
        Me.dgoe.EmbeddedNavigator.Appearance.ForeColor = System.Drawing.Color.Black
        Me.dgoe.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.dgoe.EmbeddedNavigator.Appearance.Options.UseForeColor = True
        Me.dgoe.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgoe.Location = New System.Drawing.Point(0, 130)
        Me.dgoe.LookAndFeel.SkinName = "Office 2013"
        Me.dgoe.LookAndFeel.UseDefaultLookAndFeel = False
        Me.dgoe.MainView = Me.GridView1
        Me.dgoe.Name = "dgoe"
        Me.dgoe.Size = New System.Drawing.Size(1382, 756)
        Me.dgoe.TabIndex = 126
        Me.dgoe.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoogleToolStripMenuItem, Me.ModifierToolStripMenuItem, Me.SupprimerToolStripMenuItem, Me.ImprimerToolStripMenuItem1, Me.ImprimerModifToolStripMenuItem, Me.SupprimerLMOEToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(330, 136)
        '
        'GoogleToolStripMenuItem
        '
        Me.GoogleToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.GoogleToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.vendors_database
        Me.GoogleToolStripMenuItem.Name = "GoogleToolStripMenuItem"
        Me.GoogleToolStripMenuItem.Size = New System.Drawing.Size(329, 22)
        Me.GoogleToolStripMenuItem.Text = "     Actualiser la liste des Ordres d'execution"
        '
        'ModifierToolStripMenuItem
        '
        Me.ModifierToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.ModifierToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.vendors_edit
        Me.ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        Me.ModifierToolStripMenuItem.Size = New System.Drawing.Size(329, 22)
        Me.ModifierToolStripMenuItem.Text = "     Modification l'OE selectionné"
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.SupprimerToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.vendors_remove
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(329, 22)
        Me.SupprimerToolStripMenuItem.Text = "     Supprimer l'OE"
        Me.SupprimerToolStripMenuItem.Visible = False
        '
        'ImprimerToolStripMenuItem1
        '
        Me.ImprimerToolStripMenuItem1.Image = Global.MBA.My.Resources.Resources.vendor_print
        Me.ImprimerToolStripMenuItem1.Name = "ImprimerToolStripMenuItem1"
        Me.ImprimerToolStripMenuItem1.Size = New System.Drawing.Size(329, 22)
        Me.ImprimerToolStripMenuItem1.Text = "     Imprimer la fiche d'ordre d'execution"
        '
        'ImprimerModifToolStripMenuItem
        '
        Me.ImprimerModifToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.loan_print
        Me.ImprimerModifToolStripMenuItem.Name = "ImprimerModifToolStripMenuItem"
        Me.ImprimerModifToolStripMenuItem.Size = New System.Drawing.Size(329, 22)
        Me.ImprimerModifToolStripMenuItem.Text = "     Imprimer la modification  d'un ordre d'execution"
        '
        'SupprimerLMOEToolStripMenuItem
        '
        Me.SupprimerLMOEToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.vendors_remove
        Me.SupprimerLMOEToolStripMenuItem.Name = "SupprimerLMOEToolStripMenuItem"
        Me.SupprimerLMOEToolStripMenuItem.Size = New System.Drawing.Size(329, 22)
        Me.SupprimerLMOEToolStripMenuItem.Text = "     Supprimer l'MOE"
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GridView1.GridControl = Me.dgoe
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GridView1.OptionsDetail.AutoZoomDetail = True
        Me.GridView1.OptionsDetail.SmartDetailHeight = True
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'ListOE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1382, 886)
        Me.Controls.Add(Me.dgoe)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ListOE"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste des Ordres d'execution"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.au, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.du, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgoe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chargeaffaire As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents au As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents du As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgoe As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GoogleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimerModifToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MOERadio As System.Windows.Forms.RadioButton
    Friend WithEvents OERadio As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SupprimerLMOEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
