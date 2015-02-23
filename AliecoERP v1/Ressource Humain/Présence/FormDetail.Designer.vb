<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetail
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lieux_de_Naissance = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.date_nais = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.nom = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.prenom = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dir = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.fonc = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.adr = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.au = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.du = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PFdg = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.date_nais, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.au, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.du, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PFdg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(521, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 224
        Me.Label1.Text = "Fonction :"
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
        Me.Lieux_de_Naissance.Location = New System.Drawing.Point(724, 85)
        Me.Lieux_de_Naissance.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Lieux_de_Naissance.Name = "Lieux_de_Naissance"
        Me.Lieux_de_Naissance.Size = New System.Drawing.Size(232, 25)
        Me.Lieux_de_Naissance.TabIndex = 221
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(520, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 219
        Me.Label3.Text = "Adresse :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(521, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 218
        Me.Label4.Text = "LIEU :"
        '
        'date_nais
        '
        Me.date_nais.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.date_nais.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.date_nais.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.date_nais.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.date_nais.ButtonDropDown.Visible = True
        Me.date_nais.ForeColor = System.Drawing.Color.Black
        Me.date_nais.Format = DevComponents.Editors.eDateTimePickerFormat.[Long]
        Me.date_nais.IsPopupCalendarOpen = False
        Me.date_nais.Location = New System.Drawing.Point(261, 115)
        Me.date_nais.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        '
        '
        '
        Me.date_nais.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.date_nais.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.date_nais.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.date_nais.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.date_nais.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.date_nais.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.date_nais.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.date_nais.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.date_nais.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.date_nais.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.date_nais.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.date_nais.MonthCalendar.DisplayMonth = New Date(2013, 12, 1, 0, 0, 0, 0)
        Me.date_nais.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.date_nais.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.date_nais.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.date_nais.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.date_nais.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.date_nais.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.date_nais.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.date_nais.MonthCalendar.TodayButtonVisible = True
        Me.date_nais.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.date_nais.Name = "date_nais"
        Me.date_nais.Size = New System.Drawing.Size(232, 25)
        Me.date_nais.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.date_nais.TabIndex = 217
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
        Me.nom.Location = New System.Drawing.Point(261, 85)
        Me.nom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(232, 25)
        Me.nom.TabIndex = 216
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
        Me.prenom.Location = New System.Drawing.Point(261, 56)
        Me.prenom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.prenom.Name = "prenom"
        Me.prenom.Size = New System.Drawing.Size(232, 25)
        Me.prenom.TabIndex = 215
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(56, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 17)
        Me.Label5.TabIndex = 214
        Me.Label5.Text = "Date de Naissance :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(56, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 17)
        Me.Label6.TabIndex = 213
        Me.Label6.Text = "Nom :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(56, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 17)
        Me.Label10.TabIndex = 212
        Me.Label10.Text = "Prénom :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(56, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 17)
        Me.Label11.TabIndex = 211
        Me.Label11.Text = "Matricule :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dir)
        Me.GroupBox1.Controls.Add(Me.fonc)
        Me.GroupBox1.Controls.Add(Me.adr)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.au)
        Me.GroupBox1.Controls.Add(Me.du)
        Me.GroupBox1.Controls.Add(Me.TextBoxX1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.prenom)
        Me.GroupBox1.Controls.Add(Me.Lieux_de_Naissance)
        Me.GroupBox1.Controls.Add(Me.nom)
        Me.GroupBox1.Controls.Add(Me.date_nais)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1261, 196)
        Me.GroupBox1.TabIndex = 226
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Les informations de pointage de fonctionnaire :"
        '
        'dir
        '
        Me.dir.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.dir.Border.Class = "TextBoxBorder"
        Me.dir.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dir.ForeColor = System.Drawing.Color.Black
        Me.dir.Location = New System.Drawing.Point(724, 27)
        Me.dir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dir.Name = "dir"
        Me.dir.Size = New System.Drawing.Size(232, 25)
        Me.dir.TabIndex = 235
        '
        'fonc
        '
        Me.fonc.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.fonc.Border.Class = "TextBoxBorder"
        Me.fonc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fonc.ForeColor = System.Drawing.Color.Black
        Me.fonc.Location = New System.Drawing.Point(724, 56)
        Me.fonc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.fonc.Name = "fonc"
        Me.fonc.Size = New System.Drawing.Size(232, 25)
        Me.fonc.TabIndex = 234
        '
        'adr
        '
        Me.adr.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.adr.Border.Class = "TextBoxBorder"
        Me.adr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.adr.ForeColor = System.Drawing.Color.Black
        Me.adr.Location = New System.Drawing.Point(724, 115)
        Me.adr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.adr.Name = "adr"
        Me.adr.Size = New System.Drawing.Size(232, 25)
        Me.adr.TabIndex = 233
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(520, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 231
        Me.Label2.Text = "Direction :"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(524, 137)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(40, 33)
        Me.LabelX2.TabIndex = 230
        Me.LabelX2.Text = "Au : "
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(59, 137)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(40, 33)
        Me.LabelX1.TabIndex = 229
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
        Me.au.Location = New System.Drawing.Point(724, 145)
        Me.au.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
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
        Me.au.Size = New System.Drawing.Size(231, 25)
        Me.au.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.au.TabIndex = 228
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
        Me.du.Location = New System.Drawing.Point(262, 145)
        Me.du.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
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
        Me.du.Size = New System.Drawing.Size(231, 25)
        Me.du.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.du.TabIndex = 227
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
        Me.TextBoxX1.Location = New System.Drawing.Point(261, 27)
        Me.TextBoxX1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.Size = New System.Drawing.Size(232, 25)
        Me.TextBoxX1.TabIndex = 226
        '
        'PFdg
        '
        Me.PFdg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PFdg.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PFdg.Location = New System.Drawing.Point(0, 196)
        Me.PFdg.LookAndFeel.SkinName = "Office 2013"
        Me.PFdg.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PFdg.MainView = Me.GridView1
        Me.PFdg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PFdg.Name = "PFdg"
        Me.PFdg.Size = New System.Drawing.Size(1261, 628)
        Me.PFdg.TabIndex = 227
        Me.PFdg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.PFdg
        Me.GridView1.Name = "GridView1"
        '
        'FormDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1261, 824)
        Me.Controls.Add(Me.PFdg)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormDetail"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Detail de Pointage de l'employé"
        CType(Me.date_nais, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.au, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.du, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PFdg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lieux_de_Naissance As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents date_nais As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents nom As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents prenom As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents au As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents du As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents PFdg As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fonc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents adr As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dir As DevComponents.DotNetBar.Controls.TextBoxX
End Class
