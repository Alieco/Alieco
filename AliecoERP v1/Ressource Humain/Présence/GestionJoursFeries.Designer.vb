<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionJoursFeries
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
        Me.nom = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.jour = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Decembre = New DevComponents.Editors.ComboItem()
        Me.Novembre = New DevComponents.Editors.ComboItem()
        Me.Octobre = New DevComponents.Editors.ComboItem()
        Me.Septembre = New DevComponents.Editors.ComboItem()
        Me.Aout = New DevComponents.Editors.ComboItem()
        Me.Juillet = New DevComponents.Editors.ComboItem()
        Me.Juin = New DevComponents.Editors.ComboItem()
        Me.Mai = New DevComponents.Editors.ComboItem()
        Me.Avril = New DevComponents.Editors.ComboItem()
        Me.Mars = New DevComponents.Editors.ComboItem()
        Me.Fevrier = New DevComponents.Editors.ComboItem()
        Me.Janvier = New DevComponents.Editors.ComboItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.jour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.nom)
        Me.GroupBox1.Controls.Add(Me.jour)
        Me.GroupBox1.Controls.Add(Me.ButtonX2)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(864, 84)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ajouter un jour férié : "
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
        Me.nom.Location = New System.Drawing.Point(344, 34)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(184, 22)
        Me.nom.TabIndex = 214
        Me.nom.WatermarkText = "saisir le nom de cette journée"
        '
        'jour
        '
        '
        '
        '
        Me.jour.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.jour.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.jour.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.jour.ButtonDropDown.Visible = True
        Me.jour.IsPopupCalendarOpen = False
        Me.jour.Location = New System.Drawing.Point(93, 34)
        '
        '
        '
        Me.jour.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.jour.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.jour.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.jour.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.jour.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.jour.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.jour.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.jour.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.jour.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.jour.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.jour.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.jour.MonthCalendar.DisplayMonth = New Date(2014, 6, 1, 0, 0, 0, 0)
        Me.jour.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.jour.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.jour.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.jour.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.jour.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.jour.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.jour.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.jour.MonthCalendar.TodayButtonVisible = True
        Me.jour.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.jour.Name = "jour"
        Me.jour.Size = New System.Drawing.Size(200, 22)
        Me.jour.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.jour.TabIndex = 0
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = Global.MBA.My.Resources.Resources.adde
        Me.ButtonX2.Location = New System.Drawing.Point(607, 30)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.PressedImage = Global.MBA.My.Resources.Resources.adde
        Me.ButtonX2.Size = New System.Drawing.Size(229, 24)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 213
        Me.ButtonX2.Text = "Ajouter"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(12, 33)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Jour :"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 84)
        Me.GridControl1.LookAndFeel.SkinName = "Office 2013"
        Me.GridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(864, 452)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'Decembre
        '
        Me.Decembre.Text = "Decembre"
        '
        'Novembre
        '
        Me.Novembre.Text = "Novembre"
        '
        'Octobre
        '
        Me.Octobre.Text = "Octobre"
        '
        'Septembre
        '
        Me.Septembre.Text = "Septembre"
        '
        'Aout
        '
        Me.Aout.Text = "Aout"
        '
        'Juillet
        '
        Me.Juillet.Text = "Juillet"
        '
        'Juin
        '
        Me.Juin.Text = "Juin"
        '
        'Mai
        '
        Me.Mai.Text = "Mai"
        '
        'Avril
        '
        Me.Avril.Text = "Avril"
        '
        'Mars
        '
        Me.Mars.Text = "Mars"
        '
        'Fevrier
        '
        Me.Fevrier.Text = "Fevrier"
        '
        'Janvier
        '
        Me.Janvier.Text = "Janvier"
        '
        'GestionJoursFeries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 536)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "GestionJoursFeries"
        Me.ShowIcon = False
        Me.Text = "Ajout d'un jour férié"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.jour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents jour As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Decembre As DevComponents.Editors.ComboItem
    Friend WithEvents Novembre As DevComponents.Editors.ComboItem
    Friend WithEvents Octobre As DevComponents.Editors.ComboItem
    Friend WithEvents Septembre As DevComponents.Editors.ComboItem
    Friend WithEvents Aout As DevComponents.Editors.ComboItem
    Friend WithEvents Juillet As DevComponents.Editors.ComboItem
    Friend WithEvents Juin As DevComponents.Editors.ComboItem
    Friend WithEvents Mai As DevComponents.Editors.ComboItem
    Friend WithEvents Avril As DevComponents.Editors.ComboItem
    Friend WithEvents Mars As DevComponents.Editors.ComboItem
    Friend WithEvents Fevrier As DevComponents.Editors.ComboItem
    Friend WithEvents Janvier As DevComponents.Editors.ComboItem
    Friend WithEvents nom As DevComponents.DotNetBar.Controls.TextBoxX
End Class
