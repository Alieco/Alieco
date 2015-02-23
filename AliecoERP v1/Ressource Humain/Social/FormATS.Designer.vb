<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormATS
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
        Me.matricule = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.heure = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.jour = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.du1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.au1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.GroupBox1.SuspendLayout()
        CType(Me.du1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.au1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.au1)
        Me.GroupBox1.Controls.Add(Me.du1)
        Me.GroupBox1.Controls.Add(Me.matricule)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ButtonX2)
        Me.GroupBox1.Controls.Add(Me.heure)
        Me.GroupBox1.Controls.Add(Me.jour)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(5, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 169)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Assuré(e) a travaillé pendant :"
        '
        'matricule
        '
        Me.matricule.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.matricule.BackgroundStyle.Class = "TextBoxBorder"
        Me.matricule.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.matricule.ButtonClear.Visible = True
        Me.matricule.ForeColor = System.Drawing.Color.Black
        Me.matricule.Location = New System.Drawing.Point(151, 19)
        Me.matricule.Mask = "00000"
        Me.matricule.Name = "matricule"
        Me.matricule.Size = New System.Drawing.Size(73, 20)
        Me.matricule.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.matricule.TabIndex = 93
        Me.matricule.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(68, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Matricule :"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = Global.MBA.My.Resources.Resources.vendor_add1
        Me.ButtonX2.Location = New System.Drawing.Point(113, 123)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(113, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 25
        Me.ButtonX2.Text = "Enregistrer"
        '
        'heure
        '
        Me.heure.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.heure.Border.Class = "TextBoxBorder"
        Me.heure.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.heure.ForeColor = System.Drawing.Color.Black
        Me.heure.Location = New System.Drawing.Point(205, 61)
        Me.heure.Name = "heure"
        Me.heure.Size = New System.Drawing.Size(86, 20)
        Me.heure.TabIndex = 24
        '
        'jour
        '
        Me.jour.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.jour.Border.Class = "TextBoxBorder"
        Me.jour.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.jour.ForeColor = System.Drawing.Color.Black
        Me.jour.Location = New System.Drawing.Point(51, 61)
        Me.jour.Name = "jour"
        Me.jour.Size = New System.Drawing.Size(86, 20)
        Me.jour.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(152, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Heures :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Jours :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(152, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Au"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Du"
        '
        'du1
        '
        Me.du1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.du1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.du1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.du1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.du1.ButtonDropDown.Visible = True
        Me.du1.ForeColor = System.Drawing.Color.Black
        Me.du1.IsPopupCalendarOpen = False
        Me.du1.Location = New System.Drawing.Point(51, 94)
        '
        '
        '
        Me.du1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.du1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.du1.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.du1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.du1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.du1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.du1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.du1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.du1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.du1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.du1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.du1.MonthCalendar.DisplayMonth = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.du1.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.du1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.du1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.du1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.du1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.du1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.du1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.du1.MonthCalendar.TodayButtonVisible = True
        Me.du1.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.du1.Name = "du1"
        Me.du1.Size = New System.Drawing.Size(86, 20)
        Me.du1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.du1.TabIndex = 94
        '
        'au1
        '
        Me.au1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.au1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.au1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.au1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.au1.ButtonDropDown.Visible = True
        Me.au1.ForeColor = System.Drawing.Color.Black
        Me.au1.IsPopupCalendarOpen = False
        Me.au1.Location = New System.Drawing.Point(206, 94)
        '
        '
        '
        Me.au1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.au1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.au1.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.au1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.au1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.au1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.au1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.au1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.au1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.au1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.au1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.au1.MonthCalendar.DisplayMonth = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.au1.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.au1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.au1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.au1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.au1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.au1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.au1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.au1.MonthCalendar.TodayButtonVisible = True
        Me.au1.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.au1.Name = "au1"
        Me.au1.Size = New System.Drawing.Size(86, 20)
        Me.au1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.au1.TabIndex = 95
        '
        'FormATS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 198)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormATS"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forme ATS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.du1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.au1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents jour As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents heure As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents matricule As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents au1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents du1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
End Class
