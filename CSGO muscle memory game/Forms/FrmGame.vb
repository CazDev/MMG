Imports System.Drawing.Drawing2D
Imports System
Imports System.Xml
Imports System.Diagnostics
Imports System.ComponentModel

Public Class frmgame

#Region "Load"
    Private Sub frmgame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GameVariables.GameRunningTime.Start()

        GameEvents.ResetDefaultLayout()

        GameConfig.LoadConfig()

    End Sub

#End Region

#Region "Timer count 1"
    'Calls LifeLost sub  when time runs out for shape1
    Private Sub timerlocation1_Tick(sender As Object, e As EventArgs) Handles timerlocation1.Tick
        If (Freeze.FreezeTime.Enabled = False) Then

            GameEvents.LifeLost(1)

        End If
    End Sub
#End Region

#Region "Timer count 2"
    'Calls LifeLost sub  when time runs out for shape2
    Private Sub timerlocation2_Tick(sender As Object, e As EventArgs) Handles timerlocation2.Tick
        If (Freeze.FreezeTime.Enabled = False) Then

            GameEvents.LifeLost(2)

        End If
    End Sub
#End Region

#Region "Timer count 3"
    'Calls LifeLost sub  when time runs out for shape3
    Private Sub timerlocation3_Tick(sender As Object, e As EventArgs) Handles timerlocation3.Tick
        If (Freeze.FreezeTime.Enabled = False) Then

            GameEvents.LifeLost(3)

        End If
    End Sub
#End Region

#Region "Menu Strip Items"
    'Minimise Menu Strip Item
    Private Sub MinimiseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
        timerlocation1.Stop()
        timerlocation2.Stop()
        timerlocation3.Stop()

        GameVariables.ShapeTimeCount1.Reset()
        GameVariables.ShapeTimeCount2.Reset()
        GameVariables.ShapeTimeCount3.Reset()

        frmhighscores.Hide()
        frmlose.Hide()
        FrmPreferences.Hide()
        frmpanel.Hide()
    End Sub

    'Back To Menu Menu Strip Item
    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        timerlocation1.Stop()
        timerlocation2.Stop()
        timerlocation3.Stop()

        GameVariables.ShapeTimeCount1.Reset()
        GameVariables.ShapeTimeCount2.Reset()
        GameVariables.ShapeTimeCount3.Reset()

        'Hides game and menus
        Me.Hide()
        frmhighscores.Hide()
        frmlose.Hide()
        FrmPreferences.Hide()
        FrmLinearPrefs.Hide()
        frmpanel.Hide()
        circle1.Hide()
        circle2.Hide()
        circle3.Hide()
        frmconsole.Hide()

        'Hides powerups and stops them from showing
        Freeze.Hide()
        lifeup.Hide()

        ShowLifeUp.Stop()
        ShowFreeze.Stop()

        frmmenu.Show()
        frmmenu.BringToFront()

        FrmLinearPrefs.CheckForTimeSync.Stop()
    End Sub

    'Highscore Display Menu Strip Item
    Private Sub HighscoresToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If frmhighscores.Visible = False Then
            frmhighscores.Show()
        Else
            frmhighscores.Hide()
        End If
    End Sub

    'Quick Settings Menu Strip Item
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If FrmPreferences.Visible = False Then
            FrmPreferences.Show()
        Else
            FrmPreferences.Hide()
        End If
    End Sub

    'Bold Font Menu Strip Item
    Private Sub BoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoldToolStripMenuItem.Click
        GameEvents.FontBold()
    End Sub

    'Regular Font Menu Strip Item
    Private Sub RegularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegularToolStripMenuItem.Click
        GameEvents.FontRegular()
    End Sub

    'Open Console Menu Strip Item
    Private Sub OpenConsoleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenConsoleToolStripMenuItem.Click
        GameEvents.OpenConsole()
    End Sub

    'Fullscreen Menu Strip Item
    Private Sub FullscreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullscreenToolStripMenuItem.Click
        GameEvents.FullscreenMode()
    End Sub

    'Windowed mode Menu Strip Item
    Private Sub WindowedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WindowedToolStripMenuItem.Click
        GameEvents.WindowedMode()
    End Sub

    'Banner UI scale buttons
    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        GameVariables.BannerUIScaling = 0.5D
        GameEvents.ScaleUIBanners()
    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem14.Click
        GameVariables.BannerUIScaling = 0.75F
        GameEvents.ScaleUIBanners()
    End Sub

    Private Sub ToolStripMenuItem15_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem15.Click
        GameVariables.BannerUIScaling = 1.0F
        GameEvents.ScaleUIBanners()
    End Sub

    Private Sub ToolStripMenuItem16_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem16.Click
        GameVariables.BannerUIScaling = 1.25F
        GameEvents.ScaleUIBanners()
    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem17.Click
        GameVariables.BannerUIScaling = 1.5F
        GameEvents.ScaleUIBanners()
    End Sub
    'Complex Scoring enable / disable
    Private Sub EnableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnabledToolStripMenuItem.Click
        GameVariables.ComplexScoring = True
    End Sub

    Private Sub DisableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisabledToolStripMenuItem.Click
        GameVariables.ComplexScoring = False
    End Sub
