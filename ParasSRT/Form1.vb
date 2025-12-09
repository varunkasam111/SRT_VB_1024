Imports System.IO
Imports System
Imports System.Windows
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports System.Runtime.InteropServices

Public Class frmMain
#Const TORA = 1
    Dim isloaded As Boolean
    Dim pstarted As Boolean
    Dim p As Process

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim k As Integer
        If Not isloaded Then e.Handled = True : Exit Sub
        k = e.KeyCode
        Select Case k
            Case MKey1
                If frm1StopProcessing = True Then
                    Exit Sub
                End If

                If Ztestdbg = 1 Then
                End If

                Ztestdbg += 1
                frm1StopProcessing = True
                frmTest.ShowDialog()
                frm1StopProcessing = False
                frmTest.isTextInfo = False

                e.Handled = True

            Case MKey2

                caltyp = 0
                frmCalib.ShowDialog()
                e.Handled = True

            Case MKey3

                frmData.ShowDialog()
                e.Handled = True

            Case MKey4

                If isColor Then
                    frmColors.ShowDialog()
                End If
                e.Handled = True

            Case MKey5

                frmLog.ShowDialog()
                If frm7Bool = False Then
                    Me.Text = "Launching ReviewLog Application"
                    pstarted = True
                    p = New Process
                    p.StartInfo.FileName = recordtest
                    p.Start()
                    p.WaitForExit()
                    p.Close()
                End If
                e.Handled = True

            Case MKey6
                Application.Exit()
                e.Handled = True
            Case MKey7


            Case MKey8
                Form_OdoCalib.ShowDialog()
                e.Handled = True

#If DEBUG2 Then
                 Me.Text = "Paras Electronics - U/S Single Rail Tester"
#Else
                Me.Text = "Paras Electronics - U/S Single Rail Tester"
