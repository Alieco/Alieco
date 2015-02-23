Imports DevComponents.DotNetBar
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Public Class AffectationVihecule

    Private Sub AffectationVihecule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadDriver()
        loadVihecule()
    End Sub

    Private Sub loadVihecule()
        If IsConnected("SELECT * FROM logistique_parc_vihecule", False) Then
            ViheculeCmb.Items.Clear()
            If myDR.HasRows Then
                While myDR.Read

                    ViheculeCmb.Items.Add(myDR("Matricule").ToString & " - " & myDR("Nom").ToString)
                End While
            End If
        End If
    End Sub

    Private Sub loadDriver()
        If IsConnected("SELECT Matricule,Nom,prénom FROM employes WHERE Fonction like '%Chauffeur%'", False) Then
            ChauffeurCmb.Items.Clear()
            If myDR.HasRows Then
                While myDR.Read
                    ChauffeurCmb.Items.Add(myDR("Matricule").ToString & " - " & myDR("Nom").ToString & " " & myDR("prénom").ToString)
                End While
            End If
        End If
    End Sub

    Private Sub ViheculeCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViheculeCmb.SelectedIndexChanged
        LabelControl1.Text = ""
        LabelControl2.Text = ""
        LabelControl3.Text = ""

        LabelControl5.Text = ""
        LabelControl4.Text = ""
        Dim im As Image = Nothing
        ViheculeImg.Image = im
        If ViheculeCmb.SelectedIndex > -1 And ViheculeCmb.Text.Contains("-") Then

            Dim s = ViheculeCmb.Text.Split("-")
            If s(0) <> "" Then
                If IsConnected("SELECT * FROM logistique_parc_vihecule WHERE matricule='" & s(0) & "' LIMIT 1", False) Then
                    If myDR.HasRows Then
                        While myDR.Read

                            If Not IsDBNull(myDR("photo")) Then
                                Dim lb() As Byte = myDR("photo")
                                Dim lstr As New System.IO.MemoryStream(lb)
                                ViheculeImg.Image = Image.FromStream(lstr)
                                lstr.Close()
                            End If
                            LabelControl1.Text = myDR("nom").ToString
                            LabelControl2.Text = myDR("marque").ToString
                            LabelControl3.Text = myDR("matricule").ToString
                            LabelControl5.Text = myDR("energie").ToString
                            LabelControl4.Text = myDR("entry_date").ToString
                        End While
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EffacerBtn.Click
        ViheculeCmb.SelectedIndex = -1
        ChauffeurCmb.SelectedIndex = -1
        duDate.Value = Nothing
        DuTime.Value = Nothing
        AuTime.Value = Nothing
        AuDate.Value = Nothing
    End Sub


    Private Sub afffectationBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles afffectationBtn.Click
        If ViheculeCmb.SelectedIndex > -1 And ChauffeurCmb.SelectedIndex > -1 And duDate.Value <> Nothing And DuTime.Value <> Nothing And AuDate.Value <> Nothing And AuTime.Value <> Nothing Then
            Dim em = ChauffeurCmb.Text.Split(" - ")
            Dim v = ViheculeCmb.Text.Split("-")
            If IsConnected("INSERT INTO `logistique_parc_affectation`(`id`,`matricule_chaufeur`,`matricule_vihecule`,`date_sortie`,`date_retour`,`temp_sortie`,`temp_retour`,`entry_date`)VALUES(NULL,'" & em(0) & "','" & v(0) & "','" & duDate.Value & "','" & AuDate.Value & "','" & DuTime.Value & "','" & AuTime.Value & "',NOW());", True) Then
                MessageBoxEx.Show("L'affectation est fait avec succés !", "Information ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                EffacerBtn.PerformClick()
            End If
        Else
            MessageBoxEx.Show("Vous avez laissé des champs vides !", "Erreur Champs vides ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub
End Class