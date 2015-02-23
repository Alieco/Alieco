<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListAffectation
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
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.GridAfffectations = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ViheculeImg.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridAfffectations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
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
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 161)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "rechercher un vihécule :"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(12, 50)
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
        Me.ChauffeurCmb.ItemHeight = 16
        Me.ChauffeurCmb.Location = New System.Drawing.Point(159, 55)
        Me.ChauffeurCmb.Name = "ChauffeurCmb"
        Me.ChauffeurCmb.Size = New System.Drawing.Size(246, 22)
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
        Me.ViheculeCmb.ItemHeight = 16
        Me.ViheculeCmb.Location = New System.Drawing.Point(159, 21)
        Me.ViheculeCmb.Name = "ViheculeCmb"
        Me.ViheculeCmb.Size = New System.Drawing.Size(246, 22)
        Me.ViheculeCmb.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ViheculeCmb.TabIndex = 397
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl6.Location = New System.Drawing.Point(614, 124)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl6.TabIndex = 396
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl5.Location = New System.Drawing.Point(614, 104)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl5.TabIndex = 395
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl4.Location = New System.Drawing.Point(614, 84)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl4.TabIndex = 394
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl3.Location = New System.Drawing.Point(615, 64)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl3.TabIndex = 393
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl2.Location = New System.Drawing.Point(615, 44)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl2.TabIndex = 392
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl1.Location = New System.Drawing.Point(614, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl1.TabIndex = 391
        '
        'ViheculeImg
        '
        Me.ViheculeImg.Location = New System.Drawing.Point(411, 21)
        Me.ViheculeImg.Name = "ViheculeImg"
        Me.ViheculeImg.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.ViheculeImg.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ViheculeImg.Properties.Appearance.Options.UseBackColor = True
        Me.ViheculeImg.Properties.Appearance.Options.UseForeColor = True
        Me.ViheculeImg.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.ViheculeImg.Size = New System.Drawing.Size(197, 134)
        Me.ViheculeImg.TabIndex = 390
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.MBA.My.Resources.Resources.table_save
        Me.ButtonX1.Location = New System.Drawing.Point(254, 132)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(151, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 381
        Me.ButtonX1.Text = "Exporter la liste"
        '
        'GridAfffectations
        '
        Me.GridAfffectations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAfffectations.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White
        Me.GridAfffectations.EmbeddedNavigator.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GridAfffectations.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.GridAfffectations.EmbeddedNavigator.Appearance.Options.UseForeColor = True
        Me.GridAfffectations.Location = New System.Drawing.Point(0, 161)
        Me.GridAfffectations.LookAndFeel.SkinName = "Office 2013"
        Me.GridAfffectations.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridAfffectations.MainView = Me.GridView1
        Me.GridAfffectations.Name = "GridAfffectations"
        Me.GridAfffectations.Size = New System.Drawing.Size(860, 361)
        Me.GridAfffectations.TabIndex = 4
        Me.GridAfffectations.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridAfffectations
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'ListAffectation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 522)
        Me.Controls.Add(Me.GridAfffectations)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ListAffectation"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste des affectation par vihécule"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ViheculeImg.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridAfffectations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ViheculeImg As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ChauffeurCmb As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ViheculeCmb As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents GridAfffectations As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
