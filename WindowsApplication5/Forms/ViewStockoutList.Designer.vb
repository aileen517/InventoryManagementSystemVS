<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewStockoutList
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
        Me.vsodtg_list = New System.Windows.Forms.DataGridView()
        CType(Me.vsodtg_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsodtg_list
        '
        Me.vsodtg_list.AllowUserToAddRows = False
        Me.vsodtg_list.AllowUserToDeleteRows = False
        Me.vsodtg_list.AllowUserToResizeColumns = False
        Me.vsodtg_list.AllowUserToResizeRows = False
        Me.vsodtg_list.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.vsodtg_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.vsodtg_list.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.vsodtg_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.vsodtg_list.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.vsodtg_list.Location = New System.Drawing.Point(1, 38)
        Me.vsodtg_list.Name = "vsodtg_list"
        Me.vsodtg_list.Size = New System.Drawing.Size(792, 428)
        Me.vsodtg_list.TabIndex = 19
        '
        'ViewStockoutList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 466)
        Me.Controls.Add(Me.vsodtg_list)
        Me.Name = "ViewStockoutList"
        Me.Text = "Stock-out"
        CType(Me.vsodtg_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsodtg_list As System.Windows.Forms.DataGridView
End Class
