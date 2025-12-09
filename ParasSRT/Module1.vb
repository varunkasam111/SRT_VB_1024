Imports System.IO
Imports System
Imports System.Windows
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports System.Runtime.InteropServices

Module Module1
#Const SRT = 10
#Const TORA = 1
    Public Const TotNpr As Integer = 10
    Public kmax As Integer = 40
    Public isHand As Boolean = False
#If SRT = 10 Then
    Public isColor As Boolean = True
    Public MCNO As String = "SRT"
    Public Const TotNch As Integer = 9
    Public DataArr(TotNch, TotNpr) As Integer
    Public DataArr10(0, TotNpr) As Integer 'For 10th channel data array
    Public CalsetDataArr10(9, 12) As Integer
#ElseIf SRT = 19 Then
    Public isColor As Boolean = True
    Public MCNO As String = "DRT"
    Public Const TotNch As Integer = 18
    Public DataArr(TotNch, TotNpr) As Integer
    'Public DataArr19(0, TotNpr) As Integer
#ElseIf SRT = 6 Then
    Public isColor As Boolean = True
    Public MCNO As String = " WT"
    Public Const TotNch As Integer = 5
    Public DataArr(TotNch + 1, TotNpr) As Integer
#End If
    Public uno As Integer
    Public TH As Single = 70
    Public Const RJTMULT = 1
    Public Const MINHT = 25

#If DEBUG2 Then
    Public dsteps As Integer = 1
    Public dsteps2 As Integer = 1
    Public Const Loops As Integer = 1
    Public Const MKey1 As Integer = Keys.Q
    Public Const MKey2 As Integer = Keys.W
    Public Const MKey3 As Integer = Keys.E
    Public Const MKey4 As Integer = Keys.R
    Public Const MKey5 As Integer = Keys.T
    Public Const MKey6 As Integer = Keys.Y
    Public Const MKey7 As Integer = Keys.U
    Public Const EsKey As Integer = Keys.Escape

    Public Const FkeyLf As Integer = Keys.Left
    Public Const FkeyRt As Integer = Keys.Right
    Public Const FKeyUp As Integer = Keys.Up
    Public Const FKeyDn As Integer = Keys.Down
    Public Const FKey3 As Integer = Keys.Z
    Public Const FkeySave As Integer = Keys.X
    Public Const FKeyPlus As Integer = Keys.C
    Public Const FKeyMinus As Integer = Keys.V
    Public Const FKeyRun As Integer = Keys.Enter
    Public Const FKeyLR As Integer = Keys.Tab
    Public Const KeyDeci As Integer = Keys.Decimal
    Public Const KeyDeci1 As Integer = Keys.L

    Public Const SKey1 As Integer = Keys.A
    Public Const SKey2 As Integer = Keys.S
    Public Const SKey3 As Integer = Keys.D
    Public Const SKey4 As Integer = Keys.F

    Public StorageCard As String = "\\Storage Card\\"
    Public pendrive As String = StorageCard & "Hard Disk\\"
#ElseIf TORA Then
    Public dsteps As Integer = 25
    Public dsteps2 As Integer = 2
    Public Const Loops As Integer = 1
    Public StorageCard As String = "\SD Card\"

    Public Const MKey1 As Integer = 96
    Public Const MKey2 As Integer = 97
    Public Const MKey3 As Integer = 98
    Public Const MKey4 As Integer = 99
    Public Const MKey5 As Integer = 100
    Public Const MKey6 As Integer = 101
    Public Const MKey7 As Integer = 102
    Public Const MKey8 As Integer = 104
    Public Const MKey9 As Integer = 105
    Public Const EsKey As Integer = 103
    Public Const EnKey As Integer = 8

    Public Const FkeyLf As Integer = 37
    Public Const FkeyRt As Integer = 39
    Public Const FKeyUp As Integer = 38
    Public Const FKeyDn As Integer = 40

    Public Const FKey3 As Integer = 255
    Public Const FKeySave As Integer = 188
    Public Const FKeyPlus As Integer = 9
    Public Const FKeyMinus As Integer = 220
    Public Const FKeyRun As Integer = 114
    Public Const FKeyLR As Integer = 222
    Public Const KeyDeci As Integer = 110
    Public Const KeyDeci1 As Integer = 106

    Public Const SKey1 As Integer = 1
    Public Const SKey2 As Integer = 2
    Public Const SKey3 As Integer = 3
    Public Const SKey4 As Integer = 4

    Public pendrive As String = "\USB HD\"

#ElseIf IWAVE Then
    Public dsteps As Integer = 1
    Public dsteps2 As Integer = 1
    Public Const Loops As Integer = 5
    Public StorageCard As String = "\SDMemory\"
    Public Const MKey1 As Integer = 96
    Public Const MKey2 As Integer = 97
    Public Const MKey3 As Integer = 98
    Public Const MKey4 As Integer = 99
    Public Const MKey5 As Integer = 100
    Public Const MKey6 As Integer = 101
    Public Const MKey7 As Integer = 102
    Public Const MKey8 As Integer = 104
    Public Const MKey9 As Integer = 105
    Public Const EsKey As Integer = 29
    Public Const EnKey As Integer = 187

    Public Const FkeyLf As Integer = 37
    Public Const FkeyRt As Integer = 39
    Public Const FKeyUp As Integer = 38
    Public Const FKeyDn As Integer = 40
    Public Const FKey3 As Integer = 255
    Public Const FKeySave As Integer = 115
    Public Const FKeyPlus As Integer = 9
    Public Const FKeyMinus As Integer = 220
    Public Const FKeyRun As Integer = 114
    Public Const FKeyLR As Integer = 222
    Public Const KeyDeci As Integer = 110
    Public Const KeyDeci1 As Integer = 106

    Public Const SKey1 As Integer = 1
    Public Const SKey2 As Integer = 2
    Public Const SKey3 As Integer = 3
    Public Const SKey4 As Integer = 4

    Public pendrive As String = "\Hard Disk\"

