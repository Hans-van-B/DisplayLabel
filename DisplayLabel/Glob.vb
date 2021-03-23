Module Glob
    Public AppName As String = "DisplayLabel"
    Public AppVer As String = "0.06"
    Public AppRoot As String = Application.StartupPath

    ' Log File
    Public Temp As String = Environment.GetEnvironmentVariable("TEMP")
    Public LogFile As String = Temp & "\" & AppName & ".log"
    Public LTrace As Integer = 2
    Public ErrorCount As Integer = 0
    Public WarningCount As Integer = 0

    ' Defaults
    Public IniFile1 As String = AppRoot & "\" & AppName & ".ini"
    Public IniFile2 As String = AppRoot & "\Data\" & AppName & ".ini"
    Public HideDelay As Integer = 4
    Public LabelText As String = "DisplayLabel"
    Public DX As Integer = 1000
    Public DY As Integer = 10
    Public MyWidth As Integer = 280
    Public MyHeight As Integer = 80
    Public ExitProgram As Boolean = False
    Public NoFormBorder As Boolean = True
    Public Transparancy As Double = 0.6

End Module
