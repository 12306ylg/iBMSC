<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColorPicker
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
        OK_Button = New Button()
        Cancel_Button = New Button()
        PCMain = New Panel()
        tbPrecision = New TrackBar()
        PCA = New Panel()
        PC1 = New Panel()
        rbH = New RadioButton()
        rbS = New RadioButton()
        rbL = New RadioButton()
        rbR = New RadioButton()
        rbG = New RadioButton()
        rbB = New RadioButton()
        inH = New NumericUpDown()
        inS = New NumericUpDown()
        inL = New NumericUpDown()
        inR = New NumericUpDown()
        inG = New NumericUpDown()
        inB = New NumericUpDown()
        Label1 = New Label()
        tStr = New TextBox()
        Label2 = New Label()
        inA = New NumericUpDown()
        rbA = New RadioButton()
        pPrev = New Panel()
        CType(tbPrecision, ComponentModel.ISupportInitialize).BeginInit()
        CType(inH, ComponentModel.ISupportInitialize).BeginInit()
        CType(inS, ComponentModel.ISupportInitialize).BeginInit()
        CType(inL, ComponentModel.ISupportInitialize).BeginInit()
        CType(inR, ComponentModel.ISupportInitialize).BeginInit()
        CType(inG, ComponentModel.ISupportInitialize).BeginInit()
        CType(inB, ComponentModel.ISupportInitialize).BeginInit()
        CType(inA, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' OK_Button
        ' 
        OK_Button.Anchor = AnchorStyles.None
        OK_Button.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        OK_Button.Location = New Point(315, 275)
        OK_Button.Name = "OK_Button"
        OK_Button.Size = New Size(126, 27)
        OK_Button.TabIndex = 21
        OK_Button.Text = "OK"
        ' 
        ' Cancel_Button
        ' 
        Cancel_Button.Anchor = AnchorStyles.None
        Cancel_Button.DialogResult = DialogResult.Cancel
        Cancel_Button.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Cancel_Button.Location = New Point(315, 306)
        Cancel_Button.Name = "Cancel_Button"
        Cancel_Button.Size = New Size(126, 27)
        Cancel_Button.TabIndex = 22
        Cancel_Button.Text = "Cancel"
        ' 
        ' PCMain
        ' 
        PCMain.BorderStyle = BorderStyle.FixedSingle
        PCMain.Location = New Point(14, 14)
        PCMain.Name = "PCMain"
        PCMain.Size = New Size(258, 258)
        PCMain.TabIndex = 1
        ' 
        ' tbPrecision
        ' 
        tbPrecision.LargeChange = 2
        tbPrecision.Location = New Point(73, 303)
        tbPrecision.Minimum = 1
        tbPrecision.Name = "tbPrecision"
        tbPrecision.Size = New Size(199, 45)
        tbPrecision.TabIndex = 2
        tbPrecision.Value = 2
        ' 
        ' PCA
        ' 
        PCA.BorderStyle = BorderStyle.FixedSingle
        PCA.Location = New Point(14, 278)
        PCA.Name = "PCA"
        PCA.Size = New Size(258, 19)
        PCA.TabIndex = 3
        ' 
        ' PC1
        ' 
        PC1.BorderStyle = BorderStyle.FixedSingle
        PC1.Location = New Point(278, 14)
        PC1.Name = "PC1"
        PC1.Size = New Size(19, 258)
        PC1.TabIndex = 4
        ' 
        ' rbH
        ' 
        rbH.Appearance = Appearance.Button
        rbH.FlatStyle = FlatStyle.Popup
        rbH.Location = New Point(315, 55)
        rbH.Name = "rbH"
        rbH.Size = New Size(77, 23)
        rbH.TabIndex = 7
        rbH.Text = "H (0-359)"
        rbH.UseVisualStyleBackColor = True
        ' 
        ' rbS
        ' 
        rbS.Appearance = Appearance.Button
        rbS.FlatStyle = FlatStyle.Popup
        rbS.Location = New Point(315, 80)
        rbS.Name = "rbS"
        rbS.Size = New Size(77, 23)
        rbS.TabIndex = 8
        rbS.Text = "S (0-1000)"
        rbS.UseVisualStyleBackColor = True
        ' 
        ' rbL
        ' 
        rbL.Appearance = Appearance.Button
        rbL.FlatStyle = FlatStyle.Popup
        rbL.Location = New Point(315, 105)
        rbL.Name = "rbL"
        rbL.Size = New Size(77, 23)
        rbL.TabIndex = 9
        rbL.Text = "L (0-1000)"
        rbL.UseVisualStyleBackColor = True
        ' 
        ' rbR
        ' 
        rbR.Appearance = Appearance.Button
        rbR.FlatStyle = FlatStyle.Popup
        rbR.Location = New Point(315, 134)
        rbR.Name = "rbR"
        rbR.Size = New Size(77, 23)
        rbR.TabIndex = 10
        rbR.Text = "R (0-255)"
        rbR.UseVisualStyleBackColor = True
        ' 
        ' rbG
        ' 
        rbG.Appearance = Appearance.Button
        rbG.FlatStyle = FlatStyle.Popup
        rbG.Location = New Point(315, 159)
        rbG.Name = "rbG"
        rbG.Size = New Size(77, 23)
        rbG.TabIndex = 11
        rbG.Text = "G (0-255)"
        rbG.UseVisualStyleBackColor = True
        ' 
        ' rbB
        ' 
        rbB.Appearance = Appearance.Button
        rbB.FlatStyle = FlatStyle.Popup
        rbB.Location = New Point(315, 184)
        rbB.Name = "rbB"
        rbB.Size = New Size(77, 23)
        rbB.TabIndex = 12
        rbB.Text = "B (0-255)"
        rbB.UseVisualStyleBackColor = True
        ' 
        ' inH
        ' 
        inH.Location = New Point(396, 55)
        inH.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        inH.Name = "inH"
        inH.Size = New Size(45, 23)
        inH.TabIndex = 14
        ' 
        ' inS
        ' 
        inS.Location = New Point(396, 80)
        inS.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        inS.Name = "inS"
        inS.Size = New Size(45, 23)
        inS.TabIndex = 15
        ' 
        ' inL
        ' 
        inL.Location = New Point(396, 105)
        inL.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        inL.Name = "inL"
        inL.Size = New Size(45, 23)
        inL.TabIndex = 16
        ' 
        ' inR
        ' 
        inR.Location = New Point(396, 134)
        inR.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        inR.Name = "inR"
        inR.Size = New Size(45, 23)
        inR.TabIndex = 17
        ' 
        ' inG
        ' 
        inG.Location = New Point(396, 159)
        inG.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        inG.Name = "inG"
        inG.Size = New Size(45, 23)
        inG.TabIndex = 18
        ' 
        ' inB
        ' 
        inB.Location = New Point(396, 184)
        inB.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        inB.Name = "inB"
        inB.Size = New Size(45, 23)
        inB.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(16, 305)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 17)
        Label1.TabIndex = 99
        Label1.Text = "Precision:"
        ' 
        ' tStr
        ' 
        tStr.Location = New Point(340, 245)
        tStr.Name = "tStr"
        tStr.Size = New Size(89, 23)
        tStr.TabIndex = 0
        tStr.Text = "FF000000"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ButtonHighlight
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Location = New Point(320, 248)
        Label2.Name = "Label2"
        Label2.Size = New Size(18, 19)
        Label2.TabIndex = 21
        Label2.Text = "#"
        ' 
        ' inA
        ' 
        inA.Location = New Point(396, 213)
        inA.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        inA.Name = "inA"
        inA.Size = New Size(45, 23)
        inA.TabIndex = 20
        inA.Value = New Decimal(New Integer() {255, 0, 0, 0})
        ' 
        ' rbA
        ' 
        rbA.Appearance = Appearance.Button
        rbA.Enabled = False
        rbA.FlatStyle = FlatStyle.Popup
        rbA.Location = New Point(315, 213)
        rbA.Name = "rbA"
        rbA.Size = New Size(77, 23)
        rbA.TabIndex = 13
        rbA.Text = "A (0-255)"
        rbA.UseVisualStyleBackColor = True
        ' 
        ' pPrev
        ' 
        pPrev.BorderStyle = BorderStyle.FixedSingle
        pPrev.Location = New Point(315, 14)
        pPrev.Name = "pPrev"
        pPrev.Size = New Size(125, 30)
        pPrev.TabIndex = 25
        ' 
        ' ColorPicker
        ' 
        AcceptButton = OK_Button
        AutoScaleMode = AutoScaleMode.None
        CancelButton = Cancel_Button
        ClientSize = New Size(453, 345)
        Controls.Add(inA)
        Controls.Add(rbA)
        Controls.Add(Label2)
        Controls.Add(tStr)
        Controls.Add(Label1)
        Controls.Add(Cancel_Button)
        Controls.Add(OK_Button)
        Controls.Add(inB)
        Controls.Add(inG)
        Controls.Add(inR)
        Controls.Add(inL)
        Controls.Add(inS)
        Controls.Add(inH)
        Controls.Add(rbB)
        Controls.Add(rbG)
        Controls.Add(rbR)
        Controls.Add(rbL)
        Controls.Add(rbS)
        Controls.Add(rbH)
        Controls.Add(PC1)
        Controls.Add(PCA)
        Controls.Add(tbPrecision)
        Controls.Add(PCMain)
        Controls.Add(pPrev)
        Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "ColorPicker"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "ColorPicker"
        CType(tbPrecision, ComponentModel.ISupportInitialize).EndInit()
        CType(inH, ComponentModel.ISupportInitialize).EndInit()
        CType(inS, ComponentModel.ISupportInitialize).EndInit()
        CType(inL, ComponentModel.ISupportInitialize).EndInit()
        CType(inR, ComponentModel.ISupportInitialize).EndInit()
        CType(inG, ComponentModel.ISupportInitialize).EndInit()
        CType(inB, ComponentModel.ISupportInitialize).EndInit()
        CType(inA, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents PCMain As System.Windows.Forms.Panel
    Friend WithEvents tbPrecision As System.Windows.Forms.TrackBar
    Friend WithEvents PCA As System.Windows.Forms.Panel
    Friend WithEvents PC1 As System.Windows.Forms.Panel
    Friend WithEvents rbH As System.Windows.Forms.RadioButton
    Friend WithEvents rbS As System.Windows.Forms.RadioButton
    Friend WithEvents rbL As System.Windows.Forms.RadioButton
    Friend WithEvents rbR As System.Windows.Forms.RadioButton
    Friend WithEvents rbG As System.Windows.Forms.RadioButton
    Friend WithEvents rbB As System.Windows.Forms.RadioButton
    Friend WithEvents inH As System.Windows.Forms.NumericUpDown
    Friend WithEvents inS As System.Windows.Forms.NumericUpDown
    Friend WithEvents inL As System.Windows.Forms.NumericUpDown
    Friend WithEvents inR As System.Windows.Forms.NumericUpDown
    Friend WithEvents inG As System.Windows.Forms.NumericUpDown
    Friend WithEvents inB As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tStr As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents inA As System.Windows.Forms.NumericUpDown
    Friend WithEvents rbA As System.Windows.Forms.RadioButton
    Friend WithEvents pPrev As System.Windows.Forms.Panel

End Class
