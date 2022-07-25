' Does not work yet, only assigns the desktop background color
Partial Public Class MyLabel
    Inherits Label
    Public Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
        BackColor = Color.Transparent
        AutoSize = True
        Visible = True
        Font = New Font("Arial", 20, FontStyle.Regular)
    End Sub
End Class
