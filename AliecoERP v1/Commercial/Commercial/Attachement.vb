Imports DevComponents.DotNetBar

Public Class Attachement
    Dim iddesig
    Public code
    Dim idattach
    Dim prec
    Dim prec1
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles EnregistrerButtonX1.Click
        ' Dim desig
        If CodeAffaireComboBoxEx1.Text = "" Or DesignationComboBoxEx2.Text = "" Or qt.Value = Nothing Or UnitéComboBoxEx3.Text = "" Then
            MessageBoxEx.Show("Vous devez remplir les champs vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            'If EnregistrerButtonX1.Text = "Enregistrer" Then
            'If IsConnected("SELECT * FROM commercial_attachement WHERE idBordereauPrix='" & iddesig(0) & "'", False) Then
            '    If myDR.HasRows Then
            '        While myDR.Read
            '            idattach = myDR("idCommercial_Attachement").ToString
            '        End While
            '        IsConnected("Delete from commercial_attachement WHERE idCommercial_Attachement ='" & idattach & "' limit 1", True)
            '    End If
            If IsConnected("INSERT INTO `commercial_attachement`(`code_affaire`,`idBordereauPrix`,`Qt_Precedente`,`Qt_Mois`,`Qt_Cumul`,`DateEnregistrement`)VALUES('" & CodeAffaireComboBoxEx1.Text & "','" & iddesig(0) & "','" & QtPrecedenteLabelX5.Text & "','" & qt.Value & "','" & QtCumulLabelX9.Text & "', Now());", True) Then
                'MsgBox("bon")
                MessageBoxEx.Show("L'attachement a bien été enregistré", "Succee", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'CodeAffaireComboBoxEx1.Text = ""
                qt.Value = Nothing
                DesignationComboBoxEx2.Text = ""
                QtCumulLabelX9.Text = ""
                QtPrecedenteLabelX5.Text = ""
                QtPrevueLabelX6.Text = ""
                UnitéComboBoxEx3.Text = ""
                Load_List_Attachement()
                'MontantLabelX11.Text = ""
                'PrixUnitaireLabelX6.Text = ""
                'ObservationTextBoxX1.Clear()
            Else : MessageBoxEx.Show("L'attachement n'a pas pu etre enregistré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        'End If

        '************Modification***************
        'Else
        '    IsConnected("SELECT * FROM commercial_attachement WHERE idCommercial_Attachement =" & code & "", False)
        '    If myDR.HasRows Then
        '        While myDR.Read
        '            desig = myDR("idBordereauPrix").ToString
        '        End While
        '    End If

        '    If IsConnected("UPDATE `commercial_attachement` SET `code_affaire` = '" & CodeAffaireComboBoxEx1.Text & "',`idBordereauPrix` = '" & desig & "',`Qt_Precedente` = '" & QtPrecedenteLabelX5.Text & "',`Qt_Mois` = '" & qt.Value & "',`Qt_Cumul` ='" & QtCumulLabelX9.Text & "',`DateEnregistrement` = Now() WHERE `idCommercial_Attachement` = '" & code & "'", True) Then
        '        MessageBoxEx.Show("L'attachement a bien été modifié", "Succee", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        CodeAffaireComboBoxEx1.Text = ""
        '        qt.Value = Nothing
        '        DesignationComboBoxEx2.Text = ""
        '        QtCumulLabelX9.Text = ""
        '        QtPrecedenteLabelX5.Text = ""
        '        QtPrevueLabelX6.Text = ""
        '        UnitéComboBoxEx3.Text = ""
        '        Me.Close()
        '    Else : MessageBoxEx.Show("L'attachement n'a pas pu etre Modifié", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End If
        'End If
    End Sub
#Region "Fonctions"
    Private Sub Load_List_Attachement()
        If IsConnected("SELECT commercial_attachement.code_affaire as 'Code affaire',num as 'N°', desig as 'Désignations', unite as 'Unité', Qt as 'Qte prévues', Qt_Precedente as 'Qte Précédente', Qt_Mois as 'Qte du Mois', Qt_Cumul as 'Qte cumulées',DateEnregistrement as 'Date d\'enregistrement', idCommercial_Attachement as 'Code' FROM commercial_affaire_bordereauprix, commercial_attachement WHERE commercial_affaire_bordereauprix.idBordereauPrix=commercial_attachement.idBordereauPrix and commercial_attachement.code_affaire='" & CodeAffaireComboBoxEx1.Text & "' order by DateEnregistrement desc limit 1", False) Then
            ListView1.Items.Clear()
            If myDR.HasRows Then
                While myDR.Read
                    ', idCommercial_Attachement as 'Code'
                    Dim List As ListViewItem = New ListViewItem(myDR("Code affaire").ToString)
                    List.SubItems.Add(myDR("N°").ToString)
                    List.SubItems.Add(myDR("Désignations").ToString)
                    List.SubItems.Add(myDR("Unité").ToString)
                    List.SubItems.Add(myDR("Qte prévues").ToString)
                    List.SubItems.Add(myDR("Qte Précédente").ToString)
                    List.SubItems.Add(myDR("Qte du Mois").ToString)
                    List.SubItems.Add(myDR("Qte cumulées").ToString)
                    List.SubItems.Add(myDR("Date d'enregistrement").ToString)
                    List.SubItems.Add(myDR("Code").ToString)
                    ListView1.Items.Add(List)
                End While
            End If
        End If
    End Sub
#End Region
    Private Sub Attachement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Affaire()
        'Load_List_Attachement()
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

    Private Sub CodeAffaireComboBoxEx1_TextChanged(sender As Object, e As EventArgs) Handles CodeAffaireComboBoxEx1.TextChanged
        load_designation()
        DesignationComboBoxEx2.Text = ""
        QtPrevueLabelX6.Text = ""
        QtPrecedenteLabelX5.Text = ""
        qt.Value = Nothing
        QtCumulLabelX9.Text = ""
        UnitéComboBoxEx3.Text = ""
        Load_List_Attachement()
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

    Private Sub DesignationComboBoxEx2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DesignationComboBoxEx2.SelectedIndexChanged
        If DesignationComboBoxEx2.SelectedIndex > -1 Then
            iddesig = DesignationComboBoxEx2.Text.Split("-")
            IsConnected("SELECT * FROM commercial_affaire_bordereauprix WHERE commercial_affaire_bordereauprix.idBordereauPrix='" & iddesig(0) & "'and code='" & CodeAffaireComboBoxEx1.Text & "' limit 1", False)
            If myDR.HasRows Then
                While myDR.Read
                    QtPrevueLabelX6.Text = myDR("Qt").ToString
                    UnitéComboBoxEx3.Text = myDR("unite").ToString
                    'PrixUnitaireLabelX6.Text = myDR("PrixUnit").ToString
                End While
            End If
            IsConnected("SELECT * FROM commercial_attachement WHERE commercial_attachement.idBordereauPrix='" & iddesig(0) & "' and code_affaire='" & CodeAffaireComboBoxEx1.Text & "' order by idCommercial_Attachement desc limit 1", False)
            If myDR.HasRows Then
                While myDR.Read
                    If myDR("Qt_Precedente").ToString = "0" Or myDR("Qt_Precedente").ToString = "" Then
                        QtPrecedenteLabelX5.Text = myDR("Qt_Mois").ToString
                        'Or myDR("Qt_Mois").ToString = "" Or myDR("Qt_Mois").ToString = "0"
                    ElseIf myDR("Qt_Mois").ToString <> "" Or myDR("Qt_Mois").ToString <> "0" Then
                        'MsgBox(CDbl(myDR("Qt_Precedente").ToString) + CDbl(myDR("Qt_Mois").ToString))
                        QtPrecedenteLabelX5.Text = CDbl(myDR("Qt_Precedente").ToString) + CDbl(myDR("Qt_Mois").ToString)
                    End If
                End While
            Else
                QtPrecedenteLabelX5.Text = "0"
            End If
        End If
    End Sub

    Private Sub qt_ValueChanged(sender As Object, e As EventArgs) Handles qt.ValueChanged
        If QtPrecedenteLabelX5.Text <> "" Then
            QtCumulLabelX9.Text = qt.Value + CDbl(QtPrecedenteLabelX5.Text)
            ' MontantLabelX11.Text = CDbl(QtCumulLabelX9.Text) * CDbl(PrixUnitaireLabelX6.Text)
        Else
            QtCumulLabelX9.Text = qt.Value
            ' MontantLabelX11.Text = CDbl(QtCumulLabelX9.Text) * CDbl(PrixUnitaireLabelX6.Text)
        End If
        If QtCumulLabelX9.Text <> Nothing And QtPrevueLabelX6.Text <> "" Then
            If CDbl(QtCumulLabelX9.Text.Replace(".", ",")) > CDbl(QtPrevueLabelX6.Text.Replace(".", ",")) Then
                MessageLabelX11.Text = " La quantité du mois dépasse la quantité prévue "
            Else
                MessageLabelX11.Text = " "
            End If
        End If
    End Sub

    Private Sub QtCumulLabelX9_TextChanged(sender As Object, e As EventArgs) Handles QtCumulLabelX9.TextChanged
        'If QtCumulLabelX9.Text <> "" And PrixUnitaireLabelX6.Text <> "" Then
        '    MontantLabelX11.Text = CDbl(QtCumulLabelX9.Text.Replace(".", ",")) * CDbl(PrixUnitaireLabelX6.Text.Replace(".", ","))
        'End If
    End Sub
End Class