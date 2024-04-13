<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpVisual
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TableLayoutPanel1 = New TableLayoutPanel()
        OK_Button = New Button()
        Cancel_Button = New Button()
        Panel1 = New Panel()
        Label8 = New Label()
        Label1 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Panel2 = New Panel()
        Label33 = New Label()
        iHiddenNoteOpacity = New NumericUpDown()
        Label23 = New Label()
        cAdjustLengthBorder = New Button()
        cSelectedBorder = New Button()
        cMouseOver = New Button()
        iLongLabelHorizShift = New NumericUpDown()
        iLabelHorizShift = New NumericUpDown()
        iLabelVerticalShift = New NumericUpDown()
        fMeasureLabel = New Button()
        fNoteLabel = New Button()
        iNoteHeight = New NumericUpDown()
        fTSBPM = New Button()
        cTSBPM = New Button()
        cTSSelectionFill = New Button()
        cTSCursor = New Button()
        cSelectionBox = New Button()
        cWaveForm = New Button()
        cMeasureBarLine = New Button()
        cVerticalLine = New Button()
        cSub = New Button()
        cGrid = New Button()
        cBG = New Button()
        fColumnTitle = New Button()
        cColumnTitle = New Button()
        Label40 = New Label()
        Label39 = New Label()
        Label38 = New Label()
        Label37 = New Label()
        Label88 = New Label()
        Label35 = New Label()
        Label34 = New Label()
        Label86 = New Label()
        Label98 = New Label()
        Label31 = New Label()
        Label30 = New Label()
        Label29 = New Label()
        Label28 = New Label()
        Label27 = New Label()
        Label26 = New Label()
        Label25 = New Label()
        Label24 = New Label()
        Label22 = New Label()
        Label21 = New Label()
        Label9 = New Label()
        cTSSplitter = New Button()
        Label97 = New Label()
        Label96 = New Label()
        iTSSensitivity = New NumericUpDown()
        cTSMouseOver = New Button()
        Label91 = New Label()
        Label82 = New Label()
        Label14 = New Label()
        iMiddleSensitivity = New NumericUpDown()
        PictureBox1 = New PictureBox()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(iHiddenNoteOpacity, ComponentModel.ISupportInitialize).BeginInit()
        CType(iLongLabelHorizShift, ComponentModel.ISupportInitialize).BeginInit()
        CType(iLabelHorizShift, ComponentModel.ISupportInitialize).BeginInit()
        CType(iLabelVerticalShift, ComponentModel.ISupportInitialize).BeginInit()
        CType(iNoteHeight, ComponentModel.ISupportInitialize).BeginInit()
        CType(iTSSensitivity, ComponentModel.ISupportInitialize).BeginInit()
        CType(iMiddleSensitivity, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(OK_Button, 0, 0)
        TableLayoutPanel1.Controls.Add(Cancel_Button, 1, 0)
        TableLayoutPanel1.Location = New Point(868, 672)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(146, 29)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' OK_Button
        ' 
        OK_Button.Anchor = AnchorStyles.None
        OK_Button.Location = New Point(3, 3)
        OK_Button.Name = "OK_Button"
        OK_Button.Size = New Size(67, 23)
        OK_Button.TabIndex = 0
        OK_Button.Text = "OK"
        ' 
        ' Cancel_Button
        ' 
        Cancel_Button.Anchor = AnchorStyles.None
        Cancel_Button.DialogResult = DialogResult.Cancel
        Cancel_Button.Location = New Point(76, 3)
        Cancel_Button.Name = "Cancel_Button"
        Cancel_Button.Size = New Size(67, 23)
        Cancel_Button.TabIndex = 1
        Cancel_Button.Text = "Cancel"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(10, 263)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1004, 410)
        Panel1.TabIndex = 87
        ' 
        ' Label8
        ' 
        Label8.Location = New Point(12, 324)
        Label8.Name = "Label8"
        Label8.Size = New Size(60, 65)
        Label8.TabIndex = 39
        Label8.Text = "Bg"
        Label8.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(12, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 33
        Label1.Text = "Width"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label7
        ' 
        Label7.Location = New Point(12, 258)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 66)
        Label7.TabIndex = 38
        Label7.Text = "Long" & vbCrLf & "Note" & vbCrLf & "Label"
        Label7.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label5
        ' 
        Label5.Location = New Point(12, 193)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 66)
        Label5.TabIndex = 36
        Label5.Text = "Long" & vbCrLf & "Note"
        Label5.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label6
        ' 
        Label6.Location = New Point(12, 128)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 66)
        Label6.TabIndex = 37
        Label6.Text = "Label"
        Label6.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(12, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 34
        Label2.Text = "Caption"
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(12, 63)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 66)
        Label4.TabIndex = 35
        Label4.Text = "Note"
        Label4.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Panel2
        ' 
        Panel2.AutoScroll = True
        Panel2.Location = New Point(78, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(926, 410)
        Panel2.TabIndex = 88
        ' 
        ' Label33
        ' 
        Label33.BorderStyle = BorderStyle.FixedSingle
        Label33.Location = New Point(315, 148)
        Label33.Name = "Label33"
        Label33.Size = New Size(220, 23)
        Label33.TabIndex = 137
        Label33.Text = "Hidden Note Opacity"
        Label33.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' iHiddenNoteOpacity
        ' 
        iHiddenNoteOpacity.DecimalPlaces = 2
        iHiddenNoteOpacity.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        iHiddenNoteOpacity.Location = New Point(537, 148)
        iHiddenNoteOpacity.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        iHiddenNoteOpacity.Name = "iHiddenNoteOpacity"
        iHiddenNoteOpacity.Size = New Size(80, 23)
        iHiddenNoteOpacity.TabIndex = 136
        iHiddenNoteOpacity.Tag = "4"
        ' 
        ' Label23
        ' 
        Label23.BorderStyle = BorderStyle.FixedSingle
        Label23.Location = New Point(315, 221)
        Label23.Name = "Label23"
        Label23.Size = New Size(220, 23)
        Label23.TabIndex = 135
        Label23.Text = "Note Border on Adjusting Length"
        Label23.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' cAdjustLengthBorder
        ' 
        cAdjustLengthBorder.FlatStyle = FlatStyle.Flat
        cAdjustLengthBorder.Location = New Point(537, 221)
        cAdjustLengthBorder.Name = "cAdjustLengthBorder"
        cAdjustLengthBorder.Size = New Size(80, 23)
        cAdjustLengthBorder.TabIndex = 134
        cAdjustLengthBorder.Tag = "13"
        cAdjustLengthBorder.Text = "FF000000"
        cAdjustLengthBorder.UseVisualStyleBackColor = True
        ' 
        ' cSelectedBorder
        ' 
        cSelectedBorder.FlatStyle = FlatStyle.Flat
        cSelectedBorder.Location = New Point(537, 199)
        cSelectedBorder.Name = "cSelectedBorder"
        cSelectedBorder.Size = New Size(80, 23)
        cSelectedBorder.TabIndex = 133
        cSelectedBorder.Tag = "12"
        cSelectedBorder.Text = "FF000000"
        cSelectedBorder.UseVisualStyleBackColor = True
        ' 
        ' cMouseOver
        ' 
        cMouseOver.FlatStyle = FlatStyle.Flat
        cMouseOver.Location = New Point(537, 177)
        cMouseOver.Name = "cMouseOver"
        cMouseOver.Size = New Size(80, 23)
        cMouseOver.TabIndex = 132
        cMouseOver.Tag = "11"
        cMouseOver.Text = "FF000000"
        cMouseOver.UseVisualStyleBackColor = True
        ' 
        ' iLongLabelHorizShift
        ' 
        iLongLabelHorizShift.Location = New Point(537, 126)
        iLongLabelHorizShift.Minimum = New Decimal(New Integer() {100, 0, 0, Integer.MinValue})
        iLongLabelHorizShift.Name = "iLongLabelHorizShift"
        iLongLabelHorizShift.Size = New Size(80, 23)
        iLongLabelHorizShift.TabIndex = 131
        iLongLabelHorizShift.Tag = "3"
        ' 
        ' iLabelHorizShift
        ' 
        iLabelHorizShift.Location = New Point(537, 104)
        iLabelHorizShift.Minimum = New Decimal(New Integer() {100, 0, 0, Integer.MinValue})
        iLabelHorizShift.Name = "iLabelHorizShift"
        iLabelHorizShift.Size = New Size(80, 23)
        iLabelHorizShift.TabIndex = 130
        iLabelHorizShift.Tag = "2"
        ' 
        ' iLabelVerticalShift
        ' 
        iLabelVerticalShift.Location = New Point(537, 82)
        iLabelVerticalShift.Minimum = New Decimal(New Integer() {100, 0, 0, Integer.MinValue})
        iLabelVerticalShift.Name = "iLabelVerticalShift"
        iLabelVerticalShift.Size = New Size(80, 23)
        iLabelVerticalShift.TabIndex = 129
        iLabelVerticalShift.Tag = "1"
        ' 
        ' fMeasureLabel
        ' 
        fMeasureLabel.AutoEllipsis = True
        fMeasureLabel.FlatStyle = FlatStyle.Flat
        fMeasureLabel.Location = New Point(537, 60)
        fMeasureLabel.Name = "fMeasureLabel"
        fMeasureLabel.Size = New Size(80, 23)
        fMeasureLabel.TabIndex = 128
        fMeasureLabel.Tag = "3"
        fMeasureLabel.Text = "Microsoft YaHei UI"
        fMeasureLabel.UseVisualStyleBackColor = True
        ' 
        ' fNoteLabel
        ' 
        fNoteLabel.AutoEllipsis = True
        fNoteLabel.FlatStyle = FlatStyle.Flat
        fNoteLabel.Location = New Point(537, 38)
        fNoteLabel.Name = "fNoteLabel"
        fNoteLabel.Size = New Size(80, 23)
        fNoteLabel.TabIndex = 127
        fNoteLabel.Tag = "2"
        fNoteLabel.Text = "Microsoft YaHei UI"
        fNoteLabel.UseVisualStyleBackColor = True
        ' 
        ' iNoteHeight
        ' 
        iNoteHeight.Location = New Point(537, 16)
        iNoteHeight.Name = "iNoteHeight"
        iNoteHeight.Size = New Size(80, 23)
        iNoteHeight.TabIndex = 126
        iNoteHeight.Tag = "0"
        ' 
        ' fTSBPM
        ' 
        fTSBPM.AutoEllipsis = True
        fTSBPM.FlatStyle = FlatStyle.Flat
        fTSBPM.Location = New Point(870, 170)
        fTSBPM.Name = "fTSBPM"
        fTSBPM.Size = New Size(80, 23)
        fTSBPM.TabIndex = 125
        fTSBPM.Tag = "1"
        fTSBPM.Text = "Microsoft YaHei UI"
        fTSBPM.UseVisualStyleBackColor = True
        ' 
        ' cTSBPM
        ' 
        cTSBPM.FlatStyle = FlatStyle.Flat
        cTSBPM.Location = New Point(870, 148)
        cTSBPM.Name = "cTSBPM"
        cTSBPM.Size = New Size(80, 23)
        cTSBPM.TabIndex = 124
        cTSBPM.Tag = "10"
        cTSBPM.Text = "FF000000"
        cTSBPM.UseVisualStyleBackColor = True
        ' 
        ' cTSSelectionFill
        ' 
        cTSSelectionFill.FlatStyle = FlatStyle.Flat
        cTSSelectionFill.Location = New Point(870, 126)
        cTSSelectionFill.Name = "cTSSelectionFill"
        cTSSelectionFill.Size = New Size(80, 23)
        cTSSelectionFill.TabIndex = 123
        cTSSelectionFill.Tag = "9"
        cTSSelectionFill.Text = "FF000000"
        cTSSelectionFill.UseVisualStyleBackColor = True
        ' 
        ' cTSCursor
        ' 
        cTSCursor.FlatStyle = FlatStyle.Flat
        cTSCursor.Location = New Point(870, 38)
        cTSCursor.Name = "cTSCursor"
        cTSCursor.Size = New Size(80, 23)
        cTSCursor.TabIndex = 122
        cTSCursor.Tag = "8"
        cTSCursor.Text = "FF000000"
        cTSCursor.UseVisualStyleBackColor = True
        ' 
        ' cSelectionBox
        ' 
        cSelectionBox.FlatStyle = FlatStyle.Flat
        cSelectionBox.Location = New Point(870, 16)
        cSelectionBox.Name = "cSelectionBox"
        cSelectionBox.Size = New Size(80, 23)
        cSelectionBox.TabIndex = 121
        cSelectionBox.Tag = "7"
        cSelectionBox.Text = "FF000000"
        cSelectionBox.UseVisualStyleBackColor = True
        ' 
        ' cWaveForm
        ' 
        cWaveForm.FlatStyle = FlatStyle.Flat
        cWaveForm.Location = New Point(204, 177)
        cWaveForm.Name = "cWaveForm"
        cWaveForm.Size = New Size(80, 23)
        cWaveForm.TabIndex = 120
        cWaveForm.Tag = "6"
        cWaveForm.Text = "FF000000"
        cWaveForm.UseVisualStyleBackColor = True
        ' 
        ' cMeasureBarLine
        ' 
        cMeasureBarLine.FlatStyle = FlatStyle.Flat
        cMeasureBarLine.Location = New Point(204, 155)
        cMeasureBarLine.Name = "cMeasureBarLine"
        cMeasureBarLine.Size = New Size(80, 23)
        cMeasureBarLine.TabIndex = 119
        cMeasureBarLine.Tag = "5"
        cMeasureBarLine.Text = "FF000000"
        cMeasureBarLine.UseVisualStyleBackColor = True
        ' 
        ' cVerticalLine
        ' 
        cVerticalLine.FlatStyle = FlatStyle.Flat
        cVerticalLine.Location = New Point(204, 133)
        cVerticalLine.Name = "cVerticalLine"
        cVerticalLine.Size = New Size(80, 23)
        cVerticalLine.TabIndex = 118
        cVerticalLine.Tag = "4"
        cVerticalLine.Text = "FF000000"
        cVerticalLine.UseVisualStyleBackColor = True
        ' 
        ' cSub
        ' 
        cSub.FlatStyle = FlatStyle.Flat
        cSub.Location = New Point(204, 111)
        cSub.Name = "cSub"
        cSub.Size = New Size(80, 23)
        cSub.TabIndex = 117
        cSub.Tag = "3"
        cSub.Text = "FF000000"
        cSub.UseVisualStyleBackColor = True
        ' 
        ' cGrid
        ' 
        cGrid.FlatStyle = FlatStyle.Flat
        cGrid.Location = New Point(204, 89)
        cGrid.Name = "cGrid"
        cGrid.Size = New Size(80, 23)
        cGrid.TabIndex = 116
        cGrid.Tag = "2"
        cGrid.Text = "FF000000"
        cGrid.UseVisualStyleBackColor = True
        ' 
        ' cBG
        ' 
        cBG.FlatStyle = FlatStyle.Flat
        cBG.Location = New Point(204, 60)
        cBG.Name = "cBG"
        cBG.Size = New Size(80, 23)
        cBG.TabIndex = 115
        cBG.Tag = "1"
        cBG.Text = "FF000000"
        cBG.UseVisualStyleBackColor = True
        ' 
        ' fColumnTitle
        ' 
        fColumnTitle.AutoEllipsis = True
        fColumnTitle.FlatStyle = FlatStyle.Flat
        fColumnTitle.Location = New Point(204, 38)
        fColumnTitle.Name = "fColumnTitle"
        fColumnTitle.Size = New Size(80, 23)
        fColumnTitle.TabIndex = 114
        fColumnTitle.Tag = "0"
        fColumnTitle.Text = "Microsoft YaHei UI"
        fColumnTitle.UseVisualStyleBackColor = True
        ' 
        ' cColumnTitle
        ' 
        cColumnTitle.FlatStyle = FlatStyle.Flat
        cColumnTitle.Location = New Point(204, 16)
        cColumnTitle.Name = "cColumnTitle"
        cColumnTitle.Size = New Size(80, 23)
        cColumnTitle.TabIndex = 113
        cColumnTitle.Tag = "0"
        cColumnTitle.Text = "FF000000"
        cColumnTitle.UseVisualStyleBackColor = True
        ' 
        ' Label40
        ' 
        Label40.BorderStyle = BorderStyle.FixedSingle
        Label40.Location = New Point(42, 155)
        Label40.Name = "Label40"
        Label40.Size = New Size(160, 23)
        Label40.TabIndex = 111
        Label40.Text = "Measure BarLine"
        Label40.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label39
        ' 
        Label39.BorderStyle = BorderStyle.FixedSingle
        Label39.Location = New Point(315, 126)
        Label39.Name = "Label39"
        Label39.Size = New Size(220, 23)
        Label39.TabIndex = 110
        Label39.Text = "LongNote Label Horizontal Shift"
        Label39.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label38
        ' 
        Label38.BorderStyle = BorderStyle.FixedSingle
        Label38.Location = New Point(315, 104)
        Label38.Name = "Label38"
        Label38.Size = New Size(220, 23)
        Label38.TabIndex = 109
        Label38.Text = "Note Label Horizontal Shift"
        Label38.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label37
        ' 
        Label37.BorderStyle = BorderStyle.FixedSingle
        Label37.Location = New Point(42, 16)
        Label37.Name = "Label37"
        Label37.Size = New Size(160, 23)
        Label37.TabIndex = 103
        Label37.Text = "Column Caption"
        Label37.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label88
        ' 
        Label88.BorderStyle = BorderStyle.FixedSingle
        Label88.Location = New Point(648, 148)
        Label88.Name = "Label88"
        Label88.Size = New Size(220, 23)
        Label88.TabIndex = 102
        Label88.Text = "Time Selection BPM"
        Label88.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label35
        ' 
        Label35.BorderStyle = BorderStyle.FixedSingle
        Label35.Location = New Point(315, 199)
        Label35.Name = "Label35"
        Label35.Size = New Size(220, 23)
        Label35.TabIndex = 101
        Label35.Text = "Note Border on Selection"
        Label35.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label34
        ' 
        Label34.BorderStyle = BorderStyle.FixedSingle
        Label34.Location = New Point(315, 177)
        Label34.Name = "Label34"
        Label34.Size = New Size(220, 23)
        Label34.TabIndex = 100
        Label34.Text = "Note Border on MouseOver"
        Label34.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label86
        ' 
        Label86.BorderStyle = BorderStyle.FixedSingle
        Label86.Location = New Point(648, 126)
        Label86.Name = "Label86"
        Label86.Size = New Size(220, 23)
        Label86.TabIndex = 99
        Label86.Text = "Time Selection Fill"
        Label86.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label98
        ' 
        Label98.BorderStyle = BorderStyle.FixedSingle
        Label98.Location = New Point(648, 38)
        Label98.Name = "Label98"
        Label98.Size = New Size(220, 23)
        Label98.TabIndex = 98
        Label98.Text = "Time Selection Cursor"
        Label98.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label31
        ' 
        Label31.BorderStyle = BorderStyle.FixedSingle
        Label31.Location = New Point(648, 16)
        Label31.Name = "Label31"
        Label31.Size = New Size(220, 23)
        Label31.TabIndex = 97
        Label31.Text = "Selection Box Border"
        Label31.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label30
        ' 
        Label30.BorderStyle = BorderStyle.FixedSingle
        Label30.Location = New Point(42, 60)
        Label30.Name = "Label30"
        Label30.Size = New Size(160, 23)
        Label30.TabIndex = 96
        Label30.Text = "Background"
        Label30.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label29
        ' 
        Label29.BorderStyle = BorderStyle.FixedSingle
        Label29.Location = New Point(42, 133)
        Label29.Name = "Label29"
        Label29.Size = New Size(160, 23)
        Label29.TabIndex = 95
        Label29.Text = "Vertical Line"
        Label29.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label28
        ' 
        Label28.BorderStyle = BorderStyle.FixedSingle
        Label28.Location = New Point(315, 60)
        Label28.Name = "Label28"
        Label28.Size = New Size(220, 23)
        Label28.TabIndex = 94
        Label28.Text = "Measure Label"
        Label28.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label27
        ' 
        Label27.BorderStyle = BorderStyle.FixedSingle
        Label27.Location = New Point(42, 111)
        Label27.Name = "Label27"
        Label27.Size = New Size(160, 23)
        Label27.TabIndex = 93
        Label27.Text = "Sub"
        Label27.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label26
        ' 
        Label26.BorderStyle = BorderStyle.FixedSingle
        Label26.Location = New Point(42, 89)
        Label26.Name = "Label26"
        Label26.Size = New Size(160, 23)
        Label26.TabIndex = 92
        Label26.Text = "Grid"
        Label26.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label25
        ' 
        Label25.BorderStyle = BorderStyle.FixedSingle
        Label25.Location = New Point(315, 82)
        Label25.Name = "Label25"
        Label25.Size = New Size(220, 23)
        Label25.TabIndex = 91
        Label25.Text = "Note Label Vertical Shift"
        Label25.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label24
        ' 
        Label24.BorderStyle = BorderStyle.FixedSingle
        Label24.Location = New Point(315, 38)
        Label24.Name = "Label24"
        Label24.Size = New Size(220, 23)
        Label24.TabIndex = 90
        Label24.Text = "Note Label"
        Label24.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label22
        ' 
        Label22.BorderStyle = BorderStyle.FixedSingle
        Label22.Location = New Point(42, 177)
        Label22.Name = "Label22"
        Label22.Size = New Size(160, 23)
        Label22.TabIndex = 88
        Label22.Text = "BGM Waveform"
        Label22.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label21
        ' 
        Label21.BorderStyle = BorderStyle.FixedSingle
        Label21.Location = New Point(315, 16)
        Label21.Name = "Label21"
        Label21.Size = New Size(220, 23)
        Label21.TabIndex = 87
        Label21.Text = "Note Height"
        Label21.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label9
        ' 
        Label9.BorderStyle = BorderStyle.FixedSingle
        Label9.Location = New Point(42, 38)
        Label9.Name = "Label9"
        Label9.Size = New Size(160, 23)
        Label9.TabIndex = 139
        Label9.Text = "Column Caption Font"
        Label9.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' cTSSplitter
        ' 
        cTSSplitter.FlatStyle = FlatStyle.Flat
        cTSSplitter.Location = New Point(870, 60)
        cTSSplitter.Name = "cTSSplitter"
        cTSSplitter.Size = New Size(80, 23)
        cTSSplitter.TabIndex = 141
        cTSSplitter.Tag = "9"
        cTSSplitter.Text = "FF000000"
        cTSSplitter.UseVisualStyleBackColor = True
        ' 
        ' Label97
        ' 
        Label97.BorderStyle = BorderStyle.FixedSingle
        Label97.Location = New Point(648, 60)
        Label97.Name = "Label97"
        Label97.Size = New Size(220, 23)
        Label97.TabIndex = 140
        Label97.Text = "Time Selection Splitter"
        Label97.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label96
        ' 
        Label96.BorderStyle = BorderStyle.FixedSingle
        Label96.Location = New Point(648, 82)
        Label96.Name = "Label96"
        Label96.Size = New Size(220, 23)
        Label96.TabIndex = 142
        Label96.Text = "Time Selection Cursor Sensitivity"
        Label96.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' iTSSensitivity
        ' 
        iTSSensitivity.Location = New Point(870, 82)
        iTSSensitivity.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        iTSSensitivity.Name = "iTSSensitivity"
        iTSSensitivity.Size = New Size(80, 23)
        iTSSensitivity.TabIndex = 143
        iTSSensitivity.Tag = "0"
        iTSSensitivity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' cTSMouseOver
        ' 
        cTSMouseOver.FlatStyle = FlatStyle.Flat
        cTSMouseOver.Location = New Point(870, 104)
        cTSMouseOver.Name = "cTSMouseOver"
        cTSMouseOver.Size = New Size(80, 23)
        cTSMouseOver.TabIndex = 145
        cTSMouseOver.Tag = "9"
        cTSMouseOver.Text = "FF000000"
        cTSMouseOver.UseVisualStyleBackColor = True
        ' 
        ' Label91
        ' 
        Label91.BorderStyle = BorderStyle.FixedSingle
        Label91.Location = New Point(648, 104)
        Label91.Name = "Label91"
        Label91.Size = New Size(220, 23)
        Label91.TabIndex = 144
        Label91.Text = "Time Selection MouseOver Border"
        Label91.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label82
        ' 
        Label82.BorderStyle = BorderStyle.FixedSingle
        Label82.Location = New Point(648, 170)
        Label82.Name = "Label82"
        Label82.Size = New Size(220, 23)
        Label82.TabIndex = 146
        Label82.Text = "Time Selection BPM Font"
        Label82.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label14
        ' 
        Label14.BorderStyle = BorderStyle.FixedSingle
        Label14.Location = New Point(648, 199)
        Label14.Name = "Label14"
        Label14.Size = New Size(220, 23)
        Label14.TabIndex = 147
        Label14.Text = "Middle Button Release Sensitivity"
        Label14.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' iMiddleSensitivity
        ' 
        iMiddleSensitivity.BorderStyle = BorderStyle.FixedSingle
        iMiddleSensitivity.Location = New Point(870, 199)
        iMiddleSensitivity.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        iMiddleSensitivity.Name = "iMiddleSensitivity"
        iMiddleSensitivity.Size = New Size(80, 23)
        iMiddleSensitivity.TabIndex = 148
        iMiddleSensitivity.Tag = "0"
        iMiddleSensitivity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        PictureBox1.Location = New Point(10, 259)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1000, 1)
        PictureBox1.TabIndex = 138
        PictureBox1.TabStop = False
        ' 
        ' OpVisual
        ' 
        AcceptButton = OK_Button
        AutoScaleMode = AutoScaleMode.None
        CancelButton = Cancel_Button
        ClientSize = New Size(1026, 713)
        Controls.Add(Label14)
        Controls.Add(iMiddleSensitivity)
        Controls.Add(Label82)
        Controls.Add(cTSMouseOver)
        Controls.Add(Label91)
        Controls.Add(Label96)
        Controls.Add(iTSSensitivity)
        Controls.Add(cTSSplitter)
        Controls.Add(Label97)
        Controls.Add(Label9)
        Controls.Add(PictureBox1)
        Controls.Add(Label33)
        Controls.Add(iHiddenNoteOpacity)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Label23)
        Controls.Add(Panel1)
        Controls.Add(cAdjustLengthBorder)
        Controls.Add(Label37)
        Controls.Add(cSelectedBorder)
        Controls.Add(Label21)
        Controls.Add(cMouseOver)
        Controls.Add(Label22)
        Controls.Add(iLongLabelHorizShift)
        Controls.Add(Label24)
        Controls.Add(iLabelHorizShift)
        Controls.Add(Label25)
        Controls.Add(iLabelVerticalShift)
        Controls.Add(Label26)
        Controls.Add(fMeasureLabel)
        Controls.Add(Label27)
        Controls.Add(fNoteLabel)
        Controls.Add(Label28)
        Controls.Add(iNoteHeight)
        Controls.Add(Label29)
        Controls.Add(fTSBPM)
        Controls.Add(Label30)
        Controls.Add(cTSBPM)
        Controls.Add(Label31)
        Controls.Add(cTSSelectionFill)
        Controls.Add(Label98)
        Controls.Add(cTSCursor)
        Controls.Add(Label86)
        Controls.Add(cSelectionBox)
        Controls.Add(Label34)
        Controls.Add(cWaveForm)
        Controls.Add(Label35)
        Controls.Add(cMeasureBarLine)
        Controls.Add(Label88)
        Controls.Add(cVerticalLine)
        Controls.Add(Label38)
        Controls.Add(cSub)
        Controls.Add(Label39)
        Controls.Add(cGrid)
        Controls.Add(Label40)
        Controls.Add(cBG)
        Controls.Add(cColumnTitle)
        Controls.Add(fColumnTitle)
        Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "OpVisual"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Visual Options"
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        CType(iHiddenNoteOpacity, ComponentModel.ISupportInitialize).EndInit()
        CType(iLongLabelHorizShift, ComponentModel.ISupportInitialize).EndInit()
        CType(iLabelHorizShift, ComponentModel.ISupportInitialize).EndInit()
        CType(iLabelVerticalShift, ComponentModel.ISupportInitialize).EndInit()
        CType(iNoteHeight, ComponentModel.ISupportInitialize).EndInit()
        CType(iTSSensitivity, ComponentModel.ISupportInitialize).EndInit()
        CType(iMiddleSensitivity, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents cColumnTitle As System.Windows.Forms.Button
    Friend WithEvents fColumnTitle As System.Windows.Forms.Button
    Friend WithEvents cBG As System.Windows.Forms.Button
    Friend WithEvents fTSBPM As System.Windows.Forms.Button
    Friend WithEvents cTSBPM As System.Windows.Forms.Button
    Friend WithEvents cTSSelectionFill As System.Windows.Forms.Button
    Friend WithEvents cTSCursor As System.Windows.Forms.Button
    Friend WithEvents cSelectionBox As System.Windows.Forms.Button
    Friend WithEvents cWaveForm As System.Windows.Forms.Button
    Friend WithEvents cMeasureBarLine As System.Windows.Forms.Button
    Friend WithEvents cVerticalLine As System.Windows.Forms.Button
    Friend WithEvents cSub As System.Windows.Forms.Button
    Friend WithEvents cGrid As System.Windows.Forms.Button
    Friend WithEvents fNoteLabel As System.Windows.Forms.Button
    Friend WithEvents iNoteHeight As System.Windows.Forms.NumericUpDown
    Friend WithEvents fMeasureLabel As System.Windows.Forms.Button
    Friend WithEvents iLongLabelHorizShift As System.Windows.Forms.NumericUpDown
    Friend WithEvents iLabelHorizShift As System.Windows.Forms.NumericUpDown
    Friend WithEvents iLabelVerticalShift As System.Windows.Forms.NumericUpDown
    Friend WithEvents cSelectedBorder As System.Windows.Forms.Button
    Friend WithEvents cMouseOver As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cAdjustLengthBorder As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents iHiddenNoteOpacity As System.Windows.Forms.NumericUpDown
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cTSSplitter As System.Windows.Forms.Button
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents iTSSensitivity As System.Windows.Forms.NumericUpDown
    Friend WithEvents cTSMouseOver As System.Windows.Forms.Button
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents iMiddleSensitivity As System.Windows.Forms.NumericUpDown

End Class
