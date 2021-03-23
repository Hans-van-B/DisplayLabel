Public Class Form1
    '---- Initialize ---------------------------------------------------------
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xtrace_init()
        ReadDefaults()
        Read_Command_Line_Arg()
        If ExitProgram Then Application.Exit()

        TextBox1.Text = LabelText

        Me.Width = MyWidth
        Me.Height = MyHeight

        Me.Left = DX
        Me.Top = DY

        ' Disable the top window border
        If NoFormBorder Then Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        Me.Opacity = Transparancy
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_DoubleClick(sender As Object, e As EventArgs) Handles TextBox1.DoubleClick, HideToolStripMenuItem.Click
        xtrace_subs("Double-Click or Context, Hide")
        Me.WindowState = FormWindowState.Minimized
        wait(HideDelay)
        Me.WindowState = FormWindowState.Normal
    End Sub

    '==== ContextMenuStrip ====
    '---- Border
    Private Sub BorderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorderToolStripMenuItem.Click
        xtrace_subs("Context, Border")
        If BorderToolStripMenuItem.Checked Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        Else
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        xtrace_subs("Context, Exit")
        Application.Exit()
    End Sub

    Private Sub ToolStripMenuItemHelp_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemHelp.Click
        ShowHelp()
    End Sub

    '---- Fom size ----
    Private Sub ToolStripComboBoxWidth_Click(sender As Object, e As EventArgs) Handles ToolStripComboBoxWidth.Click
        ToolStripComboBoxWidth.Text = Me.Width.ToString
    End Sub

    Private Sub ToolStripComboBoxWidth_TextChanged(sender As Object, e As EventArgs) Handles ToolStripComboBoxWidth.TextChanged
        Try
            Dim W As Integer
            W = Val(ToolStripComboBoxWidth.Text)
            If W >= 50 And W < 1000 Then Me.Width = W
        Catch ex As Exception

        End Try
    End Sub
End Class
