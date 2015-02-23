Imports MySql.Data.MySqlClient
Imports DevComponents.DotNetBar

Public Class ResumeSocialeAnnuel
    Private dt As DataTable
    Public mat As Double = 0

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            dt = New DataTable
            dt.Columns.Add("Numéro")
            dt.Columns.Add("Numéro d'assurance")
            dt.Columns.Add("Nom")
            dt.Columns.Add("Prénom")
            dt.Columns.Add("Date de naissance")
            dt.Columns.Add("Nombre de jour 1er T")
            dt.Columns.Add("Montant 1")
            dt.Columns.Add("Nombre de jour 2eme T")
            dt.Columns.Add("Montant 2")
            dt.Columns.Add("Nombre de jour 3eme T")
            dt.Columns.Add("Montant 3")
            dt.Columns.Add("Nombre de jour 4eme T")
            dt.Columns.Add("Montant 4")
            dt.Columns.Add("Date d'entrée")
            dt.Columns.Add("Date de sortie")

            Dim i = 0
            IsConnected("SELECT Employes.Matricule,Nom, Prénom, Date_de_Naissance,Num_ss,Date_entrée,Date_fin_de_contrat FROM Employes,code_papers WHERE Employes.Matricule=code_papers.Matricule", False)
            If myDR.HasRows = True Then
                While myDR.Read
                    'MsgBox(myDR("Matricule"))
                    Dim row As DataRow = dt.NewRow()
                    row(0) = myDR("Matricule")
                    row(1) = myDR("Num_ss")
                    row(2) = myDR("Nom")
                    row(3) = myDR("Prénom")
                    row(4) = myDR("Date_de_Naissance") '.ToString("dd-MM-yyyy")
                    row(5) = ""
                    row(6) = ""
                    row(7) = ""
                    row(8) = ""
                    row(9) = ""
                    row(10) = ""
                    row(11) = ""
                    row(12) = ""
                    row(13) = myDR("Date_entrée") '.ToString("dd-MM-yyyy")
                    row(14) = myDR("Date_fin_de_contrat") '.ToString("dd-MM-yyyy")

                    dt.Rows.Add(row)

                    i += 1
                End While
            End If
            DGrsa.DataSource = dt
            Mainfrm.ProgressBarItem1.Value = 0
            Mainfrm.ProgressBarItem1.Maximum = GridView1.DataRowCount - 1
            If Not BackgroundWorker1.IsBusy Then
                ButtonX2.Enabled = False
                ButtonX1.Enabled = False
                ButtonX3.Visible = True
                BackgroundWorker1.RunWorkerAsync()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            For i = 0 To GridView1.DataRowCount - 1
                If BackgroundWorker1.CancellationPending = False Then
                    Dim Matricule As String = GridView1.GetRowCellValue(i, "Numéro").ToString()
                    Dim quary As String = "select(select sum(nombre) as nb1 from paie_mensuel where( moi_annee ='01" & Anne.Text & "' or moi_annee ='02" & Anne.Text & "' or moi_annee ='03" & Anne.Text & "') and Matricule='" & Matricule & "') as j1,(select sum(soumis_Impots) as montant1 from paie_mensuel where    (moi_annee ='01" & Anne.Text & "' or moi_annee ='02" & Anne.Text & "' or moi_annee ='03" & Anne.Text & "') and  (code='561' or code='564' or code='610') and Matricule='" & Matricule & "') as m1,(select sum(nombre) as nb1 from paie_mensuel where( moi_annee ='04" & Anne.Text & "' or moi_annee ='05" & Anne.Text & "' or moi_annee ='06" & Anne.Text & "') and Matricule='" & Matricule & "') as j2,(select sum(soumis_Impots) as montant1 from paie_mensuel where    (moi_annee ='04" & Anne.Text & "' or moi_annee ='05" & Anne.Text & "' or moi_annee ='06" & Anne.Text & "') and  (code='561' or code='564' or code='610') and Matricule='" & Matricule & "') as m2,(select sum(nombre) as nb1 from paie_mensuel where( moi_annee ='07" & Anne.Text & "' or moi_annee ='08" & Anne.Text & "' or moi_annee ='09" & Anne.Text & "') and Matricule='" & Matricule & "') as j3,(select sum(soumis_Impots) as montant1 from paie_mensuel where    (moi_annee ='07" & Anne.Text & "' or moi_annee ='08" & Anne.Text & "' or moi_annee ='09" & Anne.Text & "') and  (code='561' or code='564' or code='610') and Matricule='" & Matricule & "') as m3,(select sum(nombre) as nb1 from paie_mensuel where( moi_annee ='10" & Anne.Text & "' or moi_annee ='11" & Anne.Text & "' or moi_annee ='12" & Anne.Text & "') and Matricule='" & Matricule & "') as j4,(select sum(soumis_Impots) as montant1 from paie_mensuel where    (moi_annee ='10" & Anne.Text & "' or moi_annee ='11" & Anne.Text & "' or moi_annee ='12" & Anne.Text & "') and  (code='561' or code='564' or code='610') and Matricule='" & Matricule & "') as m4"
                    Console.WriteLine(quary)
                    If IsConnected(quary, False) = True Then
                        BackgroundWorker1.ReportProgress(i)
                        If myDR.HasRows Then
                            While myDR.Read
                                GridView1.SetRowCellValue(i, "Nombre de jour 1er T", IIf(myDR("j1").ToString = "", 0, myDR("j1").ToString))
                                GridView1.SetRowCellValue(i, "Montant 1", IIf(myDR("m1").ToString = "", 0, myDR("m1").ToString))
                                GridView1.SetRowCellValue(i, "Nombre de jour 2eme T", IIf(myDR("j2").ToString = "", 0, myDR("j2").ToString))
                                GridView1.SetRowCellValue(i, "Montant 2", IIf(myDR("m2").ToString = "", 0, myDR("m2").ToString))
                                GridView1.SetRowCellValue(i, "Nombre de jour 3eme T", IIf(myDR("j3").ToString = "", 0, myDR("j3").ToString))
                                GridView1.SetRowCellValue(i, "Montant 3", IIf(myDR("m3").ToString = "", 0, myDR("m3").ToString))
                                GridView1.SetRowCellValue(i, "Nombre de jour 4eme T", IIf(myDR("j4").ToString = "", 0, myDR("j4").ToString))
                                GridView1.SetRowCellValue(i, "Montant 4", IIf(myDR("m4").ToString = "", 0, myDR("m4").ToString))
                            End While
                        End If
                    End If
                Else
                    Exit For
                End If
            Next
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ResumeSocialeAnnuel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = True
            For i As Integer = 2000 To Date.Now.Year
                Anne.Items.Add(i)
            Next
            Anne.SelectedIndex = Anne.Items.Count - 1
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Try
            Mainfrm.ProgressBarItem1.Value = e.ProgressPercentage
            Mainfrm.LabelItem2.Text = "Calcule en cours ..." & e.ProgressPercentage
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Try
            ButtonX2.Enabled = True
            ButtonX1.Enabled = True
            ButtonX3.Visible = False
            MessageBoxEx.Show("Le Calcule est terminer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Mainfrm.LabelItem2.Text = "Calcule Términé"
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub Anne_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Anne.SelectedIndexChanged
        Try
            ButtonX2.Text = "Afficher le resumer Sociale Annuel de " & Anne.Text
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            Dim s As New SaveFileDialog
            s.Filter = "Fichier Text .txt|*.txt"
            s.Title = "Enregistrer le resumé social"
            If s.ShowDialog = Windows.Forms.DialogResult.OK Then
                Mainfrm.ProgressBarItem1.Value = 0
                Mainfrm.ProgressBarItem1.Maximum = GridView1.DataRowCount - 1

                Dim file As System.IO.StreamWriter
                file = My.Computer.FileSystem.OpenTextFileWriter(s.FileName, True)
                For i = 0 To GridView1.DataRowCount - 1
                    Mainfrm.LabelItem2.Text = "Extraction en cours ..." & i
                    Mainfrm.ProgressBarItem1.Value = i
                    file.WriteLine("16131204782010     " & GridView1.GetRowCellValue(i, "Numéro d'assurance").ToString() & "" & GridView1.GetRowCellValue(i, "Nom").ToString() & "                 " & GridView1.GetRowCellValue(i, "Prénom").ToString() & "                  " & GridView1.GetRowCellValue(i, "Montant 1").ToString() & " " & GridView1.GetRowCellValue(i, "Nombre de jour 1er T").ToString() & "J  " & GridView1.GetRowCellValue(i, "Montant 2").ToString() & " " & GridView1.GetRowCellValue(i, "Nombre de jour 2eme T").ToString() & "J  " & GridView1.GetRowCellValue(i, "Montant 3").ToString() & " " & GridView1.GetRowCellValue(i, "Nombre de jour 3eme T").ToString() & "J  " & GridView1.GetRowCellValue(i, "Montant 4").ToString() & " " & GridView1.GetRowCellValue(i, "Nombre de jour 4eme T").ToString() & "J  12768147    48800579" & GridView1.GetRowCellValue(i, "Date d'entrée").ToString() & GridView1.GetRowCellValue(i, "Date de sortie").ToString() & "")
                    Next
                Mainfrm.LabelItem2.Text = "Extraction Términé"
                file.Close()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Try
            If BackgroundWorker1.IsBusy Then
                BackgroundWorker1.CancelAsync()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class