<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjoutCompte
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
        Me.famille = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.sousfamille = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.compte = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ajout = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'famille
        '
        Me.famille.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.famille.Border.Class = "TextBoxBorder"
        Me.famille.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.famille.ForeColor = System.Drawing.Color.Black
        Me.famille.Location = New System.Drawing.Point(121, 55)
        Me.famille.Name = "famille"
        Me.famille.Size = New System.Drawing.Size(206, 25)
        Me.famille.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.sousfamille)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.compte)
        Me.GroupBox1.Controls.Add(Me.famille)
        Me.GroupBox1.Controls.Add(Me.ajout)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 158)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ajouter le compte :"
        '
        'sousfamille
        '
        Me.sousfamille.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.sousfamille.Border.Class = "TextBoxBorder"
        Me.sousfamille.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sousfamille.ForeColor = System.Drawing.Color.Black
        Me.sousfamille.Location = New System.Drawing.Point(121, 84)
        Me.sousfamille.Name = "sousfamille"
        Me.sousfamille.Size = New System.Drawing.Size(206, 25)
        Me.sousfamille.TabIndex = 9
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(24, 84)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(91, 23)
        Me.LabelX3.TabIndex = 8
        Me.LabelX3.Text = "Sous famille :"
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
        Me.compte.Location = New System.Drawing.Point(121, 26)
        Me.compte.Name = "compte"
        Me.compte.Size = New System.Drawing.Size(206, 25)
        Me.compte.TabIndex = 7
        '
        'ajout
        '
        Me.ajout.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ajout.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ajout.Image = Global.MBA.My.Resources.Resources.add_button
        Me.ajout.Location = New System.Drawing.Point(287, 127)
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
        Me.LabelX2.Location = New System.Drawing.Point(24, 26)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(107, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Compte  :"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(24, 55)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(91, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Famille :"
        '
        'AjoutCompte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 212)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AjoutCompte"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajout Compte"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents famille As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents compte As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ajout As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents sousfamille As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
End Class
