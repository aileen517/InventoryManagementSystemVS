Imports MySql.Data.MySqlClient

Public Class ViewStockoutList
    Private Sub ViewStockoutList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_data_to_datagrid()
    End Sub

    Public Sub display_data_to_datagrid()
        If connection() = True Then
            Try
                sqlCmd = New MySqlCommand("Select * from " + tble2 + " ", conn)
                sqlDA = New MySqlDataAdapter(sqlCmd)
                sqlDS = New DataSet
                sqlDA.Fill(sqlDS, tble2)
                vsodtg_list.DataSource = sqlDS.Tables(tble2)
                vsodtg_list.Columns(0).Visible = False
                vsodtg_list.Columns(2).Visible = False


            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error on Query!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    Private Sub vsodtg_list_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles vsodtg_list.CellContentClick

    End Sub
End Class