<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListeDemAch
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
        Me.DGDem = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GoogleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterUnNouveauOffreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierOffreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerOffreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.au = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.du = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        CType(Me.DGDem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.au, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.du, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGDem
        '
        Me.DGDem.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DGDem.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGDem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGDem.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGDem.Location = New System.Drawing.Point(0, 85)
        Me.DGDem.LookAndFeel.SkinName = "Office 2013"
        Me.DGDem.LookAndFeel.UseDefaultLookAndFeel = False
        Me.DGDem.MainView = Me.GridView1
        Me.DGDem.Name = "DGDem"
        Me.DGDem.Size = New System.Drawing.Size(792, 595)
        Me.DGDem.TabIndex = 119
        Me.DGDem.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoogleToolStripMenuItem, Me.AjouterUnNouveauOffreToolStripMenuItem, Me.ModifierOffreToolStripMenuItem, Me.SupprimerOffreToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(260, 92)
        '
        'GoogleToolStripMenuItem
        '
        Me.GoogleToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.GoogleToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.vendors_database
        Me.GoogleToolStripMenuItem.Name = "GoogleToolStripMenuItem"
        Me.GoogleToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
        Me.GoogleToolStripMenuItem.Text = "     Actualiser la liste des demandes"
        '
        'AjouterUnNouveauOffreToolStripMenuItem
        '
        Me.AjouterUnNouveauOffreToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.AjouterUnNouveauOffreToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.vendors_add1
        Me.AjouterUnNouveauOffreToolStripMenuItem.Name = "AjouterUnNouveauOffreToolStripMenuItem"
        Me.AjouterUnNouveauOffreToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
        Me.AjouterUnNouveauOffreToolStripMenuItem.Text = "     consulter la demande"
        '
        'ModifierOffreToolStripMenuItem
        '
        Me.ModifierOffreToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.ModifierOffreToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.vendors_edit
        Me.ModifierOffreToolStripMenuItem.Name = "ModifierOffreToolStripMenuItem"
        Me.ModifierOffreToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
        Me.ModifierOffreToolStripMenuItem.Text = "     Modifier la commande selectionné"
        Me.ModifierOffreToolStripMenuItem.Visible = False
        '
        'SupprimerOffreToolStripMenuItem
        '
        Me.SupprimerOffreToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.SupprimerOffreToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.vendors_remove
        Me.SupprimerOffreToolStripMenuItem.Name = "SupprimerOffreToolStripMenuItem"
        Me.SupprimerOffreToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
        Me.SupprimerOffreToolStripMenuItem.Text = "     Supprimer la commande"
        Me.SupprimerOffreToolStripMenuItem.Visible = False
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.DGDem
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = Global.MBA.My.Resources.Resources.Excel_2013
        Me.ButtonX1.Location = New System.Drawing.Point(527, 56)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(253, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 9
        Me.ButtonX1.Text = "Exporter vers Excel"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Image = Global.MBA.My.Resources.Resources.sort
        Me.ButtonX2.Location = New System.Drawing.Point(527, 22)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(253, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 8
        Me.ButtonX2.Text = "Afficher la liste des demandes"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.au)
        Me.GroupBox1.Controls.Add(Me.du)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Controls.Add(Me.ButtonX2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(792, 85)
        Me.GroupBox1.TabIndex = 118
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "La liste des demandes :"
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
        Me.au.Location = New System.Drawing.Point(288, 24)
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
        Me.au.Size = New System.Drawing.Size(198, 23)
        Me.au.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.au.TabIndex = 24
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
        Me.du.Location = New System.Drawing.Point(39, 26)
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
        Me.du.Size = New System.Drawing.Size(198, 23)
        Me.du.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.du.TabIndex = 23
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(256, 22)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(26, 25)
        Me.LabelX2.TabIndex = 22
        Me.LabelX2.Text = "Au : "
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(12, 24)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(34, 25)
        Me.LabelX1.TabIndex = 21
        Me.LabelX1.Text = "Du :"
        '
        'ListeDemAch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 680)
        Me.Controls.Add(Me.DGDem)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Name = "ListeDemAch"
        Me.ShowIcon = False
        Me.Text = "Liste Demande Achat"
        CType(Me.DGDem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.au, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.du, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGDem As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GoogleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterUnNouveauOffreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierOffreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerOffreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents au As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents du As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
End Class
