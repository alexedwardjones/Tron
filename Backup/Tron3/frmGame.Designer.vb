<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
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
        Me.components = New System.ComponentModel.Container
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TimerOne = New System.Windows.Forms.Timer(Me.components)
        Me.TimerTwo = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.PlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PlayerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.PlayerToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.CountdownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblCountdown = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlText
        Me.PictureBox1.Location = New System.Drawing.Point(12, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(488, 280)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TimerOne
        '
        Me.TimerOne.Interval = 15
        '
        'TimerTwo
        '
        Me.TimerTwo.Interval = 15
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayerToolStripMenuItem, Me.PlayerToolStripMenuItem1, Me.PlayerToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(515, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PlayerToolStripMenuItem
        '
        Me.PlayerToolStripMenuItem.Name = "PlayerToolStripMenuItem"
        Me.PlayerToolStripMenuItem.Size = New System.Drawing.Size(65, 21)
        Me.PlayerToolStripMenuItem.Text = "2 Player"
        '
        'PlayerToolStripMenuItem1
        '
        Me.PlayerToolStripMenuItem1.Name = "PlayerToolStripMenuItem1"
        Me.PlayerToolStripMenuItem1.Size = New System.Drawing.Size(65, 21)
        Me.PlayerToolStripMenuItem1.Text = "3 Player"
        '
        'PlayerToolStripMenuItem2
        '
        Me.PlayerToolStripMenuItem2.Name = "PlayerToolStripMenuItem2"
        Me.PlayerToolStripMenuItem2.Size = New System.Drawing.Size(65, 21)
        Me.PlayerToolStripMenuItem2.Text = "4 Player"
        '
        'CountdownTimer
        '
        Me.CountdownTimer.Interval = 1000
        '
        'lblCountdown
        '
        Me.lblCountdown.AutoSize = True
        Me.lblCountdown.BackColor = System.Drawing.Color.Black
        Me.lblCountdown.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountdown.ForeColor = System.Drawing.Color.White
        Me.lblCountdown.Location = New System.Drawing.Point(245, 164)
        Me.lblCountdown.Name = "lblCountdown"
        Me.lblCountdown.Size = New System.Drawing.Size(0, 26)
        Me.lblCountdown.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlText
        Me.PictureBox2.Location = New System.Drawing.Point(12, 342)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(488, 280)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(515, 330)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblCountdown)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGame"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TimerOne As System.Windows.Forms.Timer
    Friend WithEvents TimerTwo As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PlayerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayerToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CountdownTimer As System.Windows.Forms.Timer
    Friend WithEvents lblCountdown As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
