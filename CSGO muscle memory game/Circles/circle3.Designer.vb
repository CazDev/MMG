<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class circle3
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
        Me.lbltimeleft3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbltimeleft3
        '
        Me.lbltimeleft3.BackColor = System.Drawing.Color.Transparent
        Me.lbltimeleft3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.lbltimeleft3.ForeColor = System.Drawing.Color.White
        Me.lbltimeleft3.Location = New System.Drawing.Point(51, 38)
        Me.lbltimeleft3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltimeleft3.Name = "lbltimeleft3"
        Me.lbltimeleft3.Size = New System.Drawing.Size(264, 100)
        Me.lbltimeleft3.TabIndex = 1
        Me.lbltimeleft3.Text = "1000"
        Me.lbltimeleft3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'circle3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1323, 978)
        Me.Controls.Add(Me.lbltimeleft3)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "circle3"
        Me.Text = "btncircle3"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbltimeleft3 As Label
End Class
