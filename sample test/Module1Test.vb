Imports System.Windows.Forms

Imports System.Drawing

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ParasSRT



'''<summary>
'''This is a test class for Module1Test and is intended
'''to contain all Module1Test Unit Tests
'''</summary>
<TestClass()> _
Public Class Module1Test


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
    '''A test for WriteiWConfig
    '''</summary>
    <TestMethod()> _
    Public Sub WriteiWConfigTest()
        Module1.WriteiWConfig()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for StripDotDash2Dash
    '''</summary>
    <TestMethod()> _
    Public Sub StripDotDash2DashTest()
        Dim st As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim stExpected As String = String.Empty ' TODO: Initialize to an appropriate value
        Module1.StripDotDash2Dash(st)
        Assert.AreEqual(stExpected, st)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SortListname
    '''</summary>
    <TestMethod()> _
    Public Sub SortListnameTest()
        Dim lst As ListBox = Nothing ' TODO: Initialize to an appropriate value
        Dim asc As Boolean = False ' TODO: Initialize to an appropriate value
        Module1.SortListname(lst, asc)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SortList
    '''</summary>
    <TestMethod()> _
    Public Sub SortListTest()
        Dim lst As ListBox = Nothing ' TODO: Initialize to an appropriate value
        Dim asc As Boolean = False ' TODO: Initialize to an appropriate value
        Module1.SortList(lst, asc)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SetWaveAng
    '''</summary>
    <TestMethod()> _
    Public Sub SetWaveAngTest()
        Dim j As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim ang As Single = 0.0! ' TODO: Initialize to an appropriate value
        Dim expected As Single = 0.0! ' TODO: Initialize to an appropriate value
        Dim actual As Single
        actual = Module1.SetWaveAng(j, ang)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for SetVars2
    '''</summary>
    <TestMethod()> _
    Public Sub SetVars2Test()
        Module1.SetVars2()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SetVars
    '''</summary>
    <TestMethod()> _
    Public Sub SetVarsTest()
        Module1.SetVars()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SetPens
    '''</summary>
    <TestMethod()> _
    Public Sub SetPensTest()
        Module1.SetPens()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SetCursorPos
    '''</summary>
    <TestMethod()> _
    Public Sub SetCursorPosTest()
        Dim X As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Y As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = Module1.SetCursorPos(X, Y)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for setConfig
    '''</summary>
    <TestMethod()> _
    Public Sub setConfigTest()
        Module1.setConfig()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SendGainSet
    '''</summary>
    <TestMethod()> _
    Public Sub SendGainSetTest()
        Module1.SendGainSet()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SendGain
    '''</summary>
    <TestMethod()> _
    Public Sub SendGainTest()
        Dim i As Integer = 0 ' TODO: Initialize to an appropriate value
        Module1.SendGain(i)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SaveGain10CH
    '''</summary>
    <TestMethod()> _
    Public Sub SaveGain10CHTest()
        Module1.SaveGain10CH()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SaveGain
    '''</summary>
    <TestMethod()> _
    Public Sub SaveGainTest()
        Module1.SaveGain()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SaveConfig
    '''</summary>
    <TestMethod()> _
    Public Sub SaveConfigTest()
        Module1.SaveConfig()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SaveAng10CH
    '''</summary>
    <TestMethod()> _
    Public Sub SaveAng10CHTest()
        Module1.SaveAng10CH()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for SaveAng
    '''</summary>
    <TestMethod()> _
    Public Sub SaveAngTest()
        Module1.SaveAng()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for Rangemm
    '''</summary>
    <TestMethod()> _
    Public Sub RangemmTest()
        Dim memloc As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim j As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As Single = 0.0! ' TODO: Initialize to an appropriate value
        Dim actual As Single
        actual = Module1.Rangemm(memloc, j)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for Rangeml
    '''</summary>
    <TestMethod()> _
    Public Sub RangemlTest()
        Dim mm As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim j As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As Single = 0.0! ' TODO: Initialize to an appropriate value
        Dim actual As Single
        actual = Module1.Rangeml(mm, j)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for PauseIt
    '''</summary>
    <TestMethod()> _
    Public Sub PauseItTest()
        Dim dt As Double = 0.0! ' TODO: Initialize to an appropriate value
        Module1.PauseIt(dt)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for OpenConfig2
    '''</summary>
    <TestMethod()> _
    Public Sub OpenConfig2Test()
        Module1.OpenConfig2()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for OpenConfig
    '''</summary>
    <TestMethod()> _
    Public Sub OpenConfigTest()
        Module1.OpenConfig()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for LoadParams
    '''</summary>
    <TestMethod()> _
    Public Sub LoadParamsTest()
        Module1.LoadParams()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for IsUpDn
    '''</summary>
    <TestMethod()> _
    Public Sub IsUpDnTest()
        Dim k As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As Boolean = False ' TODO: Initialize to an appropriate value
        Dim actual As Boolean
        actual = Module1.IsUpDn(k)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for IsLfRt
    '''</summary>
    <TestMethod()> _
    Public Sub IsLfRtTest()
        Dim k As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As Boolean = False ' TODO: Initialize to an appropriate value
        Dim actual As Boolean
        actual = Module1.IsLfRt(k)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for IsFuncKey
    '''</summary>
    <TestMethod()> _
    Public Sub IsFuncKeyTest()
        Dim k As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As Boolean = False ' TODO: Initialize to an appropriate value
        Dim actual As Boolean
        actual = Module1.IsFuncKey(k)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for GetWaveAng
    '''</summary>
    <TestMethod()> _
    Public Sub GetWaveAngTest()
        Dim j As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim wav As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim wavExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim ang As Single = 0.0! ' TODO: Initialize to an appropriate value
        Dim angExpected As Single = 0.0! ' TODO: Initialize to an appropriate value
        Module1.GetWaveAng(j, wav, ang)
        Assert.AreEqual(wavExpected, wav)
        Assert.AreEqual(angExpected, ang)
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for GetCursorPos
    '''</summary>
    <TestMethod()> _
    Public Sub GetCursorPosTest()
        Dim pt As Point = New Point ' TODO: Initialize to an appropriate value
        Dim ptExpected As Point = New Point ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = Module1.GetCursorPos(pt)
        Assert.AreEqual(ptExpected, pt)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for GetAppPath
    '''</summary>
    <TestMethod()> _
    Public Sub GetAppPathTest()
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = Module1.GetAppPath
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for ExtractFilename
    '''</summary>
    <TestMethod()> _
    Public Sub ExtractFilenameTest()
        Dim filepath As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        actual = Module1.ExtractFilename(filepath)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for DeviceIoControl
    '''</summary>
    <TestMethod()> _
    Public Sub DeviceIoControlTest()
        Dim hDevice As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim dwIoControlCode As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim lpInBuffer() As Byte = Nothing ' TODO: Initialize to an appropriate value
        Dim nInBufferSize As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim lpOutBuffer() As Byte = Nothing ' TODO: Initialize to an appropriate value
        Dim nOutBufferSize As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim lpBytesReturned As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim lpBytesReturnedExpected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim lpOverlapped As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = Module1.DeviceIoControl(hDevice, dwIoControlCode, lpInBuffer, nInBufferSize, lpOutBuffer, nOutBufferSize, lpBytesReturned, lpOverlapped)
        Assert.AreEqual(lpBytesReturnedExpected, lpBytesReturned)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for CreateFile
    '''</summary>
    <TestMethod()> _
    Public Sub CreateFileTest()
        Dim lpFileName As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim lpFileNameExpected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim dwDesiredAccess As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim dwShareMode As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim lpSecurityAttributes As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim dwCreationDisposition As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim dwFLagsAndAttributes As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim hTemplateFile As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = Module1.CreateFile(lpFileName, dwDesiredAccess, dwShareMode, lpSecurityAttributes, dwCreationDisposition, dwFLagsAndAttributes, hTemplateFile)
        Assert.AreEqual(lpFileNameExpected, lpFileName)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for config10CH
    '''</summary>
    <TestMethod()> _
    Public Sub config10CHTest()
        Module1.config10CH()
        Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for CloseHandle
    '''</summary>
    <TestMethod()> _
    Public Sub CloseHandleTest()
        Dim hObject As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As Boolean = False ' TODO: Initialize to an appropriate value
        Dim actual As Boolean
        actual = Module1.CloseHandle(hObject)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub
End Class
