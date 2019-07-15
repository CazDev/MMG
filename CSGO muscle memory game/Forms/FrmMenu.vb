Imports System.Drawing
Imports System.Threading
Imports System.Diagnostics
Imports System.ComponentModel
Imports System.IO

Public Class frmmenu

#Region "Variables"
    Public expanding As Boolean = True
    Public expandingbtnplay As Boolean = True
    Public expandingbtnside As Boolean = True
    Public closeexpandingh2p As Boolean = False
    Public closeexpandingsetting As Boolean = False

    Public nextbtn1 As Boolean = False
    Public nextbtn2 As Boolean = False
    Public nextbtn3 As Boolean = False

    Public InstanceRunningTime As New Stopwatch()
#End Region

#Region "Move Form"
    'Borderless move form from:
    'http://www.dreamincode.net/forums/topic/135768-moving-a-borderless-form/

    Public MoveForm1 As Boolean
    Public MoveForm1_MousePosition1 As Point

    Public Sub MoveForm1_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    rect.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm1 = True
            MoveForm1_MousePosition1 = e.Location
        End If
    End Sub

    Public Sub MoveForm1_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    rect.MouseMove

        If MoveForm1 Then
            Me.Location = Me.Location + (e.Location - MoveForm1_MousePosition1)
        End If
    End Sub

    Public Sub MoveForm1_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    rect.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm1 = False
        End If
    End Sub
#End Region

#Region "close, minimise, play buttons"
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click

        If GameVariables.soundfx = True Then
            My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        End If

        System.Threading.Thread.Sleep(100)

        For Each P As Process In System.Diagnostics.Process.GetProcessesByName("MMGPlayMusic")
            P.Kill()
        Next

        Me.Close()
    End Sub

    Private Sub btnminimise_Click(sender As Object, e As EventArgs) Handles btnminimise.Click
        Me.WindowState = FormWindowState.Minimized

        If GameVariables.soundfx = True Then
            My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub btnplay_Click(sender As Object, e As EventArgs) Handles btnplay.Click
        btnplaycloseexpand.Enabled = True
        btnlinear.Height = 0
        btnfree.Height = 0

        If GameVariables.soundfx = True Then
            My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        End If
    End Sub
#End Region

#Region "Background square location"
    Private Sub timerlocation1_Tick(sender As Object, e As EventArgs) Handles timerlocationmenu1.Tick
        Randomize()
        Dim randint As Integer = CInt(Int((400 * Rnd()) + 100))
        Dim sizex As Integer = picboxmenu.Size.Width - 140
        Dim sizey As Integer = picboxmenu.Size.Height - 140
        Dim xpoint As Integer = CInt(Int((sizex * Rnd()) + 40))
        Dim ypoint As Integer = CInt(Int((sizey * Rnd()) + 40))

        btnpressmenu2.Location = New Point(xpoint, ypoint)
        timerlocationmenu1.Interval = randint

        Dim rnd1 As New Random
        Dim rndcol1 = Color.FromArgb(&HF0000000 Or rnd1.Next(&HFFFFFF + 1))
        Me.btnpressmenu1.BackColor = rndcol1
    End Sub

    Private Sub timerlocationmenu2_Tick(sender As Object, e As EventArgs) Handles timerlocationmenu2.Tick
        Randomize()

        Dim randint As Integer = CInt(Int((400 * Rnd()) + 100))
        Dim sizex As Integer = picboxmenu.Size.Width - 140
        Dim sizey As Integer = picboxmenu.Size.Height - 140
        Dim xpoint As Integer = CInt(Int((sizex * Rnd()) + 40))
        Dim ypoint As Integer = CInt(Int((sizey * Rnd()) + 40))

        btnpressmenu1.Location = New Point(xpoint, ypoint)
        timerlocationmenu2.Interval = randint

        Dim rnd2 As New Random
        Dim rndcol2 = Color.FromArgb(&HF0000000 Or rnd2.Next(&HFFFFFF + 1))
        Me.btnpressmenu2.BackColor = rndcol2
    End Sub

    Private Sub timerlocationmenu3_Tick(sender As Object, e As EventArgs) Handles timerlocationmenu3.Tick
        Randomize()
        Dim randint As Integer = CInt(Int((400 * Rnd()) + 100))
        Dim sizex As Integer = picboxmenu.Size.Width - 140
        Dim sizey As Integer = picboxmenu.Size.Height - 140
        Dim xpoint As Integer = CInt(Int((sizex * Rnd()) + 40))
        Dim ypoint As Integer = CInt(Int((sizey * Rnd()) + 40))

        btnpressmenu3.Location = New Point(xpoint, ypoint)
        timerlocationmenu3.Interval = randint

        Dim rnd3 As New Random
        Dim rndcol3 = Color.FromArgb(&HF0000000 Or rnd3.Next(&HFFFFFF + 1))
        Me.btnpressmenu3.BackColor = rndcol3
    End Sub
