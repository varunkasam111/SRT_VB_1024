Imports System.Runtime.InteropServices

Public Class GPIO

    Public Const DIR_IN = 0
    Public Const DIR_OUT = 1
    Public Const EDGE_RISING = 1
    Public Const EDGE_FALLING = 2
    Public Const EDGE_BOTH = 3
    Public Const TYPE_PXA270 = 17
    Public Const TYPE_PXA320 = 2
    Public Const TYPE_PXA300 = 8
    <DllImport("testdll.dll")> Public Shared Function read_dpram_value(ByVal pa As Integer) As Short
    End Function

    <DllImport("GPIOLib.dll")> Public Shared Sub InitGPIOLib()
    End Sub

    <DllImport("GPIOLib.dll")> Public Shared Sub DeInitGPIOLib()
    End Sub

    <DllImport("GPIOLib.dll")> Public Shared Function GetProzessorID() As Integer
    End Function

    <DllImport("GPIOLib.dll")> Public Shared Function GetGPIODir(ByVal gpioNum As Integer) As Integer
    End Function
    <DllImport("GPIOLib.dll")> Public Shared Function GetPinDir(ByVal pinNum As Integer) As Integer
    End Function
    <DllImport("GPIOLib.dll")> Public Shared Sub SetGPIODir(ByVal gpioNum As Integer, ByVal dirOut As Boolean)
    End Sub
    <DllImport("GPIOLib.dll")> Public Shared Sub SetPinDir(ByVal pinNum As Integer, ByVal dirOut As Boolean)
    End Sub

    <DllImport("GPIOLib.dll")> Public Shared Function GetGPIOAltFn(ByVal gpioNum As Integer) As Integer
    End Function
    <DllImport("GPIOLib.dll")> Public Shared Function GetPinAltFn(ByVal pinNum As Integer) As Integer
    End Function
    <DllImport("GPIOLib.dll")> Public Shared Sub SetGPIOAltFn(ByVal gpioNum As Integer, ByVal altFn As Integer, ByVal dirOut As Boolean)
    End Sub
    <DllImport("GPIOLib.dll")> Public Shared Sub SetPinAltFn(ByVal pinNum As Integer, ByVal altFn As Integer, ByVal dirOut As Boolean)
    End Sub

    <DllImport("GPIOLib.dll")> Public Shared Function GetGPIOLevel(ByVal gpioNum As Integer) As Boolean
    End Function
    <DllImport("GPIOLib.dll")> Public Shared Function GetPinLevel(ByVal pinNum As Integer) As Boolean
    End Function
    <DllImport("GPIOLib.dll")> Public Shared Sub SetGPIOLevel(ByVal gpioNum As Integer, ByVal val As Integer)
    End Sub
    <DllImport("GPIOLib.dll")> Public Shared Sub SetPinLevel(ByVal pinNum As Integer, ByVal val As Integer)
    End Sub

    <DllImport("GPIOLib.dll")> Public Shared Function GetGPIOEdgeDetect(ByVal gpioNum As Integer) As Integer
    End Function
    <DllImport("GPIOLib.dll")> Public Shared Sub SetGPIOEdgeDetect(ByVal gpioNum As Integer, ByVal edge As Integer)
    End Sub

    <DllImport("GPIOLib.dll")> Public Shared Function GetGPIOEdgeStatus(ByVal gpioNum As Integer) As Integer
    End Function
    <DllImport("GPIOLib.dll")> Public Shared Sub ClearGPIOEdgeStatus(ByVal gpioNum As Integer)
    End Sub
End Class
