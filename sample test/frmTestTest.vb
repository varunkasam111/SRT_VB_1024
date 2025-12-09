Imports System.IO

Imports System.Windows.Forms

Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ParasSRT



'''<summary>
'''This is a test class for frmTestTest and is intended
'''to contain all frmTestTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmTestTest


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
    '''A test for txtTP2
    '''</summary>
    <TestMethod()> _
    Public Sub txtTP2Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtTP2 = expected
        actual = target.txtTP2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtTP
    '''</summary>
    <TestMethod()> _
    Public Sub txtTPTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtTP = expected
        actual = target.txtTP
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtTotKm
    '''</summary>
    <TestMethod()> _
    Public Sub txtTotKmTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtTotKm = expected
        actual = target.txtTotKm
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtTime
    '''</summary>
    <TestMethod()> _
    Public Sub txtTimeTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtTime = expected
        actual = target.txtTime
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtSta2
    '''</summary>
    <TestMethod()> _
    Public Sub txtSta2Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtSta2 = expected
        actual = target.txtSta2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtSta1
    '''</summary>
    <TestMethod()> _
    Public Sub txtSta1Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtSta1 = expected
        actual = target.txtSta1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtSec
    '''</summary>
    <TestMethod()> _
    Public Sub txtSecTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtSec = expected
        actual = target.txtSec
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtRem
    '''</summary>
    <TestMethod()> _
    Public Sub txtRemTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtRem = expected
        actual = target.txtRem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtPH2
    '''</summary>
    <TestMethod()> _
    Public Sub txtPH2Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtPH2 = expected
        actual = target.txtPH2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtPH
    '''</summary>
    <TestMethod()> _
    Public Sub txtPHTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtPH = expected
        actual = target.txtPH
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtName
    '''</summary>
    <TestMethod()> _
    Public Sub txtNameTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtName = expected
        actual = target.txtName
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtMeter2
    '''</summary>
    <TestMethod()> _
    Public Sub txtMeter2Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtMeter2 = expected
        actual = target.txtMeter2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtMCNO
    '''</summary>
    <TestMethod()> _
    Public Sub txtMCNOTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtMCNO = expected
        actual = target.txtMCNO
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtMask4
    '''</summary>
    <TestMethod()> _
    Public Sub txtMask4Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtMask4 = expected
        actual = target.txtMask4
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtMask3
    '''</summary>
    <TestMethod()> _
    Public Sub txtMask3Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtMask3 = expected
        actual = target.txtMask3
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtM
    '''</summary>
    <TestMethod()> _
    Public Sub txtMTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtM = expected
        actual = target.txtM
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtLongtitude
    '''</summary>
    <TestMethod()> _
    Public Sub txtLongtitudeTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtLongtitude = expected
        actual = target.txtLongtitude
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtLoc3
    '''</summary>
    <TestMethod()> _
    Public Sub txtLoc3Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtLoc3 = expected
        actual = target.txtLoc3
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtLoc2
    '''</summary>
    <TestMethod()> _
    Public Sub txtLoc2Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtLoc2 = expected
        actual = target.txtLoc2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtLoc1
    '''</summary>
    <TestMethod()> _
    Public Sub txtLoc1Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtLoc1 = expected
        actual = target.txtLoc1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtlen
    '''</summary>
    <TestMethod()> _
    Public Sub txtlenTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtlen = expected
        actual = target.txtlen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtLatitude
    '''</summary>
    <TestMethod()> _
    Public Sub txtLatitudeTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtLatitude = expected
        actual = target.txtLatitude
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtKM2
    '''</summary>
    <TestMethod()> _
    Public Sub txtKM2Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtKM2 = expected
        actual = target.txtKM2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtKm
    '''</summary>
    <TestMethod()> _
    Public Sub txtKmTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtKm = expected
        actual = target.txtKm
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtHM2
    '''</summary>
    <TestMethod()> _
    Public Sub txtHM2Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtHM2 = expected
        actual = target.txtHM2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtHM
    '''</summary>
    <TestMethod()> _
    Public Sub txtHMTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtHM = expected
        actual = target.txtHM
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtheight
    '''</summary>
    <TestMethod()> _
    Public Sub txtheightTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtheight = expected
        actual = target.txtheight
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtendTP
    '''</summary>
    <TestMethod()> _
    Public Sub txtendTPTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtendTP = expected
        actual = target.txtendTP
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtEndMeter
    '''</summary>
    <TestMethod()> _
    Public Sub txtEndMeterTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtEndMeter = expected
        actual = target.txtEndMeter
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtEndKm
    '''</summary>
    <TestMethod()> _
    Public Sub txtEndKmTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtEndKm = expected
        actual = target.txtEndKm
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtDiv
    '''</summary>
    <TestMethod()> _
    Public Sub txtDivTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtDiv = expected
        actual = target.txtDiv
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtdepth
    '''</summary>
    <TestMethod()> _
    Public Sub txtdepthTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtdepth = expected
        actual = target.txtdepth
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtDate
    '''</summary>
    <TestMethod()> _
    Public Sub txtDateTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtDate = expected
        actual = target.txtDate
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtcm
    '''</summary>
    <TestMethod()> _
    Public Sub txtcmTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtcm = expected
        actual = target.txtcm
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtckm
    '''</summary>
    <TestMethod()> _
    Public Sub txtckmTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtckm = expected
        actual = target.txtckm
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtCh
    '''</summary>
    <TestMethod()> _
    Public Sub txtChTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtCh = expected
        actual = target.txtCh
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtbp
    '''</summary>
    <TestMethod()> _
    Public Sub txtbpTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtbp = expected
        actual = target.txtbp
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Panel4
    '''</summary>
    <TestMethod()> _
    Public Sub Panel4Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Panel = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Panel
        target.Panel4 = expected
        actual = target.Panel4
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Panel1
    '''</summary>
    <TestMethod()> _
    Public Sub Panel1Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Panel = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Panel
        target.Panel1 = expected
        actual = target.Panel1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblTyp2
    '''</summary>
    <TestMethod()> _
    Public Sub lblTyp2Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblTyp2 = expected
        actual = target.lblTyp2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblTyp
    '''</summary>
    <TestMethod()> _
    Public Sub lblTypTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblTyp = expected
        actual = target.lblTyp
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblTP2
    '''</summary>
    <TestMethod()> _
    Public Sub lblTP2Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblTP2 = expected
        actual = target.lblTP2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblTotKm
    '''</summary>
    <TestMethod()> _
    Public Sub lblTotKmTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblTotKm = expected
        actual = target.lblTotKm
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblTime
    '''</summary>
    <TestMethod()> _
    Public Sub lblTimeTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblTime = expected
        actual = target.lblTime
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblTest
    '''</summary>
    <TestMethod()> _
    Public Sub lblTestTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblTest = expected
        actual = target.lblTest
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblStation
    '''</summary>
    <TestMethod()> _
    Public Sub lblStationTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblStation = expected
        actual = target.lblStation
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblSet
    '''</summary>
    <TestMethod()> _
    Public Sub lblSetTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblSet = expected
        actual = target.lblSet
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblSec
    '''</summary>
    <TestMethod()> _
    Public Sub lblSecTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblSec = expected
        actual = target.lblSec
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblRoad
    '''</summary>
    <TestMethod()> _
    Public Sub lblRoadTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblRoad = expected
        actual = target.lblRoad
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblRangeStart
    '''</summary>
    <TestMethod()> _
    Public Sub lblRangeStartTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblRangeStart = expected
        actual = target.lblRangeStart
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblrailtype
    '''</summary>
    <TestMethod()> _
    Public Sub lblrailtypeTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblrailtype = expected
        actual = target.lblrailtype
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblRail
    '''</summary>
    <TestMethod()> _
    Public Sub lblRailTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblRail = expected
        actual = target.lblRail
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblProbe
    '''</summary>
    <TestMethod()> _
    Public Sub lblProbeTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblProbe = expected
        actual = target.lblProbe
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblPrev
    '''</summary>
    <TestMethod()> _
    Public Sub lblPrevTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblPrev = expected
        actual = target.lblPrev
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblPH
    '''</summary>
    <TestMethod()> _
    Public Sub lblPHTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblPH = expected
        actual = target.lblPH
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblOPName
    '''</summary>
    <TestMethod()> _
    Public Sub lblOPNameTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblOPName = expected
        actual = target.lblOPName
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblMenu7
    '''</summary>
    <TestMethod()> _
    Public Sub lblMenu7Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
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
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
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
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
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
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
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
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
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
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
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
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblMenu1 = expected
        actual = target.lblMenu1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblMcno
    '''</summary>
    <TestMethod()> _
    Public Sub lblMcnoTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblMcno = expected
        actual = target.lblMcno
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblM
    '''</summary>
    <TestMethod()> _
    Public Sub lblMTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblM = expected
        actual = target.lblM
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblLongtitude
    '''</summary>
    <TestMethod()> _
    Public Sub lblLongtitudeTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblLongtitude = expected
        actual = target.lblLongtitude
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblLoc2
    '''</summary>
    <TestMethod()> _
    Public Sub lblLoc2Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblLoc2 = expected
        actual = target.lblLoc2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblLoc
    '''</summary>
    <TestMethod()> _
    Public Sub lblLocTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblLoc = expected
        actual = target.lblLoc
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lbllen
    '''</summary>
    <TestMethod()> _
    Public Sub lbllenTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lbllen = expected
        actual = target.lbllen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblLatitude
    '''</summary>
    <TestMethod()> _
    Public Sub lblLatitudeTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblLatitude = expected
        actual = target.lblLatitude
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblKM2
    '''</summary>
    <TestMethod()> _
    Public Sub lblKM2Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblKM2 = expected
        actual = target.lblKM2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblKM
    '''</summary>
    <TestMethod()> _
    Public Sub lblKMTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblKM = expected
        actual = target.lblKM
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblHM2
    '''</summary>
    <TestMethod()> _
    Public Sub lblHM2Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblHM2 = expected
        actual = target.lblHM2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblHM
    '''</summary>
    <TestMethod()> _
    Public Sub lblHMTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblHM = expected
        actual = target.lblHM
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblFLoc
    '''</summary>
    <TestMethod()> _
    Public Sub lblFLocTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblFLoc = expected
        actual = target.lblFLoc
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblFlaw
    '''</summary>
    <TestMethod()> _
    Public Sub lblFlawTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblFlaw = expected
        actual = target.lblFlaw
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Lblendtp
    '''</summary>
    <TestMethod()> _
    Public Sub LblendtpTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.Lblendtp = expected
        actual = target.Lblendtp
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblendm
    '''</summary>
    <TestMethod()> _
    Public Sub lblendmTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblendm = expected
        actual = target.lblendm
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblEndKm
    '''</summary>
    <TestMethod()> _
    Public Sub lblEndKmTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblEndKm = expected
        actual = target.lblEndKm
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblDT
    '''</summary>
    <TestMethod()> _
    Public Sub lblDTTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblDT = expected
        actual = target.lblDT
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblDiv
    '''</summary>
    <TestMethod()> _
    Public Sub lblDivTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblDiv = expected
        actual = target.lblDiv
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblDesc2
    '''</summary>
    <TestMethod()> _
    Public Sub lblDesc2Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblDesc2 = expected
        actual = target.lblDesc2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblCode2
    '''</summary>
    <TestMethod()> _
    Public Sub lblCode2Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblCode2 = expected
        actual = target.lblCode2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblCode
    '''</summary>
    <TestMethod()> _
    Public Sub lblCodeTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblCode = expected
        actual = target.lblCode
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblClass2
    '''</summary>
    <TestMethod()> _
    Public Sub lblClass2Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblClass2 = expected
        actual = target.lblClass2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblClass
    '''</summary>
    <TestMethod()> _
    Public Sub lblClassTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblClass = expected
        actual = target.lblClass
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Label9
    '''</summary>
    <TestMethod()> _
    Public Sub Label9Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
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
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
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
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
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
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
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
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
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
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
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
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
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
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.Label2 = expected
        actual = target.Label2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Label14
    '''</summary>
    <TestMethod()> _
    Public Sub Label14Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.Label14 = expected
        actual = target.Label14
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Label13
    '''</summary>
    <TestMethod()> _
    Public Sub Label13Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.Label13 = expected
        actual = target.Label13
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Label12
    '''</summary>
    <TestMethod()> _
    Public Sub Label12Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.Label12 = expected
        actual = target.Label12
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Label11
    '''</summary>
    <TestMethod()> _
    Public Sub Label11Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.Label11 = expected
        actual = target.Label11
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Label10
    '''</summary>
    <TestMethod()> _
    Public Sub Label10Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
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
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.Label1 = expected
        actual = target.Label1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for cmbTyp2
    '''</summary>
    <TestMethod()> _
    Public Sub cmbTyp2Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As ComboBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ComboBox
        target.cmbTyp2 = expected
        actual = target.cmbTyp2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for cmbTyp
    '''</summary>
    <TestMethod()> _
    Public Sub cmbTypTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As ComboBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ComboBox
        target.cmbTyp = expected
        actual = target.cmbTyp
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for cmbSets
    '''</summary>
    <TestMethod()> _
    Public Sub cmbSetsTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As ComboBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ComboBox
        target.cmbSets = expected
        actual = target.cmbSets
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for cmbRoad
    '''</summary>
    <TestMethod()> _
    Public Sub cmbRoadTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As ComboBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ComboBox
        target.cmbRoad = expected
        actual = target.cmbRoad
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for cmbRange2
    '''</summary>
    <TestMethod()> _
    Public Sub cmbRange2Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As ComboBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ComboBox
        target.cmbRange2 = expected
        actual = target.cmbRange2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for cmbRange1
    '''</summary>
    <TestMethod()> _
    Public Sub cmbRange1Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As ComboBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ComboBox
        target.cmbRange1 = expected
        actual = target.cmbRange1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for cmbrailtype
    '''</summary>
    <TestMethod()> _
    Public Sub cmbrailtypeTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As ComboBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ComboBox
        target.cmbrailtype = expected
        actual = target.cmbrailtype
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for cmbRail
    '''</summary>
    <TestMethod()> _
    Public Sub cmbRailTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As ComboBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ComboBox
        target.cmbRail = expected
        actual = target.cmbRail
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for cmbProbe
    '''</summary>
    <TestMethod()> _
    Public Sub cmbProbeTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As ComboBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ComboBox
        target.cmbProbe = expected
        actual = target.cmbProbe
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for cmbMask2
    '''</summary>
    <TestMethod()> _
    Public Sub cmbMask2Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As ComboBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ComboBox
        target.cmbMask2 = expected
        actual = target.cmbMask2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for cmbMask1
    '''</summary>
    <TestMethod()> _
    Public Sub cmbMask1Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As ComboBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ComboBox
        target.cmbMask1 = expected
        actual = target.cmbMask1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for cmbLR
    '''</summary>
    <TestMethod()> _
    Public Sub cmbLRTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As ComboBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ComboBox
        target.cmbLR = expected
        actual = target.cmbLR
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for cmbFLoc2
    '''</summary>
    <TestMethod()> _
    Public Sub cmbFLoc2Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As ComboBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ComboBox
        target.cmbFLoc2 = expected
        actual = target.cmbFLoc2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for cmbFLoc
    '''</summary>
    <TestMethod()> _
    Public Sub cmbFLocTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As ComboBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ComboBox
        target.cmbFLoc = expected
        actual = target.cmbFLoc
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for cmbCris
    '''</summary>
    <TestMethod()> _
    Public Sub cmbCrisTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As ComboBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ComboBox
        target.cmbCris = expected
        actual = target.cmbCris
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for cmbCode2
    '''</summary>
    <TestMethod()> _
    Public Sub cmbCode2Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As ComboBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ComboBox
        target.cmbCode2 = expected
        actual = target.cmbCode2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for cmbCode
    '''</summary>
    <TestMethod()> _
    Public Sub cmbCodeTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As ComboBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ComboBox
        target.cmbCode = expected
        actual = target.cmbCode
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for cmbClass2
    '''</summary>
    <TestMethod()> _
    Public Sub cmbClass2Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As ComboBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ComboBox
        target.cmbClass2 = expected
        actual = target.cmbClass2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for cmbClass
    '''</summary>
    <TestMethod()> _
    Public Sub cmbClassTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As ComboBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ComboBox
        target.cmbClass = expected
        actual = target.cmbClass
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtTP2_TextChanged_2
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtTP2_TextChanged_2Test()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtTP2_TextChanged_2(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtTP2_TextChanged_1
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtTP2_TextChanged_1Test()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtTP2_TextChanged_1(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtTP2_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtTP2_TextChangedTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtTP2_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtTP_TextChanged_1
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtTP_TextChanged_1Test()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtTP_TextChanged_1(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtSta2_TextChanged_2
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtSta2_TextChanged_2Test()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtSta2_TextChanged_2(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtSta2_TextChanged_1
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtSta2_TextChanged_1Test()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtSta2_TextChanged_1(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtSta2_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtSta2_TextChangedTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtSta2_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtSta1_TextChanged_2
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtSta1_TextChanged_2Test()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtSta1_TextChanged_2(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtSta1_TextChanged_1
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtSta1_TextChanged_1Test()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtSta1_TextChanged_1(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtSta1_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtSta1_TextChangedTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtSta1_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtSec_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtSec_TextChangedTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtSec_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtRem_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtRem_TextChangedTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtRem_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtPH2_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtPH2_TextChangedTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtPH2_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtName_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtName_TextChangedTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtName_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtMeter2_TextChanged_4
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtMeter2_TextChanged_4Test()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtMeter2_TextChanged_4(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtMeter2_TextChanged_3
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtMeter2_TextChanged_3Test()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtMeter2_TextChanged_3(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtMeter2_TextChanged_2
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtMeter2_TextChanged_2Test()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtMeter2_TextChanged_2(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtMask4_TextChanged_1
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtMask4_TextChanged_1Test()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtMask4_TextChanged_1(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtMask4_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtMask4_TextChangedTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtMask4_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtMask3_TextChanged_1
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtMask3_TextChanged_1Test()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtMask3_TextChanged_1(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtMask3_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtMask3_TextChangedTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtMask3_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtLoc3_TextChanged_2
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtLoc3_TextChanged_2Test()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtLoc3_TextChanged_2(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtLoc3_TextChanged_1
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtLoc3_TextChanged_1Test()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtLoc3_TextChanged_1(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtLoc3_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtLoc3_TextChangedTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtLoc3_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtLoc2_TextChanged_2
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtLoc2_TextChanged_2Test()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtLoc2_TextChanged_2(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtLoc2_TextChanged_1
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtLoc2_TextChanged_1Test()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtLoc2_TextChanged_1(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtLoc2_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtLoc2_TextChangedTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtLoc2_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtLoc1_TextChanged_2
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtLoc1_TextChanged_2Test()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtLoc1_TextChanged_2(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtLoc1_TextChanged_1
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtLoc1_TextChanged_1Test()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtLoc1_TextChanged_1(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtLoc1_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtLoc1_TextChangedTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtLoc1_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtKM2_TextChanged_2
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtKM2_TextChanged_2Test()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtKM2_TextChanged_2(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtKM2_TextChanged_1
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtKM2_TextChanged_1Test()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtKM2_TextChanged_1(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtKm_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtKm_TextChangedTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtKm_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtDiv_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtDiv_TextChangedTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtDiv_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txt_KeyPress
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txt_KeyPressTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As KeyPressEventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txt_KeyPress(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SortList1
    '''</summary>
    <TestMethod()> _
    Public Sub SortList1Test()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim cmbsets As ComboBox = Nothing ' TODO: Initialize to an appropriate value
        Dim asc As Boolean = False ' TODO: Initialize to an appropriate value
        target.SortList1(cmbsets, asc)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for ShowControls
    '''</summary>
    <TestMethod()> _
    Public Sub ShowControlsTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim v As Boolean = False ' TODO: Initialize to an appropriate value
        target.ShowControls(v)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SetTextBox
    '''</summary>
    <TestMethod()> _
    Public Sub SetTextBoxTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        target.SetTextBox()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for setProbes
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub setProbesTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        target.setProbes()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SetParams
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub SetParamsTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim m1 As Single = 0.0! ' TODO: Initialize to an appropriate value
        Dim m2 As Single = 0.0! ' TODO: Initialize to an appropriate value
        Dim setrange As Boolean = False ' TODO: Initialize to an appropriate value
        target.SetParams(m1, m2, setrange)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for ScaleRange
    '''</summary>
    <TestMethod()> _
    Public Sub ScaleRangeTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim m1 As Single = 0.0! ' TODO: Initialize to an appropriate value
        Dim m2 As Single = 0.0! ' TODO: Initialize to an appropriate value
        target.ScaleRange(m1, m2)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SaveInfo1
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub SaveInfo1Test()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        target.SaveInfo1()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SaveInfo
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub SaveInfoTest1()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        target.SaveInfo()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SaveInfo
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub SaveInfoTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim objBW As BinaryWriter = Nothing ' TODO: Initialize to an appropriate value
        target.SaveInfo(objBW)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SaveData2
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub SaveData2Test()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        target.SaveData2()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SaveData
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub SaveDataTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        target.SaveData()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for RunZoom
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub RunZoomTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim isFrz As Boolean = False ' TODO: Initialize to an appropriate value
        target.RunZoom(isFrz)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for RunSelfTest
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub RunSelfTestTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        target.RunSelfTest()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for RunFreeze
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub RunFreezeTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        target.RunFreeze()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for ReadOrgPRS
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub ReadOrgPRSTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = target.ReadOrgPRS
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for ReadInfo
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub ReadInfoTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        target.ReadInfo()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for ReadConfigFile
    '''</summary>
    <TestMethod()> _
    Public Sub ReadConfigFileTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        target.ReadConfigFile()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for prv_jpg
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub prv_jpgTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        target.prv_jpg()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for InitializeComponent
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        target.InitializeComponent()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for GetDateString
    '''</summary>
    <TestMethod()> _
    Public Sub GetDateStringTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = target.GetDateString
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for frmTest_UpdateEnd
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmTest_UpdateEndTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        target.frmTest_UpdateEnd()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmTest_MouseMove
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmTest_MouseMoveTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As MouseEventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmTest_MouseMove(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmTest_Load
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmTest_LoadTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmTest_Load(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmTest_KeyUp
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmTest_KeyUpTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As KeyEventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmTest_KeyUp(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmTest_KeyPress
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmTest_KeyPressTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As KeyPressEventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmTest_KeyPress(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmTest_KeyDown
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmTest_KeyDownTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As KeyEventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmTest_KeyDown(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmTest_Activated
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmTest_ActivatedTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmTest_Activated(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for DivisionParameter
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub DivisionParameterTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        target.DivisionParameter()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Dispose
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub DisposeTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim disposing As Boolean = False ' TODO: Initialize to an appropriate value
        target.Dispose(disposing)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Description
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub DescriptionTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim cod As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = target.Description(cod)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for DelOrgPRS
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub DelOrgPRSTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        target.DelOrgPRS()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Defaultvalues
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub DefaultvaluesTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        target.Defaultvalues()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for current_kmupdate
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub current_kmupdateTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        target.current_kmupdate()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for CreateRunFolder
    '''</summary>
    <TestMethod()> _
    Public Sub CreateRunFolderTest()
        Dim target As frmTest = New frmTest ' TODO: Initialize to an appropriate value
        target.CreateRunFolder()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for cmbRail_SelectedIndexChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub cmbRail_SelectedIndexChangedTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.cmbRail_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for cmbCode_SelectedIndexChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub cmbCode_SelectedIndexChangedTest()
        Dim target As frmTest_Accessor = New frmTest_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.cmbCode_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmTest Constructor
    '''</summary>
    <TestMethod()> _
    Public Sub frmTestConstructorTest()
        Dim target As frmTest = New frmTest
        Assert.Inconclusive("TODO: Implement code to verify target")
    End Sub
End Class
