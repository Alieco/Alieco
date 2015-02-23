Imports System.Threading
Imports DevExpress.XtraGrid.Views.Grid

Public Class Medalle
    Dim sql As New SQLControl
    Private Sub Medalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            Me.WindowState = FormWindowState.Maximized
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Sub reload()
        Try
            If sql.VerifiyConnection = True Then
                sql.RunQuery("SELECT Matricule,Nom,Prénom,Date_de_Naissance,DATE_FORMAT(FROM_DAYS(TO_DAYS(STR_TO_DATE('" & Date.Now.Date() & "', '%d/%m/%Y')) - TO_DAYS(STR_TO_DATE(Date_de_Naissance, '%d-%m-%Y'))), '%Y')+0 AS Age ,DATE_FORMAT(FROM_DAYS(TO_DAYS(STR_TO_DATE('01-05-" & Date.Now.Year() & "', '%d-%m-%Y')) - TO_DAYS(STR_TO_DATE(Date_entrée, '%d-%m-%Y'))), '%Y')+0 AS Ancianté ,Lieux_de_Naissance,Ville,Date_entrée,Fonction,Collectif  FROM Employes WHERE DATE_FORMAT(FROM_DAYS(TO_DAYS(STR_TO_DATE('01-05-" & Date.Now.Year() & "', '%d-%m-%Y')) - TO_DAYS(STR_TO_DATE(Date_entrée, '%d-%m-%Y'))), '%Y')+0 =10 OR DATE_FORMAT(FROM_DAYS(TO_DAYS(STR_TO_DATE('01-05-" & Date.Now.Year() & "', '%d-%m-%Y')) - TO_DAYS(STR_TO_DATE(Date_entrée, '%d-%m-%Y'))), '%Y')+0 =20 OR DATE_FORMAT(FROM_DAYS(TO_DAYS(STR_TO_DATE('01-05-" & Date.Now.Year() & "', '%d-%m-%Y')) - TO_DAYS(STR_TO_DATE(Date_entrée, '%d-%m-%Y'))), '%Y')+0 =30")
                ' TextBox1.Text = "SELECT *  FROM Employes WHERE DATE_FORMAT(FROM_DAYS(TO_DAYS(STR_TO_DATE('01-05-" & Date.Now.Year() & "', '%d-%m-%Y')) - TO_DAYS(STR_TO_DATE(Date_entrée, '%d-%m-%Y'))), '%Y')+0 =10;"
                If sql.SQLDS.Tables.Count > 0 Then
                    dgv1.DataSource = sql.SQLDS.Tables(0)
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        'Dim medalleThread As Thread = New Thread(AddressOf reload)
        'medalleThread.Start()
        reload()
    End Sub

    Private Sub GridView1_RowStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView1.RowStyle
        Try
            '< GridView1.SelectedRowsCount - 1
            Dim View As GridView = sender
            If (e.RowHandle >= 0) Then
                Dim Anciante As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Ancianté"))
                If (Anciante = "10") Then
                    e.Appearance.BackColor = Color.FromArgb(170, 146, 88)
                End If
                If (Anciante > "19") Then
                    e.Appearance.BackColor = Color.FromArgb(189, 195, 199)
                End If
                If (Anciante > "29") Then
                    e.Appearance.BackColor = Color.FromArgb(241, 196, 15)
                End If
            End If
        Catch ex As Exception
            EnvoiError(ex.Message)
        End Try
    End Sub
End Class