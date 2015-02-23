
'Imports System.Data.SqlClient
'Imports System.IO

'Module Module1
'    Public myConn As New SqlConnection
'    Public myCmd As New SqlCommand
'    Public myDR As SqlDataReader
'    Public serveur, instance, username, password As String
'    Public user_id As Integer = 0


'    Public Function Initialized() As Boolean
'        Dim ini As New IniFile
'        Dim wrapper As New Simple3Des("h.mwSN3320")
'        If File.Exists(Application.StartupPath & "\Config.ini") Then
'            ini.Load(Application.StartupPath & "\Config.ini")
'            serveur = ini.GetKeyValue("Connexion", "server")
'            instance = ini.GetKeyValue("Connexion", "instance")
'            username = ini.GetKeyValue("Connexion", "user")
'            password = wrapper.DecryptData(ini.GetKeyValue("Connexion", "pass"))
'            Return True
'        End If
'        Return False
'    End Function


'    Public Function IsConnected(ByVal strQry As String, ByVal ver As Boolean, Optional ByVal con As String = "") As Boolean
'        ' Dim main As New Mainfrm
'        Control.CheckForIllegalCrossThreadCalls = False
'        Try
'            If myConn.State = ConnectionState.Open Then myConn.Close()
'            ' MsgBox("Data Source=" & serveur & "\" & instance & ";Initial Catalog=ALIECO;Persist Security Info=True;User ID=" & username & ";Password=" & password & "")
'            'If con <> "" Then
'            '    myConn.ConnectionString = con
'            'Else
'            myConn.ConnectionString = "Data Source=" & serveur & "\" & instance & ";Initial Catalog=ALIECO;Persist Security Info=True;User ID=" & username & ";Password=" & password & ""
'            'End If

'            myConn.Open()
'            myCmd.CommandText = strQry
'            myCmd.Connection = myConn
'            If ver = False Then
'                myDR = myCmd.ExecuteReader() 'For reading query
'            Else
'                myCmd.ExecuteNonQuery() 'For updating query
'            End If

'        Catch ex As Exception
'            MsgBox(ex.Message)
'            ' MsgBox("Une erreur dans la connexion au serveur" & Environment.NewLine & "Contactez le feurniseur 123" & Environment.NewLine & "Num d'erreur : 3333", MsgBoxStyle.Critical, "Erreur de connexion")
'            Return False
'            ' MsgBox("Erreur dans la connexion au serveur : N° 3377 " & Environment.NewLine & "Veuillez contacter l'informaticiens au 123", MsgBoxStyle.Critical, "Error")
'        End Try
'        Return True
'    End Function

'End Module
