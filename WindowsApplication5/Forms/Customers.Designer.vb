<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customers))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.custxt_ID = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.custxt_mobile = New System.Windows.Forms.TextBox()
        Me.custxt_add = New System.Windows.Forms.TextBox()
        Me.custxt_lname = New System.Windows.Forms.TextBox()
        Me.custxt_fname = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.lbl_id1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dg_listcus = New System.Windows.Forms.DataGridView()
        Me.cusbtn_save = New System.Windows.Forms.Button()
        Me.cusbtn_delete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.custtxt_search = New System.Windows.Forms.TextBox()
        Me.cusbtn_edit = New System.Windows.Forms.Button()
        Me.cusbtn_clear = New System.Windows.Forms.Button()
        Me.cusbtn_update = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg_listcus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.custxt_ID)
        Me.Panel1.Controls.Add(Me.label7)
        Me.Panel1.Controls.Add(Me.custxt_mobile)
        Me.Panel1.Controls.Add(Me.custxt_add)
        Me.Panel1.Controls.Add(Me.custxt_lname)
        Me.Panel1.Controls.Add(Me.custxt_fname)
        Me.Panel1.Controls.Add(Me.label5)
        Me.Panel1.Controls.Add(Me.lbl_id1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(892, 126)
        Me.Panel1.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label6.Location = New System.Drawing.Point(23, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 16)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Last Name :"
        '
        'custxt_ID
        '
        Me.custxt_ID.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custxt_ID.Location = New System.Drawing.Point(105, 20)
        Me.custxt_ID.Name = "custxt_ID"
        Me.custxt_ID.Size = New System.Drawing.Size(280, 22)
        Me.custxt_ID.TabIndex = 60
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.BackColor = System.Drawing.Color.White
        Me.label7.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Image = CType(resources.GetObject("label7.Image"), System.Drawing.Image)
        Me.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.label7.Location = New System.Drawing.Point(66, 20)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(26, 16)
        Me.label7.TabIndex = 59
        Me.label7.Text = "Id :"
        '
        'custxt_mobile
        '
        Me.custxt_mobile.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custxt_mobile.Location = New System.Drawing.Point(485, 54)
        Me.custxt_mobile.Name = "custxt_mobile"
        Me.custxt_mobile.Size = New System.Drawing.Size(280, 22)
        Me.custxt_mobile.TabIndex = 56
        '
        'custxt_add
        '
        Me.custxt_add.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custxt_add.Location = New System.Drawing.Point(485, 24)
        Me.custxt_add.Name = "custxt_add"
        Me.custxt_add.Size = New System.Drawing.Size(280, 22)
        Me.custxt_add.TabIndex = 55
        '
        'custxt_lname
        '
        Me.custxt_lname.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custxt_lname.Location = New System.Drawing.Point(105, 84)
        Me.custxt_lname.Name = "custxt_lname"
        Me.custxt_lname.Size = New System.Drawing.Size(280, 22)
        Me.custxt_lname.TabIndex = 54
        '
        'custxt_fname
        '
        Me.custxt_fname.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custxt_fname.Location = New System.Drawing.Point(105, 51)
        Me.custxt_fname.Name = "custxt_fname"
        Me.custxt_fname.Size = New System.Drawing.Size(280, 22)
        Me.custxt_fname.TabIndex = 53
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.BackColor = System.Drawing.Color.White
        Me.label5.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Image = CType(resources.GetObject("label5.Image"), System.Drawing.Image)
        Me.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.label5.Location = New System.Drawing.Point(422, 57)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(50, 16)
        Me.label5.TabIndex = 51
        Me.label5.Text = "Mobile :"
        '
        'lbl_id1
        '
        Me.lbl_id1.AutoSize = True
        Me.lbl_id1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id1.Location = New System.Drawing.Point(141, 54)
        Me.lbl_id1.Name = "lbl_id1"
        Me.lbl_id1.Size = New System.Drawing.Size(18, 16)
        Me.lbl_id1.TabIndex = 47
        Me.lbl_id1.Text = "id"
        Me.lbl_id1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(22, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "First Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.Location = New System.Drawing.Point(410, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Address :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.dg_listcus)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 218)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(892, 423)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List Of Customers"
        '
        'dg_listcus
        '
        Me.dg_listcus.AllowUserToAddRows = False
        Me.dg_listcus.AllowUserToDeleteRows = False
        Me.dg_listcus.AllowUserToResizeColumns = False
        Me.dg_listcus.AllowUserToResizeRows = False
        Me.dg_listcus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_listcus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_listcus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_listcus.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dg_listcus.Location = New System.Drawing.Point(3, 16)
        Me.dg_listcus.Name = "dg_listcus"
        Me.dg_listcus.RowHeadersVisible = False
        Me.dg_listcus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_listcus.Size = New System.Drawing.Size(886, 404)
        Me.dg_listcus.TabIndex = 0
        '
        'cusbtn_save
        '
        Me.cusbtn_save.BackColor = System.Drawing.Color.Transparent
        Me.cusbtn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cusbtn_save.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cusbtn_save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cusbtn_save.Location = New System.Drawing.Point(81, 145)
        Me.cusbtn_save.Name = "cusbtn_save"
        Me.cusbtn_save.Size = New System.Drawing.Size(138, 26)
        Me.cusbtn_save.TabIndex = 42
        Me.cusbtn_save.Text = "Save"
        Me.cusbtn_save.UseVisualStyleBackColor = False
        '
        'cusbtn_delete
        '
        Me.cusbtn_delete.BackColor = System.Drawing.Color.Transparent
        Me.cusbtn_delete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cusbtn_delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cusbtn_delete.Location = New System.Drawing.Point(513, 145)
        Me.cusbtn_delete.Name = "cusbtn_delete"
        Me.cusbtn_delete.Size = New System.Drawing.Size(125, 26)
        Me.cusbtn_delete.TabIndex = 44
        Me.cusbtn_delete.Text = "Delete"
        Me.cusbtn_delete.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(573, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Search :"
        '
        'custtxt_search
        '
        Me.custtxt_search.Location = New System.Drawing.Point(626, 192)
        Me.custtxt_search.Name = "custtxt_search"
        Me.custtxt_search.Size = New System.Drawing.Size(263, 20)
        Me.custtxt_search.TabIndex = 48
        '
        'cusbtn_edit
        '
        Me.cusbtn_edit.BackColor = System.Drawing.Color.Transparent
        Me.cusbtn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cusbtn_edit.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cusbtn_edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cusbtn_edit.Location = New System.Drawing.Point(225, 145)
        Me.cusbtn_edit.Name = "cusbtn_edit"
        Me.cusbtn_edit.Size = New System.Drawing.Size(138, 26)
        Me.cusbtn_edit.TabIndex = 50
        Me.cusbtn_edit.Text = "Edit"
        Me.cusbtn_edit.UseVisualStyleBackColor = False
        '
        'cusbtn_clear
        '
        Me.cusbtn_clear.BackColor = System.Drawing.Color.Transparent
        Me.cusbtn_clear.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cusbtn_clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cusbtn_clear.Location = New System.Drawing.Point(644, 145)
        Me.cusbtn_clear.Name = "cusbtn_clear"
        Me.cusbtn_clear.Size = New System.Drawing.Size(125, 26)
        Me.cusbtn_clear.TabIndex = 51
        Me.cusbtn_clear.Text = "Clear"
        Me.cusbtn_clear.UseVisualStyleBackColor = False
        '
        'cusbtn_update
        '
        Me.cusbtn_update.BackColor = System.Drawing.Color.Transparent
        Me.cusbtn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cusbtn_update.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cusbtn_update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cusbtn_update.Location = New System.Drawing.Point(369, 145)
        Me.cusbtn_update.Name = "cusbtn_update"
        Me.cusbtn_update.Size = New System.Drawing.Size(138, 26)
        Me.cusbtn_update.TabIndex = 47
        Me.cusbtn_update.Text = "Update"
        Me.cusbtn_update.UseVisualStyleBackColor = False
        '
        'Customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 641)
        Me.Controls.Add(Me.cusbtn_clear)
        Me.Controls.Add(Me.cusbtn_edit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.custtxt_search)
        Me.Controls.Add(Me.cusbtn_update)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cusbtn_save)
        Me.Controls.Add(Me.cusbtn_delete)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Customers"
        Me.Text = "Customers"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dg_listcus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents custxt_ID As System.Windows.Forms.TextBox
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents custxt_mobile As System.Windows.Forms.TextBox
    Friend WithEvents custxt_add As System.Windows.Forms.TextBox
    Friend WithEvents custxt_lname As System.Windows.Forms.TextBox
    Friend WithEvents custxt_fname As System.Windows.Forms.TextBox
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_id1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_listcus As System.Windows.Forms.DataGridView
    Friend WithEvents cusbtn_save As System.Windows.Forms.Button
    Friend WithEvents cusbtn_delete As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents custtxt_search As System.Windows.Forms.TextBox
    Friend WithEvents cusbtn_edit As System.Windows.Forms.Button
    Friend WithEvents cusbtn_clear As System.Windows.Forms.Button
    Friend WithEvents cusbtn_update As System.Windows.Forms.Button
End Class
