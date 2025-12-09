Imports System.IO
Imports System
Imports System.Windows
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports System.Runtime.InteropServices

Module Module1
#Const SRT = 14
    Public Const TotNpr As Integer = 10
    Public kmax As Integer = 40

#If SRT = 7 Then
    Public MCNO As String = "SRT"
    Public Const TotNch As Integer = 6
    Public DataArr(TotNch, TotNpr) As Integer
#ElseIf SRT = 14 Then
    Public MCNO As String = "DRT"
    Public Const TotNch As Integer = 13
    Public DataArr(TotNch, TotNpr) As Integer
#ElseIf SRT = 6 Then
    Public MCNO As String = " WT"
    Public Const TotNch As Integer = 5
    Public DataArr(TotNch + 1, TotNpr) As Integer
#End If

    Public Const Loops As Integer = 5
    Public TH As Single = 70
    Public Const RJTMULT = 0.5
#If DEBUG Then
    '#If Not Device Then
    'Public Const MKey1 As Integer = 189     'Keys.F3
    'Public Const MKey2 As Integer = 187     'Keys.F4
    'Public Const MKey3 As Integer = 219     'Keys.F5
    'Public Const MKey4 As Integer = 221     'Keys.F8
    'Public Const MKey5 As Integer = 186     'Keys.F9
    'Public Const MKey6 As Integer = 222     'Keys.F10
    'Public Const MKey7 As Integer = 188     'Keys.Home

    Public Const MKey1 As Integer = Keys.F3
    Public Const MKey2 As Integer = Keys.F4
    Public Const MKey3 As Integer = Keys.F5
    Public Const MKey4 As Integer = Keys.F8
    Public Const MKey5 As Integer = Keys.F9
    Public Const MKey6 As Integer = Keys.F10
    Public Const MKey7 As Integer = Keys.PrintScreen
    Public Const EsKey As Integer = Keys.Escape

    Public Const FkeyLf As Integer = Keys.Left
    Public Const FkeyRt As Integer = Keys.Right
    Public Const FKeyUp As Integer = Keys.Up
    Public Const FKeyDn As Integer = Keys.Down
    Public Const FKey3 As Integer = Keys.Back
    Public Const FkeySave As Integer = Keys.Home
    Public Const FKeyPlus As Integer = Keys.PageUp
    Public Const FKeyMinus As Integer = Keys.PageDown
    Public Const FKeyRun As Integer = Keys.Enter
    Public Const FKeyLR As Integer = Keys.End
    Public Const KeyDeci As Integer = Keys.Decimal
    Public Const KeyDeci1 As Integer = 190
    Public StorageCard As String = "\Storage Card\"
    Public pendrive As String = StorageCard & "Hard Disk\"
#Else
    Public StorageCard As String = "\SDMemory\"
    Public Const MKey1 As Integer = 96
    Public Const MKey2 As Integer = 97
    Public Const MKey3 As Integer = 98
    Public Const MKey4 As Integer = 99
    Public Const MKey5 As Integer = 100
    Public Const MKey6 As Integer = 101
    Public Const MKey7 As Integer = 102
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

    Public pendrive As String = "\Hard Disk\"

    'Public Const FkeyLf As Integer = 37                   '222
    'Public Const FkeyRt As Integer = 39                   '107
    'Public Const FKey3 As Integer = 8
    'Public Const FkeySave As Integer = 188
    'Public Const FKeyUp As Integer = 38                  '191
    'Public Const FKeyDn As Integer = 40                  '186
    'Public Const FKeyPlus As Integer = 9                 '192
    'Public Const FKeyMinus As Integer = 220
    'Public Const FKeyRun As Integer = 114                '187
