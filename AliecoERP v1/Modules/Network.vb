Imports System.Management
Imports DevComponents.DotNetBar

Module Network

    Public Sub GetNetworkInfo(ByVal Machine As String)
        Dim scope As New System.Management.ManagementScope("\\" + Machine + "\root\cimv2")
        scope.Connect()
        Dim objectQuery As New ObjectQuery("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionId IS NOT NULL")
        Dim searcher As New ManagementObjectSearcher(scope, objectQuery)
        Dim os As ManagementObject
        Dim moColl As ManagementObjectCollection = searcher.Get()
        Dim _list As String = ""
        For Each os In moColl
            Console.WriteLine(os("NetConnectionId"))
            Console.WriteLine(ChangeAddress("set dns """ & os("NetConnectionId").ToString & """ static 208.67.222.123 primary"))
            Console.WriteLine(ChangeAddress("add dns """ & os("NetConnectionId").ToString & """ 208.67.220.123 2"))

        Next os
        MessageBoxEx.Show("Votre famille est maintenant protégé !!!", "Merci :)", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Function ChangeAddress(ByVal Argument As String) As String
        Dim _Process As New Process()
        _Process.StartInfo.RedirectStandardOutput = True
        _Process.StartInfo.UseShellExecute = False
        _Process.StartInfo.FileName = "C:\WINDOWS\system32\netsh"
        _Process.StartInfo().Arguments = "interface ip " & Argument
        _Process.Start()
        Dim _StringBuilder As New System.Text.StringBuilder
        _StringBuilder.Append("Executing: netsh " & _Process.StartInfo.Arguments & ControlChars.CrLf)
        While Not _Process.StandardOutput.EndOfStream
            _StringBuilder.Append(_Process.StandardOutput.ReadLine() & ControlChars.CrLf)
        End While
        Return _StringBuilder.ToString
    End Function
End Module
