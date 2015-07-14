<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTronsole
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tronBike1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tronBike2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tronBike3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tronBike4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tronBike1, Me.tronBike2, Me.tronBike3, Me.tronBike4})
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(78, 65)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(539, 164)
        Me.DataGridView1.TabIndex = 4
        Me.DataGridView1.VirtualMode = True
        '
        'tronBike1
        '
        Me.tronBike1.HeaderText = "tronBike1"
        Me.tronBike1.Name = "tronBike1"
        Me.tronBike1.ReadOnly = True
        '
        'tronBike2
        '
        Me.tronBike2.HeaderText = "tronBike2"
        Me.tronBike2.Name = "tronBike2"
        Me.tronBike2.ReadOnly = True
        '
        'tronBike3
        '
        Me.tronBike3.HeaderText = "tronBike3"
        Me.tronBike3.Name = "tronBike3"
        Me.tronBike3.ReadOnly = True
        '
        'tronBike4
        '
        Me.tronBike4.HeaderText = "tronBike4"
        Me.tronBike4.Name = "tronBike4"
        Me.tronBike4.ReadOnly = True
        '
        'frmTronsole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 513)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmTronsole"
        Me.Text = "Tronsole"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents tronBike1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tronBike2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tronBike3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tronBike4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
