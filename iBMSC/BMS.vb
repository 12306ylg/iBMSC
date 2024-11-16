Imports iBMSC.Editor

Friend Module BMS
	Public Function IsChannelLongNote(I As String) As Boolean
		Dim LongStart = C36to10("50")
		Dim LongEnd = C36to10("8Z")

		Dim xI As Integer = C36to10(I)

		Return xI > LongStart And xI < LongEnd
	End Function

	Public Function IsChannelHidden(I As String) As Boolean
		Dim HiddenStart = C36to10("30")
		Dim HiddenEnd = C36to10("4Z")
		Dim OptionStart = C36to10("70")
		Dim OptionEnd = C36to10("8Z")

		Dim xI As Integer = C36to10(I)

		Return (xI > HiddenStart And xI < HiddenEnd) Or (xI > OptionStart And xI < OptionEnd)
	End Function

	Public Function IsChannelLandmine(I As String) As Boolean
		Dim LandmineStart = C36to10("D0")
		Dim LandmineEnd = C36to10("EZ")

		Dim xI As Integer = C36to10(I)

		Return xI > LandmineStart And xI < LandmineEnd
	End Function
End Module
