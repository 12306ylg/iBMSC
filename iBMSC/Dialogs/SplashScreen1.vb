Public NotInheritable Class SplashScreen1


	Protected Overrides Sub OnPaint(e As PaintEventArgs)
		MyBase.OnPaint(e)
	End Sub

	Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
		SetStyle(ControlStyles.SupportsTransparentBackColor, True)
		BackColor = Color.Transparent
		Show()
		MyBase.OnPaintBackground(e)
		Dim rect As New Rectangle(0, 0, Width, Height)
	End Sub

End Class
