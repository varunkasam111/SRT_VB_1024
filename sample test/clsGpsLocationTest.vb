Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ParasSRT



'''<summary>
'''This is a test class for clsGpsLocationTest and is intended
'''to contain all clsGpsLocationTest Unit Tests
'''</summary>
<TestClass()> _
Public Class clsGpsLocationTest


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
    '''A test for ToDMS
    '''</summary>
    <TestMethod()> _
    Public Sub ToDMSTest()
        Dim target As clsGpsLocation = New clsGpsLocation ' TODO: Initialize to an appropriate value
        Dim aDecimal As [Decimal] = New [Decimal] ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = target.ToDMS(aDecimal)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for toDecimal
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub toDecimalTest()
        Dim target As clsGpsLocation_Accessor = New clsGpsLocation_Accessor ' TODO: Initialize to an appropriate value
        Dim Pos As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim actual As Double
        actual = target.toDecimal(Pos)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for OpenGpsPort
    '''</summary>
    <TestMethod()> _
    Public Sub OpenGpsPortTest()
        Dim target As clsGpsLocation = New clsGpsLocation ' TODO: Initialize to an appropriate value
        Dim expected As Boolean = False ' TODO: Initialize to an appropriate value
        Dim actual As Boolean
        actual = target.OpenGpsPort
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for IsOpen
    '''</summary>
    <TestMethod()> _
    Public Sub IsOpenTest()
        Dim target As clsGpsLocation = New clsGpsLocation ' TODO: Initialize to an appropriate value
        Dim expected As Boolean = False ' TODO: Initialize to an appropriate value
        Dim actual As Boolean
        actual = target.IsOpen
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for GetPos
    '''</summary>
    <TestMethod()> _
    Public Sub GetPosTest()
        Dim target As clsGpsLocation = New clsGpsLocation ' TODO: Initialize to an appropriate value
        Dim lat As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim latExpected As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim lon As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim lonExpected As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim lat_dir As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim lat_dirExpected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim lon_dir As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim lon_dirExpected As String = String.Empty ' TODO: Initialize to an appropriate value
        target.GetPos(lat, lon, lat_dir, lon_dir)
        Assert.AreEqual(latExpected, lat)
        Assert.AreEqual(lonExpected, lon)
        Assert.AreEqual(lat_dirExpected, lat_dir)
        Assert.AreEqual(lon_dirExpected, lon_dir)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for GetMsg
    '''</summary>
    <TestMethod(), _
     DeploymentItem("ParasSRT.exe")> _
    Public Sub GetMsgTest()
        Dim target As clsGpsLocation_Accessor = New clsGpsLocation_Accessor ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = target.GetMsg
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for FindComPort
    '''</summary>
    <TestMethod()> _
    Public Sub FindComPortTest()
        Dim target As clsGpsLocation = New clsGpsLocation ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = target.FindComPort
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for clsGpsLocation Constructor
    '''</summary>
    <TestMethod()> _
    Public Sub clsGpsLocationConstructorTest1()
        Dim target As clsGpsLocation = New clsGpsLocation
        Assert.Inconclusive("TODO: Implement code to verify target")
    End Sub

    '''<summary>
    '''A test for clsGpsLocation Constructor
    '''</summary>
    <TestMethod()> _
    Public Sub clsGpsLocationConstructorTest()
        Dim port As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim target As clsGpsLocation = New clsGpsLocation(port)
        Assert.Inconclusive("TODO: Implement code to verify target")
    End Sub
End Class
