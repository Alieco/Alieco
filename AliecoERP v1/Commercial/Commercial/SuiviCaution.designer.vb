<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuiviCaution
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GoogleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierOffreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.etatcaution = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem13 = New DevComponents.Editors.ComboItem()
        Me.ComboItem14 = New DevComponents.Editors.ComboItem()
        Me.ComboItem15 = New DevComponents.Editors.ComboItem()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.titreaffaire = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.montantc = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.typecaution = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.nemoro = New DevComponents.DotNetBar.LabelX()
        Me.reglementtxt = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.DateTimeInput1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.modalite = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.montantmodalite = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.codeaffaire = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.creancetxt = New DevComponents.DotNetBar.LabelX()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DateTimeInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.ForeColor = System.Drawing.Color.Black
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(0, 132)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1192, 609)
        Me.ListView1.TabIndex = 129
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Code affaire"
        Me.ColumnHeader1.Width = 99
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Affaire"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 206
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Montant"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 179
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Etat"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 143
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Date"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 160
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "type caution"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 113
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoogleToolStripMenuItem, Me.ModifierOffreToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(227, 48)
        '
        'GoogleToolStripMenuItem
        '
        Me.GoogleToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.GoogleToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.vendors_database
        Me.GoogleToolStripMenuItem.Name = "GoogleToolStripMenuItem"
        Me.GoogleToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.GoogleToolStripMenuItem.Text = "     Actualiser     "
        '
        'ModifierOffreToolStripMenuItem
        '
        Me.ModifierOffreToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.ModifierOffreToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.vendors_edit
        Me.ModifierOffreToolStripMenuItem.Name = "ModifierOffreToolStripMenuItem"
        Me.ModifierOffreToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.ModifierOffreToolStripMenuItem.Text = "     Modifier l'affaire selectionné"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.etatcaution)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.titreaffaire)
        Me.GroupBox1.Controls.Add(Me.montantc)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.typecaution)
        Me.GroupBox1.Controls.Add(Me.LabelX7)
        Me.GroupBox1.Controls.Add(Me.ButtonX2)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.codeaffaire)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1192, 132)
        Me.GroupBox1.TabIndex = 128
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Veuillez saisir le code de l'affaire :"
        '
        'etatcaution
        '
        Me.etatcaution.DisplayMember = "Text"
        Me.etatcaution.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.etatcaution.ForeColor = System.Drawing.Color.Black
        Me.etatcaution.FormattingEnabled = True
        Me.etatcaution.ItemHeight = 17
        Me.etatcaution.Items.AddRange(New Object() {Me.ComboItem13, Me.ComboItem14, Me.ComboItem15})
        Me.etatcaution.Location = New System.Drawing.Point(440, 55)
        Me.etatcaution.Name = "etatcaution"
        Me.etatcaution.Size = New System.Drawing.Size(196, 23)
        Me.etatcaution.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.etatcaution.TabIndex = 44
        '
        'ComboItem13
        '
        Me.ComboItem13.Text = "Fait"
        '
        'ComboItem14
        '
        Me.ComboItem14.Text = "En cours"
        '
        'ComboItem15
        '
        Me.ComboItem15.Text = "N/A"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(337, 55)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(97, 23)
        Me.LabelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.LabelX3.TabIndex = 42
        Me.LabelX3.Text = "Etat caution :"
        '
        'titreaffaire
        '
        Me.titreaffaire.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.titreaffaire.Border.Class = "TextBoxBorder"
        Me.titreaffaire.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.titreaffaire.ForeColor = System.Drawing.Color.Black
        Me.titreaffaire.Location = New System.Drawing.Point(440, 23)
        Me.titreaffaire.Name = "titreaffaire"
        Me.titreaffaire.Size = New System.Drawing.Size(196, 23)
        Me.titreaffaire.TabIndex = 41
        '
        'montantc
        '
        Me.montantc.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.montantc.Border.Class = "TextBoxBorder"
        Me.montantc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.montantc.ForeColor = System.Drawing.Color.Black
        Me.montantc.Location = New System.Drawing.Point(117, 84)
        Me.montantc.Name = "montantc"
        Me.montantc.Size = New System.Drawing.Size(196, 23)
        Me.montantc.TabIndex = 39
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(14, 84)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(97, 23)
        Me.LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.LabelX1.TabIndex = 38
        Me.LabelX1.Text = "Montant caution :"
        '
        'typecaution
        '
        Me.typecaution.DisplayMember = "Text"
        Me.typecaution.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.typecaution.ForeColor = System.Drawing.Color.Black
        Me.typecaution.FormattingEnabled = True
        Me.typecaution.ItemHeight = 17
        Me.typecaution.Items.AddRange(New Object() {Me.ComboItem5, Me.ComboItem6, Me.ComboItem7, Me.ComboItem8})
        Me.typecaution.Location = New System.Drawing.Point(117, 52)
        Me.typecaution.Name = "typecaution"
        Me.typecaution.Size = New System.Drawing.Size(196, 23)
        Me.typecaution.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.typecaution.TabIndex = 37
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "Caution d'avance forfaitaire"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "caution d'avance d'approvisionnement"
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "caution de bonne execution"
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "caution de soumission"
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(14, 55)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(97, 23)
        Me.LabelX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.LabelX7.TabIndex = 36
        Me.LabelX7.Text = "Type caution : "
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = Global.MBA.My.Resources.Resources.add_button
        Me.ButtonX2.Location = New System.Drawing.Point(623, 102)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(260, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 35
        Me.ButtonX2.Text = "Ajouter"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(337, 23)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(81, 23)
        Me.LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.LabelX2.TabIndex = 27
        Me.LabelX2.Text = "Titre affaire :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.nemoro)
        Me.GroupBox2.Controls.Add(Me.reglementtxt)
        Me.GroupBox2.Controls.Add(Me.DateTimeInput1)
        Me.GroupBox2.Controls.Add(Me.modalite)
        Me.GroupBox2.Controls.Add(Me.ButtonX1)
        Me.GroupBox2.Controls.Add(Me.montantmodalite)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(12, 158)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(557, 136)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ajout de paiement :"
        '
        'nemoro
        '
        Me.nemoro.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.nemoro.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.nemoro.ForeColor = System.Drawing.Color.Black
        Me.nemoro.Location = New System.Drawing.Point(6, 51)
        Me.nemoro.Name = "nemoro"
        Me.nemoro.Size = New System.Drawing.Size(202, 23)
        Me.nemoro.TabIndex = 27
        '
        'reglementtxt
        '
        Me.reglementtxt.DisplayMember = "Text"
        Me.reglementtxt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.reglementtxt.ForeColor = System.Drawing.Color.Black
        Me.reglementtxt.FormattingEnabled = True
        Me.reglementtxt.ItemHeight = 17
        Me.reglementtxt.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4})
        Me.reglementtxt.Location = New System.Drawing.Point(309, 80)
        Me.reglementtxt.Name = "reglementtxt"
        Me.reglementtxt.Size = New System.Drawing.Size(144, 23)
        Me.reglementtxt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.reglementtxt.TabIndex = 26
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "FAIT"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "En Cours"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "N/A"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "/"
        '
        'DateTimeInput1
        '
        Me.DateTimeInput1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.DateTimeInput1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DateTimeInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DateTimeInput1.ButtonDropDown.Visible = True
        Me.DateTimeInput1.ForeColor = System.Drawing.Color.Black
        Me.DateTimeInput1.IsPopupCalendarOpen = False
        Me.DateTimeInput1.Location = New System.Drawing.Point(309, 51)
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput1.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DateTimeInput1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DateTimeInput1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput1.MonthCalendar.DisplayMonth = New Date(2014, 8, 1, 0, 0, 0, 0)
        Me.DateTimeInput1.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.DateTimeInput1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.DateTimeInput1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DateTimeInput1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateTimeInput1.MonthCalendar.TodayButtonVisible = True
        Me.DateTimeInput1.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.DateTimeInput1.Name = "DateTimeInput1"
        Me.DateTimeInput1.Size = New System.Drawing.Size(196, 23)
        Me.DateTimeInput1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DateTimeInput1.TabIndex = 25
        '
        'modalite
        '
        Me.modalite.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.modalite.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.modalite.ForeColor = System.Drawing.Color.Black
        Me.modalite.Location = New System.Drawing.Point(6, 22)
        Me.modalite.Name = "modalite"
        Me.modalite.Size = New System.Drawing.Size(283, 23)
        Me.modalite.TabIndex = 24
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(309, 107)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(286, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 23
        Me.ButtonX1.Text = "Modifier et enregistrer"
        '
        'montantmodalite
        '
        Me.montantmodalite.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.montantmodalite.Border.Class = "TextBoxBorder"
        Me.montantmodalite.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.montantmodalite.ForeColor = System.Drawing.Color.Black
        Me.montantmodalite.Location = New System.Drawing.Point(309, 22)
        Me.montantmodalite.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.montantmodalite.Name = "montantmodalite"
        Me.montantmodalite.Size = New System.Drawing.Size(196, 23)
        Me.montantmodalite.TabIndex = 22
        Me.montantmodalite.WatermarkText = "Monatant ..."
        '
        'codeaffaire
        '
        Me.codeaffaire.DisplayMember = "Text"
        Me.codeaffaire.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.codeaffaire.ForeColor = System.Drawing.Color.Black
        Me.codeaffaire.FormattingEnabled = True
        Me.codeaffaire.ItemHeight = 17
        Me.codeaffaire.Location = New System.Drawing.Point(13, 23)
        Me.codeaffaire.Name = "codeaffaire"
        Me.codeaffaire.Size = New System.Drawing.Size(300, 23)
        Me.codeaffaire.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.codeaffaire.TabIndex = 11
        '
        'creancetxt
        '
        Me.creancetxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.creancetxt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.creancetxt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.creancetxt.ForeColor = System.Drawing.Color.Black
        Me.creancetxt.Location = New System.Drawing.Point(375, 551)
        Me.creancetxt.Name = "creancetxt"
        Me.creancetxt.Size = New System.Drawing.Size(176, 23)
        Me.creancetxt.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.creancetxt.TabIndex = 131
        '
        'SuiviCaution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 741)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.creancetxt)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SuiviCaution"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Suivis des Cautions"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DateTimeInput1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents nemoro As DevComponents.DotNetBar.LabelX
    Friend WithEvents reglementtxt As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents DateTimeInput1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents modalite As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents montantmodalite As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents codeaffaire As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents creancetxt As DevComponents.DotNetBar.LabelX
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents montantc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents typecaution As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents titreaffaire As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GoogleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierOffreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents etatcaution As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem13 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem14 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem15 As DevComponents.Editors.ComboItem
End Class
