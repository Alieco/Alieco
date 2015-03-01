Imports DevComponents.DotNetBar

Public Class EditClient
    Public idclient As Integer
    Private Sub EditClient_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            IsConnected("SELECT * FROM commercial_client WHERE idclient='" & idclient & "'", False)
            If myDR.HasRows = True Then
                While (myDR.Read)
                    code.Text = myDR("codeCl").ToString
                    secteur.Text = myDR("secteur").ToString
                    nconslt.Text = myDR("nconsult").ToString
                    datenais.Value = myDR("Date").ToString
                    nomcl.Text = myDR("NomClient").ToString
                    fonction.Text = myDR("Fonction").ToString
                    rs.Text = myDR("RaisonSocial").ToString
                    adresse.Text = myDR("Adresse").ToString
                    numtel.Text = myDR("NumTel").ToString
                    fax.Text = myDR("Fax").ToString
                    email.Text = myDR("Email").ToString
                    NIF.Text = myDR("NIdentif_fiscale").ToString
                    NAI.Text = myDR("NArticle_imposition").ToString
                    description.Text = myDR("Description_Consult").ToString
                    obs.Text = myDR("Observation").ToString
                    responsable.Text = myDR("responsable").ToString
                    contrainte.Text = myDR("contrainte").ToString
                    faisabilite.Text = myDR("faisabilite").ToString
                    delai.Text = myDR("delai_reponse").ToString
                    nRC.Text = myDR("NRC").ToString
                    activite.Text = myDR("filière").ToString
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        Try
            Dim q As String = "update commercial_client set nconsult= '" & nconslt.Text & "',codeCl = '" & code.Text & "',Date = '" & datenais.Value & "' ,NomClient = '" & nomcl.Text & "' ,Fonction='" & fonction.Text & "' ,RaisonSocial= '" & rs.Text & "' ,Adresse= '" & adresse.Text & "' ,NumTel= '" & numtel.Text & "' , Fax='" & fax.Text & " ' ,Email= '" & email.Text & "',NIdentif_fiscale= '" & NIF.Text & "', NArticle_imposition= '" & NAI.Text & "',Description_Consult = '" & description.Text & "', Observation='" & obs.Text & "', responsable='" & responsable.Text & "', contrainte='" & contrainte.Text & "', faisabilite='" & faisabilite.Text & "', delai_reponse='" & delai.Text & "',filière='" & activite.Text & "',secteur='" & secteur.Text & "'where idclient='" & idclient & "'"
            ' Clipboard.SetText(q)
            If IsConnected(q, False) = True Then
                MessageBoxEx.Show("Le client a bien été modifier", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                nRC.Clear()
                activite.Clear()
                code.Clear()
                nconslt.Clear()
                datenais.Value = Nothing
                nomcl.Clear()
                fonction.Clear()
                rs.Clear()
                adresse.Clear()
                numtel.Text = ""
                fax.Clear()
                email.Clear()
                NIF.Clear()
                NAI.Clear()
                description.Clear()
                obs.Clear()
                responsable.Clear()
                contrainte.Clear()
                faisabilite.Clear()
                secteur.Text = ""
                delai.Value = Nothing
                Me.Close()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub activite_TextChanged(sender As System.Object, e As System.EventArgs) Handles activite.TextChanged
        Try
            Dim MySource As New AutoCompleteStringCollection()

            If IsConnected("select distinct filière from commercial_client", False) Then
                If myDR.HasRows Then
                    While myDR.Read
                        MySource.Add(myDR("filière"))
                    End While
                End If
            End If
            activite.AutoCompleteCustomSource = MySource
            activite.AutoCompleteMode = AutoCompleteMode.Suggest
            activite.AutoCompleteSource = AutoCompleteSource.CustomSource
            activite.Visible = True
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class