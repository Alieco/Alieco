Imports DevExpress.XtraCharts

Public Class Statistiques
    Private Sub Statistiques_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '  Me.WindowState = FormWindowState.Maximized
            'Sexe
            Dim f As Double
            Dim h As Double
            IsConnected("select count(Matricule)as nb1 from Employes where Sexe='Madame' or Sexe='Femme' or Sexe='Mademoiselle' or Sexe='F' ", False)
            If myDR.HasRows = True Then
                While (myDR.Read)
                    f = myDR("nb1")
                End While
            End If
            IsConnected("select count(Matricule)as nb2 from Employes where Sexe='Homme' or Sexe='Monsieur' or Sexe='M' ", False)
            If myDR.HasRows = True Then
                While (myDR.Read)
                    h = myDR("nb2")
                End While
            End If
            Dim yval1 As Double() = {h, f}
            Dim xval1 As String() = {"Homme (" & String.Format("{0:0.00}", (h * 100 / (h + f))) & "%)", "Femme (" & String.Format("{0:0.00}", (f * 100 / (h + f))) & "%)"}
            Chart2.Series("Sexe").Points.DataBindXY(xval1, yval1)
            Dim seri2 As New Series("Sexe", ViewType.Pie)
            seri2.Points.Add(New SeriesPoint("H", h))
            seri2.Points.Add(New SeriesPoint("F", f))
            ChartControl3.Series.Add(seri2)
            ChartControl3.Legend.Visible = True
            ChartControl3.Legend.TextOffset = False
            Dim chartTitle2 As New ChartTitle()
            chartTitle2.Text = "Répartition par Sexe"
            ChartControl3.Titles.Add(chartTitle2)

            'Situation Administrative
            Try
                Dim a As Double = 0
                Dim b As String = ""
                IsConnected("SELECT Distinct count(Matricule) as nb, Collectif  FROM Employes WHERE Collectif <> '' GROUP BY Collectif ", False)
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        a = myDR("nb")
                        b = myDR("Collectif")
                        Chart1.Series("Situation Administratif").Points.AddXY(b, a)
                        Dim seri As New Series(b, ViewType.Bar)
                        seri.Points.Add(New SeriesPoint(b, a))
                        ChartControl2.Series.Add(seri)

                        '  Chart1.Series("Situation Administratif").Color = Color.Blue
                    End While
                    ' Hide the legend (if necessary).
                    ChartControl2.Legend.Visible = True
                    ' Add a title to the chart (if necessary).
                    Dim chartTitle1 As New ChartTitle()
                    chartTitle1.Text = "Situation Administrative"
                    ChartControl2.Titles.Add(chartTitle1)
                End If
            Catch ex As Exception
            End Try

            'Tranche d'age
            Try
                Dim j1 As Double = 0
                Dim j2 As Double = 0
                Dim j3 As Double = 0
                Dim j4 As Double = 0
                Dim j5 As Double = 0
                IsConnected("SELECT count(Matricule) as Junior FROM Employes WHERE Age1 between 18 and 24 ", False)
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        j1 = myDR("Junior")
                    End While
                End If
                IsConnected("SELECT count(Matricule) as moy1 FROM Employes WHERE Age1 between 25 and 34 ", False)
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        j2 = myDR("moy1")
                    End While
                End If
                IsConnected("SELECT count(Matricule) as moy2 FROM Employes WHERE Age1 between 35 and 44 ", False)
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        j3 = myDR("moy2")
                    End While
                End If
                IsConnected("SELECT count(Matricule) as moy3 FROM Employes WHERE Age1 between 45 and 59 ", False)
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        j4 = myDR("moy3")
                    End While
                End If
                IsConnected("SELECT count(Matricule) as Senior FROM Employes WHERE Age1 >60 ", False)
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        j5 = myDR("Senior")
                    End While
                End If
                Dim yvale1 As Double() = {j1, j2, j3, j4, j5}
                Dim xvale1 As String() = {"[18-24]", "[25-34]", "[35-44]", "[45-59]", "[60 et plus]"}
                Chart3.Series("Tranche Age").Points.DataBindXY(xvale1, yvale1)
                Dim ser As New Series("Age", ViewType.Spline)
                ser.Points.Add(New SeriesPoint("[18-24]", j1))
                ser.Points.Add(New SeriesPoint("[25-34]", j2))
                ser.Points.Add(New SeriesPoint("[35-44]", j3))
                ser.Points.Add(New SeriesPoint("[45-59]", j4))
                ser.Points.Add(New SeriesPoint("[60 et plus]", j5))
                ChartControl4.Series.Add(ser)
                ChartControl4.Legend.Visible = True
                Dim chartTitle3 As New ChartTitle()
                chartTitle3.Text = "Répartition par tranche d'age"
                ChartControl4.Titles.Add(chartTitle3)
            Catch ex As Exception
            End Try

            'Salaire


            Try
                Dim j1 As Double = 0
                Dim j2 As Double = 0
                Dim j3 As Double = 0
                Dim j4 As Double = 0
                Dim j5 As Double = 0
                Dim j6 As Double = 0
                IsConnected("SELECT count(Matricule) as nb1 FROM Employes WHERE S_B_01_14 <> '' and S_B_01_14 between '5000.00' and '9999.99' ", False)
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        j1 = myDR("nb1")
                    End While
                End If
                IsConnected("SELECT count(Matricule) as nb2 FROM Employes WHERE  S_B_01_14 <> '' and S_B_01_14 between '10000.00' and '19999.99' ", False)
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        j2 = myDR("nb2")
                    End While
                End If
                IsConnected("SELECT count(Matricule) as nb3 FROM Employes WHERE  S_B_01_14 <> '' and S_B_01_14 between '20000.00' and '29999.99' ", False)
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        j3 = myDR("nb3")
                    End While
                End If
                IsConnected("SELECT count(Matricule) as nb4 FROM Employes WHERE  S_B_01_14 <> '' and S_B_01_14 between '30000.00' and '39999.99' ", False)
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        j4 = myDR("nb4")
                    End While
                End If
                IsConnected("SELECT count(Matricule) as nb5 FROM Employes WHERE  S_B_01_14 <> '' and S_B_01_14 between '40000.00' and '49999.99' ", False)
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        j5 = myDR("nb5")
                    End While
                End If
                IsConnected("SELECT count(Matricule) as nb6 FROM Employes WHERE  S_B_01_14 <> '' and S_B_01_14 >='50000.00' ", False)
                If myDR.HasRows = True Then
                    While (myDR.Read())
                        j6 = myDR("nb6")
                    End While
                End If
                Dim y As Double() = {j1, j2, j3, j4, j5, j6}
                Dim x As String() = {"[5000.00-9999.99]", "[10000.00-19999.99]", "[20000.00-29999.99]", "[30000.00-39999.99]", "[40000.00-49999.99]", "[50000.00 et plus]"}
                Chart4.Series("Répartition par salaire").Points.DataBindXY(x, y)
                Dim ser As New Series("Sallaire", ViewType.StepLine)
                ser.Points.Add(New SeriesPoint("[5000.00-9999.99]", j1))
                ser.Points.Add(New SeriesPoint("[10000.00-19999.99]", j2))
                ser.Points.Add(New SeriesPoint("[20000.00-29999.99]", j3))
                ser.Points.Add(New SeriesPoint("[30000.00-39999.99]", j4))
                ser.Points.Add(New SeriesPoint("[40000.00-49999.99]", j5))
                ser.Points.Add(New SeriesPoint("[50000.00 et plus]", j6))
                ChartControl5.Series.Add(ser)
                ChartControl5.Legend.Visible = True
                Dim chartTitle4 As New ChartTitle()
                chartTitle4.Text = "Répartition par salaire"
                ChartControl5.Titles.Add(chartTitle4)
            Catch ex As Exception
            End Try
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class