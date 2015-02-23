<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListOffre
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
        Me.dgoffre = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GoogleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterUnNouveauOffreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierOffreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerOffreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimerOffreToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConvertitLoffreEnAffaireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.au = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.chargeaffaire = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.du = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ValiderLoffreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgoffre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.au, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.du, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgoffre
        '
        Me.dgoffre.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgoffre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgoffre.Location = New System.Drawing.Point(0, 85)
        Me.dgoffre.LookAndFeel.SkinName = "Office 2013"
        Me.dgoffre.LookAndFeel.UseDefaultLookAndFeel = False
        Me.dgoffre.MainView = Me.GridView1
        Me.dgoffre.Name = "dgoffre"
        Me.dgoffre.Size = New System.Drawing.Size(1199, 412)
        Me.dgoffre.TabIndex = 121
        Me.dgoffre.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoogleToolStripMenuItem, Me.AjouterUnNouveauOffreToolStripMenuItem, Me.ModifierOffreToolStripMenuItem, Me.SupprimerOffreToolStripMenuItem, Me.ImprimerOffreToolStripMenuItem1, Me.ConvertitLoffreEnAffaireToolStripMenuItem, Me.ValiderLoffreToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(235, 158)
        '
        'GoogleToolStripMenuItem
        '
        Me.GoogleToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.GoogleToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.vendors_database
        Me.GoogleToolStripMenuItem.Name = "GoogleToolStripMenuItem"
        Me.GoogleToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.GoogleToolStripMenuItem.Text = "     Actualiser la liste des offres    "
        '
        'AjouterUnNouveauOffreToolStripMenuItem
        '
        Me.AjouterUnNouveauOffreToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.AjouterUnNouveauOffreToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.vendors_add1
        Me.AjouterUnNouveauOffreToolStripMenuItem.Name = "AjouterUnNouveauOffreToolStripMenuItem"
        Me.AjouterUnNouveauOffreToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.AjouterUnNouveauOffreToolStripMenuItem.Text = "     Ajouter une nouvelle offre"
        '
        'ModifierOffreToolStripMenuItem
        '
        Me.ModifierOffreToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.ModifierOffreToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.vendors_edit
        Me.ModifierOffreToolStripMenuItem.Name = "ModifierOffreToolStripMenuItem"
        Me.ModifierOffreToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.ModifierOffreToolStripMenuItem.Text = "     Modifier l'offre selectionné"
        '
        'SupprimerOffreToolStripMenuItem
        '
        Me.SupprimerOffreToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.SupprimerOffreToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.vendors_remove
        Me.SupprimerOffreToolStripMenuItem.Name = "SupprimerOffreToolStripMenuItem"
        Me.SupprimerOffreToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.SupprimerOffreToolStripMenuItem.Text = "     Supprimer l'offre"
        '
        'ImprimerOffreToolStripMenuItem1
        '
        Me.ImprimerOffreToolStripMenuItem1.Image = Global.MBA.My.Resources.Resources.vendor_print
        Me.ImprimerOffreToolStripMenuItem1.Name = "ImprimerOffreToolStripMenuItem1"
        Me.ImprimerOffreToolStripMenuItem1.Size = New System.Drawing.Size(234, 22)
        Me.ImprimerOffreToolStripMenuItem1.Text = "     Imprimer la fiche de l'offre"
        '
        'ConvertitLoffreEnAffaireToolStripMenuItem
        '
        Me.ConvertitLoffreEnAffaireToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.user_id2
        Me.ConvertitLoffreEnAffaireToolStripMenuItem.Name = "ConvertitLoffreEnAffaireToolStripMenuItem"
        Me.ConvertitLoffreEnAffaireToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.ConvertitLoffreEnAffaireToolStripMenuItem.Text = "     Convertir l'offre en affaire"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.dgoffre
        Me.GridView1.Name = "GridView1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.au)
        Me.GroupBox1.Controls.Add(Me.chargeaffaire)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.du)
        Me.GroupBox1.Controls.Add(Me.ButtonX2)
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1199, 85)
        Me.GroupBox1.TabIndex = 120
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "La liste des Offres :"
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
        Me.au.Location = New System.Drawing.Point(284, 34)
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
        Me.au.Size = New System.Drawing.Size(179, 23)
        Me.au.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.au.TabIndex = 17
        '
        'chargeaffaire
        '
        Me.chargeaffaire.DisplayMember = "Text"
        Me.chargeaffaire.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.chargeaffaire.FormattingEnabled = True
        Me.chargeaffaire.ItemHeight = 17
        Me.chargeaffaire.Location = New System.Drawing.Point(579, 37)
        Me.chargeaffaire.Name = "chargeaffaire"
        Me.chargeaffaire.Size = New System.Drawing.Size(217, 23)
        Me.chargeaffaire.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chargeaffaire.TabIndex = 16
        Me.chargeaffaire.Visible = False
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(485, 34)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(97, 23)
        Me.LabelX3.TabIndex = 15
        Me.LabelX3.Text = "Chargé d'affaire :"
        Me.LabelX3.Visible = False
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(250, 30)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(28, 30)
        Me.LabelX2.TabIndex = 14
        Me.LabelX2.Text = "Au : "
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(21, 30)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(35, 30)
        Me.LabelX1.TabIndex = 13
        Me.LabelX1.Text = "Du :"
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
        Me.du.Location = New System.Drawing.Point(63, 34)
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
        Me.du.Size = New System.Drawing.Size(179, 23)
        Me.du.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.du.TabIndex = 11
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Image = Global.MBA.My.Resources.Resources.vendors_database1
        Me.ButtonX2.Location = New System.Drawing.Point(802, 37)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(178, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 10
        Me.ButtonX2.Text = "Afficher la liste des offres"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = Global.MBA.My.Resources.Resources.vendors_arrow_right
        Me.ButtonX1.Location = New System.Drawing.Point(999, 37)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(177, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 9
        Me.ButtonX1.Text = "Exporter vers Excel"
        '
        'ValiderLoffreToolStripMenuItem
        '
        Me.ValiderLoffreToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.security_lock
        Me.ValiderLoffreToolStripMenuItem.Name = "ValiderLoffreToolStripMenuItem"
        Me.ValiderLoffreToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.ValiderLoffreToolStripMenuItem.Text = "     Valider l'offre"
        Me.ValiderLoffreToolStripMenuItem.Visible = False
        '
        'ListOffre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1199, 497)
        Me.Controls.Add(Me.dgoffre)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.Name = "ListOffre"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Liste des Offres"
        CType(Me.dgoffre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.au, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.du, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgoffre As DevExpress.XtraGrid.GridControl
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GoogleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterUnNouveauOffreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierOffreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerOffreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimerOffreToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ConvertitLoffreEnAffaireToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents du As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents chargeaffaire As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents au As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents ValiderLoffreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
