Imports DevComponents.DotNetBar.Metro.ColorTables
Imports System.IO
Imports DevComponents.DotNetBar

Public Class styler

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Mainfrm.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
        Mainfrm.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(Me.ColorPickerButton1.SelectedColor.R, Byte), Integer), CType(CType(Me.ColorPickerButton1.SelectedColor.G, Byte), Integer), CType(CType(Me.ColorPickerButton1.SelectedColor.B, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(Me.ColorPickerButton2.SelectedColor.R, Byte), Integer), CType(CType(Me.ColorPickerButton2.SelectedColor.G, Byte), Integer), CType(CType(Me.ColorPickerButton2.SelectedColor.B, Byte), Integer)))
        '  Mainfrm.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(ColorTranslator.FromHtml("#003399"), System.Drawing.Color.FromArgb(CType(CType(Me.ColorPickerButton2.SelectedColor.R, Byte), Integer), CType(CType(Me.ColorPickerButton2.SelectedColor.G, Byte), Integer), CType(CType(Me.ColorPickerButton2.SelectedColor.B, Byte), Integer)))
        Dim ini As New IniFile
        If File.Exists(Application.StartupPath & "\Config.ini") Then
            ini.Load(Application.StartupPath & "\Config.ini")
        End If
        ini.AddSection("Style").AddKey("Theme").Value = Mainfrm.StyleManager1.ManagerStyle.ToString
        ini.AddSection("Style").AddKey("canvas").Value = Mainfrm.StyleManager1.MetroColorParameters.CanvasColor.Name
        ini.AddSection("Style").AddKey("basecolor").Value = Mainfrm.StyleManager1.MetroColorParameters.BaseColor.Name
        ini.Save(Application.StartupPath & "\Config.ini")
        MessageBoxEx.Show("Les ocnfiguration ont bien étais enregistré !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub styler_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If File.Exists(Application.StartupPath & "\Config.ini") Then
            Dim ini As New IniFile
            ini.Load(Application.StartupPath & "\Config.ini")
            Dim canvas = ini.GetKeyValue("Style", "canvas")
            Dim basecolor = ini.GetKeyValue("Style", "basecolor")
            If canvas <> "" And basecolor <> "" Then
                Mainfrm.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(ColorTranslator.FromHtml("#" & canvas), ColorTranslator.FromHtml("#" & basecolor))
            End If
        End If
        Me.ColorPickerButton2.SelectedColor = Mainfrm.StyleManager1.MetroColorParameters.BaseColor
        Me.ColorPickerButton1.SelectedColor = Mainfrm.StyleManager1.MetroColorParameters.CanvasColor
    End Sub
End Class