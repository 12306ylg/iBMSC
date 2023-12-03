Public Class diagFind
    Private bCol As Integer = 83
    Private msg1 As String = "Error"
    Private msg2 As String = "Invalid label."

    Public Sub New(ByVal xbCol As Integer, ByVal xmsg1 As String, ByVal xmsg2 As String)
        InitializeComponent()
        bCol = xbCol
        msg1 = xmsg1
        msg2 = xmsg2
    End Sub

    Private Sub CloseDialog(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBClose.Click
        Close()
    End Sub

    Private Sub BSAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BSAll.Click
        For Each xCB As CheckBox In Panel1.Controls
            xCB.Checked = True
        Next
    End Sub
    Private Sub BSInv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BSInv.Click
        For Each xCB As CheckBox In Panel1.Controls
            xCB.Checked = Not xCB.Checked
        Next
    End Sub
    Private Sub BSNone_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BSNone.Click
        For Each xCB As CheckBox In Panel1.Controls
            xCB.Checked = False
        Next
    End Sub

    Private Sub diagFind_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Font = MainWindow.Font
        Dim xBold As New Font(Font, FontStyle.Bold)

        TBSelect.Font = xBold
        Label8.Font = xBold
        Label9.Font = xBold

        'Dim xS() As String = Form1.lpfdr
        Text = MainWindow.TBFind.Text

        Label1.Text = Strings.fFind.NoteRange
        Label2.Text = Strings.fFind.MeasureRange
        Label3.Text = Strings.fFind.LabelRange
        Label4.Text = Strings.fFind.ValueRange
        Label5.Text = Strings.fFind.to_
        Label6.Text = Strings.fFind.to_
        Label7.Text = Strings.fFind.to_

        cbx1.Text = Strings.fFind.Selected
        cbx2.Text = Strings.fFind.UnSelected
        cbx3.Text = Strings.fFind.ShortNote
        cbx4.Text = Strings.fFind.LongNote
        cbx5.Text = Strings.fFind.Hidden
        cbx6.Text = Strings.fFind.Visible

        Label8.Text = Strings.fFind.Column
        BSAll.Text = Strings.fFind.SelectAll
        BSInv.Text = Strings.fFind.SelectInverse
        BSNone.Text = Strings.fFind.UnselectAll

        Label9.Text = Strings.fFind.Operation
        TBrl.Text = Strings.fFind.ReplaceWithLabel
        TBrv.Text = Strings.fFind.ReplaceWithValue
        TBSelect.Text = Strings.fFind.Select_
        TBUnselect.Text = Strings.fFind.Unselect_
        TBDelete.Text = Strings.fFind.Delete_
        TBClose.Text = Strings.fFind.Close_

        Panel1.Controls.Add(cb1)
        Panel1.Controls.Add(cb2)
        Panel1.Controls.Add(cb3)

        Dim xColumn = 1
        Dim xLow = 0
        For xI1 As Integer = 0 To 25
            Dim xCB As New CheckBox
            If MainWindow.column(MainWindow.niA1 + xI1).isVisible Then
                With xCB
                    .Appearance = Appearance.Button
                    .Checked = True
                    .FlatStyle = FlatStyle.System
                    .Location = New Point(((xLow Mod 8) * 35) + 3, (xColumn * 25) + 2)
                    .Size = New Size(35, 25)
                    .Tag = MainWindow.niA1 + xI1
                    .Text = MainWindow.column(MainWindow.niA1 + xI1).Title
                    .TextAlign = ContentAlignment.MiddleCenter
                    .UseVisualStyleBackColor = True
                End With
                xLow += 1
                If xLow Mod 8 = 0 Then xColumn += 1
                Panel1.Controls.Add(xCB)
            End If
        Next
        If xLow Mod 8 <> 0 Then xColumn += 1

        xLow = 0
        For xI1 As Integer = 0 To 25
            Dim xCB As New CheckBox
            If MainWindow.column(MainWindow.niD1 + xI1).isVisible Then
                With xCB
                    .Appearance = Appearance.Button
                    .Checked = True
                    .FlatStyle = FlatStyle.System
                    .Location = New Point(((xLow Mod 8) * 35) + 3, (xColumn * 25) + 2)
                    .Size = New Size(35, 25)
                    .Tag = MainWindow.niD1 + xI1
                    .Text = MainWindow.column(MainWindow.niD1 + xI1).Title
                    .TextAlign = ContentAlignment.MiddleCenter
                    .UseVisualStyleBackColor = True
                End With
                xLow += 1
                If xLow Mod 8 = 0 Then xColumn += 1
                Panel1.Controls.Add(xCB)
            End If
        Next
        If xLow Mod 8 <> 0 Then xColumn += 1
        xLow = 0

        Panel1.Controls.Add(cb4)
        cb4.Location = New Point((0 * 55) + 3, (xColumn * 25) + 2)
        Panel1.Controls.Add(cb5)
        cb5.Location = New Point((1 * 55) + 3, (xColumn * 25) + 2)
        Panel1.Controls.Add(cb6)
        cb6.Location = New Point((2 * 55) + 3, (xColumn * 25) + 2)

        xColumn += 1
        For xI1 As Integer = 63 To bCol
            Dim xCB As New CheckBox
            With xCB
                .Appearance = Appearance.Button
                .Checked = True
                .FlatStyle = FlatStyle.System
                .Location = New Point(((xLow Mod 8) * 35) + 3, (xColumn * 25) + 2)
                .Size = New Size(35, 25)
                .Tag = xI1
                .Text = "B" & (xI1 - 62).ToString
                .TextAlign = ContentAlignment.MiddleCenter
                .UseVisualStyleBackColor = True
            End With
            xLow += 1
            If xLow Mod 8 = 0 Then xColumn += 1
            Panel1.Controls.Add(xCB)
        Next

        AddHandler lr1.KeyDown, AddressOf lblKeyDown
        AddHandler lr2.KeyDown, AddressOf lblKeyDown
        AddHandler Ttl.KeyDown, AddressOf lblKeyDown
    End Sub

    Private Function ValidLabel(ByVal xStr As String) As Boolean
        xStr = UCase(Trim(xStr))

        If Len(xStr) = 0 Then Return False
        If xStr = "00" Or xStr = "0" Then Return False
        If Not Len(xStr) = 1 And Not Len(xStr) = 2 Then Return False

        Dim xI3 As Integer = Asc(Mid(xStr, 1, 1))
        If Not ((xI3 >= 48 And xI3 <= 57) Or (xI3 >= 65 And xI3 <= 90)) Then Return False
        If Len(xStr) = 2 Then
            Dim xI4 As Integer = Asc(Mid(xStr, 2, 1))
            If Not ((xI4 >= 48 And xI4 <= 57) Or (xI4 >= 65 And xI4 <= 90)) Then Return False
        End If
        Return True
        Dim unused = MsgBox(msg2, MsgBoxStyle.Critical, msg1)
    End Function

    Private Sub lblKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not e.KeyCode = Keys.Enter Then Exit Sub
        Dim unused = ValidateLabel(sender)
    End Sub

    Private Function ValidateLabel(ByVal sender As Object) As Boolean
        Dim xBool As Boolean = ValidLabel(sender.Text)
        If Not xBool Then
            Dim unused2 = MsgBox(msg2, MsgBoxStyle.Critical, msg1)
            Dim unused1 = sender.Focus()
            Dim unused = sender.SelectAll()
        End If
        ValidateLabel = xBool
    End Function

    Private Sub TBSelect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBSelect.Click
        If Not ValidateLabel(lr1) Then Exit Sub
        If Not ValidateLabel(lr2) Then Exit Sub

        Dim xCol() As Integer = {}
        For Each xCB As CheckBox In Panel1.Controls
            If xCB.Checked Then
                ReDim Preserve xCol(UBound(xCol) + 1)
                xCol(UBound(xCol)) = xCB.Tag
            End If
        Next

        Dim xRange As Integer = 1
        If cbx1.Checked Then xRange *= 2
        If cbx2.Checked Then xRange *= 3
        If cbx3.Checked Then xRange *= 5
        If cbx4.Checked Then xRange *= 7
        If cbx5.Checked Then xRange *= 11
        If cbx6.Checked Then xRange *= 13

        MainWindow.fdrSelect(xRange, _
                        mr1.Value, mr2.Value, _
                        lr1.Text, lr2.Text, _
                        vr1.Value * 10000, vr2.Value * 10000, _
                        xCol)
    End Sub

    Private Sub TBUnselect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBUnselect.Click
        If Not ValidateLabel(lr1) Then Exit Sub
        If Not ValidateLabel(lr2) Then Exit Sub

        Dim xCol() As Integer = {}
        For Each xCB As CheckBox In Panel1.Controls
            If xCB.Checked Then
                ReDim Preserve xCol(UBound(xCol) + 1)
                xCol(UBound(xCol)) = xCB.Tag
            End If
        Next

        Dim xRange As Integer = 1
        If cbx1.Checked Then xRange *= 2
        If cbx2.Checked Then xRange *= 3
        If cbx3.Checked Then xRange *= 5
        If cbx4.Checked Then xRange *= 7
        If cbx5.Checked Then xRange *= 11
        If cbx6.Checked Then xRange *= 13

        MainWindow.fdrUnselect(xRange, _
                          mr1.Value, mr2.Value, _
                          lr1.Text, lr2.Text, _
                          vr1.Value * 10000, vr2.Value * 10000, _
                          xCol)
    End Sub

    Private Sub TBDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBDelete.Click
        If Not ValidateLabel(lr1) Then Exit Sub
        If Not ValidateLabel(lr2) Then Exit Sub

        Dim xCol() As Integer = {}
        For Each xCB As CheckBox In Panel1.Controls
            If xCB.Checked Then
                ReDim Preserve xCol(UBound(xCol) + 1)
                xCol(UBound(xCol)) = xCB.Tag
            End If
        Next

        Dim xRange As Integer = 1
        If cbx1.Checked Then xRange *= 2
        If cbx2.Checked Then xRange *= 3
        If cbx3.Checked Then xRange *= 5
        If cbx4.Checked Then xRange *= 7
        If cbx5.Checked Then xRange *= 11
        If cbx6.Checked Then xRange *= 13

        MainWindow.fdrDelete(xRange, _
                        mr1.Value, mr2.Value, _
                        lr1.Text, lr2.Text, _
                        vr1.Value * 10000, vr2.Value * 10000, _
                        xCol)
    End Sub

    Private Sub TBrl_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBrl.Click
        If Not ValidateLabel(lr1) Then Exit Sub
        If Not ValidateLabel(lr2) Then Exit Sub
        If Not ValidateLabel(Ttl) Then Exit Sub

        Dim xCol() As Integer = {}
        For Each xCB As CheckBox In Panel1.Controls
            If xCB.Checked Then
                ReDim Preserve xCol(UBound(xCol) + 1)
                xCol(UBound(xCol)) = xCB.Tag
            End If
        Next

        Dim xRange As Integer = 1
        If cbx1.Checked Then xRange *= 2
        If cbx2.Checked Then xRange *= 3
        If cbx3.Checked Then xRange *= 5
        If cbx4.Checked Then xRange *= 7
        If cbx5.Checked Then xRange *= 11
        If cbx6.Checked Then xRange *= 13

        MainWindow.fdrReplaceL(xRange, _
                          mr1.Value, mr2.Value, _
                          lr1.Text, lr2.Text, _
                          vr1.Value * 10000, vr2.Value * 10000, _
                          xCol, Ttl.Text)
    End Sub

    Private Sub TBrv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBrv.Click
        If Not ValidateLabel(lr1) Then Exit Sub
        If Not ValidateLabel(lr2) Then Exit Sub

        Dim xCol() As Integer = {}
        For Each xCB As CheckBox In Panel1.Controls
            If xCB.Checked Then
                ReDim Preserve xCol(UBound(xCol) + 1)
                xCol(UBound(xCol)) = xCB.Tag
            End If
        Next

        Dim xRange As Integer = 1
        If cbx1.Checked Then xRange *= 2
        If cbx2.Checked Then xRange *= 3
        If cbx3.Checked Then xRange *= 5
        If cbx4.Checked Then xRange *= 7
        If cbx5.Checked Then xRange *= 11
        If cbx6.Checked Then xRange *= 13

        MainWindow.fdrReplaceV(xRange, _
                          mr1.Value, mr2.Value, _
                          lr1.Text, lr2.Text, _
                          vr1.Value * 10000, vr2.Value * 10000, _
                          xCol, Ttv.Value * 10000)
    End Sub
End Class
