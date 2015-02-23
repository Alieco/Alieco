<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuiviFacturation
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.impot = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.identifFisc = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
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
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.montantttc = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.du = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.nReg = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.montanttxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.objet = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.etatTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.creancetxt = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.htTxt = New DevComponents.DotNetBar.LabelX()
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX()
        Me.ttcTxt = New DevComponents.DotNetBar.LabelX()
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DateTimeInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.ListView1.ForeColor = System.Drawing.Color.Black
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(9, 189)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1212, 303)
        Me.ListView1.TabIndex = 129
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Date"
        Me.ColumnHeader1.Width = 94
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "N°"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "CA. Montant HT"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 129
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "CA. Montant TTC"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 146
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Retenue. Avance"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 146
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Retenue. Garantie"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 177
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Net a payer"
        Me.ColumnHeader7.Width = 142
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Reg."
        Me.ColumnHeader8.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Mode de réglement"
        Me.ColumnHeader9.Width = 208
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.ButtonX2)
        Me.GroupBox1.Controls.Add(Me.LabelX14)
        Me.GroupBox1.Controls.Add(Me.impot)
        Me.GroupBox1.Controls.Add(Me.LabelX13)
        Me.GroupBox1.Controls.Add(Me.identifFisc)
        Me.GroupBox1.Controls.Add(Me.LabelX12)
        Me.GroupBox1.Controls.Add(Me.TextBoxX2)
        Me.GroupBox1.Controls.Add(Me.LabelX11)
        Me.GroupBox1.Controls.Add(Me.LabelX10)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.LabelX8)
        Me.GroupBox1.Controls.Add(Me.LabelX7)
        Me.GroupBox1.Controls.Add(Me.LabelX6)
        Me.GroupBox1.Controls.Add(Me.montantttc)
        Me.GroupBox1.Controls.Add(Me.LabelX5)
        Me.GroupBox1.Controls.Add(Me.du)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.nReg)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.montanttxt)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.objet)
        Me.GroupBox1.Controls.Add(Me.ComboBoxEx1)
        Me.GroupBox1.Controls.Add(Me.etatTxt)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1348, 181)
        Me.GroupBox1.TabIndex = 128
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ajout d'affaire :"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Image = Global.MBA.My.Resources.Resources.order_export
        Me.ButtonX2.Location = New System.Drawing.Point(697, 28)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(135, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 35
        Me.ButtonX2.Text = "Exporter le resultat"
        '
        'LabelX14
        '
        Me.LabelX14.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.ForeColor = System.Drawing.Color.Black
        Me.LabelX14.Location = New System.Drawing.Point(607, 145)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(84, 27)
        Me.LabelX14.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.LabelX14.TabIndex = 34
        Me.LabelX14.Text = "Art. Impot :"
        '
        'impot
        '
        Me.impot.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.impot.Border.Class = "TextBoxBorder"
        Me.impot.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.impot.ForeColor = System.Drawing.Color.Black
        Me.impot.Location = New System.Drawing.Point(697, 145)
        Me.impot.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.impot.Name = "impot"
        Me.impot.Size = New System.Drawing.Size(135, 23)
        Me.impot.TabIndex = 33
        '
        'LabelX13
        '
        Me.LabelX13.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.ForeColor = System.Drawing.Color.Black
        Me.LabelX13.Location = New System.Drawing.Point(331, 148)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(113, 27)
        Me.LabelX13.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.LabelX13.TabIndex = 32
        Me.LabelX13.Text = "Identif. Fisc. :"
        '
        'identifFisc
        '
        Me.identifFisc.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.identifFisc.Border.Class = "TextBoxBorder"
        Me.identifFisc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.identifFisc.ForeColor = System.Drawing.Color.Black
        Me.identifFisc.Location = New System.Drawing.Point(459, 150)
        Me.identifFisc.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.identifFisc.Name = "identifFisc"
        Me.identifFisc.Size = New System.Drawing.Size(135, 23)
        Me.identifFisc.TabIndex = 31
        '
        'LabelX12
        '
        Me.LabelX12.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.ForeColor = System.Drawing.Color.Black
        Me.LabelX12.Location = New System.Drawing.Point(607, 112)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(84, 27)
        Me.LabelX12.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.LabelX12.TabIndex = 30
        Me.LabelX12.Text = "Maché /B/Cde :"
        '
        'TextBoxX2
        '
        Me.TextBoxX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX2.Border.Class = "TextBoxBorder"
        Me.TextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX2.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX2.Location = New System.Drawing.Point(697, 114)
        Me.TextBoxX2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TextBoxX2.Name = "TextBoxX2"
        Me.TextBoxX2.Size = New System.Drawing.Size(135, 23)
        Me.TextBoxX2.TabIndex = 29
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.ForeColor = System.Drawing.Color.Black
        Me.LabelX11.Location = New System.Drawing.Point(321, 44)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(75, 27)
        Me.LabelX11.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.LabelX11.TabIndex = 28
        Me.LabelX11.Text = "Nom client :"
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.ForeColor = System.Drawing.Color.Black
        Me.LabelX10.Location = New System.Drawing.Point(9, 24)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(75, 27)
        Me.LabelX10.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.LabelX10.TabIndex = 27
        Me.LabelX10.Text = "Code affaire :"
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 182)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(612, 157)
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
        Me.nemoro.Location = New System.Drawing.Point(6, 59)
        Me.nemoro.Name = "nemoro"
        Me.nemoro.Size = New System.Drawing.Size(202, 27)
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
        Me.reglementtxt.Location = New System.Drawing.Point(309, 92)
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
        Me.DateTimeInput1.Location = New System.Drawing.Point(309, 59)
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
        Me.modalite.Location = New System.Drawing.Point(6, 25)
        Me.modalite.Name = "modalite"
        Me.modalite.Size = New System.Drawing.Size(283, 27)
        Me.modalite.TabIndex = 24
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(309, 123)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(286, 27)
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
        Me.montantmodalite.Location = New System.Drawing.Point(309, 25)
        Me.montantmodalite.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.montantmodalite.Name = "montantmodalite"
        Me.montantmodalite.Size = New System.Drawing.Size(196, 23)
        Me.montantmodalite.TabIndex = 22
        Me.montantmodalite.WatermarkText = "Monatant ..."
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.ForeColor = System.Drawing.Color.Black
        Me.LabelX8.Location = New System.Drawing.Point(972, 147)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(189, 27)
        Me.LabelX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.LabelX8.TabIndex = 25
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(862, 147)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(104, 27)
        Me.LabelX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.LabelX7.TabIndex = 24
        Me.LabelX7.Text = "Charger d'affaire : "
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(331, 112)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(104, 27)
        Me.LabelX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.LabelX6.TabIndex = 22
        Me.LabelX6.Text = "Montant en TTC :"
        '
        'montantttc
        '
        Me.montantttc.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.montantttc.Border.Class = "TextBoxBorder"
        Me.montantttc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.montantttc.ForeColor = System.Drawing.Color.Black
        Me.montantttc.Location = New System.Drawing.Point(459, 114)
        Me.montantttc.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.montantttc.Name = "montantttc"
        Me.montantttc.Size = New System.Drawing.Size(135, 23)
        Me.montantttc.TabIndex = 21
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(331, 78)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(55, 27)
        Me.LabelX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.LabelX5.TabIndex = 20
        Me.LabelX5.Text = "Année :"
        '
        'du
        '
        Me.du.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.du.Border.Class = "TextBoxBorder"
        Me.du.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.du.ForeColor = System.Drawing.Color.Black
        Me.du.Location = New System.Drawing.Point(459, 81)
        Me.du.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.du.Name = "du"
        Me.du.Size = New System.Drawing.Size(135, 23)
        Me.du.TabIndex = 19
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(12, 148)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(113, 27)
        Me.LabelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.LabelX4.TabIndex = 18
        Me.LabelX4.Text = "Reg. Comm :"
        '
        'nReg
        '
        Me.nReg.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.nReg.Border.Class = "TextBoxBorder"
        Me.nReg.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.nReg.ForeColor = System.Drawing.Color.Black
        Me.nReg.Location = New System.Drawing.Point(131, 148)
        Me.nReg.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.nReg.Name = "nReg"
        Me.nReg.Size = New System.Drawing.Size(181, 23)
        Me.nReg.TabIndex = 17
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(12, 112)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(113, 27)
        Me.LabelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.LabelX3.TabIndex = 16
        Me.LabelX3.Text = "Montant en HT:"
        '
        'montanttxt
        '
        Me.montanttxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.montanttxt.Border.Class = "TextBoxBorder"
        Me.montanttxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.montanttxt.ForeColor = System.Drawing.Color.Black
        Me.montanttxt.Location = New System.Drawing.Point(131, 112)
        Me.montanttxt.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.montanttxt.Name = "montanttxt"
        Me.montanttxt.Size = New System.Drawing.Size(181, 23)
        Me.montanttxt.TabIndex = 15
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(12, 78)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 27)
        Me.LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.LabelX2.TabIndex = 14
        Me.LabelX2.Text = "Objet :"
        '
        'objet
        '
        Me.objet.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.objet.Border.Class = "TextBoxBorder"
        Me.objet.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.objet.ForeColor = System.Drawing.Color.Black
        Me.objet.Location = New System.Drawing.Point(131, 81)
        Me.objet.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.objet.Name = "objet"
        Me.objet.Size = New System.Drawing.Size(181, 23)
        Me.objet.TabIndex = 13
        '
        'ComboBoxEx1
        '
        Me.ComboBoxEx1.DisplayMember = "Text"
        Me.ComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx1.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxEx1.FormattingEnabled = True
        Me.ComboBoxEx1.ItemHeight = 17
        Me.ComboBoxEx1.Location = New System.Drawing.Point(131, 28)
        Me.ComboBoxEx1.Name = "ComboBoxEx1"
        Me.ComboBoxEx1.Size = New System.Drawing.Size(135, 23)
        Me.ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx1.TabIndex = 11
        '
        'etatTxt
        '
        Me.etatTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.etatTxt.Border.Class = "TextBoxBorder"
        Me.etatTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.etatTxt.ForeColor = System.Drawing.Color.Black
        Me.etatTxt.Location = New System.Drawing.Point(413, 48)
        Me.etatTxt.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.etatTxt.Name = "etatTxt"
        Me.etatTxt.Size = New System.Drawing.Size(181, 23)
        Me.etatTxt.TabIndex = 10
        '
        'creancetxt
        '
        Me.creancetxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.creancetxt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.creancetxt.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.creancetxt.ForeColor = System.Drawing.Color.Black
        Me.creancetxt.Location = New System.Drawing.Point(607, 500)
        Me.creancetxt.Name = "creancetxt"
        Me.creancetxt.Size = New System.Drawing.Size(614, 27)
        Me.creancetxt.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.creancetxt.TabIndex = 131
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.ForeColor = System.Drawing.Color.Black
        Me.LabelX9.Location = New System.Drawing.Point(477, 497)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(124, 27)
        Me.LabelX9.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.LabelX9.TabIndex = 130
        Me.LabelX9.Text = "TOTAL CREANCE :"
        '
        'htTxt
        '
        Me.htTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.htTxt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.htTxt.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.htTxt.ForeColor = System.Drawing.Color.Black
        Me.htTxt.Location = New System.Drawing.Point(201, 500)
        Me.htTxt.Name = "htTxt"
        Me.htTxt.Size = New System.Drawing.Size(185, 27)
        Me.htTxt.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.htTxt.TabIndex = 133
        '
        'LabelX16
        '
        Me.LabelX16.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX16.ForeColor = System.Drawing.Color.Black
        Me.LabelX16.Location = New System.Drawing.Point(12, 500)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(158, 27)
        Me.LabelX16.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.LabelX16.TabIndex = 132
        Me.LabelX16.Text = "TOTAL Montant Payé  <b>(HT)</b> :"
        '
        'ttcTxt
        '
        Me.ttcTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.ttcTxt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ttcTxt.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttcTxt.ForeColor = System.Drawing.Color.Black
        Me.ttcTxt.Location = New System.Drawing.Point(201, 533)
        Me.ttcTxt.Name = "ttcTxt"
        Me.ttcTxt.Size = New System.Drawing.Size(185, 27)
        Me.ttcTxt.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.ttcTxt.TabIndex = 135
        '
        'LabelX18
        '
        Me.LabelX18.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX18.ForeColor = System.Drawing.Color.Black
        Me.LabelX18.Location = New System.Drawing.Point(12, 533)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(158, 27)
        Me.LabelX18.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.LabelX18.TabIndex = 134
        Me.LabelX18.Text = "TOTAL Montant Payé <b>(TTC)</b> :"
        '
        'SuiviFacturation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 660)
        Me.Controls.Add(Me.ttcTxt)
        Me.Controls.Add(Me.LabelX18)
        Me.Controls.Add(Me.htTxt)
        Me.Controls.Add(Me.LabelX16)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.creancetxt)
        Me.Controls.Add(Me.LabelX9)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SuiviFacturation"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Suivi Facturation"
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
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
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
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents montantttc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents du As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents nReg As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents montanttxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents objet As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ComboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents etatTxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents creancetxt As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents impot As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents identifFisc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents htTxt As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ttcTxt As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
End Class
