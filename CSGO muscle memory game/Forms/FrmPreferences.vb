Imports System
Imports System.Xml
Imports System.IO

Public Class FrmPreferences

#Region "Load"
    Private Sub frmsettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TopMost = True
        Me.Location = New Point(frmgame.Width - Me.Width - frmhighscores.Width, 29)
        frmgame.AddOwnedForm(Me)
        GameVariables.onesquare = True
        Me.BackColor = Color.FromArgb(1, 1, 1)
        Me.TransparencyKey = Me.BackColor
        txtsquaresize.Text = square1.Size.Width
        txttimetoclick.Text = frmgame.timerlocation1.Interval
    End Sub
#End Region

#Region "Difficulty buttons"
    Private Sub btneasy_Click(sender As Object, e As EventArgs) Handles btneasy.Click
        GameEvents.TimeToClickMedium()
    End Sub

    Private Sub btnmedium_Click(sender As Object, e As EventArgs) Handles btnmedium.Click
        GameEvents.TimeToClickHard()
    End Sub

    Private Sub btnhard_Click(sender As Object, e As EventArgs) Handles btnhard.Click
        GameEvents.TimeToClickExtreme()
    End Sub

    Private Sub btnextreme_Click(sender As Object, e As EventArgs) Handles btnextreme.Click
        GameEvents.TimeToClickImposible()
    End Sub

    Private Sub btnimpossible_Click(sender As Object, e As EventArgs) Handles btnimpossible.Click
        GameEvents.TimeToClickEasy()
    End Sub
#End Region

