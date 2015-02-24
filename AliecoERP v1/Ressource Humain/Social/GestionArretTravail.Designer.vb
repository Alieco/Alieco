<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionArretTravail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionArretTravail))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.au = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.du = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.ListMatNom = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.arretDgv = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ActualiserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.StatImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox1.SuspendLayout()
        CType(Me.au, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.du, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListMatNom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arretDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.au)
        Me.GroupBox1.Controls.Add(Me.du)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.ButtonX4)
        Me.GroupBox1.Controls.Add(Me.ListMatNom)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1336, 107)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Controle des Arréts"
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
        Me.au.IsPopupCalendarOpen = False
        Me.au.Location = New System.Drawing.Point(286, 25)
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
        Me.au.MonthCalendar.DisplayMonth = New Date(2014, 12, 1, 0, 0, 0, 0)
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
        Me.au.Size = New System.Drawing.Size(173, 25)
        Me.au.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.au.TabIndex = 276
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
        Me.du.IsPopupCalendarOpen = False
        Me.du.Location = New System.Drawing.Point(76, 25)
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
        Me.du.MonthCalendar.DisplayMonth = New Date(2014, 12, 1, 0, 0, 0, 0)
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
        Me.du.Size = New System.Drawing.Size(157, 25)
        Me.du.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.du.TabIndex = 275
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(239, 25)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(24, 25)
        Me.LabelX2.TabIndex = 272
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
        Me.LabelX1.Location = New System.Drawing.Point(43, 27)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(27, 25)
        Me.LabelX1.TabIndex = 271
        Me.LabelX1.Text = "Du :"
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX4.Image = Global.MBA.My.Resources.Resources.sort
        Me.ButtonX4.Location = New System.Drawing.Point(479, 71)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(209, 23)
        Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX4.TabIndex = 268
        Me.ButtonX4.Text = "Afficher la liste des arrets de travail"
        '
        'ListMatNom
        '
        Me.ListMatNom.Location = New System.Drawing.Point(43, 72)
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
        Me.ListMatNom.Size = New System.Drawing.Size(416, 22)
        Me.ListMatNom.TabIndex = 267
        '
        'arretDgv
        '
        Me.arretDgv.ContextMenuStrip = Me.ContextMenuStrip1
        Me.arretDgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.arretDgv.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White
        Me.arretDgv.EmbeddedNavigator.Appearance.ForeColor = System.Drawing.Color.Black
        Me.arretDgv.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.arretDgv.EmbeddedNavigator.Appearance.Options.UseForeColor = True
        Me.arretDgv.Location = New System.Drawing.Point(0, 107)
        Me.arretDgv.LookAndFeel.SkinName = "Office 2013"
        Me.arretDgv.LookAndFeel.UseDefaultLookAndFeel = False
        Me.arretDgv.MainView = Me.GridView1
        Me.arretDgv.Name = "arretDgv"
        Me.arretDgv.Size = New System.Drawing.Size(1336, 823)
        Me.arretDgv.TabIndex = 1
        Me.arretDgv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActualiserToolStripMenuItem, Me.AjouterToolStripMenuItem, Me.SupprimerToolStripMenuItem, Me.ModifierToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(278, 92)
        '
        'ActualiserToolStripMenuItem
        '
        Me.ActualiserToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.ActualiserToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.refersh
        Me.ActualiserToolStripMenuItem.Name = "ActualiserToolStripMenuItem"
        Me.ActualiserToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.ActualiserToolStripMenuItem.Text = "     Actualiser la liste des arrets de travail  "
        '
        'AjouterToolStripMenuItem
        '
        Me.AjouterToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.AjouterToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.add
        Me.AjouterToolStripMenuItem.Name = "AjouterToolStripMenuItem"
        Me.AjouterToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.AjouterToolStripMenuItem.Text = "     Ajouter un nouveau arret de travail"
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.SupprimerToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.delete
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.SupprimerToolStripMenuItem.Text = "     Supprimer le  arret de travail"
        '
        'ModifierToolStripMenuItem
        '
        Me.ModifierToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.ModifierToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.edit
        Me.ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        Me.ModifierToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.ModifierToolStripMenuItem.Text = "     Modifier l' arret de travail selectionné"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.arretDgv
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
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
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelX3.Location = New System.Drawing.Point(533, 29)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(488, 23)
        Me.LabelX3.TabIndex = 277
        '
        'GestionArretTravail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1336, 930)
        Me.Controls.Add(Me.arretDgv)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GestionArretTravail"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion des Arréts de Travail"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.au, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.du, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListMatNom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arretDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents arretDgv As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ListMatNom As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents StatImageList As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ActualiserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents au As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents du As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
End Class
