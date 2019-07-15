Public Class frmhighscores

    Public Sub frmhighscores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.Location = New Point(frmgame.Width - Me.Width, 29)
        Me.BackColor = Color.FromArgb(1, 1, 1)
        Me.TransparencyKey = Me.BackColor
    End Sub
End Class