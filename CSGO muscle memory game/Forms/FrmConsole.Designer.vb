<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmconsole
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmconsole))
        Me.btnclose = New System.Windows.Forms.Button()
        Me.rect = New System.Windows.Forms.Button()
        Me.consoleinput = New System.Windows.Forms.ComboBox()
        Me.consoledialog = New System.Windows.Forms.RichTextBox()
        Me.TmrAimbot = New System.Windows.Forms.Timer(Me.components)
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
        Me.btnclose.Location = New System.Drawing.Point(932, 5)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(39, 38)
        Me.btnclose.TabIndex = 57
        Me.btnclose.Text = "X"
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
        Me.rect.Size = New System.Drawing.Size(914, 38)
        Me.rect.TabIndex = 58
        Me.rect.Text = "Muscle Memory Game - Console"
        Me.rect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rect.UseVisualStyleBackColor = False
        '
        'consoleinput
        '
        Me.consoleinput.BackColor = System.Drawing.Color.Black
        Me.consoleinput.DropDownHeight = 100
        Me.consoleinput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.consoleinput.Font = New System.Drawing.Font("Consolas", 9.75!)
        Me.consoleinput.ForeColor = System.Drawing.Color.White
        Me.consoleinput.FormattingEnabled = True
        Me.consoleinput.IntegralHeight = False
        Me.consoleinput.Items.AddRange(New Object() {"background-colour", "config-edit", "config-exec", "config-view", "open-game", "open-howtoplay", "open-menu", "reset-all-settings", "run-time-game", "run-time-instance", "shape-change-colour-onclick", "shape-colour", "shape-size", "shape-size-uneven", "shape-type", "time-to-click-easy", "time-to-click-extreme", "time-to-click-hard", "time-to-click-impossible", "time-to-click-medium", "UI-Scale-Banner"})
        Me.consoleinput.Location = New System.Drawing.Point(12, 331)
        Me.consoleinput.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.consoleinput.MaxDropDownItems = 9
        Me.consoleinput.Name = "consoleinput"
        Me.consoleinput.Size = New System.Drawing.Size(956, 31)
        Me.consoleinput.Sorted = True
        Me.consoleinput.TabIndex = 60
        '
        'consoledialog
        '
        Me.consoledialog.BackColor = System.Drawing.Color.Black
        Me.consoledialog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.consoledialog.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.consoledialog.DetectUrls = False
        Me.consoledialog.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.consoledialog.ForeColor = System.Drawing.Color.White
        Me.consoledialog.Location = New System.Drawing.Point(12, 51)
        Me.consoledialog.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.consoledialog.Name = "consoledialog"
        Me.consoledialog.ReadOnly = True
        Me.consoledialog.Size = New System.Drawing.Size(958, 271)
        Me.consoledialog.TabIndex = 61
        Me.consoledialog.Text = "MMG Console dialog" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TmrAimbot
        '
        '
        'frmconsole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(982, 385)
        Me.Controls.Add(Me.consoledialog)
        Me.Controls.Add(Me.consoleinput)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.rect)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmconsole"
        Me.RightToLeftLayout = True
        Me.Text = "frmmenusettings"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnclose As Button
    Friend WithEvents rect As Button
    Friend WithEvents consoleinput As ComboBox
    Friend WithEvents consoledialog As RichTextBox
    Friend WithEvents TmrAimbot As Timer
End Class