#End Region

#Region "Background click reset"
    'Resets game when background is clicked
    Private Sub picboxbackground_MouseDown(sender As Object, e As MouseEventArgs) Handles picboxbackground.MouseDown
        If GameVariables.Lives < 1 Then

            GameEvents.BackgroundClickReset()
            Me.LivesLeftToolStripMenuItem.Text = GameVariables.MaxLives.ToString

            Me.picboxlifelost.Show()
            Me.picboxlifelost.BringToFront()

            Me.removelifelost.Stop()
            Me.removelifelost.Start()
            GameVariables.Lives = GameVariables.MaxLives
        Else
            GameVariables.Lives -= 1
            LivesLeftToolStripMenuItem.Text = GameVariables.Lives.ToString()

            picboxlifelost.Show()
            picboxlifelost.BringToFront()

            square1.BringToFront()
            square2.BringToFront()
            square3.BringToFront()
            circle1.BringToFront()
            circle2.BringToFront()
            circle3.BringToFront()

            removelifelost.Stop()
            removelifelost.Start()

            'checks if sound is muted or enabled
            If GameVariables.soundfx = True Then
                My.Computer.Audio.Play(My.Resources.fail1, AudioPlayMode.Background)
            End If

        End If
    End Sub
#End Region

#Region "Highscore Background click reset"
    'Reset game when highscore overlay is clicked
    Private Sub picboxhighscore_MouseDown(sender As Object, e As MouseEventArgs) Handles picboxhighscore.MouseDown
        If GameVariables.Lives < 1 Then

            GameEvents.BackgroundClickReset()
            Me.LivesLeftToolStripMenuItem.Text = GameVariables.MaxLives.ToString

            Me.picboxlifelost.Show()
            Me.picboxlifelost.BringToFront()

            Me.removelifelost.Stop()
            Me.removelifelost.Start()
            GameVariables.Lives = GameVariables.MaxLives
        Else
            GameVariables.Lives -= 1
            LivesLeftToolStripMenuItem.Text = GameVariables.Lives.ToString()

            picboxlifelost.Show()
            picboxlifelost.BringToFront()

            square1.BringToFront()
            square2.BringToFront()
            square3.BringToFront()
            circle1.BringToFront()
            circle2.BringToFront()
            circle3.BringToFront()

            removelifelost.Stop()
            removelifelost.Start()

            'checks if sound is muted or enabled
            If GameVariables.soundfx = True Then
                My.Computer.Audio.Play(My.Resources.fail1, AudioPlayMode.Background)
            End If
        End If
    End Sub
#End Region

