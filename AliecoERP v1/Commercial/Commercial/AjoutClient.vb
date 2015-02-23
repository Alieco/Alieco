Imports DevComponents.DotNetBar

Public Class AjoutClient
    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        'IsConnected(" select * from commercial_client WHERE  NRC='" & nRC.Text & "'", False)
        'If myDR.HasRows = True Then
        '    MessageBoxEx.Show("le N� Registre Commerce R.C  existe d�ja dans la list des clients", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        ''If nconslt.Text = "" Then
        ''    MessageBoxEx.Show("Vous avez laiss� le  N� Consultation vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ''    Exit Sub
        ''End If
        'If nRC.Text = "" Then
        '    MessageBoxEx.Show("Vous avez laiss� le N� Registre Commerce R.C vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        'If nomcl.Text = "" Then
        '    MessageBoxEx.Show("Vous avez laiss� le Nom du client ou son repr�sentant vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        'If datenais.Text = "" Then
        '    MessageBoxEx.Show("Vous avez laiss� la date vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        'If numtel.Text = "" Then
        '    MessageBoxEx.Show("Vous avez laiss� le num�ro de t�l�phone vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        'If secteur.Text = "" Then
        '    MessageBoxEx.Show("Vous avez laiss� le champ secteur vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        ''If email.Text = "" Then
        ''    MessageBoxEx.Show("Vous avez laiss� le champ Email vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ''    Exit Sub
        ''End If
        'If rs.Text = "" Then
        '    MessageBoxEx.Show("Vous avez laiss� le champ Raison social vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        'If adresse.Text = "" Then
        '    MessageBoxEx.Show("Vous avez laiss� le champ Adresse vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        'If fonction.Text = "" Then
        '    MessageBoxEx.Show("Vous avez laiss� le champ fonction vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        'If NIF.Text = "" Then
        '    MessageBoxEx.Show("Vous avez laiss� le N� Identification fiscale vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        'If NAI.Text = "" Then
        '    MessageBoxEx.Show("Vous avez laiss� le N� Article d�imposition vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        'If description.Text = "" Then
        '    MessageBoxEx.Show("Vous avez laiss� le champ d�finition de la consultation vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        'If obs.Text = "" Then
        '    MessageBoxEx.Show("Vous avez laiss� le champ Observation vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        Try
            Dim q = "INSERT INTO commercial_client(codeCl,fili�re,nconsult,Date,NomClient,Fonction,RaisonSocial,Adresse,NumTel,Fax,NRC,NIdentif_fiscale,NArticle_imposition,Description_Consult,Observation,Email,responsable,contrainte,faisabilite,delai_reponse,secteur, user,DateEnregistrement,valide) values ('" & code.Text & "', '" & mysql_escape_string(activite.Text) & "', '" & mysql_escape_string(nconslt.Text) & "', '" & datenais.Value.ToString("yyyy-MM-dd") & "','" & mysql_escape_string(nomcl.Text) & "','" & mysql_escape_string(fonction.Text) & "','" & mysql_escape_string(rs.Text) & "','" & mysql_escape_string(adresse.Text) & "','" & mysql_escape_string(numtel.Text) & "','" & mysql_escape_string(fax.Text) & "','" & mysql_escape_string(nRC.Text) & "','" & mysql_escape_string(NIF.Text) & "','" & mysql_escape_string(NAI.Text) & "','" & mysql_escape_string(description.Text) & "','" & mysql_escape_string(obs.Text) & "','" & email.Text & "','" & mysql_escape_string(responsable.Text) & "','" & mysql_escape_string(contrainte.Text) & "','" & mysql_escape_string(faisabilite.Text) & "','" & delai.Value.ToString("yyyy-MM-dd") & "','" & mysql_escape_string(secteur.Text) & "','" & user_id & "',Now(),'0')"
            If IsConnected(q, False) Then
                MessageBoxEx.Show("Le client a bien �t� enregistrer", "Succ�s", MessageBoxButtons.OK, MessageBoxIcon.Information)
                nRC.Clear()
                activite.Clear()
                code.Clear()
                nconslt.Clear()
                datenais.Value = Nothing
                nomcl.Clear()
                fonction.Clear()
                rs.Clear()
                adresse.Clear()
                numtel.Text = ""
                fax.Clear()
                email.Clear()
                NIF.Clear()
                NAI.Clear()
                description.Clear()
                obs.Clear()
                responsable.Clear()
                contrainte.Clear()
                faisabilite.Clear()
                secteur.Text = ""
                delai.Value = Nothing
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub activite_TextChanged(sender As System.Object, e As System.EventArgs) Handles activite.TextChanged
        Try
            Dim MySource As New AutoCompleteStringCollection()

            If IsConnected("select distinct fili�re from commercial_client", False) Then
                If myDR.HasRows Then
                    While myDR.Read
                        MySource.Add(myDR("fili�re"))
                    End While
                End If
            End If
            activite.AutoCompleteCustomSource = MySource
            activite.AutoCompleteMode = AutoCompleteMode.Suggest
            activite.AutoCompleteSource = AutoCompleteSource.CustomSource
            activite.Visible = True
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class