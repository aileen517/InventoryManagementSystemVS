<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.im_users = New System.Windows.Forms.ToolStripButton()
        Me.im_customers = New System.Windows.Forms.ToolStripButton()
        Me.im_stocks = New System.Windows.Forms.ToolStripButton()
        Me.im_stockout = New System.Windows.Forms.ToolStripButton()
        Me.im_settings = New System.Windows.Forms.ToolStripButton()
        Me.im_login = New System.Windows.Forms.ToolStripButton()
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.toolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolStrip1
        '
        Me.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolStrip1.ImageScalingSize = New System.Drawing.Size(50, 35)
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.im_users, Me.im_customers, Me.im_stocks, Me.im_stockout, Me.im_settings, Me.im_login})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(69, 474)
        Me.toolStrip1.TabIndex = 1
        Me.toolStrip1.Text = "toolStrip1"
        '
        'im_users
        '
        Me.im_users.Image = CType(resources.GetObject("im_users.Image"), System.Drawing.Image)
        Me.im_users.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.im_users.Name = "im_users"
        Me.im_users.Size = New System.Drawing.Size(66, 54)
        Me.im_users.Text = "Users"
        Me.im_users.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'im_customers
        '
        Me.im_customers.Image = CType(resources.GetObject("im_customers.Image"), System.Drawing.Image)
        Me.im_customers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.im_customers.Name = "im_customers"
        Me.im_customers.Size = New System.Drawing.Size(66, 54)
        Me.im_customers.Text = "Customers"
        Me.im_customers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'im_stocks
        '
        Me.im_stocks.Image = CType(resources.GetObject("im_stocks.Image"), System.Drawing.Image)
        Me.im_stocks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.im_stocks.Name = "im_stocks"
        Me.im_stocks.Size = New System.Drawing.Size(66, 54)
        Me.im_stocks.Text = "Stocks-in"
        Me.im_stocks.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'im_stockout
        '
        Me.im_stockout.Image = CType(resources.GetObject("im_stockout.Image"), System.Drawing.Image)
        Me.im_stockout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.im_stockout.Name = "im_stockout"
        Me.im_stockout.Size = New System.Drawing.Size(66, 54)
        Me.im_stockout.Text = "Stock-out"
        Me.im_stockout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'im_settings
        '
        Me.im_settings.Image = CType(resources.GetObject("im_settings.Image"), System.Drawing.Image)
        Me.im_settings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.im_settings.Name = "im_settings"
        Me.im_settings.Size = New System.Drawing.Size(66, 54)
        Me.im_settings.Text = "Settings"
        Me.im_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'im_login
        '
        Me.im_login.Image = CType(resources.GetObject("im_login.Image"), System.Drawing.Image)
        Me.im_login.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.im_login.Name = "im_login"
        Me.im_login.Size = New System.Drawing.Size(66, 54)
        Me.im_login.Text = "Login"
        Me.im_login.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'statusStrip1
        '
        Me.statusStrip1.Location = New System.Drawing.Point(69, 452)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(878, 22)
        Me.statusStrip1.TabIndex = 2
        Me.statusStrip1.Text = "statusStrip1"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(947, 474)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.toolStrip1)
        Me.Name = "Dashboard"
        Me.Text = "Inventory System Dashboard"
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
    Public WithEvents im_customers As System.Windows.Forms.ToolStripButton
    Public WithEvents im_stocks As System.Windows.Forms.ToolStripButton
    Public WithEvents im_stockout As System.Windows.Forms.ToolStripButton
    Public WithEvents im_settings As System.Windows.Forms.ToolStripButton
    Public WithEvents im_login As System.Windows.Forms.ToolStripButton
    Friend WithEvents im_users As System.Windows.Forms.ToolStripButton
End Class
