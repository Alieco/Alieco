Imports System.Text
Imports DevExpress.XtraPrinting

Public Class SauvgardeBDD
    Dim sql As New SQLControl
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            'If du.Value= Or au.Value.ToString = "" Then MsgBox(" Veuillez saisir les dates ")
            If sql.VerifiyConnection = True Then
                Clipboard.SetText("SELECT * FROM presence_pointage WHERE date_pointage between '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "'")
                sql.RunQuery("SELECT Matricule, date_pointage, Entree1, Sortie1, Entree2,Sortie2,Entree3,Sortie3, Absence,HeureSupplementaire,Motif FROM presence_pointage WHERE date_pointage between '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "'")
                If sql.SQLDS.Tables.Count > 0 Then
                    DGVS.DataSource = sql.SQLDS.Tables(0)
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            Dim s As New SaveFileDialog
            s.DefaultExt = "*.AP"
            s.Title = "Choisisez le nom de fichier d'enregistrement"
            s.Filter = "Alieco Présence | *.AP"
            If s.ShowDialog = Windows.Forms.DialogResult.OK Then
                DGVS.ExportToCsv(s.FileName, New DevExpress.XtraPrinting.CsvExportOptions(";", Encoding.UTF8, TextExportMode.Value))
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub SauvgardeBDD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            du.Value = Date.Now.Date
            au.Value = Date.Now.Date
            My.Computer.Registry.ClassesRoot.CreateSubKey(".AP").SetValue("", "AliecoPresence")
            My.Computer.Registry.ClassesRoot.CreateSubKey("AliecoPresence\shell\open\command").SetValue("", Application.ExecutablePath & " %1")
            My.Computer.Registry.ClassesRoot.CreateSubKey("AliecoPresence\DefaultIcon").SetValue("", Application.StartupPath & "\icons\ap.ico")
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        Try
            Dim s As New SaveFileDialog
            s.DefaultExt = "*.AP"
            s.Title = "Choisisez le nom de fichier d'enregistrement"
            s.Filter = "Alieco Présence | *.AP"
            If Confirmation.ShowDialog = Windows.Forms.DialogResult.OK Then
                If s.ShowDialog = Windows.Forms.DialogResult.OK Then
                    DGVS.ExportToCsv(s.FileName, New DevExpress.XtraPrinting.CsvExportOptions(";", Encoding.UTF8, TextExportMode.Value))
                    IsConnected("DELETE FROM presence_pointage WHERE date_pointage between '" & du.Value.ToString("yyyy-MM-dd") & "' and '" & au.Value.ToString("yyyy-MM-dd") & "'", True)
                    DGVS.DataSource = Nothing
                    GridView1.Columns.Clear()
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class