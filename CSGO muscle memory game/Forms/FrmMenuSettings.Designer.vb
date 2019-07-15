<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmmenusettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmenusettings))
        Me.btnclose = New System.Windows.Forms.Button()
        Me.rect = New System.Windows.Forms.Button()
        Me.VScrollBar = New ns1.BunifuVTrackbar()
        Me.expandclose = New System.Windows.Forms.Timer(Me.components)
        Me.expand = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btndark = New System.Windows.Forms.Button()
        Me.btnlight = New System.Windows.Forms.Button()
        Me.btnconsole = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkgif = New ns1.BunifuCheckbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.chklagcomp = New ns1.BunifuCheckbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkdoublebuffering = New ns1.BunifuCheckbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkwindowed = New ns1.BunifuCheckbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblvolume = New System.Windows.Forms.Label()
        Me.HScrollBarVolume = New ns1.BunifuTrackbar()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkmusic = New ns1.BunifuCheckbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chksoundfx = New ns1.BunifuCheckbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.panelsettings = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.RefreshScrollBar = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.panelsettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Firebrick
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Location = New System.Drawing.Point(878, 5)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(156, 38)
        Me.btnclose.TabIndex = 60
        Me.btnclose.Text = "Back"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'rect
        '
        Me.rect.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.rect.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.rect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.rect.FlatAppearance.BorderSize = 0
        Me.rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rect.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rect.ForeColor = System.Drawing.Color.White
        Me.rect.Location = New System.Drawing.Point(12, 5)
        Me.rect.Name = "rect"
        Me.rect.Size = New System.Drawing.Size(860, 38)
        Me.rect.TabIndex = 61
        Me.rect.Text = "Muscle Memory Game - Settings"
        Me.rect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rect.UseVisualStyleBackColor = False
        '
        'VScrollBar
        '
        Me.VScrollBar.BackColor = System.Drawing.Color.Transparent
        Me.VScrollBar.BackgroudColor = System.Drawing.Color.DarkGray
        Me.VScrollBar.BorderRadius = 0
        Me.VScrollBar.IndicatorColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.VScrollBar.Location = New System.Drawing.Point(988, 55)
        Me.VScrollBar.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.VScrollBar.MaximumValue = 250
        Me.VScrollBar.Name = "VScrollBar"
        Me.VScrollBar.Size = New System.Drawing.Size(40, 320)
        Me.VScrollBar.SliderRadius = 0
        Me.VScrollBar.TabIndex = 64
        Me.VScrollBar.Value = 0
        '
        'expandclose
        '
        Me.expandclose.Interval = 20
        '
        'expand
        '
        Me.expand.Interval = 20
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.btndark)
        Me.Panel4.Controls.Add(Me.btnlight)
        Me.Panel4.Controls.Add(Me.btnconsole)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.chkgif)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Location = New System.Drawing.Point(4, 475)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(951, 229)
        Me.Panel4.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(514, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 30)
        Me.Label12.TabIndex = 86
        Me.Label12.Text = "Theme:"
        Me.ToolTip.SetToolTip(Me.Label12, "Key used to open console")
        '
        'btndark
        '
        Me.btndark.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btndark.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndark.FlatAppearance.BorderSize = 0
        Me.btndark.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndark.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btndark.ForeColor = System.Drawing.Color.White
        Me.btndark.Location = New System.Drawing.Point(612, 78)
        Me.btndark.Name = "btndark"
        Me.btndark.Size = New System.Drawing.Size(106, 46)
        Me.btndark.TabIndex = 85
        Me.btndark.Text = "Dark"
        Me.btndark.UseVisualStyleBackColor = False
        '
        'btnlight
        '
        Me.btnlight.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnlight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlight.FlatAppearance.BorderSize = 0
        Me.btnlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnlight.ForeColor = System.Drawing.Color.White
        Me.btnlight.Location = New System.Drawing.Point(612, 78)
        Me.btnlight.Name = "btnlight"
        Me.btnlight.Size = New System.Drawing.Size(106, 46)
        Me.btnlight.TabIndex = 84
        Me.btnlight.Text = "Light"
        Me.btnlight.UseVisualStyleBackColor = False
        '
        'btnconsole
        '
        Me.btnconsole.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnconsole.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnconsole.FlatAppearance.BorderSize = 0
        Me.btnconsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconsole.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnconsole.ForeColor = System.Drawing.Color.White
        Me.btnconsole.Location = New System.Drawing.Point(141, 163)
        Me.btnconsole.Name = "btnconsole"
        Me.btnconsole.Size = New System.Drawing.Size(240, 46)
        Me.btnconsole.TabIndex = 83
        Me.btnconsole.Text = "Open Console"
        Me.btnconsole.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(153, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(246, 30)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "Enable GIF backgrounds"
        Me.ToolTip.SetToolTip(Me.Label11, "Enables animated GIF backgrounds")
        '
        'chkgif
        '
        Me.chkgif.AutoSize = True
        Me.chkgif.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkgif.ChechedOffColor = System.Drawing.Color.DarkGray
        Me.chkgif.Checked = True
        Me.chkgif.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkgif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkgif.ForeColor = System.Drawing.Color.White
        Me.chkgif.Location = New System.Drawing.Point(117, 86)
        Me.chkgif.Margin = New System.Windows.Forms.Padding(0)
        Me.chkgif.Name = "chkgif"
        Me.chkgif.Size = New System.Drawing.Size(20, 20)
        Me.chkgif.TabIndex = 77
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 30)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "General"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(3, 14)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(945, 38)
        Me.Button3.TabIndex = 82
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.chklagcomp)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.chkdoublebuffering)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.chkwindowed)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Location = New System.Drawing.Point(4, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(951, 229)
        Me.Panel5.TabIndex = 11
        '
        'chklagcomp
        '
        Me.chklagcomp.AutoSize = True
        Me.chklagcomp.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chklagcomp.ChechedOffColor = System.Drawing.Color.DarkGray
        Me.chklagcomp.Checked = True
        Me.chklagcomp.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chklagcomp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chklagcomp.ForeColor = System.Drawing.Color.White
        Me.chklagcomp.Location = New System.Drawing.Point(454, 80)
        Me.chklagcomp.Margin = New System.Windows.Forms.Padding(0)
        Me.chklagcomp.Name = "chklagcomp"
        Me.chklagcomp.Size = New System.Drawing.Size(20, 20)
        Me.chklagcomp.TabIndex = 77
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(492, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(255, 30)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Timer Lag Compensation"
        Me.ToolTip.SetToolTip(Me.Label7, "Allows the user to see the shape timer reach the time limit")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(153, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(248, 30)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Enable Double Buffering"
        Me.ToolTip.SetToolTip(Me.Label6, "Enables Double Buffering (Helps with flickering)")
        '
        'chkdoublebuffering
        '
        Me.chkdoublebuffering.AutoSize = True
        Me.chkdoublebuffering.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkdoublebuffering.ChechedOffColor = System.Drawing.Color.DarkGray
        Me.chkdoublebuffering.Checked = True
        Me.chkdoublebuffering.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkdoublebuffering.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkdoublebuffering.ForeColor = System.Drawing.Color.White
        Me.chkdoublebuffering.Location = New System.Drawing.Point(117, 137)
        Me.chkdoublebuffering.Margin = New System.Windows.Forms.Padding(0)
        Me.chkdoublebuffering.Name = "chkdoublebuffering"
        Me.chkdoublebuffering.Size = New System.Drawing.Size(20, 20)
        Me.chkdoublebuffering.TabIndex = 74
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(153, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 30)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Windowed Mode"
        Me.ToolTip.SetToolTip(Me.Label5, "Enables windowed mode")
        '
        'chkwindowed
        '
        Me.chkwindowed.AutoSize = True
        Me.chkwindowed.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkwindowed.ChechedOffColor = System.Drawing.Color.DarkGray
        Me.chkwindowed.Checked = True
        Me.chkwindowed.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkwindowed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkwindowed.ForeColor = System.Drawing.Color.White
        Me.chkwindowed.Location = New System.Drawing.Point(117, 80)
        Me.chkwindowed.Margin = New System.Windows.Forms.Padding(0)
        Me.chkwindowed.Name = "chkwindowed"
        Me.chkwindowed.Size = New System.Drawing.Size(20, 20)
        Me.chkwindowed.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 30)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Video"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(3, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(945, 38)
        Me.Button1.TabIndex = 73
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.lblvolume)
        Me.Panel6.Controls.Add(Me.HScrollBarVolume)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Controls.Add(Me.chkmusic)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.chksoundfx)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.Button2)
        Me.Panel6.Location = New System.Drawing.Point(4, 238)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(951, 229)
        Me.Panel6.TabIndex = 12
        '
        'lblvolume
        '
        Me.lblvolume.AutoSize = True
        Me.lblvolume.BackColor = System.Drawing.Color.Transparent
        Me.lblvolume.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblvolume.ForeColor = System.Drawing.Color.White
        Me.lblvolume.Location = New System.Drawing.Point(606, 174)
        Me.lblvolume.Name = "lblvolume"
        Me.lblvolume.Size = New System.Drawing.Size(37, 30)
        Me.lblvolume.TabIndex = 82
        Me.lblvolume.Text = "50"
        '
        'HScrollBarVolume
        '
        Me.HScrollBarVolume.BackColor = System.Drawing.Color.Transparent
        Me.HScrollBarVolume.BackgroudColor = System.Drawing.Color.DarkGray
        Me.HScrollBarVolume.BorderRadius = 0
        Me.HScrollBarVolume.IndicatorColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.HScrollBarVolume.Location = New System.Drawing.Point(432, 123)
        Me.HScrollBarVolume.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.HScrollBarVolume.MaximumValue = 100
        Me.HScrollBarVolume.Name = "HScrollBarVolume"
        Me.HScrollBarVolume.Size = New System.Drawing.Size(380, 41)
        Me.HScrollBarVolume.SliderRadius = 0
        Me.HScrollBarVolume.TabIndex = 80
        Me.HScrollBarVolume.Value = 50
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(532, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(160, 30)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "Master Volume"
        Me.ToolTip.SetToolTip(Me.Label10, "Music and sound effect master volume")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(153, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 30)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "Enable Music"
        Me.ToolTip.SetToolTip(Me.Label8, "Enable background music")
        '
        'chkmusic
        '
        Me.chkmusic.AutoSize = True
        Me.chkmusic.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkmusic.ChechedOffColor = System.Drawing.Color.DarkGray
        Me.chkmusic.Checked = True
        Me.chkmusic.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chkmusic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkmusic.ForeColor = System.Drawing.Color.White
        Me.chkmusic.Location = New System.Drawing.Point(117, 138)
        Me.chkmusic.Margin = New System.Windows.Forms.Padding(0)
        Me.chkmusic.Name = "chkmusic"
        Me.chkmusic.Size = New System.Drawing.Size(20, 20)
        Me.chkmusic.TabIndex = 75
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(153, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 30)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Enable Sound Effects"
        Me.ToolTip.SetToolTip(Me.Label3, "Enable audio sound effects")
        '
        'chksoundfx
        '
        Me.chksoundfx.AutoSize = True
        Me.chksoundfx.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chksoundfx.ChechedOffColor = System.Drawing.Color.DarkGray
        Me.chksoundfx.Checked = True
        Me.chksoundfx.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chksoundfx.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chksoundfx.ForeColor = System.Drawing.Color.White
        Me.chksoundfx.Location = New System.Drawing.Point(117, 78)
        Me.chksoundfx.Margin = New System.Windows.Forms.Padding(0)
        Me.chksoundfx.Name = "chksoundfx"
        Me.chksoundfx.Size = New System.Drawing.Size(20, 20)
        Me.chksoundfx.TabIndex = 73
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(20, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 30)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Audio"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(3, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(945, 38)
        Me.Button2.TabIndex = 81
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'panelsettings
        '
        Me.panelsettings.Controls.Add(Me.Panel6)
        Me.panelsettings.Controls.Add(Me.Panel5)
        Me.panelsettings.Controls.Add(Me.Panel4)
        Me.panelsettings.Location = New System.Drawing.Point(12, 49)
        Me.panelsettings.Name = "panelsettings"
        Me.panelsettings.Size = New System.Drawing.Size(969, 725)
        Me.panelsettings.TabIndex = 65
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(12, -5)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(969, 66)
        Me.Panel2.TabIndex = 13
        '
        'ToolTip
        '
        Me.ToolTip.AutoPopDelay = 0
        Me.ToolTip.BackColor = System.Drawing.Color.DimGray
        Me.ToolTip.ForeColor = System.Drawing.Color.White
        Me.ToolTip.InitialDelay = 500
        Me.ToolTip.IsBalloon = True
        Me.ToolTip.OwnerDraw = True
        Me.ToolTip.ReshowDelay = 0
        '
        'RefreshScrollBar
        '
        Me.RefreshScrollBar.Enabled = True
        Me.RefreshScrollBar.Interval = 1
        '
        'frmmenusettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1050, 769)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.rect)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panelsettings)
        Me.Controls.Add(Me.VScrollBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmmenusettings"
        Me.Text = "frmmenusettings"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.panelsettings.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnclose As Button
    Friend WithEvents rect As Button
    Friend WithEvents VScrollBar As ns1.BunifuVTrackbar
    Friend WithEvents expandclose As Timer
    Friend WithEvents expand As Timer
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents chkgif As ns1.BunifuCheckbox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents chkdoublebuffering As ns1.BunifuCheckbox
    Friend WithEvents Label5 As Label
    Friend WithEvents chkwindowed As ns1.BunifuCheckbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents HScrollBarVolume As ns1.BunifuTrackbar
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents chkmusic As ns1.BunifuCheckbox
    Friend WithEvents Label3 As Label
    Friend WithEvents chksoundfx As ns1.BunifuCheckbox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents panelsettings As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblvolume As Label
    Friend WithEvents btnconsole As Button
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents RefreshScrollBar As Timer
    Friend WithEvents Label12 As Label
    Friend WithEvents btndark As Button
    Friend WithEvents btnlight As Button
    Friend WithEvents chklagcomp As ns1.BunifuCheckbox
    Friend WithEvents Label7 As Label
End Class
