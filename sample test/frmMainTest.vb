Imports System.Windows.Forms

Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ParasSRT



'''<summary>
'''This is a test class for frmMainTest and is intended
'''to contain all frmMainTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmMainTest


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
    '''A test for PictureBox1
    '''</summary>
    <TestMethod()> _
    Public Sub PictureBox1Test()
        Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
        Dim expected As PictureBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As PictureBox
        target.PictureBox1 = expected
        actual = target.PictureBox1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblParas
    '''</summary>
    <TestMethod()> _
    Public Sub lblParasTest()
        Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblParas = expected
        actual = target.lblParas
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblMenu8
    '''</summary>
    <TestMethod()> _
    Public Sub lblMenu8Test()
        Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblMenu8 = expected
        actual = target.lblMenu8
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblMenu7
    '''</summary>
    <TestMethod()> _
    Public Sub lblMenu7Test()
        Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
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
        Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
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
        Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblMenu5 = expected
        actual = target.lblMenu5
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblMenu4
    '''</summary>
    <TestMethod()> _
    Public Sub lblMenu4Test()
        Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblMenu4 = expected
        actual = target.lblMenu4
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblMenu3
    '''</summary>
    <TestMethod()> _
    Public Sub lblMenu3Test()
        Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblMenu3 = expected
        actual = target.lblMenu3
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblMenu2
    '''</summary>
    <TestMethod()> _
    Public Sub lblMenu2Test()
        Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
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
        Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblMenu1 = expected
        actual = target.lblMenu1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblDate
    '''</summary>
    <TestMethod()> _
    Public Sub lblDateTest()
        Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblDate = expected
        actual = target.lblDate
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblCaption2
    '''</summary>
    <TestMethod()> _
    Public Sub lblCaption2Test()
        Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblCaption2 = expected
        actual = target.lblCaption2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblCaption
    '''</summary>
    <TestMethod()> _
    Public Sub lblCaptionTest()
        Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblCaption = expected
        actual = target.lblCaption
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for ToraGetData
    '''</summary>
    <TestMethod()> _
    Public Sub ToraGetDataTest()
        Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
        target.ToraGetData()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SetPlots
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub SetPlotsTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
        Dim chnl As Integer = 0 ' TODO: Initialize to an appropriate value
        target.SetPlots(chnl)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for PlotCurvesT
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub PlotCurvesTTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
        Dim v() As Byte = Nothing ' TODO: Initialize to an appropriate value
        Dim vExpected() As Byte = Nothing ' TODO: Initialize to an appropriate value
        Dim chnl As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim fillpoly As Boolean = False ' TODO: Initialize to an appropriate value
        Dim zoom As Single = 0.0! ' TODO: Initialize to an appropriate value
        target.PlotCurvesT(v, chnl, fillpoly, zoom)
        Assert.AreEqual(vExpected, v)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Main
    '''</summary>
    <TestMethod()> _
    Public Sub MainTest()
        frmMain.Main()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Load_Graph
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub Load_GraphTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
        target.Load_Graph()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for InitializeComponent
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
        target.InitializeComponent()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmMain_KeyDown
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmMain_KeyDownTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As KeyEventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmMain_KeyDown(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmMain_Closed
    '''</summary>
    <TestMethod()> _
    Public Sub frmMain_ClosedTest()
        Dim target As frmMain = New frmMain ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmMain_Closed(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Form1_Load
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub Form1_LoadTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.Form1_Load(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Dispose
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub DisposeTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
        Dim disposing As Boolean = False ' TODO: Initialize to an appropriate value
        target.Dispose(disposing)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for AcquireDPAll
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub AcquireDPAllTest()
        Dim target As frmMain_Accessor = New frmMain_Accessor ' TODO: Initialize to an appropriate value
        Dim chnl As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim eras As Boolean = False ' TODO: Initialize to an appropriate value
        target.AcquireDPAll(chnl, eras)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmMain Constructor
    '''</summary>
    <TestMethod()> _
    Public Sub frmMainConstructorTest()
        Dim target As frmMain = New frmMain
        Assert.Inconclusive("TODO: Implement code to verify target")
    End Sub
End Class
