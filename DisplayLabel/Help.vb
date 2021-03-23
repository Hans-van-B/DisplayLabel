Module Help
    '==== GUI Help ============================================================

    Dim HelpPage As String = Temp & "\help.html"
    Dim HelpPageHtm As String = AppRoot & "\" & AppName & ".html"
    Dim HelpPagePdf As String = AppRoot & "\" & AppName & ".pdf"

    Sub ShowHelp()
        xtrace("Show Help")

        If (System.IO.File.Exists(HelpPageHtm)) Then
            HelpPage = HelpPageHtm
        ElseIf (System.IO.File.Exists(HelpPagePdf)) Then
            HelpPage = HelpPagePdf
        Else
            xtrace("Did not find " & HelpPageHtm)
            xtrace("Did not find " & HelpPagePdf)

            xtrace("Create page")
            My.Computer.FileSystem.WriteAllText(HelpPage, "<html>" & vbNewLine, False)
            WriteHelp("<head>")
            WriteHelp("")
            WriteHelp("</head>")
            WriteHelp("<H2>" & AppName & " V" & AppVer & " Help Page</H2>")
            WriteHelp("<br>")
            WriteHelp("Command line switches<br>")
            WriteHelp("<ul>")
            WriteHelp("--label=&lt;Label Text&gt; : Set the display label text<br>")
            WriteHelp("--LocationX=&lt;Int&gt; : Set the display location horizontal<br>")
            WriteHelp("--LocationY=&lt;Int&gt; : Set the display location vertical<br>")
            WriteHelp("--MyWidth=&lt;Int&gt; : Set the window Width<br>")
            WriteHelp("--MyHeight=&lt;Int&gt; : Set the window Height<br>")
            WriteHelp(" /?   = Show help<br>")
            WriteHelp(" -h   = Show help<br>")
            WriteHelp("</ul>")
            WriteHelp("Examples")
            WriteHelp("<ul>")
            WriteHelp("  DisplayLabel -h<br>")
            WriteHelp("  DisplayLabel --label=&lt;Label_Text&gt;<br>")
            WriteHelp("  DisplayLabel &lt;Label_Text&gt;<br>")
            WriteHelp("  DisplayLabel ""&lt;Label Text&gt;""<br>")
            WriteHelp("</ul>")
            WriteHelp("<br>")
            WriteHelp("The " & AppName & " log can be found here: " & Glob.LogFile & "<br>")
            WriteHelp("</body>")
            WriteHelp("</html")
        End If

        Process.Start(HelpPage, "")
    End Sub

    Sub ShowHelpAbout()
        xtrace("Show Help, about")

        xtrace("Create page")
        My.Computer.FileSystem.WriteAllText(HelpPage, "<html>" & vbNewLine, False)
        WriteHelp("<head>")
        WriteHelp("")
        WriteHelp("</head>")
        WriteHelp("<H2>" & AppName & " V" & AppVer & " Help About</H2>")
        WriteHelp("<br>")
        WriteHelp("<br>")
        WriteHelp("<br>")
        WriteHelp("<br>")
        WriteHelp("<br>")
        WriteHelp("<font size=""-1"">")
        WriteHelp(" Dev: C:\Users\nly10677\OneDrive - Philips\VS_Projects\??<br>")
        WriteHelp(" Maint: P:\Dev\Template\vb.net\ZZ_Template_Windows_Forms<br>")
        WriteHelp(" The " & AppName & " log can be found here: " & Glob.LogFile & "<br>")
        WriteHelp("</font>")
        WriteHelp("</body>")
        WriteHelp("</html")

        Process.Start(HelpPage, "")
    End Sub

    Sub WriteHelp(Line As String)
        My.Computer.FileSystem.WriteAllText(HelpPage, Line & vbNewLine, True)
    End Sub

End Module
