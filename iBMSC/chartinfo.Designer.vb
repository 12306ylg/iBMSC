<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chartinfo
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
        gotost_Button = New Button()
        Cancel_Button = New Button()
        fultit = New Label()
        alartst = New Label()
        Label1 = New Label()
        Label2 = New Label()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(gotost_Button, 0, 0)
        TableLayoutPanel1.Controls.Add(Cancel_Button, 1, 0)
        TableLayoutPanel1.Location = New Point(323, 358)
        TableLayoutPanel1.Margin = New Padding(4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(170, 38)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' gotost_Button
        ' 
        gotost_Button.Anchor = AnchorStyles.None
        gotost_Button.Location = New Point(4, 4)
        gotost_Button.Margin = New Padding(4)
        gotost_Button.Name = "gotost_Button"
        gotost_Button.Size = New Size(77, 30)
        gotost_Button.TabIndex = 0
        gotost_Button.Text = "Statistics"
        ' 
        ' Cancel_Button
        ' 
        Cancel_Button.Anchor = AnchorStyles.None
        Cancel_Button.Location = New Point(89, 4)
        Cancel_Button.Margin = New Padding(4)
        Cancel_Button.Name = "Cancel_Button"
        Cancel_Button.Size = New Size(77, 30)
        Cancel_Button.TabIndex = 1
        Cancel_Button.Text = "Close"
        ' 
        ' fultit
        ' 
        fultit.AutoSize = True
        fultit.Location = New Point(12, 9)
        fultit.Name = "fultit"
        fultit.Size = New Size(51, 17)
        fultit.TabIndex = 1
        fultit.Text = "FullTitle"
        ' 
        ' alartst
        ' 
        alartst.AutoSize = True
        alartst.Location = New Point(12, 26)
        alartst.Name = "alartst"
        alartst.Size = New Size(52, 17)
        alartst.TabIndex = 2
        alartst.Text = "AllArtist"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(69, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 17)
        Label1.TabIndex = 3
        Label1.Text = "None"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(69, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 17)
        Label2.TabIndex = 4
        Label2.Text = "None"
        ' 
        ' Chartinfo
        ' 
        AcceptButton = gotost_Button
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = Cancel_Button
        ClientSize = New Size(507, 412)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(alartst)
        Controls.Add(fultit)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Chartinfo"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "chartinfo"
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gotost_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents fultit As Label
    Friend WithEvents alartst As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
