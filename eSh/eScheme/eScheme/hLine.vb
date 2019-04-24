Imports eScheme

Public Class hLine
    Implements Removable
    'Public x1 As Integer
    'Public x2 As Integer
    'Public y As Integer
    'Public w As Integer

    Sub New(x1 As Integer, x2 As Integer, y As Integer, w As Integer)
        InitializeComponent()
        Me.Height = w
        Dim t As Integer
        t = (w - 1) / 2
        If t < 1 Then t = 0
        Me.Location = New Point(x1 * 3, y * 3 - t)
        Me.Width = (x2 - x1) * 3
    End Sub

    Private Sub Removable_Dispose() Implements Removable.Dispose
        Me.Dispose()
    End Sub
End Class