#End If
            Case Else
                e.Handled = False
        End Select
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim objSR1 As StreamReader = New StreamReader("\SD Card\Model.txt")

            Dim mstr() As String
            Dim mstr1 As String

            mstr1 = objSR1.ReadLine
            mstr = mstr1.Split(",")

            Dim Modelno As String = mstr(0)

            Me.Text = "Paras Electronics - U/S Single Rail Tester"
            Me.AutoScroll = False
            SetCursorPos(640, 460)
            isloaded = False
            Me.Width = mewidth : Me.Height = meheight
            Me.lblMenu1.Left = Me.Width - Me.lblMenu1.Width
            Me.lblMenu2.Left = Me.lblMenu1.Left
            Me.lblMenu3.Left = Me.lblMenu1.Left
            Me.lblMenu4.Left = Me.lblMenu1.Left
            Me.lblMenu5.Left = Me.lblMenu1.Left
            Me.lblMenu6.Left = Me.lblMenu1.Left
            Me.lblMenu7.Left = Me.lblMenu1.Left
            Me.lblMenu8.Left = Me.lblMenu1.Left

            Me.lblMenu1.Top = lbl1top : Me.lblMenu1.Height = lbl1height
            Me.lblMenu2.Top = lbl2top : Me.lblMenu2.Height = lbl2height
            Me.lblMenu3.Top = lbl3top : Me.lblMenu3.Height = lbl3height
            Me.lblMenu4.Top = lbl4top : Me.lblMenu4.Height = lbl4height
            Me.lblMenu5.Top = lbl5top : Me.lblMenu5.Height = lbl5height
            Me.lblMenu6.Top = lbl6top : Me.lblMenu6.Height = lbl6height
            Me.lblMenu7.Top = lbl7top : Me.lblMenu7.Height = lbl7height
            Me.lblMenu8.Top = lbl8top : Me.lblMenu8.Height = lbl8height
            Me.lblMenu4.Visible = isColor

            Me.Width = mewidth : Me.Height = meheight
            AppPath = GetAppPath()

            If File.Exists(AppPath & "\bin.bin") Then
                Dim fs As New FileStream(AppPath & "\bin.bin", FileMode.Open, FileAccess.Read)
                uno = fs.ReadByte
                uno = uno + fs.ReadByte * CInt(256)
                MCNO = MCNO & Format(uno, "0000") ' Zaid
            Else
                MsgBox("Incomplete installation. Exiting.")
                Application.Exit()
            End If

            RootDataPath = AppPath & "\" & MCNO
            If Not Directory.Exists(RootDataPath) Then
                Directory.CreateDirectory(RootDataPath)
            End If

            LoadParams()

            If TotNch = 5 Then
                Me.Text = "Paras Electronics - U/S Weld Tester"
                Me.lblCaption.Text = "U/S Weld Tester " & vbCrLf & "WT-311D"
                Me.lblCaption2.Text = "Unit Number: " & Format(uno, "0000")     'MCNO 'Zaid
            ElseIf TotNch = 9 Then
                Me.Text = "Paras Electronics - U/S Single Rail Tester"
                Me.lblCaption.Text = "Rail Tester                          Model:SRT-" & Modelno
                Me.lblCaption2.Text = "Serial Number: " & Format(uno, "0000")     'MCNO
            Else
                Me.Text = "Paras Electronics - U/S Double Rail Tester"
                Me.lblCaption.Text = "U/S Double Rail Tester  DRT-" & Modelno
                Me.lblCaption2.Text = "Unit Number: " & Format(uno, "0000")     ' MCNO 'Zaid
            End If

            'Me.lblParas.Width = 400
            'Me.lblCaption.Width = 400
            'Me.lblCaption2.Width = 400
            'Me.lblDate.Width = 400
            Me.lblParas.Width = 660
            Me.lblCaption.Width = 660
            Me.lblCaption2.Width = 660
            Me.lblDate.Width = 660
            Me.lblParas.Left = (Me.Width - Me.lblParas.Width) / 2
            Me.lblParas.Top = Me.Height / 2 - Me.lblParas.Height
            Me.lblCaption.Left = (Me.Width - Me.lblCaption.Width) / 2
            Me.lblCaption2.Left = (Me.Width - Me.lblCaption2.Width) / 2
            Me.lblDate.Left = (Me.Width - Me.lblCaption2.Width) / 2
            Me.lblCaption.Top = Me.Height / 2                       '+ Me.lblCaption.Height
            Me.lblCaption2.Top = Me.lblCaption.Top + Me.lblCaption.Height + 50
            Me.lblDate.Top = Me.lblCaption2.Top + Me.lblCaption2.Height + 30

            If TotNch > 5 Then
                StartDate = DateTime.Now.ToString("yyyy-MM-dd")
                StartTime = DateTime.Now.ToString("HH-mm")
            End If

            Me.lblDate.Text = StartDate & " " & StartTime
            Me.PictureBox1.Left = (Me.Width - Me.PictureBox1.Width) / 2
            Me.PictureBox1.Top = (Me.Height - Me.PictureBox1.Height) / 2 - 247

            OpenConfig2()
            OpenConfig210ch()
            fnFetch10ChDataArrayValue()
            isloaded = True
            SetCursorPos(640, 460)
            Me.Show()
            SendGainSet()
        Catch ex As Exception

        End Try
    End Sub

    Dim frmcap As String
    Dim bmp As Bitmap
    Dim bbmp As Bitmap
    Dim isstop As Boolean
    Dim offset As Integer, npoints As Integer

    Dim upt As Integer
    Dim pt0() As Point, pt1() As Point
    Dim sx As Single, sx1 As Single, sy As Single
    Dim v20() As Byte, v21() As Byte

    Public Sub frmMain_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        bmp.Dispose()
        bbmp.Dispose()
        objGraphics.Dispose()
        objGraphicsB.Dispose()
    End Sub
    Private Sub Load_Graph()
        'Me.Show()
        Me.Width = mewidth : Me.Height = meheight
        bmp = New Bitmap(mewidth / 2, meheight / 2)
        bbmp = New Bitmap(mewidth / 2, meheight / 2)
        objGraphics = Graphics.FromImage(bmp)
        objGraphics.Clear(Color.Black)
        objGraphicsB = Graphics.FromImage(bbmp)
        objGraphicsB.Clear(Color.FromArgb(10, 10, 10))
        objGraphicsFrm = Me.CreateGraphics
        SetVars2()
        cnfnam = "1.cnf"
        cnfnam = AppPath & "\1.cnf"
        OpenConfig()
        Me.Text = frmcap
        isstop = False
        SetCursorPos(640, 460)
        AcquireDPAll(0)
    End Sub
    Private Sub AcquireDPAll(Optional ByVal chnl As Integer = -1, Optional ByVal eras As Boolean = True)
        Dim i As Integer
        Dim i2 As Integer
        Dim x As Byte
        Dim r As Byte
        Dim vi As Integer
        Dim j1 As Integer
        Dim k As Integer = 0
        Dim j As Integer
        Dim strtj As Integer, endj As Integer
        If chnl = -1 Then strtj = 0 : endj = TotNch Else strtj = chnl : endj = chnl
        SetPlots(chnl)
        '        Me.Text = frmcap & " Acquiring"
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
        Dim k1 As Integer = 0
        Do While True
            If k = Loops Then
