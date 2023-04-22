Imports MySql.Data.MySqlClient
Public Class Users
    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_data_to_datagrid()
    End Sub

    Public Sub display_data_to_datagrid()
        If connection() = True Then
            Try
                sqlCmd = New MySqlCommand("Select * from " + tble4 + " ", conn)
                sqlDA = New MySqlDataAdapter(sqlCmd)
                sqlDS = New DataSet
                sqlDA.Fill(sqlDS, tble4)
                userdtg_list.DataSource = sqlDS.Tables(tble4)
                userdtg_list.Columns(0).Visible = False


            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error on Query!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    Private Sub userbtn_save_Click(sender As Object, e As EventArgs) Handles userbtn_save.Click
        If MessageBox.Show("You want to save this?", "Save this!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If connection() = True Then
                Try
                    Dim saveCommand As New MySqlCommand("INSERT INTO " + tble4 + " (NAME, USERNAME, PASSWORD, TYPE ) " +
                        " VALUES (@NAME, @USERNAME, @PASSWORD, @TYPE)", conn)
                    With saveCommand.Parameters
                        .AddWithValue("@NAME", usertxt_name.Text)
                        .AddWithValue("@USERNAME", usertxt_uname.Text)
                        .AddWithValue("@PASSWORD", usertxt_pass.Text)
                        .AddWithValue("@TYPE", usercbo_type.Text)

                    End With
                    saveCommand.ExecuteNonQuery()
                    MessageBox.Show("User information succesfully save!", "Successfully saved!", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        usertxt_name.Text = ""
        usertxt_uname.Text = ""
        usertxt_pass.Text = ""
        usercbo_type.Text = ""
    End Sub

    Private Sub userbtn_update_Click(sender As Object, e As EventArgs) Handles userbtn_update.Click
        If connection() = True Then
            Try
                Dim updateCommand As New MySqlCommand("UPDATE " + tble4 + " SET  NAME=@NAME, USERNAME = @USERNAME, PASSWORD = @PASSWORD, TYPE = @TYPE WHERE USER_ID = '" & userdtg_list.SelectedRows(0).DataBoundItem(0).ToString & "'", conn)
                With updateCommand.Parameters
                    .AddWithValue("@NAME", usertxt_name.Text)
                    .AddWithValue("@USERNAME", usertxt_uname.Text)
                    .AddWithValue("@PASSWORD", usertxt_pass.Text)
                    .AddWithValue("@TYPE", usercbo_type.Text)
                End With
                updateCommand.ExecuteNonQuery()
                MessageBox.Show("User information updated succesfully!", "Update saved!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Database Query Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
        display_data_to_datagrid()
    End Sub

    Private Sub usertxt_search_TextChanged(sender As Object, e As EventArgs) Handles usertxt_search.TextChanged
        If connection() = True Then
            Try
                sqlCmd = New MySqlCommand("Select * from " + tble4 + " Where USERNAME LIKE '%" + usertxt_search.Text + "%' ", conn)
                sqlDA = New MySqlDataAdapter(sqlCmd)
                sqlDS = New DataSet
                sqlDA.Fill(sqlDS, tble3)
                userdtg_list.DataSource = sqlDS.Tables(tble3)
                userdtg_list.Columns(0).Visible = False

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Database Query Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    Private Sub userbtn_edit_Click(sender As Object, e As EventArgs) Handles userbtn_edit.Click
        Clear_Data()
        If connection() = True Then

            On Error Resume Next
            sqlCmd = New MySqlCommand("Select * from " + tble4 + " WHERE USER_ID = '" & userdtg_list.SelectedRows(0).DataBoundItem(0).ToString & "'", conn)
            sqlDA = New MySqlDataAdapter(sqlCmd)
            sqlDS = New DataSet
            sqlDA.Fill(sqlDS, tble4)

            usertxt_name.Text = sqlDS.Tables(tble4).Rows(0)("NAME")
            usertxt_uname.Text = sqlDS.Tables(tble4).Rows(0)("USERNAME")
            usertxt_pass.Text = sqlDS.Tables(tble4).Rows(0)("PASSWORD")
            usercbo_type.Text = sqlDS.Tables(tble4).Rows(0)("TYPE")

        End If
        If conn.State = ConnectionState.Open Then conn.Close()

    End Sub

    Private Sub userbtn_delete_Click(sender As Object, e As EventArgs) Handles userbtn_delete.Click
        Dim ans As Integer = MessageBox.Show("Are you sure you want to delete selected Data?", "Delete selected Data?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = vbYes Then
            If connection() = True Then
                Try
                    sqlCmd = New MySqlCommand("DELETE FROM " & tble4 & " WHERE USER_ID = '" & userdtg_list.SelectedRows(0).DataBoundItem(0).ToString & "' ", conn)
                    sqlDR = sqlCmd.ExecuteReader

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Database Query Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            If conn.State = ConnectionState.Open Then conn.Close()
            display_data_to_datagrid()
        End If
    End Sub

    Private Sub userbtn_clear_Click(sender As Object, e As EventArgs) Handles userbtn_clear.Click
        Clear_Data()
        display_data_to_datagrid()
    End Sub
End Class