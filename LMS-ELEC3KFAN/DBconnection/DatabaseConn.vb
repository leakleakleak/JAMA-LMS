Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text

Module DatabaseConn

    Public conn As OleDbConnection
    Public cmd As OleDbCommand
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public dr As OleDbDataReader



    Sub openServer()
        conn = New OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\\JAMAbase.mdb"
        conn.Open()

    End Sub


    Public Function OpenConnectString() As String
        Dim connectionstring As String
        connectionstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\1404a\Downloads\LMS-ELEC3KFANv3\JAMAbase.mdb"
        Return connectionstring
    End Function
    Sub datareader(ByVal sql As String)
        cmd = New OleDbCommand
        cmd.Connection = conn
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader()
    End Sub

    Sub AddEditDeleteRecord(ByVal sql As String)
        cmd = New OleDbCommand
        cmd.Connection = conn
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
    End Sub

    Sub retrieveRecord(ByVal sql As String)

        ds = New DataSet
        da = New OleDbDataAdapter(sql, conn)
        da.Fill(ds, "a")
    End Sub

    Public Function GetHash(theInput As String) As String
        Using hasher As SHA256 = SHA256.Create()    ' create hash object

            ' Convert to byte array and get hash
            Dim dbytes As Byte() =
                 hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))

            ' sb to create string from bytes
            Dim sBuilder As New StringBuilder()

            ' convert byte data to hex string
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n

            Return sBuilder.ToString()

        End Using
    End Function
End Module