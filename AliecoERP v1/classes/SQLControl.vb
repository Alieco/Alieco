Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class SQLControl

    Private SQLCon As New MySqlConnection With {.ConnectionString = "Server=serveur;Database=" & DATABASE_NAME & ";Uid=alieco;Pwd=h.mwSN3320"}
    Private SQLCmd As MySqlCommand
    Public SQLDA As MySqlDataAdapter
    Public SQLDS As DataSet
    Public SQLPArams As New List(Of MySqlParameter)

    Public Function VerifiyConnection() As Boolean
        Try
            SQLCon.Open()
            SQLCon.Close()
            Return True
        Catch ex As Exception
            ' MsgBox(ex.Message)
            Return False
        End Try
        Return False
    End Function

    Public Sub RunQuery(ByVal query As String)
        Try
            Console.WriteLine(query)
            SQLCon.Open()
            SQLCmd = New MySqlCommand(query, SQLCon)
            SQLDA = New MySqlDataAdapter(SQLCmd)
            SQLDS = New DataSet
            SQLDA.Fill(SQLDS)
            'SQLCon.Close()
        Catch ex As Exception
            'If SQLCon.State = ConnectionState.Open Then

            'End If
        Finally
            SQLCon.Close()
        End Try
    End Sub
    Public Sub RunNonQuery(ByVal query As String)
        Try
            Console.WriteLine(query)
            SQLCon.Open()
            SQLCmd = New MySqlCommand(query, SQLCon)
            SQLCmd.ExecuteNonQuery()
            'SQLCon.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
            'If SQLCon.State = ConnectionState.Open Then
            'End If
        Finally
            SQLCon.Close()
        End Try
    End Sub
    Public Sub ParamQuery(ByVal query As String)
        Try
            SQLCon.Open()
            SQLCmd = New MySqlCommand(query, SQLCon)
            For Each p In SQLPArams
                SQLCmd.Parameters.Add(p)
                ' SQLCmd.Parameters(p.ParameterName).Value = p.Value
            Next
            SQLDA = New MySqlDataAdapter(SQLCmd)
            SQLDS = New DataSet
            SQLDA.Fill(SQLDS)
            SQLCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQLCon.State = ConnectionState.Open Then
                SQLCon.Close()
            End If
        End Try
        SQLPArams.Clear()
    End Sub
    Public Sub ParamNonQuery(ByVal query As String)
        Try
            SQLCon.Open()
            SQLCmd = New MySqlCommand(query, SQLCon)
            For Each p In SQLPArams
                SQLCmd.Parameters.Add(p)
                '  SQLCmd.Parameters(p.ParameterName).Value = p.Value
            Next
           SQLCmd.ExecuteNonQuery()
            SQLCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQLCon.State = ConnectionState.Open Then
                SQLCon.Close()
            End If
        End Try
        SQLPArams.Clear()
    End Sub
    Public Sub AddParam(ByVal Name As String, ByVal Value As Object, Optional ByVal DataType As DbType = DbType.String)
        Try
            Dim newParam As New MySqlParameter With {.ParameterName = Name, .Value = Value}
            SQLPArams.Add(newParam)
        Catch ex As Exception

        End Try
        
    End Sub
    Public Function FillDataSet(ByVal dataSet As DataSet, ByVal queryString As String) As DataSet
        Try
            SQLCon.Open()
            SQLCmd = New MySqlCommand(queryString, SQLCon)
            SQLDA = New MySqlDataAdapter(SQLCmd)
            SQLDA.Fill(dataSet)
            SQLCon.Close()
            Return dataSet
        Catch ex As Exception
            If SQLCon.State = ConnectionState.Open Then
                SQLCon.Close()
            End If
            Return Nothing
        End Try
    End Function
    Public Sub WriteXMLDataSet(ByVal rappor As String, ByVal queryString As String)
        Try
            SQLCon.Open()
            SQLCmd = New MySqlCommand(queryString, SQLCon)
            SQLDA = New MySqlDataAdapter(SQLCmd)
            SQLDS = New DataSet
            SQLDS.Clear()
            SQLDA.Fill(SQLDS)
            SQLDS.WriteXml(CurDir() & "\Raports\" & rappor, XmlWriteMode.WriteSchema)
            SQLCon.Close()
        Catch ex As Exception
            If SQLCon.State = ConnectionState.Open Then
                SQLCon.Close()
            End If
        End Try
    End Sub
End Class
