Imports DevComponents.DotNetBar
Imports DevExpress.XtraGrid.Views.Grid

Public Class ListClientfr
    Dim sql As New SQLControl
    Private dt As DataTable
    Sub reload()
        Try
            Dim s As String = ""
            Dim s1 As String = ""
            Dim utilisateur As String = ""
            dt = New DataTable
            dt.Columns.Add("Code client")
            dt.Columns.Add("Filiere")
            dt.Columns.Add("Raison sociale")
            dt.Columns.Add("Nom client")
            dt.Columns.Add("Description")
            dt.Columns.Add("contrainte")
            dt.Columns.Add("Delai de reponse")
            dt.Columns.Add("Charge d'affaire")
            dt.Columns.Add("Date d'enregistrement")
            dt.Columns.Add("Etat de l'offre")
            Dim i = 0
            If IsConnected("SELECT DISTINCT commercial_client.idclient as 'Code client',user,user_id,filière as 'Filiere',RaisonSocial as 'Raison sociale',NomClient as 'Nom client',Description_Consult as 'Description',contrainte,delai_reponse as 'Delai de reponse',fullname as 'Charge d\'affaire',DateEnregistrement as 'Date d\'enregistrement',valide FROM commercial_client,users where user=user_id", False) = True Then
                If myDR.HasRows = True Then
                    While myDR.Read
                        'commercial_offre.idclient=commercial_client.idclient and 
                        ',commercial_offre.valide
                        'commercial_offre,
                        ''MsgBox("Le user: " & myDR("user").ToString & "Le user_id est: " & myDR("user_id").ToString)
                        Dim row As DataRow = dt.NewRow()
                        row(0) = myDR("Code client").ToString
                        row(1) = myDR("Filiere").ToString
                        row(2) = myDR("Raison sociale").ToString
                        row(3) = myDR("Nom client").ToString
                        row(4) = myDR("Description").ToString
                        row(5) = myDR("contrainte").ToString
                        row(6) = myDR("Delai de reponse").ToString
                        row(7) = myDR("Charge d'affaire").ToString
                        row(8) = myDR("Date d'enregistrement").ToString
                        If myDR("valide") = "0" Then
                            row(9) = "Offre non établi"
                        Else
                            row(9) = "Offre établi"
                        End If
                        dt.Rows.Add(row)
                        i += 1
                    End While
                End If
            End If
                        dgcl.DataSource = dt
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            reload()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            Dim s As New SaveFileDialog
            s.DefaultExt = "*.xlsx"
            s.Title = "Choisissez le nom de fichier d'enregistrement"
            s.Filter = "Excel 2010 | *.xlsx"
            If s.ShowDialog = Windows.Forms.DialogResult.OK Then
                dgcl.ExportToXlsx(s.FileName)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub GoogleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoogleToolStripMenuItem.Click
        Try
            reload()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub AjouterUnNouveauClientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterUnNouveauClientToolStripMenuItem.Click
        Try
            AjoutClient.MdiParent = Mainfrm
            AjoutClient.Show()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ModifierLeClientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierLeClientToolStripMenuItem.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner un client avant de cliquer modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' MsgBox(GridView1.GetFocusedRowCellValue("Code client").ToString())
                EditClient.Text = "Modification Client " & GridView1.GetFocusedRowCellValue("Code client").ToString()
                EditClient.idclient = GridView1.GetFocusedRowCellValue("Code client").ToString()
                'MsgBox(GridView1.GetFocusedRowCellValue("NRC").ToString())
                EditClient.MdiParent = Mainfrm
                EditClient.Show()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub SupprimerLeClientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerLeClientToolStripMenuItem.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner un client avant de cliquer supprimer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim m = GridView1.GetFocusedRowCellValue("Code client").ToString()

                If m <> Nothing Then
                    If MessageBoxEx.Show("Vous voullez vraiment supprimer le client ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        IsConnected("Delete from commercial_client  WHERE idclient=" & m, True)
                        reload()
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub GridView1_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Try
            If GridView1.SelectedRowsCount > 0 Then
                SupprimerLeClientToolStripMenuItem.Enabled = True
                ModifierLeClientToolStripMenuItem.Enabled = True
            Else
                SupprimerLeClientToolStripMenuItem.Enabled = False
                ModifierLeClientToolStripMenuItem.Enabled = False
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ListClientfr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If GridView1.SelectedRowsCount > 0 Then
                SupprimerLeClientToolStripMenuItem.Enabled = True
                ModifierLeClientToolStripMenuItem.Enabled = True
            Else
                SupprimerLeClientToolStripMenuItem.Enabled = False
                ModifierLeClientToolStripMenuItem.Enabled = False
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner un client avant de cliquer Imprimer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Dim row = GridView1.GetFocusedRowCellValue("idclient")
                FicheClient.Text = "Fiche de Client "
                'FicheClient.rs.Text = GridView1.GetFocusedRowCellValue("idclient")
                'MsgBox(GridView1.GetFocusedRowCellValue("RaisonSocial").ToString())
                FicheClient.rais = GridView1.GetFocusedRowCellValue("Raison sociale").ToString()
                FicheClient.MdiParent = Mainfrm
                FicheClient.Show()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub GridView1_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Try
            Dim View As GridView = sender
            If e.Column.FieldName = "Etat de l'offre" Then
                Dim Etat As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Etat de l'offre"))
                If Etat = "Offre est établi" Then
                    e.Appearance.BackColor = Color.Lime
                    e.Appearance.BackColor2 = Color.LightGreen
                Else : e.Appearance.BackColor = Color.Yellow
                    e.Appearance.BackColor2 = Color.LightYellow
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class