<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bot_clear = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logtxt_password = New System.Windows.Forms.TextBox()
        Me.logtxt_username = New System.Windows.Forms.TextBox()
        Me.bot_login = New System.Windows.Forms.Button()
        Me.bot_close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bot_clear
        '
        Me.bot_clear.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bot_clear.Location = New System.Drawing.Point(111, 125)
        Me.bot_clear.Name = "bot_clear"
        Me.bot_clear.Size = New System.Drawing.Size(75, 27)
        Me.bot_clear.TabIndex = 27
        Me.bot_clear.Text = "Clear"
        Me.bot_clear.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Username :"
        '
        'logtxt_password
        '
        Me.logtxt_password.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logtxt_password.Location = New System.Drawing.Point(26, 93)
        Me.logtxt_password.Name = "logtxt_password"
        Me.logtxt_password.Size = New System.Drawing.Size(237, 22)
        Me.logtxt_password.TabIndex = 25
        Me.logtxt_password.UseSystemPasswordChar = True
        '
        'logtxt_username
        '
        Me.logtxt_username.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logtxt_username.Location = New System.Drawing.Point(26, 41)
        Me.logtxt_username.Name = "logtxt_username"
        Me.logtxt_username.Size = New System.Drawing.Size(237, 22)
        Me.logtxt_username.TabIndex = 22
        '
        'bot_login
        '
        Me.bot_login.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bot_login.Location = New System.Drawing.Point(26, 125)
        Me.bot_login.Name = "bot_login"
        Me.bot_login.Size = New System.Drawing.Size(75, 27)
        Me.bot_login.TabIndex = 26
        Me.bot_login.Text = "Login"
        Me.bot_login.UseVisualStyleBackColor = True
        '
        'bot_close
        '
        Me.bot_close.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bot_close.Location = New System.Drawing.Point(195, 125)
        Me.bot_close.Name = "bot_close"
        Me.bot_close.Size = New System.Drawing.Size(75, 27)
        Me.bot_close.TabIndex = 28
        Me.bot_close.Text = "Close"
        Me.bot_close.UseVisualStyleBackColor = True
        '
        'LogForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 180)
        Me.Controls.Add(Me.bot_close)
        Me.Controls.Add(Me.bot_clear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logtxt_password)
        Me.Controls.Add(Me.logtxt_username)
        Me.Controls.Add(Me.bot_login)
        Me.Name = "LogForm"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bot_clear As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents logtxt_password As System.Windows.Forms.TextBox
    Friend WithEvents logtxt_username As System.Windows.Forms.TextBox
    Friend WithEvents bot_login As System.Windows.Forms.Button
    Friend WithEvents bot_close As System.Windows.Forms.Button

End Class
