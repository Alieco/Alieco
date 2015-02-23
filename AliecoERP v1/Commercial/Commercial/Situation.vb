Imports DevComponents.DotNetBar

Public Class Situation
    Dim iddesig
    Public codeS
    Dim idattachement As String
#Region "Fonctions"
    Private Sub Load_List_Situation()
        If IsConnected("SELECT commercial_attachement.code_affaire as 'Code affaire',num as 'N°', desig as 'Désignations', unite as 'Unité', Qt as 'Qte prévues', PrixUnit as 'Prix Unitaire' ,Montant_Mois as 'Montant du mois', Qt_Cumul as 'Qte cumulées',DateEnregistrementSituation,Observation FROM commercial_affaire_bordereauprix, commercial_attachement WHERE commercial_affaire_bordereauprix.idBordereauPrix=commercial_attachement.idBordereauPrix and commercial_attachement.code_affaire='" & CodeAffaireComboBoxEx1.Text & "' order by DateEnregistrementSituation desc limit 1", False) Then
            ListView1.Items.Clear()
            If myDR.HasRows Then
                While myDR.Read
                    Dim List As ListViewItem = New ListViewItem(myDR("Code affaire").ToString)
                    List.SubItems.Add(myDR("N°").ToString)
                    List.SubItems.Add(myDR("Désignations").ToString)
                    List.SubItems.Add(myDR("Unité").ToString)
                    List.SubItems.Add(myDR("Qte prévues").ToString)
                    List.SubItems.Add(myDR("Prix Unitaire").ToString)
                    List.SubItems.Add(myDR("Montant du mois").ToString)
                    List.SubItems.Add(myDR("Qte cumulées").ToString)
                    List.SubItems.Add(myDR("DateEnregistrementSituation").ToString)
                    List.SubItems.Add(myDR("Observation").ToString)
                    ListView1.Items.Add(List)
                End While
            End If
        End If
    End Sub
