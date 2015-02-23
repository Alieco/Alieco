<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class foncionnaireEnDepart
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.volentaire = New System.Windows.Forms.RadioButton()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.licenciement = New System.Windows.Forms.RadioButton()
        Me.retraite = New System.Windows.Forms.RadioButton()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.dgv1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.volentaire)
        Me.GroupBox1.Controls.Add(Me.ButtonX2)
        Me.GroupBox1.Controls.Add(Me.licenciement)
        Me.GroupBox1.Controls.Add(Me.retraite)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1181, 91)
        Me.GroupBox1.TabIndex = 113
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Les Fonctionnaire en Depart :"
        '
        'volentaire
        '
        Me.volentaire.AutoSize = True
        Me.volentaire.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.volentaire.Location = New System.Drawing.Point(391, 38)
        Me.volentaire.Name = "volentaire"
        Me.volentaire.Size = New System.Drawing.Size(108, 17)
        Me.volentaire.TabIndex = 9
        Me.volentaire.Text = "Depart volentaire"
        Me.volentaire.UseVisualStyleBackColor = True
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = Global.MBA.My.Resources.Resources.search
        Me.ButtonX2.Location = New System.Drawing.Point(558, 35)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(159, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 8
        Me.ButtonX2.Text = "Chercher"
        '
        'licenciement
        '
        Me.licenciement.AutoSize = True
        Me.licenciement.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.licenciement.Location = New System.Drawing.Point(286, 38)
        Me.licenciement.Name = "licenciement"
        Me.licenciement.Size = New System.Drawing.Size(85, 17)
        Me.licenciement.TabIndex = 7
        Me.licenciement.Text = "Licenciement"
        Me.licenciement.UseVisualStyleBackColor = True
        '
        'retraite
        '
        Me.retraite.AutoSize = True
        Me.retraite.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.retraite.Location = New System.Drawing.Point(201, 38)
        Me.retraite.Name = "retraite"
        Me.retraite.Size = New System.Drawing.Size(63, 17)
        Me.retraite.TabIndex = 6
        Me.retraite.Text = "Retraite"
        Me.retraite.UseVisualStyleBackColor = True
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(21, 35)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(284, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Choisir un <b>Motif </b>:"
        '
        'dgv1
        '
        Me.dgv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv1.Location = New System.Drawing.Point(0, 91)
        Me.dgv1.LookAndFeel.SkinName = "Office 2013"
        Me.dgv1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.dgv1.MainView = Me.GridView1
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(1181, 515)
        Me.dgv1.TabIndex = 114
        Me.dgv1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.dgv1
        Me.GridView1.Name = "GridView1"
        '
        'foncionnaireEnDepart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 606)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Name = "foncionnaireEnDepart"
        Me.ShowIcon = False
        Me.Text = "Foncionnaire En Depart"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents volentaire As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents licenciement As System.Windows.Forms.RadioButton
    Friend WithEvents retraite As System.Windows.Forms.RadioButton
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgv1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
