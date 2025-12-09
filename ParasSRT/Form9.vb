Public Class Form_OdoCalib
    Dim isloaded As Boolean
    Dim pstarted As Boolean
    Dim p As Process
    Dim isValidIn As Boolean
    Private Sub Form9_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim k As Integer = e.KeyCode
        e.Handled = True

        ' Allow only digit, Backspace, Decimal as valid input
        If ((k >= Keys.D0 AndAlso k <= Keys.D9) Or k = Keys.Back Or k = Keys.Decimal) Then
            isValidIn = True
            e.Handled = False
            Exit Sub
        End If

        ' By default, not valid for input
        isValidIn = False

        ' Menu Keys Handling
        Select Case k
            Case MKey1
                Me.Text = "Launching Test Odometer Application"
                pstarted = True
                p = New Process
                p.StartInfo.FileName = odotest
                p.Start()
                p.WaitForExit()
                p.Close()

            Case MKey2
                Me.lblMenu1.Visible = False
                Me.lblMenu2.Visible = False
                Me.lblMenu3.Visible = False
                Me.lblMenu4.Visible = True
                Me.lblMenu5.Visible = True
                Me.Panel1.Visible = True
                Me.Panel1.Enabled = True
                Me.TextBox1.Focus()
                get_odoval()

            Case MKey3
                Me.Close()
                Exit Sub

            Case MKey4
                Dim valueToSave As String = TextBox1.Text.Trim()

                If IsNumeric(valueToSave) Then
                    Dim f As Single = CType(valueToSave, Single)
                    Using sw As New System.IO.StreamWriter(Defodovalue, False) ' False = overwrite
                        sw.WriteLine(f.ToString() & ",")
                    End Using
                Else
                    MessageBox.Show("Invalid float number.")
                End If
                Me.Panel1.Visible = False
                Me.Panel1.Enabled = False
                Me.Text = "Saved"
                Me.lblMenu1.Visible = True
                Me.lblMenu2.Visible = True
                Me.lblMenu3.Visible = True
                Me.lblMenu4.Visible = False
                Me.lblMenu5.Visible = False

            Case MKey5

                Me.Panel1.Visible = False
                Me.Panel1.Enabled = False
                Me.lblMenu1.Visible = True
                Me.lblMenu2.Visible = True
                Me.lblMenu3.Visible = True
                Me.lblMenu4.Visible = False
                Me.lblMenu5.Visible = False

            Case Else
                e.Handled = False
        End Select
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Block anything not explicitly marked as valid input
        If Not isValidIn Then
            e.Handled = True
            Return
        End If

        ' Allow only digits, Backspace, and decimal point
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        ' Prevent more than one decimal point
        If e.KeyChar = "."c AndAlso CType(sender, TextBox).Text.IndexOf(".") >= 0 Then
            e.Handled = True
        End If
    End Sub


    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AutoScroll = False
        Me.KeyPreview = True
        Me.Text = "Enc Calib"
        SetCursorPos(1024, 760)
        isloaded = False
        Me.lblMenu4.Visible = False
        Me.lblMenu5.Visible = False
        Me.Panel1.Visible = False

        Me.Width = mewidth : Me.Height = meheight
        Me.lblMenu1.Left = Me.Width - Me.lblMenu1.Width
        Me.lblMenu2.Left = Me.lblMenu1.Left
        Me.lblMenu3.Left = Me.lblMenu1.Left
        Me.lblMenu4.Left = Me.lblMenu1.Left
        Me.lblMenu5.Left = Me.lblMenu1.Left

        Me.lblMenu1.Top = lbl1top : Me.lblMenu1.Height = lbl1height
        Me.lblMenu2.Top = lbl2top : Me.lblMenu2.Height = lbl2height
        Me.lblMenu3.Top = lbl3top : Me.lblMenu3.Height = lbl3height
        Me.lblMenu4.Top = lbl4top : Me.lblMenu4.Height = lbl4height
        Me.lblMenu5.Top = lbl5top : Me.lblMenu5.Height = lbl5height
        Me.Width = mewidth : Me.Height = meheight

    End Sub
    Public Sub get_odoval()
        Dim defaultValue As String = ""
        Using sr As New System.IO.StreamReader(Defodovalue)
            defaultValue = sr.ReadToEnd().Trim()
        End Using

        If Not String.IsNullOrEmpty(defaultValue) Then
            Dim parts() As String = defaultValue.Split(","c)
            If parts.Length > 0 Then
                TextBox1.Text = parts(0).Trim()
            End If
        End If
    End Sub

End Class