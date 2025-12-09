Imports System.IO

Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ParasSRT



'''<summary>
'''This is a test class for frmCalibTest and is intended
'''to contain all frmCalibTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmCalibTest


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
    '''A test for Timer1
    '''</summary>
    <TestMethod()> _
    Public Sub Timer1Test()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Timer = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Timer
        target.Timer1 = expected
        actual = target.Timer1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Panel2
    '''</summary>
    <TestMethod()> _
    Public Sub Panel2Test()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Panel = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Panel
        target.Panel2 = expected
        actual = target.Panel2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Panel1
    '''</summary>
    <TestMethod()> _
    Public Sub Panel1Test()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Panel = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Panel
        target.Panel1 = expected
        actual = target.Panel1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for ListBox1
    '''</summary>
    <TestMethod()> _
    Public Sub ListBox1Test()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As ListBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ListBox
        target.ListBox1 = expected
        actual = target.ListBox1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblZoomR
    '''</summary>
    <TestMethod()> _
    Public Sub lblZoomRTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblZoomR = expected
        actual = target.lblZoomR
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblZoomP
    '''</summary>
    <TestMethod()> _
    Public Sub lblZoomPTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblZoomP = expected
        actual = target.lblZoomP
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblZoomM
    '''</summary>
    <TestMethod()> _
    Public Sub lblZoomMTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblZoomM = expected
        actual = target.lblZoomM
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblZoomL
    '''</summary>
    <TestMethod()> _
    Public Sub lblZoomLTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblZoomL = expected
        actual = target.lblZoomL
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblThresh
    '''</summary>
    <TestMethod()> _
    Public Sub lblThreshTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblThresh = expected
        actual = target.lblThresh
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblThr2
    '''</summary>
    <TestMethod()> _
    Public Sub lblThr2Test()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblThr2 = expected
        actual = target.lblThr2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblSide2
    '''</summary>
    <TestMethod()> _
    Public Sub lblSide2Test()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblSide2 = expected
        actual = target.lblSide2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblSide1
    '''</summary>
    <TestMethod()> _
    Public Sub lblSide1Test()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblSide1 = expected
        actual = target.lblSide1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblReject
    '''</summary>
    <TestMethod()> _
    Public Sub lblRejectTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblReject = expected
        actual = target.lblReject
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblRange
    '''</summary>
    <TestMethod()> _
    Public Sub lblRangeTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblRange = expected
        actual = target.lblRange
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblPH
    '''</summary>
    <TestMethod()> _
    Public Sub lblPHTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblPH = expected
        actual = target.lblPH
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblMenu7
    '''</summary>
    <TestMethod()> _
    Public Sub lblMenu7Test()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
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
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
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
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
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
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
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
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
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
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
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
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblMenu1 = expected
        actual = target.lblMenu1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblInput
    '''</summary>
    <TestMethod()> _
    Public Sub lblInputTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblInput = expected
        actual = target.lblInput
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblGateW
    '''</summary>
    <TestMethod()> _
    Public Sub lblGateWTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblGateW = expected
        actual = target.lblGateW
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblGateS
    '''</summary>
    <TestMethod()> _
    Public Sub lblGateSTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblGateS = expected
        actual = target.lblGateS
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblGain
    '''</summary>
    <TestMethod()> _
    Public Sub lblGainTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblGain = expected
        actual = target.lblGain
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblG2Wd
    '''</summary>
    <TestMethod()> _
    Public Sub lblG2WdTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblG2Wd = expected
        actual = target.lblG2Wd
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblG2St
    '''</summary>
    <TestMethod()> _
    Public Sub lblG2StTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblG2St = expected
        actual = target.lblG2St
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblDisp
    '''</summary>
    <TestMethod()> _
    Public Sub lblDispTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblDisp = expected
        actual = target.lblDisp
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblDelay
    '''</summary>
    <TestMethod()> _
    Public Sub lblDelayTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblDelay = expected
        actual = target.lblDelay
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblCalSet
    '''</summary>
    <TestMethod()> _
    Public Sub lblCalSetTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblCalSet = expected
        actual = target.lblCalSet
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblC9
    '''</summary>
    <TestMethod()> _
    Public Sub lblC9Test()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblC9 = expected
        actual = target.lblC9
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblC8
    '''</summary>
    <TestMethod()> _
    Public Sub lblC8Test()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblC8 = expected
        actual = target.lblC8
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblC7
    '''</summary>
    <TestMethod()> _
    Public Sub lblC7Test()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblC7 = expected
        actual = target.lblC7
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblC6
    '''</summary>
    <TestMethod()> _
    Public Sub lblC6Test()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblC6 = expected
        actual = target.lblC6
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblC5
    '''</summary>
    <TestMethod()> _
    Public Sub lblC5Test()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblC5 = expected
        actual = target.lblC5
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblC4
    '''</summary>
    <TestMethod()> _
    Public Sub lblC4Test()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblC4 = expected
        actual = target.lblC4
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblC3
    '''</summary>
    <TestMethod()> _
    Public Sub lblC3Test()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblC3 = expected
        actual = target.lblC3
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblC2
    '''</summary>
    <TestMethod()> _
    Public Sub lblC2Test()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblC2 = expected
        actual = target.lblC2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblC10
    '''</summary>
    <TestMethod()> _
    Public Sub lblC10Test()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblC10 = expected
        actual = target.lblC10
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblC1
    '''</summary>
    <TestMethod()> _
    Public Sub lblC1Test()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblC1 = expected
        actual = target.lblC1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblAng
    '''</summary>
    <TestMethod()> _
    Public Sub lblAngTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblAng = expected
        actual = target.lblAng
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for ViewGraph
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub ViewGraphTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        target.ViewGraph()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txt_KeyPress
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txt_KeyPressTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As KeyPressEventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txt_KeyPress(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for ToraGetData
    '''</summary>
    <TestMethod()> _
    Public Sub ToraGetDataTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        target.ToraGetData()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Timer1_Tick
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub Timer1_TickTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.Timer1_Tick(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for TextBox1Visible
    '''</summary>
    <TestMethod()> _
    Public Sub TextBox1VisibleTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim v As Boolean = False ' TODO: Initialize to an appropriate value
        target.TextBox1Visible(v)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for TextBox10Visible
    '''</summary>
    <TestMethod()> _
    Public Sub TextBox10VisibleTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim v As Boolean = False ' TODO: Initialize to an appropriate value
        target.TextBox10Visible(v)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for StoreVals
    '''</summary>
    <TestMethod()> _
    Public Sub StoreValsTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        target.StoreVals()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for ShowTextBoxes
    '''</summary>
    <TestMethod()> _
    Public Sub ShowTextBoxesTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim v As Boolean = False ' TODO: Initialize to an appropriate value
        target.ShowTextBoxes(v)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SetUpConfig
    '''</summary>
    <TestMethod()> _
    Public Sub SetUpConfigTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim ci As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim cj As Integer = 0 ' TODO: Initialize to an appropriate value
        target.SetUpConfig(ci, cj)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SetTextBox
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub SetTextBoxTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        target.SetTextBox()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SetPlotsData
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub SetPlotsDataTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim chnl As Integer = 0 ' TODO: Initialize to an appropriate value
        target.SetPlotsData(chnl)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SetPlots
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub SetPlotsTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim chnl As Integer = 0 ' TODO: Initialize to an appropriate value
        target.SetPlots(chnl)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SetMenu
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub SetMenuTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim mnu1 As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim mnu2 As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim mnu3 As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim mnu4 As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim mnu5 As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim mnu6 As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim mnu7 As String = String.Empty ' TODO: Initialize to an appropriate value
        target.SetMenu(mnu1, mnu2, mnu3, mnu4, mnu5, mnu6, mnu7)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SetLabels
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub SetLabelsTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        target.SetLabels()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SavePRV
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub SavePRVTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim isv As Integer = 0 ' TODO: Initialize to an appropriate value
        target.SavePRV(isv)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SavePRH
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub SavePRHTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        target.SavePRH()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SavePRC
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub SavePRCTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        target.SavePRC()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SaveInfo0
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub SaveInfo0Test()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim objBW As BinaryWriter = Nothing ' TODO: Initialize to an appropriate value
        target.SaveInfo0(objBW)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for ReadData
    '''</summary>
    <TestMethod()> _
    Public Sub ReadDataTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim chnl As Integer = 0 ' TODO: Initialize to an appropriate value
        target.ReadData(chnl)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for PlotEnv
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub PlotEnvTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim vmax As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim vmaxExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim imax As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim imaxExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim j As Integer = 0 ' TODO: Initialize to an appropriate value
        target.PlotEnv(vmax, imax, j)
        Assert.AreEqual(vmaxExpected, vmax)
        Assert.AreEqual(imaxExpected, imax)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for PlotCurvesT
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub PlotCurvesTTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
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
    '''A test for PlotCurvesData
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub PlotCurvesDataTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim v() As Byte = Nothing ' TODO: Initialize to an appropriate value
        Dim vExpected() As Byte = Nothing ' TODO: Initialize to an appropriate value
        Dim chnl As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim fillpoly As Boolean = False ' TODO: Initialize to an appropriate value
        target.PlotCurvesData(v, chnl, fillpoly)
        Assert.AreEqual(vExpected, v)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for PlotCurves
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub PlotCurvesTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim v() As Byte = Nothing ' TODO: Initialize to an appropriate value
        Dim vExpected() As Byte = Nothing ' TODO: Initialize to an appropriate value
        Dim chnl As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim fillpoly As Boolean = False ' TODO: Initialize to an appropriate value
        Dim zoom As Single = 0.0! ' TODO: Initialize to an appropriate value
        target.PlotCurves(v, chnl, fillpoly, zoom)
        Assert.AreEqual(vExpected, v)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for LblsVisible
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub LblsVisibleTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim v1 As Boolean = False ' TODO: Initialize to an appropriate value
        Dim v2 As Boolean = False ' TODO: Initialize to an appropriate value
        Dim v3 As Boolean = False ' TODO: Initialize to an appropriate value
        target.LblsVisible(v1, v2, v3)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for lblCVisible
    '''</summary>
    <TestMethod()> _
    Public Sub lblCVisibleTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim v As Boolean = False ' TODO: Initialize to an appropriate value
        target.lblCVisible(v)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for lblC1Visible
    '''</summary>
    <TestMethod()> _
    Public Sub lblC1VisibleTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim v As Boolean = False ' TODO: Initialize to an appropriate value
        target.lblC1Visible(v)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for InitializeComponent
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        target.InitializeComponent()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmCalib_Paint
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmCalib_PaintTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As PaintEventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmCalib_Paint(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmCalib_Load
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmCalib_LoadTest1()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        target.frmCalib_Load()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmCalib_Load
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmCalib_LoadTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmCalib_Load(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmCalib_KeyUp
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmCalib_KeyUpTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As KeyEventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmCalib_KeyUp(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmCalib_KeyPress
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmCalib_KeyPressTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As KeyPressEventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmCalib_KeyPress(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmCalib_KeyDown
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmCalib_KeyDownTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As KeyEventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmCalib_KeyDown(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmCalib_Closed
    '''</summary>
    <TestMethod()> _
    Public Sub frmCalib_ClosedTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmCalib_Closed(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmCalib_Activated
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmCalib_ActivatedTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmCalib_Activated(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for EditConfig
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub EditConfigTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        target.EditConfig()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for DrawPolygonPoint
    '''</summary>
    <TestMethod()> _
    Public Sub DrawPolygonPointTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim e As PaintEventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.DrawPolygonPoint(e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for DoEditMenu
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub DoEditMenuTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim k As Integer = 0 ' TODO: Initialize to an appropriate value
        target.DoEditMenu(k)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for DispVals
    '''</summary>
    <TestMethod()> _
    Public Sub DispValsTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        target.DispVals()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for DispTextBoxes1
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub DispTextBoxes1Test()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        target.DispTextBoxes1()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for DispTextBoxes
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub DispTextBoxesTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        target.DispTextBoxes()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Dispose
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub DisposeTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim disposing As Boolean = False ' TODO: Initialize to an appropriate value
        target.Dispose(disposing)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for DelConfig
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub DelConfigTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        target.DelConfig()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for CreateConfigFolder
    '''</summary>
    <TestMethod()> _
    Public Sub CreateConfigFolderTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        target.CreateConfigFolder()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for ClearLbls
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub ClearLblsTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        target.ClearLbls()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for ClearAllKeys
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub ClearAllKeysTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        target.ClearAllKeys()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for AddNewFileName
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub AddNewFileNameTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        target.AddNewFileName()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Add2CnfList
    '''</summary>
    <TestMethod()> _
    Public Sub Add2CnfListTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        target.Add2CnfList()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for AcquireZoom
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub AcquireZoomTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim j As Integer = 0 ' TODO: Initialize to an appropriate value
        target.AcquireZoom(j)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for AcquireWRTData
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub AcquireWRTDataTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim gtype As Integer = 0 ' TODO: Initialize to an appropriate value
        target.AcquireWRTData(gtype)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for AcquirePRHData
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub AcquirePRHDataTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim gtype As Integer = 0 ' TODO: Initialize to an appropriate value
        target.AcquirePRHData(gtype)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for AcquirePRCData
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub AcquirePRCDataTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim gtype As Integer = 0 ' TODO: Initialize to an appropriate value
        target.AcquirePRCData(gtype)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for AcquireFreezeEnv
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub AcquireFreezeEnvTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim j As Integer = 0 ' TODO: Initialize to an appropriate value
        target.AcquireFreezeEnv(j)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for AcquireFreezeDrawGrid
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub AcquireFreezeDrawGridTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim j As Integer = 0 ' TODO: Initialize to an appropriate value
        target.AcquireFreezeDrawGrid(j)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for AcquireFreezeData
    '''</summary>
    <TestMethod()> _
    Public Sub AcquireFreezeDataTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim gtype As Integer = 0 ' TODO: Initialize to an appropriate value
        target.AcquireFreezeData(gtype)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for AcquireFreeze
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub AcquireFreezeTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim j As Integer = 0 ' TODO: Initialize to an appropriate value
        target.AcquireFreeze(j)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for AcquireDPAll
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub AcquireDPAllTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim chnl As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim eras As Boolean = False ' TODO: Initialize to an appropriate value
        target.AcquireDPAll(chnl, eras)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for AcquireDP
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub AcquireDPTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim j As Integer = 0 ' TODO: Initialize to an appropriate value
        target.AcquireDP(j)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for AcquireData2
    '''</summary>
    <TestMethod()> _
    Public Sub AcquireData2Test()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim gtype As Integer = 0 ' TODO: Initialize to an appropriate value
        target.AcquireData2(gtype)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for AcquireData
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub AcquireDataTest()
        Dim target As frmCalib_Accessor = New frmCalib_Accessor ' TODO: Initialize to an appropriate value
        Dim j As Integer = 0 ' TODO: Initialize to an appropriate value
        target.AcquireData(j)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Acquire
    '''</summary>
    <TestMethod()> _
    Public Sub AcquireTest()
        Dim target As frmCalib = New frmCalib ' TODO: Initialize to an appropriate value
        Dim j As Integer = 0 ' TODO: Initialize to an appropriate value
        target.Acquire(j)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmCalib Constructor
    '''</summary>
    <TestMethod()> _
    Public Sub frmCalibConstructorTest()
        Dim target As frmCalib = New frmCalib
        Assert.Inconclusive("TODO: Implement code to verify target")
    End Sub
End Class
