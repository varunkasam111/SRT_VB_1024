Public Class frmColors
    Dim curi As Integer = 1
    Dim changing As Boolean = False

    Private Sub lstColor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstColor1.GotFocus, lstColor2.GotFocus, lstColor3.GotFocus, lstColor4.GotFocus, lstColor5.GotFocus, lstColor6.GotFocus, lstColor7.GotFocus, lstColor8.GotFocus, lstColor9.GotFocus
        Dim lb As ListBox = sender
        lb.BackColor = Color.FromArgb(40, 40, 40)
    End Sub

    Private Sub lstColor_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstColor1.LostFocus, lstColor2.LostFocus, lstColor3.LostFocus, lstColor4.LostFocus, lstColor5.LostFocus, lstColor6.LostFocus, lstColor7.LostFocus, lstColor8.LostFocus, lstColor9.LostFocus
        Dim lb As ListBox = sender
        lb.BackColor = Color.Black
    End Sub
    Private Sub lstColor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstColor1.SelectedIndexChanged, lstColor2.SelectedIndexChanged, lstColor3.SelectedIndexChanged, lstColor4.SelectedIndexChanged, lstColor5.SelectedIndexChanged, lstColor6.SelectedIndexChanged, lstColor7.SelectedIndexChanged, lstColor8.SelectedIndexChanged, lstColor9.SelectedIndexChanged
        If changing Then Return
        Dim lst As ListBox = sender
        If TotNch > 5 Then
            If sender Is lstColor1 Then
                colourind(0) = lstColor1.SelectedIndex
                lblC1.BackColor = colourDef(colourind(0))
            ElseIf sender Is lstColor2 Then
                colourind(1) = lstColor2.SelectedIndex
                lblC2.BackColor = colourDef(colourind(1))
            ElseIf sender Is lstColor3 Then
                colourind(2) = lstColor3.SelectedIndex
                lblC3.BackColor = colourDef(colourind(2))
            ElseIf sender Is lstColor4 Then
                colourind(3) = lstColor4.SelectedIndex
                lblC4.BackColor = colourDef(colourind(3))
            ElseIf sender Is lstColor5 Then
                colourind(4) = lstColor5.SelectedIndex
                lblC5.BackColor = colourDef(colourind(4))
            ElseIf sender Is lstColor6 Then
                colourind(5) = lstColor6.SelectedIndex
                lblC6.BackColor = colourDef(colourind(5))
            ElseIf sender Is lstColor7 Then
                colourind(6) = lstColor7.SelectedIndex
                lblC7.BackColor = colourDef(colourind(6))
            ElseIf sender Is lstColor8 Then
                colourind(7) = lstColor8.SelectedIndex
                lblC8.BackColor = colourDef(colourind(7))
            ElseIf sender Is lstColor9 Then
                colourind(8) = lstColor9.SelectedIndex
                lblC9.BackColor = colourDef(colourind(8))
            End If
        Else
            changing = True
            Dim selind As Integer = lst.SelectedIndex
            lstColor1.SelectedIndex = selind
            lstColor2.SelectedIndex = selind
            lstColor3.SelectedIndex = selind
            lstColor4.SelectedIndex = selind
            lstColor5.SelectedIndex = selind
            lstColor6.SelectedIndex = selind
            lstColor7.SelectedIndex = selind
            lstColor8.SelectedIndex = selind
            lstColor9.SelectedIndex = selind

            colourind(0) = selind : colourind(1) = selind : colourind(2) = selind : colourind(3) = selind
            colourind(4) = selind : colourind(5) = selind : colourind(6) = selind : colourind(7) = selind : colourind(8) = selind
            lblC1.BackColor = colourDef(selind)
            lblC2.BackColor = colourDef(selind)
            lblC3.BackColor = colourDef(selind)
            lblC4.BackColor = colourDef(selind)
            lblC5.BackColor = colourDef(selind)
            lblC6.BackColor = colourDef(selind)
            lblC7.BackColor = colourDef(selind)
            lblC8.BackColor = colourDef(selind)
            lblC9.BackColor = colourDef(selind)
            changing = False
        End If
    End Sub

    Private Sub frmColors_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated

    End Sub

    Private Sub Form5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim k As Integer = e.KeyCode
        e.Handled = True
        Select Case k
            Case MKey1
                SetDefault()
            Case EsKey, MKey3
                Me.Close()
                Exit Sub
            Case MKey2, FkeySave
                colours(0) = colourDef(colourind(0))
                colours(1) = colourDef(colourind(1))
                colours(2) = colourDef(colourind(2))
                colours(3) = colourDef(colourind(3))
                colours(4) = colourDef(colourind(4))
                colours(5) = colourDef(colourind(5))
                colours(6) = colourDef(colourind(6))
                colours(7) = colourDef(colourind(7))
                colours(8) = colourDef(colourind(8))
                colours(9) = colourDef(colourind(9))
                colours(10) = colourDef(colourind(0))
                WriteiWConfig()
            Case FkeyLf
                If curi > 1 Then curi = curi - 1
                Setlst()
            Case FkeyRt
                If curi < 9 Then curi = curi + 1
                Setlst()
            Case FKeyUp
                Select Case curi
                    Case 1 : If lstColor1.SelectedIndex > 0 Then lstColor1.SelectedIndex -= 1
                    Case 2 : If lstColor2.SelectedIndex > 0 Then lstColor2.SelectedIndex -= 1
                    Case 3 : If lstColor3.SelectedIndex > 0 Then lstColor3.SelectedIndex -= 1
                    Case 4 : If lstColor4.SelectedIndex > 0 Then lstColor4.SelectedIndex -= 1
                    Case 5 : If lstColor5.SelectedIndex > 0 Then lstColor5.SelectedIndex -= 1
                    Case 6 : If lstColor6.SelectedIndex > 0 Then lstColor6.SelectedIndex -= 1
                    Case 7 : If lstColor7.SelectedIndex > 0 Then lstColor7.SelectedIndex -= 1
                    Case 8 : If lstColor8.SelectedIndex > 0 Then lstColor8.SelectedIndex -= 1
                    Case 9 : If lstColor9.SelectedIndex > 0 Then lstColor9.SelectedIndex -= 1
                End Select
            Case FKeyDn
                Select Case curi
                    Case 1 : If lstColor1.SelectedIndex < lstColor1.Items.Count - 1 Then lstColor1.SelectedIndex += 1
                    Case 2 : If lstColor2.SelectedIndex < lstColor2.Items.Count - 1 Then lstColor2.SelectedIndex += 1
                    Case 3 : If lstColor3.SelectedIndex < lstColor3.Items.Count - 1 Then lstColor3.SelectedIndex += 1
                    Case 4 : If lstColor4.SelectedIndex < lstColor4.Items.Count - 1 Then lstColor4.SelectedIndex += 1
                    Case 5 : If lstColor5.SelectedIndex < lstColor5.Items.Count - 1 Then lstColor5.SelectedIndex += 1
                    Case 6 : If lstColor6.SelectedIndex < lstColor6.Items.Count - 1 Then lstColor6.SelectedIndex += 1
                    Case 7 : If lstColor7.SelectedIndex < lstColor7.Items.Count - 1 Then lstColor7.SelectedIndex += 1
                    Case 8 : If lstColor8.SelectedIndex < lstColor8.Items.Count - 1 Then lstColor8.SelectedIndex += 1
                    Case 9 : If lstColor9.SelectedIndex < lstColor9.Items.Count - 1 Then lstColor9.SelectedIndex += 1
                End Select
        End Select
    End Sub
    Private Sub Setlst()
        Select Case curi
            Case 1 : lstColor1.Focus()
            Case 2 : lstColor2.Focus()
            Case 3 : lstColor3.Focus()
            Case 4 : lstColor4.Focus()
            Case 5 : lstColor5.Focus()
            Case 6 : lstColor6.Focus()
            Case 7 : lstColor7.Focus()
            Case 8 : lstColor8.Focus()
            Case 9 : lstColor9.Focus()
        End Select
    End Sub

    Private Sub frmColors_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Me.AutoScroll = False
            SetControls()
        Catch ex As Exception
            'MessageBox.Show(ex.ToString(), "frm5_Load()")
        End Try
    End Sub
    Private Sub SetControls()

        Me.Width = mewidth : Me.Height = meheight
        Application.DoEvents()
        Me.lblMenu1.Left = Me.Width - Me.lblMenu1.Width
        Me.lblMenu2.Left = Me.lblMenu1.Left
        Me.lblMenu3.Left = Me.lblMenu1.Left
        Me.lblMenu4.Left = Me.lblMenu1.Left
        Me.lblMenu5.Left = Me.lblMenu1.Left
        Me.lblMenu6.Left = Me.lblMenu1.Left
        Me.lblMenu7.Left = Me.lblMenu1.Left
        Me.lblMenu8.Left = Me.lblMenu1.Left
        Me.lblMenu9.Left = Me.lblMenu1.Left

        Me.lblMenu1.Top = lbl1top : Me.lblMenu1.Height = lbl1height
        Me.lblMenu2.Top = lbl2top : Me.lblMenu2.Height = lbl2height 'Removed Comment
        Me.lblMenu3.Top = lbl3top : Me.lblMenu3.Height = lbl3height
        Me.lblMenu4.Top = lbl4top : Me.lblMenu4.Height = lbl4height
        Me.lblMenu5.Top = lbl5top : Me.lblMenu5.Height = lbl5height
        Me.lblMenu6.Top = lbl6top : Me.lblMenu6.Height = lbl6height
        Me.lblMenu7.Top = lbl7top : Me.lblMenu7.Height = lbl7height
        Me.lblMenu8.Top = lbl8top : Me.lblMenu8.Height = lbl8height
        Me.lblMenu9.Top = lbl9top : Me.lblMenu9.Height = lbl9height
        OpenConfig2()
        lstColor1.SelectedIndex = colourind(0)
        lstColor2.SelectedIndex = colourind(1)
        lstColor3.SelectedIndex = colourind(2)
        lstColor4.SelectedIndex = colourind(3)
        lstColor5.SelectedIndex = colourind(4)
        lstColor6.SelectedIndex = colourind(5)
        lstColor7.SelectedIndex = colourind(6)
        lstColor8.SelectedIndex = colourind(7)
        lstColor9.SelectedIndex = colourind(8)
        Application.DoEvents()

        lstColor1.Focus()
    End Sub
    Private Sub SetDefault()
        'lstColor1.SelectedIndex = 0
        'lstColor2.SelectedIndex = 6
        'lstColor3.SelectedIndex = 6
        'lstColor4.SelectedIndex = 1
        'lstColor5.SelectedIndex = 1
        'lstColor6.SelectedIndex = 5
        'lstColor7.SelectedIndex = 5

        lstColor1.SelectedIndex = 0
        lstColor2.SelectedIndex = 6
        lstColor3.SelectedIndex = 3
        lstColor4.SelectedIndex = 4
        lstColor5.SelectedIndex = 1
        lstColor6.SelectedIndex = 5
        lstColor7.SelectedIndex = 2
        lstColor8.SelectedIndex = 7
        lstColor9.SelectedIndex = 8
    End Sub

    Private Sub frmColors_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        SetControls()
    End Sub
End Class