#Region "Button time left updater"
    Private Sub timeronems_Tick(sender As Object, e As EventArgs) Handles TimeLeftCounter.Tick
        If (Freeze.FreezeTime.Enabled = False) Then

            GameVariables.ShapeTimeCount1.Start()
            GameVariables.ShapeTimeCount2.Start()
            GameVariables.ShapeTimeCount3.Start()

            GameVariables.timeleft1 = GameVariables.ShapeTimeCount1.Elapsed.TotalMilliseconds
            GameVariables.timeleft2 = GameVariables.ShapeTimeCount2.Elapsed.TotalMilliseconds
            GameVariables.timeleft3 = GameVariables.ShapeTimeCount3.Elapsed.TotalMilliseconds

            If GameVariables.timeleft1 >= timerlocation1.Interval - (timerlocation1.Interval * 0.1) Then
                If GameVariables.LagCompensation = True Then
                    'checks if time has ran out
                    'and helps compensates for lag by checking 10% less than interval
                    square1.lbltimeleft1.Text = timerlocation1.Interval
                    square2.lbltimeleft2.Text = timerlocation2.Interval
                    square3.lbltimeleft3.Text = timerlocation3.Interval

                    circle1.lbltimeleft1.Text = timerlocation1.Interval
                    circle2.lbltimeleft2.Text = timerlocation2.Interval
                    circle3.lbltimeleft3.Text = timerlocation3.Interval
                End If
            Else

                'updates counter on shapes
                square1.lbltimeleft1.Text = GameVariables.timeleft1
                square2.lbltimeleft2.Text = GameVariables.timeleft2
                square3.lbltimeleft3.Text = GameVariables.timeleft3

                circle1.lbltimeleft1.Text = GameVariables.timeleft1
                circle2.lbltimeleft2.Text = GameVariables.timeleft2
                circle3.lbltimeleft3.Text = GameVariables.timeleft3

            End If

        End If

    End Sub
#End Region

#Region "Highscore display and sound"
    Private Sub refreshtimer_Tick(sender As Object, e As EventArgs) Handles refreshtimer.Tick

        GameEvents.ShowHighscorePlaySound()

    End Sub
#End Region

#Region "Highscore remove"
    Private Sub removehighscore_Tick(sender As Object, e As EventArgs) Handles removehighscore.Tick

        GameEvents.RemoveHighscoreImage()

    End Sub
#End Region

#Region "Volume change"

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        frmmenusettings.Svol = 0
        frmmenusettings.SetVol()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        frmmenusettings.Svol = 20
        frmmenusettings.SetVol()
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        frmmenusettings.Svol = 40
        frmmenusettings.SetVol()
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        frmmenusettings.Svol = 60
        frmmenusettings.SetVol()
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        frmmenusettings.Svol = 80
        frmmenusettings.SetVol()
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        frmmenusettings.Svol = 100
        frmmenusettings.SetVol()
    End Sub

#End Region

#Region "Music / Sound effect toggles"
    'Music
    Private Sub EnabledToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EnabledToolStripMenuItem1.Click
        'starts background music process and starts process
        Dim p = Process.GetProcessesByName("MMGPlayMusic")
        If p.Count > 0 Then
        Else

            Dim FileBytes() As Byte = My.Resources.MMGPlayMusic
            System.IO.File.WriteAllBytes("MMGPlayMusic.exe", FileBytes)

            Process.Start("MMGPlayMusic.exe")
        End If
        frmmenusettings.chkmusic.Checked = True
    End Sub

    Private Sub DisabledToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DisabledToolStripMenuItem1.Click
        'stops background music process
        Try
            For Each P As Process In System.Diagnostics.Process.GetProcessesByName("MMGPlayMusic")
                P.Kill()
            Next
        Catch
            frmconsole.consoledialog.AppendText(vbNewLine)
            frmconsole.consoledialog.AppendText("Error stopping background music")
        End Try
    End Sub

    'Sound Effects
    Private Sub EnabledToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EnabledToolStripMenuItem2.Click
        GameVariables.soundfx = True
    End Sub

    Private Sub DisabledToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DisabledToolStripMenuItem2.Click
        GameVariables.soundfx = False
    End Sub
#End Region

