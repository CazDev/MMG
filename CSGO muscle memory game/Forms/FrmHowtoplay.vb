Public Class frmhowtoplay
    Public expanding = True
    Public closeexpanding = True

#Region " Move Form "

    Public MoveForm1 As Boolean
    Public MoveForm1_MousePosition1 As Point

    Public Sub MoveForm1_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    rect.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm1 = True
            MoveForm1_MousePosition1 = e.Location
        End If
    End Sub

    Public Sub MoveForm1_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    rect.MouseMove

        If MoveForm1 Then
            Me.Location = Me.Location + (e.Location - MoveForm1_MousePosition1)
        End If
    End Sub

    Public Sub MoveForm1_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    rect.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm1 = False
        End If
    End Sub
#End Region

#Region "Load"
    Private Sub frmhowtoplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Size = frmmenu.Size
        Me.Location = frmmenu.Location
        Me.Height = 50
        Me.Show()
        Me.expand.Enabled = True
        Me.expanding = True

    End Sub
#End Region

#Region "Close form"
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click

        expandclose.Enabled = True
        closeexpanding = True

        If GameVariables.soundfx = True Then
            My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        End If

    End Sub
#End Region

#Region "Expand Animation"
    Private Sub expand_Tick(sender As Object, e As EventArgs) Handles expand.Tick

        If Me.Size.Height = 270 Then
            expanding = False
            frmmenu.Hide()
            expand.Enabled = False

        Else

            expanding = True
            Me.Height += 20
        End If

    End Sub
#End Region

#Region "Close Expand Animation"
    Private Sub expandclose_Tick(sender As Object, e As EventArgs) Handles expandclose.Tick

        If Me.Size.Height = 50 Then
            frmmenu.Height = 50
            frmmenu.btnplay.Height = 0
            frmmenu.btnsettings.Height = 0
            frmmenu.btnhowtoplay.Height = 0
            frmmenu.expandingbtnplay = True
            frmmenu.expandingbtnside = True
            frmmenu.expand.Enabled = True
            frmmenu.expanding = True
            frmmenu.Show()
            closeexpanding = False
            expandclose.Enabled = False
            frmmenu.Location = Me.Location

        Else

            closeexpanding = True
            Me.Height -= 20
        End If

    End Sub

#End Region

    Private Sub VScrollBar_ValueChanged(sender As Object, e As EventArgs) Handles VScrollBar.ValueChanged

        txthowtoplay.Location = New Point(9, -VScrollBar.Value + 35)

    End Sub

End Class