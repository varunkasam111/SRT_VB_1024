Imports System.IO
Imports System
Imports System.Windows
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Public Class frmCalib
    Dim bmp As Bitmap
    Dim bbmp As Bitmap
    Dim curi As Integer, curj As Integer, cinc As Integer
    Dim mnu As Integer
    Dim isstop As Boolean, isgrid As Boolean
    Dim incval As Single
    Dim upt As Integer, upt1 As Integer
    Dim upt2 As Integer, upt21 As Integer
    Dim pt0() As Point, pt1() As Point
    Dim sx As Single, sx1 As Single
    Dim v20() As Byte

    Private Sub frmCalib_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        bmp.Dispose()
        bbmp.Dispose()
        objGraphics.Dispose()
        objGraphicsB.Dispose()
        objGraphicsFrm.Dispose()
    End Sub
    Private Sub frmCalib_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim k As Integer
        k = e.KeyCode
        If (k >= 48 And k <= 57) Then e.Handled = False : Exit Sub
        e.Handled = True
        Select Case mnu
            Case 20
                Select Case k
                    Case MKey1
                        cnfnam = ListBox1.Items(ListBox1.SelectedIndex)
                        cnfnam = AppPath & "\" & cnfnam & ".cnf"
                        OpenConfig()
                        curi = 0 : curj = 0
                        SetTextBox()
                        DispGrid()
                        Application.DoEvents()
                    Case MKey2
                        SaveConfig()
                    Case MKey3
                        AddNewFileName()
                        cnfnam = ListBox1.Items(ListBox1.SelectedIndex)
                        cnfnam = AppPath & "\" & cnfnam & ".cnf"
                        SaveConfig()
                    Case MKey4
                        DelConfig()
                    Case MKey5
                        EditConfig()
                    Case MKey6
                        StoreVals()
                    Case MKey7
                        Me.Close()
                    Case EsKey
                        Me.Close()
                    Case FKey1
                        curj = curj - 1
                        SetTextBox()
                    Case FKey2
                        curj = curj + 1
                        SetTextBox()
                    Case FKeyUp
                        curi = curi - 1
                        SetTextBox()
                    Case FKeyDn
                        curi = curi + 1
                        SetTextBox()
                End Select
            Case 25
                DoEditMenu(k)
        End Select
    End Sub
    Private Sub AddNewFileName()
        Dim i As Integer = 0
        Dim j As Integer, k As Integer
        If ListBox1.Items.Count > 0 Then
            For j = 0 To ListBox1.Items.Count - 1
                k = CInt(ListBox1.Items(j).ToString)
                If k > i Then i = k
            Next j
        End If
        i = i + 1
        ListBox1.Items.Add(i.ToString)
        ListBox1.SelectedIndex = ListBox1.Items.Count - 1
    End Sub
    Private Sub ClearAllKeys()
        lblMenu1.BackColor = Color.Green
        lblMenu2.BackColor = Color.Green
        lblMenu3.BackColor = Color.Green
        lblMenu4.BackColor = Color.Green
        lblMenu5.BackColor = Color.Green
        lblMenu6.BackColor = Color.Green
        lblMenu7.BackColor = Color.Green
    End Sub
    Private Sub DoEditMenu(ByVal k As Integer)
        Select Case k
            Case MKey1
                If lblMenu1.Visible Then
                    ClearAllKeys()
                    incval = Val(lblMenu1.Text)
                    lblMenu1.BackColor = Color.Red
                End If
            Case MKey2
                If lblMenu2.Visible Then
                    ClearAllKeys()
                    incval = Val(lblMenu2.Text)
                    lblMenu2.BackColor = Color.Red
                End If
            Case MKey3
                If lblMenu3.Visible Then
                    ClearAllKeys()
                    incval = Val(lblMenu3.Text)
                    lblMenu3.BackColor = Color.Red
                End If
            Case MKey4
                If lblMenu4.Visible Then
                    ClearAllKeys()
                    incval = Val(lblMenu4.Text)
                    lblMenu4.BackColor = Color.Red
                End If
            Case MKey5
                If lblMenu5.Visible Then
                    ClearAllKeys()
                    incval = Val(lblMenu5.Text)
                    lblMenu5.BackColor = Color.Red
                End If
            Case MKey6
                If lblMenu6.Visible Then
                    ClearAllKeys()
                    incval = Val(lblMenu6.Text)
                    lblMenu6.BackColor = Color.Red
                End If
            Case MKey7
                If lblMenu7.Visible Then
                    ClearAllKeys()
                    incval = Val(lblMenu7.Text)
                    lblMenu7.BackColor = Color.Red
                End If
            Case EsKey
                isstop = True
            Case FKey1
                curj = curj - 1
                SetTextBox()
            Case FKey2
                curj = curj + 1
                SetTextBox()
            Case FKeyUp
                curi = curi - 1
                SetTextBox()
            Case FKeyDn
                curi = curi + 1
                SetTextBox()
            Case FKeyPlus
                cinc = 1
            Case FKeyMinus
                cinc = -1
        End Select
    End Sub
    Private Sub frmCalib_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mnu = 20
        SetVars()
        bmp = New Bitmap(Me.Width / 2, Me.Height / 2)
        bbmp = New Bitmap(Me.Width / 2, Me.Height / 2)
        objGraphics = Graphics.FromImage(bmp)
        objGraphics.Clear(Color.Black)
        objGraphicsB = Graphics.FromImage(bbmp)
        objGraphicsB.Clear(Color.FromArgb(10, 10, 10))
        objGraphicsFrm = Me.CreateGraphics

        Me.lblMenu1.Left = Me.Width - Me.lblMenu1.Width : Me.lblMenu1.Top = 8
        Me.lblMenu2.Left = Me.lblMenu1.Left : Me.lblMenu2.Top = Me.lblMenu1.Top + Me.lblMenu1.Height + 8
        Me.lblMenu3.Left = Me.lblMenu1.Left : Me.lblMenu3.Top = Me.lblMenu2.Top + Me.lblMenu2.Height + 8
        Me.lblMenu4.Left = Me.lblMenu1.Left : Me.lblMenu4.Top = Me.lblMenu3.Top + Me.lblMenu3.Height + 8
        Me.lblMenu5.Left = Me.lblMenu1.Left : Me.lblMenu5.Top = Me.lblMenu4.Top + Me.lblMenu4.Height + 8
        Me.lblMenu6.Left = Me.lblMenu1.Left : Me.lblMenu6.Top = Me.lblMenu5.Top + Me.lblMenu5.Height + 8
        Me.lblMenu7.Left = Me.lblMenu1.Left : Me.lblMenu7.Top = Me.lblMenu6.Top + Me.lblMenu6.Height + 8
        lblC1.Left = 0 : lblC2.Left = 0 : lblC3.Left = 0 : lblC4.Left = 0 : lblC5.Left = 0 : lblC6.Left = 0 : lblC7.Left = 0
        lblC1.Top = lblRange.Height + 8
        lblC2.Top = lblC1.Top + lblC1.Height + 2
        lblC3.Top = lblC2.Top + lblC2.Height + 2
        lblC4.Top = lblC3.Top + lblC3.Height + 2
        lblC5.Top = lblC4.Top + lblC4.Height + 2
        lblC6.Top = lblC5.Top + lblC5.Height + 2
        lblC7.Top = lblC6.Top + lblC6.Height + 2
        lblGain.Left = lblC1.Left + lblC1.Width + 4 : lblGain.Top = 0
        lblDelay.Left = lblGain.Left + lblGain.Width + 4 : lblDelay.Top = 0
        lblRange.Left = lblDelay.Left + lblDelay.Width + 4 : lblRange.Top = 0
        lblReject.Left = lblRange.Left + lblRange.Width + 4 : lblReject.Top = 0
        lblGateS.Left = lblReject.Left + lblReject.Width + 4 : lblGateS.Top = 0
        lblGateW.Left = lblGateS.Left + lblGateS.Width + 4 : lblGateW.Top = 0
        lblThresh.Left = lblGateW.Left + lblGateW.Width + 4 : lblThresh.Top = 0
        lblG2St.Left = lblThresh.Left + lblThresh.Width + 4 : lblG2St.Top = 0
        lblG2Wd.Left = lblG2St.Left + lblG2St.Width + 4 : lblG2Wd.Top = 0
        lblThr2.Left = lblG2Wd.Left + lblG2Wd.Width + 4 : lblThr2.Top = 0
        txtInput.Left = lblThr2.Left + lblThr2.Width + 4 : txtInput.Top = 0

        Panel1.Left = lblMenu1.Left - Panel1.Width : Panel1.Top = 0

        Dim farr As String() = Directory.GetFiles(AppPath, "*.cnf")
        ListBox1.Items.Clear()
        Dim i As Integer, l As Integer, j As Integer
        For i = 0 To farr.Length - 1
            l = Len(AppPath) + 2
            j = InStr(farr(i), ".")
            ListBox1.Items.Add(Mid$(farr(i), l, j - l))
        Next i
        curi = 0 : curj = 0
        ListBox1.SelectedIndex = cnfi
        cnfnam = ListBox1.Items(ListBox1.SelectedIndex)
        cnfnam = AppPath & "\" & cnfnam & ".cnf"
        OpenConfig()
        curi = 0 : curj = 0
        SetUpConfig()
        Me.Visible = True
        DispGrid()
        DispGrid()
    End Sub
    Public Sub SetUpConfig(Optional ByVal ci As Integer = -1, Optional ByVal cj As Integer = -1)
        SetMenu("Open", "Save", "SaveAs", "Delete", "Edit", "Store", "Exit")
        mnu = 20
        If ci = -1 Then
            curi = 0 : curj = 0
        Else
            curi = ci : curj = cj
        End If
        DispVals()
        SetTextBox()
    End Sub

    Public Sub StoreVals()
        Dim i As Integer
        Dim typ As Integer
        For i = 0 To TotNch
            typ = IIf(i = 0, 1, 2)
            DataArr(i, 0) = Val(DispArr(i, 0)) * 2.0
            DataArr(i, 1) = Rangeml(Val(DispArr(i, 1)), 1)
            DataArr(i, 2) = Rangeml(Val(DispArr(i, 2)), typ)
            DataArr(i, 3) = Val(DispArr(i, 3)) * 2.4
            DataArr(i, 4) = Rangeml(Val(DispArr(i, 4)), typ)
            DataArr(i, 5) = Rangeml(Val(DispArr(i, 5)), typ)
            DataArr(i, 6) = Val(DispArr(i, 6)) * 2.4
        Next i
    End Sub
    Public Sub DispGrid()
        Dim i As Integer, j As Integer, c0 As Integer, c1 As Integer
        Dim rect As Rectangle
        Dim attr As New Drawing.Imaging.ImageAttributes
        If mnu <> 20 Then Exit Sub
        c0 = 2 : c1 = 16
        attr.SetColorKey(Color.Black, Color.Black)
        rect = New Rectangle(0, Me.ClientRectangle.Height, Me.ClientRectangle.Width, -Me.ClientRectangle.Height)

        Dim sz As Drawing.SizeF
        objGraphics.Clear(Color.Black)
        sz = objGraphics.MeasureString("8", objfont)
        For i = 0 To DispArr.GetUpperBound(0)  'rows
            For j = 0 To DispArr.GetUpperBound(1)  ' columns
                objGraphics.DrawString(DispArr(i, j), objfont, objBrush2, c1 + j * 28, sz.Height * IIf(i <= TotNch, i + 1, 0))
            Next j
        Next i
        Dim x As Integer, y As Integer
        x = c1 + curj * 28 - 2
        y = sz.Height * (curi + 1) + 2
        lblTmp.Text = (curi.ToString & "," & curj.ToString & "," & x.ToString)
        '        objGraphics.DrawRectangle(objPens(0), 0, sz.Height * (curi + 1) + 2, 9, sz.Height)
        '        objGraphics.DrawRectangle(objPens(0), 0, y, 9, sz.Height)
        '       objGraphics.DrawRectangle(objPens(0), x, 2, 26, 12)
        If curj <= TotNpr Then
            objGraphics.DrawRectangle(objRedPen, x, y, 24, sz.Height - 2)
            txtInput.Text = DispArr(curi, curj)
            txtInput.SelectionStart = txtInput.Text.Length
        Else
            objGraphics.DrawRectangle(objBlackPen, x, y, 24, sz.Height - 2)
            txtInput.Text = ""
        End If
        objGraphicsFrm.Clear(Color.Black)
        objGraphicsFrm.DrawImage(bmp, rect, 0, bmp.Height, bmp.Width, -bmp.Height, GraphicsUnit.Pixel, attr)

        Application.DoEvents()
    End Sub
    'Private Sub SaveConfig(ByVal isnew As Boolean)
    '    Dim i As Integer, j As Integer, k As Integer
    '    Dim fnam As String
    '    StoreVals()
    '    If isnew Then
    '        i = 0
    '        If ListBox1.Items.Count > 0 Then
    '            For j = 0 To ListBox1.Items.Count - 1
    '                k = CInt(ListBox1.Items(j).ToString)
    '                If k > i Then i = k
    '            Next j
    '        End If
    '        i = i + 1
    '        ListBox1.Items.Add(i.ToString)
    '        ListBox1.SelectedIndex = ListBox1.Items.Count - 1
    '    End If
    '    Application.DoEvents()
    '    fnam = ListBox1.SelectedItem
    '    fnam = AppPath & "\" & fnam & ".cnf"
    '    Dim objBW As BinaryWriter
    '    Dim objFS As FileStream
    '    objFS = New FileStream(fnam, FileMode.OpenOrCreate, FileAccess.Write)
    '    objBW = New BinaryWriter(objFS)
    '    For i = 0 To DataArr.GetUpperBound(0)
    '        For j = 0 To DataArr.GetUpperBound(1)
    '            objBW.Write(DataArr(i, j))
    '        Next j
    '    Next i
    '    Me.Text = "Paras RT511 Configuration Set:" & ListBox1.SelectedItem
    '    objBW.Close()
    '    objFS.Close()
    '    fnam = AppPath & "\Config.txt"
    '    Dim objSW As StreamWriter
    '    Dim n As Integer
    '    objSW = New StreamWriter(fnam, False, System.Text.Encoding.ASCII)
    '    For i = 0 To DataArr.GetUpperBound(0)
    '        objSW.Write((i + 1).ToString)
    '        objSW.Write(",")
    '        n = DataArr.GetUpperBound(1)
    '        objSW.Write(DataArr(i, 1).ToString) : objSW.Write(",")
    '        objSW.Write(DataArr(i, 2).ToString) : objSW.Write(",")
    '        objSW.Write(DataArr(i, 3).ToString) : objSW.Write(",")
    '        objSW.Write(DataArr(i, 4).ToString) : objSW.Write(",")
    '        objSW.Write(DataArr(i, 5).ToString) : objSW.Write(",")
    '        objSW.Write(DataArr(i, 6).ToString) : objSW.Write(",")
    '        objSW.Write(DataArr(i, 7).ToString) : objSW.Write(",")
    '        objSW.Write(DataArr(i, 8).ToString) : objSW.Write(",")
    '        objSW.Write(DataArr(i, 9).ToString) : objSW.Write(vbLf)
    '    Next i
    '    objSW.Close()
    'End Sub
    Private Sub DelConfig()
        If File.Exists(AppPath & ListBox1.SelectedItem & ".cnf") Then
            File.Delete(AppPath & ListBox1.SelectedItem & ".cnf")
        End If
    End Sub
    Private Sub EditConfig()
        Dim ii As Integer, jj As Integer
        If curj > TotNpr Then Exit Sub
        objGraphicsFrm.Clear(Color.Black)
        mnu = 25
        isstop = False
        ii = curi : jj = curj
        Do While True
