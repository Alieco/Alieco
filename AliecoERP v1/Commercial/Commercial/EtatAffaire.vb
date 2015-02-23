Imports MySql.Data.MySqlClient
Imports DevComponents.DotNetBar

Public Class EtatAffaire
    Dim c As String = ""
    Dim modalite As Integer = 0
    Dim modalite1 As Integer = 0
    Private Sub EtatAffaire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
        nombre.Items.Clear()
        For i = 1 To 100
            nombre.Items.Add(i)
        Next
        c = ListOffre.code
        'load_prestation()
        IsConnected("SELECT * FROM commercial_offre WHERE code='" & c & "'", False)
        If myDR.HasRows = True Then
            While (myDR.Read)
                Try
                    titre.Text = myDR("titre").ToString
                    nomcl.Text = myDR("nomcl").ToString
                    Dim del = myDR("delai_exe").ToString.Split(" ")
                    If del.Count > 0 Then
                        nombre.Text = del(0)
                            delai.Text = del(1)
                        End If
                        Dim del1 = myDR("delai_option").ToString.Split(" ")
                        If del1.Count > 0 Then
                            nombre1.Text = del1(0)
                            delai1.Text = del1(1)
                        End If
                    CodeAffai.Text = codeAffaire(nomcl.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End While
        End If
        CheckedComboBoxEdit1.Properties.Items.Clear()
        CheckedComboBoxEdit2.Properties.Items.Clear()
        IsConnected("SELECT * FROM commercial_offre_modalite WHERE code='" & c & "'", False)
        If myDR.HasRows = True Then
            While (myDR.Read)
                Try
                    If myDR("type").ToString.Contains("Avance") Then
                        modalite = modalite + myDR("valeur")
                        CheckedComboBoxEdit1.Properties.Items.Add(myDR("valeur") & "% " & myDR("description").ToString, CheckState.Checked)
                    Else
                        modalite1 = modalite1 + myDR("valeur")
                        CheckedComboBoxEdit2.Properties.Items.Add(myDR("valeur") & "% " & myDR("description").ToString, CheckState.Checked)
                    End If
                Catch ex As Exception

                End Try
            End While
        End If
        IsConnected("SELECT * FROM commercial_offre_bordereauprix WHERE code='" & c & "'", False)
        If myDR.HasRows = True Then
            While (myDR.Read)
                Try
                    Dim item As ListViewItem = New ListViewItem(myDR("num").ToString)
                    item.SubItems.Add(myDR("desig").ToString)
                    item.SubItems.Add(myDR("Qt").ToString)
                    item.SubItems.Add(myDR("unite").ToString)
                    item.SubItems.Add(myDR("PrixUnit").ToString)
                    item.SubItems.Add(myDR("montant").ToString)
                    item.SubItems.Add(myDR("type").ToString)
                    item.SubItems.Add(myDR("alaChargeDe").ToString)
                    ListView2.Items.Add(item)
                    total11.Text = myDR("total").ToString
                    tva.Text = myDR("totaltva").ToString
                    ttc.Text = myDR("totalttc").ToString
                Catch ex As Exception
                End Try
            End While
        End If
        'IsConnected("SELECT * FROM commercial_offre_prestation WHERE code='" & c & "'", False)
        'If myDR.HasRows = True Then
        '    While (myDR.Read)
        '        Try
        '            'For i = 0 To CheckedListBoxAlieco.Items.Count - 1
        '            '    If CheckedListBoxclient.Items(i).ToString = myDR("text").ToString And myDR("type").ToString = "Client" Then
        '            '        CheckedListBoxclient.SetItemCheckState(i, CheckState.Checked)
        '            '    End If
        '            'Next
        '            'For i = 0 To CheckedListBoxAlieco.Items.Count - 1
        '            '    If CheckedListBoxAlieco.Items(i).ToString = myDR("text").ToString And myDR("type").ToString = "Alieco" Then
        '            '        CheckedListBoxAlieco.SetItemCheckState(i, CheckState.Checked)
        '            '    End If
        '            'Next
        '        Catch ex As Exception
        '            MsgBox(ex.Message)
        '        End Try
        '    End While
            'End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    'Sub load_prestation()
    '    Dim query = "SELECT DISTINCT(text) from commercial_offre_prestation"
    '    If IsConnected(query, False) Then
    '        If myDR.HasRows Then
    '            While myDR.Read
    '                CheckedListBoxclient.Items.Add(myDR("text"))
    '                CheckedListBoxAlieco.Items.Add(myDR("text"))
    '            End While
    '        End If
    '    End If
    'End Sub
    Function codeAffaire(ByVal NomClient As String)
        Try
            Dim codeFinal As String = ""
            If NomClient.Length <= 4 Then
                codeFinal += NomClient.ToUpper
            Else
                codeFinal += NomClient.Substring(0, 4).ToUpper
            End If
            IsConnected("SELECT COUNT(idoffre) as nombre from commercial_affaire ", False)
            If myDR.HasRows Then
                While myDR.Read
                    Dim ref As String = (myDR("nombre").ToString) + 1
                    Dim reff = ""
                    If ref.Length <= 3 Then
                        For i = 1 To (4 - ref.Length)
                            reff += "0"
                        Next
                        reff += ref
                    End If
                    codeFinal += reff
                End While
            End If
            Return codeFinal
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Function

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            If modalitepaie.Text = "" Or pourcentage.Text = "" Or Not IsNumeric(pourcentage.Text.Replace("%", "")) Then
                MsgBox(" Veuillez remplir le champ!")
            Else
                If RadioButton1.Checked Then
                    Dim mode
                    If pourcentage.Text.Contains("%") Then
                        mode = pourcentage.Text.Replace("%", "")
                    Else
                        mode = pourcentage.Text
                        pourcentage.Text += "%"
                    End If
                    If IsNumeric(mode) Then
                        If modalite < 100 Then
                            modalite = modalite + mode
                            If modalite = 100 Then
                                CheckedComboBoxEdit1.Properties.Items.Add(pourcentage.Text & modalitepaie.Text, CheckState.Checked)
                                MessageBoxEx.Show("Modalité a atteint le 100%!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            ElseIf modalite < 100 Then
                                CheckedComboBoxEdit1.Properties.Items.Add(pourcentage.Text & modalitepaie.Text, CheckState.Checked)
                            Else : MessageBoxEx.Show("Modalité depasse 100%!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                modalite = modalite - mode
                            End If
                        Else
                            MessageBoxEx.Show("Modalité depasse 100%!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Else
                    Dim mode1
                    If pourcentage.Text.Contains("%") Then
                        mode1 = pourcentage.Text.Replace("%", "")
                    Else
                        mode1 = pourcentage.Text
                        pourcentage.Text += "%"
                    End If
                    If IsNumeric(mode1) Then
                        If modalite1 < 100 Then
                            modalite1 = modalite1 + mode1
                            If modalite1 = 100 Then
                                CheckedComboBoxEdit2.Properties.Items.Add(pourcentage.Text & modalitepaie.Text, CheckState.Checked)
                                MessageBoxEx.Show("Modalité a atteint le 100%!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            ElseIf modalite1 < 100 Then
                                CheckedComboBoxEdit2.Properties.Items.Add(pourcentage.Text & modalitepaie.Text, CheckState.Checked)
                            Else : MessageBoxEx.Show("Modalité depasse 100%!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                modalite1 = modalite1 - mode1
                            End If
                        Else
                            MessageBoxEx.Show("Modalité depasse 100%!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                End If
                'Else : MessageBoxEx.Show("Veuillez saisir un pourcentage au debut!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            'End If
            pourcentage.Clear()
            modalitepaie.Clear()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX7.Click
        Try
            If unit.SelectedIndex > -1 Then
                Dim List As ListViewItem = New ListViewItem(numero.Text, 1)
                List.SubItems.Add(design.Text)
                List.SubItems.Add(quantite.Text)
                List.SubItems.Add(unit.Text)
                List.SubItems.Add(prixunitaire.Text)
                Select Case unit.Text
                    Case "pourcentage"
                        'List.SubItems.Add(Math.Round((prixunitaire.Text * quantite.Text) / 100, 2))
                        Dim f As String = String.Format("{0:0,0.00}", Math.Round((prixunitaire.Text * quantite.Text) / 100, 2))
                        List.SubItems.Add(f)
                    Case "U", "Forfait"
                        'List.SubItems.Add(Math.Round((prixunitaire.Text * quantite.Text), 2))
                        Dim f As String = String.Format("{0:0,0.00}", Math.Round((prixunitaire.Text * quantite.Text), 2))
                        List.SubItems.Add(f)
                End Select
                If RadioButton3.Checked Then
                    List.SubItems.Add("D")
                    List.SubItems.Add("A")
                Else
                    List.SubItems.Add("P")
                    If ComboBoxEx1.SelectedIndex = 0 Then
                        List.SubItems.Add("C")
                    Else
                        List.SubItems.Add("A")
                    End If
                End If
                ListView2.Items.Add(List)
                numero.Clear()
                design.Clear()
                prixunitaire.Value = Nothing
                quantite.Value = Nothing
            Else : MessageBoxEx.Show("Veuillez saisir l'unité de la quantité!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX8.Click
        Try
            Dim total1 As Double = 0
            For i = 0 To ListView2.Items.Count - 1
                total1 += ListView2.Items(i).SubItems(4).Text
            Next
            total11.Text = String.Format("{0:0,0.00}", total1)
            'If Not total11.Text.Contains(",") Then
            '    total11.Text += ",00"
            'End If
            tva.Text = String.Format("{0:0,0.00}", Math.Round((total1 * 0.17), 2))
            'If Not tva.Text.Contains(",") Then
            '    tva.Text += ",00"
            'End If
            ttc.Text = String.Format("{0:0,0.00}", (total1 + tva.Text))
            'If Not ttc.Text.Contains(",") Then
            '    ttc.Text += ",00"
            'End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub numero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numero.TextChanged
        Try
            total11.Clear()
            tva.Clear()
            ttc.Clear()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    'Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If txtPris.Text = "" Then
    '        MsgBox("Veuillez saisir une prestation!")
    '    Else
    '        CheckedListBoxclient.Items.Add(txtPris.Text.Replace("'", ""), False)
    '        CheckedListBoxAlieco.Items.Add(txtPris.Text.Replace("'", ""), False)
    '    End If
    'End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Try
            For i = 0 To ListView2.Items.Count - 1
                If ListView2.Items(i).Selected = True Then
                    ListView2.Items(i).Remove()
                    Exit For
                End If
            Next
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Try
            For i = 0 To ListView2.Items.Count - 1
                If ListView2.Items(i).Selected = True Then
                    numero.Text = ListView2.Items(i).Text
                    design.Text = ListView2.Items(i).SubItems(1).Text
                    quantite.Value = ListView2.Items(i).SubItems(2).Text.Replace(".00", ",00")
                    unit.Text = ListView2.Items(i).SubItems(3).Text
                    prixunitaire.Value = ListView2.Items(i).SubItems(4).Text.Replace(".00", ",00")
                End If
            Next
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX6.Click
        Try
            If ttc.Text = String.Empty Then
                MessageBoxEx.Show("Vous avez préciser le montant de l'affaire !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If c <> Nothing Then
                Dim erreur As Boolean = False
                Dim s1 As Double = 0
                Dim s2 As Double = 0
                For i = 0 To CheckedComboBoxEdit2.Properties.Items.Count - 1
                    If CheckedComboBoxEdit2.Properties.Items(i).CheckState = CheckState.Checked Then
                        Dim sep = CheckedComboBoxEdit2.Properties.Items(i).ToString.Split("%")
                        s1 = s1 + sep(0)
                    End If
                Next
                For i = 0 To CheckedComboBoxEdit1.Properties.Items.Count - 1
                    If CheckedComboBoxEdit1.Properties.Items(i).CheckState = CheckState.Checked Then
                        Dim sep = CheckedComboBoxEdit1.Properties.Items(i).ToString.Split("%")
                        s2 = s2 + sep(0)
                    End If
                Next
                If s1 <= 100 And s2 <= 100 Then

                    ' Dim rs = nomcl.Text.Split("-")
                    Try
                        Dim quary = " INSERT INTO commercial_affaire VALUES(NULL,'" & nomcl.Text & "','" & titre.Text & "','" & nombre.Text & " " & delai.Text & "','" & c & "', NOW(),'0', '" & CodeAffai.Text & "'," & user_id & ", '" & designationtxt.Text & "','" & nombre1.Text & " " & delai1.Text & "',(SELECT idclient FROM commercial_client where RaisonSocial='" & nomcl.Text & "'));"
                        ' Clipboard.SetText(quary)
                        If IsConnected(quary, True) = False Then
                            erreur = True
                        End If
                    Catch ex As Exception
                        EnvoiError(ex.Message)
                    End Try
                    Try
                        'For i = 0 To CheckedListBoxclient.CheckedItems.Count - 1
                        '    Dim quary = " INSERT INTO commercial_affaire_prestation VALUES(NULL,'" & CodeAffai.Text & "','" & CheckedListBoxclient.CheckedItems(i).ToString & "','Client');"
                        '    ' Clipboard.SetText(quary)
                        '    If IsConnected(quary, True) = False Then
                        '        erreur = True
                        '    End If
                        'Next
                        'For i = 0 To CheckedListBoxAlieco.CheckedItems.Count - 1
                        '    Dim quary = " INSERT INTO commercial_affaire_prestation VALUES(NULL,'" & CodeAffai.Text & "','" & CheckedListBoxAlieco.CheckedItems(i).ToString & "','Alieco');"
                        '    '  Clipboard.SetText(quary)
                        '    If IsConnected(quary, True) = False Then
                        '        erreur = True
                        '    End If
                        'Next
                    Catch ex As Exception
                        EnvoiError(ex.Message)
                    End Try
                    Dim type As String = ""
                    For i = 0 To CheckedComboBoxEdit1.Properties.Items.Count - 1
                        If CheckedComboBoxEdit1.Properties.Items(i).CheckState = CheckState.Checked Then
                            type = "Avance remboursement"
                            Dim val = CheckedComboBoxEdit1.Properties.Items(i).ToString.Split("%")
                            Dim quary = " INSERT INTO commercial_affaire_modalite VALUES(NULL,'" & CodeAffai.Text & "','" & val(0) & "','" & val(1) & "',NOW(),'" & type & "','','','', 0);"
                            If IsConnected(quary, True) = False Then erreur = True
                        End If
                    Next
                    For i = 0 To CheckedComboBoxEdit2.Properties.Items.Count - 1
                        If CheckedComboBoxEdit2.Properties.Items(i).CheckState = CheckState.Checked Then
                            type = "terme paiement"
                            Dim val1 = CheckedComboBoxEdit2.Properties.Items(i).ToString.Split("%")
                            Dim quary1 = " INSERT INTO commercial_affaire_modalite VALUES(NULL,'" & CodeAffai.Text & "','" & val1(0) & "','" & val1(1) & "',NOW(),'" & type & "','','','',0);"
                            If IsConnected(quary1, True) = False Then erreur = True
                        End If
                    Next
                    For i = 0 To ListView2.Items.Count - 1
                        Try
                            Dim quary = " INSERT INTO commercial_affaire_bordereauprix VALUES(NULL,'" & mysql_escape_string(ListView2.Items(i).SubItems(0).Text) & "','" & mysql_escape_string(ListView2.Items(i).SubItems(1).Text.Replace(",", ".")) & "','" & ListView2.Items(i).SubItems(2).Text.Replace(",", ".") & "','" & ListView2.Items(i).SubItems(3).Text.Replace(",", ".") & "','" & ListView2.Items(i).SubItems(4).Text.Replace(",", ".") & "','" & ListView2.Items(i).SubItems(5).Text.Replace(",", ".") & "','" & total11.Text & "','" & tva.Text & "','" & ttc.Text & "','" & CodeAffai.Text & "','" & ListView2.Items(i).SubItems(6).Text & "','" & ListView2.Items(i).SubItems(7).Text & "');"
                            If IsConnected(quary, True) = False Then
                                erreur = True
                            End If
                        Catch ex As Exception
                            EnvoiError(ex.Message)
                        End Try
                    Next
                    IsConnected("UPDATE commercial_offre SET code_affaire='" & CodeAffai.Text & "' WHERE code='" & c & "' LIMIT 1", True)
                    If erreur = False Then
                        MessageBoxEx.Show("L'affaire a bien été enregistré", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ListView2.Items.Clear()
                        nomcl.Text = ""
                        titre.Clear()
                        modalitepaie.Text = ""
                        nombre.Text = ""
                        pourcentage.Text = ""
                        delai.Text = ""
                        Me.Close()
                    End If
                Else : MessageBoxEx.Show("La somme de pourcentage des modalités de  dépasse 100%", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Try
            ComboBoxEx1.Visible = True
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class