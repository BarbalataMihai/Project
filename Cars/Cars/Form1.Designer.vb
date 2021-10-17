<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RoadMover = New System.Windows.Forms.Timer(Me.components)
        Me.Left_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Right_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy1_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy2_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy3_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.End_Text = New System.Windows.Forms.Label()
        Me.Score_Text = New System.Windows.Forms.Label()
        Me.Retry_Button = New System.Windows.Forms.Button()
        Me.Speed_Text = New System.Windows.Forms.Label()
        Me.SpeedLowerMover = New System.Windows.Forms.Timer(Me.components)
        Me.SpeedSlowerSpawn = New System.Windows.Forms.Timer(Me.components)
        Me.EnemyCarSlow = New System.Windows.Forms.Timer(Me.components)
        Me.Ghost = New System.Windows.Forms.PictureBox()
        Me.SpeedLower = New System.Windows.Forms.PictureBox()
        Me.Car = New System.Windows.Forms.PictureBox()
        Me.EnemyCar3 = New System.Windows.Forms.PictureBox()
        Me.EnemyCar2 = New System.Windows.Forms.PictureBox()
        Me.EnemyCar1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GhostFlicker = New System.Windows.Forms.Timer(Me.components)
        Me.RoadMoverGhost = New System.Windows.Forms.Timer(Me.components)
        Me.GhostSpawn = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Ghost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpeedLower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyCar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyCar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyCar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RoadMover
        '
        Me.RoadMover.Enabled = True
        Me.RoadMover.Interval = 10
        '
        'Left_Mover
        '
        Me.Left_Mover.Interval = 10
        '
        'Right_Mover
        '
        Me.Right_Mover.Interval = 10
        '
        'Enemy1_Mover
        '
        Me.Enemy1_Mover.Enabled = True
        Me.Enemy1_Mover.Interval = 10
        '
        'Enemy2_Mover
        '
        Me.Enemy2_Mover.Enabled = True
        Me.Enemy2_Mover.Interval = 10
        '
        'Enemy3_Mover
        '
        Me.Enemy3_Mover.Enabled = True
        Me.Enemy3_Mover.Interval = 10
        '
        'End_Text
        '
        Me.End_Text.AutoSize = True
        Me.End_Text.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.End_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.End_Text.ForeColor = System.Drawing.Color.Red
        Me.End_Text.Location = New System.Drawing.Point(63, 155)
        Me.End_Text.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.End_Text.Name = "End_Text"
        Me.End_Text.Size = New System.Drawing.Size(154, 31)
        Me.End_Text.TabIndex = 3
        Me.End_Text.Text = "GameOver"
        Me.End_Text.Visible = False
        '
        'Score_Text
        '
        Me.Score_Text.AutoSize = True
        Me.Score_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score_Text.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Score_Text.Location = New System.Drawing.Point(103, 9)
        Me.Score_Text.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Score_Text.Name = "Score_Text"
        Me.Score_Text.Size = New System.Drawing.Size(74, 20)
        Me.Score_Text.TabIndex = 4
        Me.Score_Text.Text = "Score 0"
        '
        'Retry_Button
        '
        Me.Retry_Button.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Retry_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Retry_Button.ForeColor = System.Drawing.Color.DarkRed
        Me.Retry_Button.Location = New System.Drawing.Point(91, 231)
        Me.Retry_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Retry_Button.Name = "Retry_Button"
        Me.Retry_Button.Size = New System.Drawing.Size(100, 36)
        Me.Retry_Button.TabIndex = 5
        Me.Retry_Button.Text = "Retry"
        Me.Retry_Button.UseVisualStyleBackColor = False
        Me.Retry_Button.Visible = False
        '
        'Speed_Text
        '
        Me.Speed_Text.AutoSize = True
        Me.Speed_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Speed_Text.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Speed_Text.Location = New System.Drawing.Point(216, 9)
        Me.Speed_Text.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Speed_Text.Name = "Speed_Text"
        Me.Speed_Text.Size = New System.Drawing.Size(77, 20)
        Me.Speed_Text.TabIndex = 4
        Me.Speed_Text.Text = "Speed 0"
        '
        'SpeedLowerMover
        '
        Me.SpeedLowerMover.Enabled = True
        Me.SpeedLowerMover.Interval = 10
        '
        'SpeedSlowerSpawn
        '
        Me.SpeedSlowerSpawn.Enabled = True
        Me.SpeedSlowerSpawn.Interval = 7000
        '
        'EnemyCarSlow
        '
        Me.EnemyCarSlow.Interval = 10
        '
        'Ghost
        '
        Me.Ghost.Image = Global.Cars.My.Resources.Resources.ghost
        Me.Ghost.Location = New System.Drawing.Point(160, 118)
        Me.Ghost.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Ghost.Name = "Ghost"
        Me.Ghost.Size = New System.Drawing.Size(31, 34)
        Me.Ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ghost.TabIndex = 6
        Me.Ghost.TabStop = False
        Me.Ghost.Visible = False
        '
        'SpeedLower
        '
        Me.SpeedLower.Image = Global.Cars.My.Resources.Resources.lowerSpeed
        Me.SpeedLower.Location = New System.Drawing.Point(91, 118)
        Me.SpeedLower.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SpeedLower.Name = "SpeedLower"
        Me.SpeedLower.Size = New System.Drawing.Size(31, 34)
        Me.SpeedLower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SpeedLower.TabIndex = 6
        Me.SpeedLower.TabStop = False
        Me.SpeedLower.Visible = False
        '
        'Car
        '
        Me.Car.Image = CType(resources.GetObject("Car.Image"), System.Drawing.Image)
        Me.Car.Location = New System.Drawing.Point(1, 375)
        Me.Car.Margin = New System.Windows.Forms.Padding(4)
        Me.Car.Name = "Car"
        Me.Car.Size = New System.Drawing.Size(32, 58)
        Me.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Car.TabIndex = 2
        Me.Car.TabStop = False
        '
        'EnemyCar3
        '
        Me.EnemyCar3.Image = CType(resources.GetObject("EnemyCar3.Image"), System.Drawing.Image)
        Me.EnemyCar3.Location = New System.Drawing.Point(251, 57)
        Me.EnemyCar3.Margin = New System.Windows.Forms.Padding(4)
        Me.EnemyCar3.Name = "EnemyCar3"
        Me.EnemyCar3.Size = New System.Drawing.Size(32, 58)
        Me.EnemyCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyCar3.TabIndex = 2
        Me.EnemyCar3.TabStop = False
        '
        'EnemyCar2
        '
        Me.EnemyCar2.Image = CType(resources.GetObject("EnemyCar2.Image"), System.Drawing.Image)
        Me.EnemyCar2.Location = New System.Drawing.Point(120, 33)
        Me.EnemyCar2.Margin = New System.Windows.Forms.Padding(4)
        Me.EnemyCar2.Name = "EnemyCar2"
        Me.EnemyCar2.Size = New System.Drawing.Size(32, 58)
        Me.EnemyCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyCar2.TabIndex = 2
        Me.EnemyCar2.TabStop = False
        '
        'EnemyCar1
        '
        Me.EnemyCar1.Image = CType(resources.GetObject("EnemyCar1.Image"), System.Drawing.Image)
        Me.EnemyCar1.Location = New System.Drawing.Point(1, -1)
        Me.EnemyCar1.Margin = New System.Windows.Forms.Padding(4)
        Me.EnemyCar1.Name = "EnemyCar1"
        Me.EnemyCar1.Size = New System.Drawing.Size(32, 58)
        Me.EnemyCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyCar1.TabIndex = 2
        Me.EnemyCar1.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox8.Location = New System.Drawing.Point(65, 375)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(17, 114)
        Me.PictureBox8.TabIndex = 0
        Me.PictureBox8.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox6.Location = New System.Drawing.Point(203, 231)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(17, 114)
        Me.PictureBox6.TabIndex = 0
        Me.PictureBox6.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox4.Location = New System.Drawing.Point(203, 375)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(17, 114)
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox2.Location = New System.Drawing.Point(200, -66)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 114)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox7.Location = New System.Drawing.Point(65, 231)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(17, 114)
        Me.PictureBox7.TabIndex = 0
        Me.PictureBox7.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox5.Location = New System.Drawing.Point(200, 81)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(19, 114)
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox3.Location = New System.Drawing.Point(65, 81)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(17, 114)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.Location = New System.Drawing.Point(65, -66)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(17, 114)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GhostFlicker
        '
        Me.GhostFlicker.Interval = 20
        '
        'RoadMoverGhost
        '
        Me.RoadMoverGhost.Interval = 10
        '
        'GhostSpawn
        '
        Me.GhostSpawn.Enabled = True
        Me.GhostSpawn.Interval = 7000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(296, 432)
        Me.Controls.Add(Me.Ghost)
        Me.Controls.Add(Me.SpeedLower)
        Me.Controls.Add(Me.Retry_Button)
        Me.Controls.Add(Me.Speed_Text)
        Me.Controls.Add(Me.Score_Text)
        Me.Controls.Add(Me.End_Text)
        Me.Controls.Add(Me.Car)
        Me.Controls.Add(Me.EnemyCar3)
        Me.Controls.Add(Me.EnemyCar2)
        Me.Controls.Add(Me.EnemyCar1)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(314, 479)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Ghost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpeedLower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyCar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyCar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyCar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RoadMover As Timer
    Friend WithEvents Left_Mover As Timer
    Friend WithEvents Right_Mover As Timer
    Friend WithEvents Enemy1_Mover As Timer
    Friend WithEvents Enemy3_Mover As Timer
    Friend WithEvents Enemy2_Mover As Timer
    Friend WithEvents EnemyCar1 As PictureBox
    Friend WithEvents EnemyCar2 As PictureBox
    Friend WithEvents EnemyCar3 As PictureBox
    Friend WithEvents Car As PictureBox
    Friend WithEvents End_Text As Label
    Friend WithEvents Score_Text As Label
    Friend WithEvents Retry_Button As Button
    Friend WithEvents Speed_Text As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents SpeedLower As PictureBox
    Friend WithEvents SpeedLowerMover As Timer
    Friend WithEvents SpeedSlowerSpawn As Timer
    Friend WithEvents EnemyCarSlow As Timer
    Friend WithEvents Ghost As PictureBox
    Friend WithEvents GhostFlicker As Timer
    Friend WithEvents RoadMoverGhost As Timer
    Friend WithEvents GhostSpawn As Timer
End Class
