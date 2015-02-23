Public Class SuiviFacturation
    Dim code As String = ""
    Dim cr As Double = 0
    Private Sub SuiviFacturation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            loadAffaire()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub loadAffaire()
        Try
            ComboBoxEx1.Items.Clear()
            IsConnected("SELECT code_affaire FROM commercial_affaire ORDER BY idoffre DESC ", False)
            If myDR.HasRows Then
                While myDR.Read
                    ComboBoxEx1.Items.Add(myDR("code_affaire").ToString)
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ComboBoxEx1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEx1.SelectedIndexChanged
        Try
            ListView1.Items.Clear()
            objet.Text = ""
            montanttxt.Text = ""
            nReg.Text = ""
            du.Text = ""
            montantttc.Text = ""
            LabelX8.Text = ""
            cr = 0
            Dim nom As String = ""
            Dim n(2) As String
            If ComboBoxEx1.Text <> "" Then
                IsConnected("SELECT * FROM commercial_affaire, users WHERE charge_affaire=user_id AND code_affaire ='" & ComboBoxEx1.Text & "' ", False)
                If myDR.HasRows Then
                    While myDR.Read
                        LabelX8.Text = myDR("fullname").ToString
                        nom = myDR("nomcl").ToString
                        n = nom.Split("-")
                        etatTxt.Text = n(0)
                        objet.Text = n(1)
                        'delaiexe.Text = myDR("delai_exe").ToString
                        Dim d As DateTime = myDR("EntréeDate").ToString
                        du.Text = d.Year
                        code = myDR("code").ToString
                    End While
                End If
                IsConnected("SELECT * FROM commercial_client WHERE NomClient='" & n(0) & "' ", False)
                If myDR.HasRows Then
                    While myDR.Read
                        nReg.Text = myDR("NRC").ToString
                        identifFisc.Text = myDR("NIdentif_fiscale").ToString
                        impot.Text = myDR("NArticle_imposition").ToString
                    End While
                End If
                IsConnected("SELECT totalttc, total FROM commercial_affaire_bordereauprix WHERE code ='" & ComboBoxEx1.Text & "' order by idBordereauPrix desc limit 1 ", False)
                If myDR.HasRows Then
                    While myDR.Read
                        montanttxt.Text = myDR("total").ToString & " DA/HT"
                        montantttc.Text = myDR("totalttc").ToString & " DA/TTC"
                        cr = myDR("total").ToString
                    End While
                End If
                loadFacture()
                CalcCreance()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            IsConnected("UPDATE commercial_affaire_modalite SET montant='" & montantmodalite.Text & "',ddepot='" & DateTimeInput1.Text & "',reglement='" & reglementtxt.Text & "' WHERE idModalite = " & nemoro.Text & " LIMIT 1", True)
            'Clipboard.SetText("UPDATE commercial_affaire_bordereauprix SET montant='" & montantmodalite.Text & "',ddepot='" & DateTimeInput1.Text & "',montant='" & montantmodalite.Text & "' WHERE idBordereauPrix = " & nemoro.Text & " LIMIT 1")
            loadModalite()
            GroupBox2.Visible = False
            GroupBox1.Height = 157
            ListView1.Height = 364
            ListView1.Location = New Point(9, 164)
            CalcCreance()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Try
            If ListView1.SelectedItems.Count > 0 Then
                GroupBox2.Visible = True
                GroupBox1.Height = 315
                ListView1.Height = 236
                ListView1.Location = New Point(9, 308)
                modalite.Text = ListView1.SelectedItems(0).Text
                montantmodalite.Text = ListView1.SelectedItems(0).SubItems(3).Text
                DateTimeInput1.Value = IIf(ListView1.SelectedItems(0).SubItems(4).Text = "", Date.Now.Date, ListView1.SelectedItems(0).SubItems(4).Text)
                reglementtxt.Text = ListView1.SelectedItems(0).SubItems(5).Text
                nemoro.Text = ListView1.SelectedItems(0).SubItems(1).Text
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub loadModalite()
        Try
            ListView1.Items.Clear()
            IsConnected("SELECT * FROM commercial_affaire_modalite WHERE code ='" & code & "'", False)
            If myDR.HasRows Then
                While myDR.Read
                    Dim item As ListViewItem = New ListViewItem(myDR("description").ToString)
                    item.SubItems.Add(myDR("idmodalite").ToString)
                    item.SubItems.Add(myDR("datemodalite").ToString.Remove(10))
                    item.SubItems.Add(myDR("montant").ToString)
                    item.SubItems.Add(myDR("ddepot").ToString)
                    item.SubItems.Add(myDR("reglement").ToString)
                    ListView1.Items.Add(item)
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub


    Private Sub etatTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles etatTxt.TextChanged
        Try
            If etatTxt.Text.Length >= 7 And etatTxt.Text.Length <= 9 Then
                IsConnected("SELECT * FROM commercial_affaire, users WHERE charge_affaire=user_id AND code_affaire ='" & etatTxt.Text & "' ", False)

                If myDR.HasRows Then
                    While myDR.Read
                        LabelX8.Text = myDR("fullname").ToString
                        'delaiexe.Text = myDR("delai_exe").ToString
                        du.Text = myDR("entréedate").ToString
                        code = myDR("code").ToString
                    End While
                End If
                IsConnected("SELECT totalttc FROM commercial_affaire_bordereauprix WHERE code ='" & code & "' order by idBordereauPrix desc limit 1 ", False)
                If myDR.HasRows Then
                    While myDR.Read
                        montanttxt.Text = myDR("totalttc").ToString & " DA/TTC"
                    End While
                End If
                loadModalite()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub CalcCreance()
        Try
            Dim t As Double = 0
            Dim ht As Double = 0
            Dim ttc As Double = 0
            Dim creance As Double = 0
            For i = 0 To ListView1.Items.Count - 1
                If ListView1.Items(i).SubItems(6).Text <> "" And IsNumeric(ListView1.Items(i).SubItems(6).Text) Then
                    ttc += IIf(ListView1.Items(i).SubItems(6).Text = "", 0, ListView1.Items(i).SubItems(6).Text)
                End If
                If ListView1.Items(i).SubItems(2).Text <> "" And IsNumeric(ListView1.Items(i).SubItems(2).Text) Then
                    ht += IIf(ListView1.Items(i).SubItems(2).Text = "", 0, ListView1.Items(i).SubItems(2).Text)
                End If
            Next
            htTxt.Text = ht & " DA/HT"
            ttcTxt.Text = ttc & " DA/TTC"
            If cr <> 0 Then
                If ht > cr Then
                    creancetxt.Text = "Erreur dans les valeur , le montant des factures plus grand que le montant d'affaire" & Environment.NewLine & "{Montant factures: " & ht & "DA/HT , Montant Affaire : " & montanttxt.Text & "}"
                    creancetxt.Font = New Font("Segoe UI Light", 11, FontStyle.Bold)
                    creancetxt.ForeColor = Color.Red
                    creancetxt.Size = New Size(614, 60)
                Else
                    creancetxt.Text = (cr - ht) & " DA/HT"
                    creancetxt.ForeColor = Color.Red
                    creancetxt.Font = New Font("Segoe UI Light", 16, FontStyle.Bold)
                    creancetxt.Size = New Size(614, 27)
                End If
            Else
                creancetxt.Text = "Erreur dans calcule de creance le monatnt d'affaire (HT) et vide !"
                creancetxt.Font = New Font("Segoe UI Light", 11, FontStyle.Bold)
                creancetxt.Size = New Size(614, 27)
                creancetxt.ForeColor = Color.Red
            End If
            'creancetxt.Text = cr - t
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub SuiviFacturation_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            objet.Clear()
            ComboBoxEx1.Text = Nothing
            etatTxt.Clear()
            montanttxt.Clear()
            nReg.Clear()
            du.Text = Nothing
            montantttc.Clear()
            LabelX8.Text = ""
            creancetxt.Text = ""
            ListView1.Items.Clear()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub loadFacture()
        Try
            ListView1.Items.Clear()
            IsConnected("SELECT * FROM facturation_facture WHERE code_affaire ='" & ComboBoxEx1.Text & "'", False)
            If myDR.HasRows Then
                While myDR.Read
                    Dim d As DateTime = myDR("entry_date").ToString
                    Dim item As ListViewItem = New ListViewItem(d.Day & "/" & d.Month & "/" & d.Year)
                    item.SubItems.Add(myDR("nFacture").ToString)
                    item.SubItems.Add(myDR("MantantHT").ToString)
                    item.SubItems.Add(myDR("MantantFactureTTC").ToString)
                    item.SubItems.Add("")
                    item.SubItems.Add("")
                    item.SubItems.Add(myDR("MantantFactureTTC").ToString)
                    item.SubItems.Add("")
                    item.SubItems.Add(myDR("TitreCommande").ToString)
                    ListView1.Items.Add(item)
                End While
            End If
            For i = 0 To ListView1.Items.Count - 1
                IsConnected("SELECT SUM(deduire_ttc) as avance FROM facturation_facture_deduire WHERE nFacture='" & ListView1.Items(i).SubItems(1).Text & "'", False)
                If myDR.HasRows Then
                    While myDR.Read
                        ListView1.Items(i).SubItems(4).Text = myDR("avance").ToString & " DA/TTC"
                    End While
                End If
            Next
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            Dim rap As New ficheSuiveuseRPP
            rap.codeaff = ComboBoxEx1.Text
            rap.ShowDialog()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class