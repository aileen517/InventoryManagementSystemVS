Imports MySql.Data.MySqlClient

Public Class Dashboard
    Dim MysqlConn As MySqlConnection

    Private Sub im_users_Click(sender As Object, e As EventArgs) Handles im_users.Click
        With Users
            .Show()
            .Focus()

        End With
    End Sub

    Private Sub im_customers_Click(sender As Object, e As EventArgs) Handles im_customers.Click
        With Customers
            .Show()
            .Focus()

        End With
    End Sub

    Private Sub im_stocks_Click(sender As Object, e As EventArgs) Handles im_stocks.Click
        With Stocks
            .Show()
            .Focus()

        End With
    End Sub

   
    
    Private Sub im_stockout_Click(sender As Object, e As EventArgs) Handles im_stockout.Click
        With StocksOut
            .Show()
            .Focus()

        End With
    End Sub

    Private Sub im_settings_Click(sender As Object, e As EventArgs) Handles im_settings.Click
        With Settings
            .Show()
            .Focus()

        End With
    End Sub

    Private Sub im_login_Click(sender As Object, e As EventArgs) Handles im_login.Click
        
        With LogForm
            If im_login.Text = "LOGIN" Then
                .Show()
                .Focus()
            Else
                im_login.Text = "LOGIN"
                enable_disable(False)
            End If

        End With
    End Sub


    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enable_disable(False)

    End Sub
End Class