#Region "Size buttons"
    Private Sub btnmini_Click(sender As Object, e As EventArgs) Handles btnmini.Click
        'changes shape size to preset "mini"
        btnsmall.BringToFront()

        Dim f As New System.Drawing.Font("Segoe UI", 26.25)
        square1.lbltimeleft1.Font = f
        square2.lbltimeleft2.Font = f
        square3.lbltimeleft3.Font = f
        circle1.lbltimeleft1.Font = f
        circle2.lbltimeleft2.Font = f
        circle3.lbltimeleft3.Font = f

        square1.Size = New Size(150, 150)
        square2.Size = New Size(150, 150)
        square3.Size = New Size(150, 150)

        circle1.Size = New Size(150, 150)
        circle2.Size = New Size(150, 150)
        circle3.Size = New Size(150, 150)

        Using path As New System.Drawing.Drawing2D.GraphicsPath
            path.AddEllipse(0, 0, 150, 150)
            circle1.Region = New Region(path)
            circle2.Region = New Region(path)
            circle3.Region = New Region(path)
        End Using

        'centres lbltimeleft on btncircle's and btnsquare's
        circle1.lbltimeleft1.Top = (circle1.ClientSize.Height / 2) - (circle1.lbltimeleft1.Height / 2)
        circle1.lbltimeleft1.Left = (circle1.ClientSize.Width / 2) - (circle1.lbltimeleft1.Width / 2)
        circle2.lbltimeleft2.Top = (circle2.ClientSize.Height / 2) - (circle2.lbltimeleft2.Height / 2)
        circle2.lbltimeleft2.Left = (circle2.ClientSize.Width / 2) - (circle2.lbltimeleft2.Width / 2)
        circle3.lbltimeleft3.Top = (circle3.ClientSize.Height / 2) - (circle3.lbltimeleft3.Height / 2)
        circle3.lbltimeleft3.Left = (circle3.ClientSize.Width / 2) - (circle3.lbltimeleft3.Width / 2)

        square1.lbltimeleft1.Top = (square1.ClientSize.Height / 2) - (square1.lbltimeleft1.Height / 2)
        square1.lbltimeleft1.Left = (square1.ClientSize.Width / 2) - (square1.lbltimeleft1.Width / 2)
        square2.lbltimeleft2.Top = (square2.ClientSize.Height / 2) - (square2.lbltimeleft2.Height / 2)
        square2.lbltimeleft2.Left = (square2.ClientSize.Width / 2) - (square2.lbltimeleft2.Width / 2)
        square3.lbltimeleft3.Top = (square3.ClientSize.Height / 2) - (square3.lbltimeleft3.Height / 2)
        square3.lbltimeleft3.Left = (square3.ClientSize.Width / 2) - (square3.lbltimeleft3.Width / 2)

        txtsquaresize.Text = square1.Size.Width

        'centres btnsquare and btncircle
        GameEvents.CentreCircleAndSquare()
    End Sub

    Private Sub btnsmall_Click(sender As Object, e As EventArgs) Handles btnsmall.Click
        'changes shape size to preset "small"
        btnmedium1.BringToFront()

        Dim f As New System.Drawing.Font("Segoe UI", 28)
        square1.lbltimeleft1.Font = f
        square2.lbltimeleft2.Font = f
        square3.lbltimeleft3.Font = f
        circle1.lbltimeleft1.Font = f
        circle2.lbltimeleft2.Font = f
        circle3.lbltimeleft3.Font = f

        txtsquaresize.Text = square1.Size.Width

        square1.Size = New Size(200, 200)
        square2.Size = New Size(200, 200)
        square3.Size = New Size(200, 200)

        circle1.Size = New Size(200, 200)
        circle2.Size = New Size(200, 200)
        circle3.Size = New Size(200, 200)

        Using path As New System.Drawing.Drawing2D.GraphicsPath
            path.AddEllipse(0, 0, 200, 200)
            circle1.Region = New Region(path)
            circle2.Region = New Region(path)
            circle3.Region = New Region(path)
        End Using

        GameEvents.CentreCircleAndSquare()

        'centres lbltimeleft on btncircle's and btnsquare's
        circle1.lbltimeleft1.Top = (circle1.ClientSize.Height / 2) - (circle1.lbltimeleft1.Height / 2)
        circle1.lbltimeleft1.Left = (circle1.ClientSize.Width / 2) - (circle1.lbltimeleft1.Width / 2)
        circle2.lbltimeleft2.Top = (circle2.ClientSize.Height / 2) - (circle2.lbltimeleft2.Height / 2)
        circle2.lbltimeleft2.Left = (circle2.ClientSize.Width / 2) - (circle2.lbltimeleft2.Width / 2)
        circle3.lbltimeleft3.Top = (circle3.ClientSize.Height / 2) - (circle3.lbltimeleft3.Height / 2)
        circle3.lbltimeleft3.Left = (circle3.ClientSize.Width / 2) - (circle3.lbltimeleft3.Width / 2)

        square1.lbltimeleft1.Top = (square1.ClientSize.Height / 2) - (square1.lbltimeleft1.Height / 2)
        square1.lbltimeleft1.Left = (square1.ClientSize.Width / 2) - (square1.lbltimeleft1.Width / 2)
        square2.lbltimeleft2.Top = (square2.ClientSize.Height / 2) - (square2.lbltimeleft2.Height / 2)
        square2.lbltimeleft2.Left = (square2.ClientSize.Width / 2) - (square2.lbltimeleft2.Width / 2)
        square3.lbltimeleft3.Top = (square3.ClientSize.Height / 2) - (square3.lbltimeleft3.Height / 2)
        square3.lbltimeleft3.Left = (square3.ClientSize.Width / 2) - (square3.lbltimeleft3.Width / 2)
    End Sub

    Private Sub btnmedium1_Click(sender As Object, e As EventArgs) Handles btnmedium1.Click
        'changes shape size to preset "medium"
        btnlarge.BringToFront()

        Dim f As New System.Drawing.Font("Segoe UI", 32)
        square1.lbltimeleft1.Font = f
        square2.lbltimeleft2.Font = f
        square3.lbltimeleft3.Font = f
        circle1.lbltimeleft1.Font = f
        circle2.lbltimeleft2.Font = f
        circle3.lbltimeleft3.Font = f

        square1.Size = New Size(250, 250)
        square2.Size = New Size(250, 250)
        square3.Size = New Size(250, 250)

        circle1.Size = New Size(250, 250)
        circle2.Size = New Size(250, 250)
        circle3.Size = New Size(250, 250)

        Using path As New System.Drawing.Drawing2D.GraphicsPath
            path.AddEllipse(0, 0, 250, 250)
            circle1.Region = New Region(path)
            circle2.Region = New Region(path)
            circle3.Region = New Region(path)
        End Using

        'centres lbltimeleft on btncircle's and btnsquare's
        circle1.lbltimeleft1.Top = (circle1.ClientSize.Height / 2) - (circle1.lbltimeleft1.Height / 2)
        circle1.lbltimeleft1.Left = (circle1.ClientSize.Width / 2) - (circle1.lbltimeleft1.Width / 2)
        circle2.lbltimeleft2.Top = (circle2.ClientSize.Height / 2) - (circle2.lbltimeleft2.Height / 2)
        circle2.lbltimeleft2.Left = (circle2.ClientSize.Width / 2) - (circle2.lbltimeleft2.Width / 2)
        circle3.lbltimeleft3.Top = (circle3.ClientSize.Height / 2) - (circle3.lbltimeleft3.Height / 2)
        circle3.lbltimeleft3.Left = (circle3.ClientSize.Width / 2) - (circle3.lbltimeleft3.Width / 2)

        square1.lbltimeleft1.Top = (square1.ClientSize.Height / 2) - (square1.lbltimeleft1.Height / 2)
        square1.lbltimeleft1.Left = (square1.ClientSize.Width / 2) - (square1.lbltimeleft1.Width / 2)
        square2.lbltimeleft2.Top = (square2.ClientSize.Height / 2) - (square2.lbltimeleft2.Height / 2)
        square2.lbltimeleft2.Left = (square2.ClientSize.Width / 2) - (square2.lbltimeleft2.Width / 2)
        square3.lbltimeleft3.Top = (square3.ClientSize.Height / 2) - (square3.lbltimeleft3.Height / 2)
        square3.lbltimeleft3.Left = (square3.ClientSize.Width / 2) - (square3.lbltimeleft3.Width / 2)

        txtsquaresize.Text = square1.Size.Width

        GameEvents.CentreCircleAndSquare()
    End Sub

    Private Sub btnlarge_Click(sender As Object, e As EventArgs) Handles btnlarge.Click
        'changes shape size to preset "large"
        btnhuge.BringToFront()

        Dim f As New System.Drawing.Font("Segoe UI", 36)
        square1.lbltimeleft1.Font = f
        square2.lbltimeleft2.Font = f
        square3.lbltimeleft3.Font = f
        circle1.lbltimeleft1.Font = f
        circle2.lbltimeleft2.Font = f
        circle3.lbltimeleft3.Font = f

        square1.Size = New Size(300, 300)
        square2.Size = New Size(300, 300)
        square3.Size = New Size(300, 300)

        circle1.Size = New Size(300, 300)
        circle2.Size = New Size(300, 300)
        circle3.Size = New Size(300, 300)

        Using path As New System.Drawing.Drawing2D.GraphicsPath
            path.AddEllipse(0, 0, 300, 300)
            circle1.Region = New Region(path)
            circle2.Region = New Region(path)
            circle3.Region = New Region(path)
        End Using

        'centres lbltimeleft on btncircle's and btnsquare's
        circle1.lbltimeleft1.Top = (circle1.ClientSize.Height / 2) - (circle1.lbltimeleft1.Height / 2)
        circle1.lbltimeleft1.Left = (circle1.ClientSize.Width / 2) - (circle1.lbltimeleft1.Width / 2)
        circle2.lbltimeleft2.Top = (circle2.ClientSize.Height / 2) - (circle2.lbltimeleft2.Height / 2)
        circle2.lbltimeleft2.Left = (circle2.ClientSize.Width / 2) - (circle2.lbltimeleft2.Width / 2)
        circle3.lbltimeleft3.Top = (circle3.ClientSize.Height / 2) - (circle3.lbltimeleft3.Height / 2)
        circle3.lbltimeleft3.Left = (circle3.ClientSize.Width / 2) - (circle3.lbltimeleft3.Width / 2)

        square1.lbltimeleft1.Top = (square1.ClientSize.Height / 2) - (square1.lbltimeleft1.Height / 2)
        square1.lbltimeleft1.Left = (square1.ClientSize.Width / 2) - (square1.lbltimeleft1.Width / 2)
        square2.lbltimeleft2.Top = (square2.ClientSize.Height / 2) - (square2.lbltimeleft2.Height / 2)
        square2.lbltimeleft2.Left = (square2.ClientSize.Width / 2) - (square2.lbltimeleft2.Width / 2)
        square3.lbltimeleft3.Top = (square3.ClientSize.Height / 2) - (square3.lbltimeleft3.Height / 2)
        square3.lbltimeleft3.Left = (square3.ClientSize.Width / 2) - (square3.lbltimeleft3.Width / 2)

        txtsquaresize.Text = square1.Size.Width

        GameEvents.CentreCircleAndSquare()
    End Sub

    Private Sub btnhuge_Click(sender As Object, e As EventArgs) Handles btnhuge.Click
        'changes shape size to preset "huge"
        btnmini.BringToFront()

        Dim f As New System.Drawing.Font("Segoe UI", 20)
        square1.lbltimeleft1.Font = f
        square2.lbltimeleft2.Font = f
        square3.lbltimeleft3.Font = f
        circle1.lbltimeleft1.Font = f
        circle2.lbltimeleft2.Font = f
        circle3.lbltimeleft3.Font = f

        square1.Size = New Size(100, 100)
        square2.Size = New Size(100, 100)
        square3.Size = New Size(100, 100)

        circle1.Size = New Size(100, 100)
        circle2.Size = New Size(100, 100)
        circle3.Size = New Size(100, 100)

        Using path As New System.Drawing.Drawing2D.GraphicsPath
            path.AddEllipse(0, 0, 100, 100)
            circle1.Region = New Region(path)
            circle2.Region = New Region(path)
            circle3.Region = New Region(path)
        End Using

        'centres lbltimeleft on btncircle's and btnsquare's
        circle1.lbltimeleft1.Top = (circle1.ClientSize.Height / 2) - (circle1.lbltimeleft1.Height / 2)
        circle1.lbltimeleft1.Left = (circle1.ClientSize.Width / 2) - (circle1.lbltimeleft1.Width / 2)
        circle2.lbltimeleft2.Top = (circle2.ClientSize.Height / 2) - (circle2.lbltimeleft2.Height / 2)
        circle2.lbltimeleft2.Left = (circle2.ClientSize.Width / 2) - (circle2.lbltimeleft2.Width / 2)
        circle3.lbltimeleft3.Top = (circle3.ClientSize.Height / 2) - (circle3.lbltimeleft3.Height / 2)
        circle3.lbltimeleft3.Left = (circle3.ClientSize.Width / 2) - (circle3.lbltimeleft3.Width / 2)

        square1.lbltimeleft1.Top = (square1.ClientSize.Height / 2) - (square1.lbltimeleft1.Height / 2)
        square1.lbltimeleft1.Left = (square1.ClientSize.Width / 2) - (square1.lbltimeleft1.Width / 2)
        square2.lbltimeleft2.Top = (square2.ClientSize.Height / 2) - (square2.lbltimeleft2.Height / 2)
        square2.lbltimeleft2.Left = (square2.ClientSize.Width / 2) - (square2.lbltimeleft2.Width / 2)
        square3.lbltimeleft3.Top = (square3.ClientSize.Height / 2) - (square3.lbltimeleft3.Height / 2)
        square3.lbltimeleft3.Left = (square3.ClientSize.Width / 2) - (square3.lbltimeleft3.Width / 2)

        txtsquaresize.Text = square1.Size.Width

        GameEvents.CentreCircleAndSquare()
    End Sub