#Region "Keybind checks"
    'checks if key is being pressed from
    'https://msdn.microsoft.com/en-us/library/system.windows.forms.keyeventargs.aspx#
    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Int32) As Int16

    Private Sub CheckKeyBind_Tick(sender As Object, e As EventArgs) Handles CheckKeyBind.Tick

        'Checks if game is visible
        If Me.Visible Then

            GameVariables.ConsoleBind = GetAsyncKeyState(Keys.C)
            GameVariables.PauseBind = GetAsyncKeyState(Keys.P)

            'Bind for oppening the console
            If GameVariables.ConsoleBind = True Then

                CheckKeyBind.Enabled = False

                GameEvents.OpenConsole()

                GameVariables.ConsoleBind = False

            End If

            'Bind for pausing the game
            If GameVariables.PauseBind = True Then

                If GameVariables.GameStoppedState = False Then
                    'pause game
                    GameVariables.GameStoppedState = True

                    'Stops game timers to "pause" the game
                    Me.timerlocation1.Enabled = False
                    Me.timerlocation2.Enabled = False
                    Me.timerlocation3.Enabled = False

                    GameVariables.powerupenbaled = False

                    ShowLifeUp.Stop()
                    ShowFreeze.Stop()

                    Me.TimeLeftCounter.Enabled = False

                    Me.picboxbackground.Enabled = False

                    If GameVariables.squareenabled = True Then
                        square1.Enabled = False
                        square2.Enabled = False
                        square3.Enabled = False
                    Else
                        circle1.Enabled = False
                        circle2.Enabled = False
                        circle3.Enabled = False
                    End If

                Else

                    'un-pause game
                    GameVariables.GameStoppedState = False

                    'Stops game timers to "un-pause" the game
                    If GameVariables.onesquare Or GameVariables.onecircle Then
                        Me.timerlocation1.Enabled = True
                        Me.timerlocation2.Enabled = False
                        Me.timerlocation3.Enabled = False
                    End If
                    If GameVariables.twosquare Or GameVariables.twocircle Then
                        Me.timerlocation1.Enabled = True
                        Me.timerlocation2.Enabled = True
                        Me.timerlocation3.Enabled = False
                    End If
                    If GameVariables.threesquare Or GameVariables.threecircle Then
                        Me.timerlocation1.Enabled = True
                        Me.timerlocation2.Enabled = True
                        Me.timerlocation3.Enabled = True
                    End If

                    GameVariables.powerupenbaled = True
                    ShowLifeUp.Start()
                    ShowFreeze.Start()

                    Me.TimeLeftCounter.Enabled = True

                    Me.picboxbackground.Enabled = True

                    If GameVariables.squareenabled = True Then
                        square1.Enabled = True
                        square2.Enabled = True
                        square3.Enabled = True
                    Else
                        circle1.Enabled = True
                        circle2.Enabled = True
                        circle3.Enabled = True
                    End If

                End If

                GameVariables.PauseBind = False
            End If
        End If

    End Sub

#End Region

#Region "Remove Life Lost picture box"
    Private Sub removelifelost_Tick(sender As Object, e As EventArgs) Handles removelifelost.Tick
        picboxlifelost.Hide()

        removelifelost.Stop()
    End Sub
#End Region

#Region "Life Lost click reset"
    Private Sub picboxlifelost_MouseDown(sender As Object, e As MouseEventArgs) Handles picboxlifelost.MouseDown
        'Checks if lives is less than 1
        If GameVariables.Lives < 1 Then

            GameEvents.BackgroundClickReset()
            Me.LivesLeftToolStripMenuItem.Text = GameVariables.MaxLives.ToString

            Me.picboxlifelost.Show()
            Me.picboxlifelost.BringToFront()

            Me.removelifelost.Stop()
            Me.removelifelost.Start()
            GameVariables.Lives = GameVariables.MaxLives
        Else
            GameVariables.Lives -= 1
            LivesLeftToolStripMenuItem.Text = GameVariables.Lives.ToString()

            picboxlifelost.Show()
            picboxlifelost.BringToFront()

            square1.BringToFront()
            square2.BringToFront()
            square3.BringToFront()
            circle1.BringToFront()
            circle2.BringToFront()
            circle3.BringToFront()

            removelifelost.Stop()
            removelifelost.Start()

            'checks if sound is muted or enabled
            If GameVariables.soundfx = True Then
                My.Computer.Audio.Play(My.Resources.fail1, AudioPlayMode.Background)
            End If
        End If
    End Sub
