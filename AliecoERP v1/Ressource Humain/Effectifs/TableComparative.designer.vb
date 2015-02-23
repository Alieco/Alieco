<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prestationFrm
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
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.titletxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.titreformation = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.description = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Observation = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.modalitepaiement = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.prixttc = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.prixht = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.delai = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.prestatairec = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.prestataire = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.offredgv = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.offredgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelX11)
        Me.GroupBox1.Controls.Add(Me.titletxt)
        Me.GroupBox1.Controls.Add(Me.LabelX10)
        Me.GroupBox1.Controls.Add(Me.ButtonX3)
        Me.GroupBox1.Controls.Add(Me.ButtonX2)
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Controls.Add(Me.titreformation)
        Me.GroupBox1.Controls.Add(Me.description)
        Me.GroupBox1.Controls.Add(Me.Observation)
        Me.GroupBox1.Controls.Add(Me.modalitepaiement)
        Me.GroupBox1.Controls.Add(Me.prixttc)
        Me.GroupBox1.Controls.Add(Me.prixht)
        Me.GroupBox1.Controls.Add(Me.delai)
        Me.GroupBox1.Controls.Add(Me.prestatairec)
        Me.GroupBox1.Controls.Add(Me.prestataire)
        Me.GroupBox1.Controls.Add(Me.LabelX9)
        Me.GroupBox1.Controls.Add(Me.LabelX8)
        Me.GroupBox1.Controls.Add(Me.LabelX7)
        Me.GroupBox1.Controls.Add(Me.LabelX6)
        Me.GroupBox1.Controls.Add(Me.LabelX5)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1334, 242)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "prestation"
        '
        'LabelX11
        '
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Location = New System.Drawing.Point(12, 65)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(94, 23)
        Me.LabelX11.TabIndex = 173
        Me.LabelX11.Text = "Nouveau Titre"
        '
        'titletxt
        '
        Me.titletxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.titletxt.Border.Class = "TextBoxBorder"
        Me.titletxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.titletxt.ForeColor = System.Drawing.Color.Black
        Me.titletxt.Location = New System.Drawing.Point(136, 67)
        Me.titletxt.Name = "titletxt"
        Me.titletxt.Size = New System.Drawing.Size(355, 23)
        Me.titletxt.TabIndex = 172
        Me.titletxt.WatermarkText = "Lissez vide si le titre de formation exist déja"
        '
        'LabelX10
        '
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX10.Location = New System.Drawing.Point(296, 43)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(30, 23)
        Me.LabelX10.TabIndex = 171
        Me.LabelX10.Text = "Ou"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Image = Global.MBA.My.Resources.Resources.sort
        Me.ButtonX3.Location = New System.Drawing.Point(1124, 208)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.PressedImage = Global.MBA.My.Resources.Resources.sort
        Me.ButtonX3.Size = New System.Drawing.Size(198, 20)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 170
        Me.ButtonX3.Text = "Afficher toutes les offres"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = Global.MBA.My.Resources.Resources.raport
        Me.ButtonX2.Location = New System.Drawing.Point(1124, 182)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.PressedImage = Global.MBA.My.Resources.Resources.raport
        Me.ButtonX2.Size = New System.Drawing.Size(198, 20)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 169
        Me.ButtonX2.Text = "Afficher le Tableau Comparative"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.MBA.My.Resources.Resources.adde
        Me.ButtonX1.Location = New System.Drawing.Point(1124, 153)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(198, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 20
        Me.ButtonX1.Text = "Ajouter l'offre"
        '
        'titreformation
        '
        Me.titreformation.DisplayMember = "Text"
        Me.titreformation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.titreformation.FormattingEnabled = True
        Me.titreformation.ItemHeight = 17
        Me.titreformation.Location = New System.Drawing.Point(136, 19)
        Me.titreformation.Name = "titreformation"
        Me.titreformation.Size = New System.Drawing.Size(355, 23)
        Me.titreformation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.titreformation.TabIndex = 19
        '
        'description
        '
        Me.description.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.description.Border.Class = "TextBoxBorder"
        Me.description.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.description.ForeColor = System.Drawing.Color.Black
        Me.description.Location = New System.Drawing.Point(136, 96)
        Me.description.Multiline = True
        Me.description.Name = "description"
        Me.description.Size = New System.Drawing.Size(355, 50)
        Me.description.TabIndex = 18
        '
        'Observation
        '
        Me.Observation.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Observation.Border.Class = "TextBoxBorder"
        Me.Observation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Observation.ForeColor = System.Drawing.Color.Black
        Me.Observation.Location = New System.Drawing.Point(712, 171)
        Me.Observation.Multiline = True
        Me.Observation.Name = "Observation"
        Me.Observation.Size = New System.Drawing.Size(357, 55)
        Me.Observation.TabIndex = 17
        '
        'modalitepaiement
        '
        Me.modalitepaiement.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.modalitepaiement.Border.Class = "TextBoxBorder"
        Me.modalitepaiement.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.modalitepaiement.ForeColor = System.Drawing.Color.Black
        Me.modalitepaiement.Location = New System.Drawing.Point(712, 103)
        Me.modalitepaiement.Multiline = True
        Me.modalitepaiement.Name = "modalitepaiement"
        Me.modalitepaiement.Size = New System.Drawing.Size(357, 55)
        Me.modalitepaiement.TabIndex = 16
        '
        'prixttc
        '
        Me.prixttc.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.prixttc.Border.Class = "TextBoxBorder"
        Me.prixttc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.prixttc.ForeColor = System.Drawing.Color.Black
        Me.prixttc.Location = New System.Drawing.Point(712, 74)
        Me.prixttc.Name = "prixttc"
        Me.prixttc.Size = New System.Drawing.Size(357, 23)
        Me.prixttc.TabIndex = 15
        '
        'prixht
        '
        Me.prixht.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.prixht.Border.Class = "TextBoxBorder"
        Me.prixht.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.prixht.ForeColor = System.Drawing.Color.Black
        Me.prixht.Location = New System.Drawing.Point(712, 45)
        Me.prixht.Name = "prixht"
        Me.prixht.Size = New System.Drawing.Size(357, 23)
        Me.prixht.TabIndex = 14
        '
        'delai
        '
        Me.delai.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.delai.Border.Class = "TextBoxBorder"
        Me.delai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.delai.ForeColor = System.Drawing.Color.Black
        Me.delai.Location = New System.Drawing.Point(136, 205)
        Me.delai.Name = "delai"
        Me.delai.Size = New System.Drawing.Size(355, 23)
        Me.delai.TabIndex = 13
        '
        'prestatairec
        '
        Me.prestatairec.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.prestatairec.Border.Class = "TextBoxBorder"
        Me.prestatairec.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.prestatairec.ForeColor = System.Drawing.Color.Black
        Me.prestatairec.Location = New System.Drawing.Point(136, 178)
        Me.prestatairec.Name = "prestatairec"
        Me.prestatairec.Size = New System.Drawing.Size(355, 23)
        Me.prestatairec.TabIndex = 12
        '
        'prestataire
        '
        Me.prestataire.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.prestataire.Border.Class = "TextBoxBorder"
        Me.prestataire.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.prestataire.ForeColor = System.Drawing.Color.Black
        Me.prestataire.Location = New System.Drawing.Point(136, 151)
        Me.prestataire.Name = "prestataire"
        Me.prestataire.Size = New System.Drawing.Size(355, 23)
        Me.prestataire.TabIndex = 11
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(589, 197)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(176, 23)
        Me.LabelX9.TabIndex = 9
        Me.LabelX9.Text = "Observation"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(589, 123)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(117, 23)
        Me.LabelX8.TabIndex = 8
        Me.LabelX8.Text = "Modalité de paiement"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(589, 74)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(176, 23)
        Me.LabelX7.TabIndex = 7
        Me.LabelX7.Text = "Prix TTC"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(589, 45)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(176, 23)
        Me.LabelX6.TabIndex = 6
        Me.LabelX6.Text = "Prix HT"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(12, 203)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(75, 23)
        Me.LabelX5.TabIndex = 5
        Me.LabelX5.Text = "Délai"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(12, 176)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(118, 23)
        Me.LabelX4.TabIndex = 4
        Me.LabelX4.Text = "Prestataire consulter"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(12, 149)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 3
        Me.LabelX3.Text = "Prestataires"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(12, 94)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 2
        Me.LabelX2.Text = "Description"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(12, 19)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Titre formation"
        '
        'offredgv
        '
        Me.offredgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.offredgv.Location = New System.Drawing.Point(0, 242)
        Me.offredgv.LookAndFeel.SkinName = "Office 2013"
        Me.offredgv.LookAndFeel.UseDefaultLookAndFeel = False
        Me.offredgv.MainView = Me.GridView1
        Me.offredgv.Name = "offredgv"
        Me.offredgv.Size = New System.Drawing.Size(1334, 336)
        Me.offredgv.TabIndex = 1
        Me.offredgv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.offredgv
        Me.GridView1.Name = "GridView1"
        '
        'prestationFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1334, 578)
        Me.Controls.Add(Me.offredgv)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "prestationFrm"
        Me.ShowIcon = False
        Me.Text = "    Table  comparative"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.offredgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents titreformation As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents description As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Observation As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents modalitepaiement As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents prixttc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents prixht As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents delai As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents prestatairec As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents prestataire As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents titletxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents offredgv As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
