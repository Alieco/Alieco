<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajout_fonction
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.removeBtn = New DevComponents.DotNetBar.ButtonX()
        Me.fonctionCmb = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.EnregistrerBtn = New DevComponents.DotNetBar.ButtonX()
        Me.salaire = New DevComponents.DotNetBar.LabelX()
        Me.Echloncmb = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.categorycmb = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FonctionTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.removeBtn)
        Me.GroupBox1.Controls.Add(Me.fonctionCmb)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.EnregistrerBtn)
        Me.GroupBox1.Controls.Add(Me.salaire)
        Me.GroupBox1.Controls.Add(Me.Echloncmb)
        Me.GroupBox1.Controls.Add(Me.categorycmb)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.FonctionTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(1, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 282)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fonction"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(99, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "liste des fonctions"
        '
        'removeBtn
        '
        Me.removeBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.removeBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.removeBtn.Enabled = False
        Me.removeBtn.Image = Global.MBA.My.Resources.Resources.delete
        Me.removeBtn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.removeBtn.Location = New System.Drawing.Point(473, 32)
        Me.removeBtn.Name = "removeBtn"
        Me.removeBtn.Size = New System.Drawing.Size(24, 23)
        Me.removeBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.removeBtn.TabIndex = 123
        '
        'fonctionCmb
        '
        Me.fonctionCmb.AutoCompleteCustomSource.AddRange(New String() {"8", "9", "10"})
        Me.fonctionCmb.DisplayMember = "Text"
        Me.fonctionCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.fonctionCmb.ForeColor = System.Drawing.Color.Black
        Me.fonctionCmb.FormattingEnabled = True
        Me.fonctionCmb.ItemHeight = 17
        Me.fonctionCmb.Location = New System.Drawing.Point(102, 32)
        Me.fonctionCmb.Name = "fonctionCmb"
        Me.fonctionCmb.Size = New System.Drawing.Size(370, 23)
        Me.fonctionCmb.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.fonctionCmb.TabIndex = 122
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(144, 217)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(353, 28)
        Me.LabelX1.TabIndex = 121
        Me.LabelX1.Visible = False
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(17, 217)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(81, 30)
        Me.LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.LabelX2.TabIndex = 120
        Me.LabelX2.Text = "<b>Suggestion :</b><b></b>"
        Me.LabelX2.UseMnemonic = False
        Me.LabelX2.Visible = False
        '
        'EnregistrerBtn
        '
        Me.EnregistrerBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.EnregistrerBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.EnregistrerBtn.Enabled = False
        Me.EnregistrerBtn.Image = Global.MBA.My.Resources.Resources.factory_add
        Me.EnregistrerBtn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.EnregistrerBtn.Location = New System.Drawing.Point(281, 251)
        Me.EnregistrerBtn.Name = "EnregistrerBtn"
        Me.EnregistrerBtn.Size = New System.Drawing.Size(216, 25)
        Me.EnregistrerBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.EnregistrerBtn.TabIndex = 119
        Me.EnregistrerBtn.Text = "Enregistrer la nouvelle fonction"
        '
        'salaire
        '
        Me.salaire.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.salaire.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.salaire.Font = New System.Drawing.Font("Tahoma", 30.0!)
        Me.salaire.ForeColor = System.Drawing.Color.Black
        Me.salaire.Location = New System.Drawing.Point(144, 150)
        Me.salaire.Name = "salaire"
        Me.salaire.Size = New System.Drawing.Size(353, 61)
        Me.salaire.TabIndex = 17
        Me.salaire.Text = "<b></b>"
        '
        'Echloncmb
        '
        Me.Echloncmb.DisplayMember = "Text"
        Me.Echloncmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Echloncmb.ForeColor = System.Drawing.Color.Black
        Me.Echloncmb.FormattingEnabled = True
        Me.Echloncmb.ItemHeight = 17
        Me.Echloncmb.Location = New System.Drawing.Point(376, 112)
        Me.Echloncmb.Name = "Echloncmb"
        Me.Echloncmb.Size = New System.Drawing.Size(121, 23)
        Me.Echloncmb.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Echloncmb.TabIndex = 14
        '
        'categorycmb
        '
        Me.categorycmb.AutoCompleteCustomSource.AddRange(New String() {"8", "9", "10"})
        Me.categorycmb.DisplayMember = "Text"
        Me.categorycmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.categorycmb.ForeColor = System.Drawing.Color.Black
        Me.categorycmb.FormattingEnabled = True
        Me.categorycmb.ItemHeight = 17
        Me.categorycmb.Location = New System.Drawing.Point(102, 112)
        Me.categorycmb.Name = "categorycmb"
        Me.categorycmb.Size = New System.Drawing.Size(121, 23)
        Me.categorycmb.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.categorycmb.TabIndex = 14
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(17, 166)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(121, 30)
        Me.LabelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.LabelX3.TabIndex = 15
        Me.LabelX3.Text = "<b>Salaire de base :</b><b></b>"
        Me.LabelX3.UseMnemonic = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(278, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "N°Echelon :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(12, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "N°Categorie :"
        '
        'FonctionTxt
        '
        Me.FonctionTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.FonctionTxt.Border.Class = "TextBoxBorder"
        Me.FonctionTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.FonctionTxt.ForeColor = System.Drawing.Color.Black
        Me.FonctionTxt.Location = New System.Drawing.Point(102, 80)
        Me.FonctionTxt.Name = "FonctionTxt"
        Me.FonctionTxt.Size = New System.Drawing.Size(395, 23)
        Me.FonctionTxt.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Titre Fonction :"
        '
        'Ajout_fonction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 302)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ajout_fonction"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajout d'une fonction"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents salaire As DevComponents.DotNetBar.LabelX
    Friend WithEvents Echloncmb As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents categorycmb As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents FonctionTxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EnregistrerBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents removeBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents fonctionCmb As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
