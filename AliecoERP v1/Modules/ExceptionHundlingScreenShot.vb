Imports System.IO

Module ExceptionHundlingScreenShot
    Dim FileSize As UInt32
    Dim rawData() As Byte
    Dim fs As FileStream
    Dim sql As New SQLControl
    Public Sub EnvoiError(Optional ByVal ex As String = "")
        Try
            Dim bounds As Rectangle
            Dim screenshot As System.Drawing.Bitmap
            Dim graph As Graphics
            bounds = Screen.PrimaryScreen.Bounds
            screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb)
            graph = Graphics.FromImage(screenshot)
            graph.CopyFromScreen(0, 0, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
            Dim fileError As String = "error-" & My.Computer.Name & "-" & Date.Now.ToString("dd-MM-yyyy HH_mm_ss") & ".png"
            Dim fileErrorPath = Application.StartupPath & "/Docs/errors/" & fileError
            screenshot.Save(fileErrorPath, Imaging.ImageFormat.Png)

            ' Dim distinationError As String = Application.StartupPath & "/Docs/errors/" & My.Computer.Name & "/" & fileError
            'If IO.Directory.Exists(Application.StartupPath & "/Docs/errors/" & My.Computer.Name) Then
            '    IO.File.Copy(fileErrorPath, distinationError)
            'Else
            '    IO.Directory.CreateDirectory(Application.StartupPath & "/Docs/errors/" & My.Computer.Name)
            '    If IO.Directory.Exists(Application.StartupPath & "/Docs/errors/" & My.Computer.Name) Then
            '        IO.File.Copy(fileErrorPath, distinationError)
            '    End If
            'End If
            If File.Exists(fileErrorPath) Then
                fs = New FileStream(fileErrorPath, FileMode.Open, FileAccess.Read)
                FileSize = fs.Length

                rawData = New Byte(FileSize) {}
                fs.Read(rawData, 0, FileSize)
                fs.Close()
                sql.AddParam("file_name", fileError, DbType.String)
                sql.AddParam("@hostname", My.Computer.Name, DbType.String)
                sql.AddParam("@file_size", FileSize, DbType.String)
                sql.AddParam("@file", rawData, DbType.Byte)
                sql.AddParam("@ex_message", ex, DbType.String)

                sql.ParamNonQuery("INSERT INTO `informatique_exceptions`(`file_name`,`hostname`,`entry_date`,`file_size`,`file`,`ex_message`)VALUES(@file_name,@hostname,NOW(),@file_size,@file,@ex_message)")
            End If
        Catch e As Exception
        End Try
    End Sub
End Module
