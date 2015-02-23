Imports DevComponents.DotNetBar
Imports MySql.Data.MySqlClient

Public Class CalculCongePaye
    Dim moianpr As String = ""
    Dim annee As String = ""
    Dim annee1 As String = ""
    Public sass As Boolean = False
    Private Sub load_dir()
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
    Private Sub CalculCongePaye_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            load_dir()
            annee = Date.Now.ToString("yyyy")
            annee1 = annee - 1
            moianpr = Date.Now.ToString("MM")
            If moianpr.Length = 1 Then moianpr = "0" & moianpr & Date.Now.ToString("yyyy")
            datej.Text = Date.Now.ToString("MMyyyy")
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

    Private Sub ButtonX3_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX3.Click
        Try
            Dim listItem As ListViewItem
            For Each listItem In ListView1.Items
                If listItem.Text = "561" Or listItem.Text = "564" Or listItem.Text = "610" Or listItem.Text = "980" Then
                    ListView1.Items.Remove(listItem)
                End If
            Next
            Dim cp As Double = 0
            IsConnected("select distinct Matricule,total_ss from paie_mensuel where date_format(str_to_date(moi_annee, '%m%Y'), '%Y-%m-%d') >= '" & annee1 & "-07-01' and date_format(str_to_date(moi_annee, '%m%Y'), '%Y-%m-%d') < '" & annee & "-07-01'", False)

            If myDR.HasRows = True Then

                While (myDR.Read)
                    cp += Math.Round(myDR("total_ss") / 12)
                End While

            End If
            'Clipboard.SetText("select distinct Matricule,total_ss from paie_mensuel where (moi_annee between 07" & annee1 & " and 06" & annee & ")")

            Dim List As ListViewItem = New ListViewItem("130", 0)
            List.SubItems.Add("CONGE PAYE ")
            List.SubItems.Add("")
            List.SubItems.Add("")
            List.SubItems.Add(Math.Round((cp), 2))
            List.SubItems.Add(Math.Round((cp), 2))
            List.SubItems.Add(Math.Round((cp), 2))
            List.SubItems.Add("")
            ListView1.Items.Add(List)

            totalss.Text = cp

            totalgain.Text = cp
            Dim List1 As ListViewItem = New ListViewItem("561", 1)
            List1.SubItems.Add("ASSURANCE CHOMAGE")
            List1.SubItems.Add("")
            List1.SubItems.Add("0.50")
            List1.SubItems.Add(Math.Round((totalss.Text * 0.005), 2))
            List1.SubItems.Add("")
            List1.SubItems.Add("")
            List1.SubItems.Add(Math.Round((totalss.Text * 0.005), 2))
            ListView1.Items.Add(List1)
            Dim List11 As ListViewItem = New ListViewItem("564", 1)
            List11.SubItems.Add("RETRAITE ANTICIPEE")
            List11.SubItems.Add("")
            List11.SubItems.Add("0.50")
            List11.SubItems.Add(Math.Round((totalss.Text * 0.005), 2))
            List11.SubItems.Add("")
            List11.SubItems.Add("")
            List11.SubItems.Add(Math.Round((totalss.Text * 0.005), 2))
            ListView1.Items.Add(List11)
            Dim List2 As ListViewItem = New ListViewItem("610", 1)
            List2.SubItems.Add("RETENUE SECURITE SOCIALE")
            List2.SubItems.Add("")
            List2.SubItems.Add("8")
            List2.SubItems.Add(Math.Round((totalss.Text * 0.08), 2))
            List2.SubItems.Add("")
            List2.SubItems.Add("")
            List2.SubItems.Add(Math.Round((totalss.Text * 0.08), 2))
            ListView1.Items.Add(List2)
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
            Dim List4 As ListViewItem = New ListViewItem("980", 1)
            List4.SubItems.Add("I. R. G.")
            List4.SubItems.Add("")
            List4.SubItems.Add("")
            List4.SubItems.Add("")
            List4.SubItems.Add("")
            List4.SubItems.Add("")
            List4.SubItems.Add(Math.Round((totalas.Text * 0.1), 2))
            ListView1.Items.Add(List4)
            Dim s5 As Double = 0
            For i = 0 To ListView1.Items.Count - 1
                If ListView1.Items.Item(i).SubItems(7).Text <> "" Then
                    s5 += ListView1.Items.Item(i).SubItems(7).Text
                End If
            Next
            totalretenue.Text = Math.Round(s5, 2)
            netpayer.Text = totalgain.Text - totalretenue.Text
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
   
    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
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
                quary = " INSERT INTO `alieco`.`paie_mensuel` (Matricule, code, libellé, nombre, taux, soumis_Impots, soumis_ss, gain, retenue, net_payer, total_impots, total_ss, total_gain, total_retenue, mode_paiement, ncompte_bancaire,moi_annee,type)  VALUES(" & mat.Text & ",'" & ListView1.Items(i).SubItems(0).Text & "','" & ListView1.Items(i).SubItems(1).Text.Replace(",", ".") & "'," & nombre.ToString.Replace(",", ".") & "," & taux.ToString.Replace(",", ".") & ",'" & soumis_Impots.ToString.Replace(",", ".") & "','" & soumis_ss.ToString.Replace(",", ".") & "','" & gain.ToString.Replace(",", ".") & "','" & retenue.ToString.Replace(",", ".") & "','" & netpayer.Text.Replace(",", ".") & "','" & totalas.Text.Replace(",", ".") & "','" & totalss.Text.Replace(",", ".") & "','" & totalgain.Text.Replace(",", ".") & "','" & totalretenue.Text.Replace(",", ".") & "','" & mode_paiement.Text & "','" & numbanque.Text & "','" & datej.Text & "','CP');"
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
End Class