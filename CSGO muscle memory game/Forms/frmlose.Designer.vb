<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmlose
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
        Me.btntryagain = New System.Windows.Forms.Button()
        Me.timerclose = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btntryagain
        '
        Me.btntryagain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btntryagain.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btntryagain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntryagain.FlatAppearance.BorderSize = 0
        Me.btntryagain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntryagain.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntryagain.ForeColor = System.Drawing.Color.White
        Me.btntryagain.Location = New System.Drawing.Point(15, 15)
        Me.btntryagain.Name = "btntryagain"
        Me.btntryagain.Size = New System.Drawing.Size(225, 100)
        Me.btntryagain.TabIndex = 3
        Me.btntryagain.Text = "You lose" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Try again"
        Me.btntryagain.UseVisualStyleBackColor = False
        '
        'timerclose
        '
        Me.timerclose.Enabled = True
        Me.timerclose.Interval = 1500
        '
        'frmlose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(255, 131)
        Me.Controls.Add(Me.btntryagain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmlose"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btntryagain As Button
    Friend WithEvents timerclose As Timer
End Class
