Imports System.IO
Imports System
Imports System.Windows
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports System.Threading
Public Class frmTest
#Const TORA = 1
    Dim ctl As Object
    Dim curj As Integer
    Dim isValidIn As Boolean
    Dim isLoaded As Boolean
    Dim pstarted As Boolean
    Dim p As Process
    Public isTextInfo As Boolean
    Dim fllist As String
    Dim uped As Integer = 0
    Dim pt0() As Point, pt1() As Point
    Dim temp_jpg As String

    'while saving prv and prs jpg will create 
    Private Sub prv_jpg()
        Try
            If jpgflag = True Then
                datafile = AppDataPath & "\" & temp_jpg
                Dim st As String = Microsoft.VisualBasic.Right(datafile, 10)

                If Microsoft.VisualBasic.Left(st, 1) = "_" Then
                    frmCalib.curi = Val(Mid(st, 2))
                    frmCalib.ShowDialog()
                Else
                    frmCalib.curi = 0
                End If

                If InStr(temp_jpg, ".prs") Then
                    caltyp = 1
                    frmCalib.ShowDialog()
                ElseIf InStr(temp_jpg, ".prv") Then
                    caltyp = 3
                    frmCalib.ShowDialog()
                ElseIf InStr(temp_jpg, ".jpg") Then
                    frmCalib.ShowDialog()
                    Exit Sub
                End If
                Application.DoEvents()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub DivisionParameter()
        Try
            If File.Exists(Divdetails) Then File.Delete(Divdetails)
            Dim sw As StreamWriter = New StreamWriter(Divdetails)

            sw.WriteLine(Me.txtSec.Text & "," & Me.cmbRoad.Text & "," & Me.cmbRail.Text & "," & Me.txtName.Text & "," & Me.txtMCNO.Text & "," & Me.txtDiv.Text & ",")
            sw.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub current_kmupdate()
        Try
            Dim mstr() As String
            Dim mstrl As String
            Dim mst() As String
            Dim mstl As String
            Dim dir() As String
            Dim dir1 As String
            Dim KmVal1 As String
            Dim kmVal() As String
            Dim kmvalupdate As String


            Dim objSR As StreamReader = New StreamReader("\SD Card\kminfo.txt")
            Dim objSR1 As StreamReader = New StreamReader("\SD Card\ViewKM.txt")
            Dim objSR2 As StreamReader = New StreamReader(Divdetails)
            Dim ObjSR3 As StreamReader = New StreamReader("\SD Card\distance.txt")

            KmVal1 = ObjSR3.ReadLine()
            kmVal = KmVal1.Split(",")

            kmvalupdate = kmVal(0)

            dir1 = objSR2.ReadLine()
            dir = dir1.Split(",")

            mstrl = objSR.ReadLine
            mstr = mstrl.Split(",")
            Dim mstr_dec As Decimal
            mstr_dec = Decimal.Parse(mstr(1))

            'KM Value Updated Here.
            mstl = objSR1.ReadLine
            mst = mstl.Split(",")
            txtcm.Text = Format(mstr_dec.ToString("N2") + 0, "0000.00")
            txtckm.Text = mst(1)

            objSR.Close()
            objSR1.Close()
            objSR2.Close()
            ObjSR3.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RecordType()
        Dim objSW As New StreamWriter(StorageCard & "\RecordType.txt")
        Dim selectedText As String = cmbRecord.SelectedItem.ToString.Trim
        If selectedText <> "" Then
            If selectedText = "Log1" Then
                objSW.Write("Limited")
            Else
                objSW.Write("Full")
            End If
        End If
        objSW.Close()
    End Sub

    Private Sub ReadRecordType()
        Dim objSR As New StreamReader(StorageCard & "\RecordType.txt")
        Dim RecordValue As String = objSR.ReadLine()
        If RecordValue = "Limited" Then
            cmbRecord.Text = "Log1"
        Else
            cmbRecord.Text = "Log2"
        End If
    End Sub

    Private Sub frmTest_UpdateEnd(ByVal strType As String)

        Try
            Dim objSR As StreamReader = New StreamReader("\SD Card\VBmeterValue.txt") 'multi channel value
            mstrl = objSR.ReadLine
            mstr = mstrl.Split(",")

            Dim loc As Decimal
            Dim meter2 As Decimal
            Dim pstr1 As String
            Dim pstr() As String
            Dim decVal As Double
            Dim currmeter1 As String
            Dim currmeter() As String

            Dim objSR2 As StreamReader = New StreamReader("\SD Card\distance.txt") 'single channel value
            currmeter1 = objSR2.ReadLine
            currmeter = currmeter1.Split(",")
            decVal = currmeter(1)
            Me.txtcm.Text = Format(Math.Round(decVal, 2).ToString("N2") + 0, "0000.00")

            Dim mstr_dec As Decimal
            mstr_dec = Decimal.Parse(mstr(1))
            Me.txtKM2.Text = mstr(0)
            meter2 = mstr(1)

            If (strType <> "FKeySave") Then
                Me.txtMeter2.Text = Format(Math.Round(decVal, 2), "0000.00")
            End If

            Me.txtLoc3.Text = mstr_dec.ToString("N2")
            Me.txtckm.Text = mstr(0)
            Me.txtcm.Text = Format(mstr_dec.ToString("N2") + 0, "0000.00")
            objSR.Close()

            Dim ch_str As String
            ch_str = mstr(3).ToString()

            Dim dec_mstr As Decimal = Decimal.Parse(mstr_dec.ToString("N2"))

            Dim objSR1 As StreamReader = New StreamReader("\SD Card\probedetails.txt")

            pstr1 = objSR1.ReadLine
            pstr = pstr1.Split(",")

            If mstr(2).ToString.Trim.ToUpper() = "F" Then
                txtLoc2.Text = Format(Convert.ToInt32(mstr(0)), "0000") & "-" & Format(Convert.ToInt32((mstr(0) + 1)), "0000")
            ElseIf mstr(2).ToString.Trim.ToUpper() = "R" Then
                txtLoc2.Text = Format(Convert.ToInt32((mstr(0) + 1)), "0000") & "-" & Format(Convert.ToInt32(mstr(0)), "0000")
            End If

            Dim dbl_prb_ch2 As Decimal = 0
            Dim dbl_prb_ch3 As Double = 0
            Dim dbl_prb_ch4 As Double = 0
            Dim dbl_prb_ch5 As Double = 0
            Dim dbl_prb_ch6 As Double = 0
            Dim dbl_prb_ch7 As Double = 0
            Dim dbl_prb_ch8 As Double = 0
            Dim dbl_prb_ch9 As Double = 0

            If pstr.Length >= 9 Then
                dbl_prb_ch2 = Convert.ToInt32(pstr(0)) / 1000
                dbl_prb_ch3 = Convert.ToInt32(pstr(1)) / 1000
                dbl_prb_ch4 = Convert.ToInt32(pstr(2)) / 1000
                dbl_prb_ch5 = Convert.ToInt32(pstr(3)) / 1000
                dbl_prb_ch6 = Convert.ToInt32(pstr(4)) / 1000
                dbl_prb_ch7 = Convert.ToInt32(pstr(5)) / 1000
                dbl_prb_ch8 = Convert.ToInt32(pstr(6)) / 1000
                dbl_prb_ch9 = Convert.ToInt32(pstr(7)) / 1000

                If mstr(2).ToString.Trim.ToUpper() = "F" Then
                    If ch_str.ToString.Trim = "1" Then
                        Me.txtLoc3.Text = Math.Round(dec_mstr, 2)
                    ElseIf ch_str.ToString.Trim = "2" Then
                        Me.txtLoc3.Text = Math.Round(dec_mstr - dbl_prb_ch2, 2)
                    ElseIf ch_str.ToString.Trim = "3" Then
                        Me.txtLoc3.Text = Math.Round(dec_mstr - dbl_prb_ch3, 2)
                    ElseIf ch_str.ToString.Trim = "4" Then
                        Me.txtLoc3.Text = Math.Round(dec_mstr - dbl_prb_ch4, 2)
                    ElseIf ch_str.ToString.Trim = "5" Then
                        Me.txtLoc3.Text = Math.Round(dec_mstr - dbl_prb_ch5, 2)
                    ElseIf ch_str.ToString.Trim = "6" Then
                        Me.txtLoc3.Text = Math.Round(dec_mstr - dbl_prb_ch6, 2)
                    ElseIf ch_str.ToString.Trim = "7" Then
                        Me.txtLoc3.Text = Math.Round(dec_mstr - dbl_prb_ch7, 2)
                    ElseIf ch_str.ToString.Trim = "8" Then
                        Me.txtLoc3.Text = Math.Round(dec_mstr - dbl_prb_ch8, 2)
                    ElseIf ch_str.ToString.Trim = "9" Then
                        Me.txtLoc3.Text = Math.Round(dec_mstr - dbl_prb_ch9, 2)
                    End If
                ElseIf mstr(2).ToString.Trim.ToUpper() = "R" Then
                    If ch_str.ToString.Trim = "1" Then
                        Me.txtLoc3.Text = Math.Round(dec_mstr, 2)
                    ElseIf ch_str.ToString.Trim = "2" Then
                        Me.txtLoc3.Text = Math.Round(dec_mstr + dbl_prb_ch2, 2)
                    ElseIf ch_str.ToString.Trim = "3" Then
                        Me.txtLoc3.Text = Math.Round(dec_mstr + dbl_prb_ch3, 2)
                    ElseIf ch_str.ToString.Trim = "4" Then
                        Me.txtLoc3.Text = Math.Round(dec_mstr + dbl_prb_ch4, 2)
                    ElseIf ch_str.ToString.Trim = "5" Then
                        Me.txtLoc3.Text = Math.Round(dec_mstr + dbl_prb_ch5, 2)
                    ElseIf ch_str.ToString.Trim = "6" Then
                        Me.txtLoc3.Text = Math.Round(dec_mstr + dbl_prb_ch6, 2)
                    ElseIf ch_str.ToString.Trim = "7" Then
                        Me.txtLoc3.Text = Math.Round(dec_mstr + dbl_prb_ch7, 2)
                    ElseIf ch_str.ToString.Trim = "8" Then
                        Me.txtLoc3.Text = Math.Round(dec_mstr + dbl_prb_ch8, 2)
                    ElseIf ch_str.ToString.Trim = "9" Then
                        Me.txtLoc3.Text = Math.Round(dec_mstr + dbl_prb_ch9, 2)
                    End If
                End If
                Me.txtckm.Text = mstr(0)
                loc = mstr(1)
                txtLoc3.Text = Math.Round(loc, 2)
                objSR.Close()
                objSR1.Close()
                objSR2.Close()
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message(), "frmTest_UpdateEnd()")
        End Try
    End Sub

    Private Sub Defaultvalues()
        Try
            If txtKm.Text.ToString().Trim() = "" And txtM.Text.ToString().Trim() = "" And txtTP.Text.ToString().Trim() = "" And txtckm.Text.ToString().Trim() = "" And txtM.Text.ToString().Trim() = "" Then
                txtKm.Text = "0"
                txtM.Text = "0"
                txtTP.Text = "0"
                txtckm.Text = "0"
                txtcm.Text = "0000.00"

            ElseIf txtKm.Text.ToString().Trim() = "" And txtM.Text.ToString().Trim() = "" And txtTP.Text.ToString().Trim() = "" And txtckm.Text.ToString().Trim() = "" Then
                txtKm.Text = "0"
                txtM.Text = "0"
                txtTP.Text = "0"
                txtckm.Text = "0"

            ElseIf txtKm.Text.ToString().Trim() = "" And txtM.Text.ToString().Trim() = "" And txtTP.Text.ToString().Trim() = "" Then
                txtKm.Text = "0"
                txtM.Text = "0"
                txtTP.Text = "0"
            ElseIf txtKm.Text.ToString().Trim() = "" And txtM.Text.ToString().Trim() = "" Then
                txtKm.Text = "0"
                txtM.Text = "0"

            ElseIf txtM.Text.ToString().Trim() = "" And txtTP.Text.ToString().Trim() = "" Then
                txtM.Text = "0"
                txtTP.Text = "0"
            ElseIf txtTP.Text.ToString().Trim() = "" And txtckm.Text.ToString().Trim() = "" Then
                txtTP.Text = "0"
                txtckm.Text = "0"
            ElseIf txtckm.Text.ToString().Trim() = "" And txtcm.Text.ToString().Trim() = "" Then
                txtckm.Text = "0"
                txtcm.Text = "0000.00"
            ElseIf txtKm.Text.ToString().Trim() = "" And txtckm.Text.ToString().Trim() = "" Then
                txtKm.Text = "0"
                txtckm.Text = "0"
            ElseIf txtKm.Text.ToString().Trim() = "" And txtcm.Text.ToString().Trim() = "" Then
                txtKm.Text = "0"
                txtcm.Text = "0000.00"
            ElseIf txtckm.Text.ToString().Trim() = "" And txtM.Text.ToString().Trim() = "" Then
                txtckm.Text = "0"
                txtM.Text = "0"
            ElseIf txtKm.Text.ToString().Trim() = "" And txtTP.Text.ToString().Trim() = "" Then
                txtKm.Text = "0"
                txtTP.Text = "0"
            ElseIf txtTP.Text.ToString().Trim() = "" And txtcm.Text.ToString().Trim() = "" Then
                txtTP.Text = "0"
                txtcm.Text = "0000.00"
            Else
                If txtKm.Text.ToString().Trim() = "" Then
                    txtKm.Text = "0"
                    Exit Sub
                End If
                If txtM.Text.ToString().Trim() = "" Then
                    txtM.Text = "0"
                    Exit Sub
                End If
                If txtTP.Text.ToString().Trim() = "" Then
                    txtTP.Text = "0"
                    Exit Sub
                End If

                If txtckm.Text.ToString().Trim() = "" Then
                    txtckm.Text = "0"
                    Exit Sub
                End If
                If txtcm.Text.ToString().Trim() = "" Then
                    txtcm.Text = "0000.00"
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message(), "DefaultValues()")
        End Try
    End Sub

    Private Sub frmTest_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Try
            Dim GpsLocation As New clsGpsLocation
            Dim Latitude As Double, Longitude As Double
            Dim lat_dir As String, lon_dir As String
            Dim StrLatitude As String
            Dim StrLongitude As String

            GpsLocation.GetPos(Latitude, Longitude, lat_dir, lon_dir)
            StrLatitude = GpsLocation.ToDMS(Latitude)
            StrLongitude = GpsLocation.ToDMS(Longitude)
            txtLatitude.Text = (StrLatitude & " " & lat_dir)
            txtLongtitude.Text = (StrLongitude & " " & lon_dir)

        Catch ex As Exception
            'MessageBox.Show(ex.Message(), "frmTest_Activated()")
        End Try

    End Sub

    ' Handle Exited event and display process information.
    Private Sub frmTest_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Dim k As Integer, j As Integer
            k = e.KeyCode
            If (Not IsFuncKey(k)) And (Not IsLfRt(k)) And (Not IsUpDn(k)) Then isValidIn = True : e.Handled = False : Exit Sub
            If Not isLoaded Or keyprocessing Or IsKeyDown Then isValidIn = False : e.Handled = True : Exit Sub
            IsKeyDown = True
            keyprocessing = True
            isValidIn = False
            e.Handled = True
            uped = 0
            If TotNch <= 5 Then
                If k = MKey1 Then
                    k = MKey3
                ElseIf k = MKey3 Then
                    k = MKey1
                End If
            End If
            Select Case k
                Case MKey1
                    Defaultvalues()
                    setProbes()
                    curj = 0
                    SetTextBox()

                    If pstarted Then
                        p.Close()
                        pstarted = False
                        PauseIt(1)
                        'From C Side selection for Calset
                        Dim objSR3 As StreamReader = New StreamReader(Calset)
                        Dim pstr() As String
                        Dim pstr1 As String
                        Dim calsetnum As Integer
                        pstr1 = objSR3.ReadLine
                        pstr = pstr1.Split(",")
                        calsetnum = pstr(1)
                        cmbSets.SelectedValue = calsetnum
                        objSR3.Close()
                    End If

                    Me.Text = "Launching Test Application"
                    subrange1 = cmbRange1.Text
                    subrange2 = cmbRange2.Text
                    If subrange2 < (subrange1 + 20) Then subrange2 = subrange1 + 20
                    SetParams(subrange1, subrange2, False)          'set true to scale range
                    lblEndKm.Visible = False
                    txtEndKm.Visible = False
                    lblendm.Visible = False
                    txtEndMeter.Visible = False
                    Lblendtp.Visible = False
                    txtendTP.Visible = False
                    lblTotKm.Visible = False
                    txtTotKm.Visible = False
                    DelOrgPRS()
                    CreateRunFolder()
                    Panel1.Visible = False

                    SendGainSet()