#If TORA Then
                If caltyp = 2 Then PlotCurvesT(v20, chnl, Not eras) Else PlotCurvesT(v20, chnl)
#ElseIf DEBUG2 Then
                If caltyp = 2 Then PlotCurvesT(v20, chnl, Not eras) Else PlotCurvesT(v20, chnl)
#Else
                If caltyp = 2 Then PlotCurves(v20, chnl, Not eras) Else PlotCurves(v20, chnl)
#End If
                k = 0
                If eras Then ReDim v20(upt2)
            End If
            If isstop Then
                keyprocessing = False
                Exit Do
            End If
            i2 = 0
            For j = strtj To endj
                If j > 9 Then j1 = j + 1 Else j1 = j
                upt = DataArr(j, 2)
                r = DataArr(j, 3)



                vi = DataArr(j, 1) + 2048 * j1
                offset = vi : npoints = upt

                '1st Channel
                BLOCKREADINFO(0) = (vi Mod 256) : vi \= 256
                BLOCKREADINFO(1) = (vi Mod 256) : vi \= 256
                '2nd Channel
                BLOCKREADINFO(2) = (vi Mod 256) : vi \= 256
                '3rd Channel
                BLOCKREADINFO(3) = vi
                vi = upt
                '4th Channel
                BLOCKREADINFO(4) = (vi Mod 256) : vi \= 256
                '5th Channel
                BLOCKREADINFO(5) = (vi Mod 256) : vi \= 256
                '6th Channel
                BLOCKREADINFO(6) = (vi Mod 256) : vi \= 256
                '7th Channel
                BLOCKREADINFO(7) = vi
                '8th Channel
                BLOCKREADINFO(8) = (vi Mod 256) : vi \= 256
                '9th Channel
                BLOCKREADINFO(9) = (vi Mod 256) : vi \= 256
                vi = DataArr(j, 1) + 2048 * j1
                offset = vi : npoints = upt
                '10th Channel
                BLOCKREADINFO(10) = (vi Mod 256) : vi \= 256
                BLOCKREADINFO(11) = vi

#If IWAVE Then
                DeviceIoControl(hADRDriver, ADR_IOCTL_BLOCK_READ_LOWER, BLOCKREADINFO, BLOCKREADINFO.GetUpperBound(0) + 1, BLOCKREADINFO, BLOCKREADINFO.GetUpperBound(0) + 1, 0, 0)
