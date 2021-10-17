Public Class Form1
    Dim speed As Integer
    Dim road(7) As PictureBox
    Dim score As Integer = 0
    Dim counter As Integer = 0 'counter for the slowing bonus
    Dim counter1 As Integer = 0 'counter for the ghost bonus

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        speed = 3
        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox6
        road(6) = PictureBox7
        road(7) = PictureBox8

    End Sub

    Private Sub RoadMover_Tick(sender As Object, e As EventArgs) Handles RoadMover.Tick
        For x As Integer = 0 To 7
            road(x).Top += speed
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next
        If score < 10 Then
            speed = 3
        End If
        If score > 10 And score < 20 And Not EnemyCarSlow.Enabled = True Then
            speed = 5
        End If
        If score > 20 And score < 35 And Not EnemyCarSlow.Enabled = True Then
            speed = 7
        End If
        If score > 35 And score < 50 And Not EnemyCarSlow.Enabled = True Then
            speed = 8
        End If
        If score > 50 And Not EnemyCarSlow.Enabled = True Then
            speed = 10
        End If
        Speed_Text.Text = "Speed" & speed

        If (Car.Bounds.IntersectsWith(EnemyCar1.Bounds)) Then
            gameOver()
        End If
        If (Car.Bounds.IntersectsWith(EnemyCar2.Bounds)) Then
            gameOver()
        End If
        If (Car.Bounds.IntersectsWith(EnemyCar3.Bounds)) Then
            gameOver()
        End If
        If (Car.Bounds.IntersectsWith(SpeedLower.Bounds) And SpeedLower.Visible = True) Then
            SpeedLower.Visible = False
            EnemyCarSlow.Enabled = True
        End If
        If (Car.Bounds.IntersectsWith(Ghost.Bounds) And Ghost.Visible = True) Then
            Ghost.Visible = False
            GhostFlicker.Enabled = True
        End If
    End Sub
    Private Sub gameOver()
        Retry_Button.Visible = True



        End_Text.Visible = True
        RoadMover.Stop()
        Enemy1_Mover.Stop()
        Enemy2_Mover.Stop()
        Enemy3_Mover.Stop()
        SpeedLowerMover.Stop()
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            Right_Mover.Start()
        End If
        If e.KeyCode = Keys.Left Then
            Left_Mover.Start()
        End If
    End Sub

    Private Sub Right_Mover_Tick(sender As Object, e As EventArgs) Handles Right_Mover.Tick
        If (Car.Location.X < 188) Then
            Car.Left += 4.2
        End If

    End Sub

    Private Sub Left_Mover_Tick(sender As Object, e As EventArgs) Handles Left_Mover.Tick
        If (Car.Location.X > 0) Then
            Car.Left -= 4.2
        End If

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Right_Mover.Stop()
        Left_Mover.Stop()



    End Sub

    Private Sub Enemy1_Mover_Tick(sender As Object, e As EventArgs) Handles Enemy1_Mover.Tick
        EnemyCar1.Top += speed * 1.5 / 2
        If EnemyCar1.Top > Me.Height Then
            score += 1
            Score_Text.Text = "Score" & score
            EnemyCar1.Top = (-CInt(Math.Ceiling(Rnd() * 150)) + EnemyCar1.Height)
            EnemyCar1.Left = CInt(Math.Ceiling(Rnd() * 35)) + 0
        End If

    End Sub

    Private Sub Enemy2_Mover_Tick(sender As Object, e As EventArgs) Handles Enemy2_Mover.Tick
        EnemyCar2.Top += speed * 2 / 2
        If EnemyCar2.Top > Me.Height Then
            score += 1
            Score_Text.Text = "Score" & score
            EnemyCar2.Top = (-CInt(Math.Ceiling(Rnd() * 150)) + EnemyCar2.Height)
            EnemyCar2.Left = CInt(Math.Ceiling(Rnd() * 45)) + 60
        End If
    End Sub

    Private Sub Enemy3_Mover_Tick(sender As Object, e As EventArgs) Handles Enemy3_Mover.Tick
        EnemyCar3.Top += speed
        If EnemyCar3.Top > Me.Height Then
            score += 1
            Score_Text.Text = "Score" & score
            EnemyCar3.Top = (-CInt(Math.Ceiling(Rnd() * 150)) + EnemyCar3.Height)
            EnemyCar3.Left = CInt(Math.Ceiling(Rnd() * 30)) + 145
        End If
    End Sub

    Private Sub Retry_Button_Click(sender As Object, e As EventArgs) Handles Retry_Button.Click
        score = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)

    End Sub

    Private Sub SpeedLowerMover_Tick(sender As Object, e As EventArgs) Handles SpeedLowerMover.Tick
        If SpeedLower.Visible Then
            SpeedLower.Top += speed
            If SpeedLower.Top > Me.Height Then
                SpeedLower.Visible = False
            End If
        End If

        If Ghost.Visible Then
            Ghost.Top += speed
            If Ghost.Top > Me.Height Then
                Ghost.Visible = False
            End If
        End If

    End Sub


    Private Sub SpeedSlowerSpawn_Tick(sender As Object, e As EventArgs) Handles SpeedSlowerSpawn.Tick
        If Not SpeedLower.Visible Then
            SpeedLower.Top = CInt(Math.Ceiling(Rnd() * 300))
            SpeedLower.Left = CInt(Math.Ceiling(Rnd() * 188))
            If Not SpeedLower.Bounds.IntersectsWith(EnemyCar1.Bounds) And Not SpeedLower.Bounds.IntersectsWith(EnemyCar2.Bounds) And Not SpeedLower.Bounds.IntersectsWith(EnemyCar3.Bounds) Then
                SpeedLower.Visible = True
            End If
        End If
    End Sub

    Private Sub EnemyCarSlow_Tick(sender As Object, e As EventArgs) Handles EnemyCarSlow.Tick
        If counter < 100 And EnemyCarSlow.Enabled = True Then
            Speed_Text.Text = "Speed" & speed
            If score < 10 Then
                speed = 2
            End If
            If score > 10 And score < 20 Then
                speed = 3
            End If
            If score > 20 And score < 35 Then
                speed = 5
            End If
            If score > 35 And score < 50 Then
                speed = 6
            End If
            If score > 50 Then
                speed = 8
            End If
        End If
        If counter = 100 Then
            EnemyCarSlow.Enabled = False
            counter = 0
        End If
        counter += 1
    End Sub

    Private Sub GhostFlicker_Tick(sender As Object, e As EventArgs) Handles GhostFlicker.Tick
        If counter1 < 120 Then 'the car flickers for 120 ticks
            RoadMover.Enabled = False
            RoadMoverGhost.Enabled = True
            If counter1 Mod 2 = 0 Then
                Car.Visible = True
            Else
                Car.Visible = False
            End If
        End If
        'when the number of ticks ends, we switch the main road mover timer to the timer in which there is no collision with enemy cars
        If counter1 = 120 Then
            RoadMoverGhost.Enabled = False
            RoadMover.Enabled = True
            Car.Visible = True
            counter1 = 0
            GhostFlicker.Enabled = False
        End If
        counter1 += 1
    End Sub

    Private Sub RoadMoverGhost_Tick(sender As Object, e As EventArgs) Handles RoadMoverGhost.Tick
        For x As Integer = 0 To 7
            road(x).Top += speed
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next
        If score < 10 Then
            speed = 3
        End If
        If score > 10 And score < 20 And Not EnemyCarSlow.Enabled = True Then
            speed = 5
        End If
        If score > 20 And score < 35 And Not EnemyCarSlow.Enabled = True Then
            speed = 7
        End If
        If score > 35 And score < 50 And Not EnemyCarSlow.Enabled = True Then
            speed = 8
        End If
        If score > 50 And Not EnemyCarSlow.Enabled = True Then
            speed = 10
        End If
        Speed_Text.Text = "Speed" & speed

    End Sub

    Private Sub GhostSpawn_Tick(sender As Object, e As EventArgs) Handles GhostSpawn.Tick
        If Not Ghost.Visible Then
            Ghost.Top = CInt(Math.Ceiling(Rnd() * 300))
            Ghost.Left = CInt(Math.Ceiling(Rnd() * 188))
            If Not Ghost.Bounds.IntersectsWith(EnemyCar1.Bounds) And Not Ghost.Bounds.IntersectsWith(EnemyCar2.Bounds) And Not Ghost.Bounds.IntersectsWith(EnemyCar3.Bounds) Then
                Ghost.Visible = True
            End If
        End If
    End Sub
End Class