#End Region

#Region "Number of shapes buttons"
    Private Sub btnone_Click(sender As Object, e As EventArgs) Handles btnone.Click
        'enables 1 shape
        btntwo.BringToFront()
        GameVariables.onesquare = False
        GameVariables.twosquare = True
        GameVariables.threesquare = False

        GameVariables.onecircle = False
        GameVariables.twocircle = True
        GameVariables.threecircle = False
        If GameVariables.squareenabled = True Then
            square1.Show()
            square2.Show()
            square3.Hide()
            square1.BringToFront()
            square2.BringToFront()
        End If
        If GameVariables.circleenabled = True Then
            circle1.Show()
            circle2.Show()
            circle3.Hide()
            circle1.BringToFront()
            circle2.BringToFront()
        End If
        square1.Text = frmgame.timerlocation1.Interval
        square2.Text = frmgame.timerlocation2.Interval
        square3.Text = frmgame.timerlocation3.Interval

        GameEvents.CentreCircleAndSquare()
    End Sub

    Private Sub btntwo_Click(sender As Object, e As EventArgs) Handles btntwo.Click
        'enables 2 shapes
        btnthree.BringToFront()
        GameVariables.onesquare = False
        GameVariables.twosquare = False
        GameVariables.threesquare = True

        GameVariables.onecircle = False
        GameVariables.twocircle = False
        GameVariables.threecircle = True
        If GameVariables.squareenabled = True Then
            square1.Show()
            square2.Show()
            square3.Show()
            square1.BringToFront()
            square2.BringToFront()
            square3.BringToFront()
        End If
        If GameVariables.circleenabled = True Then
            circle1.Show()
            circle2.Show()
            circle3.Show()
            circle1.BringToFront()
            circle2.BringToFront()
            circle3.BringToFront()
        End If
        square1.Text = frmgame.timerlocation1.Interval
        square2.Text = frmgame.timerlocation2.Interval
        square3.Text = frmgame.timerlocation3.Interval

        GameEvents.CentreCircleAndSquare()
    End Sub

    Private Sub btnthree_Click(sender As Object, e As EventArgs) Handles btnthree.Click
        'enables 3 shapes
        btnone.BringToFront()
        GameVariables.onesquare = True
        GameVariables.twosquare = False
        GameVariables.threesquare = False

        GameVariables.onecircle = True
        GameVariables.twocircle = False
        GameVariables.threecircle = False
        If GameVariables.squareenabled = True Then
            square1.Show()
            square2.Hide()
            square3.Hide()
            square1.BringToFront()
        End If
        If GameVariables.circleenabled = True Then
            circle1.Show()
            circle2.Hide()
            circle3.Hide()
            circle1.BringToFront()
        End If
        square1.Text = frmgame.timerlocation1.Interval
        square2.Text = frmgame.timerlocation2.Interval
        square3.Text = frmgame.timerlocation3.Interval

        GameEvents.CentreCircleAndSquare()
    End Sub