#If DEBUG2 Then
                 Defaultvalues()

                caltyp = 14
                RunSelfTest()
                Me.Text = "Test Setup"
                keyprocessing = False
                IsKeyDown = False
#Else
                    Defaultvalues()
                    pstarted = True
                    p = New Process
                    p.StartInfo.FileName = test
                    p.Start()
                    p.WaitForExit()
                    p.Close()
                    'From C Side selection for Calset
                    Dim objSR As StreamReader = New StreamReader(Calset)
                    Dim mstr() As String
                    Dim mstr1 As String
                    Dim calsetno As Integer
                    mstr1 = objSR.ReadLine
                    mstr = mstr1.Split(",")
                    calsetno = mstr(1)
                    cmbSets.SelectedValue = calsetno
                    objSR.Close()
                    pstarted = False
                    frmTest_UpdateEnd("KeyDown") ' Zaid Commented 21 April
                    Me.Text = "Test Setup"
                    SendGainSet()
                    j = ReadOrgPRS()
                    keyprocessing = False
                    IsKeyDown = False
                    If j = -1 Then
                        curj = 0
                        SetTextBox()
                        Return
                    ElseIf (j >= 100 And j < 150) Then    'WT test confirm exit -> confirm
                        keyprocessing = False
                        Application.DoEvents()
                        glbi = j - 100
                        caltyp = 4
                        RunFreeze()
                    ElseIf (j >= 150 And j < 200) Then   'WT test minus exit -> zoom
                        keyprocessing = False
                        Application.DoEvents()
                        glbi = j - 150
                        caltyp = 6 : oldtyp = 0
                        RunFreeze()
                    ElseIf (j >= 200 And j < 300) Then 'SRT minus exit ->Freeze (caltyp = 2)
                        keyprocessing = False
                        Application.DoEvents()
                        glbi = j - 200
                        caltyp = 2
                        RunFreeze()
                    Else
                        Panel1.Visible = True
                        curj = 110
                        SetTextBox()
                        isTextInfo = True
                    End If
                    isTextInfo = True
