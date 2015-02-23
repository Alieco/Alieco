Imports System.Text.RegularExpressions

Module Fonctions

    Public Function mysql_escape_string(ByVal st As String) As String
        Return st.Replace("'", "\'")
    End Function
    Function ConvertBytes(ByVal Bytes As Double) As String
        Dim s As String = ""
        On Error GoTo errr

        If Bytes >= 1073741824 Then
            s = Format(Bytes / 1024 / 1024 / 1024, "#0.00") & " GB"
        ElseIf Bytes >= 1048576 Then
            s = Format(Bytes / 1024 / 1024, "#0.00") & " MB"
        ElseIf Bytes >= 1024 Then
            s = Format(Bytes / 1024, "#0.00") & " KB"
        ElseIf Bytes < 1024 Then
            s = Fix(Bytes) & " Bytes"
        End If
        Return s
        Exit Function
errr:
        s = "0 Bytes"
        Return s
    End Function
End Module
