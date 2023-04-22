Imports MySql.Data.MySqlClient
Module module_Connection
    Friend result As Boolean
    Friend sqlDS As DataSet
    Friend sqlDA As MySqlDataAdapter
    Friend conn As MySqlConnection
    Friend sqlDR As MySqlDataReader
    Friend sqlCmd As MySqlCommand
    Friend table As DataTable
    Friend row As DataRow
    Friend sql As String
    Public dt As New DataTable



    Friend strConn As String
    ''' - - - DATABASE CREDENTIALS - - - '''
    Friend dbhost = "localhost"
    Friend dbuser = "root"
    Friend dbpass = "Pass123*"
    Friend dbname = "inventory_db"
    Friend dbport = "3306"
    ' ' ' - - LIST OF TABLES - - ' ' '
    Friend tble As String = "tble_customers"
    Friend tble1 As String = "tble_settings"
    Friend tble2 As String = "tble_stock_in_out"
    Friend tble3 As String = "tble_stocks"
    Friend tble4 As String = "tble_user"



    Public Function connection() As Boolean
        Try
            conn = New MySqlConnection
            If conn.State = ConnectionState.Open Then conn.Close()
            strConn = "SERVER=" + dbhost + "; USERNAME=" + dbuser + ";PASSWORD=" + dbpass + ";DATABASE=" + dbname + ";PORT=" + dbport + ";"
            conn.ConnectionString = strConn
            conn.Open()
            result = True
        Catch ex As MySqlException
            result = False
            MessageBox.Show(ex.Message, "Database Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return result
    End Function

    Public Sub enable_disable(result As Boolean)
        With Dashboard
            .im_users.Enabled = result
            .im_settings.Enabled = result
            .im_stocks.Enabled = result
            .im_stockout.Enabled = result
            .im_customers.Enabled = result

        End With
    End Sub



    Public Sub createNoMsg(ByVal sql As String)
        Try
            conn.Open()
            With sqlCmd
                .Connection = conn
                .CommandText = sql
                sqlCmd.ExecuteNonQuery()

            End With
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "createNoMsg")
        End Try

    End Sub
End Module
