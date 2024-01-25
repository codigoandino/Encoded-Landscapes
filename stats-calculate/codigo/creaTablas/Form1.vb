Imports System.IO

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If carga_param_geom() = False Then Exit Sub
        If carga_param_rangos() = False Then Exit Sub

    End Sub

    Function carga_param_geom() As Boolean
        If IsNumeric(txtW.Text) = False Then
            MsgBox("Valores deben ser numéricos!", vbOK Or vbCritical)
            txtW.Text = ""
            Return False
        End If
        If IsNumeric(txtD.Text) = False Then
            MsgBox("Valores deben ser numéricos!", vbOK Or vbCritical)
            txtD.Text = ""
            Return False
        End If
        If IsNumeric(txtPaso.Text) = False Then
            MsgBox("Valores deben ser numéricos!", vbOK Or vbCritical)
            txtPaso.Text = ""
            Return False
        End If

        D = Val(txtD.Text)
        paso = Val(txtPaso.Text)
        W = Val(txtW.Text)
        'D = Val(txtD.Text)
        'paso = Val(txtPaso.Text)
        Return True
    End Function
    Function carga_param_rangos() As Boolean
        Try
            r3500 = Val(txt3500.Text)
            r35004000 = Val(txt35004000.Text)
            r40004500 = Val(txt40004500.Text)
            r45005000 = Val(txt45005000.Text)
            r50005500 = Val(txt50005500.Text)
            r55006000 = Val(txt55006000.Text)
            r60006500 = Val(txt60006500.Text)
            r6500 = Val(txt6500.Text)
            Return True
        Catch ex As Exception
            MsgBox("parámetros deben ser numéricos!", vbOKOnly Or vbCritical)
            Return False
        End Try
    End Function

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        If carga_param_geom() = False Then Exit Sub
        If carga_param_rangos() = False Then Exit Sub
        If path_salida = "" Then
            MsgBox("Definir archivo de salida!", vbOKOnly Or vbCritical)
            Exit Sub
        End If
        If (txtEi.Text = "" Or txtEf.Text = "") Then
            MsgBox("No existen valores Este del quad!", vbOKOnly Or vbCritical)
            Exit Sub
        End If
        If (txtNi.Text = "" Or txtNf.Text = "") Then
            MsgBox("No existen valores Norte del quad!", vbOKOnly Or vbCritical)
            Exit Sub
        End If
        If (CIMAS.Count = 0 Or CIMAS05.Count = 0 Or CIMAS08.Count = 0 Or CIMAS12.Count = 0) Then
            MsgBox("No existen Cimas para testear!", vbOKOnly Or vbCritical)
            Exit Sub
        End If

        Procesar(CIMAS, "0p")
        Procesar(CIMAS05, "05p")
        Procesar(CIMAS08, "08p")
        Procesar(CIMAS12, "12p")

        MsgBox("Archivo Procesado Correctamente!", vbOKOnly Or vbInformation)
    End Sub

    Private Sub btbSalida_Click(sender As Object, e As EventArgs) Handles btbSalida.Click
        Dim result As DialogResult = saveFile.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            Dim path As String = saveFile.FileName
            Try
                path_salida = System.IO.Path.GetDirectoryName(path) & "\"
                nombre_salida = System.IO.Path.GetFileNameWithoutExtension(path)

                lblSalidas.Text = path_salida & nombre_salida & "_(WWWWW)_(A)_(0p-05p-08p-12p).txt"
            Catch ex As Exception

                ' Report an error.
                Me.Text = "Error"

            End Try
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        If carga_param_geom() = False Then Exit Sub
        'buildQuad()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cadena() As String
        openFile.FilterIndex = 3
        Dim result As DialogResult = openFile.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            Dim path As String = openFile.FileName
            Try
                path_cimas = path
                Label13.Text = path
                Using reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(path_cimas)
                    CIMAS.Clear()
                    'Dim Titulos() As String = Trim$(reader.ReadLine()).Split(",")
                    '405338,43151222;6386616,47655958;205500,000000;-3616500,000000;6703,000000
                    While (Not reader.EndOfStream)

                        'cadena = Trim$(reader.ReadLine()).Replace(",", ".").Split(";")
                        'Dim p As point3D
                        'p.X = Val(cadena(0))
                        'p.Y = Val(cadena(1))
                        'p.Z = Val(cadena(4))

                        cadena = Trim$(reader.ReadLine()).Split(",")
                        Dim p As point3D
                        p.X = Val(cadena(0))
                        p.X = Val(cadena(0))
                        p.X = Val(cadena(0))
                        p.Y = Val(cadena(1))
                        p.Z = Val(cadena(2))


                        CIMAS.Add(p)
                    End While

                    'lblMsg1.Text = "Número de Cimas: " & CIMAS.Count
                    'buildQuad()
                    set_code_z(CIMAS)
                End Using
            Catch ex As Exception
                ' Report an error.
                Me.Text = "Error"

            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cadena() As String
        openFile.FilterIndex = 3
        Dim result As DialogResult = openFile.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            Dim path As String = openFile.FileName
            Try
                path_cimas = path
                Label17.Text = path
                Using reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(path_cimas)
                    CIMAS05.Clear()
                    'Dim Titulos() As String = Trim$(reader.ReadLine()).Split(",")
                    '405338,43151222;6386616,47655958;205500,000000;-3616500,000000;6703,000000
                    While (Not reader.EndOfStream)

                        'cadena = Trim$(reader.ReadLine()).Replace(",", ".").Split(";")
                        'Dim p As point3D
                        'p.X = Val(cadena(0))
                        'p.Y = Val(cadena(1))
                        'p.Z = Val(cadena(4))

                        cadena = Trim$(reader.ReadLine()).Split(",")
                        Dim p As point3D
                        p.X = Val(cadena(0))
                        p.X = Val(cadena(0))
                        p.X = Val(cadena(0))
                        p.Y = Val(cadena(1))
                        p.Z = Val(cadena(2))


                        CIMAS05.Add(p)
                    End While

                    'lblMsg1.Text = "Número de Cimas: " & CIMAS05.Count
                    'buildQuad()
                    set_code_z(CIMAS05)
                End Using
            Catch ex As Exception
                ' Report an error.
                Me.Text = "Error"

            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cadena() As String
        openFile.FilterIndex = 3
        Dim result As DialogResult = openFile.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            Dim path As String = openFile.FileName
            Try
                path_cimas = path
                Label18.Text = path
                Using reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(path_cimas)
                    CIMAS08.Clear()
                    'Dim Titulos() As String = Trim$(reader.ReadLine()).Split(",")
                    '405338,43151222;6386616,47655958;205500,000000;-3616500,000000;6703,000000
                    While (Not reader.EndOfStream)

                        'cadena = Trim$(reader.ReadLine()).Replace(",", ".").Split(";")
                        'Dim p As point3D
                        'p.X = Val(cadena(0))
                        'p.Y = Val(cadena(1))
                        'p.Z = Val(cadena(4))

                        cadena = Trim$(reader.ReadLine()).Split(",")
                        Dim p As point3D
                        p.X = Val(cadena(0))
                        p.X = Val(cadena(0))
                        p.X = Val(cadena(0))
                        p.Y = Val(cadena(1))
                        p.Z = Val(cadena(2))


                        CIMAS08.Add(p)
                    End While

                    'lblMsg1.Text = "Número de Cimas: " & CIMAS08.Count
                    'buildQuad()
                    set_code_z(CIMAS08)
                End Using
            Catch ex As Exception
                ' Report an error.
                Me.Text = "Error"

            End Try
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim cadena() As String
        openFile.FilterIndex = 3
        Dim result As DialogResult = openFile.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            Dim path As String = openFile.FileName
            Try
                path_cimas = path
                Label19.Text = path
                Using reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(path_cimas)
                    CIMAS12.Clear()
                    'Dim Titulos() As String = Trim$(reader.ReadLine()).Split(",")
                    '405338,43151222;6386616,47655958;205500,000000;-3616500,000000;6703,000000
                    While (Not reader.EndOfStream)

                        'cadena = Trim$(reader.ReadLine()).Replace(",", ".").Split(";")
                        'Dim p As point3D
                        'p.X = Val(cadena(0))
                        'p.Y = Val(cadena(1))
                        'p.Z = Val(cadena(4))

                        cadena = Trim$(reader.ReadLine()).Split(",")
                        Dim p As point3D
                        p.X = Val(cadena(0))
                        p.X = Val(cadena(0))
                        p.X = Val(cadena(0))
                        p.Y = Val(cadena(1))
                        p.Z = Val(cadena(2))


                        CIMAS12.Add(p)
                    End While

                    lblMsg1.Text = "Número de Cimas, base(" & CIMAS.Count & "), 05p(" & CIMAS05.Count & "), 08p(" & CIMAS08.Count & "), 12p(" & CIMAS12.Count & ")"
                    'buildQuad()
                    set_code_z(CIMAS12)
                End Using
            Catch ex As Exception
                ' Report an error.
                Me.Text = "Error"

            End Try
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
Module matho
    Public Const Pi = 3.141592653589
    Public path_cimas As String
    Public path_salida As String
    Public nombre_salida As String

    Public W As Single
    Public D As Single
    Public paso As Integer

    Public r3500 As Integer
    Public r35004000 As Integer
    Public r40004500 As Integer
    Public r45005000 As Integer
    Public r50005500 As Integer
    Public r55006000 As Integer
    Public r60006500 As Integer
    Public r6500 As Integer
    Public GEO As StreamWriter

    Public CENTER As point3D
    Sub set_code_z(ByRef lst As List(Of point3D))
        Dim code As Single = -1
        For i As Integer = 0 To lst.Count - 1
            Dim z As point3D = lst(i)
            Dim v As Single = CInt(z.Z)
            Select Case v
                Case -11000 To 3500
                    code = r3500
                Case 3501 To 4000
                    code = r35004000
                Case 4001 To 4500
                    code = r40004500
                Case 4501 To 5000
                    code = r45005000
                Case 5001 To 5500
                    code = r50005500
                Case 5501 To 6000
                    code = r55006000
                Case 6001 To 6500
                    code = r60006500
                Case 6501 To 10000
                    code = r6500
            End Select
            z.Z = code

            lst(i) = z
        Next

    End Sub
    Public Structure point3D
        Public X As Single
        Public Y As Single
        Public Z As Single
        Public valido As Integer
    End Structure
    Public CIMAS As New List(Of point3D)
    Public CIMAS05 As New List(Of point3D)
    Public CIMAS08 As New List(Of point3D)
    Public CIMAS12 As New List(Of point3D)

    Public Structure defHead
        Public ncol As Integer
        Public nrow As Integer
        Public xllcorner As Double
        Public yllcorner As Double
        Public cellSize As Double
    End Structure

    Public HEAD As defHead

    Public Structure defQuad
        Public Q1 As point3D
        Public Q2 As point3D
        Public Q3 As point3D
        Public Q4 As point3D
    End Structure
    Public Quad As New defQuad

    Function test_SignedPointoToLine(A As point3D, B As point3D, C As point3D) As Integer
        '0 eje
        '-1 derecha
        '1 izq
        Return Math.Sign((B.X - A.X) * (C.Y - A.Y) - (B.Y - A.Y) * (C.X - A.X))
    End Function

    Function chkPtoInCuad(Q As defQuad, P As point3D) As Boolean
        Dim t1 As Single = test_SignedPointoToLine(Q.Q1, Q.Q2, P)
        Dim t2 As Single = test_SignedPointoToLine(Q.Q2, Q.Q3, P)
        Dim t3 As Single = test_SignedPointoToLine(Q.Q3, Q.Q4, P)
        Dim t4 As Single = test_SignedPointoToLine(Q.Q4, Q.Q1, P)
        'poligono en sentido horario
        'test (1) cero o derecha
        'test debe ser tres lados (2,3,4) derecha

        If t1 < 1 Then
            If t2 = -1 And t3 = -1 And t4 = -1 Then
                Return True
            End If
        End If
        Return False
    End Function
    Sub buildQuad(ptos As List(Of point3D))

        Form1.carga_param_geom()

        Dim xc As Long
        Dim yc As Long

        For i As Integer = 0 To ptos.Count - 1
            xc += ptos(i).X
            yc += ptos(i).Y
        Next
        xc = xc / ptos.Count
        yc = yc / ptos.Count

        Dim distMax As Double = -10000000.0


        CENTER.X = xc
        CENTER.Y = yc
        For i As Long = 0 To ptos.Count - 1
            Dim d As Double = Distancia(CENTER, ptos(i), True)
            If d > distMax Then distMax = d
        Next
        distMax = Math.Ceiling(distMax)

        Quad.Q1.X = CENTER.X - distMax
        Quad.Q1.Y = CENTER.Y - distMax

        Quad.Q2.X = CENTER.X - distMax
        Quad.Q2.Y = CENTER.Y + distMax

        Quad.Q3.X = CENTER.X + distMax
        Quad.Q3.Y = CENTER.Y + distMax

        Quad.Q4.X = CENTER.X + distMax
        Quad.Q4.Y = CENTER.Y - distMax

        Dim nbin As Long = (distMax * 2) / W
        Form1.lblMsg2.Text = "Número de Bins: " & nbin

    End Sub
    Function Distancia(A As point3D, B As point3D, Optional en2D As Boolean = False)
        If en2D = True Then
            Return Math.Sqrt((B.Y - A.Y) * (B.Y - A.Y) + (B.X - A.X) * (B.X - A.X))
        Else
            Return Math.Sqrt(LENGTHSQ(vSUB(A, B)))
        End If
    End Function
    Function LENGTHSQ(ByVal A As point3D) As Double
        LENGTHSQ = A.X * A.X + A.Y * A.Y + A.Z * A.Z
    End Function
    Function vSUB(ByVal A As point3D, ByVal B As point3D) As point3D
        Dim X, y, z As Double
        Dim X1, y1, z1 As Double

        X = B.X
        y = B.Y
        z = B.Z

        X1 = A.X
        y1 = A.Y
        z1 = A.Z

        vSUB.X = X1 - X
        vSUB.Y = y1 - y
        vSUB.Z = z1 - z
    End Function
    Function Azimut(A As point3D, B As point3D) As Double
        Return Azimut(A.X, A.Y, B.X, B.Y)
    End Function
    Function Azimut(ByVal x0, ByVal y0, ByVal x1, ByVal y1) As Double
        Dim dx As Double
        Dim dy As Double
        Dim az As Double

        'calcula  el azimut entre dos puntos
        'medido en sexagesimal
        'valor 0 en el norte y 360 nuevamente en el norte sentido horario

        'si ambos puntos son iguales la función retorna -1 para validar
        'resultado

        dx = x1 - x0 : dy = y1 - y0
        If dx = 0 And dy = 0 Then Azimut = -1 : Exit Function

        If dx = 0 And dy > 0 Then az = 0 : GoTo Dist
        If dx = 0 And dy < 0 Then az = Pi : GoTo Dist
        If dx > 0 And dy = 0 Then az = Pi / 2 : GoTo Dist
        If dx < 0 And dy = 0 Then az = Pi * 1.5 : GoTo Dist
        az = Math.Atan(dx / dy)
        If dx > 0 And dy < 0 Then az = az + Pi
        If dx < 0 And dy < 0 Then az = az + Pi
        If dx < 0 And dy > 0 Then az = az + 2 * Pi

