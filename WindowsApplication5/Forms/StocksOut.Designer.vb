<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StocksOut
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.sobtn_save = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.sodtg_addedlist = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.sodtg_itemlist = New System.Windows.Forms.DataGridView()
        Me.sotxt_search = New System.Windows.Forms.TextBox()
        Me.sobtn_add = New System.Windows.Forms.Button()
        Me.sotxt_lnamecust = New System.Windows.Forms.Panel()
        Me.sotxt_cusid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCus_lname = New System.Windows.Forms.TextBox()
        Me.sotxt_fnamecust = New System.Windows.Forms.TextBox()
        Me.sobtn_remove = New System.Windows.Forms.Button()
        Me.sotxt_quantity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sobtn_view = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        CType(Me.sodtg_addedlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.sodtg_itemlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sotxt_lnamecust.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 294)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(168, 24)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "List of Added Items"
        '
        'sobtn_save
        '
        Me.sobtn_save.BackColor = System.Drawing.Color.Transparent
        Me.sobtn_save.ForeColor = System.Drawing.Color.Black
        Me.sobtn_save.Location = New System.Drawing.Point(86, 493)
        Me.sobtn_save.Name = "sobtn_save"
        Me.sobtn_save.Size = New System.Drawing.Size(88, 26)
        Me.sobtn_save.TabIndex = 49
        Me.sobtn_save.Text = "Save"
        Me.sobtn_save.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.sodtg_addedlist)
        Me.Panel3.Location = New System.Drawing.Point(6, 321)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(512, 166)
        Me.Panel3.TabIndex = 46
        '
        'sodtg_addedlist
        '
        Me.sodtg_addedlist.AllowUserToAddRows = False
        Me.sodtg_addedlist.AllowUserToDeleteRows = False
        Me.sodtg_addedlist.AllowUserToResizeColumns = False
        Me.sodtg_addedlist.AllowUserToResizeRows = False
        Me.sodtg_addedlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.sodtg_addedlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.sodtg_addedlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.sodtg_addedlist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.sodtg_addedlist.Location = New System.Drawing.Point(3, 17)
        Me.sodtg_addedlist.Name = "sodtg_addedlist"
        Me.sodtg_addedlist.RowHeadersVisible = False
        Me.sodtg_addedlist.Size = New System.Drawing.Size(504, 131)
        Me.sodtg_addedlist.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.sodtg_itemlist)
        Me.Panel2.Controls.Add(Me.sotxt_search)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel2.Location = New System.Drawing.Point(6, 113)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(519, 168)
        Me.Panel2.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, -1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 24)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "List of Products"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(146, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Search :"
        '
        'sodtg_itemlist
        '
        Me.sodtg_itemlist.AllowUserToAddRows = False
        Me.sodtg_itemlist.AllowUserToDeleteRows = False
        Me.sodtg_itemlist.AllowUserToResizeColumns = False
        Me.sodtg_itemlist.AllowUserToResizeRows = False
        Me.sodtg_itemlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.sodtg_itemlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.sodtg_itemlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.sodtg_itemlist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.sodtg_itemlist.Location = New System.Drawing.Point(3, 29)
        Me.sodtg_itemlist.Name = "sodtg_itemlist"
        Me.sodtg_itemlist.RowHeadersVisible = False
        Me.sodtg_itemlist.Size = New System.Drawing.Size(508, 131)
        Me.sodtg_itemlist.TabIndex = 0
        '
        'sotxt_search
        '
        Me.sotxt_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.sotxt_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.sotxt_search.Location = New System.Drawing.Point(196, 4)
        Me.sotxt_search.Name = "sotxt_search"
        Me.sotxt_search.Size = New System.Drawing.Size(184, 20)
        Me.sotxt_search.TabIndex = 3
        '
        'sobtn_add
        '
        Me.sobtn_add.BackColor = System.Drawing.Color.Transparent
        Me.sobtn_add.ForeColor = System.Drawing.Color.Black
        Me.sobtn_add.Location = New System.Drawing.Point(449, 294)
        Me.sobtn_add.Name = "sobtn_add"
        Me.sobtn_add.Size = New System.Drawing.Size(69, 24)
        Me.sobtn_add.TabIndex = 30
        Me.sobtn_add.Text = "Add"
        Me.sobtn_add.UseVisualStyleBackColor = False
        '
        'sotxt_lnamecust
        '
        Me.sotxt_lnamecust.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.sotxt_lnamecust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sotxt_lnamecust.Controls.Add(Me.sotxt_cusid)
        Me.sotxt_lnamecust.Controls.Add(Me.Label2)
        Me.sotxt_lnamecust.Controls.Add(Me.Label1)
        Me.sotxt_lnamecust.Controls.Add(Me.Label5)
        Me.sotxt_lnamecust.Controls.Add(Me.Label15)
        Me.sotxt_lnamecust.Controls.Add(Me.txtCus_lname)
        Me.sotxt_lnamecust.Controls.Add(Me.sotxt_fnamecust)
        Me.sotxt_lnamecust.Location = New System.Drawing.Point(2, 0)
        Me.sotxt_lnamecust.Name = "sotxt_lnamecust"
        Me.sotxt_lnamecust.Size = New System.Drawing.Size(523, 107)
        Me.sotxt_lnamecust.TabIndex = 44
        '
        'sotxt_cusid
        '
        Me.sotxt_cusid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.sotxt_cusid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.sotxt_cusid.Location = New System.Drawing.Point(79, 27)
        Me.sotxt_cusid.Name = "sotxt_cusid"
        Me.sotxt_cusid.Size = New System.Drawing.Size(205, 20)
        Me.sotxt_cusid.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Customer Id :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Customer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Last Name :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "First Name :"
        '
        'txtCus_lname
        '
        Me.txtCus_lname.Enabled = False
        Me.txtCus_lname.Location = New System.Drawing.Point(79, 79)
        Me.txtCus_lname.Name = "txtCus_lname"
        Me.txtCus_lname.Size = New System.Drawing.Size(205, 20)
        Me.txtCus_lname.TabIndex = 0
        '
        'sotxt_fnamecust
        '
        Me.sotxt_fnamecust.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.sotxt_fnamecust.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.sotxt_fnamecust.Enabled = False
        Me.sotxt_fnamecust.Location = New System.Drawing.Point(79, 53)
        Me.sotxt_fnamecust.Name = "sotxt_fnamecust"
        Me.sotxt_fnamecust.Size = New System.Drawing.Size(205, 20)
        Me.sotxt_fnamecust.TabIndex = 0
        '
        'sobtn_remove
        '
        Me.sobtn_remove.BackColor = System.Drawing.Color.Transparent
        Me.sobtn_remove.ForeColor = System.Drawing.Color.Black
        Me.sobtn_remove.Location = New System.Drawing.Point(198, 493)
        Me.sobtn_remove.Name = "sobtn_remove"
        Me.sobtn_remove.Size = New System.Drawing.Size(88, 26)
        Me.sobtn_remove.TabIndex = 52
        Me.sobtn_remove.Text = "Remove"
        Me.sobtn_remove.UseVisualStyleBackColor = False
        '
        'sotxt_quantity
        '
        Me.sotxt_quantity.Location = New System.Drawing.Point(343, 296)
        Me.sotxt_quantity.Name = "sotxt_quantity"
        Me.sotxt_quantity.Size = New System.Drawing.Size(100, 20)
        Me.sotxt_quantity.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(285, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Quantity::"
        '
        'sobtn_view
        '
        Me.sobtn_view.BackColor = System.Drawing.Color.Transparent
        Me.sobtn_view.ForeColor = System.Drawing.Color.Black
        Me.sobtn_view.Location = New System.Drawing.Point(310, 493)
        Me.sobtn_view.Name = "sobtn_view"
        Me.sobtn_view.Size = New System.Drawing.Size(88, 26)
        Me.sobtn_view.TabIndex = 54
        Me.sobtn_view.Text = "View"
        Me.sobtn_view.UseVisualStyleBackColor = False
        '
        'StocksOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 524)
        Me.Controls.Add(Me.sobtn_view)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.sotxt_quantity)
        Me.Controls.Add(Me.sobtn_remove)
        Me.Controls.Add(Me.sobtn_add)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.sobtn_save)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.sotxt_lnamecust)
        Me.Name = "StocksOut"
        Me.Text = "Stock-Out"
        Me.Panel3.ResumeLayout(False)
        CType(Me.sodtg_addedlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.sodtg_itemlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sotxt_lnamecust.ResumeLayout(False)
        Me.sotxt_lnamecust.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents sobtn_save As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents sobtn_add As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents sotxt_search As System.Windows.Forms.TextBox
    Friend WithEvents sotxt_lnamecust As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCus_lname As System.Windows.Forms.TextBox
    Friend WithEvents sotxt_fnamecust As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents sodtg_itemlist As System.Windows.Forms.DataGridView
    Friend WithEvents sotxt_cusid As System.Windows.Forms.TextBox
    Friend WithEvents sodtg_addedlist As System.Windows.Forms.DataGridView
    Friend WithEvents sobtn_remove As System.Windows.Forms.Button
    Friend WithEvents sotxt_quantity As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents sobtn_view As System.Windows.Forms.Button
End Class
