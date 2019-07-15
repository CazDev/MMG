<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLinearPrefs
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnreaction = New System.Windows.Forms.Button()
        Me.btnprogressive = New System.Windows.Forms.Button()
        Me.btneasy = New System.Windows.Forms.Button()
        Me.btnimpossible = New System.Windows.Forms.Button()
        Me.btnextreme = New System.Windows.Forms.Button()
        Me.btnhard = New System.Windows.Forms.Button()
        Me.btnmedium = New System.Windows.Forms.Button()
        Me.rect = New System.Windows.Forms.Button()
        Me.LblTimeToClick = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblShapeSize = New System.Windows.Forms.Label()
        Me.LabelUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbltimelimit = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.CheckForTimeSync = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(420, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 30)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Difficulty"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(736, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 30)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Mode"
        '
        'btnreaction
        '
        Me.btnreaction.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnreaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnreaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnreaction.FlatAppearance.BorderSize = 0
        Me.btnreaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreaction.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreaction.ForeColor = System.Drawing.Color.White
        Me.btnreaction.Location = New System.Drawing.Point(698, 74)
        Me.btnreaction.Name = "btnreaction"
        Me.btnreaction.Size = New System.Drawing.Size(144, 42)
        Me.btnreaction.TabIndex = 57
        Me.btnreaction.Text = "Reaction"
        Me.ToolTip.SetToolTip(Me.btnreaction, "Gamemode presets (click to change)")
        Me.btnreaction.UseVisualStyleBackColor = False
        '
        'btnprogressive
        '
        Me.btnprogressive.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnprogressive.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnprogressive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprogressive.FlatAppearance.BorderSize = 0
        Me.btnprogressive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprogressive.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprogressive.ForeColor = System.Drawing.Color.White
        Me.btnprogressive.Location = New System.Drawing.Point(698, 74)
        Me.btnprogressive.Name = "btnprogressive"
        Me.btnprogressive.Size = New System.Drawing.Size(144, 42)
        Me.btnprogressive.TabIndex = 58
        Me.btnprogressive.Text = "Progressive"
        Me.ToolTip.SetToolTip(Me.btnprogressive, "Gamemode presets (click to change)")
        Me.btnprogressive.UseVisualStyleBackColor = False
        '
        'btneasy
        '
        Me.btneasy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btneasy.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btneasy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneasy.FlatAppearance.BorderSize = 0
        Me.btneasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneasy.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneasy.ForeColor = System.Drawing.Color.White
        Me.btneasy.Location = New System.Drawing.Point(392, 74)
        Me.btneasy.Name = "btneasy"
        Me.btneasy.Size = New System.Drawing.Size(144, 42)
        Me.btneasy.TabIndex = 59
        Me.btneasy.Text = "Easy"
        Me.ToolTip.SetToolTip(Me.btneasy, "Preset difficulty (click to change)")
        Me.btneasy.UseVisualStyleBackColor = False
        '
        'btnimpossible
        '
        Me.btnimpossible.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnimpossible.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnimpossible.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnimpossible.FlatAppearance.BorderSize = 0
        Me.btnimpossible.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnimpossible.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimpossible.ForeColor = System.Drawing.Color.White
        Me.btnimpossible.Location = New System.Drawing.Point(392, 74)
        Me.btnimpossible.Name = "btnimpossible"
        Me.btnimpossible.Size = New System.Drawing.Size(144, 42)
        Me.btnimpossible.TabIndex = 63
        Me.btnimpossible.Text = "Impossible"
        Me.ToolTip.SetToolTip(Me.btnimpossible, "Preset difficulty (click to change)")
        Me.btnimpossible.UseVisualStyleBackColor = False
        '
        'btnextreme
        '
        Me.btnextreme.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnextreme.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnextreme.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnextreme.FlatAppearance.BorderSize = 0
        Me.btnextreme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnextreme.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnextreme.ForeColor = System.Drawing.Color.White
        Me.btnextreme.Location = New System.Drawing.Point(392, 74)
        Me.btnextreme.Name = "btnextreme"
        Me.btnextreme.Size = New System.Drawing.Size(144, 42)
        Me.btnextreme.TabIndex = 62
        Me.btnextreme.Text = "Extreme"
        Me.ToolTip.SetToolTip(Me.btnextreme, "Preset difficulty (click to change)")
        Me.btnextreme.UseVisualStyleBackColor = False
        '
        'btnhard
        '
        Me.btnhard.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnhard.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnhard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhard.FlatAppearance.BorderSize = 0
        Me.btnhard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhard.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhard.ForeColor = System.Drawing.Color.White
        Me.btnhard.Location = New System.Drawing.Point(392, 74)
        Me.btnhard.Name = "btnhard"
        Me.btnhard.Size = New System.Drawing.Size(144, 42)
        Me.btnhard.TabIndex = 61
        Me.btnhard.Text = "Hard"
        Me.ToolTip.SetToolTip(Me.btnhard, "Preset difficulty (click to change)")
        Me.btnhard.UseVisualStyleBackColor = False
        '
        'btnmedium
        '
        Me.btnmedium.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmedium.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnmedium.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmedium.FlatAppearance.BorderSize = 0
        Me.btnmedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmedium.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmedium.ForeColor = System.Drawing.Color.White
        Me.btnmedium.Location = New System.Drawing.Point(392, 74)
        Me.btnmedium.Name = "btnmedium"
        Me.btnmedium.Size = New System.Drawing.Size(144, 42)
        Me.btnmedium.TabIndex = 60
        Me.btnmedium.Text = "Medium"
        Me.ToolTip.SetToolTip(Me.btnmedium, "Preset difficulty (click to change)")
        Me.btnmedium.UseVisualStyleBackColor = False
        '
        'rect
        '
        Me.rect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rect.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.rect.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.rect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.rect.FlatAppearance.BorderSize = 0
        Me.rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rect.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rect.ForeColor = System.Drawing.Color.White
        Me.rect.Location = New System.Drawing.Point(2, 12)
        Me.rect.Name = "rect"
        Me.rect.Size = New System.Drawing.Size(1248, 42)
        Me.rect.TabIndex = 53
        Me.rect.UseVisualStyleBackColor = False
        '
        'LblTimeToClick
        '
        Me.LblTimeToClick.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.LblTimeToClick.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTimeToClick.ForeColor = System.Drawing.Color.White
        Me.LblTimeToClick.Location = New System.Drawing.Point(207, 92)
        Me.LblTimeToClick.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTimeToClick.Name = "LblTimeToClick"
        Me.LblTimeToClick.Size = New System.Drawing.Size(130, 55)
        Me.LblTimeToClick.TabIndex = 64
        Me.LblTimeToClick.Text = "2000"
        Me.LblTimeToClick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.LblTimeToClick, "TimeToClick (Miliseconds)")
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(210, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 30)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "TimeToClick"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(878, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 30)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Shape Size"
        '
        'LblShapeSize
        '
        Me.LblShapeSize.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.LblShapeSize.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShapeSize.ForeColor = System.Drawing.Color.White
        Me.LblShapeSize.Location = New System.Drawing.Point(873, 92)
        Me.LblShapeSize.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblShapeSize.Name = "LblShapeSize"
        Me.LblShapeSize.Size = New System.Drawing.Size(130, 55)
        Me.LblShapeSize.TabIndex = 66
        Me.LblShapeSize.Text = "300"
        Me.LblShapeSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.LblShapeSize, "Shape size (Pixels)")
        '
        'LabelUpdate
        '
        Me.LabelUpdate.Enabled = True
        Me.LabelUpdate.Interval = 50
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(566, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 30)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Time Limit"
        '
        'lbltimelimit
        '
        Me.lbltimelimit.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lbltimelimit.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltimelimit.ForeColor = System.Drawing.Color.White
        Me.lbltimelimit.Location = New System.Drawing.Point(551, 92)
        Me.lbltimelimit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltimelimit.Name = "lbltimelimit"
        Me.lbltimelimit.Size = New System.Drawing.Size(124, 55)
        Me.lbltimelimit.TabIndex = 70
        Me.lbltimelimit.Text = "30"
        Me.lbltimelimit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip.SetToolTip(Me.lbltimelimit, "Game time limit (Seconds)")
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
        Me.ToolTip.ShowAlways = True
        '
        'CheckForTimeSync
        '
        Me.CheckForTimeSync.Enabled = True
        Me.CheckForTimeSync.Interval = 5
        '
        'FrmLinearPrefs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1250, 215)
        Me.Controls.Add(Me.lbltimelimit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblShapeSize)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblTimeToClick)
        Me.Controls.Add(Me.btneasy)
        Me.Controls.Add(Me.btnimpossible)
        Me.Controls.Add(Me.btnextreme)
        Me.Controls.Add(Me.btnhard)
        Me.Controls.Add(Me.btnmedium)
        Me.Controls.Add(Me.btnprogressive)
        Me.Controls.Add(Me.btnreaction)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rect)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLinearPrefs"
        Me.Text = "FrmLinearPrefs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnreaction As Button
    Friend WithEvents btnprogressive As Button
    Friend WithEvents btneasy As Button
    Friend WithEvents btnimpossible As Button
    Friend WithEvents btnextreme As Button
    Friend WithEvents btnhard As Button
    Friend WithEvents btnmedium As Button
    Friend WithEvents rect As Button
    Friend WithEvents LblTimeToClick As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblShapeSize As Label
    Friend WithEvents LabelUpdate As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents lbltimelimit As Label
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents CheckForTimeSync As Timer
End Class
