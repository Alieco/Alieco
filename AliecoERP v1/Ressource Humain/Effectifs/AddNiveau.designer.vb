<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNiveau
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddNiveau))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SupprimerButton = New DevComponents.DotNetBar.ButtonX()
        Me.niv = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.SupprimerButton)
        Me.GroupBox1.Controls.Add(Me.niv)
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 150)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ajout d'un nouveau Niveau :"
        '
        'SupprimerButton
        '
        Me.SupprimerButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.SupprimerButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.SupprimerButton.Image = Global.MBA.My.Resources.Resources.delete
        Me.SupprimerButton.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.SupprimerButton.Location = New System.Drawing.Point(293, 108)
        Me.SupprimerButton.Name = "SupprimerButton"
        Me.SupprimerButton.Size = New System.Drawing.Size(156, 30)
        Me.SupprimerButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SupprimerButton.TabIndex = 123
        Me.SupprimerButton.Text = "Supprimer"
        '
        'niv
        '
        Me.niv.DisplayMember = "Text"
        Me.niv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.niv.FormattingEnabled = True
        Me.niv.ItemHeight = 16
        Me.niv.Location = New System.Drawing.Point(100, 33)
        Me.niv.Name = "niv"
        Me.niv.Size = New System.Drawing.Size(349, 22)
        Me.niv.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.niv.TabIndex = 120
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = CType(resources.GetObject("ButtonX1.Image"), System.Drawing.Image)
        Me.ButtonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.ButtonX1.Location = New System.Drawing.Point(293, 72)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(156, 30)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 119
        Me.ButtonX1.Text = "Enregistrer"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(10, 32)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(100, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Saisir un niveau :"
        '
        'AddNiveau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 157)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "AddNiveau"
        Me.ShowIcon = False
        Me.Text = "Ajouter un niveau"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents niv As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents SupprimerButton As DevComponents.DotNetBar.ButtonX
End Class
