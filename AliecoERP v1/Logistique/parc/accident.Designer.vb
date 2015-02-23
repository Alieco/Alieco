<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accident
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
        Me.ExportBtn = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.DiscriptionTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dateAccident = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.ChauffeurCmb = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.ViheculeCmb = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ViheculeImg = New DevExpress.XtraEditors.PictureEdit()
        Me.EnregistrerBtn = New DevComponents.DotNetBar.ButtonX()
        Me.GridAccident = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dateAccident, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViheculeImg.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridAccident, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.ExportBtn)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.DiscriptionTxt)
        Me.GroupBox1.Controls.Add(Me.dateAccident)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.ChauffeurCmb)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.ViheculeCmb)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.ViheculeImg)
        Me.GroupBox1.Controls.Add(Me.EnregistrerBtn)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(895, 197)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "rechercher un vihécule :"
        '
        'ExportBtn
        '
        Me.ExportBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ExportBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ExportBtn.Image = Global.MBA.My.Resources.Resources.table_save
        Me.ExportBtn.Location = New System.Drawing.Point(755, 168)
        Me.ExportBtn.Name = "ExportBtn"
        Me.ExportBtn.Size = New System.Drawing.Size(118, 23)
        Me.ExportBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ExportBtn.TabIndex = 405
        Me.ExportBtn.Text = "Exporter la liste"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(6, 104)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(142, 27)
        Me.LabelX3.TabIndex = 404
        Me.LabelX3.Text = "Discription d'accident:"
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(6, 75)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(142, 27)
        Me.LabelX4.TabIndex = 403
        Me.LabelX4.Text = "La date d'accident :"
        '
        'DiscriptionTxt
        '
        Me.DiscriptionTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.DiscriptionTxt.Border.Class = "TextBoxBorder"
        Me.DiscriptionTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DiscriptionTxt.ForeColor = System.Drawing.Color.Black
        Me.DiscriptionTxt.Location = New System.Drawing.Point(159, 108)
        Me.DiscriptionTxt.Multiline = True
        Me.DiscriptionTxt.Name = "DiscriptionTxt"
        Me.DiscriptionTxt.Size = New System.Drawing.Size(246, 83)
        Me.DiscriptionTxt.TabIndex = 402
        '
        'dateAccident
        '
        Me.dateAccident.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.dateAccident.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dateAccident.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateAccident.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dateAccident.ButtonDropDown.Visible = True
        Me.dateAccident.ForeColor = System.Drawing.Color.Black
        Me.dateAccident.IsPopupCalendarOpen = False
        Me.dateAccident.Location = New System.Drawing.Point(159, 79)
        '
        '
        '
        Me.dateAccident.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dateAccident.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateAccident.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dateAccident.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dateAccident.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dateAccident.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dateAccident.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dateAccident.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dateAccident.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dateAccident.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dateAccident.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateAccident.MonthCalendar.DisplayMonth = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.dateAccident.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dateAccident.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dateAccident.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dateAccident.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dateAccident.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dateAccident.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dateAccident.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateAccident.MonthCalendar.TodayButtonVisible = True
        Me.dateAccident.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dateAccident.Name = "dateAccident"
        Me.dateAccident.Size = New System.Drawing.Size(246, 23)
        Me.dateAccident.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dateAccident.TabIndex = 401
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(12, 46)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(142, 27)
        Me.LabelX2.TabIndex = 400
        Me.LabelX2.Text = "Choisissez un chauffeur :"
        '
        'ChauffeurCmb
        '
        Me.ChauffeurCmb.DisplayMember = "Text"
        Me.ChauffeurCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ChauffeurCmb.ForeColor = System.Drawing.Color.Black
        Me.ChauffeurCmb.FormattingEnabled = True
        Me.ChauffeurCmb.ItemHeight = 17
        Me.ChauffeurCmb.Location = New System.Drawing.Point(159, 50)
        Me.ChauffeurCmb.Name = "ChauffeurCmb"
        Me.ChauffeurCmb.Size = New System.Drawing.Size(246, 23)
        Me.ChauffeurCmb.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ChauffeurCmb.TabIndex = 399
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(12, 17)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(142, 27)
        Me.LabelX1.TabIndex = 398
        Me.LabelX1.Text = "Choisissez un vihécule :"
        '
        'ViheculeCmb
        '
        Me.ViheculeCmb.DisplayMember = "Text"
        Me.ViheculeCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ViheculeCmb.ForeColor = System.Drawing.Color.Black
        Me.ViheculeCmb.FormattingEnabled = True
        Me.ViheculeCmb.ItemHeight = 17
        Me.ViheculeCmb.Location = New System.Drawing.Point(159, 21)
        Me.ViheculeCmb.Name = "ViheculeCmb"
        Me.ViheculeCmb.Size = New System.Drawing.Size(246, 23)
        Me.ViheculeCmb.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ViheculeCmb.TabIndex = 397
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl6.Location = New System.Drawing.Point(661, 120)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl6.TabIndex = 396
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl5.Location = New System.Drawing.Point(661, 100)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl5.TabIndex = 395
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl4.Location = New System.Drawing.Point(661, 80)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl4.TabIndex = 394
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl3.Location = New System.Drawing.Point(662, 60)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl3.TabIndex = 393
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl2.Location = New System.Drawing.Point(662, 40)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl2.TabIndex = 392
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl1.Location = New System.Drawing.Point(661, 20)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl1.TabIndex = 391
        '
        'ViheculeImg
        '
        Me.ViheculeImg.Location = New System.Drawing.Point(411, 17)
        Me.ViheculeImg.Name = "ViheculeImg"
        Me.ViheculeImg.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.ViheculeImg.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ViheculeImg.Properties.Appearance.Options.UseBackColor = True
        Me.ViheculeImg.Properties.Appearance.Options.UseForeColor = True
        Me.ViheculeImg.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.ViheculeImg.Size = New System.Drawing.Size(241, 174)
        Me.ViheculeImg.TabIndex = 390
        '
        'EnregistrerBtn
        '
        Me.EnregistrerBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.EnregistrerBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.EnregistrerBtn.Image = Global.MBA.My.Resources.Resources.save
        Me.EnregistrerBtn.Location = New System.Drawing.Point(658, 168)
        Me.EnregistrerBtn.Name = "EnregistrerBtn"
        Me.EnregistrerBtn.Size = New System.Drawing.Size(91, 23)
        Me.EnregistrerBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.EnregistrerBtn.TabIndex = 381
        Me.EnregistrerBtn.Text = "Enregistrer"
        '
        'GridAccident
        '
        Me.GridAccident.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAccident.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White
        Me.GridAccident.EmbeddedNavigator.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GridAccident.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.GridAccident.EmbeddedNavigator.Appearance.Options.UseForeColor = True
        Me.GridAccident.Location = New System.Drawing.Point(0, 197)
        Me.GridAccident.LookAndFeel.SkinName = "Office 2013"
        Me.GridAccident.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridAccident.MainView = Me.GridView1
        Me.GridAccident.Name = "GridAccident"
        Me.GridAccident.Size = New System.Drawing.Size(895, 325)
        Me.GridAccident.TabIndex = 5
        Me.GridAccident.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridAccident
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'accident
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 522)
        Me.Controls.Add(Me.GridAccident)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "accident"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion des accidents"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dateAccident, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViheculeImg.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridAccident, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DiscriptionTxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dateAccident As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ChauffeurCmb As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ViheculeCmb As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ViheculeImg As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents EnregistrerBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GridAccident As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ExportBtn As DevComponents.DotNetBar.ButtonX
End Class
