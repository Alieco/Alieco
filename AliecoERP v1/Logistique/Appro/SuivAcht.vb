Imports DevComponents.DotNetBar

Public Class SuivAcht
    Dim sql As New SQLControl
    Public iddemande As String = ""
    Public iddesig As String = ""
#Region "Loading"
    Private Sub load_service()
        If IsConnected("SELECT distinct service FROM logistique_appro_demach ", False) = True Then
            If myDR.HasRows = True Then
                service.Items.Clear()
                While (myDR.Read())
                    service.Items.Add(myDR("service"))
                End While
            End If
        End If
    End Sub
    Private Sub load_codeaffaire()
        If IsConnected("SELECT distinct codeaffaire FROM logistique_appro_demach ", False) = True Then
            If myDR.HasRows = True Then
                codeaffaire.Items.Clear()
                While (myDR.Read())
                    codeaffaire.Items.Add(myDR("codeaffaire"))
                End While
            End If
        End If
    End Sub
#End Region
    Public Sub reload()
        'If sql.VerifiyConnection = True Then
        '    sql.RunQuery("select codeaffaire,dateEntre,dateenregistrement,logistique_appro_suividem.situationdem from logistique_appro_demach,logistique_appro_suividem where logistique_appro_demach.idapprodemach=logistique_appro_suividem.idapprodemach and idapprodemach='" & iddemande & "' and idLogistique_appro_demandeDesig='" & iddesig & "'")
        '    If sql.SQLDS.Tables.Count > 0 Then
        '        DGsuivi.DataSource = sql.SQLDS.Tables(0)
        '    End If
        'End If
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim s As New SaveFileDialog
        s.DefaultExt = "*.xlsx"
        s.Title = "Choisissez le nom de fichier d'enregistrement"
        s.Filter = "Excel 2010 | *.xlsx"
        If s.ShowDialog = Windows.Forms.DialogResult.OK Then
            DGsuivi.ExportToXlsx(s.FileName)
        End If
    End Sub

    Private Sub enregisterSituationDemande_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enregisterSituationDemande.Click
        Dim q = "INSERT INTO logistique_appro_suividem  values (NULL, '" & mysql_escape_string(situationdem.Text) & "',Now(), '" & iddemande & "','" & iddesig & "',NULL)"
        If IsConnected(q, False) Then
            MessageBoxEx.Show("La situation de la demande a bien été enregistré", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If codeaffaire.Text <> "" Then
                If sql.VerifiyConnection = True Then
                    sql.RunQuery("select codeaffaire,dateEntre,dateenregistrement,logistique_appro_suividem.situationdem from logistique_appro_demach,logistique_appro_suividem where logistique_appro_demach.idapprodemach=logistique_appro_suividem.idapprodemach and codeaffaire='" & codeaffaire.Text & "'")
                    If sql.SQLDS.Tables.Count > 0 Then
                        DGsuivi.DataSource = sql.SQLDS.Tables(0)
                    End If
                End If
            ElseIf service.Text <> "" Then
                If sql.VerifiyConnection = True Then
                    sql.RunQuery("select codeaffaire,dateEntre,dateenregistrement,logistique_appro_suividem.situationdem from logistique_appro_demach,logistique_appro_suividem where logistique_appro_demach.idapprodemach=logistique_appro_suividem.idapprodemach and service='" & service.Text & "'")
                    If sql.SQLDS.Tables.Count > 0 Then
                        DGsuivi.DataSource = sql.SQLDS.Tables(0)
                    End If
                End If
            End If
            'End If
            qt.Text = ""
            codeaffaire.Text = ""
            service.Text = ""
            situationdem.Text = ""
            datedem.Clear()
            desig.Text = ""
            dateconsult.Value = Now
        Else : MessageBoxEx.Show("La situation de la demande n'a pas été enregistré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SuivAcht_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dateconsult.Value = Now
        load_codeaffaire()
        load_service()
        LabelX6.Enabled = True
    End Sub

    Private Sub codeaffaire_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles codeaffaire.TextChanged
        'LabelX4.Enabled = False
        'service.Enabled = False
        'LabelX2.Enabled = True
        'codeaffaire.Enabled = True
        If codeaffaire.Text <> "" Then
            If sql.VerifiyConnection = True Then
                sql.RunQuery("select codeaffaire,dateEntre,dateenregistrement,logistique_appro_suividem.situationdem from logistique_appro_demach,logistique_appro_suividem where logistique_appro_demach.idapprodemach=logistique_appro_suividem.idapprodemach and codeaffaire='" & codeaffaire.Text & "'")
                If sql.SQLDS.Tables.Count > 0 Then
                    DGsuivi.DataSource = sql.SQLDS.Tables(0)
                End If
            End If
        End If
    End Sub

    Private Sub service_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles service.TextChanged
        'LabelX2.Enabled = False
        'codeaffaire.Enabled = False
        'LabelX4.Enabled = True
        'service.Enabled = True
        If service.Text <> "" Then
            If sql.VerifiyConnection = True Then
                sql.RunQuery("select codeaffaire,dateEntre,dateenregistrement,logistique_appro_suividem.situationdem from logistique_appro_demach,logistique_appro_suividem where logistique_appro_demach.idapprodemach=logistique_appro_suividem.idapprodemach and service='" & service.Text & "'")
                If sql.SQLDS.Tables.Count > 0 Then
                    DGsuivi.DataSource = sql.SQLDS.Tables(0)
                End If
            End If
        End If
    End Sub

    Private Sub codeaff_CheckedChanged(sender As Object, e As EventArgs) Handles codeaff.CheckedChanged
        LabelX4.Enabled = False
        service.Enabled = False
        LabelX2.Enabled = True
        codeaffaire.Enabled = True
        LabelX6.Enabled = True
    End Sub

    Private Sub servi_CheckedChanged(sender As Object, e As EventArgs) Handles servi.CheckedChanged
        LabelX2.Enabled = False
        codeaffaire.Enabled = False
        LabelX4.Enabled = True
        service.Enabled = True
        LabelX6.Enabled = True
    End Sub
End Class