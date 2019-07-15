Imports System.ComponentModel
Imports System.IO
Imports CoreAudio

Public Class GameConfig

#Region "Reset config GameVariables.ConfigFile"
    Public Shared Sub ResetConfig()
        Dim SW As System.IO.StreamWriter
        SW = My.Computer.FileSystem.OpenTextFileWriter(GameVariables.ConfigFile, True)
        'writes default config text
        SW.WriteLine("//MMG Config")
        SW.WriteLine("// true = t false = f")
        SW.WriteLine("")
        SW.WriteLine("//Settings")
        SW.WriteLine("BackgroundMusic= t")
        SW.WriteLine("SoundFX= t")
        SW.WriteLine("WindowedMode= f")
        SW.WriteLine("DarkLightUI= Dark")
        SW.WriteLine("")
        SW.WriteLine("//Preferences")
        SW.WriteLine("TimeToClick= 2000")
        SW.WriteLine("MaxLives= 3")
        SW.WriteLine("ShapeSize= 150")
        SW.WriteLine("Highscore= 0")

        SW.Close()
    End Sub
#End Region

#Region "Read config GameVariables.ConfigFile function"

    'declares inputs for the function
    Public Shared Function GetConfigItem(ByVal Setting As String, ByVal ID As String) As String

        'checks if config GameVariables.ConfigFile exists
        If Not System.IO.File.Exists(GameVariables.ConfigFile) Then
            System.IO.File.Create(GameVariables.ConfigFile).Close()
            'write default IDs and values if config doesnt exist

            Dim SW As System.IO.StreamWriter
            SW = My.Computer.FileSystem.OpenTextFileWriter(GameVariables.ConfigFile, True)
            'writes default config text
            SW.WriteLine("//MMG Config")
            SW.WriteLine("// true = t false =f")
            SW.WriteLine("")
            SW.WriteLine("//Settings")
            SW.WriteLine("BackgroundMusic=t")
            SW.WriteLine("SoundFX=t")
            SW.WriteLine("WindowedMode=f")
            SW.WriteLine("DarkLightUI=Dark")
            SW.WriteLine("")
            SW.WriteLine("//Preferences")
            SW.WriteLine("TimeToClick=2000")
            SW.WriteLine("MaxLives=3")
            SW.WriteLine("ShapeSize=150")
            SW.WriteLine("Highscore=0")

            SW.Close()
        End If

        'declares streamreader (GameVariables.ConfigFile reader) and result string
        Dim SR As New IO.StreamReader(Setting)
        Dim result As String = "1"

        'reads text GameVariables.ConfigFile lines sequentialy untill end of GameVariables.ConfigFile (which is the last line in text GameVariables.ConfigFile)
        Do While (SR.Peek <> -1)

            Dim Line As String = SR.ReadLine

            'reads ID line after "=" to get result
            If Line.ToLower.StartsWith(ID.ToLower & "=") Then
                'ID.Length + 1 (1 is the length of the equal sign)
                result = Line.Substring(ID.Length + 1)
            End If
            'loops to next line
        Loop
        'returns result
        SR.Close()

        Return result

    End Function
#End Region

#Region "Write to config GameVariables.ConfigFile function"
    Public Shared Function WriteToConfig(ByVal linenum As Integer, ByVal Setting As String) As String
        'declares streamreader (GameVariables.ConfigFile reader) and result string

        Dim lines() As String = System.IO.File.ReadAllLines("MMG_Config.cfg")
        'Default config GameVariables.ConfigFile format
        ' Line Number    Contents of line
        ' 0              "//MMG Config"
        ' 1              "// true = t false = f"
        ' 2              " "
        ' 3              "//Settings"
        ' 4              "BackgroundMusic=t"
        ' 5              "SoundFX=t"
        ' 6              "WindowedMode=f"
        ' 7               "DarkLightUI=Dark"
        ' 8              " "
        ' 9              "//Preferences"
        ' 10             "TimeToClick=2000"
        ' 11             "MaxLives=3"
        ' 12             "ShapeSize=150"
        ' 13             "Highscore=0"

        Try
            lines(linenum) = Setting
            System.IO.File.WriteAllLines("MMG_Config.cfg", lines)
        Catch
            frmconsole.consoledialog.AppendText(vbNewLine)
            frmconsole.consoledialog.AppendText("Error writting to config file")
        End Try
        Return True

    End Function
#End Region

