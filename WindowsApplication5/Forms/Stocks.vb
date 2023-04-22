Imports MySql.Data.MySqlClient
Public Class Stocks


    Private Sub Stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If connection() = True Then
            Try
                sqlCmd = New MySqlCommand("Select * from " + tble1 + " ", conn)
                sqlDA = New MySqlDataAdapter(sqlCmd)
                table = New DataTable()
                sqlDA.Fill(table)
                stxt_cat.DataSource = table
                stxt_cat.DisplayMember = "DESCRIPTION"
                stxt_cat.ValueMember = "SETID"


            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error on Query!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
        display_data_to_datagrid()
    End Sub

    Public Sub display_data_to_datagrid()
        If connection() = True Then
            Try
                sqlCmd = New MySqlCommand("Select * from " + tble3 + " ", conn)
                sqlDA = New MySqlDataAdapter(sqlCmd)
                sqlDS = New DataSet
                sqlDA.Fill(sqlDS, tble3)
                sdtg_list.DataSource = sqlDS.Tables(tble3)
                sdtg_list.Columns(0).Visible = False


            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error on Query!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub


    Private Sub sbtn_save_Click(sender As Object, e As EventArgs) Handles sbtn_save.Click
        If MessageBox.Show("You want to save this?", "Save this!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If connection() = True Then
                Try
                    Dim saveCommand As New MySqlCommand("INSERT INTO " + tble3 + " (ITEM,  DESCRIPTION, TYPE, PRICE, QUANTITY) " +
                        " VALUES (@ITEM, @DESCRIPTION, @TYPE, @PRICE, @QUANTITY)", conn)
                    With saveCommand.Parameters

                        .AddWithValue("@ITEM", stxt_name.Text)
                        .AddWithValue("@DESCRIPTION", stxt_description.Text)
                        .AddWithValue("@TYPE", stxt_cat.Text)
                        .AddWithValue("@PRICE", stxt_price.Text)
                        .AddWithValue("@QUANTITY", stxt_qty.Text)

                    End With
                    saveCommand.ExecuteNonQuery()
                    MessageBox.Show("Item information succesfully save!", "Successfully saved!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Clear_Data()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Database Query Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            If conn.State = ConnectionState.Open Then conn.Close()
            display_data_to_datagrid()
        End If
    End Sub

    Sub Clear_Data()
        stxt_name.Text = ""
        stxt_description.Text = ""
        stxt_cat.Text = ""
        stxt_price.Text = ""
        stxt_qty.Text = ""
    End Sub

    Private Sub sbtn_delete_Click(sender As Object, e As EventArgs) Handles sbtn_delete.Click
        Dim ans As Integer = MessageBox.Show("Are you sure you want to delete selected Data?", "Delete selected Data?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = vbYes Then
            If connection() = True Then
                Try
                    sqlCmd = New MySqlCommand("DELETE FROM " & tble3 & " WHERE ITEMID = '" & sdtg_list.SelectedRows(0).DataBoundItem(0).ToString & "' ", conn)
                    sqlDR = sqlCmd.ExecuteReader

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Database Query Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            If conn.State = ConnectionState.Open Then conn.Close()
            display_data_to_datagrid()
        End If
    End Sub


    Private Sub stxt_search_TextChanged(sender As Object, e As EventArgs) Handles stxt_search.TextChanged
        If connection() = True Then
            Try
                sqlCmd = New MySqlCommand("Select * from " + tble3 + " Where ITEM LIKE '%" + stxt_search.Text + "%' ", conn)

                sqlDA = New MySqlDataAdapter(sqlCmd)
                sqlDS = New DataSet
                sqlDA.Fill(sqlDS, tble3)
                sdtg_list.DataSource = sqlDS.Tables(tble3)
                sdtg_list.Columns(0).Visible = False

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Database Query Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    Private Sub sbtn_update_Click(sender As Object, e As EventArgs) Handles sbtn_update.Click
        If connection() = True Then
            Try
                Dim updateCommand As New MySqlCommand("UPDATE " + tble3 + " SET  ITEM=@ITEM, DESCRIPTION = @DESCRIPTION, TYPE = @TYPE, PRICE = @PRICE, QUANTITY = @QUANTITY WHERE ITEMID = '" & sdtg_list.SelectedRows(0).DataBoundItem(0).ToString & "'", conn)
                With updateCommand.Parameters
                    .AddWithValue("@ITEM", stxt_name.Text)
                    .AddWithValue("@DESCRIPTION", stxt_description.Text)
                    .AddWithValue("@TYPE", stxt_cat.Text)
                    .AddWithValue("@PRICE", stxt_price.Text)
                    .AddWithValue("@QUANTITY", stxt_qty.Text)
                End With
                updateCommand.ExecuteNonQuery()
                MessageBox.Show("Item information updated succesfully!", "Update saved!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Database Query Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
        display_data_to_datagrid()
    End Sub


    Private Sub sbtn_clear_Click(sender As Object, e As EventArgs) Handles sbtn_clear.Click
        Clear_Data()
        display_data_to_datagrid()
    End Sub

    Private Sub sbtn_edit_Click(sender As Object, e As EventArgs) Handles sbtn_edit.Click
        Clear_Data()
        If connection() = True Then

            On Error Resume Next
            sqlCmd = New MySqlCommand("Select * from " + tble3 + " WHERE ITEMID = '" & sdtg_list.SelectedRows(0).DataBoundItem(0).ToString & "'", conn)
            sqlDA = New MySqlDataAdapter(sqlCmd)
            sqlDS = New DataSet
            sqlDA.Fill(sqlDS, tble3)

            stxt_name.Text = sqlDS.Tables(tble3).Rows(0)("ITEM")
            stxt_description.Text = sqlDS.Tables(tble3).Rows(0)("DESCRIPTION")
            stxt_cat.Text = sqlDS.Tables(tble3).Rows(0)("TYPE")
            stxt_price.Text = sqlDS.Tables(tble3).Rows(0)("PRICE")
            stxt_qty.Text = sqlDS.Tables(tble3).Rows(0)("QUANTITY")

        End If
        If conn.State = ConnectionState.Open Then conn.Close()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    End Sub

End Class