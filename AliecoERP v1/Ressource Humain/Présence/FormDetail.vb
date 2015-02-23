Imports DevExpress.XtraGrid.GridControl
Imports DevExpress.XtraPivotGrid
Public Class FormDetail
    Dim sql As New SQLControl
    Public mat As Double = 1
    Public du1 As String
    Public au1 As String
    Private Sub FormDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            PFdg.DataSource = Nothing
            GridView1.ClearDocument()
            'Dim row = PFdg.SelectedRows(0)
            'If (TextBoxX1.Text = row.Cells("Matricule").Value) Then
            TextBoxX1.Text = mat
            du.Value = du1
            au.Value = au1
            IsConnected("SELECT * FROM Employes WHERE Matricule='" & mat & "'", False)
            If myDR.HasRows = True Then
                While (myDR.Read)
                    nom.Text = myDR("Nom").ToString
                    prenom.Text = myDR("Prénom").ToString
                    Lieux_de_Naissance.Text = myDR("Lieux_de_Naissance").ToString
                    dir.Text = myDR("Direction").ToString
                    fonc.Text = myDR("Fonction").ToString
                    adr.Text = myDR("Adresse").ToString
                    date_nais.Value = myDR("Date_de_Naissance").ToString
                End While
            End If
            Dim q As String = "SELECT Employes.Matricule, Nom, Prénom, date_pointage,Direction, Absence,Motif FROM presence_pointage, Employes WHERE Employes.Matricule=presence_pointage.Matricule and (date_pointage between '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "') and (Employes.Matricule=" & mat & ")"
            Clipboard.SetText(q)
            sql.RunQuery(q)
            If sql.SQLDS.Tables.Count > 0 Then
                PFdg.DataSource = sql.SQLDS.Tables(0)
            End If
            'End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

End Class