#End Region

#Region "Updates UI with window movement and resizing"
    Private Sub frmgame_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        Try
            If GameVariables.WindowedMode = True Then
                GameEvents.FitUIToScreen()
            End If
        Catch
            frmconsole.consoledialog.AppendText(vbNewLine)
            frmconsole.consoledialog.AppendText("Error while moving game in windowed mode")
        End Try
    End Sub

    Private Sub frmgame_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Try
            If GameVariables.WindowedMode = True Then
                GameEvents.FitUIToScreen()
            End If
        Catch
            frmconsole.consoledialog.AppendText(vbNewLine)
            frmconsole.consoledialog.AppendText("Error while moving game in windowed mode")
        End Try
    End Sub

    Public Shared Sub FullscreenUIUpdate()
        Try
            frmgame.Location = New Point(0, 0)

            frmpanel.Size = New Size(frmgame.Width - 20, frmhighscores.Height)
            frmpanel.Location = New Point(frmgame.Right + 10 - frmgame.Width, frmgame.Top + 30)

            FrmPreferences.Size = New Size(frmgame.Width, frmhighscores.Height)

            FrmPreferences.Location = New Point(frmgame.Right - frmgame.Width - 200, frmgame.Top + 30)
            frmhighscores.Location = New Point(frmgame.Right - frmhighscores.Width, frmgame.Top + 30)

            frmgame.picboxhighscore.Size = New Size((frmgame.picboxhighscore.Parent.ClientSize.Width / 2) * GameVariables.BannerUIScaling, (frmgame.picboxhighscore.Parent.ClientSize.Height / 2) * GameVariables.BannerUIScaling)
            frmgame.picboxhighscore.Location = New Point((frmgame.picboxhighscore.Parent.ClientSize.Width / 2) - (frmgame.picboxhighscore.Width / 2),
                                  (frmgame.picboxhighscore.Parent.ClientSize.Height / 2) - (frmgame.picboxhighscore.Height / 2))

            frmgame.picboxlifelost.Size = New Size((frmgame.picboxlifelost.Parent.ClientSize.Width / 2) * GameVariables.BannerUIScaling, (frmgame.picboxlifelost.Parent.ClientSize.Height / 2) * GameVariables.BannerUIScaling)
            frmgame.picboxlifelost.Location = New Point((frmgame.picboxlifelost.Parent.ClientSize.Width / 2) - (frmgame.picboxlifelost.Width / 2),
                                  (frmgame.picboxlifelost.Parent.ClientSize.Height / 2) - (frmgame.picboxlifelost.Height / 2))

            frmlose.Location = New Size(frmpanel.Left + frmgame.Width / 2 - frmlose.Width / 2, frmpanel.Top + frmgame.Height / 2 - frmlose.Height)

        Catch
            frmconsole.consoledialog.AppendText(vbNewLine)
            frmconsole.consoledialog.AppendText("Error while resizing in windowed mode")
        End Try
    End Sub
#End Region

