Public Class fLoadFileProgress
    Private xPath(-1) As String
    Private CancelPressed As Boolean = False
    Private IsSaved As Boolean = False

    Public Sub New(xxPath() As String, xIsSaved As Boolean, Optional TopMost As Boolean = True)
        InitializeComponent()
        prog.Maximum = UBound(xxPath) + 1
        xPath = xxPath
        IsSaved = xIsSaved
        Me.TopMost = TopMost
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        DialogResult = DialogResult.Cancel
        CancelPressed = True
        Close()
    End Sub

    Private Sub fLoadFileProgress_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        On Error GoTo 0
        For xI1 = 0 To UBound(xPath)
            Label1.Text = "Currently loading ( " & (xI1 + 1) & " / " & (UBound(xPath) + 1) & " ): " & xPath(xI1)
            Dim aa = prog.Maximum
            Dim bb = prog.Value
            prog.Value = xI1
            Application.DoEvents
            If CancelPressed Then Exit For

            If xI1 = 0 AndAlso IsSaved Then MainWindow.ReadFile(xPath(xI1)) _
                Else Dim unused = Process.Start(Application.ExecutablePath, """" & xPath(xI1) & """") 'Shell("""" & Application.ExecutablePath & """ """ & xPaths(xI1) & """") ' 
        Next
        Close
    End Sub

    Private Sub fLoadFileProgress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Font = MainWindow.Font
        Cancel_Button.Text = Strings.Cancel
    End Sub
End Class
