<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCodePaie
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.prorata = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem15 = New DevComponents.Editors.ComboItem()
        Me.ComboItem16 = New DevComponents.Editors.ComboItem()
        Me.imput = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.type = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem26 = New DevComponents.Editors.ComboItem()
        Me.ComboItem27 = New DevComponents.Editors.ComboItem()
        Me.ComboItem28 = New DevComponents.Editors.ComboItem()
        Me.ComboItem29 = New DevComponents.Editors.ComboItem()
        Me.ComboItem30 = New DevComponents.Editors.ComboItem()
        Me.ComboItem31 = New DevComponents.Editors.ComboItem()
        Me.ComboItem32 = New DevComponents.Editors.ComboItem()
        Me.rg = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem17 = New DevComponents.Editors.ComboItem()
        Me.ComboItem18 = New DevComponents.Editors.ComboItem()
        Me.ComboItem19 = New DevComponents.Editors.ComboItem()
        Me.ComboItem20 = New DevComponents.Editors.ComboItem()
        Me.ComboItem21 = New DevComponents.Editors.ComboItem()
        Me.ComboItem22 = New DevComponents.Editors.ComboItem()
        Me.ComboItem23 = New DevComponents.Editors.ComboItem()
        Me.ComboItem24 = New DevComponents.Editors.ComboItem()
        Me.ComboItem25 = New DevComponents.Editors.ComboItem()
        Me.codret = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem13 = New DevComponents.Editors.ComboItem()
        Me.ComboItem14 = New DevComponents.Editors.ComboItem()
        Me.fix = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.codcalc = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem10 = New DevComponents.Editors.ComboItem()
        Me.ComboItem11 = New DevComponents.Editors.ComboItem()
        Me.ComboItem12 = New DevComponents.Editors.ComboItem()
        Me.soumits = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.sens = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.ComboItem9 = New DevComponents.Editors.ComboItem()
        Me.soumiss = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem51 = New DevComponents.Editors.ComboItem()
        Me.ComboItem52 = New DevComponents.Editors.ComboItem()
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX()
        Me.tiers = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.prv = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.tauxpu = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.libelle1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.code1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.CPdg = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GetRubriqueBW = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CPdg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.prorata)
        Me.GroupBox1.Controls.Add(Me.imput)
        Me.GroupBox1.Controls.Add(Me.type)
        Me.GroupBox1.Controls.Add(Me.rg)
        Me.GroupBox1.Controls.Add(Me.codret)
        Me.GroupBox1.Controls.Add(Me.fix)
        Me.GroupBox1.Controls.Add(Me.codcalc)
        Me.GroupBox1.Controls.Add(Me.soumits)
        Me.GroupBox1.Controls.Add(Me.sens)
        Me.GroupBox1.Controls.Add(Me.soumiss)
        Me.GroupBox1.Controls.Add(Me.LabelX20)
        Me.GroupBox1.Controls.Add(Me.LabelX17)
        Me.GroupBox1.Controls.Add(Me.LabelX18)
        Me.GroupBox1.Controls.Add(Me.tiers)
        Me.GroupBox1.Controls.Add(Me.prv)
        Me.GroupBox1.Controls.Add(Me.LabelX11)
        Me.GroupBox1.Controls.Add(Me.LabelX12)
        Me.GroupBox1.Controls.Add(Me.tauxpu)
        Me.GroupBox1.Controls.Add(Me.LabelX13)
        Me.GroupBox1.Controls.Add(Me.LabelX14)
        Me.GroupBox1.Controls.Add(Me.LabelX15)
        Me.GroupBox1.Controls.Add(Me.LabelX16)
        Me.GroupBox1.Controls.Add(Me.LabelX9)
        Me.GroupBox1.Controls.Add(Me.LabelX10)
        Me.GroupBox1.Controls.Add(Me.LabelX7)
        Me.GroupBox1.Controls.Add(Me.LabelX8)
        Me.GroupBox1.Controls.Add(Me.libelle1)
        Me.GroupBox1.Controls.Add(Me.code1)
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1392, 284)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ajouter le code de Bulletin de paie :"
        '
        'prorata
        '
        Me.prorata.DisplayMember = "Text"
        Me.prorata.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.prorata.ForeColor = System.Drawing.Color.Black
        Me.prorata.FormattingEnabled = True
        Me.prorata.ItemHeight = 19
        Me.prorata.Items.AddRange(New Object() {Me.ComboItem15, Me.ComboItem16})
        Me.prorata.Location = New System.Drawing.Point(628, 52)
        Me.prorata.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.prorata.Name = "prorata"
        Me.prorata.Size = New System.Drawing.Size(199, 25)
        Me.prorata.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.prorata.TabIndex = 271
        '
        'ComboItem15
        '
        Me.ComboItem15.Text = "O"
        '
        'ComboItem16
        '
        Me.ComboItem16.Text = "N"
        '
        'imput
        '
        Me.imput.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.imput.Border.Class = "TextBoxBorder"
        Me.imput.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.imput.ForeColor = System.Drawing.Color.Black
        Me.imput.Location = New System.Drawing.Point(134, 180)
        Me.imput.Name = "imput"
        Me.imput.Size = New System.Drawing.Size(198, 25)
        Me.imput.TabIndex = 270
        '
        'type
        '
        Me.type.DisplayMember = "Text"
        Me.type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.type.ForeColor = System.Drawing.Color.Black
        Me.type.FormattingEnabled = True
        Me.type.ItemHeight = 19
        Me.type.Items.AddRange(New Object() {Me.ComboItem26, Me.ComboItem27, Me.ComboItem28, Me.ComboItem29, Me.ComboItem30, Me.ComboItem31, Me.ComboItem32})
        Me.type.Location = New System.Drawing.Point(627, 197)
        Me.type.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.type.Name = "type"
        Me.type.Size = New System.Drawing.Size(199, 25)
        Me.type.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.type.TabIndex = 269
        '
        'ComboItem26
        '
        Me.ComboItem26.Text = "1"
        '
        'ComboItem27
        '
        Me.ComboItem27.Text = "2"
        '
        'ComboItem28
        '
        Me.ComboItem28.Text = "3"
        '
        'ComboItem29
        '
        Me.ComboItem29.Text = "4"
        '
        'ComboItem30
        '
        Me.ComboItem30.Text = "5"
        '
        'ComboItem31
        '
        Me.ComboItem31.Text = "6"
        '
        'ComboItem32
        '
        Me.ComboItem32.Text = "7"
        '
        'rg
        '
        Me.rg.DisplayMember = "Text"
        Me.rg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.rg.ForeColor = System.Drawing.Color.Black
        Me.rg.FormattingEnabled = True
        Me.rg.ItemHeight = 19
        Me.rg.Items.AddRange(New Object() {Me.ComboItem17, Me.ComboItem18, Me.ComboItem19, Me.ComboItem20, Me.ComboItem21, Me.ComboItem22, Me.ComboItem23, Me.ComboItem24, Me.ComboItem25})
        Me.rg.Location = New System.Drawing.Point(627, 110)
        Me.rg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rg.Name = "rg"
        Me.rg.Size = New System.Drawing.Size(199, 25)
        Me.rg.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rg.TabIndex = 268
        '
        'ComboItem17
        '
        Me.ComboItem17.Text = "1"
        '
        'ComboItem18
        '
        Me.ComboItem18.Text = "2"
        '
        'ComboItem19
        '
        Me.ComboItem19.Text = "3"
        '
        'ComboItem20
        '
        Me.ComboItem20.Text = "4"
        '
        'ComboItem21
        '
        Me.ComboItem21.Text = "5"
        '
        'ComboItem22
        '
        Me.ComboItem22.Text = "6"
        '
        'ComboItem23
        '
        Me.ComboItem23.Text = "7"
        '
        'ComboItem24
        '
        Me.ComboItem24.Text = "8"
        '
        'ComboItem25
        '
        Me.ComboItem25.Text = "9"
        '
        'codret
        '
        Me.codret.DisplayMember = "Text"
        Me.codret.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.codret.ForeColor = System.Drawing.Color.Black
        Me.codret.FormattingEnabled = True
        Me.codret.ItemHeight = 19
        Me.codret.Items.AddRange(New Object() {Me.ComboItem13, Me.ComboItem14})
        Me.codret.Location = New System.Drawing.Point(628, 23)
        Me.codret.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.codret.Name = "codret"
        Me.codret.Size = New System.Drawing.Size(199, 25)
        Me.codret.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.codret.TabIndex = 266
        '
        'ComboItem13
        '
        Me.ComboItem13.Text = "O"
        '
        'ComboItem14
        '
        Me.ComboItem14.Text = "N"
        '
        'fix
        '
        Me.fix.DisplayMember = "Text"
        Me.fix.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.fix.ForeColor = System.Drawing.Color.Black
        Me.fix.FormattingEnabled = True
        Me.fix.ItemHeight = 19
        Me.fix.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2})
        Me.fix.Location = New System.Drawing.Point(135, 209)
        Me.fix.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.fix.Name = "fix"
        Me.fix.Size = New System.Drawing.Size(199, 25)
        Me.fix.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.fix.TabIndex = 265
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "F"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "V"
        '
        'codcalc
        '
        Me.codcalc.DisplayMember = "Text"
        Me.codcalc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.codcalc.ForeColor = System.Drawing.Color.Black
        Me.codcalc.FormattingEnabled = True
        Me.codcalc.ItemHeight = 19
        Me.codcalc.Items.AddRange(New Object() {Me.ComboItem3, Me.ComboItem4, Me.ComboItem5, Me.ComboItem10, Me.ComboItem11, Me.ComboItem12})
        Me.codcalc.Location = New System.Drawing.Point(134, 238)
        Me.codcalc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.codcalc.Name = "codcalc"
        Me.codcalc.Size = New System.Drawing.Size(199, 25)
        Me.codcalc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.codcalc.TabIndex = 264
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "1"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "2"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "3"
        '
        'ComboItem10
        '
        Me.ComboItem10.Text = "4"
        '
        'ComboItem11
        '
        Me.ComboItem11.Text = "5"
        '
        'ComboItem12
        '
        Me.ComboItem12.Text = "6"
        '
        'soumits
        '
        Me.soumits.DisplayMember = "Text"
        Me.soumits.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.soumits.ForeColor = System.Drawing.Color.Black
        Me.soumits.FormattingEnabled = True
        Me.soumits.ItemHeight = 19
        Me.soumits.Items.AddRange(New Object() {Me.ComboItem6, Me.ComboItem7})
        Me.soumits.Location = New System.Drawing.Point(135, 120)
        Me.soumits.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.soumits.Name = "soumits"
        Me.soumits.Size = New System.Drawing.Size(199, 25)
        Me.soumits.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.soumits.TabIndex = 262
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "O"
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "N"
        '
        'sens
        '
        Me.sens.DisplayMember = "Text"
        Me.sens.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.sens.ForeColor = System.Drawing.Color.Black
        Me.sens.FormattingEnabled = True
        Me.sens.ItemHeight = 19
        Me.sens.Items.AddRange(New Object() {Me.ComboItem8, Me.ComboItem9})
        Me.sens.Location = New System.Drawing.Point(134, 149)
        Me.sens.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sens.Name = "sens"
        Me.sens.Size = New System.Drawing.Size(199, 25)
        Me.sens.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.sens.TabIndex = 261
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "+"
        '
        'ComboItem9
        '
        Me.ComboItem9.Text = "-"
        '
        'soumiss
        '
        Me.soumiss.DisplayMember = "Text"
        Me.soumiss.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.soumiss.ForeColor = System.Drawing.Color.Black
        Me.soumiss.FormattingEnabled = True
        Me.soumiss.ItemHeight = 19
        Me.soumiss.Items.AddRange(New Object() {Me.ComboItem51, Me.ComboItem52})
        Me.soumiss.Location = New System.Drawing.Point(134, 91)
        Me.soumiss.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.soumiss.Name = "soumiss"
        Me.soumiss.Size = New System.Drawing.Size(199, 25)
        Me.soumiss.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.soumiss.TabIndex = 260
        '
        'ComboItem51
        '
        Me.ComboItem51.Text = "O"
        '
        'ComboItem52
        '
        Me.ComboItem52.Text = "N"
        '
        'LabelX20
        '
        Me.LabelX20.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX20.ForeColor = System.Drawing.Color.Black
        Me.LabelX20.Location = New System.Drawing.Point(5, 238)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.Size = New System.Drawing.Size(100, 23)
        Me.LabelX20.TabIndex = 32
        Me.LabelX20.Text = "Code calcule :"
        '
        'LabelX17
        '
        Me.LabelX17.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX17.ForeColor = System.Drawing.Color.Black
        Me.LabelX17.Location = New System.Drawing.Point(500, 199)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(110, 23)
        Me.LabelX17.TabIndex = 30
        Me.LabelX17.Text = "Type :"
        '
        'LabelX18
        '
        Me.LabelX18.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX18.ForeColor = System.Drawing.Color.Black
        Me.LabelX18.Location = New System.Drawing.Point(5, 209)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(100, 23)
        Me.LabelX18.TabIndex = 28
        Me.LabelX18.Text = "Fix :"
        '
        'tiers
        '
        Me.tiers.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tiers.Border.Class = "TextBoxBorder"
        Me.tiers.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tiers.ForeColor = System.Drawing.Color.Black
        Me.tiers.Location = New System.Drawing.Point(627, 168)
        Me.tiers.Name = "tiers"
        Me.tiers.Size = New System.Drawing.Size(199, 25)
        Me.tiers.TabIndex = 27
        '
        'prv
        '
        Me.prv.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.prv.Border.Class = "TextBoxBorder"
        Me.prv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.prv.ForeColor = System.Drawing.Color.Black
        Me.prv.Location = New System.Drawing.Point(627, 138)
        Me.prv.Name = "prv"
        Me.prv.Size = New System.Drawing.Size(199, 25)
        Me.prv.TabIndex = 26
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.ForeColor = System.Drawing.Color.Black
        Me.LabelX11.Location = New System.Drawing.Point(500, 170)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(110, 23)
        Me.LabelX11.TabIndex = 25
        Me.LabelX11.Text = "Tiers :"
        '
        'LabelX12
        '
        Me.LabelX12.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.ForeColor = System.Drawing.Color.Black
        Me.LabelX12.Location = New System.Drawing.Point(500, 141)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(111, 23)
        Me.LabelX12.TabIndex = 24
        Me.LabelX12.Text = "PRV :"
        '
        'tauxpu
        '
        Me.tauxpu.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tauxpu.Border.Class = "TextBoxBorder"
        Me.tauxpu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tauxpu.ForeColor = System.Drawing.Color.Black
        Me.tauxpu.Location = New System.Drawing.Point(628, 80)
        Me.tauxpu.Name = "tauxpu"
        Me.tauxpu.Size = New System.Drawing.Size(199, 25)
        Me.tauxpu.TabIndex = 22
        Me.tauxpu.Text = "0"
        '
        'LabelX13
        '
        Me.LabelX13.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.ForeColor = System.Drawing.Color.Black
        Me.LabelX13.Location = New System.Drawing.Point(501, 112)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(110, 23)
        Me.LabelX13.TabIndex = 21
        Me.LabelX13.Text = "RG :"
        '
        'LabelX14
        '
        Me.LabelX14.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.ForeColor = System.Drawing.Color.Black
        Me.LabelX14.Location = New System.Drawing.Point(501, 83)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(111, 23)
        Me.LabelX14.TabIndex = 20
        Me.LabelX14.Text = "Taux P.U. :"
        '
        'LabelX15
        '
        Me.LabelX15.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.ForeColor = System.Drawing.Color.Black
        Me.LabelX15.Location = New System.Drawing.Point(501, 54)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(110, 23)
        Me.LabelX15.TabIndex = 17
        Me.LabelX15.Text = "Prorata :"
        '
        'LabelX16
        '
        Me.LabelX16.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX16.ForeColor = System.Drawing.Color.Black
        Me.LabelX16.Location = New System.Drawing.Point(501, 25)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(111, 23)
        Me.LabelX16.TabIndex = 16
        Me.LabelX16.Text = "Code ret :"
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.ForeColor = System.Drawing.Color.Black
        Me.LabelX9.Location = New System.Drawing.Point(5, 180)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(100, 23)
        Me.LabelX9.TabIndex = 13
        Me.LabelX9.Text = "Impot :"
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.ForeColor = System.Drawing.Color.Black
        Me.LabelX10.Location = New System.Drawing.Point(5, 151)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(101, 23)
        Me.LabelX10.TabIndex = 12
        Me.LabelX10.Text = "Sens :"
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(6, 122)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(100, 23)
        Me.LabelX7.TabIndex = 9
        Me.LabelX7.Text = "Soumis A S/S :"
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.ForeColor = System.Drawing.Color.Black
        Me.LabelX8.Location = New System.Drawing.Point(6, 93)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(123, 23)
        Me.LabelX8.TabIndex = 8
        Me.LabelX8.Text = "Soumis A Impots :"
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
        Me.libelle1.Location = New System.Drawing.Point(135, 62)
        Me.libelle1.Name = "libelle1"
        Me.libelle1.Size = New System.Drawing.Size(307, 25)
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
        Me.code1.Location = New System.Drawing.Point(135, 32)
        Me.code1.Name = "code1"
        Me.code1.Size = New System.Drawing.Size(198, 25)
        Me.code1.TabIndex = 6
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.MBA.My.Resources.Resources.add_button
        Me.ButtonX1.Location = New System.Drawing.Point(557, 238)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(270, 23)
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
        Me.LabelX2.Location = New System.Drawing.Point(6, 64)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(100, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Libellé :"
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
        Me.LabelX1.Text = "Code :"
        '
        'CPdg
        '
        Me.CPdg.ContextMenuStrip = Me.ContextMenuStrip1
        Me.CPdg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CPdg.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White
        Me.CPdg.EmbeddedNavigator.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CPdg.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.CPdg.EmbeddedNavigator.Appearance.Options.UseForeColor = True
        Me.CPdg.Location = New System.Drawing.Point(0, 284)
        Me.CPdg.LookAndFeel.SkinName = "Office 2013"
        Me.CPdg.LookAndFeel.UseDefaultLookAndFeel = False
        Me.CPdg.MainView = Me.GridView1
        Me.CPdg.Name = "CPdg"
        Me.CPdg.Size = New System.Drawing.Size(1392, 362)
        Me.CPdg.TabIndex = 4
        Me.CPdg.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModifierToolStripMenuItem, Me.SupprimerToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(130, 48)
        '
        'ModifierToolStripMenuItem
        '
        Me.ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        Me.ModifierToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.ModifierToolStripMenuItem.Text = "Modifier"
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.SupprimerToolStripMenuItem.Text = "Supprimer"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.CPdg
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'GetRubriqueBW
        '
        Me.GetRubriqueBW.WorkerReportsProgress = True
        Me.GetRubriqueBW.WorkerSupportsCancellation = True
        '
        'FormCodePaie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1392, 646)
        Me.Controls.Add(Me.CPdg)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCodePaie"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Les Rubriques de Paie"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.CPdg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents libelle1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents code1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend CPdg As DevExpress.XtraGrid.GridControl
    Friend GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tiers As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents prv As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tauxpu As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ModifierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fix As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents codcalc As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents soumits As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents sens As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents soumiss As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents prorata As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem15 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem16 As DevComponents.Editors.ComboItem
    Friend WithEvents imput As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents type As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem26 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem27 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem28 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem29 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem30 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem31 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem32 As DevComponents.Editors.ComboItem
    Friend WithEvents rg As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem17 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem18 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem19 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem20 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem21 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem22 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem23 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem24 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem25 As DevComponents.Editors.ComboItem
    Friend WithEvents codret As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem13 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem14 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem10 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem11 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem12 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem51 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem52 As DevComponents.Editors.ComboItem
    Friend WithEvents GetRubriqueBW As System.ComponentModel.BackgroundWorker
End Class
