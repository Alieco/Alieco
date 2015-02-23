Module RegistryManipulation
    Public Sub CreateKey(ByVal ayun As String, ByVal Value As String)
        Dim b As Object
        On Error Resume Next
        b = CreateObject("wscript.shell")
        b.RegWrite(ayun, Value)
    End Sub
    Public Sub CreateIntegerKey(ByVal ayun As String, ByVal Value As Integer)
        Dim b As Object
        On Error Resume Next
        b = CreateObject("wscript.shell")
        b.RegWrite(ayun, Value, "REG_DWORD")
    End Sub
    Public Sub DeleteKey(ByVal ayun As String)
        Dim b As Object
        On Error Resume Next
        b = CreateObject("Wscript.Shell")
        b.RegDelete(ayun)
    End Sub
End Module
