Imports DevComponents.DotNetBar

Public Class PrevuEffectifParGroupeSociel
    Dim verif As Boolean = False
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If verif = True Then
            MessageBoxEx.Show("Mise à jours")
            Dim qu As String = "update prevueffictif set Prévu= " & prevu.Value & ",PrévuRealisé = " & prevurealise.Value & " ,PrévuNonRealisé = " & prevunonrealise.Value & " ,RéaliséNonPrevu=" & realisenonprevu.Value & " ,TotalRéalisé= " & totalrealise.Value & " WHERE Groupe = '" & groupe.Text & "' and Motif= '" & motif.Text & "' limit 1"
            IsConnected(qu, False)
        Else
            MessageBoxEx.Show("Insertion")
            Dim q As String = "INSERT INTO prevueffictif (Groupe,Motif,Prévu,PrévuRealisé,PrévuNonRealisé,RéaliséNonPrevu,TotalRéalisé,year)VALUES ('" & groupe.Text & "', '" & motif.Text & "'," & prevu.Value & "," & prevurealise.Value & " ," & prevunonrealise.Value & " ," & realisenonprevu.Value & " ," & totalrealise.Value & ",NOW())"
            IsConnected(q, False)
        End If
        ButtonX2.PerformClick()
    End Sub

    Private Sub groupe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles groupe.SelectedIndexChanged
        If groupe.SelectedIndex > -1 And motif.SelectedIndex > -1 Then
            ButtonX1.Enabled = True
            Dim querry As String
            querry = "select * from prevueffictif WHERE Groupe like '%" & groupe.Text & "%' and Motif like'%" & motif.Text & "%'"
            'Prévu, PrévuRealisé, PrévuNonRealisé, RéaliséNonPrevu, TotalRéalisé from prevueffictif
            IsConnected(querry, False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    prevu.Value = myDR("Prévu")
                    prevurealise.Value = myDR("PrévuRealisé")
                    prevunonrealise.Value = myDR("PrévuNonRealisé")
                    realisenonprevu.Value = myDR("RéaliséNonPrevu")
                    totalrealise.Value = myDR("TotalRéalisé")
                End While
                verif = True
                prevurealise.Enabled = True
                realisenonprevu.Enabled = True
                ButtonX1.Text = "Modifier"
                ButtonX1.Image = My.Resources.edit
            Else
                verif = False
                prevu.Value = 0
                prevurealise.Value = 0
                prevunonrealise.Value = 0
                realisenonprevu.Value = 0
                totalrealise.Value = 0
                prevurealise.Enabled = False
                realisenonprevu.Enabled = False
                ButtonX1.Text = "Ajouter"
                ButtonX1.Image = My.Resources.adde
            End If
        End If
    End Sub

    Private Sub motif_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles motif.SelectedIndexChanged
        If groupe.SelectedIndex > -1 And motif.SelectedIndex > -1 Then
            ButtonX1.Enabled = True
            Dim querry As String
            querry = "select * from prevueffictif WHERE Groupe like '%" & groupe.Text & "%' and Motif like'%" & motif.Text & "%'"
            'Prévu, PrévuRealisé, PrévuNonRealisé, RéaliséNonPrevu, TotalRéalisé from prevueffictif
            IsConnected(querry, False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    prevu.Value = myDR("Prévu")
                    prevurealise.Value = myDR("PrévuRealisé")
                    prevunonrealise.Value = myDR("PrévuNonRealisé")
                    realisenonprevu.Value = myDR("RéaliséNonPrevu")
                    totalrealise.Value = myDR("TotalRéalisé")
                End While
                verif = True
                prevurealise.Enabled = True
                realisenonprevu.Enabled = True
                ButtonX1.Text = "Modifier"
                ButtonX1.Image = My.Resources.edit
            Else
                verif = False
                prevu.Value = 0
                prevurealise.Value = 0
                prevunonrealise.Value = 0
                realisenonprevu.Value = 0
                totalrealise.Value = 0
                prevurealise.Enabled = False
                realisenonprevu.Enabled = False
                ButtonX1.Text = "Ajouter"
                ButtonX1.Image = My.Resources.adde
            End If
        End If
    End Sub

    Private Sub prevurealise_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prevurealise.ValueChanged
        totalrealise.Value = prevurealise.Value + realisenonprevu.Value
        prevunonrealise.Value = prevu.Value - prevurealise.Value
    End Sub

    Private Sub realisenonprevu_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles realisenonprevu.ValueChanged
        totalrealise.Value = prevurealise.Value + realisenonprevu.Value
        prevunonrealise.Value = prevu.Value - prevurealise.Value
    End Sub

    Private Sub PrevuEffectif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        yearcd.Maximum = Date.Now.Year + 3
        yearcd.Value = Date.Now.Year
    End Sub

    Private Sub prevu_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prevu.ValueChanged
        prevurealise.Maximum = prevu.Value
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Dim ds As PrevuEffectifDST = New PrevuEffectifDST
        ds.EnforceConstraints = False
        Try
            ds.PrevuEffectif.Clear()
            If RadioButton1.Checked Then
                IsConnected("SELECT Groupe,Motif,Prévu,PrévuRealisé,PrévuNonRealisé,RéaliséNonPrevu,TotalRéalisé FROM prevueffictif WHERE year = '" & yearcd.Value & "' AND (Groupe='Cadre' OR Groupe ='Maitrise' OR Groupe='Exécution')", False)
            Else
                IsConnected("SELECT Groupe,Motif,Prévu,PrévuRealisé,PrévuNonRealisé,RéaliséNonPrevu,TotalRéalisé FROM prevueffictif WHERE year = '" & yearcd.Value & "' AND (Groupe='Production' OR Groupe ='Soutien' OR Groupe='Administratif')", False)
            End If

            If myDR.HasRows Then
                While myDR.Read
                    ds.PrevuEffectif.AddPrevuEffectifRow(IIf(IsDBNull(myDR("Groupe")), "", myDR("Groupe")), IIf(IsDBNull(myDR("Motif")), "", myDR("Motif")), IIf(IsDBNull(myDR("Prévu")), "", myDR("Prévu")), IIf(IsDBNull(myDR("PrévuRealisé")), "", myDR("PrévuRealisé")), IIf(IsDBNull(myDR("PrévuNonRealisé")), "", myDR("PrévuNonRealisé")), IIf(IsDBNull(myDR("RéaliséNonPrevu")), "", myDR("RéaliséNonPrevu")), IIf(IsDBNull(myDR("TotalRéalisé")), "", myDR("TotalRéalisé")), Date.Now.Year)
                End While
            End If
        Catch ex As Exception
            Throw ex
        Finally
            ds.EnforceConstraints = True
        End Try
        Dim cr As RPPrevuEffectif = New RPPrevuEffectif
        cr.DataSource = ds
        DocumentViewer1.DocumentSource = cr
        cr.CreateDocument(True)
        'cr.SetDataSource(ds)
        'CrystalReportViewer1.ReportSource = cr
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            groupe.Items.Clear()
            Dim collectif() As String = New String() {"Production", "Soutien", "Administratif"}
            groupe.Items.AddRange(collectif)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            groupe.Items.Clear()
            Dim collectif() As String = New String() {"Cadre", "Maitrise", "Exécutant"}
            groupe.Items.AddRange(collectif)
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class