Imports DevComponents.DotNetBar

Public Class FacturationFrm
    Public coderEFERENCE As String = ""
    Public code1 As String = ""
    Dim ht As Double = 0
    Dim tva1 As Double = 0
    Dim pos As Integer = 0
    Dim mantChaque As String = ""
    Private Sub FacturationFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If coderEFERENCE <> String.Empty Then
            IsConnected("SELECT * FROM commercial_ordre_facturation,commercial_affaire,commercial_affaire_bordereauprix WHERE commercial_ordre_facturation.code_affaire=commercial_affaire_bordereauprix.code and commercial_ordre_facturation.code_affaire=commercial_affaire.code_affaire and  rando='" & coderEFERENCE & "' LIMIT 1", False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    montant.Text = myDR("montant_cheque").ToString & " DA/TTC"
                    mantChaque = myDR("montant_cheque").ToString
                    Dim nom = myDR("nomcl").ToString
                    Dim n = nom.Split("-")
                    nomcl.Text = n(0)
                    montant_affaire.Text = myDR("totalttc").ToString & " DA/TTC"
                    ht = myDR("total").ToString
                    tva1 = myDR("totaltva").ToString
                End While
            End If
            loadDataDP()
            loadDataAT()
        Else
            MessageBoxEx.Show("Erreur dans la connexion au serveur : N° 3370 " & Environment.NewLine & "Veuillez contacter le développeur au 123", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ComboBoxEx3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEx3.SelectedIndexChanged
        If ComboBoxEx3.SelectedIndex > -1 Then
            Dim pourc1 = ComboBoxEx3.Text.Split(" - ")
            Dim pourc = pourc1(2).Split("%")
            TextBoxX8.Text = Math.Round(((ht * pourc(0)) / 100), 2)
            TextBoxX7.Text = Math.Round(((TextBoxX8.Text * 17) / 100), 2)
            TextBoxX6.Text = Math.Round((CDbl(TextBoxX7.Text) + CDbl(TextBoxX8.Text)), 2)
        End If
    End Sub



    Private Sub ComboBoxEx1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEx1.SelectedIndexChanged
        If ComboBoxEx1.SelectedIndex > -1 Then
            Dim pourc1 = ComboBoxEx1.Text.Split(" - ")
            IsConnected("select  description,montant, commercial_affaire_bordereauprix.type, commercial_affaire_bordereauprix.unite,commercial_affaire_bordereauprix.Qt, commercial_affaire_bordereauprix.PrixUnit FROM commercial_affaire_bordereauprix, commercial_ordre_facture where commercial_ordre_facture.valeur=idBordereauPrix and rando='" & coderEFERENCE & "' and commercial_ordre_facture.type='B' and id_commercial_ordre_facture='" & pourc1(0) & "' LIMIT 1", False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    Dim a = myDR("Qt").ToString().Split(".")
                    qt.Maximum = a(0)
                    qt.Value = a(0)
                    unite.Text = myDR("unite")
                    discriTxt.Text = IIf(IsDBNull(myDR("description")), "", myDR("description").ToString)
                    prixunitaire.Text = myDR("PrixUnit").Replace(".", ",")
                    total11.Text = qt.Value * CDbl(prixunitaire.Text)
                End While
            End If
            Dim i = 0
            'Dim L As ListViewItem = New ListViewItem(pourc1(0).ToString)
            'If ListView1.FindItemWithText(pourc1(0)).Text <> "" Then
            '    L = ListView1.FindItemWithText(pourc1(0))
            '    L.Remove()
            'End If
            For i = 0 To ListView1.Items.Count - 2
                'Console.WriteLine(ListView1.Items(i).Text & " - " & pourc1(0))
                If ListView1.Items(i).Text = pourc1(0) Then
                    ListView1.Items(i).Remove()
                End If
            Next

            Dim L1 As ListViewItem = New ListViewItem(pourc1(0).ToString)
            L1.SubItems.Add(pourc1(2))
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
            'While i <= ListView1.Items.Count - 1
            '    If ListView1.Items(i).SubItems(0).Text <> pourc1(0) Then
            '        i += 1
            '    ElseIf ListView1.Items(i).SubItems(0).Text = pourc1(0) Then
            '        pos = i
            '    ElseIf i > ListView1.Items.Count - 1 Then

            '    End If
            'End While
        End If
    End Sub

    Private Sub VScrollBarAdv1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VScrollBarAdv1.Scroll
        GroupBox2.Location = New Point(0, 148 - (VScrollBarAdv1.Value * 2))
        GroupBox1.Location = New Point(0, 0 - (VScrollBarAdv1.Value * 2))
    End Sub


    Private Sub qt_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qt.ValueChanged
        If unite.Text.Contains("Unité") Then
            total11.Text = qt.Value * (prixunitaire.Text.Replace(".", ","))
        ElseIf unite.Text.Contains("Ensemble") Then
            total11.Text = prixunitaire.Text
        ElseIf unite.Text.Contains("Pourcentage") Then
            total11.Text = (qt.Value * prixunitaire.Text.Replace(".", ",")) / 100
        End If
        Dim pourc1 = ComboBoxEx1.Text.Split(" - ")
        For i = 0 To ListView1.Items.Count - 1
            If ListView1.Items(i).Text = pourc1(0) Then
                ListView1.Items(i).SubItems(5).Text = total11.Text
                ListView1.Items(i).SubItems(4).Text = prixunitaire.Text
                ListView1.Items(i).SubItems(3).Text = unite.Text
                ListView1.Items(i).SubItems(2).Text = qt.Value
            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s As Double = 0
        For i = 0 To ListView1.Items.Count - 1
            s = s + ListView1.Items(i).SubItems(5).Text.Replace(".", ",")
        Next
        MsgBox(s)
    End Sub

    Sub loadDataDP()
        ComboBoxEx1.Items.Clear()
        IsConnected("select id_commercial_ordre_facture,commercial_affaire_bordereauprix.num ,commercial_affaire_bordereauprix.desig, commercial_affaire_bordereauprix.type from commercial_affaire_bordereauprix, commercial_ordre_facture where commercial_ordre_facture.valeur=commercial_affaire_bordereauprix.idBordereauPrix and commercial_ordre_facture.type='B' and rando='" & coderEFERENCE & "' union (select id_commercial_ordre_facture,commercial_affaire_modalite.valeur ,commercial_affaire_modalite.description, commercial_affaire_modalite.type from commercial_affaire_modalite, commercial_ordre_facture where commercial_ordre_facture.valeur=commercial_affaire_modalite.idmodalite and commercial_ordre_facture.type='M' and rando='" & coderEFERENCE & "')", False)
        If myDR.HasRows = True Then
            While (myDR.Read())
                If myDR("type") = "D" Or myDR("type") = "P" Then
                    If SwitchButton1.Value = False And myDR("type") = "P" Then
                        ComboBoxEx1.Items.Add(myDR("id_commercial_ordre_facture") & " - " & myDR("desig"))
                    ElseIf SwitchButton1.Value = True And myDR("type") = "D" Then
                        ComboBoxEx1.Items.Add(myDR("id_commercial_ordre_facture") & " - " & myDR("desig"))
                    End If
                End If
            End While
        End If
    End Sub
    Sub loadDataAT()
        ComboBoxEx3.Items.Clear()
        IsConnected("select id_commercial_ordre_facture,commercial_affaire_bordereauprix.num ,commercial_affaire_bordereauprix.desig, commercial_affaire_bordereauprix.type from commercial_affaire_bordereauprix, commercial_ordre_facture where commercial_ordre_facture.valeur=commercial_affaire_bordereauprix.idBordereauPrix and commercial_ordre_facture.type='B' and rando='" & coderEFERENCE & "' union (select id_commercial_ordre_facture,commercial_affaire_modalite.valeur ,commercial_affaire_modalite.description, commercial_affaire_modalite.type from commercial_affaire_modalite, commercial_ordre_facture where commercial_ordre_facture.valeur=commercial_affaire_modalite.idmodalite and commercial_ordre_facture.type='M' and rando='" & coderEFERENCE & "')", False)
        If myDR.HasRows = True Then
            While (myDR.Read())
                If myDR("type") = "Avance remboursement" Or myDR("type") = "terme paiement" Then
                    If SwitchButton2.Value = False And myDR("type") = "Avance remboursement" Then
                        ComboBoxEx3.Items.Add(myDR("id_commercial_ordre_facture") & " - " & myDR("num") & "% " & myDR("desig"))
                    ElseIf SwitchButton2.Value = True And myDR("type") = "terme paiement" Then
                        ComboBoxEx3.Items.Add(myDR("id_commercial_ordre_facture") & " - " & myDR("num") & "% " & myDR("desig"))
                    End If
                End If
            End While
        End If
    End Sub
    Private Sub SwitchButton1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SwitchButton1.ValueChanged
        loadDataDP()
    End Sub

    Private Sub SwitchButton2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SwitchButton2.ValueChanged
        loadDataAT()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If ComboBoxEx1.SelectedIndex <> -1 Then

            Dim pourc1 = ComboBoxEx1.Text.Split(" - ")
            For i = 0 To ListView1.Items.Count - 1
                If ListView1.Items(i).Text = pourc1(0) Then
                    ListView1.Items(i).Remove()
                End If
            Next
            Dim L As ListViewItem = New ListViewItem(pourc1(0))
            L.SubItems.Add(pourc1(2))
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
            IsConnected("UPDATE commercial_ordre_facture SET description='" & mysql_escape_string(discriTxt.Text) & "' WHERE id_commercial_ordre_facture =" & pourc1(0) & " LIMIT 1", True)
            calculeTotalDP()
        End If
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        If ComboBoxEx3.SelectedIndex <> -1 Then
            Dim pourc1 = ComboBoxEx3.Text.Split(" - ")
            For i = 0 To ListView2.Items.Count - 2
                'Console.WriteLine(ListView1.Items(i).Text & " - " & pourc1(0))
                If ListView2.Items(i).Text = pourc1(0) Then
                    ListView2.Items(i).Remove()
                End If
            Next
            Dim L As ListViewItem = New ListViewItem(pourc1(0))
            L.SubItems.Add(pourc1(2))
            L.SubItems.Add(TextBoxX8.Text)
            L.SubItems.Add(TextBoxX7.Text)
            L.SubItems.Add(TextBoxX6.Text)


            If SwitchButton2.Value = True Then
                L.SubItems.Add("A")
            Else
                L.SubItems.Add("T")
            End If

            ListView2.Items.Add(L)
            calculeTotalAT()
        End If
    End Sub

    Sub calculeTotalDP()
        Dim s As Double = 0
        For i = 0 To ListView1.Items.Count - 1
            s = s + ListView1.Items(i).SubItems(5).Text.Replace(".", ",")
        Next
        TextBoxX1.Text = s
    End Sub
    Sub calculeTotalAT()
        Dim s As Double = 0
        For i = 0 To ListView2.Items.Count - 1
            s = s + ListView2.Items(i).SubItems(2).Text.Replace(".", ",")
        Next
        TextBoxX3.Text = s
    End Sub
End Class