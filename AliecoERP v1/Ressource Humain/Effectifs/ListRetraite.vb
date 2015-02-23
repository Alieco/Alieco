Public Class ListRetraite
    Dim sql As New SQLControl
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            ' MsgBox(Date.Now.Date)
            sql.RunQuery("SELECT employes.Matricule,Sexe,Nom,Prénom,Date_de_Naissance as 'Date De Naissance',DATE_FORMAT(FROM_DAYS(TO_DAYS(STR_TO_DATE('" & Date.Now.Date & "', '%d/%m/%Y')) - TO_DAYS(STR_TO_DATE(Date_de_Naissance, '%d-%m-%Y'))), '%Y')+0 AS Age,Lieux_de_Naissance as 'Lieux de naissance',Ville,fonction,Date_entrée,Date_fin_de_contrat,Date_retraite,Rtotal as 'Rappele Total' FROM alieco.employes,alieco.retraite WHERE employes.Matricule = retraite.Matricule;")
            dgv1.DataSource = sql.SQLDS.Tables(0)
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ListRetraite_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class