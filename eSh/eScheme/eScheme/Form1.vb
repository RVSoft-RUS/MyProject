Public Class Form1
	Dim rx As Integer, ry As Integer 'округленные до 20 координаты точки

	Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
		GroupBox1.Visible = CheckBox2.Checked
		If CheckBox2.Checked Then
			ToolTip1.SetToolTip(CheckBox2, "Скрыть панель")
		Else
			ToolTip1.SetToolTip(CheckBox2, "Показать панель")
		End If
	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub Label_A4_Click(sender As Object, e As EventArgs) Handles Label_A4.Click
		Dim X_ As Integer = 10, Y_ As Integer = 30 'Смещение рамки от краев
	End Sub

	Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
		rx = CInt(Math.Round(e.X / 20))
		rx = rx * 20
		ry = CInt(Math.Round(e.Y / 20))
		ry = ry * 20
		Dim G As Graphics = Me.CreateGraphics
		G.Clear(Me.BackColor)
		G.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
		Dim Pn As New Pen(Color.LightGreen, 1)
		Pn.DashStyle = Drawing2D.DashStyle.Dash
		G.DrawLine(Pn, 0, ry, 3000, ry)
		G.DrawLine(Pn, rx, 0, rx, 3000)
		G.Dispose()
		ToolTip1.SetToolTip(Me, CStr(rx) + ", " + CStr(ry))
	End Sub

	Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
		Dim P As New Point
	End Sub
End Class
