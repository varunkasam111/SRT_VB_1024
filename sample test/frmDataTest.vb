Imports System.Windows.Forms

Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ParasSRT



'''<summary>
'''This is a test class for frmDataTest and is intended
'''to contain all frmDataTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmDataTest


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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtTP = expected
        actual = target.txtTP
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtTime
    '''</summary>
    <TestMethod()> _
    Public Sub txtTimeTest()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtSta1 = expected
        actual = target.txtSta1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtSets
    '''</summary>
    <TestMethod()> _
    Public Sub txtSetsTest()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtSets = expected
        actual = target.txtSets
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtSec
    '''</summary>
    <TestMethod()> _
    Public Sub txtSecTest()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtSec = expected
        actual = target.txtSec
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtRoad
    '''</summary>
    <TestMethod()> _
    Public Sub txtRoadTest()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtRoad = expected
        actual = target.txtRoad
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtRem
    '''</summary>
    <TestMethod()> _
    Public Sub txtRemTest()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtRem = expected
        actual = target.txtRem
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtrailtype
    '''</summary>
    <TestMethod()> _
    Public Sub txtrailtypeTest()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtrailtype = expected
        actual = target.txtrailtype
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtRail
    '''</summary>
    <TestMethod()> _
    Public Sub txtRailTest()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtRail = expected
        actual = target.txtRail
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtPH2
    '''</summary>
    <TestMethod()> _
    Public Sub txtPH2Test()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtM = expected
        actual = target.txtM
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtlongtitude
    '''</summary>
    <TestMethod()> _
    Public Sub txtlongtitudeTest()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtlongtitude = expected
        actual = target.txtlongtitude
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtLoc3
    '''</summary>
    <TestMethod()> _
    Public Sub txtLoc3Test()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtlen = expected
        actual = target.txtlen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtlatitude
    '''</summary>
    <TestMethod()> _
    Public Sub txtlatitudeTest()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtlatitude = expected
        actual = target.txtlatitude
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtKmt
    '''</summary>
    <TestMethod()> _
    Public Sub txtKmtTest()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtKmt = expected
        actual = target.txtKmt
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtKM2
    '''</summary>
    <TestMethod()> _
    Public Sub txtKM2Test()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtheight = expected
        actual = target.txtheight
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtDiv
    '''</summary>
    <TestMethod()> _
    Public Sub txtDivTest()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtDate = expected
        actual = target.txtDate
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for txtCh
    '''</summary>
    <TestMethod()> _
    Public Sub txtChTest()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As TextBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As TextBox
        target.txtbp = expected
        actual = target.txtbp
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for pnlOpts
    '''</summary>
    <TestMethod()> _
    Public Sub pnlOptsTest()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As Panel = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Panel
        target.pnlOpts = expected
        actual = target.pnlOpts
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for PictureBox1
    '''</summary>
    <TestMethod()> _
    Public Sub PictureBox1Test()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As PictureBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As PictureBox
        target.PictureBox1 = expected
        actual = target.PictureBox1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Panel4
    '''</summary>
    <TestMethod()> _
    Public Sub Panel4Test()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As Panel = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Panel
        target.Panel4 = expected
        actual = target.Panel4
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Panel3
    '''</summary>
    <TestMethod()> _
    Public Sub Panel3Test()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As Panel = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Panel
        target.Panel3 = expected
        actual = target.Panel3
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Panel2
    '''</summary>
    <TestMethod()> _
    Public Sub Panel2Test()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As ListBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ListBox
        target.ListBox1 = expected
        actual = target.ListBox1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblTyp2
    '''</summary>
    <TestMethod()> _
    Public Sub lblTyp2Test()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblTP2 = expected
        actual = target.lblTP2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblStation
    '''</summary>
    <TestMethod()> _
    Public Sub lblStationTest()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblStation = expected
        actual = target.lblStation
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblProbe
    '''</summary>
    <TestMethod()> _
    Public Sub lblProbeTest()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblPH = expected
        actual = target.lblPH
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblOpts3
    '''</summary>
    <TestMethod()> _
    Public Sub lblOpts3Test()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblOpts2 = expected
        actual = target.lblOpts2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblOpts1
    '''</summary>
    <TestMethod()> _
    Public Sub lblOpts1Test()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblOpts1 = expected
        actual = target.lblOpts1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblOpts0
    '''</summary>
    <TestMethod()> _
    Public Sub lblOpts0Test()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblOpts0 = expected
        actual = target.lblOpts0
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblMeter2
    '''</summary>
    <TestMethod()> _
    Public Sub lblMeter2Test()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblMeter2 = expected
        actual = target.lblMeter2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblMenu7
    '''</summary>
    <TestMethod()> _
    Public Sub lblMenu7Test()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblMenu1 = expected
        actual = target.lblMenu1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblLoc2
    '''</summary>
    <TestMethod()> _
    Public Sub lblLoc2Test()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lbllen = expected
        actual = target.lbllen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblKM2
    '''</summary>
    <TestMethod()> _
    Public Sub lblKM2Test()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblKM2 = expected
        actual = target.lblKM2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblHM2
    '''</summary>
    <TestMethod()> _
    Public Sub lblHM2Test()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblFlaw = expected
        actual = target.lblFlaw
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblFile
    '''</summary>
    <TestMethod()> _
    Public Sub lblFileTest()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblFile = expected
        actual = target.lblFile
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblDesc2
    '''</summary>
    <TestMethod()> _
    Public Sub lblDesc2Test()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblDesc2 = expected
        actual = target.lblDesc2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblDesc
    '''</summary>
    <TestMethod()> _
    Public Sub lblDescTest()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblDesc = expected
        actual = target.lblDesc
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblCode2
    '''</summary>
    <TestMethod()> _
    Public Sub lblCode2Test()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As ComboBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ComboBox
        target.cmbTyp = expected
        actual = target.cmbTyp
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for cmbProbe
    '''</summary>
    <TestMethod()> _
    Public Sub cmbProbeTest()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As ComboBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ComboBox
        target.cmbLR = expected
        actual = target.cmbLR
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Cmblistfiles
    '''</summary>
    <TestMethod()> _
    Public Sub CmblistfilesTest()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As ComboBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ComboBox
        target.Cmblistfiles = expected
        actual = target.Cmblistfiles
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for cmbFLoc2
    '''</summary>
    <TestMethod()> _
    Public Sub cmbFLoc2Test()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As ComboBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ComboBox
        target.cmbClass = expected
        actual = target.cmbClass
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for chkCRIS
    '''</summary>
    <TestMethod()> _
    Public Sub chkCRISTest()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim expected As CheckBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As CheckBox
        target.chkCRIS = expected
        actual = target.chkCRIS
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for WriteFreezeData2
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub WriteFreezeData2Test()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim strt As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim nd As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim tot As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim sp As String = String.Empty ' TODO: Initialize to an appropriate value
        target.WriteFreezeData2(strt, nd, tot, sp)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtTP2_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtTP2_TextChangedTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtTP2_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtTP_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtTP_TextChangedTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtTP_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtSta2_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtSta2_TextChangedTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtSta2_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtSta1_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtSta1_TextChangedTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
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
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtSec_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtrailtype_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtrailtype_TextChangedTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtrailtype_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtPH2_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtPH2_TextChangedTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
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
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtName_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtmeter_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtmeter_TextChangedTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtmeter_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtMask4_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtMask4_TextChangedTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtMask4_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtMask3_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtMask3_TextChangedTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtMask3_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtLoc3_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtLoc3_TextChangedTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtLoc3_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtLoc2_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtLoc2_TextChangedTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtLoc2_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtLoc1_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtLoc1_TextChangedTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtLoc1_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtKM2_TextChanged_1
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtKM2_TextChanged_1Test()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtKM2_TextChanged_1(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtKM2_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtKM2_TextChangedTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtKM2_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtKm_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub txtKm_TextChangedTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
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
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.txtDiv_TextChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for ShowMenu
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub ShowMenuTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim ShoworHide As Boolean = False ' TODO: Initialize to an appropriate value
        target.ShowMenu(ShoworHide)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SetTextBox
    '''</summary>
    <TestMethod()> _
    Public Sub SetTextBoxTest()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        target.SetTextBox()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SaveInfo
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub SaveInfoTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim filename As String = String.Empty ' TODO: Initialize to an appropriate value
        target.SaveInfo(filename)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for RemoveGT127
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub RemoveGT127Test()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim st As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Object
        actual = target.RemoveGT127(st)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for ReadInfo
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub ReadInfoTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim filename As String = String.Empty ' TODO: Initialize to an appropriate value
        target.ReadInfo(filename)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for ReadFreezeData
    '''</summary>
    <TestMethod()> _
    Public Sub ReadFreezeDataTest()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        target.ReadFreezeData()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Panel2_GotFocus
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub Panel2_GotFocusTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.Panel2_GotFocus(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for ListBox2_SelectedIndexChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub ListBox2_SelectedIndexChangedTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
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
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
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
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
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
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
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
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
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
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.ListBox1_GotFocus(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for lblPrev_ParentChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub lblPrev_ParentChangedTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.lblPrev_ParentChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for lblMenu1_ParentChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub lblMenu1_ParentChangedTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.lblMenu1_ParentChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Label4_ParentChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub Label4_ParentChangedTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.Label4_ParentChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for InitializeComponent
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        target.InitializeComponent()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmData_Load
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmData_LoadTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmData_Load(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmData_KeyUp
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmData_KeyUpTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As KeyEventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmData_KeyUp(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmData_KeyPress
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmData_KeyPressTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As KeyPressEventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmData_KeyPress(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmData_KeyDown
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmData_KeyDownTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As KeyEventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmData_KeyDown(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for FileTransfer
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub FileTransferTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
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
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        target.FileList()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for FileDelete
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub FileDeleteTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        target.FileDelete()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Dispose
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub DisposeTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
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
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        target.DirList()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for DelDirectory
    '''</summary>
    <TestMethod()> _
    Public Sub DelDirectoryTest()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim SourceDirectory As String = String.Empty ' TODO: Initialize to an appropriate value
        target.DelDirectory(SourceDirectory)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for CopyFile
    '''</summary>
    <TestMethod()> _
    Public Sub CopyFileTest()
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
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
        Dim target As frmData = New frmData ' TODO: Initialize to an appropriate value
        Dim SourceDirectory As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim TargetDirectory As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim isdel As Boolean = False ' TODO: Initialize to an appropriate value
        target.CopyDirectory(SourceDirectory, TargetDirectory, isdel)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Cmblistfiles_SelectedIndexChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub Cmblistfiles_SelectedIndexChangedTest()
        Dim target As frmData_Accessor = New frmData_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.Cmblistfiles_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmData Constructor
    '''</summary>
    <TestMethod()> _
    Public Sub frmDataConstructorTest()
        Dim target As frmData = New frmData
        Assert.Inconclusive("TODO: Implement code to verify target")
    End Sub
End Class
