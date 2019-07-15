Public Class frmpanel

#Region "Load"
    Private Sub frmpanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'positions panel in game window and makes semi-transparent
        Me.Opacity = 0.5F
        Me.Size = New Size(frmgame.Width, frmhighscores.Height)
        Me.Location = New Point(frmgame.Width - Me.Width, 29)
        frmgame.AddOwnedForm(Me)
        Me.BringToFront()

    End Sub

    Private Sub frmpanel_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If GameVariables.Linear = False Then
            FrmPreferences.TopMost = True
        Else
            FrmLinearPrefs.TopMost = True
        End If

        frmhighscores.TopMost = True

    End Sub
#End Region

End Class