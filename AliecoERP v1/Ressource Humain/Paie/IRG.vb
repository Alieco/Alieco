Imports System.IO
Imports MySql.Data.MySqlClient
Imports DevComponents.DotNetBar

Public Class IRG
    Dim sql As New SQLControl
    Private dt As DataTable
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            dt = New DataTable
            dt.Columns.Add("Salaire")
            dt.Columns.Add("IRG")
            Dim o As New OpenFileDialog
            o.Filter = "CSV Files | *.csv"
            If o.ShowDialog = Windows.Forms.DialogResult.OK Then
                TextBoxX1.Text = o.FileName
            End If
            Dim FILE_NAME As String = o.FileName
            Dim TextLine As String = ""
            Mainfrm.ProgressBarItem1.Value = 0
            If File.Exists(FILE_NAME) = True Then
                Dim nb As Integer = File.ReadAllLines(FILE_NAME).Length
                Mainfrm.ProgressBarItem1.Maximum = nb
                Dim fileReader As New StreamReader(FILE_NAME)
                Do While fileReader.Peek() <> -1
                    Dim line = fileReader.ReadLine()
                    Dim columns = line.Split(";")
                    Dim dr As DataRow = dt.NewRow()
                    dr(0) = columns(0)
                    dr(1) = columns(1)

                    dt.Rows.Add(dr)
                    ' IsConnected("INSERT INTO `alieco`.`paie_irg` (`idIRG`,`Salaire`,`IRG`)  VALUES(NULL," & columns(0) & "," & columns(1) & ");", True)
                Loop
                Grid1.DataSource = dt
                ButtonX2.Enabled = True
                ButtonX4.Enabled = False
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            For i = 0 To GridView1.DataRowCount - 1
                Dim quary As String = " INSERT INTO `alieco`.`paie_irg` (`idIRG`,`Salaire`,`IRG`)  VALUES(NULL," & GridView1.GetRowCellValue(i, "Salaire").ToString() & "," & GridView1.GetRowCellValue(i, "IRG").ToString() & ");"
                If IsConnected(quary, True) = True Then
                    BackgroundWorker1.ReportProgress(i)
                End If
            Next
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
                Mainfrm.ProgressBarItem1.Maximum = GridView1.DataRowCount - 1
                BackgroundWorker1.RunWorkerAsync()
            End If
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
            ButtonX1.Enabled = True
            MessageBoxEx.Show("Le poitage à bien été enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Try
            If sql.VerifiyConnection Then
                sql.RunQuery("SELECT Salaire,IRG FROM paie_irg ORDER by IRG ASC")
                If sql.SQLDS.Tables.Count > 0 Then
                    Grid1.DataSource = sql.SQLDS.Tables(0)
                    ButtonX4.Enabled = True
                    ButtonX2.Enabled = False
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        Try
            If Not BackgroundWorker2.IsBusy Then
                ButtonX4.Enabled = False
                ButtonX3.Enabled = False
                Mainfrm.ProgressBarItem1.Value = 0
                Mainfrm.ProgressBarItem1.Maximum = GridView1.DataRowCount - 1
                BackgroundWorker2.RunWorkerAsync()
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundWorker2_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Try
            For i = 0 To GridView1.DataRowCount - 1
                Dim quary As String = " UPDATE `paie_irg` SET `IRG`=" & GridView1.GetRowCellValue(i, "IRG").ToString() & " WHERE `Salaire`=" & GridView1.GetRowCellValue(i, "Salaire").ToString() & " LIMIT 1"
                If IsConnected(quary, True) = True Then
                    BackgroundWorker2.ReportProgress(i)
                End If
            Next
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundWorker2_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker2.ProgressChanged
        Try
            Mainfrm.ProgressBarItem1.Value = e.ProgressPercentage
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        Try
            ButtonX3.Enabled = True
            MessageBoxEx.Show("Le poitage à bien été enregistrer", "Succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub

    Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX5.Click
        Try
            MsgBox(ficheDePaie.IRG08(irgtxt.Text, sailbsa.Text, asbt.Text))
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class