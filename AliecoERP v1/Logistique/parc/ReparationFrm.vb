Imports DevComponents.DotNetBar

Public Class ReparationFrm

    Private Sub ReparationFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadVihecule()
        loadReparation()
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

    Private Sub loadReparation()
        Dim tbl As New DataTable()
        tbl.Columns.Add("ID", GetType(Integer))
        tbl.Columns.Add("Nom de vihecule", GetType(String))
        tbl.Columns.Add("Matricule Vihécule", GetType(String))
        tbl.Columns.Add("Date de réparation", GetType(String))
        tbl.Columns.Add("Discription de réparation", GetType(String))
        tbl.Columns.Add("Date d'enregistrement", GetType(DateTime))
        Dim vv = ""
        If ViheculeCmb.SelectedIndex > -1 Then
            Dim v = ViheculeCmb.Text.Split("-")
            vv = " And logistique_parc_vihecule.matricule='" & v(0) & "'"
        End If

        If IsConnected("SELECT logistique_parc_reparation.*,logistique_parc_vihecule.nom as name,logistique_parc_vihecule.matricule FROM logistique_parc_reparation,logistique_parc_vihecule WHERE  logistique_parc_vihecule.matricule=matricule_v" & vv, False) Then
            If myDR.HasRows Then
                While myDR.Read
                    tbl.Rows.Add(New Object() {myDR("id").ToString, myDR("name").ToString, myDR("matricule").ToString, myDR("dateReparation").ToString, myDR("discription").ToString, myDR("entry_date").ToString})
                End While
            End If

        End If
        GridAccident.DataSource = tbl
    End Sub

    Private Sub ViheculeCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViheculeCmb.SelectedIndexChanged
        LabelControl1.Text = ""
        LabelControl2.Text = ""
        LabelControl3.Text = ""
        LabelControl6.Text = ""
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
                            LabelControl6.Text = myDR("remarque").ToString
                        End While
                    End If

                End If
            End If
        End If
        loadReparation()
    End Sub

    Private Sub EnregistrerBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnregistrerBtn.Click
        If ViheculeCmb.SelectedIndex > -1 And dateReparation.Value <> Nothing And DiscriptionTxt.Text <> "" Then
            Dim v = ViheculeCmb.Text.Split("-")

            If IsConnected("INSERT INTO `logistique_parc_reparation`(`id`,`matricule_v`,`discription`,`dateReparation`,`entry_date`)VALUES(NULL,'" & v(0) & "','" & mysql_escape_string(DiscriptionTxt.Text) & "','" & dateReparation.Value & "',NOW());", True) Then
                MessageBoxEx.Show("La réparation est enregistrer avec succés ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadReparation()
            End If
        Else
            MessageBoxEx.Show("Vous avez laissé des champs vides !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class