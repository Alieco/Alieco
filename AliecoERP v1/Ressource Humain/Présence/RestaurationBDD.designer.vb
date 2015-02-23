<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RestaurationBDD
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.DGVsau = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Matricule = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Datef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Entrée1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sortie1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Entrée2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sortie2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Entrée3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sortie3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Absence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Heau = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Motif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVsau, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonX2)
        Me.GroupBox1.Controls.Add(Me.TextBoxX1)
        Me.GroupBox1.Controls.Add(Me.ButtonX1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1203, 87)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selectionner le fichier de présence  :"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = Global.MBA.My.Resources.Resources.database_save
        Me.ButtonX2.Location = New System.Drawing.Point(800, 36)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(232, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 2
        Me.ButtonX2.Text = "Enregistrer dans la base de donnée"
        '
        'TextBoxX1
        '
        Me.TextBoxX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX1.Location = New System.Drawing.Point(37, 36)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.Size = New System.Drawing.Size(486, 25)
        Me.TextBoxX1.TabIndex = 1
        Me.TextBoxX1.WatermarkImage = Global.MBA.My.Resources.Resources.database_add2
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.MBA.My.Resources.Resources.computer_browse
        Me.ButtonX1.Location = New System.Drawing.Point(539, 36)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(255, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 0
        Me.ButtonX1.Text = "Parcourir un fichier de sauvegarde .AP"
        '
        'DGVsau
        '
        Me.DGVsau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVsau.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVsau.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVsau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVsau.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Matricule, Me.Datef, Me.Entrée1, Me.Sortie1, Me.Entrée2, Me.Sortie2, Me.Entrée3, Me.Sortie3, Me.Absence, Me.Heau, Me.Motif})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVsau.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVsau.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVsau.EnableHeadersVisualStyles = False
        Me.DGVsau.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.DGVsau.Location = New System.Drawing.Point(0, 87)
        Me.DGVsau.Name = "DGVsau"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVsau.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVsau.Size = New System.Drawing.Size(1203, 492)
        Me.DGVsau.TabIndex = 2
        '
        'Matricule
        '
        Me.Matricule.HeaderText = "Matricule"
        Me.Matricule.Name = "Matricule"
        '
        'Datef
        '
        Me.Datef.HeaderText = "Date de présence"
        Me.Datef.Name = "Datef"
        '
        'Entrée1
        '
        Me.Entrée1.HeaderText = "Entrée"
        Me.Entrée1.Name = "Entrée1"
        '
        'Sortie1
        '
        Me.Sortie1.HeaderText = "Sortie"
        Me.Sortie1.Name = "Sortie1"
        '
        'Entrée2
        '
        Me.Entrée2.HeaderText = "Entrée"
        Me.Entrée2.Name = "Entrée2"
        '
        'Sortie2
        '
        Me.Sortie2.HeaderText = "Sortie"
        Me.Sortie2.Name = "Sortie2"
        '
        'Entrée3
        '
        Me.Entrée3.HeaderText = "Entrée"
        Me.Entrée3.Name = "Entrée3"
        '
        'Sortie3
        '
        Me.Sortie3.HeaderText = "Sortie"
        Me.Sortie3.Name = "Sortie3"
        '
        'Absence
        '
        Me.Absence.HeaderText = "Absence"
        Me.Absence.Name = "Absence"
        '
        'Heau
        '
        Me.Heau.HeaderText = "Heure Supplementaire"
        Me.Heau.Name = "Heau"
        '
        'Motif
        '
        Me.Motif.HeaderText = "Motif"
        Me.Motif.Name = "Motif"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'RestaurationBDD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1203, 579)
        Me.Controls.Add(Me.DGVsau)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Name = "RestaurationBDD"
        Me.ShowIcon = False
        Me.Text = "Restauration BDD"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGVsau, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGVsau As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Matricule As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Datef As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Entrée1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sortie1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Entrée2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sortie2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Entrée3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sortie3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Absence As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Heau As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Motif As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