#End If

                Case MKey3

                    setProbes()
                    keyprocessing = False
                    glbi = 0
                    If TotNch > 5 Then
                        caltyp = 12
                        isHand = True
                        If File.Exists(handheld) Then
                            Dim objSR As StreamReader = New StreamReader(handheld)
                            cmbProbe.Items.Clear()
                            Do While Not objSR.EndOfStream
                                cmbProbe.Items.Add(objSR.ReadLine)
                            Loop
                            objSR.Close()
                            Dim n As Integer = cmbProbe.Items.Count
                            Dim st As String = cmbProbe.Items(0)
                            For i = n + 1 To 7
                                cmbProbe.Items.Add(st)
                            Next
                            cmbProbe.SelectedIndex = 0
                            isTextInfo = True
                        End If
                        curj = 0
                        SetTextBox()
                        If pstarted Then
                            p.Close()
                            'From C Side selection for Calset
                            Dim objSR As StreamReader = New StreamReader(Calset)
                            Dim mstr() As String
                            Dim mstr1 As String
                            Dim calsetno As Integer
                            mstr1 = objSR.ReadLine
                            mstr = mstr1.Split(",")
                            calsetno = mstr(1)
                            cmbSets.SelectedValue = calsetno
                            objSR.Close()
                            pstarted = False
                            PauseIt(1)
                        End If
                        subrange1 = cmbRange1.Text
                        subrange2 = cmbRange2.Text
                        If subrange2 < (subrange1 + 20) Then subrange2 = subrange1 + 20
                        SetParams(subrange1, subrange2, False)
                        lblEndKm.Visible = False
                        txtEndKm.Visible = False
                        lblendm.Visible = False
                        txtEndMeter.Visible = False
                        Lblendtp.Visible = False
                        txtendTP.Visible = False
                        lblTotKm.Visible = False
                        txtTotKm.Visible = False
                        RunSelfTest()
                        Me.Text = "Test Setup"
                        keyprocessing = False
                        IsKeyDown = False
                    Else
                        caltyp = 4
                        RunFreeze()
                        isTextInfo = True
                    End If
                Case SKey1
                    setProbes()
                    subrange1 = cmbRange1.Text : subrange2 = cmbRange2.Text
                    SetTextBox()
                    keyprocessing = False
                    Application.DoEvents()
                    glbi = 1
                    caltyp = 4
                    RunFreeze()
                Case SKey2
                    setProbes()
                    subrange1 = cmbRange1.Text : subrange2 = cmbRange2.Text
                    SetTextBox()
                    keyprocessing = False
                    Application.DoEvents()
                    glbi = 1
                    caltyp = 6 : oldtyp = 0
                    RunFreeze()
                Case SKey3
                    setProbes()
                    subrange1 = cmbRange1.Text : subrange2 = cmbRange2.Text
                    SetTextBox()
                    keyprocessing = False
                    Application.DoEvents()
                    glbi = 1
                    caltyp = 2
                    RunFreeze()

                Case MKey2
                    setProbes()
                    curj = 0
                    SetTextBox()
                    If pstarted Then
                        p.Close()
                        'From C Side selection for Calset
                        Dim objSR As StreamReader = New StreamReader(Calset)
                        Dim mstr() As String
                        Dim mstr1 As String
                        Dim calsetno As Integer
                        mstr1 = objSR.ReadLine
                        mstr = mstr1.Split(",")
                        calsetno = mstr(1)
                        cmbSets.SelectedValue = calsetno
                        objSR.Close()
                        pstarted = False
                        PauseIt(1)
                    End If
                    subrange1 = cmbRange1.Text
                    subrange2 = cmbRange2.Text
                    If subrange2 < (subrange1 + 20) Then subrange2 = subrange1 + 20
                    SetParams(subrange1, subrange2, False)
                    lblEndKm.Visible = False
                    txtEndKm.Visible = False
                    lblendm.Visible = False
                    txtEndMeter.Visible = False
                    Lblendtp.Visible = False
                    txtendTP.Visible = False
                    lblTotKm.Visible = False
                    txtTotKm.Visible = False
                    glbi = 0
                    If TotNch > 5 Then caltyp = 2 Else caltyp = 6 : oldtyp = 0
                    RunFreeze()
                    current_kmupdate()
                    SaveInfo()
                    SaveData2()

                Case MKey4
                    RecordType()
                    Defaultvalues()
                    If (k = FKeySave) Then
                        frmTest_UpdateEnd("FKeySave")
                    End If
                    If pstarted Then
                        p.Close()
                        'From C Side selection for Calset
                        Dim objSR As StreamReader = New StreamReader(Calset)
                        Dim mstr() As String
                        Dim mstr1 As String
                        Dim calsetno As Integer
                        mstr1 = objSR.ReadLine
                        mstr = mstr1.Split(",")
                        calsetno = mstr(1)
                        cmbSets.SelectedItem = calsetno
                        objSR.Close()
                    End If
                    CreateRunFolder()
                    DivisionParameter()
                    If txtCh.Text = "10" Or curi = 9 Then
                        OpenConfig210ch()
                    Else
                        OpenConfig2()
                    End If
                    SaveData2()
                    SaveInfo()
                    SaveInfo1()
                    current_kmupdate()
                    Panel1.Visible = False
                    curj = 0
                    SetTextBox()
                Case FKeySave
                    If (k = FKeySave) Then
                        frmTest_UpdateEnd("FKeySave")
                    End If
                    If pstarted Then
                        p.Close()
                        'From C Side selection for Calset
                        Dim objSR As StreamReader = New StreamReader(Calset)
                        Dim mstr() As String
                        Dim mstr1 As String
                        Dim calsetno As Integer
                        mstr1 = objSR.ReadLine
                        mstr = mstr1.Split(",")
                        calsetno = mstr(1)
                        cmbSets.SelectedValue = calsetno
                    End If
                    CreateRunFolder()
                    If txtCh.Text.ToString.Trim = "10" Or curi = 9 Then
                        OpenConfig210ch()
                    Else
                        OpenConfig2()
                    End If
                    SaveData2()
                    SaveInfo()
                    SaveInfo1()
                    current_kmupdate()
                    Panel1.Visible = False
                    curj = 0
                    SetTextBox()
                    RecordType()
                    jpgflag = True
                    prv_jpg()
                    Application.DoEvents()

                Case EsKey
                    If pstarted Then
                        p.Close()
                        'From C Side selection for Calset
                        Dim objSR As StreamReader = New StreamReader(Calset)
                        Dim mstr() As String
                        Dim mstr1 As String
                        Dim calsetno As Integer
                        mstr1 = objSR.ReadLine
                        mstr = mstr1.Split(",")
                        calsetno = mstr(1)
                        cmbSets.SelectedValue = calsetno
                        pstarted = False
                    End If
                    Panel1.Visible = False
                    curj = 0
                    SetTextBox()

                Case MKey7
                    If pstarted Then
                        p.Close()
                        pstarted = False
                    End If
                    isTextInfo = False
                    Panel1.Visible = False
                    If Not Me.lblEndKm.Visible Then
                        lblEndKm.Visible = True
                        txtEndKm.Visible = True
                        lblendm.Visible = True
                        txtEndMeter.Visible = True
                        Lblendtp.Visible = True
                        txtendTP.Visible = True
                        lblTotKm.Visible = True
                        txtTotKm.Visible = True
                        curj = 200
                        SetTextBox()
                    Else
                        Dim di As String = AppDataPath & "\dirinfo.txt"
                        If File.Exists(di) Then File.Delete(di)
                        Dim sw As StreamWriter = New StreamWriter(di)
                        sw.WriteLine(Me.txtEndKm.Text)
                        sw.WriteLine(Me.txtEndMeter.Text)
                        sw.WriteLine(Me.txtendTP.Text)
                        sw.WriteLine(Me.txtTotKm.Text)
                        sw.Close()
                        Me.Close()
                        frmMain.Show()
                    End If

                Case FkeyLf
                    curj = curj - 1
                    uped = -1
                    SetTextBox()

                Case FkeyRt, 229
                    curj = curj + 1
                    uped = +1
                    SetTextBox()

                Case FKeyMinus
                    If cmbSets.SelectedIndex > 0 Then cmbSets.SelectedIndex -= 1

                Case FKeyPlus
                    If cmbSets.SelectedIndex < cmbSets.Items.Count - 1 Then cmbSets.SelectedIndex += 1

                Case FKeyUp
                    Select Case curj
                        Case 0 : If cmbSets.SelectedIndex > 0 Then cmbSets.SelectedIndex -= 1
                        Case 1 : If cmbRange1.SelectedIndex > 0 Then cmbRange1.SelectedIndex -= 1
                        Case 2 : If cmbRange2.SelectedIndex > 0 Then cmbRange2.SelectedIndex -= 1
                        Case 11 : If cmbRail.SelectedIndex > 0 Then cmbRail.SelectedIndex -= 1
                        Case 12 : If cmbRoad.SelectedIndex > 0 Then cmbRoad.SelectedIndex -= 1
                        Case 13 : If cmbrailtype.SelectedIndex > 0 Then cmbrailtype.SelectedIndex -= 1
                        Case 16 : If cmbRecord.SelectedIndex > 0 Then cmbRecord.SelectedIndex -= 1
                        Case 113 : If cmbLhRh.SelectedIndex > 0 Then cmbLhRh.SelectedIndex -= 1
                        Case 115 : If cmbRWS.SelectedIndex > 0 Then cmbRWS.SelectedIndex -= 1
                        Case 17, 120 : If cmbMask1.SelectedIndex > 0 Then cmbMask1.SelectedIndex -= 1
                        Case 18, 121 : If cmbMask2.SelectedIndex > 0 Then cmbMask2.SelectedIndex -= 1
                        Case 19, 122 : If cmbMask3.SelectedIndex > 0 Then cmbMask3.SelectedIndex -= 1
                        Case 21, 124 : If cmbLR.SelectedIndex > 0 Then cmbLR.SelectedIndex -= 1
                        Case 22, 125 : If cmbProbe.SelectedIndex > 0 Then cmbProbe.SelectedIndex -= 1
                        Case 23, 126 : If cmbTyp.SelectedIndex > 0 Then cmbTyp.SelectedIndex -= 1
                        Case 24, 127 : If cmbFLoc.SelectedIndex > 0 Then cmbFLoc.SelectedIndex -= 1
                        Case 25, 129 : If cmbClass.SelectedIndex > 0 Then cmbClass.SelectedIndex -= 1
                        Case 26, 130 : If cmbCode.SelectedIndex > 0 Then cmbCode.SelectedIndex -= 1
                        Case 27, 131 : If cmbCode2.SelectedIndex > 0 Then cmbCode2.SelectedIndex -= 1
                        Case 30, 134 : If cmbTyp2.SelectedIndex > 0 Then cmbTyp2.SelectedIndex -= 1
                        Case 31, 135 : If cmbFLoc2.SelectedIndex > 0 Then cmbFLoc2.SelectedIndex -= 1
                        Case 32, 136 : If cmbClass2.SelectedIndex > 0 Then cmbClass2.SelectedIndex -= 1
                        Case 33, 138 : If cmbCris.SelectedIndex > 0 Then cmbCris.SelectedIndex -= 1
                    End Select

                Case FKeyDn
                    Select Case curj
                        Case 0 : If cmbSets.SelectedIndex < cmbSets.Items.Count - 1 Then cmbSets.SelectedIndex += 1
                        Case 1 : If cmbRange1.SelectedIndex < cmbRange1.Items.Count - 1 Then cmbRange1.SelectedIndex += 1
                        Case 2 : If cmbRange2.SelectedIndex < cmbRange2.Items.Count - 1 Then cmbRange2.SelectedIndex += 1
                        Case 11 : If cmbRail.SelectedIndex < cmbRail.Items.Count - 1 Then cmbRail.SelectedIndex += 1
                        Case 12 : If cmbRoad.SelectedIndex < cmbRoad.Items.Count - 1 Then cmbRoad.SelectedIndex += 1
                        Case 13 : If cmbrailtype.SelectedIndex < cmbrailtype.Items.Count - 1 Then cmbrailtype.SelectedIndex += 1
                        Case 16 : If cmbRecord.SelectedIndex < cmbRecord.Items.Count - 1 Then cmbRecord.SelectedIndex += 1
                        Case 113 : If cmbLhRh.SelectedIndex < cmbLhRh.Items.Count - 1 Then cmbLhRh.SelectedIndex += 1
                        Case 115 : If cmbRWS.SelectedIndex < cmbRWS.Items.Count - 1 Then cmbRWS.SelectedIndex += 1
                        Case 17, 120 : If cmbMask1.SelectedIndex < cmbMask1.Items.Count - 1 Then cmbMask1.SelectedIndex += 1
                        Case 18, 121 : If cmbMask2.SelectedIndex < cmbMask2.Items.Count - 1 Then cmbMask2.SelectedIndex += 1
                        Case 19, 122 : If cmbMask3.SelectedIndex < cmbMask3.Items.Count - 1 Then cmbMask3.SelectedIndex += 1
                        Case 21, 124 : If cmbLR.SelectedIndex < cmbLR.Items.Count - 1 Then cmbLR.SelectedIndex += 1
                        Case 22, 125 : If cmbProbe.SelectedIndex < cmbProbe.Items.Count - 1 Then cmbProbe.SelectedIndex += 1
                        Case 23, 126 : If cmbTyp.SelectedIndex < cmbTyp.Items.Count - 1 Then cmbTyp.SelectedIndex += 1
                        Case 24, 127 : If cmbFLoc.SelectedIndex < cmbFLoc.Items.Count - 1 Then cmbFLoc.SelectedIndex += 1
                        Case 25, 129 : If cmbClass.SelectedIndex < cmbClass.Items.Count - 1 Then cmbClass.SelectedIndex += 1
                        Case 26, 130 : If cmbCode.SelectedIndex < cmbCode.Items.Count - 1 Then cmbCode.SelectedIndex += 1
                        Case 27, 131 : If cmbCode2.SelectedIndex < cmbCode2.Items.Count - 1 Then cmbCode2.SelectedIndex += 1
                        Case 30, 134 : If cmbTyp2.SelectedIndex < cmbTyp2.Items.Count - 1 Then cmbTyp2.SelectedIndex += 1
                        Case 31, 135 : If cmbFLoc2.SelectedIndex < cmbFLoc2.Items.Count - 1 Then cmbFLoc2.SelectedIndex += 1
                        Case 32, 136 : If cmbClass2.SelectedIndex < cmbClass2.Items.Count - 1 Then cmbClass2.SelectedIndex += 1
                        Case 33, 138 : If cmbCris.SelectedIndex < cmbCris.Items.Count - 1 Then cmbCris.SelectedIndex += 1
                    End Select

            End Select
            keyprocessing = False
            Application.DoEvents()
        Catch ex As Exception
            'MessageBox.Show(ex.Message(), "KeyDown()")
        End Try
    End Sub

    Public Function GetDateString() As String
        Dim st As String = txtDate.Text
        Dim j As Integer
        Do While True
            j = InStr(1, st, "-")
            If j = 0 Then Exit Do
            st = Mid$(st, 1, j - 1) & Mid$(st, j + 1)
        Loop
        Do While True
            j = InStr(1, st, Chr(KeyDeci))
            If j = 0 Then Exit Do
            st = Mid$(st, 1, j - 1) & Mid$(st, j + 1)
        Loop
        Do While True
            j = InStr(1, st, Chr(189))
            If j = 0 Then Exit Do
            st = Mid$(st, 1, j - 1) & Mid$(st, j + 1)
        Loop
        Select Case cmbRoad.SelectedIndex
            Case 0 : st &= "UP" & txtMCNO.Text.ToString()
            Case 1 : st &= "DN" & txtMCNO.Text.ToString()
            Case 2 : st &= "SN" & txtMCNO.Text.ToString()
            Case 3 : st &= "UD" & txtMCNO.Text.ToString()
            Case 4 : st &= "ByPass UP" & txtMCNO.Text.ToString()
            Case 5 : st &= "ByPass DN" & txtMCNO.Text.ToString()
            Case 6 : st &= "ByPass SL" & txtMCNO.Text.ToString()
            Case 7 : st &= "L1" & txtMCNO.Text.ToString()
            Case 8 : st &= "L2" & txtMCNO.Text.ToString()
            Case 9 : st &= "L3" & txtMCNO.Text.ToString()
            Case 10 : st &= "L4" & txtMCNO.Text.ToString()
            Case 11 : st &= "L5" & txtMCNO.Text.ToString()
            Case 12 : st &= "NL" & txtMCNO.Text.ToString()
        End Select
        Return st
    End Function

    Public Sub CreateRunFolder()
        Try
            Dim j As Integer = 0
            Dim dat As String = GetDateString()
            AppDataPath = RootDataPath & "\" & dat
            If Not Directory.Exists(AppDataPath) Then
                Directory.CreateDirectory(AppDataPath)
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message(), "CreateRunFolder")
        End Try
    End Sub

    Private Sub SaveData()
        Try
            Dim farr As String() = Directory.GetFiles(StorageCard, "*.pr*")
            Dim c() As Char
            Dim i As Integer, j As Integer, k As Integer
            Dim objBW As BinaryWriter
            Dim objFS As FileStream
            Dim objBWin As BinaryReader
            Dim objFSin As FileStream
            Dim b() As Byte

            For k = 0 To farr.GetUpperBound(0)
                Dim v As String() = farr(k).Split("\")
                objFS = New FileStream(AppDataPath & v(v.GetUpperBound(0)), FileMode.OpenOrCreate, FileAccess.Write)
                objBW = New BinaryWriter(objFS)
                c = txtMCNO.Text.PadRight(20).ToCharArray
                objBW.Write(c)
                c = txtName.Text.PadRight(20).ToCharArray
                objBW.Write(c)
                c = txtDate.Text.PadRight(20).ToCharArray
                objBW.Write(c)
                c = txtTime.Text.PadRight(20).ToCharArray
                objBW.Write(c)
                c = txtDiv.Text.PadRight(20).ToCharArray
                objBW.Write(c)
                c = txtSec.Text.PadRight(20).ToCharArray
                objBW.Write(c)
                c = txtM.Text.PadRight(20).ToCharArray
                objBW.Write(c)
                c = txtKm.Text.PadRight(20).ToCharArray
                objBW.Write(c)
                c = txtTP.Text.PadRight(20).ToCharArray
                objBW.Write(c)
                c = cmbRail.Text.PadRight(20).ToCharArray
                objBW.Write(c)
                c = cmbRoad.Text.PadRight(20).ToCharArray
                objBW.Write(c)
                c = cmbrailtype.Text.PadRight(20).ToCharArray
                objBW.Write(c)
                c = txtLatitude.Text.PadRight(20).ToCharArray
                objBW.Write(c)
                c = txtLongtitude.Text.PadRight(20).ToCharArray
                objBW.Write(c)

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
                objBWin.Close()
                objFSin.Close()
                objFS.Close()
                If File.Exists(farr(k)) Then File.Delete(farr(k))
            Next k

        Catch ex As Exception
            'MessageBox.Show(ex.Message(), "Form2_SaveData()")
        End Try
    End Sub

    Private Sub RunSelfTest()
        Try
            DelOrgPRS()
            CreateRunFolder()
            Panel1.Visible = False
            glbi = 0
            curj = 0
            SendGainSet()
            frmCalib.ShowDialog()
            If Panel1.Visible Then curj = 10 Else curj = 0
            SetTextBox()
            isTextInfo = True
        Catch ex As Exception
            'MessageBox.Show(ex.Message(), "RunSelfTest()")
        End Try
    End Sub

    Private Sub RunFreeze()
        Try
            DelOrgPRS()
            CreateRunFolder()
            Panel1.Visible = False
            curj = 0
            SendGainSet()
            frmCalib.ShowDialog()
            If Panel1.Visible Then curj = 10 Else curj = 0
            SetTextBox()
            isTextInfo = True
        Catch ex As Exception
            'MessageBox.Show(ex.Message(), "RunFreeze")
        End Try
    End Sub

    Private Sub RunZoom(Optional ByVal isFrz As Boolean = True)
        Try
            DelOrgPRS()
            CreateRunFolder()
            Panel1.Visible = False
            curj = 0
            caltyp = 6
            SendGainSet()
            frmCalib.ShowDialog()
            If Panel1.Visible Then curj = 10 Else curj = 0
            SetTextBox()
            isTextInfo = True
        Catch ex As Exception
            'MessageBox.Show(ex.Message(), "RunZoom()")
        End Try
    End Sub

    Public Sub ReadConfigFile()
        Try
            Dim configData As String
            Dim configReader As StreamReader = New StreamReader(configfile)
            For i = 0 To DArr.GetUpperBound(0)
                configData = configReader.ReadLine
                Dim st2() As String = Split(configData, ",")
                For j = 0 To DArr.GetUpperBound(1)
                    DArr(i, j) = st2(j)
                Next
            Next
            configReader.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message(), "ReadConfigFile()")
        End Try
    End Sub

    'cmbProbe.Selected index based on channel number for PRS File Defect Details Window
    Private Function ReadOrgPRS() As Integer
        Try
            Dim i As Integer
            Dim curi As Integer
            Dim farr As String() = Directory.GetFiles(StorageCard, "*.prs")

            If farr.Length = 0 Then Return -1

            i = InStr(farr(0), ".prs")
            If Mid(farr(0), i - 3, 1) = "_" Then
                curi = Val(Mid(farr(0), i - 2))
                ' here will add probes
                If curi.ToString().Trim() = "1" Then
                    cmbProbe.SelectedIndex = 0
                    'cmbProbe.Text = "0°"
                ElseIf curi.ToString().Trim() = "2" Then
                    cmbProbe.SelectedIndex = 1
                ElseIf curi.ToString().Trim() = "3" Then
                    cmbProbe.SelectedIndex = 2
                ElseIf curi.ToString().Trim() = "4" Then
                    cmbProbe.SelectedIndex = 3
                ElseIf curi.ToString().Trim() = "5" Then
                    cmbProbe.SelectedIndex = 4
                ElseIf curi.ToString().Trim() = "6" Then
                    cmbProbe.SelectedIndex = 5
                ElseIf curi.ToString().Trim() = "7" Then
                    cmbProbe.SelectedIndex = 6
                ElseIf curi.ToString().Trim() = "8" Then
                    cmbProbe.SelectedIndex = 7
                ElseIf curi.ToString().Trim() = "9" Then
                    cmbProbe.SelectedIndex = 8
                ElseIf curi.ToString().Trim() = "10" Then
                    cmbProbe.SelectedIndex = 9
                End If

            Else
                curi = 0
            End If
            If curi = 0 Then Return -1
            curi -= 1
            If TotNch < 9 Then
                If InStr(UCase(farr(0)), "A_") <> 0 Then
                    File.Delete(farr(0))
                    Return 100 + curi
                End If
                If InStr(UCase(farr(0)), "B_") <> 0 Then
                    Return 150 + curi
                End If
            Else
                If InStr(UCase(farr(0)), "B_") <> 0 Then
                    File.Delete(farr(0))
                    Return 200 + curi
                End If
            End If

            'Read the Config file
            ReadConfigFile()

            Dim objFS As FileStream = New FileStream(farr(0), FileMode.Open, FileAccess.Read)
            Dim objBR As BinaryReader = New BinaryReader(objFS)
            Dim upt As Integer = DataArr(curi, 2)
            objFS.Seek(IIf(curi > 6, curi + 1, curi) * 2048 + DataArr(curi, 1), SeekOrigin.Current)
            Dim vmax As Single = 0
            Dim imax As Integer = 0
            Dim FirstPeek As Integer = 0
            Dim Downflg As Boolean = False
            Dim PeekFlag As Integer = 0
            Dim LastPeek As Integer = 0
            Dim prsSx As Double
            Dim gate1s As Integer = DArr(curi, 4)
            Dim gate1w As Integer = gate1s + DArr(curi, 5)
            Dim gate2s As Integer = DArr(curi, 7)
            Dim gate2w As Integer = gate2s + DArr(curi, 8)
            Dim rej As Integer = DArr(curi, 3)
            Dim Rising As Integer
            Dim xBP As Integer = 0
            Dim yBP As Integer = 0
            Dim sBP As Integer = 0
            Dim PV As Integer

            For i = 0 To upt
                Dim v1 As Byte = objFS.ReadByte

                If i > gate1s And i < gate1w And i > gate2s And i < gate2w Then
                    If (rej > v1) Then
                        Continue For
                    End If
                    ' Check for first rising graph 
                    'HM Start
                    If FirstPeek = 0 Then
                        If vmax < v1 Then
                            FirstPeek = i
                        End If
                    End If

                    'Check the graph is reached down
                    If v1 = 0 And FirstPeek <> 0 Then
                        If Downflg = False Then
                            Downflg = True
                            LastPeek = i
                        End If
                    Else
                        Downflg = False
                    End If

                    'HM END
                    If vmax < v1 Then
                        vmax = v1
                        imax = i
                    End If

                    'Find BP
                    ' First rising point
                    If (v1 > 0) And Rising = 0 Then
                        xBP = i
                        Rising = 1
                        PV = v1
                    End If

                    If Rising = 1 Then
                        If (PV < v1) Then
                            PV = v1
                        End If
                    End If

                    ' Reaching Origin
                    If (Rising = 1) And (v1 = 0) Then
                        If (yBP < PV) Then
                            yBP = PV
                            sBP = xBP
                        End If
                        Rising = 0
                    End If
                End If

            Next i
            objBR.Close()
            objFS.Close()

            prsSx = 500 / upt
            FirstPeek = FirstPeek * prsSx
            LastPeek = LastPeek * prsSx
            vmax /= ymaxS
            Dim dd As Single
            dd = Rangemm(imax, curi)
            txtCh.Text = Format(curi + 1, "0")
            'Reading from parameters.txt
            Dim parameterstr() As String
            Dim parameterstrl As String
            Dim objSR As StreamReader = New StreamReader("\SD Card\Parameter.txt")
            parameterstrl = objSR.ReadLine
            parameterstr = parameterstrl.Split(",")
            txtPH.Text = parameterstr(0)
            txtHM.Text = parameterstr(1)
            txtdepth.Text = parameterstr(2)
            txtbp.Text = parameterstr(3)
            objSR.Close()
            'Gps location
            Dim GpsLocation As New clsGpsLocation
            Dim Latitude As Double, Longitude As Double
            Dim lat_dir As String, lon_dir As String
            Dim StrLatitude As String
            Dim StrLongitude As String

            GpsLocation.GetPos(Latitude, Longitude, lat_dir, lon_dir)
            StrLatitude = GpsLocation.ToDMS(Latitude)
            StrLongitude = GpsLocation.ToDMS(Longitude)
            txtLatitude.Text = (StrLatitude & " " & lat_dir)
            txtLongtitude.Text = (StrLongitude & " " & lon_dir)
            Return curi

        Catch ex As Exception
            'MessageBox.Show(ex.Message(), "ReadOrgPRS()")
        End Try
    End Function

    Private Sub DelOrgPRS()
        Try
            Dim i As Integer
            Dim farr As String() = Directory.GetFiles(StorageCard, "*.prs")
            Try
                If farr.Length <> 0 Then
                    For i = 0 To farr.Length
                        File.Delete(farr(i))
                    Next i
                End If
            Catch ex As Exception

            End Try
        Catch ex As Exception
            'MessageBox.Show(ex.Message(), "DelOrgPRS()")
        End Try
    End Sub

    Private Sub SaveInfo(ByVal objBW As BinaryWriter)
        Try
            objBW.Write(txtMCNO.Text)                   '0
            If txtCh.Text.ToString().Trim() = "10" Then
                Dim objSR As StreamReader = New StreamReader(Calset)
                Dim mstr() As String
                Dim mstr1 As String
                mstr1 = objSR.ReadLine
                mstr = mstr1.Split(",")
                objBW.Write(mstr(1).ToString())         '1
            Else
                objBW.Write(cmbSets.Text)               '1
            End If
            objBW.Write(txtName.Text)                   '2
            objBW.Write(txtDate.Text)                   '3
            objBW.Write(txtTime.Text & " [Record @" & DateTime.Now.ToString("hh:mm tt") & "]")                   '4
            objBW.Write(txtDiv.Text)                    '5
            objBW.Write(txtSec.Text)                    '6
            objBW.Write(txtKm.Text)                     '7
            objBW.Write(txtM.Text)                      '8     
            objBW.Write(txtTP.Text)                     '9
            objBW.Write(cmbRail.Text)                   '10
            objBW.Write(cmbRoad.Text)                   '11
            objBW.Write(cmbrailtype.Text)               '12
            objBW.Write(txtKM2.Text)                    '13
            objBW.Write(txtMeter2.Text)                 '14
            objBW.Write(txtTP2.Text)                    '15
            objBW.Write(cmbLhRh.Text & txtLoc1.Text & cmbRWS.Text)                   '16
            objBW.Write(txtLoc2.Text)                   '17
            objBW.Write(txtLoc3.Text)                   '18
            objBW.Write(txtSta1.Text)                   '19
            objBW.Write(txtSta2.Text)                   '20
            objBW.Write(cmbMask1.Text)                  '21
            objBW.Write(cmbMask2.Text)                  '22
            objBW.Write(cmbMask3.Text)                  '23
            objBW.Write(txtMask4.Text)                  '24
            objBW.Write(cmbLR.Text)                     '25
            objBW.Write(cmbProbe.Text)                  '26
            objBW.Write(txtPH.Text)                     '27
            objBW.Write(txtHM.Text)                     '28
            objBW.Write(cmbTyp.Text)                    '29
            objBW.Write(cmbFLoc.Text)                   '30
            objBW.Write(txtlen.Text)                    '31
            objBW.Write(cmbClass.Text)                  '32
            objBW.Write(cmbCode.Text)                   '33
            objBW.Write(txtPH2.Text)                    '34
            objBW.Write(txtHM2.Text)                    '35
            objBW.Write(cmbTyp2.Text)                   '36
            objBW.Write(cmbFLoc2.Text)                  '37
            objBW.Write(cmbClass2.Text)                 '38
            objBW.Write(txtLatitude.Text)               '39   
            objBW.Write(txtLongtitude.Text)             '40    
            objBW.Write(txtdepth.Text)                  '41    
            objBW.Write(txtbp.Text)                     '42    
            objBW.Write(txtheight.Text)                 '43    
            objBW.Write(cmbCode2.Text)                  '44
            Dim st As String = cmbCode2.Text & "[" & cmbCris.Text & "[" & txtRem.Text
            objBW.Write(st)                             '45

        Catch ex As Exception
            'MessageBox.Show(ex.Message(), "SaveInfo(ByVal objBW As BinaryWriter)")
        End Try
    End Sub
    Private Sub SaveInfo()
        Try
            Dim objFS = New FileStream(testinfo, FileMode.Create, FileAccess.Write)
            Dim objBW = New BinaryWriter(objFS)
            SaveInfo(objBW)
            objBW.Close()
            objFS.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message(), "SaveInfo()")
        End Try
    End Sub

    Private Sub SaveInfo1()
        Try
            If File.Exists(kminfo) Then File.Delete(kminfo)
            Dim sw As StreamWriter = New StreamWriter(kminfo)
            sw.WriteLine(Me.txtckm.Text & "," & Me.txtcm.Text & "," & Me.txtMCNO.Text & "," & Me.cmbSets.Text & "," & Me.cmbRoad.Text & "," & Me.cmbRail.Text & "," & Me.cmbrailtype.Text & "," & Me.cmbRail.Text & ",")
            sw.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message(), "SaveInfo1()")
        End Try
    End Sub

    Private Sub ReadInfo()
        Try
            Dim st As String
            Dim ss() As String
            If Not File.Exists(testinfo) Then Exit Sub
            Dim objFS = New FileStream(testinfo, FileMode.Open, FileAccess.Read)
            Dim objBR = New BinaryReader(objFS)

            txtMCNO.Text = objBR.ReadString                 '0
            txtMCNO.Text = Format(uno, "0000")              'MCNO
            cmbSets.Text = objBR.ReadString                 '1
            txtName.Text = objBR.ReadString                 '2
            txtDate.Text = objBR.ReadString                 '3
            st = objBR.ReadString                           '4
            ss = st.Split("[")
            txtTime.Text = ss(0).Trim
            If TotNch > 5 Then
                txtDate.Text = StartDate                    'DateTime.Now.ToString("yyyy-MM-dd")   '3
                txtTime.Text = StartTime                    'DateTime.Now.ToString("HH-mm")      '4
            End If
            txtDiv.Text = objBR.ReadString                  '5
            txtSec.Text = objBR.ReadString                  '6
            txtKm.Text = objBR.ReadString                   '7
            txtM.Text = objBR.ReadString                    '8
            txtTP.Text = objBR.ReadString                   '9
            cmbRail.Text = objBR.ReadString                 '10
            cmbRoad.Text = objBR.ReadString                 '11
            cmbrailtype.Text = objBR.ReadString             '12
            txtKM2.Text = objBR.ReadString                  '13
            txtMeter2.Text = objBR.ReadString               '14
            txtTP2.Text = objBR.ReadString                  '15
            Dim strValue As String = objBR.ReadString                 '16
            txtLoc2.Text = objBR.ReadString                 '17
            txtLoc3.Text = objBR.ReadString                 '18
            txtSta1.Text = objBR.ReadString                 '19
            txtSta2.Text = objBR.ReadString                 '20
            cmbMask1.Text = objBR.ReadString                '21
            cmbMask2.Text = objBR.ReadString                '22
            cmbMask3.Text = objBR.ReadString                '23
            txtMask4.Text = objBR.ReadString                '24
            cmbLR.Text = objBR.ReadString                   '25
            cmbProbe.Text = objBR.ReadString                '26
            txtPH.Text = objBR.ReadString                   '27
            txtHM.Text = objBR.ReadString                   '28
            cmbTyp.Text = objBR.ReadString                  '29
            cmbFLoc.Text = objBR.ReadString                 '30
            txtlen.Text = objBR.ReadString                  '31
            cmbClass.Text = objBR.ReadString                '32
            cmbCode.Text = objBR.ReadString                 '33
            txtPH2.Text = objBR.ReadString                  '34
            txtHM2.Text = objBR.ReadString                  '35
            cmbTyp2.Text = objBR.ReadString                 '36
            cmbFLoc2.Text = objBR.ReadString                '37
            cmbClass2.Text = objBR.ReadString               '38
            txtLatitude.Text = objBR.ReadString             '39
            txtLongtitude.Text = objBR.ReadString           '40
            txtdepth.Text = objBR.ReadString                '41
            txtbp.Text = objBR.ReadString                   '42
            txtheight.Text = objBR.ReadString               '43
            cmbCode2.Text = objBR.ReadString                '44
            'cmbCode2.Text = objBR.ReadString               '36
            st = objBR.ReadString                           '38
            Dim sst() As String = st.Split("[")
            cmbCode2.Text = sst(0)
            If sst.Length > 1 Then
                cmbCris.Text = sst(1)
                txtRem.Text = sst(2)
            End If
            txtPH.Text = ""                                 '24
            txtHM.Text = ""                                 '25
            objBR.Close()
            objFS.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message(), "ReaddInfo()")
        End Try
    End Sub

    Private Sub SaveData2()
        Try
            ReadData()
            Static isSaving
            If isSaving Then Exit Sub
            isSaving = True
            Dim i As Integer, j As Integer, k As Integer
            Dim objBW As BinaryWriter
            Dim objFS As FileStream
            Dim objBWin As BinaryReader
            Dim objFSin As FileStream
            Dim b() As Byte
            Dim farr As String(), Outfarr As String()
            Dim kk As Integer, kk1 As Integer
            Dim st As String
            Dim cap As String = Me.Text
            Dim km As String, M As String, tp As String

            M = txtMeter2.Text.ToString()

            Dim v1 As Integer, v2 As Integer
            tp = txtTP2.Text
            v1 = Val(tp) ': v2 = 0
            For j = 1 To Len(tp)
                st = Mid$(tp, j, 1)
                If Not IsNumeric(st) Then
                    v2 = Val(Mid(tp, j + 1))
                End If
            Next

            If txtTP2.Text = "" Then
                tp = "00-00"
            End If

            tp = txtTP2.Text
            km = Trim(txtKM2.Text)
            st = Strings.Right(km, 1)
            If IsNumeric(st) Then st = " "
            km = Format(Val(km), "0000")

            'filename
            st = km & st & M & st & tp
            StripDotDash2Dash(st)
            farr = Directory.GetFiles(StorageCard, "*.prs")

            If farr.Length <> 0 Then
                Outfarr = Directory.GetFiles(AppDataPath, st & "*.prs")
                kk = 0
                For i = 0 To Outfarr.Length - 1
                    j = InStr(Outfarr(i), "_") + 1
                    kk1 = Val(Mid(Outfarr(i), j))
                    If kk1 > kk Then kk = kk1
                Next
                kk += 1
                Me.Text = cap & " - Saving"
                For k = 0 To farr.GetUpperBound(0)
                    j = InStr(farr(k), ".prs")
                    kk1 = 0
                    If Mid(farr(k), j - 3, 1) = "_" Then kk1 = Val(Mid$(farr(k), j - 2, 2))
                    Dim fnam As String = st & "_" & Format(kk, "000") & "_" & Format(kk1, "00") & ".prs"
                    objFS = New FileStream(AppDataPath & "\" & fnam, FileMode.Create, FileAccess.Write)
                    objBW = New BinaryWriter(objFS)
                    SaveInfo(objBW)
                    temp_jpg = fnam

                    If txtCh.Text.ToString.Trim = "10" Then
                        For i = 0 To DataArr10.GetUpperBound(1)
                            objBW.Write(DataArr10(0, i))
                        Next i
                    Else
                        For i = 0 To DataArr.GetUpperBound(0)
                            For j = 0 To DataArr.GetUpperBound(1)
                                If curi = 1 Or curi = 2 Then
                                    objBW.Write(DataArr(curi, j) + 20)
                                Else
                                    objBW.Write(DataArr(i, j))
                                End If
                            Next j
                        Next i
                    End If

                    objFSin = New FileStream(farr(k), FileMode.Open, FileAccess.Read)
                    objBWin = New BinaryReader(objFSin)
                    b = objBWin.ReadBytes(objFSin.Length)
                    objBW.Write(b) 'PRS peak Points are stored as a 22 byte
                    objBW.Close()
                    objFS.Close()
                    objBWin.Close()
                    objFSin.Close()
                    If File.Exists(farr(k)) Then File.Delete(farr(k))
                    kk += 1
                Next k
            End If

            farr = Directory.GetFiles(StorageCard, "*.prv")
            If farr.Length <> 0 Then
                Outfarr = Directory.GetFiles(AppDataPath, st & "*.prv")
                kk = 0
                For i = 0 To Outfarr.Length - 1
                    j = InStr(Outfarr(i), "_") + 1
                    kk1 = Val(Mid(Outfarr(i), j))
                    If kk1 > kk Then kk = kk1
                Next
                kk += 1
                Me.Text = cap & " - Saving"
                For k = 0 To farr.GetUpperBound(0)
                    j = InStr(farr(k), ".prv")
                    kk1 = 0

                    If Mid$(farr(k), j - 3, 1) = "_" Then kk1 = Val(Mid$(farr(k), j - 2, 2))
                    Dim fnam As String = st & "_" & Format(kk, "000") & "_" & Format(kk1, "00") & ".prv"
                    objFS = New FileStream(AppDataPath & "\" & fnam, FileMode.Create, FileAccess.Write)
                    objBW = New BinaryWriter(objFS)
                    SaveInfo(objBW)
                    temp_jpg = fnam

                    If txtCh.Text.ToString.Trim() = "10" Then
                        For i = 0 To DataArr10.GetUpperBound(0)
                            For j = 0 To DataArr10.GetUpperBound(1)
                                objBW.Write(DataArr10(i, j))
                            Next j
                        Next i
                    Else
                        For i = 0 To DataArr.GetUpperBound(0)
                            For j = 0 To DataArr.GetUpperBound(1)
                                objBW.Write(DataArr(i, j))
                            Next j
                        Next i
                    End If

                    objFSin = New FileStream(farr(k), FileMode.Open, FileAccess.Read)
                    objBWin = New BinaryReader(objFSin)
                    b = objBWin.ReadBytes(objFSin.Length)
                    objBW.Write(b) 'PRV Peak Points are added here
                    objBW.Close()
                    objFS.Close()
                    objBWin.Close()
                    objFSin.Close()
                    If File.Exists(farr(k)) Then File.Delete(farr(k))
                    kk += 1

                Next k
            End If

            farr = Directory.GetFiles(StorageCard, "*.prw")
            If farr.Length <> 0 Then
                Outfarr = Directory.GetFiles(AppDataPath, st & "*.prw")
                kk = 0
                For i = 0 To Outfarr.Length - 1
                    j = InStr(Outfarr(i), "_") + 1
                    kk1 = Val(Mid(Outfarr(i), j))
                    If kk1 > kk Then kk = kk1
                Next
                kk += 1
                Me.Text = cap & " - Saving"
                For k = 0 To farr.GetUpperBound(0)
                    j = InStr(farr(k), ".prw")
                    kk1 = 0
                    If Mid$(farr(k), j - 3, 1) = "_" Then kk1 = Val(Mid$(farr(k), j - 2, 2))
                    Dim fnam As String = st & "_" & Format(kk, "000") & "_" & Format(kk1, "00") & ".prw"
                    objFS = New FileStream(AppDataPath & "\" & fnam, FileMode.Create, FileAccess.Write)
                    objBW = New BinaryWriter(objFS)

                    SaveInfo(objBW)

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
                    kk += 1

                Next k
            End If

            farr = Directory.GetFiles(StorageCard, "*.prh")
            If farr.Length <> 0 Then
                Outfarr = Directory.GetFiles(AppDataPath, st & "*.prh")
                kk = 0
                For i = 0 To Outfarr.Length - 1
                    j = InStr(Outfarr(i), "_") + 1
                    kk1 = Val(Mid(Outfarr(i), j))
                    If kk1 > kk Then kk = kk1
                Next
                kk += 1
                Me.Text = cap & " - Saving"
                For k = 0 To farr.GetUpperBound(0)
                    j = InStr(farr(k), ".prh")
                    kk1 = 0
                    If Mid$(farr(k), j - 3, 1) = "_" Then kk1 = Val(Mid$(farr(k), j - 2, 2))
                    Dim fnam As String = st & "_" & Format(kk, "000") & "_" & Format(kk1, "00") & ".prh"
                    objFS = New FileStream(AppDataPath & "\" & fnam, FileMode.Create, FileAccess.Write)
                    objBW = New BinaryWriter(objFS)

                    SaveInfo(objBW)


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
                    kk += 1
                Next k
            End If

            farr = Directory.GetFiles(StorageCard, "*.prc")
            If farr.Length <> 0 Then
                Outfarr = Directory.GetFiles(AppDataPath, st & "*.prc")
                kk = 0
                For i = 0 To Outfarr.Length - 1
                    j = InStr(Outfarr(i), "_") + 1
                    kk1 = Val(Mid(Outfarr(i), j))
                    If kk1 > kk Then kk = kk1
                Next
                kk += 1
                Me.Text = cap & " - Saving"
                For k = 0 To farr.GetUpperBound(0)
                    j = InStr(farr(k), ".prc")
                    kk1 = 0
                    If Mid$(farr(k), j - 3, 1) = "_" Then kk1 = Val(Mid$(farr(k), j - 2, 2))
                    Dim fnam As String = st & "_" & Format(kk, "000") & "_" & Format(kk1, "00") & ".prc"
                    objFS = New FileStream(AppDataPath & "\" & fnam, FileMode.Create, FileAccess.Write)
                    objBW = New BinaryWriter(objFS)

                    SaveInfo(objBW)


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
                    kk += 1
                Next k
            End If
            Me.Text = cap
            isSaving = False

            cmbRoad.Focus()
        Catch ex As Exception
            'MessageBox.Show(ex.ToString, "SaveDat2()")
        End Try
    End Sub

    Private Sub frmTest_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If Not isValidIn Then
            e.Handled = True
        End If
    End Sub
    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMCNO.KeyPress, txtName.KeyPress, txtDate.KeyPress, txtTime.KeyPress, txtDiv.KeyPress, txtKm.KeyPress, txtSec.KeyPress
        If Not isValidIn Then
            e.Handled = True
        End If
    End Sub
    Private Sub SetTextBox()
        Try
            If Panel1.Visible Then
                lblRecord.Visible = False
                cmbRecord.Visible = False
            Else
                lblRecord.Visible = True
                cmbRecord.Visible = True
            End If

            If curj >= 200 Then
                Select Case curj
                    Case 200 : txtEndKm.Focus() : txtEndKm.SelectionStart = txtEndKm.TextLength
                    Case 201 : txtEndMeter.Focus() : txtEndMeter.SelectionStart = txtEndMeter.TextLength
                    Case 202 : txtendTP.Focus() : txtEndKm.SelectionStart = txtEndKm.TextLength
                    Case 203 : txtTotKm.Focus() : txtTotKm.SelectionStart = txtTotKm.TextLength
                    Case 203 : curj = 202
                End Select
                Exit Sub
            End If
            Dim uplmt As Integer = 137
            If TotNch <= 5 Then uplmt = 125
            If Not Panel1.Visible Then
                If curj < 0 Then curj = 0
                If curj > 16 Then curj = 15
            Else
                If curj <= 110 Then curj = 110
                If curj > uplmt Then curj = uplmt
            End If
            If uped = -1 Then
                If curj = 2 Then curj = 0
                If curj = 133 Then curj = 132
                If TotNch > 5 Then
                    If Not isHand Then

                    End If
                Else
                    If curj = 114 Then curj = 113
                    If curj = 121 Then curj = 119
                    If curj = 123 Then curj = 122
                End If
            Else
                If curj = 1 Then curj = 3
                If curj = 138 Then curj = 139
                If TotNch > 5 Then
                    If Not isHand Then

                    End If
                Else
                    If curj = 114 Then curj = 115
                    If curj = 121 Then curj = 122
                    If curj = 123 Then curj = 124
                End If
            End If
            Select Case curj
                Case 0 : cmbSets.Focus()
                Case 1 : cmbRange1.Focus()
                Case 2 : cmbRange2.Focus()
                Case 3 : txtName.Focus() : txtName.SelectionStart = txtName.TextLength
                Case 4 : txtDate.Focus() : txtDate.SelectionStart = txtDate.TextLength
                Case 5 : txtTime.Focus() : txtTime.SelectionStart = txtTime.TextLength
                Case 6 : txtDiv.Focus() : txtDiv.SelectionStart = txtDiv.TextLength
                Case 7 : txtSec.Focus() : txtSec.SelectionStart = txtSec.TextLength
                Case 8 : txtKm.Focus() : txtKm.SelectionStart = txtKm.TextLength
                Case 9 : txtM.Focus() : txtM.SelectionStart = txtM.TextLength
                Case 10 : txtTP.Focus() : txtTP.SelectionStart = txtTP.TextLength
                Case 11 : cmbRail.Focus()
                Case 12 : cmbRoad.Focus()
                Case 13 : cmbrailtype.Focus()
                Case 14 : txtckm.Focus() : txtckm.SelectionStart = txtckm.TextLength
                Case 15 : txtcm.Focus() : txtcm.SelectionStart = txtcm.TextLength
                Case 16 : cmbRecord.Focus()
                Case 110 : txtKM2.Focus() : txtKM2.SelectionStart = txtKM2.TextLength
                Case 111 : txtMeter2.Focus() : txtMeter2.SelectionStart = txtMeter2.TextLength
                Case 112 : txtTP2.Focus() : txtTP2.SelectionStart = txtTP2.TextLength
                Case 113 : cmbLhRh.Focus()
                Case 114 : txtLoc1.Focus() : txtLoc1.SelectionStart = txtLoc1.TextLength
                Case 115 : cmbRWS.Focus()
                Case 116 : txtLoc2.Focus() : txtLoc2.SelectionStart = txtLoc2.TextLength
                Case 117 : txtLoc3.Focus() : txtLoc3.SelectionStart = txtLoc3.TextLength
                Case 118 : txtSta1.Focus() : txtSta1.SelectionStart = txtSta1.TextLength
                Case 119 : txtSta2.Focus() : txtSta2.SelectionStart = txtSta2.TextLength
                Case 120 : cmbMask1.Focus()
                Case 121 : cmbMask2.Focus()
                Case 122 : cmbMask3.Focus()
                Case 123 : txtMask4.Focus() : txtMask4.SelectionStart = txtMask4.TextLength
                Case 124 : cmbLR.Focus()
                Case 125 : cmbProbe.Focus()
                Case 126 : cmbTyp.Focus()
                Case 127 : cmbFLoc.Focus()
                Case 128 : txtlen.Focus() : txtlen.SelectionStart = txtlen.TextLength
                Case 129 : cmbClass.Focus()
                Case 130 : cmbCode.Focus()
                Case 131 : cmbCode2.Focus()
                Case 132 : txtPH2.Focus() : txtPH2.SelectionStart = txtPH2.TextLength
                Case 133 : txtHM2.Focus() : txtHM2.SelectionStart = txtHM2.TextLength
                Case 134 : cmbTyp2.Focus()
                Case 135 : cmbFLoc2.Focus()
                Case 136 : cmbClass2.Focus()
                Case 137 : txtRem.Focus() : txtRem.SelectionStart = txtRem.TextLength
                Case 138 : cmbCris.Focus()
            End Select

        Catch ex As Exception
            'MessageBox.Show(ex.Message(), "SetTextBox()")
        End Try
    End Sub

    Public Sub ShowControls(ByVal v As Boolean)
        cmbLR.Visible = v               '21
        cmbTyp.Visible = v              '23
        lblPrev.Visible = v
        lblTyp2.Visible = v
        cmbTyp2.Visible = v
        lblMenu4.Visible = v
        txtPH2.Visible = v
        lblHM2.Visible = v
        txtHM2.Visible = v
        lblLoc2.Visible = v
        cmbFLoc2.Visible = v
        lblClass2.Visible = v
        cmbClass2.Visible = v
        lblCode2.Visible = v
        cmbCode2.Visible = v
        lblMenu2.Top = lblDesc2.Top
        Label8.Top = lblDesc2.Top
        txtRem.Top = lblDesc2.Top
        cmbCode.Items.Clear()
        cmbCode.Items.Add("Yes")
        cmbCode.Items.Add("No")
        cmbFLoc.Items.Clear()
        cmbFLoc.Items.Add("HEAD")
        cmbFLoc.Items.Add("WEB")
        cmbFLoc.Items.Add("FLANGE")
        lblLoc.Text = "WELD"
        lblCode.Visible = False
        cmbCode.Visible = False
        lblDesc2.Visible = False
        txtLoc3.Visible = False
        lblTyp.Visible = False
        cmbTyp.Visible = False
        lblTyp2.Visible = False
        cmbTyp2.Visible = False
    End Sub
    Private Sub frmTest_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        IsKeyDown = False
    End Sub
    Private Sub setProbes()
        Try
            isHand = False
            If File.Exists(probes) Then
                Dim objSR As StreamReader = New StreamReader(probes)
                cmbProbe.Items.Clear()
                Dim data As String = ""
                Dim dataArr() As String
                Dim strCmbProbData As String = ""

                Do While Not objSR.EndOfStream
                    Try
                        data = objSR.ReadLine().ToString.Trim
                        If (data <> "") Then
                            dataArr = data.ToString.Trim.Split("~")
                            If (dataArr.Length = 1) Then
                                strCmbProbData = dataArr(0) & Chr(176)
                                cmbProbe.Items.Add(strCmbProbData)
                            ElseIf (dataArr.Length = 2) Then
                                strCmbProbData = dataArr(0) & Chr(176) & dataArr(1)
                                cmbProbe.Items.Add(strCmbProbData)
                            End If
                        End If

                    Catch ex As Exception
                        'MessageBox.Show(ex.ToString, "setProbes")
                    End Try

                Loop
                objSR.Close()
            Else
                Me.cmbProbe.Items.Clear()
                Me.cmbProbe.Items.Add("0°")
                Me.cmbProbe.Items.Add("70°CF")
                Me.cmbProbe.Items.Add("70°CB")
                Me.cmbProbe.Items.Add("37°CF")
                Me.cmbProbe.Items.Add("37°CB")
                Me.cmbProbe.Items.Add("70°GFF")
                Me.cmbProbe.Items.Add("70°GFB")
                Me.cmbProbe.Items.Add("70°NGF")
                Me.cmbProbe.Items.Add("70°NGB")
                Me.cmbProbe.Items.Add("70°")
                Me.cmbProbe.Items.Add("45°")
                Me.cmbProbe.Items.Add("2x45°")
                Me.cmbProbe.Items.Add("37°")

            End If
            cmbProbe.SelectedIndex = 0

        Catch ex As Exception
            'MessageBox.Show(ex.Message(),"SetProbes()")
        End Try
    End Sub

    Public Sub SortList1(ByVal cmbsets As ComboBox, Optional ByVal asc As Boolean = True)
        Try
            Dim i As Integer
            Dim n = cmbsets.Items.Count - 1
            If n = -1 Then Exit Sub
            Dim farr(0 To n)
            For i = 0 To n
                farr(i) = Convert.ToInt32(cmbsets.Items(i).ToString) ' Zumi
            Next i
            Array.Sort(farr)
            cmbsets.Items.Clear()
            If asc Then
                For i = 0 To farr.Length - 1
                    cmbsets.Items.Add(farr(i))
                Next i
            Else
                For i = farr.Length - 1 To 0 Step -1
                    cmbsets.Items.Add(farr(i))
                Next i
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message(), "cmbsets SortList1")
        End Try
    End Sub

    Private Sub frmTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            frm1StopProcessing = True
            Me.AutoScroll = False
            SetCursorPos(640, 460)
            isLoaded = False
            lblEndKm.Visible = False
            txtEndKm.Visible = False
            lblendm.Visible = False
            txtEndMeter.Visible = False
            Lblendtp.Visible = False
            txtendTP.Visible = False
            lblTotKm.Visible = False
            txtTotKm.Visible = False

            Me.Panel1.Visible = False
            Me.Panel1.Left = 0 : Me.Panel1.Top = lblOPName.Top
            Me.Width = mewidth : Me.Height = meheight
            Me.lblMenu1.Left = Me.Width - Me.lblMenu1.Width
            Me.lblMenu2.Left = Me.lblMenu1.Left
            Me.lblMenu3.Left = Me.lblMenu1.Left
            Me.lblMenu4.Left = Me.lblMenu1.Left
            Me.lblMenu5.Left = Me.lblMenu1.Left
            Me.lblMenu6.Left = Me.lblMenu1.Left
            Me.lblMenu7.Left = Me.lblMenu1.Left

            Me.lblMenu1.Top = lbl1top : Me.lblMenu1.Height = lbl1height
            Me.lblMenu2.Top = lbl2top : Me.lblMenu2.Height = lbl2height
            Me.lblMenu3.Top = lbl3top : Me.lblMenu3.Height = lbl3height
            Me.lblMenu4.Top = lbl4top : Me.lblMenu4.Height = lbl4height
            Me.lblMenu5.Top = lbl5top : Me.lblMenu5.Height = lbl5height
            Me.lblMenu6.Top = lbl6top : Me.lblMenu6.Height = lbl6height
            Me.lblMenu7.Top = lbl7top : Me.lblMenu7.Height = lbl7height

            If TotNch > 5 Then lblMenu2.Text = "Freeze" Else lblMenu2.Text = "Zoom"
            lblMenu3.Visible = False
            If TotNch <= 5 Then
                lblMenu3.Text = "Test2"
                lblMenu3.Visible = True
            Else
                lblMenu3.Text = "HndHld"
                lblMenu3.Visible = False
            End If
            Me.Text = "Test Setup"

            Dim objSR As StreamReader = New StreamReader(flawcodes)
            fllist = objSR.ReadToEnd
            objSR.Close()

            cmbRail.Items.Clear()
            If TotNch > 9 Then
                cmbRail.Items.Add("DRT")
                cmbLR.Items.Add("RIGHT")
                cmbLR.Items.Add("LEFT")
            ElseIf TotNch <= 5 Then
                cmbRail.Items.Add("RIGHT")
                cmbRail.Items.Add("LEFT")
                cmbLR.Items.Add("WT")
            Else
                cmbRail.Items.Add("RIGHT")
                cmbRail.Items.Add("LEFT")
                cmbLR.Items.Add("SRT")
            End If

            cmbrailtype.Items.Clear()
            cmbrailtype.Items.Add("60 kg")
            cmbrailtype.Items.Add("52 kg")
            cmbrailtype.Items.Add("90 R")
            cmbrailtype.Items.Add("0")

            cmbRecord.Items.Clear()
            cmbRecord.Items.Add("Log1")
            cmbRecord.Items.Add("Log2")

            cmbRail.SelectedIndex = 0
            cmbLR.SelectedIndex = 0
            cmbrailtype.SelectedIndex = 0
            ReadRecordType()

            If TotNch = 5 Then lblTotKm.Text = "Total Welds" Else lblTotKm.Text = "Total Kms"
            setProbes()
            cmbCris.Items.Add(" ")

            If File.Exists(probes2) Then
                objSR = New StreamReader(probes2)
                cmbCris.Items.Clear()
                Do While Not objSR.EndOfStream
                    cmbCris.Items.Add(objSR.ReadLine)
                Loop
                objSR.Close()
            End If

            cmbMask1.Items.Add(" ")

            If File.Exists(rollmark) Then
                objSR = New StreamReader(rollmark)
                cmbMask1.Items.Clear()
                Do While Not objSR.EndOfStream
                    cmbMask1.Items.Add(objSR.ReadLine)
                Loop
                objSR.Close()
            End If

            cmbClass.Items.Add(" ")
            cmbClass2.Items.Add(" ")

            If File.Exists(classes) Then
                objSR = New StreamReader(classes)
                cmbClass.Items.Clear()
                cmbClass2.Items.Clear()
                Do While Not objSR.EndOfStream
                    Dim stcls As String
                    stcls = objSR.ReadLine
                    cmbClass.Items.Add(stcls)
                    cmbClass2.Items.Add(stcls)
                Loop
                objSR.Close()
            End If

            txtMCNO.Text = Format(uno, "0000")          'MCNO 'Zaid
            If cmbRail.Items.Count > 1 Then cmbRail.SelectedIndex = 1

            cmbRail.SelectedIndex = 0
            cmbRoad.SelectedIndex = 0
            cmbrailtype.SelectedIndex = 0
            cmbMask1.SelectedIndex = 0
            cmbMask2.SelectedIndex = 0
            cmbLR.SelectedIndex = 0
            cmbProbe.SelectedIndex = 0
            cmbTyp.SelectedIndex = 0
            cmbFLoc.SelectedIndex = 0
            cmbClass.SelectedIndex = 0
            cmbCode.SelectedIndex = 0
            cmbTyp2.SelectedIndex = 0
            cmbFLoc2.SelectedIndex = 0
            cmbClass2.SelectedIndex = 0
            cmbCode2.SelectedIndex = 0
            cmbCris.SelectedIndex = 0
            cmbRange1.SelectedIndex = 0
            cmbRange2.SelectedIndex = cmbRange2.Items.Count - 1
            lblTest.Left = (mewidth - lblTest.Width) / 2
            Dim farr As String() = Directory.GetFiles(AppPath, "*.cnf")

            cmbSets.Items.Clear()
            Dim i As Integer, l As Integer, j As Integer
            For i = 0 To farr.Length - 1

                l = Len(AppPath) + 2
                j = InStr(farr(i), ".")
                SortList1(cmbSets, True)
                cmbSets.Items.Add(Mid$(farr(i), l, j - l))
            Next i
            curj = 0
            If cnfi <> -1 Then cmbSets.SelectedIndex = cnfi

            txtDate.SelectionStart = Len(txtDate.Text)
            txtTime.SelectionStart = Len(txtTime.Text)


            frmTest_UpdateEnd("Load")
            ReadInfo()
            current_kmupdate()
            PauseIt(1)
            isLoaded = True
            SetCursorPos(640, 460)
            curj = 0
            If TotNch <= 5 Then
                lblTyp.Visible = False
                cmbTyp.Visible = False
                lblCode.Visible = False
                cmbCode.Visible = False
                lblDesc2.Visible = False
                'previous
                lblPrev.Visible = False
                lblMenu4.Visible = False
                txtPH2.Visible = False
                lblHM2.Visible = False
                txtHM2.Visible = False
                lblTyp2.Visible = False
                cmbTyp2.Visible = False
                lblLoc2.Visible = False
                cmbFLoc2.Visible = False
                lblClass2.Visible = False
                cmbClass2.Visible = False
                lblCode2.Visible = False
                cmbCode2.Visible = False
                lblMenu5.Visible = False
                cmbCris.Visible = False
                lblMenu2.Visible = False
                txtRem.Visible = False
            End If

            'For Left & Right In Defect Saving Form 
            If cmbRail.SelectedItem.ToString.Trim = "RIGHT" Then
                cmbLhRh.SelectedIndex = 0
            ElseIf cmbRail.SelectedItem.ToString.Trim = "LEFT" Then
                cmbLhRh.SelectedIndex = 1
            End If

            SetTextBox()
            Application.DoEvents()

            'Probe File Adding Here
            If txtCh.Text.ToString.Trim = "1" Then
                cmbProbe.SelectedIndex = 0
            ElseIf txtCh.Text.ToString.Trim = "2" Then
                cmbProbe.SelectedIndex = 1
            ElseIf txtCh.Text.ToString.Trim = "3" Then
                cmbProbe.SelectedIndex = 2
            ElseIf txtCh.Text.ToString.Trim = "4" Then
                cmbProbe.SelectedIndex = 3
            ElseIf txtCh.Text.ToString.Trim = "5" Then
                cmbProbe.SelectedIndex = 4
            ElseIf txtCh.Text.ToString.Trim = "6" Then
                cmbProbe.SelectedIndex = 5
            ElseIf txtCh.Text.ToString.Trim = "7" Then
                cmbProbe.SelectedIndex = 6
            ElseIf txtCh.Text.ToString.Trim = "8" Then
                cmbProbe.SelectedIndex = 7
            ElseIf txtCh.Text.ToString.Trim = "9" Then
                cmbProbe.SelectedIndex = 8
            ElseIf txtCh.Text.ToString.Trim = "10" Then
                cmbProbe.SelectedIndex = 9
            End If


        Catch ex As Exception
            'MessageBox.Show(ex.ToString(), "Form2_Load()")
        End Try
    End Sub

    Private Function Description(ByVal cod As String) As String
        If Len(cod) = 0 Then Description = "" : Exit Function
        cod = cod & ","
        Dim i As Integer = InStr(fllist, cod)
        Dim j As Integer
        Dim st As String = ""
        If i <> 0 Then
            i += Len(cod)
            j = InStr(i, fllist, ",")
            st = Mid$(fllist, i, j - i)
            If IsNumeric(st) Or st = "-" Then
                i = j + 1
                j = InStr(i, fllist, ",")
                st = Mid$(fllist, i, j - i)
            End If
        End If
        Description = st
    End Function

    Private Sub SetParams(ByVal m1 As Single, ByVal m2 As Single, ByVal setrange As Boolean)
        cnfnam = cmbSets.Items(cmbSets.SelectedIndex)
        cnfnam = AppPath & "\" & cnfnam & ".cnf"
        cnfi = cmbSets.SelectedIndex
        OpenConfig()
        If setrange Then
            ScaleRange(m1, m2)
        End If
        WriteiWConfig()
    End Sub
    Public Sub ScaleRange(ByVal m1 As Single, ByVal m2 As Single)
        Dim i As Integer
        For i = 0 To DataArr.GetUpperBound(0)
            Dim rng As Single = DataArr(i, 2)
            DataArr(i, 1) = DataArr(i, 1) + ((m1 * rng) / 100)
            DataArr(i, 2) = DataArr(i, 2) * (m2 - m1) / 100
            DataArr(i, 4) = DataArr(i, 4) - ((m1 * rng) / 100)
            DataArr(i, 7) = DataArr(i, 7) - ((m1 * rng) / 100)
        Next i
    End Sub
    Private Sub txtName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtName.TextChanged
        txtName.Text = UCase(txtName.Text)
        txtName.SelectionStart = txtName.TextLength
    End Sub

    Private Sub txtSec_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSec.TextChanged
        txtSec.Text = UCase(txtSec.Text)
        txtSec.SelectionStart = txtSec.TextLength
    End Sub

    Private Sub txtDiv_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiv.TextChanged
        txtDiv.Text = UCase(txtDiv.Text)
        txtDiv.SelectionStart = txtDiv.TextLength
    End Sub

    Private Sub txtLoc1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        txtLoc1.Text = UCase(txtLoc1.Text)
        txtLoc1.SelectionStart = txtLoc1.TextLength
    End Sub

    Private Sub txtLoc2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        txtLoc2.Text = UCase(txtLoc2.Text)
        txtLoc2.SelectionStart = txtLoc2.TextLength
    End Sub

    Private Sub txtLoc3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        txtLoc3.Text = UCase(txtLoc3.Text)
        txtLoc3.SelectionStart = txtLoc3.TextLength
    End Sub

    Private Sub txtMask4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        txtMask4.Text = UCase(txtMask4.Text)
        txtMask4.SelectionStart = txtMask4.TextLength
    End Sub

    Private Sub txtPH2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        txtPH2.Text = UCase(txtPH2.Text)
        txtPH2.SelectionStart = txtPH2.TextLength
    End Sub

    Private Sub txtSta1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        txtSta1.Text = UCase(txtSta1.Text)
        txtSta1.SelectionStart = txtSta1.TextLength
    End Sub

    Private Sub txtSta2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        txtSta2.Text = UCase(txtSta2.Text)
        txtSta2.SelectionStart = txtSta2.TextLength
    End Sub

    Private Sub txtTP2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        txtTP2.Text = UCase(txtTP2.Text)
        txtTP2.SelectionStart = txtTP2.TextLength
    End Sub

    Private Sub txtKm_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKm.TextChanged
        txtKm.Text = UCase(txtKm.Text)
        txtKm.SelectionStart = txtKm.TextLength
    End Sub

    Private Sub cmbRail_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRail.SelectedIndexChanged
        If cmbRail.SelectedItem.ToString.Trim = "RIGHT" Then
            cmbLhRh.SelectedIndex = 0
        ElseIf cmbRail.SelectedItem.ToString.Trim = "LEFT" Then
            cmbLhRh.SelectedIndex = 1
        End If
    End Sub

    Private Sub txtTP_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTP.TextChanged
        txtTP.Text = UCase(txtTP.Text)
        txtTP.SelectionStart = txtTP.TextLength
        txtTP2.Text = txtTP.Text
    End Sub

    Private Sub txtLoc2_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtLoc2.Text = UCase(txtLoc2.Text)
        txtLoc2.SelectionStart = txtLoc2.TextLength
    End Sub

    Private Sub txtKM2_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtKM2.Text = UCase(txtKM2.Text)
        txtKM2.SelectionStart = txtKM2.TextLength
    End Sub

    Private Sub txtMeter2_TextChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtMeter2.Text = UCase(txtMeter2.Text)
        txtMeter2.SelectionStart = txtMeter2.TextLength
    End Sub

    Private Sub txtLoc1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtLoc1.Text = UCase(txtLoc1.Text)
        txtLoc1.SelectionStart = txtLoc1.TextLength
    End Sub

    Private Sub txtTP2_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtTP2.Text = UCase(txtTP2.Text)
        txtTP2.SelectionStart = txtTP2.TextLength
    End Sub

    Private Sub txtSta1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtSta1.Text = UCase(txtSta1.Text)
        txtSta1.SelectionStart = txtSta1.TextLength
    End Sub

    Private Sub txtSta2_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtSta2.Text = UCase(txtSta2.Text)
        txtSta2.SelectionStart = txtSta2.TextLength
    End Sub

    Private Sub txtLoc3_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtLoc3.Text = UCase(txtLoc3.Text)
        txtLoc3.SelectionStart = txtLoc3.TextLength
    End Sub

    Private Sub txtLoc1_TextChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLoc1.TextChanged
        txtLoc1.Text = UCase(txtLoc1.Text)
        txtLoc1.SelectionStart = txtLoc1.TextLength
    End Sub

    Private Sub txtLoc2_TextChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLoc2.TextChanged
        txtLoc2.Text = UCase(txtLoc2.Text)
        txtLoc2.SelectionStart = txtLoc2.TextLength
    End Sub

    Private Sub txtLoc3_TextChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLoc3.TextChanged
        Me.txtLoc3.Text = Format(mstr(1) + 0, "0000.00")
        txtLoc3.Text = UCase(txtLoc3.Text)
        txtLoc3.SelectionStart = txtLoc3.TextLength
    End Sub

    Private Sub txtSta1_TextChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSta1.TextChanged
        txtSta1.Text = UCase(txtSta1.Text)
        txtSta1.SelectionStart = txtSta1.TextLength
    End Sub

    Private Sub txtSta2_TextChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSta2.TextChanged
        txtSta2.Text = UCase(txtSta2.Text)
        txtSta2.SelectionStart = txtSta2.TextLength
    End Sub

    Private Sub txtKM2_TextChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKM2.TextChanged
        Me.txtKM2.Text = Format(mstr(0) + 0, "0000")
        txtKM2.Text = UCase(txtKM2.Text)
        txtKM2.SelectionStart = txtKM2.TextLength
    End Sub

    Private Sub txtMeter2_TextChanged_3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtMeter2.Text = UCase(txtMeter2.Text)
        txtMeter2.SelectionStart = txtMeter2.TextLength
    End Sub

    Private Sub cmbCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCode.SelectedIndexChanged
        Me.lblDesc2.Text = Description(cmbCode.Text) 'SRT
    End Sub

    Private Sub txtRem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRem.TextChanged
        txtRem.Text = UCase(txtRem.Text)
        txtRem.SelectionStart = txtRem.TextLength
    End Sub

    Private Sub txtMeter2_TextChanged_4(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMeter2.TextChanged
        txtMeter2.Text = UCase(txtMeter2.Text)
        txtMeter2.SelectionStart = txtMeter2.TextLength
    End Sub

    Private Sub txtTP2_TextChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTP2.TextChanged
        txtTP2.Text = UCase(txtTP2.Text)
        txtTP2.SelectionStart = txtTP2.TextLength
    End Sub

    Private Sub txtMask4_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMask4.TextChanged
        txtMask4.Text = UCase(txtMask4.Text)
        txtMask4.SelectionStart = txtMask4.TextLength
    End Sub

    Private Sub lblTest_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTest.ParentChanged

    End Sub

    Private Sub lblLoc2_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLoc2.ParentChanged

    End Sub

    Private Sub cmbFLoc2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFLoc2.SelectedIndexChanged

    End Sub

    Private Sub Label15_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.ParentChanged

    End Sub
End Class