#End Region

#Region "Background change buttons"
    'changes background to preset backgrounds
    Private Sub btnspiral_Click(sender As Object, e As EventArgs) Handles btnspiral.Click
        btnsuperhex.BringToFront()
        If GameVariables.GifEnabled = True Then
            frmgame.picboxbackground.Image = My.Resources.CubeSlice
        End If
    End Sub

    Private Sub btnsuperhex_Click(sender As Object, e As EventArgs) Handles btnsuperhex.Click
        btngradient.BringToFront()
        frmgame.picboxbackground.Image = My.Resources.GrayGradient
    End Sub

    Private Sub btngradient_Click(sender As Object, e As EventArgs) Handles btngradient.Click
        btnabstract.BringToFront()
        frmgame.picboxbackground.Image = My.Resources.Abstract
    End Sub

    Private Sub btnabstract_Click(sender As Object, e As EventArgs) Handles btnabstract.Click
        btnblue.BringToFront()
        frmgame.picboxbackground.Image = Nothing
    End Sub

    Private Sub btnblue_Click(sender As Object, e As EventArgs) Handles btnblue.Click
        btnspiral.BringToFront()
        If GameVariables.GifEnabled = True Then
            frmgame.picboxbackground.Image = My.Resources.SlowSpiral
        End If
    End Sub
