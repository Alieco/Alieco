Imports System.IO

Public Class MainUpdater

    Private Sub MainUpdater_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim d As New IO.DirectoryInfo("\\SERVEUR\AliecoErpUpdate\")
        'list the names of all files in the specified directory
        For Each dr In d.GetDirectories
            Dim ex As Integer = 4

            Dim item As ListViewItem = New ListViewItem("", ex)
            item.SubItems.Add(dr.FullName)
            item.SubItems.Add("En Attente")
            ListView1.Items.Add(item)
        Next
        ' make a reference to a directory
        Dim di As New IO.DirectoryInfo("\\SERVEUR\AliecoErpUpdate\")
        Dim diar1 As IO.FileInfo() = di.GetFiles("*.*", IO.SearchOption.AllDirectories)
        Dim dra As IO.FileInfo

        'list the names of all files in the specified directory
        For Each dra In diar1

            Dim ex As Integer = 0
            Select Case dra.Extension
                Case ".dll"
                    ex = 1
                Case ".exe"
                    ex = 2
                Case ".ini"
                    ex = 3
                Case Else
                    ex = 0
            End Select

            Dim item As ListViewItem = New ListViewItem("", ex)
            item.SubItems.Add(dra.FullName)

            item.SubItems.Add(File.GetLastWriteTime(dra.FullName))
            item.SubItems.Add("En Attente")
            ListView1.Items.Add(item)
        Next

    End Sub
End Class