Imports System

Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ParasSRT



'''<summary>
'''This is a test class for frmColorsTest and is intended
'''to contain all frmColorsTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmColorsTest


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
    '''A test for lstColor9
    '''</summary>
    <TestMethod()> _
    Public Sub lstColor9Test()
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
        Dim expected As ListBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ListBox
        target.lstColor9 = expected
        actual = target.lstColor9
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lstColor8
    '''</summary>
    <TestMethod()> _
    Public Sub lstColor8Test()
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
        Dim expected As ListBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ListBox
        target.lstColor8 = expected
        actual = target.lstColor8
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lstColor7
    '''</summary>
    <TestMethod()> _
    Public Sub lstColor7Test()
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
        Dim expected As ListBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ListBox
        target.lstColor7 = expected
        actual = target.lstColor7
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lstColor6
    '''</summary>
    <TestMethod()> _
    Public Sub lstColor6Test()
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
        Dim expected As ListBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ListBox
        target.lstColor6 = expected
        actual = target.lstColor6
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lstColor5
    '''</summary>
    <TestMethod()> _
    Public Sub lstColor5Test()
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
        Dim expected As ListBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ListBox
        target.lstColor5 = expected
        actual = target.lstColor5
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lstColor4
    '''</summary>
    <TestMethod()> _
    Public Sub lstColor4Test()
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
        Dim expected As ListBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ListBox
        target.lstColor4 = expected
        actual = target.lstColor4
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lstColor3
    '''</summary>
    <TestMethod()> _
    Public Sub lstColor3Test()
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
        Dim expected As ListBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ListBox
        target.lstColor3 = expected
        actual = target.lstColor3
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lstColor2
    '''</summary>
    <TestMethod()> _
    Public Sub lstColor2Test()
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
        Dim expected As ListBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ListBox
        target.lstColor2 = expected
        actual = target.lstColor2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lstColor1
    '''</summary>
    <TestMethod()> _
    Public Sub lstColor1Test()
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
        Dim expected As ListBox = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As ListBox
        target.lstColor1 = expected
        actual = target.lstColor1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblTitle
    '''</summary>
    <TestMethod()> _
    Public Sub lblTitleTest()
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblTitle = expected
        actual = target.lblTitle
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblMenu9
    '''</summary>
    <TestMethod()> _
    Public Sub lblMenu9Test()
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblMenu9 = expected
        actual = target.lblMenu9
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblMenu8
    '''</summary>
    <TestMethod()> _
    Public Sub lblMenu8Test()
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
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
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
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
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
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
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
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
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
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
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
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
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
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
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblMenu1 = expected
        actual = target.lblMenu1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblC9
    '''</summary>
    <TestMethod()> _
    Public Sub lblC9Test()
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
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
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
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
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
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
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
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
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
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
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
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
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
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
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblC2 = expected
        actual = target.lblC2
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for lblC1
    '''</summary>
    <TestMethod()> _
    Public Sub lblC1Test()
        Dim target As frmColors = New frmColors ' TODO: Initialize to an appropriate value
        Dim expected As Label = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Label
        target.lblC1 = expected
        actual = target.lblC1
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Setlst
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub SetlstTest()
        Dim target As frmColors_Accessor = New frmColors_Accessor ' TODO: Initialize to an appropriate value
        target.Setlst()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SetDefault
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub SetDefaultTest()
        Dim target As frmColors_Accessor = New frmColors_Accessor ' TODO: Initialize to an appropriate value
        target.SetDefault()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SetControls
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub SetControlsTest()
        Dim target As frmColors_Accessor = New frmColors_Accessor ' TODO: Initialize to an appropriate value
        target.SetControls()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for lstColor_SelectedIndexChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub lstColor_SelectedIndexChangedTest()
        Dim target As frmColors_Accessor = New frmColors_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.lstColor_SelectedIndexChanged(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for lstColor_LostFocus
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub lstColor_LostFocusTest()
        Dim target As frmColors_Accessor = New frmColors_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.lstColor_LostFocus(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for lstColor_GotFocus
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub lstColor_GotFocusTest()
        Dim target As frmColors_Accessor = New frmColors_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.lstColor_GotFocus(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for InitializeComponent
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As frmColors_Accessor = New frmColors_Accessor ' TODO: Initialize to an appropriate value
        target.InitializeComponent()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmColors_Paint
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmColors_PaintTest()
        Dim target As frmColors_Accessor = New frmColors_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As PaintEventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmColors_Paint(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmColors_Load
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmColors_LoadTest()
        Dim target As frmColors_Accessor = New frmColors_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmColors_Load(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmColors_Activated
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmColors_ActivatedTest()
        Dim target As frmColors_Accessor = New frmColors_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmColors_Activated(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Form5_KeyDown
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub Form5_KeyDownTest()
        Dim target As frmColors_Accessor = New frmColors_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As KeyEventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.Form5_KeyDown(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Dispose
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub DisposeTest()
        Dim target As frmColors_Accessor = New frmColors_Accessor ' TODO: Initialize to an appropriate value
        Dim disposing As Boolean = False ' TODO: Initialize to an appropriate value
        target.Dispose(disposing)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmColors Constructor
    '''</summary>
    <TestMethod()> _
    Public Sub frmColorsConstructorTest()
        Dim target As frmColors = New frmColors
        Assert.Inconclusive("TODO: Implement code to verify target")
    End Sub
End Class
