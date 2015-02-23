<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdvancedSearch
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.situation = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.fonction = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.direction = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.region = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.willayid = New System.Windows.Forms.RadioButton()
        Me.dirrd = New System.Windows.Forms.RadioButton()
        Me.enrydate = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.genre = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.searchbtn = New DevComponents.DotNetBar.ButtonX()
        Me.genrerd = New System.Windows.Forms.RadioButton()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.searchtxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ProgressBarX1 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.dgv1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Controls.Add(Me.situation)
        Me.GroupBox1.Controls.Add(Me.fonction)
        Me.GroupBox1.Controls.Add(Me.direction)
        Me.GroupBox1.Controls.Add(Me.region)
        Me.GroupBox1.Controls.Add(Me.willayid)
        Me.GroupBox1.Controls.Add(Me.dirrd)
        Me.GroupBox1.Controls.Add(Me.enrydate)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.genre)
        Me.GroupBox1.Controls.Add(Me.searchbtn)
        Me.GroupBox1.Controls.Add(Me.genrerd)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.searchtxt)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1218, 163)
        Me.GroupBox1.TabIndex = 113
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identification du Fonctionnaire:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MBA.My.Resources.Resources.loader
        Me.PictureBox1.Location = New System.Drawing.Point(795, 121)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.MBA.My.Resources.Resources.Excel_2013
        Me.ButtonX1.Location = New System.Drawing.Point(1014, 121)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(121, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 19
        Me.ButtonX1.Text = "Exporter"
        '
        'situation
        '
        Me.situation.DisplayMember = "Text"
        Me.situation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.situation.FormattingEnabled = True
        Me.situation.ItemHeight = 15
        Me.situation.Items.AddRange(New Object() {Me.ComboItem3, Me.ComboItem4})
        Me.situation.Location = New System.Drawing.Point(795, 65)
        Me.situation.Name = "situation"
        Me.situation.Size = New System.Drawing.Size(147, 21)
        Me.situation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.situation.TabIndex = 18
        Me.situation.WatermarkText = "Situation :"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Confirmé"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Non Confirmé"
        '
        'fonction
        '
        Me.fonction.DisplayMember = "Text"
        Me.fonction.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.fonction.FormattingEnabled = True
        Me.fonction.ItemHeight = 15
        Me.fonction.Location = New System.Drawing.Point(633, 65)
        Me.fonction.Name = "fonction"
        Me.fonction.Size = New System.Drawing.Size(146, 21)
        Me.fonction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.fonction.TabIndex = 17
        Me.fonction.WatermarkText = "Fonction :"
        '
        'direction
        '
        Me.direction.DisplayMember = "Text"
        Me.direction.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.direction.FormattingEnabled = True
        Me.direction.ItemHeight = 15
        Me.direction.Location = New System.Drawing.Point(463, 65)
        Me.direction.Name = "direction"
        Me.direction.Size = New System.Drawing.Size(155, 21)
        Me.direction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.direction.TabIndex = 16
        Me.direction.WatermarkText = "Direction :"
        '
        'region
        '
        Me.region.DisplayMember = "Text"
        Me.region.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.region.FormattingEnabled = True
        Me.region.ItemHeight = 15
        Me.region.Location = New System.Drawing.Point(311, 65)
        Me.region.Name = "region"
        Me.region.Size = New System.Drawing.Size(136, 21)
        Me.region.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.region.TabIndex = 15
        Me.region.WatermarkText = "Willaya :"
        '
        'willayid
        '
        Me.willayid.AutoSize = True
        Me.willayid.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.willayid.Location = New System.Drawing.Point(635, 95)
        Me.willayid.Name = "willayid"
        Me.willayid.Size = New System.Drawing.Size(58, 17)
        Me.willayid.TabIndex = 14
        Me.willayid.Text = "Willaya"
        Me.willayid.UseVisualStyleBackColor = True
        '
        'dirrd
        '
        Me.dirrd.AutoSize = True
        Me.dirrd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.dirrd.Location = New System.Drawing.Point(563, 95)
        Me.dirrd.Name = "dirrd"
        Me.dirrd.Size = New System.Drawing.Size(66, 17)
        Me.dirrd.TabIndex = 13
        Me.dirrd.Text = "Direction"
        Me.dirrd.UseVisualStyleBackColor = True
        '
        'enrydate
        '
        Me.enrydate.AutoSize = True
        Me.enrydate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.enrydate.Location = New System.Drawing.Point(458, 95)
        Me.enrydate.Name = "enrydate"
        Me.enrydate.Size = New System.Drawing.Size(90, 17)
        Me.enrydate.TabIndex = 12
        Me.enrydate.Text = "Date d'entrée"
        Me.enrydate.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RadioButton2.Location = New System.Drawing.Point(385, 95)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(67, 17)
        Me.RadioButton2.TabIndex = 11
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Matricule"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(965, 35)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(43, 23)
        Me.LabelX3.TabIndex = 10
        Me.LabelX3.Text = "Sexe :"
        '
        'genre
        '
        Me.genre.DisplayMember = "Text"
        Me.genre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.genre.FormattingEnabled = True
        Me.genre.ItemHeight = 15
        Me.genre.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2})
        Me.genre.Location = New System.Drawing.Point(1014, 38)
        Me.genre.Name = "genre"
        Me.genre.Size = New System.Drawing.Size(121, 21)
        Me.genre.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.genre.TabIndex = 9
        Me.genre.WatermarkText = "Genre :"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Homme"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Femme"
        '
        'searchbtn
        '
        Me.searchbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.searchbtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.searchbtn.Image = Global.MBA.My.Resources.Resources.search
        Me.searchbtn.Location = New System.Drawing.Point(829, 121)
        Me.searchbtn.Name = "searchbtn"
        Me.searchbtn.Size = New System.Drawing.Size(113, 23)
        Me.searchbtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.searchbtn.TabIndex = 8
        Me.searchbtn.Text = "Rechercher"
        '
        'genrerd
        '
        Me.genrerd.AutoSize = True
        Me.genrerd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.genrerd.Location = New System.Drawing.Point(311, 95)
        Me.genrerd.Name = "genrerd"
        Me.genrerd.Size = New System.Drawing.Size(53, 17)
        Me.genrerd.TabIndex = 7
        Me.genrerd.Text = "Genre"
        Me.genrerd.UseVisualStyleBackColor = True
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(21, 95)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(172, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Trier la liste par  :"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(21, 35)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(284, 35)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Choisissez le  <b>Matricule</b> ,<b>Nom</b>,<b>Prénom</b> ou <b>Addresse</b>que  " & _
            "vous voullez chercher :"
        '
        'searchtxt
        '
        Me.searchtxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.searchtxt.Border.Class = "TextBoxBorder"
        Me.searchtxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.searchtxt.ForeColor = System.Drawing.Color.Black
        Me.searchtxt.Location = New System.Drawing.Point(311, 38)
        Me.searchtxt.Name = "searchtxt"
        Me.searchtxt.Size = New System.Drawing.Size(631, 21)
        Me.searchtxt.TabIndex = 0
        Me.searchtxt.WatermarkText = "Tapez ici ..."
        '
        'ProgressBarX1
        '
        '
        '
        '
        Me.ProgressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ProgressBarX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBarX1.Location = New System.Drawing.Point(0, 632)
        Me.ProgressBarX1.Name = "ProgressBarX1"
        Me.ProgressBarX1.Size = New System.Drawing.Size(1218, 14)
        Me.ProgressBarX1.TabIndex = 115
        Me.ProgressBarX1.Text = "ProgressBarX1"
        '
        'dgv1
        '
        Me.dgv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv1.Location = New System.Drawing.Point(0, 163)
        Me.dgv1.LookAndFeel.SkinName = "Office 2013"
        Me.dgv1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.dgv1.MainView = Me.GridView1
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(1218, 469)
        Me.dgv1.TabIndex = 116
        Me.dgv1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.dgv1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'AdvancedSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1218, 646)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.ProgressBarX1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Name = "AdvancedSearch"
        Me.ShowIcon = False
        Me.Text = "Recherche avancée "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents searchbtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents genrerd As System.Windows.Forms.RadioButton
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents searchtxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents situation As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents fonction As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents direction As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents region As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents willayid As System.Windows.Forms.RadioButton
    Friend WithEvents dirrd As System.Windows.Forms.RadioButton
    Friend WithEvents enrydate As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents genre As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ProgressBarX1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgv1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
