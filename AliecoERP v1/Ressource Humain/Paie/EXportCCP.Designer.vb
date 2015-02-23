<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EXportCCP
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
        Me.PathTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.OpenBtn = New DevComponents.DotNetBar.ButtonX()
        Me.SaveBtn = New DevComponents.DotNetBar.ButtonX()
        Me.ResultTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PathTxt)
        Me.GroupBox1.Controls.Add(Me.OpenBtn)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(739, 58)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "choisir un fichier .csv"
        '
        'PathTxt
        '
        Me.PathTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.PathTxt.Border.Class = "TextBoxBorder"
        Me.PathTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PathTxt.ForeColor = System.Drawing.Color.Black
        Me.PathTxt.Location = New System.Drawing.Point(21, 21)
        Me.PathTxt.Name = "PathTxt"
        Me.PathTxt.Size = New System.Drawing.Size(604, 22)
        Me.PathTxt.TabIndex = 1
        '
        'OpenBtn
        '
        Me.OpenBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.OpenBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.OpenBtn.Image = Global.MBA.My.Resources.Resources.search
        Me.OpenBtn.Location = New System.Drawing.Point(631, 21)
        Me.OpenBtn.Name = "OpenBtn"
        Me.OpenBtn.Size = New System.Drawing.Size(94, 23)
        Me.OpenBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.OpenBtn.TabIndex = 0
        Me.OpenBtn.Text = "Parcourir"
        '
        'SaveBtn
        '
        Me.SaveBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.SaveBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.SaveBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SaveBtn.Image = Global.MBA.My.Resources.Resources.save
        Me.SaveBtn.Location = New System.Drawing.Point(0, 428)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(739, 23)
        Me.SaveBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SaveBtn.TabIndex = 1
        Me.SaveBtn.Text = "Enregistrer "
        '
        'ResultTxt
        '
        Me.ResultTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.ResultTxt.Border.Class = "TextBoxBorder"
        Me.ResultTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ResultTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultTxt.ForeColor = System.Drawing.Color.Black
        Me.ResultTxt.Location = New System.Drawing.Point(0, 58)
        Me.ResultTxt.Multiline = True
        Me.ResultTxt.Name = "ResultTxt"
        Me.ResultTxt.Size = New System.Drawing.Size(739, 370)
        Me.ResultTxt.TabIndex = 2
        '
        'EXportCCP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 451)
        Me.Controls.Add(Me.ResultTxt)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EXportCCP"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exporter le fichier de CCP"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PathTxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents OpenBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SaveBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ResultTxt As DevComponents.DotNetBar.Controls.TextBoxX
End Class
