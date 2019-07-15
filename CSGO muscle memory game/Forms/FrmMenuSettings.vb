Imports CoreAudio

Public Class frmmenusettings

#Region "Variables"
    'stores current resolution setting
    Public resX As Integer = 1920
    Public resY As Integer = 1920
    Public expanding As Boolean = True
    Public closeexpanding As Boolean

    'integer used to store current volume
    Public Svol As Integer = 0
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

#Region "Scrollbar change value"
    Private Sub VScrollBar_ValueChanged(sender As Object, e As EventArgs) Handles VScrollBar.ValueChanged

        'Changes panel's vertical location based on scrollbar value
        '32 is added at the end of the vertical value so the panel stays below top bar and close button (acts as a margin)
        '12 is kept constant as it is the horizontal value

        panelsettings.Location = New Point(12, -VScrollBar.Value + 32)

    End Sub
#End Region

#Region "Load"
    Private Sub frmmenusettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets values ready for start of animation
        Me.Size = New Size(700, 50)
        Me.Location = frmmenu.Location

        'sets volume slider to current system volume
        HScrollBarVolume.Value = GetVol()
        lblvolume.Text = GetVol()
    End Sub
#End Region

#Region "Close Expand Animation"
    Private Sub expandclose_Tick(sender As Object, e As EventArgs) Handles expandclose.Tick

        'checks if form close expand has finished if it has then starts expand on frmmenu (menu form)
        If Me.Size.Height = 50 Then
            frmmenu.Height = 50
            frmmenu.btnplay.Height = 0
            frmmenu.btnsettings.Height = 0
            frmmenu.btnhowtoplay.Height = 0
            frmmenu.expandingbtnplay = True
            frmmenu.expandingbtnside = True
            frmmenu.expand.Enabled = True
            frmmenu.expanding = True
            frmmenu.Show()
            frmgame.BringToFront()
            closeexpanding = False
            expandclose.Enabled = False
            Me.Hide()
            frmmenu.Location = Me.Location

        Else

            'if not finished expanding then keep expanding
            closeexpanding = True
            Me.Height -= 20
        End If

    End Sub
#End Region

#Region "Expand Animation"
    Private Sub expand_Tick(sender As Object, e As EventArgs) Handles expand.Tick

        'checks if form has finished expanding
        If Me.Size.Height = 270 Then
            expanding = False
            frmmenu.Hide()
            expand.Enabled = False

        Else

            'if not finished expanding then keep expanding
            expanding = True
            Me.Height += 20
        End If

    End Sub
#End Region

#Region "Close Form"

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click

        'starts close expand animation
        expandclose.Enabled = True
        closeexpanding = True

        If GameVariables.soundfx = True Then
            My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        End If

    End Sub

#End Region

#Region "Volume Horizontal ScrollBar"
    Private Sub HScrollBarVolume_ValueChanged(sender As Object, e As EventArgs) Handles HScrollBarVolume.ValueChanged
        lblvolume.Text = HScrollBarVolume.Value

        Svol = Val(HScrollBarVolume.Value)             ' Get the required value
        If Svol < 0 Then Svol = 0              ' Ensure it's within limits
        If Svol > 100 Then Svol = 100
        HScrollBarVolume.Value = Svol.ToString       ' Echo the level back into TextBox1
        SetVol()                                       ' Call the subroutine.
    End Sub
#End Region

#Region "Close Console"
    Private Sub btnconsole_Click(sender As Object, e As EventArgs) Handles btnconsole.Click

        GameEvents.OpenConsole()

        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)

    End Sub
#End Region

#Region "Background Music CheckBox"
    Private Sub chkmusic_OnChange(sender As Object, e As EventArgs) Handles chkmusic.OnChange
        If chkmusic.Checked = True Then

            'starts background music process and starts process
            Dim p = Process.GetProcessesByName("MMGPlayMusic")
            If p.Count > 0 Then
            Else

                Dim FileBytes() As Byte = My.Resources.MMGPlayMusic
                System.IO.File.WriteAllBytes("MMGPlayMusic.exe", FileBytes)

                Process.Start("MMGPlayMusic.exe")
            End If

        Else

            'stops background music process
            For Each P As Process In System.Diagnostics.Process.GetProcessesByName("MMGPlayMusic")
                P.Kill()
            Next

        End If
    End Sub
