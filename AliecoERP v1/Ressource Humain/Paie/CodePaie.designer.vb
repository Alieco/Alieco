<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CodePaie
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.libelle1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.code1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.libelle2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.code2 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.libelle3 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.code3 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.CPdg = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.CPdg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.libelle1)
        Me.GroupBox1.Controls.Add(Me.code1)
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1350, 58)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ajouter le code de Bulletin de paie :"
        '
        'libelle1
        '
        Me.libelle1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.libelle1.Border.Class = "TextBoxBorder"
        Me.libelle1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.libelle1.ForeColor = System.Drawing.Color.Black
        Me.libelle1.Location = New System.Drawing.Point(306, 24)
        Me.libelle1.Name = "libelle1"
        Me.libelle1.Size = New System.Drawing.Size(121, 25)
        Me.libelle1.TabIndex = 7
        '
        'code1
        '
        Me.code1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.code1.Border.Class = "TextBoxBorder"
        Me.code1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.code1.ForeColor = System.Drawing.Color.Black
        Me.code1.Location = New System.Drawing.Point(58, 24)
        Me.code1.Name = "code1"
        Me.code1.Size = New System.Drawing.Size(168, 25)
        Me.code1.TabIndex = 6
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.MBA.My.Resources.Resources.add_button
        Me.ButtonX1.Location = New System.Drawing.Point(488, 24)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(195, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 5
        Me.ButtonX1.Text = "Ajouter"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(246, 23)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(54, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Libellé :"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(6, 23)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(55, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Code :"
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.Image = Global.MBA.My.Resources.Resources.edit
        Me.ButtonX4.Location = New System.Drawing.Point(488, 20)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(195, 23)
        Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX4.TabIndex = 6
        Me.ButtonX4.Text = "Modifier "
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(246, 16)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(54, 23)
        Me.LabelX3.TabIndex = 3
        Me.LabelX3.Text = "Libellé :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.libelle2)
        Me.GroupBox2.Controls.Add(Me.code2)
        Me.GroupBox2.Controls.Add(Me.ButtonX4)
        Me.GroupBox2.Controls.Add(Me.LabelX3)
        Me.GroupBox2.Controls.Add(Me.LabelX4)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1350, 53)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Modifier le code de Bulletin de paie :"
        '
        'libelle2
        '
        Me.libelle2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.libelle2.Border.Class = "TextBoxBorder"
        Me.libelle2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.libelle2.ForeColor = System.Drawing.Color.Black
        Me.libelle2.Location = New System.Drawing.Point(306, 17)
        Me.libelle2.Name = "libelle2"
        Me.libelle2.Size = New System.Drawing.Size(121, 25)
        Me.libelle2.TabIndex = 8
        '
        'code2
        '
        Me.code2.DisplayMember = "Text"
        Me.code2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.code2.FormattingEnabled = True
        Me.code2.ItemHeight = 19
        Me.code2.Location = New System.Drawing.Point(58, 19)
        Me.code2.Name = "code2"
        Me.code2.Size = New System.Drawing.Size(168, 25)
        Me.code2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.code2.TabIndex = 7
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(6, 19)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(55, 23)
        Me.LabelX4.TabIndex = 1
        Me.LabelX4.Text = "Code :"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = Global.MBA.My.Resources.Resources.remove_button1
        Me.ButtonX2.Location = New System.Drawing.Point(488, 21)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(195, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 0
        Me.ButtonX2.Text = "Supprimer"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(246, 18)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(54, 23)
        Me.LabelX5.TabIndex = 3
        Me.LabelX5.Text = "Libellé :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.libelle3)
        Me.GroupBox3.Controls.Add(Me.code3)
        Me.GroupBox3.Controls.Add(Me.ButtonX2)
        Me.GroupBox3.Controls.Add(Me.LabelX5)
        Me.GroupBox3.Controls.Add(Me.LabelX6)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 111)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1350, 54)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Supprimer le code de Bulletin de paie :"
        '
        'libelle3
        '
        Me.libelle3.DisplayMember = "Text"
        Me.libelle3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.libelle3.FormattingEnabled = True
        Me.libelle3.ItemHeight = 19
        Me.libelle3.Location = New System.Drawing.Point(306, 19)
        Me.libelle3.Name = "libelle3"
        Me.libelle3.Size = New System.Drawing.Size(121, 25)
        Me.libelle3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.libelle3.TabIndex = 11
        '
        'code3
        '
        Me.code3.DisplayMember = "Text"
        Me.code3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.code3.FormattingEnabled = True
        Me.code3.ItemHeight = 19
        Me.code3.Location = New System.Drawing.Point(58, 21)
        Me.code3.Name = "code3"
        Me.code3.Size = New System.Drawing.Size(168, 25)
        Me.code3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.code3.TabIndex = 8
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(6, 21)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(55, 23)
        Me.LabelX6.TabIndex = 1
        Me.LabelX6.Text = "Code :"
        '
        'CPdg
        '
        Me.CPdg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CPdg.Location = New System.Drawing.Point(0, 165)
        Me.CPdg.LookAndFeel.SkinName = "Office 2013"
        Me.CPdg.LookAndFeel.UseDefaultLookAndFeel = False
        Me.CPdg.MainView = Me.GridView1
        Me.CPdg.Name = "CPdg"
        Me.CPdg.Size = New System.Drawing.Size(1350, 455)
        Me.CPdg.TabIndex = 4
        Me.CPdg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.CPdg
        Me.GridView1.Name = "GridView1"
        '
        'CodePaie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 620)
        Me.Controls.Add(Me.CPdg)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Name = "CodePaie"
        Me.ShowIcon = False
        Me.Text = "Code Paie"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.CPdg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents code2 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents libelle3 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents code3 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents libelle1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents code1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents libelle2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend CPdg As DevExpress.XtraGrid.GridControl
    Friend GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
