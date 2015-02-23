Imports DevComponents.DotNetBar

Public Class RelanceOffre
    Dim sql As New SQLControl
    Dim code As String = ""
    Dim utilisateur As String = ""
    Sub load_chargeAffaire()
        Try
            IsConnected("SELECT distinct fullname FROM commercial_offre,users WHERE commercial_offre.charge_affaire=users.user_id", False)
            If myDR.HasRows Then
                chargeaffaire.Items.Clear()
                While myDR.Read
                    chargeaffaire.Items.Add(myDR("fullname").ToString)
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub RelanceOffre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            load_chargeAffaire()
            If user_id = 20 Or user_id = 1 Then
                LabelX3.Visible = True
                chargeaffaire.Visible = True
            Else
                LabelX3.Visible = False
                chargeaffaire.Visible = False
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub reload()
        'Try
        If user_id = 20 Or user_id = 1 Then
            If chargeaffaire.Text = "" Then
                utilisateur = ""
            Else
                MsgBox(chargeaffaire.Text)
                utilisateur = "fullname= '" & chargeaffaire.Text & "' and "
                MsgBox(utilisateur)
            End If
        Else
            utilisateur = "user_id= '" & user_id & "' and "
        End If
        If sql.VerifiyConnection = True Then
            sql.RunQuery("SELECT code ,nomcl ,titre,delai_exe,datediff(now(),EntréeDate) as delai, relance as'Nombre de relances',fullname FROM commercial_offre ,users WHERE commercial_offre.charge_affaire=users.user_id and " & utilisateur & "  ((datediff(now(),EntréeDate)>=10 and relance=0) or ( datediff(now(),EntréeDate)>=20 and relance=1) or( datediff(now(),EntréeDate)>=30 and relance=2))")

            If sql.SQLDS.Tables.Count > 0 Then
                gdcrelanceoffre.DataSource = sql.SQLDS.Tables(0)
            End If
            ' DGFonc.PerformLayout()
        End If
        'Catch ex As Exception
        '    EnvoiError(ex.Message)
        'End Try
    End Sub

    Private Sub DéjaRelancéToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DéjaRelancéToolStripMenuItem.Click
        Try
            Dim code = GridView1.GetFocusedRowCellValue("code").ToString()
            If GridView1.SelectedRowsCount = 0 Then
                MessageBoxEx.Show("Vous devez selectionner une offre avant de cliquer Imprimer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                IsConnected("UPDATE commercial_offre SET relance = relance +1 WHERE code = '" & code & "' limit 1", True)


                ImprimerOffre.Text = "Fiche de l'Offre " & code
                'RapportOffre.nrc.Text = GridView1.GetRowCellValue(0, "code").ToString()
                ImprimerOffre.MdiParent = Mainfrm
                ImprimerOffre.Show()
            End If
            MessageBoxEx.Show("Relance avec succée!")
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        ' Try
        reload()
        'Catch ex As Exception
        '    EnvoiError(ex.Message)
        'End Try
    End Sub
End Class