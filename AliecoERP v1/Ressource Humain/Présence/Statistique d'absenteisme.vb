Imports DevExpress.XtraCharts
Imports DevComponents.DotNetBar

Public Class Statistique_d_absenteisme

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            If du.Value <> Nothing And au.Value <> Nothing And au.Value >= du.Value Then

                ChartControl1.Series.Clear()
                Dim a As Double = 0
                Dim b As String = ""
                ChartControl1.Titles.Clear()
                Dim chartTitle1 As New ChartTitle()
                chartTitle1.Text = "Abscence par structure"
                ChartControl1.Titles.Add(chartTitle1)
                Clipboard.SetText("SELECT Distinct count(Employes.Matricule) as nb, Direction  FROM Employes, presence_pointage WHERE Employes.Matricule=presence_pointage.Matricule and date_pointage between '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "' and Motif like '%Absent( e )%' GROUP BY Direction")
                IsConnected("SELECT Distinct count(Employes.Matricule) as nb, Direction  FROM Employes, presence_pointage WHERE Employes.Matricule=presence_pointage.Matricule and date_pointage between '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "' and Motif like '%Absent( e )%' GROUP BY Direction ", False)
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        a = myDR("nb")
                        b = myDR("Direction")
                        Dim seri As New Series(b, ViewType.Bar)

                        seri.Points.Add(New SeriesPoint(b, a))
                        ChartControl1.Series.Add(seri)
                    End While
                    ChartControl1.Legend.Visible = True
                End If
            Else
                MessageBoxEx.Show("Vous avez fait des erreur dans les champs dates  !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub Statistique_d_absenteisme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            du.Value = Date.Now.Date
            au.Value = Date.Now.Date
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class