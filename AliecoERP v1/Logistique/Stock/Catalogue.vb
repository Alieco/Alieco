Imports DevComponents.DotNetBar

Public Class Catalogue
    Dim quary As String = ""
    Dim erreur As Boolean = False
    Dim sql As New SQLControl
    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        AjoutCompte.ShowDialog()
    End Sub

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        AjoutCodeArticle.ShowDialog()
    End Sub

    Private Sub Catalogue_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        datenrg.Text = Date.Now.ToString("dd/MM/yyyy")
        IsConnected("select * from users where user_id ='" & user_id & "'", False)
        If myDR.HasRows Then
            While myDR.Read
                utilisateur.Text = myDR("fullname")
            End While
        End If
        ' total.Text = quantite.Text * prixunitaire.Text
        load_codearticle()
        load_compte()
        reload()
    End Sub
#Region "Loading"
    Private Sub load_codearticle()
        If IsConnected("SELECT DISTINCT codearticle FROM logistique_gestionstock_catcodart ", False) = True Then
            If myDR.HasRows = True Then
                codearticle.Items.Clear()
                While (myDR.Read())
                    codearticle.Items.Add(myDR("codearticle"))
                End While
            End If
        End If
    End Sub
    Private Sub reload()
        If sql.VerifiyConnection = True Then
            sql.RunQuery("select compte,codearticle,libelle,quantite,prixunitaire,total from Logistique_GestionStock_Catalogue")
            If sql.SQLDS.Tables.Count > 0 Then
                DGcat.DataSource = sql.SQLDS.Tables(0)
            End If
        End If
    End Sub
    Private Sub load_compte()
        If IsConnected("SELECT DISTINCT compte FROM logistique_gestionstock_catcompt", False) = True Then
            If myDR.HasRows = True Then
                compte.Items.Clear()
                While (myDR.Read())
                    compte.Items.Add(myDR("compte"))
                End While
            End If
        End If
    End Sub
