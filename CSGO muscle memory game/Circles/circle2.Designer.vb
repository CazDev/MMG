<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class circle2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbltimeleft2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbltimeleft2
        '
        Me.lbltimeleft2.BackColor = System.Drawing.Color.Transparent
        Me.lbltimeleft2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.lbltimeleft2.Location = New System.Drawing.Point(69, 63)
        Me.lbltimeleft2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltimeleft2.Name = "lbltimeleft2"
        Me.lbltimeleft2.Size = New System.Drawing.Size(264, 100)
        Me.lbltimeleft2.TabIndex = 1
        Me.lbltimeleft2.Text = "1000"
        Me.lbltimeleft2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'circle2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1330, 957)
        Me.Controls.Add(Me.lbltimeleft2)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "circle2"
        Me.Text = "btncircle2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbltimeleft2 As Label
End Class