Dist:
        Azimut = (180 * az / Pi)

    End Function
    Function Rec(ByVal O As point3D, ByVal Dist As Double, ByVal az As Double, Optional Zeta As Double = 0) As point3D
        If az < 0 Then az = 360 + az
        If az > 360 Then az = az - 360

        Rec.X = O.X + Dist * Math.Sin(az * (Pi / 180))
        Rec.Y = O.Y + Dist * Math.Cos(az * (Pi / 180))
        Rec.Z = Zeta

    End Function
    Function SetXYZ(ByVal X As Double, ByVal Y As Double) As point3D
        SetXYZ.X = X
        SetXYZ.Y = Y
        SetXYZ.Z = 0
    End Function
    Sub Procesar(DATA As List(Of point3D), nombre As String)
        Dim p1, p2, p3, p4 As point3D
        Dim nn As String
        Dim x, y As Double

        Dim xi As Double = Val(Form1.txtEi.Text)
        Dim xf As Double = Val(Form1.txtEf.Text)
        Dim yi As Double = Val(Form1.txtNi.Text)
        Dim yf As Double = Val(Form1.txtNf.Text)

        'GEO = My.Computer.FileSystem.OpenTextFileWriter(Replace(path_salida, ".txt", "-cimas-bines.geojson"), False, System.Text.Encoding.ASCII)
        'write_head()
        'For p As Integer = 0 To CIMAS.Count - 1
        ' write_pto(CIMAS(p), True)
        'Next

        Dim ptos As New List(Of point3D)
        For i = 1 To DATA.Count - 1
            Dim p As point3D = DATA(i)
            x = p.X
            y = p.Y
            If x >= xi And x <= xf And y >= yi And y <= yf Then
                ptos.Add(p)
            End If
        Next

        If ptos.Count = 0 Then Exit Sub

        For km As Integer = 1000 To 10000 Step 1000
            nn = path_salida & nombre_salida & "_" & CStr(km) & "_" & CStr(paso) & "-" & nombre & ".txt"

            Form1.txtW.Text = CStr(km)
            buildQuad(ptos)

            Dim Writer As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(nn, False)
            For az As Single = 0 To 179 Step paso
                Form1.lblMsg3.Text = "Azimut: " & az & ", datos:" & nombre & " [W:" & W & ", paso:" & paso & "]"
                Application.DoEvents()

                Dim bins As Integer = 0
                Dim salida As String = CStr(az)
                For i As Integer = Quad.Q1.X To Quad.Q4.X Step W
                    bins += 1
                    p1 = SetXYZ(i, Quad.Q1.Y)
                    p2 = SetXYZ(i, Quad.Q2.Y)

                    Dim azp1 As Single = Azimut(CENTER, p1)
                    Dim azp2 As Single = Azimut(CENTER, p2)
                    Dim dp1 As Single = Distancia(CENTER, p1)
                    Dim dp2 As Single = Distancia(CENTER, p2)

                    p3 = SetXYZ(i + W, Quad.Q2.Y)
                    p4 = SetXYZ(i + W, Quad.Q1.Y)


                    Dim azp3 As Single = Azimut(CENTER, p3)
                    Dim azp4 As Single = Azimut(CENTER, p4)
                    Dim dp3 As Single = Distancia(p3, CENTER)
                    Dim dp4 As Single = Distancia(p4, CENTER)

                    Dim newQ As defQuad
                    newQ.Q1 = Rec(CENTER, dp1, azp1 + az)
                    newQ.Q2 = Rec(CENTER, dp2, azp2 + az)
                    newQ.Q3 = Rec(CENTER, dp3, azp3 + az)
                    newQ.Q4 = Rec(CENTER, dp4, azp4 + az)
                    'write_path(newQ, az, True)

                    Dim cc As Integer = 0
                    Dim pesos As Integer = 0
                    For p As Integer = 0 To ptos.Count - 1
                        Dim test As Boolean = chkPtoInCuad(newQ, ptos(p))
                        If test = True Then
                            cc += 1
                            pesos += ptos(p).Z
                        End If
                    Next p
                    Dim Msg As String = ""
                    If cc >= 2 Then
                        Dim vv As Single = cc / 2 * (cc + pesos)
                        Msg = "," & CStr(vv)
                    Else
                        Msg = ","
                    End If
                    salida += Msg
                Next i
                Writer.WriteLine(salida)
            Next az

            Writer.Close()
        Next km

        'write_tail()
        'GEO.Close()



    End Sub
