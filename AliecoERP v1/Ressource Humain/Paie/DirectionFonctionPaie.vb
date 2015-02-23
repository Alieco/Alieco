Public Class DirectionFonctionPaie
    Dim sql As New SQLControl
    Dim dir As Integer = 0
    Dim fon As Integer = 0
    Public moianpr As String = ""
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            Dim s As New SaveFileDialog
            s.DefaultExt = "*.xlsx"
            s.Title = "Choisisez le nom de fichier d'enregistrement"
            s.Filter = "Excel 2010 | *.xlsx"
            If s.ShowDialog = Windows.Forms.DialogResult.OK Then
                dgv1.ExportToXlsx(s.FileName)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub searchbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchbtn.Click
        Try
            PictureBox1.Visible = True
            searchbtn.Enabled = False
            search()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub search()
        Try
            dgv1.DataSource = Nothing
            GridView1.ClearDocument()
            Dim moi1 = Moi.Text & Anne.Text
            Dim q As String = "SELECT distinct(paie_mensuel.Matricule), Nom, Prénom, Fonction, Direction, total_impots as 'total soumis A impots', total_ss as 'total soumis A S/S', retenue as 'I.R.G.' , net_payer as 'Net a payer' FROM Employes, paie_mensuel WHERE paie_mensuel.Matricule=Employes.Matricule and paie_mensuel.code='980' and paie_mensuel.type='P' and moi_annee='" & moi1 & "' and "
            If searchtxt.Text = String.Empty Then q += "1=1" Else q += "(paie_mensuel.Matricule LIKE '%" & searchtxt.Text & "%' OR Nom like '%" & searchtxt.Text & "%' OR Prénom like '%" & searchtxt.Text & "%')"
            If fonction.SelectedIndex > -1 Then q += " and Fonction like '%" & fonction.Text & "%'"
            If direction.SelectedIndex > -1 Then q += " and Direction  like '%" & direction.Text & "%'"
            'TextBoxX1.Text = q
            sql.RunQuery(q)
            If sql.SQLDS.Tables.Count > 0 Then dgv1.DataSource = sql.SQLDS.Tables(0)
            PictureBox1.Visible = False
            searchbtn.Enabled = True
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub DirectionFonctionPaie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'For i = 1 To 12
        '    Moi.Items.Add(i)
        'Next
        Try
            Anne.Items.Clear()
            For j = 2014 To 3014
                Anne.Items.Add(j)
            Next
            Moi.Text = Date.Now.ToString("MM")
            Anne.Text = Date.Now.ToString("yyyy")
            load_fonction()
            load_direction()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub load_fonction()
        Try
            fonction.Items.Clear()
            IsConnected("select distinct Fonction from employes", False)
            If myDR.HasRows Then
                While myDR.Read
                    fonction.Items.Add(myDR("Fonction"))
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub load_direction()
        Try
            direction.Items.Clear()
            IsConnected("select distinct Direction from employes", False)
            If myDR.HasRows Then
                While myDR.Read
                    direction.Items.Add(myDR("Direction"))
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class