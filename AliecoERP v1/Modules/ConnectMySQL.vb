Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.IO
Imports DevComponents.DotNetBar

Module Module1
    Public myConn As New MySqlConnection
    Public myCmd As New MySqlCommand
    Public myDR As MySqlDataReader
    Public serveur, instance, username, password, constring As String
    Public DATABASE_NAME As String = "alieco"
    Public user_id As Integer = 0

    Public Function Initialized() As Boolean
        Dim ini As New IniFile
        Dim wrapper As New Simple3Des("h.mwSN3320")
        If File.Exists(Application.StartupPath & "\Config.ini") Then
            ini.Load(Application.StartupPath & "\Config.ini")
            serveur = ini.GetKeyValue("Connexion", "server")
            instance = ini.GetKeyValue("Connexion", "instance")
            username = ini.GetKeyValue("Connexion", "user")
            DATABASE_NAME = ini.GetKeyValue("Connexion", "database")
            password = wrapper.DecryptData(ini.GetKeyValue("Connexion", "pass"))
            Return True
        End If
        Return False
    End Function

    Public Function IsConnected(ByVal strQry As String, ByVal ver As Boolean, Optional ByVal con As String = "") As Boolean
        ' Dim main As New Mainfrm
        Control.CheckForIllegalCrossThreadCalls = False
        Try
            If myConn.State = ConnectionState.Open Then myConn.Close()
            ' MsgBox("Data Source=" & serveur & "\" & instance & ";Initial Catalog=ALIECO;Persist Security Info=True;User ID=" & username & ";Password=" & password & "")
            'If con <> "" Then
            '    myConn.ConnectionString = con
            'Else
            constring = "Server=" & serveur & ";Database=" & DATABASE_NAME & ";Uid=" & username & ";Pwd=" & password & ""
            myConn.ConnectionString = constring
            'End If
            Console.WriteLine(strQry)

            myConn.Open()
            myCmd.CommandText = "INSERT INTO `informatique_query_log`(`id`,`hostname`,`query_text`,`entry_date`)VALUES(NULL,'" & My.Computer.Name & "','" & mysql_escape_string(strQry).Replace("\\", "\") & "',NOW());" & strQry
            ' Console.WriteLine(myCmd.CommandText)
            myCmd.Connection = myConn
            If ver = False Then
                myDR = myCmd.ExecuteReader() 'For reading query
            Else
                myCmd.ExecuteNonQuery() 'For updating query
            End If
        Catch ex As MySqlException
            'Clipboard.SetText(strQry)
            MsgBox(ex.Message)
            'MessageBoxEx.Show("Erreur dans la connexion au serveur : N° 3377 " & Environment.NewLine & "Veuillez contacter le développeur au 123", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function
    'Else
    'Try
    '    If IsConnected("SELECT * FROM paie_mensuel WHERE Matricule='" & mat.Text & "' and moi_annee='" & datej.Text & "' and type='P'", False) = True Then
    '        If myDR.HasRows = True Then
    '            ButtonX1.Text = "Enregistrer les modifications "
    '        End If
    '    End If
    'Catch ex As Exception
    '    EnvoiError(ex.Message)
    'End Try
End Module

