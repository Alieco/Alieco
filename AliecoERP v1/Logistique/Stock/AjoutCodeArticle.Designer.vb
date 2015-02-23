<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjoutCodeArticle
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.compte = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.sfamille = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.um = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.rayon = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.desig = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.codearticle = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ajout = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(21, 109)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 17)
        Me.Label15.TabIndex = 100
        Me.Label15.Text = "Désignation :"
        '
        'compte
        '
        Me.compte.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.compte.Border.Class = "TextBoxBorder"
        Me.compte.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.compte.ForeColor = System.Drawing.Color.Black
        Me.compte.Location = New System.Drawing.Point(121, 25)
        Me.compte.Name = "compte"
        Me.compte.Size = New System.Drawing.Size(206, 25)
        Me.compte.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.sfamille)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.um)
        Me.GroupBox1.Controls.Add(Me.rayon)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.LabelX12)
        Me.GroupBox1.Controls.Add(Me.desig)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.compte)
        Me.GroupBox1.Controls.Add(Me.codearticle)
        Me.GroupBox1.Controls.Add(Me.ajout)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 299)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ajouter le code d'article :"
        '
        'sfamille
        '
        Me.sfamille.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.sfamille.Border.Class = "TextBoxBorder"
        Me.sfamille.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sfamille.ForeColor = System.Drawing.Color.Black
        Me.sfamille.Location = New System.Drawing.Point(121, 157)
        Me.sfamille.Name = "sfamille"
        Me.sfamille.Size = New System.Drawing.Size(206, 25)
        Me.sfamille.TabIndex = 186
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(24, 156)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(81, 23)
        Me.LabelX4.TabIndex = 185
        Me.LabelX4.Text = "S/famille :"
        '
        'um
        '
        Me.um.DisplayMember = "Text"
        Me.um.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.um.FormattingEnabled = True
        Me.um.ItemHeight = 19
        Me.um.Location = New System.Drawing.Point(121, 188)
        Me.um.Name = "um"
        Me.um.Size = New System.Drawing.Size(206, 25)
        Me.um.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.um.TabIndex = 184
        '
        'rayon
        '
        Me.rayon.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.rayon.Border.Class = "TextBoxBorder"
        Me.rayon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rayon.ForeColor = System.Drawing.Color.Black
        Me.rayon.Location = New System.Drawing.Point(121, 224)
        Me.rayon.Name = "rayon"
        Me.rayon.Size = New System.Drawing.Size(206, 25)
        Me.rayon.TabIndex = 183
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(24, 226)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(81, 23)
        Me.LabelX3.TabIndex = 182
        Me.LabelX3.Text = "Rayon :"
        '
        'LabelX12
        '
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Location = New System.Drawing.Point(24, 188)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(81, 23)
        Me.LabelX12.TabIndex = 181
        Me.LabelX12.Text = "UM :"
        '
        'desig
        '
        Me.desig.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.desig.Border.Class = "TextBoxBorder"
        Me.desig.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.desig.ForeColor = System.Drawing.Color.Black
        Me.desig.Location = New System.Drawing.Point(121, 98)
        Me.desig.Multiline = True
        Me.desig.Name = "desig"
        Me.desig.Size = New System.Drawing.Size(206, 50)
        Me.desig.TabIndex = 180
        '
        'codearticle
        '
        Me.codearticle.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.codearticle.Border.Class = "TextBoxBorder"
        Me.codearticle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.codearticle.ForeColor = System.Drawing.Color.Black
        Me.codearticle.Location = New System.Drawing.Point(121, 65)
        Me.codearticle.Name = "codearticle"
        Me.codearticle.Size = New System.Drawing.Size(206, 25)
        Me.codearticle.TabIndex = 6
        '
        'ajout
        '
        Me.ajout.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ajout.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ajout.Image = Global.MBA.My.Resources.Resources.add_button
        Me.ajout.Location = New System.Drawing.Point(261, 259)
        Me.ajout.Name = "ajout"
        Me.ajout.Size = New System.Drawing.Size(180, 23)
        Me.ajout.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ajout.TabIndex = 5
        Me.ajout.Text = "Ajouter"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(24, 24)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(91, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Compte  :"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(24, 65)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(91, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Code Article :"
        '
        'AjoutCodeArticle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 311)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AjoutCodeArticle"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajout Code Article"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents compte As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ajout As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents desig As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents codearticle As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents um As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents rayon As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents sfamille As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
End Class
