<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmhighscores
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
        Me.lblhighscorenum = New System.Windows.Forms.Label()
        Me.rect = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblhighscorenum
        '
        Me.lblhighscorenum.AutoSize = True
        Me.lblhighscorenum.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblhighscorenum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblhighscorenum.Font = New System.Drawing.Font("Segoe UI", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhighscorenum.ForeColor = System.Drawing.Color.White
        Me.lblhighscorenum.Location = New System.Drawing.Point(3, 71)
        Me.lblhighscorenum.Name = "lblhighscorenum"
        Me.lblhighscorenum.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblhighscorenum.Size = New System.Drawing.Size(88, 106)
        Me.lblhighscorenum.TabIndex = 9
        Me.lblhighscorenum.Text = "0"
        Me.lblhighscorenum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.rect.Font = New System.Drawing.Font("Segoe UI Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rect.ForeColor = System.Drawing.Color.White
        Me.rect.Location = New System.Drawing.Point(-56, 12)
        Me.rect.Name = "rect"
        Me.rect.Size = New System.Drawing.Size(165, 42)
        Me.rect.TabIndex = 53
        Me.rect.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(-2, 18)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 30)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Highscore"
        '
        'frmhighscores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(236, 215)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblhighscorenum)
        Me.Controls.Add(Me.rect)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmhighscores"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmhighscores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblhighscorenum As Label
    Friend WithEvents rect As Button
    Friend WithEvents Label7 As Label
End Class
