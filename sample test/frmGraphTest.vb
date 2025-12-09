Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ParasSRT



'''<summary>
'''This is a test class for frmGraphTest and is intended
'''to contain all frmGraphTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmGraphTest


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
    '''A test for ToraGetData
    '''</summary>
    <TestMethod()> _
    Public Sub ToraGetDataTest()
        Dim target As frmGraph = New frmGraph ' TODO: Initialize to an appropriate value
        target.ToraGetData()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SetPlots
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub SetPlotsTest()
        Dim target As frmGraph_Accessor = New frmGraph_Accessor ' TODO: Initialize to an appropriate value
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
        Dim target As frmGraph_Accessor = New frmGraph_Accessor ' TODO: Initialize to an appropriate value
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
    '''A test for InitializeComponent
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As frmGraph_Accessor = New frmGraph_Accessor ' TODO: Initialize to an appropriate value
        target.InitializeComponent()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmGraph_Load
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmGraph_LoadTest()
        Dim target As frmGraph_Accessor = New frmGraph_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmGraph_Load(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmGraph_Closed
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub frmGraph_ClosedTest()
        Dim target As frmGraph_Accessor = New frmGraph_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        target.frmGraph_Closed(sender, e)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Finalize
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub FinalizeTest()
        Dim target As frmGraph_Accessor = New frmGraph_Accessor ' TODO: Initialize to an appropriate value
        target.Finalize()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Dispose
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub DisposeTest()
        Dim target As frmGraph_Accessor = New frmGraph_Accessor ' TODO: Initialize to an appropriate value
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
        Dim target As frmGraph_Accessor = New frmGraph_Accessor ' TODO: Initialize to an appropriate value
        Dim chnl As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim eras As Boolean = False ' TODO: Initialize to an appropriate value
        target.AcquireDPAll(chnl, eras)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for frmGraph Constructor
    '''</summary>
    <TestMethod()> _
    Public Sub frmGraphConstructorTest()
        Dim target As frmGraph = New frmGraph
        Assert.Inconclusive("TODO: Implement code to verify target")
    End Sub
End Class
