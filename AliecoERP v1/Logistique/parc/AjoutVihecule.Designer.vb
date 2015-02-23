<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjoutVihecule
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
        Me.pathTxt = New System.Windows.Forms.TextBox()
        Me.ImgVihecule = New System.Windows.Forms.PictureBox()
        Me.LoadImgBtn = New DevComponents.DotNetBar.ButtonX()
        Me.MarkTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.NomTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.MatriculeTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.EngineCmb = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.discriTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.AjoutBtn = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ImgVihecule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.pathTxt)
        Me.GroupBox1.Controls.Add(Me.ImgVihecule)
        Me.GroupBox1.Controls.Add(Me.LoadImgBtn)
        Me.GroupBox1.Controls.Add(Me.MarkTxt)
        Me.GroupBox1.Controls.Add(Me.NomTxt)
        Me.GroupBox1.Controls.Add(Me.MatriculeTxt)
        Me.GroupBox1.Controls.Add(Me.EngineCmb)
        Me.GroupBox1.Controls.Add(Me.discriTxt)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.AjoutBtn)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(551, 317)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ajouter un vihécule"
        '
        'pathTxt
        '
        Me.pathTxt.BackColor = System.Drawing.Color.White
        Me.pathTxt.ForeColor = System.Drawing.Color.Black
        Me.pathTxt.Location = New System.Drawing.Point(494, 259)
        Me.pathTxt.Name = "pathTxt"
        Me.pathTxt.Size = New System.Drawing.Size(10, 23)
        Me.pathTxt.TabIndex = 393
        Me.pathTxt.Visible = False
        '
        'ImgVihecule
        '
        Me.ImgVihecule.BackColor = System.Drawing.Color.White
        Me.ImgVihecule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImgVihecule.ForeColor = System.Drawing.Color.Black
        Me.ImgVihecule.Location = New System.Drawing.Point(324, 37)
        Me.ImgVihecule.Name = "ImgVihecule"
        Me.ImgVihecule.Size = New System.Drawing.Size(180, 158)
        Me.ImgVihecule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgVihecule.TabIndex = 392
        Me.ImgVihecule.TabStop = False
        '
        'LoadImgBtn
        '
        Me.LoadImgBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.LoadImgBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.LoadImgBtn.Image = Global.MBA.My.Resources.Resources.addvacation
        Me.LoadImgBtn.Location = New System.Drawing.Point(324, 201)
        Me.LoadImgBtn.Name = "LoadImgBtn"
        Me.LoadImgBtn.Size = New System.Drawing.Size(180, 23)
        Me.LoadImgBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LoadImgBtn.TabIndex = 391
        Me.LoadImgBtn.Text = "Ajouter une photo"
        '
        'MarkTxt
        '
        Me.MarkTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.MarkTxt.Border.Class = "TextBoxBorder"
        Me.MarkTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MarkTxt.ForeColor = System.Drawing.Color.Black
        Me.MarkTxt.Location = New System.Drawing.Point(19, 64)
        Me.MarkTxt.Name = "MarkTxt"
        Me.MarkTxt.Size = New System.Drawing.Size(299, 23)
        Me.MarkTxt.TabIndex = 390
        Me.MarkTxt.WatermarkText = "Marque"
        '
        'NomTxt
        '
        Me.NomTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.NomTxt.Border.Class = "TextBoxBorder"
        Me.NomTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NomTxt.ForeColor = System.Drawing.Color.Black
        Me.NomTxt.Location = New System.Drawing.Point(19, 35)
        Me.NomTxt.Name = "NomTxt"
        Me.NomTxt.Size = New System.Drawing.Size(299, 23)
        Me.NomTxt.TabIndex = 389
        Me.NomTxt.WatermarkText = "nom d vihécule..."
        '
        'MatriculeTxt
        '
        Me.MatriculeTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.MatriculeTxt.Border.Class = "TextBoxBorder"
        Me.MatriculeTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MatriculeTxt.ForeColor = System.Drawing.Color.Black
        Me.MatriculeTxt.Location = New System.Drawing.Point(19, 105)
        Me.MatriculeTxt.Name = "MatriculeTxt"
        Me.MatriculeTxt.Size = New System.Drawing.Size(299, 23)
        Me.MatriculeTxt.TabIndex = 382
        Me.MatriculeTxt.WatermarkText = "Matricule"
        '
        'EngineCmb
        '
        Me.EngineCmb.DisplayMember = "Text"
        Me.EngineCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.EngineCmb.ForeColor = System.Drawing.Color.Black
        Me.EngineCmb.FormattingEnabled = True
        Me.EngineCmb.ItemHeight = 17
        Me.EngineCmb.Items.AddRange(New Object() {Me.ComboItem4, Me.ComboItem5, Me.ComboItem6, Me.ComboItem1})
        Me.EngineCmb.Location = New System.Drawing.Point(72, 201)
        Me.EngineCmb.Name = "EngineCmb"
        Me.EngineCmb.Size = New System.Drawing.Size(246, 23)
        Me.EngineCmb.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.EngineCmb.TabIndex = 377
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Diesel"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "Essence"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "GPL"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Hybride"
        '
        'discriTxt
        '
        Me.discriTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.discriTxt.Border.Class = "TextBoxBorder"
        Me.discriTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.discriTxt.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discriTxt.ForeColor = System.Drawing.Color.Black
        Me.discriTxt.Location = New System.Drawing.Point(19, 134)
        Me.discriTxt.Multiline = True
        Me.discriTxt.Name = "discriTxt"
        Me.discriTxt.Size = New System.Drawing.Size(299, 64)
        Me.discriTxt.TabIndex = 374
        Me.discriTxt.WatermarkText = "remarque"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(16, 205)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 15)
        Me.Label9.TabIndex = 373
        Me.Label9.Text = "Energie :"
        '
        'AjoutBtn
        '
        Me.AjoutBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.AjoutBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.AjoutBtn.Image = Global.MBA.My.Resources.Resources.adde
        Me.AjoutBtn.Location = New System.Drawing.Point(19, 230)
        Me.AjoutBtn.Name = "AjoutBtn"
        Me.AjoutBtn.Size = New System.Drawing.Size(485, 23)
        Me.AjoutBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.AjoutBtn.TabIndex = 381
        Me.AjoutBtn.Text = "Ajouter a la liste"
        '
        'AjoutVihecule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 317)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AjoutVihecule"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajouter un vihécule"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ImgVihecule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NomTxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents MatriculeTxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents EngineCmb As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents discriTxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents AjoutBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ImgVihecule As System.Windows.Forms.PictureBox
    Friend WithEvents LoadImgBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents MarkTxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents pathTxt As System.Windows.Forms.TextBox
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
End Class
