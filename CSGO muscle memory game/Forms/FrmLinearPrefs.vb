Public Class FrmLinearPrefs

#Region "Load"
    Private Sub FrmLinearPrefs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        frmgame.AddOwnedForm(Me)
        GameVariables.onesquare = True
        Me.BackColor = Color.FromArgb(1, 1, 1)
        Me.TransparencyKey = Me.BackColor

        frmgame.timerlocation2.Stop()
        frmgame.timerlocation3.Stop()

        GameVariables.onesquare = True
    End Sub

    Private Sub FrmLinearPrefs_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Location = New Point(frmgame.picboxbackground.Width - frmhighscores.Width - Me.Width, 30)
        UpdateSettings()
    End Sub
#End Region

#Region "Difficulty buttons"
    Private Sub btnimpossible_Click(sender As Object, e As EventArgs) Handles btnimpossible.Click
        'STARTS EASY DIFFICULTY
        btneasy.BringToFront()
        GameVariables.LinearScalingSpeed = 275
        GameVariables.LinearSizeScaling = 225
        GameVariables.LinearTimeToClickScaling = 250
        GameVariables.MaxShapeSize = 180
        GameVariables.MaxTimeToClick = 2500

        GameVariables.GameDifficulty = 0

        UpdateSettings()
    End Sub

    Private Sub btneasy_Click(sender As Object, e As EventArgs) Handles btneasy.Click
        'STARTS MEDIUM DIFFICULTY
        btnmedium.BringToFront()
        GameVariables.LinearScalingSpeed = 250
        GameVariables.LinearSizeScaling = 200
        GameVariables.LinearTimeToClickScaling = 225
        GameVariables.MaxShapeSize = 160
        GameVariables.MaxTimeToClick = 2250

        GameVariables.GameDifficulty = 1

        UpdateSettings()
    End Sub

    Private Sub btnmedium_Click(sender As Object, e As EventArgs) Handles btnmedium.Click
        'STARTS HARD DIFFICULTY
        btnhard.BringToFront()
        GameVariables.LinearScalingSpeed = 225
        GameVariables.LinearSizeScaling = 175
        GameVariables.LinearTimeToClickScaling = 200
        GameVariables.MaxShapeSize = 140
        GameVariables.MaxTimeToClick = 2000

        GameVariables.GameDifficulty = 2

        UpdateSettings()
    End Sub

    Private Sub btnhard_Click(sender As Object, e As EventArgs) Handles btnhard.Click
        'STARTS EXTREME DIFFICULTY
        btnextreme.BringToFront()
        GameVariables.LinearScalingSpeed = 200
        GameVariables.LinearSizeScaling = 150
        GameVariables.LinearTimeToClickScaling = 175
        GameVariables.MaxShapeSize = 120
        GameVariables.MaxTimeToClick = 1750

        GameVariables.GameDifficulty = 3

        UpdateSettings()
    End Sub

    Private Sub btnextreme_Click(sender As Object, e As EventArgs) Handles btnextreme.Click
        'STARTS IMPOSSIBLE DIFFICULTY
        btnimpossible.BringToFront()
        GameVariables.LinearScalingSpeed = 175
        GameVariables.LinearSizeScaling = 125
        GameVariables.LinearTimeToClickScaling = 150
        GameVariables.MaxShapeSize = 100
        GameVariables.MaxTimeToClick = 1500

        GameVariables.GameDifficulty = 4

        UpdateSettings()
    End Sub

    Private Sub LabelUpdate_Tick(sender As Object, e As EventArgs) Handles LabelUpdate.Tick
        Me.LblShapeSize.Text = square1.Width.ToString
        Me.LblTimeToClick.Text = frmgame.timerlocation1.Interval.ToString
    End Sub
#End Region

#Region "Gamemode buttons"

    Private Sub btnprogressive_Click(sender As Object, e As EventArgs) Handles btnprogressive.Click
        'progress through levels of difficulty
        GameVariables.ReactionMode = True

        btnreaction.BringToFront()
    End Sub

    Private Sub btnreaction_Click(sender As Object, e As EventArgs) Handles btnreaction.Click
        'triggers when mouse over shape and has timelimit

        GameVariables.ReactionMode = False

        btnprogressive.BringToFront()
    End Sub

#End Region

#Region "Checks if timelimit has been reached after interval changes"
    Private Sub CheckForTimeSync_Tick_1(sender As Object, e As EventArgs) Handles CheckForTimeSync.Tick

        FrmPreferences.Hide()

        If GameVariables.Linear = True Then

            If square1.lbltimeleft1.Text = frmgame.timerlocation1.Interval.ToString Then

                GameEvents.LifeLost(1)

                GameEvents.SquareClickChangeLocation1()

            ElseIf square2.lbltimeleft2.Text = frmgame.timerlocation2.Interval.ToString Then

                If (Freeze.FreezeTime.Enabled = False) Then

                    GameEvents.LifeLost(2)

                    If GameVariables.circleenabled = True Then
                        GameEvents.CircleClickChangeLocation2()
                    End If
                    If GameVariables.squareenabled = True Then
                        GameEvents.SquareClickChangeLocation2()
                    End If

                End If

            ElseIf square3.lbltimeleft3.Text = frmgame.timerlocation3.Interval.ToString Then

                If (Freeze.FreezeTime.Enabled = False) Then

                    GameEvents.LifeLost(3)

                    If GameVariables.circleenabled = True Then
                        GameEvents.CircleClickChangeLocation3()
                    End If
                    If GameVariables.squareenabled = True Then
                        GameEvents.SquareClickChangeLocation3()

                    End If
                End If
            End If
        End If

    End Sub
#End Region

#Region "Update Settings"
    Public Sub UpdateSettings()
        square1.Size = New Size(GameVariables.MaxShapeSize, GameVariables.MaxShapeSize)
        square2.Size = New Size(GameVariables.MaxShapeSize, GameVariables.MaxShapeSize)
        square3.Size = New Size(GameVariables.MaxShapeSize, GameVariables.MaxShapeSize)

        circle1.Size = New Size(GameVariables.MaxShapeSize, GameVariables.MaxShapeSize)
        circle2.Size = New Size(GameVariables.MaxShapeSize, GameVariables.MaxShapeSize)
        circle3.Size = New Size(GameVariables.MaxShapeSize, GameVariables.MaxShapeSize)

        frmgame.timerlocation1.Interval = GameVariables.MaxTimeToClick
        frmgame.timerlocation2.Interval = GameVariables.MaxTimeToClick
        frmgame.timerlocation3.Interval = GameVariables.MaxTimeToClick
    End Sub
#End Region

End Class