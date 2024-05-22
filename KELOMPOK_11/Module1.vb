Imports MySql.Data.MySqlClient

Module Module1
    Public conn As mysqlconnection
    Public cmd As mysqlcommand
    Public rd As mysqldatareader
    Public da As mysqldataadapter
    Public ds As DataSet
    Public str As String

 
    Sub koneksi()
        Try
            Dim str As String =
            "server=localhost;userid=root;password=;database=mahasiswa_db"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                'Console.WriteLine("ok")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub


End Module
