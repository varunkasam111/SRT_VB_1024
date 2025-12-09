Imports System.IO
Imports System
Imports System.Windows
Imports System.Windows.Forms
Imports System.Windows.Forms.ListBox
Imports Microsoft.VisualBasic
Public Class frmData
    Dim curi As Integer, curj As Integer
    Dim maxi As Integer
    Dim delcode As Integer
    Dim isdeleting As Boolean
    Dim fllist As String
    Dim bb() As Byte
    Dim isValidIn As Boolean
    Dim keyprocess As Boolean = False
    Dim uplmt As Integer = 37
    Dim dspst(44) As String
    Dim sno As Integer
    Dim outst As String
    Dim lastk As Integer

    Private Sub ReadInfo(ByVal filename As String)
        If Not File.Exists(filename) Then Exit Sub

        Dim objSR As StreamReader = New StreamReader(flawcodes)
        fllist = objSR.ReadToEnd
        objSR.Close()
        If TotNch > 9 Then
            cmbLR.Items.Add("RIGHT")
            cmbLR.Items.Add("LEFT")
        ElseIf TotNch <= 5 Then
            cmbLR.Items.Add("WT")
        Else
            cmbLR.Items.Add("SRT")
        End If
        cmbLR.SelectedIndex = 0
        cmbProbe.Items.Add(" ")
        If File.Exists(probes) Then
            Dim objSRProbe As StreamReader = New StreamReader(probes)
            cmbProbe.Items.Clear()
            Dim data As String = ""
            Dim dataArr() As String
            Dim strCmbProbData As String = ""

            Do While Not objSRProbe.EndOfStream
                Try
                    data = objSRProbe.ReadLine().ToString.Trim
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
            objSRProbe.Close()
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

        txtMCNO.Text = Format(uno, "0000")  'MCNO 'Zaid
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


        Dim objFS = New FileStream(filename, FileMode.Open, FileAccess.Read)
        Dim objBR = New BinaryReader(objFS)

        txtMCNO.Text = objBR.ReadString                 '0
        txtMCNO.Text = Format(uno, "0000")   'MCNO 
        txtSets.Text = objBR.ReadString                 '1
        txtName.Text = objBR.ReadString                 '2
        txtDate.Text = objBR.ReadString                 '3
        txtTime.Text = objBR.ReadString                 '4
        txtDiv.Text = objBR.ReadString                  '5
        txtSec.Text = objBR.ReadString                  '6
        txtKm.Text = objBR.ReadString                  '7
        txtM.Text = objBR.ReadString                 '8
        txtTP.Text = objBR.ReadString                  '9
        txtRail.Text = objBR.ReadString                 '10
        txtRoad.Text = objBR.ReadString                 '11
        txtrailtype.Text = objBR.ReadString '12
        txtKM2.Text = objBR.ReadString                   '13
        txtMeter2.Text = objBR.ReadString                 '14
        txtTP2.Text = objBR.ReadString                  '15
        txtLoc1.Text = objBR.ReadString                 '16
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
        txtHM.Text = objBR.ReadString                  '28
        cmbTyp.Text = objBR.ReadString                  '29
        cmbFLoc.Text = objBR.ReadString                 '30
        txtlen.Text = objBR.ReadString                 '31
        cmbClass.Text = objBR.ReadString                '32
        cmbCode.Text = objBR.ReadString                 '33
        txtPH2.Text = objBR.ReadString                  '34
        txtHM2.Text = objBR.ReadString                  '35
        cmbTyp2.Text = objBR.ReadString                 '36
        cmbFLoc2.Text = objBR.ReadString                '37
        cmbClass2.Text = objBR.ReadString                '38
        txtlatitude.Text = objBR.ReadString               '39
        txtlongtitude.Text = objBR.ReadString '40
        txtdepth.Text = objBR.ReadString '41
        txtbp.Text = objBR.ReadString '42
        txtheight.Text = objBR.ReadString '43
        cmbCode2.Text = objBR.ReadString '44




        '        Dim st As String = cmbCode2.Text & "-" & cmbCris.SelectedIndex & "-" & txtRem.Text
        Dim st As String = objBR.ReadString             '39
        Dim sst() As String = st.Split("[")
        cmbCode2.Text = sst(0)
        If sst.Length > 1 Then
            cmbCris.Text = sst(1)
            txtRem.Text = sst(2)
        End If
        '        cmbCode2.Text = objBR.ReadString                '35
        bb = objBR.ReadBytes(objFS.Length - objFS.Seek(0, SeekOrigin.Current))
        objBR.Close()
        objFS.Close()

        'If TotNch = 9 Then
        '    cmbLR.Enabled = False                   '22
        '    cmbProbe.Enabled = False                '23
        'End If

    End Sub
    Private Sub SaveInfo(ByVal filename As String)

        Dim objFS = New FileStream(filename, FileMode.Create, FileAccess.Write)
        Dim objBW = New BinaryWriter(objFS)
        objBW.Write(txtMCNO.Text)                 '0
        objBW.Write(txtSets.Text)                 '1
        objBW.Write(txtName.Text)                 '2
        objBW.Write(txtDate.Text)                 '3
        objBW.Write(txtTime.Text)                 '4
        objBW.Write(txtDiv.Text)                  '5
        objBW.Write(txtSec.Text)                  '6
        objBW.Write(txtKm.Text)                  '7
        objBW.Write(txtM.Text)               '8
        objBW.Write(txtTP.Text)                   '9
        objBW.Write(txtRail.Text)                 '10
        objBW.Write(txtRoad.Text)                 '11
        objBW.Write(txtrailtype.Text)                 '12

        objBW.Write(txtKM2.Text)                   '13
        objBW.Write(txtMeter2.Text)                  '14
        objBW.Write(txtTP2.Text)                  '15
        objBW.Write(txtLoc1.Text)                 '16
        objBW.Write(txtLoc2.Text)                 '17
        objBW.Write(txtLoc3.Text)                 '18
        objBW.Write(txtSta1.Text)                 '19 
        objBW.Write(txtSta2.Text)                 '20
        objBW.Write(cmbMask1.Text)                '21
        objBW.Write(cmbMask2.Text)                '22
        objBW.Write(cmbMask3.Text)                '23
        objBW.Write(txtMask4.Text)                '24
        objBW.Write(cmbLR.Text)                   '25
        objBW.Write(cmbProbe.Text)                '26
        objBW.Write(txtPH.Text)                   '27
        objBW.Write(txtHM.Text)                   '28
        objBW.Write(cmbTyp.Text)                  '29
        objBW.Write(cmbFLoc.Text)                 '30
        objBW.Write(txtlen.Text)                 '31
        objBW.Write(cmbClass.Text)                '32
        objBW.Write(cmbCode.Text)                 '33
        objBW.Write(txtPH2.Text)                  '34
        objBW.Write(txtHM2.Text)                  '35
        objBW.Write(cmbTyp2.Text)                 '36
        objBW.Write(cmbFLoc2.Text)                '37
        objBW.Write(cmbClass2.Text)               '38
        objBW.Write(txtlatitude.Text)               '39
        objBW.Write(txtlongtitude.Text)               '40
        objBW.Write(txtdepth.Text)               '41
        objBW.Write(txtbp.Text)               '42
        objBW.Write(txtheight.Text)               '


        objBW.Write(cmbCode2.Text)               '



        '        objBW.Write(cmbCode2.Text)                '36

        Dim st As String = cmbCode2.Text & "[" & cmbCris.Text & "[" & txtRem.Text
        objBW.Write(st)                '35++
        objBW.Write(bb)



        objBW.Close()
        objFS.Close()
    End Sub
    Private Sub ShowMenu(ByVal ShoworHide As Boolean)
        lblMenu1.Visible = ShoworHide : lblMenu2.Visible = ShoworHide
        lblMenu3.Visible = ShoworHide : lblMenu4.Visible = ShoworHide
        lblMenu5.Visible = ShoworHide : lblMenu6.Visible = ShoworHide
        lblMenu7.Visible = ShoworHide
    End Sub
    Private Sub frmData_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim k As Integer
        k = e.KeyCode
        If isdeleting Then
            delcode = k
            e.Handled = True
            Exit Sub
        End If
        If (Not IsFuncKey(k)) And (Not IsLfRt(k)) And (Not IsUpDn(k)) Then isValidIn = True : e.Handled = False : Exit Sub
        If keyprocess Then isValidIn = False : e.Handled = True : Exit Sub

        If pnlOpts.Visible Then
            If k = EsKey Then
                curj = 1
                ListBox2.Focus()
                PictureBox1.Visible = False
                Panel2.Visible = False
                pnlOpts.Visible = False
                ShowMenu(True)
                e.Handled = True
                keyprocess = False
                Exit Sub
            ElseIf k = FKeyRun Then

                If lblOpts0.Text = "DELETE" Then
                    datafile = RootDataPath & "\" & ListBox1.SelectedItem & "\" & lblFile.Text
                    FileDelete()
                ElseIf lblOpts0.Text = "DELETE ALL" Then
                    DelDirectory(RootDataPath)
                    ListBox2.Items.Clear()
                    lblFile.Text = ""
                    DirList()
                    Me.Close()
                ElseIf lblOpts0.Text = "EDIT" Then

                    Dim df As String = RootDataPath & "\" & ListBox1.SelectedItem & "\" & ListBox2.SelectedItem
                    If File.Exists(df) Then File.Delete(df)
                    SaveInfo(df)
                End If
                curj = 1

                PictureBox1.Visible = False
                Panel2.Visible = False
                pnlOpts.Visible = False
                ShowMenu(True)
                e.Handled = True
                keyprocess = False
                Panel3.Focus()
                ListBox2.Focus()
                Application.DoEvents()
                Exit Sub
            End If
        End If
        isValidIn = False
        keyprocess = True
        If ListBox1.Items.Count = 0 And k <> MKey7 Then
            keyprocess = False
            Exit Sub
        End If
        Select Case k
            Case MKey1
                If ListBox2.Items.Count <> 0 Then

                    datafile = RootDataPath & "\" & ListBox1.SelectedItem & "\" & ListBox2.SelectedItem
                    Dim st As String = Microsoft.VisualBasic.Right(datafile, 10)
                    If Microsoft.VisualBasic.Left(st, 1) = "_" Then
                        frmCalib.curi = Val(Mid(st, 2))
                    Else
                        frmCalib.curi = 0
                    End If
                    If InStr(ListBox2.SelectedItem, ".prs") Then
                        caltyp = 1
                    ElseIf InStr(ListBox2.SelectedItem, ".prv") Then
                        '  ElseIf InStr(ListBox2.SelectedItem, ".jpg") Then
                        caltyp = 3
                    ElseIf InStr(ListBox2.SelectedItem, ".prw") Then
                        caltyp = 5
                        grptyp = 0
                    ElseIf InStr(ListBox2.SelectedItem, ".prh") Then
                        caltyp = 5
                        grptyp = 0
                    ElseIf InStr(ListBox2.SelectedItem, ".prc") Then
                        caltyp = 5
                        grptyp = 1
                    ElseIf InStr(ListBox2.SelectedItem, ".bmp") Then
                        caltyp = 15
                    ElseIf InStr(ListBox2.SelectedItem, ".BMP") Then
                        caltyp = 15
                    ElseIf InStr(ListBox2.SelectedItem, ".jpg") Then
                        caltyp = 15
                    ElseIf InStr(ListBox2.SelectedItem, ".jpeg") Then
                        caltyp = 15
                    End If
                    frmCalib.ShowDialog()
                Else

                    Me.Text = "No Files are Recorded"
                    ' '''MessageBox.Show("No Files are Recorded", "Paras Electronics")

                End If

            Case MKey2
                FileTransfer(True)
            Case MKey3
                FileTransfer(False)
            Case MKey4
                If lblFile.Text = "" Then Exit Select
                ShowMenu(False)
                pnlOpts.Visible = True
                PictureBox1.Visible = True
                lblOpts0.Text = "DELETE"
                lblOpts1.Text = "File: " & lblFile.Text
                lblOpts2.Text = "Press RUN " & vbCrLf & "to Delete"
                lblOpts3.Text = "Press ESC " & vbCrLf & "to Cancel"
            Case MKey5

                ShowMenu(False)
                pnlOpts.Visible = True
                PictureBox1.Visible = True
                lblOpts0.Text = "DELETE ALL"
                lblOpts1.Text = "Files in Folder: " & vbCrLf & MCNO
                lblOpts2.Text = "Press RUN " & vbCrLf & "to Delete"
                lblOpts3.Text = "Press ESC " & vbCrLf & "to Cancel"
            Case MKey6
                Dim df As String = RootDataPath & "\" & ListBox1.SelectedItem & "\" & ListBox2.SelectedItem
                Dim validation() As String = df.Split(".")
                If validation(1) = "JPG" Or validation(1) = "jpg" Then
                    Cmblistfiles.Focus()
                    Me.Show()
                Else
                    'curi = Val(Microsoft.VisualBasic.Right(df, 9)) - 1
                    Dim arrChNoWithExt As String() = df.Split("_")

                    If arrChNoWithExt.Length > 2 Then
                        Dim arrChNo As String() = arrChNoWithExt(2).Split(".")

                        If arrChNo.Length > 0 Then
                            curi = Convert.ToInt32(arrChNo(0)) - 1
                        End If
                    End If

                    Dim strChannelNo As String = ""

                    If curi < 10 Then
                        strChannelNo = "0" & (curi + 1)
                    End If

                    txtCh.Text = strChannelNo
                    ShowMenu(False)
                    ReadInfo(df)
                    pnlOpts.Visible = True
                    lblOpts0.Text = "EDIT"
                    lblOpts1.Text = "File: " & vbCrLf & lblFile.Text
                    lblOpts2.Text = "Press RUN " & vbCrLf & "to Save"
                    lblOpts3.Text = "Press ESC " & vbCrLf & "to Cancel"
                    Panel2.Visible = True
                    curj = 12
                    SetTextBox()
                End If
            Case MKey7
                Me.Close()
            Case FKeyUp
                If curj = 0 Then
                    'If Cmblistfiles.SelectedIndex > 0 Then
                    '    Cmblistfiles.SelectedIndex = Cmblistfiles.SelectedIndex - 1
                    'End If
                ElseIf curj = 1 Then
                    If ListBox1.SelectedIndex > 0 Then
                        ListBox1.SelectedIndex = ListBox1.SelectedIndex
                    End If
                End If

                Select Case curj
                    Case 0 : If Cmblistfiles.SelectedIndex > 0 Then Cmblistfiles.SelectedIndex -= 1
                    Case 1 : If ListBox1.SelectedIndex > 0 Then ListBox1.SelectedIndex -= 1
                    Case 2 : If ListBox2.SelectedIndex > 0 Then ListBox2.SelectedIndex -= 1
                    Case 17 : If cmbMask1.SelectedIndex > 0 Then cmbMask1.SelectedIndex -= 1
                    Case 18 : If cmbMask2.SelectedIndex > 0 Then cmbMask2.SelectedIndex -= 1
                    Case 19 : If cmbMask3.SelectedIndex > 0 Then cmbMask3.SelectedIndex -= 1
                    Case 21 : If cmbLR.SelectedIndex > 0 Then cmbLR.SelectedIndex -= 1
                    Case 22 : If cmbProbe.SelectedIndex > 0 Then cmbProbe.SelectedIndex -= 1
                    Case 24 : If cmbTyp.SelectedIndex > 0 Then cmbTyp.SelectedIndex -= 1
                    Case 25 : If cmbFLoc.SelectedIndex > 0 Then cmbFLoc.SelectedIndex -= 1
                    Case 28 : If cmbClass.SelectedIndex > 0 Then cmbClass.SelectedIndex -= 1
                    Case 29 : If cmbCode.SelectedIndex > 0 Then cmbCode.SelectedIndex -= 1
                    Case 32 : If cmbTyp2.SelectedIndex > 0 Then cmbTyp2.SelectedIndex -= 1
                    Case 33 : If cmbFLoc2.SelectedIndex > 0 Then cmbFLoc2.SelectedIndex -= 1
                    Case 34 : If cmbClass2.SelectedIndex > 0 Then cmbClass2.SelectedIndex -= 1
                    Case 35 : If cmbCode2.SelectedIndex > 0 Then cmbCode2.SelectedIndex -= 1
                End Select
            Case FKeyLR
                If chkCRIS.CheckState = CheckState.Checked Then
                    chkCRIS.CheckState = CheckState.Unchecked
                    chkCRIS.Visible = False
                Else
                    chkCRIS.CheckState = CheckState.Checked
                    chkCRIS.Visible = True
                End If
            Case FKeyDn
                If curj = 0 Then
                    'If Cmblistfiles.SelectedIndex < Cmblistfiles.Items.Count - 1 Then
                    '    Cmblistfiles.SelectedIndex = Cmblistfiles.SelectedIndex + 1
                    'End If
                ElseIf curj = 1 Then
                    If ListBox1.SelectedIndex < ListBox1.Items.Count - 1 Then
                        ListBox1.SelectedIndex = ListBox1.SelectedIndex
                    End If
                End If
                Select Case curj
                    Case 0 : If Cmblistfiles.SelectedIndex < Cmblistfiles.Items.Count - 1 Then Cmblistfiles.SelectedIndex += 1
                    Case 1 : If ListBox1.SelectedIndex < ListBox1.Items.Count - 1 Then ListBox1.SelectedIndex += 1
                    Case 2 : If ListBox2.SelectedIndex < ListBox2.Items.Count - 1 Then ListBox2.SelectedIndex += 1
                    Case 17 : If cmbMask1.SelectedIndex < cmbMask1.Items.Count - 1 Then cmbMask1.SelectedIndex += 1
                    Case 18 : If cmbMask2.SelectedIndex < cmbMask2.Items.Count - 1 Then cmbMask2.SelectedIndex += 1
                    Case 19 : If cmbMask3.SelectedIndex < cmbMask3.Items.Count - 1 Then cmbMask3.SelectedIndex += 1
                    Case 21 : If cmbLR.SelectedIndex < cmbLR.Items.Count - 1 Then cmbLR.SelectedIndex += 1
                    Case 22 : If cmbProbe.SelectedIndex < cmbProbe.Items.Count - 1 Then cmbProbe.SelectedIndex += 1
                    Case 24 : If cmbTyp.SelectedIndex < cmbTyp.Items.Count - 1 Then cmbTyp.SelectedIndex += 1
                    Case 25 : If cmbFLoc.SelectedIndex < cmbFLoc.Items.Count - 1 Then cmbFLoc.SelectedIndex += 1
                    Case 28 : If cmbClass.SelectedIndex < cmbClass.Items.Count - 1 Then cmbClass.SelectedIndex += 1
                    Case 29 : If cmbCode.SelectedIndex < cmbCode.Items.Count - 1 Then cmbCode.SelectedIndex += 1
                    Case 32 : If cmbTyp2.SelectedIndex < cmbTyp2.Items.Count - 1 Then cmbTyp2.SelectedIndex += 1
                    Case 33 : If cmbFLoc2.SelectedIndex < cmbFLoc2.Items.Count - 1 Then cmbFLoc2.SelectedIndex += 1
                    Case 34 : If cmbClass2.SelectedIndex < cmbClass2.Items.Count - 1 Then cmbClass2.SelectedIndex += 1
                    Case 35 : If cmbCode2.SelectedIndex < cmbCode2.Items.Count - 1 Then cmbCode2.SelectedIndex += 1
                End Select
            Case FkeyLf
                curj = curj - 1
                If Not Panel2.Visible Then
                    If curj < 1 Then curj = 0
                    curi = 1
                    If curj = 0 Then
                        '  ListBox1.Focus()
                        Cmblistfiles.Focus()
                        '                    ListBox1.SelectedIndex = curi
                    ElseIf curj = 1 Then
                        ListBox1.Focus()
                    Else
                        ListBox2.Focus()
                        '                   ListBox2.SelectedIndex = curi
                    End If
                Else
                    If curj < 12 Then curj = 12
                    If curj > uplmt Then curj = uplmt
                    If TotNch = 9 Then
                        'If curj = 21 Then curj = 19
                    Else
                        'If curj = 21 Then curj = 20
                        'If curj = 23 Then curj = 22
                        If curj = 25 Then curj = 24
                    End If
                    SetTextBox()
                End If

            Case FkeyRt
                curj = curj + 1
                If Not Panel2.Visible Then
                    If curj > 2 Then curj = 2
                    curi = 0
                    ' If curj = 0 Then ListBox1.Focus() Else ListBox2.Focus()
                    If curj = 0 Then
                        Cmblistfiles.Focus()
                    ElseIf curj = 1 Then
                        ListBox1.Focus()
                    Else
                        ListBox2.Focus()

                    End If
                Else
                    If curj < 13 Then curj = 13
                    If curj > uplmt Then curj = uplmt
                    If TotNch = 9 Then
                        '       If curj = 21 Then curj = 23
                    Else
                        'If curj = 21 Then curj = 22
                        'If curj = 23 Then curj = 24
                        If curj = 26 Then curj = 27
                    End If
                    SetTextBox()
                End If
        End Select
        lastk = k
        keyprocess = False
        e.Handled = True
    End Sub
    'Private Sub frmData_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
    '    Dim k As Integer
    '    k = e.KeyCode
    '    If isdeleting Then
    '        delcode = k
    '        e.Handled = True
    '        Exit Sub
    '    End If
    '    If (Not IsFuncKey(k)) And (Not IsLfRt(k)) And (Not IsUpDn(k)) Then isValidIn = True : e.Handled = False : Exit Sub
    '    '        If ((k >= 48 And k <= 57) Or k = 8 Or k = KeyDeci) Then e.Handled = False : Exit Sub
    '    If keyprocess Then isValidIn = False : e.Handled = True : Exit Sub

    '    If k = EsKey Then
    '        If (Panel2.Visible Or lblDel.Visible Or lblDelAll.Visible) Then
    '            Panel2.Visible = False
    '            lblDel.Visible = False
    '            lblDelAll.Visible = False
    '            lblMenu6.Text = "Edit"
    '            ShowMenu(True)
    '            curj = 1
    '            ListBox2.Focus()
    '        End If
    '        e.Handled = True
    '        Exit Sub
    '    End If

    '    If (Panel2.Visible And (k <> MKey6)) Or _
    '       (lblDel.Visible And (k <> MKey4)) Or _
    '       (lblDelAll.Visible And (k <> MKey5)) Then
    '        e.Handled = True
    '        Panel2.Visible = False
    '        lblDel.Visible = False
    '        lblDelAll.Visible = False
    '        Exit Sub
    '    End If

    '    isValidIn = False
    '    keyprocess = True
    '    Select Case k
    '        Case MKey1
    '            datafile = RootDataPath & "\" & ListBox1.SelectedItem & "\" & ListBox2.SelectedItem
    '            Dim st As String = Microsoft.VisualBasic.Right(datafile, 10)
    '            If Microsoft.VisualBasic.Left(st, 1) = "_" Then
    '                frmCalib.curi = Val(Mid(st, 2))
    '            Else
    '                frmCalib.curi = 0
    '            End If
    '            If InStr(ListBox2.SelectedItem, ".prs") Then
    '                caltyp = 1
    '            ElseIf InStr(ListBox2.SelectedItem, ".prv") Then
    '                caltyp = 3
    '            ElseIf InStr(ListBox2.SelectedItem, ".prw") Then
    '                caltyp = 5
    '                grptyp = 0
    '            ElseIf InStr(ListBox2.SelectedItem, ".prh") Then
    '                caltyp = 5
    '                grptyp = 0
    '            ElseIf InStr(ListBox2.SelectedItem, ".prc") Then
    '                caltyp = 5
    '                grptyp = 1
    '            End If
    '            frmCalib.ShowDialog()
    '        Case MKey2
    '            FileTransfer(True)
    '        Case MKey3
    '            FileTransfer(False)
    '        Case MKey4
    '            If lblFile.Text = "" Then Exit Select
    '            If Not lblDel.Visible Then
    '                ShowMenu(False)
    '                lblMenu4.Visible = True
    '                lblDel.Visible = True
    '                lblDel.Text = "To Delete " & lblFile.Text & vbCrLf & " Press Del Key Again" & vbCrLf & "Press ESC to cancel"
    '            Else
    '                datafile = RootDataPath & "\" & ListBox1.SelectedItem & "\" & lblFile.Text
    '                FileDelete()
    '                lblDel.Visible = False
    '                ShowMenu(True)
    '            End If
    '        Case MKey5
    '            If Not lblDelAll.Visible Then
    '                ShowMenu(False)
    '                lblMenu5.Visible = True
    '                lblDelAll.Visible = True
    '                lblDelAll.Text = "To Delete All Files in Folder" & vbCrLf & "Press DelAll Key Again" & vbCrLf & "Press ESC to cancel"
    '            Else
    '                DelDirectory(RootDataPath)
    '                ListBox2.Items.Clear()
    '                DirList()
    '                lblDelAll.Visible = False
    '                ShowMenu(True)
    '            End If
    '        Case MKey6
    '            If Not Panel2.Visible Then
    '                Dim df As String = RootDataPath & "\" & ListBox1.SelectedItem & "\" & ListBox2.SelectedItem
    '                curi = Val(Microsoft.VisualBasic.Right(df, 9)) - 1
    '                txtCh.Text = Format(curi + 1, "0")
    '                ShowMenu(False)
    '                lblMenu6.Visible = True
    '                lblMenu6.Text = "Save"
    '                ReadInfo(df)
    '                Panel2.Visible = True
    '                curj = 12
    '                SetTextBox()
    '            Else
    '                Dim df As String = RootDataPath & "\" & ListBox1.SelectedItem & "\" & ListBox2.SelectedItem
    '                If File.Exists(df) Then File.Delete(df)
    '                SaveInfo(df)
    '                ShowMenu(True)
    '                Panel2.Visible = False
    '                lblMenu6.Text = "Edit"
    '                curj = 0
    '                '                    SetTextBox()
    '            End If
    '        Case MKey7
    '            Me.Close()
    '        Case FKeyUp
    '            'If curj = 0 Then
    '            '    If ListBox1.SelectedIndex > 0 Then
    '            '        ListBox1.SelectedIndex = ListBox1.SelectedIndex - 1
    '            '    End If
    '            'ElseIf curj = 1 Then
    '            '    If ListBox2.SelectedIndex > 0 Then
    '            '        ListBox2.SelectedIndex = ListBox2.SelectedIndex - 1
    '            '    End If
    '            'End If

    '            Select Case curj
    '                Case 0 : If ListBox1.SelectedIndex > 0 Then ListBox1.SelectedIndex -= 1
    '                Case 1 : If ListBox2.SelectedIndex > 0 Then ListBox2.SelectedIndex -= 1
    '                Case 17 : If cmbMask1.SelectedIndex > 0 Then cmbMask1.SelectedIndex -= 1
    '                Case 18 : If cmbMask2.SelectedIndex > 0 Then cmbMask2.SelectedIndex -= 1
    '                Case 21 : If cmbLR.SelectedIndex > 0 Then cmbLR.SelectedIndex -= 1
    '                Case 22 : If cmbProbe.SelectedIndex > 0 Then cmbProbe.SelectedIndex -= 1
    '                Case 23 : If cmbTyp.SelectedIndex > 0 Then cmbTyp.SelectedIndex -= 1
    '                Case 24 : If cmbFLoc.SelectedIndex > 0 Then cmbFLoc.SelectedIndex -= 1
    '                Case 25 : If cmbClass.SelectedIndex > 0 Then cmbClass.SelectedIndex -= 1
    '                Case 26 : If cmbCode.SelectedIndex > 0 Then cmbCode.SelectedIndex -= 1
    '                Case 29 : If cmbTyp2.SelectedIndex > 0 Then cmbTyp2.SelectedIndex -= 1
    '                Case 30 : If cmbFLoc2.SelectedIndex > 0 Then cmbFLoc2.SelectedIndex -= 1
    '                Case 31 : If cmbClass2.SelectedIndex > 0 Then cmbClass2.SelectedIndex -= 1
    '                Case 32 : If cmbCode2.SelectedIndex > 0 Then cmbCode2.SelectedIndex -= 1
    '            End Select
    '        Case FKeyLR
    '            If chkCRIS.CheckState = CheckState.Checked Then
    '                chkCRIS.CheckState = CheckState.Unchecked
    '                chkCRIS.Visible = False
    '            Else
    '                chkCRIS.CheckState = CheckState.Checked
    '                chkCRIS.Visible = True
    '            End If
    '        Case FKeyDn
    '            'If curj = 0 Then
    '            '    If ListBox1.SelectedIndex < ListBox1.Items.Count - 1 Then
    '            '        ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
    '            '    End If
    '            'ElseIf curj = 1 Then
    '            '    If ListBox2.SelectedIndex < ListBox2.Items.Count - 1 Then
    '            '        ListBox2.SelectedIndex = ListBox2.SelectedIndex + 1
    '            '    End If
    '            'End If
    '            Select Case curj
    '                Case 0 : If ListBox1.SelectedIndex < ListBox1.Items.Count - 1 Then ListBox1.SelectedIndex += 1
    '                Case 1 : If ListBox2.SelectedIndex < ListBox2.Items.Count - 1 Then ListBox2.SelectedIndex += 1
    '                Case 17 : If cmbMask1.SelectedIndex < cmbMask1.Items.Count - 1 Then cmbMask1.SelectedIndex += 1
    '                Case 18 : If cmbMask2.SelectedIndex < cmbMask2.Items.Count - 1 Then cmbMask2.SelectedIndex += 1
    '                Case 21 : If cmbLR.SelectedIndex < cmbLR.Items.Count - 1 Then cmbLR.SelectedIndex += 1
    '                Case 22 : If cmbProbe.SelectedIndex < cmbProbe.Items.Count - 1 Then cmbProbe.SelectedIndex += 1
    '                Case 23 : If cmbTyp.SelectedIndex < cmbTyp.Items.Count - 1 Then cmbTyp.SelectedIndex += 1
    '                Case 24 : If cmbFLoc.SelectedIndex < cmbFLoc.Items.Count - 1 Then cmbFLoc.SelectedIndex += 1
    '                Case 25 : If cmbClass.SelectedIndex < cmbClass.Items.Count - 1 Then cmbClass.SelectedIndex += 1
    '                Case 26 : If cmbCode.SelectedIndex < cmbCode.Items.Count - 1 Then cmbCode.SelectedIndex += 1
    '                Case 29 : If cmbTyp2.SelectedIndex < cmbTyp2.Items.Count - 1 Then cmbTyp2.SelectedIndex += 1
    '                Case 30 : If cmbFLoc2.SelectedIndex < cmbFLoc2.Items.Count - 1 Then cmbFLoc2.SelectedIndex += 1
    '                Case 31 : If cmbClass2.SelectedIndex < cmbClass2.Items.Count - 1 Then cmbClass2.SelectedIndex += 1
    '                Case 32 : If cmbCode2.SelectedIndex < cmbCode2.Items.Count - 1 Then cmbCode2.SelectedIndex += 1
    '            End Select
    '        Case FkeyLf
    '            curj = curj - 1
    '            If Not Panel2.Visible Then
    '                If curj < 0 Then curj = 0
    '                curi = 0
    '                If curj = 0 Then
    '                    ListBox1.Focus()
    '                    '                    ListBox1.SelectedIndex = curi
    '                Else
    '                    ListBox2.Focus()
    '                    '                   ListBox2.SelectedIndex = curi
    '                End If
    '            Else
    '                If curj < 12 Then curj = 12
    '                If curj > uplmt Then curj = uplmt
    '                If TotNch = 9 Then
    '                    If curj = 21 Then curj = 19
    '                Else
    '                    If curj = 21 Then curj = 20
    '                    If curj = 23 Then curj = 22
    '                End If
    '                SetTextBox()
    '            End If
    '        Case FkeyRt
    '            curj = curj + 1
    '            If Not Panel2.Visible Then
    '                If curj > 1 Then curj = 1
    '                curi = 0
    '                If curj = 0 Then ListBox1.Focus() Else ListBox2.Focus()
    '            Else
    '                If curj < 12 Then curj = 12
    '                If curj > uplmt Then curj = uplmt
    '                If TotNch = 9 Then
    '                    If curj = 21 Then curj = 23
    '                Else
    '                    If curj = 21 Then curj = 22
    '                    If curj = 23 Then curj = 24
    '                End If
    '                SetTextBox()
    '            End If
    '    End Select
    '    lastk = k
    '    keyprocess = False
    '    e.Handled = True
    'End Sub
    Public Sub SetTextBox()
        Try
            If curj < 10 Then curj = 10
            If curj > 37 Then curj = 38
            If TotNch <= 5 Then
                If curj > 25 Then curj = 25
            End If
            Select Case curj
                Case 12 : txtTP2.Focus() : txtTP2.SelectionStart = txtTP2.TextLength
                Case 13 : txtSta1.Focus() : txtSta1.SelectionStart = txtSta1.TextLength
                Case 14 : txtLoc1.Focus() : txtLoc1.SelectionStart = txtLoc1.TextLength
                Case 15 : txtLoc2.Focus() : txtLoc2.SelectionStart = txtLoc2.TextLength
                Case 16 : txtSta2.Focus() : txtSta2.SelectionStart = txtSta2.TextLength
                Case 17 : cmbMask1.Focus()
                Case 18 : cmbMask2.Focus()
                Case 19 : cmbMask3.Focus()
                Case 20 : txtMask4.Focus() : txtMask4.SelectionStart = txtMask4.TextLength
                Case 21 : cmbLR.Focus()
                Case 22 : cmbProbe.Focus()
                Case 23 : txtCh.Focus() : txtCh.SelectionStart = txtCh.TextLength
                Case 24 : cmbTyp.Focus()
                Case 25 : cmbFLoc.Focus()
                Case 27 : txtlen.Focus() : txtlen.SelectionStart = txtlen.TextLength
                Case 28 : cmbClass.Focus()
                Case 29 : cmbCode.Focus()
                Case 30 : txtPH2.Focus() : txtPH2.SelectionStart = txtPH2.TextLength
                Case 31 : txtHM2.Focus() : txtHM2.SelectionStart = txtHM2.TextLength
                Case 32 : cmbTyp2.Focus()
                Case 33 : cmbFLoc2.Focus()
                Case 34 : cmbClass2.Focus()
                Case 35 : cmbCode2.Focus()
                Case 36 : txtRem.Focus() : txtRem.SelectionStart = txtRem.TextLength

            End Select
        Catch ex As Exception

            'MessageBox.Show(ex.ToString(), "frm4_setTextbox()")

        End Try
    End Sub
    Public Sub DelDirectory(ByVal SourceDirectory As String)
        Try
            Dim i As Integer, j As Integer
            Dim source As DirectoryInfo = New DirectoryInfo(SourceDirectory)

            'Determine whether the source directory exists.
            If (source.Exists = False) Then
                Return
            End If

            Dim subs As DirectoryInfo() = source.GetDirectories()
            For i = 0 To subs.Length - 1
                Dim sourceFiles As FileInfo() = subs(i).GetFiles()
                For j = 0 To sourceFiles.Length - 1
                    File.Delete(sourceFiles(j).FullName)
                Next j
                subs(i).Delete()
            Next i
            subs = Nothing
            source = Nothing
        Catch ex As Exception
            'MessageBox.Show(ex.ToString(), "frm4_Deldirectory()")
        End Try
    End Sub
    Private Function RemoveGT127(ByVal st As String)
        Dim i As Integer
        Dim s As String = ""
        Dim c As String
        For i = 0 To st.Length - 1
            c = st.Substring(i, 1)
            If Asc(c) < 128 Then
                s = s & c
            End If
        Next
        Return s
    End Function
    Public Sub CopyDirectory(ByVal SourceDirectory As String, ByVal TargetDirectory As String, ByVal isdel As Boolean)
        Try
            Dim source As DirectoryInfo = New DirectoryInfo(SourceDirectory)
            Dim target As DirectoryInfo = New DirectoryInfo(TargetDirectory)

            'Determine whether the source directory exists.
            If (source.Exists = False) Then
                Return
            End If
            If (target.Exists = False) Then
                target.Create()
            End If

            Dim targetJPG As DirectoryInfo = New DirectoryInfo(TargetDirectory & "\jpg")
            If (targetJPG.Exists = False) Then
                targetJPG.Create()
            End If

            'Copy files.
            Dim sourceFiles As FileInfo() = source.GetFiles()
            Dim i, j As Integer
            If chkCRIS.CheckState = CheckState.Checked Then
                Dim fn As String = source.FullName & "\dirinfo.txt"
                Dim strt As String = "0"
                Dim nd As String = "0"
                Dim tot As String = "0"
                If File.Exists(fn) Then
                    Dim sr As StreamReader = New StreamReader(fn)
                    Dim sst() As String = sr.ReadLine.Split("-")
                    Dim ii As Integer = Val(sst(0))
                    strt = ii.ToString("G")
                    sst = sr.ReadLine.Split("-")
                    ii = Val(sst(0))
                    nd = ii.ToString("G")
                    sst = sr.ReadLine.Split("-")
                    ii = Val(sst(0))
                    tot = ii.ToString("G")
                    sr.Close()
                End If
                outst = ""
                For i = 0 To sourceFiles.Length - 1
                    datafile = sourceFiles(i).FullName
                    If InStr(datafile, ".txt") = 0 And InStr(datafile, ".csv") = 0 Then
                        sno = Format(i + 1, "0")
                        WriteFreezeData2(strt, nd, tot)
                    End If
                Next i
                Dim fn2 As String = source.FullName & "\report.csv"
                Dim sw As StreamWriter = New StreamWriter(fn2)
                sw.Write(outst)
                sw.Close()
            End If

            For i = 0 To sourceFiles.Length - 1
                Dim arrFileInfo() As String = sourceFiles(i).FullName.Split(".")
                Dim fileExtension As String = arrFileInfo(arrFileInfo.Length - 1).ToString()

                If fileExtension.ToUpper() = "JPG" Then
                    File.Copy(sourceFiles(i).FullName, target.FullName + "\\jpg\\" + sourceFiles(i).Name, True)
                End If
            Next i

            For i = 0 To sourceFiles.Length - 1
                Dim arrFileInfo() As String = sourceFiles(i).FullName.Split(".")
                Dim fileExtension As String = arrFileInfo(arrFileInfo.Length - 1).ToString()

                If fileExtension.ToUpper() <> "JPG" Then
                    File.Copy(sourceFiles(i).FullName, target.FullName + "\\" + sourceFiles(i).Name, True)
                    If isdel Then File.Delete(sourceFiles(i).FullName)
                End If
            Next i


            'For i = 0 To sourceFiles.Length - 1
            '    Dim arrFileInfo() As String = sourceFiles(i).FullName.Split(".")
            '    Dim fileExtension As String = arrFileInfo(arrFileInfo.Length - 1).ToString()

            '    If fileExtension.ToUpper() = "JPG" Then
            '        File.Delete(target.FullName + "\\" + sourceFiles(i).Name)
            '    End If
            'Next i

            'Copy directories.
            Dim sourceDirectories As DirectoryInfo() = source.GetDirectories()
            For j = 0 To sourceDirectories.Length - 1
                CopyDirectory(sourceDirectories(j).FullName, target.FullName + "\\" + sourceDirectories(j).Name, isdel)

                If isdel Then Directory.Delete(sourceDirectories(j).FullName, True)
            Next j
            source = Nothing
            target = Nothing
        Catch ex As Exception
            'MessageBox.Show(ex.ToString(), "frm4_CopyDirectory()")
        End Try
    End Sub
    Public Sub ReadFreezeData()
        Try
            Dim i As Integer, j As Integer

            Dim objFS As FileStream = New FileStream(datafile, FileMode.Open, FileAccess.Read)
            Dim objBR As BinaryReader = New BinaryReader(objFS)
            For i = 0 To dspst.GetUpperBound(0)
                dspst(i) = objBR.ReadString
            Next i
            For i = 0 To DataArr.GetUpperBound(0)
                For j = 0 To DataArr.GetUpperBound(1)
                    DataArr(i, j) = objBR.ReadInt32
                Next j
            Next i
            j = Val(Microsoft.VisualBasic.Right(datafile, 9)) - 1
            curi = j
            If InStr(datafile, ".prs") <> 0 Then
                If j <> -1 Then
                    Dim upt As Integer = DataArr(j, 2)
                    Dim g1st As Integer = DataArr(j, 4)
                    Dim g1wd As Integer = DataArr(j, 5)
                    Dim g2st As Integer = DataArr(j, 7)
                    Dim g2wd As Integer = DataArr(j, 8)
                    Dim pt0(upt) As Point
                    objFS.Seek(IIf(j > 6, j + 1, j) * 4096 + DataArr(j, 1), SeekOrigin.Current)

                    For i = 0 To upt
                        pt0(i).X = i
                        pt0(i).Y = objFS.ReadByte
                        '            Dim v As Byte = objFS.ReadByte
                    Next i
                    Dim vmax As Single = 0
                    Dim imax As Integer = 0
                    For i = g1st To g1st + g1wd
                        For j = g2st To g2st + g2wd
                            If vmax < pt0(i).Y Then
                                vmax = pt0(i).Y
                                imax = i
                            End If
                        Next
                    Next
                    vmax /= 2.4
                    Dim dd As Single = Rangemm(imax, curi)
                    dspst(24) = vmax.ToString("00")
                    dspst(25) = dd.ToString("0.0")
                Else
                    dspst(24) = ""
                    dspst(25) = ""
                End If
            End If

            objBR.Close()
            objFS.Close()

        Catch ex As Exception
            'MessageBox.Show(ex.ToString(), "frm4_ReadFreezeData()")
        End Try
    End Sub

    Private Sub WriteFreezeData2(ByVal strt As String, ByVal nd As String, ByVal tot As String, Optional ByVal sp As String = "|")
        If datafile = "" Then Exit Sub
        ReadFreezeData()
        Dim el As String = vbCrLf
        Dim isprv As Boolean = (InStr(datafile, ".prv") <> 0)

        'Dim isprv As Boolean = (InStr(datafile, ".jpg") <> 0)

        sp = ","     'ChrW(&H2502)
        Dim sp2 As String = ""  'ChrW(&HA0)
        Dim st As String = " "
        Dim ii As Integer
        Dim sst() As String
        Dim sst1 As String
        sst = dspst(44).Split("[")
        dspst(44) = IIf(sst(0) = "FP", "Y", "N")
        Dim newprb As String = "0"
        Dim newrem As String = ""
        If sst.Length > 1 Then
            newprb = sst(1)
            newrem = sst(2)
        End If

        outst &= sno & sp
        sst = dspst(3).Split("-")
        sst1 = ""
        If sst.Length > 2 Then sst1 = sst1 & sst(2) & "-"
        If sst.Length > 1 Then sst1 = sst1 & sst(1) & "-"
        If sst.Length > 0 Then sst1 = sst1 & sst(0)

        outst &= sst1 & sp
        outst &= dspst(5) & sp
        outst &= dspst(6) & sp
        outst &= dspst(10) & sp

        outst &= strt & sp
        outst &= nd & sp
        outst &= tot & sp

        ii = Val(dspst(11))
        sst1 = ii.ToString("G")
        outst &= sst1 & sp

        ii = Val(dspst(15))
        sst1 = ii.ToString("G")
        outst &= sst1 & sp
        '        rtf.SelectedText = (dspst(14) & "_" & dspst(15)) & sp : rtf.SelectionStart = rtf.TextLength
        sst = dspst(13).Split("-")
        If sst.Length = 1 Then
            sst1 = sst(0).Substring(0, 1) & sp & "-" & sp & "-"
        ElseIf sst.Length = 2 Then
            sst1 = sst(0).Substring(0, 1) & sp & sst(1) & sp & "-"
        Else
            sst1 = sst(0).Substring(0, 1) & sp & sst(1) & sp & sst(2)
        End If
        outst &= sst1 & sp
        sst = dspst(12).Split("-")
        If sst.Length = 1 Then
            sst1 = sst(0) & sp & "-"
        Else
            sst1 = sst(0) & sp & sst(1)
        End If
        outst &= sst1 & sp

        outst &= (dspst(18) & "_" & dspst(19) & "_" & dspst(20) & "_" & dspst(21)).PadRight(20) & sp

        If dspst(27).Trim <> "" Then
            outst &= dspst(27).Substring(0, 1) & sp
        Else
            outst &= " " & sp
        End If

        Dim WT As Boolean = (InStr(MCNO, "WT") <> 0)
        Dim cod As Integer = 0
        Dim probes2() As String = New String() {"0", "70", "70", "71", "71", "72", "72"}

        If Not WT Then
            cod = probes2(curi Mod 10)
        Else
            Dim dsp As String = dspst(23).ToLower.Trim
            dsp = RemoveGT127(dsp)
            If Asc(dsp.Substring(1, 1)) > 128 Then dsp = dsp.Substring(0, 1) & dsp.Substring(2)
            If File.Exists("probes.txt") Then
                Dim objSR As StreamReader = New StreamReader("probes.txt")
                Do While Not objSR.EndOfStream
                    sst1 = objSR.ReadLine
                    sst = sst1.Split(",")
                    sst(0) = sst(0).ToLower.Trim
                    If sst(0) = dsp Then cod = sst(1) : Exit Do
                Loop
                objSR.Close()
            End If
        End If
        outst &= cod & sp

        sst = dspst(25).Split("[")
        If sst.Length = 1 Then
            sst1 = sst(0) & sp & "0" & sp
        Else
            sst = sst(1).Split("-")
            sst(1) = sst(1).Substring(0, sst(1).Length - 1)
            sst1 = sst(0) & sp & sst(1) & sp
        End If
        outst &= sst1
        outst &= dspst(24) & sp
        outst &= dspst(26) & sp
        outst &= dspst(44) & sp
        outst &= newrem & sp & el

        Application.DoEvents()
    End Sub

    Public Sub CopyFile(ByVal SourceFile As String, ByVal TargetFile As String, ByVal isdel As Boolean)

        Try
            'MessageBox.Show("Copy2", "copy2")
            'Determine whether the source directory exists.
            If File.Exists(SourceFile) = False Then
                Return
            End If

            'Copy file.
            File.Copy(SourceFile, TargetFile, True)
            If isdel Then File.Delete(SourceFile)
        Catch ex As Exception
            'MessageBox.Show(ex.ToString(), "frm4_Copyfile()")
        End Try
    End Sub

    Private Sub FileTransfer(Optional ByVal iscopy As Boolean = False)
        Try
            'Dim i As Integer
            'Dim dfile As String
            '        Dim farr As String() = Directory.GetFiles(AppDataPath, "*.*")
            If Not Directory.Exists(pendrive) Then Exit Sub

            Dim st As String = Me.Text
            Me.Text = IIf(iscopy, "Copying Files", "Copy All Files")
            If Not iscopy Then
                CopyDirectory(RootDataPath, pendrive & MCNO.Trim, False)
                ListBox2.Items.Clear()
                DirList()
            Else
                CopyDirectory(RootDataPath & "\" & ListBox1.SelectedItem, pendrive & MCNO.Trim & "\" & ListBox1.SelectedItem, False)
            End If

            Me.Text = st
        Catch ex As Exception
            'MessageBox.Show(ex.ToString(), "frm4_Filetransfer()")
        End Try
    End Sub

    Private Sub FileDelete()
        File.Delete(datafile)                  '& ".prs")
        FileList()
    End Sub

    Private Sub DirList()
        Try
            Dim farr As String() = Directory.GetDirectories(RootDataPath, "*.*")
            ListBox1.Items.Clear()
            Dim i As Integer, l As Integer
            Array.Reverse(farr)
            For i = 0 To farr.Length - 1
                l = Len(RootDataPath) + 2
                ListBox1.Items.Add(Mid$(farr(i), l))
            Next i
            SortListname(ListBox1, False)
            curi = 0
            maxi = ListBox1.Items.Count - 1
            If curi <= maxi Then ListBox1.SelectedIndex = curi

        Catch ex As Exception
            'MessageBox.Show(ex.ToString(), "frm4_Dirlist()")
        End Try
    End Sub

    Private Sub FileList()
        Try
            '  ''MessageBox.Show("filelist")
            Dim isUp As Boolean
            Dim pth As String = RootDataPath & "\" & ListBox1.SelectedItem & "\"
            If InStr(pth, "DN") <> 0 Then isUp = False Else isUp = True
            isUp = True
            Dim i As Integer, l As Integer
            If Cmblistfiles.SelectedIndex = 0 Then
                Dim bmparr As String() = Directory.GetFiles(pth, "*.jpg")
                ListBox2.Items.Clear()
                For i = 0 To bmparr.Length - 1
                    l = Len(pth) + 1
                    ListBox2.Items.Add(Mid$(bmparr(i), l))
                Next i

            ElseIf Cmblistfiles.SelectedIndex = 1 Then
                Dim pth1 As String = RootDataPath & "\" & ListBox1.SelectedItem & "\"
                Dim farr As String() = Directory.GetFiles(pth1, "*.pr*")
                ListBox2.Items.Clear()
                For i = 0 To farr.Length - 1
                    l = Len(pth1) + 1
                    ListBox2.Items.Add(Mid$(farr(i), l))
                Next i

            End If

            curi = 0
            maxi = ListBox2.Items.Count - 1
            If curi <= maxi Then ListBox2.SelectedIndex = curi
            If File.Exists(pth & "dirinfo.txt") Then
                Label3.Text = ""
            Else
                Label3.Text = ""
            End If

        Catch ex As Exception
            'MessageBox.Show(ex.ToString(), "frm4_filelist()")
        End Try

    End Sub

    Private Sub frmData_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If Not isValidIn Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmData_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If Not isValidIn Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cmblistfiles.Items.Clear()
            Cmblistfiles.Focus()
            Cmblistfiles.Items.Add("JPG")
            Cmblistfiles.Items.Add("PRV&PRS")
            Cmblistfiles.SelectedIndex = 1

            Me.AutoScroll = False
            SetCursorPos(640, 460)
            Me.Show()
            Me.Text = "Loading Data - Please Wait"
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
            Me.pnlOpts.Left = Me.Width - Me.pnlOpts.Width
            Me.pnlOpts.Visible = False
            Me.chkCRIS.Top = lbl4top - Me.chkCRIS.Height
            Me.chkCRIS.Left = Me.lblMenu3.Left - Me.chkCRIS.Width
            Me.chkCRIS.Checked = CheckState.Unchecked : chkCRIS.Visible = False
            DirList()
            Me.Text = "Data Management " & MCNO
            isdeleting = False
            curi = 0
            curj = 0

            If TotNch <= 5 Then
                lblTyp.Visible = False
                cmbTyp.Visible = False
                lblCode.Visible = False
                cmbCode.Visible = False
                lblDesc.Visible = False
                'previous
                lblPrev.Visible = False
                Label5.Visible = False
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
                Label4.Visible = False
                cmbCris.Visible = False
                Label8.Visible = False
                txtRem.Visible = False
                lblDesc2.Visible = False
            End If
            PictureBox1.Left = Me.Width - PictureBox1.Width : PictureBox1.Top = Panel3.Height
            PictureBox1.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.GotFocus
        ListBox1.BackColor = Color.DarkGray
        ListBox1.ForeColor = Color.White
        Label1.ForeColor = Color.Red
    End Sub

    Private Sub ListBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.LostFocus
        ListBox1.BackColor = Color.LightGray
        ListBox1.ForeColor = Color.DarkGray
        Label1.ForeColor = Color.LightGray
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        FileList()
    End Sub

    Private Sub ListBox2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        ListBox2.BackColor = Color.DarkGray
        ListBox2.ForeColor = Color.White
        Label2.ForeColor = Color.Red
    End Sub

    Private Sub ListBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        ListBox2.BackColor = Color.LightGray
        ListBox2.ForeColor = Color.DarkGray
        Label2.ForeColor = Color.LightGray

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

    Private Sub txtLoc1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLoc1.TextChanged
        txtLoc1.Text = UCase(txtLoc1.Text)
        txtLoc1.SelectionStart = txtLoc1.TextLength
    End Sub

    Private Sub txtLoc2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLoc2.TextChanged
        txtLoc2.Text = UCase(txtLoc2.Text)
        txtLoc2.SelectionStart = txtLoc2.TextLength
    End Sub

    Private Sub txtLoc3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLoc3.TextChanged
        txtLoc3.Text = UCase(txtLoc3.Text)
        txtLoc3.SelectionStart = txtLoc3.TextLength
    End Sub

    Private Sub txtMask4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMask4.TextChanged
        txtMask4.Text = UCase(txtMask4.Text)
        txtMask4.SelectionStart = txtMask4.TextLength
    End Sub

    Private Sub txtPH2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPH2.TextChanged
        txtPH2.Text = UCase(txtPH2.Text)
        txtPH2.SelectionStart = txtPH2.TextLength
    End Sub

    Private Sub txtSta1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSta1.TextChanged
        txtSta1.Text = UCase(txtSta1.Text)
        txtSta1.SelectionStart = txtSta1.TextLength
    End Sub

    Private Sub txtSta2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSta2.TextChanged
        txtSta2.Text = UCase(txtSta2.Text)
        txtSta2.SelectionStart = txtSta2.TextLength
    End Sub

    Private Sub txtTP_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTP.TextChanged
        txtTP.Text = UCase(txtTP.Text)
        txtTP.SelectionStart = txtTP.TextLength
        txtTP2.Text = txtTP.Text
    End Sub

    Private Sub txtTP2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTP2.TextChanged
        txtTP2.Text = UCase(txtTP2.Text)
        txtTP2.SelectionStart = txtTP2.TextLength
    End Sub

    Private Sub txtKm_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKmt.TextChanged
        txtKmt.Text = UCase(txtKmt.Text)
        txtKmt.SelectionStart = txtKmt.TextLength
        txtKm.Text = txtKmt.Text
    End Sub

    Private Sub txtKM2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKm.TextChanged
        txtKm.Text = UCase(txtKm.Text)
        txtKm.SelectionStart = txtKm.TextLength
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        If ListBox2.SelectedIndex < 0 Then
            lblFile.Text = ""
        Else
            lblFile.Text = ListBox2.SelectedItem.ToString
        End If
    End Sub

    Private Sub txtKM2_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKM2.TextChanged
        txtKM2.Text = UCase(txtKM2.Text)
        txtKM2.SelectionStart = txtKM2.TextLength
    End Sub

    Private Sub Cmblistfiles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmblistfiles.SelectedIndexChanged
        Try
            Dim i As Integer, l As Integer
            Dim pth As String = RootDataPath & "\" & ListBox1.SelectedItem & "\"

            If Cmblistfiles.SelectedIndex = 0 Then
                Dim bmparr As String() = Directory.GetFiles(pth, "*.jpg")
                ListBox2.Items.Clear()
                For i = 0 To bmparr.Length - 1
                    l = Len(pth) + 1
                    ListBox2.Items.Add(Mid$(bmparr(i), l))
                Next i

            ElseIf Cmblistfiles.SelectedIndex = 1 Then
                Dim pth1 As String = RootDataPath & "\" & ListBox1.SelectedItem & "\"
                Dim farr As String() = Directory.GetFiles(pth1, "*.pr*")
                ListBox2.Items.Clear()
                For i = 0 To farr.Length - 1
                    l = Len(pth1) + 1
                    ListBox2.Items.Add(Mid$(farr(i), l))
                Next i

            End If

            If ListBox1.Items.Count > 0 Then
            End If
            If ListBox2.Items.Count > 0 Then
                ListBox2.SelectedIndex = 0
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class