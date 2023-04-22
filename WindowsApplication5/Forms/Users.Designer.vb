<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Users))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.usertxt_name = New System.Windows.Forms.TextBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.usercbo_type = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.usertxt_pass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.usertxt_uname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.userdtg_list = New System.Windows.Forms.DataGridView()
        Me.userbtn_save = New System.Windows.Forms.Button()
        Me.userbtn_update = New System.Windows.Forms.Button()
        Me.userbtn_delete = New System.Windows.Forms.Button()
        Me.userbtn_clear = New System.Windows.Forms.Button()
        Me.userbtn_edit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.usertxt_search = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.userdtg_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.usertxt_name)
        Me.Panel1.Controls.Add(Me.lbl_id)
        Me.Panel1.Controls.Add(Me.usercbo_type)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.usertxt_pass)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.usertxt_uname)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(852, 171)
        Me.Panel1.TabIndex = 28
        '
        'usertxt_name
        '
        Me.usertxt_name.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usertxt_name.Location = New System.Drawing.Point(243, 23)
        Me.usertxt_name.Name = "usertxt_name"
        Me.usertxt_name.Size = New System.Drawing.Size(280, 22)
        Me.usertxt_name.TabIndex = 1
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(257, 26)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(18, 16)
        Me.lbl_id.TabIndex = 9
        Me.lbl_id.Text = "id"
        Me.lbl_id.Visible = False
        '
        'usercbo_type
        '
        Me.usercbo_type.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usercbo_type.FormattingEnabled = True
        Me.usercbo_type.Items.AddRange(New Object() {"Administrator", "Staff"})
        Me.usercbo_type.Location = New System.Drawing.Point(243, 116)
        Me.usercbo_type.Name = "usercbo_type"
        Me.usercbo_type.Size = New System.Drawing.Size(280, 24)
        Me.usercbo_type.TabIndex = 4
        Me.usercbo_type.Text = "Administrator"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(186, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name :"
        '
        'usertxt_pass
        '
        Me.usertxt_pass.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usertxt_pass.Location = New System.Drawing.Point(243, 86)
        Me.usertxt_pass.Name = "usertxt_pass"
        Me.usertxt_pass.Size = New System.Drawing.Size(280, 22)
        Me.usertxt_pass.TabIndex = 3
        Me.usertxt_pass.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(160, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.Location = New System.Drawing.Point(186, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Type :"
        '
        'usertxt_uname
        '
        Me.usertxt_uname.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usertxt_uname.Location = New System.Drawing.Point(243, 56)
        Me.usertxt_uname.Name = "usertxt_uname"
        Me.usertxt_uname.Size = New System.Drawing.Size(280, 22)
        Me.usertxt_uname.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.Location = New System.Drawing.Point(163, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.userdtg_list)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 250)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(852, 310)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List Of User"
        '
        'userdtg_list
        '
        Me.userdtg_list.AllowUserToAddRows = False
        Me.userdtg_list.AllowUserToDeleteRows = False
        Me.userdtg_list.AllowUserToResizeColumns = False
        Me.userdtg_list.AllowUserToResizeRows = False
        Me.userdtg_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.userdtg_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.userdtg_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.userdtg_list.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.userdtg_list.Location = New System.Drawing.Point(3, 16)
        Me.userdtg_list.Name = "userdtg_list"
        Me.userdtg_list.RowHeadersVisible = False
        Me.userdtg_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.userdtg_list.Size = New System.Drawing.Size(846, 291)
        Me.userdtg_list.TabIndex = 0
        '
        'userbtn_save
        '
        Me.userbtn_save.BackColor = System.Drawing.Color.Transparent
        Me.userbtn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.userbtn_save.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userbtn_save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.userbtn_save.Location = New System.Drawing.Point(71, 187)
        Me.userbtn_save.Name = "userbtn_save"
        Me.userbtn_save.Size = New System.Drawing.Size(138, 26)
        Me.userbtn_save.TabIndex = 29
        Me.userbtn_save.Text = "Save"
        Me.userbtn_save.UseVisualStyleBackColor = False
        '
        'userbtn_update
        '
        Me.userbtn_update.BackColor = System.Drawing.Color.Transparent
        Me.userbtn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.userbtn_update.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userbtn_update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.userbtn_update.Location = New System.Drawing.Point(359, 187)
        Me.userbtn_update.Name = "userbtn_update"
        Me.userbtn_update.Size = New System.Drawing.Size(138, 26)
        Me.userbtn_update.TabIndex = 30
        Me.userbtn_update.Text = "Update"
        Me.userbtn_update.UseVisualStyleBackColor = False
        '
        'userbtn_delete
        '
        Me.userbtn_delete.BackColor = System.Drawing.Color.Transparent
        Me.userbtn_delete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userbtn_delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.userbtn_delete.Location = New System.Drawing.Point(503, 187)
        Me.userbtn_delete.Name = "userbtn_delete"
        Me.userbtn_delete.Size = New System.Drawing.Size(125, 26)
        Me.userbtn_delete.TabIndex = 32
        Me.userbtn_delete.Text = "Delete"
        Me.userbtn_delete.UseVisualStyleBackColor = False
        '
        'userbtn_clear
        '
        Me.userbtn_clear.BackColor = System.Drawing.Color.Transparent
        Me.userbtn_clear.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userbtn_clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.userbtn_clear.Location = New System.Drawing.Point(634, 187)
        Me.userbtn_clear.Name = "userbtn_clear"
        Me.userbtn_clear.Size = New System.Drawing.Size(125, 26)
        Me.userbtn_clear.TabIndex = 54
        Me.userbtn_clear.Text = "Clear"
        Me.userbtn_clear.UseVisualStyleBackColor = False
        '
        'userbtn_edit
        '
        Me.userbtn_edit.BackColor = System.Drawing.Color.Transparent
        Me.userbtn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.userbtn_edit.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userbtn_edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.userbtn_edit.Location = New System.Drawing.Point(215, 187)
        Me.userbtn_edit.Name = "userbtn_edit"
        Me.userbtn_edit.Size = New System.Drawing.Size(138, 26)
        Me.userbtn_edit.TabIndex = 53
        Me.userbtn_edit.Text = "Edit"
        Me.userbtn_edit.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(522, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Search :"
        '
        'usertxt_search
        '
        Me.usertxt_search.Location = New System.Drawing.Point(575, 224)
        Me.usertxt_search.Name = "usertxt_search"
        Me.usertxt_search.Size = New System.Drawing.Size(263, 20)
        Me.usertxt_search.TabIndex = 55
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 560)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.usertxt_search)
        Me.Controls.Add(Me.userbtn_clear)
        Me.Controls.Add(Me.userbtn_edit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.userbtn_save)
        Me.Controls.Add(Me.userbtn_update)
        Me.Controls.Add(Me.userbtn_delete)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Users"
        Me.Text = "Users"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.userdtg_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents usertxt_name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents usercbo_type As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents usertxt_pass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents usertxt_uname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents userdtg_list As System.Windows.Forms.DataGridView
    Friend WithEvents userbtn_save As System.Windows.Forms.Button
    Friend WithEvents userbtn_update As System.Windows.Forms.Button
    Friend WithEvents userbtn_delete As System.Windows.Forms.Button
    Friend WithEvents userbtn_clear As System.Windows.Forms.Button
    Friend WithEvents userbtn_edit As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents usertxt_search As System.Windows.Forms.TextBox
End Class
