Public Class DivisonnerBonCommande
    Public codebcDiv As String = ""
    Dim desig As String = ""
    Dim qt As String = ""
    Dim poids As String = ""
    Dim pu As String = ""
    Dim montant As String = ""
    Dim tva1 As String = ""
    Dim timbre1 As String = ""
    Dim qt1 As String = ""
    Dim j As String = ""
    Private Sub noe_load()
        OEComboBoxEx1.Items.Clear()
        OEComboBoxEx2.Items.Clear()
        IsConnected("SELECT distinct code_affaire FROM commercial_affaire", False)
        If myDR.HasRows = True Then
            While (myDR.Read())
                OEComboBoxEx1.Items.Add(myDR("code_affaire"))
                OEComboBoxEx2.Items.Add(myDR("code_affaire"))
            End While
        End If
    End Sub
    Private Sub DivisonnerBonCommande_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If codebcDiv <> "" Then
            IsConnected("SELECT * FROM logistique_appro_bcdesig WHERE codebc='" & codebcDiv & "'", False)
            If myDR.HasRows Then
                While myDR.Read
                    Dim List As ListViewItem = New ListViewItem(myDR("desigbc").ToString)
                    List.SubItems.Add(myDR("Qte").ToString)
                    List.SubItems.Add(myDR("poids").ToString)
                    List.SubItems.Add(myDR("pu").ToString)
                    List.SubItems.Add(myDR("montantbc").ToString)
                    ListView1.Items.Add(List)
                End While
                total.Text = myDR("totalht").ToString
                tva.Text = myDR("tauxva").ToString
                timbre.Text = myDR("timbre").ToString
                ttc.Text = myDR("montanttotal").ToString
                tva1 = myDR("tva").ToString
                timbre1 = myDR("timbre").ToString
            End If
        End If
        noe_load()
    End Sub
    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count > 0 Then
            QTNumericUpDown1.Maximum = ListView1.SelectedItems(0).SubItems(1).Text
            QTNumericUpDown1.Value = ListView1.SelectedItems(0).SubItems(1).Text
            desig = ListView1.SelectedItems(0).SubItems(0).Text
            qt = ListView1.SelectedItems(0).SubItems(1).Text
            poids = ListView1.SelectedItems(0).SubItems(2).Text
            pu = ListView1.SelectedItems(0).SubItems(3).Text
            montant = ListView1.SelectedItems(0).SubItems(4).Text
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles TransfereButton1.Click
        If QTNumericUpDown1.Value = 0 Then
            MsgBox("Veuillez choisir une designation avant de cliquer sur le bouton!")
        Else
            qt1 = ""
            qt1 = qt - QTNumericUpDown1.Value
            qt = QTNumericUpDown1.Value
            '
            For i = 0 To ListView2.Items.Count - 1
                If desig = ListView2.Items(i).SubItems(0).Text Then
                    qt = qt + ListView2.Items(i).SubItems(1).Text
                    ListView2.Items(i).Remove()
                End If
            Next
            Dim List As ListViewItem = New ListViewItem(desig, 1)
            List.SubItems.Add(qt)
            List.SubItems.Add(poids)
            List.SubItems.Add(pu)
            List.SubItems.Add(Math.Round((pu * qt), 2))
            ListView2.Items.Add(List)
            If qt1 = "0" Then
                If ListView1.SelectedItems.Count > 0 Then
                    ListView1.SelectedItems(0).Remove()
                End If
            Else
                ListView1.SelectedItems(0).SubItems(1).Text = qt1
                ListView1.SelectedItems(0).SubItems(4).Text = Math.Round((pu * qt1), 2)
            End If
            qt = ""
            desig = ""
            pu = ""
            poids = ""
            montant = ""
            totauxlist1()
            totauxlist2()
        End If
    End Sub
    Private Sub RetourButton1_Click(sender As Object, e As EventArgs) Handles RetourButton1.Click
        If QTNumericUpDown1.Value = 0 Then
            MsgBox("Veuillez choisir une designation avant de cliquer sur le bouton!")
        Else
            qt1 = ""
            qt1 = qt - QTNumericUpDown1.Value
            qt = QTNumericUpDown1.Value
            Dim List As ListViewItem = New ListViewItem(desig, 1)
            List.SubItems.Add(qt)
            List.SubItems.Add(poids)
            List.SubItems.Add(pu)
            List.SubItems.Add(Math.Round((pu * qt), 2))
            ListView1.Items.Add(List)
            If qt1 = "0" Then
                If ListView2.SelectedItems.Count > 0 Then
                    ListView2.SelectedItems(0).Remove()
                End If
            Else
                ListView2.SelectedItems(0).SubItems(1).Text = qt1
                ListView2.SelectedItems(0).SubItems(4).Text = Math.Round((pu * qt1), 2)
            End If
            qt = ""
            desig = ""
            pu = ""
            poids = ""
            montant = ""
            totauxlist1()
            totauxlist2()
        End If
    End Sub
    Sub totauxlist2()
        If ListView2.Items.Count >= 0 Then
            Dim total1 As Double = 0
            For i = 0 To ListView2.Items.Count - 1
                total1 += ListView2.Items(i).SubItems(4).Text
            Next
            totalTextBoxX4.Text = total1
            If tva1 <> "0" Then
                tvaTextBoxX3.Text = Math.Round((total1 * tva1), 2)
            Else
                tvaTextBoxX3.Text = 0
            End If
            If timbre1 <> "0" Then
                timbreTextBoxX1.Text = Math.Round((total1 * 0.2), 2)
            Else : timbreTextBoxX1.Text = 0
            End If
            ttcTextBoxX2.Text = Math.Round((total1 + tvaTextBoxX3.Text + timbreTextBoxX1.Text), 2)
        End If
    End Sub
    Sub totauxlist1()
        If ListView1.Items.Count >= 0 Then
            Dim total1 As Double = 0
            For i = 0 To ListView1.Items.Count - 1
                total1 += ListView1.Items(i).SubItems(4).Text
            Next
            total.Text = total1
            If tva1 <> "0" Then
                tva.Text = Math.Round((total1 * tva1), 2)
            Else
                tva.Text = 0
            End If
            If timbre1 <> "0" Then
                timbre.Text = Math.Round((total1 * 0.2), 2)
            Else : timbre.Text = 0
            End If
            ttc.Text = Math.Round((total1 + tva.Text + timbre.Text), 2)
        End If
    End Sub

    Private Sub ListView2_Click(sender As Object, e As EventArgs) Handles ListView2.Click
        If ListView2.SelectedItems.Count > 0 Then
            QTNumericUpDown1.Maximum = ListView2.SelectedItems(0).SubItems(1).Text
            QTNumericUpDown1.Value = ListView2.SelectedItems(0).SubItems(1).Text
            desig = ListView2.SelectedItems(0).SubItems(0).Text
            qt = ListView2.SelectedItems(0).SubItems(1).Text
            poids = ListView2.SelectedItems(0).SubItems(2).Text
            pu = ListView2.SelectedItems(0).SubItems(3).Text
            montant = ListView2.SelectedItems(0).SubItems(4).Text
        End If
    End Sub
End Class