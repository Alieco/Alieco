<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IRG
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
        Me.Grid1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.asbt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.sailbsa = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX5 = New DevComponents.DotNetBar.ButtonX()
        Me.irgtxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Grid1.Location = New System.Drawing.Point(0, 139)
        Me.Grid1.LookAndFeel.SkinName = "Office 2013"
        Me.Grid1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(1364, 588)
        Me.Grid1.TabIndex = 4
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.asbt)
        Me.GroupBox1.Controls.Add(Me.sailbsa)
        Me.GroupBox1.Controls.Add(Me.ButtonX5)
        Me.GroupBox1.Controls.Add(Me.irgtxt)
        Me.GroupBox1.Controls.Add(Me.ButtonX4)
        Me.GroupBox1.Controls.Add(Me.ButtonX3)
        Me.GroupBox1.Controls.Add(Me.ButtonX2)
        Me.GroupBox1.Controls.Add(Me.TextBoxX1)
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1364, 139)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selectionner le fichier de présence  :"
        '
        'asbt
        '
        Me.asbt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.asbt.Border.Class = "TextBoxBorder"
        Me.asbt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.asbt.ForeColor = System.Drawing.Color.Black
        Me.asbt.Location = New System.Drawing.Point(479, 82)
        Me.asbt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.asbt.Name = "asbt"
        Me.asbt.Size = New System.Drawing.Size(199, 25)
        Me.asbt.TabIndex = 251
        Me.asbt.WatermarkText = "absence"
        '
        'sailbsa
        '
        Me.sailbsa.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.sailbsa.Border.Class = "TextBoxBorder"
        Me.sailbsa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sailbsa.ForeColor = System.Drawing.Color.Black
        Me.sailbsa.Location = New System.Drawing.Point(259, 82)
        Me.sailbsa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sailbsa.Name = "sailbsa"
        Me.sailbsa.Size = New System.Drawing.Size(199, 25)
        Me.sailbsa.TabIndex = 250
        Me.sailbsa.WatermarkText = "salaire de base"
        '
        'ButtonX5
        '
        Me.ButtonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX5.Image = Global.MBA.My.Resources.Resources.adde
        Me.ButtonX5.Location = New System.Drawing.Point(695, 80)
        Me.ButtonX5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonX5.Name = "ButtonX5"
        Me.ButtonX5.PressedImage = Global.MBA.My.Resources.Resources.adde
        Me.ButtonX5.Size = New System.Drawing.Size(199, 27)
        Me.ButtonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX5.TabIndex = 249
        Me.ButtonX5.Text = "Calculer IRG"
        '
        'irgtxt
        '
        Me.irgtxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.irgtxt.Border.Class = "TextBoxBorder"
        Me.irgtxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.irgtxt.ForeColor = System.Drawing.Color.Black
        Me.irgtxt.Location = New System.Drawing.Point(45, 82)
        Me.irgtxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.irgtxt.Name = "irgtxt"
        Me.irgtxt.Size = New System.Drawing.Size(199, 25)
        Me.irgtxt.TabIndex = 248
        Me.irgtxt.WatermarkText = "totalBrut"
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.Enabled = False
        Me.ButtonX4.Image = Global.MBA.My.Resources.Resources.save
        Me.ButtonX4.Location = New System.Drawing.Point(1130, 36)
        Me.ButtonX4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(227, 25)
        Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX4.TabIndex = 4
        Me.ButtonX4.Text = "Enregistrer les modifications"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Image = Global.MBA.My.Resources.Resources.account_book2
        Me.ButtonX3.Location = New System.Drawing.Point(932, 36)
        Me.ButtonX3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(192, 25)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 3
        Me.ButtonX3.Text = "Afficher le fichier de <b>IRG</b>"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Enabled = False
        Me.ButtonX2.Image = Global.MBA.My.Resources.Resources.save
        Me.ButtonX2.Location = New System.Drawing.Point(801, 36)
        Me.ButtonX2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(125, 25)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 2
        Me.ButtonX2.Text = "Enregistrer"
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
        Me.TextBoxX1.Location = New System.Drawing.Point(45, 36)
        Me.TextBoxX1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.Size = New System.Drawing.Size(516, 25)
        Me.TextBoxX1.TabIndex = 1
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.MBA.My.Resources.Resources.account_book_import
        Me.ButtonX1.Location = New System.Drawing.Point(568, 36)
        Me.ButtonX1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(226, 25)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 0
        Me.ButtonX1.Text = "Upload le fichier de <b>IRG</b>"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'BackgroundWorker2
        '
        Me.BackgroundWorker2.WorkerReportsProgress = True
        '
        'IRG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 727)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "IRG"
        Me.ShowIcon = False
        Me.Text = "IRG"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents asbt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents sailbsa As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ButtonX5 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents irgtxt As DevComponents.DotNetBar.Controls.TextBoxX
End Class
