Imports System.IO
Imports System
Imports System.Windows
Imports System.Windows.Forms

Imports Microsoft.VisualBasic
Public Class frmGraph
#Const TORA = 1

    Dim frmcap As String
    Dim bmp As Bitmap
    Dim bbmp As Bitmap
    Dim isstop As Boolean
    Dim offset As Integer, npoints As Integer
    Dim upt As Integer
    Dim pt0() As Point, pt1() As Point
    Dim sx As Single, sx1 As Single, sy As Single
    Dim v20() As Byte, v21() As Byte

    Private Sub frmGraph_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        bmp.Dispose()
        bbmp.Dispose()
        objGraphics.Dispose()
        objGraphicsB.Dispose()
    End Sub

    Private Sub frmGraph_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

    End Sub

    Private Sub frmGraph_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.AutoScroll = False
            frmcap = "Graph"
            'Me.Show()
            Me.Text = frmcap & " - Please Wait"
            Me.Width = mewidth : Me.Height = meheight
            bmp = New Bitmap(mewidth / 2, meheight / 2)
            bbmp = New Bitmap(mewidth / 2, meheight / 2)
            objGraphics = Graphics.FromImage(bmp)
            objGraphics.Clear(Color.Black)
            objGraphicsB = Graphics.FromImage(bbmp)
            objGraphicsB.Clear(Color.FromArgb(10, 10, 10))
            objGraphicsFrm = Me.CreateGraphics
            SetVars2()
            Application.DoEvents()
            cnfnam = "1.cnf"
            cnfnam = AppPath & "\1.cnf"
            Application.DoEvents()
            Application.DoEvents()
            OpenConfig()
            Application.DoEvents()
            Me.Text = frmcap
            isstop = False
            Dim sf As SizeF = New SizeF(320, 240)
            Me.Show()
            SetCursorPos(640, 460)
            SendGainSet()
            AcquireDPAll(0)
        Catch ex As Exception

        End Try
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
            If k = Loops Then
#If TORA Then
                If caltyp = 2 Then PlotCurvesT(v20, chnl, Not eras) Else PlotCurvesT(v20, chnl)
#ElseIf DEBUG2 Then
                If caltyp = 2 Then PlotCurvesT(v20, chnl, Not eras) Else PlotCurvesT(v20, chnl)
#Else
                If caltyp = 2 Then PlotCurves(v20, chnl, Not eras) Else PlotCurves(v20, chnl)
#End If
                Application.DoEvents()
                k = 0
                If eras Then ReDim v20(upt2)
            End If
            If isstop Then
                '                PlotCurves(v20, chnl, Not eras)
                Application.DoEvents()
                keyprocessing = False
                Me.Text = frmcap & " Stopped"
                Exit Do
            End If
            i2 = 0
            For j = strtj To endj
                If j > 9 Then j1 = j + 1 Else j1 = j
                upt = DataArr(j, 2)
                r = DataArr(j, 3)
                vi = DataArr(j, 1) + 4096 * j1
                offset = vi : npoints = upt
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
        Loop
        Application.DoEvents()
#If IWAVE Then
        CloseHandle(hADRDriver)
#End If
    End Sub
    Sub ToraGetData()
        '        DeviceIoControl(hADRDriver, ADR_IOCTL_BLOCK_READ_LOWER, BLOCKREADINFO, BLOCKREADINFO.GetUpperBound(0) + 1, BLOCKREADINFO, BLOCKREADINFO.GetUpperBound(0) + 1, 0, 0)
        Dim i As Integer, j As Integer
        j = 8
        For i = offset To offset + npoints
            BLOCKREADINFO(j) = GPIO.read_dpram_value(i)       '0
            j = j + 1
        Next i
    End Sub
    Private Sub SetPlots(Optional ByVal chnl As Integer = -1)
        Dim i As Integer
        Dim t As Single
        Dim g As Integer
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
            '            sy = bmp.Height / ymax
            g = DataArr(j, 4)
            t = bbmp.Height - DataArr(j, 6) '* sy
            objGraphicsB.DrawLine(objPens(j Mod 10), sx * g, t, sx * (g + DataArr(j, 5)), t)
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
        Dim gs As Integer, ge As Integer, gs2 As Integer, ge2 As Integer
        Dim j As Integer
        Dim rect As Rectangle
        Dim strtj As Integer, endj As Integer

        If chnl = -1 Then strtj = 0 : endj = TotNch Else strtj = chnl : endj = chnl
        '        rect = New Rectangle(0, Me.ClientRectangle.Height, Me.ClientRectangle.Width, -Me.ClientRectangle.Height)
        rect = New Rectangle(0, meheight, mewidth, -meheight)
        'rect = New Rectangle(20, meheight - 40, mewidth - 80, -meheight + 40)
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
            objGraphics.DrawPolygon(objPens(j Mod 10), pt0)
            nc = (nc + 1) Mod dsteps
        Next j
        objGraphicsFrm.DrawImage(bmp, rect, 0, bmp.Height, bmp.Width / zoom, -bmp.Height, GraphicsUnit.Pixel, attr)
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class