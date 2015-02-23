Imports System.Threading
Imports DevComponents.DotNetBar
Imports System.Net
Imports System.IO

Public Class Update
    Private Sub Update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ini As New IniFile
        If File.Exists(Application.StartupPath & "\Config.ini") Then
            ini.Load(Application.StartupPath & "\Config.ini")
            Dim canvas = ini.GetKeyValue("Style", "canvas")
            Dim basecolor = ini.GetKeyValue("Style", "basecolor")
            If canvas <> "" And basecolor <> "" Then
                StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(ColorTranslator.FromHtml("#" & canvas), ColorTranslator.FromHtml("#" & basecolor))
            End If
        End If

        Dim Client As WebClient = New WebClient
        AddHandler Client.DownloadProgressChanged, AddressOf client_ProgressChanged
        AddHandler Client.DownloadFileCompleted, AddressOf client_DownloadCompleted
        Dim myProcesses As Process() = Process.GetProcessesByName("update")
        Dim myProcess As Process
        For Each myProcess In myProcesses
            myProcess.Kill()
        Next myProcess
        If IO.File.Exists("update.exe") Then
            IO.File.Delete("update.exe")
        End If
        If PathExists("\\SERVEUR\AliecoErpUpdate\update.exe", 5000) Then
            Client.DownloadFileAsync(New Uri("\\SERVEUR\AliecoErpUpdate\update.exe"), "update.exe")
        Else
            MessageBoxEx.Show("Le Fiche de mise à jour est inaccéssible Erreur code : 3311", "Erreur de réseau", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub
    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100
        ProgressBarX1.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub

    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Dim myProcesses As Process() = Process.GetProcessesByName("AliecoERP")
        Dim myProcess As Process
        For Each myProcess In myProcesses
            myProcess.Kill()
        Next myProcess
        Dim myFile As New FileInfo("update.exe")
        Dim sizeInBytes As Long = myFile.Length
        If IO.File.Exists("update.exe") And sizeInBytes > 0 Then
            Process.Start("update.exe")
        End If
        If ProgressBarX1.Value = 0 Then
            MessageBoxEx.Show("Le Fiche de mise à jour est inaccéssible", "Erreur de réseau", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub
    Public Function PathExists(ByVal path As String, ByVal timeout As Integer) As Boolean
        Dim exists As Boolean = True
        Dim t As New Thread(DirectCast(Function() CheckPathFunction(path), ThreadStart))
        t.Start()
        Dim completed As Boolean = t.Join(timeout)
        If Not completed Then
            exists = False
            t.Abort()
        End If
        Return exists
    End Function

    Public Function CheckPathFunction(ByVal path As String) As Boolean
        Return System.IO.File.Exists(path)
    End Function
End Class
