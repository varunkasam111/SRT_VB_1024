<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmLog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLog))
        Me.lblMenu7 = New System.Windows.Forms.Label
        Me.lblMenu6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblDeleteAll = New System.Windows.Forms.Label
        Me.lblMenu5 = New System.Windows.Forms.Label
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.lblMenu2 = New System.Windows.Forms.Label
        Me.lblOpts2 = New System.Windows.Forms.Label
        Me.lblOpts3 = New System.Windows.Forms.Label
        Me.Warning = New System.Windows.Forms.PictureBox
        Me.lblDelete = New System.Windows.Forms.Label
        Me.lblMenu1 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ListBox3 = New System.Windows.Forms.ListBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMenu7
        '
        Me.lblMenu7.BackColor = System.Drawing.Color.Green
        Me.lblMenu7.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblMenu7.ForeColor = System.Drawing.Color.White
        Me.lblMenu7.Location = New System.Drawing.Point(891, 725)
        Me.lblMenu7.Name = "lblMenu7"
        Me.lblMenu7.Size = New System.Drawing.Size(130, 25)
        Me.lblMenu7.Text = "Quit"
        Me.lblMenu7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMenu6
        '
        Me.lblMenu6.BackColor = System.Drawing.Color.Green
        Me.lblMenu6.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblMenu6.ForeColor = System.Drawing.Color.White
        Me.lblMenu6.Location = New System.Drawing.Point(891, 691)
        Me.lblMenu6.Name = "lblMenu6"
        Me.lblMenu6.Size = New System.Drawing.Size(130, 25)
        Me.lblMenu6.Text = "Copy All"
        Me.lblMenu6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(440, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(382, 38)
        Me.Label3.Text = "LOG DATA FILES"
        '
        'lblDeleteAll
        '
        Me.lblDeleteAll.BackColor = System.Drawing.Color.Green
        Me.lblDeleteAll.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblDeleteAll.ForeColor = System.Drawing.Color.White
        Me.lblDeleteAll.Location = New System.Drawing.Point(891, 621)
        Me.lblDeleteAll.Name = "lblDeleteAll"
        Me.lblDeleteAll.Size = New System.Drawing.Size(130, 25)
        Me.lblDeleteAll.Text = "DeleteAll"
        Me.lblDeleteAll.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMenu5
        '
        Me.lblMenu5.BackColor = System.Drawing.Color.Green
        Me.lblMenu5.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblMenu5.ForeColor = System.Drawing.Color.White
        Me.lblMenu5.Location = New System.Drawing.Point(891, 654)
        Me.lblMenu5.Name = "lblMenu5"
        Me.lblMenu5.Size = New System.Drawing.Size(130, 25)
        Me.lblMenu5.Text = "Copy"
        Me.lblMenu5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.ListBox2.Location = New System.Drawing.Point(231, 40)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(203, 626)
        Me.ListBox2.TabIndex = 9
        '
        'lblMenu2
        '
        Me.lblMenu2.BackColor = System.Drawing.Color.Green
        Me.lblMenu2.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblMenu2.ForeColor = System.Drawing.Color.White
        Me.lblMenu2.Location = New System.Drawing.Point(891, 552)
        Me.lblMenu2.Name = "lblMenu2"
        Me.lblMenu2.Size = New System.Drawing.Size(130, 25)
        Me.lblMenu2.Text = "ReviewLog"
        Me.lblMenu2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblOpts2
        '
        Me.lblOpts2.BackColor = System.Drawing.Color.Red
        Me.lblOpts2.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblOpts2.ForeColor = System.Drawing.Color.White
        Me.lblOpts2.Location = New System.Drawing.Point(864, 226)
        Me.lblOpts2.Name = "lblOpts2"
        Me.lblOpts2.Size = New System.Drawing.Size(160, 65)
        Me.lblOpts2.Text = "Press" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Run to Delete"
        Me.lblOpts2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblOpts2.Visible = False
        '
        'lblOpts3
        '
        Me.lblOpts3.BackColor = System.Drawing.Color.LimeGreen
        Me.lblOpts3.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblOpts3.ForeColor = System.Drawing.Color.White
        Me.lblOpts3.Location = New System.Drawing.Point(864, 310)
        Me.lblOpts3.Name = "lblOpts3"
        Me.lblOpts3.Size = New System.Drawing.Size(160, 60)
        Me.lblOpts3.Text = "Press" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Esc to Cancel"
        Me.lblOpts3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblOpts3.Visible = False
        '
        'Warning
        '
        Me.Warning.Image = CType(resources.GetObject("Warning.Image"), System.Drawing.Image)
        Me.Warning.Location = New System.Drawing.Point(748, 407)
        Me.Warning.Name = "Warning"
        Me.Warning.Size = New System.Drawing.Size(232, 180)
        Me.Warning.Visible = False
        '
        'lblDelete
        '
        Me.lblDelete.BackColor = System.Drawing.Color.Green
        Me.lblDelete.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblDelete.ForeColor = System.Drawing.Color.White
        Me.lblDelete.Location = New System.Drawing.Point(891, 590)
        Me.lblDelete.Name = "lblDelete"
        Me.lblDelete.Size = New System.Drawing.Size(130, 25)
        Me.lblDelete.Text = "Delete"
        Me.lblDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMenu1
        '
        Me.lblMenu1.BackColor = System.Drawing.Color.Green
        Me.lblMenu1.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblMenu1.ForeColor = System.Drawing.Color.White
        Me.lblMenu1.Location = New System.Drawing.Point(891, 518)
        Me.lblMenu1.Name = "lblMenu1"
        Me.lblMenu1.Size = New System.Drawing.Size(130, 25)
        Me.lblMenu1.Text = "BatchView"
        Me.lblMenu1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblMenu1.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(5, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 38)
        Me.Label1.Text = "DATE FOLDERS"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(231, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 38)
        Me.Label2.Text = "KM FOLDER"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.ListBox1.Location = New System.Drawing.Point(5, 40)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(220, 626)
        Me.ListBox1.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.ListBox3)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ListBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(836, 680)
        '
        'ListBox3
        '
        Me.ListBox3.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.ListBox3.Location = New System.Drawing.Point(440, 40)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(382, 626)
        Me.ListBox3.TabIndex = 14
        '
        'frmLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.lblMenu7)
        Me.Controls.Add(Me.lblMenu6)
        Me.Controls.Add(Me.lblDeleteAll)
        Me.Controls.Add(Me.lblMenu5)
        Me.Controls.Add(Me.lblMenu2)
        Me.Controls.Add(Me.lblOpts2)
        Me.Controls.Add(Me.Warning)
        Me.Controls.Add(Me.lblOpts3)
        Me.Controls.Add(Me.lblDelete)
        Me.Controls.Add(Me.lblMenu1)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "frmLog"
        Me.Text = "Form7"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkCRIS As System.Windows.Forms.CheckBox
    Friend WithEvents lblMenu7 As System.Windows.Forms.Label
    Friend WithEvents lblMenu6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDeleteAll As System.Windows.Forms.Label
    Friend WithEvents lblMenu5 As System.Windows.Forms.Label
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents lblMenu2 As System.Windows.Forms.Label
    Friend WithEvents lblOpts2 As System.Windows.Forms.Label
    Friend WithEvents lblOpts3 As System.Windows.Forms.Label
    Friend WithEvents Warning As System.Windows.Forms.PictureBox
    Friend WithEvents lblDelete As System.Windows.Forms.Label
    Friend WithEvents lblMenu1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox


End Class
