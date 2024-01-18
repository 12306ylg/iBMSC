<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpPlayer
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TPlayB = New TextBox()
        TPlay = New TextBox()
        TStop = New TextBox()
        Label6 = New Label()
        TPath = New TextBox()
        Label1 = New Label()
        BBrowse = New Button()
        BDefault = New Button()
        BRemove = New Button()
        BAdd = New Button()
        LPlayer = New ListBox()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        Label7 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' OK_Button
        ' 
        OK_Button.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        OK_Button.FlatStyle = FlatStyle.System
        OK_Button.Location = New Point(72, 316)
        OK_Button.Name = "OK_Button"
        OK_Button.Size = New Size(78, 23)
        OK_Button.TabIndex = 0
        OK_Button.Text = "OK"
        ' 
        ' Cancel_Button
        ' 
        Cancel_Button.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Cancel_Button.DialogResult = DialogResult.Cancel
        Cancel_Button.FlatStyle = FlatStyle.System
        Cancel_Button.Location = New Point(156, 316)
        Cancel_Button.Name = "Cancel_Button"
        Cancel_Button.Size = New Size(78, 23)
        Cancel_Button.TabIndex = 1
        Cancel_Button.Text = "Cancel"
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(14, 153)
        Label2.Name = "Label2"
        Label2.Size = New Size(157, 15)
        Label2.TabIndex = 3
        Label2.Text = "Play from beginning"
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(14, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(157, 15)
        Label3.TabIndex = 4
        Label3.Text = "Play from current measure"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(14, 211)
        Label4.Name = "Label4"
        Label4.Size = New Size(157, 15)
        Label4.TabIndex = 5
        Label4.Text = "Stop"
        Label4.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TPlayB
        ' 
        TPlayB.Location = New Point(177, 150)
        TPlayB.Name = "TPlayB"
        TPlayB.Size = New Size(192, 23)
        TPlayB.TabIndex = 4
        ' 
        ' TPlay
        ' 
        TPlay.Location = New Point(177, 179)
        TPlay.Name = "TPlay"
        TPlay.Size = New Size(192, 23)
        TPlay.TabIndex = 5
        ' 
        ' TStop
        ' 
        TStop.Location = New Point(177, 208)
        TStop.Name = "TStop"
        TStop.Size = New Size(192, 23)
        TStop.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(14, 244)
        Label6.Name = "Label6"
        Label6.Size = New Size(225, 60)
        Label6.TabIndex = 11
        Label6.Text = "References (case-sensitive):" & vbCrLf & "<apppath> = Directory of the application" & vbCrLf & "<measure> = Current measure" & vbCrLf & "<filename> = File Name"
        ' 
        ' TPath
        ' 
        TPath.Location = New Point(51, 98)
        TPath.Name = "TPath"
        TPath.Size = New Size(288, 23)
        TPath.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(0, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 12
        Label1.Text = "Path"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' BBrowse
        ' 
        BBrowse.FlatStyle = FlatStyle.System
        BBrowse.Location = New Point(345, 98)
        BBrowse.Name = "BBrowse"
        BBrowse.Size = New Size(24, 23)
        BBrowse.TabIndex = 3
        BBrowse.Text = "..."
        BBrowse.UseVisualStyleBackColor = True
        ' 
        ' BDefault
        ' 
        BDefault.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        BDefault.FlatStyle = FlatStyle.System
        BDefault.Location = New Point(240, 316)
        BDefault.Name = "BDefault"
        BDefault.Size = New Size(130, 23)
        BDefault.TabIndex = 62
        BDefault.Text = "Restore default"
        BDefault.UseVisualStyleBackColor = True
        ' 
        ' BRemove
        ' 
        BRemove.FlatStyle = FlatStyle.System
        BRemove.Location = New Point(243, 41)
        BRemove.Name = "BRemove"
        BRemove.Size = New Size(117, 23)
        BRemove.TabIndex = 59
        BRemove.Text = "Remove"
        BRemove.UseVisualStyleBackColor = True
        ' 
        ' BAdd
        ' 
        BAdd.FlatStyle = FlatStyle.System
        BAdd.Location = New Point(243, 12)
        BAdd.Name = "BAdd"
        BAdd.Size = New Size(117, 23)
        BAdd.TabIndex = 58
        BAdd.Text = "Add"
        BAdd.UseVisualStyleBackColor = True
        ' 
        ' LPlayer
        ' 
        LPlayer.FormattingEnabled = True
        LPlayer.IntegralHeight = False
        LPlayer.ItemHeight = 15
        LPlayer.Items.AddRange(New Object() {"uBMplay.exe", "o2play.exe", "beatoraja"})
        LPlayer.Location = New Point(12, 27)
        LPlayer.Name = "LPlayer"
        LPlayer.Size = New Size(225, 55)
        LPlayer.TabIndex = 63
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(12, 134)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(357, 1)
        PictureBox1.TabIndex = 64
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 15)
        Label5.TabIndex = 65
        Label5.Text = "Current Player:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 126)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 15)
        Label7.TabIndex = 66
        Label7.Text = "Arguments"
        ' 
        ' OpPlayer
        ' 
        AcceptButton = OK_Button
        AutoScaleMode = AutoScaleMode.None
        CancelButton = Cancel_Button
        ClientSize = New Size(382, 351)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(PictureBox1)
        Controls.Add(Cancel_Button)
        Controls.Add(OK_Button)
        Controls.Add(LPlayer)
        Controls.Add(BDefault)
        Controls.Add(BRemove)
        Controls.Add(BAdd)
        Controls.Add(BBrowse)
        Controls.Add(TPath)
        Controls.Add(Label1)
        Controls.Add(Label6)
        Controls.Add(TStop)
        Controls.Add(TPlay)
        Controls.Add(TPlayB)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "OpPlayer"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Player Options"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TPlayB As System.Windows.Forms.TextBox
    Friend WithEvents TPlay As System.Windows.Forms.TextBox
    Friend WithEvents TStop As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TPath As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BBrowse As System.Windows.Forms.Button
    Friend WithEvents BDefault As System.Windows.Forms.Button
    Friend WithEvents BRemove As System.Windows.Forms.Button
    Friend WithEvents BAdd As System.Windows.Forms.Button
    Friend WithEvents LPlayer As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