#Region "Load config GameVariables.ConfigFile"
    Public Shared Sub LoadConfig()
        'Gets values from config GameVariables.ConfigFile using the GetConfigItem function
        'GetConfigItem("Config GameVariables.ConfigFile name", "ID name in GameVariables.ConfigFile") = value
        't = true and f = false

        'Loads settings
        If GetConfigItem("MMG_Config.cfg", "SoundFX") = "t" Then
            GameVariables.soundfx = True
            frmmenusettings.chksoundfx.Checked = True
        Else
            GameVariables.soundfx = False
            frmmenusettings.chksoundfx.Checked = False
        End If

        If GetConfigItem("MMG_Config.cfg", "BackgroundMusic") = "t" Then
            'starts background music process and starts process
            Dim p = Process.GetProcessesByName("MMGPlayMusic")
            If p.Count > 0 Then
            Else

                Dim FileBytes() As Byte = My.Resources.MMGPlayMusic
                System.IO.File.WriteAllBytes("MMGPlayMusic.exe", FileBytes)

                Process.Start("MMGPlayMusic.exe")
            End If
            frmmenusettings.chkmusic.Checked = True
        Else
            For Each P As Process In System.Diagnostics.Process.GetProcessesByName("MMGPlayMusic")
                P.Kill()
            Next
            frmmenusettings.chkmusic.Checked = False
        End If

        If GetConfigItem("MMG_Config.cfg", "WindowedMode") = "t" Then
            GameEvents.WindowedMode()
            frmmenusettings.chkwindowed.Checked = True
        Else
            GameEvents.FullscreenMode()
            frmmenusettings.chkwindowed.Checked = False
        End If

        If GetConfigItem("MMG_Config.cfg", "DarkLightUI") = "Light" Then
            frmmenusettings.BackColor = Color.FromArgb(180, 180, 180) 'slightly darker to make white text more visible
            frmmenu.BackColor = Color.FromArgb(200, 200, 200) 'light grey
            frmhowtoplay.BackColor = Color.FromArgb(200, 200, 200) 'light grey
            frmconsole.BackColor = Color.FromArgb(200, 200, 200) 'light grey

            frmmenusettings.btnlight.BringToFront()
        Else
            frmmenusettings.BackColor = Color.FromArgb(64, 64, 64) 'dark grey colour
            frmmenu.BackColor = Color.FromArgb(64, 64, 64) 'dark grey colour
            frmhowtoplay.BackColor = Color.FromArgb(64, 64, 64) 'dark grey colour
            frmconsole.BackColor = Color.FromArgb(64, 64, 64) 'dark grey colour

            frmmenusettings.btndark.BringToFront()
        End If

        'Loads preferences
        'Loads Time to click 
        frmgame.timerlocation1.Interval = GetConfigItem("MMG_Config.cfg", "TimeToClick")
        frmgame.timerlocation2.Interval = GetConfigItem("MMG_Config.cfg", "TimeToClick")
        frmgame.timerlocation3.Interval = GetConfigItem("MMG_Config.cfg", "TimeToClick")
        FrmPreferences.txttimetoclick.Text = frmgame.timerlocation1.Interval

        square1.lbltimeleft1.Text = frmgame.timerlocation1.Interval
        square2.lbltimeleft2.Text = frmgame.timerlocation1.Interval
        square3.lbltimeleft3.Text = frmgame.timerlocation1.Interval

        circle1.lbltimeleft1.Text = frmgame.timerlocation1.Interval
        circle2.lbltimeleft2.Text = frmgame.timerlocation1.Interval
        circle3.lbltimeleft3.Text = frmgame.timerlocation1.Interval

        'Loads maxlives
        GameVariables.MaxLives = GetConfigItem("MMG_Config.cfg", "MaxLives")

        'Loads highscore
        frmhighscores.lblhighscorenum.Text = GetConfigItem("MMG_Config.cfg", "Highscore")

        'Loads shape size
        Dim ConfigShapeSize As Integer = GetConfigItem("MMG_Config.cfg", "ShapeSize")

        FrmPreferences.txtsquaresize.Text = ConfigShapeSize

        square1.Size = New Size(ConfigShapeSize, ConfigShapeSize)
        square2.Size = New Size(ConfigShapeSize, ConfigShapeSize)
        square3.Size = New Size(ConfigShapeSize, ConfigShapeSize)

        Using path As New System.Drawing.Drawing2D.GraphicsPath
            path.AddEllipse(0, 0, Integer.Parse(ConfigShapeSize), Integer.Parse(ConfigShapeSize))
            circle1.Region = New Region(path)
            path.AddEllipse(0, 0, Integer.Parse(ConfigShapeSize), Integer.Parse(ConfigShapeSize))
            circle2.Region = New Region(path)
            path.AddEllipse(0, 0, Integer.Parse(ConfigShapeSize), Integer.Parse(ConfigShapeSize))
            circle3.Region = New Region(path)
        End Using

        GameEvents.CentreCircleAndSquare()

    End Sub
#End Region

#Region "Read config into array"
    Public Shared Sub ReadConfigToArray()

        'http://www.dreamincode.net/forums/topic/111336-read-GameVariables.ConfigFile-line-by-line-to-array-list/
        'loads config into a array so it can be read easily while ingame
        Try
            Dim SW As New System.IO.StreamReader("MMG_Config.cfg")

            While Not (SW.Peek() = -1)
                GameVariables.ConfigArray.Add(SW.ReadLine())
            End While

            SW.Close()

        Catch ex As Exception
            frmconsole.consoledialog.AppendText(vbNewLine)
            frmconsole.consoledialog.AppendText("Error while reading config")
        End Try

    End Sub
#End Region

End Class
