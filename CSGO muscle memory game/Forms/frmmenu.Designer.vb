<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmmenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmenu))
        Me.btnsettings = New System.Windows.Forms.Button()
        Me.btnhowtoplay = New System.Windows.Forms.Button()
        Me.btnplay = New System.Windows.Forms.Button()
        Me.btnminimise = New System.Windows.Forms.Button()
        Me.btnpressmenu1 = New System.Windows.Forms.Button()
        Me.timerlocationmenu1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnpressmenu2 = New System.Windows.Forms.Button()
        Me.timerlocationmenu2 = New System.Windows.Forms.Timer(Me.components)
        Me.timerlocationmenu3 = New System.Windows.Forms.Timer(Me.components)
        Me.btnpressmenu3 = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.picboxmenu = New System.Windows.Forms.PictureBox()
        Me.expand = New System.Windows.Forms.Timer(Me.components)
        Me.rect = New System.Windows.Forms.Button()
        Me.expandclosehowtoplay = New System.Windows.Forms.Timer(Me.components)
        Me.expandclosesetting = New System.Windows.Forms.Timer(Me.components)
        Me.btnfree = New System.Windows.Forms.Button()
        Me.btnlinear = New System.Windows.Forms.Button()
        Me.btnplaycloseexpand = New System.Windows.Forms.Timer(Me.components)
        Me.btnlinearfreeexpand = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picboxmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnsettings
        '
        Me.btnsettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnsettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsettings.FlatAppearance.BorderSize = 0
        Me.btnsettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnsettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsettings.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsettings.ForeColor = System.Drawing.Color.White
        Me.btnsettings.Location = New System.Drawing.Point(33, 81)
        Me.btnsettings.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnsettings.Name = "btnsettings"
        Me.btnsettings.Size = New System.Drawing.Size(153, 68)
        Me.btnsettings.TabIndex = 1
        Me.btnsettings.Text = "Settings"
        Me.ToolTip.SetToolTip(Me.btnsettings, "Open Settings")
        Me.btnsettings.UseVisualStyleBackColor = False
        '
        'btnhowtoplay
        '
        Me.btnhowtoplay.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnhowtoplay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhowtoplay.FlatAppearance.BorderSize = 0
        Me.btnhowtoplay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnhowtoplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnhowtoplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhowtoplay.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhowtoplay.ForeColor = System.Drawing.Color.White
        Me.btnhowtoplay.Location = New System.Drawing.Point(514, 81)
        Me.btnhowtoplay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnhowtoplay.Name = "btnhowtoplay"
        Me.btnhowtoplay.Size = New System.Drawing.Size(153, 68)
        Me.btnhowtoplay.TabIndex = 4
        Me.btnhowtoplay.Text = "How to play"
        Me.ToolTip.SetToolTip(Me.btnhowtoplay, "Open How to play")
        Me.btnhowtoplay.UseVisualStyleBackColor = False
        '
        'btnplay
        '
        Me.btnplay.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnplay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnplay.FlatAppearance.BorderSize = 0
        Me.btnplay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnplay.Font = New System.Drawing.Font("Segoe UI", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnplay.ForeColor = System.Drawing.Color.White
        Me.btnplay.Location = New System.Drawing.Point(204, 51)
        Me.btnplay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnplay.Name = "btnplay"
        Me.btnplay.Size = New System.Drawing.Size(291, 140)
        Me.btnplay.TabIndex = 5
        Me.btnplay.Text = "PLAY"
        Me.btnplay.UseVisualStyleBackColor = False
        '
        'btnminimise
        '
        Me.btnminimise.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnminimise.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnminimise.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnminimise.FlatAppearance.BorderSize = 0
        Me.btnminimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimise.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnminimise.ForeColor = System.Drawing.Color.White
        Me.btnminimise.Location = New System.Drawing.Point(621, 3)
        Me.btnminimise.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnminimise.Name = "btnminimise"
        Me.btnminimise.Size = New System.Drawing.Size(32, 25)
        Me.btnminimise.TabIndex = 6
        Me.btnminimise.Text = "" & Global.Microsoft.VisualBasic.ChrW(9) & "🗕"
        Me.btnminimise.UseVisualStyleBackColor = False
        '
        'btnpressmenu1
        '
        Me.btnpressmenu1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnpressmenu1.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnpressmenu1.Enabled = False
        Me.btnpressmenu1.FlatAppearance.BorderSize = 0
        Me.btnpressmenu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpressmenu1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpressmenu1.Location = New System.Drawing.Point(314, 153)
        Me.btnpressmenu1.Margin = New System.Windows.Forms.Padding(100, 97, 100, 97)
        Me.btnpressmenu1.Name = "btnpressmenu1"
        Me.btnpressmenu1.Size = New System.Drawing.Size(67, 65)
        Me.btnpressmenu1.TabIndex = 11
        Me.btnpressmenu1.UseVisualStyleBackColor = False
        '
        'timerlocationmenu1
        '
        Me.timerlocationmenu1.Enabled = True
        Me.timerlocationmenu1.Interval = 400
        '
        'btnpressmenu2
        '
        Me.btnpressmenu2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnpressmenu2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnpressmenu2.Enabled = False
        Me.btnpressmenu2.FlatAppearance.BorderSize = 0
        Me.btnpressmenu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpressmenu2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpressmenu2.Location = New System.Drawing.Point(241, 153)
        Me.btnpressmenu2.Margin = New System.Windows.Forms.Padding(100, 97, 100, 97)
        Me.btnpressmenu2.Name = "btnpressmenu2"
        Me.btnpressmenu2.Size = New System.Drawing.Size(67, 65)
        Me.btnpressmenu2.TabIndex = 12
        Me.btnpressmenu2.UseVisualStyleBackColor = False
        '
        'timerlocationmenu2
        '
        Me.timerlocationmenu2.Enabled = True
        Me.timerlocationmenu2.Interval = 500
        '
        'timerlocationmenu3
        '
        Me.timerlocationmenu3.Enabled = True
        Me.timerlocationmenu3.Interval = 300
        '
        'btnpressmenu3
        '
        Me.btnpressmenu3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnpressmenu3.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnpressmenu3.Enabled = False
        Me.btnpressmenu3.FlatAppearance.BorderSize = 0
        Me.btnpressmenu3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpressmenu3.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpressmenu3.Location = New System.Drawing.Point(387, 153)
        Me.btnpressmenu3.Margin = New System.Windows.Forms.Padding(100, 97, 100, 97)
        Me.btnpressmenu3.Name = "btnpressmenu3"
        Me.btnpressmenu3.Size = New System.Drawing.Size(67, 65)
        Me.btnpressmenu3.TabIndex = 13
        Me.btnpressmenu3.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnclose.BackColor = System.Drawing.Color.Firebrick
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Location = New System.Drawing.Point(657, 3)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(32, 25)
        Me.btnclose.TabIndex = 7
        Me.btnclose.Text = "X"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'picboxmenu
        '
        Me.picboxmenu.BackColor = System.Drawing.Color.Transparent
        Me.picboxmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picboxmenu.Location = New System.Drawing.Point(11, 32)
        Me.picboxmenu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picboxmenu.Name = "picboxmenu"
        Me.picboxmenu.Size = New System.Drawing.Size(678, 177)
        Me.picboxmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxmenu.TabIndex = 3
        Me.picboxmenu.TabStop = False
        Me.picboxmenu.Visible = False
        '
        'expand
        '
        Me.expand.Interval = 20
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
        Me.rect.Location = New System.Drawing.Point(9, 3)
        Me.rect.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rect.Name = "rect"
        Me.rect.Size = New System.Drawing.Size(608, 25)
        Me.rect.TabIndex = 53
        Me.rect.Text = "Muscle Memory Game  - Menu"
        Me.rect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rect.UseVisualStyleBackColor = False
        '
        'expandclosehowtoplay
        '
        Me.expandclosehowtoplay.Interval = 20
        '
        'expandclosesetting
        '
        Me.expandclosesetting.Interval = 20
        '
        'btnfree
        '
        Me.btnfree.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnfree.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfree.FlatAppearance.BorderSize = 0
        Me.btnfree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnfree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnfree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfree.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfree.ForeColor = System.Drawing.Color.White
        Me.btnfree.Location = New System.Drawing.Point(205, 54)
        Me.btnfree.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnfree.Name = "btnfree"
        Me.btnfree.Size = New System.Drawing.Size(290, 60)
        Me.btnfree.TabIndex = 54
        Me.btnfree.Text = "Free mode"
        Me.ToolTip.SetToolTip(Me.btnfree, "Play free mode")
        Me.btnfree.UseVisualStyleBackColor = False
        '
        'btnlinear
        '
        Me.btnlinear.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnlinear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlinear.FlatAppearance.BorderSize = 0
        Me.btnlinear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnlinear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnlinear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlinear.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlinear.ForeColor = System.Drawing.Color.White
        Me.btnlinear.Location = New System.Drawing.Point(205, 131)
        Me.btnlinear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnlinear.Name = "btnlinear"
        Me.btnlinear.Size = New System.Drawing.Size(290, 60)
        Me.btnlinear.TabIndex = 55
        Me.btnlinear.Text = "Linear mode"
        Me.ToolTip.SetToolTip(Me.btnlinear, "Play linear mode")
        Me.btnlinear.UseVisualStyleBackColor = False
        '
        'btnplaycloseexpand
        '
        Me.btnplaycloseexpand.Interval = 20
        '
        'btnlinearfreeexpand
        '
        Me.btnlinearfreeexpand.Interval = 20
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
        'frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(700, 220)
        Me.Controls.Add(Me.btnplay)
        Me.Controls.Add(Me.btnlinear)
        Me.Controls.Add(Me.btnfree)
        Me.Controls.Add(Me.rect)
        Me.Controls.Add(Me.btnhowtoplay)
        Me.Controls.Add(Me.btnsettings)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnminimise)
        Me.Controls.Add(Me.btnpressmenu3)
        Me.Controls.Add(Me.btnpressmenu2)
        Me.Controls.Add(Me.btnpressmenu1)
        Me.Controls.Add(Me.picboxmenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "1"
        CType(Me.picboxmenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnsettings As Button
    Friend WithEvents picboxmenu As PictureBox
    Friend WithEvents btnhowtoplay As Button
    Friend WithEvents btnplay As Button
    Friend WithEvents btnminimise As Button
    Friend WithEvents btnpressmenu1 As Button
    Friend WithEvents timerlocationmenu1 As Timer
    Friend WithEvents btnpressmenu2 As Button
    Friend WithEvents timerlocationmenu2 As Timer
    Friend WithEvents timerlocationmenu3 As Timer
    Friend WithEvents btnpressmenu3 As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents expand As Timer
    Friend WithEvents rect As Button
    Friend WithEvents expandclosehowtoplay As Timer
    Friend WithEvents expandclosesetting As Timer
    Friend WithEvents btnfree As Button
    Friend WithEvents btnlinear As Button
    Friend WithEvents btnplaycloseexpand As Timer
    Friend WithEvents btnlinearfreeexpand As Timer
    Friend WithEvents ToolTip As ToolTip
End Class
