Public Class circle1
    Public btnpressound1

    'circle initialise
    Public Sub New()
        InitializeComponent()
        Me.FormBorderStyle = FormBorderStyle.None

        If GameVariables.DoubleBuffering = True Then
            Me.DoubleBuffered = True
        End If

    End Sub

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)

        'makes form into circle shape by only drawing 150,150 elipse of the form
        Using path As New System.Drawing.Drawing2D.GraphicsPath
            path.AddEllipse(0, 0, 150, 150)
            Me.Region = New Region(path)
        End Using
        MyBase.OnLoad(e)

    End Sub

    Private Sub btncircle1_Click(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left = True Then
            GameEvents.CircleClickChangeLocation1()
        End If
    End Sub

    Private Sub btncircle1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.lbltimeleft1.Location = New Point(-13, 40)
    End Sub

    Private Sub lbltimeleft1_Click(sender As Object, e As EventArgs) Handles lbltimeleft1.MouseDown
        'Sends click to shape if label is pressed
        btncircle1_Click(sender, e)
    End Sub

    Public Shared Sub CenterScreen()
        Try
            circle1.Location = New Point((frmgame.Width - square1.Width) \ 2,
                             (frmgame.Height - square1.Height) \ 2)
        Catch
        End Try
    End Sub

    Private Sub circle1_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        If GameVariables.ReactionMode = True Then
            GameEvents.CircleClickChangeLocation1()
        End If
    End Sub
End Class