#End Region

#Region "Select background image"
    Private Sub btnselectimg_Click(sender As Object, e As EventArgs) Handles btnselectimg.Click
        'open image: file dialogue using image file extensions
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Select Image"
        fd.InitialDirectory = ""
        fd.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        fd.FilterIndex = 1
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            frmgame.picboxbackground.ImageLocation = (fd.FileName)
            frmgame.picboxbackground.Load()
        End If
    End Sub
#End Region

#Region "Shape Type"
    Private Sub btncircle_Click(sender As Object, e As EventArgs) Handles btncircle.Click
        btnsquare.BringToFront()
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
        circle1.Hide()
        circle2.Hide()
        circle3.Hide()

        GameEvents.CentreCircleAndSquare()

        GameVariables.squareenabled = True
        GameVariables.circleenabled = False
    End Sub

    Private Sub btnsquare_Click(sender As Object, e As EventArgs) Handles btnsquare.Click
        btncircle.BringToFront()
        If GameVariables.onecircle = True Then
            circle1.Show()
            circle2.Hide()
            circle3.Hide()
        End If
        If GameVariables.twocircle = True Then
            circle1.Show()
            circle2.Show()
            circle3.Hide()
        End If
        If GameVariables.threecircle = True Then
            circle1.Show()
            circle2.Show()
            circle3.Show()
        End If
        square1.Hide()
        square2.Hide()
        square3.Hide()

        GameVariables.circleenabled = True
        GameVariables.squareenabled = False

        GameEvents.CentreCircleAndSquare()
    End Sub
