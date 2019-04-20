<Serializable> Public Class ePoint
	Dim X As Integer
	Dim Y As Integer
	'Dim Left As
	Public Sub New(rx As Integer, ry As Integer)

		' Этот вызов является обязательным для конструктора.
		InitializeComponent()

		' Добавить код инициализации после вызова InitializeComponent().
		X = rx
		Y = ry
		Me.Location = New Point(X - 3, Y - 3)
	End Sub

	Public Sub New()

		' Этот вызов является обязательным для конструктора.
		InitializeComponent()

		' Добавить код инициализации после вызова InitializeComponent().
		Me.Location = New Point(X - 3, Y - 3)
	End Sub



	Private Sub ePoint_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class