redo:
            Select Case curj
                Case 0                  'gain
                    SetMenu("0.5", "1.0", "2.0", "6.0", "10.0", "", "")
                Case 1                  'delay
                    SetMenu("1", "2", "5", "10", "20", "50", "100")
                Case 2                  'range
                    SetMenu("1", "2", "5", "10", "20", "50", "100")
                Case 3                  'reject
                    SetMenu("1", "2", "5", "10", "", "", "")
                Case 4                  'gatest
                    SetMenu("1", "2", "5", "10", "20", "50", "100")
                Case 5                  'gatewd
                    SetMenu("1", "2", "5", "10", "20", "50", "100")
                Case 6                  'thresh
                    SetMenu("1", "2", "5", "10", "", "", "")
                Case 7                  'gatest
                    SetMenu("1", "2", "5", "10", "20", "50", "100")
                Case 8                  'gatewd
                    SetMenu("1", "2", "5", "10", "20", "50", "100")
                Case 9                  'thresh
                    SetMenu("1", "2", "5", "10", "", "", "")
            End Select
            DoEditMenu(MKey1)
reacq:
            StoreVals()
            Acquire(curi, True)
            Dim v As Single
            Do While True
                Application.DoEvents()
                If cinc <> 0 Then
                    v = Val(DispArr(curi, curj)) + incval * cinc
                    If v < 0 Then v = 0
                    DispArr(curi, curj) = IIf(curj = 0, Format(v, "0.0"), Format(v, "0"))
                    cinc = 0
                    GoTo reacq
                End If
                If jj <> curj Or ii <> curi Then
                    ii = curi : jj = curj
                    StoreVals() : GoTo redo
                End If
                If isstop Then StoreVals() : GoTo getout
                Me.Text = "Paras RT511 Configuration Edit Ch: " & Format(ii + 1, "0") & " " & DataNam(jj) & ":" & Trim(DispArr(ii, jj)) & " | " & DataArr(ii, jj).ToString & " Inc:" & IIf(jj = 0, Format(incval, "0.0"), Format(incval, "0"))
            Loop
        Loop
