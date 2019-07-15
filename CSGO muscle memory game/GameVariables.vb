Public Class GameVariables
#Region "PreferencesVariables"
    Public Shared BannerUIScaling As Double = 1

    Public Shared squaresize As String
    Public Shared timetoclick As String

    Public Shared onesquare As Boolean
    Public Shared twosquare As Boolean
    Public Shared threesquare As Boolean

    Public Shared onecircle As Boolean
    Public Shared twocircle As Boolean
    Public Shared threecircle As Boolean

    Public Shared circleenabled As Boolean
    Public Shared squareenabled As Boolean

    Public Shared soundfx As Boolean

    Public Shared changecolouronclick As Boolean

    Public Shared poweruprate As Integer
    Public Shared powerupenbaled As Boolean = True

    Public Shared MaxLives As Integer = 3

    Public Shared WindowedMode As Boolean

    Public Shared LagCompensation As Boolean = True
#End Region

#Region "GameVariables"
    Public Shared cont1 As Control
    Public Shared cont2 As Control

    Public Shared btnfontsize As Integer = 11

    Public Shared currentscore As Integer = 0

    Public Shared Lives As Integer = 3

    Public Shared timeleft1 As Integer
    Public Shared timeleft2 As Integer
    Public Shared timeleft3 As Integer

    Public Shared btnpressound1 As Integer
    Public Shared btnpressound2 As Integer
    Public Shared btnpressound3 As Integer

    Public Shared highscoresound As Integer
    Public Shared highscoreshowing As Boolean = True

    Public Shared GameRunningTime As New Stopwatch()

    Public Shared ConfigArray As New ArrayList()

    Public Shared ShapeTimeCount1 As New Stopwatch
    Public Shared ShapeTimeCount2 As New Stopwatch
    Public Shared ShapeTimeCount3 As New Stopwatch

    Public Shared DoubleBuffering As Boolean

    Public Shared ConsoleBind As Boolean

    Public Shared PauseBind As Boolean

    Public Shared GameStoppedState As Boolean

    Public Shared ComplexScoring As Boolean = True

    Public Shared ConfigFile As String = "MMG_Config.cfg"

    Public Shared GifEnabled As Boolean = True

#End Region

#Region "Linear-mode"
    Public Shared Linear As Boolean = False

    Public Shared LinearSizeScaling As Double = 225
    Public Shared LinearTimeToClickScaling As Double = 250
    Public Shared LinearScalingSpeed As Double = 275

    Public Shared MaxShapeSize As Integer = 180
    Public Shared MaxTimeToClick As Integer = 2500

    Public Shared GameDifficulty As Integer = 0

    Public Shared TimeLimit As Boolean = False

    Public Shared ProgressCount As Integer = 0

    Public Shared ResetCheckSync As Boolean

    Public Shared ReactionMode As Boolean = False
#End Region

End Class
