Public Class GameEvents

    Public Shared Sub ResetDefaultLayout()

        GameVariables.soundfx = True
        GameVariables.changecolouronclick = False
        GameVariables.squareenabled = True
        GameVariables.circleenabled = False
        GameVariables.onesquare = True
        GameVariables.twosquare = False
        GameVariables.threesquare = False
        GameVariables.onecircle = True
        GameVariables.twocircle = False
        GameVariables.threecircle = False

        frmgame.picboxhighscore.Size = New Size(frmgame.picboxhighscore.Parent.ClientSize.Width / 2, frmgame.picboxhighscore.Parent.ClientSize.Height / 2)
        frmgame.picboxhighscore.Location = New Point((frmgame.picboxhighscore.Parent.ClientSize.Width / 2) - (frmgame.picboxhighscore.Width / 2),
                              (frmgame.picboxhighscore.Parent.ClientSize.Height / 2) - (frmgame.picboxhighscore.Height / 2))

        frmgame.picboxlifelost.Size = New Size(frmgame.picboxlifelost.Parent.ClientSize.Width / 2, frmgame.picboxlifelost.Parent.ClientSize.Height / 2)
        frmgame.picboxlifelost.Location = New Point((frmgame.picboxlifelost.Parent.ClientSize.Width / 2) - (frmgame.picboxlifelost.Width / 2),
                              (frmgame.picboxlifelost.Parent.ClientSize.Height / 2) - (frmgame.picboxlifelost.Height / 2))

        frmgame.picboxbackground.Dock = DockStyle.Fill
        frmgame.picboxbackground.BringToFront()

        square1.Size = New Size(150, 150)
        square2.Size = New Size(150, 150)
        square3.Size = New Size(150, 150)

        square1.TopLevel = False
        square2.TopLevel = False
        square3.TopLevel = False

        circle1.TopLevel = False
        circle2.TopLevel = False
        circle3.TopLevel = False

        square1.Parent = frmgame
        square2.Parent = frmgame
        square3.Parent = frmgame

        circle1.Parent = frmgame
        circle2.Parent = frmgame
        circle3.Parent = frmgame

        GameEvents.CentreCircleAndSquare()

        'this is so that when the circle is drawn the limit is 1000
        circle1.Size = New Size(1000, 1000)
        circle2.Size = New Size(1000, 1000)
        circle3.Size = New Size(1000, 1000)

        Using path As New System.Drawing.Drawing2D.GraphicsPath
            path.AddEllipse(0, 0, 150, 150)
            circle1.Region = New Region(path)
            path.AddEllipse(0, 0, 150, 150)
            circle2.Region = New Region(path)
            path.AddEllipse(0, 0, 150, 150)
            circle3.Region = New Region(path)
        End Using

        GameVariables.currentscore = 0
        frmgame.WindowState = FormWindowState.Maximized
        FrmPreferences.Show()
        frmhighscores.Show()
        frmpanel.Show()

        FrmPreferences.Location = New Point(frmgame.picboxbackground.Width - FrmPreferences.Width - frmhighscores.Width, 30)
        frmhighscores.Location = New Point(frmgame.picboxbackground.Width - frmhighscores.Width, 30)

        square1.Show()
        square2.Hide()
        square3.Hide()
        circle1.Hide()
        circle2.Hide()
        circle3.Hide()

        'Disables background and banners so player can not lose lives before starting game
        frmgame.picboxbackground.Enabled = True
        frmgame.picboxhighscore.Enabled = True
        frmgame.picboxlifelost.Enabled = True

        frmgame.lblstart.Text = "Click the shape start"
        frmgame.picboxbackground.Image = My.Resources.Abstract
        frmgame.picboxhighscore.Image = My.Resources.Highscore

        frmgame.LivesLeftToolStripMenuItem.Text = GameVariables.MaxLives
        GameVariables.Lives = GameVariables.MaxLives


        GameOverReset()

        frmconsole.consoledialog.AppendText(vbNewLine)
        frmconsole.consoledialog.AppendText("Loaded default Free-mode layout")

        If GameVariables.Linear = True Then
            'Linear mode start

            FrmLinearPrefs.Show()
            FrmPreferences.Hide()

            FrmLinearPrefs.Location = New Point(frmgame.picboxbackground.Width - frmhighscores.Width - FrmLinearPrefs.Width, 30)

        End If
    End Sub

    Public Shared Sub ShowHighscorePlaySound()

        'highscore integer stores highscore
        Dim highscore As Integer = 0
        highscore = Convert.ToInt32(frmhighscores.lblhighscorenum.Text)

        'checks if current score is higher than saved score
        If GameVariables.currentscore > highscore Then

            'checks if sound is muted or enabled
            If GameVariables.soundfx = True Then

                'generates random number depending on the result a different sound will play
                GameVariables.highscoresound = CInt(Math.Ceiling(Rnd() * 3)) + 0

                If GameVariables.highscoresound = 1 Then
                    GameVariables.highscoreshowing = False
                    My.Computer.Audio.Play(My.Resources.level1, AudioPlayMode.Background)
                End If

                If GameVariables.highscoresound = 2 Then
                    GameVariables.highscoreshowing = False
                    My.Computer.Audio.Play(My.Resources.level2, AudioPlayMode.Background)
                End If

                If GameVariables.highscoresound = 3 Then
                    GameVariables.highscoreshowing = False
                    My.Computer.Audio.Play(My.Resources.level3, AudioPlayMode.Background)
                End If

                frmgame.removehighscore.Start()
                frmgame.picboxhighscore.Show()
                frmgame.picboxhighscore.BringToFront()
                square1.BringToFront()
                square2.BringToFront()
                square3.BringToFront()
                circle1.BringToFront()
                circle2.BringToFront()
                circle3.BringToFront()
                frmgame.refreshtimer.Enabled = False

            End If
        End If
    End Sub

    Public Shared Sub RemoveHighscoreImage()
        circle1.BringToFront()
        circle2.BringToFront()
        circle3.BringToFront()

        square1.BringToFront()
        square2.BringToFront()
        square3.BringToFront()

        frmgame.picboxhighscore.Hide()
        frmgame.picboxbackground.Show()

        frmgame.removehighscore.Stop()
        GameVariables.highscoreshowing = True

        frmconsole.consoledialog.AppendText(vbNewLine)
        frmconsole.consoledialog.AppendText("New highscore")
    End Sub

    Public Shared Sub OpenConsole()
        frmconsole.Show()
        frmconsole.BringToFront()
        frmconsole.TopMost = True

        frmconsole.consoledialog.AppendText(vbNewLine)
        frmconsole.consoledialog.AppendText("Console loaded")
    End Sub

    Public Shared Sub WindowedMode()

        GameVariables.WindowedMode = True

        frmgame.FormBorderStyle = FormBorderStyle.Sizable

        frmgame.Size = New Size(1080, 500)

        frmgame.MinimumSize = New Size(1080, 500)

        frmconsole.consoledialog.AppendText(vbNewLine)
        frmconsole.consoledialog.AppendText("Loaded windowed")
    End Sub

    Public Shared Sub FullscreenMode()

        GameVariables.WindowedMode = False

        frmgame.FormBorderStyle = FormBorderStyle.None
        frmgame.Size = SystemInformation.PrimaryMonitorSize

        frmgame.FullscreenUIUpdate()

        frmconsole.consoledialog.AppendText(vbNewLine)
        frmconsole.consoledialog.AppendText("Loaded fullscreen")
    End Sub

    Public Shared Sub FontBold()
        Dim f1 As New System.Drawing.Font("Segoe UI", FrmPreferences.btnone.Font.Size, FontStyle.Bold)
        For Each btn1 As Button In FrmPreferences.Controls.OfType(Of Button)()
            btn1.Font = f1
        Next

        Dim f2 As New System.Drawing.Font("Segoe UI", FrmPreferences.btnone.Font.Size, FontStyle.Bold)
        For Each btn1 As TextBox In FrmPreferences.Controls.OfType(Of TextBox)()
            btn1.Font = f2
        Next

        Dim f3 As New System.Drawing.Font("Segoe UI", FrmPreferences.btnone.Font.Size, FontStyle.Bold)
        For Each btn1 As Label In FrmPreferences.Controls.OfType(Of Label)()
            btn1.Font = f3
        Next

        frmconsole.consoledialog.AppendText(vbNewLine)
        frmconsole.consoledialog.AppendText("Loaded Bold font")
    End Sub

    Public Shared Sub FontRegular()
        Dim f1 As New System.Drawing.Font("Segoe UI", FrmPreferences.btnone.Font.Size, FontStyle.Regular)
        For Each btn1 As Button In FrmPreferences.Controls.OfType(Of Button)()
            btn1.Font = f1
        Next

        Dim f2 As New System.Drawing.Font("Segoe UI", FrmPreferences.btnone.Font.Size, FontStyle.Regular)
        For Each btn1 As TextBox In FrmPreferences.Controls.OfType(Of TextBox)()
            btn1.Font = f2
        Next

        Dim f3 As New System.Drawing.Font("Segoe UI", FrmPreferences.btnone.Font.Size, FontStyle.Regular)
        For Each btn1 As Label In FrmPreferences.Controls.OfType(Of Label)()
            btn1.Font = f3
        Next

        frmconsole.consoledialog.AppendText(vbNewLine)
        frmconsole.consoledialog.AppendText("Loaded Regular font")
    End Sub

    Public Shared Sub BackgroundClickReset()

        GameEvents.GameOverReset()

        If frmgame.timerlocation1.Enabled = True Then

            If frmlose.Visible = False Then

                frmgame.timerlocation1.Stop()
                frmgame.timerlocation2.Stop()
                frmgame.timerlocation3.Stop()

                GameVariables.ShapeTimeCount1.Reset()
                GameVariables.ShapeTimeCount2.Reset()
                GameVariables.ShapeTimeCount3.Reset()

                If square1.Left = (square1.Parent.Width \ 2) - (square1.Width \ 2) Then

                Else
                    frmlose.Show()
                    frmlose.Location = New Point((frmgame.Width - frmlose.Width) \ 2,
                         (frmgame.Height - frmlose.Height) \ 2)

                    frmgame.picboxbackground.Enabled = False
                    frmgame.picboxhighscore.Enabled = False
                    frmgame.picboxlifelost.Enabled = False
                    square1.Hide()
                End If

                If square2.Left = (square2.Parent.Width \ 2) - (square2.Width \ 2) Then

                Else
                    frmlose.Show()
                    frmlose.Location = New Point((frmgame.Width - frmlose.Width) \ 2,
                         (frmgame.Height - frmlose.Height) \ 2)

                    frmgame.picboxbackground.Enabled = False
                    frmgame.picboxhighscore.Enabled = False
                    frmgame.picboxlifelost.Enabled = False
                    square2.Hide()
                End If

                If square3.Left = (square3.Parent.Width \ 2) - (square3.Width \ 2) Then

                Else
                    frmlose.Show()
                    frmlose.Location = New Point((frmgame.Width - frmlose.Width) \ 2,
                         (frmgame.Height - frmlose.Height) \ 2)

                    frmgame.picboxbackground.Enabled = False
                    frmgame.picboxhighscore.Enabled = False
                    frmgame.picboxlifelost.Enabled = False
                    square3.Hide()
                End If

                If circle1.Top = (square3.Parent.Height \ 2) - (square3.Height \ 2) Then

                Else
                    frmlose.Show()
                    frmlose.Location = New Point((frmgame.Width - frmlose.Width) \ 2,
                         (frmgame.Height - frmlose.Height) \ 2)

                    frmgame.picboxbackground.Enabled = False
                    frmgame.picboxhighscore.Enabled = False
                    frmgame.picboxlifelost.Enabled = False
                    circle1.Hide()
                End If

                If circle2.Top = (square3.Parent.Height \ 2) - (square3.Height \ 2) Then

                Else
                    frmlose.Show()
                    frmlose.Location = New Point((frmgame.Width - frmlose.Width) \ 2,
                         (frmgame.Height - frmlose.Height) \ 2)

                    frmgame.picboxbackground.Enabled = False
                    frmgame.picboxhighscore.Enabled = False
                    frmgame.picboxlifelost.Enabled = False
                    circle2.Hide()
                End If

                If circle3.Top = (square3.Parent.Height \ 2) - (square3.Height \ 2) Then

                Else
                    frmlose.Show()
                    frmlose.Location = New Point((frmgame.Width - frmlose.Width) \ 2,
                         (frmgame.Height - frmlose.Height) \ 2)

                    frmgame.picboxbackground.Enabled = False
                    frmgame.picboxhighscore.Enabled = False
                    frmgame.picboxlifelost.Enabled = False
                    circle3.Hide()
                End If

                GameEvents.CentreCircleAndSquare()

                Dim highscore As Integer = frmhighscores.lblhighscorenum.Text

                If GameVariables.currentscore > highscore Then
                    frmhighscores.lblhighscorenum.Text = GameVariables.currentscore
                Else

                End If
                GameVariables.currentscore = 0
                frmgame.lblstart.Text = "Click the shape to start"
                frmgame.TimeLeftCounter.Stop()

                GameVariables.timeleft1 = 0
                GameVariables.timeleft2 = 0
                GameVariables.timeleft3 = 0

                square1.lbltimeleft1.Text = frmgame.timerlocation1.Interval
                square2.lbltimeleft2.Text = frmgame.timerlocation2.Interval
                square3.lbltimeleft3.Text = frmgame.timerlocation3.Interval

                circle1.lbltimeleft1.Text = frmgame.timerlocation1.Interval
                circle2.lbltimeleft2.Text = frmgame.timerlocation2.Interval
                circle3.lbltimeleft3.Text = frmgame.timerlocation3.Interval

                frmgame.refreshtimer.Enabled = True

                If GameVariables.soundfx = True Then

                    My.Computer.Audio.Stop()
                    My.Computer.Audio.Play(My.Resources.fail2, AudioPlayMode.Background)

                End If

            End If

        End If

        If GameVariables.Linear = True Then

            FrmLinearPrefs.Show()
            FrmPreferences.Hide()
            frmpanel.Show()
            GameVariables.ProgressCount = 0

        End If

        frmconsole.consoledialog.AppendText(vbNewLine)
        frmconsole.consoledialog.AppendText("Game reset")
    End Sub

    Public Shared Sub CentreCircleAndSquare()
        square1.CenterScreen()
        square2.CenterScreen()
        square3.CenterScreen()

        circle1.CenterScreen()
        circle2.CenterScreen()
        circle3.CenterScreen()
    End Sub

    Public Shared Sub ResetAllPreferences()
        GameVariables.soundfx = True
        GameVariables.changecolouronclick = False
        GameVariables.squareenabled = True
        GameVariables.circleenabled = False

        GameVariables.onesquare = True
        GameVariables.twosquare = False
        GameVariables.threesquare = False

        GameVariables.onecircle = True
        GameVariables.twocircle = False
        GameVariables.threecircle = False

        square1.BackColor = Color.FromArgb(255, 68, 85, 105)
        square2.BackColor = Color.FromArgb(255, 68, 85, 105)
        square3.BackColor = Color.FromArgb(255, 68, 85, 105)

        circle1.BackColor = Color.FromArgb(255, 68, 85, 105)
        circle2.BackColor = Color.FromArgb(255, 68, 85, 105)
        circle3.BackColor = Color.FromArgb(255, 68, 85, 105)

        circle1.Hide()
        circle2.Hide()
        circle3.Hide()

        square1.Show()
        square2.Hide()
        square3.Hide()

        frmgame.timerlocation1.Interval = 2000
        frmgame.timerlocation2.Interval = 2000
        frmgame.timerlocation3.Interval = 2000

        frmgame.picboxbackground.Image = My.Resources.Abstract

        frmgame.CurrentScoreToolStripMenuItem.Text = "0"

        square1.Size = New Size(150, 150)
        square2.Size = New Size(150, 150)
        square3.Size = New Size(150, 150)

        Using path As New System.Drawing.Drawing2D.GraphicsPath
            path.AddEllipse(0, 0, 150, 150)
            circle1.Region = New Region(path)
            path.AddEllipse(0, 0, 150, 150)
            circle2.Region = New Region(path)
            path.AddEllipse(0, 0, 150, 150)
            circle3.Region = New Region(path)
        End Using

        frmconsole.consoledialog.AppendText(vbNewLine)
        frmconsole.consoledialog.AppendText("All preferences have been reset")
    End Sub

    Public Shared Sub GameOverReset()

        frmgame.Focus()

        GameVariables.Lives = GameVariables.MaxLives

        GameVariables.ShapeTimeCount1.Restart()
        GameVariables.ShapeTimeCount2.Restart()
        GameVariables.ShapeTimeCount3.Restart()

        frmlose.Location = New Size(frmpanel.Left + frmgame.Width / 2 - frmlose.Width / 2, frmpanel.Top + frmgame.Height / 2 - frmlose.Height)

        lifeup.Hide()
        frmgame.ShowLifeUp.Stop()

        Freeze.Hide()
        frmgame.ShowFreeze.Stop()

        GameVariables.GameStoppedState = True

        frmconsole.consoledialog.AppendText(vbNewLine)
        frmconsole.consoledialog.AppendText("Game Over")

        frmconsole.consoledialog.AppendText(vbNewLine)
        frmconsole.consoledialog.AppendText("New highscore updated in config")

        If GameVariables.Linear = True Then

            GameVariables.ProgressCount = 0

            frmgame.LinearMode.Stop()

            Dim ctrl As Control
            For Each ctrl In FrmLinearPrefs.Controls

                If TypeOf ctrl Is Button Then
                    ctrl.Enabled = True
                End If

                If TypeOf ctrl Is TextBox Then
                    ctrl.Enabled = True
                End If

            Next

            square1.Size = New Size(GameVariables.MaxShapeSize, GameVariables.MaxShapeSize)
            square2.Size = New Size(GameVariables.MaxShapeSize, GameVariables.MaxShapeSize)
            square3.Size = New Size(GameVariables.MaxShapeSize, GameVariables.MaxShapeSize)

            circle1.Size = New Size(GameVariables.MaxShapeSize, GameVariables.MaxShapeSize)
            circle2.Size = New Size(GameVariables.MaxShapeSize, GameVariables.MaxShapeSize)
            circle3.Size = New Size(GameVariables.MaxShapeSize, GameVariables.MaxShapeSize)

            If GameVariables.squareenabled = True Then
                square1.Show()
                square2.Hide()
                square3.Hide()
            Else
                circle1.Show()
                circle2.Hide()
                circle3.Hide()
            End If

            Select Case GameVariables.GameDifficulty

                Case 0
                    GameVariables.LinearScalingSpeed = 275
                    GameVariables.LinearSizeScaling = 225
                    GameVariables.LinearTimeToClickScaling = 250
                Case 1
                    GameVariables.LinearScalingSpeed = 250
                    GameVariables.LinearSizeScaling = 200
                    GameVariables.LinearTimeToClickScaling = 225
                Case 2
                    GameVariables.LinearScalingSpeed = 225
                    GameVariables.LinearSizeScaling = 175
                    GameVariables.LinearTimeToClickScaling = 200
                Case 3
                    GameVariables.LinearScalingSpeed = 200
                    GameVariables.LinearSizeScaling = 150
                    GameVariables.LinearTimeToClickScaling = 175
                Case 4
                    GameVariables.LinearScalingSpeed = 175
                    GameVariables.LinearSizeScaling = 125
                    GameVariables.LinearTimeToClickScaling = 150
            End Select

            frmgame.timerlocation1.Interval = GameVariables.MaxTimeToClick
            frmgame.timerlocation2.Interval = GameVariables.MaxTimeToClick
            frmgame.timerlocation3.Interval = GameVariables.MaxTimeToClick

        End If
    End Sub

    Public Shared Sub ClickExtra() 'Call this everytime a square is clicked

        GameVariables.ResetCheckSync = True
        FrmLinearPrefs.CheckForTimeSync.Enabled = True

        'checks for highscore
        If GameConfig.GetConfigItem("MMG_Config.cfg", "Highscore") < GameVariables.currentscore Then
            'writes new highscore to config
            GameConfig.WriteToConfig(13, "Highscore=" & GameVariables.currentscore)
        End If
        'Ensures banners and background is enabled
        frmgame.picboxbackground.Enabled = True
        frmgame.picboxhighscore.Enabled = True
        frmgame.picboxlifelost.Enabled = True

        If GameVariables.powerupenbaled = True Then
            'ensures the power up timers are started
            frmgame.ShowLifeUp.Start()

            frmgame.ShowFreeze.Start()
        End If

        GameVariables.GameStoppedState = False

        'checks if sound is muted or enabled
        If GameVariables.soundfx = True Then

            'generates random number depending on the result a different sound will play
            GameVariables.btnpressound1 = CInt(Math.Ceiling(Rnd() * 3)) + 0

            If GameVariables.btnpressound1 = 1 Then
                If GameVariables.highscoreshowing = True Then
                    My.Computer.Audio.Play(My.Resources.sound1, AudioPlayMode.Background)
                End If
            End If

            If GameVariables.btnpressound1 = 2 Then
                If GameVariables.highscoreshowing = True Then
                    My.Computer.Audio.Play(My.Resources.sound2, AudioPlayMode.Background)
                End If
            End If

            If GameVariables.btnpressound1 = 3 Then
                If GameVariables.highscoreshowing = True Then
                    My.Computer.Audio.Play(My.Resources.sound3, AudioPlayMode.Background)
                End If

            End If

        End If

        'Updates highscore
        If GameVariables.ComplexScoring = True Then

            If Convert.ToInt16(square1.lbltimeleft1.Text) < 250 Then
                GameVariables.currentscore += 8
            ElseIf Convert.ToInt16(square1.lbltimeleft1.Text) < 500 Then
                GameVariables.currentscore += 7
            ElseIf Convert.ToInt16(square1.lbltimeleft1.Text) < 750 Then
                GameVariables.currentscore += 6
            ElseIf Convert.ToInt16(square1.lbltimeleft1.Text) < 1000 Then
                GameVariables.currentscore += 5
            ElseIf Convert.ToInt16(square1.lbltimeleft1.Text) < 1250 Then
                GameVariables.currentscore += 4
            ElseIf Convert.ToInt16(square1.lbltimeleft1.Text) < 1500 Then
                GameVariables.currentscore += 3
            ElseIf Convert.ToInt16(square1.lbltimeleft1.Text) < 1750 Then
                GameVariables.currentscore += 2
            ElseIf Convert.ToInt16(square1.lbltimeleft1.Text) > 1750 Then
                GameVariables.currentscore += 1
            End If

        Else
            GameVariables.currentscore += 1
        End If

        frmgame.CurrentScoreToolStripMenuItem.Text = GameVariables.currentscore

        frmgame.lblstart.Text = ""
        frmgame.TimeLeftCounter.Start()

        'Linear mode
        If GameVariables.Linear = True Then

            frmgame.LinearMode.Start()

            Dim ctrl As Control
            For Each ctrl In FrmLinearPrefs.Controls

                If TypeOf ctrl Is Button Then
                    ctrl.Enabled = False
                End If

                If TypeOf ctrl Is TextBox Then
                    ctrl.Enabled = False
                End If

            Next

            FrmLinearPrefs.Show()
            frmhighscores.Show()
        Else
            FrmPreferences.Hide()
            frmpanel.Hide()
            frmhighscores.Hide()
        End If

    End Sub

    Public Shared Sub SquareClickChangeLocation1()

        frmgame.timerlocation1.Stop()
        frmgame.timerlocation1.Start()

        ClickExtra()

        GameVariables.ShapeTimeCount1.Reset()

        'generates new location with border
        Randomize()
        Dim sizex As Integer = frmgame.picboxbackground.Size.Width - 190
        Dim sizey As Integer = frmgame.picboxbackground.Size.Height - 190 - FrmLinearPrefs.Height
        Dim xpoint As Integer = CInt(Int((sizex * Rnd()) + 40))
        Dim ypoint As Integer = CInt(Int((sizey * Rnd()) + 40 + FrmLinearPrefs.Height))
        square1.Location = New Point(xpoint, ypoint)

        GameVariables.timeleft1 = 0

        If GameVariables.changecolouronclick = True Then
            Dim rnd As New Random
            Dim rndcol = Color.FromArgb(&HFF828282 Or rnd.Next(&HFFFFFF + 1))
            square1.BackColor = rndcol
        End If

    End Sub

    Public Shared Sub SquareClickChangeLocation2()

        frmgame.timerlocation2.Stop()
        frmgame.timerlocation2.Start()

        ClickExtra()

        GameVariables.ShapeTimeCount2.Reset()

        'generates new location with border
        Randomize()
        Dim sizex As Integer = frmgame.picboxbackground.Size.Width - 190
        Dim sizey As Integer = frmgame.picboxbackground.Size.Height - 190 - FrmLinearPrefs.Height
        Dim xpoint As Integer = CInt(Int((sizex * Rnd()) + 40))
        Dim ypoint As Integer = CInt(Int((sizey * Rnd()) + 40 + FrmLinearPrefs.Height))
        square2.Location = New Point(xpoint, ypoint)

        GameVariables.timeleft2 = 0

        If GameVariables.changecolouronclick = True Then
            Dim rnd As New Random
            Dim rndcol = Color.FromArgb(&HFF828282 Or rnd.Next(&HFFFFFF + 1))
            square2.BackColor = rndcol
        End If

    End Sub

    Public Shared Sub SquareClickChangeLocation3()

        frmgame.timerlocation3.Stop()
        frmgame.timerlocation3.Start()

        ClickExtra()

        GameVariables.ShapeTimeCount3.Reset()

        'generates new location with border
        Randomize()
        Dim sizex As Integer = frmgame.picboxbackground.Size.Width - 190
        Dim sizey As Integer = frmgame.picboxbackground.Size.Height - 190 - FrmLinearPrefs.Height
        Dim xpoint As Integer = CInt(Int((sizex * Rnd()) + 40))
        Dim ypoint As Integer = CInt(Int((sizey * Rnd()) + 40 + FrmLinearPrefs.Height))
        square1.Location = New Point(xpoint, ypoint)

        GameVariables.timeleft3 = 0

        If GameVariables.changecolouronclick = True Then
            Dim rnd As New Random
            Dim rndcol = Color.FromArgb(&HFF828282 Or rnd.Next(&HFFFFFF + 1))
            square3.BackColor = rndcol
        End If

    End Sub

    Public Shared Sub CircleClickChangeLocation1()

        frmgame.timerlocation1.Stop()
        frmgame.timerlocation1.Start()

        ClickExtra()

        GameVariables.ShapeTimeCount1.Reset()

        'generates new location with border
        Randomize()
        Dim sizex As Integer = frmgame.picboxbackground.Size.Width - 190
        Dim sizey As Integer = frmgame.picboxbackground.Size.Height - 190 - FrmLinearPrefs.Height
        Dim xpoint As Integer = CInt(Int((sizex * Rnd()) + 40))
        Dim ypoint As Integer = CInt(Int((sizey * Rnd()) + 40 + FrmLinearPrefs.Height))
        square1.Location = New Point(xpoint, ypoint)

        GameVariables.timeleft1 = 0

        If GameVariables.changecolouronclick = True Then
            Dim rnd As New Random
            Dim rndcol = Color.FromArgb(&HFF828282 Or rnd.Next(&HFFFFFF + 1))
            circle1.BackColor = rndcol
        End If

    End Sub

    Public Shared Sub CircleClickChangeLocation2()

        frmgame.timerlocation2.Stop()
        frmgame.timerlocation2.Start()

        ClickExtra()

        GameVariables.ShapeTimeCount2.Reset()

        'generates new location with border
        Randomize()
        Dim sizex As Integer = frmgame.picboxbackground.Size.Width - 190
        Dim sizey As Integer = frmgame.picboxbackground.Size.Height - 190 - FrmLinearPrefs.Height
        Dim xpoint As Integer = CInt(Int((sizex * Rnd()) + 40))
        Dim ypoint As Integer = CInt(Int((sizey * Rnd()) + 40 + FrmLinearPrefs.Height))
        square1.Location = New Point(xpoint, ypoint)

        GameVariables.timeleft1 = 0

        If GameVariables.changecolouronclick = True Then
            Dim rnd As New Random
            Dim rndcol = Color.FromArgb(&HFF828282 Or rnd.Next(&HFFFFFF + 1))
            circle2.BackColor = rndcol
        End If
    End Sub

    Public Shared Sub CircleClickChangeLocation3()

        frmgame.timerlocation3.Stop()
        frmgame.timerlocation3.Start()

        ClickExtra()

        GameVariables.ShapeTimeCount3.Reset()

        'generates new location with border
        Randomize()
        Dim sizex As Integer = frmgame.picboxbackground.Size.Width - 190
        Dim sizey As Integer = frmgame.picboxbackground.Size.Height - 190 - FrmLinearPrefs.Height
        Dim xpoint As Integer = CInt(Int((sizex * Rnd()) + 40))
        Dim ypoint As Integer = CInt(Int((sizey * Rnd()) + 40 + FrmLinearPrefs.Height))
        square1.Location = New Point(xpoint, ypoint)

        GameVariables.timeleft1 = 0

        If GameVariables.changecolouronclick = True Then
            Dim rnd As New Random
            Dim rndcol = Color.FromArgb(&HFF828282 Or rnd.Next(&HFFFFFF + 1))
            circle3.BackColor = rndcol
        End If

    End Sub

    Public Shared Sub LifeLost(ByVal ShapeNumber As Integer)
        'checks what shape has ran out of time

        If GameVariables.Lives < 1 Then

            GameVariables.ResetCheckSync = False
            FrmLinearPrefs.CheckForTimeSync.Enabled = False

            GameEvents.BackgroundClickReset()
            frmgame.LivesLeftToolStripMenuItem.Text = GameVariables.MaxLives.ToString

            frmgame.picboxlifelost.Show()
            frmgame.picboxlifelost.BringToFront()

            frmgame.removelifelost.Stop()
            frmgame.removelifelost.Start()
            GameVariables.Lives = GameVariables.MaxLives

            FrmPreferences.Show()
            frmpanel.Show()
            frmhighscores.Show()

        Else
            GameVariables.Lives -= 1
            frmgame.LivesLeftToolStripMenuItem.Text = GameVariables.Lives.ToString()

            frmgame.picboxlifelost.Show()
            frmgame.picboxlifelost.BringToFront()

            square1.BringToFront()
            square2.BringToFront()
            square3.BringToFront()
            circle1.BringToFront()
            circle2.BringToFront()
            circle3.BringToFront()

            frmgame.removelifelost.Stop()
            frmgame.removelifelost.Start()

            frmgame.lblstart.Text = ""
            frmhighscores.Hide()
            FrmPreferences.Hide()
            frmgame.CurrentScoreToolStripMenuItem.Text = GameVariables.currentscore

            frmgame.TimeLeftCounter.Start()

            'checks if sound is muted or enabled
            If GameVariables.soundfx = True Then
                My.Computer.Audio.Play(My.Resources.fail1, AudioPlayMode.Background)
            End If
        End If

        If GameVariables.Linear = True Then
            frmpanel.Show()
        Else
            FrmPreferences.Hide()
            frmpanel.Hide()
            frmhighscores.Hide()
        End If

        Select Case ShapeNumber

            Case 1

                'generates new location with border
                Randomize()
                Dim sizex As Integer = frmgame.picboxbackground.Size.Width - 190
                Dim sizey As Integer = frmgame.picboxbackground.Size.Height - 190
                Dim xpoint As Integer = CInt(Int((sizex * Rnd()) + 40))
                Dim ypoint As Integer = CInt(Int((sizey * Rnd()) + 40))
                circle1.Location = New Point(xpoint, ypoint)

                GameVariables.timeleft1 = 0

                If GameVariables.changecolouronclick = True Then
                    Dim rnd As New Random
                    Dim rndcol = Color.FromArgb(&HFF828282 Or rnd.Next(&HFFFFFF + 1))
                    circle1.BackColor = rndcol
                End If

                frmgame.timerlocation1.Stop()
                frmgame.timerlocation1.Start()

                GameVariables.ShapeTimeCount1.Reset()

                'generates new location with border
                Randomize()
                Dim sizex1 As Integer = frmgame.picboxbackground.Size.Width - 190
                Dim sizey1 As Integer = frmgame.picboxbackground.Size.Height - 190
                Dim xpoint1 As Integer = CInt(Int((sizex1 * Rnd()) + 40))
                Dim ypoint1 As Integer = CInt(Int((sizey1 * Rnd()) + 40))
                square1.Location = New Point(xpoint1, ypoint1)

                GameVariables.timeleft1 = 0

                If GameVariables.changecolouronclick = True Then
                    Dim rnd As New Random
                    Dim rndcol = Color.FromArgb(&HFF828282 Or rnd.Next(&HFFFFFF + 1))
                    square1.BackColor = rndcol
                End If

            Case 2

                'generates new location with border
                Randomize()
                Dim sizex As Integer = frmgame.picboxbackground.Size.Width - 190
                Dim sizey As Integer = frmgame.picboxbackground.Size.Height - 190
                Dim xpoint As Integer = CInt(Int((sizex * Rnd()) + 40))
                Dim ypoint As Integer = CInt(Int((sizey * Rnd()) + 40))
                circle2.Location = New Point(xpoint, ypoint)

                GameVariables.timeleft2 = 0

                If GameVariables.changecolouronclick = True Then
                    Dim rnd As New Random
                    Dim rndcol = Color.FromArgb(&HFF828282 Or rnd.Next(&HFFFFFF + 1))
                    circle2.BackColor = rndcol
                End If

                frmgame.timerlocation2.Stop()
                frmgame.timerlocation2.Start()

                GameVariables.ShapeTimeCount2.Reset()

                'generates new location with border
                Randomize()
                Dim sizex1 As Integer = frmgame.picboxbackground.Size.Width - 190
                Dim sizey1 As Integer = frmgame.picboxbackground.Size.Height - 190
                Dim xpoint1 As Integer = CInt(Int((sizex1 * Rnd()) + 40))
                Dim ypoint1 As Integer = CInt(Int((sizey1 * Rnd()) + 40))
                square2.Location = New Point(xpoint1, ypoint1)

                GameVariables.timeleft2 = 0

                If GameVariables.changecolouronclick = True Then
                    Dim rnd As New Random
                    Dim rndcol = Color.FromArgb(&HFF828282 Or rnd.Next(&HFFFFFF + 1))
                    square2.BackColor = rndcol
                End If

                'checks if sound is muted or enabled
                If GameVariables.soundfx = True Then
                    My.Computer.Audio.Play(My.Resources.fail1, AudioPlayMode.Background)
                End If

            Case 3

                'generates new location with border
                Randomize()
                Dim sizex As Integer = frmgame.picboxbackground.Size.Width - 190
                Dim sizey As Integer = frmgame.picboxbackground.Size.Height - 190
                Dim xpoint As Integer = CInt(Int((sizex * Rnd()) + 40))
                Dim ypoint As Integer = CInt(Int((sizey * Rnd()) + 40))
                circle3.Location = New Point(xpoint, ypoint)

                GameVariables.timeleft3 = 0

                If GameVariables.changecolouronclick = True Then
                    Dim rnd As New Random
                    Dim rndcol = Color.FromArgb(&HFF828282 Or rnd.Next(&HFFFFFF + 1))
                    circle3.BackColor = rndcol
                End If

                frmgame.timerlocation3.Stop()
                frmgame.timerlocation3.Start()

                GameVariables.ShapeTimeCount3.Reset()

                'generates new location with border
                Randomize()
                Dim sizex1 As Integer = frmgame.picboxbackground.Size.Width - 190
                Dim sizey1 As Integer = frmgame.picboxbackground.Size.Height - 190
                Dim xpoint1 As Integer = CInt(Int((sizex1 * Rnd()) + 40))
                Dim ypoint1 As Integer = CInt(Int((sizey1 * Rnd()) + 40))
                square3.Location = New Point(xpoint1, ypoint1)

                GameVariables.timeleft3 = 0

                If GameVariables.changecolouronclick = True Then
                    Dim rnd As New Random
                    Dim rndcol = Color.FromArgb(&HFF828282 Or rnd.Next(&HFFFFFF + 1))
                    square3.BackColor = rndcol
                End If

        End Select
    End Sub

    Public Shared Sub FitUIToScreen()

        frmpanel.Size = New Size(frmgame.Width - 20, frmhighscores.Height)
        frmpanel.Location = New Point(frmgame.Right + 10 - frmgame.Width, frmgame.Top + 62)

        FrmPreferences.Size = New Size(frmgame.Width, frmhighscores.Height)
        FrmPreferences.Location = New Point(frmgame.Right - frmgame.Width - 200, frmgame.Top + 62)

        frmhighscores.Location = New Point(frmgame.Right - frmhighscores.Width, frmgame.Top + 62)

        'Resizes and Highscore banner and lifelost banner with ui scale
        frmgame.picboxhighscore.Size = New Size((frmgame.picboxhighscore.Parent.ClientSize.Width / 2) * GameVariables.BannerUIScaling, (frmgame.picboxhighscore.Parent.ClientSize.Height / 2) * GameVariables.BannerUIScaling)
        frmgame.picboxhighscore.Location = New Point((frmgame.picboxhighscore.Parent.ClientSize.Width / 2) - (frmgame.picboxhighscore.Width / 2),
                                  (frmgame.picboxhighscore.Parent.ClientSize.Height / 2) - (frmgame.picboxhighscore.Height / 2))

        frmgame.picboxlifelost.Size = New Size((frmgame.picboxlifelost.Parent.ClientSize.Width / 2) * GameVariables.BannerUIScaling, (frmgame.picboxlifelost.Parent.ClientSize.Height / 2) * GameVariables.BannerUIScaling)
        frmgame.picboxlifelost.Location = New Point((frmgame.picboxlifelost.Parent.ClientSize.Width / 2) - (frmgame.picboxlifelost.Width / 2),
                                  (frmgame.picboxlifelost.Parent.ClientSize.Height / 2) - (frmgame.picboxlifelost.Height / 2))

    End Sub

    Public Shared Sub ScaleUIBanners()
        'Resizes and Highscore banner and lifelost banner with ui scale
        frmgame.picboxhighscore.Size = New Size((frmgame.picboxhighscore.Parent.ClientSize.Width / 2) * GameVariables.BannerUIScaling, (frmgame.picboxhighscore.Parent.ClientSize.Height / 2) * GameVariables.BannerUIScaling)
        frmgame.picboxhighscore.Location = New Point((frmgame.picboxhighscore.Parent.ClientSize.Width / 2) - (frmgame.picboxhighscore.Width / 2),
                                  (frmgame.picboxhighscore.Parent.ClientSize.Height / 2) - (frmgame.picboxhighscore.Height / 2))

        frmgame.picboxlifelost.Size = New Size((frmgame.picboxlifelost.Parent.ClientSize.Width / 2) * GameVariables.BannerUIScaling, (frmgame.picboxlifelost.Parent.ClientSize.Height / 2) * GameVariables.BannerUIScaling)
        frmgame.picboxlifelost.Location = New Point((frmgame.picboxlifelost.Parent.ClientSize.Width / 2) - (frmgame.picboxlifelost.Width / 2),
                                  (frmgame.picboxlifelost.Parent.ClientSize.Height / 2) - (frmgame.picboxlifelost.Height / 2))
    End Sub

    Public Shared Sub TimeToClickEasy()
        FrmPreferences.btneasy.BringToFront()
        frmgame.timerlocation1.Interval = 2000
        frmgame.timerlocation2.Interval = 2000
        frmgame.timerlocation3.Interval = 2000
        FrmPreferences.txttimetoclick.Text = frmgame.timerlocation1.Interval
        GameVariables.squaresize = "Easy"

        square1.Text = frmgame.timerlocation1.Interval
        square2.Text = frmgame.timerlocation1.Interval
        square3.Text = frmgame.timerlocation1.Interval

        circle1.Text = frmgame.timerlocation1.Interval
        circle2.Text = frmgame.timerlocation1.Interval
        circle3.Text = frmgame.timerlocation1.Interval
    End Sub

    Public Shared Sub TimeToClickMedium()
        FrmPreferences.btnmedium.BringToFront()
        frmgame.timerlocation1.Interval = 1400
        frmgame.timerlocation2.Interval = 1400
        frmgame.timerlocation3.Interval = 1400
        FrmPreferences.txttimetoclick.Text = frmgame.timerlocation1.Interval
        GameVariables.squaresize = "Medium"

        square1.Text = frmgame.timerlocation1.Interval
        square2.Text = frmgame.timerlocation1.Interval
        square3.Text = frmgame.timerlocation1.Interval

        circle1.Text = frmgame.timerlocation1.Interval
        circle2.Text = frmgame.timerlocation1.Interval
        circle3.Text = frmgame.timerlocation1.Interval
    End Sub

    Public Shared Sub TimeToClickHard()
        FrmPreferences.btnhard.BringToFront()
        frmgame.timerlocation1.Interval = 900
        frmgame.timerlocation2.Interval = 900
        frmgame.timerlocation3.Interval = 900
        FrmPreferences.txttimetoclick.Text = frmgame.timerlocation1.Interval
        GameVariables.squaresize = "Hard"

        square1.Text = frmgame.timerlocation1.Interval
        square2.Text = frmgame.timerlocation1.Interval
        square3.Text = frmgame.timerlocation1.Interval

        circle1.Text = frmgame.timerlocation1.Interval
        circle2.Text = frmgame.timerlocation1.Interval
        circle3.Text = frmgame.timerlocation1.Interval
    End Sub

    Public Shared Sub TimeToClickExtreme()
        FrmPreferences.btnextreme.BringToFront()
        frmgame.timerlocation1.Interval = 600
        frmgame.timerlocation2.Interval = 600
        frmgame.timerlocation3.Interval = 600
        FrmPreferences.txttimetoclick.Text = frmgame.timerlocation1.Interval
        GameVariables.squaresize = "Extreme"

        square1.Text = frmgame.timerlocation1.Interval
        square2.Text = frmgame.timerlocation1.Interval
        square3.Text = frmgame.timerlocation1.Interval

        circle1.Text = frmgame.timerlocation1.Interval
        circle2.Text = frmgame.timerlocation1.Interval
        circle3.Text = frmgame.timerlocation1.Interval
    End Sub

    Public Shared Sub TimeToClickImposible()
        FrmPreferences.btnimpossible.BringToFront()
        frmgame.timerlocation1.Interval = 400
        frmgame.timerlocation2.Interval = 400
        frmgame.timerlocation3.Interval = 400
        FrmPreferences.txttimetoclick.Text = frmgame.timerlocation1.Interval
        GameVariables.squaresize = "Impossible"

        square1.Text = frmgame.timerlocation1.Interval
        square2.Text = frmgame.timerlocation1.Interval
        square3.Text = frmgame.timerlocation1.Interval

        circle1.Text = frmgame.timerlocation1.Interval
        circle2.Text = frmgame.timerlocation1.Interval
        circle3.Text = frmgame.timerlocation1.Interval
    End Sub

End Class