getout:
        mnu = 20
        SetUpConfig(ii, jj)
    End Sub
    Private Sub SetPlot(ByVal j As Integer)
        Dim i As Integer
        Dim t As Single
        Dim g As Integer

        upt = IIf(j = 0, DataArr(0, 2), DataArr(1, 2))
        ReDim pt0(upt) : upt2 = 2 * upt
        sx = bmp.Width / upt
        For i = 0 To upt
            pt0(i).X = sx * i
        Next i
        ReDim v20(upt2)
        objGraphicsFrm.Clear(Color.Black)
        objGraphicsB.Clear(Color.FromArgb(10, 10, 10))
        For i = bbmp.Width / 10 To bbmp.Width Step bbmp.Width / 10
            objGraphicsB.DrawLine(objBackPen, i, 0, i, bbmp.Height)
            If j = 0 Then
                objGraphicsB.DrawString(Format(Rangemm(i / sx, 1), "0"), objfont, objBrush2, i, 10)
            Else
                objGraphicsB.DrawString(Format(Rangemm(i / sx, 2), "0"), objfont, objBrush3, i, 10)
            End If
        Next i
        For i = 0 To 9
            t = bbmp.Height - i * 24
            objGraphicsB.DrawLine(objBackPen, 0, t, bbmp.Width, t)
            objGraphicsB.DrawString(Format(i * 10, "0"), objfont, objBrush3, bbmp.Width - 10, t)
        Next i
        g = DataArr(j, 4)
        t = bbmp.Height - DataArr(j, 6)
        objGraphicsB.DrawLine(objPens(j), sx * g, t, sx * (g + DataArr(j, 5)), t)
    End Sub
    Private Sub Acquire(ByVal j As Integer, Optional ByVal shrt As Boolean = False, Optional ByVal rddata As Boolean = False)
        Dim i As Integer, i2 As Integer
        Dim k As Long
        Dim x As Byte
        Dim r As Byte
        Dim ii As Integer, jj As Integer

        ii = curi : jj = curj
        Dim vi As Integer

        isstop = False
        '        issave = False
        SetPlot(j)
        k = 0
        Do While True
            r = DataArr(j, 3)
            vi = DataArr(j, 1) + 4096 * j
            BLOCKREADINFO(0) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(1) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(2) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(3) = vi

            vi = upt2
            BLOCKREADINFO(4) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(5) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(6) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(7) = vi
            DeviceIoControl(hADRDriver, ADR_IOCTL_BLOCK_READ, BLOCKREADINFO, BLOCKREADINFO.GetUpperBound(0) + 1, BLOCKREADINFO, BLOCKREADINFO.GetUpperBound(0) + 1, 0, 0)
            For i = 0 To upt2 Step 2
                x = BLOCKREADINFO(8 + i)
                If x > r And x > v20(i) Then v20(i) = x
            Next i
            If (k Mod 10) = 0 Then
                PlotCurve(v20, curi, 12)
                Exit Do
                '                If issave Then Exit Do
                'If shrt And k > 2 Then Exit Do
                If ii <> curi Or jj <> curj Then Exit Sub
            End If
            k = k + 1
        Loop
        'If mnu = 25 Then
        '    Exit Sub     'SetUpConfig(ci, j)
        'ElseIf mnu = 12 Then
        '    If issave Then SaveData()
        '    TestSetup()
        '    Exit Sub
        'End If
    End Sub
    Private Sub PlotCurve(ByRef v() As Byte, ByVal j As Integer, ByVal minval As Byte)
        Dim r As Integer, nz As Integer
        Dim i As Integer, i2 As Integer
        Dim rect As Rectangle
        rect = New Rectangle(0, Me.ClientRectangle.Height, Me.ClientRectangle.Width, -Me.ClientRectangle.Height)
        Dim attr As New Drawing.Imaging.ImageAttributes

        objGraphics.DrawImage(bbmp, 0, 0)
        r = DataArr(j, 3)
        nz = bmp.Height
        pt0(0).Y = nz : pt0(upt).Y = nz
        '        v20(150) = 140 * Rnd()
        For i = 0 + 1 To upt - 1
            i2 = i * 2
            pt0(i).Y = nz - v20(i2)
            v(i2) = minval
        Next i
        objGraphics.DrawPolygon(objPens(j), pt0)
        objGraphics.DrawLine(objBackPen, pt0(0).X, nz, pt0(upt).X, nz)
        'objGraphicsFrm.DrawImage(bmp, 0, 0)
        objGraphicsFrm.DrawImage(bmp, rect, 0, bmp.Height, bmp.Width, -bmp.Height, GraphicsUnit.Pixel, attr)
        Application.DoEvents()

    End Sub
    Private Sub SetMenu(ByVal mnu1 As String, ByVal mnu2 As String, ByVal mnu3 As String, ByVal mnu4 As String, ByVal mnu5 As String, ByVal mnu6 As String, ByVal mnu7 As String)
        ClearAllKeys()
        If Trim(mnu1) <> "" Then lblMenu1.Text = mnu1 : lblMenu1.Visible = True Else lblMenu1.Visible = False
        If Trim(mnu2) <> "" Then lblMenu2.Text = mnu2 : lblMenu2.Visible = True Else lblMenu2.Visible = False
        If Trim(mnu3) <> "" Then lblMenu3.Text = mnu3 : lblMenu3.Visible = True Else lblMenu3.Visible = False
        If Trim(mnu4) <> "" Then lblMenu4.Text = mnu4 : lblMenu4.Visible = True Else lblMenu4.Visible = False
        If Trim(mnu5) <> "" Then lblMenu5.Text = mnu5 : lblMenu5.Visible = True Else lblMenu5.Visible = False
        If Trim(mnu6) <> "" Then lblMenu6.Text = mnu6 : lblMenu6.Visible = True Else lblMenu6.Visible = False
        If Trim(mnu7) <> "" Then lblMenu7.Text = mnu7 : lblMenu7.Visible = True Else lblMenu7.Visible = False
    End Sub

    Private Sub SetTextBox()
        Dim maxi As Integer
        ClearLbls()
        If curi < 0 Then curi = 0
        If curj < 0 Then curj = 0
        If curj > TotNpr Then
            curj = TotNpr + 1 : maxi = ListBox1.Items.Count - 1
        Else
            maxi = TotNch
        End If
        If curi > maxi Then curi = maxi
        If curj = TotNpr + 1 Then
            If Not ListBox1.Enabled Then
                curi = cnfi
                ListBox1.Enabled = True : ListBox1.SelectedIndex = curi
                Exit Sub
            Else
                ListBox1.SelectedIndex = curi
                Exit Sub
            End If
        Else
            ListBox1.Enabled = False
        End If
        Select Case curi
            Case 0 : lblC1.ForeColor = colours(8)
            Case 1 : lblC2.ForeColor = colours(8)
            Case 2 : lblC3.ForeColor = colours(8)
            Case 3 : lblC4.ForeColor = colours(8)
            Case 4 : lblC5.ForeColor = colours(8)
            Case 5 : lblC6.ForeColor = colours(8)
            Case 6 : lblC7.ForeColor = colours(8)
        End Select
        Select Case curj
            Case 0 : lblGain.ForeColor = colours(8)
            Case 1 : lblDelay.ForeColor = colours(8)
            Case 2 : lblRange.ForeColor = colours(8)
            Case 3 : lblReject.ForeColor = colours(8)
            Case 4 : lblGateS.ForeColor = colours(8)
            Case 5 : lblGateW.ForeColor = colours(8)
            Case 6 : lblThresh.ForeColor = colours(8)
            Case 7 : lblG2St.ForeColor = colours(8)
            Case 8 : lblG2Wd.ForeColor = colours(8)
            Case 9 : lblThr2.ForeColor = colours(8)
            Case 10 : lblCalSet.ForeColor = colours(8)
        End Select
        '        Me.Text = "channel: " & Format(curi + 1, "0") & " " & DataNam(curj) & ":" & Trim(DispArr(curi, curj)) & " Inc:" & IIf(curj = 0, Format(incval, "0.0"), Format(incval, "0"))
        DispGrid()

    End Sub
    Private Sub ClearLbls()
        lblC1.ForeColor = colours(7)
        lblC2.ForeColor = colours(7) : lblC3.ForeColor = colours(7) : lblC4.ForeColor = colours(7)
        lblC5.ForeColor = colours(7) : lblC6.ForeColor = colours(7) : lblC7.ForeColor = colours(7)
        lblGain.ForeColor = colours(7) : lblDelay.ForeColor = colours(7) : lblRange.ForeColor = colours(7)
        lblReject.ForeColor = colours(7) : lblGateS.ForeColor = colours(7) : lblGateW.ForeColor = colours(7)
        lblThresh.ForeColor = colours(7) : lblG2St.ForeColor = colours(7) : lblG2Wd.ForeColor = colours(7)
        lblThr2.ForeColor = colours(7)
        lblCalSet.ForeColor = colours(7)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub txtInput_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtInput.KeyDown
        '        Dim k As Integer, j As Integer
        '        k = e.KeyCode
        '       If (k > 57) Then e.Handled = True : Exit Sub
    End Sub

    Private Sub txtInput_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInput.KeyPress
        Dim k As Integer, j As Integer

        k = Asc(e.KeyChar)
        If (k > 57) Then e.Handled = True : Exit Sub
        If k = 13 Then
            j = InStr(txtInput.Text, vbCrLf)
            If j <> 0 Then
                DispArr(curi, curj) = Mid$(txtInput.Text, 1, j - 1)
            Else
                DispArr(curi, curj) = txtInput.Text
            End If
            DispGrid()
        End If
    End Sub
End Class