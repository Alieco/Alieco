<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class archive1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(archive1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.SaveBtn = New DevComponents.DotNetBar.ButtonX()
        Me.SerachTxt = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Controls.Add(Me.SaveBtn)
        Me.GroupBox1.Controls.Add(Me.SerachTxt)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(917, 78)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Veuillez choisir:"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.MBA.My.Resources.Resources.order_ok
        Me.ButtonX1.Location = New System.Drawing.Point(487, 33)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(148, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 12
        Me.ButtonX1.Text = "Graver"
        '
        'SaveBtn
        '
        Me.SaveBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.SaveBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.SaveBtn.Image = Global.MBA.My.Resources.Resources.order_ok
        Me.SaveBtn.Location = New System.Drawing.Point(641, 33)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(148, 23)
        Me.SaveBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SaveBtn.TabIndex = 11
        Me.SaveBtn.Text = "Supprimer"
        '
        'SerachTxt
        '
        Me.SerachTxt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.SerachTxt.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.SerachTxt.Image = Global.MBA.My.Resources.Resources.order_search
        Me.SerachTxt.Location = New System.Drawing.Point(262, 33)
        Me.SerachTxt.Name = "SerachTxt"
        Me.SerachTxt.Size = New System.Drawing.Size(219, 23)
        Me.SerachTxt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SerachTxt.TabIndex = 10
        Me.SerachTxt.Text = "Afficher la liste des PCs a archiv�"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(12, 29)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(244, 27)
        Me.LabelX1.TabIndex = 8
        Me.LabelX1.Text = "Taille total des fichiers :"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(0, 78)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(917, 336)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Type"
        Me.ColumnHeader1.Width = 109
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Chemin"
        Me.ColumnHeader2.Width = 460
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Etat"
        Me.ColumnHeader3.Width = 268
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "folder.png")
        Me.ImageList1.Images.SetKeyName(1, "document_text.png")
        '
        'archive1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 414)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "archive1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Archive"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SaveBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SerachTxt As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
End Class
