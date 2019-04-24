Public Class vLine
    Implements Removable
    Sub New(x As Integer, y1 As Integer, y2 As Integer, w As Integer)
        InitializeComponent()
        Me.Width = w
        Dim t As Integer
        t = (w - 1) / 2
        If t < 1 Then t = 0
        Me.Location = New Point(x * 3 - t, y1 * 3)
        Me.Height = (y2 - y1) * 3
    End Sub

    Private Sub Removable_Dispose() Implements Removable.Dispose
        Me.Dispose()
    End Sub
End Class
