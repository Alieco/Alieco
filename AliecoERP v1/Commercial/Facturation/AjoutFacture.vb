Imports DevComponents.DotNetBar

Public Class AjoutFacture
    Public MantantDeAffaire As Double = 0
    Public MantantClacule As Double = 0
    Public MantantModalite As Double = 0
    Public MantantRemise As Double = 0
    Public MantantDeduire As Double = 0
    Public MantantFinal As Double = 0
    Public MantantFinalHT As Double = 0
    Public CodeAffaire As String = ""
    Public CodeTemp As String = ""

    Private Sub CodeAffaireTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeAffaireTxt.TextChanged
        Try
            existPasTxt.Visible = False
            MantantDeAffaire = 0
            nomclTxt.Text = ""
            MontantAffaireTxt.Text = ""
            ListView1.Items.Clear()
            ListView2.Items.Clear()
            ListView3.Items.Clear()
            porcentageTxt.Value = 0
            DescTxt.Clear()
            PortcTxt.Value = 0
            deduirTxt.Value = 0
            desinTxt.Clear()
            discriTxt.Clear()
            prixunitaire.Clear()
            qt.Value = 1
            total11.Clear()
            unite.Text = ""
            DescTxt.Clear()
            PortcTxt.Value = 0
            MhtTxt.Clear()
            MtvaTxt.Clear()
            MttcTxt.Clear()
            remiseTxt.Value = 0
            RemiseHTTxt.Clear()
            MantantCalculeARemiseTxt.Clear()
            DHtTxt.Clear()
            DtvaTxt.Clear()
            DttcTxt.Clear()
            TabItem4.Text = "   Remise / debait  "
            TabItem1.Text = "  Désignations / Préstations   "
            TabItem2.Text = "   Modalités (Termes / Avances) de paiement   "
            TabItem3.Text = "   Avance remboursable (à déduire)   "
            MantantDeAffaire = 0
            MantantClacule = 0
            MantantModalite = 0
            MantantRemise = 0
            MantantDeduire = 0
            MantantFinal = 0
            MantantFinalHT = 0
            CodeAffaire = ""
            CodeTemp = ""
            If CodeAffaireTxt.Text.Length > 6 Then
                If IsConnected("SELECT nomcl,total FROM commercial_affaire,commercial_affaire_bordereauprix WHERE commercial_affaire.code_affaire=commercial_affaire_bordereauprix.code and code_affaire='" & mysql_escape_string(CodeAffaireTxt.Text) & "' LIMIT 1", False) Then
                    If myDR.HasRows Then
                        While myDR.Read
                            existPasTxt.Visible = False
                            CodeAffaire = CodeAffaireTxt.Text
                            nomclTxt.Text = myDR("nomcl").ToString
                            MontantAffaireTxt.Text = myDR("total").ToString & " DA (HT)"
                            MantantDeAffaire = myDR("total").ToString
                            MantantClacule = myDR("total").ToString
                            loadDataDP()
                            loadDataAT()
                        End While
                        EnregistrerBtn.Enabled = False
                        TabControlPanel1.Enabled = True
                        TabControlPanel2.Enabled = True
                        TabControlPanel3.Enabled = True
                        TabControlPanel4.Enabled = True
                        RecalculerBtn.Enabled = True
                        ValiderBtn.Enabled = True
                    Else
                        EnregistrerBtn.Enabled = False
                        TabControlPanel1.Enabled = False
                        TabControlPanel2.Enabled = False
                        TabControlPanel3.Enabled = False
                        TabControlPanel4.Enabled = False
                        RecalculerBtn.Enabled = False
                        ValiderBtn.Enabled = False
                        CodeAffaire = ""
                        existPasTxt.Visible = True
                        existPasTxt.ForeColor = Color.Red
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub CheckBoxX2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxX2.CheckedChanged
        Try
            If CheckBoxX2.Checked Then
                CheckBoxX1.Checked = False
                ComboBoxEx1.Enabled = True
                porcentageTxt.Enabled = False
                desinTxt.Enabled = False
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub CheckBoxX1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxX1.CheckedChanged
        Try
            If CheckBoxX1.Checked Then
                CheckBoxX2.Checked = False
                ComboBoxEx1.Enabled = False
                porcentageTxt.Enabled = True
                desinTxt.Enabled = True
                qt.Maximum = 99999999
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub SwitchButton1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SwitchButton1.ValueChanged
        Try
            If SwitchButton1.Value = True Then
                ComboBoxEx1.WatermarkText = "Choisez une Désignation"
                ComboBoxEx1.Text = "Choisez une Désignation"
                ComboBoxEx1.SelectedIndex = -1
                desinTxt.WatermarkText = "Text de désignation"
            Else
                ComboBoxEx1.WatermarkText = "Choisez une Préstation"
                ComboBoxEx1.Text = "Choisez une Préstation"
                ComboBoxEx1.SelectedIndex = -1
                desinTxt.WatermarkText = "Text de préstation"
            End If
            loadDataDP()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub


    'Private Sub porcentageTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not porcentageTxt.Text = String.Empty And Not IsNumeric(porcentageTxt.Text) Then
    '        MessageBoxEx.Show("Vous avez entré un charactaire non valide !", "Error de sesai", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '    End If
    'End Sub