#End If

    Public Const lbl1top As Integer = 0
    Public Const lbl1height As Integer = 40
    Public Const lbl2top As Integer = 71
    Public Const lbl2height As Integer = 61
    Public Const lbl3top As Integer = 160
    Public Const lbl3height As Integer = 61
    Public Const lbl4top As Integer = 246
    Public Const lbl4height As Integer = 61
    Public Const lbl5top As Integer = 337
    Public Const lbl5height As Integer = 61
    Public Const lbl6top As Integer = 423
    Public Const lbl6height As Integer = 61
    Public Const lbl7top As Integer = 508
    Public Const lbl7height As Integer = 61
    Public Const lbl8top As Integer = 597
    Public Const lbl8height As Integer = 61
    Public Const lbl9top As Integer = 686
    Public Const lbl9height As Integer = 61
    Public Const memrange As Integer = 4096
    Public curi As Integer
    Public AppPath As String, AppDataPath As String, RootDataPath As String, ConfigGraphPath As String

    Public Calset As String = StorageCard & "CalSetNum.txt"

    Public configfile As String = StorageCard & "config.txt"
    Public gainfile As String = StorageCard & "gaindata.txt"
    Public angfile As String = StorageCard & "angdata.txt"

    'calset filenames for angle and gain and config 10th channel
    Public gainfile1 As String = StorageCard & "gaindata1.txt"
    Public gainfile2 As String = StorageCard & "gaindata2.txt"
    Public gainfile3 As String = StorageCard & "gaindata3.txt"
    Public gainfile4 As String = StorageCard & "gaindata4.txt"
    Public gainfile5 As String = StorageCard & "gaindata5.txt"
    Public gainfile6 As String = StorageCard & "gaindata6.txt"
    Public gainfile7 As String = StorageCard & "gaindata7.txt"
    Public gainfile8 As String = StorageCard & "gaindata8.txt"
    Public gainfile9 As String = StorageCard & "gaindata9.txt"
    Public gainfile10 As String = StorageCard & "gaindata10.txt"
    Public angfile10 As String = StorageCard & "angdata10.txt"
    Public config10 As String = StorageCard & "config10.txt"
    Public Defodovalue As String = StorageCard & "Defodovalue.txt"
    Public gain10DBflag As String = StorageCard & "Gain10DBFlag.txt"
    Public test As String = StorageCard & "test.exe"
    Public recordtest As String = StorageCard & "RecordTest.exe"
    Public odotest As String = StorageCard & "odotest.exe"
    Public gainset As String = StorageCard & "gain.exe"
    Public datafile As String = StorageCard & "31121979_080958.prs"    '"Data_File.txt"
    Public datafile1 As String = StorageCard & "31121979_080958.prs"    '"Data_File.txt"
    Public jpgflag As Boolean
    Public frm7Bool As Boolean

    Public testsetup As String = StorageCard & "testsetup.txt"
    Public testinfo As String = StorageCard & "testinfo.txt"
    Public kminfo As String = StorageCard & "kminfo.txt"
    Public Divdetails As String = StorageCard & "Divdetails.txt"
    Public flawcodes As String = StorageCard & "flawcodes.txt"
    Public probes As String = StorageCard & "probes.txt"
    Public probes2 As String = StorageCard & "probes2.txt"
    Public handheld As String = StorageCard & "handheld.txt"
    Public rollmark As String = StorageCard & "rollmark.txt"
    Public classes As String = StorageCard & "classes.txt"
    Public RootDataPath1 As String = "\SD Card\Logs"
    Public FrmWidth As Integer
    Public FrmHeight As Integer
    Public BSCANBUFF1(6, 56500) As Byte      ' Storing BScan data
    Public DArr(TotNch, 10) As Integer

    Public BScanH As Integer
    Public Logfile1 As String = StorageCard
    Public Logfile2 As String = StorageCard & "\Logs"

    Public ChanActive(9) As Boolean
    Public cnfi As Integer
    Public cnfnam As String
    Public subrange1 As Single, subrange2 As Single
    'angle factor for less than 30 and greater than Degree
    Public ml2mm1 As Single = 0.294
    Public ml2mm2 As Single = 0.161
    Public glbi As Integer = -1
    Public StartDate As String
    Public StartTime As String

    Public Const ADR_IOCTL_SINGLE_BYTE_READ As Integer = 1
    Public Const ADR_IOCTL_BLOCK_READ As Integer = 2
    Public Const ADR_IOCTL_BLOCK_WRITE As Integer = 3
    Public Const ADR_IOCTL_WRITE_MAGIC_NUMBERS As Integer = 4
    Public Const ADR_IOCTL_READ_MAGIC_NUMBERS As Integer = 5
    Public Const ADR_IOCTL_PRINT_MAGIC_NUMBERS As Integer = 6
    Public Const ADR_IOCTL_BLOCK_READ_UPPER As Integer = 7
    Public Const ADR_IOCTL_BLOCK_READ_LOWER As Integer = 8
    Public Const ADC_IOCTL_LOAD_ALL_CHANNEL_DATA As Integer = 1
    Public Const ADC_IOCTL_LOAD_ONE_CHANNEL_DATA As Integer = 2
    Public Const ADC_IOCTL_SYS_RST_LOW As Integer = 3
    Public Const ADC_IOCTL_SYS_RST_HIGH As Integer = 4
    Public Const ADC_IOCTL_SYS_RST_PULSE As Integer = 5
    Public Const GENERIC_READ As Int32 = &H80000000
    Public Const GENERIC_WRITE As Int32 = &H40000000
    Public Const OPEN_EXISTING As Int32 = 3
    Public Const FILE_ATTRIBUTE_NORMAL As Int32 = &H80
    Public Const NOPARITY As Int32 = 0
    Public Const ONESTOPBIT As Int32 = 0
    Public IO_COMMAND As Integer
    Public BYTEREADINFO(12) As Byte           ' 13 BYTES = READ_BYTE_DATA_INFO
    Public BLOCKREADINFO(24587) As Byte      ' 11 + 16384     As READ_BLOCK_DATA_INFO
    Public BSCANBUFF(56500) As Byte      ' Storing BScan data Zaid
    Public WRITEINFO(10) As Byte             ' 11 + 3         As WRITE_DATA_INFO
    Public WRITEINFO2(10) As Byte             ' 11 + 3         dummy 
    Public SingleChannelData(3) As Byte
    Public SINGLE_CHANNEL_DATA(4) As Byte
    Public SINGLE_CHANNEL_OUT(4) As Byte
    Public st1, st2, st3, st4, st5 As String
    Public BPval As Integer

    Public mstr() As String
    Public mstrl As String
    Public mstr_dec As Decimal
    Public frm3StopProcessing As Boolean, frm1StopProcessing As Boolean
    Public fllist As String
    Public Ztestdbg As Integer = 0
    Public prsflag As Boolean
    Public calsetflg As Boolean
    Public bCAppTest As Boolean = False
    Public bEsc As Boolean = False

    <DllImport("CoreDll.dll")> _
    Function DeviceIoControl(ByVal hDevice As Integer, ByVal dwIoControlCode As Integer, _
                         ByVal lpInBuffer() As Byte, ByVal nInBufferSize As Integer, _
                         ByVal lpOutBuffer() As Byte, ByVal nOutBufferSize As Integer, _
                         ByRef lpBytesReturned As Integer, ByVal lpOverlapped As Integer) As Integer
    End Function

    Public Declare Function CreateFile Lib "coredll.dll" (ByVal lpFileName As String, ByVal dwDesiredAccess As Integer, ByVal dwShareMode As Integer, ByVal lpSecurityAttributes As Integer, ByVal dwCreationDisposition As Integer, ByVal dwFLagsAndAttributes As Integer, ByVal hTemplateFile As Integer) As Integer
    Public Declare Function CloseHandle Lib "coredll.dll" (ByVal hObject As Integer) As Boolean
    Public Declare Function SetCursorPos Lib "coredll.dll" (ByVal X As Integer, ByVal Y As Integer) As Integer
    Public Declare Function GetCursorPos Lib "coredll.dll" (ByRef pt As Point) As Integer

    <DllImport("coredll.dll")> _
    Public Function GetDC(ByVal hwnd As IntPtr) As IntPtr
    End Function

    <DllImport("coredll.dll")> _
    Public Function ReleaseDC(ByVal hwnd As IntPtr, ByVal hdc As IntPtr) As Integer
    End Function

    <DllImport("coredll.dll")> _
    Public Function BitBlt(ByVal hdcDest As IntPtr, ByVal nXDest As Integer, ByVal nYDest As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hdcSrc As IntPtr, ByVal nXSrc As Integer, ByVal nYSrc As Integer, ByVal dwRop As Integer) As Integer
    End Function

    Public objfont As Font
    Public objfontcalib As Font
    Public objfont2 As Font
    Public objBrush As Brush
    Public objBrush2 As Brush
    Public objBrush3 As Brush
    Public objBrushBlk As Brush
    Public objPens(10) As Pen
    Public objBrushes(10) As Brush
    Public objWhitePen As Pen
    Public objRedPen As Pen
    Public objBack0Pen As Pen
    Public objBack1Pen As Pen
    Public objBackPen As Pen
    Public objRejectPen As Pen
    Public objBlackPen As Pen
    Public objGraphics As Graphics
    Public objGraphicsB As Graphics
    Public objGraphicsFrm As Graphics
    Public fflag As Boolean

    Public Const InfoSiz As Integer = 230
    Public DataNam() As String = {"Gain", "Delay", "Range", "Reject", "Gate St", "Gate Wd", "Theshold", "Gate2 St", "Gate2 Wd", "Theshold2"}

    'Public colours() As Color = {Color.White, Color.Yellow, Color.Yellow, Color.FromArgb(86, 255, 232), Color.FromArgb(86, 255, 232), Color.DeepPink, Color.DeepPink, Color.LightGray, Color.Black}
    Public colours2() As Color = {Color.White, Color.Yellow, Color.Yellow, Color.FromArgb(86, 255, 232), Color.FromArgb(86, 255, 232), Color.DeepPink, Color.DeepPink, Color.LightGray, Color.Black}
    'Plic colours() As Color = {Color.White, Color.Yellow, Color.Red, Color.FromArgb(86, 255, 232), Color.CornflowerBlue, Color.FromArgb(255, 153, 255), Color.LightDarkSeaGreen, Color.White, Color.Yellow, Color.Red, Color.FromArgb(86, 255, 232), Color.CornflowerBlue, Color.FromArgb(255, 153, 255), Color.LightDarkSeaGreen, Color.Black}
    'Public colours() As Color = {Color.White, Color.Yellow, Color.Red, Color.FromArgb(86, 255, 232), Color.CornflowerBlue, Color.FromArgb(255, 153, 255), Color.LightGreen, Color.White, Color.Yellow, Color.Red, Color.FromArgb(86, 255, 232), Color.CornflowerBlue, Color.FromArgb(255, 153, 255), Color.LightGreen, Color.Black}
    Public colours() As Color = {Color.White, Color.Yellow, Color.Red, Color.FromArgb(86, 255, 232), Color.CornflowerBlue, Color.FromArgb(255, 153, 255), Color.LightGreen, Color.Orange, Color.FromArgb(128, 128, 0), Color.White, Color.Yellow, Color.Red, Color.FromArgb(86, 255, 232), Color.CornflowerBlue, Color.FromArgb(255, 153, 255), Color.LightGreen, Color.Orange, Color.FromArgb(128, 128, 0), Color.Black}
    Public colourDef() As Color = {Color.FromArgb(255, 255, 255), Color.CornflowerBlue, Color.LightGreen, Color.Red, Color.FromArgb(0, 255, 255), Color.FromArgb(255, 0, 255), Color.FromArgb(255, 255, 0), Color.Orange, Color.FromArgb(189, 209, 90), Color.LightGray, Color.Black}
    Public colourind() As Integer = {0, 1, 2, 3, 4, 5, 6, 7, 8, 0}
    Public costh As Double, sinth As Double
    'Public mewidth As Integer = 640
    'Public meheight As Integer = 480
    Public mewidth As Integer = 1024
    Public meheight As Integer = 768
    Public ymax As Integer = 255 '240
    Public ymaxS As Single = ymax / 100
    Public keyprocessing As Boolean = False
    Public IsKeyDown As Boolean = False
    Public caltyp As Integer = 0
    Public caltypS As Integer = 0
    Public oldtyp As Integer = 0
    Public grptyp As Integer = 0
    Public isCalib As Boolean = False
    Public isSavedData As Boolean = False 'for 10 channel config,angle,gain file data

    Public Sub StripDotDash2Dash(ByRef st As String)

        Dim j As Integer

        Do While True
            j = InStr(1, st, Chr(KeyDeci))
            If j = 0 Then Exit Do
            st = Mid$(st, 1, j - 1) & "-" & Mid$(st, j + 1)
        Loop

        Do While True
            j = InStr(1, st, Chr(189))
            If j = 0 Then Exit Do
            st = Mid$(st, 1, j - 1) & "-" & Mid$(st, j + 1)
        Loop

    End Sub

    Public Function GetAppPath() As String
        Return System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
    End Function

    Public Function IsFuncKey(ByVal k As Integer) As Boolean
        IsFuncKey = (k = MKey1 Or k = MKey2 Or k = MKey3 Or k = MKey4 Or k = MKey5 Or k = MKey6 Or k = MKey7 _
                    Or k = FKeySave Or k = FKeyPlus Or k = FKeyMinus Or k = FKeyRun Or k = FKeyLR Or k = EsKey Or k = 229 Or k = SKey1 Or k = SKey2 Or k = SKey3 Or k = SKey4)
    End Function

    Public Function IsLfRt(ByVal k As Integer) As Boolean
        IsLfRt = (k = FkeyLf Or k = FkeyRt Or k = 229)
    End Function

    Public Function IsUpDn(ByVal k As Integer) As Boolean
        IsUpDn = (k = FKeyUp Or k = FKeyDn)
    End Function

    Public Sub SetVars()
        costh = Math.Cos(TH * Math.PI / 180)
        sinth = Math.Sin(TH * Math.PI / 180)

        objPens(0) = New Pen(colours(0))
        objPens(1) = New Pen(colours(1))
        objPens(2) = New Pen(colours(2))
        objPens(3) = New Pen(colours(3))
        objPens(4) = New Pen(colours(4))
        objPens(5) = New Pen(colours(5))
        objPens(6) = New Pen(colours(6))
        objPens(7) = New Pen(colours(7))
        objPens(8) = New Pen(colours(8))
        objPens(9) = New Pen(colours(0))
        objBrushes(0) = New SolidBrush(colours(0))
        objBrushes(1) = New SolidBrush(colours(1))
        objBrushes(2) = New SolidBrush(colours(2))
        objBrushes(3) = New SolidBrush(colours(3))
        objBrushes(4) = New SolidBrush(colours(4))
        objBrushes(5) = New SolidBrush(colours(5))
        objBrushes(6) = New SolidBrush(colours(6))
        objBrushes(7) = New SolidBrush(colours(7))
        objBrushes(8) = New SolidBrush(colours(8))
        objBrushes(9) = New SolidBrush(colours(0))

        frmCalib.lblC1.BackColor = colours(0)
        frmCalib.lblC2.BackColor = colours(1)
        frmCalib.lblC3.BackColor = colours(2)
        frmCalib.lblC4.BackColor = colours(3)
        frmCalib.lblC5.BackColor = colours(4)
        frmCalib.lblC6.BackColor = colours(5)
        frmCalib.lblC7.BackColor = colours(6)
        frmCalib.lblC8.BackColor = colours(7)
        frmCalib.lblC9.BackColor = colours(8)
        frmCalib.lblC10.BackColor = colours(0)

        frmCalib.lblC11.BackColor = colours(0)
        frmCalib.lblC12.BackColor = colours(1)
        frmCalib.lblC13.BackColor = colours(2)
        frmCalib.lblC14.BackColor = colours(3)
        frmCalib.lblC15.BackColor = colours(4)
        frmCalib.lblC16.BackColor = colours(5)
        frmCalib.lblC17.BackColor = colours(6)

        objBackPen = New Pen(Color.FromArgb(80, 80, 80))
        objRejectPen = New Pen(Color.FromArgb(80, 80, 80))
        objRejectPen.DashStyle = Drawing2D.DashStyle.Dash
        objBlackPen = New Pen(Color.Black)
        objWhitePen = New Pen(Color.White)
        objRedPen = New Pen(Color.Red)
        objBrush = New SolidBrush(Color.Gray)
        objBrush2 = New SolidBrush(Color.White)
        objBrush3 = New SolidBrush(Color.White)
        objBrushBlk = New SolidBrush(Color.Black)
        objfont = New Font(frmCalib.Font.Name, 12.0, FontStyle.Regular)
        objfontcalib = New Font(frmCalib.Font.Name, 19.0, FontStyle.Regular)
        objfont2 = New Font(frmCalib.Font.Name, 14.0, FontStyle.Bold)
        'setConfig()
    End Sub
    Public Sub SetVars2()

        costh = Math.Cos(TH * Math.PI / 180)
        sinth = Math.Sin(TH * Math.PI / 180)

        objPens(0) = New Pen(colours(0))
        objPens(1) = New Pen(colours(1))
        objPens(2) = New Pen(colours(2))
        objPens(3) = New Pen(colours(3))
        objPens(4) = New Pen(colours(4))
        objPens(5) = New Pen(colours(5))
        objPens(6) = New Pen(colours(6))
        objPens(7) = New Pen(colours(7))
        objPens(8) = New Pen(colours(8))
        objPens(9) = New Pen(colours(0))

        objBrushes(0) = New SolidBrush(colours(0))
        objBrushes(1) = New SolidBrush(colours(1))
        objBrushes(2) = New SolidBrush(colours(2))
        objBrushes(3) = New SolidBrush(colours(3))
        objBrushes(4) = New SolidBrush(colours(4))
        objBrushes(5) = New SolidBrush(colours(5))
        objBrushes(6) = New SolidBrush(colours(6))
        objBrushes(7) = New SolidBrush(colours(7))
        objBrushes(8) = New SolidBrush(colours(8))
        objBrushes(9) = New SolidBrush(colours(0))

        objBackPen = New Pen(Color.FromArgb(80, 80, 80))
        objRejectPen = New Pen(Color.FromArgb(80, 80, 80))
        objRejectPen.DashStyle = Drawing2D.DashStyle.Dash
        objBlackPen = New Pen(Color.Black)
        objWhitePen = New Pen(Color.White)
        objRedPen = New Pen(Color.Red)
        objBrush = New SolidBrush(Color.Gray)
        objBrush2 = New SolidBrush(Color.White)
        objBrush3 = New SolidBrush(Color.White)
        objBrushBlk = New SolidBrush(Color.Black)
        objfont = New Font(frmCalib.Font.Name, 8.0, FontStyle.Regular)
        objfont2 = New Font(frmCalib.Font.Name, 10.0, FontStyle.Bold)
        'setConfig()

    End Sub

    Public Sub SetPens()

        costh = Math.Cos(TH * Math.PI / 180)
        sinth = Math.Sin(TH * Math.PI / 180)

        objPens(0) = New Pen(colours(0))
        objPens(1) = New Pen(colours(1))
        objPens(2) = New Pen(colours(2))
        objPens(3) = New Pen(colours(3))
        objPens(4) = New Pen(colours(4))
        objPens(5) = New Pen(colours(5))
        objPens(6) = New Pen(colours(6))
        objPens(7) = New Pen(colours(7))
        objPens(8) = New Pen(colours(8))
        objPens(9) = New Pen(colours(0))

        objBrushes(0) = New SolidBrush(colours(0))
        objBrushes(1) = New SolidBrush(colours(1))
        objBrushes(2) = New SolidBrush(colours(2))
        objBrushes(3) = New SolidBrush(colours(3))
        objBrushes(4) = New SolidBrush(colours(4))
        objBrushes(5) = New SolidBrush(colours(5))
        objBrushes(6) = New SolidBrush(colours(6))
        objBrushes(7) = New SolidBrush(colours(7))
        objBrushes(8) = New SolidBrush(colours(8))
        objBrushes(9) = New SolidBrush(colours(0))

        objBackPen = New Pen(Color.FromArgb(80, 80, 80))
        objBlackPen = New Pen(Color.Black)
        objWhitePen = New Pen(Color.White)
        objRedPen = New Pen(Color.Red)
        objBrush = New SolidBrush(Color.Gray)
        objBrush2 = New SolidBrush(Color.White)
        objBrush3 = New SolidBrush(Color.White)
        objBrushBlk = New SolidBrush(Color.Black)

        objfont = New Font(frmCalib.Font.Name, 8.0, FontStyle.Regular)
        objfont2 = New Font(frmCalib.Font.Name, 10.0, FontStyle.Bold)
        'setConfig()

    End Sub

    Public Sub setConfig()
        Dim farr As String() = Directory.GetFiles(AppPath, "*.cnf")
        If farr.Length = 0 Then
            Dim fnam As String = AppPath & "\1.cnf"
            Dim objBW As BinaryWriter
            Dim objFS As FileStream
            objFS = New FileStream(fnam, FileMode.OpenOrCreate, FileAccess.Write)
            objBW = New BinaryWriter(objFS)

            For i = 0 To DataArr.GetUpperBound(0)
                For j = 0 To DataArr.GetUpperBound(1)
                    objBW.Write(DataArr(i, j))
                Next j
            Next i

            cnfi = 0
            objBW.Close()
            objFS.Close()

        End If

    End Sub

    Public Sub OpenConfig()

        Dim i As Integer, j As Integer
        Dim objBW As BinaryReader
        Dim objFS As FileStream
        objFS = New FileStream(cnfnam, FileMode.Open, FileAccess.Read)
        objBW = New BinaryReader(objFS)

        For i = 0 To DataArr.GetUpperBound(0)
            'If i <> 9 Then
            For j = 0 To DataArr.GetUpperBound(1)
                DataArr(i, j) = objBW.ReadInt32
            Next j
            'End If
        Next i

        objBW.Close()
        objFS.Close()

    End Sub

    Public Sub fngain10db(ByVal chnl As Integer)
        Try
            Dim objSR As StreamReader = New StreamReader(gain10DBflag)
            Dim gain10db As String = objSR.ReadLine
            Dim gain10dbvalue As String = gain10db.Split(",")(0)
            Dim filePath As String = gainfile
            Dim lines As New List(Of String)

            ' Read all lines from the file into a list
            Using sr As New StreamReader(filePath)
                While Not sr.EndOfStream
                    lines.Add(sr.ReadLine())
                End While
            End Using

            ' Update line 2, 3, 4, 5 values
            If lines.Count >= 5 Then
                If chnl = 1 Then
                    If gain10dbvalue = "10" Then
                        lines(1) = "1," & DataArr(chnl, 0) + 20 & ","
                    ElseIf gain10dbvalue = "-10" Then
                        lines(1) = "1," & DataArr(chnl, 0) - 20 & ","
                    Else
                        lines(1) = "1," & DataArr(chnl, 0) & ","
                    End If
                ElseIf chnl = 2 Then
                    If gain10dbvalue = "10" Then
                        lines(2) = "2," & DataArr(chnl, 0) + 20 & ","
                    ElseIf gain10dbvalue = "-10" Then
                        lines(2) = "2," & DataArr(chnl, 0) - 20 & ","
                    Else
                        lines(2) = "2," & DataArr(chnl, 0) & ","
                    End If
                ElseIf chnl = 3 Then
                    If gain10dbvalue = "10" Then
                        lines(3) = "3," & DataArr(chnl, 0) + 20 & ","
                    ElseIf gain10dbvalue = "-10" Then
                        lines(3) = "3," & DataArr(chnl, 0) - 20 & ","
                    Else
                        lines(3) = "3," & DataArr(chnl, 0) & ","
                    End If
                ElseIf chnl = 4 Then
                    If gain10dbvalue = "10" Then
                        lines(4) = "4," & DataArr(chnl, 0) + 20 & ","
                    ElseIf gain10dbvalue = "-10" Then
                        lines(4) = "4," & DataArr(chnl, 0) - 20 & ","
                    Else
                        lines(4) = "4," & DataArr(chnl, 0) & ","
                    End If
                End If
            End If

                ' Write updated lines back to the file
                Using sw As New StreamWriter(filePath)
                    For Each line In lines
                        sw.WriteLine(line)
                    Next
                End Using
                SendGainSet()
        Catch ex As Exception
            'MessageBox.Show(ex.ToString(), "fngain10db(curi)")
        End Try
    End Sub

    Public Sub OpenConfig2()

        Try
            Dim i As Integer
            Dim starr() As String, st As String
            Dim objSR As StreamReader
            objSR = New StreamReader(configfile)
            For i = 0 To DataArr.GetUpperBound(0)
                st = objSR.ReadLine()
                starr = Strings.Split(st, ",")
                DataArr(i, 2) = Val(starr(1))
                DataArr(i, 1) = Val(starr(2))
                DataArr(i, 3) = Val(starr(3))
                DataArr(i, 4) = Val(starr(4))
                DataArr(i, 5) = Val(starr(5))
                DataArr(i, 6) = Val(starr(6))
                DataArr(i, 7) = Val(starr(7))
                DataArr(i, 8) = Val(starr(8))
                DataArr(i, 9) = Val(starr(9))
                If i < 10 And starr.Length > 11 Then
                    colourind(i) = Val(starr(10))
                    colours(i) = colourDef(colourind(i))
                End If
            Next i
            objSR.Close()

            objSR = New StreamReader(gainfile)
            For i = 0 To DataArr.GetUpperBound(0)
                st = objSR.ReadLine()
                If i = 10 Then st = objSR.ReadLine()
                starr = Strings.Split(st, ",")
                DataArr(i, 0) = Val(starr(1))
            Next i
            objSR.Close()

            If Not File.Exists(angfile) Then
                For i = 0 To DataArr.GetUpperBound(0)
                    DataArr(i, 10) = 2560 * IIf(i = 0 Or i = 10, 0, 70)
                Next i
            Else
                objSR = New StreamReader(angfile)
                For i = 0 To DataArr.GetUpperBound(0)
                    st = objSR.ReadLine()
                    If i = 10 Then st = objSR.ReadLine()
                    starr = Strings.Split(st, ",")

                    If i <> 9 Then
                        DataArr(i, 10) = Val(starr(1))
                    End If
                Next i
                objSR.Close()

            End If

        Catch ex As Exception
            'MessageBox.Show(ex.Message(), "OpenConfig2()")
        End Try

    End Sub


    Public Sub openConfig210()
        Try
            Dim i As Integer
            Dim starr() As String, st As String
            Dim objSR As StreamReader
            objSR = New StreamReader(config10)
            For i = 0 To CalsetDataArr10.GetUpperBound(0)
                st = objSR.ReadLine()
                starr = Strings.Split(st, ",")
                CalsetDataArr10(i, 2) = Val(starr(1))
                CalsetDataArr10(i, 1) = Val(starr(2))
                CalsetDataArr10(i, 3) = Val(starr(3))
                CalsetDataArr10(i, 4) = Val(starr(4))
                CalsetDataArr10(i, 5) = Val(starr(5))
                CalsetDataArr10(i, 6) = Val(starr(6))
                CalsetDataArr10(i, 7) = Val(starr(7))
                CalsetDataArr10(i, 8) = Val(starr(8))
                CalsetDataArr10(i, 9) = Val(starr(9))
                If i < 10 And starr.Length > 11 Then
                    colourind(i) = Val(starr(10))
                    colours(i) = colourDef(colourind(i))
                End If
            Next i
            objSR.Close()

            objSR = New StreamReader(gainfile)
            For i = 0 To CalsetDataArr10.GetUpperBound(0)
                st = objSR.ReadLine()
                If i = 10 Then st = objSR.ReadLine()
                starr = Strings.Split(st, ",")
                CalsetDataArr10(i, 0) = Val(starr(1))
            Next i
            objSR.Close()

            If Not File.Exists(angfile10) Then
                For i = 0 To CalsetDataArr10.GetUpperBound(0)
                    CalsetDataArr10(i, 10) = 2560 * IIf(i = 0 Or i = 10, 0, 70)
                Next i
            Else
                objSR = New StreamReader(angfile10)
                For i = 0 To DataArr.GetUpperBound(0)
                    st = objSR.ReadLine()
                    If i = 10 Then st = objSR.ReadLine()
                    starr = Strings.Split(st, ",")

                    If i <> 9 Then
                        CalsetDataArr10(i, 10) = Val(starr(1))
                    End If
                Next i
                objSR.Close()

            End If

        Catch ex As Exception
            'MessageBox.Show(ex.Message(), "OpenConfig2()")
        End Try
    End Sub

    'open cofig 10ch
    Public Sub OpenConfig210ch()

        Try
            'c file for calset
            Dim i As Integer
            Dim cals As Integer = 0
            Dim objSR As StreamReader
            Dim calsetArr() As String
            objSR = New StreamReader(Calset)
            Dim calsetNo As String
            calsetNo = objSR.ReadLine()
            calsetArr = Strings.Split(calsetNo, ",")
            cals = calsetArr(1)
            objSR.Close()

            Dim starr() As String, st As String = ""
            objSR = New StreamReader(StorageCard & "config10.txt")
            For i = 0 To DataArr.GetUpperBound(0)

                For j = 1 To cals
                    st = objSR.ReadLine()
                Next

                If st <> "" Then
                    starr = Strings.Split(st, ",")
                    DataArr(0, 2) = Val(starr(1))
                    DataArr(0, 1) = Val(starr(2))
                    DataArr(0, 3) = Val(starr(3))
                    DataArr(0, 4) = Val(starr(4))
                    DataArr(0, 5) = Val(starr(5))
                    DataArr(0, 6) = Val(starr(6))
                    DataArr(0, 7) = Val(starr(7))
                    DataArr(0, 8) = Val(starr(8))
                    DataArr(0, 9) = Val(starr(9))
                    If i < 10 And starr.Length > 11 Then
                        'colourind(i) = Val(starr(10))
                    End If
                End If
            Next i
            objSR.Close()

            objSR = New StreamReader(StorageCard & "gaindata" & cals & ".txt")
            For i = 0 To 10
                st = objSR.ReadLine
                starr = Strings.Split(st, ",")
                DataArr(0, 0) = Val(starr(1))
            Next i
            objSR.Close()

            objSR = New StreamReader(StorageCard & "\" & "angdata10.txt")

            For i = 0 To DataArr.GetUpperBound(0)

                For j = 1 To cals
                    st = objSR.ReadLine()
                Next

                If st <> "" Then
                    starr = Strings.Split(st, ",")
                    DataArr(0, 10) = Val(starr(1))
                End If
            Next i
            objSR.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message(), "OpenConfig210ch()")
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

    Public Sub LoadParams()
        Try
            Dim starr() As String, st As String
            Dim objSR As StreamReader
            If File.Exists(AppPath & "\params.txt") Then
                objSR = New StreamReader(AppPath & "\params.txt")
                st = objSR.ReadLine()
                starr = Strings.Split(st, ",")
                ml2mm1 = Val(starr(0))
                ml2mm2 = Val(starr(1))
                objSR.Close()
            End If
            If File.Exists(AppPath & "\kmax.txt") Then
                objSR = New StreamReader(AppPath & "\kmax.txt")
                st = objSR.ReadLine()
                kmax = Val(st)
                objSR.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub SortList(ByVal lst As ListBox, Optional ByVal asc As Boolean = True)
        Dim i As Integer

        Dim n = lst.Items.Count - 1
        If n = -1 Then Exit Sub
        Dim farr(0 To n)

        For i = 0 To n
            farr(i) = Convert.ToInt32(lst.Items(i).ToString)
        Next i

        Array.Sort(farr)
        lst.Items.Clear()

        If asc Then
            For i = 0 To farr.Length - 1
                lst.Items.Add(farr(i))
            Next i
        Else
            For i = farr.Length - 1 To 0 Step -1
                lst.Items.Add(farr(i))
            Next i
        End If

    End Sub

    Public Sub SortListname(ByVal lst As ListBox, Optional ByVal asc As Boolean = True)
        Dim i As Integer
        Dim n = lst.Items.Count - 1
        If n = -1 Then Exit Sub
        Dim farr(0 To n)
        For i = 0 To n
            farr(i) = lst.Items(i).ToString
        Next i
        System.Array.Sort(farr)
        lst.Items.Clear()
        If asc Then
            For i = 0 To farr.Length - 1
                lst.Items.Add(farr(i))
            Next i
        Else
            For i = farr.Length - 1 To 0 Step -1
                lst.Items.Add(farr(i))
            Next i
        End If
    End Sub

    Public Sub SaveConfig()
        Dim i As Integer, j As Integer
        Dim objBW As BinaryWriter
        Dim objFS As FileStream
        objFS = New FileStream(cnfnam, FileMode.OpenOrCreate, FileAccess.Write)
        objBW = New BinaryWriter(objFS)

        For i = 0 To DataArr.GetUpperBound(0)
            For j = 0 To DataArr.GetUpperBound(1)
                objBW.Write(DataArr(i, j))
            Next j
        Next i

        objBW.Close()
        objFS.Close()
        WriteiWConfig()
        ReadData()
    End Sub

    Public Sub WriteiWConfig()
        Dim fnam As String
        fnam = configfile
        If File.Exists(fnam) Then File.Delete(fnam)
        Dim objSW As StreamWriter
        objSW = New StreamWriter(fnam, False, System.Text.Encoding.ASCII)
        For i = 0 To DataArr.GetUpperBound(0)
            objSW.Write((i + 1).ToString)
            objSW.Write(",")
            objSW.Write(DataArr(i, 2).ToString) : objSW.Write(",")
            objSW.Write(DataArr(i, 1).ToString) : objSW.Write(",")
            objSW.Write(DataArr(i, 3).ToString) : objSW.Write(",")
            objSW.Write(DataArr(i, 4).ToString) : objSW.Write(",")
            objSW.Write(DataArr(i, 5).ToString) : objSW.Write(",")
            objSW.Write(DataArr(i, 6).ToString) : objSW.Write(",")
            objSW.Write(DataArr(i, 7).ToString) : objSW.Write(",")
            objSW.Write(DataArr(i, 8).ToString) : objSW.Write(",")
            objSW.Write(DataArr(i, 9).ToString) : objSW.Write(",")
            If isColor Then
                Dim j As Integer = i Mod 10
                objSW.Write(colourind(j).ToString) : objSW.Write(",")
            End If
            objSW.Write(vbCrLf)

        Next i
        objSW.Close()

        SaveGain()
        SaveAng()

        SaveGain10CH()
        SaveAngle10CH()
        SaveConfig10CH()
    End Sub

    Public Sub ReadData() 'Created for 10th channel Array Data based on calsets
        Try
            'From C Side selection for Calset
            Dim objSR As StreamReader = New StreamReader(Calset)
            Dim mstr() As String
            Dim mstr1 As String
            Dim calsetno As Integer
            mstr1 = objSR.ReadLine
            mstr = mstr1.Split(",")
            calsetno = mstr(1)

            'VB Read Based On Calset From C side
            Dim starrConfig() As String
            Dim objSRConfig As StreamReader
            Dim configFile As String = StorageCard & "config10.txt"

            Dim Data10ChConfig As String = ""
            objSRConfig = New StreamReader(configFile)

            Dim intLoop As Integer = 0

            Try
                If File.Exists(configFile) Then
                    Do While Not objSRConfig.EndOfStream
                        intLoop = intLoop + 1
                        Data10ChConfig = objSRConfig.ReadLine

                        If intLoop = calsetno Then
                            starrConfig = Strings.Split(Data10ChConfig, ",")
                            DataArr10(0, 2) = Val(starrConfig(1))
                            DataArr10(0, 1) = Val(starrConfig(2))
                            DataArr10(0, 3) = Val(starrConfig(3))
                            DataArr10(0, 4) = Val(starrConfig(4))
                            DataArr10(0, 5) = Val(starrConfig(5))
                            DataArr10(0, 6) = Val(starrConfig(6))
                            DataArr10(0, 7) = Val(starrConfig(7))
                            DataArr10(0, 8) = Val(starrConfig(8))
                            DataArr10(0, 9) = Val(starrConfig(9))

                            Exit Do
                        End If

                    Loop
                Else
                    'MessageBox.Show("Config" & calsetno & ".txt Not Exists", "Config" & calsetno & ".txt Not Exists")
                End If
            Catch ex As Exception

            End Try

            '1st File gain
            Dim starrGain() As String
            Dim objSRGain As StreamReader
            Dim gainFile As String = StorageCard & "gaindata" & calsetno & ".txt"
            Dim Data10ChGain As String = ""
            objSRGain = New StreamReader(gainFile)

            If File.Exists(gainFile) Then
                For m = 0 To 10
                    Data10ChGain = objSRGain.ReadLine
                Next

                starrGain = Strings.Split(Data10ChGain, ",")
                DataArr10(0, 0) = Val(starrGain(1))
            Else
                'MessageBox.Show("Gaindata" & calsetno & ".txt Not Exists", "Gaindata" & calsetno & ".txt Not Exists")
            End If

            '1st File Angle
            Dim starrAngle() As String
            Dim objSRAngle As StreamReader
            Dim angleFile As String = StorageCard & "angdata10.txt"
            Dim Data10ChAngle As String = ""
            objSRAngle = New StreamReader(angleFile)

            Dim intLoopAngle As Integer = 0
            Try
                If File.Exists(angleFile) Then
                    Do While Not objSRAngle.EndOfStream
                        intLoopAngle = intLoopAngle + 1
                        Data10ChAngle = objSRAngle.ReadLine

                        If intLoopAngle = calsetno Then
                            starrAngle = Strings.Split(Data10ChAngle, ",")
                            DataArr10(0, 10) = Val(starrAngle(1))

                            Exit Do
                        End If

                    Loop
                Else
                    'MessageBox.Show("Config" & calsetno & ".txt Not Exists", "Config" & calsetno & ".txt Not Exists")
                End If
            Catch ex As Exception

            End Try

        Catch ex As Exception
            'MessageBox.Show(ex.ToString(), "Module1.ReadData()")
        End Try
    End Sub

    Public Sub SaveGain10CH()

        If (frmCalib.ListBox1.SelectedIndex >= 0) Then
            Dim calSetNo As Integer = Convert.ToInt32(frmCalib.ListBox1.SelectedIndex) + 1

            Dim GainFile As String = StorageCard & "gaindata" & calSetNo & ".txt"

            If File.Exists(GainFile) Then File.Delete(GainFile)
            Dim objSW As StreamWriter = New StreamWriter(GainFile, False, System.Text.Encoding.ASCII)

            For i = 0 To 6
                objSW.Write(i.ToString) : objSW.Write(",")
                objSW.Write(DataArr(i, 0).ToString) : objSW.Write(",") : objSW.Write(vbCrLf)
            Next i

            objSW.Write("7,1," & vbCrLf)

            For i = 7 To 9
                objSW.Write((i + 1).ToString) : objSW.Write(",")
                objSW.Write(DataArr(i, 0).ToString) : objSW.Write(",") : objSW.Write(vbCrLf)
            Next i

            objSW.Close()
            SendGainSet()
        End If
    End Sub

    Public Sub SaveAngle10CH()
        Try
            Dim strCalSetNo As String = ""
            If (frmCalib.ListBox1.SelectedIndex >= 0) Then
                strCalSetNo = frmCalib.ListBox1.SelectedItem.ToString.Trim
            End If

            Dim strFullData As String = ""

            If Not File.Exists(angfile10) Then
                Dim objSW1 As StreamWriter = New StreamWriter(angfile10, False, System.Text.Encoding.ASCII)

                For x = 0 To 9
                    objSW1.WriteLine((x + 1) & ",0,")
                Next

                objSW1.Close()
            End If

            Dim objSR1 As StreamReader = New StreamReader(angfile10)

            For i = 0 To 9
                If i = 0 Then
                    strFullData = objSR1.ReadLine
                Else
                    strFullData = strFullData & "~" & objSR1.ReadLine
                End If
            Next

            objSR1.Close()

            Dim arrFullData As String() = strFullData.Split("~")

            Dim strAngle As String = DataArr(9, 10).ToString.Trim

            For j = 0 To 9
                Dim strEditedData As String = strCalSetNo & "," & strAngle & ","
                If (j + 1).ToString() = strCalSetNo Then
                    arrFullData(j) = strEditedData
                    Exit For
                End If
            Next

            Dim objsw2 As StreamWriter = New StreamWriter(angfile10, False, System.Text.Encoding.ASCII)
            For i = 0 To arrFullData.Length - 1
                objsw2.WriteLine(arrFullData(i))
            Next i

            objsw2.Close()

        Catch ex As Exception
            'MessageBox.Show(ex.Message(), "SaveAngle10CH()")
        End Try

    End Sub

    Public Sub SaveConfig10CH()
        Try
            Dim strCalSetNo As String = ""
            If (frmCalib.ListBox1.SelectedIndex >= 0) Then
                strCalSetNo = frmCalib.ListBox1.SelectedItem.ToString.Trim
            End If

            Dim strFullData As String = ""

            If Not File.Exists(config10) Then
                Dim objSW1 As StreamWriter = New StreamWriter(config10, False, System.Text.Encoding.ASCII)

                For x = 0 To 9
                    objSW1.WriteLine((x + 1) & ",0,0,0,0,0,0,0,0,0,0,")
                Next

                objSW1.Close()

            End If

            Dim objSR1 As StreamReader = New StreamReader(config10)

            For i = 0 To 9
                If i = 0 Then
                    strFullData = objSR1.ReadLine
                Else
                    strFullData = strFullData & "~" & objSR1.ReadLine
                End If
            Next

            objSR1.Close()

            Dim arrFullData As String() = strFullData.Split("~")

            Dim strDelay As String = DataArr(9, 2).ToString.Trim
            Dim strRange As String = DataArr(9, 1).ToString.Trim
            Dim strReject As String = DataArr(9, 3).ToString.Trim
            Dim strGate1Start As String = DataArr(9, 4).ToString.Trim
            Dim strGate1End As String = DataArr(9, 5).ToString.Trim
            Dim strThreshold1 As String = DataArr(9, 6).ToString.Trim
            Dim strGate2Start As String = DataArr(9, 7).ToString.Trim
            Dim strGate2End As String = DataArr(9, 8).ToString.Trim
            Dim strThreshold2 As String = DataArr(9, 9).ToString.Trim
            Dim strColor As String = colourind(0).ToString

            Dim strEditedData As String = strCalSetNo & "," & strDelay & "," & strRange & "," & strReject & "," & strGate1Start & "," & strGate1End & "," & strThreshold1 & "," & strGate2Start & "," & strGate2End & "," & strThreshold2 & "," & strColor & ","

            For j = 0 To 9
                If (j + 1).ToString() = strCalSetNo Then
                    arrFullData(j) = strEditedData
                    Exit For
                End If
            Next

            Dim objsw2 As StreamWriter = New StreamWriter(config10, False, System.Text.Encoding.ASCII)
            For i = 0 To arrFullData.Length - 1
                objsw2.WriteLine(arrFullData(i))
            Next i
            objsw2.Close()

        Catch ex As Exception
            'MessageBox.Show(ex.Message(), "SaveConfig10CH()")
        End Try

    End Sub

    Public Sub SaveGain()
        If File.Exists(gainfile) Then File.Delete(gainfile)
        Dim objSW As StreamWriter = New StreamWriter(gainfile, False, System.Text.Encoding.ASCII)
        For i = 0 To 6                    'DataArr.GetUpperBound(0)
            objSW.Write(i.ToString) : objSW.Write(",")
            objSW.Write(DataArr(i, 0).ToString) : objSW.Write(",") : objSW.Write(vbCrLf)
        Next i
        objSW.Write("7,1," & vbCrLf)
        For i = 7 To 9                    'DataArr.GetUpperBound(0)
            objSW.Write((i + 1).ToString) : objSW.Write(",")
            objSW.Write(DataArr(i, 0).ToString) : objSW.Write(",") : objSW.Write(vbCrLf)
        Next i
        objSW.Close()
        SendGainSet()
    End Sub

    Public Sub SaveAng()
        If File.Exists(angfile) Then File.Delete(angfile)
        Dim objSW As StreamWriter = New StreamWriter(angfile, False, System.Text.Encoding.ASCII)
        For i = 0 To 9
            objSW.Write(i.ToString) : objSW.Write(",")
            objSW.Write(DataArr(i, 10).ToString) : objSW.Write(",") : objSW.Write(vbCrLf)
        Next i
        objSW.Close()
        SendGainSet()
    End Sub

    Public Sub SendGainSet() 'From C side Gain.exe file For ADC Data Changes.
        'For Gain Increasing And Decreasing
        Dim p As New Process
        p.StartInfo.FileName = gainset
        p.Start()
        PauseIt(1)
        p.WaitForExit()             'added for Toradex
        p.Close()
        Application.DoEvents()
    End Sub

    Public Sub SendGain(ByVal i As Integer) 'ADC Communication
        Dim v As Integer
        v = DataArr(i, 0)
        SINGLE_CHANNEL_DATA(0) = CByte(i)
        SINGLE_CHANNEL_DATA(1) = CByte(0)
        SINGLE_CHANNEL_DATA(2) = CByte(v)
        SINGLE_CHANNEL_DATA(3) = CByte(0)
        PauseIt(3)
    End Sub

    Public Sub PauseIt(ByVal dt As Double)
        Dim t As Double = Microsoft.VisualBasic.Timer
        t = t + dt
        Do While Microsoft.VisualBasic.Timer < t
            Application.DoEvents()
        Loop
    End Sub

    Public Function Rangemm(ByVal memloc As Integer, ByVal j As Integer) As Single
        Dim wav As Integer
        Dim ang As Single
        If j <> -1 Then
            GetWaveAng(j, wav, ang)
            If wav = 1 Then
                Rangemm = CSng(memloc) * ml2mm1
            ElseIf wav = 2 Then
                Rangemm = CSng(memloc) * ml2mm2
            End If
        Else
            Rangemm = CSng(memloc) * ml2mm1
        End If
    End Function

    Public Function Rangeml(ByVal mm As Integer, ByVal j As Integer) As Single 'Range and channel is passing here
        Dim wav As Integer
        Dim ang As Single
        If j <> -1 Then
            GetWaveAng(j, wav, ang)
            If wav = 1 Then
                Rangeml = CSng(mm) / ml2mm1
            ElseIf wav = 2 Then
                Rangeml = CSng(mm) / ml2mm2
            End If
        Else
            Rangeml = CSng(mm) / ml2mm1
        End If
    End Function

    Public Sub GetWaveAng(ByVal j As Integer, ByRef wav As Integer, ByRef ang As Single)

        If j = 9 Then
            wav = DataArr10(0, 10) Mod 256
        Else
            wav = DataArr(j, 10) Mod 256
        End If

        If wav = 0 Then
            If curi = 10 Then
                ang = (DataArr10(0, 10) \ 256) / 10
            Else
                ang = (DataArr(j, 10) \ 256) / 10
            End If
            If ang <= 30 Then
                wav = 1
            Else
                wav = 2
            End If
        Else
            If wav = 1 Then
                ang = 0
            Else
                ang = 70
            End If
        End If
    End Sub

    Public Function SetWaveAng(ByVal j As Integer, ByVal ang As Single) As Single
        SetWaveAng = ang * 256
    End Function

    Public Function ExtractFilename(ByVal filepath As String) As String
        ' If path ends with a "\", it's a path only so return String.Empty.
        If filepath.Trim().EndsWith("\") Then Return String.Empty

        ' Determine where last backslash is.
        Dim position As Integer = filepath.LastIndexOf("\"c)
        ' If there is no backslash, assume that this is a filename.
        If position = -1 Then
            Return String.Empty
        Else
            Return filepath.Substring(position + 1)
        End If
    End Function
End Module
