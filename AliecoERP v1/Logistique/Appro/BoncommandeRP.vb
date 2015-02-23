Public Class BoncommandeRP
    Public code As String = ""
    Public codea As String = ""
    Dim cr As New LogistiqueRP()
    Private Sub BoncommandeRP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim codefour As String = ""
        If code <> "" Then
            MsgBox("code2= " & code)
            IsConnected("SELECT * FROM logistique_appro_bondecommande where codebc='" & code & "'", False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    cr.XrLabel2.Text = "Bon de commande N° " & myDR("reference")
                    cr.XrTableCell1.Text = "Delai execution " & myDR("delaiexe")
                    cr.XrTableCell7.Text = "Mode expedition " & myDR("modeexpe")
                    cr.XrTableCell5.Text = "Mode de paiement  " & myDR("modepaiem")
                    cr.XrTableCell3.Text = "Ref/Offre " & myDR("ref_offre")
                    cr.XrTableCell13.Text = "Alger, le " & myDR("dateEnreg")
                    cr.XrTableCell14.Text = "N/Ref  " & myDR("ref")
                    cr.XrTableCell15.Text = "Demandeur " & myDR("demandeur")
                    cr.XrTableCell25.Text = "Imputation " & Environment.NewLine & myDR("imputation")
                    cr.XrTableCell27.Text = " Montant total " & myDR("monnaie")
                End While
            End If
           
            IsConnected("SELECT * FROM logistique_appro_bcdesig where codebc='" & code & "'", False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    cr.XrTableCell21.Text = myDR("desigbc").ToString
                    cr.XrTableCell16.Text = "Code fournisseur " & myDR("codefour").ToString
                    codefour = myDR("codefour").ToString
                    cr.XrTableCell22.Text = myDR("Qte").ToString
                    cr.XrTableCell23.Text = myDR("pu").ToString
                    cr.XrTableCell24.Text = myDR("montantbc").ToString
                    cr.XrLabel7.Text = myDR("totalht").ToString
                    cr.XrLabel8.Text = myDR("tauxva").ToString
                    cr.XrLabel9.Text = myDR("timbre").ToString
                    cr.XrTableCell26.Text = " Poids total " & Environment.NewLine & myDR("poids").ToString
                    cr.XrTableCell28.Text = myDR("montanttotal").ToString
                    cr.XrLabel5.Text = "Tva " & myDR("tva").ToString
                End While
            End If
            IsConnected("SELECT * FROM logistique_appro_fournis where code='" & codefour & "'", False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    cr.XrLabel3.Text = " Fournisseur " & Environment.NewLine & myDR("nomfourn").ToString & Environment.NewLine & myDR("adress").ToString & Environment.NewLine & myDR("ville").ToString
                End While
            End If
        Else
            IsConnected("SELECT * FROM logistique_appro_bonachat where codeba='" & codea & "'", False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    cr.XrLabel2.Text = "BON D'ACHAT N° " & myDR("reference").ToString
                    cr.XrTableCell1.Text = "Delai execution " & myDR("delaiexe").ToString
                    cr.XrTableCell7.Text = "Mode expedition " & myDR("modeexpe").ToString
                    cr.XrTableCell5.Text = "Mode de paiement  " & myDR("modepaiem").ToString
                    cr.XrTableCell3.Text = "Ref/Offre " & myDR("ref_offre").ToString
                    cr.XrTableCell13.Text = "Alger, le " & myDR("dateEnreg").ToString
                    cr.XrTableCell14.Text = "N/Ref  " & myDR("ref").ToString
                    cr.XrTableCell15.Text = "Demandeur " & myDR("demandeur").ToString
                    cr.XrTableCell25.Text = "Imputation " & Environment.NewLine & myDR("imputation").ToString
                    cr.XrTableCell27.Text = " Montant total " & myDR("monnaie").ToString
                End While
            End If
            IsConnected("SELECT * FROM logistique_appro_fournis where code='" & codefour & "'", False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    cr.XrLabel3.Text = " Fournisseur " & Environment.NewLine & myDR("nomfourn").ToString & Environment.NewLine & myDR("adress").ToString & Environment.NewLine & myDR("ville").ToString
                End While
            End If
            IsConnected("SELECT * FROM logistique_appro_badesig where codeba='" & codea & "'", False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    cr.XrTableCell21.Text = myDR("desigba").ToString
                    cr.XrTableCell16.Text = "Code fournisseur " & myDR("codefour").ToString
                    codefour = myDR("codefour").ToString
                    cr.XrTableCell22.Text = myDR("Qte").ToString
                    cr.XrTableCell23.Text = myDR("pu").ToString
                    cr.XrTableCell24.Text = myDR("montantbc").ToString
                    cr.XrLabel7.Text = myDR("totalht").ToString
                    cr.XrLabel8.Text = myDR("tauxva").ToString
                    cr.XrLabel9.Text = myDR("timbre").ToString
                    cr.XrTableCell26.Text = " Poids total " & Environment.NewLine & myDR("poids").ToString
                    cr.XrTableCell28.Text = myDR("montanttotal").ToString
                    cr.XrLabel5.Text = "Tva " & myDR("tva").ToString
                End While
            End If
        End If
        DocumentViewer1.DocumentSource = cr
        cr.CreateDocument(True)
    End Sub
End Class