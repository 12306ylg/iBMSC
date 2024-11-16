Public Class Chartinfo

	Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles gotost_Button.Click
		Me.DialogResult = DialogResult.OK
		MainWindow.TBStatistics_Click(sender, e)
		Me.Close()
	End Sub

	Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
		Me.DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub

End Class
