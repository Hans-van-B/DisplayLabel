Module Log
    Sub xtrace_init()
        My.Computer.FileSystem.WriteAllText(LogFile, "" & vbNewLine, False)
        xtrace(AppName & " V" & AppVer)
        xtrace("AppRoot = " & AppRoot)

    End Sub

    '---- xtrace
    Sub xtrace(Msg As String)
        xtrace(Msg, 2)
    End Sub

    Sub xtrace(Msg As String, TV As Integer)
        If TV <= LTrace Then
            My.Computer.FileSystem.WriteAllText(LogFile, Msg & vbNewLine, True)
        End If
    End Sub

    Sub xtrace_i(Msg As String)
        xtrace(" * " & Msg)
    End Sub

    Sub xtrace_subs(Msg As String)
        xtrace("## " & Msg)
    End Sub

    Sub xtrace_sube(Msg As String)

    End Sub


    Sub xtrace_err(Msg As String)
        xtrace("ERROR: " & Msg)
    End Sub


End Module