#End If

    Public Const lbl1top As Integer = 11
    Public Const lbl1height As Integer = 52
    Public Const lbl2top As Integer = 71
    Public Const lbl2height As Integer = 52
    Public Const lbl3top As Integer = 131
    Public Const lbl3height As Integer = 52
    Public Const lbl4top As Integer = 191
    Public Const lbl4height As Integer = 52
    Public Const lbl5top As Integer = 251
    Public Const lbl5height As Integer = 52
    Public Const lbl6top As Integer = 311
    Public Const lbl6height As Integer = 52
    Public Const lbl7top As Integer = 371
    Public Const lbl7height As Integer = 52

    Public AppPath As String, AppDataPath As String, RootDataPath As String
    Public configfile As String = StorageCard & "config.txt"
    Public gainfile As String = StorageCard & "gaindata.txt"
    Public angfile As String = StorageCard & "angdata.txt"
    Public test As String = StorageCard & "test.exe"
    Public gainset As String = StorageCard & "gain.exe"
    Public datafile As String = StorageCard & "31121979_080958.prs"    '"Data_File.txt"
    Public testsetup As String = StorageCard & "testsetup.txt"
    Public testinfo As String = StorageCard & "testinfo.txt"
    Public flawcodes As String = StorageCard & "flawcodes.txt"
    Public probes As String = StorageCard & "probes.txt"
    Public rollmark As String = StorageCard & "rollmark.txt"
    Public classes As String = StorageCard & "classes.txt"


    Public cnfi As Integer
    Public cnfnam As String

    Public ml2mm1 As Single = 0.294
    Public ml2mm2 As Single = 0.161

    Public glbi As Integer = -1

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
    'Structure READ_BYTE_DATA_INFO
    '    Public Offset As Integer
    '    Public nLengthOfBytes As Integer
    '    Public ByteReadBuffer As Byte
    'End Structure
    Public BYTEREADINFO(8) As Byte           ' 9 BYTES = READ_BYTE_DATA_INFO

    'Structure READ_BLOCK_DATA_INFO
    '    Public Offset As Integer
    '    Public nLengthOfBytes As Integer
    '    Public BlockReadBuffer() As Byte
    'End Structure
    '    Public BLOCKREADINFO(16391) As Byte      ' 8 + 16384     As READ_BLOCK_DATA_INFO
    Public BLOCKREADINFO(16391) As Byte      ' 8 + 16384     As READ_BLOCK_DATA_INFO

    'Structure WRITE_DATA_INFO
    '    Public Offset As Integer
    '    Public nLengthOfBytes As Integer
    '    Public WriteData() As Byte
    'End Structure
    Public WRITEINFO(10) As Byte             ' 8 + 3         As WRITE_DATA_INFO
    Public WRITEINFO2(10) As Byte             ' 8 + 3         dummy 

    'struct SINGLE_CHANNEL_DATA{
    '	int ChannelAddress;
    '	int ChannelValue;	
    '};
    'struct SINGLE_CHANNEL_DATA SingleChannelData;
    Public SingleChannelData(3) As Byte
    Public SINGLE_CHANNEL_DATA(4) As Byte
    Public SINGLE_CHANNEL_OUT(4) As Byte


    <DllImport("CoreDll.dll")> _
    Function DeviceIoControl(ByVal hDevice As Integer, ByVal dwIoControlCode As Integer, _
                         ByVal lpInBuffer() As Byte, ByVal nInBufferSize As Integer, _
                         ByVal lpOutBuffer() As Byte, ByVal nOutBufferSize As Integer, _
                         ByRef lpBytesReturned As Integer, ByVal lpOverlapped As Integer) As Integer
    End Function
    'Public Structure SHELLEXECUTEINFO
    '    Public cbSize As UInt32
    '    Public fMask As UInt32
    '    Public hwnd As IntPtr
    '    Public lpVerb As IntPtr
    '    Public lpFile As IntPtr
    '    Public lpParameters As IntPtr
    '    Public lpDirectory As IntPtr

    '    Public nShow As Integer
    '    Public hInstApp As IntPtr
    '    ' Optional members
    '    Public lpIDList As IntPtr
    '    Public lpClass As IntPtr
    '    Public hkeyClass As IntPtr
    '    Public dwHotKey As UInt32
    '    Public hIcon As IntPtr
    '    Public hProcess As IntPtr
    'End Structure  'SHELLEXECUTEEX
    '<DllImport("coredll")> _
    'Public Function ShellExecuteEx(ByRef ex As SHELLEXECUTEINFO) As Integer
    'End Function
    '<DllImport("coredll")> _
    'Public Function LocalAlloc(ByVal flags As Integer, ByVal size As Integer) As IntPtr
    'End Function

    '<DllImport("coredll")> _
    'Public Sub LocalFree(ByVal ptr As IntPtr)
    'End Sub

    Public Declare Function CreateFile Lib "coredll.dll" (ByVal lpFileName As String, ByVal dwDesiredAccess As Integer, ByVal dwShareMode As Integer, ByVal lpSecurityAttributes As Integer, ByVal dwCreationDisposition As Integer, ByVal dwFLagsAndAttributes As Integer, ByVal hTemplateFile As Integer) As Integer
    '    Public Declare Function CloseHandle Lib "coredll.dll" (ByVal hObject As IntPtr) As Boolean
    Public Declare Function CloseHandle Lib "coredll.dll" (ByVal hObject As Integer) As Boolean
    '    Public hADRDriver As Integer
    '   Public hADCDriver As Integer
    Public Declare Function SetCursorPos Lib "coredll.dll" (ByVal X As Integer, ByVal Y As Integer) As Integer
    Public Declare Function GetCursorPos Lib "coredll.dll" (ByRef pt As Point) As Integer

    Public objfont As Font
    Public objfont2 As Font
    Public objBrush As Brush
    Public objBrush2 As Brush
    Public objBrush3 As Brush
    Public objBrushBlk As Brush
    Public objPens(7) As Pen
    Public objBrushes(7) As Brush
    Public objWhitePen As Pen
    Public objRedPen As Pen
    Public objBack0Pen As Pen
    Public objBack1Pen As Pen
    Public objBackPen As Pen
    Public objBlackPen As Pen
    Public objGraphics As Graphics
    Public objGraphicsB As Graphics
    Public objGraphicsFrm As Graphics

    Public Const InfoSiz As Integer = 230
    Public DataNam() As String = {"Gain", "Delay", "Range", "Reject", "Gate St", "Gate Wd", "Theshold", "Gate2 St", "Gate2 Wd", "Theshold2"}

    Public colours() As Color = {Color.White, Color.Yellow, Color.Yellow, Color.Cyan, Color.Cyan, Color.DeepPink, Color.DeepPink, Color.LightGray, Color.Black}
    Public costh As Double, sinth As Double

    Public mewidth As Integer = 640
    Public meheight As Integer = 480
    Public ymax As Integer = 240
    Public ymaxS As Single = ymax / 100
    Public keyprocessing As Boolean = False
    Public IsKeyDown As Boolean = False
    Public caltyp As Integer = 0
    Public isCalib As Boolean = False
    Public isSavedData As Boolean = False
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
                    Or k = FKeySave Or k = FKeyPlus Or k = FKeyMinus Or k = FKeyRun Or k = FKeyLR Or k = EsKey Or k = 229)
    End Function
    Public Function IsLfRt(ByVal k As Integer) As Boolean
        IsLfRt = (k = FkeyLf Or k = FkeyRt Or k = 229)
    End Function
    Public Function IsUpDn(ByVal k As Integer) As Boolean
        IsUpDn = (k = FKeyUp Or k = FKeyDn)
    End Function
    Public Sub SetVars()
        '        hADRDriver = CreateFile("ADR1:", GENERIC_READ Or GENERIC_WRITE, 0, 0, OPEN_EXISTING, 0, 0)
        '       hADCDriver = CreateFile("ADC1:", GENERIC_READ Or GENERIC_WRITE, 0, 0, OPEN_EXISTING, 0, 0)

        costh = Math.Cos(TH * Math.PI / 180)
        sinth = Math.Sin(TH * Math.PI / 180)

        objPens(0) = New Pen(colours(0))
        objPens(1) = New Pen(colours(1))
        objPens(2) = New Pen(colours(2))
        objPens(3) = New Pen(colours(3))
        objPens(4) = New Pen(colours(4))
        objPens(5) = New Pen(colours(5))
        objPens(6) = New Pen(colours(6))
        objBrushes(0) = New SolidBrush(colours(0))
        objBrushes(1) = New SolidBrush(colours(1))
        objBrushes(2) = New SolidBrush(colours(2))
        objBrushes(3) = New SolidBrush(colours(3))
        objBrushes(4) = New SolidBrush(colours(4))
        objBrushes(5) = New SolidBrush(colours(5))
        objBrushes(6) = New SolidBrush(colours(6))


        frmCalib.lblC1.BackColor = colours(0)
        frmCalib.lblC2.BackColor = colours(1)
        frmCalib.lblC3.BackColor = colours(2)
        frmCalib.lblC4.BackColor = colours(3)
        frmCalib.lblC5.BackColor = colours(4)
        frmCalib.lblC6.BackColor = colours(5)
        frmCalib.lblC7.BackColor = colours(6)

        objBackPen = New Pen(Color.FromArgb(80, 80, 80))
        objBlackPen = New Pen(Color.Black)
        objWhitePen = New Pen(Color.White)
        objRedPen = New Pen(Color.Red)
        objBrush = New SolidBrush(Color.Gray)
        objBrush2 = New SolidBrush(colours(0))
        objBrush3 = New SolidBrush(colours(1))
        objBrushBlk = New SolidBrush(Color.Black)

        objfont = New Font(frmCalib.Font.Name, 8.0, FontStyle.Regular)
        objfont2 = New Font(frmCalib.Font.Name, 10.0, FontStyle.Bold)

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
            '        Me.Text = "Paras RT511 Configuration Set:" & ListBox1.SelectedItem
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
            For j = 0 To DataArr.GetUpperBound(1)
                DataArr(i, j) = objBW.ReadInt32
            Next j
        Next i
        objBW.Close()
        objFS.Close()
    End Sub
    Public Sub OpenConfig2()
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
        Next i
        objSR.Close()

        objSR = New StreamReader(gainfile)
        For i = 0 To DataArr.GetUpperBound(0)
            st = objSR.ReadLine()
            If i = 7 Then st = objSR.ReadLine()
            starr = Strings.Split(st, ",")
            DataArr(i, 0) = Val(starr(1))
        Next i
        objSR.Close()
        If Not File.Exists(angfile) Then
            For i = 0 To DataArr.GetUpperBound(0)
                DataArr(i, 10) = 2560 * IIf(i = 0 Or i = 7, 0, 70)
            Next i
        Else
            objSR = New StreamReader(angfile)
            For i = 0 To DataArr.GetUpperBound(0)
                st = objSR.ReadLine()
                If i = 7 Then st = objSR.ReadLine()
                starr = Strings.Split(st, ",")
                DataArr(i, 10) = Val(starr(1))
            Next i
            objSR.Close()
        End If
    End Sub
    Public Sub LoadParams()
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
    End Sub
    Public Sub SortList(ByVal lst As ListBox, Optional ByVal asc As Boolean = True)
        Dim i As Integer
        Dim n = lst.Items.Count - 1
        If n = -1 Then Exit Sub
        Dim farr(0 To n)
        For i = 0 To n
            farr(i) = lst.Items(i).ToString
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
            objSW.Write(DataArr(i, 9).ToString) : objSW.Write(",") : objSW.Write(vbCrLf)
        Next i
        objSW.Close()
        SaveGain()
        SaveAng()
    End Sub
    Public Sub SaveGain()
        If File.Exists(gainfile) Then File.Delete(gainfile)
        Dim objSW As StreamWriter = New StreamWriter(gainfile, False, System.Text.Encoding.ASCII)
        For i = 0 To 6                    'DataArr.GetUpperBound(0)
            objSW.Write(i.ToString) : objSW.Write(",")
            objSW.Write(DataArr(i, 0).ToString) : objSW.Write(",") : objSW.Write(vbCrLf)
        Next i
        objSW.Write("7,1," & vbCrLf)
        If DataArr.GetUpperBound(0) < 7 Then
            For i = 0 To DataArr.GetUpperBound(0)
                objSW.Write((i + 8).ToString) : objSW.Write(",")
                objSW.Write(DataArr(i, 0).ToString) : objSW.Write(",") : objSW.Write(vbCrLf)
            Next i
        Else
            For i = 7 To 13                    'DataArr.GetUpperBound(0)
                objSW.Write((i + 1).ToString) : objSW.Write(",")
                objSW.Write(DataArr(i, 0).ToString) : objSW.Write(",") : objSW.Write(vbCrLf)
            Next i
        End If
        objSW.Write("15") : objSW.Write(",")
        objSW.Write(DataArr(3, 0).ToString) : objSW.Write(",") : objSW.Write(vbCrLf)
        objSW.Close()
        SendGainSet()
    End Sub
    Public Sub SaveAng()
        If File.Exists(angfile) Then File.Delete(angfile)
        Dim objSW As StreamWriter = New StreamWriter(angfile, False, System.Text.Encoding.ASCII)
        For i = 0 To 6                    'DataArr.GetUpperBound(0)
            objSW.Write(i.ToString) : objSW.Write(",")
            objSW.Write(DataArr(i, 10).ToString) : objSW.Write(",") : objSW.Write(vbCrLf)
        Next i
        objSW.Write("7,1," & vbCrLf)
        If DataArr.GetUpperBound(0) < 7 Then
            For i = 0 To DataArr.GetUpperBound(0)
                objSW.Write((i + 8).ToString) : objSW.Write(",")
                objSW.Write(DataArr(i, 10).ToString) : objSW.Write(",") : objSW.Write(vbCrLf)
            Next i
        Else
            For i = 7 To 13                    'DataArr.GetUpperBound(0)
                objSW.Write((i + 1).ToString) : objSW.Write(",")
                objSW.Write(DataArr(i, 10).ToString) : objSW.Write(",") : objSW.Write(vbCrLf)
            Next i
        End If
        objSW.Write("15") : objSW.Write(",")
        objSW.Write(DataArr(3, 0).ToString) : objSW.Write(",") : objSW.Write(vbCrLf)
        objSW.Close()
        SendGainSet()
    End Sub
    Public Sub SendGainSet()
        Dim p As New Process
        p.StartInfo.FileName = gainset
        p.Start()
        PauseIt(1)
        p.Close()
    End Sub
    Public Sub SendGain(ByVal i As Integer)
        Dim v As Integer = DataArr(i, 0)
        SINGLE_CHANNEL_DATA(0) = CByte(i)
        SINGLE_CHANNEL_DATA(1) = CByte(0)
        SINGLE_CHANNEL_DATA(2) = CByte(v)
        SINGLE_CHANNEL_DATA(3) = CByte(0)

        '        DeviceIoControl(hADCDriver, ADC_IOCTL_LOAD_ONE_CHANNEL_DATA, SINGLE_CHANNEL_DATA, SINGLE_CHANNEL_DATA.Length, SINGLE_CHANNEL_OUT, SINGLE_CHANNEL_OUT.Length, 0, 0)
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
    Public Function Rangeml(ByVal mm As Integer, ByVal j As Integer) As Single
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
        wav = DataArr(j, 10) Mod 256
        If wav = 0 Then
            ang = (DataArr(j, 10) \ 256) / 10
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
End Module
