<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stocks
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
        Me.pnl_stockmaster = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.stxt_qty = New System.Windows.Forms.TextBox()
        Me.stxt_description = New System.Windows.Forms.RichTextBox()
        Me.stxt_cat = New System.Windows.Forms.ComboBox()
        Me.stxt_name = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.stxt_price = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.stxt_search = New System.Windows.Forms.TextBox()
        Me.sbtn_clear = New System.Windows.Forms.Button()
        Me.sbtn_edit = New System.Windows.Forms.Button()
        Me.sbtn_update = New System.Windows.Forms.Button()
        Me.sbtn_save = New System.Windows.Forms.Button()
        Me.sbtn_delete = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.sdtg_list = New System.Windows.Forms.DataGridView()
        Me.pnl_stockmaster.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.sdtg_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_stockmaster
        '
        Me.pnl_stockmaster.BackColor = System.Drawing.Color.White
        Me.pnl_stockmaster.Controls.Add(Me.Label7)
        Me.pnl_stockmaster.Controls.Add(Me.stxt_qty)
        Me.pnl_stockmaster.Controls.Add(Me.stxt_description)
        Me.pnl_stockmaster.Controls.Add(Me.stxt_cat)
        Me.pnl_stockmaster.Controls.Add(Me.stxt_name)
        Me.pnl_stockmaster.Controls.Add(Me.Label4)
        Me.pnl_stockmaster.Controls.Add(Me.Label3)
        Me.pnl_stockmaster.Controls.Add(Me.stxt_price)
        Me.pnl_stockmaster.Controls.Add(Me.Label2)
        Me.pnl_stockmaster.Controls.Add(Me.Label1)
        Me.pnl_stockmaster.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_stockmaster.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_stockmaster.Location = New System.Drawing.Point(0, 0)
        Me.pnl_stockmaster.Name = "pnl_stockmaster"
        Me.pnl_stockmaster.Size = New System.Drawing.Size(799, 184)
        Me.pnl_stockmaster.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(395, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Quantity ::"
        '
        'stxt_qty
        '
        Me.stxt_qty.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stxt_qty.Location = New System.Drawing.Point(475, 112)
        Me.stxt_qty.Name = "stxt_qty"
        Me.stxt_qty.Size = New System.Drawing.Size(252, 22)
        Me.stxt_qty.TabIndex = 4
        '
        'stxt_description
        '
        Me.stxt_description.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stxt_description.Location = New System.Drawing.Point(109, 79)
        Me.stxt_description.Name = "stxt_description"
        Me.stxt_description.Size = New System.Drawing.Size(253, 62)
        Me.stxt_description.TabIndex = 3
        Me.stxt_description.Text = ""
        '
        'stxt_cat
        '
        Me.stxt_cat.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stxt_cat.FormattingEnabled = True
        Me.stxt_cat.Location = New System.Drawing.Point(475, 34)
        Me.stxt_cat.Name = "stxt_cat"
        Me.stxt_cat.Size = New System.Drawing.Size(252, 24)
        Me.stxt_cat.TabIndex = 2
        '
        'stxt_name
        '
        Me.stxt_name.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stxt_name.Location = New System.Drawing.Point(110, 37)
        Me.stxt_name.Name = "stxt_name"
        Me.stxt_name.Size = New System.Drawing.Size(252, 22)
        Me.stxt_name.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(414, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Price ::"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(392, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Category ::"
        '
        'stxt_price
        '
        Me.stxt_price.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stxt_price.Location = New System.Drawing.Point(475, 73)
        Me.stxt_price.Name = "stxt_price"
        Me.stxt_price.Size = New System.Drawing.Size(252, 22)
        Me.stxt_price.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description ::"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Item Name ::"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(471, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Search :"
        '
        'stxt_search
        '
        Me.stxt_search.Location = New System.Drawing.Point(521, 248)
        Me.stxt_search.Name = "stxt_search"
        Me.stxt_search.Size = New System.Drawing.Size(263, 20)
        Me.stxt_search.TabIndex = 45
        '
        'sbtn_clear
        '
        Me.sbtn_clear.BackColor = System.Drawing.Color.Transparent
        Me.sbtn_clear.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.sbtn_clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.sbtn_clear.Location = New System.Drawing.Point(614, 205)
        Me.sbtn_clear.Name = "sbtn_clear"
        Me.sbtn_clear.Size = New System.Drawing.Size(125, 26)
        Me.sbtn_clear.TabIndex = 58
        Me.sbtn_clear.Text = "Clear"
        Me.sbtn_clear.UseVisualStyleBackColor = false
        '
        'sbtn_edit
        '
        Me.sbtn_edit.BackColor = System.Drawing.Color.Transparent
        Me.sbtn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sbtn_edit.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.sbtn_edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.sbtn_edit.Location = New System.Drawing.Point(195, 205)
        Me.sbtn_edit.Name = "sbtn_edit"
        Me.sbtn_edit.Size = New System.Drawing.Size(138, 26)
        Me.sbtn_edit.TabIndex = 57
        Me.sbtn_edit.Text = "Edit"
        Me.sbtn_edit.UseVisualStyleBackColor = false
        '
        'sbtn_update
        '
        Me.sbtn_update.BackColor = System.Drawing.Color.Transparent
        Me.sbtn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sbtn_update.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.sbtn_update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.sbtn_update.Location = New System.Drawing.Point(339, 205)
        Me.sbtn_update.Name = "sbtn_update"
        Me.sbtn_update.Size = New System.Drawing.Size(138, 26)
        Me.sbtn_update.TabIndex = 56
        Me.sbtn_update.Text = "Update"
        Me.sbtn_update.UseVisualStyleBackColor = false
        '
        'sbtn_save
        '
        Me.sbtn_save.BackColor = System.Drawing.Color.Transparent
        Me.sbtn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sbtn_save.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.sbtn_save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.sbtn_save.Location = New System.Drawing.Point(51, 205)
        Me.sbtn_save.Name = "sbtn_save"
        Me.sbtn_save.Size = New System.Drawing.Size(138, 26)
        Me.sbtn_save.TabIndex = 54
        Me.sbtn_save.Text = "Save"
        Me.sbtn_save.UseVisualStyleBackColor = false
        '
        'sbtn_delete
        '
        Me.sbtn_delete.BackColor = System.Drawing.Color.Transparent
        Me.sbtn_delete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.sbtn_delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.sbtn_delete.Location = New System.Drawing.Point(483, 205)
        Me.sbtn_delete.Name = "sbtn_delete"
        Me.sbtn_delete.Size = New System.Drawing.Size(125, 26)
        Me.sbtn_delete.TabIndex = 55
        Me.sbtn_delete.Text = "Delete"
        Me.sbtn_delete.UseVisualStyleBackColor = false
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.sdtg_list)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 279)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(799, 423)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "List of Stocks"
        '
        'sdtg_list
        '
        Me.sdtg_list.AllowUserToAddRows = false
        Me.sdtg_list.AllowUserToDeleteRows = false
        Me.sdtg_list.AllowUserToResizeColumns = false
        Me.sdtg_list.AllowUserToResizeRows = false
        Me.sdtg_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.sdtg_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.sdtg_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sdtg_list.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.sdtg_list.Location = New System.Drawing.Point(3, 16)
        Me.sdtg_list.Name = "sdtg_list"
        Me.sdtg_list.RowHeadersVisible = false
        Me.sdtg_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.sdtg_list.Size = New System.Drawing.Size(793, 404)
        Me.sdtg_list.TabIndex = 0
        '
        'Stocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 702)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.sbtn_clear)
        Me.Controls.Add(Me.sbtn_edit)
        Me.Controls.Add(Me.sbtn_update)
        Me.Controls.Add(Me.sbtn_save)
        Me.Controls.Add(Me.sbtn_delete)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.stxt_search)
        Me.Controls.Add(Me.pnl_stockmaster)
        Me.Name = "Stocks"
        Me.Text = "Stocks"
        Me.pnl_stockmaster.ResumeLayout(false)
        Me.pnl_stockmaster.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        CType(Me.sdtg_list,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents pnl_stockmaster As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents stxt_qty As System.Windows.Forms.TextBox
    Friend WithEvents stxt_description As System.Windows.Forms.RichTextBox
    Friend WithEvents stxt_cat As System.Windows.Forms.ComboBox
    Friend WithEvents stxt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents stxt_price As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents stxt_search As System.Windows.Forms.TextBox
    Friend WithEvents sbtn_clear As System.Windows.Forms.Button
    Friend WithEvents sbtn_edit As System.Windows.Forms.Button
    Friend WithEvents sbtn_update As System.Windows.Forms.Button
    Friend WithEvents sbtn_save As System.Windows.Forms.Button
    Friend WithEvents sbtn_delete As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents sdtg_list As System.Windows.Forms.DataGridView
End Class
