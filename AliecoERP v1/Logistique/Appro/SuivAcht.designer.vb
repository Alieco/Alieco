<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuivAcht
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SuivAcht))
        Me.DGsuivi = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.datedem = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.desig = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.qt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.service = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.enregisterSituationDemande = New DevComponents.DotNetBar.ButtonX()
        Me.situationdem = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.codeaffaire = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ActualiserMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsulterDemandeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dateconsult = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.codeaff = New System.Windows.Forms.RadioButton()
        Me.servi = New System.Windows.Forms.RadioButton()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        CType(Me.DGsuivi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.dateconsult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGsuivi
        '
        Me.DGsuivi.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGsuivi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGsuivi.Location = New System.Drawing.Point(0, 231)
        Me.DGsuivi.LookAndFeel.SkinName = "Office 2013"
        Me.DGsuivi.LookAndFeel.UseDefaultLookAndFeel = False
        Me.DGsuivi.MainView = Me.GridView1
        Me.DGsuivi.Name = "DGsuivi"
        Me.DGsuivi.Size = New System.Drawing.Size(864, 337)
        Me.DGsuivi.TabIndex = 123
        Me.DGsuivi.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.DGsuivi
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.LabelX6)
        Me.GroupBox1.Controls.Add(Me.servi)
        Me.GroupBox1.Controls.Add(Me.codeaff)
        Me.GroupBox1.Controls.Add(Me.dateconsult)
        Me.GroupBox1.Controls.Add(Me.LabelX5)
        Me.GroupBox1.Controls.Add(Me.datedem)
        Me.GroupBox1.Controls.Add(Me.desig)
        Me.GroupBox1.Controls.Add(Me.qt)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.service)
        Me.GroupBox1.Controls.Add(Me.enregisterSituationDemande)
        Me.GroupBox1.Controls.Add(Me.situationdem)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.codeaffaire)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.LabelX12)
        Me.GroupBox1.Controls.Add(Me.LabelX9)
        Me.GroupBox1.Controls.Add(Me.LabelX8)
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(864, 231)
        Me.GroupBox1.TabIndex = 122
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Infos de la demande :"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(345, 70)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(31, 23)
        Me.LabelX5.TabIndex = 317
        Me.LabelX5.Text = "Ou"
        '
        'datedem
        '
        Me.datedem.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.datedem.Border.Class = "TextBoxBorder"
        Me.datedem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.datedem.ForeColor = System.Drawing.Color.Black
        Me.datedem.Location = New System.Drawing.Point(154, 168)
        Me.datedem.Name = "datedem"
        Me.datedem.Size = New System.Drawing.Size(185, 23)
        Me.datedem.TabIndex = 315
        '
        'desig
        '
        Me.desig.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.desig.Border.Class = "TextBoxBorder"
        Me.desig.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.desig.ForeColor = System.Drawing.Color.Black
        Me.desig.Location = New System.Drawing.Point(154, 137)
        Me.desig.Name = "desig"
        Me.desig.Size = New System.Drawing.Size(185, 23)
        Me.desig.TabIndex = 314
        '
        'qt
        '
        Me.qt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.qt.Border.Class = "TextBoxBorder"
        Me.qt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.qt.ForeColor = System.Drawing.Color.Black
        Me.qt.Location = New System.Drawing.Point(154, 103)
        Me.qt.Name = "qt"
        Me.qt.Size = New System.Drawing.Size(185, 23)
        Me.qt.TabIndex = 313
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Enabled = False
        Me.LabelX4.Location = New System.Drawing.Point(382, 70)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(81, 23)
        Me.LabelX4.TabIndex = 312
        Me.LabelX4.Text = "Service :"
        '
        'service
        '
        Me.service.DisplayMember = "Text"
        Me.service.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.service.Enabled = False
        Me.service.FormattingEnabled = True
        Me.service.ItemHeight = 17
        Me.service.Location = New System.Drawing.Point(509, 70)
        Me.service.Name = "service"
        Me.service.Size = New System.Drawing.Size(319, 23)
        Me.service.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.service.TabIndex = 311
        '
        'enregisterSituationDemande
        '
        Me.enregisterSituationDemande.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.enregisterSituationDemande.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.enregisterSituationDemande.Image = CType(resources.GetObject("enregisterSituationDemande.Image"), System.Drawing.Image)
        Me.enregisterSituationDemande.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.enregisterSituationDemande.Location = New System.Drawing.Point(362, 190)
        Me.enregisterSituationDemande.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.enregisterSituationDemande.Name = "enregisterSituationDemande"
        Me.enregisterSituationDemande.Size = New System.Drawing.Size(238, 30)
        Me.enregisterSituationDemande.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.enregisterSituationDemande.TabIndex = 310
        Me.enregisterSituationDemande.Text = "Enregistrer la situation de la demande"
        '
        'situationdem
        '
        Me.situationdem.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.situationdem.Border.Class = "TextBoxBorder"
        Me.situationdem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.situationdem.ForeColor = System.Drawing.Color.Black
        Me.situationdem.Location = New System.Drawing.Point(508, 106)
        Me.situationdem.Multiline = True
        Me.situationdem.Name = "situationdem"
        Me.situationdem.Size = New System.Drawing.Size(320, 63)
        Me.situationdem.TabIndex = 179
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(382, 106)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(120, 23)
        Me.LabelX3.TabIndex = 57
        Me.LabelX3.Text = " Situation Demande :"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Enabled = False
        Me.LabelX2.Location = New System.Drawing.Point(24, 70)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(81, 23)
        Me.LabelX2.TabIndex = 56
        Me.LabelX2.Text = "Code affaire :"
        '
        'codeaffaire
        '
        Me.codeaffaire.DisplayMember = "Text"
        Me.codeaffaire.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.codeaffaire.Enabled = False
        Me.codeaffaire.FormattingEnabled = True
        Me.codeaffaire.ItemHeight = 17
        Me.codeaffaire.Location = New System.Drawing.Point(154, 70)
        Me.codeaffaire.Name = "codeaffaire"
        Me.codeaffaire.Size = New System.Drawing.Size(185, 23)
        Me.codeaffaire.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.codeaffaire.TabIndex = 55
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(24, 198)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(108, 23)
        Me.LabelX1.TabIndex = 50
        Me.LabelX1.Text = "Date consultation :"
        '
        'LabelX12
        '
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Location = New System.Drawing.Point(24, 166)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(81, 23)
        Me.LabelX12.TabIndex = 49
        Me.LabelX12.Text = "Date demande :"
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(24, 103)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(81, 23)
        Me.LabelX9.TabIndex = 48
        Me.LabelX9.Text = "Quantité :"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(24, 132)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(81, 28)
        Me.LabelX8.TabIndex = 47
        Me.LabelX8.Text = "Désignation :"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = Global.MBA.My.Resources.Resources.vendors_arrow_right
        Me.ButtonX1.Location = New System.Drawing.Point(606, 190)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(222, 30)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 9
        Me.ButtonX1.Text = "Exporter vers Excel"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActualiserMenuItem, Me.ConsulterDemandeToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(248, 48)
        '
        'ActualiserMenuItem
        '
        Me.ActualiserMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.ActualiserMenuItem.Image = Global.MBA.My.Resources.Resources.vendors_database
        Me.ActualiserMenuItem.Name = "ActualiserMenuItem"
        Me.ActualiserMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.ActualiserMenuItem.Text = "     Actualiser la liste des demandes"
        '
        'ConsulterDemandeToolStripMenuItem
        '
        Me.ConsulterDemandeToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window
        Me.ConsulterDemandeToolStripMenuItem.Image = Global.MBA.My.Resources.Resources.vendors_add1
        Me.ConsulterDemandeToolStripMenuItem.Name = "ConsulterDemandeToolStripMenuItem"
        Me.ConsulterDemandeToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.ConsulterDemandeToolStripMenuItem.Text = "     consulter la demande"
        '
        'dateconsult
        '
        '
        '
        '
        Me.dateconsult.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dateconsult.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateconsult.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dateconsult.ButtonDropDown.Visible = True
        Me.dateconsult.Format = DevComponents.Editors.eDateTimePickerFormat.[Long]
        Me.dateconsult.IsPopupCalendarOpen = False
        Me.dateconsult.Location = New System.Drawing.Point(154, 199)
        Me.dateconsult.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        '
        '
        '
        Me.dateconsult.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dateconsult.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateconsult.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dateconsult.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dateconsult.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dateconsult.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dateconsult.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dateconsult.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dateconsult.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dateconsult.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dateconsult.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateconsult.MonthCalendar.DisplayMonth = New Date(2014, 6, 1, 0, 0, 0, 0)
        Me.dateconsult.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dateconsult.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dateconsult.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dateconsult.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dateconsult.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dateconsult.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dateconsult.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateconsult.MonthCalendar.TodayButtonVisible = True
        Me.dateconsult.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dateconsult.Name = "dateconsult"
        Me.dateconsult.Size = New System.Drawing.Size(185, 23)
        Me.dateconsult.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dateconsult.TabIndex = 318
        '
        'codeaff
        '
        Me.codeaff.AutoSize = True
        Me.codeaff.Location = New System.Drawing.Point(245, 22)
        Me.codeaff.Name = "codeaff"
        Me.codeaff.Size = New System.Drawing.Size(85, 19)
        Me.codeaff.TabIndex = 319
        Me.codeaff.TabStop = True
        Me.codeaff.Text = "Code affaire"
        Me.codeaff.UseVisualStyleBackColor = True
        '
        'servi
        '
        Me.servi.AutoSize = True
        Me.servi.Location = New System.Drawing.Point(408, 22)
        Me.servi.Name = "servi"
        Me.servi.Size = New System.Drawing.Size(59, 19)
        Me.servi.TabIndex = 320
        Me.servi.TabStop = True
        Me.servi.Text = "Service"
        Me.servi.UseVisualStyleBackColor = True
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Enabled = False
        Me.LabelX6.Location = New System.Drawing.Point(38, 20)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(192, 23)
        Me.LabelX6.TabIndex = 321
        Me.LabelX6.Text = "Veuillez selectionner votre recherche :"
        '
        'SuivAcht
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 568)
        Me.Controls.Add(Me.DGsuivi)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Name = "SuivAcht"
        Me.ShowIcon = False
        Me.Text = " Suivi des demandes "
        CType(Me.DGsuivi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.dateconsult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGsuivi As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents codeaffaire As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents situationdem As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents service As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents enregisterSituationDemande As DevComponents.DotNetBar.ButtonX
    Friend WithEvents datedem As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents desig As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents qt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ActualiserMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsulterDemandeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents servi As System.Windows.Forms.RadioButton
    Friend WithEvents codeaff As System.Windows.Forms.RadioButton
    Friend WithEvents dateconsult As DevComponents.Editors.DateTimeAdv.DateTimeInput
End Class
