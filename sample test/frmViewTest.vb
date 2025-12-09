Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ParasSRT



'''<summary>
'''This is a test class for frmViewTest and is intended
'''to contain all frmViewTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmViewTest


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
    '''A test for tvlbl
    '''</summary>
    <TestMethod()> _
    Public Sub tvlblTest()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.tvlbl = expected
        actual = target.tvlbl
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for timelbl
    '''</summary>
    <TestMethod()> _
    Public Sub timelblTest()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.timelbl = expected
        actual = target.timelbl
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for PictureBox1
    '''</summary>
    <TestMethod()> _
    Public Sub PictureBox1Test()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As PictureBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As PictureBox
        target.PictureBox1 = expected
        actual = target.PictureBox1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for picGraph
    '''</summary>
    <TestMethod()> _
    Public Sub picGraphTest()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As PictureBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As PictureBox
        target.picGraph = expected
        actual = target.picGraph
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Panel1
    '''</summary>
    <TestMethod()> _
    Public Sub Panel1Test()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Panel = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Panel
        target.Panel1 = expected
        actual = target.Panel1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Lonlbl
    '''</summary>
    <TestMethod()> _
    Public Sub LonlblTest()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.Lonlbl = expected
        actual = target.Lonlbl
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblvH
    '''</summary>
    <TestMethod()> _
    Public Sub lblvHTest()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblvH = expected
        actual = target.lblvH
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblvd
    '''</summary>
    <TestMethod()> _
    Public Sub lblvdTest()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblvd = expected
        actual = target.lblvd
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblvbp
    '''</summary>
    <TestMethod()> _
    Public Sub lblvbpTest()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblvbp = expected
        actual = target.lblvbp
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lbllong
    '''</summary>
    <TestMethod()> _
    Public Sub lbllongTest()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lbllong = expected
        actual = target.lbllong
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblHMtxt
    '''</summary>
    <TestMethod()> _
    Public Sub lblHMtxtTest()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblHMtxt = expected
        actual = target.lblHMtxt
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblhm
    '''</summary>
    <TestMethod()> _
    Public Sub lblhmTest()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblhm = expected
        actual = target.lblhm
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblH
    '''</summary>
    <TestMethod()> _
    Public Sub lblHTest()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblH = expected
        actual = target.lblH
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lbldepth
    '''</summary>
    <TestMethod()> _
    Public Sub lbldepthTest()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lbldepth = expected
        actual = target.lbldepth
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblbp
    '''</summary>
    <TestMethod()> _
    Public Sub lblbpTest()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblbp = expected
        actual = target.lblbp
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for latvlbl
    '''</summary>
    <TestMethod()> _
    Public Sub latvlblTest()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.latvlbl = expected
        actual = target.latvlbl
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for latlbl
    '''</summary>
    <TestMethod()> _
    Public Sub latlblTest()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.latlbl = expected
        actual = target.latlbl
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Label9
    '''</summary>
    <TestMethod()> _
    Public Sub Label9Test()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.Label9 = expected
        actual = target.Label9
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Label8
    '''</summary>
    <TestMethod()> _
    Public Sub Label8Test()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.Label8 = expected
        actual = target.Label8
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Label7
    '''</summary>
    <TestMethod()> _
    Public Sub Label7Test()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.Label7 = expected
        actual = target.Label7
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Label6
    '''</summary>
    <TestMethod()> _
    Public Sub Label6Test()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.Label6 = expected
        actual = target.Label6
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Label5
    '''</summary>
    <TestMethod()> _
    Public Sub Label5Test()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.Label5 = expected
        actual = target.Label5
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Label4
    '''</summary>
    <TestMethod()> _
    Public Sub Label4Test()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.Label4 = expected
        actual = target.Label4
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Label3
    '''</summary>
    <TestMethod()> _
    Public Sub Label3Test()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.Label3 = expected
        actual = target.Label3
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Label2
    '''</summary>
    <TestMethod()> _
    Public Sub Label2Test()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.Label2 = expected
        actual = target.Label2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Label10
    '''</summary>
    <TestMethod()> _
    Public Sub Label10Test()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.Label10 = expected
        actual = target.Label10
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Label1
    '''</summary>
    <TestMethod()> _
    Public Sub Label1Test()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.Label1 = expected
        actual = target.Label1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for frm8mvlbl
    '''</summary>
    <TestMethod()> _
    Public Sub frm8mvlblTest()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.frm8mvlbl = expected
        actual = target.frm8mvlbl
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for frm8lbl_ch
    '''</summary>
    <TestMethod()> _
    Public Sub frm8lbl_chTest()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.frm8lbl_ch = expected
        actual = target.frm8lbl_ch
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for frm8kmvlabel
    '''</summary>
    <TestMethod()> _
    Public Sub frm8kmvlabelTest()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.frm8kmvlabel = expected
        actual = target.frm8kmvlabel
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for disp
    '''</summary>
    <TestMethod()> _
    Public Sub dispTest()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.disp = expected
        actual = target.disp
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for dismlbl
    '''</summary>
    <TestMethod()> _
    Public Sub dismlblTest()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.dismlbl = expected
        actual = target.dismlbl
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for diskmlbl
    '''</summary>
    <TestMethod()> _
    Public Sub diskmlblTest()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.diskmlbl = expected
        actual = target.diskmlbl
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for datevlbl
    '''</summary>
    <TestMethod()> _
    Public Sub datevlblTest()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.datevlbl = expected
        actual = target.datevlbl
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for datelbl
    '''</summary>
    <TestMethod()> _
    Public Sub datelblTest()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.datelbl = expected
        actual = target.datelbl
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for UpdateMeter
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub UpdateMeterTest()
        Dim target As frmView_Accessor = New frmView_Accessor ' TODO: Initialize to an appropriate value
        target.UpdateMeter()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for UpdateKM
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub UpdateKMTest()
        Dim target As frmView_Accessor = New frmView_Accessor ' TODO: Initialize to an appropriate value
        target.UpdateKM()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for ToDMS
    '''</summary>
    <TestMethod()> _
    Public Sub ToDMSTest()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        Dim aDecimal As [Decimal] = New [Decimal] ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = target.ToDMS(aDecimal)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for ReDrawCh
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub ReDrawChTest()
        Dim target As frmView_Accessor = New frmView_Accessor ' TODO: Initialize to an appropriate value
        Dim chan As Integer = 0 ' TODO: Initialize to an appropriate value
        target.ReDrawCh(chan)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for ReDrawAllCh
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub ReDrawAllChTest()
        Dim target As frmView_Accessor = New frmView_Accessor ' TODO: Initialize to an appropriate value
        target.ReDrawAllCh()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for ReadConfigFile
    '''</summary>
    <TestMethod()> _
    Public Sub ReadConfigFileTest()
        Dim target As frmView = New frmView ' TODO: Initialize to an appropriate value
        target.ReadConfigFile()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for PlotCurvesT
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub PlotCurvesTTest()
        Dim target As frmView_Accessor = New frmView_Accessor ' TODO: Initialize to an appropriate value
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
    '''A test for OpenReadAndPlotData
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub OpenReadAndPlotDataTest()
        Dim target As frmView_Accessor = New frmView_Accessor ' TODO: Initialize to an appropriate value
        target.OpenReadAndPlotData()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for LogDataFolderView
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub LogDataFolderViewTest()
        Dim target As frmView_Accessor = New frmView_Accessor ' TODO: Initialize to an appropriate value
        Dim gtype As Integer = 0 ' TODO: Initialize to an appropriate value
        target.LogDataFolderView(gtype)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for InitializeComponent
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As frmView_Accessor = New frmView_Accessor ' TODO: Initialize to an appropriate value
        target.InitializeComponent()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmView_Load
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmView_LoadTest()
        Dim target As frmView_Accessor = New frmView_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmView_Load(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmView_KeyDown
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmView_KeyDownTest()
        Dim target As frmView_Accessor = New frmView_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As KeyEventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmView_KeyDown(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for DrawGraph
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub DrawGraphTest()
        Dim target As frmView_Accessor = New frmView_Accessor ' TODO: Initialize to an appropriate value
        target.DrawGraph()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for DrawFixedFrame
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub DrawFixedFrameTest()
        Dim target As frmView_Accessor = New frmView_Accessor ' TODO: Initialize to an appropriate value
        target.DrawFixedFrame()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Dispose
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub DisposeTest()
        Dim target As frmView_Accessor = New frmView_Accessor ' TODO: Initialize to an appropriate value
        Dim disposing As Boolean = False ' TODO: Initialize to an appropriate value
        target.Dispose(disposing)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for ClearBScanWindow
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub ClearBScanWindowTest()
        Dim target As frmView_Accessor = New frmView_Accessor ' TODO: Initialize to an appropriate value
        target.ClearBScanWindow()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for CalculateGateValue
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub CalculateGateValueTest()
        Dim target As frmView_Accessor = New frmView_Accessor ' TODO: Initialize to an appropriate value
        Dim ch As Integer = 0 ' TODO: Initialize to an appropriate value
        target.CalculateGateValue(ch)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for AcquireFreezeData
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub AcquireFreezeDataTest()
        Dim target As frmView_Accessor = New frmView_Accessor ' TODO: Initialize to an appropriate value
        Dim gtype As Integer = 0 ' TODO: Initialize to an appropriate value
        target.AcquireFreezeData(gtype)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmView Constructor
    '''</summary>
    <TestMethod()> _
    Public Sub frmViewConstructorTest()
        Dim target As frmView = New frmView
        Assert.Inconclusive("TODO: Implement code to verify target")
    End Sub
End Class
