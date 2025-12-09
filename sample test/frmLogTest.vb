Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ParasSRT



'''<summary>
'''This is a test class for frmLogTest and is intended
'''to contain all frmLogTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmLogTest


    Private testContextInstance As TestContext

    '''<summary>
    '''Gets or sets the test context which provides
    '''information about and functionality for the current test run.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = Value
        End Set
    End Property

#Region "Additional test attributes"
    '
    'You can use the following additional attributes as you write your tests:
    '
    'Use ClassInitialize to run code before running the first test in the class
    '<ClassInitialize()>  _
    'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    'End Sub
    '
    'Use ClassCleanup to run code after all tests in a class have run
    '<ClassCleanup()>  _
    'Public Shared Sub MyClassCleanup()
    'End Sub
    '
    'Use TestInitialize to run code before running each test
    '<TestInitialize()>  _
    'Public Sub MyTestInitialize()
    'End Sub
    '
    'Use TestCleanup to run code after each test has run
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region


    '''<summary>
    '''A test for Warning
    '''</summary>
    <TestMethod()> _
    Public Sub WarningTest()
        Dim target As frmLog = New frmLog ' TODO: Initialize to an appropriate value
        Dim expected As PictureBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As PictureBox
        target.Warning = expected
        actual = target.Warning
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Panel1
    '''</summary>
    <TestMethod()> _
    Public Sub Panel1Test()
        Dim target As frmLog = New frmLog ' TODO: Initialize to an appropriate value
        Dim expected As Panel = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Panel
        target.Panel1 = expected
        actual = target.Panel1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for ListBox2
    '''</summary>
    <TestMethod()> _
    Public Sub ListBox2Test()
        Dim target As frmLog = New frmLog ' TODO: Initialize to an appropriate value
        Dim expected As ListBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ListBox
        target.ListBox2 = expected
        actual = target.ListBox2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for ListBox1
    '''</summary>
    <TestMethod()> _
    Public Sub ListBox1Test()
        Dim target As frmLog = New frmLog ' TODO: Initialize to an appropriate value
        Dim expected As ListBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ListBox
        target.ListBox1 = expected
        actual = target.ListBox1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblOpts3
    '''</summary>
    <TestMethod()> _
    Public Sub lblOpts3Test()
        Dim target As frmLog = New frmLog ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblOpts3 = expected
        actual = target.lblOpts3
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblOpts2
    '''</summary>
    <TestMethod()> _
    Public Sub lblOpts2Test()
        Dim target As frmLog = New frmLog ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblOpts2 = expected
        actual = target.lblOpts2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblMenu7
    '''</summary>
    <TestMethod()> _
    Public Sub lblMenu7Test()
        Dim target As frmLog = New frmLog ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblMenu7 = expected
        actual = target.lblMenu7
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblMenu6
    '''</summary>
    <TestMethod()> _
    Public Sub lblMenu6Test()
        Dim target As frmLog = New frmLog ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblMenu6 = expected
        actual = target.lblMenu6
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblMenu5
    '''</summary>
    <TestMethod()> _
    Public Sub lblMenu5Test()
        Dim target As frmLog = New frmLog ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblMenu5 = expected
        actual = target.lblMenu5
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblMenu2
    '''</summary>
    <TestMethod()> _
    Public Sub lblMenu2Test()
        Dim target As frmLog = New frmLog ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblMenu2 = expected
        actual = target.lblMenu2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblMenu1
    '''</summary>
    <TestMethod()> _
    Public Sub lblMenu1Test()
        Dim target As frmLog = New frmLog ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblMenu1 = expected
        actual = target.lblMenu1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblDeleteAll
    '''</summary>
    <TestMethod()> _
    Public Sub lblDeleteAllTest()
        Dim target As frmLog = New frmLog ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblDeleteAll = expected
        actual = target.lblDeleteAll
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblDelete
    '''</summary>
    <TestMethod()> _
    Public Sub lblDeleteTest()
        Dim target As frmLog = New frmLog ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblDelete = expected
        actual = target.lblDelete
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Label2
    '''</summary>
    <TestMethod()> _
    Public Sub Label2Test()
        Dim target As frmLog = New frmLog ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.Label2 = expected
        actual = target.Label2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Label1
    '''</summary>
    <TestMethod()> _
    Public Sub Label1Test()
        Dim target As frmLog = New frmLog ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.Label1 = expected
        actual = target.Label1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for chkCRIS
    '''</summary>
    <TestMethod()> _
    Public Sub chkCRISTest()
        Dim target As frmLog = New frmLog ' TODO: Initialize to an appropriate value
        Dim expected As CheckBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As CheckBox
        target.chkCRIS = expected
        actual = target.chkCRIS
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for ListBox2_SelectedIndexChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub ListBox2_SelectedIndexChangedTest()
        Dim target As frmLog_Accessor = New frmLog_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.ListBox2_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for ListBox2_LostFocus
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub ListBox2_LostFocusTest()
        Dim target As frmLog_Accessor = New frmLog_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.ListBox2_LostFocus(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for ListBox2_GotFocus
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub ListBox2_GotFocusTest()
        Dim target As frmLog_Accessor = New frmLog_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.ListBox2_GotFocus(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for ListBox1_SelectedIndexChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub ListBox1_SelectedIndexChangedTest()
        Dim target As frmLog_Accessor = New frmLog_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.ListBox1_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for ListBox1_LostFocus
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub ListBox1_LostFocusTest()
        Dim target As frmLog_Accessor = New frmLog_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.ListBox1_LostFocus(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for ListBox1_GotFocus
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub ListBox1_GotFocusTest()
        Dim target As frmLog_Accessor = New frmLog_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.ListBox1_GotFocus(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for InitializeComponent
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As frmLog_Accessor = New frmLog_Accessor ' TODO: Initialize to an appropriate value
        target.InitializeComponent()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmLog_Load
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmLog_LoadTest()
        Dim target As frmLog_Accessor = New frmLog_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmLog_Load(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmLog_KeyDown
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmLog_KeyDownTest()
        Dim target As frmLog_Accessor = New frmLog_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As KeyEventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmLog_KeyDown(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Frm5DelDirectory
    '''</summary>
    <TestMethod()> _
    Public Sub Frm5DelDirectoryTest()
        Dim target As frmLog = New frmLog ' TODO: Initialize to an appropriate value
        Dim SourceDirectory As String = String.Empty ' TODO: Initialize to an appropriate value
        target.Frm5DelDirectory(SourceDirectory)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Frm5DelAllDirectory
    '''</summary>
    <TestMethod()> _
    Public Sub Frm5DelAllDirectoryTest()
        Dim target As frmLog = New frmLog ' TODO: Initialize to an appropriate value
        Dim SourceDirectory As String = String.Empty ' TODO: Initialize to an appropriate value
        target.Frm5DelAllDirectory(SourceDirectory)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for FileTransfer
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub FileTransferTest()
        Dim target As frmLog_Accessor = New frmLog_Accessor ' TODO: Initialize to an appropriate value
        Dim iscopy As Boolean = False ' TODO: Initialize to an appropriate value
        target.FileTransfer(iscopy)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for FileList
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub FileListTest()
        Dim target As frmLog_Accessor = New frmLog_Accessor ' TODO: Initialize to an appropriate value
        target.FileList()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Dispose
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub DisposeTest()
        Dim target As frmLog_Accessor = New frmLog_Accessor ' TODO: Initialize to an appropriate value
        Dim disposing As Boolean = False ' TODO: Initialize to an appropriate value
        target.Dispose(disposing)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for DirList
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub DirListTest()
        Dim target As frmLog_Accessor = New frmLog_Accessor ' TODO: Initialize to an appropriate value
        target.DirList()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for CopyFile
    '''</summary>
    <TestMethod()> _
    Public Sub CopyFileTest()
        Dim target As frmLog = New frmLog ' TODO: Initialize to an appropriate value
        Dim SourceFile As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim TargetFile As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim isdel As Boolean = False ' TODO: Initialize to an appropriate value
        target.CopyFile(SourceFile, TargetFile, isdel)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for CopyDirectory
    '''</summary>
    <TestMethod()> _
    Public Sub CopyDirectoryTest()
        Dim target As frmLog = New frmLog ' TODO: Initialize to an appropriate value
        Dim SourceDirectory As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim TargetDirectory As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim isdel As Boolean = False ' TODO: Initialize to an appropriate value
        target.CopyDirectory(SourceDirectory, TargetDirectory, isdel)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmLog Constructor
    '''</summary>
    <TestMethod()> _
    Public Sub frmLogConstructorTest()
        Dim target As frmLog = New frmLog
        Assert.Inconclusive("TODO: Implement code to verify target")
    End Sub
End Class
