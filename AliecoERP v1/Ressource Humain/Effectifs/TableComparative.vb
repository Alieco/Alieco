Imports DevComponents.DotNetBar
Public Class prestationFrm
    Dim sql As New SQLControl
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            Dim q = "INSERT INTO table_comparative(Titre_formation, Description, Prestataire, Prestataire_consulter, Delai, PrixHT, PrixTTC, Modalite_paiement,Observation)values('" & IIf((titletxt.Text <> String.Empty), titletxt.Text, titreformation.Text) & "', '" & description.Text & "', '" & prestataire.Text & "', '" & prestatairec.Text & "', '" & delai.Text & "', '" & prixht.Text & "', '" & prixttc.Text & "', '" & modalitepaiement.Text & "', '" & Observation.Text & "')"
            If IsConnected(q, False) = True Then
                MessageBoxEx.Show("La prestation a bien été enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ButtonX3.PerformClick()
            End If
            sql.RunQuery("select * from table_comparative")
            If sql.SQLDS.Tables.Count > 0 Then
                offredgv.DataSource = sql.SQLDS.Tables(0)
            End If
            load_titreformation()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_titreformation()
        Try
            If IsConnected("SELECT * FROM table_comparative ", False) = True Then
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        titreformation.Text = myDR("Titre_formation").ToString
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub TableComparative_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            load_titre_formation()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
#Region "Titre formation"
    Private Sub load_titre_formation()
        Try
            If IsConnected("SELECT DISTINCT(Titre_formation) FROM table_comparative ", False) = True Then
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        titreformation.Items.Add(myDR("Titre_formation"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

#End Region

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Try
            If sql.VerifiyConnection = True Then
                sql.RunQuery("SELECT * FROM table_comparative ")
                If sql.SQLDS.Tables.Count > 0 Then
                    offredgv.DataSource = sql.SQLDS.Tables(0)
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            RPtablecomparative.MdiParent = Mainfrm
            RPtablecomparative.Show()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class