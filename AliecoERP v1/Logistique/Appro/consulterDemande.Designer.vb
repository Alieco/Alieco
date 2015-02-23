<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consulterDemande
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(consulterDemande))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.remettre = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.votreoffre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.reglement = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.expedition = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.delai = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX6 = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelX9)
        Me.GroupBox2.Controls.Add(Me.LabelX8)
        Me.GroupBox2.Controls.Add(Me.LabelX7)
        Me.GroupBox2.Controls.Add(Me.LabelX6)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(837, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "La Demande :"
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(352, 41)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(479, 53)
        Me.LabelX9.TabIndex = 3
        Me.LabelX9.Text = "Designation : "
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(352, 19)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(333, 23)
        Me.LabelX8.TabIndex = 2
        Me.LabelX8.Text = "Service :"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(6, 48)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(311, 23)
        Me.LabelX7.TabIndex = 1
        Me.LabelX7.Text = "Affaire :"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(6, 19)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(311, 23)
        Me.LabelX6.TabIndex = 0
        Me.LabelX6.Text = "Demandeur :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.remettre)
        Me.GroupBox1.Controls.Add(Me.votreoffre)
        Me.GroupBox1.Controls.Add(Me.reglement)
        Me.GroupBox1.Controls.Add(Me.expedition)
        Me.GroupBox1.Controls.Add(Me.delai)
        Me.GroupBox1.Controls.Add(Me.LabelX5)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(837, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "A remplir par le service d'achat :"
        '
        'remettre
        '
        Me.remettre.DisplayMember = "Text"
        Me.remettre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.remettre.FormattingEnabled = True
        Me.remettre.ItemHeight = 14
        Me.remettre.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4, Me.ComboItem5})
        Me.remettre.Location = New System.Drawing.Point(675, 19)
        Me.remettre.Name = "remettre"
        Me.remettre.Size = New System.Drawing.Size(121, 20)
        Me.remettre.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.remettre.TabIndex = 9
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "BELAOUER Mounir"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "HADOUCHE Ahmed"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "MAYOUF Mustapha"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "OUAHAL Said"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "WALID Mahdi"
        '
        'votreoffre
        '
        Me.votreoffre.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.votreoffre.Border.Class = "TextBoxBorder"
        Me.votreoffre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.votreoffre.ForeColor = System.Drawing.Color.Black
        Me.votreoffre.Location = New System.Drawing.Point(447, 53)
        Me.votreoffre.Name = "votreoffre"
        Me.votreoffre.Size = New System.Drawing.Size(141, 20)
        Me.votreoffre.TabIndex = 8
        '
        'reglement
        '
        Me.reglement.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.reglement.Border.Class = "TextBoxBorder"
        Me.reglement.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.reglement.ForeColor = System.Drawing.Color.Black
        Me.reglement.Location = New System.Drawing.Point(447, 19)
        Me.reglement.Name = "reglement"
        Me.reglement.Size = New System.Drawing.Size(141, 20)
        Me.reglement.TabIndex = 7
        '
        'expedition
        '
        Me.expedition.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.expedition.Border.Class = "TextBoxBorder"
        Me.expedition.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.expedition.ForeColor = System.Drawing.Color.Black
        Me.expedition.Location = New System.Drawing.Point(84, 56)
        Me.expedition.Name = "expedition"
        Me.expedition.Size = New System.Drawing.Size(137, 20)
        Me.expedition.TabIndex = 6
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
        Me.delai.Location = New System.Drawing.Point(84, 19)
        Me.delai.Name = "delai"
        Me.delai.Size = New System.Drawing.Size(137, 20)
        Me.delai.TabIndex = 5
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(603, 19)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(66, 23)
        Me.LabelX5.TabIndex = 4
        Me.LabelX5.Text = "Remettre à :"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(366, 53)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(75, 23)
        Me.LabelX4.TabIndex = 3
        Me.LabelX4.Text = "Votre offre du :"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(366, 19)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 2
        Me.LabelX3.Text = "Réglement :"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(6, 53)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "Expedition :"
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
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Délai :"
        '
        'ButtonX6
        '
        Me.ButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX6.Image = CType(resources.GetObject("ButtonX6.Image"), System.Drawing.Image)
        Me.ButtonX6.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.ButtonX6.Location = New System.Drawing.Point(578, 207)
        Me.ButtonX6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonX6.Name = "ButtonX6"
        Me.ButtonX6.Size = New System.Drawing.Size(259, 24)
        Me.ButtonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX6.TabIndex = 310
        Me.ButtonX6.Text = "Enregistrer"
        '
        'consulterDemande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 232)
        Me.Controls.Add(Me.ButtonX6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.DoubleBuffered = True
        Me.Name = "consulterDemande"
        Me.ShowIcon = False
        Me.Text = "consulter la demande"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents remettre As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents votreoffre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents reglement As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents expedition As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents delai As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX6 As DevComponents.DotNetBar.ButtonX
End Class
