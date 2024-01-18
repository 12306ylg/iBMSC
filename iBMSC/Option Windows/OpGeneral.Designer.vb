<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpGeneral
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
        CWheel = New ComboBox()
        CTextEncoding = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        TBAssociate = New Button()
        cBeep = New CheckBox()
        PictureBox1 = New PictureBox()
        cBpm1296 = New CheckBox()
        cStop1296 = New CheckBox()
        cMEnterFocus = New CheckBox()
        cMClickFocus = New CheckBox()
        TBAssociatePMS = New Button()
        TBAssociateIBMSC = New Button()
        Label5 = New Label()
        CPgUpDn = New ComboBox()
        NAutoSave = New NumericUpDown()
        Label7 = New Label()
        cAutoSave = New CheckBox()
        cMStopPreview = New CheckBox()
        nGridPartition = New NumericUpDown()
        Label6 = New Label()
        TBAssociateBME = New Button()
        TBAssociateBML = New Button()
        Label3 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        rMiddleAuto = New RadioButton()
        rMiddleDrag = New RadioButton()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NAutoSave, ComponentModel.ISupportInitialize).BeginInit()
        CType(nGridPartition, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel1.SuspendLayout()
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
        TableLayoutPanel1.Location = New Point(229, 463)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(170, 33)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' OK_Button
        ' 
        OK_Button.Anchor = AnchorStyles.None
        OK_Button.Location = New Point(3, 3)
        OK_Button.Name = "OK_Button"
        OK_Button.Size = New Size(78, 27)
        OK_Button.TabIndex = 0
        OK_Button.Text = "OK"
        ' 
        ' Cancel_Button
        ' 
        Cancel_Button.Anchor = AnchorStyles.None
        Cancel_Button.DialogResult = DialogResult.Cancel
        Cancel_Button.Location = New Point(88, 3)
        Cancel_Button.Name = "Cancel_Button"
        Cancel_Button.Size = New Size(78, 27)
        Cancel_Button.TabIndex = 1
        Cancel_Button.Text = "Cancel"
        ' 
        ' CWheel
        ' 
        CWheel.DropDownStyle = ComboBoxStyle.DropDownList
        CWheel.FormattingEnabled = True
        CWheel.Items.AddRange(New Object() {"1", "1 / 2", "1 / 3", "1 / 4"})
        CWheel.Location = New Point(154, 269)
        CWheel.Name = "CWheel"
        CWheel.Size = New Size(237, 25)
        CWheel.TabIndex = 11
        ' 
        ' CTextEncoding
        ' 
        CTextEncoding.DropDownStyle = ComboBoxStyle.DropDownList
        CTextEncoding.FormattingEnabled = True
        CTextEncoding.Items.AddRange(New Object() {"ANSI (Locale dependant)", "Little Endian UTF16", "ASCII", "Big Endian UTF16", "Little Endian UTF32", "UTF7", "UTF8", "Shift-JIS", "EUC-KR"})
        CTextEncoding.Location = New Point(137, 18)
        CTextEncoding.Name = "CTextEncoding"
        CTextEncoding.Size = New Size(254, 25)
        CTextEncoding.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(12, 271)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 17)
        Label1.TabIndex = 40
        Label1.Text = "Mouse Wheel"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(-5, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 17)
        Label2.TabIndex = 41
        Label2.Text = "Text Encoding"
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(-5, 50)
        Label4.Name = "Label4"
        Label4.Size = New Size(136, 17)
        Label4.TabIndex = 43
        Label4.Text = "Associate Filetype"
        Label4.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TBAssociate
        ' 
        TBAssociate.Location = New Point(137, 47)
        TBAssociate.Name = "TBAssociate"
        TBAssociate.Size = New Size(122, 23)
        TBAssociate.TabIndex = 3
        TBAssociate.Text = "*.bms"
        TBAssociate.UseVisualStyleBackColor = True
        ' 
        ' cBeep
        ' 
        cBeep.AutoSize = True
        cBeep.Checked = True
        cBeep.CheckState = CheckState.Checked
        cBeep.Location = New Point(32, 169)
        cBeep.Name = "cBeep"
        cBeep.Size = New Size(128, 21)
        cBeep.TabIndex = 8
        cBeep.Text = "Beep while saved"
        cBeep.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        PictureBox1.Location = New Point(20, 253)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(375, 1)
        PictureBox1.TabIndex = 47
        PictureBox1.TabStop = False
        ' 
        ' cBpm1296
        ' 
        cBpm1296.AutoSize = True
        cBpm1296.Location = New Point(32, 194)
        cBpm1296.Name = "cBpm1296"
        cBpm1296.Size = New Size(278, 21)
        cBpm1296.TabIndex = 9
        cBpm1296.Text = "Extend number of multi-byte BPMs to 1296"
        cBpm1296.UseVisualStyleBackColor = True
        ' 
        ' cStop1296
        ' 
        cStop1296.AutoSize = True
        cStop1296.Location = New Point(32, 219)
        cStop1296.Name = "cStop1296"
        cStop1296.Size = New Size(220, 21)
        cStop1296.TabIndex = 10
        cStop1296.Text = "Extend number of STOPs to 1296"
        cStop1296.UseVisualStyleBackColor = True
        ' 
        ' cMEnterFocus
        ' 
        cMEnterFocus.AutoSize = True
        cMEnterFocus.Location = New Point(34, 379)
        cMEnterFocus.Name = "cMEnterFocus"
        cMEnterFocus.Size = New Size(352, 21)
        cMEnterFocus.TabIndex = 14
        cMEnterFocus.Text = "Automatically set focus to editing panel on mouse enter"
        cMEnterFocus.UseVisualStyleBackColor = True
        ' 
        ' cMClickFocus
        ' 
        cMClickFocus.AutoSize = True
        cMClickFocus.Location = New Point(34, 404)
        cMClickFocus.Name = "cMClickFocus"
        cMClickFocus.Size = New Size(324, 21)
        cMClickFocus.TabIndex = 15
        cMClickFocus.Text = "Disable first click if the editing panel is not focused"
        cMClickFocus.UseVisualStyleBackColor = True
        ' 
        ' TBAssociatePMS
        ' 
        TBAssociatePMS.Location = New Point(310, 78)
        TBAssociatePMS.Name = "TBAssociatePMS"
        TBAssociatePMS.Size = New Size(81, 23)
        TBAssociatePMS.TabIndex = 4
        TBAssociatePMS.Text = "*.pms"
        TBAssociatePMS.UseVisualStyleBackColor = True
        ' 
        ' TBAssociateIBMSC
        ' 
        TBAssociateIBMSC.Location = New Point(265, 47)
        TBAssociateIBMSC.Name = "TBAssociateIBMSC"
        TBAssociateIBMSC.Size = New Size(127, 23)
        TBAssociateIBMSC.TabIndex = 5
        TBAssociateIBMSC.Text = "*.ibmsc"
        TBAssociateIBMSC.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.Location = New Point(12, 300)
        Label5.Name = "Label5"
        Label5.Size = New Size(136, 17)
        Label5.TabIndex = 56
        Label5.Text = "PageUp / PageDown"
        Label5.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' CPgUpDn
        ' 
        CPgUpDn.DropDownStyle = ComboBoxStyle.DropDownList
        CPgUpDn.FormattingEnabled = True
        CPgUpDn.Items.AddRange(New Object() {"8", "6", "4", "3", "2", "1", "1 / 2"})
        CPgUpDn.Location = New Point(154, 298)
        CPgUpDn.Name = "CPgUpDn"
        CPgUpDn.Size = New Size(237, 25)
        CPgUpDn.TabIndex = 12
        ' 
        ' NAutoSave
        ' 
        NAutoSave.DecimalPlaces = 1
        NAutoSave.Location = New Point(171, 142)
        NAutoSave.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        NAutoSave.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NAutoSave.Name = "NAutoSave"
        NAutoSave.Size = New Size(62, 23)
        NAutoSave.TabIndex = 7
        NAutoSave.Value = New Decimal(New Integer() {2, 0, 0, 0})
        ' 
        ' Label7
        ' 
        Label7.Location = New Point(239, 144)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 17)
        Label7.TabIndex = 59
        Label7.Text = "minutes"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cAutoSave
        ' 
        cAutoSave.AutoSize = True
        cAutoSave.Checked = True
        cAutoSave.CheckState = CheckState.Checked
        cAutoSave.Location = New Point(32, 144)
        cAutoSave.Name = "cAutoSave"
        cAutoSave.Size = New Size(81, 21)
        cAutoSave.TabIndex = 6
        cAutoSave.Text = "AutoSave"
        cAutoSave.UseVisualStyleBackColor = True
        ' 
        ' cMStopPreview
        ' 
        cMStopPreview.AutoSize = True
        cMStopPreview.Checked = True
        cMStopPreview.CheckState = CheckState.Checked
        cMStopPreview.Location = New Point(34, 429)
        cMStopPreview.Name = "cMStopPreview"
        cMStopPreview.Size = New Size(279, 21)
        cMStopPreview.TabIndex = 60
        cMStopPreview.Text = "Stop preview if clicked on the editing panel"
        cMStopPreview.UseVisualStyleBackColor = True
        ' 
        ' nGridPartition
        ' 
        nGridPartition.Location = New Point(219, 107)
        nGridPartition.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nGridPartition.Minimum = New Decimal(New Integer() {8, 0, 0, 0})
        nGridPartition.Name = "nGridPartition"
        nGridPartition.Size = New Size(79, 23)
        nGridPartition.TabIndex = 61
        nGridPartition.Value = New Decimal(New Integer() {192, 0, 0, 0})
        ' 
        ' Label6
        ' 
        Label6.Location = New Point(44, 108)
        Label6.Name = "Label6"
        Label6.Size = New Size(169, 17)
        Label6.TabIndex = 62
        Label6.Text = "Max Grid Partition in BMS"
        Label6.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TBAssociateBME
        ' 
        TBAssociateBME.Location = New Point(137, 78)
        TBAssociateBME.Name = "TBAssociateBME"
        TBAssociateBME.Size = New Size(76, 23)
        TBAssociateBME.TabIndex = 63
        TBAssociateBME.Text = "*.bme"
        TBAssociateBME.UseVisualStyleBackColor = True
        ' 
        ' TBAssociateBML
        ' 
        TBAssociateBML.Location = New Point(219, 78)
        TBAssociateBML.Name = "TBAssociateBML"
        TBAssociateBML.Size = New Size(85, 23)
        TBAssociateBML.TabIndex = 64
        TBAssociateBML.Text = "*.bml"
        TBAssociateBML.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(12, 328)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 17)
        Label3.TabIndex = 65
        Label3.Text = "Mouse Middle Button"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoSize = True
        FlowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel1.Controls.Add(rMiddleAuto)
        FlowLayoutPanel1.Controls.Add(rMiddleDrag)
        FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel1.Location = New Point(154, 327)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(152, 42)
        FlowLayoutPanel1.TabIndex = 66
        ' 
        ' rMiddleAuto
        ' 
        rMiddleAuto.AutoSize = True
        rMiddleAuto.Checked = True
        rMiddleAuto.Location = New Point(3, 0)
        rMiddleAuto.Margin = New Padding(3, 0, 3, 0)
        rMiddleAuto.Name = "rMiddleAuto"
        rMiddleAuto.Size = New Size(146, 21)
        rMiddleAuto.TabIndex = 0
        rMiddleAuto.TabStop = True
        rMiddleAuto.Text = "Click and Auto Scroll"
        rMiddleAuto.UseVisualStyleBackColor = True
        ' 
        ' rMiddleDrag
        ' 
        rMiddleDrag.AutoSize = True
        rMiddleDrag.Location = New Point(3, 21)
        rMiddleDrag.Margin = New Padding(3, 0, 3, 0)
        rMiddleDrag.Name = "rMiddleDrag"
        rMiddleDrag.Size = New Size(112, 21)
        rMiddleDrag.TabIndex = 1
        rMiddleDrag.TabStop = True
        rMiddleDrag.Text = "Click and Drag"
        rMiddleDrag.UseVisualStyleBackColor = True
        ' 
        ' OpGeneral
        ' 
        AcceptButton = OK_Button
        AutoScaleMode = AutoScaleMode.None
        CancelButton = Cancel_Button
        ClientSize = New Size(413, 510)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Label3)
        Controls.Add(TBAssociateBML)
        Controls.Add(TBAssociateBME)
        Controls.Add(Label6)
        Controls.Add(nGridPartition)
        Controls.Add(cMStopPreview)
        Controls.Add(cAutoSave)
        Controls.Add(Label7)
        Controls.Add(NAutoSave)
        Controls.Add(Label5)
        Controls.Add(CPgUpDn)
        Controls.Add(TBAssociateIBMSC)
        Controls.Add(TBAssociatePMS)
        Controls.Add(cMClickFocus)
        Controls.Add(cMEnterFocus)
        Controls.Add(cStop1296)
        Controls.Add(cBpm1296)
        Controls.Add(PictureBox1)
        Controls.Add(cBeep)
        Controls.Add(TBAssociate)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(CTextEncoding)
        Controls.Add(CWheel)
        Controls.Add(TableLayoutPanel1)
        Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "OpGeneral"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "General Settings"
        TableLayoutPanel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(NAutoSave, ComponentModel.ISupportInitialize).EndInit()
        CType(nGridPartition, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents CWheel As System.Windows.Forms.ComboBox
    Friend WithEvents CTextEncoding As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBAssociate As System.Windows.Forms.Button
    Friend WithEvents cBeep As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cBpm1296 As System.Windows.Forms.CheckBox
    Friend WithEvents cStop1296 As System.Windows.Forms.CheckBox
    Friend WithEvents cMEnterFocus As System.Windows.Forms.CheckBox
    Friend WithEvents cMClickFocus As System.Windows.Forms.CheckBox
    Friend WithEvents TBAssociatePMS As System.Windows.Forms.Button
    Friend WithEvents TBAssociateIBMSC As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CPgUpDn As System.Windows.Forms.ComboBox
    Friend WithEvents NAutoSave As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cAutoSave As System.Windows.Forms.CheckBox
    Friend WithEvents cMStopPreview As System.Windows.Forms.CheckBox
    Friend WithEvents nGridPartition As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TBAssociateBME As System.Windows.Forms.Button
    Friend WithEvents TBAssociateBML As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents rMiddleAuto As System.Windows.Forms.RadioButton
    Friend WithEvents rMiddleDrag As System.Windows.Forms.RadioButton

End Class
