Imports DevExpress.XtraTreeList.Nodes
Imports System.IO

Public Class archive1
    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        Try
            For Each myDirectory As IO.DirectoryInfo In New IO.DirectoryInfo("\\ARCHIVES\archives").GetDirectories()
                For Each mFile As IO.FileInfo In New IO.DirectoryInfo(myDirectory.FullName).GetFiles()
                    mFile.Delete()
                    Dim List As ListViewItem = New ListViewItem("", 0)
                    List.SubItems.Add(mFile.FullName)
                    List.SubItems.Add("A bien été supprimé")
                    ListView1.Items.Add(List)
                Next
                For Each mssdirectory As IO.DirectoryInfo In New IO.DirectoryInfo(myDirectory.FullName).GetDirectories
                    mssdirectory.Delete(True)
                    Dim List As ListViewItem = New ListViewItem("", 1)
                    List.SubItems.Add(mssdirectory.FullName)
                    List.SubItems.Add("A bien été supprimé")
                    ListView1.Items.Add(List)
                Next
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub exist()
        Try
            ListView1.Items.Clear()
            For Each myDirectory As IO.DirectoryInfo In New IO.DirectoryInfo("\\ARCHIVES\archives").GetDirectories()
                Dim tailltotal As Double = 0
                Dim dInfo As New DirectoryInfo(myDirectory.FullName)
                Dim tail As Long = DirectorySize(dInfo, True)
                tailltotal += tail
                LabelX1.Text = "Taille total des fichiers : " & tailltotal
                If tail > 0 Then
                    Dim List As ListViewItem = New ListViewItem("", 0)
                    List.SubItems.Add(myDirectory.Name)
                    List.SubItems.Add(Math.Round((tail / 1024), 2) & " KB")
                    'Console.WriteLine("la taille de repertoire en KB : {0:N2} KB", (CDbl(tail)) / 1024)
                    ListView1.Items.Add(List)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SerachTxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SerachTxt.Click
        exist()
    End Sub
    Private Function DirectorySize(ByVal dInfo As DirectoryInfo, ByVal includeSubDir As Boolean) As Long
        Dim totalSize As Long = dInfo.EnumerateFiles().Sum(Function(file) file.Length)
        If includeSubDir Then
            totalSize += dInfo.EnumerateDirectories().Sum(Function(dir) DirectorySize(dir, True))
        End If
        Return totalSize
    End Function
End Class