#Region "Power-Ups"

    Private Sub ShowFreeze_Tick(sender As Object, e As EventArgs) Handles ShowFreeze.Tick
        Freeze.Opacity = 1.0
        Freeze.Show()
        Freeze.FreezeDecay.Start()
        Freeze.BringToFront()

        Freeze.Opacity = 1.0
        Freeze.Show()
        Freeze.FreezeDecay.Start()
        Freeze.BringToFront()

        Dim sizex As Integer = Me.picboxbackground.Size.Width - 190
        Dim sizey As Integer = Me.picboxbackground.Size.Height - 190
        Dim xpoint As Integer = CInt(Int((sizex * Rnd()) + 40))
        Dim ypoint As Integer = CInt(Int((sizey * Rnd()) + 40))
        Freeze.Location = New Point(xpoint, ypoint)

        'generates new timer interval between LifeUpRate (30 seconds) and 5 seconds
        Me.ShowFreeze.Interval = CInt(Int((GameVariables.poweruprate * Rnd()) + 10000))

    End Sub

    Private Sub ShowLifeUp_Tick(sender As Object, e As EventArgs) Handles ShowLifeUp.Tick

        lifeup.Opacity = 1.0
        lifeup.Show()
        lifeup.LifeupDecay.Start()
        lifeup.BringToFront()

        lifeup.Opacity = 1.0
        lifeup.Show()
        lifeup.LifeupDecay.Start()
        lifeup.BringToFront()

        Dim sizex As Integer = Me.picboxbackground.Size.Width - 190
        Dim sizey As Integer = Me.picboxbackground.Size.Height - 190
        Dim xpoint As Integer = CInt(Int((sizex * Rnd()) + 40))
        Dim ypoint As Integer = CInt(Int((sizey * Rnd()) + 40))
        lifeup.Location = New Point(xpoint, ypoint)

        'generates new timer interval between LifeUpRate (30 seconds) and 5 seconds
        Me.ShowLifeUp.Interval = CInt(Int((GameVariables.poweruprate * Rnd()) + 15000))

    End Sub
#End Region

#Region "Lienar Mode Timers"
    Private Sub LinearMode_Tick(sender As Object, e As EventArgs) Handles LinearMode.Tick
        If GameVariables.Linear = True Then
            LinearMode.Interval -= Math.Pow(LinearMode.Interval / GameVariables.LinearScalingSpeed, 2)

            Dim size As Integer
            size = square1.Width
            size -= Math.Pow(square1.Width / GameVariables.LinearSizeScaling, 2)
            square1.Size = New Size(size, size)
            square2.Size = New Size(size, size)
            square3.Size = New Size(size, size)

            timerlocation1.Interval -= Math.Pow(timerlocation1.Interval / GameVariables.LinearTimeToClickScaling, 2)
            timerlocation2.Interval -= Math.Pow(timerlocation2.Interval / GameVariables.LinearTimeToClickScaling, 2)
            timerlocation3.Interval -= Math.Pow(timerlocation3.Interval / GameVariables.LinearTimeToClickScaling, 2)

            GameVariables.ProgressCount += 1

            DifficultyShapeDisplay()

        End If
    End Sub
#End Region

