Imports MySql.Data.MySqlClient
Public Class Settings
   
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_data_to_datagrid()
    End Sub

    Public Sub display_data_to_datagrid()
        If connection() = True Then
            Try
                sqlCmd = New MySqlCommand("Select * from " + tble1 + " ", conn)
                sqlDA = New MySqlDataAdapter(sqlCmd)
                sqlDS = New DataSet
                sqlDA.Fill(sqlDS, tble1)
                dg_listset.DataSource = sqlDS.Tables(tble1)
                dg_listset.Columns(0).Visible = False

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error on Query!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    Private Sub setbtn_save_Click(sender As Object, e As EventArgs) Handles setbtn_save.Click
        If MessageBox.Show("You want to save this?", "Save this!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If connection() = True Then
                Try
                    Dim saveCommand As New MySqlCommand("INSERT INTO " + tble1 + " (CATEGORYID, DESCRIPTION) " +
                        " VALUES (@CATEGORYID, @DESCRIPTION)", conn)
                    With saveCommand.Parameters

                        .AddWithValue("@CATEGORYID", settxt_ID.Text)
                        .AddWithValue("@DESCRIPTION", settxt_cat.Text)
                        

                    End With
                    saveCommand.ExecuteNonQuery()
                    MessageBox.Show("Settings information succesfully save!", "Successfully saved!", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        settxt_ID.Text = ""
        settxt_cat.Text = ""
      
    End Sub


    Private Sub setbtn_delete_Click(sender As Object, e As EventArgs) Handles setbtn_delete.Click
        Dim ans As Integer = MessageBox.Show("Are you sure you want to delete selected Data?", "Delete selected Data?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = vbYes Then
            If connection() = True Then
                Try
                    sqlCmd = New MySqlCommand("DELETE FROM " & tble1 & " WHERE SETID = '" & dg_listset.SelectedRows(0).DataBoundItem(0).ToString & "' ", conn)
                    sqlDR = sqlCmd.ExecuteReader

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Database Query Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            If conn.State = ConnectionState.Open Then conn.Close()
            display_data_to_datagrid()
        End If

    End Sub

    Private Sub setsearch_search_TextChanged(sender As Object, e As EventArgs) Handles setsearch_search.TextChanged
        If connection() = True Then
            Try
                sqlCmd = New MySqlCommand("Select * from " + tble1 + " Where DESCRIPTION LIKE '%" + setsearch_search.Text + "%' ", conn)

                sqlDA = New MySqlDataAdapter(sqlCmd)
                sqlDS = New DataSet
                sqlDA.Fill(sqlDS, tble1)
                dg_listset.DataSource = sqlDS.Tables(tble1)
                dg_listset.Columns(0).Visible = False

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Database Query Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub


    Private Sub setbtn_update_Click(sender As Object, e As EventArgs) Handles setbtn_update.Click
        If connection() = True Then
            Try
                Dim updateCommand As New MySqlCommand("UPDATE " + tble1 + " SET  CATEGORYID=@CATEGORYID, DESCRIPTION = @DESCRIPTION WHERE SETID = '" & dg_listset.SelectedRows(0).DataBoundItem(0).ToString & "'", conn)
                With updateCommand.Parameters
                    .AddWithValue("@CATEGORYID", settxt_ID.Text)
                    .AddWithValue("@DESCRIPTION", settxt_cat.Text)
                  
                End With
                updateCommand.ExecuteNonQuery()
                MessageBox.Show("Category information updated succesfully!", "Update saved!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Database Query Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
        display_data_to_datagrid()
    End Sub

    Private Sub setbtn_clear_Click(sender As Object, e As EventArgs) Handles setbtn_clear.Click
        Clear_Data()
        display_data_to_datagrid()
    End Sub

    Private Sub setbtn_edit_Click(sender As Object, e As EventArgs) Handles setbtn_edit.Click
        Clear_Data()
        If connection() = True Then

            On Error Resume Next
            sqlCmd = New MySqlCommand("Select * from " + tble1 + " WHERE SETID = '" & dg_listset.SelectedRows(0).DataBoundItem(0).ToString & "'", conn)
            sqlDA = New MySqlDataAdapter(sqlCmd)
            sqlDS = New DataSet
            sqlDA.Fill(sqlDS, tble)

            settxt_ID.Text = sqlDS.Tables(tble).Rows(0)("CATEGORYID")
            settxt_cat.Text = sqlDS.Tables(tble).Rows(0)("DESCRIPTION")
           
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub
End Class