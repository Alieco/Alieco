Imports System.Runtime.InteropServices
Public Class UsbScan
    Public total As Integer = 0
    Private Const WM_DEVICECHANGE As Integer = &H219
    Private Const DBT_DEVICEARRIVAL As Integer = &H8000
    Private Const DBT_DEVTYP_VOLUME As Integer = &H2

    'Device information structure
    Public Structure DEV_BROADCAST_HDR
        Public dbch_size As Int32
        Public dbch_devicetype As Int32
        Public dbch_reserved As Int32
    End Structure

    'Volume information Structure
    Private Structure DEV_BROADCAST_VOLUME
        Public dbcv_size As Int32
        Public dbcv_devicetype As Int32
        Public dbcv_reserved As Int32
        Public dbcv_unitmask As Int32
        Public dbcv_flags As Int16
    End Structure

    'Function that gets the drive letter from the unit mask
    Private Function GetDriveLetterFromMask(ByRef Unit As Int32) As Char
        For i As Integer = 0 To 25
            If Unit = (2 ^ i) Then
                Return Chr(Asc("A") + i)
            End If
        Next
    End Function

    'Override message processing to check for the DEVICECHANGE message
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_DEVICECHANGE Then
            If CInt(m.WParam) = DBT_DEVICEARRIVAL Then
                Dim DeviceInfo As DEV_BROADCAST_HDR
                DeviceInfo = DirectCast(Marshal.PtrToStructure(m.LParam, GetType(DEV_BROADCAST_HDR)), DEV_BROADCAST_HDR)
                If DeviceInfo.dbch_devicetype = DBT_DEVTYP_VOLUME Then
                    Dim Volume As DEV_BROADCAST_VOLUME
                    Volume = DirectCast(Marshal.PtrToStructure(m.LParam, GetType(DEV_BROADCAST_VOLUME)), DEV_BROADCAST_VOLUME)
                    Dim DriveLetter As String = (GetDriveLetterFromMask(Volume.dbcv_unitmask) & ":\")
                    ComboBox1.Text = DriveLetter
                    Label2.Text = DriveLetter
                    ListView1.Items.Clear()
                    Dim aryFi() As String = IO.Directory.GetFiles(Label2.Text, "*.inf", IO.SearchOption.TopDirectoryOnly)
                    For Each aryF In aryFi
                        ListView1.Items.Add(aryF, 1).SubItems.Add(aryF)
                    Next
                    Dim aryFi1() As String = IO.Directory.GetFiles(Label2.Text, "*.lnk", IO.SearchOption.TopDirectoryOnly)
                    For Each aryF In aryFi1
                        ListView1.Items.Add(aryF, 1).SubItems.Add(aryF)
                    Next
                    'Dim aryFi2() As String = IO.Directory.GetFiles(Label2.Text, "*.exe", IO.SearchOption.AllDirectories)
                    'For Each aryF In aryFi2
                    '    ListView1.Items.Add(aryF, 1).SubItems.Add(aryF)
                    'Next

                    'attrib -s -h -r /s /d g:\*.*
                End If
            End If
        End If
        'Process all other messages as normal
        MyBase.WndProc(m)
    End Sub


    Sub ShowSubFolders(ByVal Folder)
        Dim str = ""
        For Each Subfolder In Folder.SubFolders
            str = str & " " & Subfolder.Path
            Subfolder.Attributes = 0
            ShowSubFolders(Subfolder)
        Next
    End Sub
    Private Sub UnhideWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles UnhideWorker.DoWork
        Dim cDrive As String = ComboBox1.Text
        Dim i As Integer = 0
        Dim aryFi() As String = IO.Directory.GetFiles(cDrive, "*", IO.SearchOption.AllDirectories)
        For Each aryF In aryFi
            'If Attribute.GetAttributes(aryF) =  Then

            'End If
            SetAttr(aryF, FileAttribute.Normal)
            i += 1
            UnhideWorker.ReportProgress(i)
        Next
        Dim aryDi() As String = IO.Directory.GetDirectories(cDrive, "*", IO.SearchOption.AllDirectories)
        For Each aryD In aryDi
            SetAttr(aryD, FileAttribute.Normal)
            i += 1
            UnhideWorker.ReportProgress(i)
        Next
    End Sub

    Private Sub UnhideWorker_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles UnhideWorker.ProgressChanged
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label3.Text = e.ProgressPercentage
        ProgressBar1.Value = Convert.ToInt32((e.ProgressPercentage * 100) / total)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub
    Public Function countTotal()
        Dim cDrive As String = ComboBox1.Text
        Dim num As Integer = 0
        Dim aryFi() As String = IO.Directory.GetFiles(cDrive, "*", IO.SearchOption.AllDirectories)
        For Each aryF In aryFi
            num += 1
        Next
        Dim aryDi() As String = IO.Directory.GetDirectories(cDrive, "*", IO.SearchOption.AllDirectories)
        For Each aryD In aryDi
            num += 1
        Next
        Return num
    End Function

    Private Sub UnhideWorker_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles UnhideWorker.RunWorkerCompleted
        MsgBox("Tous les fichiers sont reparés")
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            total = countTotal()
            Label5.Text = "/" & total
            UnhideWorker.RunWorkerAsync()
        Catch ex As Exception
            MsgBox("Vous devez brancher un flash disque avant de clicker sur le bouton")
        End Try
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        For i = 0 To ListView1.Items.Count - 1
            IO.File.Delete(ListView1.Items(i).SubItems(1).Text)
        Next
        MsgBox("OK")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
