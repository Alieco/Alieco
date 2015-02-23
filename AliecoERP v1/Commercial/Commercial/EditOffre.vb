Imports DevComponents.DotNetBar
Imports MySql.Data.MySqlClient

Public Class EditOffre
    Public varcode As String
    Dim c As String
    Dim modalite As Integer = 0
    Dim modalite1 As Integer = 0
    Function RandomNumber()
        Try
            Return CLng(DateTime.Now.Subtract(New DateTime(1970, 1, 1)).TotalMilliseconds)
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
        Return Nothing
    End Function
    Private Sub EditOffre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'If user_id = 20 Or user_id = 1 Then
            '    ValiderButtonX3.Visible = True
            'Else
            '    ValiderButtonX3.Visible = False
            'End If
            nombre.Items.Clear()
            For i = 1 To 100
                nombre.Items.Add(i)
            Next
            varcode = RandomNumber()
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
                    Catch ex As Exception
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
                            CheckedComboBoxEdit1.Properties.Items.Add(myDR("valeur") & "%" & myDR("description").ToString, CheckState.Checked)
                        Else
                            modalite1 = modalite1 + myDR("valeur")
                            CheckedComboBoxEdit2.Properties.Items.Add(myDR("valeur") & "%" & myDR("description").ToString, CheckState.Checked)
                        End If
                    Catch ex As Exception
                    End Try
                End While
            End If
            IsConnected("SELECT * FROM commercial_offre_bordereauprix WHERE type='D' and code='" & c & "' ", False)
            If myDR.HasRows = True Then
                While (myDR.Read)
                    Try
                        Dim item As ListViewItem = New ListViewItem(myDR("num").ToString)
                        item.SubItems.Add(myDR("desig").ToString)
                        item.SubItems.Add(myDR("Qt").ToString)
                        item.SubItems.Add(myDR("unite").ToString)
                        item.SubItems.Add(myDR("PrixUnit").ToString)
                        item.SubItems.Add(myDR("montant").ToString)
                        ListView1.Items.Add(item)
                        total11.Text = myDR("total").ToString
                        tva.Text = myDR("totaltva").ToString
                        ttc.Text = myDR("totalttc").ToString
                    Catch ex As Exception
                    End Try
                End While
            End If
            IsConnected("SELECT * FROM commercial_offre_bordereauprix WHERE type='P' and code='" & c & "' ", False)
            If myDR.HasRows = True Then
                While (myDR.Read)
                    Try
                        Dim item As ListViewItem = New ListViewItem(myDR("num").ToString)
                        item.SubItems.Add(myDR("desig").ToString)
                        item.SubItems.Add(myDR("Qt").ToString)
                        item.SubItems.Add(myDR("unite").ToString)
                        item.SubItems.Add(myDR("PrixUnit").ToString)
                        item.SubItems.Add(myDR("montant").ToString)
                        item.SubItems.Add(myDR("alaChargeDe").ToString)
                        ListView2.Items.Add(item)
                    Catch ex As Exception
                    End Try
                End While
            End If
            'IsConnected("SELECT * FROM commercial_offre_bordereauprix WHERE code='" & c & "' and commercial_offre_bordereauprix.type='P' ", False)
            'If myDR.HasRows = True Then
            '    While (myDR.Read)
            '        Try
            '           Dim item As ListViewItem = New ListViewItem(myDR("num").ToString)
            '            item.SubItems.Add(myDR("desig").ToString)
            '            item.SubItems.Add(myDR("Qt").ToString)
            '            item.SubItems.Add(myDR("unite").ToString)
            '            item.SubItems.Add(myDR("PrixUnit").ToString)
            '            item.SubItems.Add(myDR("montant").ToString)
            '            item.SubItems.Add(myDR("type").ToString)
            '            item.SubItems.Add(myDR("alaChargeDe").ToString)
            '            ListView2.Items.Add(item)
            '            total11.Text = myDR("total").ToString
            '            tva.Text = myDR("totaltva").ToString
            '            ttc.Text = myDR("totalttc").ToString
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


    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            TabControl1.SelectedTabIndex = 1
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

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
    'Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If txtPris.Text = "" Then
    '        MsgBox("Veuillez saisir une prestation!")
    '    Else
    '        CheckedListBoxclient.Items.Add(txtPris.Text.Replace("'", ""), False)
    '        CheckedListBoxAlieco.Items.Add(txtPris.Text.Replace("'", ""), False)
    '    End If
    'End Sub

    Private Sub ButtonX8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim total1 As Double = 0
            For i = 0 To ListView2.Items.Count - 1
                total1 += ListView2.Items(i).SubItems(4).Text
            Next
            total11.Text = total1
            tva.Text = Math.Round((total1 * 0.17), 2)
            ttc.Text = total1 + tva.Text
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub numero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            total11.Clear()
            tva.Clear()
            ttc.Clear()
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
                    ListView2.Items(i).Remove()
                End If
            Next
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

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
    Private Sub design_TextChanged(sender As System.Object, e As System.EventArgs) Handles design.TextChanged
        If design.Text = "" Or quantite.Value = Nothing Or unit.Text = "" Or prixunitaire.Value = Nothing Then
            ButtonX4.Enabled = False
        Else
            ButtonX4.Enabled = True
        End If
    End Sub

    Private Sub prest_TextChanged(sender As System.Object, e As System.EventArgs) Handles prest.TextChanged
        If prest.Text = "" Or quantite1.Value = Nothing Or unit1.Text = "" Or prixunitaire1.Value = Nothing Or alacharge.Text = "" Then
            ButtonX7.Enabled = False
        Else
            ButtonX7.Enabled = True
        End If
    End Sub
    Private Sub prixunitaire_ValueChanged(sender As System.Object, e As System.EventArgs) Handles prixunitaire.ValueChanged
        If design.Text = "" Or quantite.Value = Nothing Or unit.Text = "" Or prixunitaire.Value = Nothing Then
            ButtonX4.Enabled = False
        Else
            ButtonX4.Enabled = True
        End If
    End Sub

    Private Sub quantite_ValueChanged(sender As System.Object, e As System.EventArgs) Handles quantite.ValueChanged
        If design.Text = "" Or quantite.Value = Nothing Or unit.Text = "" Or prixunitaire.Value = Nothing Then
            ButtonX4.Enabled = False
        Else
            ButtonX4.Enabled = True
        End If
    End Sub

    Private Sub unit_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles unit.SelectedIndexChanged
        If design.Text = "" Or quantite.Value = Nothing Or unit.Text = "" Or prixunitaire.Value = Nothing Then
            ButtonX4.Enabled = False
        Else
            ButtonX4.Enabled = True
        End If
    End Sub

    Private Sub quantite1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles quantite1.ValueChanged
        If prest.Text = "" Or quantite1.Value = Nothing Or unit1.Text = "" Or prixunitaire1.Value = Nothing Or alacharge.Text = "" Then
            ButtonX7.Enabled = False
        Else
            ButtonX7.Enabled = True
        End If
    End Sub

    Private Sub unit1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles unit1.SelectedIndexChanged
        If prest.Text = "" Or quantite1.Value = Nothing Or unit1.Text = "" Or prixunitaire1.Value = Nothing Or alacharge.Text = "" Then
            ButtonX7.Enabled = False
        Else
            ButtonX7.Enabled = True
        End If
    End Sub

    Private Sub prixunitaire1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles prixunitaire1.ValueChanged
        If prest.Text = "" Or quantite1.Value = Nothing Or unit1.Text = "" Or prixunitaire1.Value = Nothing Or alacharge.Text = "" Then
            ButtonX7.Enabled = False
        Else
            ButtonX7.Enabled = True
        End If
    End Sub

    Private Sub alacharge_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles alacharge.SelectedIndexChanged
        If prest.Text = "" Or quantite1.Value = Nothing Or unit1.Text = "" Or prixunitaire1.Value = Nothing Or alacharge.Text = "" Then
            ButtonX7.Enabled = False
        Else
            ButtonX7.Enabled = True
        End If
    End Sub

    Private Sub ButtonX5_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX5.Click
        Try
            Dim total1 As Double = 0
            For i = 0 To ListView1.Items.Count - 1
                'If 
                If ListView1.Items(i).SubItems(5).Text <> "" Then
                    total1 += ListView1.Items(i).SubItems(5).Text
                End If
            Next
            'MsgBox("affiche1: " & total1.ToString("F", CultureInfo.InvariantCulture))
            'MsgBox("affiche2: " & String.Format(CultureInfo.InvariantCulture, "{0:# #}", total1))
            'MsgBox("affiche3: " & String.Format("{0:0,0.00}", total1))
            total11.Text = String.Format("{0:0,0.00}", total1)
            'total1.ToString("{0:0,0.00}")
            'If Not total11.Text.Contains(",00") Then
            '    total11.Text += ",00"
            'End If
            tva.Text = String.Format("{0:0,0.00}", Math.Round((total1 * 0.17), 2))
            'Math.Round((total1 * 0.17), 2).ToString("{0:0,0.00}")
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

    Private Sub ButtonX4_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX4.Click
        Try
            Dim List As ListViewItem = New ListViewItem((ListView1.Items.Count + 1).ToString, 1)
            List.SubItems.Add(design.Text)
            List.SubItems.Add(quantite.Text)
            List.SubItems.Add(unit.Text)
            List.SubItems.Add(prixunitaire.Text)
            Select Case unit.Text
                Case "pourcentage"
                    List.SubItems.Add(Math.Round((prixunitaire.Text * quantite.Text) / 100, 2))
                Case "U", "Forfait"
                    Dim f As String = String.Format("{0:0,0.00}", Math.Round((prixunitaire.Text * quantite.Text), 2))
                    'Math.Round((prixunitaire.Text * quantite.Text), 2)
                    'If Not f.Contains(",") Then
                    '    f += ",00"
                    'End If
                    List.SubItems.Add(f)
            End Select
            'If RadioButton3.Checked Then
            '    List.SubItems.Add("D")
            '    List.SubItems.Add("A")
            'Else
            '    List.SubItems.Add("P")
            '    If ComboBoxEx1.SelectedIndex = 0 Then
            '        List.SubItems.Add("C")
            '    Else
            '        List.SubItems.Add("A")
            '    End If
            'End If
            ListView1.Items.Add(List)
            numero.Clear()
            design.Clear()
            unit.SelectedIndex = -1
            prixunitaire.Value = Nothing
            quantite.Value = Nothing
            ButtonX4.Enabled = False
            total11.Clear()
            tva.Clear()
            ttc.Clear()
            'Else : MessageBoxEx.Show("Veuillez saisir l'unité de la quantité!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX6_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX6.Click
        Try
            If total11.Text = "" Or tva.Text = "" Or ttc.Text = "" Then
                MessageBoxEx.Show("Vous avez oublié le calcul des totaux !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
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
                If c <> Nothing Then
                    IsConnected("Delete from commercial_offre WHERE code ='" & c & "' limit 1", True)
                    IsConnected("Delete from commercial_offre_bordereauprix WHERE code ='" & c & "' ", True)
                    IsConnected("Delete from commercial_offre_modalite WHERE code ='" & c & "' ", True)
                    Dim erreur As Boolean = False
                    Try
                        'Dim rs = nomcl.Text.Split("-")
                        Dim quary = " INSERT INTO commercial_offre (`idoffre`,`nomcl`,`titre`,`delai_exe`,`code`,`EntréeDate`,`relance`,`code_affaire`,`charge_affaire`,`delai_option`,`idclient`,`valide`) VALUES (NULL,'" & mysql_escape_string(nomcl.Text) & "','" & mysql_escape_string(titre.Text) & "','" & nombre.Text & " " & delai.Text & "','" & c & "', NOW(),'0',NULL," & user_id & ",'" & nombre1.Text & " " & delai1.Text & "',(SELECT idclient FROM commercial_client where RaisonSocial='" & nomcl.Text & "'),'0');"
                        'Clipboard.SetText(quary)
                        If IsConnected(quary, True) = False Then
                            erreur = True
                        End If
                    Catch ex As Exception
                        EnvoiError(ex.Message)
                    End Try
                    Dim type As String = ""
                    For i = 0 To CheckedComboBoxEdit1.Properties.Items.Count - 1
                        If CheckedComboBoxEdit1.Properties.Items(i).CheckState = CheckState.Checked And CheckedComboBoxEdit1.Properties.Items(i).ToString.Contains("%") Then
                            type = "Avance remboursement"
                            Dim val = CheckedComboBoxEdit1.Properties.Items(i).ToString.Split("%")
                            Dim quary = " INSERT INTO commercial_offre_modalite VALUES(NULL,'" & c & "','" & val(0) & "','" & val(1) & "',NOW(),'" & type & "');"
                            'Clipboard.SetText(quary)
                            If IsConnected(quary, True) = False Then erreur = True
                        End If

                    Next
                    For i = 0 To CheckedComboBoxEdit2.Properties.Items.Count - 1
                        If CheckedComboBoxEdit2.Properties.Items(i).CheckState = CheckState.Checked And CheckedComboBoxEdit2.Properties.Items(i).ToString.Contains("%") Then
                            type = "terme paiement"
                            Dim val1 = CheckedComboBoxEdit2.Properties.Items(i).ToString.Split("%")
                            Dim quary1 = " INSERT INTO commercial_offre_modalite VALUES(NULL,'" & c & "','" & val1(0) & "','" & val1(1) & "',NOW(),'" & type & "');"
                            ' Clipboard.SetText(quary1)
                            If IsConnected(quary1, True) = False Then erreur = True
                        End If
                    Next
                    'For i = 0 To ListView2.Items.Count - 1
                    '    Try
                    '        Dim quary = " INSERT INTO commercial_offre_bordereauprix VALUES(NULL,'" & mysql_escape_string(ListView2.Items(i).SubItems(0).Text) & "','" & mysql_escape_string(ListView2.Items(i).SubItems(1).Text) & "','" & ListView2.Items(i).SubItems(2).Text & "','" & ListView2.Items(i).SubItems(3).Text & "','" & ListView2.Items(i).SubItems(4).Text & "','" & ListView2.Items(i).SubItems(5).Text & "','" & total11.Text & "','" & tva.Text & "','" & ttc.Text & "','" & c & "','" & ListView2.Items(i).SubItems(6).Text & "','" & ListView2.Items(i).SubItems(7).Text & "');"
                    '        'Clipboard.SetText(quary)
                    '        If IsConnected(quary, True) = False Then
                    '            erreur = True
                    '        End If
                    '    Catch ex As Exception
                    '        EnvoiError(ex.Message)
                    '    End Try
                    'Next
                    For i = 0 To ListView1.Items.Count - 1
                        Try
                            Dim quary1 As String = " INSERT INTO commercial_offre_bordereauprix (`idBordereauPrix`,`num`,`desig`,`Qt`,`unite`,`PrixUnit`,`Montant`,`total`,`totaltva`,`totalttc`,`code`,`type`,`alaChargeDe`) VALUES(NULL,'" & mysql_escape_string(ListView1.Items(i).SubItems(0).Text) & "','" & mysql_escape_string(ListView1.Items(i).SubItems(1).Text) & "','" & ListView1.Items(i).SubItems(2).Text & "','" & ListView1.Items(i).SubItems(3).Text & "','" & ListView1.Items(i).SubItems(4).Text & "','" & ListView1.Items(i).SubItems(5).Text & "','" & total11.Text & "','" & tva.Text & "','" & ttc.Text & "','" & c & "','D','0');"
                            If IsConnected(quary1, True) = False Then
                                erreur = True
                            End If
                        Catch ex As MySqlException
                            EnvoiError(ex.Message)
                        End Try
                    Next
                    For i = 0 To ListView2.Items.Count - 1
                        Try
                            'MsgBox(ListView1.Items(i).SubItems(6).Text)
                            Dim quary = " INSERT INTO commercial_offre_bordereauprix (`idBordereauPrix`,`num`,`desig`,`Qt`,`unite`,`PrixUnit`,`Montant`,`total`,`totaltva`,`totalttc`,`code`,`type`,`alaChargeDe`) VALUES(NULL,'" & mysql_escape_string(ListView2.Items(i).SubItems(0).Text) & "','" & mysql_escape_string(ListView2.Items(i).SubItems(1).Text) & "','" & ListView2.Items(i).SubItems(2).Text & "','" & ListView2.Items(i).SubItems(3).Text & "','" & ListView2.Items(i).SubItems(4).Text & "','" & ListView2.Items(i).SubItems(5).Text & "',null,null,null,'" & c & "','P','" & ListView2.Items(i).SubItems(6).Text & "');"
                            'Clipboard.SetText(quary)
                            If IsConnected(quary, True) = False Then
                                erreur = True
                            End If
                        Catch ex As MySqlException
                            EnvoiError(ex.Message)
                        End Try
                    Next
                    If erreur = False Then
                        MessageBoxEx.Show("L'offre a bien été Modifier", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ListView2.Items.Clear()
                        nomcl.Text = ""
                        titre.Clear()
                        modalitepaie.Text = ""
                        nombre.Text = ""
                        delai.Text = ""
                        pourcentage.Text = ""
                        total11.Clear()
                        tva.Clear()
                        ttc.Clear()
                        Me.Close()
                    End If
                Else : MessageBoxEx.Show("La somme de pourcentage des modalités dépasse 100%", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX7_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX7.Click
        Try
            ' If unit.SelectedIndex > -1 Then
            Dim List As ListViewItem = New ListViewItem((ListView2.Items.Count + 1).ToString, 1)
            List.SubItems.Add(design.Text)
            List.SubItems.Add(quantite.Text)
            List.SubItems.Add(unit.Text)
            List.SubItems.Add(prixunitaire.Text)
            Select Case unit.Text
                Case "pourcentage"
                    List.SubItems.Add(Math.Round((prixunitaire.Text * quantite.Text) / 100, 2))
                Case "U", "Forfait"
                    Dim f As String = Math.Round((prixunitaire.Text * quantite.Text), 2)
                    If Not f.Contains(",") Then
                        f += ",00"
                    End If
                    List.SubItems.Add(f)
            End Select
            'If RadioButton3.Checked Then
            '    List.SubItems.Add("D")
            '    List.SubItems.Add("A")
            'Else
            '    List.SubItems.Add("P")
            '    If ComboBoxEx1.SelectedIndex = 0 Then
            '        List.SubItems.Add("C")
            '    Else
            '        List.SubItems.Add("A")
            '    End If
            'End If
            If alacharge.SelectedIndex = 0 Then
                List.SubItems.Add("C")
                'A la charge du Client
            Else
                List.SubItems.Add("A")
                'A la charge d'Alieco
            End If
            ListView2.Items.Add(List)
            numero.Clear()
            design.Clear()
            prixunitaire.Value = Nothing
            quantite.Value = Nothing
            total11.Clear()
            tva.Clear()
            ttc.Clear()
            'Else : MessageBoxEx.Show("Veuillez saisir l'unité de la quantité!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class