Imports System.Drawing.Drawing2D
Imports eScheme

<Serializable> Public Class EPoint
	Implements IConnectable
	Dim X As Integer
	Dim Y As Integer
	Public num As Integer
	'Dim Left As
	Public Sub New(rx As Integer, ry As Integer)
		' Этот вызов является обязательным для конструктора.
		InitializeComponent()
		' Добавить код инициализации после вызова InitializeComponent().
		X = rx
		Y = ry
		Init()
	End Sub

	Public Sub New()
		' Этот вызов является обязательным для конструктора.
		InitializeComponent()
		' Добавить код инициализации после вызова InitializeComponent().
		Init()
	End Sub

	Sub Init()
		Me.Location = New Point(X - 5, Y - 5)
		Dim gpath As New GraphicsPath
		Dim thePoint As Rectangle = Me.ClientRectangle
		thePoint.Inflate(-1, -1)  ' уменьшаем, чтобы края не обрезались,можно наоборот                          
		gpath.AddEllipse(thePoint)
		Me.Region = New Region(gpath)
	End Sub

	Public Sub Change(from As Integer) Implements IConnectable.Change
		Throw New NotImplementedException()
	End Sub

	Private Sub EPoint_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
		If e.KeyChar = "n" Or e.KeyChar = "т" Then
			MsgBox("Номер узла: " + CStr(num))
		End If
	End Sub

	Private Sub Connectable_Dispose() Implements IConnectable.Dispose
		Me.Dispose()
	End Sub
End Class
