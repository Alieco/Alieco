Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Security.AccessControl

Module FolderLocker
    Public status As String = ""
    Private arr As String() = New String(5) {}
    Public Sub lockFolder()
        arr(0) = ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}"
        arr(1) = ".{21EC2020-3AEA-1069-A2DD-08002B30309D}"
        arr(2) = ".{2559a1f4-21d7-11d4-bdaf-00c04f60b9f0}"
        arr(3) = ".{645FF040-5081-101B-9F08-00AA002F954E}"
        arr(4) = ".{2559a1f1-21d7-11d4-bdaf-00c04f60b9f0}"
        arr(5) = ".{7007ACC7-3202-11D1-AAD2-00805FC1270E}"
        status = arr(0)
        Dim FolderBrowserDialog1 As New FolderBrowserDialog
        If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim dirnam As DirectoryInfo = New DirectoryInfo(FolderBrowserDialog1.SelectedPath)
            Dim selectedpath As String = dirnam.Parent.FullName + dirnam.Name

            If FolderBrowserDialog1.SelectedPath.LastIndexOf(".{") = -1 Then
                If (Not dirnam.Root.Equals(dirnam.Parent.FullName)) Then
                    dirnam.MoveTo(dirnam.Parent.FullName & "\" & dirnam.Name & status)
                Else
                    dirnam.MoveTo(dirnam.Parent.FullName + dirnam.Name & status)
                End If
            Else
                status = getstatus(status)
                dirnam.MoveTo(FolderBrowserDialog1.SelectedPath.Substring(0, FolderBrowserDialog1.SelectedPath.LastIndexOf(".")))
            End If
            'Dim fs As FileSystemSecurity = File.GetAccessControl(FolderBrowserDialog1.SelectedPath)
            'fs.AddAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
            'File.SetAccessControl(FolderBrowserDialog1.SelectedPath, fs)
        End If
    End Sub
    Public Sub UnlockFolder()
        arr(0) = ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}"
        arr(1) = ".{21EC2020-3AEA-1069-A2DD-08002B30309D}"
        arr(2) = ".{2559a1f4-21d7-11d4-bdaf-00c04f60b9f0}"
        arr(3) = ".{645FF040-5081-101B-9F08-00AA002F954E}"
        arr(4) = ".{2559a1f1-21d7-11d4-bdaf-00c04f60b9f0}"
        arr(5) = ".{7007ACC7-3202-11D1-AAD2-00805FC1270E}"
        Dim FolderBrowserDialog1 As New FolderBrowserDialog
        status = arr(1)

        If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim dirnam As DirectoryInfo = New DirectoryInfo(FolderBrowserDialog1.SelectedPath)
            Dim selectedpath As String = dirnam.Parent.FullName + dirnam.Name

            If FolderBrowserDialog1.SelectedPath.LastIndexOf(".{") = -1 Then
                If (Not dirnam.Root.Equals(dirnam.Parent.FullName)) Then
                    dirnam.MoveTo(dirnam.Parent.FullName & "\" & dirnam.Name & status)
                Else
                    dirnam.MoveTo(dirnam.Parent.FullName + dirnam.Name & status)
                End If
            Else
                status = getstatus(status)
                dirnam.MoveTo(FolderBrowserDialog1.SelectedPath.Substring(0, FolderBrowserDialog1.SelectedPath.LastIndexOf(".")))
            End If
            'Dim fs As FileSystemSecurity = File.GetAccessControl(FolderBrowserDialog1.SelectedPath)
            'fs.RemoveAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
            'File.SetAccessControl(FolderBrowserDialog1.SelectedPath, fs)
        End If
    End Sub
    Private Function getstatus(ByVal stat As String) As String
        For i As Integer = 0 To 5
            If stat.LastIndexOf(arr(i)) <> -1 Then
                stat = stat.Substring(stat.LastIndexOf("."))
            End If
        Next i
        Return stat
    End Function
End Module