#ElseIf DEBUG2 Then
                ToraGetData()
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
            k1 += 1
            If k1 = 200 Then
                isstop = True
            End If
        Loop
#If IWAVE Then
        CloseHandle(hADRDriver)
#End If
    End Sub
    Sub ToraGetData()
        Dim i As Integer, j As Integer
        j = 12
        For i = offset To offset + npoints
            BLOCKREADINFO(j) = GPIO.read_dpram_value(i)       '0
            j = j + 1
        Next i
    End Sub

    Private Sub SetPlots(Optional ByVal chnl As Integer = -1)
        Dim i As Integer
        Dim t As Single, t2 As Single
        Dim g As Integer, g2 As Integer
        Dim stp As Single
        Dim strtj As Integer, endj As Integer

        If chnl = -1 Then strtj = 0 : endj = TotNch Else strtj = chnl : endj = chnl

        objGraphicsFrm.Clear(Color.Black)
        objGraphicsB.Clear(Color.FromArgb(10, 10, 10))

        stp = bmp.Height / 10
        t = bmp.Height                        '- 1
        For i = 0 To 10
            objGraphicsB.DrawLine(objBackPen, 0, t, bbmp.Width, t)
            objGraphicsB.DrawString(Format(i * 10, "0"), objfont, objBrush3, 10, t)
            t = t - stp
        Next i
        objGraphicsB.DrawLine(objBackPen, 0, bmp.Height - 1, bbmp.Width, bmp.Height - 1)

        For j = strtj To endj
            upt = DataArr(j, 2)
            sx = bmp.Width / upt
            g = DataArr(j, 4)
            t = bbmp.Height - DataArr(j, 6) '* sy
            g2 = DataArr(j, 7)
            t2 = bbmp.Height - DataArr(j, 9) '* sy
            objGraphicsB.DrawLine(objPens(j Mod 10), sx * g, t, sx * (g + DataArr(j, 5)), t)
            objGraphicsB.DrawLine(objPens(j Mod 10), sx * g2, t2, sx * (g2 + DataArr(j, 8)), t2)
        Next j

        For i = bbmp.Width / 10 To bbmp.Width Step bbmp.Width / 10
            objGraphicsB.DrawLine(objBackPen, i, 0, i, bbmp.Height)
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

    End Sub

    Private Sub PlotCurvesT(ByRef v() As Byte, Optional ByVal chnl As Integer = -1, Optional ByVal fillpoly As Boolean = False, Optional ByVal zoom As Single = 1.0)
        Static nc As Integer = 0
        Dim nz As Integer
        Dim i As Integer, i2 As Integer, i3 As Integer
        Dim gs As Integer, ge As Integer
        Dim j As Integer
        Dim rect As Rectangle
        Dim strtj As Integer, endj As Integer

        If chnl = -1 Then strtj = 0 : endj = TotNch Else strtj = chnl : endj = chnl
        rect = New Rectangle(0, meheight / 4, mewidth / 4, -meheight / 4)
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

            For i = 0 To UBound(pt0)
                pt0(i).Y = nz
            Next i
            i2 += 1
            Dim vmax As Integer = 0
            Dim vv As Integer, imax As Integer
            For i = 0 + 1 To upt - 1
                vv = v20(i2) : i2 += 1
                If i >= gs And i <= ge Then
                    If vmax < vv Then vmax = vv : imax = i
                End If
                vv = nz - vv
                i3 = Int(i * sx)
                If pt0(i3).Y > vv Then pt0(i3).Y = vv
            Next i
            pt0(0).Y = nz : pt0(UBound(pt0)).Y = nz
            objGraphics.DrawPolygon(objPens(j Mod 10), pt0)
            nc = (nc + 1) Mod dsteps
        Next j
        objGraphicsFrm.DrawImage(bmp, rect, 0, bmp.Height, bmp.Width / zoom, -bmp.Height, GraphicsUnit.Pixel, attr)
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class
