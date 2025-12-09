Imports System.IO
Imports System
Imports System.Windows
Imports System.Windows.Forms
Imports System.Drawing
Imports Microsoft.VisualBasic
Imports System.Threading
Public Class frmView
#Const TORA = 1
    Public bmp As Bitmap
    Public isstop As Boolean
    Public foffset As Integer
    Public log_offset As Integer
    Public isOpen As Boolean
    Public showgraph As Boolean
    Dim objFS As FileStream
    Dim objBR As BinaryReader
    Dim gRm2 As Integer
    Dim gRm2be As Integer
    Dim gLm2 As Integer
    Dim gTm As Integer
    Dim gBm As Integer
    Dim upt As Integer
    Dim pmax As Integer
    Dim splitch As Integer
    Dim pt0() As Point, pt1() As Point
    Dim v20() As Byte, v21() As Byte
    Dim g1st As Integer, g1wd As Integer
    Dim objBlackPen As Pen = New Pen(Color.White)
    Dim logfilename As String = ""
    Dim logfoldername As String = ""
    Dim upt2 As Integer = 0
    Dim GpsLocation As New clsGpsLocation
    Dim MoveDataOffset As Boolean
    Dim strtj As Integer, endj As Integer
    Dim gobjPens(10) As Pen

    Dim Odometer As Double
    Dim objGraphics As Graphics
    Dim bmp1 As Bitmap
    Dim bmp2 As Bitmap
    Dim dispChAll As Boolean
    Dim dispCh1 As Boolean
    Dim dispCh2 As Boolean
    Dim dispCh3 As Boolean
    Dim dispCh4 As Boolean
    Dim dispCh5 As Boolean
    Dim dispCh6 As Boolean
    Dim dispCh7 As Boolean
    Dim dispCh8 As Boolean
    Dim dispCh9 As Boolean
    Dim dispCh10 As Boolean
    Dim dispDown As Boolean
    Dim OdometerVal As Decimal
    Dim PreOdometerVal As Decimal

    Dim UpdatedispChAll As Boolean
    Dim UpdatedispCh1 As Boolean
    Dim UpdatedispCh2 As Boolean
    Dim UpdatedispCh3 As Boolean
    Dim UpdatedispCh4 As Boolean
    Dim UpdatedispCh5 As Boolean
    Dim UpdatedispCh6 As Boolean
    Dim UpdatedispCh7 As Boolean
    Dim UpdatedispCh8 As Boolean
    Dim UpdatedispCh9 As Boolean
    Dim UpdatedispCh10 As Boolean

    Dim ZTest As Integer = 0
    Dim gtestitr As Integer = 0
    Dim gPause As Boolean
    Dim gRestart As Boolean
    Dim Form5Loaded As Boolean = False

    Dim frm4unit As String
    Dim filelist(5) As String
    Dim folderlist(5) As String
    Dim unitlist(5) As String
    Dim unitselecteditem As Integer
    Dim folderselecteditem As Integer
    Dim fileselecteditem As Integer
    Dim numberoffiles As Integer
    Dim refreshupdate As Integer
    Private m_GraphThread As Thread
    Dim gridbmp As Bitmap

    Dim fcount As Integer
    Dim PlayNextFile As Boolean

    Dim g1stlinex1(TotNch) As Integer
    Dim g1wdliney1(TotNch) As Integer
    Dim g1stlinex2(TotNch) As Integer
    Dim Th(TotNch) As Integer

    Dim g1stlinex1ch1 As Integer
    Dim g1wdliney1ch1 As Integer
    Dim g1stlinex2ch1 As Integer
    Dim gspeed() As Integer = {500, 450, 400, 350, 300, 250, 200, 150, 100, 0}
    Dim gfreeze As Boolean

    Dim gfreezeFirstTime As Boolean
    Dim gfreezestarted As Boolean
    Dim gisfreezeNext As Boolean
    Dim itr As Integer = 0
    Dim Hm As Integer
    Dim HmMax As Integer

    Public ReadOnly WaitEvent As New ManualResetEvent(True)



    Private Sub frmView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim k As Integer
        k = e.KeyCode

        Select Case k
            Case FKeyLR 'pause  





            Case FKeyRun 'channelall
                For i = 1 To ChanActive.GetUpperBound(0)
                    ChanActive(i) = False
                Next
                ChanActive(0) = True
                frm8lbl_ch.Text = "ALL"
                dispChAll = True
                dispCh1 = False
                dispCh2 = False
                dispCh3 = False
                dispCh4 = False
                dispCh5 = False
                dispCh6 = False
                dispCh7 = False
                dispCh8 = False
                dispCh9 = False
                dispCh10 = False
                UpdatedispChAll = True
                UpdatedispCh1 = False
                UpdatedispCh2 = False
                UpdatedispCh3 = False
                UpdatedispCh4 = False
                UpdatedispCh5 = False
                UpdatedispCh6 = False
                UpdatedispCh7 = False
                UpdatedispCh8 = False
                UpdatedispCh9 = False
                UpdatedispCh10 = False

            Case MKey1 'channel1
                frm8lbl_ch.Text = "1"
                For i = 0 To ChanActive.GetUpperBound(0)
                    ChanActive(i) = False
                Next
                ChanActive(1) = True


                dispChAll = False
                dispCh1 = True
                dispCh2 = False
                dispCh3 = False
                dispCh4 = False
                dispCh5 = False
                dispCh6 = False
                dispCh7 = False
                dispCh8 = False
                dispCh9 = False
                dispCh10 = False

                UpdatedispChAll = False
                UpdatedispCh1 = True
                UpdatedispCh2 = False
                UpdatedispCh3 = False
                UpdatedispCh4 = False
                UpdatedispCh5 = False
                UpdatedispCh6 = False
                UpdatedispCh7 = False
                UpdatedispCh8 = False
                UpdatedispCh9 = False
                UpdatedispCh10 = False


            Case MKey2 'channel2
                frm8lbl_ch.Text = "2"
                For i = 0 To ChanActive.GetUpperBound(0)
                    ChanActive(i) = False
                Next
                ChanActive(2) = True


                dispChAll = False
                dispCh1 = False
                dispCh2 = True
                dispCh3 = False
                dispCh4 = False
                dispCh5 = False
                dispCh6 = False
                dispCh7 = False
                dispCh8 = False
                dispCh9 = False
                dispCh10 = False

                UpdatedispChAll = False
                UpdatedispCh1 = False
                UpdatedispCh2 = True
                UpdatedispCh3 = False
                UpdatedispCh4 = False
                UpdatedispCh5 = False
                UpdatedispCh6 = False
                UpdatedispCh7 = False
                UpdatedispCh8 = False
                UpdatedispCh9 = False
                UpdatedispCh10 = False



            Case MKey3 'channel3
                frm8lbl_ch.Text = "3"
                For i = 0 To ChanActive.GetUpperBound(0)
                    ChanActive(i) = False
                Next
                ChanActive(3) = True
                dispChAll = False
                dispCh1 = False
                dispCh2 = False
                dispCh3 = True
                dispCh4 = False
                dispCh5 = False
                dispCh6 = False
                dispCh7 = False
                dispCh8 = False
                dispCh9 = False
                dispCh10 = False

                UpdatedispChAll = False
                UpdatedispCh1 = False
                UpdatedispCh2 = False
                UpdatedispCh3 = True
                UpdatedispCh4 = False
                UpdatedispCh5 = False
                UpdatedispCh6 = False
                UpdatedispCh7 = False
                UpdatedispCh8 = False
                UpdatedispCh9 = False
                UpdatedispCh10 = False



            Case MKey4 'channel4
                frm8lbl_ch.Text = "4"
                For i = 0 To ChanActive.GetUpperBound(0)
                    ChanActive(i) = False
                Next
                ChanActive(4) = True
                dispChAll = False
                dispCh1 = False
                dispCh2 = False
                dispCh3 = False
                dispCh4 = True
                dispCh5 = False
                dispCh6 = False
                dispCh7 = False
                dispCh8 = False
                dispCh9 = False
                dispCh10 = False

                UpdatedispChAll = False
                UpdatedispCh1 = False
                UpdatedispCh2 = False
                UpdatedispCh3 = False
                UpdatedispCh4 = True
                UpdatedispCh5 = False
                UpdatedispCh6 = False
                UpdatedispCh7 = False
                UpdatedispCh8 = False
                UpdatedispCh9 = False
                UpdatedispCh10 = False

            Case MKey5 'channel5
                frm8lbl_ch.Text = "5"
                For i = 0 To ChanActive.GetUpperBound(0)
                    ChanActive(i) = False
                Next
                ChanActive(5) = True
                dispChAll = False
                dispCh1 = False
                dispCh2 = False
                dispCh3 = False
                dispCh4 = False
                dispCh5 = True
                dispCh6 = False
                dispCh7 = False
                dispCh8 = False
                dispCh9 = False
                dispCh10 = False

                UpdatedispChAll = False
                UpdatedispCh1 = False
                UpdatedispCh2 = False
                UpdatedispCh3 = False
                UpdatedispCh4 = False
                UpdatedispCh5 = True
                UpdatedispCh6 = False
                UpdatedispCh7 = False
                UpdatedispCh8 = False
                UpdatedispCh9 = False
                UpdatedispCh10 = False


            Case MKey6 'channel6 
                frm8lbl_ch.Text = "6"
                For i = 0 To ChanActive.GetUpperBound(0)
                    ChanActive(i) = False
                Next
                ChanActive(6) = True
                dispChAll = False
                dispCh1 = False
                dispCh2 = False
                dispCh3 = False
                dispCh4 = False
                dispCh5 = False
                dispCh6 = True
                dispCh7 = False
                dispCh8 = False
                dispCh9 = False
                dispCh10 = False

                UpdatedispChAll = False
                UpdatedispCh1 = False
                UpdatedispCh2 = False
                UpdatedispCh3 = False
                UpdatedispCh4 = False
                UpdatedispCh5 = False
                UpdatedispCh6 = True
                UpdatedispCh7 = False
                UpdatedispCh8 = False
                UpdatedispCh9 = False
                UpdatedispCh10 = False


            Case MKey7 'channel7
                frm8lbl_ch.Text = "7"
                For i = 0 To ChanActive.GetUpperBound(0)
                    ChanActive(i) = False
                Next
                ChanActive(7) = True
                dispChAll = False
                dispCh1 = False
                dispCh2 = False
                dispCh3 = False
                dispCh4 = False
                dispCh5 = False
                dispCh6 = False
                dispCh7 = True
                dispCh8 = False
                dispCh9 = False
                dispCh10 = False

                UpdatedispChAll = False
                UpdatedispCh1 = False
                UpdatedispCh2 = False
                UpdatedispCh3 = False
                UpdatedispCh4 = False
                UpdatedispCh5 = False
                UpdatedispCh6 = False
                UpdatedispCh7 = True
                UpdatedispCh8 = False
                UpdatedispCh9 = False
                UpdatedispCh10 = False

            Case MKey8 'channel8
                frm8lbl_ch.Text = "8"
                For i = 0 To ChanActive.GetUpperBound(0)
                    ChanActive(i) = False
                Next
                ChanActive(8) = True
                dispChAll = False
                dispCh1 = False
                dispCh2 = False
                dispCh3 = False
                dispCh4 = False
                dispCh5 = False
                dispCh6 = False
                dispCh7 = False
                dispCh8 = True
                dispCh9 = False
                dispCh10 = False

                UpdatedispChAll = False
                UpdatedispCh1 = False
                UpdatedispCh2 = False
                UpdatedispCh3 = False
                UpdatedispCh4 = False
                UpdatedispCh5 = False
                UpdatedispCh6 = False
                UpdatedispCh7 = False
                UpdatedispCh8 = True
                UpdatedispCh9 = False
                UpdatedispCh10 = False

            Case MKey9 'channel9
                frm8lbl_ch.Text = "9"
                For i = 0 To ChanActive.GetUpperBound(0)
                    ChanActive(i) = False
                Next
                ChanActive(9) = True
                dispChAll = False
                dispCh1 = False
                dispCh2 = False
                dispCh3 = False
                dispCh4 = False
                dispCh5 = False
                dispCh6 = False
                dispCh7 = False
                dispCh8 = False
                dispCh9 = True
                dispCh10 = False

                UpdatedispChAll = False
                UpdatedispCh1 = False
                UpdatedispCh2 = False
                UpdatedispCh3 = False
                UpdatedispCh4 = False
                UpdatedispCh5 = False
                UpdatedispCh6 = False
                UpdatedispCh7 = False
                UpdatedispCh8 = False
                UpdatedispCh9 = True
                UpdatedispCh10 = False

            Case FKeyUp 'freeze


            Case FKeyDn

            Case FkeyLf 'decreament
                fflag = True

            Case FkeyRt 'increament
                fflag = True


            Case FKeySave 'freezesave





            Case EsKey
                Me.Close()
        End Select


    End Sub
    Private Sub frmView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReDim filelist(frmLog.ListBox2.Items.Count)
        ReDim folderlist(frmLog.ListBox1.Items.Count)

        'MessageBox.Show("5")
        'MessageBox.Show(frmLog.ListBox2.Items.Count.ToString())
        'MessageBox.Show(frmLog.ListBox1.Items.Count.ToString())

        numberoffiles = frmLog.ListBox2.Items.Count
        'Change the Channel button color based on the config.txt file


        'Copy the Folder  
        For i = 0 To frmLog.ListBox1.Items.Count - 1
            folderlist(i) = frmLog.ListBox1.Items(i)
            'MessageBox.Show(filelist(i).ToString())
        Next

        'Copy the  Filelist
        For i = 0 To frmLog.ListBox2.Items.Count - 1
            filelist(i) = frmLog.ListBox2.Items(i)
            'MessageBox.Show(filelist(i).ToString())
        Next

        folderselecteditem = frmLog.ListBox1.SelectedIndex
        fileselecteditem = frmLog.ListBox2.SelectedIndex
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None

        gfreeze = False
        gfreezeFirstTime = True
        gfreezestarted = False
        gisfreezeNext = False
        Hm = 0
        HmMax = 0
        itr = 0
        'AppPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.GetName.CodeBase)
        AppPath = "\SD Card"
        'MessageBox.Show(FrmWidth.ToString())
        'MessageBox.Show(FrmHeight.ToString())
        ' Start the Ploting Thread
        DrawGraph()
    End Sub

    Private Sub DrawGraph()
        Try
            Dim ai As Integer
            Dim aj As Integer

            bmp = New Bitmap(Me.Width, Me.Height)
            'bmp = New Bitmap(FrmWidth, FrmHeight)
            Dim strPath1 As String
            strPath1 = AppPath & "\grid.bmp"

            ' ''MessageBox.Show(strPath1.ToString(), "strPath1")

            gridbmp = New Bitmap(strPath1)
            objGraphics = Graphics.FromImage(bmp)

            ' picGraph.Image = gridbmp




            OdometerVal = 0.0
            PreOdometerVal = 0.0
            isstop = False
            foffset = 0
            isOpen = False
            showgraph = False
            dispChAll = True
            dispCh1 = False
            dispCh2 = False
            dispCh3 = False
            dispCh4 = False
            dispCh5 = False
            dispCh6 = False
            dispCh7 = False
            dispCh8 = False
            dispCh9 = False
            dispCh10 = False
            dispDown = False

            'UpdatedispChAll = False
            UpdatedispChAll = True
            UpdatedispCh1 = False
            UpdatedispCh2 = False
            UpdatedispCh3 = False
            UpdatedispCh4 = False
            UpdatedispCh5 = False
            UpdatedispCh6 = False
            UpdatedispCh7 = False
            UpdatedispCh8 = False
            UpdatedispCh9 = False
            UpdatedispCh10 = False

            ChanActive(0) = True

            For i = 1 To ChanActive.GetUpperBound(0)
                ChanActive(i) = False
            Next

            gPause = False
            gRestart = False

            'Log data Start offset
            log_offset = 100
            MoveDataOffset = False

            ' Clearing the BScan buffer
            For ai = 0 To BSCANBUFF1.GetUpperBound(0)
                For aj = 0 To BSCANBUFF1.GetUpperBound(1) - 1
                    BSCANBUFF1(ai, aj) = 0
                Next aj
            Next ai

            ' Read the config.txt file
            ReadConfigFile()
            logfilename = AppPath & "\Logs" & "\" & folderlist(folderselecteditem) & "\" & filelist(fileselecteditem)
            AcquireFreezeData(1)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LogDataFolderView(Optional ByVal gtype As Integer = 2)
        ' ''MessageBox.Show("LogDataFolderView")

        'For fcount = 0 To numberoffiles - 1
        fcount = 0
        Do While True
            logfilename = AppPath & "\Logs" & "\" & folderlist(folderselecteditem)
            logfilename = logfilename & "\" & filelist(fcount)
            AcquireFreezeData(2)
        Loop
        'Next


    End Sub
    Public Sub ReadConfigFile()
        'MessageBox.Show("ReadConfigFile")
        Dim Configfile As String
        Dim configData As String
        'Read the config file
        'Configfile = logfilename & "\" & folderlist(folderselecteditem)
        Configfile = AppPath & "\Logs" & "\" & folderlist(folderselecteditem)
        ' MessageBox.Show(Configfile.ToString())
        Configfile = Configfile & "\config.txt"
        ' MessageBox.Show(Configfile.ToString())
        Dim configReader As StreamReader = New StreamReader(Configfile)
        For i = 0 To DArr.GetUpperBound(0)
            configData = configReader.ReadLine
            ' MessageBox.Show(configData, "cdata")
            Dim st1() As String = Split(configData, ",")
            For j = 0 To DArr.GetUpperBound(1)
                DArr(i, j) = st1(j)
            Next
            gobjPens(i) = New Pen(colours(Convert.ToInt32(st1(10)) Mod 10), 2)
        Next

        configReader.Close()

    End Sub



    Private Sub DrawFixedFrame()

        Dim Sy As Single = (198 - 15) / 256
        Dim i As Integer
        Dim mode() As Integer = {6, 6, 9, 24, 27, 30, 33} 'Change
        objGraphics.DrawImage(gridbmp, 0, 0)
        ' If gfreeze = False Then
        'If ChanActive(0) = True Then
        ' Draw Gate line for the appropriate ch
        For i = 0 To splitch
            If g1stlinex1(i) <> -1 Then
                objGraphics.DrawLine(gobjPens(i), g1stlinex1(i), g1wdliney1(i), g1stlinex2(i), g1wdliney1(i))
                If (i = 0) Then
                    objGraphics.DrawLine(gobjPens(i), g1stlinex1ch1, g1wdliney1ch1, g1stlinex2ch1, g1wdliney1ch1)
                End If
            End If
        Next i
        For i = splitch + 1 To DArr.GetUpperBound(0)
            If g1stlinex1(i) <> -1 Then
                objGraphics.DrawLine(gobjPens(i), g1stlinex1(i), g1wdliney1(i), g1stlinex2(i), g1wdliney1(i))
            End If
        Next i
        ' Else
        ' Draw Gate line for the appropriate ch
        For i = 0 To TotNch
            If g1stlinex1(i) <> -1 Then
                objGraphics.DrawLine(gobjPens(i), g1stlinex1(i), g1wdliney1(i), g1stlinex2(i), g1wdliney1(i))
                If (i = 0) Then
                    objGraphics.DrawLine(gobjPens(i), g1stlinex1ch1, g1wdliney1ch1, g1stlinex2ch1, g1wdliney1ch1)
                End If
            End If
        Next i
        ' End If
        ' End If

    End Sub

    Private Sub OpenReadAndPlotData()
        'MessageBox.Show("OpenReadAndPlotData")
        Dim i As Integer
        Dim i2 As Integer
        Dim vi As Integer
        Dim offset As Integer
        Dim npoints As Integer
        Dim Meter As Double = 0
        Dim Lstr(25) As Char
        Dim Val As Short
        Dim x As Byte
        Dim r As Byte
        Dim kk As Integer
        Dim FileLength As Integer
        Dim ReadLength As Integer
        ZTest = 0

        If isOpen = False Then

            'Open the log file
            objFS = New FileStream(logfilename, FileMode.Open, FileAccess.Read)
            ' ''MessageBox.Show(logfilename.ToString(), "logfilename")
            'objFS.Seek(log_offset, SeekOrigin.Current)
            objFS.Seek(4096, SeekOrigin.Current)
            objBR = New BinaryReader(objFS)
            FileLength = objBR.BaseStream.Length
            If FileLength = 0 Then
                objFS.Close()
                objBR.Close()
                Exit Sub
            End If

            isOpen = True
            MoveDataOffset = True
            itr = 0
        End If

        strtj = 0
        endj = TotNch
        Odometer = 0.0
        PreOdometerVal = 0.0

        'Update Meter 
        UpdateMeter()

        'Update KM
        UpdateKM()


        i = 0
        Dim ReadByte As Byte
        Dim Val1 As Char
        Dim Val2 As Char
        Dim ReadByte1 As Byte, ReadByte2 As Byte


        ' Read Longitude 
        Do While True
            ReadByte1 = objBR.ReadByte
            Val1 = Convert.ToChar(ReadByte1)
            ReadByte2 = objBR.ReadByte
            Val2 = Convert.ToChar(ReadByte2)
            Lstr(i) = Val2
            i += 1
            Lstr(i) = Val1
            If ReadByte1 = 0 Or ReadByte2 = 0 Then
                Exit Do
            End If
            i += 1
        Loop

        ' Read Direction
        ReadByte = objBR.ReadByte
        If ReadByte = 0 Then
            ReadByte = objBR.ReadByte
        Else
            ReadByte1 = objBR.ReadByte
        End If
        ' ReadByte1 = objBR.ReadByte
        If ReadByte <> 0 Then
            Dim LgStr As String = New String(Lstr)
            Dim LgDec As Double = Convert.ToDecimal(LgStr)
            Dim LgStrLde As String = ToDMS(LgDec) & " " & Convert.ToChar(ReadByte)
            'lonvlbl.Text = LgStrLde
            '  ''MessageBox.Show(LgStrLde)
            lbllong.Text = LgStrLde



        Else
            lbllong.Text = "0°0'0.00"""
        End If
        'MessageBox.Show(StrLatitude)

        ReadByte = 0
        For i = 0 To Lstr.GetUpperBound(0)
            Lstr(i) = Convert.ToChar(ReadByte)

        Next
        i = 0

        'ReadByte1 = objBR.ReadByte
        'Read Latitude
        Do While True

            ReadByte1 = objBR.ReadByte
            Val1 = Convert.ToChar(ReadByte1)
            ReadByte2 = objBR.ReadByte
            Val2 = Convert.ToChar(ReadByte2)
            Lstr(i) = Val2
            i += 1
            Lstr(i) = Val1
            If ReadByte1 = 0 Or ReadByte2 = 0 Then
                Exit Do
            End If
            i += 1
        Loop

        ' Read Direction
        ReadByte = objBR.ReadByte
        If ReadByte = 0 Then
            ReadByte = objBR.ReadByte
        End If
        If ReadByte <> 0 Then

            Dim Str1 As String = New String(Lstr)
            Dim LDec As Decimal = Convert.ToDecimal(Str1)
            Dim StrLde As String = GpsLocation.ToDMS(LDec) & " " & Convert.ToChar(ReadByte)
            latvlbl.Text = StrLde

        Else
            latvlbl.Text = "0°0'0.00"""
        End If
        ReadByte = objBR.ReadByte

        'Update Date
        Dim DateSplit() As String = Split(filelist(fileselecteditem), "_")
        datevlbl.Text = DateSplit(3).Replace("d", "") & "/"
        datevlbl.Text = datevlbl.Text & DateSplit(4).Replace("m", "") & "/"
        datevlbl.Text = datevlbl.Text & DateSplit(5).Replace("y", "")

        tvlbl.Text = DateSplit(6).Replace("h", "") & ":"
        tvlbl.Text = tvlbl.Text & DateSplit(7).Replace("m", "") & ":"
        tvlbl.Text = tvlbl.Text & DateSplit(8).Replace("s", "")

        ' Get the KiloMeter Data

        For j = strtj To endj
            upt2 += (DArr(j, 1) + 1)
        Next

        ReDim v20(upt2)

        If MoveDataOffset = True Then
            objFS.Seek((curi * 4096), SeekOrigin.Current)

            MoveDataOffset = False
        End If





        'pmax = 172
        'gTm = 25
        'gBm = gTm + pmax
        'gLm2 = 0
        'gRm2 = gLm2 + 500
        i2 = 0
        'Dim itr As Integer = 0
        Do While True
            strtj = 0
            endj = 9
            Application.DoEvents()
            'If gPause = True Then

            '    btnpause.Text = "Resume"
            '    btnrestart.Enabled = True
            '    lblstatus.Text = "Status : Paused..."
            '    btninc.Enabled = True
            '    btndec.Enabled = True
            '    btnpause.Enabled = True
            '    If ChanActive(0) <> True Then
            '        'chkbfrz.Enabled = True
            '    End If
            '    Do While True
            '        If gPause = False Then
            '            Exit Do
            '        End If
            '        Application.DoEvents()
            '        'Threading.Thread.Sleep(500)

            '    Loop
            '    If (gfreeze = False) Then
            '        'btnpause.Text = "Pause"
            '        'btnrestart.Enabled = False
            '        'lblstatus.Text = "Status : Running..."
            '        'btninc.Enabled = False
            '        'btndec.Enabled = False
            '        'btnpause.Enabled = True
            '    Else
            '        'lblstatus.Text = "Status : Freeze..."
            '        'btnrestart.Enabled = False
            '        'btninc.Enabled = False
            '        'btndec.Enabled = False
            '    End If
            'End If

            'If isstop = True Then
            '    'isstop = False
            '    Exit Do
            'End If

            ''Wait for the Freeze Event
            'If (gfreeze = True) Then
            '    'Wait until event received
            '    If gisfreezeNext = True Then

            '    Else
            '        itr -= 16
            '        If itr <= 0 Then
            '            itr = 0
            '            lblstatus.Text = "Status : Freeze Reached SOF"
            '            Do While True
            '                Threading.Thread.Sleep(5000)
            '            Loop
            '        End If
            '    End If
            '    'Threading.Thread.Sleep(100)
            '    If chkbfrz.Checked = False Then
            '        WaitEvent.WaitOne()
            '        WaitEvent.Reset()
            '    End If

            'End If
            ' ''MessageBox.Show("y01")
            ReDrawAllCh()
            'If (UpdatedispChAll = True) Then
            '    ReDrawAllCh()
            'ElseIf (UpdatedispCh1 = True) Then
            '    ReDrawCh(1)
            'ElseIf (UpdatedispCh2 = True) Then
            '    ReDrawCh(2)
            'ElseIf (UpdatedispCh3 = True) Then
            '    ReDrawCh(3)
            'ElseIf (UpdatedispCh4 = True) Then
            '    ReDrawCh(4)
            'ElseIf (UpdatedispCh5 = True) Then
            '    ReDrawCh(5)
            'ElseIf (UpdatedispCh6 = True) Then
            '    ReDrawCh(6)
            'ElseIf (UpdatedispCh7 = True) Then
            '    ReDrawCh(7)
            'End If
            ' ''MessageBox.Show("y0")
            For i = 0 To v20.GetUpperBound(0)
                v20(i) = 0
            Next i
            ' ''MessageBox.Show("y1")
            'If gfreeze = False Then
            ' ''MessageBox.Show("y2")
            ' DrawFixedFrame()
            ' Else
            ' ClearBScanWindow()
            ' If gfreezeFirstTime = True Then
            'gfreezeFirstTime = False
            '
            DrawFixedFrame()
            'End If
            'End If

            ''objGraphicsFrm.DrawImage(bmp, 0, 0)

            i2 = 0
            Dim res As Integer
            For j = strtj To endj

                'If j > 9 Then j1 = j + 1 Else j1 = j
                upt = DArr(j, 1)
                r = DArr(j, 3)
                ' itr = itr + 1
                res = DArr(j, 2)
                vi = (res * 2) + (8192 * itr)

                'itr = itr + 7
                itr = itr + 1
                'If (j = 6) Then
                '    itr = itr + 9
                'End If

                offset = vi - 1 : npoints = upt

                vi = upt

                ReadLength = ReadLength + (8192 * j)
                ' Read the data from the File

                'objFS.Seek(offset, SeekOrigin.Begin)

                kk = 8
                '  ''MessageBox.Show("y7")

                For i = offset To offset + upt

                    ReadByte = objBR.ReadByte()

                    ReadByte = objBR.ReadByte()

                    BLOCKREADINFO(kk) = ReadByte       '0

                    If BLOCKREADINFO(kk) > r Then
                        Val = 0
                    End If
                    kk = kk + 1
                Next i

                ' Copy to the process array v20 if the raw data is greater than reject value
                For i = 0 To upt - 1 Step 1
                    x = BLOCKREADINFO(12 + i)
                    If x > r And x > v20(i2) Then
                        v20(i2) = x

                        ' ''MessageBox.Show("y7.1")
                        'Else
                        'v20(i2) = 0
                    End If
                    i2 += 1
                Next i

                'MessageBox.Show("y7.2")
            Next j
            'MessageBox.Show("y7.3")

            'MessageBox.Show(v20.ToString, "v20")
            'MessageBox.Show(curi.ToString, "curi")
            PlotCurvesT(v20, curi)


            'Threading.Thread.Sleep(500)
            'itr = itr + 8
            itr = itr + 1
            If (FileLength <= (objFS.Position + (128 * 1024))) Or (gRestart = True) Or (PlayNextFile = True) Then
                isOpen = False
                objFS.Close()
                objBR.Close()
                If gRestart = True Then
                    '  lblstatus.Text = "Status : Stopped..."
                End If
                Exit Do
            End If
            offset = (8192 * itr) + 4096
            objFS.Seek(offset, SeekOrigin.Begin)
            UpdateMeter()
            UpdateKM()
            If (gfreeze = True) Then
                '   lblfrzprev.Enabled = True
                '   lblfrznext.Enabled = True
            End If

        Loop

    End Sub

    Private Sub UpdateMeter()

        Dim MeterIntup As Integer
        Dim MeterIntlow As Integer
        Dim MeterDecup As Integer
        Dim MeterDeclow As Integer
        Dim Meter As Double = 0

        ' Get the Meter Data
        MeterIntup = objBR.ReadUInt16
        MeterIntlow = objBR.ReadUInt16
        MeterIntup = ((MeterIntup << 16)) Or MeterIntlow
        MeterDecup = objBR.ReadInt16
        MeterDeclow = objBR.ReadInt16
        MeterDecup = (MeterDecup << 16) + MeterDeclow
        Meter = MeterDecup / 1000000
        Meter = Meter + MeterIntup

        Meter = Meter / 1000
        frm8mvlbl.Text = Meter.ToString("N2")

        OdometerVal = Math.Round(Meter, 3)
        If PreOdometerVal = 0.0 Then
            PreOdometerVal = Math.Round(Meter, 3)
        End If

    End Sub
    Private Sub UpdateKM()
        Dim KMeter As Integer
        Dim KMeterup As Integer

        KMeter = objBR.ReadInt16
        KMeterup = objBR.ReadInt16
        KMeter = KMeter << 16 Or KMeterup

        frm8kmvlabel.Text = KMeter.ToString()
    End Sub


    Private Sub PlotCurvesT(ByRef v() As Byte, Optional ByVal chnl As Integer = -1, Optional ByVal fillpoly As Boolean = False, Optional ByVal zoom As Single = 1.0)
        'MessageBox.Show("PlotCurvesT")
        Dim i2 As Integer
        Dim strtuhj As Integer
        Dim enduhj As Integer
        Dim strtlhj As Integer
        Dim endlhj As Integer
        Dim r As Integer
        Dim vv As Integer
        Dim i3 As Integer

        Dim Movingoffset As Integer

        Dim Channel_Angle As Double
        Dim x_index1 As Double
        Dim BScan_data As Double
        Dim X_val As Integer
        Dim ai As Integer
        Dim aj As Integer

        Dim DownMargin As Integer
        BScanH = 103

        If dispChAll = True Then

            strtuhj = 0
            enduhj = 2
            strtlhj = 3
            endlhj = TotNch
            i2 = 1

        ElseIf dispCh1 = True Then

            strtuhj = 0
            enduhj = 0
            strtlhj = 0
            endlhj = 0
            i2 = 0
        ElseIf dispCh2 = True Then

            strtuhj = 1
            enduhj = 1
            strtlhj = 0
            endlhj = 0
            i2 = DArr(0, 1) - 1
        ElseIf dispCh3 = True Then

            strtuhj = 2
            enduhj = 2
            strtlhj = 0
            endlhj = 0
            i2 = (DArr(0, 1) - 1) + (DArr(1, 1) - 1)
        ElseIf dispCh4 = True Then

            strtuhj = 3
            enduhj = 3
            strtlhj = 0
            endlhj = 0
            i2 = (DArr(0, 1) - 1) + (DArr(1, 1) - 1)
            i2 = i2 + (DArr(2, 1) - 1)
        ElseIf dispCh5 = True Then

            strtuhj = 4
            enduhj = 4
            strtlhj = 0
            endlhj = 0
            i2 = (DArr(0, 1) - 1) + (DArr(1, 1) - 1)
            i2 = i2 + (DArr(2, 1) - 1) + (DArr(3, 1) - 1)

        ElseIf dispCh6 = True Then

            strtuhj = 5
            enduhj = 5
            strtlhj = 0
            endlhj = 0
            i2 = (DArr(0, 1) - 1) + (DArr(1, 1) - 1)
            i2 = i2 + (DArr(2, 1) - 1) + (DArr(3, 1) - 1)
            i2 = i2 + (DArr(4, 1) - 1)
        ElseIf dispCh7 = True Then

            strtuhj = 6
            enduhj = 6
            strtlhj = 0
            endlhj = 0
            i2 = (DArr(0, 1) - 1) + (DArr(1, 1) - 1)
            i2 = i2 + (DArr(2, 1) - 1) + (DArr(3, 1) - 1)
            i2 = i2 + (DArr(4, 1) - 1) + (DArr(5, 1) - 1)

        ElseIf dispCh8 = True Then

            strtuhj = 7
            enduhj = 7
            strtlhj = 0
            endlhj = 0
            i2 = (DArr(0, 1) - 1) + (DArr(1, 1) - 1)
            i2 = i2 + (DArr(2, 1) - 1) + (DArr(3, 1) - 1)
            i2 = i2 + (DArr(4, 1) - 1) + (DArr(5, 1) - 1)

        ElseIf dispCh9 = True Then

            strtuhj = 8
            enduhj = 8
            strtlhj = 0
            endlhj = 0
            i2 = (DArr(0, 1) - 1) + (DArr(1, 1) - 1)
            i2 = i2 + (DArr(2, 1) - 1) + (DArr(3, 1) - 1)
            i2 = i2 + (DArr(4, 1) - 1) + (DArr(5, 1) - 1)

        End If

        If (OdometerVal <> PreOdometerVal) Then

            x_index1 = (OdometerVal - PreOdometerVal) / 0.002

            Movingoffset = Convert.ToInt32(x_index1)
        End If

        ' BScan Moving
        If Movingoffset > 0 And Movingoffset < 20 Then

            For j = 0 To BSCANBUFF1.GetUpperBound(0)

                For ai = 0 To BScanH - 1

                    For aj = 0 To 500 - (Movingoffset + 1)
                        r = (ai * 500) + aj
                        BSCANBUFF1(j, r) = BSCANBUFF1(j, r + Movingoffset)
                    Next aj

                Next ai
            Next j

            For j = 0 To BSCANBUFF1.GetUpperBound(0)

                For ai = 0 To BScanH - 1

                    For aj = 500 - (Movingoffset) To 500 - 1

                        r = (ai * 500) + aj
                        BSCANBUFF1(j, r) = 0
                    Next aj
                Next ai
            Next j

        ElseIf Movingoffset < 0 Then
            Movingoffset = Math.Abs(Movingoffset)
            If Movingoffset < 20 Then
                For j = 0 To BSCANBUFF.GetUpperBound(0)
                    For ai = 0 To 100
                        'For aj = Movingoffset To 500 - 1
                        For aj = 500 - 1 To Movingoffset Step -1
                            r = (ai * 500) + aj
                            BSCANBUFF1(j, r) = BSCANBUFF1(j, r - Movingoffset)
                        Next aj
                    Next ai
                Next j

                For j = 0 To BSCANBUFF1.GetUpperBound(0)
                    For ai = 0 To 100
                        For aj = 0 To Movingoffset - 1
                            r = (ai * 500) + aj
                            ' BSCANBUFF(j, r) = 0
                        Next aj
                    Next ai
                Next j
            End If
        End If

        If dispChAll = True Or dispDown = False Then


            'Plot First 3 Channel UP
            For j = strtuhj To enduhj

                Application.DoEvents()
                upt = DArr(j, 1)

                ReDim pt0(upt)
                ReDim pt1(upt)
                r = DArr(j, 3)

                'AScan -  Map the Rail X Length to Pixel X Length
                Dim Sx As Single = (gRm2 - gLm2) / upt

                'AScan -  Map the Rail Y Length to Pixel Y Length
                Dim Sy As Single = (gBm - gTm) / 256
                Dim vmax As Single = 0
                Dim imax As Integer = 0
                Dim i As Integer

                ' Fix the Default Y Boundary Value
                For i = 0 To UBound(pt0)
                    pt1(i).Y = gBm - 12
                Next i



                g1st = DArr(j, 4)


                g1wd = g1st + DArr(j, 5)

                'Fix the Default X Boundary Value
                For i = 0 To upt - 1
                    pt1(i).X = i * Sx + gLm2
                Next i

                ' Plot AScan
                For i = 0 + 1 To upt - 1

                    Application.DoEvents()
                    vv = gBm - v20(i2)

                    ' Already Fix the lower Y Value
                    ' If the lower Y value is less than current DPRAM value then
                    ' use the currn DPRAM Value
                    If pt1(i).Y > vv Then pt1(i).Y = vv
                    '  ''MessageBox.Show("1.32")
                    ' If the Y valu is crossing the Top margin then assign
                    ' the next three pixel down from Top margin
                    If (pt1(i).Y < gTm) Then
                        pt1(i).Y = gTm + 3
                    End If

                    If gfreeze = True Then

                        ' Horizontal Movement
                        If pt1(i).Y < (gBm - 12) Then
                            If pt1(i).X < Hm Or Hm = 0 Then
                                Hm = pt1(i).X
                            End If
                            If pt1(i).X > HmMax Or HmMax = 0 Then
                                HmMax = pt1(i).X
                            End If

                        End If
                        lblHMtxt.Text = Int(((HmMax / 50) - (Hm / 50))).ToString()
                    End If
                    i2 = i2 + 1
                Next i

                'Fix the First and last value to Origin
                pt1(0).Y = gBm - 12 : pt1(UBound(pt1)).Y = gBm - 12
                Dim PlFactor As Double
                Dim Angle As Double
                Select Case j
                    Case 0
                        PlFactor = 0.2941
                        Angle = 0
                    Case 1, 3, 5
                        PlFactor = 0.161
                        Angle = 70
                    Case 2, 4, 6
                        PlFactor = 0.161
                        Angle = 70
                End Select

                Dim BP As Double = ((DArr(j, 1) * imax) / 500) * PlFactor
                lblvbp.Text = BP.ToString() ' Format(BP.ToString(), "0.00")
                Dim D As Double = BP * Math.Cos(Angle * ((22 / 7) / 180))
                lblvd.Text = D.ToString()
                Dim H As Double = BP * Math.Sin(Angle * ((22 / 7) / 180))
                lblvH.Text = H.ToString()

                For i = 0 To upt - 1


                    objGraphics.DrawLine(gobjPens(j), pt1(i).X, pt1(i).Y, pt1(i + 1).X, pt1(i + 1).Y)
                Next
                '    ''MessageBox.Show("1.2")
                'Now Start the BScan using the AScan Value
                For i = 0 To upt

                    Application.DoEvents()

                    ' If the Y value is in lower Axis value then Skip this
                    ' Dont Plot
                    If pt1(i).Y = gBm - 12 Then
                        Continue For
                    End If

                    If (j = 0) Then
                        If pt1(i).X > 350 Then
                            x_index1 = 0
                        End If
                    End If



                    If gfreeze = False Then


                        x_index1 = 0

                        ' Checking Gate1 Value
                        '                        <  X Value  <
                        '         g1stlinex1                      g1stlinex2
                        '.........|===================================|............
                        '           ^  Above g1wdliney1 > Y
                        '           |  
                        '           |
                        '           |
                        '----------------------------------------------------------

                        If (pt1(i).X > g1stlinex1(j)) And (pt1(i).X < g1stlinex2(j)) Then

                            If (g1wdliney1(j) < pt1(i).Y) Then
                                Continue For
                            End If

                            x_index1 = 1
                        End If

                        j = j

                        ' Checking Gate2 Value only for first channel
                        '               <  X Value  <
                        '         g1stlinex1ch1        g1stlinex2ch1
                        '.........|=====================|............
                        '           ^  Above g1wdliney1ch1 > Y
                        '           |  
                        '           |
                        '           |
                        '----------------------------------------------------------

                        If (j = 0) Then

                            If (pt1(i).X > g1stlinex1ch1) And (pt1(i).X < g1stlinex2ch1) Then
                                If (g1wdliney1ch1 < pt1(i).Y) Then
                                    Continue For

                                End If

                                x_index1 = 1
                            End If

                        End If

                        If x_index1 = 0 Then

                            Continue For
                        End If
                    End If
                    ' Move X data to BScan Y data
                    'BScan_data = (pt1(i).X - 10) * (BScanH / (gRm2 - gLm2))

                    If j = 0 Then


                        'Back Echo
                        BScan_data = (pt1(i).X) * (BScanH / (gRm2be - gLm2))
                    Else

                        BScan_data = (pt1(i).X) * (BScanH / (gRm2 - gLm2))
                    End If

                    Select Case j
                        Case 0

                            Channel_Angle = 1
                            X_val = BScan_data * Channel_Angle
                            x_index1 = 498

                        Case 1

                            Channel_Angle = 0.3
                            X_val = BScan_data * Channel_Angle
                            x_index1 = 425 - (X_val * 0.4095)

                        Case 2

                            Channel_Angle = 0.3
                            X_val = BScan_data * Channel_Angle
                            x_index1 = 404 + (X_val * 0.4095)

                        Case 3

                            Channel_Angle = 0.3
                            X_val = BScan_data * Channel_Angle
                            x_index1 = 333 - (X_val * 0.4095)
                        Case 4

                            Channel_Angle = 0.3
                            X_val = BScan_data * Channel_Angle
                            x_index1 = 306 + (X_val * 0.4095)

                        Case 5

                            Channel_Angle = 0.3
                            X_val = BScan_data * Channel_Angle
                            x_index1 = 236 - (X_val * 0.4095)

                        Case 6

                            Channel_Angle = 0.3
                            X_val = BScan_data * Channel_Angle
                            x_index1 = 209 + (X_val * 0.4095)
                    End Select

                    'X_val = BScan_data * Channel_Angle

                    'Fix the higher end value
                    If (X_val >= BScanH) Then
                        X_val = 103 - 1
                    End If

                    'If (((X_val * 500) + 450) > (500 * 103)) Then
                    '    X_val = 103 - 1
                    'End If

                    ' Fix the lower Range
                    If (X_val < 8) Then
                        X_val = 9
                    End If

                    BSCANBUFF1(j, ((X_val * (gRm2 - gLm2) + x_index1))) = 22

                Next i
            Next j
        End If

        ' If dispChAll = True And dispDown = True Then
        ' ''MessageBox.Show("1.68")
        Dim z As Integer = 0
        Dim z1 As Integer = 0

        For j = strtlhj To endlhj
            upt = DArr(j, 1)


            ReDim pt0(upt)
            ReDim pt1(upt)

            'AScan -  Map the Rail X Length to Pixel X Length
            Dim Sx As Single = (gRm2 - gLm2) / upt

            'AScan -  Map the Rail Y Length to Pixel Y Length
            Dim Sy As Single = (gTm - gBm) / pmax
            Dim vmax As Single = 0
            Dim imax As Integer = 0
            Dim i As Integer

            g1st = DArr(j, 4)
            g1wd = g1st + DArr(j, 5)
            DownMargin = gBm + 10 - 12

            ' Fix the Default Y Boundary Value
            For i = 0 To UBound(pt0)
                pt1(i).Y = DownMargin

            Next i

            'Fix the Default X Boundary Value
            For i = 0 To upt - 1
                pt1(i).X = i * Sx + gLm2
            Next i

            For i = 0 To upt - 1
                vv = gBm - v20(i2)

                ' Already Fix the lower Y Value
                ' If the lower Y value is less than current DPRAM value then
                ' use the currn DPRAM Value
                If pt1(i).Y > vv Then pt1(i).Y = vv

                ' Drawing the graphs to Downward, So Need to adjust the
                ' Y Value
                z = gBm - pt1(i).Y
                pt1(i).Y = DownMargin + z
                If (pt1(i).Y > ((gBm * 2) - 15)) Then
                    pt1(i).Y = (gBm * 2) - 15
                End If
                ' If the Y value is crossing the Downward Top margin then assign
                ' the next three pixel down from Top margin
                If (pt1(i).Y < DownMargin) Then
                    pt1(i).Y = DownMargin
                End If

                If gfreeze = True Then
                    ' Horizontal Movement
                    If pt1(i).Y > DownMargin Then
                        If pt1(i).X < Hm Or Hm = 0 Then
                            Hm = pt1(i).X
                        End If
                        If pt1(i).X > HmMax Or HmMax = 0 Then
                            HmMax = pt1(i).X
                        End If

                    End If
                    lblHMtxt.Text = Int(((HmMax / 50) - (Hm / 50))).ToString()
                End If

                i2 = i2 + 1

            Next i


            pt1(0).Y = DownMargin
            z = gBm - pt1(0).Y
            pt1(0).Y = DownMargin + z

            If (pt1(0).Y > ((gBm * 2) - 15)) Then
                pt1(0).Y = (gBm * 2) - 15
            End If


            If (pt1(0).Y < DownMargin) Then
                pt1(0).Y = DownMargin
            End If


            pt1(UBound(pt1)).Y = DownMargin

            z = gBm - pt1(UBound(pt1)).Y
            pt1(UBound(pt1)).Y = DownMargin + z

            If (pt1(UBound(pt1)).Y > ((gBm * 2) - 15)) Then
                pt1(UBound(pt1)).Y = (gBm * 2) - 15
            End If

            If (pt1(UBound(pt1)).Y < DownMargin) Then
                pt1(UBound(pt1)).Y = DownMargin
            End If



            'objGraphicsFrm.DrawPolygon(gobjPens(j), pt1)
            For i = 0 To upt - 1

                objGraphics.DrawLine(gobjPens(j), pt1(i).X, pt1(i).Y, pt1(i + 1).X, pt1(i + 1).Y)
            Next

            'objGraphicsFrm.DrawLine(gobjPens(j), 0, (gBm * 2) - 15, 300, (gBm * 2) - 15)
            For i = 0 To upt - 1

                If pt1(i).Y > (gBm * 2) - 10 Then
                    'MessageBox.Show("Wrong")
                End If
            Next

            'BScan
            For i = 0 To upt
                Application.DoEvents()
                'z = ((gBm * 2) - (pt1(i).Y) + gBm)
                z = DownMargin - pt1(i).Y
                pt1(i).Y = gBm + z
                If pt1(i).Y = gBm Then
                    Continue For
                End If

                If gfreeze = False Then
                    'If (pt1(i).X < g1stlinex1(j)) Or (pt1(i).X < g1stlinex2(j)) Then
                    If (pt1(i).X > g1stlinex1(j)) And (pt1(i).X < g1stlinex2(j)) Then

                        i3 = g1wdliney1(j)
                        If ChanActive(0) = True Then
                            i3 = (g1wdliney1(j) - Th(j)) - (Th(j) + 3)
                        End If
                        If (i3 < pt1(i).Y) Then
                            Continue For
                        End If
                    Else
                        Continue For
                    End If
                End If



                If (j = 4) Then
                    i3 = 0
                End If

                ' Move X data to BScan Y data
                BScan_data = (pt1(i).X - 10) * (i3 / (gRm2 - gLm2))

                Select Case j
                    Case 0
                        Channel_Angle = 1
                        x_index1 = 499

                    Case 1
                        Channel_Angle = 0.3
                        x_index1 = 425 - (X_val * 0.4095)

                    Case 2
                        Channel_Angle = 0.3
                        x_index1 = 404 + (X_val * 0.4095)

                    Case 3
                        Channel_Angle = 0.3
                        x_index1 = 333 - (X_val * 0.4095)

                    Case 4
                        Channel_Angle = 0.3
                        x_index1 = 306 + (X_val * 0.4095)

                    Case 5
                        Channel_Angle = 0.3
                        x_index1 = 236 - (X_val * 0.4095)

                    Case 6
                        Channel_Angle = 0.3
                        x_index1 = 209 + (X_val * 0.4095)
                End Select



                X_val = BScan_data * Channel_Angle

                'Fix the higher end value
                If (((X_val * 500) + 450) > (500 * 100)) Then
                    X_val = 110 - 1
                End If

                ' Fix the lower Range
                If (X_val < 8) Then
                    X_val = 9
                End If

                BSCANBUFF1(j, ((X_val * (gRm2 - gLm2) + x_index1))) = 22
            Next i
        Next j

        'End If
        PreOdometerVal = OdometerVal

        For z = 0 To BSCANBUFF1.GetUpperBound(0) Step 1

            If (ChanActive(z + 1) = False) And (ChanActive(0) = False) Then
                Continue For
            End If
            'MessageBox.Show(z.ToString(), "z")
            For ai = 0 To BScanH - 1 Step 1
                Application.DoEvents()
                For aj = 0 To (gRm2 - gLm2) - 1 Step 1

                    If z = 0 Then ' First channel fill nearby pixel
                        'MessageBox.Show("2.5")
                        objGraphics.DrawLine(gobjPens(z), aj - 2, 360 + ai, aj + 2, 360 + ai)
                    Else

                        objGraphics.DrawLine(gobjPens(z), aj - 2, 360 + ai, aj + 2, 360 + ai)
                    End If
                Next
            Next
        Next z
        'MessageBox.Show("3")
        objGraphics.DrawLine(gobjPens(1), 50, 50, 100, 100)
        objGraphics.DrawLine(gobjPens(1), 55, 55, 100, 100)
        objGraphics.DrawLine(gobjPens(1), 65, 65, 100, 100)
        picGraph.Image = bmp

    End Sub

    Private Sub AcquireFreezeData(Optional ByVal gtype As Integer = 2)

        Dim objboldfont1 As New Font(FontFamily.GenericSansSerif, 7.0F, FontStyle.Bold)
        Dim objBackPen = New Pen(Color.FromArgb(80, 80, 80))
        Dim objwhitePen = New Pen(Color.FloralWhite)
        objGraphicsFrm = Me.CreateGraphics
        Dim blackpen As New Pen(Color.Black)
        Dim whitepenpen As New Pen(Color.White)

        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        'Read the Channel number
        curi = Val(Microsoft.VisualBasic.Right(logfilename, 5)) - 1
        frm8lbl_ch.Text = "0"
        Dim bb(3) As Byte
        Dim st(38) As String
        Dim objfont As New Font(FontFamily.GenericSansSerif, 7.0F, FontStyle.Regular)
        Dim WhitePen As New Pen(Color.White)
        OpenReadAndPlotData()
        Application.DoEvents()

    End Sub

    Private Sub ClearBScanWindow()
        Dim blackpen As New Pen(Color.Black)
        For i = 0 To 110  'BSCANHEIGHT
            objGraphics.DrawLine(blackpen, 0, 360 + i, 502, 360 + i)
        Next

    End Sub

    Private Sub ReDrawAllCh()
        pmax = 183
        gTm = 0
        gBm = gTm + pmax
        gLm2 = 0
        'c
        gRm2 = gLm2 + 500
        splitch = 2
        CalculateGateValue(0)
        UpdatedispChAll = False
        dispDown = True
    End Sub

    Private Sub CalculateGateValue(ByVal ch As Integer)
        Dim Th1 As Integer
        Dim Sx As Single
        Dim Sy As Single = (gBm - gTm) / 256
        Dim i As Integer
        Dim chlowstart As Integer
        Dim chlowend As Integer
        Dim chhighstart As Integer
        Dim chhighend As Integer


        Dim mode() As Integer = {6, 6, 9, 24, 27, 30, 33}
        For i = 0 To DArr.GetUpperBound(0)
            g1stlinex1(i) = -1
        Next
        If (ch = 0) Then
            chlowstart = 0
            chlowend = splitch
            chhighstart = splitch + 1
            chhighend = TotNch
        Else
            chlowstart = ch - 1
            chlowend = ch - 1
            chhighstart = ch - 1
            chhighend = ch - 1
        End If

        If (ch - 1) <= splitch Then
            For i = chlowstart To chlowend
                Sx = (gRm2 - gLm2) / DArr(i, 1)
                ' Sx = (511 - 6) / DArr(i, 1)
                g1stlinex1(i) = DArr(i, 4) * Sx + gLm2
                Th(i) = ((DArr(i, 6) * Sy))
                g1wdliney1(i) = ((gBm - 12) - gTm) - (Th(i))
                g1stlinex2(i) = DArr(i, 5) * Sx + g1stlinex1(i)

                If (i = 0) Then
                    'Sx = (gRm2 - gLm2) / DArr(i, 1)
                    g1stlinex1ch1 = DArr(i, 7) * Sx + gLm2
                    Th1 = ((DArr(i, 9) * Sy))
                    g1wdliney1ch1 = ((gBm - 12) - gTm) - (Th1)
                    g1stlinex2ch1 = DArr(i, 8) * Sx + g1stlinex1ch1
                    gRm2be = g1stlinex2ch1
                End If
            Next i
        End If
        If (ch - 1) > splitch Or ch = 0 Then
            For i = chhighstart To chhighend
                Sx = (gRm2 - gLm2) / DArr(i, 1)
                g1stlinex1(i) = DArr(i, 4) * Sx + gLm2
                Th(i) = ((DArr(i, 6) * Sy))
                If ChanActive(0) = True Then
                    g1wdliney1(i) = ((gBm) + Th(i))
                Else
                    g1wdliney1(i) = ((gBm) - gTm) - (Th(i))
                End If
                g1stlinex2(i) = DArr(i, 5) * Sx + g1stlinex1(i)
            Next i
        End If

    End Sub
    Private Sub ReDrawCh(ByVal chan As Integer)


        pmax = 366
        gTm = 0
        gBm = gTm + pmax
        gLm2 = 0
        gRm2 = gLm2 + 500

        CalculateGateValue(chan)


        UpdatedispCh1 = False
        UpdatedispCh2 = False
        UpdatedispCh3 = False
        UpdatedispCh4 = False
        UpdatedispCh5 = False
        UpdatedispCh6 = False
        UpdatedispCh7 = False
        UpdatedispCh8 = False
        UpdatedispCh9 = False
        UpdatedispCh10 = False
        dispDown = False

    End Sub


    Public Function ToDMS(ByVal aDecimal As Decimal) As String

        'degree
        Dim returnString As String
        returnString = Int(aDecimal / 100)

        'minute
        Dim minutes As Decimal
        minutes = Int(aDecimal Mod 100)

        'Seconds
        Dim seconds As Decimal
        seconds = Convert.ToDecimal((aDecimal - ((returnString * 100) + minutes)) * 60)
        seconds = Math.Round(seconds, 2)

        ' Format 
        returnString &= "° " & minutes.ToString & "' " & seconds.ToString & "''"
        Return returnString
    End Function

    Private Sub picGraph_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picGraph.Click

    End Sub
End Class