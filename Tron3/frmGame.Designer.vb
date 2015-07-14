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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayerToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DifficultyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EasyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoundariesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CountdownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblCountdown = New System.Windows.Forms.Label()
        Me.TimerGame = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
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
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayerToolStripMenuItem, Me.PlayerToolStripMenuItem1, Me.PlayerToolStripMenuItem2, Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(670, 25)
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
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DifficultyToolStripMenuItem, Me.BoundariesToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(64, 21)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'DifficultyToolStripMenuItem
        '
        Me.DifficultyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EasyToolStripMenuItem, Me.MediumToolStripMenuItem, Me.HardToolStripMenuItem})
        Me.DifficultyToolStripMenuItem.Name = "DifficultyToolStripMenuItem"
        Me.DifficultyToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.DifficultyToolStripMenuItem.Text = "Difficulty"
        '
        'EasyToolStripMenuItem
        '
        Me.EasyToolStripMenuItem.CheckOnClick = True
        Me.EasyToolStripMenuItem.Name = "EasyToolStripMenuItem"
        Me.EasyToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.EasyToolStripMenuItem.Text = "Easy"
        '
        'MediumToolStripMenuItem
        '
        Me.MediumToolStripMenuItem.CheckOnClick = True
        Me.MediumToolStripMenuItem.Name = "MediumToolStripMenuItem"
        Me.MediumToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.MediumToolStripMenuItem.Text = "Medium"
        '
        'HardToolStripMenuItem
        '
        Me.HardToolStripMenuItem.Checked = True
        Me.HardToolStripMenuItem.CheckOnClick = True
        Me.HardToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HardToolStripMenuItem.Name = "HardToolStripMenuItem"
        Me.HardToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.HardToolStripMenuItem.Text = "Hard"
        '
        'BoundariesToolStripMenuItem
        '
        Me.BoundariesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnToolStripMenuItem, Me.OffToolStripMenuItem})
        Me.BoundariesToolStripMenuItem.Name = "BoundariesToolStripMenuItem"
        Me.BoundariesToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.BoundariesToolStripMenuItem.Text = "Boundaries"
        '
        'OnToolStripMenuItem
        '
        Me.OnToolStripMenuItem.Checked = True
        Me.OnToolStripMenuItem.CheckOnClick = True
        Me.OnToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.OnToolStripMenuItem.Name = "OnToolStripMenuItem"
        Me.OnToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.OnToolStripMenuItem.Text = "On"
        '
        'OffToolStripMenuItem
        '
        Me.OffToolStripMenuItem.CheckOnClick = True
        Me.OffToolStripMenuItem.Name = "OffToolStripMenuItem"
        Me.OffToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.OffToolStripMenuItem.Text = "Off"
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
        'TimerGame
        '
        Me.TimerGame.Interval = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(529, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(529, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(529, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(529, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(529, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(529, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Label6"
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(670, 331)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCountdown)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGame"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PlayerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayerToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CountdownTimer As System.Windows.Forms.Timer
    Friend WithEvents lblCountdown As System.Windows.Forms.Label
    Friend WithEvents TimerGame As System.Windows.Forms.Timer
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DifficultyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EasyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MediumToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BoundariesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
