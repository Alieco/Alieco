Imports MySql.Data.MySqlClient
Imports DevComponents.DotNetBar
Imports DevExpress.XtraEditors.Controls
Imports System.Globalization

Public Class AjoutOffre
    Public varcode As String
    Dim modalite As Integer = 0
    Dim modalite1 As Integer = 0
    Dim mode
    Dim mode1
    Private Sub load_NomClient()
        Try
            If IsConnected("SELECT DISTINCT RaisonSocial FROM commercial_client ", False) = True Then
                If myDR.HasRows = True Then
                    nomcl.Items.Clear()
                    While (myDR.Read())
                        nomcl.Items.Add(myDR("RaisonSocial"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub AjoutOffre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            load_prestation()
            load_NomClient()
            load_modalite()
            nombre.Items.Clear()
            For i = 1 To 100
                nombre.Items.Add(i)
            Next
            varcode = RandomNumber()
            varcodd.Text = varcode
            unit1.SelectedIndex = 0
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub load_modalite()
        Try
            Dim MySource As New AutoCompleteStringCollection()
            If IsConnected("select distinct description from commercial_offre_modalite ", False) Then
                If myDR.HasRows Then
                    While myDR.Read
                        MySource.Add(myDR("description"))
                    End While
                End If
            End If
            modalitepaie.AutoCompleteCustomSource = MySource
            modalitepaie.AutoCompleteMode = AutoCompleteMode.Suggest
            modalitepaie.AutoCompleteSource = AutoCompleteSource.CustomSource
            modalitepaie.Visible = True
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub load_prestation()
        Try
            Dim query = "SELECT * from commercial_offre_prestation"
            If IsConnected(query, False) Then
                If myDR.HasRows Then
                    While myDR.Read
                        'CheckedListBoxclient.Items.Add(myDR("text"))
                        'CheckedListBoxAlieco.Items.Add(myDR("text"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Function RandomNumber()
        Try
            Return CLng(DateTime.Now.Subtract(New DateTime(1970, 1, 1)).TotalMilliseconds)
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
        Return Nothing
    End Function

    'Private Sub ButtonX2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
    '    Try
    '        TabControl1.SelectedTabIndex = 1
    '    Catch ex As Exception
    '        EnvoiError(ex.Message)
    '    End Try
    'End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            If modalitepaie.Text = "" Or pourcentage.Text = "" Or Not IsNumeric(pourcentage.Text.Replace("%", "")) Then
                MsgBox(" Veuillez remplir le champ!")
            Else
                If RadioButton1.Checked Then
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

    Private Sub modalitepaie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modalitepaie.TextChanged
        Try
            Dim MySource As New AutoCompleteStringCollection()

            If IsConnected("select distinct description from commercial_offre_modalite ", False) Then
                If myDR.HasRows Then
                    While myDR.Read
                        MySource.Add(myDR("description"))
                    End While
                End If
            End If
            modalitepaie.AutoCompleteCustomSource = MySource
            modalitepaie.AutoCompleteMode = AutoCompleteMode.Suggest
            modalitepaie.AutoCompleteSource = AutoCompleteSource.CustomSource
            modalitepaie.Visible = True
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Try
            For i = 0 To ListView2.Items.Count - 1
                If ListView2.Items(i).Selected = True Then
                    numero1.Text = ListView2.Items(i).Text
                    prest.Text = ListView2.Items(i).SubItems(1).Text
                    quantite1.Value = ListView2.Items(i).SubItems(2).Text.Replace(".00", "")
                    unit1.Text = ListView2.Items(i).SubItems(3).Text
                    prixunitaire1.Value = ListView2.Items(i).SubItems(4).Text.Replace(".00", "")
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
    Private Sub ToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Try
            For i = 0 To ListView1.Items.Count - 1
                If ListView1.Items(i).Selected = True Then
                    numero1.Text = ListView1.Items(i).Text
                    prest.Text = ListView1.Items(i).SubItems(1).Text
                    quantite1.Value = ListView1.Items(i).SubItems(2).Text.Replace(".00", "")
                    unit1.Text = ListView1.Items(i).SubItems(3).Text
                    prixunitaire1.Value = ListView1.Items(i).SubItems(4).Text.Replace(".00", "")
                    ListView1.Items(i).Remove()
                End If
            Next
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Try
            For i = 0 To ListView1.Items.Count - 1
                If ListView1.Items(i).Selected = True Then
                    ListView1.Items(i).Remove()
                    Exit For
                End If
            Next
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX4_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX4.Click
        Try
            'If unit.SelectedIndex > -1 Then
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

    Private Sub ButtonX7_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX7.Click
        Try
            'If unit1.SelectedIndex > -1 Then
            Dim List As ListViewItem = New ListViewItem((ListView2.Items.Count + 1).ToString, 1)
            List.SubItems.Add(prest.Text)
            List.SubItems.Add(quantite1.Text)
            List.SubItems.Add(unit1.Text)
            List.SubItems.Add(prixunitaire1.Text)
            Select Case unit1.Text
                Case "pourcentage"
                    List.SubItems.Add(Math.Round((prixunitaire1.Text * quantite1.Text) / 100, 2))
                Case "U", "Forfait"
                    Dim f As String = String.Format("{0:0,0.00}", Math.Round((prixunitaire1.Text * quantite1.Text), 2))
                    'Math.Round((prixunitaire.Text * quantite.Text), 2)
                    'If Not f.Contains(",") Then
                    '    f += ",00"
                    'End If
                    List.SubItems.Add(f)
            End Select
            'List.SubItems.Add(alacharge.Text)
            'If RadioButton3.Checked Then
            '    List.SubItems.Add("D")
            '    List.SubItems.Add("A")
            'Else
            '    List.SubItems.Add("P")
            If alacharge.SelectedIndex = 0 Then
                List.SubItems.Add("C")
                'A la charge du Client
            Else
                List.SubItems.Add("A")
                'A la charge d'Alieco
            End If
            'End If
            ListView2.Items.Add(List)
            numero1.Clear()
            unit1.SelectedIndex = -1
            prest.Clear()
            alacharge.SelectedIndex = -1
            prixunitaire1.Value = Nothing
            quantite1.Value = Nothing
            ButtonX7.Enabled = False
            'Else : MessageBoxEx.Show("Veuillez saisir l'unité de la quantité!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX6_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX6.Click
        Try
            If delai.Text = "" And nombre.Text <> "" Then
                MessageBoxEx.Show("Vous avez laissé le  délai d'execution vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If delai.Text <> "" And nombre.Text = "" Then
                MessageBoxEx.Show("Vous avez laissé le nombre de délai d'execution vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If delai1.Text = "" And nombre1.Text <> "" Then
                MessageBoxEx.Show("Vous avez laissé le  délai d'option vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If delai1.Text <> "" And nombre1.Text = "" Then
                MessageBoxEx.Show("Vous avez laissé le nombre de délai d'option vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If total11.Text = "" Or tva.Text = "" Or ttc.Text = "" Then
                MessageBoxEx.Show("Vous avez oublié le calcul des totaux !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If nomcl.Text = "" Then
                MessageBoxEx.Show("Vous avez laissé le  Nom client vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
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
                Try
                    'Dim rs = nomcl.Text.Split("-")
                    Dim quary = " INSERT INTO commercial_offre VALUES(NULL,'" & mysql_escape_string(nomcl.Text) & "','" & mysql_escape_string(titre.Text) & "','" & nombre.Text & " " & delai.Text & "','" & varcode & "', NOW(),'0',NULL," & user_id & ",'" & nombre1.Text & " " & delai1.Text & "',(SELECT idclient FROM commercial_client where RaisonSocial='" & nomcl.Text & "'),'0');"
                    ' Clipboard.SetText(quary)
                    If IsConnected(quary, True) = False Then
                        erreur = True
                    End If
                    IsConnected("UPDATE `commercial_client`SET valide='1' WHERE RaisonSocial='" & nomcl.Text & "';", True)
                Catch ex As MySqlException
                    EnvoiError(ex.Message)
                End Try
                Try
                    'For i = 0 To CheckedListBoxclient.CheckedItems.Count - 1
                    '    Dim quary = " INSERT INTO commercial_offre_prestation VALUES(NULL,'" & varcode & "','" & mysql_escape_string(CheckedListBoxclient.CheckedItems(i).ToString) & "','Client');"
                    '    Clipboard.SetText(quary)
                    '    If IsConnected(quary, True) = False Then
                    '        erreur = True
                    '    End If
                    'Next
                    'For i = 0 To CheckedListBoxAlieco.CheckedItems.Count - 1
                    '    Dim quary = " INSERT INTO commercial_offre_prestation VALUES(NULL,'" & varcode & "','" & mysql_escape_string(CheckedListBoxAlieco.CheckedItems(i).ToString) & "','Alieco');"
                    '    Clipboard.SetText(quary)
                    '    If IsConnected(quary, True) = False Then
                    '        erreur = True
                    '    End If
                    'Next
                Catch ex As MySqlException
                    EnvoiError(ex.Message)
                End Try
                Dim type As String = ""
                For i = 0 To CheckedComboBoxEdit1.Properties.Items.Count - 1
                    If CheckedComboBoxEdit1.Properties.Items(i).CheckState = CheckState.Checked And CheckedComboBoxEdit1.Properties.Items(i).ToString.Contains("%") Then
                        type = "Avance remboursement"
                        Dim sep = CheckedComboBoxEdit1.Properties.Items(i).ToString.Split("%")
                        Dim quary = " INSERT INTO commercial_offre_modalite VALUES(NULL,'" & varcode & "','" & mysql_escape_string(sep(0)) & "','" & mysql_escape_string(sep(1)) & "',NOW(),'" & type & "');"
                        ' MsgBox(CheckedComboBoxEdit1.Properties.Items(i).Value)
                        'Clipboard.SetText(quary)
                        If IsConnected(quary, True) = False Then erreur = True
                    End If
                Next
                For i = 0 To CheckedComboBoxEdit2.Properties.Items.Count - 1
                    If CheckedComboBoxEdit2.Properties.Items(i).CheckState = CheckState.Checked And CheckedComboBoxEdit2.Properties.Items(i).ToString.Contains("%") Then
                        type = "terme paiement"
                        Dim sep = CheckedComboBoxEdit2.Properties.Items(i).ToString.Split("%")
                        Dim quary1 = " INSERT INTO commercial_offre_modalite VALUES(NULL,'" & varcode & "','" & mysql_escape_string(sep(0)) & "','" & mysql_escape_string(sep(1)) & "',NOW(),'" & type & "');"
                        ' Clipboard.SetText(quary1)
                        If IsConnected(quary1, True) = False Then erreur = True
                    End If
                Next
                For i = 0 To ListView1.Items.Count - 1
                    Try
                        Dim quary1 As String = " INSERT INTO commercial_offre_bordereauprix (`idBordereauPrix`,`num`,`desig`,`Qt`,`unite`,`PrixUnit`,`Montant`,`total`,`totaltva`,`totalttc`,`code`,`type`,`alaChargeDe`) VALUES(NULL,'" & mysql_escape_string(ListView1.Items(i).SubItems(0).Text) & "','" & mysql_escape_string(ListView1.Items(i).SubItems(1).Text) & "','" & ListView1.Items(i).SubItems(2).Text & "','" & ListView1.Items(i).SubItems(3).Text.Replace(".", ",") & "','" & ListView1.Items(i).SubItems(4).Text.Replace(".", ",") & "','" & ListView1.Items(i).SubItems(5).Text.Replace(".", ",") & "','" & total11.Text.Replace(".", ",") & "','" & tva.Text.Replace(".", ",") & "','" & ttc.Text.Replace(".", ",") & "','" & varcode & "','D','0');"
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
                        Dim quary = " INSERT INTO commercial_offre_bordereauprix (`idBordereauPrix`,`num`,`desig`,`Qt`,`unite`,`PrixUnit`,`Montant`,`total`,`totaltva`,`totalttc`,`code`,`type`,`alaChargeDe`) VALUES(NULL,'" & mysql_escape_string(ListView2.Items(i).SubItems(0).Text) & "','" & mysql_escape_string(ListView2.Items(i).SubItems(1).Text) & "','" & ListView2.Items(i).SubItems(2).Text & "','" & ListView2.Items(i).SubItems(3).Text.Replace(".", ",") & "','" & ListView2.Items(i).SubItems(4).Text.Replace(".", ",") & "','" & ListView2.Items(i).SubItems(5).Text.Replace(".", ",") & "',null,null,null,'" & varcode & "','P','" & ListView2.Items(i).SubItems(6).Text & "');"
                        'Clipboard.SetText(quary)
                        If IsConnected(quary, True) = False Then
                            erreur = True
                        End If
                    Catch ex As MySqlException
                        EnvoiError(ex.Message)
                    End Try
                Next
                If erreur = False Then
                    MessageBoxEx.Show("L'offre a bien été enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ListView2.Items.Clear()
                    ListView1.Items.Clear()
                    nomcl.Text = ""
                    titre.Clear()
                    modalitepaie.Text = ""
                    nombre.Text = ""
                    delai.Text = ""
                    nombre1.Text = ""
                    delai1.Text = ""
                    CheckedComboBoxEdit1.Text = ""
                    CheckedComboBoxEdit2.Text = ""
                    mode = 0
                    mode1 = 0
                    total11.Clear()
                    tva.Clear()
                    ttc.Clear()
                End If
            Else : MessageBoxEx.Show("La somme de pourcentage de modalité dépasse 100%", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
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
        If prest.Text = "" Or alacharge.Text = "" Then
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

    'Private Sub quantite1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles quantite1.ValueChanged
    '    If prest.Text = "" Or quantite1.Value = Nothing Or unit1.Text = "" Or prixunitaire1.Value = Nothing Or alacharge.Text = "" Then
    '        ButtonX7.Enabled = False
    '    Else
    '        ButtonX7.Enabled = True
    '    End If
    'End Sub

    'Private Sub unit1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles unit1.SelectedIndexChanged
    '    If prest.Text = "" Or quantite1.Value = Nothing Or unit1.Text = "" Or prixunitaire1.Value = Nothing Or alacharge.Text = "" Then
    '        ButtonX7.Enabled = False
    '    Else
    '        ButtonX7.Enabled = True
    '    End If
    'End Sub

    'Private Sub prixunitaire1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles prixunitaire1.ValueChanged
    '    If prest.Text = "" Or quantite1.Value = Nothing Or unit1.Text = "" Or prixunitaire1.Value = Nothing Or alacharge.Text = "" Then
    '        ButtonX7.Enabled = False
    '    Else
    '        ButtonX7.Enabled = True
    '    End If
    'End Sub

    Private Sub alacharge_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles alacharge.SelectedIndexChanged
        If prest.Text = "" Or alacharge.Text = "" Then
            ButtonX7.Enabled = False
        Else
            ButtonX7.Enabled = True
        End If
    End Sub
End Class