<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BonEssence
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
        Me.Valeurslbl = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.AjoutBonBtn = New DevComponents.DotNetBar.ButtonX()
        Me.valeurTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.quantity = New DevComponents.Editors.IntegerInput()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.ChauffeurCmb = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ExportBtn = New DevComponents.DotNetBar.ButtonX()
        Me.GridBons = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridBons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Valeurslbl)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.AjoutBonBtn)
        Me.GroupBox1.Controls.Add(Me.valeurTxt)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.quantity)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.ChauffeurCmb)
        Me.GroupBox1.Controls.Add(Me.ExportBtn)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(799, 95)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "rechercher un vihécule :"
        '
        'Valeurslbl
        '
        '
        '
        '
        Me.Valeurslbl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Valeurslbl.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Valeurslbl.Location = New System.Drawing.Point(364, 56)
        Me.Valeurslbl.Name = "Valeurslbl"
        Me.Valeurslbl.Size = New System.Drawing.Size(102, 23)
        Me.Valeurslbl.TabIndex = 407
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(319, 56)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(39, 23)
        Me.LabelX4.TabIndex = 406
        Me.LabelX4.Text = "DA = "
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(238, 56)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(13, 23)
        Me.LabelX3.TabIndex = 405
        Me.LabelX3.Text = "X"
        '
        'AjoutBonBtn
        '
        Me.AjoutBonBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.AjoutBonBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.AjoutBonBtn.Image = Global.MBA.My.Resources.Resources.add_button1
        Me.AjoutBonBtn.Location = New System.Drawing.Point(472, 27)
        Me.AjoutBonBtn.Name = "AjoutBonBtn"
        Me.AjoutBonBtn.Size = New System.Drawing.Size(126, 52)
        Me.AjoutBonBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AjoutBonBtn.TabIndex = 404
        Me.AjoutBonBtn.Text = "Ajouter un bon"
        '
        'valeurTxt
        '
        Me.valeurTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.valeurTxt.Border.Class = "TextBoxBorder"
        Me.valeurTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.valeurTxt.ForeColor = System.Drawing.Color.Black
        Me.valeurTxt.Location = New System.Drawing.Point(257, 56)
        Me.valeurTxt.Name = "valeurTxt"
        Me.valeurTxt.Size = New System.Drawing.Size(56, 23)
        Me.valeurTxt.TabIndex = 403
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(6, 48)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(142, 31)
        Me.LabelX1.TabIndex = 402
        Me.LabelX1.Text = "Quantité et Valeur :"
        '
        'quantity
        '
        Me.quantity.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.quantity.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.quantity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.quantity.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.quantity.ForeColor = System.Drawing.Color.Black
        Me.quantity.Location = New System.Drawing.Point(153, 56)
        Me.quantity.MaxValue = 999
        Me.quantity.MinValue = 0
        Me.quantity.Name = "quantity"
        Me.quantity.ShowUpDown = True
        Me.quantity.Size = New System.Drawing.Size(80, 23)
        Me.quantity.TabIndex = 401
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(6, 22)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(142, 31)
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
        Me.ChauffeurCmb.Location = New System.Drawing.Point(153, 27)
        Me.ChauffeurCmb.Name = "ChauffeurCmb"
        Me.ChauffeurCmb.Size = New System.Drawing.Size(313, 23)
        Me.ChauffeurCmb.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ChauffeurCmb.TabIndex = 399
        '
        'ExportBtn
        '
        Me.ExportBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ExportBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ExportBtn.Image = Global.MBA.My.Resources.Resources.table_save
        Me.ExportBtn.Location = New System.Drawing.Point(658, 22)
        Me.ExportBtn.Name = "ExportBtn"
        Me.ExportBtn.Size = New System.Drawing.Size(115, 27)
        Me.ExportBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ExportBtn.TabIndex = 381
        Me.ExportBtn.Text = "Exporter la liste"
        '
        'GridBons
        '
        Me.GridBons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridBons.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White
        Me.GridBons.EmbeddedNavigator.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GridBons.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.GridBons.EmbeddedNavigator.Appearance.Options.UseForeColor = True
        Me.GridBons.Location = New System.Drawing.Point(0, 95)
        Me.GridBons.LookAndFeel.SkinName = "Office 2013"
        Me.GridBons.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridBons.MainView = Me.GridView1
        Me.GridBons.Name = "GridBons"
        Me.GridBons.Size = New System.Drawing.Size(799, 480)
        Me.GridBons.TabIndex = 4
        Me.GridBons.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridBons
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'BonEssence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 575)
        Me.Controls.Add(Me.GridBons)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BonEssence"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion des bons d'essence"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.quantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridBons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ChauffeurCmb As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ExportBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents valeurTxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents quantity As DevComponents.Editors.IntegerInput
    Friend WithEvents AjoutBonBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GridBons As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Valeurslbl As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
End Class
