Imports System.IO.Ports
'Public SUBs and FUNCTIONS
'Sub New()
'Sub New(port$) 'if port is known
'Function FindComPort() As String 'returns for example 'COM4' if COM4 read out returns GPS-Messages
'Public Function OpenGpsPort() As Boolean 'returns TRUE if _SerPort is open or could be opened
'Public Sub GetPos(ByRef lat As Double, ByRef lon As Double) 'returns latitude / longitude in case of success. 0, 0 if not

Public Class clsGpsLocation
    Dim _SerPort As New SerialPort()
    Public _Port$
    Public _SatellitesInView&

    Dim GpsLogFile = "Gps.Log"

    Sub New()
    End Sub

    Sub New(ByVal port$)
        _Port$ = port$
    End Sub

    Public Function FindComPort() As String
        FindComPort = ""

        For i As Integer = 1 To 9
            Try
                _SerPort.Close()
            Catch ex As Exception
            End Try

            _SerPort.PortName = "COM" & i
            Try
                _SerPort.Open()
            Catch ex As Exception
            End Try

            If _SerPort.IsOpen Then
                '5 Sekunden einlesen
                Dim tmStart As Date = Now
                While tmStart.AddSeconds(5) > Now
                    Application.DoEvents()
                    Dim msg$ = _SerPort.ReadExisting

                    If InStr(msg, "$GPRMC") Then
                        'Gefunden
                        _Port = _SerPort.PortName
                        FindComPort = _SerPort.PortName
                        Exit Function
                    End If
                    Application.DoEvents()
                End While
            End If
        Next

        Try
            _SerPort.Close()
        Catch ex As Exception
        End Try

    End Function

    Public Function OpenGpsPort() As Boolean
        'Offen: OK
        If _SerPort.IsOpen Then Return True

        'Port bereits ermittelt?
        If _Port <> "" Then
            _SerPort.PortName = _Port
            Try
                _SerPort.Open()
            Catch ex As Exception
            End Try

            If _SerPort.IsOpen Then Return True
        End If

        'Port ermitteln
        _Port = FindComPort()
        Return _SerPort.IsOpen

    End Function

    Public Function IsOpen() As Boolean
        Return _SerPort.IsOpen
    End Function

    Private Function GetMsg() As String
        If Not OpenGpsPort() Then
            Return ""
        End If

        '5 Sekunden einlesen
        Dim tmStart As Date = Now
        While tmStart.AddSeconds(5) > Now
            Application.DoEvents()
            Dim msg$ = _SerPort.ReadExisting
            If InStr(msg, "$GPRMC") Then
                'Gelesen
                Return msg
            End If
            Application.DoEvents()
        End While

        'Nix
        Return ""
    End Function

    Private Function toDecimal(ByVal Pos As String) As Double
        'Pos="5601.0318"
        'Degrees: 56, Minutes: 010318
        'Berechnung: Decimal Degrees = Degrees + Minutes/60

        'PosDb: 56.010318
        Dim PosDb As Double = CType(Replace(Pos, ".", ","), Double) 'Replace . with , (Used in german doubles)
        'Deg: 56
        Dim Deg As Double = Math.Floor(PosDb / 100)

        Dim DecPos As Double = Math.Round(Deg + ((PosDb - (Deg * 100)) / 60), 5)
        Return DecPos '=56.0172

    End Function

    '12.1.2019 lat and long conversion
    Public Function ToDMS(ByVal aDecimal As Decimal) As String

        'degree
        Dim returnString As String
        returnString = Format(Int(aDecimal / 100), "00")

        'minute
        Dim minutes As Decimal
        minutes = Format(Int(aDecimal Mod 100), "00")

        'Seconds
        Dim seconds As Decimal
        seconds = Convert.ToDecimal((aDecimal - ((returnString * 100) + minutes)) * 60)
        seconds = Format(Math.Round(seconds, 2), "00.00")

        ' Format 
        returnString &= "° " & minutes.ToString & "' " & seconds.ToString & "''"


        Return returnString
    End Function

    Public Sub GetPos(ByRef lat As Double, ByRef lon As Double, ByRef lat_dir As String, ByRef lon_dir As String)
        lat = 0
        lon = 0

        If Not OpenGpsPort() Then
            Exit Sub
        End If

        Dim msg$
        Dim sentence$
        Dim LogSentence$

        While True
            msg$ = GetMsg()

            Dim Sentences() As String = Split(msg$, "$")
            Dim bPosRead As Boolean = False

            For i As Integer = 0 To Sentences.Length - 2 'Den letzten Satz nicht verarbeiten da der meistens verstümmelt ist. Es wird immer nur der Buffer gefüllt auch wenn der letzte Satz nicht mehr komplett passt.
                sentence = Sentences(i)
                Dim words() As String = Split(sentence, ",")
                Select Case words(0)
                    Case "GPGGA"

                        If ((words(2).Length) = 0) Then
                            lat = 0
                        Else
                            lat = Convert.ToDecimal(words(2))
                        End If

                        lat_dir = words(3)
                        lon_dir = words(5)

                        If ((words(4).Length) = 0) Then
                            lon = 0
                        Else
                            lon = Convert.ToDecimal(words(4))
                        End If

                        _SatellitesInView& = CLng(words(7))
                        LogSentence$ = Now & ":" & sentence
                        bPosRead = True



                        'Case "GPRMC"
                        '    lat = toDecimal(words(3))
                        '    lon = toDecimal(words(5))
                        '    LogSentence$ = Now & ":" & sentence
                        '    bPosRead = True

                        'Case "GPGLL"
                        '    lat = toDecimal(words(1))
                        '    lon = toDecimal(words(3))
                        '    LogSentence$ = Now & ":" & sentence
                        '    bPosRead = True

                        'Case "GPRMA"
                        '    lat = toDecimal(words(2))
                        '    lon = toDecimal(words(4))
                        '    LogSentence$ = Now & ":" & sentence
                        '    bPosRead = True

                End Select
                Application.DoEvents()
            Next
            If bPosRead = True Then Exit While
            Application.DoEvents()
        End While
        _SerPort.Close()

        'GpsLogFile 
        'call some function that writes LogSentence$ into GpsLogFile

    End Sub


End Class
