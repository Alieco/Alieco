Public Class EXportCCP

    Private Sub OpenBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenBtn.Click
        Dim o As New OpenFileDialog
        o.Filter = "CSV Files | *.csv"
        If o.ShowDialog = Windows.Forms.DialogResult.OK Then
            PathTxt.Text = o.FileName
        End If
        Dim FILE_NAME As String = o.FileName

        Dim TextLine As String = String.Empty

        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim fileReader As New System.IO.StreamReader(FILE_NAME)

            Do While fileReader.Peek() <> -1
                Dim line = fileReader.ReadLine().Replace(";", "").Replace("  ", " ")
                If line.Length < 62 Then
                    Dim line1 As String = line.Substring(0, line.Length - 1)
                    Dim un As String = line.Substring(line.Length - 1, 1)
                    While line1.Length < 61
                        line1 += " "
                    End While
                    line = line1 & un
                    ' MsgBox(line)
                End If
                TextLine += line & vbNewLine

            Loop

            ResultTxt.Text = TextLine

        Else

            MsgBox("File Does Not Exist")

        End If
    End Sub

    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        Dim s As New SaveFileDialog
        s.Filter = "Text File | *.txt"
        If s.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(s.FileName, ResultTxt.Text, False)
            MsgBox("Fichier enregistré dans : " & vbNewLine & s.FileName)
        End If
    End Sub
End Class