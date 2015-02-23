<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class styler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(styler))
        Me.ColorPickerButton1 = New DevComponents.DotNetBar.ColorPickerButton()
        Me.ColorPickerButton2 = New DevComponents.DotNetBar.ColorPickerButton()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'ColorPickerButton1
        '
        Me.ColorPickerButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ColorPickerButton1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ColorPickerButton1.Image = CType(resources.GetObject("ColorPickerButton1.Image"), System.Drawing.Image)
        Me.ColorPickerButton1.Location = New System.Drawing.Point(166, 31)
        Me.ColorPickerButton1.Name = "ColorPickerButton1"
        Me.ColorPickerButton1.SelectedColorImageRectangle = New System.Drawing.Rectangle(2, 2, 12, 12)
        Me.ColorPickerButton1.Size = New System.Drawing.Size(37, 23)
        Me.ColorPickerButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ColorPickerButton1.TabIndex = 1
        '
        'ColorPickerButton2
        '
        Me.ColorPickerButton2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ColorPickerButton2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ColorPickerButton2.Image = CType(resources.GetObject("ColorPickerButton2.Image"), System.Drawing.Image)
        Me.ColorPickerButton2.Location = New System.Drawing.Point(166, 60)
        Me.ColorPickerButton2.Name = "ColorPickerButton2"
        Me.ColorPickerButton2.SelectedColorImageRectangle = New System.Drawing.Rectangle(2, 2, 12, 12)
        Me.ColorPickerButton2.Size = New System.Drawing.Size(37, 23)
        Me.ColorPickerButton2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ColorPickerButton2.TabIndex = 2
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(33, 31)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(114, 23)
        Me.LabelX1.TabIndex = 3
        Me.LabelX1.Text = "Coulour de Principal"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(33, 60)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(114, 23)
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = "Coulour secondaire"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.BackColor = System.Drawing.Color.White
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(111, 105)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(92, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.SymbolSize = 12.0!
        Me.ButtonX1.TabIndex = 5
        Me.ButtonX1.Text = "Appliquer"
        Me.ButtonX1.Tooltip = "Appliquer le changement de coulour"
        '
        'styler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(221, 142)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.ColorPickerButton2)
        Me.Controls.Add(Me.ColorPickerButton1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "styler"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modifier la coulour Metro"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColorPickerButton1 As DevComponents.DotNetBar.ColorPickerButton
    Friend WithEvents ColorPickerButton2 As DevComponents.DotNetBar.ColorPickerButton
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
End Class