End Module
Module drawing
    Sub write_head()
        GEO.WriteLine("{")
        GEO.WriteLine("'type': 'FeatureCollection',")
        GEO.WriteLine("'features': [")
    End Sub
    Sub write_tail()
        GEO.WriteLine("]")
        GEO.WriteLine("}")
    End Sub
    Sub write_pto(P As point3D, Optional coma As Boolean = False)
        GEO.WriteLine("{")
        GEO.WriteLine("'type': 'Feature',")
        GEO.WriteLine("'geometry': {")
        GEO.WriteLine("'type': 'Point',")
        GEO.WriteLine("'coordinates': [" & P.X & "," & P.Y & "]},")
        GEO.WriteLine("'properties': {'codigo':'" & CStr(P.Z) & "'}")
        GEO.WriteLine("}")

        If coma = True Then
            GEO.WriteLine(",")
        End If
    End Sub
    Sub write_path(Q As defQuad, az As Double, Optional coma As Boolean = False)
        GEO.WriteLine("{")
        GEO.WriteLine("'type': 'Feature',")
        GEO.WriteLine("'geometry': {")
        GEO.WriteLine("'type': 'LineString',")
        GEO.WriteLine("'coordinates': [")
        GEO.WriteLine("[" & Q.Q1.X & "," & Q.Q1.Y & "],")
        GEO.WriteLine("[" & Q.Q2.X & "," & Q.Q2.Y & "],")
        GEO.WriteLine("[" & Q.Q3.X & "," & Q.Q3.Y & "],")
        GEO.WriteLine("[" & Q.Q4.X & "," & Q.Q4.Y & "],")
        GEO.WriteLine("[" & Q.Q1.X & "," & Q.Q1.Y & "]]},")
        GEO.WriteLine("'properties': {'azimut':'" & CStr(az) & "'}")
        GEO.WriteLine("}")

        If coma = True Then
            GEO.WriteLine(",")
        End If
    End Sub
    Function Crunch(ByVal Texto As String, ByVal Buscado As String, ByVal Nuevo As String) As String
        Dim c, Temp, Fin, Car As String
        Dim L, X As Integer
        Temp = ""
        X = 1
        While X <= Len(Texto)
            c = Mid$(Texto, X, 1)
            Temp = Temp + c
            If c = Buscado Then
                While Mid$(Texto, X, 1) = Buscado
                    X = X + 1
                End While
            Else
                X = X + 1
            End If
        End While
        L = Len(Temp)
        Fin = ""
        For ciclo = 1 To L
            Car = Mid$(Temp, ciclo, 1)
            If Car = Buscado Then Car = Nuevo
            Fin = Fin & Car
        Next ciclo
        Crunch = Fin
    End Function
End Module