#End Region

#Region "How to play and settings buttons"
    Private Sub btnhowtoplay_Click(sender As Object, e As EventArgs) Handles btnhowtoplay.Click
        expandclosehowtoplay.Enabled = True
        closeexpandingh2p = True
        btnlinear.Hide()
        btnfree.Hide()

        If GameVariables.soundfx = True Then
            My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub btnsettings_Click(sender As Object, e As EventArgs) Handles btnsettings.Click
        expandclosesetting.Enabled = True
        closeexpandingsetting = True
        btnlinear.Hide()
        btnfree.Hide()
        frmmenusettings.Show()
        If GameVariables.soundfx = True Then
            My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        End If
    End Sub
#End Region

#Region "Load"
    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InstanceRunningTime.Start()

        expand.Enabled = True
        Me.Height = 50
        btnplay.Height = 0
        btnsettings.Height = 0
        btnhowtoplay.Height = 0

        Me.btnlinear.Hide()
        Me.btnfree.Hide()
        Me.btnfree.Height = 0
        Me.btnlinear.Height = 0

        GameConfig.LoadConfig()

        FrmPreferences.Hide()
        frmpanel.Hide()
        frmhighscores.Hide()
    End Sub
#End Region

#Region "Main form Expand/Close"
    Private Sub expand_Tick(sender As Object, e As EventArgs) Handles expand.Tick
        'Used IF statements because do while
        'With System.threads.thread.sleep(1) was very buggy with moving objects
        If expanding = True Then
            Me.Height += 20
        End If

        If Me.Size.Height = 210 Then
            expanding = False
            frmhowtoplay.Hide()

            If btnplay.Height = 140 Then
                expandingbtnplay = False
                expand.Enabled = False
            End If

            If expandingbtnplay = True Then
                btnplay.Height += 20
            End If

            If btnsettings.Height = 80 Then
                expandingbtnside = False
            End If

            If expandingbtnside = True Then
                btnsettings.Height += 20
                btnhowtoplay.Height += 20
            End If

        End If
    End Sub

    Private Sub expandclose_Tick(sender As Object, e As EventArgs) Handles expandclosehowtoplay.Tick
        'checks if this form has finished expanding
        If Me.Size.Height = 50 Then
            frmhowtoplay.Size = Me.Size
            frmhowtoplay.Location = Me.Location
            frmhowtoplay.Height = 50
            frmhowtoplay.Show()
            frmhowtoplay.expand.Enabled = True
            frmhowtoplay.expanding = True
            closeexpandingh2p = False
            expandclosehowtoplay.Enabled = False
            btnplay.Show()
            btnsettings.Show()
            btnhowtoplay.Show()
        End If
        'keeps expanding this form
        If closeexpandingh2p = True Then
            Me.Height -= 20
            btnplay.Hide()
            btnsettings.Hide()
            btnhowtoplay.Hide()
        End If
    End Sub
