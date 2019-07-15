<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmhowtoplay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmhowtoplay))
        Me.btnclose = New System.Windows.Forms.Button()
        Me.expand = New System.Windows.Forms.Timer(Me.components)
        Me.rect = New System.Windows.Forms.Button()
        Me.txthowtoplay = New System.Windows.Forms.RichTextBox()
        Me.expandclose = New System.Windows.Forms.Timer(Me.components)
        Me.VScrollBar = New ns1.BunifuVTrackbar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Firebrick
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Location = New System.Drawing.Point(878, 5)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(156, 38)
        Me.btnclose.TabIndex = 8
        Me.btnclose.Text = "Back"
        Me.btnclose.UseVisualStyleBackColor = False
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
        Me.rect.Location = New System.Drawing.Point(12, 5)
        Me.rect.Name = "rect"
        Me.rect.Size = New System.Drawing.Size(855, 38)
        Me.rect.TabIndex = 54
        Me.rect.Text = "Muscle Memory Game - How to play"
        Me.rect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rect.UseVisualStyleBackColor = False
        '
        'txthowtoplay
        '
        Me.txthowtoplay.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txthowtoplay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txthowtoplay.DetectUrls = False
        Me.txthowtoplay.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthowtoplay.ForeColor = System.Drawing.Color.White
        Me.txthowtoplay.Location = New System.Drawing.Point(12, 54)
        Me.txthowtoplay.Name = "txthowtoplay"
        Me.txthowtoplay.ReadOnly = True
        Me.txthowtoplay.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txthowtoplay.Size = New System.Drawing.Size(968, 480)
        Me.txthowtoplay.TabIndex = 55
        Me.txthowtoplay.Text = resources.GetString("txthowtoplay.Text")
        '
        'expandclose
        '
        Me.expandclose.Interval = 20
        '
        'VScrollBar
        '
        Me.VScrollBar.BackColor = System.Drawing.Color.Transparent
        Me.VScrollBar.BackgroudColor = System.Drawing.Color.DarkGray
        Me.VScrollBar.BorderRadius = 0
        Me.VScrollBar.IndicatorColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.VScrollBar.Location = New System.Drawing.Point(994, 54)
        Me.VScrollBar.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.VScrollBar.MaximumValue = 200
        Me.VScrollBar.Name = "VScrollBar"
        Me.VScrollBar.Size = New System.Drawing.Size(40, 345)
        Me.VScrollBar.SliderRadius = 0
        Me.VScrollBar.TabIndex = 65
        Me.VScrollBar.Value = 0
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(4, -3)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1029, 52)
        Me.Panel2.TabIndex = 66
        '
        'frmhowtoplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1050, 1043)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.rect)
        Me.Controls.Add(Me.VScrollBar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txthowtoplay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmhowtoplay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmhowtoplay"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnclose As Button
    Friend WithEvents expand As Timer
    Friend WithEvents rect As Button
    Friend WithEvents txthowtoplay As RichTextBox
    Friend WithEvents expandclose As Timer
    Friend WithEvents VScrollBar As ns1.BunifuVTrackbar
    Friend WithEvents Panel2 As Panel
End Class
