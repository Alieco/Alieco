<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListFacture
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.errorLbl = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.auTxt = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.duTxt = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.nFactureCmb = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.CodeAffaireTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.RechercheBtn = New DevComponents.DotNetBar.ButtonX()
        Me.FactureGrid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.auTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.duTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FactureGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Controls.Add(Me.errorLbl)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.auTxt)
        Me.GroupBox1.Controls.Add(Me.duTxt)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.nFactureCmb)
        Me.GroupBox1.Controls.Add(Me.CodeAffaireTxt)
        Me.GroupBox1.Controls.Add(Me.RechercheBtn)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1170, 115)
        Me.GroupBox1.TabIndex = 123
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liste des factures :"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = Global.MBA.My.Resources.Resources.order_export
        Me.ButtonX1.Location = New System.Drawing.Point(358, 80)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(262, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 19
        Me.ButtonX1.Text = "Exporter la liste des resultats"
        Me.ButtonX1.Visible = False
        '
        'errorLbl
        '
        Me.errorLbl.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.errorLbl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.errorLbl.ForeColor = System.Drawing.Color.Black
        Me.errorLbl.Location = New System.Drawing.Point(312, 22)
        Me.errorLbl.Name = "errorLbl"
        Me.errorLbl.Size = New System.Drawing.Size(342, 23)
        Me.errorLbl.TabIndex = 18
        Me.errorLbl.Text = "Cette Affaire n'as pas de Facture ou le code affaire est erroné !"
        Me.errorLbl.Visible = False
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(30, 80)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(59, 23)
        Me.LabelX3.TabIndex = 17
        Me.LabelX3.Text = "jusqu'au :"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(30, 51)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(59, 23)
        Me.LabelX2.TabIndex = 16
        Me.LabelX2.Text = "date du :"
        '
        'auTxt
        '
        Me.auTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.auTxt.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.auTxt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.auTxt.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.auTxt.ButtonDropDown.Visible = True
        Me.auTxt.ForeColor = System.Drawing.Color.Black
        Me.auTxt.IsPopupCalendarOpen = False
        Me.auTxt.Location = New System.Drawing.Point(95, 80)
        '
        '
        '
        Me.auTxt.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.auTxt.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.auTxt.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.auTxt.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.auTxt.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.auTxt.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.auTxt.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.auTxt.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.auTxt.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.auTxt.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.auTxt.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.auTxt.MonthCalendar.DisplayMonth = New Date(2014, 10, 1, 0, 0, 0, 0)
        Me.auTxt.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.auTxt.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.auTxt.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.auTxt.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.auTxt.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.auTxt.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.auTxt.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.auTxt.MonthCalendar.TodayButtonVisible = True
        Me.auTxt.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.auTxt.Name = "auTxt"
        Me.auTxt.Size = New System.Drawing.Size(200, 23)
        Me.auTxt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.auTxt.TabIndex = 15
        '
        'duTxt
        '
        Me.duTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.duTxt.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.duTxt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.duTxt.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.duTxt.ButtonDropDown.Visible = True
        Me.duTxt.ForeColor = System.Drawing.Color.Black
        Me.duTxt.IsPopupCalendarOpen = False
        Me.duTxt.Location = New System.Drawing.Point(95, 51)
        '
        '
        '
        Me.duTxt.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.duTxt.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.duTxt.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.duTxt.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.duTxt.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.duTxt.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.duTxt.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.duTxt.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.duTxt.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.duTxt.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.duTxt.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.duTxt.MonthCalendar.DisplayMonth = New Date(2014, 10, 1, 0, 0, 0, 0)
        Me.duTxt.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.duTxt.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.duTxt.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.duTxt.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.duTxt.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.duTxt.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.duTxt.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.duTxt.MonthCalendar.TodayButtonVisible = True
        Me.duTxt.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.duTxt.Name = "duTxt"
        Me.duTxt.Size = New System.Drawing.Size(200, 23)
        Me.duTxt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.duTxt.TabIndex = 14
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(142, 22)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(26, 23)
        Me.LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.LabelX1.TabIndex = 13
        Me.LabelX1.Text = "N°"
        '
        'nFactureCmb
        '
        Me.nFactureCmb.DisplayMember = "Text"
        Me.nFactureCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.nFactureCmb.ForeColor = System.Drawing.Color.Black
        Me.nFactureCmb.FormattingEnabled = True
        Me.nFactureCmb.ItemHeight = 17
        Me.nFactureCmb.Location = New System.Drawing.Point(174, 22)
        Me.nFactureCmb.Name = "nFactureCmb"
        Me.nFactureCmb.Size = New System.Drawing.Size(121, 23)
        Me.nFactureCmb.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.nFactureCmb.TabIndex = 12
        '
        'CodeAffaireTxt
        '
        Me.CodeAffaireTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.CodeAffaireTxt.Border.Class = "TextBoxBorder"
        Me.CodeAffaireTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CodeAffaireTxt.ForeColor = System.Drawing.Color.Black
        Me.CodeAffaireTxt.Location = New System.Drawing.Point(30, 22)
        Me.CodeAffaireTxt.Name = "CodeAffaireTxt"
        Me.CodeAffaireTxt.Size = New System.Drawing.Size(106, 23)
        Me.CodeAffaireTxt.TabIndex = 11
        Me.CodeAffaireTxt.WatermarkText = "Code Affaire ..."
        '
        'RechercheBtn
        '
        Me.RechercheBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.RechercheBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.RechercheBtn.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RechercheBtn.Image = Global.MBA.My.Resources.Resources.order_search
        Me.RechercheBtn.Location = New System.Drawing.Point(358, 51)
        Me.RechercheBtn.Name = "RechercheBtn"
        Me.RechercheBtn.Size = New System.Drawing.Size(262, 23)
        Me.RechercheBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RechercheBtn.TabIndex = 10
        Me.RechercheBtn.Text = "Afficher La liste des factures "
        '
        'FactureGrid
        '
        Me.FactureGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FactureGrid.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White
        Me.FactureGrid.EmbeddedNavigator.Appearance.ForeColor = System.Drawing.Color.Black
        Me.FactureGrid.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.FactureGrid.EmbeddedNavigator.Appearance.Options.UseForeColor = True
        Me.FactureGrid.Location = New System.Drawing.Point(0, 115)
        Me.FactureGrid.LookAndFeel.SkinName = "Office 2013"
        Me.FactureGrid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.FactureGrid.MainView = Me.GridView1
        Me.FactureGrid.Name = "FactureGrid"
        Me.FactureGrid.Size = New System.Drawing.Size(1170, 496)
        Me.FactureGrid.TabIndex = 124
        Me.FactureGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.FactureGrid
        Me.GridView1.Name = "GridView1"
        '
        'ListFacture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1170, 611)
        Me.Controls.Add(Me.FactureGrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ListFacture"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste des factures "
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.auTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.duTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FactureGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents auTxt As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents duTxt As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents nFactureCmb As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents CodeAffaireTxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents RechercheBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents errorLbl As DevComponents.DotNetBar.LabelX
    Friend WithEvents FactureGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
End Class
