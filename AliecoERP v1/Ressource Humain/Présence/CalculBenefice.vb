Imports MySql.Data.MySqlClient
Imports DevComponents.DotNetBar

Public Class CalculBenefice
    Dim moianpr As String = ""
    Dim annee As String = ""
    Dim annee1 As String = ""
    Public sass As Boolean = False
    Public sai As Boolean = False
    Public gain As Boolean = False
    Private Sub mat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mat.TextChanged
        Try
            If mat.Text.Length = 5 Then
                ListView1.Items.Clear()
                IsConnected("SELECT * FROM Employes, code_papers WHERE Employes.Matricule=code_papers.Matricule and Employes.Matricule=" & mat.Text, False)
                If myDR.HasRows = True Then
                    While (myDR.Read)
                        nom.Text = myDR("Nom").ToString
                        prenom.Text = myDR("Prénom").ToString
                        fonction.Text = myDR("Fonction").ToString
                        ech.Text = myDR("Ech").ToString
                        cat.Text = myDR("Cat").ToString
                        sb.Text = myDR("S_B_01_14").ToString
                        numbanque.Text = myDR("Num_CPT").ToString
                        numss.Text = myDR("Num_SS").ToString
                        If IsNumeric(sb.Text) Then
                            nbheure.Text = String.Format("{0:0.00}", (sb.Text / 173.33))
                        End If
                        service.Text = myDR("service").ToString
                        sf.Text = myDR("sit_fam").ToString
                        GroupBox2.Enabled = True
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_direction()
        Try
            If IsConnected("SELECT DISTINCT liborg FROM paie_direction ", False) = True Then
                If myDR.HasRows = True Then
                    direction.Items.Clear()
                    While (myDR.Read())
                        direction.Items.Add(myDR("liborg"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub CalculBenefice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            load_direction()
            annee = Date.Now.ToString("yyyy")
            annee1 = annee - 1
            moianpr = Date.Now.ToString("MM") - 1
            If moianpr.Length = 1 Then moianpr = "0" & moianpr & Date.Now.ToString("yyyy")
            datej.Text = Date.Now.ToString("MMyyyy")
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub direction_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If IsConnected("SELECT DISTINCT csect FROM paie_direction where liborg= '" & direction.Text & "'  ", False) = True Then
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        codedirection.Text = myDR("csect")
                    End While
                Else : codedirection.Text = ""
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Try
            Dim val1 As Double = 0
            val1 = valeur.Text.Replace(".", ",")
            If IsNumeric(val1) Then
                Dim val As Double = valeur.Text.Replace(".", ",")
                Dim List As ListViewItem = New ListViewItem("947", 0)
                List.SubItems.Add("BENEFICE EXERC " & annee1)
                List.SubItems.Add("")
                List.SubItems.Add("")
                List.SubItems.Add(Math.Round((val * 1), 2))
                List.SubItems.Add("")
                List.SubItems.Add(Math.Round((valeur.Text.Replace(".", ",") * 1), 2))
                List.SubItems.Add("")
                ListView1.Items.Add(List)
                Dim List1 As ListViewItem = New ListViewItem("980", 1)
                List1.SubItems.Add("I. R. G.")
                List1.SubItems.Add("")
                List1.SubItems.Add("")
                List1.SubItems.Add("")
                List1.SubItems.Add("")
                List1.SubItems.Add("")
                List1.SubItems.Add(Math.Round((valeur.Text.Replace(".", ",") * 0.1), 2))
                ListView1.Items.Add(List1)
                Dim s2 As Double = 0
                Dim r2 As Double = 0
                For i = 0 To ListView1.Items.Count - 1
                    If ListView1.Items.Item(i).SubItems(5).Text <> "" Then
                        If ListView1.Items.Item(i).SubItems(7).Text <> "" Then
                            r2 += ListView1.Items.Item(i).SubItems(5).Text
                        Else
                            s2 += ListView1.Items.Item(i).SubItems(5).Text.Replace(".", ",")
                        End If
                    End If
                Next
                totalss.Text = s2 - r2
                Dim s3 As Double = 0
                For i = 0 To ListView1.Items.Count - 1
                    If ListView1.Items.Item(i).SubItems(6).Text <> "" Then
                        s3 += ListView1.Items.Item(i).SubItems(6).Text.Replace(".", ",")
                    End If
                Next
                totalgain.Text = s3

                totalas.Text = totalss.Text - ((totalss.Text * 0.08) + (totalss.Text * 0.01))
                Dim s4 As Double = 0
                For i = 0 To ListView1.Items.Count - 1
                    If ListView1.Items.Item(i).SubItems(4).Text <> "" And ListView1.Items.Item(i).SubItems(5).Text = "" And ListView1.Items.Item(i).SubItems(7).Text = "" Then
                        s4 += ListView1.Items.Item(i).SubItems(4).Text
                    End If
                Next
                totalas.Text += Math.Round(s4, 2)
                totalas.Text = Math.Round((totalas.Text + 0.01), 2)
                Console.WriteLine(totalas.Text)
                Dim abs As Double = 0
                Dim sab As Double = 0
                Dim s5 As Double = 0
                For i = 0 To ListView1.Items.Count - 1
                    If ListView1.Items.Item(i).SubItems(7).Text <> "" Then
                        s5 += ListView1.Items.Item(i).SubItems(7).Text.Replace(".", ",")
                    End If
                Next
                totalretenue.Text = Math.Round(s5, 2)
                netpayer.Text = totalgain.Text - totalretenue.Text
            Else : MessageBoxEx.Show("Veuillez saisir une valeur numerique", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            Dim erreur As Boolean = False
            Dim quary As String
            For i = 0 To ListView1.Items.Count - 1
                Dim nombre As Double = 0
                Dim taux As Double = 0
                Dim soumis_Impots As Double = 0
                Dim soumis_ss As Double = 0
                Dim gain As Double = 0
                Dim retenue As Double = 0

                If ListView1.Items(i).SubItems(2).Text <> "" Then nombre = ListView1.Items(i).SubItems(2).Text
                If ListView1.Items(i).SubItems(3).Text <> "" Then taux = ListView1.Items(i).SubItems(3).Text.Replace(".", ",")
                If ListView1.Items(i).SubItems(4).Text <> "" Then soumis_Impots = ListView1.Items(i).SubItems(4).Text.Replace(".", ",")
                If ListView1.Items(i).SubItems(5).Text <> "" Then soumis_ss = ListView1.Items(i).SubItems(5).Text.Replace(".", ",")
                If ListView1.Items(i).SubItems(6).Text <> "" Then gain = ListView1.Items(i).SubItems(6).Text.Replace(".", ",")
                If ListView1.Items(i).SubItems(7).Text <> "" Then retenue = ListView1.Items(i).SubItems(7).Text.Replace(".", ",")
                'Console.WriteLine(ListView1.Items(i).SubItems(3).Text)
                '
                quary = " INSERT INTO `alieco`.`paie_mensuel` (Matricule, code, libellé, nombre, taux, soumis_Impots, soumis_ss, gain, retenue, net_payer, total_impots, total_ss, total_gain, total_retenue, mode_paiement, ncompte_bancaire,moi_annee,type)  VALUES(" & mat.Text & ",'" & ListView1.Items(i).SubItems(0).Text & "','" & ListView1.Items(i).SubItems(1).Text.Replace(",", ".") & "'," & nombre.ToString.Replace(",", ".") & "," & taux.ToString.Replace(",", ".") & ",'" & soumis_Impots.ToString.Replace(",", ".") & "','" & soumis_ss.ToString.Replace(",", ".") & "','" & gain.ToString.Replace(",", ".") & "','" & retenue.ToString.Replace(",", ".") & "','" & netpayer.Text.Replace(",", ".") & "','" & totalas.Text.Replace(",", ".") & "','" & totalss.Text.Replace(",", ".") & "','" & totalgain.Text.Replace(",", ".") & "','" & totalretenue.Text.Replace(",", ".") & "','" & mode_paiement.Text & "','" & numbanque.Text & "','" & datej.Text & "','B');"
                Clipboard.SetText(quary)
                If IsConnected(quary, True) = False Then
                    erreur = True
                End If
            Next
            If erreur = False Then
                MessageBoxEx.Show("La paie a bien été enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class