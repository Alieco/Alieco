<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MentionObservation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MentionObservation))
        Me.observation = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX6 = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'observation
        '
        Me.observation.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.observation.Border.Class = "TextBoxBorder"
        Me.observation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.observation.ForeColor = System.Drawing.Color.Black
        Me.observation.Location = New System.Drawing.Point(12, 12)
        Me.observation.Multiline = True
        Me.observation.Name = "observation"
        Me.observation.Size = New System.Drawing.Size(349, 95)
        Me.observation.TabIndex = 0
        '
        'ButtonX6
        '
        Me.ButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX6.Image = CType(resources.GetObject("ButtonX6.Image"), System.Drawing.Image)
        Me.ButtonX6.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.ButtonX6.Location = New System.Drawing.Point(37, 122)
        Me.ButtonX6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonX6.Name = "ButtonX6"
        Me.ButtonX6.Size = New System.Drawing.Size(261, 24)
        Me.ButtonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX6.TabIndex = 307
        Me.ButtonX6.Text = "Enregistrer"
        '
        'MentionObservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 159)
        Me.Controls.Add(Me.ButtonX6)
        Me.Controls.Add(Me.observation)
        Me.DoubleBuffered = True
        Me.Name = "MentionObservation"
        Me.ShowIcon = False
        Me.Text = "Mentionner une observation"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents observation As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ButtonX6 As DevComponents.DotNetBar.ButtonX
End Class
