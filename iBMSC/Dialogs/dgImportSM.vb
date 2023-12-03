Public Class dgImportSM

    Public iResult As Integer = -1

    Public Sub New(ByVal sDiff() As String)
        InitializeComponent()

        LDiff.Items.AddRange(sDiff)
        LDiff.SelectedIndex = 0
    End Sub

    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        DialogResult = System.Windows.Forms.DialogResult.OK
        iResult = LDiff.SelectedIndex
        Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Close()
    End Sub

    Private Sub dgImportSM_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim xS() As String = Form1.lpimpSM

        Font = MainWindow.Font

        Text = Strings.fImportSM.Title
        Label7.Text = Strings.fImportSM.Difficulty
        Label5.Text = Strings.fImportSM.Note
        OK_Button.Text = Strings.OK
        Cancel_Button.Text = Strings.Cancel
    End Sub
End Class
