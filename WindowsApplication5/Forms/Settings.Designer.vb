<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.settxt_cat = New System.Windows.Forms.TextBox()
        Me.setsearch_search = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.settxt_ID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.setbtn_clear = New System.Windows.Forms.Button()
        Me.setbtn_edit = New System.Windows.Forms.Button()
        Me.setbtn_update = New System.Windows.Forms.Button()
        Me.setbtn_save = New System.Windows.Forms.Button()
        Me.setbtn_delete = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dg_listset = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dg_listset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(18, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Category :"
        '
        'settxt_cat
        '
        Me.settxt_cat.Location = New System.Drawing.Point(84, 56)
        Me.settxt_cat.Name = "settxt_cat"
        Me.settxt_cat.Size = New System.Drawing.Size(260, 20)
        Me.settxt_cat.TabIndex = 2
        '
        'setsearch_search
        '
        Me.setsearch_search.Location = New System.Drawing.Point(287, 144)
        Me.setsearch_search.Name = "setsearch_search"
        Me.setsearch_search.Size = New System.Drawing.Size(263, 20)
        Me.setsearch_search.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(226, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Search :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(53, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "ID :"
        '
        'settxt_ID
        '
        Me.settxt_ID.Location = New System.Drawing.Point(84, 30)
        Me.settxt_ID.Name = "settxt_ID"
        Me.settxt_ID.Size = New System.Drawing.Size(260, 20)
        Me.settxt_ID.TabIndex = 55
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.setbtn_save)
        Me.GroupBox1.Controls.Add(Me.setbtn_clear)
        Me.GroupBox1.Controls.Add(Me.settxt_ID)
        Me.GroupBox1.Controls.Add(Me.setbtn_update)
        Me.GroupBox1.Controls.Add(Me.setbtn_delete)
        Me.GroupBox1.Controls.Add(Me.setbtn_edit)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.setsearch_search)
        Me.GroupBox1.Controls.Add(Me.settxt_cat)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(3, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(565, 496)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add new Category"
        '
        'setbtn_clear
        '
        Me.setbtn_clear.BackColor = System.Drawing.Color.Transparent
        Me.setbtn_clear.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.setbtn_clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.setbtn_clear.Location = New System.Drawing.Point(399, 104)
        Me.setbtn_clear.Name = "setbtn_clear"
        Me.setbtn_clear.Size = New System.Drawing.Size(63, 25)
        Me.setbtn_clear.TabIndex = 56
        Me.setbtn_clear.Text = "Clear"
        Me.setbtn_clear.UseVisualStyleBackColor = False
        '
        'setbtn_edit
        '
        Me.setbtn_edit.BackColor = System.Drawing.Color.Transparent
        Me.setbtn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.setbtn_edit.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.setbtn_edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.setbtn_edit.Location = New System.Drawing.Point(166, 104)
        Me.setbtn_edit.Name = "setbtn_edit"
        Me.setbtn_edit.Size = New System.Drawing.Size(76, 25)
        Me.setbtn_edit.TabIndex = 55
        Me.setbtn_edit.Text = "Edit"
        Me.setbtn_edit.UseVisualStyleBackColor = False
        '
        'setbtn_update
        '
        Me.setbtn_update.BackColor = System.Drawing.Color.Transparent
        Me.setbtn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.setbtn_update.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.setbtn_update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.setbtn_update.Location = New System.Drawing.Point(248, 104)
        Me.setbtn_update.Name = "setbtn_update"
        Me.setbtn_update.Size = New System.Drawing.Size(76, 25)
        Me.setbtn_update.TabIndex = 54
        Me.setbtn_update.Text = "Update"
        Me.setbtn_update.UseVisualStyleBackColor = False
        '
        'setbtn_save
        '
        Me.setbtn_save.BackColor = System.Drawing.Color.Transparent
        Me.setbtn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.setbtn_save.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.setbtn_save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.setbtn_save.Location = New System.Drawing.Point(84, 105)
        Me.setbtn_save.Name = "setbtn_save"
        Me.setbtn_save.Size = New System.Drawing.Size(76, 25)
        Me.setbtn_save.TabIndex = 52
        Me.setbtn_save.Text = "Save"
        Me.setbtn_save.UseVisualStyleBackColor = False
        '
        'setbtn_delete
        '
        Me.setbtn_delete.BackColor = System.Drawing.Color.Transparent
        Me.setbtn_delete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.setbtn_delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.setbtn_delete.Location = New System.Drawing.Point(330, 104)
        Me.setbtn_delete.Name = "setbtn_delete"
        Me.setbtn_delete.Size = New System.Drawing.Size(63, 25)
        Me.setbtn_delete.TabIndex = 53
        Me.setbtn_delete.Text = "Delete"
        Me.setbtn_delete.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.dg_listset)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(3, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(559, 323)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List Of Categories"
        '
        'dg_listset
        '
        Me.dg_listset.AllowUserToAddRows = False
        Me.dg_listset.AllowUserToDeleteRows = False
        Me.dg_listset.AllowUserToResizeColumns = False
        Me.dg_listset.AllowUserToResizeRows = False
        Me.dg_listset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_listset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_listset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_listset.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dg_listset.Location = New System.Drawing.Point(3, 16)
        Me.dg_listset.Name = "dg_listset"
        Me.dg_listset.RowHeadersVisible = False
        Me.dg_listset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_listset.Size = New System.Drawing.Size(553, 304)
        Me.dg_listset.TabIndex = 0
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 513)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dg_listset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents settxt_cat As System.Windows.Forms.TextBox
    Friend WithEvents setsearch_search As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents settxt_ID As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents setbtn_save As System.Windows.Forms.Button
    Friend WithEvents setbtn_clear As System.Windows.Forms.Button
    Friend WithEvents setbtn_update As System.Windows.Forms.Button
    Friend WithEvents setbtn_delete As System.Windows.Forms.Button
    Friend WithEvents setbtn_edit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_listset As System.Windows.Forms.DataGridView
End Class
