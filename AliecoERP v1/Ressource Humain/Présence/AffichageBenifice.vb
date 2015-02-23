Imports DevComponents.DotNetBar
Public Class AffichageBenifice
    Public moianpr As String = ""
 
    Private Sub mat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mat.TextChanged
        Try
            'datej.Focus()
            If mat.Text.Length = 5 And datej.Text <> "" And datej.Text.Length = 6 Then
                ListView1.Items.Clear()
                'Nom,Prénom,Fonction,Ech,Cat,S_B_01_14,Direction,sit_fam,codesection,ncompte_bancaire,total_impots,total_ss,total_gain,total_retenue,net_payer,paie_mensuel.moi_annee,paie_mensuel.tauxhoraire
                IsConnected("SELECT * FROM Employes,paie_mensuel,code_papers  WHERE Employes.Matricule=paie_mensuel.Matricule and code_papers.Matricule=paie_mensuel.Matricule  and paie_mensuel.type='B' and moi_annee='" & datej.Text & "' and paie_mensuel.Matricule=" & mat.Text, False)
                If myDR.HasRows = True Then
                    While (myDR.Read)
                            nom.Text = myDR("Nom").ToString & " " & myDR("Prénom").ToString
                            fonction.Text = myDR("Fonction").ToString
                            ech.Text = myDR("Ech").ToString
                            cat.Text = myDR("Cat").ToString
                            sb.Text = myDR("S_B_01_14").ToString
                            service.Text = myDR("Direction").ToString
                            sf.Text = myDR("sit_fam").ToString
                            datej.Text = myDR("moi_annee").ToString
                            nbheure.Text = myDR("tauxhoraire").ToString
                            ncompte.Text = myDR("Num_CPT").ToString
                            TextBoxX8.Text = myDR("Num_SS").ToString
                            codedirection.Text = myDR("Affectation").ToString
                            totalas.Text = myDR("total_impots").ToString
                            totalss.Text = myDR("total_ss").ToString
                            totalgain.Text = myDR("total_gain").ToString
                            totalretenue.Text = myDR("total_retenue").ToString
                            netpayer.Text = myDR("net_payer").ToString
                            Dim List1 As ListViewItem = New ListViewItem(myDR("code").ToString, 0)
                            List1.SubItems.Add(myDR("libellé").ToString)
                            List1.SubItems.Add(myDR("nombre").ToString)
                            List1.SubItems.Add(myDR("taux").ToString)
                            List1.SubItems.Add(myDR("soumis_Impots").ToString)
                            List1.SubItems.Add(myDR("soumis_ss").ToString)
                            List1.SubItems.Add(myDR("gain").ToString)
                            List1.SubItems.Add(myDR("retenue").ToString)
                            ListView1.Items.Add(List1)
                            mode_paiement.Text = myDR("mode_paiement").ToString
                            If IsNumeric(sb.Text) Then
                                nbheure.Text = String.Format("{0:0.00}", (sb.Text / 173.33))
                            End If
                            For i = 0 To ListView1.Items.Count - 1
                                If ListView1.Items(i).Text = "0" Then
                                    ListView1.Items(i).Text = ""
                                End If
                                For j = 1 To 7
                                    If ListView1.Items(i).SubItems(j).Text = "0" Then
                                        ListView1.Items(i).SubItems(j).Text = ""
                                    End If

                                Next
                            Next
                    End While
                Else
                    MessageBoxEx.Show("La paie que vous chercher n'exist pas !", "Paie non trouvé", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub AffichageBenifice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            moianpr = Date.Now.ToString("MM") - 0
            If moianpr.Length = 1 Then moianpr = "0" & moianpr & Date.Now.ToString("yyyy")
            'datej.Text = Date.Now.ToString("MMyyyy")
            datej.Text = moianpr
            mat.Focus()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub AffichageBenifice_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Try
            GroupBox1.Top = (Me.Height - GroupBox1.Height) / 2
            GroupBox1.Left = (Me.Width - GroupBox1.Width) / 2
            mat.Focus()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub datej_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datej.TextChanged
        Try
            'datej.Focus()
            If mat.Text.Length = 5 And datej.Text <> "" And datej.Text.Length = 6 Then
                ListView1.Items.Clear()
                'Nom,Prénom,Fonction,Ech,Cat,S_B_01_14,Direction,sit_fam,codesection,ncompte_bancaire,total_impots,total_ss,total_gain,total_retenue,net_payer,paie_mensuel.moi_annee,paie_mensuel.tauxhoraire
                IsConnected("SELECT * FROM Employes,paie_mensuel,code_papers  WHERE Employes.Matricule=paie_mensuel.Matricule and code_papers.Matricule=paie_mensuel.Matricule  and paie_mensuel.type='B' and moi_annee='" & datej.Text & "' and paie_mensuel.Matricule=" & mat.Text, False)
                If myDR.HasRows = True Then
                    While (myDR.Read)
                        nom.Text = myDR("Nom").ToString & " " & myDR("Prénom").ToString
                        fonction.Text = myDR("Fonction").ToString
                        ech.Text = myDR("Ech").ToString
                        cat.Text = myDR("Cat").ToString
                        sb.Text = myDR("S_B_01_14").ToString
                        service.Text = myDR("Direction").ToString
                        sf.Text = myDR("sit_fam").ToString
                        datej.Text = myDR("moi_annee").ToString
                        nbheure.Text = myDR("tauxhoraire").ToString
                        ncompte.Text = myDR("Num_CPT").ToString
                        TextBoxX8.Text = myDR("Num_SS").ToString
                        codedirection.Text = myDR("Affectation").ToString
                        totalas.Text = myDR("total_impots").ToString
                        totalss.Text = myDR("total_ss").ToString
                        totalgain.Text = myDR("total_gain").ToString
                        totalretenue.Text = myDR("total_retenue").ToString
                        netpayer.Text = myDR("net_payer").ToString
                        Dim List1 As ListViewItem = New ListViewItem(myDR("code").ToString, 0)
                        List1.SubItems.Add(myDR("libellé").ToString)
                        List1.SubItems.Add(myDR("nombre").ToString)
                        List1.SubItems.Add(myDR("taux").ToString)
                        List1.SubItems.Add(myDR("soumis_Impots").ToString)
                        List1.SubItems.Add(myDR("soumis_ss").ToString)
                        List1.SubItems.Add(myDR("gain").ToString)
                        List1.SubItems.Add(myDR("retenue").ToString)
                        ListView1.Items.Add(List1)
                        mode_paiement.Text = myDR("mode_paiement").ToString
                        If IsNumeric(sb.Text) Then
                            nbheure.Text = String.Format("{0:0.00}", (sb.Text / 173.33))
                        End If
                        For i = 0 To ListView1.Items.Count - 1
                            If ListView1.Items(i).Text = "0" Then
                                ListView1.Items(i).Text = ""
                            End If
                            For j = 1 To 7
                                If ListView1.Items(i).SubItems(j).Text = "0" Then
                                    ListView1.Items(i).SubItems(j).Text = ""
                                End If

                            Next
                        Next
                    End While
                Else
                    MessageBoxEx.Show("La paie que vous chercher n'exist pas !", "Paie non trouvé", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class

                 