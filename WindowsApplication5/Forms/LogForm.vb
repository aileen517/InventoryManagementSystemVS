
Imports MySql.Data.MySqlClient

Public Class LogForm


    Private Sub bot_login_Click(sender As Object, e As EventArgs) Handles bot_login.Click
       


                If logtxt_password.Text = "" Or logtxt_username.Text = "" Then
                    MessageBox.Show("Please complete the required fields..", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If connection() = True Then


                sqlCmd = New MySqlCommand("Select * from " + tble4 + " where USERNAME='" + logtxt_username.Text + "' and PASSWORD='" + logtxt_password.Text + "'", conn)
                sqlDA = New MySqlDataAdapter(sqlCmd)
                table = New DataTable
                sqlDA.Fill(table)

                If (table.Rows.Count > 0) Then
                    MessageBox.Show("Login Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    With Dashboard
                        .im_users.Enabled = result
                        .im_customers.Enabled = result
                        .im_stocks.Enabled = result
                        .im_stockout.Enabled = result
                        .im_settings.Enabled = result

                    
                        .im_login.Text = "LOGOUT"
                        Me.Close()

                    End With
                Else
                    MessageBox.Show("Error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If



            End If

        End If


                   
        If conn.State = ConnectionState.Open Then conn.Close()

    End Sub

    Private Sub LogForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bot_clear_Click(sender As Object, e As EventArgs) Handles bot_clear.Click
        Clear_Data()

    End Sub
    Sub Clear_Data()
        logtxt_username.Text = ""
        logtxt_password.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bot_close.Click
        Me.Close()
    End Sub
End Class
