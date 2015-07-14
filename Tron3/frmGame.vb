Public Class frmGame

    Dim intCountdown As Integer
    Dim bolBoundaries
    Dim tronBikes(4, 4)
    Dim int As New Bitmap(488, 280)
    Dim int2 As New Bitmap(488, 280)
    Dim intPlayers As Integer
    Dim intCount As Integer
    Dim i As Integer

    'AI variables
    Dim xDifference As Integer
    Dim yDifference As Integer
    Dim Distance As Integer
    Dim PrevDistance As Integer

    Private Sub frmGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bolBoundaries = True
        'frmTronsole.Show()
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case Keys.A
                tronBikes(1, 3) = tronBikes(1, 3) + 1
                If tronBikes(1, 3) = 5 Then
                    tronBikes(1, 3) = 1
                End If
            Case Keys.D
                tronBikes(1, 3) = tronBikes(1, 3) - 1
                If tronBikes(1, 3) = 0 Then
                    tronBikes(1, 3) = 4
                End If
            Case Keys.Left
                tronBikes(2, 3) = tronBikes(2, 3) + 1
                If tronBikes(2, 3) = 5 Then
                    tronBikes(2, 3) = 1
                End If
            Case Keys.Right
                tronBikes(2, 3) = tronBikes(2, 3) - 1
                If tronBikes(2, 3) = 0 Then
                    tronBikes(2, 3) = 4
                End If
            Case Keys.H
                tronBikes(3, 3) = tronBikes(3, 3) + 1
                If tronBikes(3, 3) = 5 Then
                    tronBikes(3, 3) = 1
                End If
            Case Keys.K
                tronBikes(3, 3) = tronBikes(3, 3) - 1
                If tronBikes(3, 3) = 0 Then
                    tronBikes(3, 3) = 4
                End If
            Case Keys.NumPad4
                tronBikes(4, 3) = tronBikes(4, 3) + 1
                If tronBikes(4, 3) = 5 Then
                    tronBikes(4, 3) = 1
                End If
            Case Keys.NumPad6
                tronBikes(4, 3) = tronBikes(4, 3) - 1
                If tronBikes(4, 3) = 0 Then
                    tronBikes(4, 3) = 4
                End If
        End Select


    End Sub

    Private Sub PlayerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayerToolStripMenuItem.Click

        intPlayers = 2
        Call GameInitialise()

    End Sub

    Private Sub PlayerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayerToolStripMenuItem1.Click

        intPlayers = 3
        Call GameInitialise()

    End Sub

    Private Sub PlayerToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayerToolStripMenuItem2.Click

        intPlayers = 4
        Call GameInitialise()

    End Sub

    Private Sub GameInitialise()

        Call Pythag()
        PrevDistance = Distance

        intCount = intPlayers

        While intCount > 0

            Select Case intCount
                Case 1
                    tronBikes(1, 1) = 334
                    tronBikes(1, 2) = 140
                    tronBikes(1, 3) = 3
                    tronBikes(1, 4) = 1
                Case 2
                    tronBikes(2, 1) = 153
                    tronBikes(2, 2) = 140
                    tronBikes(2, 3) = 1
                    tronBikes(2, 4) = 1
                Case 3
                    tronBikes(3, 1) = 243
                    tronBikes(3, 2) = 230
                    tronBikes(3, 3) = 2
                    tronBikes(3, 4) = 1
                Case 4
                    tronBikes(4, 1) = 243
                    tronBikes(4, 2) = 50
                    tronBikes(4, 3) = 4
                    tronBikes(4, 4) = 1
            End Select

            intCount = intCount - 1
        End While

        Dim x, y As Integer

        intCountdown = 3
        x = -1
        y = 0

        Do While y < 280

            If x = 487 Then
                x = -1
                y = y + 1
            Else
                x = x + 1
                int.SetPixel(x, y, Color.Black)
            End If

        Loop

        CountdownTimer.Enabled = True
        lblCountdown.Text = intCountdown
        lblCountdown.Visible = True

    End Sub

    Private Sub BoundariesTrue()

        If tronBikes(i, 1) = 487 Or tronBikes(i, 1) = 0 Or tronBikes(i, 2) = 279 Or tronBikes(i, 2) = 0 Then
            tronBikes(i, 4) = 0
            intCount = intCount + 1

            If intCount = intPlayers - 1 Then
                TimerGame.Enabled = False
            End If

        End If

    End Sub

    Private Sub BoundariesFalse()

        If tronBikes(i, 1) = 488 Then
            tronBikes(i, 1) = 0
        ElseIf tronBikes(i, 1) = -1 Then
            tronBikes(i, 1) = 487
        ElseIf tronBikes(i, 2) = 280 Then
            tronBikes(i, 2) = 0
        ElseIf tronBikes(i, 2) = 0 Then
            tronBikes(i, 2) = 279
        End If

    End Sub

    Private Sub CoordinateChange()

            Select Case tronBikes(i, 3)
                Case 1
                    tronBikes(i, 1) = tronBikes(i, 1) + 1
                Case 2
                    tronBikes(i, 2) = tronBikes(i, 2) - 1
                Case 3
                    tronBikes(i, 1) = tronBikes(i, 1) - 1
                Case 4
                    tronBikes(i, 2) = tronBikes(i, 2) + 1
        End Select

    End Sub

    Private Sub CountdownTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountdownTimer.Tick

        intCountdown = intCountdown - 1
        lblCountdown.Text = intCountdown

        If intCountdown = "0" Then

            lblCountdown.Visible = False
            CountdownTimer.Enabled = False
            TimerGame.Enabled = True


        End If
    End Sub

    Private Sub TimerGame_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerGame.Tick

        Dim MyColor As Color

        Label1.Text = Distance
        Label2.Text = tronBikes(1, 1)
        Label3.Text = tronBikes(1, 2)
        Label4.Text = tronBikes(1, 3)

        For i = 1 To intPlayers

            If tronBikes(i, 4) = 1 Then

                Select Case tronBikes(i, 3)
                    Case 1
                        tronBikes(i, 1) = tronBikes(i, 1) + 1
                    Case 2
                        tronBikes(i, 2) = tronBikes(i, 2) - 1
                    Case 3
                        tronBikes(i, 1) = tronBikes(i, 1) - 1
                    Case 4
                        tronBikes(i, 2) = tronBikes(i, 2) + 1
                End Select

                If i = 2 Then
                    Call PlayerAI()
                End If

                If bolBoundaries = True Then
                    Call BoundariesTrue()
                ElseIf bolBoundaries = False Then
                    Call BoundariesFalse()
                End If

                MyColor = int.GetPixel(tronBikes(i, 1), tronBikes(i, 2))

                If MyColor.ToArgb = Color.Yellow.ToArgb Or MyColor.ToArgb = Color.Red.ToArgb Or MyColor.ToArgb = Color.Cyan.ToArgb Or MyColor.ToArgb = Color.Chartreuse.ToArgb Then
                    tronBikes(i, 4) = 0
                    intCount = intCount + 1

                    If intCount = intPlayers - 1 Then
                        TimerGame.Enabled = False
                    End If

                ElseIf i = 1 Then
                    int.SetPixel(tronBikes(i, 1), tronBikes(i, 2), Color.Red)
                ElseIf i = 2 Then
                    int.SetPixel(tronBikes(i, 1), tronBikes(i, 2), Color.Yellow)
                ElseIf i = 3 Then
                    int.SetPixel(tronBikes(i, 1), tronBikes(i, 2), Color.Cyan)
                ElseIf i = 4 Then
                    int.SetPixel(tronBikes(i, 1), tronBikes(i, 2), Color.Chartreuse)
                End If
                PictureBox1.Image = int
            End If
        Next

    End Sub

    Private Sub EasyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EasyToolStripMenuItem.Click

        MediumToolStripMenuItem.Checked = False
        HardToolStripMenuItem.Checked = False
        TimerGame.Interval = 30

    End Sub

    Private Sub MediumToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MediumToolStripMenuItem.Click

        EasyToolStripMenuItem.Checked = False
        HardToolStripMenuItem.Checked = False
        TimerGame.Interval = 20

    End Sub

    Private Sub HardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HardToolStripMenuItem.Click

        EasyToolStripMenuItem.Checked = False
        MediumToolStripMenuItem.Checked = False
        TimerGame.Interval = 10

    End Sub

    Private Sub OnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnToolStripMenuItem.Click
        OffToolStripMenuItem.Checked = False
        bolBoundaries = True
    End Sub

    Private Sub OffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OffToolStripMenuItem.Click
        OnToolStripMenuItem.Checked = False
        bolBoundaries = False
    End Sub

    Private Sub PlayerAI()

        Call DefenseAI()

    End Sub

    Private Function Pythag() As Integer

        xDifference = tronBikes(2, 1) - tronBikes(1, 1)
        yDifference = tronBikes(2, 2) - tronBikes(1, 2)

        Pythag = xDifference ^ 2 + yDifference ^ 2
        Pythag = Distance ^ 0.5


    End Function

    Private Sub DefenseAI()

        Distance = Pythag()

        If Distance > PrevDistance Then

            Select Case tronBikes(2, 3)
                Case 1

                    Distance = Pythag()
                Case 2
                    Distance = Pythag()
                Case 3
                    Distance = Pythag()
                Case 4
                    Distance = Pythag()
            End Select

        End If

    End Sub

    Private Sub AggressionAI()
        'Dim xDifference As Integer
        'Dim yDifference As Integer
        'Dim direction As Integer
        'Dim MyColor As Color
        'Dim found As Boolean


        'MyColor = int.GetPixel(tronBikes(2, 1), tronBikes(2, 2))

        'While found = False

        '    If MyColor.ToArgb = Color.Black.ToArgb Then
        '        'do nothing
        '        found = True
        '    Else
        '        Select Case tronBikes(2, 3)
        '            Case 1
        '                tronBikes(2, 1) = tronBikes(2, 1) - 1
        '            Case 2
        '                tronBikes(2, 2) = tronBikes(2, 2) + 1
        '            Case 3
        '                tronBikes(2, 1) = tronBikes(2, 1) + 1
        '            Case 4
        '                tronBikes(2, 2) = tronBikes(2, 2) - 1
        '        End Select
        '    End If
        'End While

        'If tronBikes(2, 1) > tronBikes(1, 1) Then
        '    xDifference = tronBikes(2, 1) - tronBikes(1, 1)
        '    direction = 3
        'ElseIf tronBikes(2, 1) < tronBikes(1, 1) Then
        '    xDifference = tronBikes(1, 1) - tronBikes(2, 1)
        '    direction = 1
        'End If

        'If tronBikes(2, 2) > tronBikes(1, 2) Then
        '    yDifference = tronBikes(2, 2) - tronBikes(1, 2)
        '    direction = 4
        'ElseIf tronBikes(2, 2) < tronBikes(1, 2) Then
        '    yDifference = tronBikes(1, 2) - tronBikes(2, 2)
        '    direction = 2
        'End If

        'Select Case direction
        '    Case 1
        '        Select Case tronBikes(2, 3)
        '            Case 2
        '                tronBikes(2, 3) = 1
        '            Case 3
        '                tronBikes(2, 3) = 4
        '            Case 4
        '                tronBikes(2, 3) = 1
        '        End Select

        '    Case 2
        '        Select Case tronBikes(2, 3)
        '            Case 1
        '                tronBikes(2, 3) = 2
        '            Case 3
        '                tronBikes(2, 3) = 2
        '            Case 4
        '                tronBikes(2, 3) = 3
        '        End Select

        '    Case 3
        '        Select Case tronBikes(2, 3)
        '            Case 1
        '                tronBikes(2, 3) = 2
        '            Case 2
        '                tronBikes(2, 3) = 3
        '            Case 4
        '                tronBikes(2, 3) = 3
        '        End Select

        '    Case 4
        '        Select Case tronBikes(2, 3)
        '            Case 1
        '                tronBikes(2, 3) = 4
        '            Case 2
        '                tronBikes(2, 3) = 1
        '            Case 3
        '                tronBikes(2, 3) = 4
        '        End Select
        'End Select

        'If xDifference > yDifference And MyColor.ToArgb = Color.Black.ToArgb Then
        '    'tronBikes(2, 3) = tronBikes(2, 3) + 1
        '    'If tronBikes(2, 3) = 5 Then
        '    '    tronBikes(2, 3) = 1
        '    'End If

        'ElseIf xDifference < yDifference And MyColor.ToArgb = Color.Black.ToArgb Then
        '    tronBikes(2, 3) = tronBikes(2, 3) - 1
        '    If tronBikes(2, 3) = 0 Then
        '        tronBikes(2, 3) = 4
        '    End If

        'End If
    End Sub

End Class
