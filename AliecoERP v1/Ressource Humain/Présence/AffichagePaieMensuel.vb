Imports DevComponents.DotNetBar

Public Class AffichagePaieMensuel
    Public moianpr As String = ""
    Private Sub mat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mat.TextChanged
        Try
            'datej.Focus()
            If mat.Text.Length = 5 And datej.Text <> "" Then
                ListView1.Items.Clear()
                'Nom,Prénom,Fonction,Ech,Cat,S_B_01_14,Direction,sit_fam,codesection,ncompte_bancaire,total_impots,total_ss,total_gain,total_retenue,net_payer,paie_mensuel.moi_annee,paie_mensuel.tauxhoraire
                IsConnected("SELECT * FROM Employes,paie_mensuel WHERE Employes.Matricule=paie_mensuel.Matricule and paie_mensuel.type='P' and moi_annee='" & datej.Text & "' and paie_mensuel.Matricule=" & mat.Text, False)
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
                        codedirection.Text = myDR("codesection").ToString
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
                    End While
                Else
                    nom.Clear()
                    fonction.Clear()
                    ech.Clear()
                    cat.Clear()
                    sb.Clear()
                    ncompte.Clear()
                    numss.Clear()
                    nbheure.Clear()
                    service.Clear()
                    sf.Clear()
                    ListView1.Items.Clear()
                    totalas.Clear()
                    totalgain.Clear()
                    totalretenue.Clear()
                    totalss.Clear()
                    netpayer.Clear()
                    mode_paiement.Text = ""
                    nbheure.Clear()
                End If
                IsConnected(" SELECT * FROM code_papers where Matricule=" & mat.Text, False)
                If myDR.HasRows = True Then
                    While (myDR.Read)
                        numss.Text = myDR("Num_SS").ToString
                        ncompte.Text = myDR("Num_CPT").ToString
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub AffichagePaieMensuel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            mat.Focus()
            moianpr = Date.Now.ToString("MM") - 1
            If moianpr.Length = 1 Then moianpr = "0" & moianpr & Date.Now.ToString("yyyy")
            datej.Text = Date.Now.ToString("MMyyyy")
            ' datej.Text = moianpr
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub AffichagePaieMensuel_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Try
            GroupBox1.Top = (Me.Height - GroupBox1.Height) / 2
            GroupBox1.Left = (Me.Width - GroupBox1.Width) / 2
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub datej_TextChanged(sender As System.Object, e As System.EventArgs) Handles datej.TextChanged
        Try
            If mat.Text.Length = 5 And datej.Text <> "" Then
                ListView1.Items.Clear()
                'Nom,Prénom,Fonction,Ech,Cat,S_B_01_14,Direction,sit_fam,codesection,ncompte_bancaire,total_impots,total_ss,total_gain,total_retenue,net_payer,paie_mensuel.moi_annee,paie_mensuel.tauxhoraire
                IsConnected("SELECT * FROM Employes,paie_mensuel,code_papers WHERE Employes.Matricule=paie_mensuel.Matricule and code_papers.Matricule=paie_mensuel.Matricule and paie_mensuel.type='P' and moi_annee='" & datej.Text & "' and paie_mensuel.Matricule=" & mat.Text, False)
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
                        codedirection.Text = myDR("codesection").ToString
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
                        ncompte.Text = myDR("Num_CPT").ToString
                        numss.Text = myDR("Num_SS").ToString
                        ListView1.Items.Add(List1)
                        mode_paiement.Text = myDR("mode_paiement").ToString
                        If IsNumeric(sb.Text) Then
                            nbheure.Text = String.Format("{0:0.00}", (sb.Text / 173.33))
                        End If
                    End While
                Else
                    nom.Clear()
                    fonction.Clear()
                    ech.Clear()
                    cat.Clear()
                    sb.Clear()
                    ncompte.Clear()
                    numss.Clear()
                    nbheure.Clear()
                    service.Clear()
                    sf.Clear()
                    ListView1.Items.Clear()
                    totalas.Clear()
                    totalgain.Clear()
                    totalretenue.Clear()
                    totalss.Clear()
                    netpayer.Clear()
                    mode_paiement.Text = ""
                    nbheure.Clear()
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class