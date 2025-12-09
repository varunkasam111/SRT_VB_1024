Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ParasSRT



'''<summary>
'''This is a test class for GPIOTest and is intended
'''to contain all GPIOTest Unit Tests
'''</summary>
<TestClass()> _
Public Class GPIOTest


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
    '''A test for SetPinLevel
    '''</summary>
    <TestMethod()> _
    Public Sub SetPinLevelTest()
        Dim pinNum As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim val As Integer = 0 ' TODO: Initialize to an appropriate value
        GPIO.SetPinLevel(pinNum, val)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SetPinDir
    '''</summary>
    <TestMethod()> _
    Public Sub SetPinDirTest()
        Dim pinNum As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim dirOut As Boolean = False ' TODO: Initialize to an appropriate value
        GPIO.SetPinDir(pinNum, dirOut)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SetPinAltFn
    '''</summary>
    <TestMethod()> _
    Public Sub SetPinAltFnTest()
        Dim pinNum As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim altFn As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim dirOut As Boolean = False ' TODO: Initialize to an appropriate value
        GPIO.SetPinAltFn(pinNum, altFn, dirOut)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SetGPIOLevel
    '''</summary>
    <TestMethod()> _
    Public Sub SetGPIOLevelTest()
        Dim gpioNum As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim val As Integer = 0 ' TODO: Initialize to an appropriate value
        GPIO.SetGPIOLevel(gpioNum, val)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SetGPIOEdgeDetect
    '''</summary>
    <TestMethod()> _
    Public Sub SetGPIOEdgeDetectTest()
        Dim gpioNum As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim edge As Integer = 0 ' TODO: Initialize to an appropriate value
        GPIO.SetGPIOEdgeDetect(gpioNum, edge)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SetGPIODir
    '''</summary>
    <TestMethod()> _
    Public Sub SetGPIODirTest()
        Dim gpioNum As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim dirOut As Boolean = False ' TODO: Initialize to an appropriate value
        GPIO.SetGPIODir(gpioNum, dirOut)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SetGPIOAltFn
    '''</summary>
    <TestMethod()> _
    Public Sub SetGPIOAltFnTest()
        Dim gpioNum As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim altFn As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim dirOut As Boolean = False ' TODO: Initialize to an appropriate value
        GPIO.SetGPIOAltFn(gpioNum, altFn, dirOut)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for read_dpram_value
    '''</summary>
    <TestMethod()> _
    Public Sub read_dpram_valueTest()
        Dim pa As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As Short = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Short
        actual = GPIO.read_dpram_value(pa)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for InitGPIOLib
    '''</summary>
    <TestMethod()> _
    Public Sub InitGPIOLibTest()
        GPIO.InitGPIOLib()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for GetProzessorID
    '''</summary>
    <TestMethod()> _
    Public Sub GetProzessorIDTest()
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = GPIO.GetProzessorID
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for GetPinLevel
    '''</summary>
    <TestMethod()> _
    Public Sub GetPinLevelTest()
        Dim pinNum As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As Boolean = False ' TODO: Initialize to an appropriate value
        Dim actual As Boolean
        actual = GPIO.GetPinLevel(pinNum)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for GetPinDir
    '''</summary>
    <TestMethod()> _
    Public Sub GetPinDirTest()
        Dim pinNum As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = GPIO.GetPinDir(pinNum)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for GetPinAltFn
    '''</summary>
    <TestMethod()> _
    Public Sub GetPinAltFnTest()
        Dim pinNum As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = GPIO.GetPinAltFn(pinNum)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for GetGPIOLevel
    '''</summary>
    <TestMethod()> _
    Public Sub GetGPIOLevelTest()
        Dim gpioNum As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As Boolean = False ' TODO: Initialize to an appropriate value
        Dim actual As Boolean
        actual = GPIO.GetGPIOLevel(gpioNum)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for GetGPIOEdgeStatus
    '''</summary>
    <TestMethod()> _
    Public Sub GetGPIOEdgeStatusTest()
        Dim gpioNum As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = GPIO.GetGPIOEdgeStatus(gpioNum)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for GetGPIOEdgeDetect
    '''</summary>
    <TestMethod()> _
    Public Sub GetGPIOEdgeDetectTest()
        Dim gpioNum As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = GPIO.GetGPIOEdgeDetect(gpioNum)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for GetGPIODir
    '''</summary>
    <TestMethod()> _
    Public Sub GetGPIODirTest()
        Dim gpioNum As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = GPIO.GetGPIODir(gpioNum)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for GetGPIOAltFn
    '''</summary>
    <TestMethod()> _
    Public Sub GetGPIOAltFnTest()
        Dim gpioNum As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = GPIO.GetGPIOAltFn(gpioNum)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for DeInitGPIOLib
    '''</summary>
    <TestMethod()> _
    Public Sub DeInitGPIOLibTest()
        GPIO.DeInitGPIOLib()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for ClearGPIOEdgeStatus
    '''</summary>
    <TestMethod()> _
    Public Sub ClearGPIOEdgeStatusTest()
        Dim gpioNum As Integer = 0 ' TODO: Initialize to an appropriate value
        GPIO.ClearGPIOEdgeStatus(gpioNum)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for GPIO Constructor
    '''</summary>
    <TestMethod()> _
    Public Sub GPIOConstructorTest()
        Dim target As GPIO = New GPIO
        Assert.Inconclusive("TODO: Implement code to verify target")
    End Sub
End Class
