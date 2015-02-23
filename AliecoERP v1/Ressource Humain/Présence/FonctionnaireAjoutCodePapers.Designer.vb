<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FonctionnaireAjoutCodePapers
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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Mod_Paiement = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.servicelbl = New DevComponents.DotNetBar.LabelX()
        Me.fonctionlbl = New DevComponents.DotNetBar.LabelX()
        Me.Nomlbl = New DevComponents.DotNetBar.LabelX()
        Me.mat = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.Pos_paiement = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Num_CPT = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Code_Mut = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Num_SS = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Affectation = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Section = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX()
        Me.Anc_NumSS = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Nbre_Charge = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.Nombre_enfant = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.CPdg = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CPdg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModifierToolStripMenuItem, Me.SupprimerToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(206, 48)
        '
        'ModifierToolStripMenuItem
        '
        Me.ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        Me.ModifierToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ModifierToolStripMenuItem.Text = "   Modifier Cette ligne   "
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.SupprimerToolStripMenuItem.Text = "   Supprimer cette ligne   "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Mod_Paiement)
        Me.GroupBox1.Controls.Add(Me.servicelbl)
        Me.GroupBox1.Controls.Add(Me.fonctionlbl)
        Me.GroupBox1.Controls.Add(Me.Nomlbl)
        Me.GroupBox1.Controls.Add(Me.mat)
        Me.GroupBox1.Controls.Add(Me.Pos_paiement)
        Me.GroupBox1.Controls.Add(Me.Num_CPT)
        Me.GroupBox1.Controls.Add(Me.Code_Mut)
        Me.GroupBox1.Controls.Add(Me.Num_SS)
        Me.GroupBox1.Controls.Add(Me.Affectation)
        Me.GroupBox1.Controls.Add(Me.Section)
        Me.GroupBox1.Controls.Add(Me.LabelX20)
        Me.GroupBox1.Controls.Add(Me.LabelX18)
        Me.GroupBox1.Controls.Add(Me.Anc_NumSS)
        Me.GroupBox1.Controls.Add(Me.Nbre_Charge)
        Me.GroupBox1.Controls.Add(Me.LabelX13)
        Me.GroupBox1.Controls.Add(Me.LabelX14)
        Me.GroupBox1.Controls.Add(Me.LabelX16)
        Me.GroupBox1.Controls.Add(Me.LabelX9)
        Me.GroupBox1.Controls.Add(Me.LabelX10)
        Me.GroupBox1.Controls.Add(Me.LabelX7)
        Me.GroupBox1.Controls.Add(Me.LabelX8)
        Me.GroupBox1.Controls.Add(Me.Nombre_enfant)
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1271, 216)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ajouter le code de fonctionnaire :"
        '
        'Mod_Paiement
        '
        Me.Mod_Paiement.DisplayMember = "Text"
        Me.Mod_Paiement.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Mod_Paiement.ForeColor = System.Drawing.Color.Black
        Me.Mod_Paiement.FormattingEnabled = True
        Me.Mod_Paiement.ItemHeight = 19
        Me.Mod_Paiement.Location = New System.Drawing.Point(667, 151)
        Me.Mod_Paiement.Name = "Mod_Paiement"
        Me.Mod_Paiement.Size = New System.Drawing.Size(161, 25)
        Me.Mod_Paiement.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Mod_Paiement.TabIndex = 279
        '
        'servicelbl
        '
        Me.servicelbl.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.servicelbl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.servicelbl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.servicelbl.ForeColor = System.Drawing.Color.Black
        Me.servicelbl.Location = New System.Drawing.Point(337, 93)
        Me.servicelbl.Name = "servicelbl"
        Me.servicelbl.Size = New System.Drawing.Size(145, 23)
        Me.servicelbl.TabIndex = 278
        '
        'fonctionlbl
        '
        Me.fonctionlbl.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.fonctionlbl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fonctionlbl.ForeColor = System.Drawing.Color.Black
        Me.fonctionlbl.Location = New System.Drawing.Point(846, 58)
        Me.fonctionlbl.Name = "fonctionlbl"
        Me.fonctionlbl.Size = New System.Drawing.Size(367, 27)
        Me.fonctionlbl.TabIndex = 277
        '
        'Nomlbl
        '
        Me.Nomlbl.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Nomlbl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Nomlbl.ForeColor = System.Drawing.Color.Black
        Me.Nomlbl.Location = New System.Drawing.Point(846, 30)
        Me.Nomlbl.Name = "Nomlbl"
        Me.Nomlbl.Size = New System.Drawing.Size(284, 27)
        Me.Nomlbl.TabIndex = 276
        '
        'mat
        '
        Me.mat.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.mat.BackgroundStyle.Class = "TextBoxBorder"
        Me.mat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mat.ButtonClear.Visible = True
        Me.mat.ForeColor = System.Drawing.Color.Black
        Me.mat.Location = New System.Drawing.Point(134, 36)
        Me.mat.Mask = "00000"
        Me.mat.Name = "mat"
        Me.mat.Size = New System.Drawing.Size(199, 20)
        Me.mat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.mat.TabIndex = 275
        Me.mat.Text = ""
        '
        'Pos_paiement
        '
        Me.Pos_paiement.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Pos_paiement.Border.Class = "TextBoxBorder"
        Me.Pos_paiement.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Pos_paiement.ForeColor = System.Drawing.Color.Black
        Me.Pos_paiement.Location = New System.Drawing.Point(134, 120)
        Me.Pos_paiement.Name = "Pos_paiement"
        Me.Pos_paiement.Size = New System.Drawing.Size(197, 25)
        Me.Pos_paiement.TabIndex = 274
        '
        'Num_CPT
        '
        Me.Num_CPT.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Num_CPT.Border.Class = "TextBoxBorder"
        Me.Num_CPT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Num_CPT.ForeColor = System.Drawing.Color.Black
        Me.Num_CPT.Location = New System.Drawing.Point(667, 31)
        Me.Num_CPT.Name = "Num_CPT"
        Me.Num_CPT.Size = New System.Drawing.Size(161, 25)
        Me.Num_CPT.TabIndex = 273
        '
        'Code_Mut
        '
        Me.Code_Mut.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Code_Mut.Border.Class = "TextBoxBorder"
        Me.Code_Mut.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Code_Mut.ForeColor = System.Drawing.Color.Black
        Me.Code_Mut.Location = New System.Drawing.Point(134, 180)
        Me.Code_Mut.Name = "Code_Mut"
        Me.Code_Mut.Size = New System.Drawing.Size(197, 25)
        Me.Code_Mut.TabIndex = 271
        '
        'Num_SS
        '
        Me.Num_SS.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Num_SS.Border.Class = "TextBoxBorder"
        Me.Num_SS.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Num_SS.ForeColor = System.Drawing.Color.Black
        Me.Num_SS.Location = New System.Drawing.Point(134, 151)
        Me.Num_SS.Name = "Num_SS"
        Me.Num_SS.Size = New System.Drawing.Size(198, 25)
        Me.Num_SS.TabIndex = 270
        '
        'Affectation
        '
        Me.Affectation.DisplayMember = "Text"
        Me.Affectation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Affectation.ForeColor = System.Drawing.Color.Black
        Me.Affectation.FormattingEnabled = True
        Me.Affectation.ItemHeight = 19
        Me.Affectation.Location = New System.Drawing.Point(135, 91)
        Me.Affectation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Affectation.Name = "Affectation"
        Me.Affectation.Size = New System.Drawing.Size(196, 25)
        Me.Affectation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Affectation.TabIndex = 262
        '
        'Section
        '
        Me.Section.DisplayMember = "Text"
        Me.Section.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Section.ForeColor = System.Drawing.Color.Black
        Me.Section.FormattingEnabled = True
        Me.Section.ItemHeight = 19
        Me.Section.Location = New System.Drawing.Point(134, 62)
        Me.Section.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Section.Name = "Section"
        Me.Section.Size = New System.Drawing.Size(199, 25)
        Me.Section.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Section.TabIndex = 260
        '
        'LabelX20
        '
        Me.LabelX20.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX20.ForeColor = System.Drawing.Color.Black
        Me.LabelX20.Location = New System.Drawing.Point(507, 153)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.Size = New System.Drawing.Size(100, 23)
        Me.LabelX20.TabIndex = 32
        Me.LabelX20.Text = "Mode Paiement :"
        '
        'LabelX18
        '
        Me.LabelX18.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX18.ForeColor = System.Drawing.Color.Black
        Me.LabelX18.Location = New System.Drawing.Point(5, 180)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(100, 23)
        Me.LabelX18.TabIndex = 28
        Me.LabelX18.Text = "Code Mutuelle :"
        '
        'Anc_NumSS
        '
        Me.Anc_NumSS.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Anc_NumSS.Border.Class = "TextBoxBorder"
        Me.Anc_NumSS.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Anc_NumSS.ForeColor = System.Drawing.Color.Black
        Me.Anc_NumSS.Location = New System.Drawing.Point(667, 125)
        Me.Anc_NumSS.Name = "Anc_NumSS"
        Me.Anc_NumSS.Size = New System.Drawing.Size(161, 25)
        Me.Anc_NumSS.TabIndex = 26
        '
        'Nbre_Charge
        '
        Me.Nbre_Charge.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Nbre_Charge.Border.Class = "TextBoxBorder"
        Me.Nbre_Charge.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Nbre_Charge.ForeColor = System.Drawing.Color.Black
        Me.Nbre_Charge.Location = New System.Drawing.Point(667, 94)
        Me.Nbre_Charge.Name = "Nbre_Charge"
        Me.Nbre_Charge.Size = New System.Drawing.Size(161, 25)
        Me.Nbre_Charge.TabIndex = 22
        Me.Nbre_Charge.Text = "0"
        '
        'LabelX13
        '
        Me.LabelX13.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.ForeColor = System.Drawing.Color.Black
        Me.LabelX13.Location = New System.Drawing.Point(508, 117)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(110, 23)
        Me.LabelX13.TabIndex = 21
        Me.LabelX13.Text = "Ancien Num SS :"
        '
        'LabelX14
        '
        Me.LabelX14.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.ForeColor = System.Drawing.Color.Black
        Me.LabelX14.Location = New System.Drawing.Point(507, 91)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(111, 23)
        Me.LabelX14.TabIndex = 20
        Me.LabelX14.Text = "Nombre Charge :"
        '
        'LabelX16
        '
        Me.LabelX16.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX16.ForeColor = System.Drawing.Color.Black
        Me.LabelX16.Location = New System.Drawing.Point(507, 31)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(155, 23)
        Me.LabelX16.TabIndex = 16
        Me.LabelX16.Text = "Num Compte bancaire :"
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.ForeColor = System.Drawing.Color.Black
        Me.LabelX9.Location = New System.Drawing.Point(5, 151)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(100, 23)
        Me.LabelX9.TabIndex = 13
        Me.LabelX9.Text = "Num SS :"
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.ForeColor = System.Drawing.Color.Black
        Me.LabelX10.Location = New System.Drawing.Point(5, 122)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(101, 23)
        Me.LabelX10.TabIndex = 12
        Me.LabelX10.Text = "Pos paiement:"
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(6, 93)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(100, 23)
        Me.LabelX7.TabIndex = 9
        Me.LabelX7.Text = "Affectation :"
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.ForeColor = System.Drawing.Color.Black
        Me.LabelX8.Location = New System.Drawing.Point(6, 64)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(123, 23)
        Me.LabelX8.TabIndex = 8
        Me.LabelX8.Text = "Section :"
        '
        'Nombre_enfant
        '
        Me.Nombre_enfant.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.Nombre_enfant.Border.Class = "TextBoxBorder"
        Me.Nombre_enfant.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Nombre_enfant.ForeColor = System.Drawing.Color.Black
        Me.Nombre_enfant.Location = New System.Drawing.Point(667, 62)
        Me.Nombre_enfant.Name = "Nombre_enfant"
        Me.Nombre_enfant.Size = New System.Drawing.Size(161, 25)
        Me.Nombre_enfant.TabIndex = 7
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.MBA.My.Resources.Resources.add_button
        Me.ButtonX1.Location = New System.Drawing.Point(857, 180)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(255, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 5
        Me.ButtonX1.Text = "Ajouter"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(507, 60)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(100, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Nombre enfant :"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(6, 35)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(101, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Matricule :"
        '
        'CPdg
        '
        Me.CPdg.ContextMenuStrip = Me.ContextMenuStrip1
        Me.CPdg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CPdg.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White
        Me.CPdg.EmbeddedNavigator.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CPdg.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.CPdg.EmbeddedNavigator.Appearance.Options.UseForeColor = True
        Me.CPdg.Location = New System.Drawing.Point(0, 216)
        Me.CPdg.LookAndFeel.SkinName = "Office 2013"
        Me.CPdg.LookAndFeel.UseDefaultLookAndFeel = False
        Me.CPdg.MainView = Me.GridView1
        Me.CPdg.Name = "CPdg"
        Me.CPdg.Size = New System.Drawing.Size(1271, 417)
        Me.CPdg.TabIndex = 8
        Me.CPdg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.CPdg
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'FonctionnaireAjoutCodePapers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1271, 633)
        Me.Controls.Add(Me.CPdg)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FonctionnaireAjoutCodePapers"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Affectation des employes"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.CPdg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ModifierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents mat As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents Pos_paiement As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Num_CPT As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Code_Mut As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Num_SS As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Affectation As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Section As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Anc_NumSS As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Nbre_Charge As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Nombre_enfant As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CPdg As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents fonctionlbl As DevComponents.DotNetBar.LabelX
    Friend WithEvents Nomlbl As DevComponents.DotNetBar.LabelX
    Friend WithEvents servicelbl As DevComponents.DotNetBar.LabelX
    Friend WithEvents Mod_Paiement As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
