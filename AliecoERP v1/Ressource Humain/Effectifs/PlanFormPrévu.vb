Imports DevComponents.DotNetBar

Public Class PlanFormPrévu
    Dim verif As Boolean = False
    Dim ds1 As Formationdst = New Formationdst
    Dim cr As FormationPrévu = New FormationPrévu
    Dim sql As New SQLControl
    Private Sub PlanFormPrévu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ButtonX1.Enabled = False
        load_nf()
        load_spec()
        'MySub()
    End Sub
#Region "function"
    Sub reload()
        If sql.VerifiyConnection = True Then
            sql.RunQuery("select Specialite,NatureFormation,EffectifPrevu,Alternance,Duree,DateDebut,CoutTTC,Lieu,year from planformation")
            If sql.SQLDS.Tables.Count > 0 Then
                GridControl1.DataSource = sql.SQLDS.Tables(0)
            End If
        End If
    End Sub
    Private Sub load_nf()
        If IsConnected("SELECT DISTINCT(NatureFormation) FROM Planformation ", False) = True Then
            If myDR.HasRows = True Then
                nf.Items.Clear()
                While (myDR.Read())
                    nf.Items.Add(myDR("NatureFormation"))
                End While
            End If
        End If
    End Sub
    Private Sub load_spec()
        If IsConnected("SELECT DISTINCT(Specialite) FROM Planformation ", False) = True Then
            If myDR.HasRows = True Then
                spec.Items.Clear()
                While (myDR.Read())
                    spec.Items.Add(myDR("Specialite"))
                End While
            End If
        End If
    End Sub
#End Region
    Sub MySub()
        ds1.EnforceConstraints = False
        Try
            ' Attempt to fill the dataset MainTable
            ds1.PFormation.Clear()
            IsConnected("SELECT Specialite,NatureFormation,EffectifPrevu,Alternance,Duree,DateDebut,CoutTTC,Lieu FROM Planformation WHERE EtatFormation='0' ORDER BY NatureFormation ASC ", False)
            If myDR.HasRows Then
                While myDR.Read
                    ds1.PFormation.AddPFormationRow(IIf(myDR("Specialite").ToString = "NULL", "", myDR("Specialite")), IIf(myDR("NatureFormation").ToString = "NULL", "", myDR("NatureFormation")), IIf(myDR("EffectifPrevu").ToString = "NULL", "", myDR("EffectifPrevu")), IIf(myDR("Alternance").ToString = "NULL", "", myDR("Alternance")), IIf(myDR("Duree").ToString = "NULL", "", myDR("Duree")), IIf(myDR("DateDebut").ToString = "NULL", "", myDR("DateDebut")), IIf(myDR("CoutTTC").ToString = "NULL", "", Val(myDR("CoutTTC"))), IIf(myDR("Lieu").ToString = "NULL", "", myDR("Lieu")))
                End While
            End If
        Catch ex As Exception
            Throw ex
        Finally
            ds1.EnforceConstraints = True
        End Try
        ' Set the report DataSet   
        cr.DataSource = ds1
        DocumentViewer1.DocumentSource = cr
        'If Sql.VerifiyConnection = True Then
        '    '  sql.RunQuery("SELECT Matricule,Nom,Prénom,DNaissance as 'Date de naissance',Dentrée as 'Date d\'entrée',numTel as 'Num Téléphone',name_service as 'Nom de service',titre_fonction as Fonction,name_direction as Direction,name_departement as Departement,Statut,Sexe,Sit_fam as 'Situation familiale',Adresse,willaya FROM Services, Departement, Direction, Employes, Fonction, willaya WHERE Services.id_departement=Departement.id_departement and Direction.id_direction=Departement.id_direction and Employe.id_service=Services.id_service and Fonction.id_fonction=Employe.id_fonction and willaya.id=Employe.VilleAdr")
        '    ' Clipboard.SetText("SELECT Matricule,Nom,Prénom,DNaissance as 'Date de naissance',Dentrée as 'Date d'entrée',numTel as 'Num Tel',name_service,titre_fonction as Fonction,name_direction as Direction,name_departement as Departement,Statut,Sexe,Sit_fam as 'Situation familiale',Adresse,willaya FROM Services, Departement, Direction, Employe, Fonction, willaya WHERE Services.id_departement=Departement.id_departement and Direction.id_direction=Departement.id_direction and Employe.id_service=Services.id_service and Fonction.id_fonction=Employe.id_fonction and willaya.id=Employe.VilleAdr")
        '    sql.RunQuery("SELECT Specialite,NatureFormation,EffectifPrevu,Alternance,Duree,DateDebut,CoutTTC,Lieu FROM Planformation group by Specialite")

        '    If Sql.SQLDS.Tables.Count > 0 Then
        '        DataGridViewX1.DataSource = sql.SQLDS.Tables(0)
        '    End If
        'End If
        GridControl1.DataSource = ds1.PFormation
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        If spec.Text = "" Then
            MessageBoxEx.Show("Vous avez laissé le champ Spécialité vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If nf.Text = "" Then
            MessageBoxEx.Show("Vous avez laissé le champ Nature de formation vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If ep.Text = "" Then
            MessageBoxEx.Show("Vous avez laissé la champ Effectif Prévu vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If alt.Text = "" Then
            MessageBoxEx.Show("Vous avez laissé le champ Alternance vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If duree.Text = "" Then
            MessageBoxEx.Show("Vous avez laissé le champ Durée vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If datedb.Text = "" Then
            MessageBoxEx.Show("Vous avez laissé le champ Date début vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If cout.Text = "" Then
            MessageBoxEx.Show("Vous avez laissé le champ Cout vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If lieu.Text = "" Then
            MessageBoxEx.Show("Vous avez laissé le champ Lieu vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim q As String = "INSERT INTO Planformation VALUES (NULL,'" & mysql_escape_string(spec.Text) & "', '" & mysql_escape_string(nf.Text) & "'," & ep.Value & ",'" & alt.Text & "' ,'" & mysql_escape_string(duree.Text) & "' ,'" & datedb.Text & "' ,'" & cout.Text & "','" & lieu.Text & "','0','0',Now())"
        IsConnected(q, False)
        MessageBoxEx.Show("Le plan de formation prévu a bien été enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
        spec.Text = ""
        nf.Text = ""
        alt.Text = ""
        duree.Text = ""
        datedb.Text = ""
        ep.Value = Nothing
        lieu.Text = ""
        cout.Text = ""
        ButtonX1.Enabled = True
        Dim cr As FormationPrévu = New FormationPrévu
        MySub()
        cr.DataSource = ds1
        DocumentViewer1.DocumentSource = cr
        cr.CreateDocument(True)
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        GridControl1.Visible = False
        DocumentViewer1.Visible = True
        MySub()
        cr.DataSource = ds1
        DocumentViewer1.DocumentSource = cr
        cr.CreateDocument(True)
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        reload()
        GridControl1.Visible = True
        DocumentViewer1.Visible = False
    End Sub
    Private Sub ButtonX4_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX4.Click
        Formation.ShowDialog()
    End Sub
End Class