#End Region
    Private Sub Situation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Affaire()
        ' Load_List_Situation()
    End Sub
    Private Sub load_Affaire()
        IsConnected("SELECT distinct code_affaire FROM commercial_affaire", False)
        If myDR.HasRows Then
            CodeAffaireComboBoxEx1.Items.Clear()
            While myDR.Read
                CodeAffaireComboBoxEx1.Items.Add(myDR("code_affaire").ToString)
            End While
        End If
    End Sub
    Private Sub load_designation()
        IsConnected("SELECT distinct desig,idBordereauPrix FROM commercial_affaire_bordereauprix WHERE code='" & CodeAffaireComboBoxEx1.Text & "'", False)
        If myDR.HasRows Then
            DesignationComboBoxEx2.Items.Clear()
            While myDR.Read
                DesignationComboBoxEx2.Items.Add(myDR("idBordereauPrix").ToString & "-" & myDR("desig").ToString)
            End While
        End If
    End Sub

    Private Sub CodeAffaireComboBoxEx1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CodeAffaireComboBoxEx1.SelectedIndexChanged
        load_designation()
        DesignationComboBoxEx2.Text = ""
        QtPrevueLabelX6.Text = ""
        PrixUnitaireLabelX6.Text = ""
        'MontantMoisDoubleInput1.Value = Nothing
        ObservationTextBoxX1.Text = ""
    End Sub

    Private Sub DesignationComboBoxEx2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DesignationComboBoxEx2.SelectedIndexChanged
        If DesignationComboBoxEx2.SelectedIndex > -1 Then
            iddesig = DesignationComboBoxEx2.Text.Split("-")
            IsConnected("SELECT * FROM commercial_affaire_bordereauprix WHERE commercial_affaire_bordereauprix.idBordereauPrix='" & iddesig(0) & "'and code='" & CodeAffaireComboBoxEx1.Text & "' ", False)
            If myDR.HasRows Then
                While myDR.Read
                    QtPrevueLabelX6.Text = myDR("Qt").ToString
                    PrixUnitaireLabelX6.Text = myDR("PrixUnit").ToString
                End While
            End If
            IsConnected("select * from commercial_attachement where idBordereauPrix='" & iddesig(0) & "'and code_affaire='" & CodeAffaireComboBoxEx1.Text & "' order by DateEnregistrement desc limit 1", False)
            If myDR.HasRows Then
                While myDR.Read
                    QtCumulLabelX9.Text = myDR("Qt_Cumul").ToString
                    idattachement = myDR("idCommercial_Attachement").ToString
                End While
            End If
            If QtCumulLabelX9.Text <> "" And PrixUnitaireLabelX6.Text <> "" Then
                MontantMoisLabelX7.Text = CDbl(QtCumulLabelX9.Text.Replace(".", ",")) * CDbl(PrixUnitaireLabelX6.Text.Replace(".", ","))
            End If
        End If
    End Sub

    Private Sub EnregistrerButtonX1_Click(sender As Object, e As EventArgs) Handles EnregistrerButtonX1.Click
        'If EnregistrerButtonX1.Text = "Enregistrer" Then
        ' iddesig = DesignationComboBoxEx2.Text.Split("-")
        ' Else
        'IsConnected("SELECT * FROM commercial_attachement WHERE idCommercial_Attachement='" & codeS & "'", False)
        'If myDR.HasRows Then
        '    While myDR.Read
        '        iddesig = myDR("idBordereauPrix").ToString
        '    End While
        'End If
        ' End If

        '****************Modifier*****************
        If IsConnected(" UPDATE `commercial_attachement`SET `DateEnregistrementSituation` =Now(),`Montant_Mois` = '" & MontantMoisLabelX7.Text & "',`Observation` = '" & mysql_escape_string(ObservationTextBoxX1.Text) & "' WHERE idCommercial_Attachement='" & idattachement & "' ;", True) Then
            'idCommercial_Attachement='" & codeS & "' and idBordereauPrix='" & iddesig & "' and Qt_Cumul='" & QtCumulLabelX9.Text & "'
            'TextBox1.Text = "UPDATE `commercial_attachement`SET `DateEnregistrementSituation` =Now(),`Montant_Mois` = '" & MontantMoisLabelX7.Text & "',`Observation` = '" & mysql_escape_string(ObservationTextBoxX1.Text) & "' WHERE idCommercial_Attachement='" & idattachement & "'"
            MessageBoxEx.Show("La situation a bien été enregistré", "Succee", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'CodeAffaireComboBoxEx1.SelectedIndex = -1
            DesignationComboBoxEx2.SelectedIndex = -1
            QtPrevueLabelX6.Text = ""
            PrixUnitaireLabelX6.Text = ""
            MontantMoisLabelX7.Text = ""
            ObservationTextBoxX1.Clear()
            ' Me.Close()
            Load_List_Situation()
        Else : MessageBoxEx.Show("La situation n'a pas pu etre enregistré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub QtCumulLabelX9_TextChanged(sender As System.Object, e As System.EventArgs) Handles QtCumulLabelX9.TextChanged
        If QtCumulLabelX9.Text <> "" And PrixUnitaireLabelX6.Text <> "" Then
            MontantMoisLabelX7.Text = CDbl(QtCumulLabelX9.Text.Replace(".", ",")) * CDbl(PrixUnitaireLabelX6.Text.Replace(".", ","))
        End If
    End Sub

    'Private Sub PrixUnitaireLabelX6_TextChanged(sender As System.Object, e As System.EventArgs) Handles PrixUnitaireLabelX6.TextChanged
    '    If QtCumulLabelX9.Text <> "" And PrixUnitaireLabelX6.Text <> "" Then
    '        MontantMoisDoubleInput1.Value = CDbl(QtCumulLabelX9.Text.Replace(".", ",")) * CDbl(PrixUnitaireLabelX6.Text.Replace(".", ","))
    '    End If
    'End Sub
End Class