Imports System.IO
Imports System
Imports System.Windows
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports System.Runtime.InteropServices

Public Class frmLog

    Dim curi As Integer, curj As Integer
    Dim maxi As Integer
    Dim delcode As Integer
    Dim isdeleting As Boolean
    Dim fllist As String
    Dim bb() As Byte
    Dim isValidIn As Boolean
    Dim keyprocess As Boolean = False
    Dim uplmt As Integer = 37
    Dim dspst(35) As String
    Dim sno As Integer
    Dim outst As String
    Dim lastk As Integer
    Dim stateKey As Integer = 0
    Dim pkdeleteall As Boolean
    Dim pkdelete As Boolean
    Dim Fileindex As Integer
    Dim boolc As Boolean
    Dim pstarted As Boolean
    Dim p As Process
    <DllImport("coredll.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
   Private Shared Function GetDiskFreeSpaceEx( _
       ByVal lpDirectoryName As String, _
       ByRef lpFreeBytesAvailable As Long, _
       ByRef lpTotalNumberOfBytes As Long, _
       ByRef lpTotalNumberOfFreeBytes As Long) As Boolean
    End Function
    Public Function GetSDSpace(ByVal sdPath As String) As String
        Dim freeBytes As Long = 0
        Dim totalBytes As Long = 0
        Dim totalFreeBytes As Long = 0

        Dim ok As Boolean = GetDiskFreeSpaceEx(sdPath, freeBytes, totalBytes, totalFreeBytes)

        If ok = False Then
            Return "Error reading SD card"
        End If

        Return "  Total Space: " & FormatBytes(totalBytes) & "     Free Space: " & FormatBytes(freeBytes)
    End Function
    Private Function FormatBytes(ByVal bytes As Long) As String
        If bytes > 1024L * 1024L * 1024L Then
            Return Math.Round(bytes / 1024.0 / 1024.0 / 1024.0, 2) & " GB"
        ElseIf bytes > 1024L * 1024L Then
            Return Math.Round(bytes / 1024.0 / 1024.0, 2) & " MB"
        Else
            Return Math.Round(bytes / 1024.0, 2) & " KB"
        End If
    End Function
    Private Sub frmLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            SetCursorPos(640, 460)
            pstarted = False
            Me.Width = mewidth : Me.Height = meheight
            Me.lblMenu1.Left = Me.Width - Me.lblMenu1.Width
            Me.lblMenu2.Left = Me.lblMenu1.Left - 10
            Me.lblDeleteAll.Left = Me.lblMenu1.Left - 10
            Me.lblDelete.Left = Me.lblMenu1.Left - 10
            Me.lblMenu5.Left = Me.lblMenu1.Left - 10
            Me.lblMenu6.Left = Me.lblMenu1.Left - 10
            Me.lblMenu7.Left = Me.lblMenu1.Left - 10
            Me.lblOpts2.Left = Me.lblMenu1.Left - 15
            Me.lblOpts3.Left = Me.lblMenu1.Left - 15

            Me.lblMenu1.Top = lbl1top : Me.lblMenu1.Height = lbl1height
            Me.lblOpts2.Top = lbl1top : Me.lblOpts2.Height = lbl1height

            Me.lblMenu2.Top = lbl2top + 187 : Me.lblMenu2.Height = lbl2height
            Me.lblOpts3.Top = lbl2top : Me.lblOpts3.Height = lbl2height

            Me.lblDelete.Top = lbl3top + 187 : Me.lblDelete.Height = lbl3height
            Me.lblOpts2.Top = lbl3top : Me.lblOpts2.Height = lbl3height

            Me.lblDeleteAll.Top = lbl4top + 187 : Me.lblDeleteAll.Height = lbl3height
            Me.lblOpts3.Top = lbl4top : Me.lblOpts3.Height = lbl3height

            Me.lblMenu5.Top = lbl5top + 187 : Me.lblMenu5.Height = lbl5height
            Me.lblMenu6.Top = lbl6top + 187 : Me.lblMenu6.Height = lbl6height
            Me.lblMenu7.Top = lbl7top + 187 : Me.lblMenu7.Height = lbl7height - 20

            Me.Width = mewidth : Me.Height = meheight

            Me.lblOpts2.Visible = False
            Me.lblOpts3.Visible = False
            Me.Warning.Visible = False

            Me.LabelAvailSpaceVal.Text = GetSDSpace(StorageCard)

            DirList()
            SubDirList()
            FileList()
            pstarted = True
            SetCursorPos(640, 460)
            Me.Text = "  Log Data Files "
            curi = 0
            curj = 0

        Catch ex As Exception
            'MessageBox.Show(ex.ToString(), "frm7_Load()")
        End Try

    End Sub


    Public Sub Frm5DelAllDirectory(ByVal SourceDirectory As String)
        Try
            Dim j As Integer
            Dim source As DirectoryInfo = New DirectoryInfo(SourceDirectory)

            'Determine whether the source directory exists.

            If (source.Exists = False) Then
                Return
            End If

            Dim subs As DirectoryInfo() = source.GetDirectories()
            For i = 0 To subs.Length - 1
                Dim sourceFiles As FileInfo() = subs(i).GetFiles()
                Me.Text = "Deleting... File" & Fileindex
                Fileindex += 1
                For j = 0 To sourceFiles.Length - 1
                    File.Delete(sourceFiles(j).FullName)
                Next j
                subs(i).Delete()
            Next i
            source = Nothing

        Catch ex As Exception
            'MessageBox.Show(ex.ToString(), "Frm5DelAllDirectory()")
        End Try
    End Sub

    Private Sub DeleteAllDirectoryWithContents(ByVal folderpath As String)
        Try
            ' Check if the folder exists
            If Directory.Exists(folderPath) Then
                ' Delete all files in the folder
                For Each filePath As String In Directory.GetFiles(folderPath)
                    File.Delete(filePath)
                Next

                ' Recursively delete subfolders
                For Each subfolderPath As String In Directory.GetDirectories(folderPath)
                    DeleteAllDirectoryWithContents(subfolderPath)
                Next

                ' Finally, delete the folder itself
                Directory.Delete(folderPath)
            End If
        Catch ex As Exception
            ' Handle any exceptions that may occur during the process
            Console.WriteLine("Error: " & ex.ToString)
        End Try
    End Sub

    Public Sub Frm5DelDirectory(ByVal SourceDirectory As String)

        Try
            Dim j As Integer
            Dim source As DirectoryInfo = New DirectoryInfo(SourceDirectory)

            'Determine whether the source directory exists.
            If (source.Exists = False) Then
                Return
            End If

            Dim sourceFiles As FileInfo() = source.GetFiles()
            For j = 0 To sourceFiles.Length - 1
                File.Delete(sourceFiles(j).FullName)
            Next j
            source.Delete()
            source = Nothing
        Catch ex As Exception
            'MessageBox.Show(ex.Message(), "exception")
        End Try

    End Sub

    Private Sub frmLog_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        Try
            Me.lblOpts2.Visible = False
            Me.lblOpts3.Visible = False
            Me.Warning.Visible = False

            Dim k As Integer
            k = e.KeyCode

            Select Case k

                Case EsKey
                    Me.Text = "Log Data Files"
                    Fileindex = 0

                    Me.lblDeleteAll.Visible = True
                    Me.lblDelete.Visible = True
                    Me.lblMenu5.Visible = True
                    Me.lblMenu6.Visible = True
                    Me.lblMenu7.Visible = True
                    Me.lblOpts2.Visible = False
                    Me.lblOpts3.Visible = False
                    Me.Warning.Visible = False

                    pkdeleteall = False
                    pkdelete = False

                Case FKeyRun

                    If pkdeleteall = True And pkdelete = False Then
                        Me.Text = "Deleting...."
                        Fileindex = 0

                        datafile = "\SD Card\Logs\"
                        If ListBox1.Items.Count > 0 Then
                            'Frm5DelAllDirectory(datafile)
                            DeleteAllDirectoryWithContents(datafile & ListBox1.SelectedItem.ToString.Trim)
                            ListBox1.SelectedIndex = 0
                        End If
                        Me.Text = "Deleted Successfully"
                        pkdeleteall = False
                        pkdelete = False

                        DirList()
                        SubDirList()
                        FileList()
                        Me.LabelAvailSpaceVal.Text = GetSDSpace(StorageCard)
                        Me.Refresh()

                        Me.lblDeleteAll.Visible = True
                        Me.lblDelete.Visible = True
                        Me.lblMenu5.Visible = True
                        Me.lblMenu6.Visible = True
                        Me.lblMenu7.Visible = True
                        Me.lblOpts2.Visible = False
                        Me.lblOpts3.Visible = False
                        Me.Warning.Visible = False

                    ElseIf pkdeleteall = False And pkdelete = True Then
                        Me.Text = "Deleting...."
                        Fileindex = 0
                        datafile = StorageCard & "Logs\" & ListBox1.SelectedItem.ToString.Trim & "\" & ListBox2.SelectedItem.ToString.Trim
                        If ListBox1.Items.Count > 0 AndAlso ListBox2.Items.Count > 0 Then
                            Frm5DelDirectory(datafile)
                            ListBox3.Items.Clear()
                        End If
                        Me.Text = "Deleted Successfully"
                        pkdeleteall = False
                        pkdelete = False

                        DirList()
                        SubDirList()
                        FileList()
                        Me.LabelAvailSpaceVal.Text = GetSDSpace(StorageCard)
                        Me.Refresh()

                        Me.lblDeleteAll.Visible = True
                        Me.lblDelete.Visible = True
                        Me.lblMenu5.Visible = True
                        Me.lblMenu6.Visible = True
                        Me.lblMenu7.Visible = True
                        Me.lblOpts2.Visible = False
                        Me.lblOpts3.Visible = False
                        Me.Warning.Visible = False
                    End If

                Case MKey4 'Review Log

                    Fileindex = 0

                    datafile = "\SD Card\SortedLog"

                    If Not Directory.Exists(datafile) Then
                        Directory.CreateDirectory(datafile)
                    End If

                    Dim filesInDirectory As String() = Directory.GetFiles(datafile)

                    If filesInDirectory.Length > 0 Then
                        If ListBox1.Items.Count > 0 AndAlso ListBox2.Items.Count > 0 Then
                            Frm5DelAllDirectory(datafile)
                        End If

                        For Each filePath As String In Directory.GetFiles(datafile)
                            File.Delete(filePath)
                        Next
                    End If

                    FileTransferForCApp(True)
                    frm7Bool = False
                    Me.Close()
                    e.Handled = True

                Case MKey5

                    Me.lblDeleteAll.Visible = False
                    Me.lblDelete.Visible = False
                    Me.lblMenu5.Visible = False
                    Me.lblMenu6.Visible = False
                    Me.lblMenu7.Visible = False
                    Me.lblOpts2.Visible = True
                    Me.lblOpts3.Visible = True
                    Me.Warning.Visible = True
                    pkdeleteall = False
                    pkdelete = True
                    Me.Text = "Delete"

                Case MKey6

                    Me.lblDeleteAll.Visible = False
                    Me.lblDelete.Visible = False
                    Me.lblMenu5.Visible = False
                    Me.lblMenu6.Visible = False
                    Me.lblMenu7.Visible = False
                    Me.lblOpts2.Visible = True
                    Me.lblOpts3.Visible = True
                    Me.Warning.Visible = True
                    pkdeleteall = True
                    pkdelete = False
                    Me.Text = "Delete All"

                Case MKey7

                    FileTransfer(True)

                Case MKey8

                    FileTransfer(False)

                Case MKey9

                    frm7Bool = True
                    Me.Close()

                Case FKeyUp

                    Select Case curj
                        Case 0 : If ListBox1.SelectedIndex > 0 Then ListBox1.SelectedIndex -= 1
                        Case 1 : If ListBox2.SelectedIndex > 0 Then ListBox2.SelectedIndex -= 1
                        Case 2 : If ListBox3.SelectedIndex > 0 Then ListBox3.SelectedIndex -= 1
                    End Select

                Case FKeyDn

                    Select Case curj
                        Case 0 : If ListBox1.SelectedIndex < ListBox1.Items.Count - 1 Then ListBox1.SelectedIndex += 1
                        Case 1 : If ListBox2.SelectedIndex < ListBox2.Items.Count - 1 Then ListBox2.SelectedIndex += 1
                        Case 2 : If ListBox3.SelectedIndex < ListBox3.Items.Count - 1 Then ListBox3.SelectedIndex += 1
                    End Select

                Case FkeyLf

                    curj = curj - 1
                    curi = 0
                    If curj = 0 Then
                        ListBox1.Focus()
                    ElseIf curj = 1 Then
                        ListBox2.Focus()
                    ElseIf curj = 2 Then
                        ListBox3.Focus()
                    End If

                Case FkeyRt

                    curj = curj + 1
                    curi = 0
                    If curj = 0 Then
                        ListBox1.Focus()
                    ElseIf curj = 1 Then
                        ListBox2.Focus()
                    ElseIf curj = 2 Then
                        ListBox3.Focus()
                    End If

            End Select

            lastk = k
            keyprocess = False
            e.Handled = True
        Catch ex As Exception
            'MessageBox.Show(ex.Message(), "Exception")
        End Try
    End Sub

    Private Sub FileTransfer(Optional ByVal iscopy As Boolean = False)
        Try
            If Not Directory.Exists(pendrive) Then
                Exit Sub
            End If


            Dim st As String = Me.Text
            Me.Text = IIf(iscopy, "Copying Files", "Copying All Files")

            If Not iscopy Then
                CopyDirectoryAll(StorageCard & "Logs\" & ListBox1.SelectedItem.ToString.Trim & "\", pendrive & "DRT" & Format(uno, "0000") & "\" & "Logs" & "\" & ListBox1.SelectedItem.ToString.Trim & "\")
                DirList()
            Else
                copy(RootDataPath1 & "\" & ListBox1.SelectedItem.ToString.Trim & "\" & ListBox2.SelectedItem.ToString.Trim & "\", pendrive & "DRT" & Format(uno, "0000") & "\" & "Logs" & "\" & ListBox1.SelectedItem.ToString.Trim & "\" & ListBox2.SelectedItem.ToString.Trim & "\", False)
            End If

            Me.Text = st
        Catch ex As Exception
            'MessageBox.Show(ex.ToString(), "FileTransfer()")
        End Try
    End Sub

    Private Sub FileTransferForCApp(Optional ByVal iscopy As Boolean = False)
        Try
            boolc = True
            If Not Directory.Exists(StorageCard) Then
                Exit Sub
            End If

            Dim st As String = Me.Text
            Me.Text = IIf(iscopy, "Copying Files", "Copying All Files")

            If Not iscopy Then
                copy(RootDataPath1, StorageCard & "SortedLog\", False)
                ListBox3.Items.Clear()
                DirList()
            Else
                copy(RootDataPath1 & "\" & ListBox1.SelectedItem.ToString.Trim & "\" & ListBox2.SelectedItem.ToString.Trim, StorageCard & "SortedLog\", False)
            End If

            Me.Text = st
        Catch ex As Exception
            'MessageBox.Show(ex.ToString(), "FileTransfer()")
        End Try
    End Sub

    Private Sub CopyDirectoryAll(ByVal sourceDir As String, ByVal destDir As String)
        Dim sourceFiles = Directory.GetFiles(sourceDir)
        Dim totalFiles = sourceFiles.Length
        Dim copiedFiles = 0

        If Not Directory.Exists(destDir) Then
            Directory.CreateDirectory(destDir)
        End If

        For Each filePath As String In sourceFiles
            Dim fileName As String = Path.GetFileName(filePath)
            Dim destFilePath As String = Path.Combine(destDir, fileName)
            File.Copy(filePath, destFilePath, True)
            copiedFiles += 1

            ' Calculate and display the progress as a percentage
            Dim progressPercentage As Integer = CInt((copiedFiles / totalFiles) * 100)
            Me.Text = "Copying All Directory " & progressPercentage & Chr(37)
        Next

        For Each subDirPath As String In Directory.GetDirectories(sourceDir)
            Dim subDirName As String = Path.GetFileName(subDirPath)
            Dim destSubDirPath As String = Path.Combine(destDir, subDirName)
            CopyDirectoryAll(subDirPath, destSubDirPath)
        Next
        Me.Text = "ALL Directories Copied Sucessfully Remove Pendrive"
    End Sub


    Private Sub copy(ByVal SourceDirectory As String, ByVal TargetDirectory As String, ByVal isdel As Boolean)
        Try
            Dim source As DirectoryInfo = New DirectoryInfo(SourceDirectory)
            Dim target As DirectoryInfo = New DirectoryInfo(TargetDirectory)

            ' Determine whether the source directory exists.
            If (source.Exists = False) Then
                Return
            End If

            If (target.Exists = False) Then
                target.Create()
            End If

            ' Copy files.
            Dim sourceFiles As FileInfo() = source.GetFiles()
            Dim intPercentage As Integer

            If boolc = True Then
                For i = 0 To sourceFiles.Length - 1
                    File.Copy(sourceFiles(i).FullName, target.FullName + "\\" & sourceFiles(i).Name, True)
                    intPercentage = (i * 100) / sourceFiles.Length
                    Me.Text = "Reviewing Copy Percent " & intPercentage.ToString() & " " & Chr(37)

                Next i
            Else
                For i As Integer = 0 To sourceFiles.Length - 1
                    If isdel Then
                        File.Delete(sourceFiles(i).FullName)
                    Else
                        File.Copy(sourceFiles(i).FullName, Path.Combine(target.FullName, sourceFiles(i).Name), True)
                    End If

                    intPercentage = (i * 100) / sourceFiles.Length
                    Me.Text = "Copying Percent " & intPercentage.ToString() & " " & Chr(37)
                Next i

            End If

            ' Copy directories.
            Dim sourceDirectories As DirectoryInfo() = source.GetDirectories()

            For j As Integer = 0 To sourceDirectories.Length - 1
                copy(sourceDirectories(j).FullName, Path.Combine(target.FullName, sourceDirectories(j).Name), isdel)
            Next j

            If isdel Then
                source.Delete(True)
            End If

        Catch ex As Exception
            ' Handle exceptions here
            'MessageBox.Show(ex.ToString(), "CopyDirectory()")
        End Try
    End Sub

    Private Sub DirList()
        Try
            Dim farr1 As String() = Directory.GetDirectories(RootDataPath1, "*.*")
            ListBox1.Items.Clear()

            Dim n = farr1.Length - 1
            If n = -1 Then Exit Sub
            Dim farr2(0 To n)

            For m = 0 To farr1.Length - 1
                If (farr1(m).IndexOf("date_").ToString() <> "0") Then
                    'Not contain "date_" format
                    Dim arrDateFolder As String() = farr1(m).ToString.Trim.Split("\")
                    Dim arrDate As String() = arrDateFolder(arrDateFolder.Length - 1).ToString.Trim.Split("_")
                    Dim strYear As String = arrDate(2).ToString.Trim
                    Dim strMonth As String = arrDate(1).ToString.Trim
                    Dim strDate As String = arrDate(0).ToString.Trim
                    farr2(m) = strYear & strMonth & strDate & "~" & arrDateFolder(arrDateFolder.Length - 1).ToString.Trim
                Else
                    'Contain "date_" format
                    Dim arrDateFolder As String() = farr1(m).ToString.Trim.Split("\")
                    Dim arrDate As String() = arrDateFolder(arrDateFolder.Length - 1).ToString.Trim.Split("_")
                    Dim strYear As String = arrDate(3).ToString.Trim
                    Dim strMonth As String = arrDate(2).ToString.Trim
                    Dim strDate As String = arrDate(1).ToString.Trim
                    farr2(m) = strYear & strMonth & strDate & "~" & arrDateFolder(arrDateFolder.Length - 1).ToString.Trim
                End If
            Next

            Array.Sort(farr2)
            Array.Reverse(farr2)

            ListBox1.Items.Clear()

            For n = 0 To farr2.Length - 1
                Dim arrFolderName() As String = farr2(n).ToString().Split("~")
                'Extra Space Added Space " " Before Date For Numeric Keypad issue
                ListBox1.Items.Add(" " & arrFolderName(1).ToString.Trim)
            Next n

            curi = 0
            maxi = ListBox1.Items.Count - 1
            If curi <= maxi Then ListBox1.SelectedIndex = curi

        Catch ex As Exception
            'MessageBox.Show(ex.ToString(), "frm4_Dirlist()")
        End Try
    End Sub

    Private Sub SubDirList()

        Try
            Dim RootDataPath1 As String = StorageCard & "Logs\" & ListBox1.SelectedItem.ToString.Trim & "\"
            Dim farr1 As String() = Directory.GetDirectories(RootDataPath1, "*.*")
            ListBox2.Items.Clear()

            Dim n = farr1.Length - 1
            If n = -1 Then Exit Sub
            Dim farr2(0 To n)


            For m = 0 To farr1.Length - 1
                If (farr1(m).IndexOf("KM_").ToString() <> "0") Then
                    'Contain "KM_" format
                    Dim arrSubFolder As String() = farr1(m).ToString.Trim.Split("\")
                    farr2(m) = (arrSubFolder(arrSubFolder.Length - 1)).ToString.Trim
                End If
            Next

            Array.Sort(farr2)
            Array.Reverse(farr2)

            ListBox2.Items.Clear()

            For i = 0 To farr2.Length - 1
                ListBox2.Items.Add(" " & farr2(i).ToString.Trim)
            Next

            curi = 0
            maxi = ListBox2.Items.Count - 1
            If curi <= maxi Then ListBox2.SelectedIndex = curi

        Catch ex As Exception
            'MessageBox.Show(ex.ToString(), "Exception")
        End Try

    End Sub

    Private Sub FileList()
        Try

            Dim isUp As Boolean
            Dim pth As String = RootDataPath1 & "\" & ListBox1.SelectedItem.ToString.Trim & "\" & ListBox2.SelectedItem.ToString.Trim & "\"
            If InStr(pth, "DN") <> 0 Then isUp = False Else isUp = True
            isUp = True
            Dim farr1 As String() = Directory.GetFiles(pth, "*.txt*")
            ListBox3.Items.Clear()
            Dim i As Integer, res As Integer
            Dim st() As String
            For i = 0 To farr1.Length - 1
                st = farr1(i).Split("\")
                res = InStr(farr1(i), "Log_")
                If res <> 0 Then
                    ListBox3.Items.Add(st(st.Length - 1))
                End If
            Next i

            SortListname(ListBox3, isUp)

            curi = 0
            maxi = ListBox3.Items.Count - 1
            If curi <= maxi Then ListBox3.SelectedIndex = curi

        Catch ex As Exception
            'MessageBox.Show(ex.ToString(), "Filelist()")
        End Try

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SubDirList()
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FileList()
    End Sub

    Private Sub ListBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        ListBox1.BackColor = Color.DarkGray
        ListBox1.ForeColor = Color.White
    End Sub

    Private Sub ListBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        ListBox1.BackColor = Color.LightGray
        ListBox1.ForeColor = Color.DarkGray
        Label1.ForeColor = Color.LightGray
    End Sub

    Private Sub ListBox2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        ListBox2.BackColor = Color.DarkGray
        ListBox2.ForeColor = Color.White
    End Sub

    Private Sub ListBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        ListBox2.BackColor = Color.LightGray
        ListBox2.ForeColor = Color.DarkGray
        Label2.ForeColor = Color.LightGray
    End Sub

    Private Sub ListBox3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        ListBox3.BackColor = Color.DarkGray
        ListBox3.ForeColor = Color.White
    End Sub

    Private Sub ListBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        ListBox3.BackColor = Color.LightGray
        ListBox3.ForeColor = Color.DarkGray
        Label3.ForeColor = Color.LightGray
    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        SubDirList()
    End Sub

    Private Sub ListBox2_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        FileList()
    End Sub
End Class