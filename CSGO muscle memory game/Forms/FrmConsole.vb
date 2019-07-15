Public Class frmconsole

#Region "Commands"
    'Config commands
    '"config-exec"
    '"config-reset"
    '"config-view"
    '"config-edit"
    'Shape commands
    '"shape-size"
    '"shape-type"
    '"shape-colour"
    'Setting commands
    '"sound-fx"
    '"time-to-click"
    'Open screen commands
    '"open-menu"
    '"open-game"
    '"open-howtoplay"
    'Run timer commands
    '"run-time-game"
    '"run-time-instance"
    'Hidden commands
    '"z-aimbot"
    '"z-easter-egg"
#End Region

#Region "Move Form "

    'Borderless move form from:
    'http://www.dreamincode.net/forums/topic/135768-moving-a-borderless-form/

    Public MoveForm As Boolean
    Public MoveForm_MousePosition1 As Point

    'Mouse Down
    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles rect.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            MoveForm_MousePosition1 = e.Location
        End If
    End Sub

    'Mouse Move
    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles rect.MouseMove

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition1)
        End If
    End Sub

    'Mouse Up
    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles rect.MouseUp

        If e.Button = MouseButtons.Left Then
            MoveForm = False
        End If

    End Sub
#End Region

#Region "Split string with single value"
    'Splits string with a single value
    Public Shared Function GetValue(ByVal InputString) As String
        Try
            'String is split into an array using " " between splits
            Dim Result As String() = InputString.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            Return Result(1)
        Catch
            frmconsole.consoledialog.AppendText("Invalid value")
            Return ""
        End Try

    End Function
#End Region

#Region "Split string with multiple values"

    Public MultiValue1 As String
    Public MultiValue2 As String
    Public MultiValue3 As String
    'Gets values from console input and returns 3 strings as output (using the " " space separator)
    Public Function GetMultiValue(ByVal InputString) As Integer

        Dim Result As String() = InputString.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)

        'Checks for amount of values given from input
        If Result.Length = 2 Then

            MultiValue1 = Result(1)
            'Function returns 1 for 1 value
            Return 1

        ElseIf Result.Length = 3 Then

            MultiValue2 = Result(2)
            'Function returns 2 for 2 values
            Return 2

        ElseIf Result.Length = 4 Then

            MultiValue3 = Result(3)
            'Function returns 3 for 3 values
            Return 3

        Else
            'unknown error
            Return -3
        End If

        If Result.Length > 4 Then
            'Function returns 0 for too many values
            Return 0

        ElseIf Result.Length < 2 Then
            'Function returns -1 for no values 
            Return -1
        Else
            'unknown error
            Return -3
        End If

    End Function
#End Region

#Region "Close Form"
    'Close button
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Hide()

        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)

        frmgame.CheckKeyBind.Start()
    End Sub
#End Region

