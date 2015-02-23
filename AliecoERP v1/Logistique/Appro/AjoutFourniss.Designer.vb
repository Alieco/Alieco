<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjoutFourniss
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
        Me.nomfourn = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.type = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.ComboItem12 = New DevComponents.Editors.ComboItem()
        Me.ComboItem13 = New DevComponents.Editors.ComboItem()
        Me.ComboItem14 = New DevComponents.Editors.ComboItem()
        Me.ComboItem15 = New DevComponents.Editors.ComboItem()
        Me.ComboItem16 = New DevComponents.Editors.ComboItem()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.MaskedTextBoxAdv1 = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.mail = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.fax = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.tel = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.ads = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.willaya = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem9 = New DevComponents.Editors.ComboItem()
        Me.ComboItem10 = New DevComponents.Editors.ComboItem()
        Me.ComboItem11 = New DevComponents.Editors.ComboItem()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.code = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ajout = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.code2 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.nomfourech = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.boutrech = New DevComponents.DotNetBar.ButtonX()
        Me.DGcf = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGcf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nomfourn
        '
        Me.nomfourn.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.nomfourn.Border.Class = "TextBoxBorder"
        Me.nomfourn.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.nomfourn.ForeColor = System.Drawing.Color.Black
        Me.nomfourn.Location = New System.Drawing.Point(542, 22)
        Me.nomfourn.Name = "nomfourn"
        Me.nomfourn.Size = New System.Drawing.Size(180, 25)
        Me.nomfourn.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.type)
        Me.GroupBox1.Controls.Add(Me.LabelX6)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBoxAdv1)
        Me.GroupBox1.Controls.Add(Me.mail)
        Me.GroupBox1.Controls.Add(Me.LabelX5)
        Me.GroupBox1.Controls.Add(Me.fax)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.tel)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.ads)
        Me.GroupBox1.Controls.Add(Me.willaya)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.nomfourn)
        Me.GroupBox1.Controls.Add(Me.code)
        Me.GroupBox1.Controls.Add(Me.ajout)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1027, 204)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ajouter le code de Fournisseur :"
        '
        'type
        '
        Me.type.DisplayMember = "Text"
        Me.type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.type.ForeColor = System.Drawing.Color.Black
        Me.type.FormattingEnabled = True
        Me.type.ItemHeight = 19
        Me.type.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4, Me.ComboItem5, Me.ComboItem6, Me.ComboItem7, Me.ComboItem8, Me.ComboItem12, Me.ComboItem13, Me.ComboItem14, Me.ComboItem15, Me.ComboItem16})
        Me.type.Location = New System.Drawing.Point(542, 139)
        Me.type.Name = "type"
        Me.type.Size = New System.Drawing.Size(180, 25)
        Me.type.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.type.TabIndex = 189
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "MOTEURS"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "LEVAGE ET MANUTENTION"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "CABLE ACIER"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "MATERIEL ELECTRIQUE"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "VISSERIES"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "MATERIEL ELECTRONIQUE"
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "OUTILLAGE"
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "CABLE ELECTRIQUE"
        '
        'ComboItem12
        '
        Me.ComboItem12.Text = "PIENTURE"
        '
        'ComboItem13
        '
        Me.ComboItem13.Text = "TRANSITAIRES"
        '
        'ComboItem14
        '
        Me.ComboItem14.Text = "HEDROMICANIQUE"
        '
        'ComboItem15
        '
        Me.ComboItem15.Text = "FILTRES JOINTS ET COUROIES"
        '
        'ComboItem16
        '
        Me.ComboItem16.Text = "PAPIERS ET CONSOMABLES"
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(429, 134)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(60, 23)
        Me.LabelX6.TabIndex = 188
        Me.LabelX6.Text = "Type :"
        '
        'MaskedTextBoxAdv1
        '
        Me.MaskedTextBoxAdv1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.MaskedTextBoxAdv1.BackgroundStyle.Class = "TextBoxBorder"
        Me.MaskedTextBoxAdv1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MaskedTextBoxAdv1.ButtonClear.Visible = True
        Me.MaskedTextBoxAdv1.ForeColor = System.Drawing.Color.Black
        Me.MaskedTextBoxAdv1.Location = New System.Drawing.Point(728, 98)
        Me.MaskedTextBoxAdv1.Mask = "[a-zA-Z0-9.-]+@[a-zA-Z0-9-]+\.[A-Za-z]{2,6}"
        Me.MaskedTextBoxAdv1.Name = "MaskedTextBoxAdv1"
        Me.MaskedTextBoxAdv1.Size = New System.Drawing.Size(37, 24)
        Me.MaskedTextBoxAdv1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.MaskedTextBoxAdv1.TabIndex = 187
        Me.MaskedTextBoxAdv1.Text = ""
        Me.MaskedTextBoxAdv1.Visible = False
        '
        'mail
        '
        Me.mail.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.mail.Border.Class = "TextBoxBorder"
        Me.mail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mail.ForeColor = System.Drawing.Color.Black
        Me.mail.Location = New System.Drawing.Point(542, 97)
        Me.mail.Name = "mail"
        Me.mail.Size = New System.Drawing.Size(180, 25)
        Me.mail.TabIndex = 186
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(429, 96)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(60, 23)
        Me.LabelX5.TabIndex = 185
        Me.LabelX5.Text = "Mail :"
        '
        'fax
        '
        Me.fax.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.fax.Border.Class = "TextBoxBorder"
        Me.fax.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fax.ForeColor = System.Drawing.Color.Black
        Me.fax.Location = New System.Drawing.Point(192, 139)
        Me.fax.Name = "fax"
        Me.fax.Size = New System.Drawing.Size(228, 25)
        Me.fax.TabIndex = 184
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(12, 134)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(40, 23)
        Me.LabelX4.TabIndex = 183
        Me.LabelX4.Text = "Fax :"
        '
        'tel
        '
        Me.tel.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tel.Border.Class = "TextBoxBorder"
        Me.tel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tel.ForeColor = System.Drawing.Color.Black
        Me.tel.Location = New System.Drawing.Point(192, 108)
        Me.tel.Name = "tel"
        Me.tel.Size = New System.Drawing.Size(228, 25)
        Me.tel.TabIndex = 182
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(12, 107)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(40, 23)
        Me.LabelX3.TabIndex = 181
        Me.LabelX3.Text = "Tel. :"
        '
        'ads
        '
        Me.ads.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.ads.Border.Class = "TextBoxBorder"
        Me.ads.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ads.ForeColor = System.Drawing.Color.Black
        Me.ads.Location = New System.Drawing.Point(192, 51)
        Me.ads.Multiline = True
        Me.ads.Name = "ads"
        Me.ads.Size = New System.Drawing.Size(228, 54)
        Me.ads.TabIndex = 180
        '
        'willaya
        '
        Me.willaya.DisplayMember = "Text"
        Me.willaya.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.willaya.ForeColor = System.Drawing.Color.Black
        Me.willaya.FormattingEnabled = True
        Me.willaya.ItemHeight = 19
        Me.willaya.Items.AddRange(New Object() {Me.ComboItem9, Me.ComboItem10, Me.ComboItem11})
        Me.willaya.Location = New System.Drawing.Point(542, 57)
        Me.willaya.Name = "willaya"
        Me.willaya.Size = New System.Drawing.Size(180, 25)
        Me.willaya.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.willaya.TabIndex = 103
        '
        'ComboItem9
        '
        Me.ComboItem9.Text = "Célibataire"
        '
        'ComboItem10
        '
        Me.ComboItem10.Text = "Marié sans enfants"
        '
        'ComboItem11
        '
        Me.ComboItem11.Text = "Marié avec enfants"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(426, 57)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 17)
        Me.Label23.TabIndex = 102
        Me.Label23.Text = "willaya :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(4, 59)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(182, 17)
        Me.Label15.TabIndex = 100
        Me.Label15.Text = "Adresse de Correspondance :"
        '
        'code
        '
        Me.code.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.code.Border.Class = "TextBoxBorder"
        Me.code.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.code.ForeColor = System.Drawing.Color.Black
        Me.code.Location = New System.Drawing.Point(192, 19)
        Me.code.Name = "code"
        Me.code.Size = New System.Drawing.Size(228, 25)
        Me.code.TabIndex = 6
        '
        'ajout
        '
        Me.ajout.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ajout.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ajout.Image = Global.MBA.My.Resources.Resources.add_button
        Me.ajout.Location = New System.Drawing.Point(342, 170)
        Me.ajout.Name = "ajout"
        Me.ajout.Size = New System.Drawing.Size(180, 23)
        Me.ajout.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ajout.TabIndex = 5
        Me.ajout.Text = "Ajouter"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(429, 21)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(107, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Nom Fournisseur :"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(12, 24)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(40, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Code :"
        '
        'code2
        '
        Me.code2.DisplayMember = "Text"
        Me.code2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.code2.ForeColor = System.Drawing.Color.Black
        Me.code2.FormattingEnabled = True
        Me.code2.ItemHeight = 19
        Me.code2.Location = New System.Drawing.Point(77, 35)
        Me.code2.Name = "code2"
        Me.code2.Size = New System.Drawing.Size(121, 25)
        Me.code2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.code2.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.nomfourech)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.boutrech)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(0, 204)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1027, 52)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recherche Fournisseur"
        '
        'nomfourech
        '
        Me.nomfourech.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.nomfourech.Border.Class = "TextBoxBorder"
        Me.nomfourech.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.nomfourech.ForeColor = System.Drawing.Color.Black
        Me.nomfourech.Location = New System.Drawing.Point(12, 21)
        Me.nomfourech.Name = "nomfourech"
        Me.nomfourech.Size = New System.Drawing.Size(408, 20)
        Me.nomfourech.TabIndex = 23
        Me.nomfourech.WatermarkImage = Global.MBA.My.Resources.Resources.user_id2
        Me.nomfourech.WatermarkText = "  Nom de Fournisseur ou bien Code..."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.MBA.My.Resources.Resources.loader
        Me.PictureBox1.Location = New System.Drawing.Point(542, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'boutrech
        '
        Me.boutrech.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.boutrech.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.boutrech.Image = Global.MBA.My.Resources.Resources.search
        Me.boutrech.Location = New System.Drawing.Point(586, 17)
        Me.boutrech.Name = "boutrech"
        Me.boutrech.Size = New System.Drawing.Size(136, 23)
        Me.boutrech.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.boutrech.TabIndex = 21
        Me.boutrech.Text = "Rechercher"
        '
        'DGcf
        '
        Me.DGcf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGcf.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White
        Me.DGcf.EmbeddedNavigator.Appearance.ForeColor = System.Drawing.Color.Black
        Me.DGcf.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.DGcf.EmbeddedNavigator.Appearance.Options.UseForeColor = True
        Me.DGcf.Location = New System.Drawing.Point(0, 256)
        Me.DGcf.LookAndFeel.SkinName = "Office 2013"
        Me.DGcf.LookAndFeel.UseDefaultLookAndFeel = False
        Me.DGcf.MainView = Me.GridView1
        Me.DGcf.Name = "DGcf"
        Me.DGcf.Size = New System.Drawing.Size(1027, 514)
        Me.DGcf.TabIndex = 15
        Me.DGcf.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.DGcf
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'AjoutFourniss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 770)
        Me.Controls.Add(Me.DGcf)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.code2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AjoutFourniss"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajout Fournisseur"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGcf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents nomfourn As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents code As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ajout As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents code2 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents willaya As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem10 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem11 As DevComponents.Editors.ComboItem
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents boutrech As DevComponents.DotNetBar.ButtonX
    Friend WithEvents nomfourech As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents DGcf As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ads As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tel As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents mail As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents fax As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents MaskedTextBoxAdv1 As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents type As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem12 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem13 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem14 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem15 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem16 As DevComponents.Editors.ComboItem
End Class