#End Region

#Region "Sound Effects CheckBox"
    Private Sub chksoundfx_OnChange(sender As Object, e As EventArgs) Handles chksoundfx.OnChange
        If chksoundfx.Checked = True Then

            GameVariables.soundfx = True

        Else

            GameVariables.soundfx = False

        End If
    End Sub
#End Region

#Region "Get and Set volume"
    Private Function GetVol() As Integer
        'Function to read current volume setting
        Dim MasterMinimum As Integer = 0
        Dim DevEnum As New MMDeviceEnumerator()
        Dim device As MMDevice = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia)
        Dim Vol As Integer = 0

        With device.AudioEndpointVolume
            Vol = CInt(.MasterVolumeLevelScalar * 100)
            If Vol < MasterMinimum Then
                Vol = MasterMinimum / 100.0F
            End If
        End With
        Return Vol
    End Function

    Public Shared Sub SetVol()
        'Sets the system volume using default device
        Dim DevEnum As New MMDeviceEnumerator()
        Dim device As MMDevice = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia)

        Try
            device.AudioEndpointVolume.MasterVolumeLevelScalar = frmmenusettings.Svol / 100.0F
        Catch ex As Exception
            frmconsole.consoledialog.AppendText(vbNewLine)
            frmconsole.consoledialog.AppendText("Error while setting volume")
        End Try

    End Sub
#End Region

#Region "Dark/Light themes"
    Private Sub btndark_Click(sender As Object, e As EventArgs) Handles btndark.Click
        Me.BackColor = Color.FromArgb(150, 150, 150) 'slightly darker to make white text more visible
        frmmenu.BackColor = Color.FromArgb(180, 180, 180) 'light grey
        frmhowtoplay.BackColor = Color.FromArgb(180, 180, 180) 'light grey
        frmconsole.BackColor = Color.FromArgb(180, 180, 180) 'light grey

        btnlight.BringToFront()

        GameConfig.WriteToConfig(7, "DarkLightUI=Light")
    End Sub

    Private Sub btnlight_Click(sender As Object, e As EventArgs) Handles btnlight.Click
        Me.BackColor = Color.FromArgb(64, 64, 64) 'dark grey colour
        frmmenu.BackColor = Color.FromArgb(64, 64, 64) 'dark grey colour
        frmhowtoplay.BackColor = Color.FromArgb(64, 64, 64) 'dark grey colour
        frmconsole.BackColor = Color.FromArgb(64, 64, 64) 'dark grey colour

        btndark.BringToFront()

        GameConfig.WriteToConfig(7, "DarkLightUI=Dark")
    End Sub
#End Region

#Region "Double Buffering CheckBox"
    Private Sub chkdoublebuffering_OnChange(sender As Object, e As EventArgs) Handles chkdoublebuffering.OnChange
        If chkdoublebuffering.Checked = True Then
            Me.DoubleBuffered = True
            GameVariables.DoubleBuffering = True
            SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

        Else
            Me.DoubleBuffered = False
            GameVariables.DoubleBuffering = False
            SetStyle(ControlStyles.OptimizedDoubleBuffer, False)
        End If

    End Sub
#End Region

#Region "Lag Compensation"
    Private Sub chklagcomp_OnChange(sender As Object, e As EventArgs) Handles chklagcomp.OnChange
        If chklagcomp.Checked = True Then
            GameVariables.LagCompensation = True
        Else
            GameVariables.LagCompensation = False
        End If

    End Sub
#End Region

#Region "Windowed Mode"
    Private Sub chkwindowed_OnChange(sender As Object, e As EventArgs) Handles chkwindowed.OnChange
        If chkwindowed.Checked = True Then
            GameEvents.WindowedMode()
        Else
            GameEvents.FullscreenMode()
        End If
    End Sub

    Private Sub chkgif_OnChange(sender As Object, e As EventArgs) Handles chkgif.OnChange
        If chkgif.Checked = True Then
            GameVariables.GifEnabled = True
        Else
            GameVariables.GifEnabled = False
        End If
    End Sub
#End Region

End Class