Imports DevComponents.DotNetBar
Imports System.Text

Public Class OrderFacturation
    Dim sql As New SQLControl
    Dim cr As Double = 0
    Dim codaff As String = "11"
    Dim rand As String = Rando()

    Private Sub OrderFacturation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            rand = Rando()
            'load_designation()
            'load_prestation()
            load_codeaffaire()
            'load_modalite()
            'load_avance()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub load_prestation()
        Try
            ListView2.Items.Clear()
            IsConnected("select * from commercial_affaire_bordereauprix where code='" & codaff & "' and commercial_affaire_bordereauprix.type='P' ", False)
            If myDR.HasRows Then
                While myDR.Read
                    Dim L As ListViewItem = New ListViewItem(myDR("num").ToString)
                    L.Checked = False
                    L.SubItems.Add(myDR("desig"))
                    L.SubItems.Add(myDR("Qt"))
                    L.SubItems.Add(myDR("unite"))
                    L.SubItems.Add(myDR("PrixUnit"))
                    L.SubItems.Add(myDR("Montant"))
                    L.SubItems.Add(myDR("idBordereauPrix"))
                    ListView2.Items.Add(L)
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub load_designation()
        Try
            ListView1.Items.Clear()
            IsConnected("select * from commercial_affaire_bordereauprix where code='" & codaff & "' and commercial_affaire_bordereauprix.type='D'", False)
            If myDR.HasRows Then
                While myDR.Read
                    Dim L As ListViewItem = New ListViewItem(myDR("num").ToString)
                    L.Checked = False
                    L.SubItems.Add(myDR("desig"))
                    L.SubItems.Add(myDR("Qt"))
                    L.SubItems.Add(myDR("unite"))
                    L.SubItems.Add(myDR("PrixUnit"))
                    L.SubItems.Add(myDR("Montant"))
                    L.SubItems.Add(myDR("idBordereauPrix"))
                    ListView1.Items.Add(L)
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub codeaff_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles codeaff.SelectedIndexChanged
        Try
            codaff = codeaff.Text
            Console.WriteLine(codeaff.Text)
            Console.WriteLine(codaff)
            rand = Rando()
            Console.WriteLine(rand)
            If CheckBoxX1.Checked Then
                load_designation()
                load_prestation()
            End If

            If CheckBoxX3.Checked Then
                load_modalite()
                load_avance()
            End If
            load_orderf()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub load_codeaffaire()
        Try
            codeaff.Items.Clear()
            IsConnected("select * from commercial_affaire ", False)
            If myDR.HasRows Then
                While myDR.Read
                    codeaff.Items.Add(myDR("code_affaire"))
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub load_modalite()
        Try
            ListView3.Items.Clear()
            IsConnected("select * from commercial_affaire_modalite where  commercial_affaire_modalite.type='terme paiement' and code='" & codaff & "'", False)
            If myDR.HasRows Then
                While myDR.Read
                    Dim L As ListViewItem = New ListViewItem(myDR("valeurpour").ToString & "%")
                    L.Checked = False
                    L.SubItems.Add(myDR("description"))
                    L.SubItems.Add(myDR("reglement"))
                    L.SubItems.Add(myDR("idmodalite"))
                    ListView3.Items.Add(L)
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub CheckBoxX1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxX1.CheckedChanged
        Try
            If CheckBoxX1.Checked Then
                GroupBox4.Size = New Size(848, 148)
                load_designation()
                load_prestation()
            Else
                GroupBox4.Size = New Size(848, 44)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_avance()
        Try
            ListView4.Items.Clear()
            IsConnected("select * from commercial_affaire_modalite where  commercial_affaire_modalite.type='Avance remboursement' and code='" & codaff & "'", False)
            If myDR.HasRows Then
                While myDR.Read
                    Dim L As ListViewItem = New ListViewItem(myDR("valeurpour").ToString & "%")
                    L.Checked = False
                    L.SubItems.Add(myDR("description"))
                    L.SubItems.Add(myDR("reglement"))
                    L.SubItems.Add(myDR("idmodalite"))
                    ListView4.Items.Add(L)
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub CheckBoxX3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxX3.CheckedChanged
        Try
            If CheckBoxX3.Checked Then
                GroupBox3.Size = New Size(848, 148)
                load_modalite()
                load_avance()
            Else
                GroupBox3.Size = New Size(848, 44)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            Dim q As String = ""
            Dim b As Boolean = True
            If montant.Text = String.Empty Then
                MessageBoxEx.Show("Vous avez laissé le champ Montant vide !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            For i = 0 To ListView1.CheckedItems.Count - 1
                q = "INSERT INTO `commercial_ordre_facture` VALUES(NULL," & mysql_escape_string(ListView1.CheckedItems(i).SubItems(6).Text) & ",'B','" & codaff & "',NOW(),'" & rand & "',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);"
                If IsConnected(q, True) = False Then
                    MessageBoxEx.Show("Une erreur s'est produit lors de l'insertion de description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    delet_temp(rand, codaff)
                    Exit Sub
                End If
            Next
            For i = 0 To ListView2.CheckedItems.Count - 1
                q = "INSERT INTO `commercial_ordre_facture` VALUES(NULL," & mysql_escape_string(ListView2.CheckedItems(i).SubItems(6).Text) & ",'B','" & codaff & "',NOW(),'" & rand & "',NULL);"
                If IsConnected(q, True) = False Then
                    MessageBoxEx.Show("Une erreur s'est produit lors de l'insertion de préstation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    delet_temp(rand, codaff)
                    Exit Sub
                End If
            Next
            For i = 0 To ListView3.CheckedItems.Count - 1
                q = "INSERT INTO `commercial_ordre_facture` VALUES(NULL," & mysql_escape_string(ListView3.CheckedItems(i).SubItems(3).Text) & ",'M','" & codaff & "',NOW(),'" & rand & "',NULL);"
                If IsConnected(q, True) = False Then
                    MessageBoxEx.Show("Une erreur s'est produit lors de l'insertion de modalité", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    delet_temp(rand, codaff)
                    Exit Sub
                End If
            Next
            For i = 0 To ListView4.CheckedItems.Count - 1
                q = "INSERT INTO `commercial_ordre_facture` VALUES(NULL," & mysql_escape_string(ListView4.CheckedItems(i).SubItems(3).Text) & ",'M','" & codaff & "',NOW(),'" & rand & "',NULL);"
                If IsConnected(q, True) = False Then
                    MessageBoxEx.Show("Une erreur s'est produit lors de l'insertion de avance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    delet_temp(rand, codaff)
                    Exit Sub
                End If
            Next
            Dim q1 As String = "INSERT INTO `commercial_ordre_facturation` VALUES(NULL,NOW(),'" & codaff & "','" & montant.Text & "',0,'" & rand & "');"
            If IsConnected(q1, True) = False Then
                MessageBoxEx.Show("Une erreur s'est produit lors de l'insertion de ordre de facturation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                delet_temp(rand, codaff)
                Exit Sub
            End If
            MessageBoxEx.Show("L'ordre de facturation a bien été enregistrer", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
            montant.Clear()
            codeaff.Text = ""
            LabelX5.Text = ""
            LabelX7.Text = ""
            GroupBox3.Size = New Size(848, 44)
            GroupBox4.Size = New Size(848, 44)
            GridControl1.DataSource = Nothing
            '  GridControl1.databind()
            CheckBoxX1.Checked = False
            CheckBoxX3.Checked = False
            rand = Rando()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub load_orderf()
        Try
            Dim mn As String = "0"
            If sql.VerifiyConnection = True Then
                sql.RunQuery("SELECT code_affaire as 'Code affaire',date_ordrefac as 'Date d\'ordre de facturation',montant_cheque as 'Montant du chaque',(select sum(montant_cheque) from commercial_ordre_facturation where code_affaire='" & codaff & "' and etat_facture=1) as somme FROM commercial_ordre_facturation WHERE code_affaire='" & codaff & "' order by idCommercial_ordre_facturation desc")
                If sql.SQLDS.Tables.Count > 0 Then
                    ' Supprimer la colonne : sql.SQLDS.Tables(0).Columns.Remove("idCommercial_ordre_facturation")
                    If sql.SQLDS.Tables(0).Rows.Count > 0 Then
                        mn = sql.SQLDS.Tables(0).Rows(0).Item(3).ToString
                        If mn = "" Then mn = 0
                    End If
                    GridControl1.DataSource = sql.SQLDS.Tables(0)
                End If
            End If
            IsConnected("SELECT * from commercial_affaire_bordereauprix WHERE code='" & codaff & "' ", False)
            If myDR.HasRows Then
                While myDR.Read
                    LabelX5.Text = myDR("totalttc")
                End While
            End If
            LabelX7.Text = LabelX5.Text - mn
            cr = LabelX7.Text
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub montant_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles montant.TextChanged
        Try
            If montant.Text <> "" Then
                If LabelX5.Text <> String.Empty Then
                    If IsNumeric(montant.Text) Then
                        If montant.Text < cr Then
                            LabelX7.Text = cr & "  sera : " & (cr - montant.Text)
                        Else
                            MessageBoxEx.Show("Vous avez fait une erreur :" & Environment.NewLine & "- le montant dépasse le montant de créance", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        MessageBoxEx.Show("Vous avez fait une erreur :" & Environment.NewLine & "- Veuillez saisir un chiffre !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBoxEx.Show("Veuillez choisir un code affaire avant !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Function Rando() As String
        Try
            Dim s As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
            Dim r As New Random
            Dim key As New StringBuilder
            For i As Integer = 1 To 10
                Dim idx As Integer = r.Next(0, s.Length)
                ' Console.WriteLine(idx)
                key.Append(s.Substring(idx, 1))
            Next
            Console.WriteLine(key)
            Return key.ToString
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
        Return Nothing
    End Function
    Sub delet_temp(ByVal ran As String, ByVal code As String)
        Try
            If ran <> "" And code <> "" Then
                IsConnected("DELETE FROM commercial_ordre_facture where rando='" & ran & "'and code_affaire='" & code & "'", True)
                IsConnected("DELETE FROM commercial_ordre_facturation where rando='" & ran & "'and code_affaire='" & code & "' limit 1", True)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class