#End Region

#Region "Random Colour button"
    Private Sub btnshaperandom_Click(sender As Object, e As EventArgs) Handles btnshaperandom.Click
        Dim rnd As New Random
        Dim rndcol = Color.FromArgb(&HFF000000 Or rnd.Next(&HFFFFFF + 1))
        circle1.BackColor = rndcol
        circle2.BackColor = rndcol
        circle3.BackColor = rndcol

        square1.BackColor = rndcol
        square2.BackColor = rndcol
        square3.BackColor = rndcol
    End Sub
#End Region

#Region "Shape colour"
    Private Sub btngreen1_Click(sender As Object, e As EventArgs) Handles btngreen1.Click
        Me.btnyellow1.BringToFront()
        square1.BackColor = Color.Yellow
        square2.BackColor = Color.Yellow
        square3.BackColor = Color.Yellow

        circle1.BackColor = Color.Yellow
        circle2.BackColor = Color.Yellow
        circle3.BackColor = Color.Yellow
    End Sub

    Private Sub btnyellow1_Click(sender As Object, e As EventArgs) Handles btnyellow1.Click
        Me.btnred1.BringToFront()
        square1.BackColor = Color.Red
        square2.BackColor = Color.Red
        square3.BackColor = Color.Red

        circle1.BackColor = Color.Red
        circle2.BackColor = Color.Red
        circle3.BackColor = Color.Red
    End Sub

    Private Sub btnred1_Click(sender As Object, e As EventArgs) Handles btnred1.Click
        Me.btnblue1.BringToFront()
        square1.BackColor = Color.Blue
        square2.BackColor = Color.Blue
        square3.BackColor = Color.Blue

        circle1.BackColor = Color.Blue
        circle2.BackColor = Color.Blue
        circle3.BackColor = Color.Blue
    End Sub

    Private Sub btnblue1_Click(sender As Object, e As EventArgs) Handles btnblue1.Click
        Me.btndefault1.BringToFront()
        square1.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFFF)
        square2.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFFF)
        square3.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFFF)

        circle1.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFFF)
        circle2.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFFF)
        circle3.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFFF)
    End Sub

    Private Sub btndefault1_Click(sender As Object, e As EventArgs) Handles btndefault1.Click
        Me.btngreen1.BringToFront()
        square1.BackColor = Color.FromArgb(68, 85, 105)
        square2.BackColor = Color.FromArgb(68, 85, 105)
        square3.BackColor = Color.FromArgb(68, 85, 105)

        circle1.BackColor = Color.FromArgb(68, 85, 105)
        circle2.BackColor = Color.FromArgb(68, 85, 105)
        circle3.BackColor = Color.FromArgb(68, 85, 105)
    End Sub
#End Region

#Region "Change colour on click"
    Private Sub changecolourtrue_Click(sender As Object, e As EventArgs) Handles btnchangecolourtrue.Click
        btnchangecolourfalse.BringToFront()
        GameVariables.changecolouronclick = False
    End Sub

    Private Sub changecolourfalse_Click(sender As Object, e As EventArgs) Handles btnchangecolourfalse.Click
        btnchangecolourtrue.BringToFront()
        GameVariables.changecolouronclick = True
    End Sub
#End Region