#End Region

    Private Sub ajout_Click(sender As System.Object, e As System.EventArgs) Handles ajout.Click
        total.Text = quantite.Text * prixunitaire.Text
        If ajout.Text = "Ajouter" Then
            quary = "INSERT INTO Logistique_GestionStock_Catalogue VALUES(NULL,'" & datenrg.Text & "','" & total.Text & "','" & quantite.Text & "','" & prixunitaire.Text & "','" & utilisateur.Text & "','" & codearticle.Text & "','" & mysql_escape_string(libelle.Text) & "','" & sfamille.Text & "','" & um.Text & "','" & rayon.Text & "','" & compte.Text & "','" & sousfamille.Text & "','" & famille.Text & "')"
            Clipboard.SetText(quary)
            If IsConnected(quary, True) = False Then
                erreur = True
            End If
            If erreur = False Then
                MessageBoxEx.Show("Le'" & libelle.Text & "' a bien été enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                datenrg.Text = ""
                codearticle.Text = ""
                libelle.Text = ""
                famille.Text = ""
                sfamille.Text = ""
                sousfamille.Text = ""
                compte.Text = ""
                total.Clear()
                quantite.Text = ""
                prixunitaire.Text = ""
                um.Text = ""
                rayon.Text = ""
                utilisateur.Text = ""
            End If
            reload()
        ElseIf ajout.Text = "Modifier le Compte" Then
            IsConnected("DELETE FROM Logistique_GestionStock_Catalogue WHERE =codearticle'" & codearticle.Text & "' and compte='" & compte.Text & "'limit 1", True)
            quary = "update Logistique_GestionStock_Catalogue set total='" & total.Text & "',quantite='" & quantite.Text & "',prixunitaire'" & prixunitaire.Text & "',libelle='" & mysql_escape_string(libelle.Text) & "','" & sfamille.Text & "','" & um.Text & "','" & rayon.Text & "'where codearticle='" & codearticle.Text & "'and compte='" & compte.Text & "')"
            Clipboard.SetText(quary)
            If IsConnected(quary, True) = False Then
                erreur = True
            End If
            If erreur = False Then
                MessageBoxEx.Show("Le'" & libelle.Text & "' a bien été modifier", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                datenrg.Text = ""
                codearticle.Text = ""
                libelle.Text = ""
                famille.Text = ""
                sfamille.Text = ""
                sousfamille.Text = ""
                compte.Text = ""
                total.Clear()
                quantite.Text = ""
                prixunitaire.Text = ""
                um.Text = ""
                rayon.Text = ""
                utilisateur.Text = ""
            End If
            reload()
            ajout.Text = "Ajouter"
            ajout.Image = My.Resources.add
        End If
    End Sub

    Private Sub codearticle_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles codearticle.SelectedIndexChanged
        If codearticle.Text.Length < 13 And codearticle.SelectedIndex <> -1 Then
            IsConnected("select * from logistique_gestionstock_catcodart where codearticle='" & codearticle.Text & "'", False)
            If myDR.HasRows Then
                While myDR.Read
                    libelle.Text = myDR("libelle")
                    sfamille.Text = myDR("sfamille")
                    um.Text = myDR("um")
                    rayon.Text = myDR("rayon")
                End While
            End If

        Else : MessageBoxEx.Show("Le nombre '" & codearticle.Text & "'est depassé les 12 chiffres !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub compte_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles compte.SelectedIndexChanged
        If compte.Text.Length < 7 And compte.SelectedIndex <> -1 Then
            IsConnected("select * from logistique_gestionstock_catcompt where compte='" & compte.Text & "'", False)
            If myDR.HasRows Then
                While myDR.Read
                    famille.Text = myDR("famille")
                    sousfamille.Text = myDR("sousfamille")
                End While
            End If
        Else : MessageBoxEx.Show("Le nombre '" & compte.Text & "'est depassé les 6 chiffres !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ButtonX3_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX3.Click
        Dim s As New SaveFileDialog
        s.DefaultExt = "*.xlsx"
        s.Title = "Choisisez le nom de fichier d'enregistrement"
        s.Filter = "Excel 2010 | *.xlsx"
        If s.ShowDialog = Windows.Forms.DialogResult.OK Then
            DGcat.ExportToXlsx(s.FileName)
        End If
    End Sub

    Private Sub GoogleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GoogleToolStripMenuItem.Click
        reload()
    End Sub

    Private Sub ModifierLeFonctionnaireFonctionnaireToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModifierLeFonctionnaireFonctionnaireToolStripMenuItem.Click
        If GridView1.SelectedRowsCount = 0 Then
            MessageBoxEx.Show("Vous devez selectionner un catalogue avant de cliquer modifier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.Text = "Modification le catalogue " & GridView1.GetFocusedRowCellValue("compte").ToString()
            compte.Text = GridView1.GetFocusedRowCellValue("compte").ToString()
            codearticle.Text = GridView1.GetFocusedRowCellValue("codearticle").ToString()
        End If

        If compte.Text <> "" And codearticle.Text <> "" Then
            IsConnected("SELECT * FROM Logistique_GestionStock_Catalogue WHERE compte='" & compte.Text & "'and codearticle='" & codearticle.Text & "'", False)
            If myDR.HasRows = True Then
                While (myDR.Read)
                    Try
                        datenrg.Text = myDR("datenrg")
                        codearticle.Text = myDR("codearticle")
                        libelle.Text = myDR("libelle")
                        famille.Text = myDR("famille")
                        sfamille.Text = myDR("sfamille")
                        sousfamille.Text = myDR("sousfamille")
                        compte.Text = myDR("compte")
                        total.Text = myDR("total")
                        quantite.Text = myDR("quantite")
                        prixunitaire.Text = myDR("prixunitaire")
                        um.Text = myDR("um")
                        rayon.Text = myDR("rayon")
                        utilisateur.Text = myDR("utilisateur")
                    Catch ex As Exception
                    End Try
                End While
            End If
        End If
        ajout.Text = "Modifier le Compte" & compte.Text
        ajout.Image = My.Resources.edit
    End Sub
    Private Sub ToolStripTextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles ToolStripTextBox2.TextChanged
        DGcat.DataSource = Nothing
        GridView1.ClearDocument()
        Dim q As String = "SELECT compte,codearticle,libelle,quantite,prixunitaire,total FROM Logistique_GestionStock_Catalogue WHERE "
        If ToolStripTextBox2.Text = String.Empty Then q += "1=1" Else q += "(compte LIKE '%" & ToolStripTextBox2.Text & "%' OR codearticle like '%" & ToolStripTextBox2.Text & "%'OR libelle like '%" & ToolStripTextBox2.Text & "%'OR utilisateur like '%" & ToolStripTextBox2.Text & "%'OR datenrg like '%" & ToolStripTextBox2.Text & "%'OR sousfamille like '%" & ToolStripTextBox2.Text & "%')"
        sql.RunQuery(q)
        If sql.SQLDS.Tables.Count > 0 Then DGcat.DataSource = sql.SQLDS.Tables(0)

    End Sub
End Class