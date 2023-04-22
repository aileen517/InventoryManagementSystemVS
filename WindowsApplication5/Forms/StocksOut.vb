Imports MySql.Data.MySqlClient
Public Class StocksOut
    Private Sub sobtn_viewso_Click(sender As Object, e As EventArgs)
        With ViewStockoutList
            .Show()
            .Focus()

        End With
    End Sub

    Private Sub StocksOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_data_to_datagrid()


    End Sub

    Public Sub display_data_to_datagrid()
        If connection() = True Then
            Try
                sqlCmd = New MySqlCommand("Select * from " + tble3 + " ", conn)
                sqlDA = New MySqlDataAdapter(sqlCmd)
                sqlDS = New DataSet
                sqlDA.Fill(sqlDS, tble3)
                sodtg_itemlist.DataSource = sqlDS.Tables(tble3)



            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error on Query!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        If conn.State = ConnectionState.Open Then conn.Close()


    End Sub
    Sub Clear_Data()
        sotxt_fnamecust.Text = ""
        txtCus_lname.Text = ""

    End Sub



    Private Sub sotxt_search_TextChanged(sender As Object, e As EventArgs) Handles sotxt_search.TextChanged
        If connection() = True Then
            Try
                sqlCmd = New MySqlCommand("Select * from " + tble3 + " Where ITEM LIKE '%" + sotxt_search.Text + "%' ", conn)
                sqlDA = New MySqlDataAdapter(sqlCmd)
                sqlDS = New DataSet
                sqlDA.Fill(sqlDS, tble3)
                sodtg_itemlist.DataSource = sqlDS.Tables(tble3)


            Catch ex As Exception
                MessageBox.Show(ex.Message, "Database Query Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub




    Private Sub sotxt_cusid_TextChanged_1(sender As Object, e As EventArgs) Handles sotxt_cusid.TextChanged
        Clear_Data()
        If connection() = True Then

            On Error Resume Next
            sqlCmd = New MySqlCommand("Select * from " + tble + " WHERE CUSTOMERID = '" & sotxt_cusid.Text & "'", conn)
            sqlDA = New MySqlDataAdapter(sqlCmd)
            sqlDS = New DataSet
            sqlDA.Fill(sqlDS, tble)

            sotxt_fnamecust.Text = sqlDS.Tables(tble).Rows(0)("FIRSTNAME")
            txtCus_lname.Text = sqlDS.Tables(tble).Rows(0)("LASTNAME")

        End If
        If conn.State = ConnectionState.Open Then conn.Close()

    End Sub



    Private Sub sobtn_add_Click(sender As Object, e As EventArgs) Handles sobtn_add.Click
        If connection() = True Then
            Try
                If sodtg_addedlist.RowCount = 0 Then
                    With sodtg_itemlist.CurrentRow
                        sodtg_addedlist.ColumnCount = 6
                        sodtg_addedlist.Columns(0).Name = "ITEMID"
                        sodtg_addedlist.Columns(1).Name = "ITEM"
                        sodtg_addedlist.Columns(2).Name = "DESCRIPTION"
                        sodtg_addedlist.Columns(3).Name = "TYPE"
                        sodtg_addedlist.Columns(4).Name = "TOTALPRICE"
                        sodtg_addedlist.Columns(5).Name = "QUANTITY"

                        Dim qty = Convert.ToInt32(sotxt_quantity.Text)

                        Dim tot As Double = Double.Parse(.Cells(4).Value) * Convert.ToInt32(sotxt_quantity.Text)

                        Dim row As String() = New String() {.Cells(0).Value,
                                                        .Cells(1).Value,
                                                       .Cells(2).Value,
                                                       .Cells(3).Value,
                                                       tot,
                                                       Convert.ToInt32(sotxt_quantity.Text)
                                                       }
                        sodtg_addedlist.Rows.Add(row)

                    End With
                Else
                    For Each r As DataGridViewRow In sodtg_addedlist.Rows
                        If sodtg_itemlist.CurrentRow.Cells(0).Value = r.Cells(0).Value Then
                            MsgBox("Item is already in the cart", MsgBoxStyle.Exclamation)
                            Exit Sub
                        End If
                        For Each v As DataGridViewRow In sodtg_itemlist.Rows

                        Next
                    Next
                    If sodtg_addedlist.CurrentRow.Cells(0).Value <> sodtg_itemlist.CurrentRow.Cells(0).Value Then
                        With sodtg_itemlist.CurrentRow
                            sodtg_addedlist.ColumnCount = 6
                            sodtg_addedlist.Columns(0).Name = "ITEMID"
                            sodtg_addedlist.Columns(1).Name = "ITEM"
                            sodtg_addedlist.Columns(2).Name = "DESCRIPTION"
                            sodtg_addedlist.Columns(3).Name = "TYPE"
                            sodtg_addedlist.Columns(4).Name = "TOTALPRICE"
                            sodtg_addedlist.Columns(5).Name = "QUANTITY"


                            Dim qty = Convert.ToInt32(sotxt_quantity.Text)

                            Dim tot As Double = Double.Parse(.Cells(4).Value) * Convert.ToInt32(sotxt_quantity.Text)
                            Dim row As String() = New String() {.Cells(0).Value,
                                                            .Cells(1).Value,
                                                            .Cells(2).Value,
                                                                 .Cells(3).Value,
                                                           tot,
                                                           Convert.ToInt32(sotxt_quantity.Text)
                                                           }
                            sodtg_addedlist.Rows.Add(row)

                        End With


                    Else
                        MsgBox("Item is already in the cart", MsgBoxStyle.Exclamation)
                    End If

                    For Each v As DataGridViewRow In sodtg_itemlist.Rows

                    Next
                End If



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub



    Private Sub sobtn_remove_Click(sender As Object, e As EventArgs) Handles sobtn_remove.Click
        Try
            sodtg_addedlist.Rows.Remove(sodtg_addedlist.CurrentRow)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub sobtn_save_Click(sender As Object, e As EventArgs) Handles sobtn_save.Click

        If sotxt_cusid.Text = "" Then
            MsgBox("There are empty fields left that must be fill up!", MsgBoxStyle.Exclamation)
            Return
        End If

        If sodtg_addedlist.RowCount = 0 Then
            MsgBox("Empty Cart!", MsgBoxStyle.Exclamation)
            Return
        End If


        ''''''''''''''''''''''''''''''''''''''''stock-out

        If MessageBox.Show("You want to save this?", "Save this!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If connection() = True Then
                For Each r As DataGridViewRow In sodtg_addedlist.Rows

                    Try
                        Dim saveCommand As New MySqlCommand("INSERT INTO " + tble2 + " ( DATE, ITEMID, ITEM, DESCRIPTION, TYPE, TOTALPRICE, QUANTITY, CUSTOMERID) " +
                            " VALUES ( @DATE, @ITEMID, @ITEM, @DESCRIPTION, @TYPE, @TOTALPRICE, @QUANTITY, @CUSTOMERID)", conn)
                        With saveCommand.Parameters
                            .AddWithValue("@DATE", Format(Now, "yyyy-MM-dd"))
                            .AddWithValue("@ITEMID", r.Cells(0).Value)
                            .AddWithValue("@ITEM", r.Cells(1).Value)
                            .AddWithValue("@DESCRIPTION", r.Cells(2).Value)
                            .AddWithValue("@TYPE", r.Cells(3).Value)
                            .AddWithValue("@TOTALPRICE", r.Cells(4).Value)
                            .AddWithValue("@QUANTITY", r.Cells(5).Value)
                            .AddWithValue("@CUSTOMERID", sotxt_cusid.Text)




                        End With
                        saveCommand.ExecuteNonQuery()
                        MessageBox.Show("StockOut information succesfully save!", "Successfully saved!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Clear_Data()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Database Query Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Next
            End If
            If conn.State = ConnectionState.Open Then conn.Close()
        End If

        '''''''''''''''''''''''''''update quantity in stocks
        If connection() = True Then
            For Each r As DataGridViewRow In sodtg_addedlist.Rows

                Try
                    Dim updateCommand As New MySqlCommand("UPDATE " + tble3 + " SET  QUANTITY=QUANTITY - '" & r.Cells(5).Value & "' WHERE ITEMID = @ITEMID", conn)
                    With updateCommand.Parameters
                        .AddWithValue("@ITEMID", r.Cells(0).Value)

                    End With
                    updateCommand.ExecuteNonQuery()

                Catch ex As Exception
                    createNoMsg(sql)
                End Try
            Next
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
        display_data_to_datagrid()
    End Sub
    Private Sub sobtn_view_Click(sender As Object, e As EventArgs) Handles sobtn_view.Click
        With ViewStockoutList
            .Show()
            .Focus()
        End With
    End Sub
End Class