#Region "Sound mute/unmute"
    Private Sub btnsoundtrue_Click(sender As Object, e As EventArgs) Handles btnsoundtrue.Click
        btnsoundfalse.BringToFront()
        GameVariables.soundfx = True
    End Sub

    Private Sub btnsoundfalse_Click(sender As Object, e As EventArgs) Handles btnsoundfalse.Click
        btnsoundtrue.BringToFront()
        GameVariables.soundfx = False
    End Sub
#End Region

#Region "Reset all button"
    Private Sub btnresetall_Click(sender As Object, e As EventArgs) Handles btnresetall.Click

        GameEvents.ResetAllPreferences()

    End Sub
#End Region

#Region "Square size parse value to integer"
    Private Sub txtsquaresize_TextChanged(sender As Object, e As EventArgs) Handles txtsquaresize.TextChanged

        GameEvents.CentreCircleAndSquare()

        Try

            square1.Size = New Size(txtsquaresize.Text, txtsquaresize.Text)
            square2.Size = New Size(txtsquaresize.Text, txtsquaresize.Text)
            square3.Size = New Size(txtsquaresize.Text, txtsquaresize.Text)

            Using path As New System.Drawing.Drawing2D.GraphicsPath
                path.AddEllipse(0, 0, Integer.Parse(txtsquaresize.Text), Integer.Parse(txtsquaresize.Text))
                circle1.Region = New Region(path)
                path.AddEllipse(0, 0, Integer.Parse(txtsquaresize.Text), Integer.Parse(txtsquaresize.Text))
                circle2.Region = New Region(path)
                path.AddEllipse(0, 0, Integer.Parse(txtsquaresize.Text), Integer.Parse(txtsquaresize.Text))
                circle3.Region = New Region(path)
            End Using

        Catch ex As Exception
            frmconsole.consoledialog.AppendText(vbNewLine)
            frmconsole.consoledialog.AppendText("Shape Size number not valid")
        End Try

    End Sub
#End Region

#Region "Time to click parse value to integer"
    Private Sub txttimetoclick_TextChanged(sender As Object, e As EventArgs) Handles txttimetoclick.TextChanged

        GameEvents.CentreCircleAndSquare()

        Try

            frmgame.timerlocation1.Interval = txttimetoclick.Text
            frmgame.timerlocation2.Interval = txttimetoclick.Text
            frmgame.timerlocation3.Interval = txttimetoclick.Text

            square1.lbltimeleft1.Text = txttimetoclick.Text
            square2.lbltimeleft2.Text = txttimetoclick.Text
            square3.lbltimeleft3.Text = txttimetoclick.Text

            circle1.lbltimeleft1.Text = txttimetoclick.Text
            circle2.lbltimeleft2.Text = txttimetoclick.Text
            circle3.lbltimeleft3.Text = txttimetoclick.Text

        Catch ex As Exception
            frmconsole.consoledialog.AppendText(vbNewLine)
            frmconsole.consoledialog.AppendText("Time To Clcik number not valid")
        End Try
    End Sub

    Private Sub btnpowerupslow_Click(sender As Object, e As EventArgs) Handles btnpowerupslow.Click
        'fast rate
        GameVariables.poweruprate = 20000
        btnpowerupfast.BringToFront()
    End Sub

    Private Sub btnpowerupfast_Click(sender As Object, e As EventArgs) Handles btnpowerupfast.Click
        'normal rate
        GameVariables.poweruprate = 35000
        btnpowerupnormal.BringToFront()
    End Sub

    Private Sub btnpowerupnormal_Click(sender As Object, e As EventArgs) Handles btnpowerupnormal.Click
        'slow rate
        GameVariables.poweruprate = 50000
        btnpowerupslow.BringToFront()
    End Sub
    'disable power ups
    Private Sub btnpowerupnone_Click(sender As Object, e As EventArgs) Handles btnpowerupnone.Click
        GameVariables.powerupenbaled = True
        btnpowerupall.BringToFront()
    End Sub
    'enable power ups
    Private Sub btnpowerupall_Click(sender As Object, e As EventArgs) Handles btnpowerupall.Click
        GameVariables.powerupenbaled = False
        btnpowerupnone.BringToFront()
    End Sub

#End Region

#Region "Textbox events to force only number input"

    Private Sub txttimetoclick_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttimetoclick.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtsquaresize_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsquaresize.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

#End Region

End Class