#End Region

#Region "Close main form into settings"

    Private Sub expandclosesetting_Tick(sender As Object, e As EventArgs) Handles expandclosesetting.Tick
        'checks if close expand has finsihed if it has then starts expand on frmmenusettings
        If Me.Size.Height = 50 Then
            frmmenusettings.Size = Me.Size
            frmmenusettings.Location = Me.Location
            frmmenusettings.Height = 50
            frmmenusettings.Show()
            frmmenusettings.expand.Enabled = True
            frmmenusettings.expanding = True
            expandclosesetting.Enabled = False
            closeexpandingsetting = False
            btnplay.Show()
            btnsettings.Show()
            btnhowtoplay.Show()
        End If

        If closeexpandingsetting = True Then
            Me.Height -= 20
            btnplay.Hide()
            btnsettings.Hide()
            btnhowtoplay.Hide()
        End If
    End Sub

#End Region

#Region "Free and Linear mode buttons"
    Private Sub btnfree_Click(sender As Object, e As EventArgs) Handles btnfree.Click
        'loads free game-mode

        GameVariables.Linear = False

        Me.Hide()
        frmgame.Show()
        frmpanel.Show()
        FrmPreferences.Show()
        frmhighscores.Show()

        square1.Show()
        square1.BringToFront()
        square2.BringToFront()
        square3.BringToFront()
        circle1.BringToFront()
        circle2.BringToFront()
        circle3.BringToFront()

        If GameVariables.soundfx = True Then
            My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        End If

    End Sub

    Private Sub btnlinear_Click(sender As Object, e As EventArgs) Handles btnlinear.Click
        'loads linear game-mode

        Dim Result As DialogResult

        Result = MessageBox.Show(Me, "This gamemode is extremely buggy as it is not yet complete", "Warning:", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

        ' Gets the result of the MessageBox display.
        If Result = System.Windows.Forms.DialogResult.OK Then
            GameVariables.Linear = True

            Me.Hide()
            frmgame.Show()
            frmpanel.Show()
            FrmLinearPrefs.Show()
            frmhighscores.Show()

            square1.Show()
            square1.BringToFront()
            square2.BringToFront()
            square3.BringToFront()
            circle1.BringToFront()
            circle2.BringToFront()
            circle3.BringToFront()

            If GameVariables.soundfx = True Then
                My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
            End If

        End If
    End Sub
#End Region

#Region "Close expand play button"
    Private Sub btnplaycloseexpand_Tick(sender As Object, e As EventArgs) Handles btnplaycloseexpand.Tick
        If btnplay.Height = 0 Then
            'checks if button has finished expanding
            btnlinearfreeexpand.Enabled = True
            btnlinear.Show()
            btnfree.Show()
            nextbtn1 = True
            btnplaycloseexpand.Enabled = False
            'else not finsihed expanding then keeps expanding
        Else
            btnplay.Height -= 20
        End If
    End Sub
#End Region

#Region "Expand Linear and Free mode buttons"
    Private Sub btnlinearfreeexpand_Tick(sender As Object, e As EventArgs) Handles btnlinearfreeexpand.Tick
        'checks if buttons have finished expanding
        If btnlinear.Height = 60 Then
            btnlinearfreeexpand.Enabled = False
            btnlinear.Show()
            btnfree.Show()
            nextbtn1 = True
            'else not finsihed expanding then keeps expanding
        Else
            btnlinear.Height += 20
            btnfree.Height += 20
        End If
    End Sub
#End Region

#Region "Form Closing"
    Private Sub frmmenu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'stops background music process
        Try
            For Each P As Process In System.Diagnostics.Process.GetProcessesByName("MMGPlayMusic")
                P.Kill()
            Next
        Catch
            frmconsole.consoledialog.AppendText(vbNewLine)
            frmconsole.consoledialog.AppendText("Error stopping background music")
        End Try

        Environment.Exit(0)
    End Sub

#End Region

End Class