#Region "Console Input"
    Private Sub consoleinput_KeyDown(sender As Object, e As KeyEventArgs) Handles consoleinput.KeyDown
        If e.KeyCode = Keys.Enter Then

            'starts new line in console
            consoledialog.AppendText(vbNewLine)
            consoledialog.AppendText(consoleinput.Text)
            consoledialog.AppendText(vbNewLine)

            'checks if console input matches any commands
            'shape size
            If consoleinput.Text.Contains("shape-size") Then
                If consoleinput.Text = "shape-size" Then
                    'Displays size of shapes
                    consoledialog.AppendText($"Shape size = {square1.Size.ToString}")

                Else

                    Dim size As Integer

                    Try
                        size = GetValue(consoleinput.Text)
                    Catch
                        consoledialog.AppendText("Plese use valid format - shape-size (Number) ")
                    End Try

                    'Sets size of squares
                    If GameVariables.squareenabled = True Then
                        square1.Size = New Size(size, size)
                        square2.Size = New Size(size, size)
                        square3.Size = New Size(size, size)
                    Else
                        'Sets size of circles
                        Using path As New System.Drawing.Drawing2D.GraphicsPath
                            path.AddEllipse(0, 0, size, size)
                            circle1.Region = New Region(path)
                            circle2.Region = New Region(path)
                            circle3.Region = New Region(path)
                        End Using
                    End If
                End If
                'shape size un even
            ElseIf consoleinput.Text.Contains("shape-size-uneven") Then
                If consoleinput.Text = "shape-size-uneven" Then
                    'Displays size of shapes
                    consoledialog.AppendText($"Shape size = {square1.Size.ToString}")

                Else

                    GetMultiValue(consoleinput.Text)

                    If GetMultiValue(consoleinput.Text) = 2 Then

                        Dim size1 As Integer
                        Dim size2 As Integer

                        Try
                            size1 = MultiValue1
                            size2 = MultiValue2
                        Catch
                            consoledialog.AppendText("Plese use valid format - shape-size-uneven (Width Number) (Length Number) ")
                        End Try

                        'Sets size of squares
                        If GameVariables.squareenabled = True Then
                            square1.Size = New Size(size1, size2)
                            square2.Size = New Size(size1, size2)
                            square3.Size = New Size(size1, size2)
                        Else
                            'Sets size of circles
                            Using path As New System.Drawing.Drawing2D.GraphicsPath
                                path.AddEllipse(0, 0, size1, size2)
                                circle1.Region = New Region(path)
                                circle2.Region = New Region(path)
                                circle3.Region = New Region(path)
                            End Using
                        End If

                        'Checks through returns from function and displays error linked to returned value
                    ElseIf GetMultiValue(consoleinput.Text) = 3 Then
                        consoledialog.AppendText("Too many parameters entered, two numbers are required")
                    ElseIf GetMultiValue(consoleinput.Text) = 1 Then
                        consoledialog.AppendText("Only one parameter entered, two numbers are required")
                    ElseIf GetMultiValue(consoleinput.Text) = 0 Then
                        consoledialog.AppendText("Too many parameters entered, two numbers are required")
                    ElseIf GetMultiValue(consoleinput.Text) = -1 Then
                        consoledialog.AppendText("No parameters entered, three parameters are required")
                    End If

                End If
                'shape colour
            ElseIf consoleinput.Text.Contains("shape-colour") Then

                If consoleinput.Text = "shape-colour-rgb" Then

                    consoledialog.AppendText($"Shape Colour = {square1.BackColor.ToString}")

                Else

                    GetMultiValue(consoleinput.Text)

                    If GetMultiValue(consoleinput.Text) = 3 Then

                        'Creats new colour from given values
                        Dim col As Color

                        Try
                            Color.FromArgb(255, MultiValue1, MultiValue2, MultiValue3)
                        Catch ex As Exception
                            consoledialog.AppendText("Plese use valid format - shape-colour-rgb (Red Number) (Green Number) (Blue Number) ")
                        End Try

                        square1.BackColor = col
                        square2.BackColor = col
                        square3.BackColor = col

                        circle1.BackColor = col
                        circle2.BackColor = col
                        circle3.BackColor = col

                        'Checks through returns from function and displays error linked to returned value
                    ElseIf GetMultiValue(consoleinput.Text) = 2 Then
                        consoledialog.AppendText("Only two parameters entered, three numbers are required")
                    ElseIf GetMultiValue(consoleinput.Text) = 1 Then
                        consoledialog.AppendText("Only one parameter entered, three numbers are required")
                    ElseIf GetMultiValue(consoleinput.Text) = 0 Then
                        consoledialog.AppendText("Too many parameters entered, three numbers are required")
                    ElseIf GetMultiValue(consoleinput.Text) = -1 Then
                        consoledialog.AppendText("No parameters entered, three numbers are required")
                    End If

                End If

                'shape type
            ElseIf consoleinput.Text.Contains("shape-type") Then

                If consoleinput.Text = "shape-type" Then

                    If GameVariables.squareenabled = True Then
                        consoledialog.AppendText("Square shape = Square")
                    Else
                        consoledialog.AppendText("Square shape = Circle")
                    End If

                Else

                    If GetValue(consoleinput.Text) = "square" Then
                        GameVariables.squareenabled = True

                        If GameVariables.onesquare Then
                            square1.Show()
                        ElseIf GameVariables.twosquare Then
                            square2.Show()
                        ElseIf GameVariables.threesquare Then
                            square3.Show()
                        End If

                        circle1.Hide()
                        circle2.Hide()
                        circle3.Hide()
                    ElseIf GetValue(consoleinput.Text) = "circle" Then
                        GameVariables.squareenabled = False

                        square1.Hide()
                        square2.Hide()
                        square3.Hide()

                        If GameVariables.onecircle Then
                            circle1.Show()
                        ElseIf GameVariables.twocircle Then
                            circle2.Show()
                        ElseIf GameVariables.threecircle Then
                            circle3.Show()
                        End If
                    Else
                        consoledialog.AppendText("Invalid shape type, expected square or circle")
                    End If

                End If

                'sound effects
            ElseIf consoleinput.Text.Contains("sound-fx") Then

                If consoleinput.Text = "sound-fx" Then
                    consoledialog.AppendText($"Sound effects = {GameVariables.soundfx.ToString()}")

                Else

                    If GetValue(consoleinput.Text) = "t" Then
                        GameVariables.soundfx = True
                    ElseIf GetValue(consoleinput.Text) = "f" Then
                        GameVariables.soundfx = False
                    Else
                        consoledialog.AppendText("Invalid parameter, expected t or f (true or false)")
                    End If

                End If

            ElseIf consoleinput.Text = "run-time-instance" Then
                consoledialog.AppendText($"Instance time elapsed = {frmmenu.InstanceRunningTime.Elapsed}")

            ElseIf consoleinput.Text = "run-time-game" Then
                consoledialog.AppendText($"Game time elapsed = {GameVariables.GameRunningTime.Elapsed}")

            ElseIf consoleinput.Text.Contains("shape-change-colour-onclick") Then

                If consoleinput.Text = "shape-change-colour-onclick" Then
                    consoledialog.AppendText($"Change shape colour on click = {GameVariables.changecolouronclick.ToString}")
                Else

                    If GetValue(consoleinput.Text) = "t" Then
                        GameVariables.changecolouronclick = True
                    ElseIf GetValue(consoleinput.Text) = "f" Then
                        GameVariables.changecolouronclick = False
                    Else
                        consoledialog.AppendText("Invalid parameter, expected t or f (true or false)")
                    End If

                End If
                'background colour
            ElseIf consoleinput.Text.Contains("background-colour") Then

                If consoleinput.Text = "background-colour" Then

                    consoledialog.AppendText($"Background colour = {frmmenu.BackColor.ToString}")

                Else

                    GetMultiValue(consoleinput.Text)

                    If GetMultiValue(consoleinput.Text) = 3 Then

                        Dim col As Color = Color.FromArgb(255, MultiValue1, MultiValue2, MultiValue3)

                        frmmenu.BackColor = col
                        frmhowtoplay.BackColor = col
                        frmmenusettings.BackColor = col

                        'Checks through returns from function and displays error linked to returned value
                    ElseIf GetMultiValue(consoleinput.Text) = 2 Then
                        consoledialog.AppendText("Only two parameters entered, three numbers are required")
                    ElseIf GetMultiValue(consoleinput.Text) = 1 Then
                        consoledialog.AppendText("Only one parameter entered, three numbers are required")
                    ElseIf GetMultiValue(consoleinput.Text) = 0 Then
                        consoledialog.AppendText("Too many parameters entered, three numbers are required")
                    ElseIf GetMultiValue(consoleinput.Text) = -1 Then
                        consoledialog.AppendText("No parameters entered, three numbers are required")
                    End If

                End If
                'Help commands
                'Help all - displays all commands
            ElseIf consoleinput.Text = "help-all" Then
                consoledialog.AppendText("background-colour" & vbNewLine)
                consoledialog.AppendText("config-edit" & vbNewLine)
                consoledialog.AppendText("config-view" & vbNewLine)
                consoledialog.AppendText("config-exec" & vbNewLine)
                consoledialog.AppendText("open-game" & vbNewLine)
                consoledialog.AppendText("open-howtoplay" & vbNewLine)
                consoledialog.AppendText("open-Menu" & vbNewLine)
                consoledialog.AppendText("Reset-all-settings" & vbNewLine)
                consoledialog.AppendText("run-time-game" & vbNewLine)
                consoledialog.AppendText("run-time-instance" & vbNewLine)
                consoledialog.AppendText("shape-change-colour-onclick" & vbNewLine)
                consoledialog.AppendText("shape-colour" & vbNewLine)
                consoledialog.AppendText("shape-colour-rgb" & vbNewLine)
                consoledialog.AppendText("shape-Size" & vbNewLine)
                consoledialog.AppendText("shape-Size-uneven" & vbNewLine)
                consoledialog.AppendText("shape-type" & vbNewLine)
                consoledialog.AppendText("time-to-click" & vbNewLine)
                consoledialog.AppendText("ui-scale-banner")
                'Help (page number)
            ElseIf consoleinput.Text.Contains("help") Then
                If consoleinput.Text = "help" Then
                    consoledialog.AppendText("Plese use valid format - help (Page Number) or use help-all")
                Else
                    GetValue(consoleinput.Text)

                    If GetValue(consoleinput.Text) = 1 Then
                        consoledialog.AppendText("background-colour" & vbNewLine)
                        consoledialog.AppendText("config-edit" & vbNewLine)
                        consoledialog.AppendText("config-view" & vbNewLine)
                        consoledialog.AppendText("config-exec" & vbNewLine)
                        consoledialog.AppendText("open-game" & vbNewLine)
                    End If

                    If GetValue(consoleinput.Text) = 2 Then
                        consoledialog.AppendText("open-howtoplay" & vbNewLine)
                        consoledialog.AppendText("open-Menu" & vbNewLine)
                        consoledialog.AppendText("Reset-all-settings" & vbNewLine)
                        consoledialog.AppendText("run-time-game" & vbNewLine)
                        consoledialog.AppendText("run-time-instance" & vbNewLine)
                    End If

                    If GetValue(consoleinput.Text) = 3 Then
                        consoledialog.AppendText("shape-change-colour-onclick" & vbNewLine)
                        consoledialog.AppendText("shape-colour" & vbNewLine)
                        consoledialog.AppendText("shape-colour-rgb" & vbNewLine)
                        consoledialog.AppendText("shape-Size" & vbNewLine)
                        consoledialog.AppendText("shape-Size-uneven" & vbNewLine)
                    End If

                    If GetValue(consoleinput.Text) = 3 Then
                        consoledialog.AppendText("shape-type" & vbNewLine)
                        consoledialog.AppendText("time-to-click" & vbNewLine)
                        consoledialog.AppendText("ui-scale-banner" & vbNewLine)
                        consoledialog.AppendText("help" & vbNewLine)
                        consoledialog.AppendText("help-all" & vbNewLine)
                    End If
                End If

            ElseIf consoleinput.Text.Contains("time-to-click") Then
                If consoleinput.Text = "time-to-click" Then
                    consoledialog.AppendText(GameVariables.timetoclick)
                Else

                    GetValue(consoleinput.Text)

                    If GetValue(consoleinput.Text) = "easy" Then
                        GameEvents.TimeToClickEasy()
                    ElseIf GetValue(consoleinput.Text) = "medium" Then
                        GameEvents.TimeToClickMedium()
                    ElseIf GetValue(consoleinput.Text) = "hard" Then
                        GameEvents.TimeToClickHard()
                    ElseIf GetValue(consoleinput.Text) = "extreme" Then
                        GameEvents.TimeToClickExtreme()
                    ElseIf GetValue(consoleinput.Text) = "impossible" Then
                        GameEvents.TimeToClickImposible()

                    Else
                        consoledialog.AppendText("Plese use valid format - time-to-click (difficulty)")
                    End If
                End If

                'reset all preferences command
            ElseIf consoleinput.Text = "reset-all-preferences" Then
                GameEvents.ResetAllPreferences()

            ElseIf consoleinput.Text.Contains("UI-Scale-Banner") Then
                If consoleinput.Text = ("UI-Scale-Banner") Then
                    'Showns the value for BannerUIScaling
                    consoledialog.AppendText(GameVariables.BannerUIScaling.ToString())

                Else
                    Try
                        'Sets the value for BannerUIScaling
                        GameVariables.BannerUIScaling = Convert.ToDouble(GetValue(consoleinput.Text)) / 100
                        GameEvents.FitUIToScreen()

                    Catch
                        consoledialog.AppendText("Incorrect Format, please use a number")

                    End Try
                End If

                'Hidden commands:
                'Easter egg command
            ElseIf consoleinput.Text = "z-easter-egg" Then
                ' ;-)
                consoledialog.AppendText("                   _" & vbNewLine)
                consoledialog.AppendText("                   \`\    _" & vbNewLine)
                consoledialog.AppendText("     _________      \ \ /\ \" & vbNewLine)
                consoledialog.AppendText("    |  Hello  |\     \ V /\/       ____" & vbNewLine)
                consoledialog.AppendText("    |_________| \_   /. .\       .'(<>)'." & vbNewLine)
                consoledialog.AppendText("                    =\_T_/=     /.'    '.\" & vbNewLine)
                consoledialog.AppendText("                     /   \      ||-=-=-=||" & vbNewLine)
                consoledialog.AppendText("                    ((   ))     ||=-=-=-||" & vbNewLine)
                consoledialog.AppendText("                    /\) (/\     |-=-=-=-=|" & vbNewLine)
                consoledialog.AppendText("                  __\     / __  \        /" & vbNewLine)
                consoledialog.AppendText("                 (____ /^\ ___)  '------'")

                'Aimbot command
            ElseIf consoleinput.Text.Contains("z-aimbot") Then
                If consoleinput.Text.Contains("z-aimbot-interval") Then
                    Try
                        GetValue(consoleinput.Text)
                        TmrAimbot.Interval = GetValue(consoleinput.Text)
                        consoledialog.AppendText("New interval set")
                    Catch
                        consoledialog.AppendText("Invalid parameter, expected a number")
                    End Try
                Else
                    GetValue(consoleinput.Text)
                    If GetValue(consoleinput.Text) = "t" Then
                        TmrAimbot.Start()
                        consoledialog.AppendText("Aimbot enabled")
                    ElseIf GetValue(consoleinput.Text) = "f" Then
                        TmrAimbot.Stop()
                        consoledialog.AppendText("Aimbot disabled")
                    Else
                        consoledialog.AppendText("Invalid parameter, expected t or f (true or false)")
                    End If
                End If

                'Commands for openning screens
                'Menu
            ElseIf consoleinput.Text = "open-menu" Then
                frmmenu.Height = 50
                frmmenu.Show()
                frmmenu.BringToFront()
                frmmenu.expanding = True
                frmmenu.expand.Enabled = True
                consoledialog.AppendText("opening menu...")

                'How to play
            ElseIf consoleinput.Text = "open-howtoplay" Then
                frmhowtoplay.Show()
                frmhowtoplay.BringToFront()
                frmhowtoplay.expanding = True
                frmhowtoplay.expand.Enabled = True
                consoledialog.AppendText("opening how to play...")

                'Game
            ElseIf consoleinput.Text = "open-game" Then
                frmgame.Show()
                frmpanel.Show()
                FrmPreferences.Show()
                frmhighscores.Show()
                square1.Show()
                square1.BringToFront()
                consoledialog.AppendText("opening game...")

                'Config related commands
                'execute config
            ElseIf consoleinput.Text = "config-exec" Then
                consoledialog.AppendText("Loading Config...")
                GameConfig.LoadConfig()
                consoledialog.AppendText(vbNewLine)
                consoledialog.AppendText("Config Loaded")
                'reset config
            ElseIf consoleinput.Text = "config-reset" Then
                GameConfig.ResetConfig()
                consoledialog.AppendText(vbNewLine)
                consoledialog.AppendText("Config Reset")
                'view config
            ElseIf consoleinput.Text = "config-view" Then
                'Updates config from text file into array
                GameConfig.ReadConfigToArray()

                consoledialog.AppendText(vbNewLine)

                consoledialog.AppendText("Line Number" & "  " & "Contents of line" & vbNewLine)
                'Reads the config as array line by line
                Dim count As Integer = 0
                For Each item As String In GameVariables.ConfigArray
                    consoledialog.AppendText($" {count}.          " & item & vbNewLine)
                    count += 1
                Next
                'edit config
            ElseIf consoleinput.Text.Contains("config-edit") Then

                GetMultiValue(consoleinput.Text)

                If GetMultiValue(consoleinput.Text) = 2 Then

                    Dim LineNum As Integer = MultiValue1
                    Dim Setting As String = MultiValue2

                    Try
                        GameConfig.WriteToConfig(LineNum, Setting)
                        consoledialog.AppendText("Config file changed")
                    Catch
                        consoledialog.AppendText("Plese use valid format - config-edit (LineNumber) (Contents of line) ")
                    End Try

                ElseIf GetMultiValue(consoleinput.Text) < 5 Then
                    'Checks through returns from function and displays error linked to returned value
                ElseIf GetMultiValue(consoleinput.Text) = 2 Then
                    consoledialog.AppendText("Only two parameters entered, two parameters required")
                ElseIf GetMultiValue(consoleinput.Text) = 1 Then
                    consoledialog.AppendText("Only one parameter entered, two parameters required")
                ElseIf GetMultiValue(consoleinput.Text) = 0 Then
                    consoledialog.AppendText("Too many parameters entered, two parameters are required")
                ElseIf GetMultiValue(consoleinput.Text) = -1 Then
                    consoledialog.AppendText("No parameters entered, two parameters are required")
                End If
            ElseIf consoleinput.Text = "clear" Then
                consoledialog.Text = ""

                'returns "Unknown command" if there is no matching commands
            Else
                consoledialog.AppendText("Unknown command")
            End If

            'reset console input to blank
            consoleinput.Text = ""
            e.SuppressKeyPress = True

            consoledialog.AppendText(vbNewLine)
        End If
    End Sub
#End Region

#Region "AutoComplete"

    'Variation of this code:
    'https://support.microsoft.com/en-ph/help/320107/how-to-provide-automatic-text-completion-for-a-combobox-control-in-visual-basic-.net-or-in-visual-basic-2005

    Private Sub consoleinput_KeyUp(sender As Object, e As KeyEventArgs) Handles consoleinput.KeyUp
        Dim index As Integer
        Dim actual As String

        ' Do nothing for some keys such as navigation keys.
        If ((e.KeyCode = Keys.Back) Or
            (e.KeyCode = Keys.Left) Or
            (e.KeyCode = Keys.Right) Or
            (e.KeyCode = Keys.Up) Or
            (e.KeyCode = Keys.Delete) Or
            (e.KeyCode = Keys.Down) Or
            (e.KeyCode = Keys.PageUp) Or
            (e.KeyCode = Keys.PageDown) Or
            (e.KeyCode = Keys.Home) Or
            (e.KeyCode = Keys.End)) Then

            Return
        End If

        ' Store the actual text that has been typed.
        actual = Me.consoleinput.Text

        ' Find the first match for the typed value.
        index = Me.consoleinput.FindString(actual)
    End Sub

    Private Sub consoledialog_TextChanged(sender As Object, e As EventArgs) Handles consoledialog.TextChanged
        'Scrolls console to bottom of richtextbox (consoledialog)
        consoledialog.ScrollToCaret()
    End Sub

    Private Sub consoleinput_TextChanged(sender As Object, e As EventArgs) Handles consoleinput.TextUpdate
        'Ensures input combobox is always dropped down when selected / focused
        consoleinput.DroppedDown = True
    End Sub

    Private Sub consoleinput_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles consoleinput.GotFocus
        'Ensures input combobox is always dropped down when selected / focused
        consoleinput.DroppedDown = True
    End Sub

#End Region

#Region "Aimbot"
    Private Sub TmrAimbot_Tick(sender As Object, e As EventArgs) Handles TmrAimbot.Tick
        If GameVariables.onesquare Then
            GameEvents.SquareClickChangeLocation1()
        ElseIf GameVariables.twosquare Then
            GameEvents.CircleClickChangeLocation1()
            GameEvents.SquareClickChangeLocation2()
        ElseIf GameVariables.threesquare Then
            GameEvents.CircleClickChangeLocation1()
            GameEvents.CircleClickChangeLocation2()
            GameEvents.SquareClickChangeLocation3()
        End If

        If GameVariables.onecircle Then
            GameEvents.CircleClickChangeLocation1()
        ElseIf GameVariables.twocircle Then
            GameEvents.CircleClickChangeLocation1()
            GameEvents.CircleClickChangeLocation2()
        ElseIf GameVariables.threecircle Then
            GameEvents.CircleClickChangeLocation1()
            GameEvents.CircleClickChangeLocation2()
            GameEvents.CircleClickChangeLocation3()
        End If
    End Sub
#End Region

End Class