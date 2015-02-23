Imports DevComponents.DotNetBar

Public Class depart_fonctionnaire
    Public matri As String = ""

    Private Sub depart_fonctionnaire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Mat.Text = matri
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
     Private Sub Mat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mat.TextChanged
        reload_detail()
    End Sub
    Sub reload_detail()
        Try
             IsConnected("SELECT * FROM Employes WHERE Matricule='" & Mat.Text & "'", False)
            If myDR.HasRows = True Then
                While (myDR.Read())
                    Nom.Text = "<b>Nom: </b> " & myDR("Nom")
                    Prenom.Text = "<b>Prenom: </b>" & myDR("Prénom")
                    DateNai.Text = "<b>Lieu de naissance: </b>" & myDR("Lieux_de_Naissance")
                    Adresse.Text = "<b>Ville de naissance : </b>" & myDR("Ville")
                    Fonction.Text = "<b>Date theorie : </b>" & myDR("Date_théorie")
                    Direction.Text = "<b>Date d'entrée 1 : </b>" & myDR("Date_entrée_1")
                    LabelX1.Text = "<b>Ancienneté : </b>" & myDR("Anc_1")
                    Departement.Text = "<b>Hall : </b>" & myDR("Hall")
                    Ech.Text = "<b>Equipe : </b>" & myDR("Equipe")
                    Cat.Text = "<b>Collectif : </b>" & myDR("Collectif")
                    SalaireB.Text = "<b>Type : </b>" & myDR("Type")
                    sitf.Text = "<b>Collectif_prc : </b>" & myDR("Collectif_prc")
                    Niveau.Text = "<b>Statut : </b>" & myDR("Statut")
                    Sexe.Text = "<b>Motif. Recrut. : </b>" & myDR("Motif_de_Recrut")
                    LabelX3.Text = "<b>Nb. contrat : </b>" & myDR("Nbres_Cont")
                    LabelX2.Text = "<b>Niveau : </b>" & myDR("Niveau")
                    LabelX4.Text = "<b>Formation ext. : </b>" & myDR("Formation_ext")
                    LabelX5.Text = "<b>Formation int. : </b>" & myDR("Formation_int")
                    LabelX7.Text = "<b>Nature contrat : </b>" & myDR("NC")
                    LabelX6.Text = "<b>Service national : </b>" & myDR("Service_national")
                    LabelX8.Text = "<b>Salissure :</b>" & myDR("Salissure") & ".       <b>Pénibilité :</b>" & myDR("Pénibilité") & ".       <b>Insalubrité :</b>" & myDR("Insalubrité") & ".             <b>Danger :</b>" & myDR("Danger")
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Try
            Dim frm = New ListFoncionnaires
            frm.MdiParent = Mainfrm
            frm.Show()
            Me.Close()
            Mat.Text = ""
            Nom.Text = ""
            Prenom.Text = ""
            DateNai.Text = ""
            Adresse.Text = ""
            Fonction.Text = ""
            Direction.Text = ""
            LabelX1.Text = ""
            Departement.Text = ""
            Ech.Text = ""
            Cat.Text = ""
            SalaireB.Text = ""
            sitf.Text = ""
            Niveau.Text = ""
            Sexe.Text = ""
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class