#Region "Function"
    Sub loadDataDP()
        Try
            ComboBoxEx1.Items.Clear()
            If Not CodeAffaire = "" Then
                Dim DP As String = "D"
                If SwitchButton1.Value = False Then
                    DP = "P"
                End If
                IsConnected("SELECT * FROM commercial_affaire_bordereauprix WHERE code='" & CodeAffaire & "' AND type ='" & DP & "'", False)
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        ComboBoxEx1.Items.Add(myDR("idBordereauPrix") & " - " & myDR("desig"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub calculeTotalDP()
        Try
            Dim s As Double = 0
            For i = 0 To ListView1.Items.Count - 1
                If ListView1.Items(i).SubItems(3).Text = "pourcentage" Then
                    ListView1.Items(i).SubItems(5).Text = ListView1.Items(i).SubItems(4).Text / 100 * ListView1.Items(i).SubItems(2).Text
                Else
                    ListView1.Items(i).SubItems(5).Text = ListView1.Items(i).SubItems(4).Text * ListView1.Items(i).SubItems(2).Text
                End If
                s = s + ListView1.Items(i).SubItems(5).Text.Replace(".", ",")
                s = Math.Round(s, 2)
            Next
            If s = 0 Then
                TabItem1.Text = "  Désignations / Préstations   "
                MantantClacule = 0
            Else
                TabItem1.Text = "  Désignations / Préstations   (" & s & " DA /HT)"
                MantantClacule = s
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub loadDataAT()
        Try
            ComboBoxEx3.Items.Clear()
            If Not CodeAffaire = "" Then
                Dim AT As String = "terme paiement"
                If SwitchButton2.Value = False Then
                    AT = "Avance remboursement"
                End If
                IsConnected("SELECT * FROM commercial_affaire_modalite WHERE code='" & CodeAffaire & "' AND type ='" & AT & "'", False)
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        ComboBoxEx3.Items.Add(myDR("idmodalite") & " - " & myDR("description"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub calculeTotalAT()
        Try
            Dim s As Double = 0
            For i = 0 To ListView2.Items.Count - 1
                s = s + ListView2.Items(i).SubItems(3).Text.Replace(".", ",")
                s = Math.Round(s, 2)
            Next
            If s = 0 Then

                TabItem2.Text = "   Modalités (Termes / Avances) de paiement   "
                MantantModalite = 0
            Else
                TabItem2.Text = "   Modalités (Termes / Avances) de paiement (" & s & " DA /HT)"
                MantantModalite = s
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub calculeTotalDR()
        Try
            Dim s As Double = 0
            For i = 0 To ListView3.Items.Count - 1
                s = s + ListView3.Items(i).SubItems(2).Text.Replace(".", ",")
                s = Math.Round(s, 2)
            Next
            If s = 0 Then

                TabItem3.Text = "   Avance remboursable (à déduire)   "
                MantantDeduire = 0
            Else
                TabItem3.Text = "   Avance remboursable (à déduire) (" & s & " DA /HT)"
                MantantDeduire = s
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub calculeChaque()
        Try
            calculeTotalDR()
            calculeTotalAT()
            calculeTotalDP()
            Console.WriteLine(MantantFinal)
            MantantFinal = MantantDeAffaire
            If MantantClacule > 0 Then
                MantantFinal = MantantClacule
                Console.WriteLine(MantantFinal)
            End If
            If MantantModalite > 0 Then
                MantantFinal = MantantModalite
                Console.WriteLine(MantantFinal)
            End If
            If MantantRemise > 0 Then
                MantantFinal = MantantFinal - MantantRemise
                Console.WriteLine(MantantFinal)
            End If
            If MantantDeduire > 0 Then
                MantantFinal = MantantFinal - MantantDeduire
                Console.WriteLine(MantantFinal)
            End If
            MantantFinalHT = MantantFinal
            Console.WriteLine(MantantFinal)
            MantantFinal = Math.Round((MantantFinal * 17 / 100) + MantantFinal, 2)
            Console.WriteLine(MantantFinal)
            MantantChaqueTxt.Text = Math.Round(MantantFinal, 2) & "  DA / TTC"
            MantantChaqueTxt.ForeColor = Color.CadetBlue
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub InsertFacture(Optional ByVal exist As Boolean = False)
        Try
            Dim dp = IIf(MantantClacule > 0, "1", "0")
            Dim at = IIf(MantantModalite > 0, "1", "0")
            Dim D = IIf(MantantDeduire > 0, "1", "0")
            Dim R = IIf(MantantRemise > 0, "1", "0")
            Dim HT = MantantFinalHT
            If NfactureTxt.Text <> "" Then
                IsConnected("DELETE FROM `facturation_facture_dp` WHERE nFacture='" & mysql_escape_string(NfactureTxt.Text) & "'", True)
            End If
            If exist Then
                IsConnected("DELETE FROM `facturation_facture` WHERE nFacture='" & mysql_escape_string(NfactureTxt.Text) & "' LIMIT 1", True)
            End If
            If dp = "1" Then
                For Each item As ListViewItem In ListView1.Items
                    IsConnected("INSERT INTO `facturation_facture_dp`VALUES(NULL," & item.Text & ",'" & mysql_escape_string(item.SubItems(1).Text) & "','" & mysql_escape_string(item.SubItems(6).Text) & "','" & mysql_escape_string(item.SubItems(2).Text) & "','" & mysql_escape_string(item.SubItems(3).Text) & "','" & mysql_escape_string(item.SubItems(4).Text) & "','" & mysql_escape_string(item.SubItems(5).Text) & "','" & mysql_escape_string(item.SubItems(7).Text) & "','" & mysql_escape_string(NfactureTxt.Text) & "');", True)
                Next
            End If
            If at = "1" Then
                For Each item As ListViewItem In ListView2.Items
                    '  MsgBox(mysql_escape_string(item.SubItems(5).Text))
                    IsConnected("INSERT INTO `facturation_facture_at`VALUES(NULL,'" & mysql_escape_string(item.Text) & "','" & mysql_escape_string(item.SubItems(1).Text) & "','" & mysql_escape_string(item.SubItems(2).Text) & "','" & mysql_escape_string(item.SubItems(3).Text) & "','" & mysql_escape_string(item.SubItems(5).Text) & "','" & mysql_escape_string(NfactureTxt.Text) & "');", True)
                Next
            End If
            If R = "1" Then
                Dim re As String = "Remise"
                If RadioButton2.Checked Then re = "Debait"
                IsConnected("INSERT INTO `facturation_facture_remise` VALUES(NULL,'" & re & "','" & remiseTxt.Text & "','" & RemiseHTTxt.Text & "','" & mysql_escape_string(NfactureTxt.Text) & "');", True)
            End If
            If D = "1" Then
                For Each item As ListViewItem In ListView3.Items
                    IsConnected("INSERT INTO `facturation_facture_deduire`VALUES(NULL,'" & mysql_escape_string(item.Text) & "','" & mysql_escape_string(item.SubItems(1).Text) & "','" & mysql_escape_string(item.SubItems(2).Text) & "','" & mysql_escape_string(item.SubItems(4).Text) & "','" & mysql_escape_string(NfactureTxt.Text) & "');", True)
                Next
            End If
            If IsConnected("INSERT INTO `facturation_facture` VALUES(NULL,'" & CodeAffaire & "','" & mysql_escape_string(NfactureTxt.Text) & "','" & mysql_escape_string(NRefTxt.Text) & "','" & mysql_escape_string(VCommandeTxt.Text) & "','" & HT & "','" & mysql_escape_string(MantantFinal) & "','" & dp & "','" & at & "','" & D & "','" & R & "',NOW());", True) Then
                MessageBoxEx.Show("La facture : " & NfactureTxt.Text & " a bien ete enregistrer !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If CodeTemp <> "" Then
                    IsConnected("update commercial_ordre_facturation set etat_facture='1' where rando ='" & CodeTemp & "'", True)
                    Mainfrm.listOrdre.NotificationMarkText -= 1
                    Dim l As New ListOrdreFactureNonFacture
                    l.ButtonX2.PerformClick()
                End If
                CodeAffaireTxt.Clear()
            Else
                MessageBoxEx.Show("La facture : " & NfactureTxt.Text & " n'a pas ete enregistrer !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub LoadOrdreFacture()
        Try
            If CodeTemp <> "" Then
                IsConnected("SELECT * FROM commercial_affaire_bordereauprix, commercial_ordre_facture WHERE commercial_affaire_bordereauprix.idBordereauPrix=commercial_ordre_facture.valeur and rando='" & CodeTemp & "' and code='" & CodeAffaire & "' AND commercial_ordre_facture.type ='B'", False)
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        Dim L As ListViewItem = New ListViewItem(myDR("idBordereauPrix").ToString.Replace(",00", ""))
                        L.SubItems.Add(myDR("desig").ToString)
                        L.SubItems.Add(myDR("Qt").ToString.Replace(".", ","))
                        L.SubItems.Add(myDR("unite").ToString)
                        L.SubItems.Add(myDR("PrixUnit").ToString.Replace(".", ","))
                        L.SubItems.Add(myDR("Montant").ToString.Replace(".", ","))
                        L.SubItems.Add("")
                        If myDR("type") = "D" Then
                            L.SubItems.Add("D")
                        Else
                            L.SubItems.Add("P")
                        End If
                        ListView1.Items.Add(L)
                    End While
                End If
                Dim v As Double = 0
                IsConnected("SELECT * FROM commercial_affaire_modalite, commercial_ordre_facture WHERE commercial_affaire_modalite.idmodalite=commercial_ordre_facture.valeur and rando='" & CodeTemp & "' and code='" & CodeAffaire & "' AND commercial_ordre_facture.type ='M'", False)
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        Try
                            Dim L1 As ListViewItem = New ListViewItem(myDR("idmodalite").ToString.Replace(",00", ""))
                            L1.SubItems.Add(myDR("valeurpour").ToString.Replace(".", ","))
                            L1.SubItems.Add(myDR("description").ToString)
                            L1.SubItems.Add(myDR("montant").ToString.Replace(".", ","))
                            L1.SubItems.Add(Math.Round(17 * myDR("montant") / 100, 2))
                            L1.SubItems.Add(myDR("montant").Replace(".", ",") + Math.Round(17 * myDR("montant") / 100, 2))
                            If myDR("type").ToString = "terme paiement" Then
                                L1.SubItems.Add("T")
                            Else
                                L1.SubItems.Add("A")
                            End If

                            ListView2.Items.Add(L1)
                        Catch ex As Exception
                            Console.WriteLine(ex.Message)
                        End Try
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub ComboBoxEx1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEx1.SelectedIndexChanged
        Try
            qt.Value = 1
            desinTxt.Text = ""
            porcentageTxt.Text = ""
            unite.Text = ""
            discriTxt.Text = ""
            prixunitaire.Text = ""
            total11.Text = ""
            If ComboBoxEx1.SelectedIndex > -1 Then
                Dim num = ComboBoxEx1.Text.Split(" - ")
                IsConnected("SELECT * FROM commercial_affaire_bordereauprix WHERE code='" & CodeAffaire & "' and idBordereauPrix=" & num(0) & " LIMIT 1", False)
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        Dim a = myDR("Qt").ToString().Replace(".00", "")
                        If myDR("unite") = "pourcentage" Then
                            qt.Maximum = 100
                        Else
                            qt.Maximum = a
                        End If

                        qt.Value = a
                        desinTxt.Text = myDR("desig").ToString
                        porcentageTxt.Text = myDR("idBordereauPrix").ToString
                        unite.Text = myDR("unite")
                        ' discriTxt.Text = IIf(IsDBNull(myDR("description")), "", myDR("description").ToString)
                        prixunitaire.Text = myDR("PrixUnit").Replace(".", ",")
                        If myDR("unite").ToString = "unité" Then
                            total11.Text = qt.Value * CDbl(prixunitaire.Text)
                        ElseIf myDR("unite").ToString = "ensemble" Then
                            total11.Text = qt.Value * CDbl(prixunitaire.Text)
                        ElseIf myDR("unite").ToString = "pourcentage" Then
                            total11.Text = (qt.Value * CDbl(prixunitaire.Text)) / 100
                        End If
                    End While
                End If
                Dim i = 0
                For i = 0 To ListView1.Items.Count - 2
                    If ListView1.Items(i).Text.Replace(",00", "") = num(0) Then
                        discriTxt.Text = ListView1.Items(i).SubItems(6).Text
                        ListView1.Items(i).Remove()
                    End If
                Next

                Dim L1 As ListViewItem = New ListViewItem(porcentageTxt.Text)
                L1.SubItems.Add(desinTxt.Text)
                L1.SubItems.Add(qt.Value)
                L1.SubItems.Add(unite.Text)
                L1.SubItems.Add(prixunitaire.Text)
                L1.SubItems.Add(total11.Text)
                L1.SubItems.Add(discriTxt.Text)
                If SwitchButton1.Value = True Then
                    L1.SubItems.Add("D")
                Else
                    L1.SubItems.Add("P")
                End If
                ListView1.Items.Add(L1)
                calculeTotalDP()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            If porcentageTxt.Text <> "" And desinTxt.Text <> "" Then
                Dim id = ComboBoxEx1.Text.Split(" - ")
                For i = 0 To ListView1.Items.Count - 1
                    If ListView1.Items(i).Text = id(0) Then
                        ListView1.Items(i).Remove()
                        Exit For
                    End If
                Next
                Dim L As ListViewItem = New ListViewItem(id(0))
                L.SubItems.Add(desinTxt.Text)
                L.SubItems.Add(qt.Value)
                L.SubItems.Add(unite.Text)
                L.SubItems.Add(prixunitaire.Text)
                L.SubItems.Add(total11.Text)
                L.SubItems.Add(discriTxt.Text)
                If SwitchButton1.Value = True Then
                    L.SubItems.Add("D")
                Else
                    L.SubItems.Add("P")
                End If
                ListView1.Items.Add(L)
                '  IsConnected("UPDATE commercial_ordre_facture SET description='" & mysql_escape_string(discriTxt.Text) & "' WHERE id_commercial_ordre_facture =" & id(0) & " LIMIT 1", True)
                calculeTotalDP()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            If ListView1.SelectedItems.Count = 1 Then
                rmvBtn.Visible = True
            Else
                rmvBtn.Visible = False
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub rmvBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rmvBtn.Click
        Try
            If MessageBoxEx.Show("Ete vous sure de vouloir effacer cette ligne ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                ListView1.SelectedItems(0).Remove()
            End If
            rmvBtn.Visible = False
            calculeTotalDP()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub qt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qt.ValueChanged
        Try
            If prixunitaire.Text <> "" And IsNumeric(prixunitaire.Text) Then
                If unite.Text.Contains("unité") Then
                    total11.Text = qt.Value * CDbl(prixunitaire.Text)
                ElseIf unite.Text.Contains("ensemble") Then
                    total11.Text = qt.Value * CDbl(prixunitaire.Text)
                ElseIf unite.Text.Contains("pourcentage") Then
                    total11.Text = (qt.Value * CDbl(prixunitaire.Text)) / 100
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub unite_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unite.SelectedIndexChanged
        Try
            If unite.SelectedIndex > -1 Then
                If prixunitaire.Text <> "" And IsNumeric(prixunitaire.Text) Then
                    If unite.Text.Contains("unité") Then
                        total11.Text = qt.Value * CDbl(prixunitaire.Text)
                    ElseIf unite.Text.Contains("ensemble") Then
                        total11.Text = qt.Value * CDbl(prixunitaire.Text)
                    ElseIf unite.Text.Contains("pourcentage") Then
                        total11.Text = (qt.Value * CDbl(prixunitaire.Text)) / 100
                    End If
                End If
            End If
            If unite.SelectedIndex = 2 Then
                qt.Maximum = 100

            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub prixunitaire_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prixunitaire.TextChanged
        Try
            If prixunitaire.Text <> "" And IsNumeric(prixunitaire.Text) Then
                If unite.Text.Contains("unité") Then
                    total11.Text = qt.Value * CDbl(prixunitaire.Text)
                ElseIf unite.Text.Contains("ensemble") Then
                    total11.Text = qt.Value * CDbl(prixunitaire.Text)
                ElseIf unite.Text.Contains("pourcentage") Then
                    total11.Text = (qt.Value * CDbl(prixunitaire.Text)) / 100
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub AjoutFacture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CodeAffaireTxt.Focus()
            CodeAffaireTxt.Select()
            'CodeTemp = ListOrdreFactureNonFacture.GridView1.GetFocusedRowCellValue("CodeReference").ToString()
            If CodeTemp <> "" Then
                'MsgBox(CodeTemp)
                LoadOrdreFacture()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub SwitchButton2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SwitchButton2.ValueChanged
        Try
            If SwitchButton1.Value = True Then
                ComboBoxEx3.WatermarkText = "Choisez un Terme de paiement"
                ComboBoxEx3.Text = "Choisez un Terme de paiement"
                ComboBoxEx3.SelectedIndex = -1
                desinTxt.WatermarkText = "Text de Terme de paiement "
            Else
                ComboBoxEx1.WatermarkText = "Choisez une avance non rembourssable"
                ComboBoxEx1.Text = "Choisez une avance non rembourssable"
                ComboBoxEx1.SelectedIndex = -1
                desinTxt.WatermarkText = "Text d' avance non rembourssable"
            End If
            loadDataAT()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub CheckBoxX3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxX3.CheckedChanged
        Try
            If CheckBoxX3.Checked Then
                CheckBoxX4.Checked = False
                ComboBoxEx3.Enabled = True
                PortcTxt.Enabled = False
                DescTxt.Enabled = False
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub CheckBoxX4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxX4.CheckedChanged
        Try
            If CheckBoxX4.Checked Then
                CheckBoxX3.Checked = False
                ComboBoxEx3.Enabled = False
                PortcTxt.Enabled = True
                DescTxt.Enabled = True
                PortcTxt.MaxValue = 100
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ComboBoxEx3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEx3.SelectedIndexChanged
        Try
            PortcTxt.Value = 0
            DescTxt.Text = ""
            MhtTxt.Text = ""
            MtvaTxt.Text = ""
            MttcTxt.Text = ""
            If ComboBoxEx3.SelectedIndex > -1 Then
                Dim num = ComboBoxEx3.Text.Split(" - ")
                IsConnected("SELECT * FROM commercial_affaire_modalite WHERE code='" & CodeAffaire & "' and idmodalite=" & num(0) & " LIMIT 1", False)
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        '  MsgBox(myDR("valeur").ToString().Replace("%", ""))
                        If myDR("valeurpour").ToString().Replace("%", "") > 0 Then
                            PortcTxt.Value = myDR("valeurpour").ToString().Replace("%", "")
                        Else
                            PortcTxt.Value = 0
                        End If

                        DescTxt.Text = myDR("description").ToString
                        MsgBox(MantantClacule)
                        MhtTxt.Text = MantantClacule * myDR("valeurpour").ToString().Replace("%", "") / 100
                    End While
                End If
                Dim i = 0
                For i = 0 To ListView2.Items.Count - 1
                    If ListView2.Items(i).Text.Replace(",00", "") = num(0) Then
                        ListView2.Items(i).Remove()
                        Exit For
                    End If
                Next

                Dim L1 As ListViewItem = New ListViewItem(num(0))
                L1.SubItems.Add(PortcTxt.Text)
                L1.SubItems.Add(DescTxt.Text)
                L1.SubItems.Add(MhtTxt.Text)
                L1.SubItems.Add(MtvaTxt.Text)
                L1.SubItems.Add(MttcTxt.Text)
                If SwitchButton1.Value = True Then
                    L1.SubItems.Add("T")
                Else
                    L1.SubItems.Add("A")
                End If

                ListView2.Items.Add(L1)
                calculeTotalAT()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    'Private Sub PortcTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If PortcTxt.Value > 0 Then
    '        MhtTxt.Text = Math.Round(MantantClacule * PortcTxt.Text / 100, 2)
    '    Else

    '    End If

    'End Sub

    Private Sub MhtTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MhtTxt.TextChanged
        Try
            If MhtTxt.Text <> String.Empty Then
                MtvaTxt.Text = Math.Round(17 * MhtTxt.Text / 100, 2)
                MttcTxt.Text = Math.Round(CDbl(MhtTxt.Text) + CDbl(MtvaTxt.Text), 2)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub MtvaTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MtvaTxt.TextChanged
        Try
            If MhtTxt.Text <> String.Empty Then
                MtvaTxt.Text = Math.Round(17 * MhtTxt.Text / 100, 2)
                MttcTxt.Text = Math.Round(CDbl(MhtTxt.Text) + CDbl(MtvaTxt.Text), 2)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ListView2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView2.SelectedIndexChanged
        Try
            If ListView2.SelectedItems.Count = 1 Then
                rmvBtn2.Visible = True
            Else
                rmvBtn2.Visible = False
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub rmvBtn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rmvBtn2.Click
        Try
            If MessageBoxEx.Show("Ete vous sure de vouloir effacer cette ligne ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                ListView2.SelectedItems(0).Remove()
            End If
            rmvBtn2.Visible = False
            calculeTotalAT()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

 
    'Private Sub remiseTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    MantantCalculeARemiseTxt.Text = ""
    '    RemiseHTTxt.Text = ""
    '    If remiseTxt.Text <> "" Then
    '        If remiseTxt.Text > 0 Then
    '            If remiseTxt.Text > 100 Then
    '                MessageBoxEx.Show("Vous evez depacer les 100% de remise", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Else
    '                If MantantModalite > 0 Then
    '                    RemiseHTTxt.Text = Math.Round(remiseTxt.Text * MantantModalite / 100, 2)
    '                    MantantRemise = Math.Round(remiseTxt.Text * MantantModalite / 100, 2)
    '                    MantantCalculeARemiseTxt.Text = Math.Round(MantantModalite - MantantRemise, 2)
    '                    Label7.Text = "Le mantant de la Modalité apres la remise (HT):"
    '                ElseIf MantantClacule > 0 Then
    '                    RemiseHTTxt.Text = Math.Round(remiseTxt.Text * MantantClacule / 100, 2)
    '                    MantantRemise = Math.Round(remiseTxt.Text * MantantClacule / 100, 2)
    '                    MantantCalculeARemiseTxt.Text = Math.Round(MantantClacule - MantantRemise, 2)
    '                    Label7.Text = "Le mantant de la Désignation apres la remise (HT) :"
    '                Else
    '                    RemiseHTTxt.Text = Math.Round(remiseTxt.Text * MantantDeAffaire / 100, 2)
    '                    MantantRemise = Math.Round(remiseTxt.Text * MantantDeAffaire / 100, 2)
    '                    MantantCalculeARemiseTxt.Text = Math.Round(MantantDeAffaire - MantantRemise, 2)
    '                    Label7.Text = "Le mantant de l'affaire apres la remise (HT) :"
    '                End If
    '                TabItem4.Text = "   Remise / debait  (" & MantantRemise & " DA /HT)"
    '            End If
    '        Else
    '            TabItem4.Text = "   Remise / debait  "
    '            MantantRemise = 0
    '        End If
    '    Else
    '        TabItem4.Text = "   Remise / debait  "
    '        MantantRemise = 0
    '    End If

    'End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            MantantCalculeARemiseTxt.Text = ""
            RemiseHTTxt.Text = ""
            remiseTxt.Text = ""
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    'Private Sub deduirTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub

    Private Sub RtvaTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtvaTxt.TextChanged
        Try
            If DHtTxt.Text <> String.Empty Then
                DtvaTxt.Text = Math.Round(17 * DHtTxt.Text / 100, 2)
                DttcTxt.Text = Math.Round(CDbl(DHtTxt.Text) + CDbl(DtvaTxt.Text), 2)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub


    Private Sub ValiderBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValiderBtn.Click
        Try
            If NfactureTxt.Text = "" Then
                MessageBoxEx.Show("Vous avez oublié de mettre le N° de facture", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If NRefTxt.Text = "" Then
                MessageBoxEx.Show("Vous avez oublié de mettre le N° de reference", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If NRefTxt.Text = "" Then
                MessageBoxEx.Show("Vous avez oublié de mettre le N° de reference", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If MessageBoxEx.Show("Ete vous sure de vouloir VALIDER cette Facture ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                EnregistrerBtn.Enabled = True
                TabControlPanel1.Enabled = False
                TabControlPanel2.Enabled = False
                TabControlPanel3.Enabled = False
                TabControlPanel4.Enabled = False
                RecalculerBtn.Enabled = False
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub RecalculerBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecalculerBtn.Click
        Try
            calculeChaque()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX5.Click
        Try
            If deduirTxt.Text <> "" And detTxt.Text <> "" Then
                Dim l As ListViewItem = New ListViewItem(deduirTxt.Text)
                l.SubItems.Add(detTxt.Text)
                l.SubItems.Add(DHtTxt.Text)
                l.SubItems.Add(DtvaTxt.Text)
                l.SubItems.Add(DttcTxt.Text)
                ListView3.Items.Add(l)
            Else
                MessageBoxEx.Show("Veuillez remplir les champs vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            calculeTotalDR()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub DHtTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DHtTxt.TextChanged
        Try
            If DHtTxt.Text <> String.Empty Then
                DtvaTxt.Text = Math.Round(17 * DHtTxt.Text / 100, 2)
                DttcTxt.Text = Math.Round(CDbl(DHtTxt.Text) + CDbl(DtvaTxt.Text), 2)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub EnregistrerBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnregistrerBtn.Click
        Try
            If CodeAffaireTxt.Text <> "" And MantantChaqueTxt.Text <> "" And NfactureTxt.Text <> "" And VCommandeTxt.Text <> "" And NRefTxt.Text <> "" Then
                If IsConnected("SELECT * FROM facturation_facture WHERE nFacture='" & mysql_escape_string(NfactureTxt.Text) & "' LIMIT 1", False) Then
                    If myDR.HasRows Then
                        If MessageBoxEx.Show("Le N° de facture : " & NfactureTxt.Text & " existe déja dans la base des donneé" & Environment.NewLine & "Voullez vous l'ecraser ? " & Environment.NewLine & "ATTENTION: cette action est irreversible, lorsque les données sont ecrasés vous ne pouvez pas les recuperer", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                            InsertFacture(True)
                        End If
                    Else
                        InsertFacture()
                    End If
                End If
            Else
                MessageBoxEx.Show("Veuillez remplir les champs vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rmvBtn3.Click
        Try
            If MessageBoxEx.Show("Ete vous sure de vouloir effacer cette ligne ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                ListView3.SelectedItems(0).Remove()
            End If
            rmvBtn3.Visible = False
            calculeTotalDR()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ListView3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView3.SelectedIndexChanged
        Try
            If ListView3.SelectedItems.Count = 1 Then
                rmvBtn3.Visible = True
            Else
                rmvBtn3.Visible = False
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Try
            Dim num = ComboBoxEx3.Text.Split(" - ")
            Dim i = 0
            For i = 0 To ListView2.Items.Count - 1
                If ListView2.Items(i).Text.Replace(",00", "") = num(0) Then
                    ListView2.Items(i).Remove()
                    Exit For
                End If
            Next
            Dim L1 As ListViewItem = New ListViewItem(num(0))
            L1.SubItems.Add(PortcTxt.Text)
            L1.SubItems.Add(DescTxt.Text)
            L1.SubItems.Add(MhtTxt.Text)
            L1.SubItems.Add(MtvaTxt.Text)
            L1.SubItems.Add(MttcTxt.Text)
            If SwitchButton1.Value = True Then
                L1.SubItems.Add("T")
            Else
                L1.SubItems.Add("A")
            End If
            ListView2.Items.Add(L1)
            calculeTotalAT()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub porcentageTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If Not porcentageTxt.Text = String.Empty And Not IsNumeric(porcentageTxt.Text) Then
                MessageBoxEx.Show("Vous avez entré un charactaire non valide !", "Error de sesai", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub PortcTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PortcTxt.ValueChanged
        Try
            If PortcTxt.Value > 0 Then
                MhtTxt.Text = Math.Round(MantantClacule * PortcTxt.Text / 100, 2)
            Else

            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub remiseTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles remiseTxt.ValueChanged
        Try
            MantantCalculeARemiseTxt.Text = ""
            RemiseHTTxt.Text = ""
            If remiseTxt.Text <> "" Then
                If remiseTxt.Text > 0 Then
                    If remiseTxt.Text > 100 Then
                        MessageBoxEx.Show("Vous evez depacer les 100% de remise", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        If MantantModalite > 0 Then
                            RemiseHTTxt.Text = Math.Round(remiseTxt.Text * MantantModalite / 100, 2)
                            MantantRemise = Math.Round(remiseTxt.Text * MantantModalite / 100, 2)
                            MantantCalculeARemiseTxt.Text = Math.Round(MantantModalite - MantantRemise, 2)
                            Label7.Text = "Le mantant de la Modalité apres la remise (HT):"
                        ElseIf MantantClacule > 0 Then
                            RemiseHTTxt.Text = Math.Round(remiseTxt.Text * MantantClacule / 100, 2)
                            MantantRemise = Math.Round(remiseTxt.Text * MantantClacule / 100, 2)
                            MantantCalculeARemiseTxt.Text = Math.Round(MantantClacule - MantantRemise, 2)
                            Label7.Text = "Le mantant de la Désignation apres la remise (HT) :"
                        Else
                            RemiseHTTxt.Text = Math.Round(remiseTxt.Text * MantantDeAffaire / 100, 2)
                            MantantRemise = Math.Round(remiseTxt.Text * MantantDeAffaire / 100, 2)
                            MantantCalculeARemiseTxt.Text = Math.Round(MantantDeAffaire - MantantRemise, 2)
                            Label7.Text = "Le mantant de l'affaire apres la remise (HT) :"
                        End If
                        TabItem4.Text = "   Remise / debait  (" & MantantRemise & " DA /HT)"
                    End If
                Else
                    TabItem4.Text = "   Remise / debait  "
                    MantantRemise = 0
                End If
            Else
                TabItem4.Text = "   Remise / debait  "
                MantantRemise = 0
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub deduirTxt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deduirTxt.ValueChanged
        Try
            DHtTxt.Text = ""
            DttcTxt.Text = ""
            DtvaTxt.Text = ""
            If deduirTxt.Text <> "" Then
                If deduirTxt.Text <= 100 Then
                    If MantantRemise > 0 Then
                        'Mantant avec remise
                        If MantantModalite > 0 Then
                            DHtTxt.Text = Math.Round(deduirTxt.Text * (MantantModalite - MantantRemise) / 100, 2)
                        ElseIf MantantClacule > 0 Then
                            DHtTxt.Text = Math.Round(deduirTxt.Text * (MantantClacule - MantantRemise) / 100, 2)
                        Else
                            DHtTxt.Text = Math.Round(deduirTxt.Text * (MantantDeAffaire - MantantRemise) / 100, 2)
                        End If
                    Else
                        'mantant sans remise
                        If MantantModalite > 0 Then
                            DHtTxt.Text = Math.Round(deduirTxt.Text * MantantModalite / 100, 2)
                        ElseIf MantantClacule > 0 Then
                            DHtTxt.Text = Math.Round(deduirTxt.Text * MantantClacule / 100, 2)
                        Else
                            DHtTxt.Text = Math.Round(deduirTxt.Text * MantantDeAffaire / 100, 2)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class