<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RapportFichSuiveuse
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
        Me.exportBtn = New DevComponents.DotNetBar.ButtonX()
        Me.errorLbl = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.clientcombo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.RechercheBtn = New DevComponents.DotNetBar.ButtonX()
        Me.RichEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.exportBtn)
        Me.GroupBox1.Controls.Add(Me.errorLbl)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.clientcombo)
        Me.GroupBox1.Controls.Add(Me.RechercheBtn)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1243, 62)
        Me.GroupBox1.TabIndex = 124
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "La fiche suiveuse :"
        '
        'exportBtn
        '
        Me.exportBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.exportBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.exportBtn.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exportBtn.Image = Global.MBA.My.Resources.Resources.order_export
        Me.exportBtn.Location = New System.Drawing.Point(878, 22)
        Me.exportBtn.Name = "exportBtn"
        Me.exportBtn.Size = New System.Drawing.Size(97, 23)
        Me.exportBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.exportBtn.TabIndex = 19
        Me.exportBtn.Text = "Exporter"
        Me.exportBtn.Visible = False
        '
        'errorLbl
        '
        Me.errorLbl.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.errorLbl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.errorLbl.ForeColor = System.Drawing.Color.Black
        Me.errorLbl.Location = New System.Drawing.Point(312, 22)
        Me.errorLbl.Name = "errorLbl"
        Me.errorLbl.Size = New System.Drawing.Size(328, 23)
        Me.errorLbl.TabIndex = 18
        Me.errorLbl.Text = "Cette Affaire n'as pas de Facture ou le code affaire est erroné !"
        Me.errorLbl.Visible = False
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(12, 22)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(72, 23)
        Me.LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.LabelX1.TabIndex = 13
        Me.LabelX1.Text = "Nom client :"
        '
        'clientcombo
        '
        Me.clientcombo.DisplayMember = "Text"
        Me.clientcombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.clientcombo.ForeColor = System.Drawing.Color.Black
        Me.clientcombo.FormattingEnabled = True
        Me.clientcombo.ItemHeight = 17
        Me.clientcombo.Location = New System.Drawing.Point(90, 22)
        Me.clientcombo.Name = "clientcombo"
        Me.clientcombo.Size = New System.Drawing.Size(203, 23)
        Me.clientcombo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.clientcombo.TabIndex = 12
        '
        'RechercheBtn
        '
        Me.RechercheBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.RechercheBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.RechercheBtn.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RechercheBtn.Image = Global.MBA.My.Resources.Resources.order_search
        Me.RechercheBtn.Location = New System.Drawing.Point(680, 22)
        Me.RechercheBtn.Name = "RechercheBtn"
        Me.RechercheBtn.Size = New System.Drawing.Size(192, 23)
        Me.RechercheBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RechercheBtn.TabIndex = 10
        Me.RechercheBtn.Text = "Afficher La liste des factures "
        '
        'RichEditControl1
        '
        Me.RichEditControl1.Appearance.Text.ForeColor = System.Drawing.Color.Black
        Me.RichEditControl1.Appearance.Text.Options.UseForeColor = True
        Me.RichEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichEditControl1.EnableToolTips = True
        Me.RichEditControl1.Location = New System.Drawing.Point(0, 62)
        Me.RichEditControl1.LookAndFeel.SkinName = "Office 2013"
        Me.RichEditControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.RichEditControl1.Name = "RichEditControl1"
        Me.RichEditControl1.Size = New System.Drawing.Size(1243, 643)
        Me.RichEditControl1.TabIndex = 125
        '
        'RapportFichSuiveuse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 705)
        Me.Controls.Add(Me.RichEditControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RapportFichSuiveuse"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rapport fiche suiveuse"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents exportBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents errorLbl As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents clientcombo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents RechercheBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents RichEditControl1 As DevExpress.XtraRichEdit.RichEditControl
End Class
