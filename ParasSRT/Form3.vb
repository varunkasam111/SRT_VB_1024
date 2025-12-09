Imports System.IO
Imports System
Imports System.Windows
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Drawing.Imaging

#Const BSCAN = 1
Imports Microsoft.VisualBasic


Public Class frmCalib
#Const TORA = 1
    Dim frmcap As String
    Public bmp As Bitmap
    Public bbmp As Bitmap
    Dim bmpview As Bitmap
    Public curi As Integer
    Dim curj As Integer, cinc As Integer
    Dim mnu As Integer
    Dim isstop As Boolean, isgrid As Boolean
    Dim isstopped As Boolean, lastkey As Integer
    Dim incval As Single
    Dim offset As Integer, npoints As Integer
    Dim upt As Integer, upt1 As Integer
    Dim upt2 As Integer, upt21 As Integer
    Dim pt0() As Point, pt1() As Point
    Dim sx As Single, sx1 As Single, sy As Single
    Dim v20() As Byte, v21() As Byte
    Dim tb As TextBox, lbC As Label, lbP As Label
    Dim angle As Integer

    'Controls Variables
    Dim txtGain1 As TextBox
    Dim txtGain2 As TextBox
    Dim txtGain3 As TextBox
    Dim txtGain4 As TextBox
    Dim txtGain5 As TextBox
    Dim txtGain6 As TextBox
    Dim txtGain7 As TextBox
    Dim txtGain8 As TextBox
    Dim txtGain9 As TextBox
    Dim txtGain10 As TextBox

    Dim txtDelay1 As TextBox
    Dim txtDelay2 As TextBox
    Dim txtDelay3 As TextBox
    Dim txtDelay4 As TextBox
    Dim txtDelay5 As TextBox
    Dim txtDelay6 As TextBox
    Dim txtDelay7 As TextBox
    Dim txtDelay8 As TextBox
    Dim txtDelay9 As TextBox
    Dim txtDelay10 As TextBox

    Dim txtRange1 As TextBox
    Dim txtRange2 As TextBox
    Dim txtRange3 As TextBox
    Dim txtRange4 As TextBox
    Dim txtRange5 As TextBox
    Dim txtRange6 As TextBox
    Dim txtRange7 As TextBox
    Dim txtRange8 As TextBox
    Dim txtRange9 As TextBox
    Dim txtRange10 As TextBox

    Dim txtReject1 As TextBox
    Dim txtReject2 As TextBox
    Dim txtReject3 As TextBox
    Dim txtReject4 As TextBox
    Dim txtReject5 As TextBox
    Dim txtReject6 As TextBox
    Dim txtReject7 As TextBox
    Dim txtReject8 As TextBox
    Dim txtReject9 As TextBox
    Dim txtReject10 As TextBox

    Dim txtGateS1 As TextBox
    Dim txtGateS2 As TextBox
    Dim txtGateS3 As TextBox
    Dim txtGateS4 As TextBox
    Dim txtGateS5 As TextBox
    Dim txtGateS6 As TextBox
    Dim txtGateS7 As TextBox
    Dim txtGateS8 As TextBox
    Dim txtGateS9 As TextBox
    Dim txtGateS10 As TextBox

    Dim txtGateW1 As TextBox
    Dim txtGateW2 As TextBox
    Dim txtGateW3 As TextBox
    Dim txtGateW4 As TextBox
    Dim txtGateW5 As TextBox
    Dim txtGateW6 As TextBox
    Dim txtGateW7 As TextBox
    Dim txtGateW8 As TextBox
    Dim txtGateW9 As TextBox
    Dim txtGateW10 As TextBox

    Dim txtThresh1 As TextBox
    Dim txtThresh2 As TextBox
    Dim txtThresh3 As TextBox
    Dim txtThresh4 As TextBox
    Dim txtThresh5 As TextBox
    Dim txtThresh6 As TextBox
    Dim txtThresh7 As TextBox
    Dim txtThresh8 As TextBox
    Dim txtThresh9 As TextBox
    Dim txtThresh10 As TextBox

    Dim txtG2St1 As TextBox
    Dim txtG2St2 As TextBox
    Dim txtG2St3 As TextBox
    Dim txtG2St4 As TextBox
    Dim txtG2St5 As TextBox
    Dim txtG2St6 As TextBox
    Dim txtG2St7 As TextBox
    Dim txtG2St8 As TextBox
    Dim txtG2St9 As TextBox
    Dim txtG2St10 As TextBox

    Dim txtG2Wd1 As TextBox
    Dim txtG2Wd2 As TextBox
    Dim txtG2Wd3 As TextBox
    Dim txtG2Wd4 As TextBox
    Dim txtG2Wd5 As TextBox
    Dim txtG2Wd6 As TextBox
    Dim txtG2Wd7 As TextBox
    Dim txtG2Wd8 As TextBox
    Dim txtG2Wd9 As TextBox
    Dim txtG2Wd10 As TextBox

    Dim txtThr21 As TextBox
    Dim txtThr22 As TextBox
    Dim txtThr23 As TextBox
    Dim txtThr24 As TextBox
    Dim txtThr25 As TextBox
    Dim txtThr26 As TextBox
    Dim txtThr27 As TextBox
    Dim txtThr28 As TextBox
    Dim txtThr29 As TextBox
    Dim txtThr210 As TextBox

    Dim txtGain11 As TextBox
    Dim txtGain12 As TextBox
    Dim txtGain13 As TextBox
    Dim txtGain14 As TextBox
    Dim txtGain15 As TextBox
    Dim txtGain16 As TextBox
    Dim txtGain17 As TextBox
    Dim txtGain18 As TextBox
    Dim txtGain19 As TextBox
    Dim txtGain20 As TextBox

    Dim txtDelay11 As TextBox
    Dim txtDelay12 As TextBox
    Dim txtDelay13 As TextBox
    Dim txtDelay14 As TextBox
    Dim txtDelay15 As TextBox
    Dim txtDelay16 As TextBox
    Dim txtDelay17 As TextBox
    Dim txtDelay18 As TextBox
    Dim txtDelay19 As TextBox
    Dim txtDelay20 As TextBox

    Dim txtRange11 As TextBox
    Dim txtRange12 As TextBox
    Dim txtRange13 As TextBox
    Dim txtRange14 As TextBox
    Dim txtRange15 As TextBox
    Dim txtRange16 As TextBox
    Dim txtRange17 As TextBox
    Dim txtRange18 As TextBox
    Dim txtRange19 As TextBox
    Dim txtRange20 As TextBox

    Dim txtReject11 As TextBox
    Dim txtReject12 As TextBox
    Dim txtReject13 As TextBox
    Dim txtReject14 As TextBox
    Dim txtReject15 As TextBox
    Dim txtReject16 As TextBox
    Dim txtReject17 As TextBox
    Dim txtReject18 As TextBox
    Dim txtReject19 As TextBox
    Dim txtReject20 As TextBox

    Dim txtGateS11 As TextBox
    Dim txtGateS12 As TextBox
    Dim txtGateS13 As TextBox
    Dim txtGateS14 As TextBox
    Dim txtGateS15 As TextBox
    Dim txtGateS16 As TextBox
    Dim txtGateS17 As TextBox
    Dim txtGateS18 As TextBox
    Dim txtGateS19 As TextBox
    Dim txtGateS20 As TextBox

    Dim txtGateW11 As TextBox
    Dim txtGateW12 As TextBox
    Dim txtGateW13 As TextBox
    Dim txtGateW14 As TextBox
    Dim txtGateW15 As TextBox
    Dim txtGateW16 As TextBox
    Dim txtGateW17 As TextBox
    Dim txtGateW18 As TextBox
    Dim txtGateW19 As TextBox
    Dim txtGateW20 As TextBox

    Dim txtThresh11 As TextBox
    Dim txtThresh12 As TextBox
    Dim txtThresh13 As TextBox
    Dim txtThresh14 As TextBox
    Dim txtThresh15 As TextBox
    Dim txtThresh16 As TextBox
    Dim txtThresh17 As TextBox
    Dim txtThresh18 As TextBox
    Dim txtThresh19 As TextBox
    Dim txtThresh20 As TextBox

    Dim txtG2St11 As TextBox
    Dim txtG2St12 As TextBox
    Dim txtG2St13 As TextBox
    Dim txtG2St14 As TextBox
    Dim txtG2St15 As TextBox
    Dim txtG2St16 As TextBox
    Dim txtG2St17 As TextBox
    Dim txtG2St18 As TextBox
    Dim txtG2St19 As TextBox
    Dim txtG2St20 As TextBox

    Dim txtG2Wd11 As TextBox
    Dim txtG2Wd12 As TextBox
    Dim txtG2Wd13 As TextBox
    Dim txtG2Wd14 As TextBox
    Dim txtG2Wd15 As TextBox
    Dim txtG2Wd16 As TextBox
    Dim txtG2Wd17 As TextBox
    Dim txtG2Wd18 As TextBox
    Dim txtG2Wd19 As TextBox
    Dim txtG2Wd20 As TextBox

    Dim txtThr211 As TextBox
    Dim txtThr212 As TextBox
    Dim txtThr213 As TextBox
    Dim txtThr214 As TextBox
    Dim txtThr215 As TextBox
    Dim txtThr216 As TextBox
    Dim txtThr217 As TextBox
    Dim txtThr218 As TextBox
    Dim txtThr219 As TextBox
    Dim txtThr220 As TextBox


    Dim txtAng1 As TextBox
    Dim txtAng2 As TextBox
    Dim txtAng3 As TextBox
    Dim txtAng4 As TextBox
    Dim txtAng5 As TextBox
    Dim txtAng6 As TextBox
    Dim txtAng7 As TextBox
    Dim txtAng8 As TextBox
    Dim txtAng9 As TextBox
    Dim txtAng10 As TextBox

    Dim txtAng11 As TextBox
    Dim txtAng12 As TextBox
    Dim txtAng13 As TextBox
    Dim txtAng14 As TextBox
    Dim txtAng15 As TextBox
    Dim txtAng16 As TextBox
    Dim txtAng17 As TextBox
    Dim txtAng18 As TextBox
    Dim txtAng19 As TextBox
    Dim txtAng20 As TextBox

    Public lblC11 As Label
    Public lblC12 As Label
    Public lblC13 As Label
    Public lblC14 As Label
    Public lblC15 As Label
    Public lblC16 As Label
    Public lblC17 As Label
    Public lblC18 As Label
    Public lblC19 As Label
    Public lblC20 As Label

    Dim isloaded As Boolean
    Dim isValidIn As Boolean
    Dim isRefresh As Boolean

    Dim maxcount As Integer = 99, maxgain As Integer = 80, maxdelay As Integer = 225, maxrange As Integer = 600, maxreject As Integer = 99, maxangle As Integer = 90, maxthreshold As Integer = 99, maxGate As Integer = 99

    Public Sub frmCalib_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        bmp.Dispose()
        bbmp.Dispose()
        objGraphics.Dispose()
        objGraphicsB.Dispose()
        objGraphicsFrm.Dispose()
    End Sub

    Private Sub AddNewFileName()
        Dim i As Integer = 1
        Dim j As Integer, k As Integer
        If ListBox1.Items.Count > 0 Then
            For j = 0 To ListBox1.Items.Count - 1
                k = CInt(ListBox1.Items(j).ToString)
                If k > i Then
                    Exit For
                Else
                    i += 1
                End If
                If i = 10 Then
                    Exit For
                End If
            Next j
            ListBox1.Items.Add(i.ToString)
            ListBox1.SelectedIndex = ListBox1.Items.Count - 1
        End If
    End Sub

    Private Sub ClearAllKeys()
        lblMenu1.BackColor = Color.Green
        lblMenu2.BackColor = Color.Green
        lblMenu3.BackColor = Color.Green
        lblMenu4.BackColor = Color.Green
        lblMenu5.BackColor = Color.Green
        lblMenu6.BackColor = Color.Green
        lblMenu7.BackColor = Color.Green
        lblMenu8.BackColor = Color.Green
    End Sub

    Private Sub SavePRV(Optional ByVal isv As Integer = 0)
        Try
            Dim i As Integer
            Dim objBW As BinaryWriter
            Dim objFS As FileStream
            Dim v As String = StorageCard & Format(Now, "yyMMddhhmmss_") & Format(curi + 1, "00")
            Select Case isv
                Case 0 : v = v & ".prv"
                Case 1 : v = v & ".prw"
                Case 2 : v = v & ".prc"
                Case 3 : v = v & ".prh"
                Case 14 : v = v & ".prs"
            End Select
            If File.Exists(v) Then File.Delete(v)
            objFS = New FileStream(v, FileMode.Create, FileAccess.Write)
            objBW = New BinaryWriter(objFS)
            If isv = 14 Then
                For i = 0 To BLOCKREADINFO.Length - 1
                    objBW.Write(BLOCKREADINFO(i))
                Next
            Else
                For i = 0 To pt0.GetUpperBound(0)
                    objBW.Write(i)
                    objBW.Write(pt0(i).Y)
                Next i
            End If

            objBW.Close()
            objFS.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DoEditMenu(ByVal k As Integer)
        Dim v As Single
        Select Case caltyp
            Case 1
                If k = EsKey Then
                    lblPH.Visible = False
                    caltyp = 0
                    isstop = True
                    Me.Close()
                    Exit Sub
                End If

                If k = FKeySave Then
                    Dim fnm As String = Mid(datafile, 1, Len(datafile) - 3) & "jpg" '"bmp"
                    If File.Exists(fnm) Then File.Delete(fnm)
                    bmp.Save(fnm, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Me.Text = Me.Text & " - Saved"
                    Exit Sub
                End If
                Select Case k
                    Case FKeyUp
                        curi = curi - 1
                        SetTextBox()
                        SetLabels()
                    Case FKeyDn
                        curi = curi + 1
                        SetTextBox()
                        SetLabels()
                    Case FKeyLR
                        If curi <= 9 Then
                            curi = curi + 10
                        Else
                            curi = curi - 10
                        End If
                        SetTextBox()
                        SetLabels()
                    Case Else
                        Select Case k
                            Case MKey1 : If curi <= 9 Then curi = 0 Else curi = 9
                            Case MKey2 : If curi <= 9 Then curi = 1 Else curi = 10
                            Case MKey3 : If curi <= 9 Then curi = 2 Else curi = 11
                            Case MKey4 : If curi <= 9 Then curi = 3 Else curi = 12
                            Case MKey5 : If curi <= 9 Then curi = 4 Else curi = 13
                            Case MKey6 : If curi <= 9 Then curi = 5 Else curi = 14
                            Case MKey7 : If curi <= 9 Then curi = 6 Else curi = 15
                            Case MKey8 : If curi <= 9 Then curi = 7 Else curi = 16
                            Case MKey9 : If curi <= 9 Then curi = 8 Else curi = 17
                        End Select
                        SetTextBox()
                        SetLabels()
                End Select
                Acquire(curi)
            Case 3, 5, 13, 15
                If k = EsKey Then
                    lblPH.Visible = False
                    caltyp = 0
                    isstop = True

                    Me.Close()
                    keyprocessing = False
                    Exit Sub

                End If

                If k = FKeySave Then
                End If
            Case 2                      'PRV Freeze
                fngain10db(curi)
                If isstopped Then
                    If k = FKeyRun Then
                        isRefresh = False
                        isstop = False
                        keyprocessing = False
                        Acquire(curi)
                        Exit Sub
                    End If
                Else
                    isstop = True
                    If k <> FKeyRun Then
                        lastkey = k
                        Timer1.Enabled = True
                        keyprocessing = False
                    End If
                    Exit Sub
                End If
                Select Case k
                    Case FKeyUp
                        isRefresh = False
                        curi = curi - 1
                        SetTextBox()
                        SetLabels()
                    Case FKeyDn
                        isRefresh = False
                        curi = curi + 1
                        SetTextBox()
                        SetLabels()
                    Case FKeySave
                        SavePRV()
                        frmTest.Panel1.Visible = True
                        caltyp = 0
                        Me.Close()
                        frm3StopProcessing = True
                        Exit Sub

                    Case EsKey
                        lblPH.Visible = False
                        Timer1.Enabled = False
                        mnu = 20
                        caltyp = 0
                        Me.Close()
                        frm3StopProcessing = True
                        Exit Sub

                    Case FKeyLR
                        If curi <= 9 Then
                            curi = curi + 10
                        Else
                            curi = curi - 10
                        End If
                        SetTextBox()
                        SetLabels()
                    Case Else
                        SetTextBox()
                        SetLabels()
                End Select
            Case 4
                If isstopped Then
                    If k = FKeyRun Then

                        isstop = False
                        keyprocessing = False
                        Acquire(curi)
                        Exit Sub
                    End If
                Else
                    isstop = True
                    If k <> FKeyRun Then
                        lastkey = k
                        Timer1.Enabled = True
                        keyprocessing = False
                    End If
                    Exit Sub
                End If
                Select Case k
                    Case FKeyUp
                        curi = curi - 1
                        SetTextBox()
                        SetLabels()
                    Case FKeyDn
                        curi = curi + 1
                        SetTextBox()
                        SetLabels()
                    Case FKeyLR                         'FKeyLR = "save" in weld test
                        glbi = curi
                        SavePRV(1)
                        frmTest.Panel1.Visible = True
                        lblPH.Visible = False
                        mnu = 20
                        Timer1.Enabled = False
                        Me.Close()
                    Case EsKey
                        lblPH.Visible = False
                        Timer1.Enabled = False
                        mnu = 20
                        Me.Close()

                    Case FKeyMinus
                        glbi = curi
                        oldtyp = caltyp
                        caltyp = 6
                        isstop = False
                        frmCalib_Load()
                End Select
            Case 6
                If Not isstopped Then
                    isstop = True
                    If k <> FKeyRun Then
                        lastkey = k
                        Timer1.Enabled = True
                    End If
                    Return
                End If
                If k = FKeyRun Then

                    isstop = False
                    keyprocessing = False
                    Acquire(curi)
                    Return
                Else
                    Select Case k
                        Case FKeyUp
                            curi = curi - 1
                            SetTextBox()
                            SetLabels()
                        Case FKeyDn
                            curi = curi + 1
                            SetTextBox()
                            SetLabels()
                        Case FKeyMinus
                            Dim st() As String = lblPH.Tag.ToString.Split(",")
                            lblPH.Tag = (CInt(st(0)) - 2 * CInt(st(1))).ToString & "," & st(1)
                        Case FkeyLf
                            Dim st() As String = lblPH.Tag.ToString.Split(",")
                            Dim ss = (CInt(st(0)) - CInt(st(1))).ToString & "," & st(1)
                            lblPH.Tag = ss
                        Case FkeyRt
                            Dim st() As String = lblPH.Tag.ToString.Split(",")
                            Dim ss = (CInt(st(0)) + CInt(st(1))).ToString & "," & st(1)
                            lblPH.Tag = ss
                        Case FKeyPlus
                            Dim st() As String = lblPH.Tag.ToString.Split(",")
                            Dim ss = (CInt(st(0)) + 2 * CInt(st(1))).ToString & "," & st(1)
                            lblPH.Tag = ss
                        Case MKey1
                            If subrange1 < 40 Then subrange1 += 10
                            If subrange2 > 60 Then subrange2 -= 10
                        Case MKey2
                            If subrange1 > 0 Then subrange1 -= 10
                            If subrange2 < 100 Then subrange2 += 10
                        Case MKey3
                            If subrange1 > 0 Then
                                subrange1 -= 10
                                subrange2 -= 10
                            End If
                        Case MKey4
                            If subrange2 < 100 Then
                                subrange1 += 10
                                subrange2 += 10
                            End If
                        Case EsKey
                            lblPH.Visible = False
                            If TotNch < 6 Then
                                glbi = curi
                                If oldtyp <> 0 Then
                                    caltyp = oldtyp
                                    frmCalib_Load()
                                Else
                                    Timer1.Enabled = False
                                    mnu = 20
                                    caltyp = 0
                                    Me.Close()

                                End If
                            End If
                    End Select
                End If
            Case 0
                If isstopped Then
                    If k = FKeyRun Then
                        isstop = False
                        keyprocessing = False
                        Acquire(curi)
                        Exit Sub
                    End If
                Else
                    isstop = True
                    If k <> FKeyRun Then
                        lastkey = k
                        Timer1.Enabled = True
                        keyprocessing = False
                    End If
                    Exit Sub
                End If
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
                    Case MKey8 'Key implemented for Save JPG calib mode
                        If lblMenu8.Visible Then
                            ClearAllKeys()
                            lblMenu8.BackColor = Color.Red
                            fnSaveCalibJPG()
                        End If
                    Case FKeySave 'SaveKey implemented for Save JPG calib mode
                        If lblMenu8.Visible Then
                            ClearAllKeys()
                            lblMenu8.BackColor = Color.Red
                            fnSaveCalibJPG()
                        End If
                    Case EsKey
                        lblPH.Visible = False
                        isstopped = True
                        Timer1.Enabled = False
                        mnu = 20
                        SetUpConfig(curi, curj)
                    Case FkeyLf
                        curj = curj - 1
                        StoreVals()
                        SetTextBox()
                        EditConfig()
                    Case FkeyRt
                        curj = curj + 1
                        StoreVals()
                        SetTextBox()
                        EditConfig()
                    Case FKeyUp
                        curi = curi - 1
                        StoreVals()
                        SetTextBox()
                        SetLabels()
                    Case FKeyDn
                        curi = curi + 1
                        SetTextBox()
                        StoreVals()
                        SetLabels()
                    Case FKeyLR
                        If curi <= 9 Then
                            curi = curi + 10
                        Else
                            curi = curi - 10
                        End If
                        SetTextBox()
                    Case FKeyPlus
                        v = Val(tb.Text) + incval
                        tb.Text = IIf(curj = 0 Or curj = 10, Format(v, "0.0"), Format(v, "0"))
                        Me.lblInput.Text = tb.Text
                        StoreVals()
                        If curj = 0 Then
                            SaveGain()
                        End If

                        'reject
                        If txtReject1.Text > maxcount Then
                            tb.Text = maxcount
                        ElseIf txtReject2.Text > maxcount Then
                            tb.Text = maxcount
                        ElseIf txtReject3.Text > maxcount Then
                            tb.Text = maxcount
                        ElseIf txtReject4.Text > maxcount Then
                            tb.Text = maxcount
                        ElseIf txtReject5.Text > maxcount Then
                            tb.Text = maxcount
                        ElseIf txtReject6.Text > maxcount Then
                            tb.Text = maxcount
                        ElseIf txtReject7.Text > maxcount Then
                            tb.Text = maxcount
                        ElseIf txtReject8.Text > maxcount Then
                            tb.Text = maxcount
                        ElseIf txtReject9.Text > maxcount Then
                            tb.Text = maxcount
                        ElseIf txtReject10.Text > maxcount Then
                            tb.Text = maxcount
                        End If
                        If TotNch > 9 Then
                            If txtReject11.Text > maxcount Then
                                tb.Text = maxcount
                            ElseIf txtReject12.Text > maxcount Then
                                tb.Text = maxcount
                            ElseIf txtReject13.Text > maxcount Then
                                tb.Text = maxcount
                            ElseIf txtReject14.Text > maxcount Then
                                tb.Text = maxcount
                            ElseIf txtReject15.Text > maxcount Then
                                tb.Text = maxcount
                            ElseIf txtReject16.Text > maxcount Then
                                tb.Text = maxcount
                            ElseIf txtReject17.Text > maxcount Then
                                tb.Text = maxcount
                            End If
                        End If


                        'angle
                        If txtAng1.Text > maxangle Then
                            tb.Text = maxangle
                        ElseIf txtAng2.Text > maxangle Then
                            tb.Text = maxangle
                        ElseIf txtAng3.Text > maxangle Then
                            tb.Text = maxangle
                        ElseIf txtAng4.Text > maxangle Then
                            tb.Text = maxangle
                        ElseIf txtAng5.Text > maxangle Then
                            tb.Text = maxangle
                        ElseIf txtAng6.Text > maxangle Then
                            tb.Text = maxangle
                        ElseIf txtAng7.Text > maxangle Then
                            tb.Text = maxangle
                        ElseIf txtAng8.Text > maxangle Then
                            tb.Text = maxangle
                        ElseIf txtAng9.Text > maxangle Then
                            tb.Text = maxangle
                        ElseIf txtAng10.Text > maxangle Then
                            tb.Text = maxangle
                        End If

                        If TotNch > 9 Then
                            If txtAng11.Text > maxangle Then
                                tb.Text = maxangle
                            ElseIf txtAng12.Text > maxangle Then
                                tb.Text = maxangle
                            ElseIf txtAng13.Text > maxangle Then
                                tb.Text = maxangle
                            ElseIf txtAng14.Text > maxangle Then
                                tb.Text = maxangle
                            ElseIf txtAng15.Text > maxangle Then
                                tb.Text = maxangle
                            ElseIf txtAng16.Text > maxangle Then
                                tb.Text = maxangle
                            ElseIf txtAng17.Text > maxangle Then
                                tb.Text = maxangle
                            End If
                        End If

                        'gain
                        If txtGain1.Text > maxgain Then
                            tb.Text = maxgain
                        ElseIf txtGain2.Text > maxgain Then
                            tb.Text = maxgain
                        ElseIf txtGain3.Text > maxgain Then
                            tb.Text = maxgain
                        ElseIf txtGain4.Text > maxgain Then
                            tb.Text = maxgain
                        ElseIf txtGain5.Text > maxgain Then
                            tb.Text = maxgain
                        ElseIf txtGain6.Text > maxgain Then
                            tb.Text = maxgain
                        ElseIf txtGain7.Text > maxgain Then
                            tb.Text = maxgain
                        ElseIf txtGain8.Text > maxgain Then
                            tb.Text = maxgain
                        ElseIf txtGain9.Text > maxgain Then
                            tb.Text = maxgain
                        ElseIf txtGain10.Text > maxgain Then
                            tb.Text = maxgain
                        End If

                        If TotNch > 9 Then
                            If txtGain11.Text > maxgain Then
                                tb.Text = maxgain
                            ElseIf txtGain12.Text > maxgain Then
                                tb.Text = maxgain
                            ElseIf txtGain13.Text > maxgain Then
                                tb.Text = maxgain
                            ElseIf txtGain14.Text > maxgain Then
                                tb.Text = maxgain
                            ElseIf txtGain15.Text > maxgain Then
                                tb.Text = maxgain
                            ElseIf txtGain16.Text > maxgain Then
                                tb.Text = maxgain
                            ElseIf txtGain17.Text > maxgain Then
                                tb.Text = maxgain
                            End If
                        End If

                        'Gate 1 End
                        If txtGateW1.Text > maxGate Then
                            txtGateW1.Text = maxGate
                        ElseIf txtGateW2.Text > maxGate Then
                            txtGateW2.Text = maxGate
                        ElseIf txtGateW3.Text > maxGate Then
                            txtGateW3.Text = maxGate
                        ElseIf txtGateW4.Text > maxGate Then
                            txtGateW4.Text = maxGate
                        ElseIf txtGateW5.Text > maxGate Then
                            txtGateW5.Text = maxGate
                        ElseIf txtGateW6.Text > maxGate Then
                            txtGateW6.Text = maxGate
                        ElseIf txtGateW7.Text > maxGate Then
                            txtGateW7.Text = maxGate
                        ElseIf txtGateW8.Text > maxGate Then
                            txtGateW8.Text = maxGate
                        ElseIf txtGateW9.Text > maxGate Then
                            txtGateW9.Text = maxGate
                        ElseIf txtGateW10.Text > maxGate Then
                            txtGateW10.Text = maxGate
                        End If


                        'Gate 1 Start
                        If txtGateS1.Text > maxGate Then
                            txtGateS1.Text = maxGate
                        ElseIf txtGateS2.Text > maxGate Then
                            txtGateS2.Text = maxGate
                        ElseIf txtGateS3.Text > maxGate Then
                            txtGateS3.Text = maxGate
                        ElseIf txtGateS4.Text > maxGate Then
                            txtGateS4.Text = maxGate
                        ElseIf txtGateS5.Text > maxGate Then
                            txtGateS5.Text = maxGate
                        ElseIf txtGateS6.Text > maxGate Then
                            txtGateS6.Text = maxGate
                        ElseIf txtGateS7.Text > maxGate Then
                            txtGateS7.Text = maxGate
                        ElseIf txtGateS8.Text > maxGate Then
                            txtGateS8.Text = maxGate
                        ElseIf txtGateS9.Text > maxGate Then
                            txtGateS9.Text = maxGate
                        ElseIf txtGateS10.Text > maxGate Then
                            txtGateS10.Text = maxGate
                        End If

                        'Gate 2 end
                        If txtG2Wd1.Text > maxGate Then
                            txtG2Wd1.Text = maxGate
                        ElseIf txtG2Wd2.Text > maxGate Then
                            txtG2Wd2.Text = maxGate
                        ElseIf txtG2Wd3.Text > maxGate Then
                            txtG2Wd3.Text = maxGate
                        ElseIf txtG2Wd4.Text > maxGate Then
                            txtG2Wd4.Text = maxGate
                        ElseIf txtG2Wd5.Text > maxGate Then
                            txtG2Wd5.Text = maxGate
                        ElseIf txtG2Wd6.Text > maxGate Then
                            txtG2Wd6.Text = maxGate
                        ElseIf txtG2Wd7.Text > maxGate Then
                            txtG2Wd7.Text = maxGate
                        ElseIf txtG2Wd8.Text > maxGate Then
                            txtG2Wd8.Text = maxGate
                        ElseIf txtG2Wd9.Text > maxGate Then
                            txtG2Wd9.Text = maxGate
                        ElseIf txtG2Wd10.Text > maxGate Then
                            txtG2Wd10.Text = maxGate
                        End If


                        'Gate 2 Start
                        If txtG2St1.Text > maxGate Then
                            txtG2St1.Text = maxGate
                        ElseIf txtG2St2.Text > maxGate Then
                            txtG2St2.Text = maxGate
                        ElseIf txtG2St3.Text > maxGate Then
                            txtG2St3.Text = maxGate
                        ElseIf txtG2St4.Text > maxGate Then
                            txtG2St4.Text = maxGate
                        ElseIf txtG2St5.Text > maxGate Then
                            txtG2St5.Text = maxGate
                        ElseIf txtG2St6.Text > maxGate Then
                            txtG2St6.Text = maxGate
                        ElseIf txtG2St7.Text > maxGate Then
                            txtG2St7.Text = maxGate
                        ElseIf txtG2St8.Text > maxGate Then
                            txtG2St8.Text = maxGate
                        ElseIf txtG2St9.Text > maxGate Then
                            txtG2St9.Text = maxGate
                        ElseIf txtG2St10.Text > maxGate Then
                            txtG2St10.Text = maxGate
                        End If

                        'max G1ST
                        If txtGateS1.Text > maxGate Then
                            txtGateS1.Text = maxGate
                        ElseIf txtGateS2.Text > maxGate Then
                            txtGateS2.Text = maxGate
                        ElseIf txtGateS3.Text > maxGate Then
                            txtGateS3.Text = maxGate
                        ElseIf txtGateS4.Text > maxGate Then
                            txtGateS4.Text = maxGate
                        ElseIf txtGateS5.Text > maxGate Then
                            txtGateS5.Text = maxGate
                        ElseIf txtGateS6.Text > maxGate Then
                            txtGateS6.Text = maxGate
                        ElseIf txtGateS7.Text > maxGate Then
                            txtGateS7.Text = maxGate
                        ElseIf txtGateS8.Text > maxGate Then
                            txtGateS8.Text = maxGate
                        ElseIf txtGateS9.Text > maxGate Then
                            txtGateS9.Text = maxGate
                        ElseIf txtGateS10.Text > maxGate Then
                            txtGateS10.Text = maxGate
                        End If


                        'threshold1
                        If txtThresh1.Text > maxthreshold Then
                            tb.Text = maxthreshold
                        ElseIf txtThresh2.Text > maxthreshold Then
                            tb.Text = maxthreshold
                        ElseIf txtThresh3.Text > maxthreshold Then
                            tb.Text = maxthreshold
                        ElseIf txtThresh4.Text > maxthreshold Then
                            tb.Text = maxthreshold
                        ElseIf txtThresh5.Text > maxthreshold Then
                            tb.Text = maxthreshold
                        ElseIf txtThresh6.Text > maxthreshold Then
                            tb.Text = maxthreshold
                        ElseIf txtThresh7.Text > maxthreshold Then
                            tb.Text = maxthreshold
                        ElseIf txtThresh8.Text > maxthreshold Then
                            tb.Text = maxthreshold
                        ElseIf txtThresh9.Text > maxthreshold Then
                            tb.Text = maxthreshold
                        ElseIf txtThresh10.Text > maxthreshold Then
                            tb.Text = maxthreshold
                        End If

                        If TotNch > 9 Then
                            If txtThresh11.Text > maxthreshold Then
                                tb.Text = maxthreshold
                            ElseIf txtThresh12.Text > maxthreshold Then
                                tb.Text = maxthreshold
                            ElseIf txtThresh13.Text > maxthreshold Then
                                tb.Text = maxthreshold
                            ElseIf txtThresh14.Text > maxthreshold Then
                                tb.Text = maxthreshold
                            ElseIf txtThresh15.Text > maxthreshold Then
                                tb.Text = maxthreshold
                            ElseIf txtThresh16.Text > maxthreshold Then
                                tb.Text = maxthreshold
                            ElseIf txtThresh17.Text > maxthreshold Then
                                tb.Text = maxthreshold
                            End If
                        End If


                        'threshold 2
                        If txtThr21.Text > maxthreshold Then
                            tb.Text = maxthreshold
                        ElseIf txtThr22.Text > maxthreshold Then
                            tb.Text = maxthreshold
                        ElseIf txtThr23.Text > maxthreshold Then
                            tb.Text = maxthreshold
                        ElseIf txtThr24.Text > maxthreshold Then
                            tb.Text = maxthreshold
                        ElseIf txtThr25.Text > maxthreshold Then
                            tb.Text = maxthreshold
                        ElseIf txtThr26.Text > maxthreshold Then
                            tb.Text = maxthreshold
                        ElseIf txtThr27.Text > maxthreshold Then
                            tb.Text = maxthreshold
                        ElseIf txtThr28.Text > maxthreshold Then
                            tb.Text = maxthreshold
                        ElseIf txtThr29.Text > maxthreshold Then
                            tb.Text = maxthreshold
                        ElseIf txtThr210.Text > maxthreshold Then
                            tb.Text = maxthreshold
                        End If

                        If TotNch > 9 Then
                            If txtThr211.Text > maxthreshold Then
                                tb.Text = maxthreshold
                            ElseIf txtThr212.Text > maxthreshold Then
                                tb.Text = maxthreshold
                            ElseIf txtThr213.Text > maxthreshold Then
                                tb.Text = maxthreshold
                            ElseIf txtThr214.Text > maxthreshold Then
                                tb.Text = maxthreshold
                            ElseIf txtThr215.Text > maxthreshold Then
                                tb.Text = maxthreshold
                            ElseIf txtThr216.Text > maxthreshold Then
                                tb.Text = maxthreshold
                            ElseIf txtThr217.Text > maxthreshold Then
                                tb.Text = maxthreshold
                            End If
                        End If



                        'delay
                        If txtDelay1.Text > maxdelay Then
                            tb.Text = maxdelay
                        ElseIf txtDelay2.Text > maxdelay Then
                            tb.Text = maxdelay
                        ElseIf txtDelay3.Text > maxdelay Then
                            tb.Text = maxdelay
                        ElseIf txtDelay4.Text > maxdelay Then
                            tb.Text = maxdelay
                        ElseIf txtDelay5.Text > maxdelay Then
                            tb.Text = maxdelay
                        ElseIf txtDelay6.Text > maxdelay Then
                            tb.Text = maxdelay
                        ElseIf txtDelay7.Text > maxdelay Then
                            tb.Text = maxdelay
                        ElseIf txtDelay8.Text > maxdelay Then
                            tb.Text = maxdelay
                        ElseIf txtDelay9.Text > maxdelay Then
                            tb.Text = maxdelay
                        ElseIf txtDelay10.Text > maxdelay Then
                            tb.Text = maxdelay
                        End If

                        If TotNch > 9 Then
                            If txtDelay11.Text > maxdelay Then
                                tb.Text = maxdelay
                            ElseIf txtDelay12.Text > maxdelay Then
                                tb.Text = maxdelay
                            ElseIf txtDelay13.Text > maxdelay Then
                                tb.Text = maxdelay
                            ElseIf txtDelay14.Text > maxdelay Then
                                tb.Text = maxdelay
                            ElseIf txtDelay15.Text > maxdelay Then
                                tb.Text = maxdelay
                            ElseIf txtDelay16.Text > maxdelay Then
                                tb.Text = maxdelay
                            ElseIf txtDelay17.Text > maxdelay Then
                                tb.Text = maxdelay
                            End If
                        End If

                        'range
                        If txtRange1.Text > maxrange Then
                            tb.Text = maxrange
                        ElseIf txtRange2.Text > maxrange Then
                            tb.Text = maxrange
                        ElseIf txtRange3.Text > maxrange Then
                            tb.Text = maxrange
                        ElseIf txtRange4.Text > maxrange Then
                            tb.Text = maxrange
                        ElseIf txtRange5.Text > maxrange Then
                            tb.Text = maxrange
                        ElseIf txtRange6.Text > maxrange Then
                            tb.Text = maxrange
                        ElseIf txtRange7.Text > maxrange Then
                            tb.Text = maxrange
                        ElseIf txtRange8.Text > maxrange Then
                            tb.Text = maxrange
                        ElseIf txtRange9.Text > maxrange Then
                            tb.Text = maxrange
                        ElseIf txtRange10.Text > maxrange Then
                            tb.Text = maxrange
                        End If

                        If TotNch > 9 Then
                            If txtRange11.Text > maxrange Then
                                tb.Text = maxrange
                            ElseIf txtRange12.Text > maxrange Then
                                tb.Text = maxrange
                            ElseIf txtRange13.Text > maxrange Then
                                tb.Text = maxrange
                            ElseIf txtRange14.Text > maxrange Then
                                tb.Text = maxrange
                            ElseIf txtRange15.Text > maxrange Then
                                tb.Text = maxrange
                            ElseIf txtRange16.Text > maxrange Then
                                tb.Text = maxrange
                            ElseIf txtRange17.Text > maxrange Then
                                tb.Text = maxrange
                            End If
                        End If

                    Case FKeyMinus
                        v = Val(tb.Text) - incval
                        If v < 0 Then v = 0
                        If curj = 2 Then If v < 50 Then v = 50
                        tb.Text = IIf(curj = 0 Or curj = 10, Format(v, "0.0"), Format(v, "0"))
                        Me.lblInput.Text = tb.Text
                        StoreVals()
                        If curj = 0 Then
                            SaveGain()
                        End If
                End Select
            Case 10
                If isstopped Then
                    If k = FKeyRun Then
                        isstop = False
                        keyprocessing = False
                        Acquire(curi)
                        Exit Sub
                    End If
                Else
                    isstop = True
                    If k <> FKeyRun Then
                        lastkey = k
                        Timer1.Enabled = True
                        keyprocessing = False
                    End If
                    Exit Sub
                End If
                Select Case k
                    Case FKeySave                         'save config graph
                        SavePRC()
                    Case EsKey

                        lblPH.Visible = False
                        isstopped = True
                        Timer1.Enabled = False
                        mnu = 20
                        caltyp = 0
                        If caltypS = 2 Then
                            SetUpConfig(curi, curj)
                        Else
                            Close()
                        End If
                    Case FKeyUp
                        curi = curi - 1
                        StoreVals()
                        SetTextBox()
                        SetLabels()
                    Case FKeyDn
                        curi = curi + 1
                        SetTextBox()
                        StoreVals()
                        SetLabels()
                    Case FKeyLR
                        If curi <= 9 Then
                            curi = curi + 10
                        Else
                            curi = curi - 10
                        End If
                        SetTextBox()
                End Select
            Case 12
                If isstopped Then
                    If k = FKeyRun Then
                        isstop = False
                        keyprocessing = False
                        Acquire(curi)
                        Exit Sub
                    End If
                Else
                    isstop = True
                    If k <> FKeyRun Then
                        lastkey = k
                        Timer1.Enabled = True
                        keyprocessing = False
                    End If
                    Exit Sub
                End If
                Select Case k
                    Case FKeySave                         'save config graph

                        glbi = curi
                        SavePRV(3)
                        frmTest.Panel1.Visible = True
                        lblPH.Visible = False
                        mnu = 20
                        Timer1.Enabled = False
                        Me.Close()
                    Case EsKey
                        lblPH.Visible = False
                        isstopped = True
                        Timer1.Enabled = False
                        mnu = 20
                        Me.Close()
                        frm3StopProcessing = True
                        Exit Sub
                        curi = curi - 1
                        SetTextBox()
                        SetLabels()
                    Case FKeyDn
                        curi = curi + 1
                        SetTextBox()
                        SetLabels()
                    Case FKeyLR
                        If curi <= 9 Then
                            curi = curi + 10
                        Else
                            curi = curi - 10
                        End If
                        SetTextBox()
                End Select
            Case 14
                If isstopped Then
                    If k = FKeyRun Then

                        isstop = False
                        keyprocessing = False
                        Acquire(curi)
                        Exit Sub
                    End If
                Else
                    isstop = True
                    If k <> FKeyRun Then
                        lastkey = k
                        Timer1.Enabled = True
                        keyprocessing = False
                    End If
                    Exit Sub
                End If
                Select Case k
                    Case FKeySave                         'save config graph
                        glbi = curi
                        SavePRV(14)
                        frmTest.Panel1.Visible = True
                        lblPH.Visible = False
                        mnu = 20
                        Timer1.Enabled = False
                        Me.Close()
                    Case EsKey
                        lblPH.Visible = False
                        isstopped = True
                        Timer1.Enabled = False
                        mnu = 20
                        Me.Close()
                    Case FKeyUp
                        curi = curi - 1
                        SetTextBox()
                        SetLabels()
                    Case FKeyDn
                        curi = curi + 1
                        SetTextBox()
                        SetLabels()
                    Case FKeyLR
                        If curi <= 9 Then
                            curi = curi + 10
                        Else
                            curi = curi - 10
                        End If
                        SetTextBox()
                End Select

        End Select
        keyprocessing = False
        Application.DoEvents()
    End Sub
    Public Sub CreateConfigFolder()
        Dim j As Integer = 0
        Dim dat As String = "calib"
        ConfigGraphPath = RootDataPath & "\" & dat
        If Not Directory.Exists(AppDataPath) Then
            Directory.CreateDirectory(AppDataPath)
        End If
    End Sub

    Private Sub SavePRH()
        Try
            'ToDo: Rplace ref to km tp etc - replace saveinfo with empty info
            'Save folder ??
            Static isSaving
            If isSaving Then Exit Sub
            isSaving = True
            Dim i As Integer, j As Integer, k As Integer
            Dim objBW As BinaryWriter
            Dim objFS As FileStream
            Dim objBWin As BinaryReader
            Dim objFSin As FileStream
            Dim b() As Byte
            Dim farr As String()

            Dim cap As String = Me.Text
            SavePRV(2)
            StoreVals()
            ConfigGraphPath = RootDataPath & "\" & "Calib"
            If Not Directory.Exists(ConfigGraphPath) Then
                Directory.CreateDirectory(ConfigGraphPath)
            End If

            farr = Directory.GetFiles(StorageCard, "*.prc")
            If farr.Length <> 0 Then
                Me.Text = cap & " - Saving"
                For k = 0 To farr.GetUpperBound(0)
                    Dim fnam As String = ExtractFilename(farr(k))
                    objFS = New FileStream(ConfigGraphPath & "\" & fnam, FileMode.Create, FileAccess.Write)
                    objBW = New BinaryWriter(objFS)

                    SaveInfo0(objBW)

                    For i = 0 To DataArr.GetUpperBound(0)
                        For j = 0 To DataArr.GetUpperBound(1)
                            objBW.Write(DataArr(i, j))
                        Next j
                    Next i

                    objFSin = New FileStream(farr(k), FileMode.Open, FileAccess.Read)
                    objBWin = New BinaryReader(objFSin)
                    b = objBWin.ReadBytes(objFSin.Length)
                    objBW.Write(b)
                    objBW.Close()
                    objFS.Close()
                    objBWin.Close()
                    objFSin.Close()
                    If File.Exists(farr(k)) Then File.Delete(farr(k))
                Next k
            End If

            Me.Text = cap
            isSaving = False
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SavePRC()
        Try
            'ToDo: Rplace ref to km tp etc - replace saveinfo with empty info
            'Save folder ??
            Static isSaving
            If isSaving Then Exit Sub
            isSaving = True
            Dim i As Integer, j As Integer, k As Integer
            Dim objBW As BinaryWriter
            Dim objFS As FileStream
            Dim objBWin As BinaryReader
            Dim objFSin As FileStream
            Dim b() As Byte
            Dim farr As String()

            Dim cap As String = Me.Text
            SavePRV(2)
            StoreVals()
            ConfigGraphPath = RootDataPath & "\" & "Calib"
            If Not Directory.Exists(ConfigGraphPath) Then
                Directory.CreateDirectory(ConfigGraphPath)
            End If

            farr = Directory.GetFiles(StorageCard, "*.prc")
            If farr.Length <> 0 Then
                Me.Text = cap & " - Saving"
                For k = 0 To farr.GetUpperBound(0)
                    Dim fnam As String = ExtractFilename(farr(k))
                    objFS = New FileStream(ConfigGraphPath & "\" & fnam, FileMode.Create, FileAccess.Write)
                    objBW = New BinaryWriter(objFS)

                    SaveInfo0(objBW)

                    For i = 0 To DataArr.GetUpperBound(0)
                        For j = 0 To DataArr.GetUpperBound(1)
                            objBW.Write(DataArr(i, j))
                        Next j
                    Next i

                    objFSin = New FileStream(farr(k), FileMode.Open, FileAccess.Read)
                    objBWin = New BinaryReader(objFSin)
                    b = objBWin.ReadBytes(objFSin.Length)
                    objBW.Write(b)
                    objBW.Close()
                    objFS.Close()
                    objBWin.Close()
                    objFSin.Close()
                    If File.Exists(farr(k)) Then File.Delete(farr(k))
                Next k
            End If

            Me.Text = cap
            isSaving = False

        Catch ex As Exception

        End Try
    End Sub
    Private Sub SaveInfo0(ByVal objBW As BinaryWriter)

        objBW.Write(Format(uno, "00000"))                   '0
        Dim st As String = ListBox1.Items(ListBox1.SelectedIndex)
        objBW.Write(st)                   '1
        objBW.Write("")                   '2
        objBW.Write("")                   '3
        objBW.Write(DateTime.Now.ToString("dd/MM/yy hh:mm tt"))                   '4
        objBW.Write("")                    '5
        objBW.Write("")                    '6
        objBW.Write("")                     '7
        objBW.Write("")                     '8
        objBW.Write("")                   '9
        objBW.Write("")                   '10
        objBW.Write("")                    '11
        objBW.Write("")                    '12
        objBW.Write("")                   '13
        objBW.Write("")                   '14
        objBW.Write("")                   '15
        objBW.Write("")                   '16
        objBW.Write("")                   '17
        objBW.Write("")                  '18
        objBW.Write("")                  '19
        objBW.Write("")                  '20
        objBW.Write("")                  '21
        objBW.Write("")                     '22
        objBW.Write("")                  '23
        Dim xxx As String = Me.lblPH.Text.Replace(vbCrLf, " ")
        objBW.Write(xxx)     '24
        objBW.Write("")     '25
        objBW.Write("")                    '26
        objBW.Write("")                   '27
        objBW.Write("")                  '28
        objBW.Write("")                   '29
        objBW.Write("")                    '30
        objBW.Write("")                    '31
        objBW.Write("")                   '32
        objBW.Write("")                  '33
        objBW.Write("")                 '34
        st = "" 'cmbCode2.Text & "[" & cmbCris.Text & "[" & txtRem.Text
        objBW.Write(st)                  '35
    End Sub

    Private Sub frmCalib_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frm3StopProcessing = False
        isRefresh = True
        frmCalib_Load()
    End Sub

    Private Sub frmCalib_Load()
        Try
            Me.AutoScroll = False
            lblPH.Visible = False
            Dim i As Integer
            SetCursorPos(640, 460)
            isloaded = False
            isstop = True
            i = InStr(datafile, MCNO)

            Dim RW As String = IIf(TotNch < 5, "WELD", IIf(InStr(datafile, ".prh") <> 0, "HANDHELD", "CALIBRATION"))
            Dim frmcaps() As String = New String() {"Calibration", "Read AScan", "Acquire Freeze", "Read Freeze Data", "Acquire", "Read " & RW & " Data", "Acquire Zoom", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""}
            frmcap = frmcaps(caltyp) & IIf(caltyp = 0 Or caltyp = 2 Or caltyp = 4 Or caltyp = 6 Or caltyp = 10 Or caltyp = 12 Or caltyp = 14 Or caltyp = 15, "", "-File:" & Mid$(datafile, i + 9))

            If ((caltyp = 2) = True) Then
                Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None

            ElseIf (caltyp = 0 Or caltyp = 4 Or caltyp = 6 Or caltyp = 10 Or caltyp = 12 Or caltyp = 14 Or caltyp = 15) Then
                Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle

            End If


            For ai = 0 To BSCANBUFF.GetUpperBound(0) Step 1
                BSCANBUFF(ai) = 0
            Next

            Me.Text = frmcap & " - Please Wait"
            Me.Width = mewidth : Me.Height = meheight
            Me.lblMenu1.Left = mewidth - Me.lblMenu1.Width
            Me.lblMenu2.Left = Me.lblMenu1.Left
            Me.lblMenu3.Left = Me.lblMenu1.Left
            Me.lblMenu4.Left = Me.lblMenu1.Left
            Me.lblMenu5.Left = Me.lblMenu1.Left
            Me.lblMenu6.Left = Me.lblMenu1.Left
            Me.lblMenu7.Left = Me.lblMenu1.Left
            Me.lblMenu8.Left = Me.lblMenu1.Left
            Me.lblZoomP.Left = Me.lblMenu1.Left
            Me.lblZoomM.Left = Me.lblMenu1.Left
            Me.lblZoomL.Left = Me.lblMenu1.Left
            Me.lblZoomR.Left = Me.lblMenu1.Left

            Me.lblMenu1.Top = lbl1top : Me.lblMenu1.Height = lbl1height
            Me.lblMenu2.Top = lbl2top : Me.lblMenu2.Height = lbl2height
            Me.lblMenu3.Top = lbl3top : Me.lblMenu3.Height = lbl3height
            Me.lblMenu4.Top = lbl4top : Me.lblMenu4.Height = lbl4height
            Me.lblMenu5.Top = lbl5top : Me.lblMenu5.Height = lbl5height
            Me.lblMenu6.Top = lbl6top : Me.lblMenu6.Height = lbl6height
            Me.lblMenu7.Top = lbl7top : Me.lblMenu7.Height = lbl7height
            Me.lblMenu8.Top = lbl8top : Me.lblMenu8.Height = lbl8height
            Me.lblZoomP.Top = lbl1top : Me.lblZoomP.Height = lbl1height
            Me.lblZoomM.Top = lbl2top : Me.lblZoomM.Height = lbl2height
            Me.lblZoomL.Top = lbl3top : Me.lblZoomL.Height = lbl1height
            Me.lblZoomR.Top = lbl4top : Me.lblZoomM.Height = lbl2height

            Me.lblZoomL.Visible = False
            Me.lblZoomM.Visible = False
            Me.lblZoomP.Visible = False
            Me.lblZoomR.Visible = False

            mnu = 20

            If caltyp = 0 Or caltyp = 10 Or caltyp = 12 Or caltyp = 14 Then
                bmp = New Bitmap(mewidth / 2, meheight / 2)
                bbmp = New Bitmap(mewidth / 2, meheight / 2)
            ElseIf caltyp = 4 Then
                bmp = New Bitmap(mewidth / 2, meheight / 2)
                bbmp = New Bitmap(mewidth / 2, meheight / 2)
            ElseIf caltyp = 1 Then
                bmp = New Bitmap(mewidth, meheight)
                bbmp = New Bitmap(mewidth, meheight)
            Else
                bmp = New Bitmap(mewidth, meheight)
                bbmp = New Bitmap(mewidth, meheight)
            End If

            objGraphics = Graphics.FromImage(bmp)
            objGraphics.Clear(Color.Black)
            objGraphicsB = Graphics.FromImage(bbmp)
            objGraphicsB.Clear(Color.FromArgb(10, 10, 10))
            objGraphicsFrm = Me.CreateGraphics

            lblC1.Left = 0 : lblC2.Left = 0 : lblC3.Left = 0 : lblC4.Left = 0 : lblC5.Left = 0 : lblC6.Left = 0 : lblC7.Left = 0 : lblC8.Left = 0 : lblC9.Left = 0 : lblC10.Left = 0
            lblC1.Top = lblRange.Height
            lblC2.Top = lblC1.Top + lblC1.Height + 2
            lblC3.Top = lblC2.Top + lblC2.Height + 2
            lblC4.Top = lblC3.Top + lblC3.Height + 2
            lblC5.Top = lblC4.Top + lblC4.Height + 2
            lblC6.Top = lblC5.Top + lblC5.Height + 2
            lblC7.Top = lblC6.Top + lblC6.Height + 2
            lblC8.Top = lblC7.Top + lblC7.Height + 2
            lblC9.Top = lblC8.Top + lblC8.Height + 2
            lblC10.Top = lblC9.Top + lblC9.Height + 2
            lblGain.Left = lblC1.Left + lblC1.Width + 0 : lblGain.Top = 0
            lblDelay.Left = lblGain.Left + lblGain.Width + 0 : lblDelay.Top = 0
            lblRange.Left = lblDelay.Left + lblDelay.Width + 0 : lblRange.Top = 0
            lblReject.Left = lblRange.Left + lblRange.Width + 0 : lblReject.Top = 0
            lblGateS.Left = lblReject.Left + lblReject.Width + 0 : lblGateS.Top = 0
            lblGateW.Left = lblGateS.Left + lblGateS.Width + 0 : lblGateW.Top = 0
            lblThresh.Left = lblGateW.Left + lblGateW.Width + 0 : lblThresh.Top = 0
            lblG2St.Left = lblThresh.Left + lblThresh.Width + 0 : lblG2St.Top = 0
            lblG2Wd.Left = lblG2St.Left + lblG2St.Width + 0 : lblG2Wd.Top = 0
            lblThr2.Left = lblG2Wd.Left + lblG2Wd.Width + 0 : lblThr2.Top = 0
            lblAng.Left = lblThr2.Left + lblThr2.Width + 0 : lblAng.Top = 0
            lblSide1.Left = 0 : lblSide1.Top = lblGain.Top
            If Not isCalib Then             '1st time create textboxes
                DispTextBoxes()
                DispTextBoxes1()
                isCalib = True
            End If
            If caltyp <> 1 Then
                SetVars()
            Else
                SetVars2()
            End If
            If caltyp >= 2 Then
                If caltyp = 2 Or caltyp = 4 Or caltyp = 6 Or caltyp = 15 Then curi = glbi
                isloaded = True
                ShowTextBoxes(False)
                SetLabels()

                If caltyp = 15 Then
                    bmpview = New Bitmap(datafile)
                End If
                Me.Show()
                Me.Focus()
                mnu = 25

                If InStr(frmData.ListBox2.SelectedItem, ".jpg") Or InStr(frmData.ListBox2.SelectedItem, ".jpeg") Or InStr(frmData.ListBox2.SelectedItem, ".JPEG") Or InStr(frmData.ListBox2.SelectedItem, ".bmp") Or InStr(frmData.ListBox2.SelectedItem, ".BMP") Then
                    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
                Else
                    Acquire(curi)
                    Me.Refresh()
                End If
                Exit Sub
            End If
            If caltyp = 1 Then
                ShowTextBoxes(False)
                isloaded = True
                SetLabels()
                Me.Show()
                Me.Focus()
                curi = Val(Microsoft.VisualBasic.Right(datafile, 6)) - 1

                If curi = -1 Then curi = 0
                mnu = 25
                Acquire(curi)
                Exit Sub
            End If
            Panel2.SendToBack()
            Panel2.Left = 0
            Panel2.Top = 0
            Panel2.Width = Me.Width
            Panel2.Height = Me.Height
            Application.DoEvents()
            Panel1.Left = lblMenu1.Left - Panel1.Width : Panel1.Top = lblC1.Top

            If TotNch <= 9 Then
                Panel1.Height = lblC9.Top + lblC9.Height '- lblGain.Top
            Else
                Panel1.Height = lblC17.Top + lblC17.Height - Panel1.Top
            End If

            lblInput.Left = Panel1.Left : lblInput.Top = 0
            ListBox1.Top = lblCalSet.Top + lblCalSet.Height
            ListBox1.Height = Panel1.Height - ListBox1.Top
            ListBox1.Font = New Font(FontFamily.GenericSansSerif, 18.0F, FontStyle.Bold)

            Application.DoEvents()
            Add2CnfList()
            SortList(ListBox1, True)
            ListBox1.SelectedIndex = cnfi
            cnfnam = ListBox1.Items(ListBox1.SelectedIndex)
            cnfnam = AppPath & "\" & cnfnam & ".cnf"
            Application.DoEvents()
            curi = 0 : curj = 0
            SetLabels()
            Application.DoEvents()
            OpenConfig()
            Application.DoEvents()
            SetUpConfig()
            Application.DoEvents()
            Panel2.SendToBack()
            Me.Text = frmcap
            isstop = True
            If caltyp = 0 Then
                ShowTextBoxes(True)
                tb.Focus()
                isloaded = True
                Me.Show()
            Else
                If caltyp = 2 Or caltyp = 4 Or caltyp = 6 Then curi = glbi
                ShowTextBoxes(False)
                EditConfig()
                isloaded = True
                Me.Show()
                Me.Focus()
                Acquire(curi)
            End If
            SetCursorPos(640, 460)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Add2CnfList()
        Try
            Dim farr As String() = Directory.GetFiles(AppPath, "*.cnf")
            Dim i As Integer, j As Integer, l As Integer
            ListBox1.Items.Clear()
            For i = 0 To farr.Length - 1
                l = Len(AppPath) + 2
                j = InStr(farr(i), ".")
                ListBox1.Items.Add(Mid$(farr(i), l, j - l))
            Next i
        Catch ex As Exception

        End Try
    End Sub
    Public Sub fnFetch10ChDataArrayValue()
        Try
            'Config
            Dim configFile As String = StorageCard & "config10.txt"
            Dim strLineData As String = ""
            Dim arrData() As String
            Dim arrCurrLineData() As String
            Dim objSRConfig As StreamReader
            objSRConfig = New StreamReader(configFile)

            Dim intLineLoop As Integer = 0
            Dim strConfig10Data As String = ""

            If File.Exists(configFile) Then
                Do While Not objSRConfig.EndOfStream
                    intLineLoop = intLineLoop + 1

                    strLineData = objSRConfig.ReadLine

                    If intLineLoop = 1 Then
                        strConfig10Data = strLineData
                    Else
                        strConfig10Data = strConfig10Data & "~" & strLineData
                    End If
                Loop
            End If

            arrData = strConfig10Data.Split("~")

            For i = 0 To CalsetDataArr10.GetUpperBound(0)
                For j = 0 To CalsetDataArr10.GetUpperBound(1)

                    Dim strCurrLine As String = arrData(i) & ","
                    arrCurrLineData = strCurrLine.Split(",")

                    If arrCurrLineData(j).ToString.Trim <> "" Then
                        CalsetDataArr10(i, j) = Convert.ToInt32(arrCurrLineData(j).ToString.Trim)
                    End If
                Next
            Next

            'Gain
            Dim strLineDataGain As String = ""
            Dim arrDataGain() As String
            Dim arrCurrLineDataGain() As String
            Dim objSRGain As StreamReader


            Dim intLineLoopGain As Integer = 0
            Dim strGain10Data As String = ""

            For rr = 1 To 10
                Dim gainFile As String = StorageCard & "gaindata" & rr & ".txt"
                objSRGain = New StreamReader(gainFile)

                If File.Exists(gainFile) Then
                    Do While Not objSRGain.EndOfStream
                        intLineLoopGain = intLineLoopGain + 1

                        For ww = 1 To 11
                            strLineDataGain = objSRGain.ReadLine
                        Next

                        If intLineLoopGain = 1 Then
                            strGain10Data = strLineDataGain
                        Else
                            strGain10Data = strGain10Data & "~" & strLineDataGain
                        End If
                    Loop
                End If
            Next


            arrDataGain = strGain10Data.Split("~")

            For i = 0 To CalsetDataArr10.GetUpperBound(0)
                For j = 0 To CalsetDataArr10.GetUpperBound(1)

                    Dim strCurrLine As String = arrDataGain(i)
                    arrCurrLineDataGain = strCurrLine.Split(",")

                    If j = 11 Then
                        If arrCurrLineDataGain(1).ToString.Trim <> "" Then
                            CalsetDataArr10(i, j) = Convert.ToInt32(arrCurrLineDataGain(1).ToString.Trim)
                        End If
                    End If
                Next
            Next

            'Angle
            Dim angleFile As String = StorageCard & "angdata10.txt"
            Dim strLineDataAngle As String = ""
            Dim arrDataAngle() As String
            Dim arrCurrLineDataAngle() As String
            Dim objSRAngle As StreamReader
            objSRAngle = New StreamReader(angleFile)

            Dim intLineLoopAngle As Integer = 0
            Dim strAngle10Data As String = ""

            If File.Exists(angleFile) Then
                Do While Not objSRAngle.EndOfStream
                    intLineLoopAngle = intLineLoopAngle + 1

                    strLineDataAngle = objSRAngle.ReadLine

                    If intLineLoopAngle = 1 Then
                        strAngle10Data = strLineDataAngle
                    Else
                        strAngle10Data = strAngle10Data & "~" & strLineDataAngle
                    End If
                Loop
            End If

            arrDataAngle = strAngle10Data.Split("~")

            For i = 0 To CalsetDataArr10.GetUpperBound(0)
                For j = 0 To CalsetDataArr10.GetUpperBound(1)

                    Dim strCurrLine As String = arrDataAngle(i)
                    arrCurrLineDataAngle = strCurrLine.Split(",")

                    If j = 12 Then
                        If arrCurrLineDataAngle(1).ToString.Trim <> "" Then
                            CalsetDataArr10(i, j) = Convert.ToInt32(arrCurrLineDataAngle(1).ToString.Trim)
                        End If
                    End If
                Next
            Next

        Catch ex As Exception

        End Try
    End Sub

    Public Sub DispVals()

        Try
            'Gain
            txtGain1.MaxLength = 4
            txtGain2.MaxLength = 4
            txtGain3.MaxLength = 4
            txtGain4.MaxLength = 4
            txtGain5.MaxLength = 4
            txtGain6.MaxLength = 4
            txtGain7.MaxLength = 4
            txtGain8.MaxLength = 4
            txtGain9.MaxLength = 4
            txtGain10.MaxLength = 4
            'DRT
            txtGain11.MaxLength = 4
            txtGain12.MaxLength = 4
            txtGain13.MaxLength = 4
            txtGain14.MaxLength = 4
            txtGain15.MaxLength = 4
            txtGain16.MaxLength = 4
            txtGain17.MaxLength = 4


            'Delay
            txtDelay1.MaxLength = 3
            txtDelay2.MaxLength = 3
            txtDelay3.MaxLength = 3
            txtDelay4.MaxLength = 3
            txtDelay5.MaxLength = 3
            txtDelay6.MaxLength = 3
            txtDelay7.MaxLength = 3
            txtDelay8.MaxLength = 3
            txtDelay9.MaxLength = 3
            txtDelay10.MaxLength = 3
            'DRT
            txtDelay11.MaxLength = 3
            txtDelay12.MaxLength = 3
            txtDelay13.MaxLength = 3
            txtDelay14.MaxLength = 3
            txtDelay15.MaxLength = 3
            txtDelay16.MaxLength = 3
            txtDelay17.MaxLength = 3

            'Range
            txtRange1.MaxLength = 3
            txtRange2.MaxLength = 3
            txtRange3.MaxLength = 3
            txtRange4.MaxLength = 3
            txtRange5.MaxLength = 3
            txtRange6.MaxLength = 3
            txtRange7.MaxLength = 3
            txtRange8.MaxLength = 3
            txtRange9.MaxLength = 3
            txtRange10.MaxLength = 3
            'DRT
            txtRange11.MaxLength = 3
            txtRange12.MaxLength = 3
            txtRange13.MaxLength = 3
            txtRange14.MaxLength = 3
            txtRange15.MaxLength = 3
            txtRange16.MaxLength = 3
            txtRange17.MaxLength = 3

            'Reject
            txtReject1.MaxLength = 2
            txtReject2.MaxLength = 2
            txtReject3.MaxLength = 2
            txtReject4.MaxLength = 2
            txtReject5.MaxLength = 2
            txtReject6.MaxLength = 2
            txtReject7.MaxLength = 2
            txtReject8.MaxLength = 2
            txtReject9.MaxLength = 2
            txtReject10.MaxLength = 2
            'DRT
            txtReject11.MaxLength = 2
            txtReject12.MaxLength = 2
            txtReject13.MaxLength = 2
            txtReject14.MaxLength = 2
            txtReject15.MaxLength = 2
            txtReject16.MaxLength = 2
            txtReject17.MaxLength = 2

            'G1ST
            txtGateS1.MaxLength = 2
            txtGateS2.MaxLength = 2
            txtGateS3.MaxLength = 2
            txtGateS4.MaxLength = 2
            txtGateS5.MaxLength = 2
            txtGateS6.MaxLength = 2
            txtGateS7.MaxLength = 2
            txtGateS8.MaxLength = 2
            txtGateS9.MaxLength = 2
            txtGateS10.MaxLength = 2
            'DRT
            txtGateS11.MaxLength = 2
            txtGateS12.MaxLength = 2
            txtGateS13.MaxLength = 2
            txtGateS14.MaxLength = 2
            txtGateS15.MaxLength = 2
            txtGateS16.MaxLength = 2
            txtGateS17.MaxLength = 2

            'G1WD
            txtGateW1.MaxLength = 2
            txtGateW2.MaxLength = 2
            txtGateW3.MaxLength = 2
            txtGateW4.MaxLength = 2
            txtGateW5.MaxLength = 2
            txtGateW6.MaxLength = 2
            txtGateW7.MaxLength = 2
            txtGateW8.MaxLength = 2
            txtGateW9.MaxLength = 2
            txtGateW10.MaxLength = 2
            'DRT
            txtGateW11.MaxLength = 2
            txtGateW12.MaxLength = 2
            txtGateW13.MaxLength = 2
            txtGateW14.MaxLength = 2
            txtGateW15.MaxLength = 2
            txtGateW16.MaxLength = 2
            txtGateW17.MaxLength = 2

            'Threshold 1
            txtThresh1.MaxLength = 2
            txtThresh2.MaxLength = 2
            txtThresh3.MaxLength = 2
            txtThresh4.MaxLength = 2
            txtThresh5.MaxLength = 2
            txtThresh6.MaxLength = 2
            txtThresh7.MaxLength = 2
            txtThresh8.MaxLength = 2
            txtThresh9.MaxLength = 2
            txtThresh10.MaxLength = 2
            'DRT
            txtThresh11.MaxLength = 2
            txtThresh12.MaxLength = 2
            txtThresh13.MaxLength = 2
            txtThresh14.MaxLength = 2
            txtThresh15.MaxLength = 2
            txtThresh16.MaxLength = 2
            txtThresh17.MaxLength = 2

            'G2ST
            txtG2St1.MaxLength = 2
            txtG2St2.MaxLength = 2
            txtG2St3.MaxLength = 2
            txtG2St4.MaxLength = 2
            txtG2St5.MaxLength = 2
            txtG2St6.MaxLength = 2
            txtG2St7.MaxLength = 2
            txtG2St8.MaxLength = 2
            txtG2St9.MaxLength = 2
            txtG2St10.MaxLength = 2
            'DRT
            txtG2St11.MaxLength = 2
            txtG2St12.MaxLength = 2
            txtG2St13.MaxLength = 2
            txtG2St14.MaxLength = 2
            txtG2St15.MaxLength = 2
            txtG2St16.MaxLength = 2
            txtG2St17.MaxLength = 2

            'G2WD
            txtG2Wd1.MaxLength = 2
            txtG2Wd2.MaxLength = 2
            txtG2Wd3.MaxLength = 2
            txtG2Wd4.MaxLength = 2
            txtG2Wd5.MaxLength = 2
            txtG2Wd6.MaxLength = 2
            txtG2Wd7.MaxLength = 2
            txtG2Wd8.MaxLength = 2
            txtG2Wd9.MaxLength = 2
            txtG2Wd10.MaxLength = 2
            'DRT
            txtG2Wd11.MaxLength = 2
            txtG2Wd12.MaxLength = 2
            txtG2Wd13.MaxLength = 2
            txtG2Wd14.MaxLength = 2
            txtG2Wd15.MaxLength = 2
            txtG2Wd16.MaxLength = 2
            txtG2Wd17.MaxLength = 2

            'Threshold 2
            txtThr21.MaxLength = 2
            txtThr22.MaxLength = 2
            txtThr23.MaxLength = 2
            txtThr24.MaxLength = 2
            txtThr25.MaxLength = 2
            txtThr26.MaxLength = 2
            txtThr27.MaxLength = 2
            txtThr28.MaxLength = 2
            txtThr29.MaxLength = 2
            txtThr210.MaxLength = 2
            'for DRT
            txtThr211.MaxLength = 2
            txtThr212.MaxLength = 2
            txtThr213.MaxLength = 2
            txtThr214.MaxLength = 2
            txtThr215.MaxLength = 2
            txtThr216.MaxLength = 2
            txtThr217.MaxLength = 2

            txtGain1.Text = Format(CSng(DataArr(0, 0)) / 2.0, "##0.0")
            txtGain2.Text = Format(CSng(DataArr(1, 0)) / 2.0, "##0.0")
            txtGain3.Text = Format(CSng(DataArr(2, 0)) / 2.0, "##0.0")
            txtGain4.Text = Format(CSng(DataArr(3, 0)) / 2.0, "##0.0")
            txtGain5.Text = Format(CSng(DataArr(4, 0)) / 2.0, "##0.0")
            txtGain6.Text = Format(CSng(DataArr(5, 0)) / 2.0, "##0.0")
            txtGain7.Text = Format(CSng(DataArr(6, 0)) / 2.0, "##0.0")
            txtGain8.Text = Format(CSng(DataArr(7, 0)) / 2.0, "##0.0")
            txtGain9.Text = Format(CSng(DataArr(8, 0)) / 2.0, "##0.0")
            txtGain10.Text = Format(CSng(DataArr(9, 0)) / 2.0, "##0.0")

            If TotNch > 9 Then
                txtGain11.Text = Format(CSng(DataArr(10, 0)) / 2.0, "##0.0")
                txtGain12.Text = Format(CSng(DataArr(11, 0)) / 2.0, "##0.0")
                txtGain13.Text = Format(CSng(DataArr(12, 0)) / 2.0, "##0.0")
                txtGain14.Text = Format(CSng(DataArr(13, 0)) / 2.0, "##0.0")
                txtGain15.Text = Format(CSng(DataArr(14, 0)) / 2.0, "##0.0")
                txtGain16.Text = Format(CSng(DataArr(15, 0)) / 2.0, "##0.0")
                txtGain17.Text = Format(CSng(DataArr(16, 0)) / 2.0, "##0.0")
            End If

            txtDelay1.Text = Format((DataArr(0, 1) * 0.2941), "###0")
            txtDelay2.Text = Format((DataArr(1, 1) * 0.2941), "###0")
            txtDelay3.Text = Format((DataArr(2, 1) * 0.2941), "###0")
            txtDelay4.Text = Format((DataArr(3, 1) * 0.2941), "###0")
            txtDelay5.Text = Format((DataArr(4, 1) * 0.2941), "###0")
            txtDelay6.Text = Format((DataArr(5, 1) * 0.2941), "###0")
            txtDelay7.Text = Format((DataArr(6, 1) * 0.2941), "###0")
            txtDelay8.Text = Format((DataArr(7, 1) * 0.2941), "###0")
            txtDelay9.Text = Format((DataArr(8, 1) * 0.2941), "###0")
            txtDelay10.Text = Format((DataArr(9, 1) * 0.2941), "###0")

            If TotNch > 9 Then
                txtDelay11.Text = Format((DataArr(7, 1) * 0.2941), "###0")
                txtDelay12.Text = Format((DataArr(8, 1) * 0.2941), "###0")
                txtDelay13.Text = Format((DataArr(9, 1) * 0.2941), "###0")
                txtDelay14.Text = Format((DataArr(10, 1) * 0.2941), "###0")
                txtDelay15.Text = Format((DataArr(11, 1) * 0.2941), "###0")
                txtDelay16.Text = Format((DataArr(12, 1) * 0.2941), "###0")
                txtDelay17.Text = Format((DataArr(13, 1) * 0.2941), "###0")
            End If

            txtRange1.Text = Format(Rangemm(DataArr(0, 2), 0), "###0")
            txtRange2.Text = Format(Rangemm(DataArr(1, 2), 1), "###0")
            txtRange3.Text = Format(Rangemm(DataArr(2, 2), 2), "###0")
            txtRange4.Text = Format(Rangemm(DataArr(3, 2), 3), "###0")
            txtRange5.Text = Format(Rangemm(DataArr(4, 2), 4), "###0")
            txtRange6.Text = Format(Rangemm(DataArr(5, 2), 5), "###0")
            txtRange7.Text = Format(Rangemm(DataArr(6, 2), 6), "###0")
            txtRange8.Text = Format(Rangemm(DataArr(7, 2), 7), "###0")
            txtRange9.Text = Format(Rangemm(DataArr(8, 2), 8), "###0")
            txtRange10.Text = Format(Rangemm(DataArr(9, 2), 9), "###0")

            If TotNch > 9 Then
                txtRange11.Text = Format(Rangemm(DataArr(10, 2), 10), "###0")
                txtRange12.Text = Format(Rangemm(DataArr(11, 2), 11), "###0")
                txtRange13.Text = Format(Rangemm(DataArr(12, 2), 12), "###0")
                txtRange14.Text = Format(Rangemm(DataArr(13, 2), 13), "###0")
                txtRange15.Text = Format(Rangemm(DataArr(14, 2), 14), "###0")
                txtRange16.Text = Format(Rangemm(DataArr(15, 2), 15), "###0")
                txtRange17.Text = Format(Rangemm(DataArr(16, 2), 16), "###0")
            End If

            'reject
            txtReject1.Text = Format(CSng(DataArr(0, 3)) / ymaxS, "#0")
            'channel 2-7
            txtReject2.Text = Format(CSng(DataArr(1, 3)) / ymaxS, "#0")
            txtReject3.Text = Format(CSng(DataArr(2, 3)) / ymaxS, "#0")
            txtReject4.Text = Format(CSng(DataArr(3, 3)) / ymaxS, "#0")
            txtReject5.Text = Format(CSng(DataArr(4, 3)) / ymaxS, "#0")
            txtReject6.Text = Format(CSng(DataArr(5, 3)) / ymaxS, "#0")
            txtReject7.Text = Format(CSng(DataArr(6, 3)) / ymaxS, "#0")
            txtReject8.Text = Format(CSng(DataArr(7, 3)) / ymaxS, "#0")
            txtReject9.Text = Format(CSng(DataArr(8, 3)) / ymaxS, "#0")
            txtReject10.Text = Format(CSng(DataArr(9, 3)) / ymaxS, "#0")

            '04.05.19 G1ST
            txtGateS1.Text = Format((DataArr(0, 4) / DataArr(0, 2)) * 100, "###0")
            txtGateS2.Text = Format((DataArr(1, 4) / DataArr(1, 2)) * 100, "###0")
            txtGateS3.Text = Format((DataArr(2, 4) / DataArr(2, 2)) * 100, "###0")
            txtGateS4.Text = Format((DataArr(3, 4) / DataArr(3, 2)) * 100, "###0")
            txtGateS5.Text = Format((DataArr(4, 4) / DataArr(4, 2)) * 100, "###0")
            txtGateS6.Text = Format((DataArr(5, 4) / DataArr(5, 2)) * 100, "###0")
            txtGateS7.Text = Format((DataArr(6, 4) / DataArr(6, 2)) * 100, "###0")
            txtGateS8.Text = Format((DataArr(7, 4) / DataArr(7, 2)) * 100, "###0")
            txtGateS9.Text = Format((DataArr(8, 4) / DataArr(8, 2)) * 100, "###0")
            txtGateS10.Text = Format((DataArr(9, 4) / DataArr(9, 2)) * 100, "###0")

            If TotNch > 9 Then
                txtGateS11.Text = Format((DataArr(10, 4) / DataArr(10, 2)) * 100, "###0")
                txtGateS12.Text = Format((DataArr(11, 4) / DataArr(11, 2)) * 100, "###0")
                txtGateS12.Text = Format((DataArr(11, 4) / DataArr(11, 2)) * 100, "###0")
                txtGateS13.Text = Format((DataArr(12, 4) / DataArr(12, 2)) * 100, "###0")
                txtGateS14.Text = Format((DataArr(13, 4) / DataArr(13, 2)) * 100, "###0")
                txtGateS15.Text = Format((DataArr(14, 4) / DataArr(14, 2)) * 100, "###0")
                txtGateS16.Text = Format((DataArr(15, 4) / DataArr(15, 2)) * 100, "###0")
                txtGateS17.Text = Format((DataArr(16, 4) / DataArr(16, 2)) * 100, "###0")
            End If

            'G1WD
            txtGateW1.Text = Format(((DataArr(0, 5) / DataArr(0, 2)) * 100) + txtGateS1.Text, "###0")
            txtGateW2.Text = Format(((DataArr(1, 5) / DataArr(1, 2)) * 100) + txtGateS2.Text, "###0")
            txtGateW3.Text = Format(((DataArr(2, 5) / DataArr(2, 2)) * 100) + txtGateS3.Text, "###0")
            txtGateW4.Text = Format(((DataArr(3, 5) / DataArr(3, 2)) * 100) + txtGateS4.Text, "###0")
            txtGateW5.Text = Format(((DataArr(4, 5) / DataArr(4, 2)) * 100) + txtGateS5.Text, "###0")
            txtGateW6.Text = Format(((DataArr(5, 5) / DataArr(5, 2)) * 100) + txtGateS6.Text, "###0")
            txtGateW7.Text = Format(((DataArr(6, 5) / DataArr(6, 2)) * 100) + txtGateS7.Text, "###0")
            txtGateW8.Text = Format(((DataArr(7, 5) / DataArr(7, 2)) * 100) + txtGateS8.Text, "###0")
            txtGateW9.Text = Format(((DataArr(8, 5) / DataArr(8, 2)) * 100) + txtGateS9.Text, "###0")
            txtGateW10.Text = Format(((DataArr(9, 5) / DataArr(9, 2)) * 100) + txtGateS10.Text, "###0")

            If TotNch > 9 Then
                txtGateW11.Text = Format(((DataArr(10, 5) / DataArr(10, 2)) * 100) + txtGateS11.Text, "###0")
                txtGateW12.Text = Format(((DataArr(11, 5) / DataArr(11, 2)) * 100) + txtGateS12.Text, "###0")
                txtGateW13.Text = Format(((DataArr(12, 5) / DataArr(12, 2)) * 100) + txtGateS13.Text, "###0")
                txtGateW14.Text = Format(((DataArr(13, 5) / DataArr(13, 2)) * 100) + txtGateS14.Text, "###0")
                txtGateW15.Text = Format(((DataArr(14, 5) / DataArr(14, 2)) * 100) + txtGateS15.Text, "###0")
                txtGateW16.Text = Format(((DataArr(15, 5) / DataArr(15, 2)) * 100) + txtGateS16.Text, "###0")
                txtGateW17.Text = Format(((DataArr(16, 5) / DataArr(16, 2)) * 100) + txtGateS17.Text, "###0")
            End If

            txtThresh1.Text = Format(CSng(DataArr(0, 6)) / ymaxS, "#0")
            txtThresh2.Text = Format(CSng(DataArr(1, 6)) / ymaxS, "#0")
            txtThresh3.Text = Format(CSng(DataArr(2, 6)) / ymaxS, "#0")
            txtThresh4.Text = Format(CSng(DataArr(3, 6)) / ymaxS, "#0")
            txtThresh5.Text = Format(CSng(DataArr(4, 6)) / ymaxS, "#0")
            txtThresh6.Text = Format(CSng(DataArr(5, 6)) / ymaxS, "#0")
            txtThresh7.Text = Format(CSng(DataArr(6, 6)) / ymaxS, "#0")
            txtThresh8.Text = Format(CSng(DataArr(7, 6)) / ymaxS, "#0")
            txtThresh9.Text = Format(CSng(DataArr(8, 6)) / ymaxS, "#0")
            txtThresh10.Text = Format(CSng(DataArr(9, 6)) / ymaxS, "#0")

            If TotNch > 9 Then
                txtThresh11.Text = Format(CSng(DataArr(10, 6)) / ymaxS, "#0")
                txtThresh12.Text = Format(CSng(DataArr(11, 6)) / ymaxS, "#0")
                txtThresh13.Text = Format(CSng(DataArr(12, 6)) / ymaxS, "#0")
                txtThresh14.Text = Format(CSng(DataArr(13, 6)) / ymaxS, "#0")
                txtThresh15.Text = Format(CSng(DataArr(14, 6)) / ymaxS, "#0")
                txtThresh16.Text = Format(CSng(DataArr(15, 6)) / ymaxS, "#0")
                txtThresh17.Text = Format(CSng(DataArr(16, 6)) / ymaxS, "#0")
            End If

            txtG2St1.Text = Format((DataArr(0, 7) / DataArr(0, 2)) * 100, "###0")
            txtG2St2.Text = Format((DataArr(1, 7) / DataArr(1, 2)) * 100, "###0")
            txtG2St3.Text = Format((DataArr(2, 7) / DataArr(2, 2)) * 100, "###0")
            txtG2St4.Text = Format((DataArr(3, 7) / DataArr(3, 2)) * 100, "###0")
            txtG2St5.Text = Format((DataArr(4, 7) / DataArr(4, 2)) * 100, "###0")
            txtG2St6.Text = Format((DataArr(5, 7) / DataArr(5, 2)) * 100, "###0")
            txtG2St7.Text = Format((DataArr(6, 7) / DataArr(6, 2)) * 100, "###0")
            txtG2St8.Text = Format((DataArr(7, 7) / DataArr(7, 2)) * 100, "###0")
            txtG2St9.Text = Format((DataArr(8, 7) / DataArr(8, 2)) * 100, "###0")
            txtG2St10.Text = Format((DataArr(9, 7) / DataArr(9, 2)) * 100, "###0")

            If TotNch > 9 Then

                txtG2St11.Text = Format((DataArr(10, 7) / DataArr(10, 2)) * 100, "###0")
                txtG2St12.Text = Format((DataArr(11, 7) / DataArr(11, 2)) * 100, "###0")
                txtG2St13.Text = Format((DataArr(12, 7) / DataArr(12, 2)) * 100, "###0")
                txtG2St14.Text = Format((DataArr(13, 7) / DataArr(13, 2)) * 100, "###0")
                txtG2St15.Text = Format((DataArr(14, 7) / DataArr(14, 2)) * 100, "###0")
                txtG2St16.Text = Format((DataArr(15, 7) / DataArr(15, 2)) * 100, "###0")
                txtG2St17.Text = Format((DataArr(16, 7) / DataArr(16, 2)) * 100, "###0")
            End If

            'G2WD
            txtG2Wd1.Text = Format(((DataArr(0, 8) / DataArr(0, 2)) * 100) + txtG2St1.Text, "###0")
            txtG2Wd2.Text = Format(((DataArr(1, 8) / DataArr(1, 2)) * 100) + txtG2St2.Text, "###0")
            txtG2Wd3.Text = Format(((DataArr(2, 8) / DataArr(2, 2)) * 100) + txtG2St3.Text, "###0")
            txtG2Wd4.Text = Format(((DataArr(3, 8) / DataArr(3, 2)) * 100) + txtG2St4.Text, "###0")
            txtG2Wd5.Text = Format(((DataArr(4, 8) / DataArr(4, 2)) * 100) + txtG2St5.Text, "###0")
            txtG2Wd6.Text = Format(((DataArr(5, 8) / DataArr(5, 2)) * 100) + txtG2St6.Text, "###0")
            txtG2Wd7.Text = Format(((DataArr(6, 8) / DataArr(6, 2)) * 100) + txtG2St7.Text, "###0")
            txtG2Wd8.Text = Format(((DataArr(7, 8) / DataArr(7, 2)) * 100) + txtG2St8.Text, "###0")
            txtG2Wd9.Text = Format(((DataArr(8, 8) / DataArr(8, 2)) * 100) + txtG2St9.Text, "###0")
            txtG2Wd10.Text = Format(((DataArr(9, 8) / DataArr(9, 2)) * 100) + txtG2St10.Text, "###0")

            If TotNch > 9 Then
                txtG2Wd11.Text = Format(((DataArr(10, 8) / DataArr(10, 2)) * 100) + txtG2St11.Text, "###0")
                txtG2Wd12.Text = Format(((DataArr(11, 8) / DataArr(11, 2)) * 100) + txtG2St12.Text, "###0")
                txtG2Wd13.Text = Format(((DataArr(12, 8) / DataArr(12, 2)) * 100) + txtG2St13.Text, "###0")
                txtG2Wd14.Text = Format(((DataArr(13, 8) / DataArr(13, 2)) * 100) + txtG2St14.Text, "###0")
                txtG2Wd15.Text = Format(((DataArr(14, 8) / DataArr(14, 2)) * 100) + txtG2St15.Text, "###0")
                txtG2Wd16.Text = Format(((DataArr(15, 8) / DataArr(15, 2)) * 100) + txtG2St16.Text, "###0")
                txtG2Wd17.Text = Format(((DataArr(16, 8) / DataArr(16, 2)) * 100) + txtG2St17.Text, "###0")
            End If

            txtThr21.Text = Format(CSng(DataArr(0, 9)) / ymaxS, "#0")
            txtThr22.Text = Format(CSng(DataArr(1, 9)) / ymaxS, "#0")
            txtThr23.Text = Format(CSng(DataArr(2, 9)) / ymaxS, "#0")
            txtThr24.Text = Format(CSng(DataArr(3, 9)) / ymaxS, "#0")
            txtThr25.Text = Format(CSng(DataArr(4, 9)) / ymaxS, "#0")
            txtThr26.Text = Format(CSng(DataArr(5, 9)) / ymaxS, "#0")
            txtThr27.Text = Format(CSng(DataArr(6, 9)) / ymaxS, "#0")
            txtThr28.Text = Format(CSng(DataArr(7, 9)) / ymaxS, "#0")
            txtThr29.Text = Format(CSng(DataArr(8, 9)) / ymaxS, "#0")
            txtThr210.Text = Format(CSng(DataArr(9, 9)) / ymaxS, "#0")

            If TotNch > 9 Then
                txtThr211.Text = Format(CSng(DataArr(10, 9)) / ymaxS, "#0")
                txtThr212.Text = Format(CSng(DataArr(11, 9)) / ymaxS, "#0")
                txtThr213.Text = Format(CSng(DataArr(12, 9)) / ymaxS, "#0")
                txtThr214.Text = Format(CSng(DataArr(13, 9)) / ymaxS, "#0")
                txtThr215.Text = Format(CSng(DataArr(14, 9)) / ymaxS, "#0")
                txtThr216.Text = Format(CSng(DataArr(15, 9)) / ymaxS, "#0")
                txtThr217.Text = Format(CSng(DataArr(16, 9)) / ymaxS, "#0")
            End If

            Dim wav As Integer, ang As Single
            GetWaveAng(0, wav, ang) : txtAng1.Text = Format(ang, "0.0")
            GetWaveAng(1, wav, ang) : txtAng2.Text = Format(ang, "0.0")
            GetWaveAng(2, wav, ang) : txtAng3.Text = Format(ang, "0.0")
            GetWaveAng(3, wav, ang) : txtAng4.Text = Format(ang, "0.0")
            GetWaveAng(4, wav, ang) : txtAng5.Text = Format(ang, "0.0")
            GetWaveAng(5, wav, ang) : txtAng6.Text = Format(ang, "0.0")
            GetWaveAng(6, wav, ang) : txtAng7.Text = Format(ang, "0.0")
            GetWaveAng(7, wav, ang) : txtAng8.Text = Format(ang, "0.0")
            GetWaveAng(8, wav, ang) : txtAng9.Text = Format(ang, "0.0")
            GetWaveAng(9, wav, ang) : txtAng10.Text = Format(ang, "0.0")

            If TotNch > 9 Then
                GetWaveAng(10, wav, ang) : txtAng11.Text = Format(ang, "0.0")
                GetWaveAng(11, wav, ang) : txtAng12.Text = Format(ang, "0.0")
                GetWaveAng(12, wav, ang) : txtAng13.Text = Format(ang, "0.0")
                GetWaveAng(13, wav, ang) : txtAng14.Text = Format(ang, "0.0")
                GetWaveAng(14, wav, ang) : txtAng15.Text = Format(ang, "0.0")
                GetWaveAng(15, wav, ang) : txtAng16.Text = Format(ang, "0.0")
                GetWaveAng(16, wav, ang) : txtAng17.Text = Format(ang, "0.0")
            End If


            'fnFetch10ChDataArrayValue()

            'Dim strCalsetNo As String = ""

            'If ListBox1.SelectedItem.ToString.Trim > 0 Then
            '    strCalsetNo = ListBox1.SelectedItem.ToString.Trim
            'End If

            'Dim intCSN As Integer = Convert.ToInt32(strCalsetNo) - 1

            'Dim strWav As String = ""
            'Dim intRange As Integer = 0
            'Dim ang10 As Single

            'ang10 = (Convert.ToInt32(CalsetDataArr10(intCSN, 12)) \ 256) / 10

            'If ang10 = 0 Then
            '    strWav = "1"
            'ElseIf ang10 > 30 Then
            '    strWav = "2"
            'End If

            'If strWav = "1" Then
            '    intRange = Format(CalsetDataArr10(intCSN, 1) * ml2mm1, "0")
            'ElseIf strWav = "2" Then
            '    intRange = Format(CalsetDataArr10(intCSN, 1) * ml2mm2, "0")
            'End If

            'txtGain10.Text = Format(CSng(CalsetDataArr10(intCSN, 11)) / 2.0, "##0.0")
            'txtDelay10.Text = Format((CalsetDataArr10(intCSN, 2) * 0.2941), "###0")
            'txtRange10.Text = intRange
            'txtReject10.Text = Format(CSng(CalsetDataArr10(intCSN, 3)) / ymaxS, "#0")
            'txtGateS10.Text = Format((CalsetDataArr10(intCSN, 4) / CalsetDataArr10(intCSN, 1)) * 100, "###0")
            'txtGateW10.Text = Format(((CalsetDataArr10(intCSN, 5) / CalsetDataArr10(intCSN, 1)) * 100) + txtGateS10.Text, "###0")
            'txtThresh10.Text = Format(CSng(CalsetDataArr10(intCSN, 6)) / ymaxS, "#0")
            'txtG2St10.Text = Format((CalsetDataArr10(intCSN, 7) / CalsetDataArr10(intCSN, 1)) * 100, "###0")
            'txtG2Wd10.Text = Format(((CalsetDataArr10(intCSN, 8) / CalsetDataArr10(intCSN, 1)) * 100) + txtG2St10.Text, "###0")
            'txtThr210.Text = Format(CSng(CalsetDataArr10(intCSN, 9)) / ymaxS, "#0")
            'txtAng10.Text = Format(ang10, "0.0")
        Catch ex As Exception
            'MessageBox.Show(ex.ToString, "ex.ToString")
        End Try
    End Sub

    Public Sub StoreVals()
        Try

            Dim minreject As Integer = 0, minthreshold As Integer = 5, mingate = 3, minrange As Integer = 50

            If txtReject1.Text < 0 Then
                txtReject1.Text = minreject
            ElseIf txtReject2.Text < 0 Then
                txtReject2.Text = minreject
            ElseIf txtReject3.Text < 0 Then
                txtReject3.Text = minreject
            ElseIf txtReject4.Text < 0 Then
                txtReject4.Text = minreject
            ElseIf txtReject5.Text < 0 Then
                txtReject5.Text = minreject
            ElseIf txtReject6.Text < 0 Then
                txtReject6.Text = minreject
            ElseIf txtReject7.Text < 0 Then
                txtReject7.Text = minreject
            ElseIf txtReject8.Text < 0 Then
                txtReject8.Text = minreject
            ElseIf txtReject9.Text < 0 Then
                txtReject9.Text = minreject
            ElseIf txtReject10.Text < 0 Then
                txtReject10.Text = minreject
            End If

            'threshold1
            If txtThresh1.Text < minthreshold Then
                txtThresh1.Text = minthreshold
            ElseIf txtThresh2.Text < minthreshold Then
                txtThresh2.Text = minthreshold
            ElseIf txtThresh3.Text < minthreshold Then
                txtThresh3.Text = minthreshold
            ElseIf txtThresh4.Text < minthreshold Then
                txtThresh4.Text = minthreshold
            ElseIf txtThresh5.Text < minthreshold Then
                txtThresh5.Text = minthreshold
            ElseIf txtThresh6.Text < minthreshold Then
                txtThresh6.Text = minthreshold
            ElseIf txtThresh7.Text < minthreshold Then
                txtThresh7.Text = minthreshold
            ElseIf txtThresh8.Text < minthreshold Then
                txtThresh8.Text = minthreshold
            ElseIf txtThresh9.Text < minthreshold Then
                txtThresh9.Text = minthreshold
            ElseIf txtThresh10.Text < minthreshold Then
                txtThresh10.Text = minthreshold
            End If

            ''threshold 2
            If txtThr21.Text < minthreshold Then
                txtThr21.Text = minthreshold
            ElseIf txtThr22.Text < minthreshold Then
                txtThr22.Text = minthreshold
            ElseIf txtThr23.Text < minthreshold Then
                txtThr23.Text = minthreshold
            ElseIf txtThr24.Text < minthreshold Then
                txtThr24.Text = minthreshold
            ElseIf txtThr25.Text < minthreshold Then
                txtThr25.Text = minthreshold
            ElseIf txtThr26.Text < minthreshold Then
                txtThr26.Text = minthreshold
            ElseIf txtThr27.Text < minthreshold Then
                txtThr27.Text = minthreshold
            ElseIf txtThr28.Text < minthreshold Then
                txtThr28.Text = minthreshold
            ElseIf txtThr29.Text < minthreshold Then
                txtThr29.Text = minthreshold
            ElseIf txtThr210.Text < minthreshold Then
                txtThr210.Text = minthreshold
            End If

            'range
            If txtRange1.Text < minrange Then
                txtRange1.Text = minrange
            ElseIf txtRange2.Text < minrange Then
                tb.Text = minrange
            ElseIf txtRange3.Text < minrange Then
                tb.Text = minrange
            ElseIf txtRange4.Text < minrange Then
                tb.Text = minrange
            ElseIf txtRange5.Text < minrange Then
                tb.Text = maxrange
            ElseIf txtRange6.Text < minrange Then
                tb.Text = maxrange
            ElseIf txtRange7.Text < minrange Then
                tb.Text = minrange
            ElseIf txtRange8.Text < minrange Then
                tb.Text = minrange
            ElseIf txtRange9.Text < minrange Then
                tb.Text = minrange
            ElseIf txtRange10.Text < minrange Then
                tb.Text = minrange
            End If


            'min G1ST
            If txtGateS1.Text < mingate Then
                txtGateS1.Text = mingate
            ElseIf txtGateS2.Text < mingate Then
                txtGateS2.Text = mingate
            ElseIf txtGateS3.Text < mingate Then
                txtGateS3.Text = mingate
            ElseIf txtGateS4.Text < mingate Then
                txtGateS4.Text = mingate
            ElseIf txtGateS5.Text < mingate Then
                txtGateS5.Text = mingate
            ElseIf txtGateS6.Text < mingate Then
                txtGateS6.Text = mingate
            ElseIf txtGateS7.Text < mingate Then
                txtGateS7.Text = mingate
            ElseIf txtGateS8.Text < mingate Then
                txtGateS8.Text = mingate
            ElseIf txtGateS9.Text < mingate Then
                txtGateS9.Text = mingate
            ElseIf txtGateS10.Text < mingate Then
                txtGateS10.Text = mingate
            End If

            'min G1WD
            If txtGateW1.Text < mingate Then
                txtGateW1.Text = mingate
            ElseIf txtGateW2.Text < mingate Then
                txtGateW2.Text = mingate
            ElseIf txtGateW3.Text < mingate Then
                txtGateW3.Text = mingate
            ElseIf txtGateW4.Text < mingate Then
                txtGateW4.Text = mingate
            ElseIf txtGateW5.Text < mingate Then
                txtGateW5.Text = mingate
            ElseIf txtGateW6.Text < mingate Then
                txtGateW6.Text = mingate
            ElseIf txtGateW7.Text < mingate Then
                txtGateW7.Text = mingate
            ElseIf txtGateW8.Text < mingate Then
                txtGateW8.Text = mingate
            ElseIf txtGateW9.Text < mingate Then
                txtGateW9.Text = mingate
            ElseIf txtGateW10.Text < mingate Then
                txtGateW10.Text = mingate
            End If

            'min G2ST
            If txtG2St1.Text < mingate Then
                txtG2St1.Text = mingate
            ElseIf txtG2St2.Text < mingate Then
                txtG2St2.Text = mingate
            ElseIf txtG2St3.Text < mingate Then
                txtG2St3.Text = mingate
            ElseIf txtG2St4.Text < mingate Then
                txtG2St4.Text = mingate
            ElseIf txtG2St5.Text < mingate Then
                txtG2St5.Text = mingate
            ElseIf txtG2St6.Text < mingate Then
                txtG2St6.Text = mingate
            ElseIf txtG2St7.Text < mingate Then
                txtG2St7.Text = mingate
            ElseIf txtG2St8.Text < mingate Then
                txtG2St8.Text = mingate
            ElseIf txtG2St9.Text < mingate Then
                txtG2St9.Text = mingate
            ElseIf txtG2St10.Text < mingate Then
                txtG2St10.Text = mingate
            End If

            'min G2ST
            If txtG2Wd1.Text < mingate Then
                txtG2Wd1.Text = mingate
            ElseIf txtG2Wd2.Text < mingate Then
                txtG2Wd2.Text = mingate
            ElseIf txtG2Wd3.Text < mingate Then
                txtG2Wd3.Text = mingate
            ElseIf txtG2Wd4.Text < mingate Then
                txtG2Wd4.Text = mingate
            ElseIf txtG2Wd5.Text < mingate Then
                txtG2Wd5.Text = mingate
            ElseIf txtG2Wd6.Text < mingate Then
                txtG2Wd6.Text = mingate
            ElseIf txtG2Wd7.Text < mingate Then
                txtG2Wd7.Text = mingate
            ElseIf txtG2Wd8.Text < mingate Then
                txtG2Wd8.Text = mingate
            ElseIf txtG2Wd9.Text < mingate Then
                txtG2Wd9.Text = mingate
            ElseIf txtG2Wd10.Text < mingate Then
                txtG2Wd10.Text = mingate
            End If

            If Not isloaded Then Exit Sub
            ' max ang is 90
            'Angle
            DataArr(0, 10) = Math.Min((CInt(CSng(txtAng1.Text))), 90) * 2560
            DataArr(1, 10) = Math.Min((CInt(CSng(txtAng2.Text))), 90) * 2560
            DataArr(2, 10) = Math.Min((CInt(CSng(txtAng3.Text))), 90) * 2560
            DataArr(3, 10) = Math.Min((CInt(CSng(txtAng4.Text))), 90) * 2560
            DataArr(4, 10) = Math.Min((CInt(CSng(txtAng5.Text))), 90) * 2560
            DataArr(5, 10) = Math.Min((CInt(CSng(txtAng6.Text))), 90) * 2560
            DataArr(6, 10) = Math.Min((CInt(CSng(txtAng7.Text))), 90) * 2560
            DataArr(7, 10) = Math.Min((CInt(CSng(txtAng8.Text))), 90) * 2560
            DataArr(8, 10) = Math.Min((CInt(CSng(txtAng9.Text))), 90) * 2560
            DataArr(9, 10) = Math.Min((CInt(CSng(txtAng10.Text))), 90) * 2560

            If TotNch > 9 Then
                DataArr(10, 10) = Math.Min((CInt(CSng(txtAng11.Text))), 90) * 2560
                DataArr(11, 10) = Math.Min((CInt(CSng(txtAng12.Text))), 90) * 2560
                DataArr(12, 10) = Math.Min((CInt(CSng(txtAng13.Text))), 90) * 2560
                DataArr(13, 10) = Math.Min((CInt(CSng(txtAng14.Text))), 90) * 2560
                DataArr(14, 10) = Math.Min((CInt(CSng(txtAng15.Text))), 90) * 2560
                DataArr(15, 10) = Math.Min((CInt(CSng(txtAng16.Text))), 90) * 2560
                DataArr(16, 10) = Math.Min((CInt(CSng(txtAng17.Text))), 90) * 2560
            End If

            'Gain max is 80
            If txtGain1.Text > maxgain Then
                txtGain1.Text = maxgain
            ElseIf txtGain2.Text > maxgain Then
                txtGain2.Text = maxgain
            ElseIf txtGain3.Text > maxgain Then
                txtGain3.Text = maxgain
            ElseIf txtGain4.Text > maxgain Then
                txtGain4.Text = maxgain
            ElseIf txtGain5.Text > maxgain Then
                txtGain5.Text = maxgain
            ElseIf txtGain6.Text > maxgain Then
                txtGain6.Text = maxgain
            ElseIf txtGain7.Text > maxgain Then
                txtGain7.Text = maxgain
            ElseIf txtGain8.Text > maxgain Then
                txtGain8.Text = maxgain
            ElseIf txtGain9.Text > maxgain Then
                txtGain9.Text = maxgain
            ElseIf txtGain10.Text > maxgain Then
                txtGain10.Text = maxgain
            End If

            'Gain
            DataArr(0, 0) = Math.Min((CSng(txtGain1.Text)), 80) * 2.0
            DataArr(1, 0) = Math.Min((CSng(txtGain2.Text)), 80) * 2.0
            DataArr(2, 0) = Math.Min((CSng(txtGain3.Text)), 80) * 2.0
            DataArr(3, 0) = Math.Min((CSng(txtGain4.Text)), 80) * 2.0
            DataArr(4, 0) = Math.Min((CSng(txtGain5.Text)), 80) * 2.0
            DataArr(5, 0) = Math.Min((CSng(txtGain6.Text)), 80) * 2.0
            DataArr(6, 0) = Math.Min((CSng(txtGain7.Text)), 80) * 2.0
            DataArr(7, 0) = Math.Min((CSng(txtGain8.Text)), 80) * 2.0
            DataArr(8, 0) = Math.Min((CSng(txtGain9.Text)), 80) * 2.0
            DataArr(9, 0) = Math.Min((CSng(txtGain10.Text)), 80) * 2.0
            If TotNch > 9 Then

                DataArr(10, 0) = Math.Min((CSng(txtGain11.Text)), 80) * 2.0
                DataArr(11, 0) = Math.Min((CSng(txtGain12.Text)), 80) * 2.0
                DataArr(12, 0) = Math.Min((CSng(txtGain13.Text)), 80) * 2.0
                DataArr(13, 0) = Math.Min((CSng(txtGain14.Text)), 80) * 2.0
                DataArr(14, 0) = Math.Min((CSng(txtGain15.Text)), 80) * 2.0
                DataArr(15, 0) = Math.Min((CSng(txtGain16.Text)), 80) * 2.0
                DataArr(16, 0) = Math.Min((CSng(txtGain17.Text)), 80) * 2.0
            End If

            ' Delay(max Is 200)

            If txtDelay1.Text > maxdelay Then
                txtDelay1.Text = maxdelay
            ElseIf txtDelay2.Text > maxdelay Then
                txtDelay2.Text = maxdelay
            ElseIf txtDelay3.Text > maxdelay Then
                txtDelay3.Text = maxdelay
            ElseIf txtDelay4.Text > maxdelay Then
                txtDelay4.Text = maxdelay
            ElseIf txtDelay5.Text > maxdelay Then
                txtDelay5.Text = maxdelay
            ElseIf txtDelay6.Text > maxdelay Then
                txtDelay6.Text = maxdelay
            ElseIf txtDelay7.Text > maxdelay Then
                txtDelay7.Text = maxdelay
            ElseIf txtDelay8.Text > maxdelay Then
                txtDelay8.Text = maxdelay
            ElseIf txtDelay9.Text > maxdelay Then
                txtDelay9.Text = maxdelay
            ElseIf txtDelay10.Text > maxdelay Then
                txtDelay10.Text = maxdelay
            End If

            'Dely

            DataArr(0, 1) = Math.Min((CInt(txtDelay1.Text)), 225) / 0.2941
            DataArr(1, 1) = Math.Min((CInt(txtDelay2.Text)), 225) / 0.2941
            DataArr(2, 1) = Math.Min((CInt(txtDelay3.Text)), 225) / 0.2941
            DataArr(3, 1) = Math.Min((CInt(txtDelay4.Text)), 225) / 0.2941
            DataArr(4, 1) = Math.Min((CInt(txtDelay5.Text)), 225) / 0.2941
            DataArr(5, 1) = Math.Min((CInt(txtDelay6.Text)), 225) / 0.2941
            DataArr(6, 1) = Math.Min((CInt(txtDelay7.Text)), 225) / 0.2941
            DataArr(7, 1) = Math.Min((CInt(txtDelay8.Text)), 225) / 0.2941
            DataArr(8, 1) = Math.Min((CInt(txtDelay9.Text)), 225) / 0.2941
            DataArr(9, 1) = Math.Min((CInt(txtDelay10.Text)), 225) / 0.2941

            If TotNch > 9 Then
                DataArr(10, 1) = Math.Min((CInt(txtDelay11.Text)), 225) / 0.2941
                DataArr(11, 1) = Math.Min((CInt(txtDelay12.Text)), 225) / 0.2941
                DataArr(12, 1) = Math.Min((CInt(txtDelay13.Text)), 225) / 0.2941
                DataArr(13, 1) = Math.Min((CInt(txtDelay14.Text)), 225) / 0.2941
                DataArr(14, 1) = Math.Min((CInt(txtDelay15.Text)), 225) / 0.2941
                DataArr(15, 1) = Math.Min((CInt(txtDelay16.Text)), 225) / 0.2941
                DataArr(16, 1) = Math.Min((CInt(txtDelay17.Text)), 225) / 0.2941
            End If


            'max value of range is 700
            If txtRange1.Text > maxrange Then
                txtRange1.Text = maxrange
            ElseIf txtRange2.Text > maxrange Then
                txtRange2.Text = maxrange
            ElseIf txtRange3.Text > maxrange Then
                txtRange3.Text = maxrange
            ElseIf txtRange4.Text > maxrange Then
                txtRange4.Text = maxrange
            ElseIf txtRange5.Text > maxrange Then
                txtRange5.Text = maxrange
            ElseIf txtRange6.Text > maxrange Then
                txtRange6.Text = maxrange
            ElseIf txtRange7.Text > maxrange Then
                txtRange7.Text = maxrange
            ElseIf txtRange8.Text > maxrange Then
                txtRange8.Text = maxrange
            ElseIf txtRange9.Text > maxrange Then
                txtRange9.Text = maxrange
            ElseIf txtRange10.Text > maxrange Then
                txtRange10.Text = maxrange
            End If

            'Range

            DataArr(0, 2) = Rangeml(CInt(txtRange1.Text), 0)
            DataArr(1, 2) = Rangeml(CInt(txtRange2.Text), 1)
            DataArr(2, 2) = Rangeml(CInt(txtRange3.Text), 2)
            DataArr(3, 2) = Rangeml(CInt(txtRange4.Text), 3)
            DataArr(4, 2) = Rangeml(CInt(txtRange5.Text), 4)
            DataArr(5, 2) = Rangeml(CInt(txtRange6.Text), 5)
            DataArr(6, 2) = Rangeml(CInt(txtRange7.Text), 6)
            DataArr(7, 2) = Rangeml(CInt(txtRange8.Text), 7)
            DataArr(8, 2) = Rangeml(CInt(txtRange9.Text), 8)
            DataArr(9, 2) = Rangeml(CInt(txtRange10.Text), 9)

            If TotNch > 9 Then
                DataArr(10, 2) = Rangeml(CInt(txtRange11.Text), 10)
                DataArr(11, 2) = Rangeml(CInt(txtRange12.Text), 11)
                DataArr(12, 2) = Rangeml(CInt(txtRange13.Text), 12)
                DataArr(13, 2) = Rangeml(CInt(txtRange14.Text), 13)
                DataArr(14, 2) = Rangeml(CInt(txtRange15.Text), 14)
                DataArr(15, 2) = Rangeml(CInt(txtRange16.Text), 15)
                DataArr(16, 2) = Rangeml(CInt(txtRange17.Text), 16)
            End If

            'Reject
            DataArr(0, 3) = CSng(txtReject1.Text) * ymaxS
            'channel 2-7
            DataArr(1, 3) = CSng(txtReject2.Text) * ymaxS
            DataArr(2, 3) = CSng(txtReject3.Text) * ymaxS
            DataArr(3, 3) = CSng(txtReject4.Text) * ymaxS
            DataArr(4, 3) = CSng(txtReject5.Text) * ymaxS
            DataArr(5, 3) = CSng(txtReject6.Text) * ymaxS
            DataArr(6, 3) = CSng(txtReject7.Text) * ymaxS
            DataArr(7, 3) = CSng(txtReject8.Text) * ymaxS
            DataArr(8, 3) = CSng(txtReject9.Text) * ymaxS
            DataArr(9, 3) = CSng(txtReject10.Text) * ymaxS

            '04.05.19 G1Start
            DataArr(0, 4) = (Rangeml(CInt(txtRange1.Text), 0) / 100) * Math.Min(CInt(txtGateS1.Text), 99)
            DataArr(1, 4) = (Rangeml(CInt(txtRange2.Text), 1) / 100) * Math.Min(CInt(txtGateS2.Text), 99)
            DataArr(2, 4) = (Rangeml(CInt(txtRange3.Text), 2) / 100) * Math.Min(CInt(txtGateS3.Text), 99)
            DataArr(3, 4) = (Rangeml(CInt(txtRange4.Text), 3) / 100) * Math.Min(CInt(txtGateS4.Text), 99)
            DataArr(4, 4) = (Rangeml(CInt(txtRange5.Text), 4) / 100) * Math.Min(CInt(txtGateS5.Text), 99)
            DataArr(5, 4) = (Rangeml(CInt(txtRange6.Text), 5) / 100) * Math.Min(CInt(txtGateS6.Text), 99)
            DataArr(6, 4) = (Rangeml(CInt(txtRange7.Text), 6) / 100) * Math.Min(CInt(txtGateS7.Text), 99)
            DataArr(7, 4) = (Rangeml(CInt(txtRange8.Text), 7) / 100) * Math.Min(CInt(txtGateS8.Text), 99)
            DataArr(8, 4) = (Rangeml(CInt(txtRange9.Text), 8) / 100) * Math.Min(CInt(txtGateS9.Text), 99)
            DataArr(9, 4) = (Rangeml(CInt(txtRange10.Text), 9) / 100) * Math.Min(CInt(txtGateS10.Text), 99)
            If TotNch > 9 Then
                DataArr(10, 4) = (Rangeml(CInt(txtRange11.Text), 10) / 100) * Math.Min(CInt(txtGateS11.Text), 99)
                DataArr(11, 4) = (Rangeml(CInt(txtRange12.Text), 11) / 100) * Math.Min(CInt(txtGateS12.Text), 99)
                DataArr(12, 4) = (Rangeml(CInt(txtRange13.Text), 12) / 100) * Math.Min(CInt(txtGateS13.Text), 99)
                DataArr(13, 4) = (Rangeml(CInt(txtRange14.Text), 13) / 100) * Math.Min(CInt(txtGateS14.Text), 99)
                DataArr(14, 4) = (Rangeml(CInt(txtRange15.Text), 14) / 100) * Math.Min(CInt(txtGateS15.Text), 99)
                DataArr(15, 4) = (Rangeml(CInt(txtRange16.Text), 15) / 100) * Math.Min(CInt(txtGateS16.Text), 99)
                DataArr(16, 4) = (Rangeml(CInt(txtRange17.Text), 16) / 100) * Math.Min(CInt(txtGateS17.Text), 99)
            End If

            'G1End
            DataArr(0, 5) = (Rangeml(CInt(txtRange1.Text), 0) / 100) * (Math.Min(CInt(txtGateW1.Text), 99) - Math.Min(CInt(txtGateS1.Text), 99))
            DataArr(1, 5) = (Rangeml(CInt(txtRange2.Text), 1) / 100) * (Math.Min(CInt(txtGateW2.Text), 99) - Math.Min(CInt(txtGateS2.Text), 99))
            DataArr(2, 5) = (Rangeml(CInt(txtRange3.Text), 2) / 100) * (Math.Min(CInt(txtGateW3.Text), 99) - Math.Min(CInt(txtGateS3.Text), 99))
            DataArr(3, 5) = (Rangeml(CInt(txtRange4.Text), 3) / 100) * (Math.Min(CInt(txtGateW4.Text), 99) - Math.Min(CInt(txtGateS4.Text), 99))
            DataArr(4, 5) = (Rangeml(CInt(txtRange5.Text), 4) / 100) * (Math.Min(CInt(txtGateW5.Text), 99) - Math.Min(CInt(txtGateS5.Text), 99))
            DataArr(5, 5) = (Rangeml(CInt(txtRange6.Text), 5) / 100) * (Math.Min(CInt(txtGateW6.Text), 99) - Math.Min(CInt(txtGateS6.Text), 99))
            DataArr(6, 5) = (Rangeml(CInt(txtRange7.Text), 6) / 100) * (Math.Min(CInt(txtGateW7.Text), 99) - Math.Min(CInt(txtGateS7.Text), 99))
            DataArr(7, 5) = (Rangeml(CInt(txtRange8.Text), 7) / 100) * (Math.Min(CInt(txtGateW8.Text), 99) - Math.Min(CInt(txtGateS8.Text), 99))
            DataArr(8, 5) = (Rangeml(CInt(txtRange9.Text), 8) / 100) * (Math.Min(CInt(txtGateW9.Text), 99) - Math.Min(CInt(txtGateS9.Text), 99))
            DataArr(9, 5) = (Rangeml(CInt(txtRange10.Text), 9) / 100) * (Math.Min(CInt(txtGateW10.Text), 99) - Math.Min(CInt(txtGateS10.Text), 99))

            If TotNch > 9 Then
                DataArr(10, 5) = (Rangeml(CInt(txtRange11.Text), 10) / 100) * (Math.Min(CInt(txtGateW11.Text), 99) - Math.Min(CInt(txtGateS11.Text), 99))
                DataArr(11, 5) = (Rangeml(CInt(txtRange12.Text), 11) / 100) * (Math.Min(CInt(txtGateW12.Text), 99) - Math.Min(CInt(txtGateS12.Text), 99))
                DataArr(12, 5) = (Rangeml(CInt(txtRange13.Text), 12) / 100) * (Math.Min(CInt(txtGateW13.Text), 99) - Math.Min(CInt(txtGateS13.Text), 99))
                DataArr(13, 5) = (Rangeml(CInt(txtRange14.Text), 13) / 100) * (Math.Min(CInt(txtGateW14.Text), 99) - Math.Min(CInt(txtGateS14.Text), 99))
                DataArr(14, 5) = (Rangeml(CInt(txtRange15.Text), 14) / 100) * (Math.Min(CInt(txtGateW15.Text), 99) - Math.Min(CInt(txtGateS15.Text), 99))
                DataArr(15, 5) = (Rangeml(CInt(txtRange16.Text), 15) / 100) * (Math.Min(CInt(txtGateW16.Text), 99) - Math.Min(CInt(txtGateS16.Text), 99))
                DataArr(16, 5) = (Rangeml(CInt(txtRange17.Text), 16) / 100) * (Math.Min(CInt(txtGateW17.Text), 99) - Math.Min(CInt(txtGateS17.Text), 99))
            End If

            'Threshold 1
            DataArr(0, 6) = CSng(txtThresh1.Text) * ymaxS
            DataArr(1, 6) = CSng(txtThresh2.Text) * ymaxS
            DataArr(2, 6) = CSng(txtThresh3.Text) * ymaxS
            DataArr(3, 6) = CSng(txtThresh4.Text) * ymaxS
            DataArr(4, 6) = CSng(txtThresh5.Text) * ymaxS
            DataArr(5, 6) = CSng(txtThresh6.Text) * ymaxS
            DataArr(6, 6) = CSng(txtThresh7.Text) * ymaxS
            DataArr(7, 6) = CSng(txtThresh8.Text) * ymaxS
            DataArr(8, 6) = CSng(txtThresh9.Text) * ymaxS
            DataArr(9, 6) = CSng(txtThresh10.Text) * ymaxS

            If TotNch > 9 Then
                DataArr(10, 6) = CSng(txtThresh11.Text) * ymaxS
                DataArr(11, 6) = CSng(txtThresh12.Text) * ymaxS
                DataArr(12, 6) = CSng(txtThresh13.Text) * ymaxS
                DataArr(13, 6) = CSng(txtThresh14.Text) * ymaxS
                DataArr(14, 6) = CSng(txtThresh15.Text) * ymaxS
                DataArr(15, 6) = CSng(txtThresh16.Text) * ymaxS
                DataArr(16, 6) = CSng(txtThresh17.Text) * ymaxS
            End If

            '04.05.19 G2Start
            DataArr(0, 7) = (Rangeml(CInt(txtRange1.Text), 0) / 100) * Math.Min(CInt(txtG2St1.Text), 99)
            DataArr(1, 7) = (Rangeml(CInt(txtRange2.Text), 1) / 100) * Math.Min(CInt(txtG2St2.Text), 99)
            DataArr(2, 7) = (Rangeml(CInt(txtRange3.Text), 2) / 100) * Math.Min(CInt(txtG2St3.Text), 99)
            DataArr(3, 7) = (Rangeml(CInt(txtRange4.Text), 3) / 100) * Math.Min(CInt(txtG2St4.Text), 99)
            DataArr(4, 7) = (Rangeml(CInt(txtRange5.Text), 4) / 100) * Math.Min(CInt(txtG2St5.Text), 99)
            DataArr(5, 7) = (Rangeml(CInt(txtRange6.Text), 5) / 100) * Math.Min(CInt(txtG2St6.Text), 99)
            DataArr(6, 7) = (Rangeml(CInt(txtRange7.Text), 6) / 100) * Math.Min(CInt(txtG2St7.Text), 99)
            DataArr(7, 7) = (Rangeml(CInt(txtRange8.Text), 7) / 100) * Math.Min(CInt(txtG2St8.Text), 99)
            DataArr(8, 7) = (Rangeml(CInt(txtRange9.Text), 8) / 100) * Math.Min(CInt(txtG2St9.Text), 99)
            DataArr(9, 7) = (Rangeml(CInt(txtRange10.Text), 9) / 100) * Math.Min(CInt(txtG2St10.Text), 99)

            If TotNch > 9 Then
                DataArr(10, 7) = (Rangeml(CInt(txtRange11.Text), 10) / 100) * Math.Min(CInt(txtG2St11.Text), 99)
                DataArr(11, 7) = (Rangeml(CInt(txtRange12.Text), 11) / 100) * Math.Min(CInt(txtG2St12.Text), 99)
                DataArr(12, 7) = (Rangeml(CInt(txtRange13.Text), 12) / 100) * Math.Min(CInt(txtG2St13.Text), 99)
                DataArr(13, 7) = (Rangeml(CInt(txtRange14.Text), 13) / 100) * Math.Min(CInt(txtG2St14.Text), 99)
                DataArr(14, 7) = (Rangeml(CInt(txtRange15.Text), 14) / 100) * Math.Min(CInt(txtG2St15.Text), 99)
                DataArr(15, 7) = (Rangeml(CInt(txtRange16.Text), 15) / 100) * Math.Min(CInt(txtG2St16.Text), 99)
                DataArr(16, 7) = (Rangeml(CInt(txtRange17.Text), 16) / 100) * Math.Min(CInt(txtG2St17.Text), 99)
            End If

            'G2End

            DataArr(0, 8) = (Rangeml(CInt(txtRange1.Text), 0) / 100) * (Math.Min(CInt(txtG2Wd1.Text), 99) - Math.Min(CInt(txtG2St1.Text), 99))
            DataArr(1, 8) = (Rangeml(CInt(txtRange2.Text), 1) / 100) * (Math.Min(CInt(txtG2Wd2.Text), 99) - Math.Min(CInt(txtG2St2.Text), 99))
            DataArr(2, 8) = (Rangeml(CInt(txtRange3.Text), 2) / 100) * (Math.Min(CInt(txtG2Wd3.Text), 99) - Math.Min(CInt(txtG2St3.Text), 99))
            DataArr(3, 8) = (Rangeml(CInt(txtRange4.Text), 3) / 100) * (Math.Min(CInt(txtG2Wd4.Text), 99) - Math.Min(CInt(txtG2St4.Text), 99))
            DataArr(4, 8) = (Rangeml(CInt(txtRange5.Text), 4) / 100) * (Math.Min(CInt(txtG2Wd5.Text), 99) - Math.Min(CInt(txtG2St5.Text), 99))
            DataArr(5, 8) = (Rangeml(CInt(txtRange6.Text), 5) / 100) * (Math.Min(CInt(txtG2Wd6.Text), 99) - Math.Min(CInt(txtG2St6.Text), 99))
            DataArr(6, 8) = (Rangeml(CInt(txtRange7.Text), 6) / 100) * (Math.Min(CInt(txtG2Wd7.Text), 99) - Math.Min(CInt(txtG2St7.Text), 99))
            DataArr(7, 8) = (Rangeml(CInt(txtRange8.Text), 7) / 100) * (Math.Min(CInt(txtG2Wd8.Text), 99) - Math.Min(CInt(txtG2St8.Text), 99))
            DataArr(8, 8) = (Rangeml(CInt(txtRange9.Text), 8) / 100) * (Math.Min(CInt(txtG2Wd9.Text), 99) - Math.Min(CInt(txtG2St9.Text), 99))
            DataArr(9, 8) = (Rangeml(CInt(txtRange10.Text), 9) / 100) * (Math.Min(CInt(txtG2Wd10.Text), 99) - Math.Min(CInt(txtG2St10.Text), 99))

            If TotNch > 9 Then
                DataArr(10, 8) = (Rangeml(CInt(txtRange11.Text), 10) / 100) * (Math.Min(CInt(txtG2Wd11.Text), 99) - Math.Min(CInt(txtG2St11.Text), 99))
                DataArr(11, 8) = (Rangeml(CInt(txtRange12.Text), 11) / 100) * (Math.Min(CInt(txtG2Wd12.Text), 99) - Math.Min(CInt(txtG2St12.Text), 99))
                DataArr(12, 8) = (Rangeml(CInt(txtRange13.Text), 12) / 100) * (Math.Min(CInt(txtG2Wd13.Text), 99) - Math.Min(CInt(txtG2St13.Text), 99))
                DataArr(13, 8) = (Rangeml(CInt(txtRange14.Text), 13) / 100) * (Math.Min(CInt(txtG2Wd14.Text), 99) - Math.Min(CInt(txtG2St14.Text), 99))
                DataArr(14, 8) = (Rangeml(CInt(txtRange15.Text), 14) / 100) * (Math.Min(CInt(txtG2Wd15.Text), 99) - Math.Min(CInt(txtG2St15.Text), 99))
                DataArr(15, 8) = (Rangeml(CInt(txtRange16.Text), 15) / 100) * (Math.Min(CInt(txtG2Wd16.Text), 99) - Math.Min(CInt(txtG2St16.Text), 99))
                DataArr(16, 8) = (Rangeml(CInt(txtRange17.Text), 16) / 100) * (Math.Min(CInt(txtG2Wd17.Text), 99) - Math.Min(CInt(txtG2St17.Text), 99))
            End If


            'Threshold 2
            DataArr(0, 9) = CSng(txtThr21.Text) * ymaxS
            DataArr(1, 9) = CSng(txtThr22.Text) * ymaxS
            DataArr(2, 9) = CSng(txtThr23.Text) * ymaxS
            DataArr(3, 9) = CSng(txtThr24.Text) * ymaxS
            DataArr(4, 9) = CSng(txtThr25.Text) * ymaxS
            DataArr(5, 9) = CSng(txtThr26.Text) * ymaxS
            DataArr(6, 9) = CSng(txtThr27.Text) * ymaxS
            DataArr(7, 9) = CSng(txtThr28.Text) * ymaxS
            DataArr(8, 9) = CSng(txtThr29.Text) * ymaxS
            DataArr(9, 9) = CSng(txtThr210.Text) * ymaxS
            If TotNch > 9 Then
                DataArr(10, 9) = CSng(txtThr211.Text) * ymaxS
                DataArr(11, 9) = CSng(txtThr212.Text) * ymaxS
                DataArr(12, 9) = CSng(txtThr213.Text) * ymaxS
                DataArr(13, 9) = CSng(txtThr214.Text) * ymaxS
                DataArr(14, 9) = CSng(txtThr215.Text) * ymaxS
                DataArr(15, 9) = CSng(txtThr216.Text) * ymaxS
                DataArr(16, 9) = CSng(txtThr217.Text) * ymaxS
            End If

        Catch ex As Exception
            'MessageBox.Show(ex.ToString, "StoreVals()")
        End Try

    End Sub

    Public Sub SetUpConfig(Optional ByVal ci As Integer = -1, Optional ByVal cj As Integer = -1)
        Try
            objGraphicsFrm.Clear(Color.Black)

            If caltyp = 0 Then
                SetMenu("Open", "Save", "New", "Del", "Edit", "", "Exit")
            Else
                SetMenu("", "", "", "", "", "", "")
            End If

            mnu = 20

            If ci = -1 Then
                curi = 0 : curj = 0
            Else
                curi = ci : curj = cj
            End If

            DispVals() 'Values Display from here with DataArray().
            ShowTextBoxes(True)
            SetTextBox()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DelConfig()
        If File.Exists(AppPath & "\" & ListBox1.SelectedItem & ".cnf") Then
            File.Delete(AppPath & "\" & ListBox1.SelectedItem & ".cnf")
        End If
    End Sub

    Private Sub ViewGraph()
        If curj > TotNpr Then Exit Sub
        objGraphicsFrm.Clear(Color.Black)
        mnu = 25
        caltyp = 10
        caltypS = 2
        curi = 0 : curj = 0
        SetMenu("", "", "", "", "", "", "")
        SetLabels()

    End Sub

    Private Sub EditConfig() 'Edit Config keys
        Dim ii As Integer, jj As Integer
        If curj > TotNpr Then Exit Sub
        objGraphicsFrm.Clear(Color.Black)
        mnu = 25
        If caltyp <> 0 Then Exit Sub
        ii = curi : jj = curj

        Select Case curj
            Case 0                  'gain
                SetMenu("0.5", "1.0", "2.0", "3.0", "6.0", "10.0", "20.0", "Save")
            Case 1                  'delay
                SetMenu("1", "2", "5", "10", "20", "50", "100", "Save")
            Case 2                  'range
                SetMenu("1", "2", "5", "10", "20", "50", "100", "Save")
            Case 3                  'reject
                SetMenu("1", "2", "3", "5", "10", "20", "30", "Save")
            Case 4                  'gatest
                SetMenu("1", "2", "5", "10", "20", "50", "100", "Save")
            Case 5                  'gatewd
                SetMenu("1", "2", "5", "10", "20", "50", "100", "Save")
            Case 6                  'threshold 1
                SetMenu("1", "2", "3", "5", "10", "20", "30", "Save")
            Case 7                  'gatest
                SetMenu("1", "2", "5", "10", "20", "50", "100", "Save")
            Case 8                  'gatewd
                SetMenu("1", "2", "5", "10", "20", "50", "100", "Save")
            Case 10                  'threshold 2
                SetMenu(".1", ".2", ".3", ".5", "1.0", "2.0", "3.0", "Save")
        End Select
        DoEditMenu(MKey1)
    End Sub

    Private Sub SetPlots(Optional ByVal chnl As Integer = -1)
        Try
            Dim i As Integer
            Dim t As Single, t2 As Single
            Dim g As Integer, g2 As Integer
            Dim stp As Single
            Dim strtj As Integer, endj As Integer

            If chnl = -1 Then strtj = 0 : endj = TotNch Else strtj = chnl : endj = chnl

            objGraphicsFrm.Clear(Color.Black)
            objGraphicsB.Clear(Color.FromArgb(10, 10, 10))

            stp = bmp.Height / 10
            t = bmp.Height  

            For i = 0 To 10
                If i = 2 Then
                    objGraphicsB.DrawLine(objBackPen, 0, t + 2, bbmp.Width, t + 2)
                    objGraphicsB.DrawString(Format(i * 10, "0"), objfont, objBrush3, 10, t + 2)
                    t = t - stp
                ElseIf i = 3 Then
                    objGraphicsB.DrawLine(objBackPen, 0, t + 2, bbmp.Width, t + 2)
                    objGraphicsB.DrawString(Format(i * 10, "0"), objfont, objBrush3, 10, t + 2)
                    t = t - stp
                Else
                    objGraphicsB.DrawLine(objBackPen, 0, t, bbmp.Width, t)
                    objGraphicsB.DrawString(Format(i * 10, "0"), objfont, objBrush3, 10, t)
                    t = t - stp
                End If
            Next i

            ' objGraphicsB.DrawLine(objBackPen, 0, bmp.Height - 1, bbmp.Width, bmp.Height - 1)

            For j = strtj To endj
                upt = DataArr(j, 2)
                sx = bmp.Width / upt
                g = DataArr(j, 4)
                g2 = DataArr(j, 7)
                sy = bmp.Height / ymax

                t = bmp.Height - DataArr(j, 6) * sy
                t2 = bmp.Height - DataArr(j, 9) * sy

                objGraphicsB.DrawLine(objPens(j Mod 9), 0, 239 * 1.6, 319 * 1.6, 239 * 1.6) 'varun BASE LINE FOR GRID

                If Convert.ToInt32(DataArr(j, 6)) <= 26 Then
                    'gate 1
                    objGraphicsB.DrawLine(objPens(j Mod 10), sx * g, t, sx * (g + DataArr(j, 5)), t)
                ElseIf Convert.ToInt32(DataArr(j, 6)) <= 51 Then
                    'gate 1
                    objGraphicsB.DrawLine(objPens(j Mod 10), sx * g, t + 2, sx * (g + DataArr(j, 5)), t + 2)
                ElseIf Convert.ToInt32(DataArr(j, 6)) <= 77 Then
                    'gate 1
                    objGraphicsB.DrawLine(objPens(j Mod 10), sx * g, t + 2, sx * (g + DataArr(j, 5)), t + 2)
                Else
                    'gate 1
                    objGraphicsB.DrawLine(objPens(j Mod 10), sx * g, t, sx * (g + DataArr(j, 5)), t)
                End If


                If Convert.ToInt32(DataArr(j, 9)) <= 26 Then
                    'gate 2
                    objGraphicsB.DrawLine(objPens(j Mod 10), sx * g2, t2, sx * (g2 + DataArr(j, 8)), t2)
                ElseIf Convert.ToInt32(DataArr(j, 9)) <= 51 Then
                    'gate 2
                    objGraphicsB.DrawLine(objPens(j Mod 10), sx * g2, t2 + 2, sx * (g2 + DataArr(j, 8)), t2 + 2)
                ElseIf Convert.ToInt32(DataArr(j, 9)) <= 77 Then
                    'gate 2
                    objGraphicsB.DrawLine(objPens(j Mod 9), sx * g2, t2 + 2, sx * (g2 + DataArr(j, 8)), t2 + 2)
                Else
                    'gate 2
                    objGraphicsB.DrawLine(objPens(j Mod 9), sx * g2, t2, sx * (g2 + DataArr(j, 8)), t2)
                End If

            Next j

            For i = 0 To bbmp.Width Step bbmp.Width / 10
                objGraphicsB.DrawLine(objBackPen, i, 0, i, bbmp.Height)
                'objGraphicsB.DrawLine(objBackPen, 320, 0, 320, bbmp.Height)
                objGraphicsB.DrawString(Format(Rangemm(i / sx, chnl), "0"), objfont, objBrush2, i, bbmp.Height - 12)
            Next i

            If caltyp = 1 Then
                i = chnl
                objGraphicsB.DrawString("Gain:" & Format(DataArr(i, 0), "0.0") & " Delay:" & Format(Rangemm(DataArr(i, 1), 0), "###0") & " Range:" & Format(Rangemm(DataArr(i, 2), 0), "###0") & " Reject:" & Format(CSng(DataArr(i, 3)) / ymaxS, "#0"), objfont, objBrush2, 40, 0)
            End If

            ReDim pt0(bmp.Width - 1)
            For i = 0 To bmp.Width - 1
                pt0(i).X = i
            Next i

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Exception")
        End Try
    End Sub

    Private Sub SetPlotsData(Optional ByVal chnl As Integer = -1)
        Try
            Dim i As Integer
            Dim t As Single, t2 As Single
            Dim g As Integer, g2 As Integer
            Dim stp As Single
            Dim strtj As Integer, endj As Integer

            If chnl = -1 Then strtj = 0 : endj = TotNch Else strtj = chnl : endj = chnl
            objGraphicsFrm.Clear(Color.White)
            objGraphicsB.Clear(Color.White)


            stp = bmp.Height / 10
            t = bmp.Height                        '- 1
            t2 = bmp.Height
            For i = 0 To 10
                objGraphicsB.DrawLine(objBackPen, 0, t, bbmp.Width, t)
                objGraphicsB.DrawString(Format(i * 10, "0"), objfont, objBrush, 10, t)
                objGraphicsB.DrawLine(objBackPen, 0, t2, bbmp.Width, t2)
                objGraphicsB.DrawString(Format(i * 10, "0"), objfont, objBrush, 10, t2)
                t = t - stp
                t2 = t2 - stp
            Next i
            objGraphicsB.DrawLine(objBackPen, 0, bmp.Height - 1, bbmp.Width, bmp.Height - 1)

            For j = strtj To endj
                upt = DataArr(j, 2)
                sx = bmp.Width / upt
                g = DataArr(j, 4)
                t = bbmp.Height - DataArr(j, 6) '* sy
                objGraphicsB.DrawLine(objBackPen, sx * g, t, sx * (g + DataArr(j, 5)), t)
                g2 = DataArr(j, 7)
                t2 = bbmp.Height - DataArr(j, 9) '* sy
                objGraphicsB.DrawLine(objBackPen, sx * g2, t2, sx * (g2 + DataArr(j, 8)), t2)
            Next j
            For i = bbmp.Width / 10 To bbmp.Width Step bbmp.Width / 10
                objGraphicsB.DrawLine(objBackPen, i, 20, i, bbmp.Height - 20)
                objGraphicsB.DrawString(Format(Rangemm(i / sx, chnl), "0"), objfont, objBrush, i, bbmp.Height - 12)
            Next i

            i = chnl
            objGraphicsB.DrawString("Gain:" & Format(DataArr(i, 0), "0.0") & " Delay:" & Format(Rangemm(DataArr(i, 1), 0), "###0") & " Range:" & Format(Rangemm(DataArr(i, 2), 0), "###0") & " Reject:" & Format(CSng(DataArr(i, 3)) / ymaxS, "#0"), objfont, objBrush, 40, 0)

            ReDim pt0(upt)
            For i = 0 To upt
                pt0(i).X = i
            Next i
        Catch ex As Exception

        End Try

    End Sub
    Private Sub AcquireFreezeEnv(ByVal j As Integer)

        Try
            Dim i As Integer, ii As Integer
            Const kmax = 5
            Dim x As Byte
            Dim vi As Integer
            Dim j1 As Integer = IIf(j > 6, j + 1, j)
            Dim hADRDriver As Integer = CreateFile("ADR1:", GENERIC_READ Or GENERIC_WRITE, 0, 0, OPEN_EXISTING, 0, 0)
            isstopped = False
            StoreVals()
            Dim upt As Integer
            Dim r As Integer
            Module1.ReadData()

            If curi = 9 Then
                upt = DataArr10(0, 2)
                r = CInt(DataArr10(0, 3) * RJTMULT)
            Else
                upt = DataArr(j, 2)
                r = CInt(DataArr(j, 3) * RJTMULT)
            End If

            Dim Lm As Integer = 20, Tm As Integer = 10
            Dim Bm As Integer = Me.Height - 20, Rm As Integer = Me.Width - 20
            Dim Sx As Single '= (Rm - Lm) / upt
            Dim Sy As Single '= (Tm - Bm) / ymax

            ReDim pt0(upt)
            ReDim pt1(upt)
            objGraphicsFrm.Clear(Color.Black)
            ii = 0
            For i = Lm To Rm Step (Rm - Lm) / 10
                objGraphicsFrm.DrawLine(objBackPen, i, Tm, i, Bm)
                objGraphicsFrm.DrawString(Format(ii), objfont, objBrush2, i, Bm)
                ii += 1
            Next i
            Dim k As Integer = 100
            For i = 0 To 10
                Dim yy As Single = Tm + CSng(i * (Bm - Tm)) / 10.0
                objGraphicsFrm.DrawLine(objBackPen, Lm, yy, Rm, yy)
                objGraphicsFrm.DrawString(Format(k, "0"), objfont, objBrush3, 25, yy)
                k -= 10
            Next i
            If curi = 9 Then
                upt = DataArr10(0, 2)
            Else
                upt = DataArr(j, 2)
            End If
            Sx = (Rm - Lm) / upt
            Sy = (Tm - Bm) / ymax

            For i = 0 To upt
                pt0(i).X = i
                pt1(i).X = i * Sx + Lm
                pt0(i).Y = 0
            Next i
            pt1(0).Y = Bm
            pt1(upt).Y = Bm

            Dim t As Single
            Dim t2 As Single

            If curi = 9 Then
                t = Bm - DataArr10(0, 6) * Sy
                t2 = Bm - DataArr10(0, 9) * Sy
            Else
                t = Bm - DataArr(j, 6) * Sy
                t2 = Bm - DataArr(j, 9) * Sy
            End If

            If j = 9 Then
                objGraphicsFrm.DrawLine(objPens(0 Mod 10), Sx * DataArr10(0, 4) + Lm, t, Sx * (DataArr10(0, 4) + DataArr10(0, 5)) + Lm, t)  'Gate
                objGraphicsFrm.DrawLine(objPens(0 Mod 10), Sx * DataArr10(0, 7) + Lm, t2, Sx * (DataArr10(0, 7) + DataArr10(0, 8)) + Lm, t2)  'Gate2
            Else
                objGraphicsFrm.DrawLine(objPens(j Mod 10), Sx * DataArr(j, 4) + Lm, t, Sx * (DataArr(j, 4) + DataArr(j, 5)) + Lm, t)  'Gate
                objGraphicsFrm.DrawLine(objPens(j Mod 10), Sx * DataArr(j, 7) + Lm, t2, Sx * (DataArr(j, 7) + DataArr(j, 8)) + Lm, t2)  'Gate2
            End If

            Me.Text = frmcap

           
            If j = 9 Then
                vi = DataArr10(0, 1) + 2048 * j1
            Else
                vi = DataArr(j, 1) + 2048 * j1
            End If

            BLOCKREADINFO(0) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(1) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(2) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(3) = vi
            vi = upt
            BLOCKREADINFO(4) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(5) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(6) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(7) = vi

            BLOCKREADINFO(8) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(9) = (vi Mod 256) : vi \= 256
            
            BLOCKREADINFO(10) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(11) = vi

            Dim imaxmax As Integer = 0
            Dim vmaxmax As Integer = 0
            Dim vmax As Integer = 0
            Dim imax As Integer = 0

#If DEBUG2 Then
            Dim kk As Integer
            Dim kk1 As Integer
            Dim kk2 As Integer
                If j = 9 Then
                  kk = DataArr10(0, 4)
                  kk1 = DataArr10(0, 4) + 50
                  kk2 = DataArr10(0, 4) + 450
                Else
                  kk = DataArr10(0, 4)
                  kk1 = DataArr10(0, 4) + 50
                  kk2 = DataArr10(0, 4) + 450
                End If

                Dim vv As Integer = 10
#ElseIf TORA Then
            Dim kk As Integer
            Dim kk1 As Integer
            Dim kk2 As Integer
            If j = 9 Then
                kk = DataArr10(0, 4)
                kk1 = DataArr10(0, 4) + 50
                kk2 = DataArr10(0, 4) + 450
            Else
                kk = DataArr10(0, 4)
                kk1 = DataArr10(0, 4) + 50
                kk2 = DataArr10(0, 4) + 450
            End If
            Dim vv As Integer = 10
#End If

            k = 0
            Do While True
                If isstop Then
                    Application.DoEvents()
                    keyprocessing = False
                    Me.Text = frmcap & " Stopped"
                    isstopped = True
                    Exit Do
                End If
#If IWAVE Then
                    DeviceIoControl(hADRDriver, ADR_IOCTL_BLOCK_READ_LOWER, BLOCKREADINFO, BLOCKREADINFO.GetUpperBound(0) + 1, BLOCKREADINFO, BLOCKREADINFO.GetUpperBound(0) + 1, 0, 0)
#ElseIf DEBUG2 Then
                    For i = 0 To BLOCKREADINFO.GetUpperBound(0)
                        BLOCKREADINFO(i) = 0
                    Next i
                    If j = 9 Then
                      BLOCKREADINFO(12 + DataArr10(0, 4) + kk) = vv
                    Else
                      BLOCKREADINFO(12 + DataArr(j, 4) + kk) = vv
                    End If
                    If kk > kk1 And kk < kk2 Then
                        vv = vv + 1
                    ElseIf kk > kk2 And kk < upt Then
                        vv = vv - 1
                    End If
                    If vv < 0 Then vv = 0
                    If vv > 230 Then vv = 230
                    lblDisp.Text = Format(kk, "0")
                    kk += 1
                    If kk >= upt Then kk = 0
#ElseIf TORA Then
                For i = 0 To BLOCKREADINFO.GetUpperBound(0)
                    BLOCKREADINFO(i) = 0
                Next i
                BLOCKREADINFO(12 + DataArr(j, 4) + kk) = vv
                If kk > kk1 And kk < kk2 Then
                    vv = vv + 1
                ElseIf kk > kk2 And kk < upt Then
                    vv = vv - 1
                End If
                If vv < 0 Then vv = 0
                If vv > 230 Then vv = 230
                lblDisp.Text = Format(kk, "0")
                kk += 1
                If kk >= upt Then kk = 0
#End If
                For i = 0 To upt - 1 Step 1
                    x = BLOCKREADINFO(12 + i)
                    If x > r Then
                        If pt0(i).Y < x Then pt0(i).Y = x
                        If vmax < x Then
                            vmax = x : imax = i
                        End If
                    End If
                Next i
                k += 1
                If k = Loops Then
                    For i = 1 To upt - 1
                        pt1(i).Y = pt0(i).Y * Sy + Bm
                    Next
                    If j = 9 Then
                        objGraphicsFrm.FillPolygon(objBrushes(0 Mod 10), pt1)
                    Else
                        objGraphicsFrm.FillPolygon(objBrushes(j Mod 10), pt1)
                    End If
                    Application.DoEvents()
                    k = 0
                End If
                keyprocessing = False
            Loop
            frmTest.txtPH.Text = Format(vmax / ymaxS, "0")
            Dim imin1 As Integer = 0
            Dim imin2 As Integer = upt
            For i = imax To 0 Step -1
                If pt0(i).Y = 0 Then
                    For k = i To i - kmax Step -1
                        If k < 0 Then k = i - kmax - 1 : Exit For
                        If pt0(k).Y > 0 Then Exit For
                    Next
                    If k < i - kmax Then imin1 = i : Exit For
                End If
            Next i
            For i = imax To upt Step 1
                If pt0(i).Y = 0 Then
                    For k = i To i + kmax
                        If k > upt Then k = i + kmax + 1 : Exit For
                        If pt0(k).Y > 0 Then Exit For
                    Next
                    If k > i + kmax Then imin2 = i : Exit For
                End If
            Next i

            Dim dd1 As Single = (pt0(imin2).X - Lm) / (Rm - Lm) * 100
            Dim dd2 As Single = (pt0(imin1).X - Lm) / (Rm - Lm) * 100

            Dim dd As Single = dd1 - dd2

            frmTest.txtHM.Text = Format(dd, "0") & "[" & Format(dd2, "0") & "-" & Format(dd1, "0") & "]"

            frmTest.cmbLR.SelectedIndex = IIf(j <= 9, 0, 1)
            frmTest.txtCh.Text = Format(j + 1, "00")
            frmTest.cmbProbe.SelectedIndex = j Mod 10
            CloseHandle(hADRDriver)
        Catch ex As Exception

        End Try

    End Sub
    Private Sub AcquireZoom(ByVal j As Integer)
        Try
            lblPH.Top = Me.Height - lblPH.Height - 20
            lblPH.BackColor = Color.Black
            lblPH.ForeColor = Color.Blue
            lblPH.Visible = True

            Dim i As Integer, i1 As Integer, ii As Integer
            lblZoomL.Visible = True
            lblZoomM.Visible = True
            lblZoomP.Visible = True
            lblZoomR.Visible = True

            Dim x As Byte
            Dim vi As Integer
            Dim j1 As Integer = IIf(j > 6, j + 1, j)
            isstopped = False
            Dim r As Integer
            Dim gs As Integer
            Dim ge As Integer
            Dim gs2 As Integer
            Dim ge2 As Integer
            If curi = 9 Then
                Module1.ReadData()
                upt = DataArr10(0, 2)
                r = CInt(DataArr10(0, 3) * RJTMULT)
                gs = DataArr10(0, 4)              '* sx
                ge = gs + DataArr10(0, 5)         '* sx
                gs2 = DataArr10(0, 7)              '* sx
                ge2 = gs2 + DataArr10(0, 8)         '* sx
            Else
                upt = DataArr(j, 2)
                r = CInt(DataArr(j, 3) * RJTMULT)
                gs = DataArr(j, 4)              '* sx
                ge = gs + DataArr(j, 5)         '* sx
                gs2 = DataArr(j, 7)              '* sx
                ge2 = gs2 + DataArr(j, 8)         '* sx
            End If
            Dim gs1 As Integer, gst2 As Integer
            Dim ge1 As Integer, get2 As Integer


            Dim gwidth As Single = (Me.Width - 40) / ((subrange2 - subrange1) / 100)

            Dim Lm As Integer = 20 - (subrange1 * gwidth) / 100
            Dim Rm As Integer = Lm + gwidth
            Dim Bm As Integer = Me.Height - 20, Tm As Integer = 10
            Dim Sx As Single = (Rm - Lm) / upt
            Dim Sy As Single = (Bm - Tm) / ymax
            Dim ThisPen As Pen = New Pen(colours(j Mod 10), Sx + 2)
            Dim ThisPen2 As Pen = New Pen(colours(j Mod 10), 1)
            Dim rect As Rectangle = New Rectangle(0, 0, mewidth, meheight)
            Dim attr As New Drawing.Imaging.ImageAttributes

            Dim st() As String = lblPH.Tag.ToString.Split(",")
            i = CInt(st(0))
            i1 = lblPH.Width / Sx
            i = Math.Min(upt, Math.Max(-i1, i))
            lblPH.Left = i * Sx + Lm
            gs1 = i
            ge1 = gs1 + i1
            gst2 = i
            get2 = gst2 + i1
            i1 = i1 / 2
            lblPH.Tag = i.ToString & "," & i1.ToString

            ReDim pt0(upt)
            For i = 0 To upt
                pt0(i).X = i * Sx + Lm
                pt0(i).Y = Bm
            Next i

            If curi - 9 Then
                vi = DataArr10(0, 1) + 2048 * j1
            Else
                vi = DataArr(j, 1) + 2048 * j1
            End If
            offset = vi : npoints = upt
            BLOCKREADINFO(0) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(1) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(2) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(3) = vi

            vi = upt
            BLOCKREADINFO(4) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(5) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(6) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(7) = vi
            BLOCKREADINFO(8) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(9) = (vi Mod 256) : vi \= 256
            vi = DataArr(j, 1) + 2048 * j1
            offset = vi : npoints = upt
            BLOCKREADINFO(10) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(11) = vi

            Dim imaxmax As Integer = 0
            Dim vmaxmax As Integer = 0
#If IWAVE Then
        Dim hADRDriver As Integer = CreateFile("ADR1:", GENERIC_READ Or GENERIC_WRITE, 0, 0, OPEN_EXISTING, 0, 0)
#ElseIf DEBUG2 Then
            Dim kk As Integer 
            If curi = 9 Then
               kk = DataArr10(0, 4)
               kk1 = DataArr10(0, 4) + 50
               kk2 = DataArr10(0, 4) + 450
            Else
               kk = DataArr(j, 4)
               kk1 = DataArr(j, 4) + 50
               kk2 = DataArr(j, 4) + 450
            End If
        Dim vv As Integer = 10
#End If
            Dim dst As String = ""
            Dim dst1 As String = ""
            Me.Text = frmcap & dst
            objGraphicsB.Clear(Color.Black)
            ii = 0
            For i = Lm To Rm Step (Rm - Lm) / 10
                objGraphicsB.DrawLine(objBackPen, i, Tm, i, Bm)
                objGraphicsB.DrawString(Format(ii * 10), objfont, objBrush2, i, Bm)
                ii += 1
            Next i
            Dim k As Integer = 100
            For i = 0 To 9
                Dim yy As Single = Tm + CSng(i * (Bm - Tm)) / 10.0
                objGraphicsB.DrawLine(objBackPen, Lm, yy, Rm, yy)
                objGraphicsB.DrawString(Format(k, "0"), objfont, objBrush3, 25, yy)
                k -= 10
            Next i
            Dim t As Single
            Dim t2 As Single
            If curi = 9 Then
                t = Bm - DataArr10(0, 6) * Sy
                t2 = Bm - DataArr10(0, 9) * Sy
                ThisPen2.DashStyle = Drawing2D.DashStyle.Solid
                objGraphicsB.DrawLine(ThisPen2, Sx * DataArr10(0, 4) + Lm, t, Sx * (DataArr10(0, 4) + DataArr10(0, 5)) + Lm, t)  'Gate
                objGraphicsB.DrawLine(ThisPen2, Sx * DataArr10(0, 7) + Lm, t2, Sx * (DataArr10(0, 7) + DataArr10(0, 8)) + Lm, t2)  'Gate
            Else
                t = Bm - DataArr(j, 6) * Sy
                t2 = Bm - DataArr(j, 9) * Sy
                ThisPen2.DashStyle = Drawing2D.DashStyle.Solid
                objGraphicsB.DrawLine(ThisPen2, Sx * DataArr(j, 4) + Lm, t, Sx * (DataArr(j, 4) + DataArr(j, 5)) + Lm, t)  'Gate
                objGraphicsB.DrawLine(ThisPen2, Sx * DataArr(j, 7) + Lm, t2, Sx * (DataArr(j, 7) + DataArr(j, 8)) + Lm, t2)  'Gate
            End If
            t = Bm - r * Sy
            t2 = Bm - r * Sy
            ThisPen2.DashStyle = Drawing2D.DashStyle.Dash
            ThisPen.DashStyle = Drawing2D.DashStyle.Solid
            k = 0
            Do While True
                If isstop Then
                    Application.DoEvents()
                    keyprocessing = False
                    Me.Text = frmcap & " " & (j + 1) & ":" & dst & " Stopped"
                    isstopped = True
                    ThisPen.Dispose()
                    Exit Do
                End If
#If IWAVE Then
            DeviceIoControl(hADRDriver, ADR_IOCTL_BLOCK_READ_LOWER, BLOCKREADINFO, BLOCKREADINFO.GetUpperBound(0) + 1, BLOCKREADINFO, BLOCKREADINFO.GetUpperBound(0) + 1, 0, 0)
#ElseIf DEBUG2 Then
            ToraGetData()
#ElseIf TORA Then
                ToraGetData()
#End If

                Dim vmax As Integer = 0
                Dim imax As Integer = 0
                Dim vmax1 As Integer = 0
                Dim imax1 As Integer = 0
                For i = 1 To upt - 1 Step 1
                    x = BLOCKREADINFO(12 + i)
                    pt0(i).Y = Bm - Sy * x
                    If i >= gs And i <= ge Then
                        If (x > vmax) Then
                            vmax = x
                            imax = i
                        End If
                    End If
                    If i >= gs1 And i <= ge1 Then
                        If (x > vmax1) Then
                            vmax1 = x
                            imax1 = i
                        End If
                    End If
                Next i
                k += 1
                If k Mod dsteps2 = 0 Then
                    objGraphicsFrm.DrawImage(bbmp, rect, 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, attr)
                    objGraphicsFrm.DrawPolygon(ThisPen, pt0)
                End If
                If k Mod dsteps = 0 Then
                    Dim dd As Single = Rangemm(imax, j)
                    Dim dd1 As Single = Rangemm(imax1, j)
                    dst = " PH=" & Format(vmax / ymaxS, "0") & " BP=" & Format(dd, "0")
                    dst1 = "P=" & Format(vmax1 / ymaxS, "0") & " B=" & Format(dd1, "0")
                    If j Mod 10 <> 0 Then
                        Dim wav As Integer, ang As Single
                        GetWaveAng(curi, wav, ang)
                        TH = ang * Math.PI / 180
                        costh = Math.Cos(TH)
                        sinth = Math.Sin(TH)
                        dst = dst & " D=" & Format(dd * costh, "0") & " SD=" & Format(dd * sinth, "0")
                        dst1 = dst1 & " D=" & Format(dd1 * costh, "0") & " SD=" & Format(dd1 * sinth, "0")
                    End If
                    lblPH.Text = dst1
                    Me.Text = frmcap & " " & (j + 1) & ":" & dst

                    Application.DoEvents()
                End If
                keyprocessing = False
            Loop
#If IWAVE Then
        CloseHandle(hADRDriver)
#End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub DrawPolygonPoint(ByVal e As PaintEventArgs)

        ' Create pen. 
        Dim wPen As New Pen(Color.White, 3)

        ' Create points that define polygon. 
        Dim point1 As New Point(50, 50)
        Dim point2 As New Point(100, 25)
        Dim point3 As New Point(200, 5)
        Dim point4 As New Point(250, 50)
        Dim point5 As New Point(300, 100)
        Dim point6 As New Point(350, 200)
        Dim point7 As New Point(250, 250)
        Dim point8 As New Point(350, 200)
        Dim point9 As New Point(300, 250)
        Dim point10 As New Point(200, 100)
        Dim curvePoints As Point() = {point1, point2, point3, point4, _
        point5, point6, point7, point8, point9, point10}

        ' Draw polygon to screen.
        e.Graphics.DrawPolygon(wPen, curvePoints)
    End Sub

    Private Sub AcquireFreezeDrawGrid(ByVal j As Integer) 'Before pressing run prv grid FREEZE BEFORE PRESSING RUN

        Try
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Dim FirstPeek As Integer = 0
            Dim Downflg As Boolean = False
            Dim PeekFlag As Integer = 0
            Dim LastPeek As Integer = 0
            Dim xBP As Integer = 0
            Dim yBP As Integer = 0
            Dim sBP As Integer = 0

            Module1.ReadData()

            If curi = 9 Then

                fngaindata10()

                Dim gate1s As Integer = DataArr10(0, 4)
                Dim gate1w As Integer = gate1s + DataArr10(0, 5)
                Dim gate2s As Integer = DataArr10(0, 7)
                Dim gate2w As Integer = gate2s + DataArr10(0, 8)
            Else
                Dim gate1s As Integer = DArr(curi, 4)
                Dim gate1w As Integer = gate1s + DArr(curi, 5)
                Dim gate2s As Integer = DArr(curi, 7)
                Dim gate2w As Integer = gate2s + DArr(curi, 8)
            End If

            Dim railbmp As Bitmap
            Dim myAsm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()

            Dim i As Integer, i1 As Integer, ii As Integer
            Dim vi As Integer
            Dim j1 As Integer = IIf(j > 6, j + 1, j)
            Dim r As Integer
            Dim gs As Integer
            Dim ge As Integer
            Dim gs2 As Integer
            Dim ge2 As Integer

            If j = 9 Then
                upt = DataArr10(0, 2)
                r = CInt(DataArr10(0, 3) * RJTMULT)
                gs = DataArr10(0, 4)              '* sx
                ge = gs + DataArr10(0, 5)         '* sx
                gs2 = DataArr10(0, 7)              '* sx
                ge2 = gs2 + DataArr10(0, 8)         '* sx
            Else
                upt = DataArr(j, 2)
                r = CInt(DataArr(j, 3) * RJTMULT)
                gs = DataArr(j, 4)              '* sx
                ge = gs + DataArr(j, 5)         '* sx
                gs2 = DataArr(j, 7)              '* sx
                ge2 = gs2 + DataArr(j, 8)         '* sx
            End If

            Dim gs1 As Integer, gst2 As Integer
            Dim ge1 As Integer, get2 As Integer
            Dim gwidth As Single = (Me.Width - 40) / ((subrange2 - subrange1) / 75)

            Dim Lm As Integer = 50 - (subrange1 * gwidth) / 75
            Dim Rm As Integer = Lm + gwidth
            'Dim Bm As Integer = Me.Height - 150, Tm As Integer = 10
            Dim Bm As Integer = Me.Height - 220, Tm As Integer = 10
            Dim Sx As Single = (Rm - Lm) / upt
            Dim Sy As Single = (Bm - Tm) / ymax
            Dim ThisPen As Pen = New Pen(colours(j Mod 10), Sx + 1)
            Dim ThisPen2 As Pen = New Pen(colours(j Mod 10), 1)
            lblPH.Top = 0 : lblPH.Visible = True : lblPH.BackColor = Color.DarkRed
            lblPH.Left = -100
            Dim st() As String = lblPH.Tag.ToString.Split(",")
            i = CInt(st(0))
            i1 = lblPH.Width / Sx
            i = Math.Min(upt, Math.Max(-i1, i))
            gs1 = i
            ge1 = gs1 + i1
            gst2 = i
            get2 = gst2 + i1
            i1 = i1 / 2
            lblPH.Tag = i.ToString & "," & i1.ToString
            SetTextBox()

            ReDim pt0(upt)
            For i = 0 To upt
                pt0(i).X = i * Sx + Lm
                pt0(i).Y = 0
            Next i

            If j = 9 Then
                vi = DataArr10(0, 1) + 2048 * j1
            Else
                vi = DataArr(j, 1) + 2048 * j1
            End If

            offset = vi : npoints = upt
            BLOCKREADINFO(0) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(1) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(2) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(3) = vi

            vi = upt
            BLOCKREADINFO(4) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(5) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(6) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(7) = vi

            BLOCKREADINFO(8) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(9) = (vi Mod 256) : vi \= 256


            If j = 9 Then
                vi = DataArr10(0, 1) + 2048 * j1
            Else
                vi = DataArr(j, 1) + 2048 * j1
            End If

            offset = vi : npoints = upt
            BLOCKREADINFO(10) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(11) = vi

            Dim imaxmax As Integer = 0
            Dim vmaxmax As Integer = 0
#If IWAVE Then
        Dim hADRDriver As Integer = CreateFile("ADR1:", GENERIC_READ Or GENERIC_WRITE, 0, 0, OPEN_EXISTING, 0, 0)
#ElseIf DEBUG2 Then
          If  j = 9 Then
              Dim kk As Integer = DataArr10(0, 4)
              Dim kk1 As Integer = DataArr10(0, 4) + 50
              Dim kk2 As Integer = DataArr10(0, 4) + 450
          else
              Dim kk As Integer = DataArr(j, 4)
              Dim kk1 As Integer = DataArr(j, 4) + 50
              Dim kk2 As Integer = DataArr(j, 4) + 450
End If
        Dim vv As Integer = 10
#End If
            Dim dst As String = ""
            Dim dst1 As String = ""

            Dim whitePen As New Pen(Color.White)
            Dim whiteBrush As New SolidBrush(Color.White)

            Me.Text = frmcap & dst
            objGraphicsFrm.Clear(Color.Black)
            'objGraphicsFrm.FillRectangle(whiteBrush, 500, 0, 329, 480)
            objGraphicsFrm.FillRectangle(whiteBrush, 820, 0, 326, 768)

            ii = 0
            For i = Lm To Rm Step (Rm - Lm) / 10
                objGraphicsFrm.DrawLine(objBackPen, i, Tm, i, Bm)
                objGraphicsFrm.DrawString(Format(ii * 10), objfont, objBrush2, i, Bm)
                ii += 1
            Next i
            objGraphicsFrm.DrawLine(objBackPen, Rm, Tm, Rm, Bm)
            objGraphicsFrm.DrawString(Format(ii * 10), objfont, objBrush2, Rm, Bm)
            Dim k As Integer = 100

            For i = 0 To 10
                Dim yy As Single = Tm + CSng(i * (Bm - Tm)) / 10.0
                objGraphicsFrm.DrawLine(objBackPen, Lm, yy, Rm, yy)
                'objGraphicsFrm.DrawString(Format(k, "0"), objfont, objBrush3, 25, yy)
                objGraphicsFrm.DrawString(Format(k, "0"), objfont, objBrush3, 50, yy)
                k -= 10
            Next i

            Dim t As Single
            Dim t2 As Single

            If j = 9 Then
                t = Bm - DataArr10(0, 6) * Sy
                t2 = Bm - DataArr10(0, 9) * Sy
            Else
                t = Bm - DataArr(j, 6) * Sy
                t2 = Bm - DataArr(j, 9) * Sy
            End If
            ThisPen2.DashStyle = Drawing2D.DashStyle.Solid
            If j = 9 Then
                objGraphicsFrm.DrawLine(ThisPen2, Sx * DataArr10(0, 4) + Lm, t, Sx * (DataArr10(0, 4) + DataArr10(0, 5)) + Lm, t)  'Gate
                objGraphicsFrm.DrawLine(ThisPen2, Sx * DataArr10(0, 7) + Lm, t2, Sx * (DataArr10(0, 7) + DataArr10(0, 8)) + Lm, t2)  'Gate2
            Else
                objGraphicsFrm.DrawLine(ThisPen2, Sx * DataArr(j, 4) + Lm, t, Sx * (DataArr(j, 4) + DataArr(j, 5)) + Lm, t)  'Gate
                objGraphicsFrm.DrawLine(ThisPen2, Sx * DataArr(j, 7) + Lm, t2, Sx * (DataArr(j, 7) + DataArr(j, 8)) + Lm, t2)  'Gate2
            End If
            t = Bm - r * Sy
            t2 = Bm - r * Sy
            ThisPen2.DashStyle = Drawing2D.DashStyle.Dash
            k = 0

            'yyy
            'objGraphicsFrm.DrawLine(whitePen, 0, 355, 800, 355)
            objGraphicsFrm.DrawLine(whitePen, 0, 568, 1000, 568)

            Dim mstr() As String
            Dim mstrl As String

            Dim objSR As StreamReader = New StreamReader("\SD Card\distance.txt")
            Do While Not objSR.EndOfStream
                mstrl = objSR.ReadLine
                mstr = mstrl.Split(",")
            Loop

            objSR.Close()

            railbmp = New Bitmap("\SD Card\rail.bmp")
            'objGraphicsFrm.DrawImage(railbmp, 505, 367)
            objGraphicsFrm.DrawImage(railbmp, 828, 595)
            railbmp.Dispose()
            Dim objBrushtmp As Brush
            objBrushtmp = objBrushBlk

            Dim objfont1 As New Font(FontFamily.GenericSansSerif, 18.0F, FontStyle.Bold)
            'objGraphicsFrm.DrawString("KM : ", objfont1, objBrushtmp, 505, 25)
            objGraphicsFrm.DrawString("KM : ", objfont1, objBrushtmp, 828, 40)
            'objGraphicsFrm.DrawString("   " & mstr(0), objfont1, objBrushtmp, 500, 50)
            objGraphicsFrm.DrawString("   " & mstr(0), objfont1, objBrushtmp, 828, 80)
            'objGraphicsFrm.DrawString("Meter: ", objfont1, objBrushtmp, 505, 100)
            objGraphicsFrm.DrawString("Meter: ", objfont1, objBrushtmp, 828, 160)
            Dim mstr_dec As Decimal
            mstr_dec = Decimal.Parse(mstr(1))
            objGraphicsFrm.DrawString("  " & mstr_dec.ToString("N2"), objfont1, objBrushtmp, 828, 200)
            Application.DoEvents()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub AcquireFreeze(ByVal j As Integer) 'After Pressing run PRV grid
        Try
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Dim FirstPeek As Integer = 0
            Dim Downflg As Boolean = False
            Dim PeekFlag As Integer = 0
            Dim LastPeek As Integer = 0
            Dim Rising As Integer
            Dim xBP As Integer = 0
            Dim yBP As Integer = 0
            Dim sBP As Integer = 0
            Dim PV As Integer
            Dim gate1s As Integer
            Dim gate1w As Integer
            Dim gate2s As Integer
            Dim gate2w As Integer
            Dim angle As Integer

            If j = 9 Then
                Module1.ReadData()
            End If

            If j = 9 Then
                gate1s = DataArr10(0, 4)
                gate1w = gate1s + DataArr10(0, 5)
                gate2s = DataArr10(0, 7)
                gate2w = gate2s + DataArr10(0, 8)
                angle = (Convert.ToInt32(DataArr10(0, 10) \ 256) / 10)
            Else
                gate1s = DArr(curi, 4)
                gate1w = gate1s + DArr(curi, 5)
                gate2s = DArr(curi, 7)
                gate2w = gate2s + DArr(curi, 8)
                angle = (Convert.ToInt32(DataArr(curi, 10) \ 256) / 10)
            End If

            Dim railbmp As Bitmap
            Dim myAsm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()

            Dim i As Integer, i1 As Integer, ii As Integer
            Dim x As Byte
            Dim vi As Integer
            Dim j1 As Integer = IIf(j > 6, j + 1, j)
            Dim r As Integer
            Dim ge As Integer
            Dim gs As Integer
            Dim ge2 As Integer
            Dim gs2 As Integer
            isstopped = False

            If j = 9 Then
                upt = DataArr10(0, 2)
                r = CInt(DataArr10(0, 3) * RJTMULT)
                gs = DataArr10(0, 4)              '* sx
                ge = gs + DataArr10(0, 5)         '* sx
                gs2 = DataArr10(0, 7)              '* sx
                ge2 = gs2 + DataArr10(0, 8)         '* sx
            Else
                upt = DataArr(j, 2)
                r = CInt(DataArr(j, 3) * RJTMULT)
                gs = DataArr(j, 4)              '* sx
                ge = gs + DataArr(j, 5)         '* sx
                gs2 = DataArr(j, 7)              '* sx
                ge2 = gs2 + DataArr(j, 8)         '* sx
            End If

            Dim gs1 As Integer, gst2 As Integer
            Dim ge1 As Integer, get2 As Integer
            Dim gwidth As Single = (Me.Width - 40) / ((subrange2 - subrange1) / 75)

            'Dim Lm As Integer = 20 - (subrange1 * gwidth) / 75
            Dim Lm As Integer = 50 - (subrange1 * gwidth) / 75
            Dim Rm As Integer = Lm + gwidth
            'Dim Bm As Integer = Me.Height - 150, Tm As Integer = 10
            Dim Bm As Integer = Me.Height - 220, Tm As Integer = 10
            Dim Sx As Single = (Rm - Lm) / upt
            Dim Sy As Single = (Bm - Tm) / ymax
            Dim ThisPen As Pen = New Pen(colours(j Mod 10), Sx + 1)
            Dim ThisPen2 As Pen = New Pen(colours(j Mod 10), 1)
            lblPH.Top = 0 : lblPH.Visible = True : lblPH.BackColor = Color.DarkRed
            lblPH.Left = -100
            Dim st() As String = lblPH.Tag.ToString.Split(",")
            i = CInt(st(0))
            i1 = lblPH.Width / Sx
            i = Math.Min(upt, Math.Max(-i1, i))
            gs1 = i
            ge1 = gs1 + i1
            gst2 = i
            get2 = gst2 + i1
            i1 = i1 / 2
            lblPH.Tag = i.ToString & "," & i1.ToString
            SetTextBox()

            ReDim pt0(upt)
            For i = 0 To upt
                pt0(i).X = i * Sx + Lm
                pt0(i).Y = 0
            Next i

            If j = 9 Then
                vi = DataArr10(0, 1) + 2048 * j1
            Else
                vi = DataArr(j, 1) + 2048 * j1
            End If

            offset = vi : npoints = upt
            BLOCKREADINFO(0) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(1) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(2) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(3) = vi

            vi = upt
            BLOCKREADINFO(4) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(5) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(6) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(7) = vi

            BLOCKREADINFO(8) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(9) = (vi Mod 256) : vi \= 256

            If j = 9 Then
                vi = DataArr10(0, 1) + 2048 * j1
            Else
                vi = DataArr(j, 1) + 2048 * j1
            End If

            offset = vi : npoints = upt
            BLOCKREADINFO(10) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(11) = vi

            Dim imaxmax As Integer = 0
            Dim vmaxmax As Integer = 0
            Dim xx As Integer


#If IWAVE Then
        Dim hADRDriver As Integer = CreateFile("ADR1:", GENERIC_READ Or GENERIC_WRITE, 0, 0, OPEN_EXISTING, 0, 0)
#ElseIf DEBUG2 Then


            Dim kk As Integer
            Dim kk1 As Integer
            Dim kk2 As Integer
            If j = 9
               kk = DataArr10(0, 4)
               kk1 = DataArr10(0, 4) + 50
               kk2 = DataArr10(0, 4) + 450
            Else
               kk = DataArr(j, 4)
               kk1 = DataArr(j, 4) + 50
               kk2 = DataArr(j, 4) + 450
            End If
        Dim vv As Integer = 10
#End If


            Dim dst As String = ""
            Dim dst1 As String = ""

            Dim whitePen As New Pen(Color.White)
            Dim whiteBrush As New SolidBrush(Color.White)

            Me.Text = frmcap & dst
            objGraphicsFrm.Clear(Color.Black)
            'objGraphicsFrm.FillRectangle(whiteBrush, 500, 0, 329, 480)
            objGraphicsFrm.FillRectangle(whiteBrush, 820, 0, 526, 768)

            ii = 0
            For i = Lm To Rm Step (Rm - Lm) / 10
                objGraphicsFrm.DrawLine(objBackPen, i, Tm, i, Bm)
                objGraphicsFrm.DrawString(Format(ii * 10), objfont, objBrush2, i, Bm)
                ii += 1
            Next i
            objGraphicsFrm.DrawLine(objBackPen, Rm, Tm, Rm, Bm)
            objGraphicsFrm.DrawString(Format(ii * 10), objfont, objBrush2, Rm, Bm)
            Dim k As Integer = 100
            For i = 0 To 10
                Dim yy As Single = Tm + CSng(i * (Bm - Tm)) / 10.0
                objGraphicsFrm.DrawLine(objBackPen, Lm, yy, Rm, yy)
                'objGraphicsFrm.DrawString(Format(k, "0"), objfont, objBrush3, 25, yy)
                objGraphicsFrm.DrawString(Format(k, "0"), objfont, objBrush3, 50, yy)
                k -= 10
            Next i
            Dim t As Single
            Dim t2 As Single
            If j = 9 Then
                t = Bm - DataArr10(0, 6) * Sy
                t2 = Bm - DataArr10(0, 9) * Sy
            Else
                t = Bm - DataArr(j, 6) * Sy
                t2 = Bm - DataArr(j, 9) * Sy
            End If
            ThisPen2.DashStyle = Drawing2D.DashStyle.Solid
            If j = 9 Then
                objGraphicsFrm.DrawLine(ThisPen2, Sx * DataArr10(0, 4) + Lm, t, Sx * (DataArr10(0, 4) + DataArr10(0, 5)) + Lm, t)  'Gate
                objGraphicsFrm.DrawLine(ThisPen2, Sx * DataArr10(0, 7) + Lm, t2, Sx * (DataArr10(0, 7) + DataArr10(0, 8)) + Lm, t2)  'Gate2
            Else
                objGraphicsFrm.DrawLine(ThisPen2, Sx * DataArr(j, 4) + Lm, t, Sx * (DataArr(j, 4) + DataArr(j, 5)) + Lm, t)  'Gate
                objGraphicsFrm.DrawLine(ThisPen2, Sx * DataArr(j, 7) + Lm, t2, Sx * (DataArr(j, 7) + DataArr(j, 8)) + Lm, t2)  'Gate2
            End If
            t = Bm - r * Sy
            t2 = Bm - r * Sy
            ThisPen2.DashStyle = Drawing2D.DashStyle.Dash
            k = 0
            'objGraphicsFrm.DrawLine(whitePen, 0, 355, 800, 355)
            objGraphicsFrm.DrawLine(whitePen, 0, 568, 1000, 568)

            Dim Move_Dir As Integer
            Dim BScan_data As Double
            Dim ai As Integer
            Dim aj As Integer

            For i = 0 To 56500 - 1
                BSCANBUFF(i) = 0
            Next

            If isstop = False Then
                Dim mstr() As String
                Dim mstrl As String

                Dim objSR As StreamReader = New StreamReader("\SD Card\distance.txt")
                Do While Not objSR.EndOfStream
                    mstrl = objSR.ReadLine
                    mstr = mstrl.Split(",")
                Loop

                objSR.Close()
                railbmp = New Bitmap("\SD Card\rail.bmp")
                'objGraphicsFrm.DrawImage(railbmp, 505, 367)
                objGraphicsFrm.DrawImage(railbmp, 828, 595)
                railbmp.Dispose()
                Dim objBrushtmp As Brush
                objBrushtmp = objBrushBlk
                Dim objfont1 As New Font(FontFamily.GenericSansSerif, 18.0F, FontStyle.Bold)
                objGraphicsFrm.DrawString("KM : ", objfont1, objBrushtmp, 828, 40)
                objGraphicsFrm.DrawString("   " & mstr(0), objfont1, objBrushtmp, 820, 80)
                objGraphicsFrm.DrawString("Meter: ", objfont1, objBrushtmp, 828, 160)
                Dim mstr_dec As Decimal
                mstr_dec = Decimal.Parse(mstr(1))
                objGraphicsFrm.DrawString("  " & mstr_dec.ToString("N2"), objfont1, objBrushtmp, 820, 200)

            End If

            Move_Dir = 1
            Dim Channel_Angle As Double
            Dim x_index1 As Double
            Do While True
                If isstop Then
                    Application.DoEvents()
                    keyprocessing = False
                    Me.Text = frmcap & " Stopped"
                    isstopped = True
                    ThisPen.Dispose()
                    Exit Do
                End If


#If IWAVE Then
            DeviceIoControl(hADRDriver, ADR_IOCTL_BLOCK_READ_LOWER, BLOCKREADINFO, BLOCKREADINFO.GetUpperBound(0) + 1, BLOCKREADINFO, BLOCKREADINFO.GetUpperBound(0) + 1, 0, 0)
#ElseIf DEBUG2 Then
            ToraGetData()
#ElseIf TORA Then
                ToraGetData()
#End If


                Dim vmax As Integer = 0
                Dim imax As Integer = 0
                For i = 0 To upt - 1 Step 1
                    x = BLOCKREADINFO(12 + i)

                    'Find BP
                    If gs < i And i < ge Or gst2 < i And get2 < i Then

                        ' First rising point
                        If (x > 0) And Rising = 0 Then
                            xBP = i
                            Rising = 1
                            PV = x
                        End If

                        If Rising = 1 Then
                            If (PV < x) Then
                                PV = x
                            End If
                        End If

                        ' Reaching Origin
                        If (Rising = 1) And (x = 0) Then
                            If (yBP < PV) Then
                                yBP = PV
                                sBP = xBP

                            End If

                            Rising = 0
                        End If

                    End If
                    If x < r Then x = 0

                    If x > vmax Then
                        vmax = x
                        imax = i
                    End If

                Next i

                If pt0(imax).Y < vmax Then
                    pt0(imax).Y = vmax
                    xx = pt0(imax).X

                    'Ascan
                    If Bm - Sy * vmax < Tm Then
                        objGraphicsFrm.DrawLine(ThisPen, xx, Bm, xx, Tm + 2)
                    Else
                        'plotting the A-Scan Peak From C to VB freeze window.
                        objGraphicsFrm.DrawLine(ThisPen, xx, Bm, xx, Bm - Sy * vmax)
                    End If

                    If vmax > vmaxmax Then
                        vmaxmax = vmax
                        imaxmax = imax
                    End If

#If BSCAN Then
                    ' Store the BSCAN Data
                    BScan_data = (xx - 11) * (100 / 460)

                    If BScan_data < 0 Then

                    End If


                    Dim ch_range As Integer
                    If j = 9 Then
                        Module1.ReadData()
                        ch_range = (Format(Rangemm(DataArr10(0, 2), 0), "0"))
                    Else
                        ch_range = (Format(Rangemm(DataArr(j, 2), j), "0"))
                    End If

                    Dim ti As Integer
                    ti = BScan_data * Channel_Angle
                    If (((ti * 500) + 300) > (500 * 100)) Then

                        ti = 110 - 1
                    End If

                    If angle = 0 Then
                        Channel_Angle = 1
                        'x_index1 = 300
                        x_index1 = 480
                    ElseIf angle = 70 Then
                        If j = 1 Or j = 3 Or j = 5 Or j = 7 Then
                            Channel_Angle = 0.3
                            x_index1 = 480 - (ti * 0.4095)
                        ElseIf j = 2 Or j = 4 Or j = 6 Or j = 8 Then
                            Channel_Angle = 0.3
                            x_index1 = 480 + (ti * 0.4095)
                        End If
                    ElseIf angle = 37 Then
                        If j = 1 Or j = 3 Then
                            Channel_Angle = 1
                            x_index1 = 480 - (ti * 0.4095)
                        ElseIf j = 2 Or j = 4 Then
                            Channel_Angle = 0.8
                            x_index1 = 480 + (ti * 0.2941)
                        End If
                    End If

                    BSCANBUFF((ti * 500) + x_index1) = 22


                    'Plot Graph
                    For ai = 0 To 99 Step 1
                        For aj = 0 To 500 - 1 Step 1

                            If BSCANBUFF((ai * 500) + aj) <> 0 Then
                                If angle = 37 Then
                                    If j = 3 Or j = 4 Or j = 1 Or j = 2 Then
                                        If ch_range = 200 Then
                                            'objGraphicsFrm.DrawLine(ThisPen, aj, 360 + ai, aj + 1, 360 + ai)
                                            objGraphicsFrm.DrawLine(ThisPen, aj, 576 + ai, aj + 1, 576 + ai)
                                        ElseIf ch_range = 275 Then
                                            'objGraphicsFrm.DrawLine(ThisPen, aj, 390 + ai, aj + 1, 390 + ai)
                                            objGraphicsFrm.DrawLine(ThisPen, aj, 624 + ai, aj + 1, 624 + ai)
                                        End If
                                    Else
                                        'objGraphicsFrm.DrawLine(ThisPen, aj, 360 + ai, aj + 1, 360 + ai)
                                        objGraphicsFrm.DrawLine(ThisPen, aj, 576 + ai, aj + 1, 576 + ai)
                                    End If
                                Else
                                    'objGraphicsFrm.DrawLine(ThisPen, aj, 360 + ai, aj + 1, 360 + ai)
                                    objGraphicsFrm.DrawLine(ThisPen, aj, 576 + ai, aj + 1, 576 + ai)
                                End If
                            End If

                        Next
                    Next

                End If



#End If

                k += 1
                If k = dsteps Then
                    dst = " PH=" & Format(vmaxmax / ymaxS, "0")
                    Me.Text = frmcap & dst
                    Application.DoEvents()
                    k = 0
                    '                ReDim v20(upt)
                End If
                keyprocessing = False
            Loop
            frmTest.txtPH.Text = Format(vmaxmax / ymaxS, "0")


            Dim PlFactor As Double

            If angle = 0 Then
                PlFactor = 0.2941
                angle = 0
            ElseIf angle = 70 Then
                If j = 1 Or j = 2 Or j = 3 Or j = 4 Or j = 5 Or j = 6 Or j = 7 Or j = 8 Then
                    PlFactor = 0.161
                    angle = 70
                End If
            ElseIf angle = 37 Then
                If j = 1 Or j = 2 Or j = 3 Or j = 4 Then
                    PlFactor = 0.161
                    angle = 37
                End If
            End If

            Dim bp As Single
            bp = sBP * PlFactor

            frmTest.txtbp.Text = Format(bp, "0")


            Dim wav As Integer ', ang As Double
            If j = 9 Then
                GetWaveAng(9, wav, Channel_Angle)
            Else
                GetWaveAng(j, wav, Channel_Angle)
            End If
            TH = Channel_Angle * Math.PI / 180
            costh = Math.Cos(TH)
            sinth = Math.Sin(TH)

            frmTest.txtheight.Text = Format(bp * sinth, "0")

            frmTest.txtdepth.Text = Format(bp * costh, "0")

            Dim imin1 As Integer = 0
            Dim imin2 As Integer = upt
            For i = imaxmax To 0 Step -1
                If pt0(i).Y < r Then
                    For k = i To i - kmax Step -1
                        If k < 0 Then k = i - kmax - 1 : Exit For
                        If pt0(k).Y >= r Then Exit For
                    Next
                    If k < i - kmax Then imin1 = i : Exit For
                End If
            Next i
            For i = imaxmax To upt Step 1
                If pt0(i).Y < r Then
                    For k = i To i + kmax
                        If k > upt Then k = i + kmax + 1 : Exit For
                        If pt0(k).Y >= r Then Exit For
                    Next
                    If k > i + kmax Then imin2 = i : Exit For
                End If
            Next i

            'HM,BP,D values
            Dim dd1 As Single = (pt0(imin2).X - Lm) / (Rm - Lm) * 100
            Dim dd2 As Single = (pt0(imin1).X - Lm) / (Rm - Lm) * 100
            Dim dd As Single = dd1 - dd2
            frmTest.txtHM.Text = Format(dd, "0") & "[" & Format(dd2, "0") & "-" & Format(dd1, "0") & "]"
            dst = dst & Format(dd, "0") & "[" & Format(dd2, "0") & "-" & Format(dd1, "0") & "]"
            Me.Text = frmcap & dst
            frmTest.cmbLR.SelectedIndex = IIf(j <= 9, 0, 1)
            frmTest.cmbProbe.SelectedIndex = j Mod 10
            frmTest.txtCh.Text = Format(j + 1, "00")
#If IWAVE Then
        CloseHandle(hADRDriver)
#End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Acquire Freeze()")
        End Try
    End Sub

    Public Sub fngaindata10()

        Try
            Dim objSR As StreamReader = New StreamReader(Calset)
            Dim mstr() As String
            Dim mstr1 As String
            mstr1 = objSR.ReadLine
            mstr = mstr1.Split(",")
            objSR.Close()

            Dim starrGain() As String
            Dim objSRGain As StreamReader
            Dim gainFile As String = StorageCard & "gaindata" & mstr(1) & ".txt"
            Dim gainFileCommon As String = StorageCard & "gaindata.txt"
            Dim Data10ChGain As String = ""
            objSRGain = New StreamReader(gainFile)

            If File.Exists(gainFile) Then
                For m = 0 To 10
                    Data10ChGain = objSRGain.ReadLine
                Next
                starrGain = Data10ChGain.Split(",")
            End If

            objSRGain.Close()

            Dim objSR1 As StreamReader = New StreamReader(gainFile)
            Dim strFullText As String = ""
            For i = 0 To 10
                strFullText += objSR1.ReadLine() & "~"
            Next

            Dim arrStr() As String = strFullText.Split("~")

            For i = 0 To arrStr.Length - 1
                Dim arrCalSetNo() As String = arrStr(i).Split(",")
                If arrCalSetNo(0) = "10" Then
                    Dim strTextBoxAng As String = "10," & starrGain(1) & ","
                    arrStr(i) = strTextBoxAng
                End If
            Next

            objSR1.Close()

            Dim objSW As StreamWriter = New StreamWriter(gainFileCommon, False, System.Text.Encoding.ASCII)

            For j = 0 To arrStr.Length - 1
                objSW.WriteLine(arrStr(j))
            Next
            objSW.Close()
            SendGainSet()
        Catch ex As Exception

        End Try
    End Sub
   
    Public Sub AcquireFreezeData(Optional ByVal gtype As Integer = 2) 'Here Freeze Prv is generated. PRV
        Try
            Dim objSR2 As StreamReader = New StreamReader("\SD Card\Model.txt")

            Dim mstrr() As String
            Dim mstrr1 As String

            mstrr1 = objSR2.ReadLine
            mstrr = mstrr1.Split(",")


            Dim objSR1 As StreamReader = New StreamReader("\SD Card\CalSetNum.txt")

            Dim mstr() As String
            Dim mstr1 As String

            mstr1 = objSR1.ReadLine
            mstr = mstr1.Split(",")

            Dim railbmp As Bitmap
            Dim blackpen As New Pen(Color.Black)
            Dim colours() As Color = {Color.White, Color.Yellow, Color.LightCoral, Color.FromArgb(86, 255, 232), Color.LightBlue, Color.FromArgb(255, 153, 255), Color.LightGreen, Color.Orange, Color.FromArgb(189, 209, 90), Color.Black}

            Dim i As Integer, j As Integer
            Dim objBrushtmp As Brush, objBrushGrp As Brush
            If gtype = 1 Then
                objBrushtmp = objBrush3
                objBrushGrp = objBrushes(curi Mod 10)
                objGraphics.Clear(Color.Black)
            Else
                objBrushtmp = objBrushBlk
                objBrushGrp = objBrushBlk
                objGraphics.Clear(Color.White)
            End If
            Module1.ReadData()

            Dim bb(3) As Byte
            Dim st(45) As String
            'Dim objfont As New Font(FontFamily.GenericSansSerif, 7.0F, FontStyle.Regular)
            'Dim objboldfont1 As New Font(FontFamily.GenericSansSerif, 7.0F, FontStyle.Bold)
            Dim objfont As New Font(FontFamily.GenericSansSerif, 11.0F, FontStyle.Regular)
            Dim objboldfont1 As New Font(FontFamily.GenericSansSerif, 11.0F, FontStyle.Bold)


            Dim objFS As FileStream = New FileStream(datafile, FileMode.Open, FileAccess.Read)

            Dim objBR As BinaryReader = New BinaryReader(objFS)

            For i = 0 To st.GetUpperBound(0)
                st(i) = objBR.ReadString
            Next i

            curi = Val(Microsoft.VisualBasic.Right(datafile, 6)) - 1

            If curi = 9 Then
                Module1.ReadData()
                For i = 0 To DataArr10.GetUpperBound(0)
                    For j = 0 To DataArr10.GetUpperBound(1)
                        DataArr10(i, j) = objBR.ReadInt32
                    Next j
                Next i
            Else
                For i = 0 To DataArr.GetUpperBound(0)
                    For j = 0 To DataArr.GetUpperBound(1)
                        DataArr(i, j) = objBR.ReadInt32
                    Next j
                Next i
            End If

            j = curi

            If curi = 9 Then
                upt = (DataArr10(0, 2))
            Else
                upt = DataArr(curi, 2)
            End If

            ReDim pt0(upt)
            Dim pt1(upt) As Point
            Dim vmax As Single = 0

            Try
                For i = 0 To upt - 2
                    pt0(i).X = objBR.ReadInt32
                    pt0(i).Y = objBR.ReadInt32
                    If pt0(i).Y > vmax Then vmax = pt0(i).Y
                Next
            Catch ex As Exception

            End Try

            pt0(0).Y = 0
            pt0(upt).Y = 0
            objBR.Close()
            objFS.Close()

            Dim Lm As Integer = 16 ' 10
            Dim fh As Integer = 22 '14
            Dim lt As Integer = 0

            Dim grp1x As Integer = 16 '10
            Dim grp1y As Integer = 6 '4
            Dim grp2x As Integer = 256 '160
            Dim grp2y As Integer = 6 '4
            Dim grp3x As Integer = 632 '395
            Dim grp3y As Integer = 6 '4
            Dim grp4x As Integer = 632 '395
            Dim grp4y As Integer = 192 '120
            Dim grp5x As Integer = 632 '395
            Dim grp5y As Integer

            lt = 0
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None

            Dim ObjSR As StreamReader = New StreamReader("\SD Card\parameter.txt")
            Dim value() As String
            Dim valuel As String

            valuel = ObjSR.ReadLine()
            value = valuel.Split(",")

            '1st Group
            objGraphics.DrawString("Test Information: ", objfont, objBrushtmp, grp1x, grp1y)

            grp1y += fh
            objGraphics.DrawString("M/C No:PE- " & mstrr(0) & "/" & st(0), objfont, objBrushtmp, grp1x, grp1y)
            grp1y += fh
            objGraphics.DrawString("Division: " & st(5), objfont, objBrushtmp, grp1x, grp1y)
            grp1y += fh
            objGraphics.DrawString("Start Km,M/TP: " & st(7) & " , " & st(8) & " / " & st(9), objfont, objBrushtmp, grp1x, grp1y)
            grp1y += fh
            objGraphics.DrawString("Date: " & st(3), objfont, objBrushtmp, grp1x, grp1y)
            grp1y += (fh + (fh / 2))
            objGraphics.DrawString("Prameter Values", objfont, objBrushtmp, grp1x, grp1y - 15)

            '2nd Group
            Dim fstr As String() = datafile.Split("\")
            objGraphics.DrawString("File:  " & fstr(3) & "  \" & fstr(4) & "\" & fstr(5), objfont, objBrushtmp, grp2x + 32, grp2y) ' 20, grp2y)
            grp2y += fh
            objGraphics.DrawString("OP NAME / Code:  " & st(2), objfont, objBrushtmp, grp2x + 32, grp2y)
            grp2y += fh
            objGraphics.DrawString("Block Section: " & st(6), objfont, objBrushtmp, grp2x + 32, grp2y)
            grp2y += fh
            objGraphics.DrawString("Line: " & st(11), objfont, objBrushtmp, grp2x + 32, grp2y)
            grp2y += fh
            objGraphics.DrawString("Start Time: " & st(4), objfont, objBrushtmp, grp2x + 32, grp2y)
            grp2y += fh

            ' 3rd Group
            objGraphics.DrawString("                     Location  ", objfont, objBrushtmp, grp3x, grp3y)
            grp3y += fh
            'objGraphics.DrawRectangle(blackpen, grp3x + 55, grp3y + 2, 130, 29)
            objGraphics.DrawRectangle(blackpen, grp3x + 88, grp3y + 3, 208, 46)
            'objGraphics.DrawString("     Km   Km   m   ", objboldfont1, objBrushtmp, grp3x + 57, grp3y + 4)
            objGraphics.DrawString("     Km   Km   m   ", objboldfont1, objBrushtmp, grp3x + 91, grp3y + 4)
            'objGraphics.DrawString("     " & st(17) & " -" & st(18), objboldfont1, objBrushtmp, grp3x + 57, grp3y + fh)
            objGraphics.DrawString("     " & st(17) & " -" & st(18), objboldfont1, objBrushtmp, grp3x + 91, grp3y + fh)
            'grp3y += 42
            grp3y += 67
            objGraphics.DrawString("Latitude  ", objfont, objBrushtmp, grp3x, grp3y)
            'objGraphics.DrawString("Longtitude  ", objfont, objBrushtmp, grp3x + 130, grp3y)
            objGraphics.DrawString("Longtitude  ", objfont, objBrushtmp, grp3x + 208, grp3y)
            grp3y += fh

            ' Latitude
            'objGraphics.DrawRectangle(blackpen, grp3x, grp3y, 100, 19)
            objGraphics.DrawRectangle(blackpen, grp3x, grp3y, 160, 31)
            Dim deg() As String, min() As String, secs() As String
            deg = st(39).Split("°")
            min = deg(1).Split("''")
            secs = st(39).Split("'")
            'objGraphics.DrawString(Format(deg(0) + 0, "00") & "°" & " " & Format(min(0) + 0, "00") & "' " & Format(secs(1) + 0, "00.00") & "'' " & "N", objfont, objBrushtmp, grp3x + 4, grp3y + 2)
            objGraphics.DrawString(Format(deg(0) + 0, "00") & "°" & " " & Format(min(0) + 0, "00") & "' " & Format(secs(1) + 0, "00.00") & "'' " & "N", objfont, objBrushtmp, grp3x + 6, grp3y + 3)

            'Longtitude
            'objGraphics.DrawRectangle(blackpen, grp3x + 130, grp3y, 100, 19)
            objGraphics.DrawRectangle(blackpen, grp3x + 208, grp3y, 160, 31)
            Dim deg1() As String, min1() As String, secs1() As String ', dir() As String
            deg1 = st(40).Split("°")
            min1 = deg1(1).Split("''")
            secs1 = st(40).Split("'")
            'objGraphics.DrawString(Format(deg1(0) + 0, "00") & "° " & Format(min1(0) + 0, "00") & "' " & Format(secs1(1) + 0, "00.00") & "'' " & "E", objfont, objBrushtmp, grp3x + 133, grp3y + 2)
            objGraphics.DrawString(Format(deg1(0) + 0, "00") & "° " & Format(min1(0) + 0, "00") & "' " & Format(secs1(1) + 0, "00.00") & "'' " & "E", objfont, objBrushtmp, grp3x + 212, grp3y + 3)


            '4th Group
            Dim objboldfont As New Font(FontFamily.GenericSansSerif, 11.0F, FontStyle.Bold)
            objGraphics.DrawString("Defect Details:  ", objboldfont, objBrushtmp, grp4x, grp4y)
            grp4y += (fh + 2)
            objGraphics.DrawString("Km,M/ Tp : " & Format(st(13) + 0, "0000") & "," & st(14) & " /" & st(15), objboldfont, objBrushtmp, grp4x, grp4y)

            grp4y += fh
            objGraphics.DrawString("Stations:  " & st(19) & "-" & st(20), objfont, objBrushtmp, grp4x, grp4y)
            grp4y += (fh + 2)
            objGraphics.DrawString("Rolling Mark:  " & st(21) & "_" & st(22) & "_" & st(23) & "_" & st(24), objfont, objBrushtmp, grp4x, grp4y)
            grp4y += fh
            objGraphics.DrawString("Rail/Weld No:  " & st(16), objboldfont, objBrushtmp, grp4x, grp4y)
            grp4y += fh
            objGraphics.DrawString("Probe:  " & st(25) & "      " & st(26), objfont, objBrushtmp, grp4x, grp4y)
            grp4y += fh
            grp5y = grp4y

            If (st(27) >= 100) Then
                st(27) = 100
            End If

            objGraphics.DrawString("PH:  " & "", objfont, objBrushtmp, grp5x, grp5y)
            'objGraphics.DrawString("D:  " & "", objfont, objBrushtmp, grp5x + 75, grp5y)
            objGraphics.DrawString("D:  " & "", objfont, objBrushtmp, grp5x + 120, grp5y)

            'objGraphics.DrawString("CalSet:  " & st(1), objfont, objBrushtmp, grp5x + 150, grp5y)
            objGraphics.DrawString("CalSet:  " & st(1), objfont, objBrushtmp, grp5x + 240, grp5y)
            grp5y += (fh + 8)
            objGraphics.DrawString("BP:  " & "", objfont, objBrushtmp, grp5x, grp5y)
            'objGraphics.DrawString("SD:  " & "", objfont, objBrushtmp, grp5x + 75, grp5y)
            objGraphics.DrawString("SD:  " & "", objfont, objBrushtmp, grp5x + 120, grp5y)
            'objGraphics.DrawString("Channel:  " & Format(curi + 1, "00"), objfont, objBrushtmp, grp5x + 150, grp5y)
            objGraphics.DrawString("Channel:  " & Format(curi + 1, "00"), objfont, objBrushtmp, grp5x + 240, grp5y)
            grp5y += (fh + 8)
            'objGraphics.DrawString("Current  ", objfont, objBrushtmp, grp5x + 75, grp5y)
            'objGraphics.DrawString("Previous  ", objfont, objBrushtmp, grp5x + 150, grp5y)
            objGraphics.DrawString("Current  ", objfont, objBrushtmp, grp5x + 120, grp5y)
            objGraphics.DrawString("Previous  ", objfont, objBrushtmp, grp5x + 240, grp5y)
            grp5y += (fh + 8)

            If (st(27) >= 100) Then
                st(27) = 100
            End If

            objGraphics.DrawString("PH  ", objfont, objBrushtmp, grp5x, grp5y)
            'objGraphics.DrawString(st(27), objfont, objBrushtmp, grp5x + 75, grp5y)
            'objGraphics.DrawString(st(34), objfont, objBrushtmp, grp5x + 150, grp5y)
            objGraphics.DrawString(st(27), objfont, objBrushtmp, grp5x + 120, grp5y)
            objGraphics.DrawString(st(34), objfont, objBrushtmp, grp5x + 240, grp5y)
            grp5y += fh
            objGraphics.DrawString("HM  ", objfont, objBrushtmp, grp5x, grp5y)
            'objGraphics.DrawString(st(28), objfont, objBrushtmp, grp5x + 75, grp5y)
            'objGraphics.DrawString(st(35), objfont, objBrushtmp, grp5x + 150, grp5y)
            objGraphics.DrawString(st(28), objfont, objBrushtmp, grp5x + 120, grp5y)
            objGraphics.DrawString(st(35), objfont, objBrushtmp, grp5x + 240, grp5y)
            grp5y += fh

            objGraphics.DrawString("LENGTH:  ", objfont, objBrushtmp, grp5x, grp5y)
            'objGraphics.DrawString(st(31), objfont, objBrushtmp, grp5x + 75, grp5y)
            objGraphics.DrawString(st(31), objfont, objBrushtmp, grp5x + 120, grp5y)
            grp5y += fh
            objGraphics.DrawString("Type  ", objfont, objBrushtmp, grp5x, grp5y)
            'objGraphics.DrawString(st(29), objfont, objBrushtmp, grp5x + 75, grp5y)
            'objGraphics.DrawString(st(36), objfont, objBrushtmp, grp5x + 150, grp5y)
            objGraphics.DrawString(st(29), objfont, objBrushtmp, grp5x + 120, grp5y)
            objGraphics.DrawString(st(36), objfont, objBrushtmp, grp5x + 240, grp5y)
            grp5y += fh
            objGraphics.DrawString("Loc  ", objfont, objBrushtmp, grp5x, grp5y)
            'objGraphics.DrawString(st(30), objfont, objBrushtmp, grp5x + 75, grp5y)
            'objGraphics.DrawString(st(37), objfont, objBrushtmp, grp5x + 150, grp5y)
            objGraphics.DrawString(st(30), objfont, objBrushtmp, grp5x + 120, grp5y)
            objGraphics.DrawString(st(37), objfont, objBrushtmp, grp5x + 240, grp5y)
            grp5y += fh
            objGraphics.DrawString("Class  ", objfont, objBrushtmp, grp5x, grp5y)
            objGraphics.DrawString(st(32), objfont, objBrushtmp, grp5x + 120, grp5y)
            objGraphics.DrawString(st(38), objfont, objBrushtmp, grp5x + 240, grp5y)
            grp5y += fh
            objGraphics.DrawString("Flaw Code  ", objfont, objBrushtmp, grp5x, grp5y)
            objGraphics.DrawString(st(33), objfont, objBrushtmp, grp5x + 120, grp5y)
            objGraphics.DrawString("Jog Plate Provided " & st(44), objfont, objBrushtmp, grp5x + 240, grp5y)

            Dim lt1 As Integer = lt + fh

            lt = 190
            Dim Tm As Integer = lt    ' 110
            Dim Bm As Integer = Tm + 0.52 * Me.Height       '200
            Dim Rm As Integer = Me.Width - 20


            Dim Lm2 As Integer = 10
            Dim Rm2 As Integer = Me.Width - 411

            Dim Sx As Single = (Rm2 - Lm2) / upt
            Dim Sy As Single = (Tm - Bm) / ymax

            Dim r As Integer

            If curi = 9 Then
                r = DataArr10(0, 3)
            Else
                r = DataArr(j, 3)
            End If

            For i = 0 To upt
                pt1(i).X = i * Sx + Lm2
                pt1(i).Y = pt0(i).Y * Sy + Bm
            Next

            Dim ii As Integer = 0

            'reject condition
            Dim reject_eff As Integer
            If j = 0 Then
                reject_eff = Format(CSng(DataArr(j, 3)) / ymaxS, "#0")
            ElseIf j = 9 Then
                reject_eff = Format(CSng(DataArr10(0, 3)) / ymaxS, "#0")
            End If

            If j = 1 Or j = 2 Or j = 3 Or j = 4 Or j = 5 Or j = 6 Or j = 7 Or j = 8 Or j = 10 Then
                reject_eff = Format(CSng(DataArr(j, 3)) / ymaxS, "#0")
            End If

            If curi = 9 Then
                ' 10th channel
                Dim strCurrCalSet As String = mstr(1)
                Dim DataArrCh10(TotNch, TotNpr) As Integer

                Dim Configfile As String = ""
                Dim configData As String = ""
                Configfile = "\SD Card\config10.txt"

                Dim configReader As StreamReader = New StreamReader(Configfile)

                Dim q As Integer = 1
                For q = 1 To st(1)
                    configData = configReader.ReadLine
                Next

                Dim st1() As String = Split(configData, ",")
                For g = 0 To DataArrCh10.GetUpperBound(1)
                    DataArrCh10(0, g) = st1(g)
                Next

                'Gain
                Dim gainfile As String = ""
                Dim gainData As String = ""
                Dim strGain10cch As String = ""
                gainfile = "\SD Card\gaindata" & st(1) & ".txt"

                Dim gainReader As StreamReader = New StreamReader(gainfile)

                For z = 0 To 10
                    gainData = gainReader.ReadLine
                Next

                Dim gndt() As String = Split(gainData, ",")
                strGain10cch = gndt(1)
                ii = (Rm2 - Lm2) / 10
                i = Lm2

                'Gain
                objGraphics.DrawString(Format(strGain10cch / 2.0, "0.0"), objfont, objBrushBlk, i, Tm - 24) '15)
                objGraphics.DrawString(lblGain.Text, objfont, objBrushBlk, i, Tm - 45) '28)
                i = i + ii

                'Delay
                objGraphics.DrawString(Format((DataArrCh10(0, 2) * 0.2941), "0"), objfont, objBrushBlk, i, Tm - 24)
                objGraphics.DrawString(lblDelay.Text, objfont, objBrushBlk, i - 5, Tm - 45)
                i = i + ii

                'range
                Dim intRange As Integer
                Dim strWav As String = ""
                Dim anglefile As String = ""
                Dim angleData As String = ""
                Dim strangle10cch As String = ""
                anglefile = "\SD Card\angdata10.txt"

                Dim angleReader As StreamReader = New StreamReader(anglefile)

                For q = 1 To st(1) '1 - 10 line need to read instead of st1 line no need to pass
                    angleData = angleReader.ReadLine
                Next

                Dim angledt() As String = Split(angleData, ",")
                strangle10cch = angledt(1)
                Dim ang As Single
                ang = (Convert.ToInt32(strangle10cch) \ 256) / 10

                If ang = 0 Then
                    strWav = "1"
                ElseIf ang > 30 Then
                    strWav = "2"
                End If

                If strWav = "1" Then
                    intRange = Format(DataArrCh10(0, 1) * ml2mm1, "0")
                ElseIf strWav = "2" Then
                    intRange = Format(DataArrCh10(0, 1) * ml2mm2, "0")
                End If

                objGraphics.DrawString(intRange, objfont, objBrushtmp, i, Tm - 24)
                objGraphics.DrawString(lblRange.Text, objfont, objBrushBlk, i - 5, Tm - 45)
                i = i + ii

                'reject
                objGraphics.DrawString(Format(CSng(DataArrCh10(0, 3)) / ymaxS, "#0"), objfont, objBrushtmp, i, Tm - 24)
                objGraphics.DrawString(lblReject.Text, objfont, objBrushBlk, i - 5, Tm - 45)
                i = i + ii

                'gate1st 
                Dim dbGate1St As Double
                dbGate1St = Format(((DataArrCh10(0, 4) / DataArrCh10(0, 1))) * 100, "###0")
                objGraphics.DrawString(dbGate1St, objfont, objBrushtmp, i, Tm - 24)
                objGraphics.DrawString(lblGateS.Text, objfont, objBrushBlk, i - 5, Tm - 45)
                i = i + ii

                ' g1wd                
                objGraphics.DrawString(Format(((DataArrCh10(0, 5) / DataArrCh10(0, 1)) * 100) + dbGate1St, "###0"), objfont, objBrushtmp, i, Tm - 24)
                objGraphics.DrawString(lblGateW.Text, objfont, objBrushBlk, i - 5, Tm - 45)
                i = i + ii

                'Threshold1
                objGraphics.DrawString(Format(CSng(DataArrCh10(0, 6)) / ymaxS, "#0"), objfont, objBrushtmp, i + 7, Tm - 24)
                objGraphics.DrawString(lblThresh.Text, objfont, objBrushBlk, i + 7, Tm - 45)
                i = i + ii

                'gate2st 
                Dim dbGate2Start As Double
                dbGate2Start = Format((DataArrCh10(0, 7) / DataArrCh10(0, 1)) * 100, "###0")
                objGraphics.DrawString(dbGate2Start, objfont, objBrushtmp, i, Tm - 24)
                objGraphics.DrawString(lblG2St.Text, objfont, objBrushBlk, i - 6, Tm - 45)
                i = i + ii

                ' g2wd                
                objGraphics.DrawString(Format(((DataArrCh10(0, 8) / DataArrCh10(0, 1)) * 100) + dbGate2Start, "###0"), objfont, objBrushtmp, i, Tm - 24)
                objGraphics.DrawString(lblG2Wd.Text, objfont, objBrushBlk, i - 5, Tm - 45)
                i = i + ii

                'Threshold2
                objGraphics.DrawString(Format(CSng(DataArrCh10(0, 9) / ymaxS), "0"), objfont, objBrushtmp, i + 7, Tm - 24)
                objGraphics.DrawString(lblThr2.Text, objfont, objBrushBlk, i + 7, Tm - 45)
                i = i + ii

                'Angle
                objGraphics.DrawString(Format(ang, "0.0"), objfont, objBrushtmp, i - 3, Tm - 24)
                objGraphics.DrawString(lblAng.Text, objfont, objBrushBlk, i - 6, Tm - 45)

                ii = 0
                For i = Lm2 To Rm2 Step (Rm2 - Lm2) / 10
                    If ii = 0 Then
                        objGraphics.DrawLine(objBackPen, i, Tm, i, 768)
                    Else
                        objGraphics.DrawLine(objBackPen, i, Tm, i, Bm)
                    End If
                    ii += 1
                    If ii <> 11 Then
                        objGraphics.DrawString(Format(ii), objfont, objBrushBlk, i + 40, Bm - 21) ' 25, Bm - 13)
                    End If

                Next i

                ii = 0
                Dim k As Integer = 100
                For i = Tm To Bm Step (Bm - Tm) / 10
                    If ii = 10 Then
                        objGraphics.DrawLine(objBackPen, Lm2, i + 1, 1024, i + 1)
                    Else
                        objGraphics.DrawLine(objBackPen, Lm2, i, Rm2, i)
                    End If
                    ii += 1
                    If ii <> 11 Then
                        objGraphics.DrawString(Format(k, "0"), objfont, objBrushtmp, Lm2 + 5, i + 5)
                    End If
                    k -= 10
                Next i

                For i = 0 To 56500 - 1
                    BSCANBUFF(i) = 0
                Next
                Dim Channel_Angle As Double
                Dim x_index1 As Double
                Dim BScan_data As Double
                Dim X_val As Integer
                Dim ai As Integer
                Dim aj As Integer

                Dim tpen As New Pen(Color.Black)
                If objPens(0).Color <> Color.White Then
                    tpen.Color = objPens(0).Color
                End If

                For i = 0 To upt
                    'AScan
                    If pt1(i).Y < Tm Then
                        'objGraphics.DrawLine(tpen, pt1(i).X, 370, pt1(i).X, Tm + 1)
                        objGraphics.DrawLine(tpen, pt1(i).X, 592, pt1(i).X, Tm + 1)
                    Else
                        'objGraphics.DrawLine(tpen, pt1(i).X, 370, pt1(i).X, pt1(i).Y)
                        objGraphics.DrawLine(tpen, pt1(i).X, 592, pt1(i).X, pt1(i).Y)
                    End If

                    If pt1(i).Y = Bm Then '370 Then
                        Continue For
                    End If

                    Dim angle As Integer = Format(strangle10cch, "0.0")

                    Dim ch_range As Integer = (Format(Rangemm(DataArrCh10(0, 1), 0), "0"))
                    If angle = 45 Then '45 degree plotting
                        If ch_range = 275 Then
                            BScan_data = (pt1(i).X - 10) * (110 / 200)
                        End If
                    ElseIf angle = 37 Then '37 degree plotting
                        If ch_range = 200 Then
                            BScan_data = (pt1(i).X - 10) * (110 / 230)
                        End If
                    Else
                        BScan_data = (pt1(i).X - 10) * (110 / 380)
                    End If

                    X_val = BScan_data * Channel_Angle

                    If (((X_val * 500) + 300) > (500 * 100)) Then
                        X_val = 110 - 1
                    End If
                    BSCANBUFF((X_val * 500) + x_index1) = 22

                    For ai = 0 To 99 Step 1
                        For aj = 0 To 500 - 1 Step 1
                            'considering bscan plot above the reject value
                            If pt0(i).Y > r Then
                                If BSCANBUFF((ai * 500) + aj) <> 0 Then
                                    'objGraphics.DrawLine(tpen, aj, 372 + ai, aj + 1, 372 + ai)
                                    objGraphics.DrawLine(tpen, aj, 596 + ai, aj + 1, 596 + ai)
                                End If
                            End If
                        Next
                    Next
                Next
            Else
                ' 1 to 9 channel
                If curi = 7 Then
                    ii = (Rm2 - Lm2) / 10
                    i = Lm2
                    objGraphics.DrawString(Format(DataArr(8, 0) / 2.0, "0.0"), objfont, objBrushBlk, i, Tm - 24)
                    objGraphics.DrawString(lblGain.Text, objfont, objBrushBlk, i, Tm - 45)
                    i = i + ii
                Else
                    ii = (Rm2 - Lm2) / 10
                    i = Lm2
                    objGraphics.DrawString(Format(DataArr(j, 0) / 2.0, "0.0"), objfont, objBrushBlk, i, Tm - 24)
                    objGraphics.DrawString(lblGain.Text, objfont, objBrushBlk, i, Tm - 45)
                    i = i + ii
                End If

                'Delay
                objGraphics.DrawString(Format((DataArr(j, 1) * 0.2941), "0"), objfont, objBrushBlk, i, Tm - 24)
                objGraphics.DrawString(lblDelay.Text, objfont, objBrushBlk, i - 5, Tm - 45)
                i = i + ii

                'Range
                objGraphics.DrawString(Format(Rangemm(DataArr(j, 2), j), "0"), objfont, objBrushtmp, i, Tm - 24)
                objGraphics.DrawString(lblRange.Text, objfont, objBrushBlk, i - 5, Tm - 45)
                i = i + ii

                'Reject
                objGraphics.DrawString(Format(reject_eff, "0"), objfont, objBrushtmp, i, Tm - 24)
                objGraphics.DrawString(lblReject.Text, objfont, objBrushBlk, i - 5, Tm - 45)
                i = i + ii

                'gate1st 
                objGraphics.DrawString(Format((DataArr(j, 4) / DataArr(j, 2)) * 100, "###0"), objfont, objBrushtmp, i, Tm - 24)
                objGraphics.DrawString(lblGateS.Text, objfont, objBrushBlk, i - 6, Tm - 45)
                i = i + ii

                ' g1wd
                objGraphics.DrawString(Format(((DataArr(j, 5) / DataArr(j, 2)) * 100) + ((DataArr(j, 4) / DataArr(j, 2))) * 100, "###0"), objfont, objBrushtmp, i, Tm - 24)
                objGraphics.DrawString(lblGateW.Text, objfont, objBrushBlk, i - 5, Tm - 45)
                i = i + ii

                'Threshold1
                objGraphics.DrawString(Format(CSng(DataArr(j, 6) / ymaxS), "0"), objfont, objBrushtmp, i + 7, Tm - 24)
                objGraphics.DrawString(lblThresh.Text, objfont, objBrushBlk, i + 7, Tm - 45)
                i = i + ii

                'gate2st 
                objGraphics.DrawString(Format((DataArr(j, 7) / DataArr(j, 2)) * 100, "###0"), objfont, objBrushtmp, i, Tm - 24)
                objGraphics.DrawString(lblG2St.Text, objfont, objBrushBlk, i - 6, Tm - 45)
                i = i + ii

                ' g2wd
                objGraphics.DrawString(Format(((DataArr(j, 8) / DataArr(j, 2)) * 100) + ((DataArr(j, 7) / DataArr(j, 2))) * 100, "###0"), objfont, objBrushtmp, i, Tm - 24)
                objGraphics.DrawString(lblG2Wd.Text, objfont, objBrushBlk, i - 5, Tm - 45)
                i = i + ii

                'Threshold2
                objGraphics.DrawString(Format(CSng(DataArr(j, 9) / ymaxS), "0"), objfont, objBrushtmp, i + 7, Tm - 24)
                objGraphics.DrawString(lblThr2.Text, objfont, objBrushBlk, i + 7, Tm - 45)
                i = i + ii

                Dim wav As Integer, ang As Single
                GetWaveAng(j, wav, ang)
                objGraphics.DrawString(Format(ang, "0.0"), objfont, objBrushtmp, i - 3, Tm - 24)
                objGraphics.DrawString(lblAng.Text, objfont, objBrushBlk, i - 6, Tm - 45)

                ii = 0
                For i = Lm2 To Rm2 Step (Rm2 - Lm2) / 10
                    If ii = 0 Then
                        objGraphics.DrawLine(objBackPen, i, Tm, i, 768)
                    Else
                        objGraphics.DrawLine(objBackPen, i, Tm, i, Bm)
                    End If
                    ii += 1
                    If ii <> 11 Then
                        'objGraphics.DrawString(Format(ii), objfont, objBrushBlk, i + 25, Bm - 13)
                        objGraphics.DrawString(Format(ii), objfont, objBrushBlk, i + 40, Bm - 21)
                    End If

                Next i

                ii = 0
                Dim k As Integer = 100
                For i = Tm To Bm Step (Bm - Tm) / 10
                    If ii = 10 Then
                        objGraphics.DrawLine(objBackPen, Lm2, i + 1, 1024, i + 1)
                    Else
                        objGraphics.DrawLine(objBackPen, Lm2, i, Rm2, i)
                    End If
                    ii += 1
                    If ii <> 11 Then
                        objGraphics.DrawString(Format(k, "0"), objfont, objBrushtmp, Lm2 + 8, i + 8)
                    End If
                    k -= 10
                Next i

                For i = 0 To 56500 - 1
                    BSCANBUFF(i) = 0
                Next
                Dim Channel_Angle As Double
                Dim x_index1 As Double
                Dim BScan_data As Double
                Dim ai As Integer
                Dim aj As Integer

                Dim tpen As New Pen(Color.Black)
                If objPens(j).Color <> Color.White Then
                    tpen.Color = objPens(j).Color
                End If

                For i = 0 To upt
                    If pt1(i).Y < Tm Then
                        'objGraphics.DrawLine(tpen, pt1(i).X, 370, pt1(i).X, Tm + 1)
                        objGraphics.DrawLine(tpen, pt1(i).X, 592, pt1(i).X, Tm + 1)
                    Else
                        'objGraphics.DrawLine(tpen, pt1(i).X, 370, pt1(i).X, pt1(i).Y)
                        objGraphics.DrawLine(tpen, pt1(i).X, 592, pt1(i).X, pt1(i).Y)
                    End If

                    If pt1(i).Y = Bm Then '370 Then
                        Continue For
                    End If

                    'objSW11.Write("pt1(" + i.ToString() + ").X=" & pt1(i).X.ToString() & ",pt1(" + i.ToString() + ").Y=" + pt1(i).Y.ToString() & vbCrLf)

                    Dim angle As Integer = Format(ang, "0.0")

                    Dim ch_range As Integer = (Format(Rangemm(DataArr(j, 2), j), "0"))
                    If angle = 45 Then '45 degree plotting
                        If ch_range = 275 Then
                            BScan_data = (pt1(i).X - 10) * (110 / 200)
                        End If
                    ElseIf angle = 37 Then '37 degree plotting
                        If ch_range = 200 Then
                            BScan_data = (pt1(i).X - 10) * (110 / 230)
                        ElseIf ch_range = 275 Then
                            BScan_data = (pt1(i).X - 10) * (110 / 230)
                        End If
                    Else
                        BScan_data = (pt1(i).X - 10) * (110 / 380)
                    End If


                    Dim ti As Integer
                    ti = BScan_data * Channel_Angle

                    If (((ti * 500) + 300) > (500 * 100)) Then
                        ti = 110 - 1
                    End If


                    If angle = 0 Then
                        Channel_Angle = 1
                        'x_index1 = 300
                        x_index1 = 480
                    ElseIf angle = 70 Then
                        If curi = 1 Or curi = 3 Or curi = 5 Or curi = 7 Then
                            Channel_Angle = 0.3
                            x_index1 = 480 - (ti * 0.4095)
                        ElseIf curi = 2 Or curi = 4 Or curi = 6 Or curi = 8 Then
                            Channel_Angle = 0.3
                            x_index1 = 480 + (ti * 0.2941)
                        End If
                    ElseIf angle = 37 Then
                        If curi = 1 Or curi = 3 Then
                            Channel_Angle = 0.6
                            x_index1 = 480 - (ti * 0.4095)
                        ElseIf curi = 2 Or curi = 4 Then
                            Channel_Angle = 0.6
                            x_index1 = 480 + (ti * 0.4095)
                        End If
                    End If

                    BSCANBUFF((ti * 500) + x_index1) = 22

                    'Plot Graph
                    For ai = 0 To 99 Step 1
                        For aj = 0 To 500 - 1 Step 1
                            If BSCANBUFF((ai * 500) + aj) <> 0 Then
                                If angle = 45 Then
                                    If ch_range = 200 Then
                                        'objGraphics.DrawLine(tpen, aj, 413 + ai, aj + 1, 413 + ai)
                                        objGraphics.DrawLine(tpen, aj, 661 + ai, aj + 1, 661 + ai)
                                    ElseIf ch_range = 275 Then
                                        'objGraphics.DrawLine(tpen, aj, 413 + ai, aj + 1, 413 + ai)
                                        objGraphics.DrawLine(tpen, aj, 661 + ai, aj + 1, 661 + ai)
                                    End If
                                ElseIf angle = 37 Then
                                    If ch_range = 200 Then
                                        'objGraphics.DrawLine(tpen, aj, 370 + ai, aj + 1, 370 + ai)
                                        objGraphics.DrawLine(tpen, aj, 592 + ai, aj + 1, 592 + ai)
                                    ElseIf ch_range = 275 Then
                                        'objGraphics.DrawLine(tpen, aj, 385 + ai, aj + 1, 385 + ai)
                                        objGraphics.DrawLine(tpen, aj, 616 + ai, aj + 1, 616 + ai)
                                    End If
                                Else
                                    If angle = 37 Then
                                        'objGraphics.DrawLine(tpen, aj, 372 + ai, aj + 1, 372 + ai)
                                        objGraphics.DrawLine(tpen, aj, 595 + ai, aj + 1, 595 + ai)
                                    Else '70 Degree Plot is added for 1-9 B-Scan
                                        'objGraphics.DrawLine(tpen, aj, 375 + ai, aj + 1, 375 + ai)
                                        objGraphics.DrawLine(tpen, aj, 600 + ai, aj + 1, 600 + ai)
                                    End If
                                End If
                            End If
                        Next
                    Next
                Next

                'objSW11.Close()

                lt = Bm + fh
                objGraphicsFrm.DrawImage(bmp, 0, 0)
                railbmp = New Bitmap("\SD Card\rail.bmp")
                'objGraphics.DrawImage(railbmp, 380, 375)
                objGraphics.DrawImage(railbmp, 610, 600)
                railbmp.Dispose()
                'objGraphics.DrawLine(objBackPen, 10, 374, 400, 374)
                'objGraphics.DrawLine(objBackPen, 10, 410, 400, 410)
                'objGraphics.DrawLine(objBackPen, 10, 478, 640, 478)
                objGraphics.DrawLine(objBackPen, 10, 606, 640, 606)
                objGraphics.DrawLine(objBackPen, 10, 656, 640, 656)
                objGraphics.DrawLine(objBackPen, 10, 765, 1024, 765)
                Dim objBrushtmp1 As Brush
                objBrushtmp1 = objBrushBlk
            End If

            Dim fnm As String = Mid(datafile, 1, Len(datafile) - 4) & "_PRV.jpg" '"bmp"
            If File.Exists(fnm) Then File.Delete(fnm)
            bmp.Save(fnm, System.Drawing.Imaging.ImageFormat.Jpeg)
            Me.Text = Me.Text & " -.jpg is Saved "
            Application.DoEvents()

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error")
        End Try
    End Sub

    Private Sub AcquirePRHData(Optional ByVal gtype As Integer = 2)

        Try
            Dim i As Integer, j As Integer
            Dim objBrushtmp As Brush, objBrushGrp As Brush

            If gtype = 1 Then
                objBrushtmp = objBrush3
                objBrushGrp = objBrushes(curi Mod 10)
                objGraphics.Clear(Color.Black)
            Else
                objBrushtmp = objBrushBlk
                objBrushGrp = objBrushBlk
                objGraphics.Clear(Color.White)
            End If

            Dim bb(3) As Byte
            Dim st(35) As String
            Dim objfont As New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular)

            Dim objFS As FileStream = New FileStream(datafile, FileMode.Open, FileAccess.Read)
            Dim objBR As BinaryReader = New BinaryReader(objFS)
            For i = 0 To st.GetUpperBound(0)
                st(i) = objBR.ReadString
            Next i
            For i = 0 To DataArr.GetUpperBound(0)
                For j = 0 To DataArr.GetUpperBound(1)
                    DataArr(i, j) = objBR.ReadInt32
                Next j
            Next i
            curi = Val(Microsoft.VisualBasic.Right(datafile, 9)) - 1
            j = curi
            Dim upt As Integer = DataArr(curi, 2)
            upt = 319
            ReDim pt0(upt)
            Dim pt1(upt) As Point
            Dim vmax As Single = 0
            For i = 0 To upt
                pt0(i).X = objBR.ReadInt32
                pt0(i).Y = 241 - objBR.ReadInt32
                If pt0(i).Y > vmax Then vmax = pt0(i).Y
            Next
            pt0(0).Y = 0
            pt0(upt).Y = 0
            objBR.Close()
            objFS.Close()

            Dim Lm As Integer = 60
            Dim fh As Integer = 16
            Dim lt As Integer = 0
            lt = 0
            i = InStr(datafile, MCNO) + 9
            If grptyp = 0 Then
                objGraphics.DrawString("U/S TESTING OF WELD with Paras Rail Tester. ", objfont, objBrushtmp, Lm + 200, lt) : lt += fh
                objGraphics.DrawString("TEST INFORMATION                                  File:" & Mid$(datafile, i), objfont, objBrushtmp, Lm, lt) : lt += fh
                objGraphics.DrawString("MCNo: " & st(0), objfont, objBrushtmp, Lm, lt)
                objGraphics.DrawString("OP NAME: " & st(2), objfont, objBrushtmp, Lm + 200, lt) : lt += fh
                objGraphics.DrawString("DIVISION: " & st(5), objfont, objBrushtmp, Lm, lt)
                objGraphics.DrawString("SECTION: " & st(6), objfont, objBrushtmp, Lm + 200, lt) : lt += fh
                objGraphics.DrawString("START KM/TP: " & st(7) & " / " & st(8), objfont, objBrushtmp, Lm, lt)
                objGraphics.DrawString("RAIL: " & st(9), objfont, objBrushtmp, Lm + 200, lt)
                objGraphics.DrawString("ROAD: " & st(10), objfont, objBrushtmp, Lm + 300, lt) : lt += fh

                objGraphics.DrawString("START DATE: " & st(3), objfont, objBrushtmp, Lm, lt)
                objGraphics.DrawString("START TIME: " & st(4), objfont, objBrushtmp, Lm + 200, lt)
                objGraphics.DrawString("CALSET: " & st(1), objfont, objBrushtmp, Lm + 450, lt) : lt += fh
            ElseIf grptyp = 1 Then
                objGraphics.DrawString("U/S TESTING OF RAIL with Paras Rail Tester. ", objfont, objBrushtmp, Lm + 200, lt) : lt += fh
                objGraphics.DrawString("CALIBRATION INFORMATION                                  File:" & Mid$(datafile, i), objfont, objBrushtmp, Lm, lt) : lt += fh
                objGraphics.DrawString("MCNo: " & st(0), objfont, objBrushtmp, Lm, lt)
                objGraphics.DrawString("OP NAME: " & st(2), objfont, objBrushtmp, Lm + 200, lt) : lt += fh
                lt += fh
                lt += fh
                Dim sss() As String = st(4).Split("[")
                objGraphics.DrawString("START DATE: " & st(3), objfont, objBrushtmp, Lm, lt)
                objGraphics.DrawString("START TIME: " & sss(0), objfont, objBrushtmp, Lm + 200, lt)
                objGraphics.DrawString("CALSET: " & st(1), objfont, objBrushtmp, Lm + 450, lt) : lt += fh
            End If

            Dim lt1 As Integer = lt + fh
            objGraphics.DrawString(lblGain.Text, objfont, objBrushtmp, Lm, lt)
            objGraphics.DrawString(Format(DataArr(j, 0) / 2.0, "0.0"), objfont, objBrushtmp, Lm, lt1)
            objGraphics.DrawString(lblDelay.Text, objfont, objBrushtmp, Lm + 50, lt)
            objGraphics.DrawString(Format(Rangemm(DataArr(j, 1), -1), "0"), objfont, objBrushtmp, Lm + 50, lt1)
            objGraphics.DrawString(lblRange.Text, objfont, objBrushtmp, Lm + 100, lt)
            objGraphics.DrawString(Format(Rangemm(DataArr(j, 2), j), "0"), objfont, objBrushtmp, Lm + 100, lt1)
            objGraphics.DrawString(lblReject.Text, objfont, objBrushtmp, Lm + 150, lt)
            objGraphics.DrawString(Format(CSng(DataArr(j, 3)) / ymaxS, "0"), objfont, objBrushtmp, Lm + 150, lt1)
            objGraphics.DrawString(lblGateS.Text, objfont, objBrushtmp, Lm + 200, lt)
            objGraphics.DrawString(Format(Rangemm(DataArr(j, 4), j), "0"), objfont, objBrushtmp, Lm + 200, lt1)
            objGraphics.DrawString(lblGateW.Text, objfont, objBrushtmp, Lm + 250, lt)
            objGraphics.DrawString(Format(Rangemm(DataArr(j, 5), j), "0"), objfont, objBrushtmp, Lm + 250, lt1)
            objGraphics.DrawString(lblThresh.Text, objfont, objBrushtmp, Lm + 300, lt)
            objGraphics.DrawString(Format(CSng(DataArr(j, 6) / ymaxS), "0"), objfont, objBrushtmp, Lm + 300, lt1)
            objGraphics.DrawString(lblG2St.Text, objfont, objBrushtmp, Lm + 350, lt)
            objGraphics.DrawString(Format(Rangemm(DataArr(j, 7), j), "0"), objfont, objBrushtmp, Lm + 350, lt1)
            objGraphics.DrawString(lblG2Wd.Text, objfont, objBrushtmp, Lm + 400, lt)
            objGraphics.DrawString(Format(Rangemm(DataArr(j, 8), j), "0"), objfont, objBrushtmp, Lm + 400, lt1)
            objGraphics.DrawString(lblThr2.Text, objfont, objBrushtmp, Lm + 450, lt)
            objGraphics.DrawString(Format(CSng(DataArr(j, 9) / ymaxS), "0"), objfont, objBrushtmp, Lm + 450, lt1)
            Dim wav As Integer, ang As Single
            GetWaveAng(j, wav, ang)
            objGraphics.DrawString(lblAng.Text, objfont, objBrushtmp, Lm + 500, lt)
            objGraphics.DrawString(Format(ang, "0.0"), objfont, objBrushtmp, Lm + 500, lt1)
            lt = lt1 + fh

            Dim Tm As Integer = lt    ' 110
            Dim Bm As Integer = Tm + 0.4 * Me.Height       '200
            Dim Rm As Integer = Me.Width - 20
            Dim Lm2 As Integer = 100
            Dim Rm2 As Integer = Me.Width - 80

            Dim Sx As Single = (Rm2 - Lm2) / upt
            Dim Sy As Single = (Tm - Bm) / ymax
            For i = 0 To upt
                pt1(i).X = i * Sx + Lm2
                pt1(i).Y = pt0(i).Y * Sy + Bm
            Next
            Dim ii As Integer = 0

            For i = Lm2 To Rm2 Step (Rm2 - Lm2) / 10
                objGraphics.DrawLine(objBackPen, i, Tm, i, Bm)
                objGraphics.DrawString(Format(ii), objfont, objBrushBlk, i, Bm)
                ii += 1
            Next i
            Dim k As Integer = 100
            For i = Tm To Bm Step (Bm - Tm) / 10
                objGraphics.DrawLine(objBackPen, Lm2, i, Rm2, i)
                objGraphics.DrawString(Format(k, "0"), objfont, objBrushtmp, Lm2 - 20, i - 5)
                k -= 10
            Next i
            objGraphics.DrawPolygon(objBlackPen, pt1)

            lt = Bm + fh
            If grptyp = 0 Then
                objGraphics.DrawString("DEFECT DETAILS:", objfont, objBrushtmp, Lm, lt) : lt += fh
                objGraphics.DrawString("KM/TP  :" & st(11) & " /" & st(12), objfont, objBrushtmp, Lm, lt)
                objGraphics.DrawString("LOCATION:" & st(13) & "_" & st(14) & "_" & st(15), objfont, objBrushtmp, Lm + 200, lt)
                objGraphics.DrawString("STATIONS:" & st(16) & "-" & st(17), objfont, objBrushtmp, Lm + 400, lt) : lt += fh
                objGraphics.DrawString("ROLLING MARK:" & st(18) & "_" & st(19) & "_" & st(20) & "_" & st(21), objfont, objBrushtmp, Lm, lt) : lt += fh
                objGraphics.DrawString("PROBE:" & "      " & st(23), objfont, objBrushtmp, Lm, lt)
                objGraphics.DrawString("CHANNEL: " & Format(curi + 1, "00"), objfont, objBrushtmp, Lm + 200, lt) : lt += fh
                objGraphics.DrawString("PH", objfont, objBrushtmp, Lm + 100, lt)
                objGraphics.DrawString("HM", objfont, objBrushtmp, Lm + 150, lt)
                If TotNch > 5 Then objGraphics.DrawString("TYPE", objfont, objBrushtmp, Lm + 250, lt)
                objGraphics.DrawString("LOC", objfont, objBrushtmp, Lm + 300, lt)
                objGraphics.DrawString("CLASS", objfont, objBrushtmp, Lm + 350, lt)
                If TotNch > 5 Then objGraphics.DrawString("CODE", objfont, objBrushtmp, Lm + 400, lt)
                lt += fh
                objGraphics.DrawString("CURRENT:", objfont, objBrushtmp, Lm, lt)
                objGraphics.DrawString(st(24), objfont, objBrushtmp, Lm + 100, lt)
                objGraphics.DrawString(st(25), objfont, objBrushtmp, Lm + 150, lt)
                If TotNch > 5 Then objGraphics.DrawString(st(26), objfont, objBrushtmp, Lm + 250, lt)
                objGraphics.DrawString(st(27), objfont, objBrushtmp, Lm + 300, lt)
                objGraphics.DrawString(st(28), objfont, objBrushtmp, Lm + 350, lt)
                If TotNch > 5 Then objGraphics.DrawString(st(29), objfont, objBrushtmp, Lm + 400, lt)
                lt += fh
                If TotNch > 5 Then
                    objGraphics.DrawString("PREVIOUS:", objfont, objBrushtmp, Lm, lt)
                    objGraphics.DrawString(st(30), objfont, objBrushtmp, Lm + 100, lt)
                    objGraphics.DrawString(st(31), objfont, objBrushtmp, Lm + 150, lt)
                    objGraphics.DrawString(st(32), objfont, objBrushtmp, Lm + 250, lt)
                    objGraphics.DrawString(st(33), objfont, objBrushtmp, Lm + 300, lt)
                    objGraphics.DrawString(st(34), objfont, objBrushtmp, Lm + 350, lt)
                    Dim sst() As String = st(35).Split("[")
                    objGraphics.DrawString(sst(0), objfont, objBrushtmp, Lm + 400, lt)
                    If sst.Length > 1 Then
                        objGraphics.DrawString("prb:" & sst(1), objfont, objBrushtmp, Lm + 450, lt)
                        objGraphics.DrawString(sst(2), objfont, objBrushtmp, Lm + 510, lt)
                    End If
                End If
            Else
                lt += fh
                lt += fh
                objGraphics.DrawString("PROBE:" & "      " & st(23), objfont, objBrushtmp, Lm, lt)
                objGraphics.DrawString("CHANNEL: " & Format(curi + 1, "00"), objfont, objBrushtmp, Lm, lt + 200) : lt += fh
                objGraphics.DrawString(st(24), objfont, objBrushtmp, Lm, lt)
            End If
            lt += fh
            objGraphicsFrm.DrawImage(bmp, 0, 0)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub AcquireWRTData(Optional ByVal gtype As Integer = 2)
        Try
            Dim i As Integer, j As Integer
            Dim objBrushtmp As Brush, objBrushGrp As Brush
            If gtype = 1 Then
                objBrushtmp = objBrush3
                objBrushGrp = objBrushes(curi Mod 10)
                objGraphics.Clear(Color.Black)
            Else
                objBrushtmp = objBrushBlk
                objBrushGrp = objBrushBlk
                objGraphics.Clear(Color.White)
            End If
            Dim bb(3) As Byte
            Dim st(35) As String
            Dim objfont As New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular)

            Dim objFS As FileStream = New FileStream(datafile, FileMode.Open, FileAccess.Read)
            Dim objBR As BinaryReader = New BinaryReader(objFS)
            For i = 0 To st.GetUpperBound(0)
                st(i) = objBR.ReadString
            Next i
            If curi = 9 Then
                Module1.ReadData()
                For i = 0 To DataArr10.GetUpperBound(0)
                    For j = 0 To DataArr10.GetUpperBound(1)
                        DataArr10(0, j) = objBR.ReadInt32
                    Next j
                Next i
            Else
                For i = 0 To DataArr.GetUpperBound(0)
                    For j = 0 To DataArr.GetUpperBound(1)
                        DataArr(i, j) = objBR.ReadInt32
                    Next j
                Next i
            End If
            curi = Val(Microsoft.VisualBasic.Right(datafile, 9)) - 1
            j = curi
            Dim upt As Integer = DataArr(curi, 2)
            upt = 319
            ReDim pt0(upt)
            Dim pt1(upt) As Point
            Dim vmax As Single = 0
            For i = 0 To upt
                pt0(i).X = objBR.ReadInt32
                pt0(i).Y = 241 - objBR.ReadInt32
                If pt0(i).Y > vmax Then vmax = pt0(i).Y
            Next
            pt0(0).Y = 0
            pt0(upt).Y = 0
            objBR.Close()
            objFS.Close()

            Dim Lm As Integer = 60
            Dim fh As Integer = 16
            Dim lt As Integer = 0
            lt = 0
            i = InStr(datafile, MCNO) + 9
            Dim RW As String = IIf(TotNch < 9, "WELD", "RAIL")
            If grptyp = 0 Then
                objGraphics.DrawString("U/S TESTING OF " & RW & " with Paras " & RW & " Tester. ", objfont, objBrushtmp, Lm + 200, lt) : lt += fh
                objGraphics.DrawString("TEST INFORMATION                                  File:" & Mid$(datafile, i), objfont, objBrushtmp, Lm, lt) : lt += fh
                objGraphics.DrawString("MCNo: " & st(0), objfont, objBrushtmp, Lm, lt)
                objGraphics.DrawString("OP NAME: " & st(2), objfont, objBrushtmp, Lm + 200, lt) : lt += fh
                objGraphics.DrawString("DIVISION: " & st(5), objfont, objBrushtmp, Lm, lt)
                objGraphics.DrawString("SECTION: " & st(6), objfont, objBrushtmp, Lm + 200, lt) : lt += fh
                objGraphics.DrawString("START KM/TP: " & st(7) & " / " & st(8), objfont, objBrushtmp, Lm, lt)
                objGraphics.DrawString("RAIL: " & st(9), objfont, objBrushtmp, Lm + 200, lt)
                objGraphics.DrawString("ROAD: " & st(10), objfont, objBrushtmp, Lm + 300, lt) : lt += fh
                objGraphics.DrawString("START DATE: " & st(3), objfont, objBrushtmp, Lm, lt)
                objGraphics.DrawString("START TIME: " & st(4), objfont, objBrushtmp, Lm + 200, lt)
                objGraphics.DrawString("CALSET: " & st(1), objfont, objBrushtmp, Lm + 450, lt) : lt += fh
            ElseIf grptyp = 1 Then
                objGraphics.DrawString("U/S TESTING OF RAIL with Paras Rail Tester. ", objfont, objBrushtmp, Lm + 200, lt) : lt += fh
                objGraphics.DrawString("CALIBRATION INFORMATION                                  File:" & Mid$(datafile, i), objfont, objBrushtmp, Lm, lt) : lt += fh
                objGraphics.DrawString("MCNo: " & st(0), objfont, objBrushtmp, Lm, lt)
                objGraphics.DrawString("OP NAME: " & st(2), objfont, objBrushtmp, Lm + 200, lt) : lt += fh
                lt += fh
                lt += fh
                Dim sss() As String = st(4).Split("[")
                objGraphics.DrawString("START DATE: " & st(3), objfont, objBrushtmp, Lm, lt)
                objGraphics.DrawString("START TIME: " & sss(0), objfont, objBrushtmp, Lm + 200, lt)
                objGraphics.DrawString("CALSET: " & st(1), objfont, objBrushtmp, Lm + 450, lt) : lt += fh
            End If

            Dim lt1 As Integer = lt + fh
            objGraphics.DrawString(lblGain.Text, objfont, objBrushtmp, Lm, lt)
            objGraphics.DrawString(Format(DataArr(j, 0) / 2.0, "0.0"), objfont, objBrushtmp, Lm, lt1)
            objGraphics.DrawString(lblDelay.Text, objfont, objBrushtmp, Lm + 50, lt)
            objGraphics.DrawString(Format(Rangemm(DataArr(j, 1), -1), "0"), objfont, objBrushtmp, Lm + 50, lt1)
            objGraphics.DrawString(lblRange.Text, objfont, objBrushtmp, Lm + 100, lt)
            objGraphics.DrawString(Format(Rangemm(DataArr(j, 2), j), "0"), objfont, objBrushtmp, Lm + 100, lt1)
            objGraphics.DrawString(lblReject.Text, objfont, objBrushtmp, Lm + 150, lt)
            objGraphics.DrawString(Format(CSng(DataArr(j, 3)) / ymaxS, "0"), objfont, objBrushtmp, Lm + 150, lt1)
            objGraphics.DrawString(lblGateS.Text, objfont, objBrushtmp, Lm + 200, lt)
            objGraphics.DrawString(Format(Rangemm(DataArr(j, 4), j), "0"), objfont, objBrushtmp, Lm + 200, lt1)
            objGraphics.DrawString(lblGateW.Text, objfont, objBrushtmp, Lm + 250, lt)
            objGraphics.DrawString(Format(Rangemm(DataArr(j, 5), j), "0"), objfont, objBrushtmp, Lm + 250, lt1)
            objGraphics.DrawString(lblThresh.Text, objfont, objBrushtmp, Lm + 300, lt)
            objGraphics.DrawString(Format(CSng(DataArr(j, 6) / ymaxS), "0"), objfont, objBrushtmp, Lm + 300, lt1)
            objGraphics.DrawString(lblG2St.Text, objfont, objBrushtmp, Lm + 350, lt)
            objGraphics.DrawString(Format(Rangemm(DataArr(j, 7), j), "0"), objfont, objBrushtmp, Lm + 350, lt1)
            objGraphics.DrawString(lblG2Wd.Text, objfont, objBrushtmp, Lm + 400, lt)
            objGraphics.DrawString(Format(Rangemm(DataArr(j, 8), j), "0"), objfont, objBrushtmp, Lm + 400, lt1)
            objGraphics.DrawString(lblThr2.Text, objfont, objBrushtmp, Lm + 450, lt)
            objGraphics.DrawString(Format(CSng(DataArr(j, 9) / ymaxS), "0"), objfont, objBrushtmp, Lm + 450, lt1)
            Dim wav As Integer, ang As Single
            GetWaveAng(j, wav, ang)
            objGraphics.DrawString(lblAng.Text, objfont, objBrushtmp, Lm + 500, lt)
            objGraphics.DrawString(Format(ang, "0.0"), objfont, objBrushtmp, Lm + 500, lt1)
            lt = lt1 + fh
            Dim Tm As Integer = lt    ' 110
            Dim Bm As Integer = Tm + 0.4 * Me.Height       '200
            Dim Rm As Integer = Me.Width - 20
            Dim Lm2 As Integer = 100
            Dim Rm2 As Integer = Me.Width - 80

            Dim Sx As Single = (Rm2 - Lm2) / upt
            Dim Sy As Single = (Tm - Bm) / ymax
            For i = 0 To upt
                pt1(i).X = i * Sx + Lm2
                pt1(i).Y = pt0(i).Y * Sy + Bm
            Next
            Dim ii As Integer = 0

            For i = Lm2 To Rm2 Step (Rm2 - Lm2) / 10
                objGraphics.DrawLine(objBackPen, i, Tm, i, Bm)
                objGraphics.DrawString(Format(ii), objfont, objBrushBlk, i, Bm)
                ii += 1
            Next i
            Dim k As Integer = 100
            For i = Tm To Bm Step (Bm - Tm) / 10
                objGraphics.DrawLine(objBackPen, Lm2, i, Rm2, i)
                objGraphics.DrawString(Format(k, "0"), objfont, objBrushtmp, Lm2 - 20, i - 5)
                k -= 10
            Next i
            objGraphics.DrawPolygon(objBlackPen, pt1)

            lt = Bm + fh
            If grptyp = 0 Then
                objGraphics.DrawString("DEFECT DETAILS:", objfont, objBrushtmp, Lm, lt) : lt += fh
                objGraphics.DrawString("KM/TP  :" & st(11) & " /" & st(12), objfont, objBrushtmp, Lm, lt)
                objGraphics.DrawString("LOCATION:" & st(13) & "_" & st(14) & "_" & st(15), objfont, objBrushtmp, Lm + 200, lt)
                objGraphics.DrawString("STATIONS:" & st(16) & "-" & st(17), objfont, objBrushtmp, Lm + 400, lt) : lt += fh
                objGraphics.DrawString("ROLLING MARK:" & st(18) & "_" & st(19) & "_" & st(20) & "_" & st(21), objfont, objBrushtmp, Lm, lt) : lt += fh
                objGraphics.DrawString("PROBE:" & "      " & st(23), objfont, objBrushtmp, Lm, lt)
                objGraphics.DrawString("CHANNEL: " & Format(curi + 1, "00"), objfont, objBrushtmp, Lm + 200, lt) : lt += fh
                objGraphics.DrawString("PH", objfont, objBrushtmp, Lm + 100, lt)
                objGraphics.DrawString("HM", objfont, objBrushtmp, Lm + 150, lt)
                If TotNch > 5 Then objGraphics.DrawString("TYPE", objfont, objBrushtmp, Lm + 250, lt)
                objGraphics.DrawString("LOC", objfont, objBrushtmp, Lm + 300, lt)
                objGraphics.DrawString("CLASS", objfont, objBrushtmp, Lm + 350, lt)
                If TotNch > 5 Then objGraphics.DrawString("CODE", objfont, objBrushtmp, Lm + 400, lt)
                lt += fh
                objGraphics.DrawString("CURRENT:", objfont, objBrushtmp, Lm, lt)
                objGraphics.DrawString(st(24), objfont, objBrushtmp, Lm + 100, lt)
                objGraphics.DrawString(st(25), objfont, objBrushtmp, Lm + 150, lt)
                If TotNch > 5 Then objGraphics.DrawString(st(26), objfont, objBrushtmp, Lm + 250, lt)
                objGraphics.DrawString(st(27), objfont, objBrushtmp, Lm + 300, lt)
                objGraphics.DrawString(st(28), objfont, objBrushtmp, Lm + 350, lt)
                If TotNch > 5 Then objGraphics.DrawString(st(29), objfont, objBrushtmp, Lm + 400, lt)
                lt += fh
                If TotNch > 5 Then
                    objGraphics.DrawString("PREVIOUS:", objfont, objBrushtmp, Lm, lt)
                    objGraphics.DrawString(st(30), objfont, objBrushtmp, Lm + 100, lt)
                    objGraphics.DrawString(st(31), objfont, objBrushtmp, Lm + 150, lt)
                    objGraphics.DrawString(st(32), objfont, objBrushtmp, Lm + 250, lt)
                    objGraphics.DrawString(st(33), objfont, objBrushtmp, Lm + 300, lt)
                    objGraphics.DrawString(st(34), objfont, objBrushtmp, Lm + 350, lt)
                    Dim sst() As String = st(35).Split("[")
                    objGraphics.DrawString(sst(0), objfont, objBrushtmp, Lm + 400, lt)
                    If sst.Length > 1 Then
                        objGraphics.DrawString("prb:" & sst(1), objfont, objBrushtmp, Lm + 450, lt)
                        objGraphics.DrawString(sst(2), objfont, objBrushtmp, Lm + 510, lt)
                    End If
                End If
            Else
                lt += fh
                lt += fh
                objGraphics.DrawString("PROBE:" & "      " & st(23), objfont, objBrushtmp, Lm, lt)
                objGraphics.DrawString("CHANNEL: " & Format(curi + 1, "00"), objfont, objBrushtmp, Lm, lt + 200) : lt += fh
                objGraphics.DrawString(st(24), objfont, objBrushtmp, Lm, lt)
            End If
            lt += fh
            objGraphicsFrm.DrawImage(bmp, 0, 0)
            Application.DoEvents()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub AcquirePRCData(Optional ByVal gtype As Integer = 2)
        Try
            Dim i As Integer, j As Integer
            Dim objBrushtmp As Brush, objBrushGrp As Brush
            If gtype = 1 Then
                objBrushtmp = objBrush3
                objBrushGrp = objBrushes(curi Mod 10)
                objGraphics.Clear(Color.Black)
            Else
                objBrushtmp = objBrushBlk
                objBrushGrp = objBrushBlk
                objGraphics.Clear(Color.White)
            End If
            Dim bb(3) As Byte
            Dim st(35) As String
            Dim objfont As New Font(FontFamily.GenericSansSerif, 8.0F, FontStyle.Regular)

            Dim objFS As FileStream = New FileStream(datafile, FileMode.Open, FileAccess.Read)
            Dim objBR As BinaryReader = New BinaryReader(objFS)
            For i = 0 To st.GetUpperBound(0)
                st(i) = objBR.ReadString
            Next i
            For i = 0 To DataArr.GetUpperBound(0)
                For j = 0 To DataArr.GetUpperBound(1)
                    DataArr(i, j) = objBR.ReadInt32
                Next j
            Next i
            curi = Val(Microsoft.VisualBasic.Right(datafile, 9)) - 1
            j = curi
            Dim upt As Integer = DataArr(curi, 2)
            upt = 319
            ReDim pt0(upt)
            Dim pt1(upt) As Point
            Dim vmax As Single = 0
            For i = 0 To upt
                pt0(i).X = objBR.ReadInt32
                pt0(i).Y = 241 - objBR.ReadInt32
                If pt0(i).Y > vmax Then vmax = pt0(i).Y
            Next
            pt0(0).Y = 0
            pt0(upt).Y = 0
            objBR.Close()
            objFS.Close()

            Dim Lm As Integer = 60
            Dim fh As Integer = 16
            Dim lt As Integer = 0
            lt = 0
            i = InStr(datafile, MCNO) + 9

            objGraphics.DrawString("U/S TESTING OF RAIL with Paras Rail Tester. ", objfont, objBrushtmp, Lm + 200, lt) : lt += fh
            objGraphics.DrawString("TEST INFORMATION                                  File:" & Mid$(datafile, i), objfont, objBrushtmp, Lm, lt) : lt += fh
            objGraphics.DrawString("MCNo: " & st(0), objfont, objBrushtmp, Lm, lt)
            objGraphics.DrawString("OP NAME: " & st(2), objfont, objBrushtmp, Lm + 200, lt) : lt += fh
            objGraphics.DrawString("DIVISION: " & st(5), objfont, objBrushtmp, Lm, lt)
            objGraphics.DrawString("SECTION: " & st(6), objfont, objBrushtmp, Lm + 200, lt) : lt += fh
            objGraphics.DrawString("START KM/TP: " & st(7) & " / " & st(8), objfont, objBrushtmp, Lm, lt)
            objGraphics.DrawString("RAIL: " & st(9), objfont, objBrushtmp, Lm + 200, lt)
            objGraphics.DrawString("ROAD: " & st(10), objfont, objBrushtmp, Lm + 300, lt) : lt += fh

            objGraphics.DrawString("START DATE: " & st(3), objfont, objBrushtmp, Lm, lt)
            If TotNch > 5 Then
                objGraphics.DrawString("START TIME: " & st(4), objfont, objBrushtmp, Lm + 200, lt)
            Else
                Dim sss() As String = st(4).Split("[")
                objGraphics.DrawString("START TIME: " & sss(0), objfont, objBrushtmp, Lm + 200, lt)
            End If
            objGraphics.DrawString("CALSET: " & st(1), objfont, objBrushtmp, Lm + 450, lt) : lt += fh

            Dim lt1 As Integer = lt + fh
            objGraphics.DrawString(lblGain.Text, objfont, objBrushtmp, Lm, lt)
            objGraphics.DrawString(Format(DataArr(j, 0) / 2.0, "0.0"), objfont, objBrushtmp, Lm, lt1)
            objGraphics.DrawString(lblDelay.Text, objfont, objBrushtmp, Lm + 50, lt)
            objGraphics.DrawString(Format(Rangemm(DataArr(j, 1), -1), "0"), objfont, objBrushtmp, Lm + 50, lt1)
            objGraphics.DrawString(lblRange.Text, objfont, objBrushtmp, Lm + 100, lt)
            objGraphics.DrawString(Format(Rangemm(DataArr(j, 2), j), "0"), objfont, objBrushtmp, Lm + 100, lt1)
            objGraphics.DrawString(lblReject.Text, objfont, objBrushtmp, Lm + 150, lt)
            objGraphics.DrawString(Format(CSng(DataArr(j, 3)) / ymaxS, "0"), objfont, objBrushtmp, Lm + 150, lt1)
            objGraphics.DrawString(lblGateS.Text, objfont, objBrushtmp, Lm + 200, lt)
            objGraphics.DrawString(Format(Rangemm(DataArr(j, 4), j), "0"), objfont, objBrushtmp, Lm + 200, lt1)
            objGraphics.DrawString(lblGateW.Text, objfont, objBrushtmp, Lm + 250, lt)
            objGraphics.DrawString(Format(Rangemm(DataArr(j, 5), j), "0"), objfont, objBrushtmp, Lm + 250, lt1)
            objGraphics.DrawString(lblThresh.Text, objfont, objBrushtmp, Lm + 300, lt)
            objGraphics.DrawString(Format(CSng(DataArr(j, 6) / ymaxS), "0"), objfont, objBrushtmp, Lm + 300, lt1)
            objGraphics.DrawString(lblG2St.Text, objfont, objBrushtmp, Lm + 350, lt)
            objGraphics.DrawString(Format(Rangemm(DataArr(j, 7), j), "0"), objfont, objBrushtmp, Lm + 350, lt1)
            objGraphics.DrawString(lblG2Wd.Text, objfont, objBrushtmp, Lm + 400, lt)
            objGraphics.DrawString(Format(Rangemm(DataArr(j, 8), j), "0"), objfont, objBrushtmp, Lm + 400, lt1)
            objGraphics.DrawString(lblThr2.Text, objfont, objBrushtmp, Lm + 450, lt)
            objGraphics.DrawString(Format(CSng(DataArr(j, 9) / ymaxS), "0"), objfont, objBrushtmp, Lm + 450, lt1)
            Dim wav As Integer, ang As Single
            GetWaveAng(j, wav, ang)
            objGraphics.DrawString(lblAng.Text, objfont, objBrushtmp, Lm + 500, lt)
            objGraphics.DrawString(Format(ang, "0.0"), objfont, objBrushtmp, Lm + 500, lt1)
            lt = lt1 + fh
            Dim Tm As Integer = lt    ' 110
            Dim Bm As Integer = Tm + 0.4 * Me.Height       '200
            Dim Rm As Integer = Me.Width - 20
            Dim Lm2 As Integer = 100
            Dim Rm2 As Integer = Me.Width - 80

            Dim Sx As Single = (Rm2 - Lm2) / upt
            Dim Sy As Single = (Tm - Bm) / ymax
            For i = 0 To upt
                pt1(i).X = i * Sx + Lm2
                pt1(i).Y = pt0(i).Y * Sy + Bm
            Next
            Dim ii As Integer = 0

            For i = Lm2 To Rm2 Step (Rm2 - Lm2) / 10
                objGraphics.DrawLine(objBackPen, i, Tm, i, Bm)
                objGraphics.DrawString(Format(ii), objfont, objBrushBlk, i, Bm)
                ii += 1
            Next i
            Dim k As Integer = 100
            For i = Tm To Bm Step (Bm - Tm) / 10
                objGraphics.DrawLine(objBackPen, Lm2, i, Rm2, i)
                objGraphics.DrawString(Format(k, "0"), objfont, objBrushtmp, Lm2 - 20, i - 5)
                k -= 10
            Next i
            objGraphics.DrawPolygon(objBlackPen, pt1)

            lt = Bm + fh
            objGraphics.DrawString("DEFECT DETAILS:", objfont, objBrushtmp, Lm, lt) : lt += fh
            objGraphics.DrawString("KM/TP  :" & st(11) & " /" & st(12), objfont, objBrushtmp, Lm, lt)
            objGraphics.DrawString("LOCATION:" & st(13) & "_" & st(14) & "_" & st(15), objfont, objBrushtmp, Lm + 200, lt)
            objGraphics.DrawString("STATIONS:" & st(16) & "-" & st(17), objfont, objBrushtmp, Lm + 400, lt) : lt += fh
            objGraphics.DrawString("ROLLING MARK:" & st(18) & "_" & st(19) & "_" & st(20) & "_" & st(21), objfont, objBrushtmp, Lm, lt)
            objGraphics.DrawString("PROBE:" & "      " & st(23), objfont, objBrushtmp, Lm + 200, lt)
            objGraphics.DrawString("CHANNEL: " & Format(curi + 1, "00"), objfont, objBrushtmp, Lm + 400, lt) : lt += fh
            objGraphics.DrawString("PH", objfont, objBrushtmp, Lm + 100, lt)
            objGraphics.DrawString("HM", objfont, objBrushtmp, Lm + 150, lt)
            If TotNch > 5 Then objGraphics.DrawString("TYPE", objfont, objBrushtmp, Lm + 250, lt)
            objGraphics.DrawString("LOC", objfont, objBrushtmp, Lm + 300, lt)
            objGraphics.DrawString("CLASS", objfont, objBrushtmp, Lm + 350, lt)
            If TotNch > 5 Then objGraphics.DrawString("CODE", objfont, objBrushtmp, Lm + 400, lt)
            lt += fh
            objGraphics.DrawString("CURRENT:", objfont, objBrushtmp, Lm, lt)
            objGraphics.DrawString(st(24), objfont, objBrushtmp, Lm + 100, lt)
            objGraphics.DrawString(st(25), objfont, objBrushtmp, Lm + 150, lt)
            If TotNch > 5 Then objGraphics.DrawString(st(26), objfont, objBrushtmp, Lm + 250, lt)
            objGraphics.DrawString(st(27), objfont, objBrushtmp, Lm + 300, lt)
            objGraphics.DrawString(st(28), objfont, objBrushtmp, Lm + 350, lt)
            If TotNch > 5 Then objGraphics.DrawString(st(29), objfont, objBrushtmp, Lm + 400, lt)
            lt += fh
            If TotNch > 5 Then
                objGraphics.DrawString("PREVIOUS:", objfont, objBrushtmp, Lm, lt)
                objGraphics.DrawString(st(30), objfont, objBrushtmp, Lm + 100, lt)
                objGraphics.DrawString(st(31), objfont, objBrushtmp, Lm + 150, lt)
                objGraphics.DrawString(st(32), objfont, objBrushtmp, Lm + 250, lt)
                objGraphics.DrawString(st(33), objfont, objBrushtmp, Lm + 300, lt)
                objGraphics.DrawString(st(34), objfont, objBrushtmp, Lm + 350, lt)
                Dim sst() As String = st(35).Split("[")
                objGraphics.DrawString(sst(0), objfont, objBrushtmp, Lm + 400, lt)
                If sst.Length > 1 Then
                    objGraphics.DrawString("prb:" & sst(1), objfont, objBrushtmp, Lm + 450, lt)
                    objGraphics.DrawString(sst(2), objfont, objBrushtmp, Lm + 510, lt)
                End If
            End If
            lt += fh
            objGraphicsFrm.DrawImage(bmp, 0, 0)
            Application.DoEvents()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub AcquireData2(Optional ByVal gtype As Integer = 2) 'prs

        Try
            Dim objSR2 As StreamReader = New StreamReader("\SD Card\Model.txt")

            Dim mstrr() As String
            Dim mstrr1 As String

            mstrr1 = objSR2.ReadLine
            mstrr = mstrr1.Split(",")

            Dim objg10db As StreamReader = New StreamReader("\SD Card\Gain10DBFlag.txt")

            Dim gain10db() As String
            Dim gain10db1 As String
            Dim gain10dbval As String

            gain10db1 = objg10db.ReadLine
            gain10db = gain10db1.Split(",")
            gain10dbval = gain10db(0).ToString

            If curi = 9 Then
                '10th channel
                Dim objSR1 As StreamReader = New StreamReader("\SD Card\CalSetNum.txt")

                Dim mstr() As String
                Dim mstr1 As String

                mstr1 = objSR1.ReadLine
                mstr = mstr1.Split(",")

                Dim strCurrCalSet As String = mstr(1)

                Dim DataArrCh10(TotNch, TotNpr) As Integer

                Dim i As Integer
                Dim bb(3) As Byte
                Dim st(45) As String
                'Dim objfont As New Font(FontFamily.GenericSansSerif, 7.0F, FontStyle.Regular)
                Dim objfont As New Font(FontFamily.GenericSansSerif, 11.0F, FontStyle.Regular)
                Dim objFS As FileStream = New FileStream(datafile, FileMode.Open, FileAccess.Read)
                Dim objBR As BinaryReader = New BinaryReader(objFS)

                For i = 0 To st.GetUpperBound(0)
                    st(i) = objBR.ReadString
                Next i

                Dim Configfile As String = ""
                Dim configData As String = ""
                Configfile = "\SD Card\config10.txt"

                Dim configReader As StreamReader = New StreamReader(Configfile)

                Dim q As Integer = 1
                For q = 1 To st(1)
                    configData = configReader.ReadLine
                Next

                Dim st1() As String = Split(configData, ",")
                For g = 0 To DataArrCh10.GetUpperBound(1)
                    DataArrCh10(0, g) = st1(g)
                Next

                Dim blackpen As New Pen(Color.Black)
                'Dim objboldfont1 As New Font(FontFamily.GenericSansSerif, 7.0F, FontStyle.Bold)
                Dim objboldfont1 As New Font(FontFamily.GenericSansSerif, 11.0F, FontStyle.Bold)
                Dim objBrushtmp As Brush, objBrushGrp As Brush
                Dim grp1x As Integer = 16 '10
                Dim grp1y As Integer = 6 '4
                Dim grp2x As Integer = 256 '160
                Dim grp2y As Integer = 6 '4
                Dim grp3x As Integer = 632 '395
                Dim grp3y As Integer = 6 ' 4
                Dim grp4x As Integer = 632 '395
                Dim grp4y As Integer = 192 '120
                Dim grp5x As Integer = 632 '395
                Dim grp5y As Integer
                Dim r As Integer = DataArrCh10(0, 3)


                Dim T1 As Integer = CSng(DataArrCh10(0, 6)) / ymaxS
                Dim T2 As Integer = CSng(DataArrCh10(0, 9)) / ymaxS

                If gtype = 1 Then
                    objBrushtmp = objBrush3
                    objBrushGrp = objBrushes(curi Mod 10)
                    objGraphics.Clear(Color.Black)
                Else
                    objBrushtmp = objBrushBlk
                    objBrushGrp = objBrushBlk
                    objGraphics.Clear(Color.White)
                End If

                Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
                Dim upt As Integer = DataArrCh10(0, 1)

                'Dim intExtraXLine As Integer = 20
                ReDim pt0(upt)
                Dim pt1(upt) As Point
                Dim gate1start As Integer = Format((DataArrCh10(0, 4) / DataArrCh10(0, 1)) * 100, "###0")
                Dim gate1end As Integer = Format(((DataArrCh10(0, 5) / DataArrCh10(0, 1)) * 100) + ((DataArrCh10(0, 4) / DataArrCh10(0, 1))) * 100, "###0")
                Dim gate2start As Integer = Format((DataArrCh10(0, 7) / DataArrCh10(0, 1)) * 100, "###0")
                Dim gate2end As Integer = Format(((DataArrCh10(0, 8) / DataArrCh10(0, 1)) * 100) + ((DataArrCh10(0, 7) / DataArrCh10(0, 1))) * 100, "###0")
                objFS.Seek(IIf(curi > 8, curi + 1, curi) * 2048 + DataArrCh10(0, 2), SeekOrigin.Current)

                For i = 0 To upt
                    pt0(i).X = i
                    pt0(i).Y = objFS.ReadByte
                Next i

                objBR.Close()
                objFS.Close()
                Dim Lm As Integer = 16 '10
                Dim fh As Integer = 22 '14
                Dim lt As Integer = 0
                lt = 0

                '1st Group
                objGraphics.DrawString("Test Information: ", objfont, objBrushtmp, grp1x, grp1y)
                grp1y += fh
                objGraphics.DrawString("M/C No:PE-" & mstrr(0) & "/" & st(0), objfont, objBrushtmp, grp1x, grp1y)
                grp1y += fh
                objGraphics.DrawString("Division: " & st(5), objfont, objBrushtmp, grp1x, grp1y)
                grp1y += fh

                objGraphics.DrawString("Start Km,M/ Tp : " & st(7) & "," & st(8) & " /" & st(9), objfont, objBrushtmp, grp1x, grp1y)
                grp1y += fh
                objGraphics.DrawString("Date: " & st(3), objfont, objBrushtmp, grp1x, grp1y)
                grp1y += (fh + (fh / 2))
                objGraphics.DrawString("Prameter Values", objfont, objBrushtmp, grp1x, grp1y - 16)

                '2nd Group
                Dim fstr As String() = datafile.Split("\")
                objGraphics.DrawString("File:  " & fstr(3) & "  \" & fstr(4) & "\" & fstr(5), objfont, objBrushtmp, grp2x + 32, grp2y) ' grp2x + 20, grp2y)
                grp2y += fh
                objGraphics.DrawString("OP NAME / Code:  " & st(2), objfont, objBrushtmp, grp2x + 32, grp2y) ' grp2x + 20, grp2y)
                grp2y += fh
                objGraphics.DrawString("Block Section: " & st(6), objfont, objBrushtmp, grp2x + 32, grp2y)
                grp2y += fh
                objGraphics.DrawString("Line: " & st(11), objfont, objBrushtmp, grp2x + 32, grp2y)
                grp2y += fh
                objGraphics.DrawString("Start Time: " & st(4), objfont, objBrushtmp, grp2x + 32, grp2y)
                grp2y += fh

                '3rd Group
                objGraphics.DrawString("                     Location  ", objfont, objBrushtmp, grp3x, grp3y)
                grp3y += fh
                'objGraphics.DrawRectangle(blackpen, grp3x + 55, grp3y + 2, 130, 29)
                objGraphics.DrawRectangle(blackpen, grp3x + 88, grp3y + 3, 208, 46)
                'objGraphics.DrawString("     Km   Km   m   ", objboldfont1, objBrushtmp, grp3x + 57, grp3y + 4)
                objGraphics.DrawString("     Km   Km   m   ", objboldfont1, objBrushtmp, grp3x + 91, grp3y + 6)
                'objGraphics.DrawString("     " & st(17) & " -" & st(18), objboldfont1, objBrushtmp, grp3x + 57, grp3y + fh)
                objGraphics.DrawString("     " & st(17) & " -" & st(18), objboldfont1, objBrushtmp, grp3x + 91, grp3y + fh)
                'grp3y += 42
                grp3y += 67
                objGraphics.DrawString("Latitude  ", objfont, objBrushtmp, grp3x, grp3y)
                'objGraphics.DrawString("Longtitude  ", objfont, objBrushtmp, grp3x + 130, grp3y)
                objGraphics.DrawString("Longtitude  ", objfont, objBrushtmp, grp3x + 208, grp3y)
                grp3y += fh

                ' Latitude
                'objGraphics.DrawRectangle(blackpen, grp3x, grp3y, 100, 19)
                objGraphics.DrawRectangle(blackpen, grp3x, grp3y, 160, 31)
                Dim deg() As String, min() As String, secs() As String ', dir() As String
                deg = st(39).Split("°")
                min = deg(1).Split("''")
                secs = st(39).Split("'")
                objGraphics.DrawString(Format(deg(0) + 0, "00") & "° " & Format(min(0) + 0, "00") & "' " & Format(secs(1) + 0, "00.00") & "'' " & "N", objfont, objBrushtmp, grp3x + 6, grp3y + 3) 'grp3x + 4, grp3y + 2)

                'Longtitude
                'objGraphics.DrawRectangle(blackpen, grp3x + 130, grp3y, 100, 19)
                objGraphics.DrawRectangle(blackpen, grp3x + 208, grp3y, 160, 31)
                Dim deg1() As String, min1() As String, secs1() As String
                deg1 = st(40).Split("°")
                min1 = deg1(1).Split("''")
                secs1 = st(40).Split("'")
                objGraphics.DrawString(Format(deg1(0) + 0, "00") & "° " & Format(min1(0) + 0, "00") & "' " & Format(secs1(1) + 0, "00.00") & "'' " & "E", objfont, objBrushtmp, grp3x + 213, grp3y + 3) 'grp3x + 133, grp3y + 2)

                '4th Group
                Dim objboldfont As New Font(FontFamily.GenericSansSerif, 11.0F, FontStyle.Bold)
                objGraphics.DrawString("Defect Details:  ", objboldfont, objBrushtmp, grp4x, grp4y)
                grp4y += (fh + 3)
                objGraphics.DrawString("Km,M/ Tp : " & Format(st(13) + 0, "0000") & "," & st(14) & " /" & st(15), objboldfont, objBrushtmp, grp4x, grp4y)
                grp4y += fh
                objGraphics.DrawString("Stations:  " & st(19) & "-" & st(20), objfont, objBrushtmp, grp4x, grp4y)
                grp4y += (fh + 3)
                objGraphics.DrawString("Rolling Mark:  " & st(21) & "_" & st(22) & "_" & st(23) & "_" & st(24), objfont, objBrushtmp, grp4x, grp4y)
                grp4y += fh
                objGraphics.DrawString("Rail/Weld No:  " & st(16), objboldfont, objBrushtmp, grp4x, grp4y)
                grp4y += fh
                objGraphics.DrawString("Probe:  " & st(25) & "      " & st(26), objfont, objBrushtmp, grp4x, grp4y)
                grp4y += fh
                grp5y = grp4y

                Dim rawPH As Integer = st(27)
                Dim PH_data As Integer = rawPH
                If (PH_data >= 100) Then
                    PH_data = 100
                End If
                If PH_data = 0 Then
                    st(41) = 0
                    st(28) = 0
                    st(42) = 0
                End If

                objGraphics.DrawString("PH:  " & PH_data, objfont, objBrushtmp, grp5x, grp5y)
                'objGraphics.DrawString("D:  " & st(41), objfont, objBrushtmp, grp5x + 75, grp5y)
                'objGraphics.DrawString("CalSet:  " & st(1), objfont, objBrushtmp, grp5x + 150, grp5y)
                objGraphics.DrawString("D:  " & st(41), objfont, objBrushtmp, grp5x + 120, grp5y)
                objGraphics.DrawString("CalSet:  " & st(1), objfont, objBrushtmp, grp5x + 240, grp5y)

                grp5y += (fh + 5)
                objGraphics.DrawString("BP:  " & st(28), objfont, objBrushtmp, grp5x, grp5y)
                'objGraphics.DrawString("SD:  " & st(42), objfont, objBrushtmp, grp5x + 75, grp5y)
                'objGraphics.DrawString("Channel:  " & Format(curi + 1, "00"), objfont, objBrushtmp, grp5x + 150, grp5y)
                objGraphics.DrawString("SD:  " & st(42), objfont, objBrushtmp, grp5x + 120, grp5y)
                objGraphics.DrawString("Channel:  " & Format(curi + 1, "00"), objfont, objBrushtmp, grp5x + 240, grp5y)
                grp5y += (fh + 5)

                objGraphics.DrawString("Current  ", objfont, objBrushtmp, grp5x + 120, grp5y)
                objGraphics.DrawString("Previous  ", objfont, objBrushtmp, grp5x + 240, grp5y)
                grp5y += (fh + 5)

                If (st(27) >= 100) Then
                    st(27) = 100
                End If

                objGraphics.DrawString("PH  ", objfont, objBrushtmp, grp5x, grp5y)
                objGraphics.DrawString(" ", objfont, objBrushtmp, grp5x + 120, grp5y)
                objGraphics.DrawString(st(34), objfont, objBrushtmp, grp5x + 240, grp5y)
                grp5y += fh

                objGraphics.DrawString("HM  ", objfont, objBrushtmp, grp5x, grp5y)
                objGraphics.DrawString(" ", objfont, objBrushtmp, grp5x + 120, grp5y)
                objGraphics.DrawString(st(35), objfont, objBrushtmp, grp5x + 240, grp5y)
                grp5y += fh

                objGraphics.DrawString("LENGTH:  ", objfont, objBrushtmp, grp5x, grp5y)
                objGraphics.DrawString(st(31), objfont, objBrushtmp, grp5x + 240, grp5y)
                grp5y += fh

                objGraphics.DrawString("Type  ", objfont, objBrushtmp, grp5x, grp5y)
                objGraphics.DrawString(st(29), objfont, objBrushtmp, grp5x + 120, grp5y)
                objGraphics.DrawString(st(36), objfont, objBrushtmp, grp5x + 240, grp5y)
                grp5y += fh

                objGraphics.DrawString("Loc  ", objfont, objBrushtmp, grp5x, grp5y)
                objGraphics.DrawString(st(30), objfont, objBrushtmp, grp5x + 120, grp5y)
                objGraphics.DrawString(st(37), objfont, objBrushtmp, grp5x + 240, grp5y)
                grp5y += fh

                objGraphics.DrawString("Class  ", objfont, objBrushtmp, grp5x, grp5y)
                objGraphics.DrawString(st(32), objfont, objBrushtmp, grp5x + 120, grp5y)
                objGraphics.DrawString(st(38), objfont, objBrushtmp, grp5x + 240, grp5y)
                grp5y += fh

                objGraphics.DrawString("Flaw Code  ", objfont, objBrushtmp, grp5x, grp5y)
                objGraphics.DrawString(st(33), objfont, objBrushtmp, grp5x + 120, grp5y)
                objGraphics.DrawString("Jog Plate Provided " & st(44), objfont, objBrushtmp, grp5x + 227, grp5y) 'Jog plate


                Dim lt1 As Integer = lt + fh
                'lt = 120
                lt = 180
                Dim Tm As Integer = lt    ' 110
                Dim Bm As Integer = Tm + 0.52 * Me.Height       '200
                Dim Rm As Integer = Me.Width - 20
                Dim Lm2 As Integer = 10
                Dim Rm2 As Integer = Me.Width - 410 '260
                Dim Sx As Single = (Rm2 - Lm2) / upt
                Dim Sy As Single = (Tm - Bm) / ymax
                Dim vmax As Single = 0
                Dim imax As Integer = 0
                Dim gs As Integer = DataArrCh10(0, 4)              '* sx
                Dim ge As Integer = gs + DataArrCh10(0, 5)         '* sx
                Dim gs2 As Integer = DataArrCh10(0, 7)              '* sx
                Dim ge2 As Integer = gs + DataArrCh10(0, 8)         '* sx

                Dim t_prs As Integer = r * Sy

                Dim intRawRejection As Integer = Convert.ToInt32(DataArrCh10(0, 3))

                For i = 0 To upt

                    pt1(i).X = i * Sx - 15

                    If Convert.ToInt32(pt0(i).Y) <= intRawRejection Then
                        pt0(i).Y = 0
                    End If

                    If i > upt Then
                        pt1(i).X = i * Sx
                        pt0(i).Y = 0
                    End If

                    pt1(i).Y = pt0(i).Y * Sy + Bm

                    If pt1(i).Y < T1 Or pt1(i).Y < T2 Then
                        pt1(i).Y = 0
                    Else
                        If i >= gs And i <= ge Or i >= gs2 And i <= ge2 Then
                            If vmax < pt0(i).Y Then
                                vmax = pt0(i).Y
                                imax = i
                            End If
                        End If
                        If (pt1(i).Y < Tm) Then
                            pt1(i).Y = Tm + 1
                        End If
                    End If
                Next

                vmax /= 2.55

                pt1(upt - 1).Y = Bm
                pt1(upt).X = Lm2
                pt1(upt).Y = Bm
                Dim ii As Integer = 0

                'reject condition
                Dim reject_eff As Integer
                If DataArrCh10(0, 10) = 0 Then
                    reject_eff = Format((((CSng(DataArrCh10(0, 3)) / ymaxS) - 20) / 0.8), "#0")
                Else
                    reject_eff = Format(CSng(DataArrCh10(0, 3)) / ymaxS, "#0")
                End If

                'Gain
                Dim gainfile As String = ""
                Dim gainData As String = ""
                Dim strGain10cch As String = ""
                gainfile = "\SD Card\gaindata" & st(1) & ".txt"

                Dim gainReader As StreamReader = New StreamReader(gainfile)

                For z = 0 To 10
                    gainData = gainReader.ReadLine
                Next

                Dim gndt() As String = Split(gainData, ",")
                strGain10cch = gndt(1)

                ii = (Rm2 - Lm2) / 10
                i = Lm2
                objGraphics.DrawString(Format(strGain10cch / 2.0, "0.0"), objfont, objBrushBlk, i, Tm - 24)
                objGraphics.DrawString(lblGain.Text, objfont, objBrushBlk, i, Tm - 45)
                i = i + ii

                'Delay
                objGraphics.DrawString(Format((DataArrCh10(0, 2) * 0.2941), "0"), objfont, objBrushBlk, i, Tm - 24)
                objGraphics.DrawString(lblDelay.Text, objfont, objBrushBlk, i - 5, Tm - 45)
                i = i + ii

                'range
                Dim intRange As Integer
                Dim strWav As String = ""
                Dim anglefile As String = ""
                Dim angleData As String = ""
                Dim strangle10cch As String = ""
                anglefile = "\SD Card\angdata10.txt"

                Dim angleReader As StreamReader = New StreamReader(anglefile)

                For q = 1 To st(1)
                    angleData = angleReader.ReadLine
                Next

                Dim angledt() As String = Split(angleData, ",")
                strangle10cch = angledt(1)

                Dim ang As Single
                ang = (Convert.ToInt32(strangle10cch) \ 256) / 10

                If ang = 0 Then
                    strWav = "1"
                ElseIf ang > 30 Then
                    strWav = "2"
                End If

                If strWav = "1" Then
                    intRange = Format(DataArrCh10(0, 1) * ml2mm1, "0")
                ElseIf strWav = "2" Then
                    intRange = Format(DataArrCh10(0, 1) * ml2mm2, "0")
                End If

                objGraphics.DrawString(intRange, objfont, objBrushtmp, i, Tm - 24)
                objGraphics.DrawString(lblRange.Text, objfont, objBrushBlk, i - 8, Tm - 45)
                i = i + ii

                'reject
                objGraphics.DrawString(Format(CSng(DataArrCh10(0, 3)) / ymaxS, "#0"), objfont, objBrushtmp, i, Tm - 24)
                objGraphics.DrawString(lblReject.Text, objfont, objBrushBlk, i - 8, Tm - 45)
                i = i + ii

                'gate1st 
                Dim dbGate1St As Double
                dbGate1St = Format(((DataArrCh10(0, 4) / DataArrCh10(0, 1))) * 100, "###0")
                objGraphics.DrawString(dbGate1St, objfont, objBrushtmp, i, Tm - 24)
                objGraphics.DrawString(lblGateS.Text, objfont, objBrushBlk, i - 6, Tm - 45)
                i = i + ii

                ' g1wd                
                objGraphics.DrawString(Format(((DataArrCh10(0, 5) / DataArrCh10(0, 1)) * 100) + dbGate1St, "###0"), objfont, objBrushtmp, i, Tm - 24)
                objGraphics.DrawString(lblGateW.Text, objfont, objBrushBlk, i - 5, Tm - 45)
                i = i + ii

                'Threshold1
                objGraphics.DrawString(Format(CSng(DataArrCh10(0, 6)) / ymaxS, "#0"), objfont, objBrushtmp, i + 7, Tm - 24)
                objGraphics.DrawString(lblThresh.Text, objfont, objBrushBlk, i + 7, Tm - 45)
                i = i + ii

                'gate2st 
                Dim dbGate2Start As Double
                dbGate2Start = Format((DataArrCh10(0, 7) / DataArrCh10(0, 1)) * 100, "###0")
                objGraphics.DrawString(dbGate2Start, objfont, objBrushtmp, i, Tm - 24)
                objGraphics.DrawString(lblG2St.Text, objfont, objBrushBlk, i - 6, Tm - 45)
                i = i + ii

                ' g2wd                
                objGraphics.DrawString(Format(((DataArrCh10(0, 8) / DataArrCh10(0, 1)) * 100) + dbGate2Start, "###0"), objfont, objBrushtmp, i, Tm - 24)
                objGraphics.DrawString(lblG2Wd.Text, objfont, objBrushBlk, i - 5, Tm - 45)
                i = i + ii

                'Threshold2
                objGraphics.DrawString(Format(CSng(DataArrCh10(0, 9) / ymaxS), "0"), objfont, objBrushtmp, i + 10, Tm - 24)
                objGraphics.DrawString(lblThr2.Text, objfont, objBrushBlk, i + 10, Tm - 45)
                i = i + ii

                'Angle
                objGraphics.DrawString(Format(ang, "0.0"), objfont, objBrushtmp, i - 4, Tm - 24)
                objGraphics.DrawString(lblAng.Text, objfont, objBrushBlk, i - 8, Tm - 45)

                ii = 0
                For i = Lm2 To Rm2 Step (Rm2 - Lm2) / 10
                    If ii = 0 Then
                        objGraphics.DrawLine(objBackPen, i, Tm, i, 768)
                    Else
                        objGraphics.DrawLine(objBackPen, i, Tm, i, Bm)
                    End If
                    ii += 1

                    If ii <> 11 Then
                        objGraphics.DrawString(Format(ii), objfont, objBrushtmp, i + 40, Bm - 21)
                    End If
                Next i

                ii = 0
                Dim k As Integer = 100
                For i = Tm To Bm Step (Bm - Tm) / 10
                    If ii = 10 Then
                        objGraphics.DrawLine(objBackPen, Lm2, i + 1, 1024, i + 1)
                    Else
                        objGraphics.DrawLine(objBackPen, Lm2, i, Rm2, i)
                    End If
                    ii += 1
                    If ii <> 11 Then
                        objGraphics.DrawString(Format(k, "0"), objfont, objBrushtmp, Lm2 + 7, i + 7)
                    End If
                    k -= 10
                Next i

                Dim tpen As New Pen(Color.Black)

                If objPens(9).Color <> Color.White Then
                    tpen.Color = objPens(9).Color
                End If

                'A-scan draw
                objGraphics.DrawPolygon(tpen, pt1)

            Else
                '1 to 9 channel
                Dim blackpen As New Pen(Color.Black)
                Dim objboldfont1 As New Font(FontFamily.GenericSansSerif, 11.0F, FontStyle.Bold)
                Dim i As Integer, j As Integer
                Dim objBrushtmp As Brush, objBrushGrp As Brush
                Dim railbmp As Bitmap
                Dim grp1x As Integer = 16 '10
                Dim grp1y As Integer = 6 '4
                Dim grp2x As Integer = 256 ' 160
                Dim grp2y As Integer = 6 '4
                Dim grp3x As Integer = 632 '395
                Dim grp3y As Integer = 6 '4
                Dim grp4x As Integer = 632 '395
                Dim grp4y As Integer = 192 '120
                Dim grp5x As Integer = 632 '395
                Dim grp5y As Integer
                Dim r As Integer = DataArr(j, 3)
                Dim reject_eff As Integer

                Dim T1 As Integer = CSng(DataArr(j, 6)) / ymaxS
                Dim T2 As Integer = CSng(DataArr(j, 9)) / ymaxS

                If gtype = 1 Then
                    objBrushtmp = objBrush3
                    objBrushGrp = objBrushes(curi Mod 10)
                    objGraphics.Clear(Color.Black)
                Else
                    objBrushtmp = objBrushBlk
                    objBrushGrp = objBrushBlk
                    objGraphics.Clear(Color.White)
                End If

                Dim bb(3) As Byte
                Dim st(45) As String
                Dim objfont As New Font(FontFamily.GenericSansSerif, 11.0F, FontStyle.Regular)
                Dim objFS As FileStream = New FileStream(datafile, FileMode.Open, FileAccess.Read)
                Dim objBR As BinaryReader = New BinaryReader(objFS)

                For i = 0 To st.GetUpperBound(0)
                    st(i) = objBR.ReadString
                Next i

                For i = 0 To DataArr.GetUpperBound(0)
                    For j = 0 To DataArr.GetUpperBound(1)
                        DataArr(i, j) = objBR.ReadInt32
                    Next j
                Next i

                j = curi
                Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
                Dim upt As Integer = DataArr(curi, 2)
                ReDim pt0(upt)
                Dim pt1(upt) As Point
                Dim gate1start As Integer = Format((DataArr(j, 4) / DataArr(j, 2)) * 100, "###0")
                Dim gate1end As Integer = Format(((DataArr(j, 5) / DataArr(j, 2)) * 100) + ((DataArr(j, 4) / DataArr(j, 2))) * 100, "###0")
                Dim gate2start As Integer = Format((DataArr(j, 7) / DataArr(j, 2)) * 100, "###0")
                Dim gate2end As Integer = Format(((DataArr(j, 8) / DataArr(j, 2)) * 100) + ((DataArr(j, 7) / DataArr(j, 2))) * 100, "###0")
                Dim angle As Integer = (Convert.ToInt32(DataArr(j, 10)) \ 256) / 10
                objFS.Seek(IIf(curi > 6, curi + 1, curi) * 2048 + DataArr(curi, 1), SeekOrigin.Current)

                For i = 0 To upt
                    pt0(i).X = i
                    pt0(i).Y = objFS.ReadByte
                Next i

                objBR.Close()
                objFS.Close()

                Dim Lm As Integer = 16 '10
                Dim fh As Integer = 22 '14
                Dim lt As Integer = 0
                lt = 0

                Dim wav As Integer, ang As Single
                GetWaveAng(j, wav, ang)

                '1st Group
                objGraphics.DrawString("Test Information: ", objfont, objBrushtmp, grp1x, grp1y)

                grp1y += fh
                objGraphics.DrawString("M/C No:PE-" & mstrr(0) & "/" & st(0), objfont, objBrushtmp, grp1x, grp1y)
                grp1y += fh
                objGraphics.DrawString("Division: " & st(5), objfont, objBrushtmp, grp1x, grp1y)
                grp1y += fh
                objGraphics.DrawString("Start Km,M/ Tp : " & st(7) & "," & st(8) & " /" & st(9), objfont, objBrushtmp, grp1x, grp1y)
                grp1y += fh
                objGraphics.DrawString("Date: " & st(3), objfont, objBrushtmp, grp1x, grp1y)
                grp1y += (fh + (fh / 2))
                objGraphics.DrawString("Prameter Values", objfont, objBrushtmp, grp1x - 6, grp1y - 13)

                '2nd Group
                Dim fstr As String() = datafile.Split("\")
                objGraphics.DrawString("File:  " & fstr(3) & "  \" & fstr(4) & "\" & fstr(5), objfont, objBrushtmp, grp2x + 32, grp2y)
                grp2y += fh
                objGraphics.DrawString("OP NAME / Code:  " & st(2), objfont, objBrushtmp, grp2x + 32, grp2y)
                grp2y += fh
                objGraphics.DrawString("Block Section: " & st(6), objfont, objBrushtmp, grp2x + 32, grp2y)
                grp2y += fh
                objGraphics.DrawString("Line: " & st(11), objfont, objBrushtmp, grp2x + 32, grp2y)
                grp2y += fh
                objGraphics.DrawString("Start Time: " & st(4), objfont, objBrushtmp, grp2x + 32, grp2y)
                grp2y += fh

                '3rd Group
                objGraphics.DrawString("                     Location  ", objfont, objBrushtmp, grp3x, grp3y)
                grp3y += fh
                'objGraphics.DrawRectangle(blackpen, grp3x + 55, grp3y + 2, 130, 29)
                objGraphics.DrawRectangle(blackpen, grp3x + 88, grp3y + 3, 208, 46)
                objGraphics.DrawString("     Km   Km   m   ", objboldfont1, objBrushtmp, grp3x + 91, grp3y + 6)
                objGraphics.DrawString("     " & st(17) & " -" & st(18), objboldfont1, objBrushtmp, grp3x + 91, grp3y + fh)
                grp3y += 67
                objGraphics.DrawString("Latitude  ", objfont, objBrushtmp, grp3x, grp3y)
                objGraphics.DrawString("Longtitude  ", objfont, objBrushtmp, grp3x + 208, grp3y)
                grp3y += fh
                ' Latitude
                objGraphics.DrawRectangle(blackpen, grp3x, grp3y, 160, 31)
                Dim deg() As String, min() As String, secs() As String ', dir() As String
                deg = st(39).Split("°")
                min = deg(1).Split("''")
                secs = st(39).Split("'")
                objGraphics.DrawString(Format(deg(0) + 0, "00") & "° " & Format(min(0) + 0, "00") & "' " & Format(secs(1) + 0, "00.00") & "'' " & "N", objfont, objBrushtmp, grp3x + 6, grp3y + 3)
                'Longtitude
                objGraphics.DrawRectangle(blackpen, grp3x + 208, grp3y, 160, 31)
                Dim deg1() As String, min1() As String, secs1() As String
                deg1 = st(40).Split("°")
                min1 = deg1(1).Split("''")
                secs1 = st(40).Split("'")
                objGraphics.DrawString(Format(deg1(0) + 0, "00") & "° " & Format(min1(0) + 0, "00") & "' " & Format(secs1(1) + 0, "00.00") & "'' " & "E", objfont, objBrushtmp, grp3x + 213, grp3y + 3)

                '4th Group
                Dim objboldfont As New Font(FontFamily.GenericSansSerif, 11.0F, FontStyle.Bold)
                objGraphics.DrawString("Defect Details:  ", objboldfont, objBrushtmp, grp4x, grp4y)
                grp4y += (fh + 3)
                objGraphics.DrawString("Km,M/ Tp : " & Format(st(13) + 0, "0000") & "," & st(14) & " /" & st(15), objboldfont, objBrushtmp, grp4x, grp4y)
                grp4y += fh
                objGraphics.DrawString("Stations:  " & st(19) & "-" & st(20), objfont, objBrushtmp, grp4x, grp4y)
                grp4y += (fh + 3)
                objGraphics.DrawString("Rolling Mark:  " & st(21) & "_" & st(22) & "_" & st(23) & "_" & st(24), objfont, objBrushtmp, grp4x, grp4y)
                grp4y += fh
                objGraphics.DrawString("Rail/Weld No:  " & st(16), objboldfont, objBrushtmp, grp4x, grp4y)
                grp4y += fh
                objGraphics.DrawString("Probe:  " & st(25) & "      " & st(26), objfont, objBrushtmp, grp4x, grp4y)
                grp4y += fh

                grp5y = grp4y

                Dim PH_data As Integer = 0
                If st(27).ToString().Trim() = "" Then
                    st(27) = "0"
                End If

                PH_data = st(27)
                If (PH_data >= 100) Then
                    PH_data = 100
                End If

                If PH_data = 0 Then
                    st(41) = 0
                    st(28) = 0
                    st(42) = 0
                End If

                Dim intPhValue As String = 0

                If PH_data.ToString.Trim <> "" Then
                    intPhValue = Convert.ToInt32(PH_data)
                End If

                objGraphics.DrawString("PH:  " & intPhValue, objfont, objBrushtmp, grp5x, grp5y)

                If ang = 0 Then
                    Dim intDValue As String = 0

                    If st(41).ToString.Trim <> "" Then
                        intDValue = Convert.ToInt32(st(41))
                    End If

                    Dim intBPValue As String = 0

                    If st(28).ToString.Trim <> "" Then
                        intBPValue = Convert.ToInt32(st(28))
                    End If

                    objGraphics.DrawString("D:  " & intDValue.ToString, objfont, objBrushtmp, grp5x + 120, grp5y)
                    objGraphics.DrawString("CalSet:  " & st(1), objfont, objBrushtmp, grp5x + 240, grp5y)
                    grp5y += (fh + 8)
                    objGraphics.DrawString("BP:  " & intBPValue, objfont, objBrushtmp, grp5x, grp5y)
                Else
                    objGraphics.DrawString("D:  " & st(41), objfont, objBrushtmp, grp5x + 120, grp5y)
                    objGraphics.DrawString("CalSet:  " & st(1), objfont, objBrushtmp, grp5x + 240, grp5y)
                    grp5y += (fh + 8)
                    objGraphics.DrawString("BP:  " & st(28), objfont, objBrushtmp, grp5x, grp5y)
                End If
                
                objGraphics.DrawString("SD:  " & st(42), objfont, objBrushtmp, grp5x + 120, grp5y)
                objGraphics.DrawString("Channel:  " & Format(curi + 1, "00"), objfont, objBrushtmp, grp5x + 240, grp5y)
                grp5y += (fh + 5)
                objGraphics.DrawString("Current  ", objfont, objBrushtmp, grp5x + 120, grp5y)
                objGraphics.DrawString("Previous  ", objfont, objBrushtmp, grp5x + 240, grp5y)
                grp5y += (fh + 5)
                If (st(27) >= 100) Then
                    st(27) = 100
                End If

                objGraphics.DrawString("PH  ", objfont, objBrushtmp, grp5x, grp5y)
                objGraphics.DrawString(" ", objfont, objBrushtmp, grp5x + 120, grp5y)
                objGraphics.DrawString(st(34), objfont, objBrushtmp, grp5x + 240, grp5y)
                grp5y += fh
                objGraphics.DrawString("HM  ", objfont, objBrushtmp, grp5x, grp5y)
                objGraphics.DrawString(" ", objfont, objBrushtmp, grp5x + 120, grp5y)
                objGraphics.DrawString(st(35), objfont, objBrushtmp, grp5x + 240, grp5y)
                grp5y += fh

                objGraphics.DrawString("LENGTH:  ", objfont, objBrushtmp, grp5x, grp5y)
                objGraphics.DrawString(st(31), objfont, objBrushtmp, grp5x + 120, grp5y)
                grp5y += fh
                objGraphics.DrawString("Type  ", objfont, objBrushtmp, grp5x, grp5y)
                objGraphics.DrawString(st(29), objfont, objBrushtmp, grp5x + 120, grp5y)
                objGraphics.DrawString(st(36), objfont, objBrushtmp, grp5x + 240, grp5y)
                grp5y += fh
                objGraphics.DrawString("Loc  ", objfont, objBrushtmp, grp5x, grp5y)
                objGraphics.DrawString(st(30), objfont, objBrushtmp, grp5x + 120, grp5y)
                objGraphics.DrawString(st(37), objfont, objBrushtmp, grp5x + 240, grp5y)
                grp5y += fh
                objGraphics.DrawString("Class  ", objfont, objBrushtmp, grp5x, grp5y)
                objGraphics.DrawString(st(32), objfont, objBrushtmp, grp5x + 120, grp5y)
                objGraphics.DrawString(st(38), objfont, objBrushtmp, grp5x + 240, grp5y)
                grp5y += fh
                objGraphics.DrawString("Flaw Code  ", objfont, objBrushtmp, grp5x, grp5y - 5)
                objGraphics.DrawString(st(33), objfont, objBrushtmp, grp5x + 120, grp5y - 5)
                objGraphics.DrawString("Jog Plate Provided " & st(44), objfont, objBrushtmp, grp5x + 227, grp5y - 5) 'Jog plate

                Dim lt1 As Integer = lt + fh

                lt = 180 '  120
                Dim Tm As Integer = lt    ' 110
                Dim Bm As Integer = Tm + 0.52 * Me.Height       '200
                Dim Rm As Integer = Me.Width - 20
                Dim Lm2 As Integer = 10
                Dim Rm2 As Integer = Me.Width - 410 '260

                Dim Sx As Single = (Rm2 - Lm2) / upt
                Dim Sy As Single = (Tm - Bm) / ymax
                Dim vmax As Single = 0
                Dim imax As Integer = 0
                Dim gs As Integer = DataArr(j, 4)              '* sx
                Dim ge As Integer = gs + DataArr(j, 5)         '* sx
                Dim gs2 As Integer = DataArr(j, 7)              '* sx
                Dim ge2 As Integer = gs2 + DataArr(j, 8)         '* sx

                Dim t_prs As Integer = r * Sy

                Dim intRawRejection As Integer = Convert.ToInt32(DataArr(j, 3))

                For i = 0 To upt

                    pt1(i).X = i * Sx + Lm2

                    If Convert.ToInt32(pt0(i).Y) <= intRawRejection Then
                        pt0(i).Y = 0
                    End If

                    pt1(i).Y = pt0(i).Y * Sy + Bm

                    If pt1(i).Y < T1 Or pt1(i).Y < T2 Then
                        pt1(i).Y = 0
                    Else
                        If i >= gs And i <= ge Or i >= gs2 And i <= ge2 Then
                            If vmax < pt0(i).Y Then
                                vmax = pt0(i).Y
                                imax = i
                            End If
                        End If
                        If (pt1(i).Y < Tm) Then
                            pt1(i).Y = Tm + 1
                        End If
                    End If
                Next

                vmax /= 2.55 ' 2.4

                pt1(upt - 1).Y = Bm
                pt1(upt).X = Lm2
                pt1(upt).Y = Bm

                Dim ii As Integer = 0

                ii = (Rm2 - Lm2) / 10
                i = Lm2

                'reject condition
                If j = 0 Or j = 9 Then
                    reject_eff = Format(CSng(DataArr(j, 3)) / ymaxS, "#0")
                End If

                If j = 1 Or j = 2 Or j = 3 Or j = 4 Or j = 5 Or j = 6 Or j = 8 Or j = 10 Or j = 11 Or j = 12 Or j = 13 Then
                    reject_eff = Format(CSng(DataArr(j, 3)) / ymaxS, "#0")
                End If

                'Gain
                If angle = 70 Then
                    If j = 1 Or j = 2 Or j = 3 Or j = 4 Then
                        If gain10dbval.ToString.Trim = "10" Then
                            objGraphics.DrawString(Format((DataArr(j, 0) + 20) / 2.0, "0.0"), objfont, objBrushBlk, i, Tm - 24)
                            objGraphics.DrawString(lblGain.Text, objfont, objBrushBlk, i, Tm - 45)
                            i = i + ii
                        ElseIf gain10dbval.ToString.Trim = "-10" Then
                            objGraphics.DrawString(Format((DataArr(j, 0) - 20) / 2.0, "0.0"), objfont, objBrushBlk, i, Tm - 24)
                            objGraphics.DrawString(lblGain.Text, objfont, objBrushBlk, i, Tm - 45)
                            i = i + ii
                        Else
                            objGraphics.DrawString(Format(DataArr(j, 0) / 2.0, "0.0"), objfont, objBrushBlk, i, Tm - 24)
                            objGraphics.DrawString(lblGain.Text, objfont, objBrushBlk, i, Tm - 45)
                            i = i + ii
                        End If
                    End If
                ElseIf curi = 7 Then
                    objGraphics.DrawString(Format(DataArr(8, 0) / 2.0, "0.0"), objfont, objBrushBlk, i, Tm - 24)
                    objGraphics.DrawString(lblGain.Text, objfont, objBrushBlk, i, Tm - 45)
                    i = i + ii
                Else
                    objGraphics.DrawString(Format(DataArr(j, 0) / 2.0, "0.0"), objfont, objBrushBlk, i, Tm - 24)
                    objGraphics.DrawString(lblGain.Text, objfont, objBrushBlk, i, Tm - 45)
                    i = i + ii
                End If


                'Delay
                objGraphics.DrawString(Format((DataArr(j, 1) * 0.2941), "0"), objfont, objBrushBlk, i, Tm - 24)
                objGraphics.DrawString(lblDelay.Text, objfont, objBrushBlk, i - 8, Tm - 45)
                i = i + ii

                'Ramge
                objGraphics.DrawString(Format(Rangemm(DataArr(j, 2), j), "0"), objfont, objBrushtmp, i, Tm - 24)
                objGraphics.DrawString(lblRange.Text, objfont, objBrushBlk, i - 8, Tm - 45)
                i = i + ii

                'reject
                objGraphics.DrawString(Format(reject_eff, "0"), objfont, objBrushtmp, i, Tm - 24)
                objGraphics.DrawString(lblReject.Text, objfont, objBrushBlk, i - 8, Tm - 45)
                i = i + ii

                'gate1st 
                objGraphics.DrawString(Format((DataArr(j, 4) / DataArr(j, 2)) * 100, "###0"), objfont, objBrushtmp, i, Tm - 24)
                objGraphics.DrawString(lblGateS.Text, objfont, objBrushBlk, i - 9, Tm - 45)
                i = i + ii

                ' g1wd

                objGraphics.DrawString(Format(((DataArr(j, 5) / DataArr(j, 2)) * 100) + ((DataArr(j, 4) / DataArr(j, 2))) * 100, "###0"), objfont, objBrushtmp, i, Tm - 24)
                objGraphics.DrawString(lblGateW.Text, objfont, objBrushBlk, i - 5, Tm - 45)
                i = i + ii

                'Threshold 1
                objGraphics.DrawString(Format(CSng(DataArr(j, 6) / ymaxS), "0"), objfont, objBrushtmp, i + 7, Tm - 24)
                objGraphics.DrawString(lblThresh.Text, objfont, objBrushBlk, i + 7, Tm - 45)
                i = i + ii

                'g2st
                objGraphics.DrawString(Format((DataArr(j, 7) / DataArr(j, 2)) * 100, "0"), objfont, objBrushtmp, i, Tm - 24)
                objGraphics.DrawString(lblG2St.Text, objfont, objBrushBlk, i - 5, Tm - 45)
                i = i + ii

                'g2wd
                objGraphics.DrawString(Format(((DataArr(j, 8) / DataArr(j, 2)) * 100) + ((DataArr(j, 7) / DataArr(j, 2))) * 100, "0"), objfont, objBrushtmp, i, Tm - 24)
                objGraphics.DrawString(lblG2Wd.Text, objfont, objBrushBlk, i - 5, Tm - 45)
                i = i + ii

                'Threshold 2
                objGraphics.DrawString(Format(CSng(DataArr(j, 9) / ymaxS), "0"), objfont, objBrushtmp, i + 7, Tm - 24)
                objGraphics.DrawString(lblThr2.Text, objfont, objBrushBlk, i + 7, Tm - 45)
                i = i + ii

                'Angle
                objGraphics.DrawString(Format(angle, "0.0"), objfont, objBrushtmp, i - 3, Tm - 24)
                objGraphics.DrawString(lblAng.Text, objfont, objBrushBlk, i - 8, Tm - 45)
                ii = 0

                For i = Lm2 To Rm2 Step (Rm2 - Lm2) / 10
                    If ii = 0 Then
                        objGraphics.DrawLine(objBackPen, i, Tm, i, 768)
                    Else
                        objGraphics.DrawLine(objBackPen, i, Tm, i, Bm)
                    End If
                    ii += 1

                    If ii <> 11 Then
                        objGraphics.DrawString(Format(ii), objfont, objBrushtmp, i + 40, Bm - 21)
                    End If
                Next i

                ii = 0

                Dim k As Integer = 100
                For i = Tm To Bm Step (Bm - Tm) / 10
                    If ii = 10 Then
                        'objGraphics.DrawLine(objBackPen, Lm2, i + 2, 1024, i + 2)
                        objGraphics.DrawLine(objBackPen, Lm2, Bm, 1024, Bm)
                        MessageBox.Show("Bottom line geesthunam ra thamudu")
                    Else
                        objGraphics.DrawLine(objBackPen, Lm2, i, Rm2, i)
                    End If
                    ii += 1
                    If ii <> 11 Then
                        objGraphics.DrawString(Format(k, "0"), objfont, objBrushtmp, Lm2 + 8, i + 8)
                    End If
                    k -= 10
                Next i
                'objGraphics.DrawLine(objBackPen, Lm2, Bm, 1024, Bm)

                'considering Bscan plot above the reject value

                Dim tpen As New Pen(Color.Black)

                If objPens(j).Color <> Color.White Then
                    tpen.Color = objPens(j).Color
                End If

                'Ascan plot
                objGraphics.DrawPolygon(tpen, pt1)

                'Bscan plot
                Dim Channel_Angle As Double
                Dim x_index1 As Double
                Dim BScan_data As Double
                Dim X_val As Integer
                Dim ai As Integer
                Dim aj As Integer

                Dim ch_range As Integer = (Format(Rangemm(DataArr(j, 2), j), "0"))

                Dim ph_value As Integer = st(27)

                For i = 0 To upt
                    If pt1(i).Y = Bm Then '370 Then
                        Continue For
                    End If

                    If j = 0 Then
                        If ch_range = 200 Then
                            BScan_data = (pt1(i).X - 10) * (103 / 300)
                        ElseIf ch_range = 300 Then
                            BScan_data = (pt1(i).X - 10) * (103 / 210)
                        Else
                            If ch_range = 200 Then
                                If ang = 37.0 Then
                                    BScan_data = (pt1(i).X - 10) * (103 / 300)
                                End If
                            Else
                                BScan_data = (pt1(i).X - 10) * (103 / 300)
                            End If
                        End If
                    Else
                        BScan_data = (pt1(i).X - 10) * (103 / 228)
                    End If

                    If angle = 0 Then
                        'considering Bscan plot above the reject and threshold1 value 
                        If ph_value > T1 Or ph_value > T2 Then
                            Channel_Angle = 1
                            x_index1 = 480 '300

                        ElseIf pt0(i).Y < T1 Then

                        Else

                        End If
                    ElseIf angle = 70 Then
                        If curi = 1 Or curi = 3 Or curi = 5 Or curi = 7 Then
                            Channel_Angle = 0.3
                            x_index1 = 480 - (X_val * 0.4095) ' 300 - (X_val * 0.4095)
                        ElseIf curi = 2 Or curi = 4 Or curi = 6 Or curi = 8 Then
                            Channel_Angle = 0.3
                            x_index1 = 480 + (X_val * 0.2941)
                        End If
                    ElseIf angle = 37 Then
                        If curi = 1 Or curi = 3 Then
                            Channel_Angle = 0.6
                            x_index1 = 480 - (X_val * 0.4095)
                        ElseIf curi = 2 Or curi = 4 Then
                            Channel_Angle = 0.6
                            x_index1 = 480 + (X_val * 0.2941)
                        End If
                    End If

                    X_val = BScan_data * Channel_Angle

                    If (((X_val * 500) + 300) > (500 * 100)) Then
                        X_val = 103 - 1
                    End If

                    BSCANBUFF((X_val * 500) + x_index1) = 22

                    For ai = 0 To 99 Step 1
                        For aj = 0 To 500 - 1 Step 1

                            If BSCANBUFF((ai * 500) + aj) <> 0 Then
                                If ch_range = 200 Then
                                    'objGraphics.DrawLine(tpen, aj + 62, 380 + ai, aj + 63, 380 + ai)
                                    objGraphics.DrawLine(tpen, aj + 99, 608 + ai, aj + 101, 608 + ai)
                                ElseIf ch_range = 275 Then
                                    If ang = 37.0 Then
                                        'objGraphics.DrawLine(tpen, aj + 0, 390 + ai, aj + 1, 390 + ai)
                                        objGraphics.DrawLine(tpen, aj + 0, 624 + ai, aj + 1, 624 + ai)
                                    End If
                                ElseIf ch_range = 300 Then
                                    'objGraphics.DrawLine(tpen, aj + 62, 377 + ai, aj + 63, 377 + ai)
                                    objGraphics.DrawLine(tpen, aj + 99, 603 + ai, aj + 101, 603 + ai)
                                Else
                                    'objGraphics.DrawLine(tpen, aj + 62, 365 + ai, aj + 63, 365 + ai)
                                    objGraphics.DrawLine(tpen, aj + 99, 584 + ai, aj + 101, 584 + ai)
                                End If
                            End If
                        Next
                    Next
                Next

                lt = Bm + fh
                railbmp = New Bitmap("\SD Card\rail.bmp")
                'objGraphics.DrawImage(railbmp, 380, 375)
                objGraphics.DrawImage(railbmp, 608, 600)
                railbmp.Dispose()
                'objGraphics.DrawLine(objBackPen, 10, 374, 400, 374)
                'objGraphics.DrawLine(objBackPen, 10, 410, 400, 410)
                'objGraphics.DrawLine(objBackPen, 10, 478, 640, 478)
                objGraphics.DrawLine(objBackPen, 10, 598, 640, 598)
                objGraphics.DrawLine(objBackPen, 10, 656, 640, 656)
                objGraphics.DrawLine(objBackPen, 10, 765, 1024, 765)
                lt += fh
                objGraphicsFrm.DrawImage(bmp, 0, 0)
            End If

                Dim fnm As String = Mid(datafile, 1, Len(datafile) - 4) & "_PRS.jpg" '"bmp"
                If File.Exists(fnm) Then File.Delete(fnm)
                bmp.Save(fnm, System.Drawing.Imaging.ImageFormat.Jpeg)
                Me.Text = Me.Text & " -.jpg is Saved "
                Application.DoEvents()

        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "AcquireData2()")
        End Try
    End Sub

    Private Sub PlotEnv(ByRef vmax As Integer, ByRef imax As Integer, ByVal j As Integer)
        Dim nz As Integer
        Dim rect As Rectangle
        rect = New Rectangle(20, meheight - 20, mewidth - 80, -meheight + 60)
        Dim attr As New Drawing.Imaging.ImageAttributes

        nz = bmp.Height
        pt0(imax).Y = nz - vmax
        objGraphics.DrawLine(objPens(j Mod 10), pt0(imax).X, nz, pt0(imax).X, pt0(imax).Y)
        objGraphicsFrm.DrawImage(bmp, rect, 0, bmp.Height, bmp.Width, -bmp.Height, GraphicsUnit.Pixel, attr)
        Application.DoEvents()
    End Sub

    Private Sub PlotCurves(ByRef v() As Byte, Optional ByVal chnl As Integer = -1, Optional ByVal fillpoly As Boolean = False, Optional ByVal zoom As Single = 1.0)
        Try
            Dim nz As Integer
            Dim i As Integer, i2 As Integer, i3 As Integer
            Dim gs As Integer, ge As Integer, gs2 As Integer, ge2 As Integer
            Dim j As Integer
            Dim rect As Rectangle
            Dim strtj As Integer, endj As Integer
            Dim dd As Single

            If chnl = -1 Then strtj = 0 : endj = TotNch Else strtj = chnl : endj = chnl
            rect = New Rectangle(20, meheight - 30, mewidth - 80, -meheight + 50)
            Dim attr As New Drawing.Imaging.ImageAttributes

            nz = bmp.Height
            i2 = 0
            objGraphics.DrawImage(bbmp, 0, 0)
            For j = strtj To endj
                upt = DataArr(j, 2)
                sx = bmp.Width / upt
                nz = bmp.Height
                gs = DataArr(j, 4)              '* sx
                ge = gs + DataArr(j, 5)         '* sx
                gs2 = DataArr(j, 7)              '* sx
                ge2 = gs2 + DataArr(j, 8)         '* sx
                For i = 0 To UBound(pt0)
                    pt0(i).Y = nz
                Next i
                i2 += 1


                Dim vmax As Integer = 0
                Dim vv As Integer, imax As Integer
                For i = 0 + 1 To upt - 1
                    vv = v20(i2) : i2 += 1
                    If i >= gs And i <= ge And i >= gs2 And i <= ge2 Then
                        If vmax < vv Then vmax = vv : imax = i
                    End If
                    vv = nz - vv
                    i3 = Int(i * sx)
                    If pt0(i3).Y > vv Then pt0(i3).Y = vv
                Next i

                Dim imin As Integer
                For imin = imax - 1 To 0
                    vv = v20(imin)
                    If vv <= MINHT Then Exit For
                Next imin
                '-------------------------------------------

                pt0(0).Y = nz : pt0(UBound(pt0)).Y = nz
                If chnl <> -1 Then
                    dd = Rangemm(imax, j)

                    Dim dd1 As Single = Rangemm(imax, j)
                    objGraphics.DrawString("PH=" & Format(vmax / 2.55, "0"), objfont, objBrush2, 150, 10)
                    objGraphics.DrawString("BP=" & Format(dd, "0") & "[" & Format(dd, "0") & "-" & Format(dd, "0") & "]", objfont, objBrush2, 200, 10)

                    If caltyp = 4 Then
                        If TotNch <= 5 Then frmTest.lblHM.Text = "BP"
                        frmTest.txtPH.Text = Format(vmax / 2.55, "0")
                        frmTest.txtHM.Text = Format(dd, "0")
                        frmTest.txtCh.Text = Format(j + 1, "00")
                        frmTest.cmbLR.SelectedIndex = IIf(chnl < 10, 0, 1)
                        frmTest.cmbProbe.SelectedIndex = IIf(chnl < 10, chnl, chnl - 10)
                    End If

                    If chnl Mod 10 <> 0 Then
                        Dim wav As Integer, ang As Single
                        GetWaveAng(curi, wav, ang)
                        TH = ang * Math.PI / 180
                        costh = Math.Cos(TH)
                        sinth = Math.Sin(TH)

                        objGraphics.DrawString("D=" & Format(dd1 * costh, "0"), objfont, objBrush2, 150, 20)
                        objGraphics.DrawString("SD=" & Format(dd1 * sinth, "0"), objfont, objBrush2, 200, 20)
                        objGraphics.DrawString("B1=" & Format(dd1, "0"), objfont, objBrush2, 250, 10)

                        If TotNch <= 5 And caltyp = 4 Then
                            frmTest.txtHM.Text = frmTest.txtHM.Text '& "[D=" & Format(dd * costh, "0") & "," & "SD=" & Format(dd * sinth, "0") & "]"
                        End If

                    End If

                End If

                If chnl <> -1 And fillpoly Then
                    objGraphics.FillPolygon(objBrushes(j Mod 10), pt0)
                    If isstop Then
                        Dim r As Integer = DataArr(j, 3)
                        Dim imin1 As Integer = 0
                        Dim imin2 As Integer = upt
                        For i = imax To 0 Step -1
                            If v20(i) < r Then
                                imin1 = i : Exit For
                            End If
                        Next i
                        For i = imax To upt Step 1
                            If v20(i) < r Then
                                imin2 = i : Exit For
                            End If
                        Next i
                        dd = (imin2 - imin1) * 100.0 / upt
                        objGraphics.DrawString("HM=" & Format(dd, "0"), objfont, objBrush2, 250, 0)
                        frmTest.txtPH.Text = Format(vmax / ymaxS, "0")
                        frmTest.txtHM.Text = Format(dd, "0")
                        frmTest.txtCh.Text = Format(chnl + 1, "0")
                        frmTest.cmbLR.SelectedIndex = IIf(chnl < 10, 0, 1)
                        frmTest.cmbProbe.SelectedIndex = IIf(chnl < 10, chnl, chnl - 10)
                    End If
                Else
                    objGraphics.DrawPolygon(objPens(j Mod 10), pt0)
                End If
            Next j

            objGraphicsFrm.DrawImage(bmp, rect, 0, bmp.Height, bmp.Width / zoom, -bmp.Height, GraphicsUnit.Pixel, attr)
        Catch ex As Exception

        End Try
    End Sub

    'This function is plotting grid and graph curves in edit mode
    Private Sub PlotCurvesT(ByRef v() As Byte, Optional ByVal chnl As Integer = -1, Optional ByVal fillpoly As Boolean = False, Optional ByVal zoom As Single = 1.0)

        Try
            Static nc As Integer = 0
            If isstop Then
                nc = 0
            End If
            Dim nz As Integer
            Dim i As Integer, i2 As Integer, i3 As Integer
            Dim gs As Integer, ge As Integer, gs2 As Integer, ge2 As Integer
            Dim j As Integer
            Dim rect As Rectangle
            Dim strtj As Integer, endj As Integer
            Dim dd As Single

            If chnl = -1 Then strtj = 0 : endj = TotNch Else strtj = chnl : endj = chnl
            'rect = New Rectangle(20, meheight - 30, mewidth - 73, -meheight + 50)
            rect = New Rectangle(50, meheight - 30, mewidth - 150, -meheight + 60)
            Dim attr As New Drawing.Imaging.ImageAttributes
            nz = bmp.Height
            i2 = 0
            objGraphics.DrawImage(bbmp, 0, 0)

            For j = strtj To endj
                upt = DataArr(j, 2)
                sx = bmp.Width / upt
                nz = bmp.Height
                gs = DataArr(j, 4)              '* sx
                ge = gs + DataArr(j, 5)         '* sx
                gs2 = DataArr(j, 7)              '* sx
                ge2 = gs2 + DataArr(j, 8)         '* sx

                For i = 0 To UBound(pt0)
                    pt0(i).Y = nz
                Next i
                i2 += 1
                Dim vmax As Integer = 0

                Dim vv As Integer, imax As Integer
                For i = 0 + 1 To upt - 1
                    vv = v20(i2) : i2 += 1

                    'gate 1
                    If i >= gs And i <= ge Then
                        If vmax < vv Then vmax = vv : imax = i
                    End If

                    'gate2 For 0 And 10 negative
                    If i >= gs2 And i <= ge2 Then
                        If j = 0 Or j = 9 Then
                        Else
                            If vmax < vv Then vmax = vv : imax = i
                        End If
                    End If

                    vv = nz - vv
                    i3 = Int(i * sx)
                    If pt0(i3).Y > vv Then pt0(i3).Y = vv
                Next i

                Dim imin As Integer
                For imin = imax - 1 To 0 Step -1
                    vv = v20(imin)
                    If vv <= MINHT Then Exit For
                Next imin
                pt0(0).Y = nz : pt0(UBound(pt0)).Y = nz

                If chnl <> -1 And nc = 0 Then
                    st1 = "" : st2 = "" : st3 = "" : st4 = "" : st5 = ""
                    dd = Rangemm(imax, j) - 1

                    Dim dd1 As Single = Rangemm(imin, j)
                    Dim t As String = Me.Text
                    st1 = Format(vmax / 2.55, "0")
                    st2 = Format(dd1, "0")
                    If BPval < 0 Then
                        st3 = Format(0, "0")
                    End If
                    st4 = 0
                    BPval = 0

                    


                    Dim anglefile As String = ""
                    Dim angleData As String = ""
                    Dim strangle10cch As String = ""
                    Dim ang As Single

                    'Angle
                    ang = (Convert.ToInt32(DataArr(curi, 10) \ 256) / 10)

                    If Convert.ToInt32(st2) > 0 Then
                        BPval = Convert.ToInt32(st2)
                        If BPval <= 0 Then
                            BPval = 0
                        Else
                            If ang = 0 Then
                                BPval = Convert.ToInt32(st2) - 2
                            Else
                                BPval = Convert.ToInt32(st2)
                            End If
                        End If
                    End If

                    If caltyp = 4 Then
                        If TotNch <= 5 Then frmTest.lblHM.Text = "BP"
                        frmTest.txtPH.Text = Format(vmax / 2.55, "0")
                        frmTest.txtHM.Text = Format(dd, "0")
                        frmTest.txtCh.Text = Format(chnl + 1, "0")
                        frmTest.cmbLR.SelectedIndex = IIf(chnl < 10, 0, 1)
                        frmTest.cmbProbe.SelectedIndex = IIf(chnl < 10, chnl, chnl - 10)
                    End If

                    If chnl Mod 10 <> -1 Or TotNch <= 5 Then
                        Dim wav As Integer
                        GetWaveAng(curi, wav, ang)
                        TH = ang * Math.PI / 180
                        costh = Math.Cos(TH)
                        sinth = Math.Sin(TH)

                        st3 = Format(dd1 * costh, "0")
                        st4 = Format(dd1 * sinth, "0")
                    End If


                    Me.lblPH.Text = st1 & vbCrLf & st2 & vbCrLf & st3 & vbCrLf & st4 & vbCrLf & st5 & vbCrLf

                    If isstopped = False And bEsc = False Then

                        angle = (Convert.ToInt32(DataArr(j, 10) \ 256) / 10)
                        'Calibration BP SD D H vslues on Form Top
                        If angle = 0 Then
                            If Convert.ToInt32(st1) > 100 Then
                                st1 = "100"
                                If BPval <= 0 Then
                                    BPval = 0
                                    Me.Text = frmcap & " Acquiring" & " [PH=" & Double.Parse(st1) & ", BP=" & BPval & ", D=" & BPval & ", SD=" & st4 & "]"
                                Else
                                    Me.Text = frmcap & " Acquiring" & " [PH=" & Double.Parse(st1) & ", BP=" & BPval & ", D=" & BPval & ", SD=" & st4 & "]"
                                End If
                            Else
                                If BPval < 0 Then
                                    BPval = 0
                                    If Convert.ToInt32(st1) < 40 Then
                                        Me.Text = frmcap & " Acquiring" & " [PH=" & Double.Parse(st1) + 1 & ", BP=" & BPval & ", D=" & BPval & ", SD=" & st4 & "]"
                                    Else
                                        Me.Text = frmcap & " Acquiring" & " [PH=" & Double.Parse(st1) & ", BP=" & BPval & ", D=" & BPval & ", SD=" & st4 & "]"
                                    End If
                                Else
                                    If Convert.ToInt32(st1) = 0 Then
                                        Me.Text = frmcap & " Acquiring" & " [PH=" & Double.Parse(st1) & ", BP=" & BPval & ", D=" & BPval & ", SD=" & st4 & "]"
                                    ElseIf Convert.ToInt32(st1) < 30 Then
                                        Me.Text = frmcap & " Acquiring" & " [PH=" & Double.Parse(st1) + 1 & ", BP=" & BPval & ", D=" & BPval & ", SD=" & st4 & "]"
                                    Else
                                        Me.Text = frmcap & " Acquiring" & " [PH=" & Double.Parse(st1) & ", BP=" & BPval & ", D=" & BPval & ", SD=" & st4 & "]"
                                    End If
                                End If
                            End If
                        Else
                            If Convert.ToInt32(st1) > 100 Then
                                st1 = "100"
                                Me.Text = frmcap & " Acquiring" & " [PH=" & Double.Parse(st1) & ", BP=" & BPval & ", D=" & st3 & ", SD=" & st4 & "]"
                            Else
                                If Convert.ToInt32(st1) = 0 Then
                                    Me.Text = frmcap & " Acquiring" & " [PH=" & Double.Parse(st1) & ", BP=" & BPval & ", D=" & st3 & ", SD=" & st4 & "]"
                                ElseIf Convert.ToInt32(st1) < 30 Then
                                    Me.Text = frmcap & " Acquiring" & " [PH=" & Double.Parse(st1) + 1 & ", BP=" & BPval & ", D=" & st3 & ", SD=" & st4 & "]"
                                Else
                                    Me.Text = frmcap & " Acquiring" & " [PH=" & Double.Parse(st1) & ", BP=" & BPval & ", D=" & st3 & ", SD=" & st4 & "]"
                                End If
                            End If
                        End If
                    End If
                End If

                If chnl <> -1 And fillpoly Then
                    objGraphics.FillPolygon(objBrushes(j Mod 10), pt0)
                    If isstop Then
                        Dim r As Integer = DataArr(j, 3)
                        Dim imin1 As Integer = 0
                        Dim imin2 As Integer = upt
                        For i = imax To 0 Step -1
                            If v20(i) < r Then
                                imin1 = i : Exit For
                            End If
                        Next i
                        For i = imax To upt Step 1
                            If v20(i) < r Then
                                imin2 = i : Exit For
                            End If
                        Next i
                        dd = (imin2 - imin1) * 100.0 / upt
                        objGraphics.DrawString("HM=" & Format(dd, "0"), objfont, objBrush2, 250, 0)
                        frmTest.txtPH.Text = Format(vmax / ymaxS, "0")
                        frmTest.txtHM.Text = Format(dd, "0")
                        frmTest.txtCh.Text = Format(chnl + 1, "0")
                        frmTest.cmbLR.SelectedIndex = IIf(chnl < 10, 0, 1)
                        frmTest.cmbProbe.SelectedIndex = IIf(chnl < 10, chnl, chnl - 10)
                    End If
                Else
                    objGraphics.DrawPolygon(objPens(j Mod 10), pt0)
                    nc = (nc + 1) Mod dsteps
                End If
            Next j

            objGraphicsFrm.DrawImage(bmp, rect, 0, bmp.Height, bmp.Width, -bmp.Height, GraphicsUnit.Pixel, attr)
        Catch ex As Exception
            'MessageBox.Show(ex.Message(), "Exception BPVal")
        End Try

    End Sub

    Private Function getDateFormat()
        ' The Function will return the Date as in the Format of (YYYYMMDD) without the "/"
        Dim myDate As DateTime = Date.Today
        Dim formattedDate As String = myDate.ToString("yyyyMMdd")
        Return formattedDate
    End Function

    Private Function getDateFormated()
        'This function is Purposefully Designed for Displaying Date & Time with the Proper Specified format (YYYY/MM/DD/HH:MM:SS)
        Dim myDate As DateTime = Date.Today
        Dim formattedDate As String = myDate.ToString("yyyy/MM/dd")
        Dim data As String = formattedDate
        Return data
    End Function

    Private Sub PlotCurvesData(ByRef v() As Byte, Optional ByVal chnl As Integer = -1, Optional ByVal fillpoly As Boolean = False)
        Try
            Dim nz As Integer
            Dim i As Integer, i2 As Integer, i3 As Integer
            Dim gs As Integer, ge As Integer, gs2 As Integer, ge2 As Integer
            Dim j As Integer
            Dim rect As Rectangle
            Dim strtj As Integer, endj As Integer
            If chnl = -1 Then strtj = 0 : endj = TotNch Else strtj = chnl : endj = chnl
            'rect = New Rectangle(20, meheight - 30, (mewidth - 80), (-meheight + 50))
            rect = New Rectangle(50, meheight - 30, mewidth - 110, -meheight + 50)
            Dim attr As New Drawing.Imaging.ImageAttributes
            nz = bmp.Height
            i2 = 0
            objGraphics.DrawImage(bbmp, 0, 0)
            For j = strtj To endj
                upt = DataArr(j, 2)
                sx = bmp.Width / upt
                nz = bmp.Height
                gs = DataArr(j, 4)              '* sx
                ge = gs + DataArr(j, 5)         '* sx
                gs2 = DataArr(j, 7)              '* sx
                ge2 = gs2 + DataArr(j, 8)         '* sx
                For i = 0 To UBound(pt0)
                    pt0(i).Y = nz
                Next i
                i2 += 1
                Dim vmax As Integer = 0
                Dim vv As Integer, imax As Integer
                For i = 0 + 1 To upt - 1
                    vv = v20(i2) : i2 += 1
                    If i >= gs And i <= ge And i >= gs2 And i <= ge2 Then
                        If vmax < vv Then vmax = vv : imax = i
                    End If
                    vv = nz - vv
                    i3 = Int(i * sx)
                    If pt0(i3).Y > vv Then pt0(i3).Y = vv
                Next i
                pt0(0).Y = nz : pt0(UBound(pt0)).Y = nz
                objGraphics.DrawPolygon(objBlackPen, pt0)
            Next j
            objGraphicsFrm.DrawImage(bmp, rect, 0, bmp.Height, bmp.Width, -bmp.Height, GraphicsUnit.Pixel, attr)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AcquireDPAll(Optional ByVal chnl As Integer = -1, Optional ByVal eras As Boolean = True)

        Try
            Dim objfont As New Font(FontFamily.GenericSansSerif, 9.0F, FontStyle.Regular)

            lblPH.Visible = False
            lblPH.BackColor = Color.Black : lblPH.ForeColor = Color.Yellow    '21/10/16 - WT

            lblPH.Width = 1 * lblMenu1.Width : lblPH.Height = 4 * lblMenu1.Height

            If lblMenu1.Visible Then
                lblPH.Left = lblMenu1.Left - 2 * lblMenu1.Width

            Else
                lblPH.Left = Me.Width - lblPH.Width
            End If
            lblPH.Top = 365
            lblPH.Left = 585

            lblPH.Font = objfont

            lblPH.BringToFront()
            Dim i As Integer
            Dim i2 As Integer
            Dim x As Byte
            Dim r As Byte
            Dim ii As Integer, jj As Integer
            Dim vi As Integer
            Dim j1 As Integer
            Dim k As Integer = 0
            Dim j As Integer
            Dim strtj As Integer, endj As Integer
            If chnl = -1 Then strtj = 0 : endj = TotNch Else strtj = chnl : endj = chnl

            ii = curi : jj = curj
            If caltyp <> 4 And caltyp <> 6 And caltyp <> 10 And caltyp <> 12 And caltyp <> 14 Then StoreVals()
            SetTextBox()
            If TotNch < 9 Then isstop = False
            isstopped = False

            SetPlots(chnl)

            Me.Text = frmcap & " Acquiring"
#If IWAVE Then
        Dim hADRDriver As Integer = CreateFile("ADR1:", GENERIC_READ Or GENERIC_WRITE, 0, 0, OPEN_EXISTING, 0, 0)
#ElseIf DEBUG2 Then
        Dim kk As Integer = DataArr(j, 4)
        Dim kk1 As Integer = DataArr(j, 4) + 50
        Dim kk2 As Integer = DataArr(j, 4) + 450


        Dim vv As Integer = 10
#End If
            For i = 0 To BLOCKREADINFO.GetUpperBound(0)
                BLOCKREADINFO(i) = 0
            Next i
            Dim upt2 As Integer = 0
            For j = strtj To endj
                upt2 += (DataArr(j, 2) + 1)


            Next
            ReDim v20(upt2)
            k = 0
            Dim jjj As Integer = 0
            Do While True
                If isstop Then
#If TORA Then
                    If caltyp = 2 Then PlotCurvesT(v20, chnl, Not eras) Else PlotCurvesT(v20, chnl)
#ElseIf DEBUG2 Then
                If caltyp = 2 Then PlotCurves(v20, chnl, Not eras) Else PlotCurvesT(v20, chnl)
#Else
                If caltyp = 2 Then PlotCurves(v20, chnl, Not eras) Else PlotCurves(v20, chnl)
#End If

                    Application.DoEvents()
                    keyprocessing = False

                    isstopped = True

                    Try
                        If isstopped = True And bEsc = False Then

                            If angle = 0 Then
                                If Convert.ToInt32(st1) < 30 Then
                                    Me.Text = frmcap & " Stopped [PH=" & Convert.ToInt32(st1) + 2 & ", BP=" & BPval & ", D=" & BPval & ", SD=" & st4 & "]"
                                End If
                                If Convert.ToInt32(st1) > 100 Then
                                    st1 = "100"
                                    Me.Text = frmcap & " Stopped [PH=" & st1 & ", BP=" & BPval & ", D=" & BPval & ", SD=" & st4 & "]"
                                Else
                                    Me.Text = frmcap & " Stopped [PH=" & st1 & ", BP=" & BPval & ", D=" & BPval & ", SD=" & st4 & "]"
                                End If
                            Else
                                If Convert.ToInt32(st1) > 100 Then
                                    st1 = "100"
                                    Me.Text = frmcap & " Stopped [" & "PH=" & st1 & ", BP=" & BPval & ", D=" & st3 & ", SD=" & st4 & "]"
                                Else
                                    Me.Text = frmcap & " Stopped [" & "PH=" & st1 & ", BP=" & BPval & ", D=" & st3 & ", SD=" & st4 & "]"
                                End If
                            End If
                        End If

                        BPval = 0

                    Catch ex As Exception
                        'MessageBox.Show(ex.Message, "Exception AcquireCPALL()")
                    End Try

                    Exit Do
                End If
                If k = Loops Then
#If TORA Then
                    If caltyp = 2 Then PlotCurvesT(v20, chnl, Not eras) Else PlotCurvesT(v20, chnl)
#ElseIf DEBUG2 Then
                If caltyp = 2 Then PlotCurves(v20, chnl, Not eras) Else PlotCurvesT(v20, chnl)
#Else
                If caltyp = 2 Then PlotCurves(v20, chnl, Not eras) Else PlotCurves(v20, chnl)
#End If
                    Application.DoEvents()
                    k = 0
                    If eras Then ReDim v20(upt2)
                End If
                i2 = 0
                For j = strtj To endj
                    If j > 6 Then j1 = j + 1 Else j1 = j
                    upt = DataArr(j, 2)
                    r = DataArr(j, 3)
                    vi = DataArr(j, 1) + 2048 * j1
                    offset = vi : npoints = upt
                    '1st
                    BLOCKREADINFO(0) = (vi Mod 256) : vi \= 256
                    BLOCKREADINFO(1) = (vi Mod 256) : vi \= 256
                    '2nd
                    BLOCKREADINFO(2) = (vi Mod 256) : vi \= 256
                    '3rd
                    BLOCKREADINFO(3) = vi
                    vi = upt
                    '4th
                    BLOCKREADINFO(4) = (vi Mod 256) : vi \= 256
                    '5th
                    BLOCKREADINFO(5) = (vi Mod 256) : vi \= 256
                    '6th
                    BLOCKREADINFO(6) = (vi Mod 256) : vi \= 256
                    '7th
                    BLOCKREADINFO(7) = vi
                    '8th
                    BLOCKREADINFO(8) = (vi Mod 256) : vi \= 256
                    '9th
                    BLOCKREADINFO(9) = (vi Mod 256) : vi \= 256
                    vi = DataArr(j, 1) + 2048 * j1
                    offset = vi : npoints = upt
                    '10th
                    BLOCKREADINFO(10) = (vi Mod 256) : vi \= 256
                    BLOCKREADINFO(11) = vi


#If IWAVE Then
                DeviceIoControl(hADRDriver, ADR_IOCTL_BLOCK_READ_LOWER, BLOCKREADINFO, BLOCKREADINFO.GetUpperBound(0) + 1, BLOCKREADINFO, BLOCKREADINFO.GetUpperBound(0) + 1, 0, 0)
#ElseIf DEBUG2 Then
                For i = 0 To BLOCKREADINFO.GetUpperBound(0)
                    BLOCKREADINFO(i) = 0
                Next i
                For i = 50 To 55
                    BLOCKREADINFO(i) = 1
                Next
                BLOCKREADINFO(12 + DataArr(0, 4) + kk) = vv
                If kk > kk1 And kk < kk2 Then
                    vv = vv + 1
                ElseIf kk > kk2 And kk < upt Then
                    vv = vv - 1
                End If
                If vv < 0 Then vv = 0
                If vv > 230 Then vv = 230
                lblDisp.Text = Format(kk, "0")
                kk += 1
                If kk >= upt Then kk = 0
#ElseIf TORA Then
                    ToraGetData()
#End If
                    For i = 0 To upt Step 1
                        x = BLOCKREADINFO(12 + i)
                        If x > r And x > v20(i2) Then
                            v20(i2) = x
                        End If
                        i2 += 1
                    Next i
                Next j
                k += 1
            Loop
            Application.DoEvents()
#If IWAVE Then
        CloseHandle(hADRDriver)
#End If

        Catch ex As Exception

        End Try

    End Sub

    Sub ToraGetData()
        Dim i As Integer, j As Integer
        j = 12
        For i = offset To offset + upt
            BLOCKREADINFO(j) = GPIO.read_dpram_value(i)       '0
            j = j + 1
        Next i
    End Sub

    Private Sub AcquireDP(ByVal j As Integer)
        Try
            Dim i As Integer, ii As Integer
            Dim vi As Integer
            Dim j1 As Integer = IIf(j > 9, j + 1, j)
            Dim hADRDriver As Integer = CreateFile("ADR1:", GENERIC_READ Or GENERIC_WRITE, 0, 0, OPEN_EXISTING, 0, 0)
            isstopped = False
            Dim upt As Integer = DataArr(j, 2)
            Dim r As Integer = CInt(DataArr(j, 3) * RJTMULT)

            Dim Lm As Integer = 20, Tm As Integer = 10
            Dim Bm As Integer = Me.Height - 20, Rm As Integer = Me.Width - 20
            Dim Sx As Single = (Rm - Lm) / upt
            Dim Sy As Single = (Bm - Tm) / ymax

            SetTextBox()
            ReDim pt0(upt)
            For i = 0 To upt
                pt0(i).X = i * Sx + Lm
                pt0(i).Y = Bm
            Next i

            objGraphicsFrm.Clear(Color.Black)
            ii = 0
            For i = Lm To Rm Step (Rm - Lm) / 10
                objGraphicsFrm.DrawLine(objBackPen, i, Tm, i, Bm)
                objGraphicsFrm.DrawString(Format(ii), objfont, objBrush2, i, Bm)
                ii += 1
            Next i
            Dim k As Integer = 100
            For i = 0 To 10
                Dim yy As Single = Tm + CSng(i * (Bm - Tm)) / 10.0
                objGraphicsFrm.DrawLine(objBackPen, Lm, yy, Rm, yy)
                objGraphicsFrm.DrawString(Format(k, "0"), objfont, objBrush3, 25, yy)
                k -= 10
            Next i
            upt = DataArr(j, 2)
            Sx = (Rm - Lm) / upt
            Sy = (Bm - Tm) / ymax
            Dim t As Single = Bm - DataArr(j, 6) * Sy
            Dim t2 As Single = Bm - DataArr(j, 9) * Sy
            objGraphicsFrm.DrawLine(objPens(j Mod 10), Sx * DataArr(j, 4) + Lm, t, Sx * (DataArr(j, 4) + DataArr(j, 5)) + Lm, t)  'Gate
            objGraphicsFrm.DrawLine(objPens(j Mod 10), Sx * DataArr(j, 7) + Lm, t2, Sx * (DataArr(j, 7) + DataArr(j, 8)) + Lm, t2)  'Gate2
            Me.Text = frmcap

            vi = DataArr(j, 1) + 2048 * j1
            BLOCKREADINFO(0) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(1) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(2) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(3) = vi
            vi = upt

            BLOCKREADINFO(4) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(5) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(6) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(7) = vi

            BLOCKREADINFO(8) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(9) = (vi Mod 256) : vi \= 256

            vi = DataArr(j, 1) + 2048 * j1
            BLOCKREADINFO(10) = (vi Mod 256) : vi \= 256
            BLOCKREADINFO(11) = vi

            Dim imaxmax As Integer = 0
            Dim vmaxmax As Integer = 0
            Dim xx As Integer

#If DEBUG2 Then
        Dim kk As Integer = DataArr(j, 4)
        Dim kk1 As Integer = DataArr(j, 4) + 50
        Dim kk2 As Integer = DataArr(j, 4) + 450
        Dim kkk As Integer = DataArr(j, 7)
        Dim kkk1 As Integer = DataArr(j, 7) + 50
        Dim kkk2 As Integer = DataArr(j, 7) + 450
        Dim vv As Integer = 10
#ElseIf TORA Then
            Dim kk As Integer = DataArr(j, 4)
            Dim kk1 As Integer = DataArr(j, 4) + 50
            Dim kk2 As Integer = DataArr(j, 4) + 450
            Dim kkk As Integer = DataArr(j, 7)
            Dim kkk1 As Integer = DataArr(j, 7) + 50
            Dim kkk2 As Integer = DataArr(j, 7) + 450
            Dim vv As Integer = 10
#End If
            k = 0
            Dim objTPen As Pen = New Pen(colours(j Mod 10), 2)
            Do While True
                If isstop Then
                    Application.DoEvents()
                    keyprocessing = False
                    Me.Text = frmcap & " Stopped5"
                    isstopped = True
                    Exit Do
                End If
#If IWAVE Then
            DeviceIoControl(hADRDriver, ADR_IOCTL_BLOCK_READ_LOWER, BLOCKREADINFO, BLOCKREADINFO.GetUpperBound(0) + 1, BLOCKREADINFO, BLOCKREADINFO.GetUpperBound(0) + 1, 0, 0)
#ElseIf DEBUG2 Then
            For i = 0 To BLOCKREADINFO.GetUpperBound(0)
                BLOCKREADINFO(i) = 0
            Next i
            BLOCKREADINFO(12 + DataArr(j, 4) + kk) = vv
            If kk > kk1 And kk < kk2 And kkk > kkk1 And kkk < kkk2 Then
                vv = vv + 1
            ElseIf kk > kk2 And kk < upt And kkk > kkk2 And kkk < upt Then
                vv = vv - 1
            End If
            If vv < 0 Then vv = 0
            If vv > 230 Then vv = 230
            lblDisp.Text = Format(kk, "0")
            kk += 1
            kkk += 1
            If kk >= upt And kkk >= upt Then kk = 0, kkk = 0
#ElseIf TORA Then
                For i = 0 To BLOCKREADINFO.GetUpperBound(0)
                    BLOCKREADINFO(i) = 0
                Next i
                BLOCKREADINFO(12 + DataArr(j, 4) + kk) = vv
                BLOCKREADINFO(12 + DataArr(j, 7) + kkk) = vv
                If kk > kk1 And kk < kk2 And kkk > kkk1 And kkk < kkk2 Then
                    vv = vv + 1
                ElseIf kk > kk2 And kk < upt And kkk > kkk2 And kkk < upt Then
                    vv = vv - 1
                End If
                If vv < 0 Then vv = 0
                If vv > 230 Then vv = 230
                lblDisp.Text = Format(kk, "0")
                lblDisp.Text = Format(kkk, "0")
                kk += 1
                kkk += 1
                If kk >= upt Then kk = 0
                If kkk >= upt Then kkk = 0
#End If
                Dim vmax As Integer = 0
                Dim imax As Integer = 0
                For i = 1 To upt - 1 Step 1
                    xx = BLOCKREADINFO(12 + i)
                    If xx < r Then xx = Bm Else xx = Bm - Sy * xx
                    If xx < pt0(i).Y Then
                        pt0(i).Y = xx
                    End If
                Next i
                pt0(0).Y = Bm : pt0(upt).Y = Bm
                k += 1
                If k = Loops Then
                    objGraphicsFrm.Clear(Color.Black)
                    objGraphicsFrm.DrawPolygon(objTPen, pt0)
                    Application.DoEvents()
                    For i = 0 To upt
                        pt0(i).Y = Bm
                    Next i
                    k = 0
                End If
                keyprocessing = False
            Loop
            CloseHandle(hADRDriver)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SetLabels()
        keyprocessing = False
        If caltyp = 0 Then
            LblsVisible(True, True, True)
        ElseIf caltyp = 1 Then
            LblsVisible(False, False, False)
        ElseIf caltyp = 2 Then
            LblsVisible(True, False, False)
        ElseIf caltyp = 3 Then
            LblsVisible(False, False, False)
        ElseIf caltyp = 4 Then
            LblsVisible(True, False, False)
        ElseIf caltyp = 5 Then
            LblsVisible(False, False, False)
        ElseIf caltyp = 6 Then
            LblsVisible(True, False, False)
        ElseIf caltyp = 10 Then
            LblsVisible(True, False, False)
        ElseIf caltyp = 11 Then
            LblsVisible(False, False, False)
        ElseIf caltyp = 12 Then
            LblsVisible(True, False, False)
        ElseIf caltyp = 14 Then
            LblsVisible(True, False, False)
        ElseIf caltyp = 15 Then
            LblsVisible(False, False, False)
        End If
    End Sub

    Public Sub Acquire(ByVal j As Integer)
        Try
            keyprocessing = False
            lblPH.Visible = False
            If caltyp = 0 Or caltyp = 10 Or caltyp = 12 Or caltyp = 14 Then
                AcquireDPAll(j)
            ElseIf caltyp = 1 Then
                AcquireData2()                              'prs Read Stored Data 
            ElseIf caltyp = 2 Then
                AcquireFreeze(j)
            ElseIf caltyp = 3 Then
                AcquireFreezeData()                        'prv Read Freeze Data
            ElseIf caltyp = 4 Then
                AcquireDPAll(j)
            ElseIf caltyp = 5 Then
                AcquireWRTData()                        'Read Weld Data
            ElseIf caltyp = 6 Then
                AcquireZoom(j)
            ElseIf caltyp = 11 Then
                AcquireWRTData()                        'Read calib Data
            ElseIf caltyp = 13 Then
                AcquirePRHData()                        'Read handheld Data
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AcquireData(ByVal j As Integer)
        SetPlotsData(curi)
        ReadData(curi)
        PlotCurvesData(v20, curi)
        SetTextBox()
    End Sub

    Public Sub ReadData(ByVal chnl As Integer)
        Dim b(InfoSiz - 1) As Byte
        Dim bb(3) As Byte
        Dim st(35) As String

        Dim i As Integer, j As Integer
        '        Dim objBR As BinaryReader
        Dim objFS As FileStream
        objFS = New FileStream(datafile, FileMode.Open, FileAccess.Read)
        Dim objBR As BinaryReader = New BinaryReader(objFS)
        For i = 0 To st.GetUpperBound(0)
            st(i) = objBR.ReadString
        Next i
        For i = 0 To DataArr.GetUpperBound(0)
            For j = 0 To DataArr.GetUpperBound(1)
                DataArr(i, j) = objBR.ReadInt32
            Next j
        Next i
        Dim k As Integer = IIf(chnl > 6, chnl + 1, chnl)
        objFS.Seek(k * 2048 + DataArr(chnl, 1), SeekOrigin.Current)
        upt = DataArr(chnl, 2) + 1
        ReDim v20(upt)
        ReDim v21(upt)
        For i = 0 To upt
            v20(i) = objFS.ReadByte
            v21(i) = objFS.ReadByte
        Next i
        objFS.Close()
    End Sub

    Private Sub SetMenu(ByVal mnu1 As String, ByVal mnu2 As String, ByVal mnu3 As String, ByVal mnu4 As String, ByVal mnu5 As String, ByVal mnu6 As String, ByVal mnu7 As String, Optional ByVal mnu8 As String = "")
        ClearAllKeys()
        If Trim(mnu1) <> "" Then lblMenu1.Text = mnu1 : lblMenu1.Visible = True Else lblMenu1.Visible = False
        If Trim(mnu2) <> "" Then lblMenu2.Text = mnu2 : lblMenu2.Visible = True Else lblMenu2.Visible = False
        If Trim(mnu3) <> "" Then lblMenu3.Text = mnu3 : lblMenu3.Visible = True Else lblMenu3.Visible = False
        If Trim(mnu4) <> "" Then lblMenu4.Text = mnu4 : lblMenu4.Visible = True Else lblMenu4.Visible = False
        If Trim(mnu5) <> "" Then lblMenu5.Text = mnu5 : lblMenu5.Visible = True Else lblMenu5.Visible = False
        If Trim(mnu6) <> "" Then lblMenu6.Text = mnu6 : lblMenu6.Visible = True Else lblMenu6.Visible = False
        If Trim(mnu7) <> "" Then lblMenu7.Text = mnu7 : lblMenu7.Visible = True Else lblMenu7.Visible = False
        If Trim(mnu8) <> "" Then lblMenu8.Text = mnu8 : lblMenu8.Visible = True Else lblMenu8.Visible = False
    End Sub

    Private Sub DispTextBoxes()
        Try
            txtGain1 = New TextBox
            txtGain1.Left = lblGain.Left : txtGain1.Top = lblC1.Top : txtGain1.Width = lblGain.Width
            txtGain1.Font = lblInput.Font
            txtGain2 = New TextBox
            txtGain2.Left = lblGain.Left : txtGain2.Top = lblC2.Top : txtGain2.Width = lblGain.Width
            txtGain2.Font = lblInput.Font
            txtGain3 = New TextBox
            txtGain3.Left = lblGain.Left : txtGain3.Top = lblC3.Top : txtGain3.Width = lblGain.Width
            txtGain3.Font = lblInput.Font
            txtGain4 = New TextBox
            txtGain4.Left = lblGain.Left : txtGain4.Top = lblC4.Top : txtGain4.Width = lblGain.Width
            txtGain4.Font = lblInput.Font
            txtGain5 = New TextBox
            txtGain5.Left = lblGain.Left : txtGain5.Top = lblC5.Top : txtGain5.Width = lblGain.Width
            txtGain5.Font = lblInput.Font
            txtGain6 = New TextBox
            txtGain6.Left = lblGain.Left : txtGain6.Top = lblC6.Top : txtGain6.Width = lblGain.Width
            txtGain6.Font = lblInput.Font
            txtGain7 = New TextBox
            txtGain7.Left = lblGain.Left : txtGain7.Top = lblC7.Top : txtGain7.Width = lblGain.Width
            txtGain7.Font = lblInput.Font

            txtGain8 = New TextBox
            txtGain8.Left = lblGain.Left : txtGain8.Top = lblC8.Top : txtGain8.Width = lblGain.Width
            txtGain8.Font = lblInput.Font
            txtGain9 = New TextBox
            txtGain9.Left = lblGain.Left : txtGain9.Top = lblC9.Top : txtGain9.Width = lblGain.Width
            txtGain9.Font = lblInput.Font
            txtGain10 = New TextBox
            txtGain10.Left = lblGain.Left : txtGain10.Top = lblC10.Top : txtGain10.Width = lblGain.Width
            txtGain10.Font = lblInput.Font


            txtDelay1 = New TextBox
            txtDelay1.Left = lblDelay.Left : txtDelay1.Top = lblC1.Top : txtDelay1.Width = lblDelay.Width
            txtDelay1.Font = lblInput.Font
            txtDelay2 = New TextBox
            txtDelay2.Left = lblDelay.Left : txtDelay2.Top = lblC2.Top : txtDelay2.Width = lblDelay.Width
            txtDelay2.Font = lblInput.Font
            txtDelay3 = New TextBox
            txtDelay3.Left = lblDelay.Left : txtDelay3.Top = lblC3.Top : txtDelay3.Width = lblDelay.Width
            txtDelay3.Font = lblInput.Font
            txtDelay4 = New TextBox
            txtDelay4.Left = lblDelay.Left : txtDelay4.Top = lblC4.Top : txtDelay4.Width = lblDelay.Width
            txtDelay4.Font = lblInput.Font
            txtDelay5 = New TextBox
            txtDelay5.Left = lblDelay.Left : txtDelay5.Top = lblC5.Top : txtDelay5.Width = lblDelay.Width
            txtDelay5.Font = lblInput.Font
            txtDelay6 = New TextBox
            txtDelay6.Left = lblDelay.Left : txtDelay6.Top = lblC6.Top : txtDelay6.Width = lblDelay.Width
            txtDelay6.Font = lblInput.Font
            txtDelay7 = New TextBox
            txtDelay7.Left = lblDelay.Left : txtDelay7.Top = lblC7.Top : txtDelay7.Width = lblDelay.Width
            txtDelay7.Font = lblInput.Font

            txtDelay8 = New TextBox
            txtDelay8.Left = lblDelay.Left : txtDelay8.Top = lblC8.Top : txtDelay8.Width = lblDelay.Width
            txtDelay8.Font = lblInput.Font
            txtDelay9 = New TextBox
            txtDelay9.Left = lblDelay.Left : txtDelay9.Top = lblC9.Top : txtDelay9.Width = lblDelay.Width
            txtDelay9.Font = lblInput.Font
            txtDelay10 = New TextBox
            txtDelay10.Left = lblDelay.Left : txtDelay10.Top = lblC10.Top : txtDelay10.Width = lblDelay.Width
            txtDelay10.Font = lblInput.Font

            txtRange1 = New TextBox
            txtRange1.Left = lblRange.Left : txtRange1.Top = lblC1.Top : txtRange1.Width = lblRange.Width
            txtRange1.Font = lblInput.Font
            txtRange2 = New TextBox
            txtRange2.Left = lblRange.Left : txtRange2.Top = lblC2.Top : txtRange2.Width = lblRange.Width
            txtRange2.Font = lblInput.Font
            txtRange3 = New TextBox
            txtRange3.Left = lblRange.Left : txtRange3.Top = lblC3.Top : txtRange3.Width = lblRange.Width
            txtRange3.Font = lblInput.Font
            txtRange4 = New TextBox
            txtRange4.Left = lblRange.Left : txtRange4.Top = lblC4.Top : txtRange4.Width = lblRange.Width
            txtRange4.Font = lblInput.Font
            txtRange5 = New TextBox
            txtRange5.Left = lblRange.Left : txtRange5.Top = lblC5.Top : txtRange5.Width = lblRange.Width
            txtRange5.Font = lblInput.Font
            txtRange6 = New TextBox
            txtRange6.Left = lblRange.Left : txtRange6.Top = lblC6.Top : txtRange6.Width = lblRange.Width
            txtRange6.Font = lblInput.Font
            txtRange7 = New TextBox
            txtRange7.Left = lblRange.Left : txtRange7.Top = lblC7.Top : txtRange7.Width = lblRange.Width
            txtRange7.Font = lblInput.Font

            txtRange8 = New TextBox
            txtRange8.Left = lblRange.Left : txtRange8.Top = lblC8.Top : txtRange8.Width = lblRange.Width
            txtRange8.Font = lblInput.Font
            txtRange9 = New TextBox
            txtRange9.Left = lblRange.Left : txtRange9.Top = lblC9.Top : txtRange9.Width = lblRange.Width
            txtRange9.Font = lblInput.Font
            txtRange10 = New TextBox
            txtRange10.Left = lblRange.Left : txtRange10.Top = lblC10.Top : txtRange10.Width = lblRange.Width
            txtRange10.Font = lblInput.Font

            txtReject1 = New TextBox
            txtReject1.Left = lblReject.Left : txtReject1.Top = lblC1.Top : txtReject1.Width = lblReject.Width
            txtReject1.Font = lblInput.Font
            txtReject2 = New TextBox
            txtReject2.Left = lblReject.Left : txtReject2.Top = lblC2.Top : txtReject2.Width = lblReject.Width
            txtReject2.Font = lblInput.Font
            txtReject3 = New TextBox
            txtReject3.Left = lblReject.Left : txtReject3.Top = lblC3.Top : txtReject3.Width = lblReject.Width
            txtReject3.Font = lblInput.Font
            txtReject4 = New TextBox
            txtReject4.Left = lblReject.Left : txtReject4.Top = lblC4.Top : txtReject4.Width = lblReject.Width
            txtReject4.Font = lblInput.Font
            txtReject5 = New TextBox
            txtReject5.Left = lblReject.Left : txtReject5.Top = lblC5.Top : txtReject5.Width = lblReject.Width
            txtReject5.Font = lblInput.Font
            txtReject6 = New TextBox
            txtReject6.Left = lblReject.Left : txtReject6.Top = lblC6.Top : txtReject6.Width = lblReject.Width
            txtReject6.Font = lblInput.Font
            txtReject7 = New TextBox
            txtReject7.Left = lblReject.Left : txtReject7.Top = lblC7.Top : txtReject7.Width = lblReject.Width
            txtReject7.Font = lblInput.Font

            txtReject8 = New TextBox
            txtReject8.Left = lblReject.Left : txtReject8.Top = lblC8.Top : txtReject8.Width = lblReject.Width
            txtReject8.Font = lblInput.Font
            txtReject9 = New TextBox
            txtReject9.Left = lblReject.Left : txtReject9.Top = lblC9.Top : txtReject9.Width = lblReject.Width
            txtReject9.Font = lblInput.Font
            txtReject10 = New TextBox
            txtReject10.Left = lblReject.Left : txtReject10.Top = lblC10.Top : txtReject10.Width = lblReject.Width
            txtReject10.Font = lblInput.Font

            txtGateS1 = New TextBox
            txtGateS1.Left = lblGateS.Left : txtGateS1.Top = lblC1.Top : txtGateS1.Width = lblGateS.Width
            txtGateS1.Font = lblInput.Font
            txtGateS2 = New TextBox
            txtGateS2.Left = lblGateS.Left : txtGateS2.Top = lblC2.Top : txtGateS2.Width = lblGateS.Width
            txtGateS2.Font = lblInput.Font
            txtGateS3 = New TextBox
            txtGateS3.Left = lblGateS.Left : txtGateS3.Top = lblC3.Top : txtGateS3.Width = lblGateS.Width
            txtGateS3.Font = lblInput.Font
            txtGateS4 = New TextBox
            txtGateS4.Left = lblGateS.Left : txtGateS4.Top = lblC4.Top : txtGateS4.Width = lblGateS.Width
            txtGateS4.Font = lblInput.Font
            txtGateS5 = New TextBox
            txtGateS5.Left = lblGateS.Left : txtGateS5.Top = lblC5.Top : txtGateS5.Width = lblGateS.Width
            txtGateS5.Font = lblInput.Font
            txtGateS6 = New TextBox
            txtGateS6.Left = lblGateS.Left : txtGateS6.Top = lblC6.Top : txtGateS6.Width = lblGateS.Width
            txtGateS6.Font = lblInput.Font
            txtGateS7 = New TextBox
            txtGateS7.Left = lblGateS.Left : txtGateS7.Top = lblC7.Top : txtGateS7.Width = lblGateS.Width
            txtGateS7.Font = lblInput.Font

            txtGateS8 = New TextBox
            txtGateS8.Left = lblGateS.Left : txtGateS8.Top = lblC8.Top : txtGateS8.Width = lblGateS.Width
            txtGateS8.Font = lblInput.Font
            txtGateS9 = New TextBox
            txtGateS9.Left = lblGateS.Left : txtGateS9.Top = lblC9.Top : txtGateS9.Width = lblGateS.Width
            txtGateS9.Font = lblInput.Font
            txtGateS10 = New TextBox
            txtGateS10.Left = lblGateS.Left : txtGateS10.Top = lblC10.Top : txtGateS10.Width = lblGateS.Width
            txtGateS10.Font = lblInput.Font

            txtGateW1 = New TextBox
            txtGateW1.Left = lblGateW.Left : txtGateW1.Top = lblC1.Top : txtGateW1.Width = lblGateW.Width
            txtGateW1.Font = lblInput.Font
            txtGateW2 = New TextBox
            txtGateW2.Left = lblGateW.Left : txtGateW2.Top = lblC2.Top : txtGateW2.Width = lblGateW.Width
            txtGateW2.Font = lblInput.Font
            txtGateW3 = New TextBox
            txtGateW3.Left = lblGateW.Left : txtGateW3.Top = lblC3.Top : txtGateW3.Width = lblGateW.Width
            txtGateW3.Font = lblInput.Font
            txtGateW4 = New TextBox
            txtGateW4.Left = lblGateW.Left : txtGateW4.Top = lblC4.Top : txtGateW4.Width = lblGateW.Width
            txtGateW4.Font = lblInput.Font
            txtGateW5 = New TextBox
            txtGateW5.Left = lblGateW.Left : txtGateW5.Top = lblC5.Top : txtGateW5.Width = lblGateW.Width
            txtGateW5.Font = lblInput.Font
            txtGateW6 = New TextBox
            txtGateW6.Left = lblGateW.Left : txtGateW6.Top = lblC6.Top : txtGateW6.Width = lblGateW.Width
            txtGateW6.Font = lblInput.Font
            txtGateW7 = New TextBox
            txtGateW7.Left = lblGateW.Left : txtGateW7.Top = lblC7.Top : txtGateW7.Width = lblGateW.Width
            txtGateW7.Font = lblInput.Font

            txtGateW8 = New TextBox
            txtGateW8.Left = lblGateW.Left : txtGateW8.Top = lblC8.Top : txtGateW8.Width = lblGateW.Width
            txtGateW8.Font = lblInput.Font
            txtGateW9 = New TextBox
            txtGateW9.Left = lblGateW.Left : txtGateW9.Top = lblC9.Top : txtGateW9.Width = lblGateW.Width
            txtGateW9.Font = lblInput.Font
            txtGateW10 = New TextBox
            txtGateW10.Left = lblGateW.Left : txtGateW10.Top = lblC10.Top : txtGateW10.Width = lblGateW.Width
            txtGateW10.Font = lblInput.Font

            txtThresh1 = New TextBox
            txtThresh1.Left = lblThresh.Left : txtThresh1.Top = lblC1.Top : txtThresh1.Width = lblThresh.Width
            txtThresh1.Font = lblInput.Font
            txtThresh2 = New TextBox
            txtThresh2.Left = lblThresh.Left : txtThresh2.Top = lblC2.Top : txtThresh2.Width = lblThresh.Width
            txtThresh2.Font = lblInput.Font
            txtThresh3 = New TextBox
            txtThresh3.Left = lblThresh.Left : txtThresh3.Top = lblC3.Top : txtThresh3.Width = lblThresh.Width
            txtThresh3.Font = lblInput.Font
            txtThresh4 = New TextBox
            txtThresh4.Left = lblThresh.Left : txtThresh4.Top = lblC4.Top : txtThresh4.Width = lblThresh.Width
            txtThresh4.Font = lblInput.Font
            txtThresh5 = New TextBox
            txtThresh5.Left = lblThresh.Left : txtThresh5.Top = lblC5.Top : txtThresh5.Width = lblThresh.Width
            txtThresh5.Font = lblInput.Font
            txtThresh6 = New TextBox
            txtThresh6.Left = lblThresh.Left : txtThresh6.Top = lblC6.Top : txtThresh6.Width = lblThresh.Width
            txtThresh6.Font = lblInput.Font
            txtThresh7 = New TextBox
            txtThresh7.Left = lblThresh.Left : txtThresh7.Top = lblC7.Top : txtThresh7.Width = lblThresh.Width
            txtThresh7.Font = lblInput.Font

            txtThresh8 = New TextBox
            txtThresh8.Left = lblThresh.Left : txtThresh8.Top = lblC8.Top : txtThresh8.Width = lblThresh.Width
            txtThresh8.Font = lblInput.Font
            txtThresh9 = New TextBox
            txtThresh9.Left = lblThresh.Left : txtThresh9.Top = lblC9.Top : txtThresh9.Width = lblThresh.Width
            txtThresh9.Font = lblInput.Font
            txtThresh10 = New TextBox
            txtThresh10.Left = lblThresh.Left : txtThresh10.Top = lblC10.Top : txtThresh10.Width = lblThresh.Width
            txtThresh10.Font = lblInput.Font

            txtG2St1 = New TextBox
            txtG2St1.Left = lblG2St.Left : txtG2St1.Top = lblC1.Top : txtG2St1.Width = lblG2St.Width
            txtG2St1.Font = lblInput.Font
            txtG2St2 = New TextBox
            txtG2St2.Left = lblG2St.Left : txtG2St2.Top = lblC2.Top : txtG2St2.Width = lblG2St.Width
            txtG2St2.Font = lblInput.Font
            txtG2St3 = New TextBox
            txtG2St3.Left = lblG2St.Left : txtG2St3.Top = lblC3.Top : txtG2St3.Width = lblG2St.Width
            txtG2St3.Font = lblInput.Font
            txtG2St4 = New TextBox
            txtG2St4.Left = lblG2St.Left : txtG2St4.Top = lblC4.Top : txtG2St4.Width = lblG2St.Width
            txtG2St4.Font = lblInput.Font
            txtG2St5 = New TextBox
            txtG2St5.Left = lblG2St.Left : txtG2St5.Top = lblC5.Top : txtG2St5.Width = lblG2St.Width
            txtG2St5.Font = lblInput.Font
            txtG2St6 = New TextBox
            txtG2St6.Left = lblG2St.Left : txtG2St6.Top = lblC6.Top : txtG2St6.Width = lblG2St.Width
            txtG2St6.Font = lblInput.Font
            txtG2St7 = New TextBox
            txtG2St7.Left = lblG2St.Left : txtG2St7.Top = lblC7.Top : txtG2St7.Width = lblG2St.Width
            txtG2St7.Font = lblInput.Font

            txtG2St8 = New TextBox
            txtG2St8.Left = lblG2St.Left : txtG2St8.Top = lblC8.Top : txtG2St8.Width = lblG2St.Width
            txtG2St8.Font = lblInput.Font
            txtG2St9 = New TextBox
            txtG2St9.Left = lblG2St.Left : txtG2St9.Top = lblC9.Top : txtG2St9.Width = lblG2St.Width
            txtG2St9.Font = lblInput.Font
            txtG2St10 = New TextBox
            txtG2St10.Left = lblG2St.Left : txtG2St10.Top = lblC10.Top : txtG2St10.Width = lblG2St.Width
            txtG2St10.Font = lblInput.Font

            txtG2Wd1 = New TextBox
            txtG2Wd1.Left = lblG2Wd.Left : txtG2Wd1.Top = lblC1.Top : txtG2Wd1.Width = lblG2Wd.Width
            txtG2Wd1.Font = lblInput.Font
            txtG2Wd2 = New TextBox
            txtG2Wd2.Left = lblG2Wd.Left : txtG2Wd2.Top = lblC2.Top : txtG2Wd2.Width = lblG2Wd.Width
            txtG2Wd2.Font = lblInput.Font
            txtG2Wd3 = New TextBox
            txtG2Wd3.Left = lblG2Wd.Left : txtG2Wd3.Top = lblC3.Top : txtG2Wd3.Width = lblG2Wd.Width
            txtG2Wd3.Font = lblInput.Font
            txtG2Wd4 = New TextBox
            txtG2Wd4.Left = lblG2Wd.Left : txtG2Wd4.Top = lblC4.Top : txtG2Wd4.Width = lblG2Wd.Width
            txtG2Wd4.Font = lblInput.Font
            txtG2Wd5 = New TextBox
            txtG2Wd5.Left = lblG2Wd.Left : txtG2Wd5.Top = lblC5.Top : txtG2Wd5.Width = lblG2Wd.Width
            txtG2Wd5.Font = lblInput.Font
            txtG2Wd6 = New TextBox
            txtG2Wd6.Left = lblG2Wd.Left : txtG2Wd6.Top = lblC6.Top : txtG2Wd6.Width = lblG2Wd.Width
            txtG2Wd6.Font = lblInput.Font
            txtG2Wd7 = New TextBox
            txtG2Wd7.Left = lblG2Wd.Left : txtG2Wd7.Top = lblC7.Top : txtG2Wd7.Width = lblG2Wd.Width
            txtG2Wd7.Font = lblInput.Font

            txtG2Wd8 = New TextBox
            txtG2Wd8.Left = lblG2Wd.Left : txtG2Wd8.Top = lblC8.Top : txtG2Wd8.Width = lblG2Wd.Width
            txtG2Wd8.Font = lblInput.Font
            txtG2Wd9 = New TextBox
            txtG2Wd9.Left = lblG2Wd.Left : txtG2Wd9.Top = lblC9.Top : txtG2Wd9.Width = lblG2Wd.Width
            txtG2Wd9.Font = lblInput.Font
            txtG2Wd10 = New TextBox
            txtG2Wd10.Left = lblG2Wd.Left : txtG2Wd10.Top = lblC10.Top : txtG2Wd10.Width = lblG2Wd.Width
            txtG2Wd10.Font = lblInput.Font

            txtThr21 = New TextBox
            txtThr21.Left = lblThr2.Left : txtThr21.Top = lblC1.Top : txtThr21.Width = lblThr2.Width
            txtThr21.Font = lblInput.Font
            txtThr22 = New TextBox
            txtThr22.Left = lblThr2.Left : txtThr22.Top = lblC2.Top : txtThr22.Width = lblThr2.Width
            txtThr22.Font = lblInput.Font
            txtThr23 = New TextBox
            txtThr23.Left = lblThr2.Left : txtThr23.Top = lblC3.Top : txtThr23.Width = lblThr2.Width
            txtThr23.Font = lblInput.Font
            txtThr24 = New TextBox
            txtThr24.Left = lblThr2.Left : txtThr24.Top = lblC4.Top : txtThr24.Width = lblThr2.Width
            txtThr24.Font = lblInput.Font
            txtThr25 = New TextBox
            txtThr25.Left = lblThr2.Left : txtThr25.Top = lblC5.Top : txtThr25.Width = lblThr2.Width
            txtThr25.Font = lblInput.Font
            txtThr26 = New TextBox
            txtThr26.Left = lblThr2.Left : txtThr26.Top = lblC6.Top : txtThr26.Width = lblThr2.Width
            txtThr26.Font = lblInput.Font
            txtThr27 = New TextBox
            txtThr27.Left = lblThr2.Left : txtThr27.Top = lblC7.Top : txtThr27.Width = lblThr2.Width
            txtThr27.Font = lblInput.Font

            txtThr28 = New TextBox
            txtThr28.Left = lblThr2.Left : txtThr28.Top = lblC8.Top : txtThr28.Width = lblThr2.Width
            txtThr28.Font = lblInput.Font
            txtThr29 = New TextBox
            txtThr29.Left = lblThr2.Left : txtThr29.Top = lblC9.Top : txtThr29.Width = lblThr2.Width
            txtThr29.Font = lblInput.Font
            txtThr210 = New TextBox
            txtThr210.Left = lblThr2.Left : txtThr210.Top = lblC10.Top : txtThr210.Width = lblThr2.Width
            txtThr210.Font = lblInput.Font

            txtAng1 = New TextBox
            txtAng1.Left = lblAng.Left : txtAng1.Top = lblC1.Top : txtAng1.Width = lblAng.Width
            txtAng1.Font = lblInput.Font
            txtAng2 = New TextBox
            txtAng2.Left = lblAng.Left : txtAng2.Top = lblC2.Top : txtAng2.Width = lblAng.Width
            txtAng2.Font = lblInput.Font
            txtAng3 = New TextBox
            txtAng3.Left = lblAng.Left : txtAng3.Top = lblC3.Top : txtAng3.Width = lblAng.Width
            txtAng3.Font = lblInput.Font
            txtAng4 = New TextBox
            txtAng4.Left = lblAng.Left : txtAng4.Top = lblC4.Top : txtAng4.Width = lblAng.Width
            txtAng4.Font = lblInput.Font
            txtAng5 = New TextBox
            txtAng5.Left = lblAng.Left : txtAng5.Top = lblC5.Top : txtAng5.Width = lblAng.Width
            txtAng5.Font = lblInput.Font
            txtAng6 = New TextBox
            txtAng6.Left = lblAng.Left : txtAng6.Top = lblC6.Top : txtAng6.Width = lblAng.Width
            txtAng6.Font = lblInput.Font
            txtAng7 = New TextBox
            txtAng7.Left = lblAng.Left : txtAng7.Top = lblC7.Top : txtAng7.Width = lblAng.Width
            txtAng7.Font = lblInput.Font

            txtAng8 = New TextBox
            txtAng8.Left = lblAng.Left : txtAng8.Top = lblC8.Top : txtAng8.Width = lblAng.Width
            txtAng8.Font = lblInput.Font
            txtAng9 = New TextBox
            txtAng9.Left = lblAng.Left : txtAng9.Top = lblC9.Top : txtAng9.Width = lblAng.Width
            txtAng9.Font = lblInput.Font
            txtAng10 = New TextBox
            txtAng10.Left = lblAng.Left : txtAng10.Top = lblC10.Top : txtAng10.Width = lblAng.Width
            txtAng10.Font = lblInput.Font

            Panel2.Controls.Add(txtGain1)
            Panel2.Controls.Add(txtGain2)
            Panel2.Controls.Add(txtGain3)
            Panel2.Controls.Add(txtGain4)
            Panel2.Controls.Add(txtGain5)
            Panel2.Controls.Add(txtGain6)
            Panel2.Controls.Add(txtGain7)
            Panel2.Controls.Add(txtGain8)
            Panel2.Controls.Add(txtGain9)
            Panel2.Controls.Add(txtGain10)

            Panel2.Controls.Add(txtDelay1)
            Panel2.Controls.Add(txtDelay2)
            Panel2.Controls.Add(txtDelay3)
            Panel2.Controls.Add(txtDelay4)
            Panel2.Controls.Add(txtDelay5)
            Panel2.Controls.Add(txtDelay6)
            Panel2.Controls.Add(txtDelay7)
            Panel2.Controls.Add(txtDelay8)
            Panel2.Controls.Add(txtDelay9)
            Panel2.Controls.Add(txtDelay10)

            Panel2.Controls.Add(txtRange1)
            Panel2.Controls.Add(txtRange2)
            Panel2.Controls.Add(txtRange3)
            Panel2.Controls.Add(txtRange4)
            Panel2.Controls.Add(txtRange5)
            Panel2.Controls.Add(txtRange6)
            Panel2.Controls.Add(txtRange7)
            Panel2.Controls.Add(txtRange8)
            Panel2.Controls.Add(txtRange9)
            Panel2.Controls.Add(txtRange10)

            Panel2.Controls.Add(txtReject1)
            Panel2.Controls.Add(txtReject2)
            Panel2.Controls.Add(txtReject3)
            Panel2.Controls.Add(txtReject4)
            Panel2.Controls.Add(txtReject5)
            Panel2.Controls.Add(txtReject6)
            Panel2.Controls.Add(txtReject7)
            Panel2.Controls.Add(txtReject8)
            Panel2.Controls.Add(txtReject9)
            Panel2.Controls.Add(txtReject10)

            Panel2.Controls.Add(txtGateS1)
            Panel2.Controls.Add(txtGateS2)
            Panel2.Controls.Add(txtGateS3)
            Panel2.Controls.Add(txtGateS4)
            Panel2.Controls.Add(txtGateS5)
            Panel2.Controls.Add(txtGateS6)
            Panel2.Controls.Add(txtGateS7)
            Panel2.Controls.Add(txtGateS8)
            Panel2.Controls.Add(txtGateS9)
            Panel2.Controls.Add(txtGateS10)

            Panel2.Controls.Add(txtGateW1)
            Panel2.Controls.Add(txtGateW2)
            Panel2.Controls.Add(txtGateW3)
            Panel2.Controls.Add(txtGateW4)
            Panel2.Controls.Add(txtGateW5)
            Panel2.Controls.Add(txtGateW6)
            Panel2.Controls.Add(txtGateW7)
            Panel2.Controls.Add(txtGateW8)
            Panel2.Controls.Add(txtGateW9)
            Panel2.Controls.Add(txtGateW10)

            Panel2.Controls.Add(txtThresh1)
            Panel2.Controls.Add(txtThresh2)
            Panel2.Controls.Add(txtThresh3)
            Panel2.Controls.Add(txtThresh4)
            Panel2.Controls.Add(txtThresh5)
            Panel2.Controls.Add(txtThresh6)
            Panel2.Controls.Add(txtThresh7)
            Panel2.Controls.Add(txtThresh8)
            Panel2.Controls.Add(txtThresh9)
            Panel2.Controls.Add(txtThresh10)

            Panel2.Controls.Add(txtG2St1)
            Panel2.Controls.Add(txtG2St2)
            Panel2.Controls.Add(txtG2St3)
            Panel2.Controls.Add(txtG2St4)
            Panel2.Controls.Add(txtG2St5)
            Panel2.Controls.Add(txtG2St6)
            Panel2.Controls.Add(txtG2St7)
            Panel2.Controls.Add(txtG2St8)
            Panel2.Controls.Add(txtG2St9)
            Panel2.Controls.Add(txtG2St10)

            Panel2.Controls.Add(txtG2Wd1)
            Panel2.Controls.Add(txtG2Wd2)
            Panel2.Controls.Add(txtG2Wd3)
            Panel2.Controls.Add(txtG2Wd4)
            Panel2.Controls.Add(txtG2Wd5)
            Panel2.Controls.Add(txtG2Wd6)
            Panel2.Controls.Add(txtG2Wd7)
            Panel2.Controls.Add(txtG2Wd8)
            Panel2.Controls.Add(txtG2Wd9)
            Panel2.Controls.Add(txtG2Wd10)

            Panel2.Controls.Add(txtThr21)
            Panel2.Controls.Add(txtThr22)
            Panel2.Controls.Add(txtThr23)
            Panel2.Controls.Add(txtThr24)
            Panel2.Controls.Add(txtThr25)
            Panel2.Controls.Add(txtThr26)
            Panel2.Controls.Add(txtThr27)
            Panel2.Controls.Add(txtThr28)
            Panel2.Controls.Add(txtThr29)
            Panel2.Controls.Add(txtThr210)

            Panel2.Controls.Add(txtG2St1)
            Panel2.Controls.Add(txtG2St2)
            Panel2.Controls.Add(txtG2St3)
            Panel2.Controls.Add(txtG2St4)
            Panel2.Controls.Add(txtG2St5)
            Panel2.Controls.Add(txtG2St6)
            Panel2.Controls.Add(txtG2St7)
            Panel2.Controls.Add(txtG2St8)
            Panel2.Controls.Add(txtG2St9)
            Panel2.Controls.Add(txtG2St10)

            Panel2.Controls.Add(txtG2Wd1)
            Panel2.Controls.Add(txtG2Wd2)
            Panel2.Controls.Add(txtG2Wd3)
            Panel2.Controls.Add(txtG2Wd4)
            Panel2.Controls.Add(txtG2Wd5)
            Panel2.Controls.Add(txtG2Wd6)
            Panel2.Controls.Add(txtG2Wd7)
            Panel2.Controls.Add(txtG2Wd8)
            Panel2.Controls.Add(txtG2Wd9)
            Panel2.Controls.Add(txtG2Wd10)

            Panel2.Controls.Add(txtThr21)
            Panel2.Controls.Add(txtThr22)
            Panel2.Controls.Add(txtThr23)
            Panel2.Controls.Add(txtThr24)
            Panel2.Controls.Add(txtThr25)
            Panel2.Controls.Add(txtThr26)
            Panel2.Controls.Add(txtThr27)
            Panel2.Controls.Add(txtThr28)
            Panel2.Controls.Add(txtThr29)
            Panel2.Controls.Add(txtThr210)

            Panel2.Controls.Add(txtAng1)
            Panel2.Controls.Add(txtAng2)
            Panel2.Controls.Add(txtAng3)
            Panel2.Controls.Add(txtAng4)
            Panel2.Controls.Add(txtAng5)
            Panel2.Controls.Add(txtAng6)
            Panel2.Controls.Add(txtAng7)
            Panel2.Controls.Add(txtAng8)
            Panel2.Controls.Add(txtAng9)
            Panel2.Controls.Add(txtAng10)

            AddHandler txtGain1.KeyPress, AddressOf txt_KeyPress
            AddHandler txtGain2.KeyPress, AddressOf txt_KeyPress
            AddHandler txtGain3.KeyPress, AddressOf txt_KeyPress
            AddHandler txtGain4.KeyPress, AddressOf txt_KeyPress
            AddHandler txtGain5.KeyPress, AddressOf txt_KeyPress
            AddHandler txtGain6.KeyPress, AddressOf txt_KeyPress
            AddHandler txtGain7.KeyPress, AddressOf txt_KeyPress
            AddHandler txtGain8.KeyPress, AddressOf txt_KeyPress
            AddHandler txtGain9.KeyPress, AddressOf txt_KeyPress
            AddHandler txtGain10.KeyPress, AddressOf txt_KeyPress

            AddHandler txtDelay1.KeyPress, AddressOf txt_KeyPress
            AddHandler txtDelay2.KeyPress, AddressOf txt_KeyPress
            AddHandler txtDelay3.KeyPress, AddressOf txt_KeyPress
            AddHandler txtDelay4.KeyPress, AddressOf txt_KeyPress
            AddHandler txtDelay5.KeyPress, AddressOf txt_KeyPress
            AddHandler txtDelay6.KeyPress, AddressOf txt_KeyPress
            AddHandler txtDelay7.KeyPress, AddressOf txt_KeyPress
            AddHandler txtDelay8.KeyPress, AddressOf txt_KeyPress
            AddHandler txtDelay9.KeyPress, AddressOf txt_KeyPress
            AddHandler txtDelay10.KeyPress, AddressOf txt_KeyPress


            AddHandler txtRange1.KeyPress, AddressOf txt_KeyPress
            AddHandler txtRange2.KeyPress, AddressOf txt_KeyPress
            AddHandler txtRange3.KeyPress, AddressOf txt_KeyPress
            AddHandler txtRange4.KeyPress, AddressOf txt_KeyPress
            AddHandler txtRange5.KeyPress, AddressOf txt_KeyPress
            AddHandler txtRange6.KeyPress, AddressOf txt_KeyPress
            AddHandler txtRange7.KeyPress, AddressOf txt_KeyPress
            AddHandler txtRange8.KeyPress, AddressOf txt_KeyPress
            AddHandler txtRange9.KeyPress, AddressOf txt_KeyPress
            AddHandler txtRange10.KeyPress, AddressOf txt_KeyPress

            AddHandler txtReject1.KeyPress, AddressOf txt_KeyPress
            AddHandler txtReject2.KeyPress, AddressOf txt_KeyPress
            AddHandler txtReject3.KeyPress, AddressOf txt_KeyPress
            AddHandler txtReject4.KeyPress, AddressOf txt_KeyPress
            AddHandler txtReject5.KeyPress, AddressOf txt_KeyPress
            AddHandler txtReject6.KeyPress, AddressOf txt_KeyPress
            AddHandler txtReject7.KeyPress, AddressOf txt_KeyPress
            AddHandler txtReject8.KeyPress, AddressOf txt_KeyPress
            AddHandler txtReject9.KeyPress, AddressOf txt_KeyPress
            AddHandler txtReject10.KeyPress, AddressOf txt_KeyPress

            AddHandler txtGateS1.KeyPress, AddressOf txt_KeyPress
            AddHandler txtGateS2.KeyPress, AddressOf txt_KeyPress
            AddHandler txtGateS3.KeyPress, AddressOf txt_KeyPress
            AddHandler txtGateS4.KeyPress, AddressOf txt_KeyPress
            AddHandler txtGateS5.KeyPress, AddressOf txt_KeyPress
            AddHandler txtGateS6.KeyPress, AddressOf txt_KeyPress
            AddHandler txtGateS7.KeyPress, AddressOf txt_KeyPress
            AddHandler txtGateS8.KeyPress, AddressOf txt_KeyPress
            AddHandler txtGateS9.KeyPress, AddressOf txt_KeyPress
            AddHandler txtGateS10.KeyPress, AddressOf txt_KeyPress

            AddHandler txtGateW1.KeyPress, AddressOf txt_KeyPress
            AddHandler txtGateW2.KeyPress, AddressOf txt_KeyPress
            AddHandler txtGateW3.KeyPress, AddressOf txt_KeyPress
            AddHandler txtGateW4.KeyPress, AddressOf txt_KeyPress
            AddHandler txtGateW5.KeyPress, AddressOf txt_KeyPress
            AddHandler txtGateW6.KeyPress, AddressOf txt_KeyPress
            AddHandler txtGateW7.KeyPress, AddressOf txt_KeyPress
            AddHandler txtGateW8.KeyPress, AddressOf txt_KeyPress
            AddHandler txtGateW9.KeyPress, AddressOf txt_KeyPress
            AddHandler txtGateW10.KeyPress, AddressOf txt_KeyPress

            AddHandler txtThresh1.KeyPress, AddressOf txt_KeyPress
            AddHandler txtThresh2.KeyPress, AddressOf txt_KeyPress
            AddHandler txtThresh3.KeyPress, AddressOf txt_KeyPress
            AddHandler txtThresh4.KeyPress, AddressOf txt_KeyPress
            AddHandler txtThresh5.KeyPress, AddressOf txt_KeyPress
            AddHandler txtThresh6.KeyPress, AddressOf txt_KeyPress
            AddHandler txtThresh7.KeyPress, AddressOf txt_KeyPress
            AddHandler txtThresh8.KeyPress, AddressOf txt_KeyPress
            AddHandler txtThresh9.KeyPress, AddressOf txt_KeyPress
            AddHandler txtThresh10.KeyPress, AddressOf txt_KeyPress

            AddHandler txtG2St1.KeyPress, AddressOf txt_KeyPress
            AddHandler txtG2St2.KeyPress, AddressOf txt_KeyPress
            AddHandler txtG2St3.KeyPress, AddressOf txt_KeyPress
            AddHandler txtG2St4.KeyPress, AddressOf txt_KeyPress
            AddHandler txtG2St5.KeyPress, AddressOf txt_KeyPress
            AddHandler txtG2St6.KeyPress, AddressOf txt_KeyPress
            AddHandler txtG2St7.KeyPress, AddressOf txt_KeyPress
            AddHandler txtG2St8.KeyPress, AddressOf txt_KeyPress
            AddHandler txtG2St9.KeyPress, AddressOf txt_KeyPress
            AddHandler txtG2St10.KeyPress, AddressOf txt_KeyPress

            AddHandler txtG2Wd1.KeyPress, AddressOf txt_KeyPress
            AddHandler txtG2Wd2.KeyPress, AddressOf txt_KeyPress
            AddHandler txtG2Wd3.KeyPress, AddressOf txt_KeyPress
            AddHandler txtG2Wd4.KeyPress, AddressOf txt_KeyPress
            AddHandler txtG2Wd5.KeyPress, AddressOf txt_KeyPress
            AddHandler txtG2Wd6.KeyPress, AddressOf txt_KeyPress
            AddHandler txtG2Wd7.KeyPress, AddressOf txt_KeyPress
            AddHandler txtG2Wd8.KeyPress, AddressOf txt_KeyPress
            AddHandler txtG2Wd9.KeyPress, AddressOf txt_KeyPress
            AddHandler txtG2Wd10.KeyPress, AddressOf txt_KeyPress

            AddHandler txtThr21.KeyPress, AddressOf txt_KeyPress
            AddHandler txtThr22.KeyPress, AddressOf txt_KeyPress
            AddHandler txtThr23.KeyPress, AddressOf txt_KeyPress
            AddHandler txtThr24.KeyPress, AddressOf txt_KeyPress
            AddHandler txtThr25.KeyPress, AddressOf txt_KeyPress
            AddHandler txtThr26.KeyPress, AddressOf txt_KeyPress
            AddHandler txtThr27.KeyPress, AddressOf txt_KeyPress
            AddHandler txtThr28.KeyPress, AddressOf txt_KeyPress
            AddHandler txtThr29.KeyPress, AddressOf txt_KeyPress
            AddHandler txtThr210.KeyPress, AddressOf txt_KeyPress

            AddHandler txtAng1.KeyPress, AddressOf txt_KeyPress
            AddHandler txtAng2.KeyPress, AddressOf txt_KeyPress
            AddHandler txtAng3.KeyPress, AddressOf txt_KeyPress
            AddHandler txtAng4.KeyPress, AddressOf txt_KeyPress
            AddHandler txtAng5.KeyPress, AddressOf txt_KeyPress
            AddHandler txtAng6.KeyPress, AddressOf txt_KeyPress
            AddHandler txtAng7.KeyPress, AddressOf txt_KeyPress
            AddHandler txtAng8.KeyPress, AddressOf txt_KeyPress
            AddHandler txtAng9.KeyPress, AddressOf txt_KeyPress
            AddHandler txtAng10.KeyPress, AddressOf txt_KeyPress

            Application.DoEvents()
        Catch ex As Exception

        End Try
    End Sub

    'DRT Function
    Private Sub DispTextBoxes1()
        lblSide2.Left = 0 : lblSide2.Top = lblC7.Top + lblC7.Height + 2
        lblC11 = New Label
        lblC11.BackColor = lblC1.BackColor
        lblC11.Font = lblC1.Font
        lblC11.Height = lblC1.Height
        lblC11.Left = lblC1.Left : lblC11.Top = lblSide2.Top + lblSide2.Height + 2 : lblC11.Text = "8"
        lblC11.Width = lblC1.Width

        lblC12 = New Label
        lblC12.BackColor = lblC2.BackColor
        lblC12.Font = lblC2.Font
        lblC12.Height = lblC2.Height
        lblC12.Left = lblC1.Left : lblC12.Top = lblC11.Top + lblC11.Height + 2 : lblC12.Text = "9"
        lblC12.Width = lblC1.Width
        Application.DoEvents()

        lblC13 = New Label
        lblC13.BackColor = lblC3.BackColor
        lblC13.Font = lblC3.Font
        lblC13.Height = lblC3.Height
        lblC13.Left = lblC1.Left : lblC13.Top = lblC12.Top + lblC12.Height + 2 : lblC13.Text = "10"
        lblC13.Width = lblC1.Width
        Application.DoEvents()

        lblC14 = New Label
        lblC14.BackColor = lblC4.BackColor
        lblC14.Font = lblC4.Font
        lblC14.Height = lblC4.Height
        lblC14.Left = lblC1.Left : lblC14.Top = lblC13.Top + lblC13.Height + 2 : lblC14.Text = "11"
        lblC14.Width = lblC1.Width
        Application.DoEvents()

        lblC15 = New Label
        lblC15.BackColor = lblC5.BackColor
        lblC15.Font = lblC5.Font
        lblC15.Height = lblC5.Height
        lblC15.Left = lblC1.Left : lblC15.Top = lblC14.Top + lblC14.Height + 2 : lblC15.Text = "12"
        lblC15.Width = lblC1.Width
        Application.DoEvents()

        lblC16 = New Label
        lblC16.BackColor = lblC6.BackColor
        lblC16.Font = lblC6.Font
        lblC16.Height = lblC6.Height
        lblC16.Left = lblC1.Left : lblC16.Top = lblC15.Top + lblC15.Height + 2 : lblC16.Text = "13"
        lblC16.Width = lblC1.Width
        Application.DoEvents()

        lblC17 = New Label
        lblC17.BackColor = lblC7.BackColor
        lblC17.Font = lblC7.Font
        lblC17.Height = lblC7.Height
        lblC17.Left = lblC1.Left : lblC17.Top = lblC16.Top + lblC16.Height + 2 : lblC17.Text = "14"
        lblC17.Width = lblC1.Width
        Application.DoEvents()

        Me.Controls.Add(lblC11)
        Me.Controls.Add(lblC12)
        Me.Controls.Add(lblC13)
        Me.Controls.Add(lblC14)
        Me.Controls.Add(lblC15)
        Me.Controls.Add(lblC16)
        Me.Controls.Add(lblC17)


        txtGain11 = New TextBox
        txtGain11.Left = lblGain.Left : txtGain11.Top = lblC11.Top : txtGain11.Width = lblGain.Width
        txtGain11.Font = lblInput.Font
        txtGain12 = New TextBox
        txtGain12.Font = lblInput.Font
        txtGain12.Left = lblGain.Left : txtGain12.Top = lblC12.Top : txtGain12.Width = lblGain.Width
        txtGain13 = New TextBox
        txtGain13.Left = lblGain.Left : txtGain13.Top = lblC13.Top : txtGain13.Width = lblGain.Width
        txtGain13.Font = lblInput.Font
        txtGain14 = New TextBox
        txtGain14.Left = lblGain.Left : txtGain14.Top = lblC14.Top : txtGain14.Width = lblGain.Width
        txtGain14.Font = lblInput.Font
        txtGain15 = New TextBox
        txtGain15.Left = lblGain.Left : txtGain15.Top = lblC15.Top : txtGain15.Width = lblGain.Width
        txtGain15.Font = lblInput.Font
        txtGain16 = New TextBox
        txtGain16.Left = lblGain.Left : txtGain16.Top = lblC16.Top : txtGain16.Width = lblGain.Width
        txtGain16.Font = lblInput.Font
        txtGain17 = New TextBox
        txtGain17.Left = lblGain.Left : txtGain17.Top = lblC17.Top : txtGain17.Width = lblGain.Width
        txtGain17.Font = lblInput.Font

        txtDelay11 = New TextBox
        txtDelay11.Left = lblDelay.Left : txtDelay11.Top = lblC11.Top : txtDelay11.Width = lblDelay.Width
        txtDelay11.Font = lblInput.Font
        txtDelay12 = New TextBox
        txtDelay12.Left = lblDelay.Left : txtDelay12.Top = lblC12.Top : txtDelay12.Width = lblDelay.Width
        txtDelay12.Font = lblInput.Font
        txtDelay13 = New TextBox
        txtDelay13.Left = lblDelay.Left : txtDelay13.Top = lblC13.Top : txtDelay13.Width = lblDelay.Width
        txtDelay13.Font = lblInput.Font
        txtDelay14 = New TextBox
        txtDelay14.Left = lblDelay.Left : txtDelay14.Top = lblC14.Top : txtDelay14.Width = lblDelay.Width
        txtDelay14.Font = lblInput.Font
        txtDelay15 = New TextBox
        txtDelay15.Left = lblDelay.Left : txtDelay15.Top = lblC15.Top : txtDelay15.Width = lblDelay.Width
        txtDelay15.Font = lblInput.Font
        txtDelay16 = New TextBox
        txtDelay16.Left = lblDelay.Left : txtDelay16.Top = lblC16.Top : txtDelay16.Width = lblDelay.Width
        txtDelay16.Font = lblInput.Font
        txtDelay17 = New TextBox
        txtDelay17.Left = lblDelay.Left : txtDelay17.Top = lblC17.Top : txtDelay17.Width = lblDelay.Width
        txtDelay17.Font = lblInput.Font

        txtRange11 = New TextBox
        txtRange11.Left = lblRange.Left : txtRange11.Top = lblC11.Top : txtRange11.Width = lblRange.Width
        txtRange11.Font = lblInput.Font
        txtRange12 = New TextBox
        txtRange12.Left = lblRange.Left : txtRange12.Top = lblC12.Top : txtRange12.Width = lblRange.Width
        txtRange12.Font = lblInput.Font
        txtRange13 = New TextBox
        txtRange13.Left = lblRange.Left : txtRange13.Top = lblC13.Top : txtRange13.Width = lblRange.Width
        txtRange13.Font = lblInput.Font
        txtRange14 = New TextBox
        txtRange14.Left = lblRange.Left : txtRange14.Top = lblC14.Top : txtRange14.Width = lblRange.Width
        txtRange14.Font = lblInput.Font
        txtRange15 = New TextBox
        txtRange15.Left = lblRange.Left : txtRange15.Top = lblC15.Top : txtRange15.Width = lblRange.Width
        txtRange15.Font = lblInput.Font
        txtRange16 = New TextBox
        txtRange16.Left = lblRange.Left : txtRange16.Top = lblC16.Top : txtRange16.Width = lblRange.Width
        txtRange16.Font = lblInput.Font
        txtRange17 = New TextBox
        txtRange17.Left = lblRange.Left : txtRange17.Top = lblC17.Top : txtRange17.Width = lblRange.Width
        txtRange17.Font = lblInput.Font

        txtReject11 = New TextBox
        txtReject11.Left = lblReject.Left : txtReject11.Top = lblC11.Top : txtReject11.Width = lblReject.Width
        txtReject11.Font = lblInput.Font
        txtReject12 = New TextBox
        txtReject12.Left = lblReject.Left : txtReject12.Top = lblC12.Top : txtReject12.Width = lblReject.Width
        txtReject12.Font = lblInput.Font
        txtReject13 = New TextBox
        txtReject13.Left = lblReject.Left : txtReject13.Top = lblC13.Top : txtReject13.Width = lblReject.Width
        txtReject13.Font = lblInput.Font
        txtReject14 = New TextBox
        txtReject14.Left = lblReject.Left : txtReject14.Top = lblC14.Top : txtReject14.Width = lblReject.Width
        txtReject14.Font = lblInput.Font
        txtReject15 = New TextBox
        txtReject15.Left = lblReject.Left : txtReject15.Top = lblC15.Top : txtReject15.Width = lblReject.Width
        txtReject15.Font = lblInput.Font
        txtReject16 = New TextBox
        txtReject16.Left = lblReject.Left : txtReject16.Top = lblC16.Top : txtReject16.Width = lblReject.Width
        txtReject16.Font = lblInput.Font
        txtReject17 = New TextBox
        txtReject17.Left = lblReject.Left : txtReject17.Top = lblC17.Top : txtReject17.Width = lblReject.Width
        txtReject17.Font = lblInput.Font

        txtGateS11 = New TextBox
        txtGateS11.Left = lblGateS.Left : txtGateS11.Top = lblC11.Top : txtGateS11.Width = lblGateS.Width
        txtGateS11.Font = lblInput.Font
        txtGateS12 = New TextBox
        txtGateS12.Left = lblGateS.Left : txtGateS12.Top = lblC12.Top : txtGateS12.Width = lblGateS.Width
        txtGateS12.Font = lblInput.Font
        txtGateS13 = New TextBox
        txtGateS13.Left = lblGateS.Left : txtGateS13.Top = lblC13.Top : txtGateS13.Width = lblGateS.Width
        txtGateS13.Font = lblInput.Font
        txtGateS14 = New TextBox
        txtGateS14.Left = lblGateS.Left : txtGateS14.Top = lblC14.Top : txtGateS14.Width = lblGateS.Width
        txtGateS14.Font = lblInput.Font
        txtGateS15 = New TextBox
        txtGateS15.Left = lblGateS.Left : txtGateS15.Top = lblC15.Top : txtGateS15.Width = lblGateS.Width
        txtGateS15.Font = lblInput.Font
        txtGateS16 = New TextBox
        txtGateS16.Left = lblGateS.Left : txtGateS16.Top = lblC16.Top : txtGateS16.Width = lblGateS.Width
        txtGateS16.Font = lblInput.Font
        txtGateS17 = New TextBox
        txtGateS17.Left = lblGateS.Left : txtGateS17.Top = lblC17.Top : txtGateS17.Width = lblGateS.Width
        txtGateS17.Font = lblInput.Font

        txtGateW11 = New TextBox
        txtGateW11.Left = lblGateW.Left : txtGateW11.Top = lblC11.Top : txtGateW11.Width = lblGateW.Width
        txtGateW11.Font = lblInput.Font
        txtGateW12 = New TextBox
        txtGateW12.Left = lblGateW.Left : txtGateW12.Top = lblC12.Top : txtGateW12.Width = lblGateW.Width
        txtGateW12.Font = lblInput.Font
        txtGateW13 = New TextBox
        txtGateW13.Left = lblGateW.Left : txtGateW13.Top = lblC13.Top : txtGateW13.Width = lblGateW.Width
        txtGateW13.Font = lblInput.Font
        txtGateW14 = New TextBox
        txtGateW14.Left = lblGateW.Left : txtGateW14.Top = lblC14.Top : txtGateW14.Width = lblGateW.Width
        txtGateW14.Font = lblInput.Font
        txtGateW15 = New TextBox
        txtGateW15.Left = lblGateW.Left : txtGateW15.Top = lblC15.Top : txtGateW15.Width = lblGateW.Width
        txtGateW15.Font = lblInput.Font
        txtGateW16 = New TextBox
        txtGateW16.Left = lblGateW.Left : txtGateW16.Top = lblC16.Top : txtGateW16.Width = lblGateW.Width
        txtGateW16.Font = lblInput.Font
        txtGateW17 = New TextBox
        txtGateW17.Left = lblGateW.Left : txtGateW17.Top = lblC17.Top : txtGateW17.Width = lblGateW.Width
        txtGateW17.Font = lblInput.Font

        txtThresh11 = New TextBox
        txtThresh11.Left = lblThresh.Left : txtThresh11.Top = lblC11.Top : txtThresh11.Width = lblThresh.Width
        txtThresh11.Font = lblInput.Font
        txtThresh12 = New TextBox
        txtThresh12.Left = lblThresh.Left : txtThresh12.Top = lblC12.Top : txtThresh12.Width = lblThresh.Width
        txtThresh12.Font = lblInput.Font
        txtThresh13 = New TextBox
        txtThresh13.Left = lblThresh.Left : txtThresh13.Top = lblC13.Top : txtThresh13.Width = lblThresh.Width
        txtThresh13.Font = lblInput.Font
        txtThresh14 = New TextBox
        txtThresh14.Left = lblThresh.Left : txtThresh14.Top = lblC14.Top : txtThresh14.Width = lblThresh.Width
        txtThresh14.Font = lblInput.Font
        txtThresh15 = New TextBox
        txtThresh15.Left = lblThresh.Left : txtThresh15.Top = lblC15.Top : txtThresh15.Width = lblThresh.Width
        txtThresh15.Font = lblInput.Font
        txtThresh16 = New TextBox
        txtThresh16.Left = lblThresh.Left : txtThresh16.Top = lblC16.Top : txtThresh16.Width = lblThresh.Width
        txtThresh16.Font = lblInput.Font
        txtThresh17 = New TextBox
        txtThresh17.Left = lblThresh.Left : txtThresh17.Top = lblC17.Top : txtThresh17.Width = lblThresh.Width
        txtThresh17.Font = lblInput.Font

        txtG2St11 = New TextBox
        txtG2St11.Left = lblG2St.Left : txtG2St11.Top = lblC11.Top : txtG2St11.Width = lblG2St.Width
        txtG2St11.Font = lblInput.Font
        txtG2St12 = New TextBox
        txtG2St12.Left = lblG2St.Left : txtG2St12.Top = lblC12.Top : txtG2St12.Width = lblG2St.Width
        txtG2St12.Font = lblInput.Font
        txtG2St13 = New TextBox
        txtG2St13.Left = lblG2St.Left : txtG2St13.Top = lblC13.Top : txtG2St13.Width = lblG2St.Width
        txtG2St13.Font = lblInput.Font
        txtG2St14 = New TextBox
        txtG2St14.Left = lblG2St.Left : txtG2St14.Top = lblC14.Top : txtG2St14.Width = lblG2St.Width
        txtG2St14.Font = lblInput.Font
        txtG2St15 = New TextBox
        txtG2St15.Left = lblG2St.Left : txtG2St15.Top = lblC15.Top : txtG2St15.Width = lblG2St.Width
        txtG2St15.Font = lblInput.Font
        txtG2St16 = New TextBox
        txtG2St16.Left = lblG2St.Left : txtG2St16.Top = lblC16.Top : txtG2St16.Width = lblG2St.Width
        txtG2St16.Font = lblInput.Font
        txtG2St17 = New TextBox
        txtG2St17.Left = lblG2St.Left : txtG2St17.Top = lblC17.Top : txtG2St17.Width = lblG2St.Width
        txtG2St17.Font = lblInput.Font

        txtG2Wd11 = New TextBox
        txtG2Wd11.Left = lblG2Wd.Left : txtG2Wd11.Top = lblC11.Top : txtG2Wd11.Width = lblG2Wd.Width
        txtG2Wd11.Font = lblInput.Font
        txtG2Wd12 = New TextBox
        txtG2Wd12.Left = lblG2Wd.Left : txtG2Wd12.Top = lblC12.Top : txtG2Wd12.Width = lblG2Wd.Width
        txtG2Wd12.Font = lblInput.Font
        txtG2Wd13 = New TextBox
        txtG2Wd13.Left = lblG2Wd.Left : txtG2Wd13.Top = lblC13.Top : txtG2Wd13.Width = lblG2Wd.Width
        txtG2Wd13.Font = lblInput.Font
        txtG2Wd14 = New TextBox
        txtG2Wd14.Left = lblG2Wd.Left : txtG2Wd14.Top = lblC14.Top : txtG2Wd14.Width = lblG2Wd.Width
        txtG2Wd14.Font = lblInput.Font
        txtG2Wd15 = New TextBox
        txtG2Wd15.Left = lblG2Wd.Left : txtG2Wd15.Top = lblC15.Top : txtG2Wd15.Width = lblG2Wd.Width
        txtG2Wd15.Font = lblInput.Font
        txtG2Wd16 = New TextBox
        txtG2Wd16.Left = lblG2Wd.Left : txtG2Wd16.Top = lblC16.Top : txtG2Wd16.Width = lblG2Wd.Width
        txtG2Wd16.Font = lblInput.Font
        txtG2Wd17 = New TextBox
        txtG2Wd17.Left = lblG2Wd.Left : txtG2Wd17.Top = lblC17.Top : txtG2Wd17.Width = lblG2Wd.Width
        txtG2Wd17.Font = lblInput.Font

        txtThr211 = New TextBox
        txtThr211.Left = lblThr2.Left : txtThr211.Top = lblC11.Top : txtThr211.Width = lblThr2.Width
        txtThr211.Font = lblInput.Font
        txtThr212 = New TextBox
        txtThr212.Left = lblThr2.Left : txtThr212.Top = lblC12.Top : txtThr212.Width = lblThr2.Width
        txtThr212.Font = lblInput.Font
        txtThr213 = New TextBox
        txtThr213.Left = lblThr2.Left : txtThr213.Top = lblC13.Top : txtThr213.Width = lblThr2.Width
        txtThr213.Font = lblInput.Font
        txtThr214 = New TextBox
        txtThr214.Left = lblThr2.Left : txtThr214.Top = lblC14.Top : txtThr214.Width = lblThr2.Width
        txtThr214.Font = lblInput.Font
        txtThr215 = New TextBox
        txtThr215.Left = lblThr2.Left : txtThr215.Top = lblC15.Top : txtThr215.Width = lblThr2.Width
        txtThr215.Font = lblInput.Font
        txtThr216 = New TextBox
        txtThr216.Left = lblThr2.Left : txtThr216.Top = lblC16.Top : txtThr216.Width = lblThr2.Width
        txtThr216.Font = lblInput.Font
        txtThr217 = New TextBox
        txtThr217.Left = lblThr2.Left : txtThr217.Top = lblC17.Top : txtThr217.Width = lblThr2.Width
        txtThr217.Font = lblInput.Font

        txtAng11 = New TextBox
        txtAng11.Left = lblAng.Left : txtAng11.Top = lblC11.Top : txtAng11.Width = lblAng.Width
        txtAng11.Font = lblInput.Font
        txtAng12 = New TextBox
        txtAng12.Left = lblAng.Left : txtAng12.Top = lblC12.Top : txtAng12.Width = lblAng.Width
        txtAng12.Font = lblInput.Font
        txtAng13 = New TextBox
        txtAng13.Left = lblAng.Left : txtAng13.Top = lblC13.Top : txtAng13.Width = lblAng.Width
        txtAng13.Font = lblInput.Font
        txtAng14 = New TextBox
        txtAng14.Left = lblAng.Left : txtAng14.Top = lblC14.Top : txtAng14.Width = lblAng.Width
        txtAng14.Font = lblInput.Font
        txtAng15 = New TextBox
        txtAng15.Left = lblAng.Left : txtAng15.Top = lblC15.Top : txtAng15.Width = lblAng.Width
        txtAng15.Font = lblInput.Font
        txtAng16 = New TextBox
        txtAng16.Left = lblAng.Left : txtAng16.Top = lblC16.Top : txtAng16.Width = lblAng.Width
        txtAng16.Font = lblInput.Font
        txtAng17 = New TextBox
        txtAng17.Left = lblAng.Left : txtAng17.Top = lblC17.Top : txtAng17.Width = lblAng.Width
        txtAng17.Font = lblInput.Font

        Panel2.Controls.Add(txtGain11)
        Panel2.Controls.Add(txtGain12)
        Panel2.Controls.Add(txtGain13)
        Panel2.Controls.Add(txtGain14)
        Panel2.Controls.Add(txtGain15)
        Panel2.Controls.Add(txtGain16)
        Panel2.Controls.Add(txtGain17)

        Panel2.Controls.Add(txtDelay11)
        Panel2.Controls.Add(txtDelay12)
        Panel2.Controls.Add(txtDelay13)
        Panel2.Controls.Add(txtDelay14)
        Panel2.Controls.Add(txtDelay15)
        Panel2.Controls.Add(txtDelay16)
        Panel2.Controls.Add(txtDelay17)

        Panel2.Controls.Add(txtRange11)
        Panel2.Controls.Add(txtRange12)
        Panel2.Controls.Add(txtRange13)
        Panel2.Controls.Add(txtRange14)
        Panel2.Controls.Add(txtRange15)
        Panel2.Controls.Add(txtRange16)
        Panel2.Controls.Add(txtRange17)

        Panel2.Controls.Add(txtReject11)
        Panel2.Controls.Add(txtReject12)
        Panel2.Controls.Add(txtReject13)
        Panel2.Controls.Add(txtReject14)
        Panel2.Controls.Add(txtReject15)
        Panel2.Controls.Add(txtReject16)
        Panel2.Controls.Add(txtReject17)

        Panel2.Controls.Add(txtGateS11)
        Panel2.Controls.Add(txtGateS12)
        Panel2.Controls.Add(txtGateS13)
        Panel2.Controls.Add(txtGateS14)
        Panel2.Controls.Add(txtGateS15)
        Panel2.Controls.Add(txtGateS16)
        Panel2.Controls.Add(txtGateS17)

        Panel2.Controls.Add(txtGateW11)
        Panel2.Controls.Add(txtGateW12)
        Panel2.Controls.Add(txtGateW13)
        Panel2.Controls.Add(txtGateW14)
        Panel2.Controls.Add(txtGateW15)
        Panel2.Controls.Add(txtGateW16)
        Panel2.Controls.Add(txtGateW17)

        Panel2.Controls.Add(txtThresh11)
        Panel2.Controls.Add(txtThresh12)
        Panel2.Controls.Add(txtThresh13)
        Panel2.Controls.Add(txtThresh14)
        Panel2.Controls.Add(txtThresh15)
        Panel2.Controls.Add(txtThresh16)
        Panel2.Controls.Add(txtThresh17)

        Panel2.Controls.Add(txtG2St11)
        Panel2.Controls.Add(txtG2St12)
        Panel2.Controls.Add(txtG2St13)
        Panel2.Controls.Add(txtG2St14)
        Panel2.Controls.Add(txtG2St15)
        Panel2.Controls.Add(txtG2St16)
        Panel2.Controls.Add(txtG2St17)

        Panel2.Controls.Add(txtG2Wd11)
        Panel2.Controls.Add(txtG2Wd12)
        Panel2.Controls.Add(txtG2Wd13)
        Panel2.Controls.Add(txtG2Wd14)
        Panel2.Controls.Add(txtG2Wd15)
        Panel2.Controls.Add(txtG2Wd16)
        Panel2.Controls.Add(txtG2Wd17)

        Panel2.Controls.Add(txtThr211)
        Panel2.Controls.Add(txtThr212)
        Panel2.Controls.Add(txtThr213)
        Panel2.Controls.Add(txtThr214)
        Panel2.Controls.Add(txtThr215)
        Panel2.Controls.Add(txtThr216)
        Panel2.Controls.Add(txtThr217)

        Panel2.Controls.Add(txtAng11)
        Panel2.Controls.Add(txtAng12)
        Panel2.Controls.Add(txtAng13)
        Panel2.Controls.Add(txtAng14)
        Panel2.Controls.Add(txtAng15)
        Panel2.Controls.Add(txtAng16)
        Panel2.Controls.Add(txtAng17)

        AddHandler txtGain11.KeyPress, AddressOf txt_KeyPress
        AddHandler txtGain12.KeyPress, AddressOf txt_KeyPress
        AddHandler txtGain13.KeyPress, AddressOf txt_KeyPress
        AddHandler txtGain14.KeyPress, AddressOf txt_KeyPress
        AddHandler txtGain15.KeyPress, AddressOf txt_KeyPress
        AddHandler txtGain16.KeyPress, AddressOf txt_KeyPress
        AddHandler txtGain17.KeyPress, AddressOf txt_KeyPress

        AddHandler txtDelay11.KeyPress, AddressOf txt_KeyPress
        AddHandler txtDelay12.KeyPress, AddressOf txt_KeyPress
        AddHandler txtDelay13.KeyPress, AddressOf txt_KeyPress
        AddHandler txtDelay14.KeyPress, AddressOf txt_KeyPress
        AddHandler txtDelay15.KeyPress, AddressOf txt_KeyPress
        AddHandler txtDelay16.KeyPress, AddressOf txt_KeyPress
        AddHandler txtDelay17.KeyPress, AddressOf txt_KeyPress

        AddHandler txtRange11.KeyPress, AddressOf txt_KeyPress
        AddHandler txtRange12.KeyPress, AddressOf txt_KeyPress
        AddHandler txtRange13.KeyPress, AddressOf txt_KeyPress
        AddHandler txtRange14.KeyPress, AddressOf txt_KeyPress
        AddHandler txtRange15.KeyPress, AddressOf txt_KeyPress
        AddHandler txtRange16.KeyPress, AddressOf txt_KeyPress
        AddHandler txtRange17.KeyPress, AddressOf txt_KeyPress

        AddHandler txtReject11.KeyPress, AddressOf txt_KeyPress
        AddHandler txtReject12.KeyPress, AddressOf txt_KeyPress
        AddHandler txtReject13.KeyPress, AddressOf txt_KeyPress
        AddHandler txtReject14.KeyPress, AddressOf txt_KeyPress
        AddHandler txtReject15.KeyPress, AddressOf txt_KeyPress
        AddHandler txtReject16.KeyPress, AddressOf txt_KeyPress
        AddHandler txtReject17.KeyPress, AddressOf txt_KeyPress

        AddHandler txtGateS11.KeyPress, AddressOf txt_KeyPress
        AddHandler txtGateS12.KeyPress, AddressOf txt_KeyPress
        AddHandler txtGateS13.KeyPress, AddressOf txt_KeyPress
        AddHandler txtGateS14.KeyPress, AddressOf txt_KeyPress
        AddHandler txtGateS15.KeyPress, AddressOf txt_KeyPress
        AddHandler txtGateS16.KeyPress, AddressOf txt_KeyPress
        AddHandler txtGateS17.KeyPress, AddressOf txt_KeyPress

        AddHandler txtGateW11.KeyPress, AddressOf txt_KeyPress
        AddHandler txtGateW12.KeyPress, AddressOf txt_KeyPress
        AddHandler txtGateW13.KeyPress, AddressOf txt_KeyPress
        AddHandler txtGateW14.KeyPress, AddressOf txt_KeyPress
        AddHandler txtGateW15.KeyPress, AddressOf txt_KeyPress
        AddHandler txtGateW16.KeyPress, AddressOf txt_KeyPress
        AddHandler txtGateW17.KeyPress, AddressOf txt_KeyPress

        AddHandler txtThresh11.KeyPress, AddressOf txt_KeyPress
        AddHandler txtThresh12.KeyPress, AddressOf txt_KeyPress
        AddHandler txtThresh13.KeyPress, AddressOf txt_KeyPress
        AddHandler txtThresh14.KeyPress, AddressOf txt_KeyPress
        AddHandler txtThresh15.KeyPress, AddressOf txt_KeyPress
        AddHandler txtThresh16.KeyPress, AddressOf txt_KeyPress
        AddHandler txtThresh17.KeyPress, AddressOf txt_KeyPress

        AddHandler txtG2St11.KeyPress, AddressOf txt_KeyPress
        AddHandler txtG2St12.KeyPress, AddressOf txt_KeyPress
        AddHandler txtG2St13.KeyPress, AddressOf txt_KeyPress
        AddHandler txtG2St14.KeyPress, AddressOf txt_KeyPress
        AddHandler txtG2St15.KeyPress, AddressOf txt_KeyPress
        AddHandler txtG2St16.KeyPress, AddressOf txt_KeyPress
        AddHandler txtG2St17.KeyPress, AddressOf txt_KeyPress

        AddHandler txtG2Wd11.KeyPress, AddressOf txt_KeyPress
        AddHandler txtG2Wd12.KeyPress, AddressOf txt_KeyPress
        AddHandler txtG2Wd13.KeyPress, AddressOf txt_KeyPress
        AddHandler txtG2Wd14.KeyPress, AddressOf txt_KeyPress
        AddHandler txtG2Wd15.KeyPress, AddressOf txt_KeyPress
        AddHandler txtG2Wd16.KeyPress, AddressOf txt_KeyPress
        AddHandler txtG2Wd17.KeyPress, AddressOf txt_KeyPress

        AddHandler txtThr211.KeyPress, AddressOf txt_KeyPress
        AddHandler txtThr212.KeyPress, AddressOf txt_KeyPress
        AddHandler txtThr213.KeyPress, AddressOf txt_KeyPress
        AddHandler txtThr214.KeyPress, AddressOf txt_KeyPress
        AddHandler txtThr215.KeyPress, AddressOf txt_KeyPress
        AddHandler txtThr216.KeyPress, AddressOf txt_KeyPress
        AddHandler txtThr217.KeyPress, AddressOf txt_KeyPress

        AddHandler txtAng11.KeyPress, AddressOf txt_KeyPress
        AddHandler txtAng12.KeyPress, AddressOf txt_KeyPress
        AddHandler txtAng13.KeyPress, AddressOf txt_KeyPress
        AddHandler txtAng14.KeyPress, AddressOf txt_KeyPress
        AddHandler txtAng15.KeyPress, AddressOf txt_KeyPress
        AddHandler txtAng16.KeyPress, AddressOf txt_KeyPress
        AddHandler txtAng17.KeyPress, AddressOf txt_KeyPress

        If TotNch <= 9 Then TextBox1Visible(False) Else TextBox1Visible(True)
        If TotNch <= 5 Then TextBox10Visible(False)
        Application.DoEvents()
    End Sub
    Public Sub TextBox10Visible(Optional ByVal v As Boolean = True)
        txtGain10.Visible = v
        txtDelay10.Visible = v
        txtRange10.Visible = v
        txtReject10.Visible = v
        txtGateS10.Visible = v
        txtGateW10.Visible = v
        txtThresh10.Visible = v
        txtG2St10.Visible = v
        txtG2Wd10.Visible = v
        txtThr210.Visible = v
        txtAng10.Visible = v
        lblC10.Visible = v
    End Sub
    Public Sub lblCVisible(Optional ByVal v As Boolean = True)
        lblC1.Visible = v
        lblC2.Visible = v
        lblC3.Visible = v
        lblC4.Visible = v
        lblC5.Visible = v
        lblC6.Visible = v
        lblC7.Visible = v
        lblC8.Visible = v
        lblC9.Visible = v
        lblC10.Visible = v
    End Sub
    Public Sub lblC1Visible(Optional ByVal v As Boolean = True)
        lblC11.Visible = v
        lblC12.Visible = v
        lblC13.Visible = v
        lblC14.Visible = v
        lblC15.Visible = v
        lblC16.Visible = v
        lblC17.Visible = v
        lblSide1.Visible = v
        lblSide2.Visible = v
    End Sub
    Public Sub ShowTextBoxes(Optional ByVal v As Boolean = True)
        Panel1.Visible = v
        Panel2.Visible = v
    End Sub
    Public Sub TextBox1Visible(Optional ByVal v As Boolean = True)

        txtGain11.Visible = v
        txtGain12.Visible = v
        txtGain13.Visible = v
        txtGain14.Visible = v
        txtGain15.Visible = v
        txtGain16.Visible = v
        txtGain17.Visible = v

        txtDelay11.Visible = v
        txtDelay12.Visible = v
        txtDelay13.Visible = v
        txtDelay14.Visible = v
        txtDelay15.Visible = v
        txtDelay16.Visible = v
        txtDelay17.Visible = v

        txtRange11.Visible = v
        txtRange12.Visible = v
        txtRange13.Visible = v
        txtRange14.Visible = v
        txtRange15.Visible = v
        txtRange16.Visible = v
        txtRange17.Visible = v

        txtReject11.Visible = v
        txtReject12.Visible = v
        txtReject13.Visible = v
        txtReject14.Visible = v
        txtReject15.Visible = v
        txtReject16.Visible = v
        txtReject17.Visible = v

        txtGateS11.Visible = v
        txtGateS12.Visible = v
        txtGateS13.Visible = v
        txtGateS14.Visible = v
        txtGateS15.Visible = v
        txtGateS16.Visible = v
        txtGateS17.Visible = v

        txtGateW11.Visible = v
        txtGateW12.Visible = v
        txtGateW13.Visible = v
        txtGateW14.Visible = v
        txtGateW15.Visible = v
        txtGateW16.Visible = v
        txtGateW17.Visible = v

        txtThresh11.Visible = v
        txtThresh12.Visible = v
        txtThresh13.Visible = v
        txtThresh14.Visible = v
        txtThresh15.Visible = v
        txtThresh16.Visible = v
        txtThresh17.Visible = v

        txtG2St11.Visible = v
        txtG2St12.Visible = v
        txtG2St13.Visible = v
        txtG2St14.Visible = v
        txtG2St15.Visible = v
        txtG2St16.Visible = v
        txtG2St17.Visible = v

        txtG2Wd11.Visible = v
        txtG2Wd12.Visible = v
        txtG2Wd13.Visible = v
        txtG2Wd14.Visible = v
        txtG2Wd15.Visible = v
        txtG2Wd16.Visible = v
        txtG2Wd17.Visible = v

        txtThr211.Visible = v
        txtThr212.Visible = v
        txtThr213.Visible = v
        txtThr214.Visible = v
        txtThr215.Visible = v
        txtThr216.Visible = v
        txtThr217.Visible = v

        txtAng11.Visible = v
        txtAng12.Visible = v
        txtAng13.Visible = v
        txtAng14.Visible = v
        txtAng15.Visible = v
        txtAng16.Visible = v
        txtAng17.Visible = v

    End Sub

    Private Sub SetTextBox()  'In This Fun We Are Setting Currsor And TextBoxes

        Dim maxi As Integer
        ClearLbls()
        If caltyp = 4 Then
            lblSide1.Text = "ALL"
            lblSide1.Visible = True
            If curi = -1 Then
                lblSide1.ForeColor = Color.Red
                Exit Sub
            Else
                lblSide1.ForeColor = Color.Gray
            End If
        End If

        If caltyp <> 0 Then
            curj = 0
        End If

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
                ListBox1.Focus()
                Exit Sub
            Else
                ListBox1.SelectedIndex = curi
                Exit Sub
            End If
        Else
            ListBox1.Enabled = False
        End If
        Select Case curi                   'Label For Calib Window
            Case 0 : lbC = lblC1
            Case 1 : lbC = lblC2
            Case 2 : lbC = lblC3
            Case 3 : lbC = lblC4
            Case 4 : lbC = lblC5
            Case 5 : lbC = lblC6
            Case 6 : lbC = lblC7
            Case 7 : lbC = lblC8
            Case 8 : lbC = lblC9
            Case 9 : lbC = lblC10
        End Select
        Select Case curj                'Parameters For Label in Calib Window
            Case 0 : lbP = lblGain
            Case 1 : lbP = lblDelay
            Case 2 : lbP = lblRange
            Case 3 : lbP = lblReject
            Case 4 : lbP = lblGateS
            Case 5 : lbP = lblGateW
            Case 6 : lbP = lblThresh
            Case 7 : lbP = lblG2St
            Case 8 : lbP = lblG2Wd
            Case 9 : lbP = lblThr2
            Case 10 : lbP = lblAng
            Case TotNch + 1 : lbP = lblCalSet
        End Select
        Select Case curj
            Case 0
                Select Case curi
                    Case 0 : tb = txtGain1
                    Case 1 : tb = txtGain2
                    Case 2 : tb = txtGain3
                    Case 3 : tb = txtGain4
                    Case 4 : tb = txtGain5
                    Case 5 : tb = txtGain6
                    Case 6 : tb = txtGain7
                    Case 7 : tb = txtGain8
                    Case 8 : tb = txtGain9
                    Case 9 : tb = txtGain10
                    Case 10 : tb = txtGain11
                    Case 11 : tb = txtGain12
                    Case 12 : tb = txtGain13
                    Case 13 : tb = txtGain14
                    Case 14 : tb = txtGain15
                    Case 15 : tb = txtGain16
                    Case 16 : tb = txtGain17
                End Select
            Case 1
                Select Case curi
                    Case 0 : tb = txtDelay1
                    Case 1 : tb = txtDelay2
                    Case 2 : tb = txtDelay3
                    Case 3 : tb = txtDelay4
                    Case 4 : tb = txtDelay5
                    Case 5 : tb = txtDelay6
                    Case 6 : tb = txtDelay7
                    Case 7 : tb = txtDelay8
                    Case 8 : tb = txtDelay9
                    Case 9 : tb = txtDelay10
                    Case 10 : tb = txtDelay11
                    Case 11 : tb = txtDelay12
                    Case 12 : tb = txtDelay13
                    Case 13 : tb = txtDelay14
                    Case 14 : tb = txtDelay15
                    Case 15 : tb = txtDelay16
                    Case 16 : tb = txtDelay17
                End Select
            Case 2
                Select Case curi
                    Case 0 : tb = txtRange1
                    Case 1 : tb = txtRange2
                    Case 2 : tb = txtRange3
                    Case 3 : tb = txtRange4
                    Case 4 : tb = txtRange5
                    Case 5 : tb = txtRange6
                    Case 6 : tb = txtRange7
                    Case 7 : tb = txtRange8
                    Case 8 : tb = txtRange9
                    Case 9 : tb = txtRange10
                    Case 10 : tb = txtRange11
                    Case 11 : tb = txtRange12
                    Case 12 : tb = txtRange13
                    Case 13 : tb = txtRange14
                    Case 14 : tb = txtRange15
                    Case 15 : tb = txtRange16
                    Case 16 : tb = txtRange17
                End Select
            Case 3
                Select Case curi
                    Case 0 : tb = txtReject1
                    Case 1 : tb = txtReject2
                    Case 2 : tb = txtReject3
                    Case 3 : tb = txtReject4
                    Case 4 : tb = txtReject5
                    Case 5 : tb = txtReject6
                    Case 6 : tb = txtReject7
                    Case 7 : tb = txtReject8
                    Case 8 : tb = txtReject9
                    Case 9 : tb = txtReject10
                    Case 10 : tb = txtReject11
                    Case 11 : tb = txtReject12
                    Case 12 : tb = txtReject13
                    Case 13 : tb = txtReject14
                    Case 14 : tb = txtReject15
                    Case 15 : tb = txtReject16
                    Case 16 : tb = txtReject17
                End Select
            Case 4
                Select Case curi
                    Case 0 : tb = txtGateS1
                    Case 1 : tb = txtGateS2
                    Case 2 : tb = txtGateS3
                    Case 3 : tb = txtGateS4
                    Case 4 : tb = txtGateS5
                    Case 5 : tb = txtGateS6
                    Case 6 : tb = txtGateS7
                    Case 7 : tb = txtGateS8
                    Case 8 : tb = txtGateS9
                    Case 9 : tb = txtGateS10
                    Case 10 : tb = txtGateS11
                    Case 11 : tb = txtGateS12
                    Case 12 : tb = txtGateS13
                    Case 13 : tb = txtGateS14
                    Case 14 : tb = txtGateS15
                    Case 15 : tb = txtGateS16
                    Case 16 : tb = txtGateS17
                End Select
            Case 5
                Select Case curi
                    Case 0 : tb = txtGateW1
                    Case 1 : tb = txtGateW2
                    Case 2 : tb = txtGateW3
                    Case 3 : tb = txtGateW4
                    Case 4 : tb = txtGateW5
                    Case 5 : tb = txtGateW6
                    Case 6 : tb = txtGateW7
                    Case 7 : tb = txtGateW8
                    Case 8 : tb = txtGateW9
                    Case 9 : tb = txtGateW10
                    Case 10 : tb = txtGateW11
                    Case 11 : tb = txtGateW12
                    Case 12 : tb = txtGateW13
                    Case 13 : tb = txtGateW14
                    Case 14 : tb = txtGateW15
                    Case 15 : tb = txtGateW16
                    Case 16 : tb = txtGateW17
                End Select
            Case 6
                Select Case curi
                    Case 0 : tb = txtThresh1
                    Case 1 : tb = txtThresh2
                    Case 2 : tb = txtThresh3
                    Case 3 : tb = txtThresh4
                    Case 4 : tb = txtThresh5
                    Case 5 : tb = txtThresh6
                    Case 6 : tb = txtThresh7
                    Case 7 : tb = txtThresh8
                    Case 8 : tb = txtThresh9
                    Case 9 : tb = txtThresh10
                    Case 10 : tb = txtThresh11
                    Case 11 : tb = txtThresh12
                    Case 12 : tb = txtThresh13
                    Case 13 : tb = txtThresh14
                    Case 14 : tb = txtThresh15
                    Case 15 : tb = txtThresh16
                    Case 16 : tb = txtThresh17
                End Select
            Case 7
                Select Case curi
                    Case 0 : tb = txtG2St1
                    Case 1 : tb = txtG2St2
                    Case 2 : tb = txtG2St3
                    Case 3 : tb = txtG2St4
                    Case 4 : tb = txtG2St5
                    Case 5 : tb = txtG2St6
                    Case 6 : tb = txtG2St7
                    Case 7 : tb = txtG2St8
                    Case 8 : tb = txtG2St9
                    Case 9 : tb = txtG2St10
                    Case 10 : tb = txtG2St11
                    Case 11 : tb = txtG2St12
                    Case 12 : tb = txtG2St13
                    Case 13 : tb = txtG2St14
                    Case 14 : tb = txtG2St15
                    Case 15 : tb = txtG2St16
                    Case 16 : tb = txtG2St17
                End Select
            Case 8
                Select Case curi
                    Case 0 : tb = txtG2Wd1
                    Case 1 : tb = txtG2Wd2
                    Case 2 : tb = txtG2Wd3
                    Case 3 : tb = txtG2Wd4
                    Case 4 : tb = txtG2Wd5
                    Case 5 : tb = txtG2Wd6
                    Case 6 : tb = txtG2Wd7
                    Case 7 : tb = txtG2Wd8
                    Case 8 : tb = txtG2Wd9
                    Case 9 : tb = txtG2Wd10
                    Case 10 : tb = txtG2Wd11
                    Case 11 : tb = txtG2Wd12
                    Case 12 : tb = txtG2Wd13
                    Case 13 : tb = txtG2Wd14
                    Case 14 : tb = txtG2Wd15
                    Case 15 : tb = txtG2Wd16
                    Case 16 : tb = txtG2Wd17
                End Select
            Case 9
                Select Case curi
                    Case 0 : tb = txtThr21
                    Case 1 : tb = txtThr22
                    Case 2 : tb = txtThr23
                    Case 3 : tb = txtThr24
                    Case 4 : tb = txtThr25
                    Case 5 : tb = txtThr26
                    Case 6 : tb = txtThr27
                    Case 7 : tb = txtThr28
                    Case 8 : tb = txtThr29
                    Case 9 : tb = txtThr210
                    Case 10 : tb = txtThr211
                    Case 11 : tb = txtThr212
                    Case 12 : tb = txtThr213
                    Case 13 : tb = txtThr214
                    Case 14 : tb = txtThr215
                    Case 15 : tb = txtThr216
                    Case 16 : tb = txtThr217
                End Select
            Case 10
                Select Case curi
                    Case 0 : tb = txtAng1
                    Case 1 : tb = txtAng2
                    Case 2 : tb = txtAng3
                    Case 3 : tb = txtAng4
                    Case 4 : tb = txtAng5
                    Case 5 : tb = txtAng6
                    Case 6 : tb = txtAng7
                    Case 7 : tb = txtAng8
                    Case 8 : tb = txtAng9
                    Case 9 : tb = txtAng10
                    Case 10 : tb = txtAng11
                    Case 11 : tb = txtAng12
                    Case 12 : tb = txtAng13
                    Case 13 : tb = txtAng14
                    Case 14 : tb = txtAng15
                    Case 15 : tb = txtAng16
                    Case 16 : tb = txtAng17
                End Select
        End Select

        lbC.ForeColor = colours2(8)
        lbP.ForeColor = colours2(8)
        tb.SelectionStart = tb.Text.Length
        lblInput.Text = tb.Text
        tb.Focus()
    End Sub
    Private Sub LblsVisible(Optional ByVal v1 As Boolean = True, Optional ByVal v2 As Boolean = True, Optional ByVal v3 As Boolean = True)
        lblC1.Visible = v1 : lblC2.Visible = v1 : lblC3.Visible = v1 : lblC4.Visible = v1
        lblC5.Visible = v1 : lblC6.Visible = v1 : lblC7.Visible = v1 : lblC8.Visible = v1
        lblC9.Visible = v1 : lblC10.Visible = v1

        If TotNch <= 5 Then lblC7.Visible = False
        If TotNch <= 9 Then v1 = False
        lblC11.Visible = v1 : lblC12.Visible = v1 : lblC13.Visible = v1 : lblC14.Visible = v1
        lblC15.Visible = v1 : lblC16.Visible = v1 : lblC17.Visible = v1
        lblSide1.Visible = v1 : lblSide2.Visible = v1

        lblGain.Visible = v2 : lblDelay.Visible = v2 : lblRange.Visible = v2
        lblReject.Visible = v2 : lblGateS.Visible = v2 : lblGateW.Visible = v2
        lblThresh.Visible = v2 : lblG2St.Visible = v2 : lblG2Wd.Visible = v2
        lblAng.Visible = v2
        lblThr2.Visible = v2
        lblCalSet.Visible = v2
        lblInput.Visible = v2
        Me.lblMenu1.Visible = v3
        Me.lblMenu2.Visible = v3
        Me.lblMenu3.Visible = v3
        Me.lblMenu4.Visible = v3
        Me.lblMenu5.Visible = v3
        Me.lblMenu6.Visible = v3
        Me.lblMenu7.Visible = v3
        Me.lblMenu8.Visible = v3
        Application.DoEvents()

    End Sub

    Private Sub displayLabel()
        lblMenu1.Visible = True
        lblMenu2.Visible = True
        lblMenu3.Visible = True
        lblMenu4.Visible = True
        lblMenu5.Visible = True
        lblMenu7.Visible = True
    End Sub

    Private Sub SaveJPG()

        ' The Function Is Designed For Save The Calibration Table as the JPG image format using (BitBlt) library Function
        ' Library is Loaded From the Module.vb file
        ' the Function is having the Return Values as the Variable name (DateStr) & (formatDate)

        lblMenu1.Visible = False
        lblMenu2.Visible = False
        lblMenu3.Visible = False
        lblMenu4.Visible = False
        lblMenu5.Visible = False
        lblMenu7.Visible = False

        Dim dirpath As String
        Dim DateStr As String = getDateFormat()
        Dim formatDate As String = getDateFormated()


        Dim bmp As New Bitmap(Panel2.Width, Panel2.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            Dim panelDC As IntPtr = GetDC(Panel2.Handle)
            BitBlt(g.GetHdc(), 0, 0, Panel2.Width, Panel2.Height, panelDC, 0, 0, 13369376)
            g.ReleaseHdc(IntPtr.Zero)
            ReleaseDC(Panel2.Handle, panelDC)


            ' Define a font and brush for the text
            Dim font As New Font("Arial", 18, FontStyle.Bold) ' You can change the font and size
            Dim brush As New SolidBrush(Color.Black) ' You can change the text color

            ' Draw the text on the graphics
            g.DrawString(MCNO.ToString.Trim, font, brush, 16, 660)
            g.DrawString(DateTime.Now.ToString.Trim, font, brush, 240, 660)

            ' Dispose of the font and brush when done
            font.Dispose()
            brush.Dispose()

        End Using

        Dim path As String = StorageCard & "PARASRT\" & MCNO.ToString.Trim & "\" & DateStr & "Calib\"
        If Not Directory.Exists(path) Then ' If Directory is not available then create the Directory
            Directory.CreateDirectory(path)
            dirpath = path & "Calset" & ListBox1.SelectedItem.ToString & ".jpg" 'File name for JPG
        Else ' IF directory is Available the File name of the JPG will be created in the Specified Path using the Graphics Library
            dirpath = path & "Calset" & ListBox1.SelectedItem.ToString & ".jpg" 'File name for JPG
        End If

        ' Save the captured image as a JPEG
        bmp.Save(dirpath, ImageFormat.Jpeg)

        ' Dispose of the Bitmap
        bmp.Dispose()

    End Sub

    Private Sub ClearLbls() 'SRT Variables

        lblC1.ForeColor = colours(0)
        lblC2.ForeColor = colours(0) : lblC3.ForeColor = colours(0) : lblC4.ForeColor = colours(0)
        lblC5.ForeColor = colours(0) : lblC6.ForeColor = colours(0) : lblC7.ForeColor = colours(0) : lblC8.ForeColor = colours(0) : lblC9.ForeColor = colours(0) : lblC10.ForeColor = colours(0)
        lblGain.ForeColor = colours(0) : lblDelay.ForeColor = colours(0) : lblRange.ForeColor = colours(0)
        lblReject.ForeColor = colours(0) : lblGateS.ForeColor = colours(0) : lblGateW.ForeColor = colours(0)
        lblThresh.ForeColor = colours(0) : lblG2St.ForeColor = colours(0) : lblG2Wd.ForeColor = colours(0)
        lblThr2.ForeColor = colours(0) : lblAng.ForeColor = colours(0)
        lblCalSet.ForeColor = colours(0)

        If TotNch > 9 Then 'Changed
            lblC11.ForeColor = colours(7)
            lblC12.ForeColor = colours(7) : lblC13.ForeColor = colours(7) : lblC14.ForeColor = colours(7)
            lblC15.ForeColor = colours(7) : lblC16.ForeColor = colours(7) : lblC17.ForeColor = colours(7)
        End If

    End Sub

    Private Sub frmCalib_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim k As Integer, i As Integer
        k = e.KeyCode
        If (k = KeyDeci1) Then k = KeyDeci
        If ((k >= 48 And k <= 57) Or k = 8 Or k = KeyDeci) Then isValidIn = True : e.Handled = False : Exit Sub

        If frm3StopProcessing = True Then
            Exit Sub
        End If

        If k = 103 Then
            Me.Text = frmcap
            bEsc = True
        Else
            bEsc = False
        End If

        If Not isloaded Or keyprocessing Or IsKeyDown Then isValidIn = False : e.Handled = True : Exit Sub
        IsKeyDown = True
        keyprocessing = True
        isValidIn = False
        e.Handled = True
        Dim cap As String = Me.Text
        Select Case mnu
            Case 20
                Select Case k

                    Case MKey1

                        cnfnam = ListBox1.Items(ListBox1.SelectedIndex)
                        cnfnam = AppPath & "\" & cnfnam & ".cnf"
                        cnfi = ListBox1.SelectedIndex
                        OpenConfig()
                        curi = 0 : curj = 0
                        DispVals()
                        SetTextBox()
                        Application.DoEvents()

                    Case MKey2, FKeySave
                        Me.Text = cap & " - Saving"
                        SaveJPG()
                        displayLabel()
                        StoreVals()
                        SaveConfig()
                        Me.Text = cap

                    Case MKey3
                        Me.Text = cap & " - Saving"
                        AddNewFileName()
                        i = Val(ListBox1.SelectedItem.ToString)
                        SortList(ListBox1, True)
                        ListBox1.SelectedIndex = i - 1
                        cnfnam = ListBox1.Items(ListBox1.SelectedIndex)
                        cnfnam = AppPath & "\" & cnfnam & ".cnf"
                        StoreVals()
                        SaveConfig()
                        Me.Text = cap

                    Case MKey4
                        Me.Text = cap & " - Deleting"
                        cnfnam = ListBox1.Items(ListBox1.SelectedIndex)
                        cnfnam = AppPath & "\" & cnfnam & ".cnf"
                        DelConfig()
                        Add2CnfList()
                        Me.Text = cap

                    Case MKey5
                        ShowTextBoxes(False)
                        Application.DoEvents()
                        keyprocessing = True
                        EditConfig()
                        SaveGain()
                        Acquire(curi)

                    Case MKey6
                        StoreVals()
                        ShowTextBoxes(False)
                        Application.DoEvents()
                        keyprocessing = True
                        ViewGraph()
                        SaveGain() 'Check
                        Acquire(curi)

                    Case MKey7
                        Me.Close()

                    Case FkeyLf
                        curj = curj - 1
                        SetTextBox()

                    Case FkeyRt
                        curj = curj + 1
                        SetTextBox()

                    Case FKeyUp
                        curi = curi - 1
                        SetTextBox()

                    Case FKeyDn
                        curi = curi + 1
                        SetTextBox()

                    Case FKeyPlus

                        If curj <= TotNpr Then
                            curj = TotNpr + 1
                        Else
                            curj = 0
                        End If
                        SetTextBox()

                    Case FKeyMinus, FKeyLR

                        If curi <= 9 Then
                            curi = curi + 10
                        Else
                            curi = curi - 10
                        End If
                        SetTextBox()

                    Case EsKey
                        Me.Text = frmcap

                End Select
            Case 25
                DoEditMenu(k)
        End Select
        PauseIt(1)
        keyprocessing = False
    End Sub

    Private Sub frmCalib_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If Not isValidIn Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmCalib_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        IsKeyDown = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If isstopped Then
            Timer1.Enabled = False
            '            If caltyp = 4 Then Exit Sub
            DoEditMenu(lastkey)
            If lastkey <> EsKey And lastkey <> FKeySave And lastkey <> FKeyLR Then
                DoEditMenu(FKeyRun)
                Application.DoEvents()
            End If
        End If
    End Sub

    Private Sub frmCalib_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        If caltyp = 15 Then
            objGraphicsFrm.DrawImage(bmpview, 0, 0)
            bmpview.Dispose()
            Exit Sub
        End If

        If caltyp = 2 And isRefresh = True Then
            AcquireFreezeDrawGrid(curi)
        End If

        Dim rect As Rectangle
        Dim attr As New Drawing.Imaging.ImageAttributes
        If caltyp = 1 Then
            'rect = New Rectangle(20, meheight - 30, mewidth - 80, -meheight + 50)
            rect = New Rectangle(50, meheight - 30, mewidth - 110, -meheight + 50)
            objGraphicsFrm.DrawImage(bmp, 0, 0)
        ElseIf caltyp = 3 Or caltyp = 5 Then
            'rect = New Rectangle(20, meheight - 30, mewidth - 80, -meheight + 50)
            rect = New Rectangle(50, meheight - 30, mewidth - 110, -meheight + 50)
            objGraphicsFrm.DrawImage(bmp, 0, 0)
        End If
    End Sub
    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not isValidIn Or mnu <> 20 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fnSaveCalibJPG()

        Dim bmp As New Bitmap(Me.Width, Me.Height)
        Using gr As Graphics = Graphics.FromImage(bmp)
            Dim panelDC As IntPtr = GetDC(Me.Handle)
            BitBlt(gr.GetHdc(), 0, 0, Me.Width, Me.Height, panelDC, 0, 0, 13369376)
            gr.ReleaseHdc(IntPtr.Zero)
            ReleaseDC(Me.Handle, panelDC)

            Try
                Me.FormBorderStyle = Forms.FormBorderStyle.FixedSingle

                Dim strCalibValues As String = ""
                Dim channelno As String = ""
                Dim gain As String = ""
                Dim delay As String = ""
                Dim range As String = ""
                Dim reject As String = ""
                Dim ang As Single

                If curi = 9 Then
                    channelno = (curi + 1).ToString()
                Else
                    channelno = "0" & (curi + 1).ToString()
                End If

                If curi = 9 Then ' 10th channel

                    'Gain
                    Dim DataArrCh10(TotNch, TotNpr) As Integer
                    Dim Configfile As String = ""
                    Dim configData As String = ""
                    Configfile = "\SD Card\config10.txt"

                    Dim configReader As StreamReader = New StreamReader(Configfile)

                    For q = 1 To Convert.ToInt32(ListBox1.Items(ListBox1.SelectedIndex).ToString())
                        configData = configReader.ReadLine
                    Next

                    Dim st1() As String = Split(configData, ",")

                    For g = 0 To DataArrCh10.GetUpperBound(1)
                        DataArrCh10(0, g) = st1(g)
                    Next

                    Dim gainfile As String = ""
                    Dim gainData As String = ""
                    Dim strGain10cch As String = ""
                    gainfile = "\SD Card\gaindata" & ListBox1.Items(ListBox1.SelectedIndex).ToString() & ".txt"

                    Dim gainReader As StreamReader = New StreamReader(gainfile)

                    For z = 0 To 10
                        gainData = gainReader.ReadLine
                    Next

                    Dim gndt() As String = Split(gainData, ",")
                    strGain10cch = gndt(1)

                    gain = Format(strGain10cch / 2.0, "0.0")

                    'Delay
                    delay = Format((DataArrCh10(0, 2) * 0.2941), "0")

                    'range
                    Dim intRange As Integer
                    Dim strWav As String = ""
                    Dim anglefile As String = ""
                    Dim angleData As String = ""
                    Dim strangle10cch As String = ""

                    anglefile = "\SD Card\angdata10.txt"

                    Dim angleReader As StreamReader = New StreamReader(anglefile)

                    For q = 1 To Convert.ToInt32(ListBox1.Items(ListBox1.SelectedIndex).ToString())
                        angleData = angleReader.ReadLine
                    Next

                    Dim angledt() As String = Split(angleData, ",")
                    strangle10cch = angledt(1)

                    ang = (Convert.ToInt32(strangle10cch) \ 256) / 10

                    If ang = 0 Then
                        strWav = "1"
                    ElseIf ang > 30 Then
                        strWav = "2"
                    End If

                    If strWav = "1" Then
                        intRange = Format(DataArrCh10(0, 1) * ml2mm1, "0")
                    ElseIf strWav = "2" Then
                        intRange = Format(DataArrCh10(0, 1) * ml2mm2, "0")
                    End If

                    range = intRange

                    'reject
                    reject = Format(CSng(DataArrCh10(0, 3)) / ymaxS, "#0")

                    'MessageBox.Show(ang, "ang10")

                    If Convert.ToInt32(st2) > 0 Then
                        BPval = Convert.ToInt32(st2)
                        If BPval <= 0 Then
                            BPval = 0
                        Else
                            If ang = 0 Then
                                BPval = Convert.ToInt32(st2) - 2
                            Else
                                BPval = Convert.ToInt32(st2)
                            End If
                        End If
                    End If
                Else ' 1 to 9 channel
                    'gain
                    If curi = 7 Then
                        gain = Format(DataArr(8, 0) / 2.0, "0.0")
                    Else
                        gain = Format(DataArr(curi, 0) / 2.0, "0.0")
                    End If

                    'Delay
                    delay = Format((DataArr(curi, 1) * 0.2941), "0")

                    'Range
                    range = Format(Rangemm(DataArr(curi, 2), curi), "0")

                    'Reject
                    Dim reject_eff As Integer
                    reject_eff = Format(CSng(DataArr(curi, 3)) / ymaxS, "#0")

                    reject = Format(reject_eff, "0")

                    'Angle
                    ang = (Convert.ToInt32(DataArr(curi, 10) \ 256) / 10)

                    If Convert.ToInt32(st2) > 0 Then
                        BPval = Convert.ToInt32(st2)
                        If BPval <= 0 Then
                            BPval = 0
                        Else
                            If ang = 0 Then
                                BPval = Convert.ToInt32(st2) - 2
                            Else
                                BPval = Convert.ToInt32(st2)
                            End If
                        End If
                    End If
                End If

                If ang = 0 Then
                    If Convert.ToInt32(st1) > 100 Then
                        st1 = "100"
                        If BPval < 0 Then
                            BPval = 0
                            strCalibValues = "  [" & "PH=" & st1 & "," & "BP=" & BPval & "," & " " & "D=" & BPval & "," & "SD=" & st4 & "]"
                        Else
                            strCalibValues = "  [" & "PH=" & st1 & "," & "BP=" & BPval & "," & " " & "D=" & BPval & "," & "SD=" & st4 & "]"
                        End If
                    Else
                        If BPval < 0 Then
                            BPval = 0
                            If Convert.ToInt32(st1) = 0 Then
                                strCalibValues = "  [" & "PH=" & st1 & "," & "BP=" & BPval & "," & " " & "D=" & BPval & "," & "SD=" & st4 & "]"
                            ElseIf Convert.ToInt32(st1) < 30 Then
                                strCalibValues = "  [" & "PH=" & Convert.ToInt32(st1) + 1 & "," & "BP=" & BPval & "," & " " & "D=" & BPval & "," & "SD=" & st4 & "]"
                            Else
                                strCalibValues = "  [" & "PH=" & st1 & "," & "BP=" & BPval & "," & " " & "D=" & BPval & "," & "SD=" & st4 & "]"
                            End If
                        Else
                            If Convert.ToInt32(st1) = 0 Then
                                strCalibValues = "  [" & "PH=" & st1 & "," & "BP=" & BPval & "," & " " & "D=" & BPval & "," & "SD=" & st4 & "]"
                            ElseIf Convert.ToInt32(st1) < 30 Then
                                strCalibValues = "  [" & "PH=" & Convert.ToInt32(st1) + 1 & "," & "BP=" & BPval & "," & " " & "D=" & BPval & "," & "SD=" & st4 & "]"
                            Else
                                strCalibValues = "  [" & "PH=" & st1 & "," & "BP=" & BPval & "," & " " & "D=" & BPval & "," & "SD=" & st4 & "]"
                            End If
                        End If
                    End If
                Else
                    If Convert.ToInt32(st1) > 100 Then
                        st1 = "100"
                        strCalibValues = "[PH=" & st1 & ", BP=" & BPval & ", D=" & st3 & ", SD=" & st4 & "]"
                    Else
                        If Convert.ToInt32(st1) = 0 Then
                            strCalibValues = "  [" & "PH=" & st1 & "," & "BP=" & BPval & "," & " " & "D=" & st3 & "," & "SD=" & st4 & "]"
                        ElseIf Convert.ToInt32(st1) < 30 Then
                            strCalibValues = "  [" & "PH=" & Convert.ToInt32(st1) + 1 & "," & "BP=" & BPval & "," & " " & "D=" & st3 & "," & "SD=" & st4 & "]"
                        Else
                            strCalibValues = "  [" & "PH=" & st1 & "," & "BP=" & BPval & "," & " " & "D=" & st3 & "," & "SD=" & st4 & "]"
                        End If
                    End If
                End If

                'Date Printing
                gr.DrawString(DateTime.Now.ToString("dd-MM-yyyy"), objfontcalib, objBrush3, 130, 32)
                gr.DrawString(MCNO, objfontcalib, objBrush3, 130, 64)

                'Calib Aquiring Print
                gr.DrawString(strCalibValues, objfontcalib, objBrush3, 258, 32)

                'Channel No, Gain, Delay, Range, Reject values print

                If curi = 0 Then
                    channelno = "01"
                ElseIf curi = 1 Then
                    channelno = "02 CF"
                ElseIf curi = 2 Then
                    channelno = "03 CB"
                ElseIf curi = 3 Then
                    channelno = "04 CF"
                ElseIf curi = 4 Then
                    channelno = "05 CB"
                ElseIf curi = 5 Then
                    channelno = "06 GFF"
                ElseIf curi = 6 Then
                    channelno = "07 GFB"
                ElseIf curi = 7 Then
                    channelno = "08 NGF"
                ElseIf curi = 8 Then
                    channelno = "09 NGB"
                ElseIf curi = 9 Then
                    channelno = "10"
                End If

                gr.DrawString("CH   : " & channelno, objfontcalib, objBrush3, 770, 48)
                gr.DrawString("Gain : " & gain, objfontcalib, objBrush3, 770, 80)
                gr.DrawString("Dely : " & delay, objfontcalib, objBrush3, 770, 112)
                gr.DrawString("Rng  : " & range, objfontcalib, objBrush3, 770, 144)
                gr.DrawString("RJ    : " & reject, objfontcalib, objBrush3, 770, 176)
                gr.DrawString("Ang  : " & ang, objfontcalib, objBrush3, 770, 208)


                Dim objSR As StreamReader = New StreamReader("\SD Card\kminfo.txt")
                Dim objst As String() = objSR.ReadLine().ToString.Trim.Split(",")
                Dim strDateFolder As String = ""

                If objst.Length > 4 Then
                    strDateFolder = DateTime.Now.ToString("yyyyMMdd") & objst(4)
                End If

                Dim strDate As String = getDateFormat()
                Dim strjpgfolderpath As String = StorageCard & "PARASRT\" & MCNO & "\" & strDate & "Calib\"
                If Not Directory.Exists(strjpgfolderpath) Then
                    Directory.CreateDirectory(strjpgfolderpath)
                End If

                Dim strFilePath As String = strjpgfolderpath & "\" & curi + 1 & "_" & DateTime.Now.ToString("yyyyMMdd_hh_mm_ss") & ".jpg"
                bmp.Save(strFilePath, System.Drawing.Imaging.ImageFormat.Jpeg)

            Catch ex As Exception

            End Try
        End Using
    End Sub
End Class