Public Class frmGame

    Dim Direction1, Direction2 As Integer
    Dim X1, X2, Y1, Y2 As Integer
    Dim Countdown As Integer
    Dim CoNumber As Integer
    Dim Coordinates As XY
    Dim int As New Bitmap(488, 280)
    Dim int2 As New Bitmap(488, 280)

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Direction1 = 1
        Direction2 = 3
        CoNumber = 1
        Countdown = 4
        X1 = 100
        X2 = 388
        Y2 = 120
        Y1 = 120


    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case Keys.A
                If Direction1 = 1 Then
                    Direction1 = 2
                ElseIf Direction1 = 2 Then
                    Direction1 = 3
                ElseIf Direction1 = 3 Then
                    Direction1 = 4
                ElseIf Direction1 = 4 Then
                    Direction1 = 1
                End If
            Case Keys.D
                If Direction1 = 1 Then
                    Direction1 = 4
                ElseIf Direction1 = 4 Then
                    Direction1 = 3
                ElseIf Direction1 = 3 Then
                    Direction1 = 2
                ElseIf Direction1 = 2 Then
                    Direction1 = 1
                End If
            Case Keys.Left
                If Direction2 = 1 Then
                    Direction2 = 2
                ElseIf Direction2 = 2 Then
                    Direction2 = 3
                ElseIf Direction2 = 3 Then
                    Direction2 = 4
                ElseIf Direction2 = 4 Then
                    Direction2 = 1
                End If
            Case Keys.Right
                If Direction2 = 1 Then
                    Direction2 = 4
                ElseIf Direction2 = 4 Then
                    Direction2 = 3
                ElseIf Direction2 = 3 Then
                    Direction2 = 2
                ElseIf Direction2 = 2 Then
                    Direction2 = 1
                End If
        End Select


    End Sub

    Public Sub timerOne_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerOne.Tick

        Dim MyColor As Color

        If Direction1 = 1 Then
            X1 = X1 + 1
            MyColor = int.GetPixel(X1, Y1)
            If MyColor.ToArgb = Color.Yellow.ToArgb Or MyColor.ToArgb = Color.Red.ToArgb Then
                TimerOne.Enabled = False
                TimerTwo.Enabled = False
                MsgBox("Yellow Loses")
            End If
            int.SetPixel(X1, Y1, Color.Yellow)

        ElseIf Direction1 = 2 Then
            Y1 = Y1 - 1
            MyColor = int.GetPixel(X1, Y1)
            If MyColor.ToArgb = Color.Yellow.ToArgb Or MyColor.ToArgb = Color.Red.ToArgb Then
                TimerOne.Enabled = False
                TimerTwo.Enabled = False
                MsgBox("Yellow Loses")
            End If
            int.SetPixel(X1, Y1, Color.Yellow)

        ElseIf Direction1 = 3 Then
            X1 = X1 - 1
            MyColor = int.GetPixel(X1, Y1)
            If MyColor.ToArgb = Color.Yellow.ToArgb Or MyColor.ToArgb = Color.Red.ToArgb Then
                TimerOne.Enabled = False
                TimerTwo.Enabled = False
                MsgBox("Yellow Loses")
            End If
            int.SetPixel(X1, Y1, Color.Yellow)

        ElseIf Direction1 = 4 Then
            Y1 = Y1 + 1

            MyColor = int.GetPixel(X1, Y1)
            If MyColor.ToArgb = Color.Yellow.ToArgb Or MyColor.ToArgb = Color.Red.ToArgb Then
                TimerOne.Enabled = False
                TimerTwo.Enabled = False
                MsgBox("Yellow Loses")

            End If
            int.SetPixel(X1, Y1, Color.Yellow)
        End If

        PictureBox1.Image = int

    End Sub

    Private Sub TimerTwo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTwo.Tick

        Dim MyColor As Color

        If Direction2 = 1 Then
            X2 = X2 + 1
            MyColor = int.GetPixel(X2, Y2)
            If MyColor.ToArgb = Color.Yellow.ToArgb Or MyColor.ToArgb = Color.Red.ToArgb Then
                TimerOne.Enabled = False
                TimerTwo.Enabled = False
                MsgBox("Red Loses")
            End If
            int.SetPixel(X2, Y2, Color.Red)

        ElseIf Direction2 = 2 Then
            Y2 = Y2 - 1
            MyColor = int.GetPixel(X2, Y2)
            If MyColor.ToArgb = Color.Yellow.ToArgb Or MyColor.ToArgb = Color.Red.ToArgb Then
                TimerOne.Enabled = False
                TimerTwo.Enabled = False
                MsgBox("Red Loses")
            End If
            int.SetPixel(X2, Y2, Color.Red)

        ElseIf Direction2 = 3 Then
            X2 = X2 - 1
            MyColor = int.GetPixel(X2, Y2)
            If MyColor.ToArgb = Color.Yellow.ToArgb Or MyColor.ToArgb = Color.Red.ToArgb Then
                TimerOne.Enabled = False
                TimerTwo.Enabled = False
                MsgBox("Red Loses")
            End If
            int.SetPixel(X2, Y2, Color.Red)

        ElseIf Direction2 = 4 Then
            Y2 = Y2 + 1
            MyColor = int.GetPixel(X2, Y2)
            If MyColor.ToArgb = Color.Yellow.ToArgb Or MyColor.ToArgb = Color.Red.ToArgb Then
                TimerOne.Enabled = False
                TimerTwo.Enabled = False
                MsgBox("Red Loses")
            End If
            int.SetPixel(X2, Y2, Color.Red)
        End If

        PictureBox1.Image = int

    End Sub

    Private Sub PlayerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayerToolStripMenuItem.Click
        Dim x, y As Integer
        Direction1 = 1
        Direction2 = 3
        CoNumber = 1
        Countdown = 4
        X1 = 100
        X2 = 388
        Y2 = 120
        Y1 = 120
        x = 1
        y = 1
        PictureBox1.Image = PictureBox2.Image
        Do While y < 280
            If x = 487 Then
                x = 1
                y = y + 1
            Else
                x = x + 1
                int.SetPixel(x, y, Color.Black)
            End If
        Loop

        CountdownTimer.Enabled = True
        lblCountdown.Visible = True
    End Sub

    Private Sub PlayerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayerToolStripMenuItem1.Click

    End Sub

    Private Sub PlayerToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayerToolStripMenuItem2.Click

    End Sub

    Private Sub CountdownTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountdownTimer.Tick
        Countdown = Countdown - 1
        lblCountdown.Text = Countdown
        If Countdown = "0" Then
            TimerOne.Enabled = True
            TimerTwo.Enabled = True
            lblCountdown.Visible = False
            CountdownTimer.Enabled = False
        End If
    End Sub


End Class
