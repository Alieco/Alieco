Public Class RapportAbsentéisme

  
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            direction.Enabled = False

            If mat.Text.Length = 5 And IsNumeric(mat.Text) Then
                Dim ds1 As AbsentéismeDS = New AbsentéismeDS
                Dim titre As String = ""
                ds1.EnforceConstraints = False
                Try
                    'Attempt to fill the dataset MainTable
                    ds1.PointageAbsence.Clear()
                    IsConnected("SELECT count(Employes.Matricule) as Nombre_absence ,Employes.Matricule, Nom, Prénom, Direction,date_pointage, Entree1,Sortie1, Entree2,Sortie2,Entree3,Sortie3, Absence, HeureSupplementaire, Motif,Fonction,Département FROM presence_pointage, Employes WHERE Employes.Matricule=presence_pointage.Matricule and (date_pointage between  '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "') and (Motif like '%Absent( e )%') and Employes.Matricule=" & mat.Text, False)
                    Clipboard.SetText("SELECT count(Employes.Matricule) as Nombre_absence ,Employes.Matricule, Nom, Prénom, Direction,date_pointage, Entree1,Sortie1, Entree2,Sortie2,Entree3,Sortie3, Absence, HeureSupplementaire, Motif,,Fonction,Département FROM presence_pointage, Employes WHERE Employes.Matricule=presence_pointage.Matricule and (date_pointage between  '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "') and (Motif like '%Absent( e )%') and Employes.Matricule=" & mat.Text)
                    If myDR.HasRows Then
                        While myDR.Read
                            titre = "Fonctionnaire " & myDR("nom") & " " & myDR("prénom") & " " & "Absent(e)"
                            ds1.PointageAbsence.AddPointageAbsenceRow(IIf(IsDBNull(myDR("Matricule")), "", myDR("Matricule")), IIf(IsDBNull(myDR("Nombre_absence")), "", myDR("Nombre_absence")), IIf(IsDBNull(myDR("nom")), "", myDR("nom")), IIf(IsDBNull(myDR("prénom")), "", myDR("prénom")), IIf(IsDBNull(myDR("Direction")), "", myDR("Direction")), IIf(IsDBNull(myDR("date_pointage")), "", myDR("date_pointage")), IIf(IsDBNull(myDR("Entree1")), "", myDR("Entree1")), IIf(IsDBNull(myDR("Sortie1")), "", myDR("Sortie1")), IIf(IsDBNull(myDR("Entree2")), "", myDR("Entree2")), IIf(IsDBNull(myDR("Sortie2")), "", myDR("Sortie2")), IIf(IsDBNull(myDR("Entree3")), "", myDR("Entree3")), IIf(IsDBNull(myDR("Sortie3")), "", myDR("Sortie3")), IIf(IsDBNull(myDR("Absence")), "", myDR("Absence")), IIf(IsDBNull(myDR("HeureSupplementaire")), "", myDR("HeureSupplementaire")), IIf(IsDBNull(myDR("Motif")), "", myDR("Motif")), IIf(IsDBNull(myDR("Fonction")), "", myDR("Fonction")))
                        End While
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    ds1.EnforceConstraints = True
                End Try

                Dim cr As New PointAbsence()
                cr.XrLabel1.Text = titre.ToString
                cr.DataSource = ds1
                DocumentViewer1.DocumentSource = cr
                cr.CreateDocument(True)
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_direction()
        Try
            If IsConnected("SELECT DISTINCT Direction FROM Employes ", False) = True Then
                If myDR.HasRows = True Then
                    direction.Items.Clear()
                    While (myDR.Read())
                        direction.Items.Add(myDR("Direction"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub load_mat()
        Try
            If IsConnected("SELECT DISTINCT Matricule FROM presence_pointage ORDER BY Matricule ASC", False) = True Then
                If myDR.HasRows = True Then
                    mat.Items.Clear()
                    While (myDR.Read())
                        mat.Items.Add(myDR("Matricule"))
                    End While
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ds1 As AbsentéismeDS = New AbsentéismeDS
        Dim titre As String = ""
        ds1.EnforceConstraints = False
        Try
            'Attempt to fill the dataset MainTable
            ds1.PointageAbsence.Clear()
            'SELECT COunt(Matricule) as nb,Motif FROM alieco.presence_pointage WHERE Matricule=20133 and (date_pointage between  '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "') GROUP BY Motif;
            IsConnected("SELECT count(Employes.Matricule) as Nombre_absence ,Employes.Matricule, Nom, Prénom, Direction,date_pointage, Entree1,Sortie1, Entree2,Sortie2,Entree3,Sortie3, Absence, HeureSupplementaire, Motif,Fonction,Département FROM presence_pointage, Employes WHERE Employes.Matricule=presence_pointage.Matricule and (date_pointage between  '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "') and (Motif like '%Absent( e )%') and Direction='" & direction.Text & "'", False)
            Clipboard.SetText("SELECT count(Employes.Matricule) as Nombre_absence ,Employes.Matricule, Nom, Prénom, Direction,date_pointage, Entree1,Sortie1, Entree2,Sortie2,Entree3,Sortie3, Absence, HeureSupplementaire, Motif,Fonction,Département FROM presence_pointage, Employes WHERE Employes.Matricule=presence_pointage.Matricule and (date_pointage between  '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "') and (Motif like '%Absent( e )%') and Direction='" & direction.Text & "'")
            If myDR.HasRows Then
                While myDR.Read
                    titre = "La direction " & direction.Text
                    ds1.PointageAbsence.AddPointageAbsenceRow(IIf(IsDBNull(myDR("Matricule")), "", myDR("Matricule")), IIf(IsDBNull(myDR("Nombre_absence")), "", myDR("Nombre_absence")), IIf(IsDBNull(myDR("nom")), "", myDR("nom")), IIf(IsDBNull(myDR("prénom")), "", myDR("prénom")), IIf(IsDBNull(myDR("Direction")), "", myDR("Direction")), IIf(IsDBNull(myDR("date_pointage")), "", myDR("date_pointage")), IIf(IsDBNull(myDR("Entree1")), "", myDR("Entree1")), IIf(IsDBNull(myDR("Sortie1")), "", myDR("Sortie1")), IIf(IsDBNull(myDR("Entree2")), "", myDR("Entree2")), IIf(IsDBNull(myDR("Sortie2")), "", myDR("Sortie2")), IIf(IsDBNull(myDR("Entree3")), "", myDR("Entree3")), IIf(IsDBNull(myDR("Sortie3")), "", myDR("Sortie3")), IIf(IsDBNull(myDR("Absence")), "", myDR("Absence")), IIf(IsDBNull(myDR("HeureSupplementaire")), "", myDR("HeureSupplementaire")), IIf(IsDBNull(myDR("Motif")), "", myDR("Motif")), IIf(IsDBNull(myDR("Fonction")), "", myDR("Fonction")))
                End While
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        Finally
            ds1.EnforceConstraints = True
        End Try
        Dim cr As New DirectionAbsence()
        cr.XrLabel1.Text = titre.ToString
        cr.DataSource = ds1
        DocumentViewer1.DocumentSource = cr
        cr.CreateDocument(True)
    End Sub

    Private Sub RapportAbsentéisme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            load_direction()
            load_mat()
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Try
            If RadioButton1.Checked Then
                mat.Enabled = True
                direction.Enabled = False
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Try
            If RadioButton2.Checked Then
                mat.Enabled = False
                direction.Enabled = True
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class