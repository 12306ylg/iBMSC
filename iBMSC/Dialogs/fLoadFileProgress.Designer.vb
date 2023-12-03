<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fLoadFileProgress
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
        Cancel_Button = New Button()
        prog = New ProgressBar()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Cancel_Button
        ' 
        Cancel_Button.Anchor = AnchorStyles.Bottom
        Cancel_Button.DialogResult = DialogResult.Cancel
        Cancel_Button.Location = New Point(245, 81)
        Cancel_Button.Name = "Cancel_Button"
        Cancel_Button.Size = New Size(120, 27)
        Cancel_Button.TabIndex = 1
        Cancel_Button.Text = "Cancel"
        ' 
        ' prog
        ' 
        prog.Location = New Point(15, 60)
        prog.Name = "prog"
        prog.Size = New Size(584, 15)
        prog.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(587, 48)
        Label1.TabIndex = 3
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' fLoadFileProgress
        ' 
        AcceptButton = Cancel_Button
        AutoScaleMode = AutoScaleMode.None
        CancelButton = Cancel_Button
        ClientSize = New Size(611, 120)
        ControlBox = False
        Controls.Add(Label1)
        Controls.Add(prog)
        Controls.Add(Cancel_Button)
        Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "fLoadFileProgress"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Loading Files"
        TopMost = True
        ResumeLayout(False)

    End Sub
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents prog As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
