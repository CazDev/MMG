Public Class frmlose

    Private Sub frmlose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'creates transparent background of form only showing button
        frmgame.AddOwnedForm(Me)
        Me.TopMost = True
        Me.BackColor = Color.FromArgb(8, 45, 92)
        Me.TransparencyKey = Me.BackColor
        Me.timerclose.Enabled = True
    End Sub

    Private Sub btntryagain_Click_1(sender As Object, e As EventArgs) Handles btntryagain.Click
        Me.Hide()
        'checks if square is enabled
        If GameVariables.squareenabled = True Then

            If GameVariables.onesquare = True Then
                square1.Show()
                square2.Hide()
                square3.Hide()
            End If

            If GameVariables.twosquare = True Then
                square1.Show()
                square2.Show()
                square3.Hide()
            End If

            If GameVariables.threesquare = True Then
                square1.Show()
                square2.Show()
                square3.Show()
            End If
        End If

        'check if circle is enabled
        If GameVariables.circleenabled = True Then
            If GameVariables.onesquare = True Then
                circle1.Show()
                circle2.Hide()
                circle3.Hide()
            End If

            If GameVariables.twosquare = True Then
                circle1.Show()
                circle2.Show()
                circle3.Hide()
            End If

            If GameVariables.threesquare = True Then
                circle1.Show()
                circle2.Show()
                circle3.Show()
            End If
        End If

    End Sub
End Class