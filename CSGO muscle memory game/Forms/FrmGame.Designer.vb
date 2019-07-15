<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmgame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmgame))
        Me.timerlocation1 = New System.Windows.Forms.Timer(Me.components)
        Me.gamemenu = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontStyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolumeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MusicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnabledToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisabledToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoundEffectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnabledToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisabledToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullscreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UIScaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CenterBannersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComplexScoringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnabledToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisabledToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CurrentScoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LivesLeftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblstart = New System.Windows.Forms.ToolStripMenuItem()
        Me.timerlocation2 = New System.Windows.Forms.Timer(Me.components)
        Me.timerlocation3 = New System.Windows.Forms.Timer(Me.components)
        Me.timerhighscore = New System.Windows.Forms.Timer(Me.components)
        Me.TimeLeftCounter = New System.Windows.Forms.Timer(Me.components)
        Me.refreshtimer = New System.Windows.Forms.Timer(Me.components)
        Me.removehighscore = New System.Windows.Forms.Timer(Me.components)
        Me.removelifelost = New System.Windows.Forms.Timer(Me.components)
        Me.CheckKeyBind = New System.Windows.Forms.Timer(Me.components)
        Me.ShowLifeUp = New System.Windows.Forms.Timer(Me.components)
        Me.picboxlifelost = New System.Windows.Forms.PictureBox()
        Me.picboxhighscore = New System.Windows.Forms.PictureBox()
        Me.picboxbackground = New System.Windows.Forms.PictureBox()
        Me.LinearMode = New System.Windows.Forms.Timer(Me.components)
        Me.ShowFreeze = New System.Windows.Forms.Timer(Me.components)
        Me.gamemenu.SuspendLayout()
        CType(Me.picboxlifelost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxhighscore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxbackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timerlocation1
        '
        Me.timerlocation1.Interval = 2000
        '
        'gamemenu
        '
        Me.gamemenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.gamemenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gamemenu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gamemenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.gamemenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.ToolStripMenuItem1, Me.CurrentScoreToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.LivesLeftToolStripMenuItem, Me.ToolStripMenuItem4, Me.ToolStripMenuItem11, Me.lblstart})
        Me.gamemenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.gamemenu.Location = New System.Drawing.Point(0, 0)
        Me.gamemenu.Name = "gamemenu"
        Me.gamemenu.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.gamemenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.gamemenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gamemenu.Size = New System.Drawing.Size(1900, 42)
        Me.gamemenu.TabIndex = 7
        Me.gamemenu.Text = "GameMenu"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(175, 36)
        Me.MenuToolStripMenuItem.Text = "Back to Menu"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontStyleToolStripMenuItem, Me.AudioToolStripMenuItem, Me.VideoToolStripMenuItem, Me.UIScaleToolStripMenuItem, Me.ComplexScoringToolStripMenuItem, Me.OpenConsoleToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(113, 36)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'FontStyleToolStripMenuItem
        '
        Me.FontStyleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.FontStyleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoldToolStripMenuItem, Me.RegularToolStripMenuItem})
        Me.FontStyleToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FontStyleToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FontStyleToolStripMenuItem.Name = "FontStyleToolStripMenuItem"
        Me.FontStyleToolStripMenuItem.Size = New System.Drawing.Size(284, 36)
        Me.FontStyleToolStripMenuItem.Text = "Font Style"
        '
        'BoldToolStripMenuItem
        '
        Me.BoldToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BoldToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.BoldToolStripMenuItem.Name = "BoldToolStripMenuItem"
        Me.BoldToolStripMenuItem.Size = New System.Drawing.Size(183, 36)
        Me.BoldToolStripMenuItem.Text = "Bold"
        '
        'RegularToolStripMenuItem
        '
        Me.RegularToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.RegularToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.RegularToolStripMenuItem.Name = "RegularToolStripMenuItem"
        Me.RegularToolStripMenuItem.Size = New System.Drawing.Size(183, 36)
        Me.RegularToolStripMenuItem.Text = "Regular"
        '
        'AudioToolStripMenuItem
        '
        Me.AudioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.AudioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolumeToolStripMenuItem, Me.MusicToolStripMenuItem, Me.SoundEffectsToolStripMenuItem})
        Me.AudioToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AudioToolStripMenuItem.Name = "AudioToolStripMenuItem"
        Me.AudioToolStripMenuItem.Size = New System.Drawing.Size(284, 36)
        Me.AudioToolStripMenuItem.Text = "Audio"
        '
        'VolumeToolStripMenuItem
        '
        Me.VolumeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.VolumeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9, Me.ToolStripMenuItem10})
        Me.VolumeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.VolumeToolStripMenuItem.Name = "VolumeToolStripMenuItem"
        Me.VolumeToolStripMenuItem.Size = New System.Drawing.Size(249, 36)
        Me.VolumeToolStripMenuItem.Text = "Volume"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ToolStripMenuItem5.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(142, 36)
        Me.ToolStripMenuItem5.Text = "0"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ToolStripMenuItem6.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(142, 36)
        Me.ToolStripMenuItem6.Text = "20"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ToolStripMenuItem7.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(142, 36)
        Me.ToolStripMenuItem7.Text = "40"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ToolStripMenuItem8.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(142, 36)
        Me.ToolStripMenuItem8.Text = "60"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ToolStripMenuItem9.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(142, 36)
        Me.ToolStripMenuItem9.Text = "80"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ToolStripMenuItem10.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(142, 36)
        Me.ToolStripMenuItem10.Text = "100"
        '
        'MusicToolStripMenuItem
        '
        Me.MusicToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.MusicToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnabledToolStripMenuItem1, Me.DisabledToolStripMenuItem1})
        Me.MusicToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MusicToolStripMenuItem.Name = "MusicToolStripMenuItem"
        Me.MusicToolStripMenuItem.Size = New System.Drawing.Size(249, 36)
        Me.MusicToolStripMenuItem.Text = "Music"
        '
        'EnabledToolStripMenuItem1
        '
        Me.EnabledToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.EnabledToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.EnabledToolStripMenuItem1.Name = "EnabledToolStripMenuItem1"
        Me.EnabledToolStripMenuItem1.Size = New System.Drawing.Size(195, 36)
        Me.EnabledToolStripMenuItem1.Text = "Enabled"
        '
        'DisabledToolStripMenuItem1
        '
        Me.DisabledToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.DisabledToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.DisabledToolStripMenuItem1.Name = "DisabledToolStripMenuItem1"
        Me.DisabledToolStripMenuItem1.Size = New System.Drawing.Size(195, 36)
        Me.DisabledToolStripMenuItem1.Text = "Disabled"
        '
        'SoundEffectsToolStripMenuItem
        '
        Me.SoundEffectsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.SoundEffectsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnabledToolStripMenuItem2, Me.DisabledToolStripMenuItem2})
        Me.SoundEffectsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SoundEffectsToolStripMenuItem.Name = "SoundEffectsToolStripMenuItem"
        Me.SoundEffectsToolStripMenuItem.Size = New System.Drawing.Size(249, 36)
        Me.SoundEffectsToolStripMenuItem.Text = "Sound Effects"
        '
        'EnabledToolStripMenuItem2
        '
        Me.EnabledToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.EnabledToolStripMenuItem2.ForeColor = System.Drawing.Color.White
        Me.EnabledToolStripMenuItem2.Name = "EnabledToolStripMenuItem2"
        Me.EnabledToolStripMenuItem2.Size = New System.Drawing.Size(195, 36)
        Me.EnabledToolStripMenuItem2.Text = "Enabled"
        '
        'DisabledToolStripMenuItem2
        '
        Me.DisabledToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.DisabledToolStripMenuItem2.ForeColor = System.Drawing.Color.White
        Me.DisabledToolStripMenuItem2.Name = "DisabledToolStripMenuItem2"
        Me.DisabledToolStripMenuItem2.Size = New System.Drawing.Size(195, 36)
        Me.DisabledToolStripMenuItem2.Text = "Disabled"
        '
        'VideoToolStripMenuItem
        '
        Me.VideoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.VideoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FullscreenToolStripMenuItem, Me.WindowedToolStripMenuItem})
        Me.VideoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.VideoToolStripMenuItem.Name = "VideoToolStripMenuItem"
        Me.VideoToolStripMenuItem.Size = New System.Drawing.Size(284, 36)
        Me.VideoToolStripMenuItem.Text = "Video"
        '
        'FullscreenToolStripMenuItem
        '
        Me.FullscreenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.FullscreenToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FullscreenToolStripMenuItem.Name = "FullscreenToolStripMenuItem"
        Me.FullscreenToolStripMenuItem.Size = New System.Drawing.Size(217, 36)
        Me.FullscreenToolStripMenuItem.Text = "Fullscreen"
        '
        'WindowedToolStripMenuItem
        '
        Me.WindowedToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.WindowedToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.WindowedToolStripMenuItem.Name = "WindowedToolStripMenuItem"
        Me.WindowedToolStripMenuItem.Size = New System.Drawing.Size(217, 36)
        Me.WindowedToolStripMenuItem.Text = "Windowed"
        '
        'UIScaleToolStripMenuItem
        '
        Me.UIScaleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.UIScaleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CenterBannersToolStripMenuItem})
        Me.UIScaleToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.UIScaleToolStripMenuItem.Name = "UIScaleToolStripMenuItem"
        Me.UIScaleToolStripMenuItem.Size = New System.Drawing.Size(284, 36)
        Me.UIScaleToolStripMenuItem.Text = "UI Scale"
        '
        'CenterBannersToolStripMenuItem
        '
        Me.CenterBannersToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.CenterBannersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem13, Me.ToolStripMenuItem14, Me.ToolStripMenuItem15, Me.ToolStripMenuItem16, Me.ToolStripMenuItem17})
        Me.CenterBannersToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CenterBannersToolStripMenuItem.Name = "CenterBannersToolStripMenuItem"
        Me.CenterBannersToolStripMenuItem.Size = New System.Drawing.Size(266, 36)
        Me.CenterBannersToolStripMenuItem.Text = "Center Banners"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ToolStripMenuItem13.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(162, 36)
        Me.ToolStripMenuItem13.Text = "50%"
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ToolStripMenuItem14.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(162, 36)
        Me.ToolStripMenuItem14.Text = "75%"
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ToolStripMenuItem15.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(162, 36)
        Me.ToolStripMenuItem15.Text = "100%"
        '
        'ToolStripMenuItem16
        '
        Me.ToolStripMenuItem16.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ToolStripMenuItem16.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        Me.ToolStripMenuItem16.Size = New System.Drawing.Size(162, 36)
        Me.ToolStripMenuItem16.Text = "125%"
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ToolStripMenuItem17.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(162, 36)
        Me.ToolStripMenuItem17.Text = "150%"
        '
        'ComplexScoringToolStripMenuItem
        '
        Me.ComplexScoringToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ComplexScoringToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnabledToolStripMenuItem, Me.DisabledToolStripMenuItem})
        Me.ComplexScoringToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ComplexScoringToolStripMenuItem.Name = "ComplexScoringToolStripMenuItem"
        Me.ComplexScoringToolStripMenuItem.Size = New System.Drawing.Size(284, 36)
        Me.ComplexScoringToolStripMenuItem.Text = "Complex Scoring"
        '
        'EnabledToolStripMenuItem
        '
        Me.EnabledToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.EnabledToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EnabledToolStripMenuItem.Name = "EnabledToolStripMenuItem"
        Me.EnabledToolStripMenuItem.Size = New System.Drawing.Size(195, 36)
        Me.EnabledToolStripMenuItem.Text = "Enabled"
        '
        'DisabledToolStripMenuItem
        '
        Me.DisabledToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.DisabledToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DisabledToolStripMenuItem.Name = "DisabledToolStripMenuItem"
        Me.DisabledToolStripMenuItem.Size = New System.Drawing.Size(195, 36)
        Me.DisabledToolStripMenuItem.Text = "Disabled"
        '
        'OpenConsoleToolStripMenuItem
        '
        Me.OpenConsoleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.OpenConsoleToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OpenConsoleToolStripMenuItem.Name = "OpenConsoleToolStripMenuItem"
        Me.OpenConsoleToolStripMenuItem.Size = New System.Drawing.Size(284, 36)
        Me.OpenConsoleToolStripMenuItem.Text = "Open Console"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(33, 36)
        Me.ToolStripMenuItem1.Text = "|"
        '
        'CurrentScoreToolStripMenuItem
        '
        Me.CurrentScoreToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.CurrentScoreToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentScoreToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CurrentScoreToolStripMenuItem.Name = "CurrentScoreToolStripMenuItem"
        Me.CurrentScoreToolStripMenuItem.Size = New System.Drawing.Size(40, 36)
        Me.CurrentScoreToolStripMenuItem.Text = "0"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(86, 36)
        Me.ToolStripMenuItem2.Text = "Score"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem3.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(33, 36)
        Me.ToolStripMenuItem3.Text = "|"
        '
        'LivesLeftToolStripMenuItem
        '
        Me.LivesLeftToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.LivesLeftToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LivesLeftToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LivesLeftToolStripMenuItem.Name = "LivesLeftToolStripMenuItem"
        Me.LivesLeftToolStripMenuItem.Size = New System.Drawing.Size(40, 36)
        Me.LivesLeftToolStripMenuItem.Text = "3"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ToolStripMenuItem4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem4.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(79, 36)
        Me.ToolStripMenuItem4.Text = "Lives"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ToolStripMenuItem11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem11.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(33, 36)
        Me.ToolStripMenuItem11.Text = "|"
        '
        'lblstart
        '
        Me.lblstart.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstart.ForeColor = System.Drawing.Color.White
        Me.lblstart.Name = "lblstart"
        Me.lblstart.Size = New System.Drawing.Size(229, 36)
        Me.lblstart.Text = "Click shape to start"
        '
        'timerlocation2
        '
        Me.timerlocation2.Interval = 2000
        '
        'timerlocation3
        '
        Me.timerlocation3.Interval = 2000
        '
        'timerhighscore
        '
        Me.timerhighscore.Enabled = True
        '
        'TimeLeftCounter
        '
        Me.TimeLeftCounter.Interval = 10
        '
        'refreshtimer
        '
        Me.refreshtimer.Enabled = True
        Me.refreshtimer.Interval = 50
        '
        'removehighscore
        '
        Me.removehighscore.Interval = 1000
        '
        'removelifelost
        '
        Me.removelifelost.Interval = 1000
        '
        'CheckKeyBind
        '
        Me.CheckKeyBind.Enabled = True
        Me.CheckKeyBind.Interval = 300
        '
        'ShowLifeUp
        '
        Me.ShowLifeUp.Interval = 15000
        '
        'picboxlifelost
        '
        Me.picboxlifelost.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picboxlifelost.BackColor = System.Drawing.Color.Firebrick
        Me.picboxlifelost.Image = Global.Muscle_memory_game.My.Resources.Resources.Lose_Life
        Me.picboxlifelost.Location = New System.Drawing.Point(570, 454)
        Me.picboxlifelost.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picboxlifelost.Name = "picboxlifelost"
        Me.picboxlifelost.Size = New System.Drawing.Size(705, 368)
        Me.picboxlifelost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxlifelost.TabIndex = 12
        Me.picboxlifelost.TabStop = False
        '
        'picboxhighscore
        '
        Me.picboxhighscore.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picboxhighscore.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.picboxhighscore.Image = Global.Muscle_memory_game.My.Resources.Resources.Highscore
        Me.picboxhighscore.Location = New System.Drawing.Point(1164, 49)
        Me.picboxhighscore.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picboxhighscore.Name = "picboxhighscore"
        Me.picboxhighscore.Size = New System.Drawing.Size(596, 349)
        Me.picboxhighscore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxhighscore.TabIndex = 11
        Me.picboxhighscore.TabStop = False
        '
        'picboxbackground
        '
        Me.picboxbackground.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picboxbackground.BackColor = System.Drawing.Color.SteelBlue
        Me.picboxbackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picboxbackground.Location = New System.Drawing.Point(140, 48)
        Me.picboxbackground.Name = "picboxbackground"
        Me.picboxbackground.Size = New System.Drawing.Size(548, 349)
        Me.picboxbackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxbackground.TabIndex = 10
        Me.picboxbackground.TabStop = False
        '
        'LinearMode
        '
        Me.LinearMode.Interval = 3000
        '
        'ShowFreeze
        '
        Me.ShowFreeze.Interval = 10000
        '
        'frmgame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1900, 915)
        Me.ControlBox = False
        Me.Controls.Add(Me.picboxlifelost)
        Me.Controls.Add(Me.picboxhighscore)
        Me.Controls.Add(Me.gamemenu)
        Me.Controls.Add(Me.picboxbackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.gamemenu
        Me.MinimumSize = New System.Drawing.Size(1500, 769)
        Me.Name = "frmgame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Muscle Memory Game"
        Me.gamemenu.ResumeLayout(False)
        Me.gamemenu.PerformLayout()
        CType(Me.picboxlifelost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxhighscore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxbackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timerlocation1 As Timer
    Friend WithEvents gamemenu As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CurrentScoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents timerlocation2 As Timer
    Friend WithEvents timerlocation3 As Timer
    Friend WithEvents timerhighscore As Timer
    Friend WithEvents picboxbackground As PictureBox
    Friend WithEvents lblstart As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontStyleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BoldToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents TimeLeftCounter As Timer
    Friend WithEvents refreshtimer As Timer
    Friend WithEvents removehighscore As Timer
    Friend WithEvents picboxhighscore As PictureBox
    Friend WithEvents VideoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FullscreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AudioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolumeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripMenuItem
    Friend WithEvents OpenConsoleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picboxlifelost As PictureBox
    Friend WithEvents removelifelost As Timer
    Friend WithEvents LivesLeftToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As ToolStripMenuItem
    Friend WithEvents CheckKeyBind As Timer
    Friend WithEvents ShowLifeUp As Timer
    Friend WithEvents LinearMode As Timer
    Friend WithEvents ShowFreeze As Timer
    Friend WithEvents UIScaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CenterBannersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem14 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem15 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem16 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem17 As ToolStripMenuItem
    Friend WithEvents ComplexScoringToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnabledToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisabledToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MusicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnabledToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DisabledToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SoundEffectsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnabledToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents DisabledToolStripMenuItem2 As ToolStripMenuItem
End Class
