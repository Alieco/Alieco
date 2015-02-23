<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EffictifEnFormation
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.datenais = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.mat = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.nom = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.prenom = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.natureformation = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.specialite = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.prevu = New DevComponents.DotNetBar.LabelX()
        Me.alternance = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.fonctiuonnairecount = New DevComponents.DotNetBar.LabelX()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.idformation = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox1.SuspendLayout()
        CType(Me.datenais, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.idformation)
        Me.GroupBox1.Controls.Add(Me.ButtonX3)
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Controls.Add(Me.DataGridViewX1)
        Me.GroupBox1.Controls.Add(Me.ButtonX2)
        Me.GroupBox1.Controls.Add(Me.fonctiuonnairecount)
        Me.GroupBox1.Controls.Add(Me.LabelX5)
        Me.GroupBox1.Controls.Add(Me.alternance)
        Me.GroupBox1.Controls.Add(Me.prevu)
        Me.GroupBox1.Controls.Add(Me.natureformation)
        Me.GroupBox1.Controls.Add(Me.specialite)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.datenais)
        Me.GroupBox1.Controls.Add(Me.mat)
        Me.GroupBox1.Controls.Add(Me.nom)
        Me.GroupBox1.Controls.Add(Me.prenom)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1177, 404)
        Me.GroupBox1.TabIndex = 111
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Assignation du Fonctionnaire:"
        '
        'datenais
        '
        Me.datenais.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.datenais.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.datenais.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.datenais.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.datenais.ButtonDropDown.Visible = True
        Me.datenais.ForeColor = System.Drawing.Color.Black
        Me.datenais.Format = DevComponents.Editors.eDateTimePickerFormat.[Long]
        Me.datenais.IsPopupCalendarOpen = False
        Me.datenais.Location = New System.Drawing.Point(208, 290)
        '
        '
        '
        Me.datenais.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.datenais.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.datenais.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.datenais.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.datenais.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.datenais.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.datenais.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.datenais.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.datenais.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.datenais.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.datenais.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.datenais.MonthCalendar.DisplayMonth = New Date(2013, 12, 1, 0, 0, 0, 0)
        Me.datenais.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.datenais.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.datenais.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.datenais.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.datenais.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.datenais.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.datenais.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.datenais.MonthCalendar.TodayButtonVisible = True
        Me.datenais.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.datenais.Name = "datenais"
        Me.datenais.Size = New System.Drawing.Size(229, 25)
        Me.datenais.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.datenais.TabIndex = 96
        '
        'mat
        '
        Me.mat.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.mat.BackgroundStyle.Class = "TextBoxBorder"
        Me.mat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mat.ButtonClear.Visible = True
        Me.mat.ForeColor = System.Drawing.Color.Black
        Me.mat.Location = New System.Drawing.Point(208, 194)
        Me.mat.Mask = "00000"
        Me.mat.Name = "mat"
        Me.mat.Size = New System.Drawing.Size(229, 20)
        Me.mat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.mat.TabIndex = 91
        Me.mat.Text = ""
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
        Me.nom.Location = New System.Drawing.Point(208, 259)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(229, 25)
        Me.nom.TabIndex = 90
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
        Me.prenom.Location = New System.Drawing.Point(208, 225)
        Me.prenom.Name = "prenom"
        Me.prenom.Size = New System.Drawing.Size(229, 25)
        Me.prenom.TabIndex = 89
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(33, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 17)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Date de Naissance :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(33, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Nom :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(33, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Prénom :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(33, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Matricule :"
        '
        'natureformation
        '
        Me.natureformation.DisplayMember = "Text"
        Me.natureformation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.natureformation.FormattingEnabled = True
        Me.natureformation.ItemHeight = 19
        Me.natureformation.Location = New System.Drawing.Point(208, 73)
        Me.natureformation.Name = "natureformation"
        Me.natureformation.Size = New System.Drawing.Size(229, 25)
        Me.natureformation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.natureformation.TabIndex = 168
        '
        'specialite
        '
        Me.specialite.DisplayMember = "Text"
        Me.specialite.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.specialite.FormattingEnabled = True
        Me.specialite.ItemHeight = 19
        Me.specialite.Location = New System.Drawing.Point(208, 45)
        Me.specialite.Name = "specialite"
        Me.specialite.Size = New System.Drawing.Size(229, 25)
        Me.specialite.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.specialite.TabIndex = 167
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(36, 125)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(90, 23)
        Me.LabelX4.TabIndex = 166
        Me.LabelX4.Text = "Alternance"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(36, 99)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(90, 23)
        Me.LabelX3.TabIndex = 165
        Me.LabelX3.Text = "Effectif prévu"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(36, 75)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(128, 23)
        Me.LabelX2.TabIndex = 164
        Me.LabelX2.Text = "Nature de formation"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(36, 47)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 163
        Me.LabelX1.Text = "Spécialité "
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 21)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1171, 380)
        Me.ShapeContainer1.TabIndex = 171
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 57
        Me.LineShape1.X2 = 400
        Me.LineShape1.Y1 = 146
        Me.LineShape1.Y2 = 146
        '
        'prevu
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.prevu.Location = New System.Drawing.Point(208, 99)
        Me.prevu.Name = "prevu"
        Me.prevu.Size = New System.Drawing.Size(47, 23)
        Me.prevu.TabIndex = 172
        '
        'alternance
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.alternance.Location = New System.Drawing.Point(208, 125)
        Me.alternance.Name = "alternance"
        Me.alternance.Size = New System.Drawing.Size(229, 23)
        Me.alternance.TabIndex = 173
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(261, 99)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(120, 23)
        Me.LabelX5.TabIndex = 174
        Me.LabelX5.Text = "Effectif déja assigné"
        '
        'fonctiuonnairecount
        '
        '
        '
        '
        Me.fonctiuonnairecount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fonctiuonnairecount.Location = New System.Drawing.Point(401, 99)
        Me.fonctiuonnairecount.Name = "fonctiuonnairecount"
        Me.fonctiuonnairecount.Size = New System.Drawing.Size(36, 23)
        Me.fonctiuonnairecount.TabIndex = 175
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.AllowUserToAddRows = False
        Me.DataGridViewX1.AllowUserToDeleteRows = False
        Me.DataGridViewX1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewX1.EnableHeadersVisualStyles = False
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(510, 45)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewX1.Size = New System.Drawing.Size(655, 270)
        Me.DataGridViewX1.TabIndex = 177
        '
        'idformation
        '
        '
        '
        '
        Me.idformation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.idformation.Location = New System.Drawing.Point(36, 348)
        Me.idformation.Name = "idformation"
        Me.idformation.Size = New System.Drawing.Size(75, 23)
        Me.idformation.TabIndex = 180
        Me.idformation.Visible = False
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Image = Global.MBA.My.Resources.Resources.refersh
        Me.ButtonX3.Location = New System.Drawing.Point(510, 351)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(229, 20)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 179
        Me.ButtonX3.Text = "Actualiser"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.MBA.My.Resources.Resources.delete
        Me.ButtonX1.Location = New System.Drawing.Point(754, 351)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(229, 20)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 178
        Me.ButtonX1.Text = "Supprimer"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = Global.MBA.My.Resources.Resources.adde
        Me.ButtonX2.Location = New System.Drawing.Point(208, 351)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.PressedImage = Global.MBA.My.Resources.Resources.adde
        Me.ButtonX2.Size = New System.Drawing.Size(229, 20)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 176
        Me.ButtonX2.Text = "Ajouter"
        '
        'EffictifEnFormation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1177, 596)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "EffictifEnFormation"
        Me.ShowIcon = False
        Me.Text = "    Effictifs en Formation     "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.datenais, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents datenais As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents mat As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents nom As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents prenom As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents natureformation As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents specialite As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents alternance As DevComponents.DotNetBar.LabelX
    Friend WithEvents prevu As DevComponents.DotNetBar.LabelX
    Friend WithEvents fonctiuonnairecount As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents idformation As DevComponents.DotNetBar.LabelX
End Class
