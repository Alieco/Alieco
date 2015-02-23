<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FicheSuiveuse
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FicheSuiveuse))
        Me.tva = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.obs = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.total = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FichSuiv = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ButtonX6 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.exo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.modepaiement = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.nomcl = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.codecl = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tva
        '
        Me.tva.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tva.Border.Class = "TextBoxBorder"
        Me.tva.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tva.ForeColor = System.Drawing.Color.Black
        Me.tva.Location = New System.Drawing.Point(427, 281)
        Me.tva.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tva.Name = "tva"
        Me.tva.Size = New System.Drawing.Size(111, 20)
        Me.tva.TabIndex = 284
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.exo)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.modepaiement)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.nomcl)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.codecl)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.obs)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.ButtonX3)
        Me.GroupBox4.Controls.Add(Me.tva)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.total)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.FichSuiv)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(0, 13)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(597, 367)
        Me.GroupBox4.TabIndex = 252
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = " Fiche suiveuse :"
        '
        'obs
        '
        Me.obs.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.obs.Border.Class = "TextBoxBorder"
        Me.obs.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.obs.ForeColor = System.Drawing.Color.Black
        Me.obs.Location = New System.Drawing.Point(140, 286)
        Me.obs.Multiline = True
        Me.obs.Name = "obs"
        Me.obs.Size = New System.Drawing.Size(167, 65)
        Me.obs.TabIndex = 303
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(21, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 302
        Me.Label7.Text = "Observation :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(367, 285)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 283
        Me.Label9.Text = "TVA 17% :"
        '
        'total
        '
        Me.total.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.total.Border.Class = "TextBoxBorder"
        Me.total.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.total.ForeColor = System.Drawing.Color.Black
        Me.total.Location = New System.Drawing.Point(427, 253)
        Me.total.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(111, 20)
        Me.total.TabIndex = 282
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(367, 257)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 281
        Me.Label10.Text = "Montant :"
        '
        'FichSuiv
        '
        Me.FichSuiv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.FichSuiv.FullRowSelect = True
        Me.FichSuiv.GridLines = True
        Me.FichSuiv.LabelEdit = True
        Me.FichSuiv.Location = New System.Drawing.Point(15, 73)
        Me.FichSuiv.Name = "FichSuiv"
        Me.FichSuiv.Size = New System.Drawing.Size(554, 169)
        Me.FichSuiv.TabIndex = 272
        Me.FichSuiv.UseCompatibleStateImageBehavior = False
        Me.FichSuiv.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Imputation"
        Me.ColumnHeader1.Width = 126
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Facture/Decompte"
        Me.ColumnHeader2.Width = 166
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Date"
        Me.ColumnHeader3.Width = 112
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Montant"
        Me.ColumnHeader4.Width = 144
        '
        'ButtonX6
        '
        Me.ButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX6.Image = CType(resources.GetObject("ButtonX6.Image"), System.Drawing.Image)
        Me.ButtonX6.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.ButtonX6.Location = New System.Drawing.Point(437, 387)
        Me.ButtonX6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonX6.Name = "ButtonX6"
        Me.ButtonX6.Size = New System.Drawing.Size(160, 24)
        Me.ButtonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX6.TabIndex = 301
        Me.ButtonX6.Text = "Enregistrer"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Image = Global.MBA.My.Resources.Resources.slideshow_arrow_right
        Me.ButtonX3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.ButtonX3.Location = New System.Drawing.Point(978, 250)
        Me.ButtonX3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(259, 24)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 301
        Me.ButtonX3.Text = "Suivant"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.MBA.My.Resources.Resources.raport
        Me.ButtonX1.Location = New System.Drawing.Point(15, 387)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(169, 25)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 302
        Me.ButtonX1.Text = "Afficher la fiche suiveuse "
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(176, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.White
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Image = Global.MBA.My.Resources.Resources.edit
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(175, 22)
        Me.ToolStripMenuItem1.Text = "Modifier la ligne"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.White
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem2.Image = Global.MBA.My.Resources.Resources.delete
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(175, 22)
        Me.ToolStripMenuItem2.Text = "Supprimer la ligne"
        '
        'exo
        '
        Me.exo.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.exo.Border.Class = "TextBoxBorder"
        Me.exo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.exo.ForeColor = System.Drawing.Color.Black
        Me.exo.Location = New System.Drawing.Point(427, 310)
        Me.exo.Name = "exo"
        Me.exo.Size = New System.Drawing.Size(111, 20)
        Me.exo.TabIndex = 311
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(369, 315)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 310
        Me.Label1.Text = "Exoneree :"
        '
        'modepaiement
        '
        Me.modepaiement.DisplayMember = "Text"
        Me.modepaiement.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.modepaiement.ForeColor = System.Drawing.Color.Black
        Me.modepaiement.FormattingEnabled = True
        Me.modepaiement.ItemHeight = 19
        Me.modepaiement.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4, Me.ComboItem5})
        Me.modepaiement.Location = New System.Drawing.Point(140, 254)
        Me.modepaiement.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.modepaiement.Name = "modepaiement"
        Me.modepaiement.Size = New System.Drawing.Size(117, 25)
        Me.modepaiement.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.modepaiement.TabIndex = 309
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "VIREMENT CCP"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "VIREMENT BANQUE"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "MANDAT"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "CHEQUE"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "ESPECES"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(21, 257)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(101, 13)
        Me.Label23.TabIndex = 308
        Me.Label23.Text = "Mode de paiement :"
        '
        'nomcl
        '
        Me.nomcl.DisplayMember = "Text"
        Me.nomcl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.nomcl.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomcl.FormattingEnabled = True
        Me.nomcl.ItemHeight = 19
        Me.nomcl.Location = New System.Drawing.Point(98, 28)
        Me.nomcl.Name = "nomcl"
        Me.nomcl.Size = New System.Drawing.Size(190, 25)
        Me.nomcl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.nomcl.TabIndex = 307
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 17)
        Me.Label6.TabIndex = 306
        Me.Label6.Text = "Client :"
        '
        'codecl
        '
        Me.codecl.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.codecl.Border.Class = "TextBoxBorder"
        Me.codecl.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.codecl.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codecl.ForeColor = System.Drawing.Color.Black
        Me.codecl.Location = New System.Drawing.Point(379, 27)
        Me.codecl.Name = "codecl"
        Me.codecl.Size = New System.Drawing.Size(190, 25)
        Me.codecl.TabIndex = 305
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.White
        Me.Label26.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(294, 29)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(60, 17)
        Me.Label26.TabIndex = 304
        Me.Label26.Text = "C/Client :"
        '
        'FicheSuiveuse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 422)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.ButtonX6)
        Me.Controls.Add(Me.GroupBox4)
        Me.DoubleBuffered = True
        Me.Name = "FicheSuiveuse"
        Me.ShowIcon = False
        Me.Text = "Fiche Suiveuse"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents tva As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents total As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents FichSuiv As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ButtonX6 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents obs As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents exo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents modepaiement As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents nomcl As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents codecl As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label26 As System.Windows.Forms.Label
End Class