#Region "Display shapes based on progress and difficulty"
    Public Sub DifficultyShapeDisplay()
        Select Case GameVariables.GameDifficulty

            Case 0
                If GameVariables.squareenabled = True Then
                    If GameVariables.ProgressCount = 20 Then
                        timerlocation2.Start()
                        square2.Show()
                        GameVariables.twosquare = True
                        GameEvents.SquareClickChangeLocation2()
                    End If
                    If GameVariables.ProgressCount = 40 Then
                        timerlocation3.Start()
                        square3.Show()
                        GameVariables.threesquare = True
                        GameEvents.SquareClickChangeLocation3()
                    End If
                Else
                    If GameVariables.ProgressCount = 20 Then
                        timerlocation2.Start()
                        circle2.Show()
                        GameVariables.twocircle = True
                        GameEvents.SquareClickChangeLocation2()
                    End If
                    If GameVariables.ProgressCount = 40 Then
                        timerlocation3.Start()
                        circle3.Show()
                        GameVariables.threecircle = True
                        GameEvents.SquareClickChangeLocation3()
                    End If
                End If

            Case 1
                If GameVariables.squareenabled = True Then
                    If GameVariables.ProgressCount = 15 Then
                        timerlocation2.Start()
                        square2.Show()
                        GameVariables.twosquare = True
                        GameEvents.SquareClickChangeLocation2()
                    End If
                    If GameVariables.ProgressCount = 30 Then
                        timerlocation3.Start()
                        square3.Show()
                        GameVariables.threesquare = True
                        GameEvents.SquareClickChangeLocation3()
                    End If
                Else
                    If GameVariables.ProgressCount = 15 Then
                        timerlocation2.Start()
                        circle2.Show()
                        GameVariables.twocircle = True
                        GameEvents.SquareClickChangeLocation2()
                    End If
                    If GameVariables.ProgressCount = 30 Then
                        timerlocation3.Start()
                        circle3.Show()
                        GameVariables.threecircle = True
                        GameEvents.SquareClickChangeLocation3()
                    End If
                End If

            Case 2
                If GameVariables.squareenabled = True Then
                    If GameVariables.ProgressCount = 10 Then
                        timerlocation2.Start()
                        square2.Show()
                        GameVariables.twosquare = True
                        GameEvents.SquareClickChangeLocation2()
                    End If
                    If GameVariables.ProgressCount = 25 Then
                        timerlocation3.Start()
                        square3.Show()
                        GameVariables.threesquare = True
                        GameEvents.SquareClickChangeLocation3()
                    End If
                Else
                    If GameVariables.ProgressCount = 10 Then
                        timerlocation2.Start()
                        circle2.Show()
                        GameVariables.twocircle = True
                        GameEvents.SquareClickChangeLocation2()
                    End If
                    If GameVariables.ProgressCount = 25 Then
                        timerlocation3.Start()
                        circle3.Show()
                        GameVariables.threecircle = True
                        GameEvents.SquareClickChangeLocation3()
                    End If
                End If

            Case 3
                If GameVariables.squareenabled = True Then
                    If GameVariables.ProgressCount = 5 Then
                        timerlocation2.Start()
                        square2.Show()
                        GameVariables.twosquare = True
                        GameEvents.SquareClickChangeLocation2()
                    End If
                    If GameVariables.ProgressCount = 15 Then
                        timerlocation3.Start()
                        square3.Show()
                        GameVariables.threesquare = True
                        GameEvents.SquareClickChangeLocation3()
                    End If
                Else
                    If GameVariables.ProgressCount = 5 Then
                        timerlocation2.Start()
                        circle2.Show()
                        GameVariables.twocircle = True
                        GameEvents.SquareClickChangeLocation2()
                    End If
                    If GameVariables.ProgressCount = 15 Then
                        timerlocation3.Start()
                        circle3.Show()
                        GameVariables.threecircle = True
                        GameEvents.SquareClickChangeLocation3()
                    End If
                End If

            Case 4
                If GameVariables.squareenabled = True Then
                    If GameVariables.ProgressCount = 3 Then
                        timerlocation2.Start()
                        square2.Show()
                        GameVariables.twosquare = True
                        GameEvents.SquareClickChangeLocation2()
                    End If
                    If GameVariables.ProgressCount = 10 Then
                        timerlocation3.Start()
                        square3.Show()
                        GameVariables.threesquare = True
                        GameEvents.SquareClickChangeLocation3()
                    End If
                Else
                    If GameVariables.ProgressCount = 3 Then
                        timerlocation2.Start()
                        circle2.Show()
                        GameVariables.twocircle = True
                        GameEvents.SquareClickChangeLocation2()
                    End If
                    If GameVariables.ProgressCount = 10 Then
                        timerlocation3.Start()
                        circle3.Show()
                        GameVariables.threecircle = True
                        GameEvents.SquareClickChangeLocation3()
                    End If
                End If

        End Select
    End Sub
#End Region

#Region "Initialises new renderer class"
    'Initialises custom colour toolstrip control
    Public Sub New()
        InitializeComponent()
        gamemenu.Renderer = New MenuStipColour()
    End Sub

#End Region

End Class

Public Class MenuStipColour

#Region "Custom toolstrip menu colour class"

    'Asines toolstrip control a custom colour
    Inherits ToolStripProfessionalRenderer

    Protected Overloads Overrides Sub OnRenderMenuItemBackground(ByVal e As ToolStripItemRenderEventArgs)

        Dim rectcol As New Rectangle(Point.Empty, e.Item.Size)
        Dim col As Color = IIf(e.Item.Selected, Color.FromArgb(78, 95, 115), Color.FromArgb(68, 85, 105))

        Using brush As New SolidBrush(col)
            e.Graphics.FillRectangle(brush, rectcol)
        End Using

    End Sub
#End Region

End Class