Imports DevComponents.DotNetBar

Public Class DemandePourAppro
    Private Sub ButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX6.Click
        Dim b As Boolean = True
        Dim b1 As Boolean = True
        Dim id As String = ""
        If (IsConnected("INSERT INTO logistique_appro_demach VALUES(NULL,'" & demandeur.Text & "','" & service.Text & "','" & affaire.Text & "','" & nclassement.Text & "','" & TextBoxX1.Text & "','" & TextBoxX5.Text & "','" & DateTimeInput1.Value.ToString("yyyy/MM/dd") & "','" & DateTimeInput2.Value.ToString("yyyy/MM/dd") & "','" & fournisAchat.Text & "','" & nachat.Text & "',NULL,NULL,NULL,NULL,NULL,NULL,'" & dateconst.Text & "','" & visaconslt.Text & "','" & dateachat.Text & "','" & visaachat.Text & "','0','" & codefr.Text & "',Now(),'0',NULL,NULL);", True)) = True Then
            b = True
            IsConnected("SELECT max(idapprodemach) as iddemande FROM logistique_appro_demach", False)
            If myDR.HasRows Then
                While myDR.Read
                    id = myDR("iddemande").ToString
                End While
            End If
            For i = 0 To ListView1.Items.Count - 1
                If (IsConnected("INSERT INTO logistique_appro_demandedesig VALUES(NULL,'" & mysql_escape_string(ListView1.Items(i).SubItems(0).Text) & "','" & mysql_escape_string(ListView1.Items(i).SubItems(1).Text) & "','" & mysql_escape_string(ListView1.Items(i).SubItems(2).Text) & "', '" & mysql_escape_string(ListView1.Items(i).SubItems(3).Text) & "','" & mysql_escape_string(ListView1.Items(i).SubItems(4).Text) & "','" & mysql_escape_string(ListView1.Items(i).SubItems(5).Text) & "','" & mysql_escape_string(ListView1.Items(i).SubItems(6).Text) & "','" & mysql_escape_string(ListView1.Items(i).SubItems(7).Text) & "','" & mysql_escape_string(ListView1.Items(i).SubItems(8).Text) & "', '" & id & "', '0',NULL,NULL,NULL);", True)) = True Then
                    b = True
                Else : b = False
                End If
            Next
            MessageBoxEx.Show("La demande a bien été enregistré", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
            demandeur.Text = ""
            service.Clear()
            affaire.Clear()
            nclassement.Clear()
            TextBoxX1.Clear()
            TextBoxX5.Clear()
            DateTimeInput1.Value = Nothing
            DateTimeInput2.Value = Nothing
            fournisAchat.Clear()
            nachat.Clear()
            duachat.Clear()
            codefr.Clear()
            dateconst.Clear()
            visaachat.Clear()
            visaconslt.Clear()
            dateachat.Clear()
        Else
            MessageBoxEx.Show("Echec de l'enregistrement! ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim List As ListViewItem = New ListViewItem(dateliv.Text, 1)
        List.SubItems.Add(oe.Text)
        List.SubItems.Add(rep.Text)
        List.SubItems.Add(qt.Text)
        List.SubItems.Add(unite.Text)
        List.SubItems.Add(desig.Text)
        List.SubItems.Add(poids.Text)
        List.SubItems.Add(pu.Text)
        List.SubItems.Add(mtnapp.Text)
        ListView1.Items.Add(List)
        qt.Value = Nothing
        desig.Clear()
        pu.Clear()
        poids.Clear()
        dateliv.Clear()
        oe.Clear()
        rep.Clear()
        mtnapp.Clear()
        unite.Text = ""
    End Sub

    Private Sub DemandePourAppro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IsConnected("SELECT * FROM users WHERE username='" & Mainfrm.user & "'", False)
        If myDR.HasRows Then
            While myDR.Read
                demandeur.Text = myDR("fullname").ToString
            End While
        End If
    End Sub
End Class