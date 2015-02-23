Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList
Imports DevComponents.DotNetBar


Public Class ExceptionErrors

    Private Sub ExceptionErrors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        loadFilestoTree()
    End Sub

#Region "Function"
    Sub loadFilestoTree()
        treelist1.Nodes.Clear()
        treelist1.BeginUnboundLoad()
        Dim parentForRootNodes As TreeListNode = Nothing
        Dim rootNode As TreeListNode = treelist1.AppendNode(New Object() {"Lists des erreurs"}, parentForRootNodes)
        rootNode.ImageIndex = 0

        If IsConnected("SELECT hostname,count(id) as erros FROM informatique_exceptions group by hostname", False) Then

            If myDR.HasRows Then
                While myDR.Read
                    Dim aff As TreeListNode = treelist1.AppendNode(New Object() {myDR("hostname") & " - (" & myDR("erros") & ")"}, rootNode)
                    aff.ImageIndex = 1
                    aff.SelectImageIndex = 1
                End While
            End If
        End If
        For Each n As TreeListNode In rootNode.Nodes

            Dim hostname = n.GetDisplayText(0).Split(" - ")
            Dim v As String = hostname(0)
            IsConnected("SELECT file_name FROM informatique_exceptions where hostname='" & v & "'", False)
            If myDR.HasRows Then
                While myDR.Read
                    Dim af As TreeListNode = treelist1.AppendNode(New Object() {myDR("file_name")}, n)
                    af.ImageIndex = 2
                    af.SelectImageIndex = 3
                End While
            End If
            n.ExpandAll()
            n.Expanded = True
        Next
        rootNode.Expanded = True
        treelist1.EndUnboundLoad()
    End Sub
    Sub LoadFacture()

    End Sub
#End Region

    Private Sub treelist1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles treelist1.DoubleClick
        Dim fPoint As Point = Control.MousePosition
        Dim tl As TreeList = sender
        fPoint = tl.PointToClient(fPoint)
        Dim hInfo As TreeListHitInfo = tl.CalcHitInfo(fPoint)
        If Not hInfo.Node Is Nothing Then
            If hInfo.Node.GetDisplayText(0).Contains("error") Then

                IsConnected("SELECT file,hostname,ex_message,entry_date FROM informatique_exceptions WHERE file_name='" & hInfo.Node.GetDisplayText(0).ToString & "'", False)
                If myDR.HasRows Then
                    Dim hostname As String = ""
                    While myDR.Read
                        hostname = myDR("hostname")
                        LabelX3.Text = myDR("hostname").ToString
                        LabelX4.Text = myDR("entry_date").ToString
                        LabelX6.Text = myDR("ex_message").ToString
                        Dim lb() As Byte = myDR("file")
                        Dim lstr As New System.IO.MemoryStream(lb)
                        Console.WriteLine(lb(0))
                        PicturePreview.Image = Image.FromStream(lstr)
                        lstr.Close()
                        IsConnected("SELECT * FROM informatique_query_log WHERE hostname='" & hostname & "' ORDER BY id Desc LIMIT 100", False)
                        If myDR.HasRows Then
                            While myDR.Read
                                ListBoxControl1.Items.Add(myDR("query_text").ToString)
                            End While
                        End If
                    End While
                End If
            End If
        End If
    End Sub


    Private Sub CopierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopierToolStripMenuItem.Click
        If ListBoxControl1.SelectedItems.Count > 0 Then
            Clipboard.SetText(ListBoxControl1.SelectedItems(0).ToString)
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        If treelist1.FocusedNode.GetDisplayText(0).Contains("error") Then
            If MessageBoxEx.Show("Voullez vous vraiment corriger cette error ?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                IsConnected("DELETE FROM informatique_exceptions WHERE file_name='" & treelist1.FocusedNode.GetDisplayText(0).ToString & "' LIMIT 1", True)
                loadFilestoTree()
                Mainfrm.ButtonItem162.NotificationMarkText -= 1
            End If
            End If
    End Sub
End Class