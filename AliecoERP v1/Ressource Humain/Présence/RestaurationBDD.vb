Imports DevComponents.DotNetBar
Imports System.IO
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class RestaurationBDD
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            Dim EntryDate As String = ""
            Dim direction As String = ""
            Dim o As New OpenFileDialog
            o.Filter = "Alieco Présence | *.AP"
            If o.ShowDialog = Windows.Forms.DialogResult.OK Then
                TextBoxX1.Text = o.FileName
            End If
            Dim FILE_NAME As String = o.FileName
            Dim TextLine As String = ""
            Mainfrm.ProgressBarItem1.Value = 0
            If File.Exists(FILE_NAME) = True Then
                DGVsau.Rows.Clear()

                Dim nb As Integer = File.ReadAllLines(FILE_NAME).Length
                Mainfrm.ProgressBarItem1.Maximum = nb
                ' Mainfrm.LabelItem3.Text = "Nombre de ligne avant l'importe :  " & nb
                Dim fileReader As New StreamReader(FILE_NAME)
                Do While fileReader.Peek() <> -1
                    Dim line = fileReader.ReadLine().Replace("""", "")
                    Dim columns = line.Split(";")
                    If columns.Length = 11 Then
                        If IsNumeric(columns(0)) Then
                            DGVsau.Rows.Add(columns(0), columns(1), columns(2), columns(3), columns(4), columns(5), columns(6), columns(7), columns(8), columns(9), columns(10))
                            Mainfrm.ProgressBarItem1.Value += 1
                            Mainfrm.LabelItem2.Text = "Nombre de ligne : " & DGVsau.RowCount
                        End If
                    ElseIf columns.Length = 12 Then
                        If IsNumeric(columns(0)) Then
                            DGVsau.Rows.Add(columns(0), columns(1), columns(2), columns(3), columns(4), columns(5), columns(6), columns(7), columns(8), columns(9), columns(10), columns(11))
                            Mainfrm.ProgressBarItem1.Value += 1
                            Mainfrm.LabelItem2.Text = "Nombre de ligne : " & DGVsau.RowCount
                        End If
                    End If
                Loop
                Mainfrm.LabelItem2.Text = "Nombre de ligne : " & DGVsau.RowCount
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Try
            If Not BackgroundWorker1.IsBusy Then
                ButtonX2.Enabled = False
                ButtonX1.Enabled = False
                Mainfrm.ProgressBarItem1.Value = 0
                Mainfrm.ProgressBarItem1.Maximum = DGVsau.RowCount - 2
                BackgroundWorker1.RunWorkerAsync()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            For i = 0 To DGVsau.RowCount - 2

                Dim ab As String = DGVsau.Rows(i).Cells(8).Value.ToString
                Dim hs As String = DGVsau.Rows(i).Cells(9).Value.ToString
                Dim quary As String = " INSERT INTO presence_pointage(Matricule,date_pointage,Entree1,Sortie1,Entree2,Sortie2,Entree3,Sortie3,Absence,HeureSupplementaire,Motif)VALUES(" & DGVsau.Rows(i).Cells(0).Value & ",'" & CDate(DGVsau.Rows(i).Cells(1).Value).ToString("yyyy-MM-dd") & "','" & DGVsau.Rows(i).Cells(2).Value & "','" & DGVsau.Rows(i).Cells(3).Value & "','" & DGVsau.Rows(i).Cells(4).Value & "','" & DGVsau.Rows(i).Cells(5).Value & "','" & DGVsau.Rows(i).Cells(6).Value & "','" & DGVsau.Rows(i).Cells(7).Value & "','" & ab & "','" & hs & "','" & DGVsau.Rows(i).Cells(10).Value & "')"
                If IsConnected(quary, False) = True Then
                    BackgroundWorker1.ReportProgress(i)
                End If
            Next
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Try
            Mainfrm.ProgressBarItem1.Value = e.ProgressPercentage
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Try
            ButtonX2.Enabled = True
            ButtonX1.Enabled = True
            DGVsau.Rows.Clear()
            TextBoxX1.Clear()
            MessageBoxEx.Show("Le poitage à bien été Réstorer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub RestaurationBDD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            My.Computer.Registry.ClassesRoot.CreateSubKey(".AP").SetValue("", "AliecoPresence")
            My.Computer.Registry.ClassesRoot.CreateSubKey("AliecoPresence\shell\open\command").SetValue("", Application.ExecutablePath & " %1")
            My.Computer.Registry.ClassesRoot.CreateSubKey("AliecoPresence\DefaultIcon").SetValue("", Application.StartupPath & "\icons\ap.ico")
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class