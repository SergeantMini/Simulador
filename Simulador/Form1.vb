Imports System.Threading.Tasks
Imports System.Timers
Public Class Form1
    'el color de aire es blanco
    'color de solución de sistema es lightblue
    'color de solución de calibración es amarillo
    'color de muestra de sangre es rojo
    'color de vacío es button face
    Dim pos As Int32

    Public Function CerrarTodoPaso()
        CBPinch1.CheckState = CheckState.Indeterminate
        CBPinch2.CheckState = CheckState.Indeterminate
        CBPinch3.CheckState = CheckState.Indeterminate
        CBPinch4.CheckState = CheckState.Indeterminate
        CBPos1.CheckState = CheckState.Indeterminate
        CBPos2.CheckState = CheckState.Indeterminate
        CBPos3.CheckState = CheckState.Indeterminate
        CBPos4.CheckState = CheckState.Indeterminate
        Return 0
    End Function

    Public Function DepositoDesechos()
        'If (PBJar3.Image = Image.FromFile("C:\Users\mones\Pictures\SS\jar.jpg")) Then
        'PBJar3.Image = Image.FromFile("C:\Users\mones\Pictures\SS\jarDesechos1.jpg")
        'ElseIf (PBJar3.Image = Image.FromFile("C:\Users\mones\Pictures\SS\jarDesechos1.jpg")) Then
        'PBJar3.Image = Image.FromFile("C:\Users\mones\Pictures\SS\jarDesechos2.jpg")
        'End If
        Return 0
    End Function

    Public Function abrirValvulaSelectoraEnPos(ByVal pos As Int32) As String
        If (pos = 1) Then
            If (CBPos1.CheckState = CheckState.Indeterminate) Then
                Console.WriteLine("Abriendo válvula selectora en posición de muestra de sangre")
                CBPos1.CheckState = CheckState.Unchecked
            End If
        ElseIf (pos = 2) Then
            If (CBPos2.CheckState = CheckState.Indeterminate) Then
                Console.WriteLine("Abriendo válvula selectora en posición de solución del sistema")
                CBPos2.CheckState = CheckState.Unchecked
            End If
        ElseIf (pos = 3) Then
            If (CBPos3.CheckState = CheckState.Indeterminate) Then
                Console.WriteLine("Abriendo válvula selectora en posición de solución de calibración")
                CBPos3.CheckState = CheckState.Unchecked
            End If
        ElseIf (pos = 4) Then
            If (CBPos4.CheckState = CheckState.Indeterminate) Then
                Console.WriteLine("Abriendo válvula selectora en posición de aire")
                CBPos4.CheckState = CheckState.Unchecked
            End If
        End If
        Return 0
    End Function

    Public Function cerrarValvulaSelectoraEnPos(ByVal pos As Int32) As String
        If (pos = 1) Then
            If (CBPos1.CheckState = CheckState.Unchecked) Then
                Console.WriteLine("Cerrando válvula selectora en posición de muestra de sangre")
                CBPos1.CheckState = CheckState.Indeterminate
            End If
        ElseIf (pos = 2) Then
            If (CBPos2.CheckState = CheckState.Unchecked) Then
                Console.WriteLine("Cerrando válvula selectora en posición de solución del sistema")
                CBPos2.CheckState = CheckState.Indeterminate
            End If
        ElseIf (pos = 3) Then
            If (CBPos3.CheckState = CheckState.Unchecked) Then
                Console.WriteLine("Cerrando válvula selectora en posición de solución de calibración")
                CBPos3.CheckState = CheckState.Indeterminate
            End If
        ElseIf (pos = 4) Then
            If (CBPos4.CheckState = CheckState.Unchecked) Then
                Console.WriteLine("Cerrando válvula selectora en posición de aire")
                CBPos4.CheckState = CheckState.Indeterminate
            End If
        End If
        Return 0
    End Function

    Public Function abrirValvulaPinch(ByVal pos As Int32) As String
        If (pos = 1) Then
            If (CBPinch1.CheckState = CheckState.Indeterminate) Then
                Console.WriteLine("Abriendo válvula Pinch 1")
                CBPinch1.CheckState = CheckState.Unchecked
            End If
        ElseIf (pos = 2) Then
            If (CBPinch2.CheckState = CheckState.Indeterminate) Then
                Console.WriteLine("Abriendo válvula Pinch 2")
                CBPinch2.CheckState = CheckState.Unchecked
            End If
        ElseIf (pos = 3) Then
            If (CBPinch3.CheckState = CheckState.Indeterminate) Then
                Console.WriteLine("Abriendo válvula Pinch 3")
                CBPinch3.CheckState = CheckState.Unchecked
            End If
        ElseIf (pos = 4) Then
            If (CBPinch4.CheckState = CheckState.Indeterminate) Then
                Console.WriteLine("Abriendo válvula Pinch 4")
                CBPinch4.CheckState = CheckState.Unchecked
            End If
            Return 0
        End If
        Return 0
    End Function

    Public Function cerrarValvulaPinch(ByVal pos As Int32) As String
        If (pos = 1) Then
            If (CBPinch1.CheckState = CheckState.Unchecked) Then
                Console.WriteLine("Cerrando válvula Pinch 1")
                CBPinch1.CheckState = CheckState.Indeterminate
            End If
        ElseIf (pos = 2) Then
            If (CBPinch2.CheckState = CheckState.Unchecked) Then
                Console.WriteLine("Cerrando válvula Pinch 2")
                CBPinch2.CheckState = CheckState.Indeterminate
            End If
        ElseIf (pos = 3) Then
            If (CBPinch3.CheckState = CheckState.Unchecked) Then
                Console.WriteLine("Cerrando válvula Pinch 3")
                CBPinch3.CheckState = CheckState.Indeterminate
            End If
        ElseIf (pos = 4) Then
            If (CBPinch4.CheckState = CheckState.Unchecked) Then
                Console.WriteLine("Cerrando válvula Pinch 4")
                CBPinch4.CheckState = CheckState.Indeterminate
            End If
            Return 0
        End If
        Return 0
    End Function

    Public Function pasarSolucionDeSistemaHastaCeldaDeMedicion()
        LSensGota1.BackColor = Color.LightBlue
        LValvSelect.BackColor = Color.LightBlue
        LPinch3.BackColor = Color.LightBlue
        LSensColor.BackColor = Color.LightBlue
        LCeldaMedicion.BackColor = Color.LightBlue
        Console.WriteLine("Solución de sistema en celda de medición")
        Return 0
    End Function

    Public Function pasarAirePorElSistema()
        Console.WriteLine("Pasando aire por el sistema")
        LValvSelect.BackColor = Color.White
        LPinch3.BackColor = Color.White
        LSensColor.BackColor = Color.White
        LCeldaMedicion.BackColor = Color.White
        LValvPinch4.BackColor = Color.White
        'cambiar imagen de depósito de desechos
        Return 0
    End Function

    Public Function retenerSolucionDeSistemaEnCeldaDeMedicion()
        LSensGota1.BackColor = SystemColors.ButtonFace
        LValvSelect.BackColor = SystemColors.ButtonFace
        LPinch3.BackColor = SystemColors.ButtonFace
        LSensColor.BackColor = Color.LightBlue
        LCeldaMedicion.BackColor = Color.LightBlue
        Return 0
    End Function

    Public Function retenerAireEnCelda()
        LValvSelect.BackColor = SystemColors.ButtonFace
        LPinch3.BackColor = SystemColors.ButtonFace
        LSensColor.BackColor = Color.White
        LCeldaMedicion.BackColor = Color.White
        Return 0
    End Function

    Public Function pasarSolucionDeCalibracion()
        Console.WriteLine("Pasando solución de calibración hasta celda de medición")
        LSensGota2.BackColor = Color.Yellow
        LValvSelect.BackColor = Color.Yellow
        LPinch3.BackColor = Color.Yellow
        LSensColor.BackColor = Color.Yellow
        LCeldaMedicion.BackColor = Color.Yellow
        Return 0
        Return 0
    End Function

    Public Function Paso1()
        abrirValvulaSelectoraEnPos(1)
        abrirValvulaPinch(3)
        pasarSolucionDeSistemaHastaCeldaDeMedicion()
        Return 0
    End Function

    Public Function Paso2()
        Console.WriteLine("Se detecta el paso de la solución por la celda de medición por 1 segundo")
        Return 0
    End Function

    Public Function Paso3()
        cerrarValvulaSelectoraEnPos(1)
        cerrarValvulaPinch(3)
        retenerSolucionDeSistemaEnCeldaDeMedicion()
        Return 0
    End Function

    Public Function Paso4()
        abrirValvulaSelectoraEnPos(4)
        abrirValvulaPinch(3)
        abrirValvulaPinch(4)
        pasarAirePorElSistema()
        Return 0
    End Function

    Public Function Paso5()
        cerrarValvulaSelectoraEnPos(4)
        cerrarValvulaPinch(3)
        cerrarValvulaPinch(4)
        retenerAireEnCelda()
        Return 0
    End Function

    Public Function Paso6()
        abrirValvulaSelectoraEnPos(3)
        abrirValvulaPinch(3)
        pasarSolucionDeCalibracion()
        Return 0
    End Function

    Private Sub BComienzo_Click(sender As Object, e As EventArgs) Handles BComienzo.Click
        If (LMuestraSangre.BackColor = Color.Firebrick) Then
            Console.WriteLine("Hay muestra de sangre en el depósito")
            'LSensGota3.BackColor = Color.Firebrick
            Paso1()
            Paso2()
            Paso3()
            Paso4()
            Paso5()
            Paso6()
        ElseIf (LMuestraSangre.BackColor = SystemColors.ButtonFace) Then
            MessageBox.Show("Ingresar una muestra de sangre")
        End If

    End Sub

    Private Sub BAgregarMuestra_Click(sender As Object, e As EventArgs) Handles BAgregarMuestra.Click
        LMuestraSangre.BackColor = Color.Firebrick
        Console.WriteLine("Se ingresó una muestra de sangre en el sistema")
    End Sub
End Class