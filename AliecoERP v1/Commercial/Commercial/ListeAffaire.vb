Imports MySql.Data.MySqlClient
Imports DevComponents.DotNetBar

Public Class ListeAffaire
    Dim sql As New SQLControl
    Private dt As DataTable
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            reload()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
        ' Pour connaitre le nom du PC
        'MsgBox(My.Computer.Name)
    End Sub
    Sub reload()
        Try
            Dim utilisateur As String = ""
            If user_id = 20 Or user_id = 1 Then
                If chargeaffaire.Text = "" Then
                    utilisateur = ""
                Else
                    utilisateur = "and fullname= '" & chargeaffaire.Text & "'"
                End If
            Else
                utilisateur = " and fullname= '" & user_id & "'"
            End If
            Dim row As DataRow
            dt = New DataTable
            dt.Columns.Add("N°")
            dt.Columns.Add("Client")
            dt.Columns.Add("Affaire")
            dt.Columns.Add("Désignation")
            dt.Columns.Add("Montant affaire")
            dt.Columns.Add("Créance")
            dt.Columns.Add("Etat affaire")
            Dim i = 0
            If IsConnected("SELECT nomcl,code_affaire FROM commercial_affaire,users WHERE users.user_id=charge_affaire " & utilisateur & " and entréedate between '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "' group by commercial_affaire.code", False) = True Then
                If myDR.HasRows = True Then
                    While myDR.Read
                        i += 1
                        row = dt.NewRow()
                        row(0) = i
                        row(1) = myDR("nomcl")
                        row(2) = myDR("code_affaire")
                        row(3) = ""
                        row(4) = ""
                        row(5) = ""
                        dt.Rows.Add(row)
                    End While
                End If
            End If
            dgoffre.DataSource = dt
            For i = 0 To GridView1.DataRowCount - 1
                Dim code As String = GridView1.GetRowCellValue(i, "Affaire").ToString()
                IsConnected("SELECT desig, Qt,totalttc from commercial_affaire_bordereauprix,commercial_affaire WHERE commercial_affaire.code_affaire=commercial_affaire_bordereauprix.code  and commercial_affaire.code_affaire='" & code & "'", False)
                If myDR.HasRows Then
                    While myDR.Read
                        GridView1.SetRowCellValue(i, "Montant affaire", IIf(myDR("totalttc").ToString = "", "", myDR("totalttc").ToString))
                        GridView1.SetRowCellValue(i, "Désignation", GridView1.GetRowCellValue(i, "Désignation") & IIf(GridView1.GetRowCellValue(i, "Désignation") = "", "", " + ") & IIf(myDR("Qt").ToString = "", 0, myDR("qt").ToString & " " & myDR("desig").ToString))
                    End While
                End If
            Next
            For i = 0 To GridView1.DataRowCount - 1
                Dim code As String = GridView1.GetRowCellValue(i, "Affaire").ToString()
                IsConnected("SELECT reglement FROM commercial_affaire_modalite WHERE code='" & code & "' ", False)
                If myDR.HasRows Then
                    While myDR.Read
                        If myDR("reglement").ToString <> "FAIT" Then
                            GridView1.SetRowCellValue(i, "Etat affaire", "En attente de paiement")
                        Else
                            GridView1.SetRowCellValue(i, "Etat affaire", "Soldée")
                        End If
                    End While
                End If
                IsConnected("SELECT sum(MantantFactureTTC) as montant FROM facturation_facture WHERE code_affaire='" & code & "' ", False)
                If myDR.HasRows Then
                    While myDR.Read
                        GridView1.SetRowCellValue(i, "Créance", (GridView1.GetRowCellValue(i, "Montant affaire").ToString() - IIf(myDR("montant").ToString = "", 0, myDR("montant").ToString)))
                    End While
                End If
            Next
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
    Private Sub ModifierLetatDeLaffaireToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierLetatDeLaffaireToolStripMenuItem.Click
        Try
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner une offre avant de cliquer modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                etatAffaireFrm.Text = "Modification d'etat de l'affaire " & GridView1.GetFocusedRowCellValue("Affaire").ToString()
                'EditOffre.code.Text = GridView1.GetFocusedRowCellValue("code").ToString()
                etatAffaireFrm.codeAffaire = GridView1.GetFocusedRowCellValue("Affaire").ToString()
                etatAffaireFrm.ShowDialog()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub ListeAffaire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            au.Value = Date.Now.Date
            Dim d As Date = Date.Today
            d = d.AddDays(-30)
            du.Value = d
            If user_id = 20 Or user_id = 1 Then
                LabelX3.Visible = True
                chargeaffaire.Visible = True
                load_chargeaffaire()
            Else
                LabelX3.Visible = False
                chargeaffaire.Visible = False
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub load_chargeaffaire()
        Try
            IsConnected("SELECT distinct fullname FROM commercial_affaire,users WHERE commercial_affaire.charge_affaire=users.user_id", False)
            If myDR.HasRows Then
                chargeaffaire.Items.Clear()
                While myDR.Read
                    chargeaffaire.Items.Add(myDR("fullname").ToString)
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class