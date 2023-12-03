Public Class fLoadFileProgress
    Private xPath(-1) As String
    Private CancelPressed As Boolean = False
    Private IsSaved As Boolean = False

    Public Sub New(ByVal xxPath() As String, ByVal xIsSaved As Boolean, Optional ByVal TopMost As Boolean = True)
        InitializeComponent()
        prog.Maximum = UBound(xxPath) + 1
        xPath = xxPath
        IsSaved = xIsSaved
        Me.TopMost = TopMost
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        DialogResult = Forms.DialogResult.Cancel
        CancelPressed = True
        Close()
    End Sub

    Private Sub fLoadFileProgress_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
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

    Private Sub fLoadFileProgress_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Font = MainWindow.Font
        Cancel_Button.Text = Strings.Cancel
    End Sub
End Class
