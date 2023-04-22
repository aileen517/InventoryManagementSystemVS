Imports MySql.Data.MySqlClient

Public Class Customers
    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_data_to_datagrid()
    End Sub

    Public Sub display_data_to_datagrid()
        If connection() = True Then
            Try
                sqlCmd = New MySqlCommand("Select * from " + tble + " ", conn)
                sqlDA = New MySqlDataAdapter(sqlCmd)
                sqlDS = New DataSet
                sqlDA.Fill(sqlDS, tble)
                dg_listcus.DataSource = sqlDS.Tables(tble)
                dg_listcus.Columns(0).Visible = False

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error on Query!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub



    Private Sub cusbtn_save_Click(sender As Object, e As EventArgs) Handles cusbtn_save.Click
        If MessageBox.Show("You want to save this?", "Save this!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If connection() = True Then
                Try
                    Dim saveCommand As New MySqlCommand("INSERT INTO " + tble + " (CUSTOMERID, FIRSTNAME, LASTNAME, ADDRESS, MOBILE) " +
                        " VALUES (@CUSTOMERID, @FIRSTNAME, @LASTNAME, @ADDRESS, @MOBILE)", conn)
                    With saveCommand.Parameters

                        .AddWithValue("@CUSTOMERID", custxt_ID.Text)
                        .AddWithValue("@FIRSTNAME", custxt_fname.Text)
                        .AddWithValue("@LASTNAME", custxt_lname.Text)
                        .AddWithValue("@ADDRESS", custxt_add.Text)
                        .AddWithValue("@MOBILE", custxt_mobile.Text)
                        
                    End With
                    saveCommand.ExecuteNonQuery()
                    MessageBox.Show("Customer information succesfully save!", "Successfully saved!", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        custxt_ID.Text = ""
        custxt_fname.Text = ""
        custxt_lname.Text = ""
        custxt_add.Text = ""
        custxt_mobile.Text = ""
    End Sub



   

    Private Sub cusbtn_delete_Click(sender As Object, e As EventArgs) Handles cusbtn_delete.Click
        Dim ans As Integer = MessageBox.Show("Are you sure you want to delete selected Data?", "Delete selected Data?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = vbYes Then
            If connection() = True Then
                Try
                    sqlCmd = New MySqlCommand("DELETE FROM " & tble & " WHERE ID = '" & dg_listcus.SelectedRows(0).DataBoundItem(0).ToString & "' ", conn)
                    sqlDR = sqlCmd.ExecuteReader

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Database Query Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            If conn.State = ConnectionState.Open Then conn.Close()
            display_data_to_datagrid()
        End If

    End Sub


    
 

    Private Sub stxt_search_TextChanged(sender As Object, e As EventArgs) Handles custtxt_search.TextChanged
        If connection() = True Then
            Try
                sqlCmd = New MySqlCommand("Select * from " + tble + " Where LASTNAME LIKE '%" + custtxt_search.Text + "%' ", conn)
                sqlDA = New MySqlDataAdapter(sqlCmd)
                sqlDS = New DataSet
                sqlDA.Fill(sqlDS, tble3)
                dg_listcus.DataSource = sqlDS.Tables(tble3)
                dg_listcus.Columns(0).Visible = False

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Database Query Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub


    Private Sub cusbtn_update_Click(sender As Object, e As EventArgs) Handles cusbtn_update.Click
        If connection() = True Then
            Try
                Dim updateCommand As New MySqlCommand("UPDATE " + tble + " SET  CUSTOMERID=@CUSTOMERID, FIRSTNAME = @FIRSTNAME, LASTNAME = @LASTNAME, ADDRESS = @ADDRESS, MOBILE = @MOBILE WHERE ID = '" & dg_listcus.SelectedRows(0).DataBoundItem(0).ToString & "'", conn)
                With updateCommand.Parameters
                    .AddWithValue("@CUSTOMERID", custxt_ID.Text)
                    .AddWithValue("@FIRSTNAME", custxt_fname.Text)
                    .AddWithValue("@LASTNAME", custxt_lname.Text)
                    .AddWithValue("@ADDRESS", custxt_add.Text)
                    .AddWithValue("@MOBILE", custxt_mobile.Text)
                End With
                updateCommand.ExecuteNonQuery()
                MessageBox.Show("Customer information updated succesfully!", "Update saved!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Database Query Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
        display_data_to_datagrid()
    End Sub

    Private Sub cusbtn_clear_Click_1(sender As Object, e As EventArgs) Handles cusbtn_clear.Click
        Clear_Data()
        display_data_to_datagrid()
    End Sub



  
    Private Sub cusbtn_edit_Click(sender As Object, e As EventArgs) Handles cusbtn_edit.Click
        Clear_Data()
        If connection() = True Then

            On Error Resume Next
            sqlCmd = New MySqlCommand("Select * from " + tble + " WHERE ID = '" & dg_listcus.SelectedRows(0).DataBoundItem(0).ToString & "'", conn)
            sqlDA = New MySqlDataAdapter(sqlCmd)
            sqlDS = New DataSet
            sqlDA.Fill(sqlDS, tble)

            custxt_ID.Text = sqlDS.Tables(tble).Rows(0)("CUSTOMERID")
            custxt_fname.Text = sqlDS.Tables(tble).Rows(0)("FIRSTNAME")
            custxt_lname.Text = sqlDS.Tables(tble).Rows(0)("LASTNAME")
            custxt_add.Text = sqlDS.Tables(tble).Rows(0)("ADDRESS")
            custxt_mobile.Text = sqlDS.Tables(tble).Rows(0)("MOBILE")

        End If
        If conn.State = ConnectionState.Open Then conn.Close()

    End Sub
End Class