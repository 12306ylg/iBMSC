Imports CSCore
Imports CSCore.Codecs


Partial Public Class MainWindow

    '----WaveForm Options
    Private wWavL() As Single
    Private wWavR() As Single
    Private wLock As Boolean = True
    Private wSampleRate As Integer
    Private wPosition As Double = 0
    Private wLeft As Integer = 50
    Private wWidth As Integer = 100
    Private wPrecision As Integer = 1

    Private Sub BWLoad_Click(sender As Object, e As EventArgs) Handles BWLoad.Click
        Dim xDWAV As New OpenFileDialog With {
            .Filter = "Wave files (*.wav, *.ogg)" & "|*.wav;*.ogg",
            .DefaultExt = "wav",
            .InitialDirectory = IIf(ExcludeFileName(FileName) = String.Empty, InitPath, ExcludeFileName(FileName))
        }

        If xDWAV.ShowDialog = Forms.DialogResult.Cancel Then Exit Sub
        InitPath = ExcludeFileName(xDWAV.FileName)

        Dim src = CodecFactory.Instance.GetCodec(xDWAV.FileName)

        Dim unused1 = src.ToStereo()
        Dim samples(src.Length) As Single
        Dim unused = src.ToSampleSource().Read(samples, 0, src.Length)

        Dim flen = (src.Length - 1) / src.WaveFormat.Channels

        ' Copy interleaved data
        ReDim wWavL(flen + 1)
        ReDim wWavR(flen + 1)
        For i As Integer = 0 To flen
            If 2 * i < src.Length Then
                wWavL(i) = samples(2 * i)
            End If
            If (2 * i) + 1 < src.Length Then
                wWavR(i) = samples((2 * i) + 1)
            End If
        Next

        wSampleRate = src.WaveFormat.SampleRate
        RefreshPanelAll()

        TWFileName.Text = xDWAV.FileName
        TWFileName.Select(Len(xDWAV.FileName), 0)
    End Sub

    Private Sub BWClear_Click(sender As Object, e As EventArgs) Handles BWClear.Click
        Erase wWavL
        Erase wWavR
        TWFileName.Text = "(" & Strings.None & ")"
        RefreshPanelAll()
    End Sub

    Private Sub BWLock_CheckedChanged(sender As Object, e As EventArgs) Handles BWLock.CheckedChanged
        wLock = BWLock.Checked
        TWPosition.Enabled = Not wLock
        TWPosition2.Enabled = Not wLock
        RefreshPanelAll()
    End Sub
End Class
