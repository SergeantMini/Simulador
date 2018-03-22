Imports System.ComponentModel

Public Class Form1
    'el color de aire es rosa
    'color de solución de sistema es lightblue
    'color de solución de calibración es amarillo
    'color de muestra de sangre es firebrick
    'color de vacío es button face
    Dim pos As Int32
    Dim nombre As String


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
        ' en esta función se pretende cambiar la imagen de acuerdo al uso que se le ha dado a las soluciones
        ' o de acuerdo a la cantidad de desechos que se le da al depósito.
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
                TBEstado.Text = ("Abriendo válvula selectora en posición de muestra de sangre")
                wait(2000)
                CBPos1.CheckState = CheckState.Unchecked
            End If
        ElseIf (pos = 2) Then
            If (CBPos2.CheckState = CheckState.Indeterminate) Then
                TBEstado.Text = ("Abriendo válvula selectora en posición de solución del sistema")
                wait(2000)
                CBPos2.CheckState = CheckState.Unchecked
            End If
        ElseIf (pos = 3) Then
            If (CBPos3.CheckState = CheckState.Indeterminate) Then
                TBEstado.Text = ("Abriendo válvula selectora en posición de solución de calibración")
                wait(2000)
                CBPos3.CheckState = CheckState.Unchecked
            End If
        ElseIf (pos = 4) Then
            If (CBPos4.CheckState = CheckState.Indeterminate) Then
                TBEstado.Text = ("Abriendo válvula selectora en posición de aire")
                wait(2000)
                CBPos4.CheckState = CheckState.Unchecked
            End If
        End If
        Return 0
    End Function

    Public Function cerrarValvulaSelectoraEnPos(ByVal pos As Int32) As String
        If (pos = 1) Then
            If (CBPos1.CheckState = CheckState.Unchecked) Then
                TBEstado.Text = ("Cerrando válvula selectora en posición de muestra de sangre")
                wait(2000)
                CBPos1.CheckState = CheckState.Indeterminate
            End If
        ElseIf (pos = 2) Then
            If (CBPos2.CheckState = CheckState.Unchecked) Then
                TBEstado.Text = ("Cerrando válvula selectora en posición de solución del sistema")
                wait(2000)
                CBPos2.CheckState = CheckState.Indeterminate
            End If
        ElseIf (pos = 3) Then
            If (CBPos3.CheckState = CheckState.Unchecked) Then
                TBEstado.Text = ("Cerrando válvula selectora en posición de solución de calibración")
                wait(2000)
                CBPos3.CheckState = CheckState.Indeterminate
            End If
        ElseIf (pos = 4) Then
            If (CBPos4.CheckState = CheckState.Unchecked) Then
                TBEstado.Text = ("Cerrando válvula selectora en posición de aire")
                wait(2000)
                CBPos4.CheckState = CheckState.Indeterminate
            End If
        End If
        Return 0
    End Function

    Public Function abrirValvulaPinch(ByVal pos As Int32) As String
        If (pos = 1) Then
            If (CBPinch1.CheckState = CheckState.Indeterminate) Then
                TBEstado.Text = ("Abriendo válvula Pinch 1")
                wait(2000)
                CBPinch1.CheckState = CheckState.Unchecked
            End If
        ElseIf (pos = 2) Then
            If (CBPinch2.CheckState = CheckState.Indeterminate) Then
                TBEstado.Text = ("Abriendo válvula Pinch 2")
                wait(2000)
                CBPinch2.CheckState = CheckState.Unchecked
            End If
        ElseIf (pos = 3) Then
            If (CBPinch3.CheckState = CheckState.Indeterminate) Then
                TBEstado.Text = ("Abriendo válvula Pinch 3")
                wait(2000)
                CBPinch3.CheckState = CheckState.Unchecked
            End If
        ElseIf (pos = 4) Then
            If (CBPinch4.CheckState = CheckState.Indeterminate) Then
                TBEstado.Text = ("Abriendo válvula Pinch 4")
                wait(2000)
                CBPinch4.CheckState = CheckState.Unchecked
            End If
            Return 0
        End If
        Return 0
    End Function

    Public Function cerrarValvulaPinch(ByVal pos As Int32) As String
        If (pos = 1) Then
            If (CBPinch1.CheckState = CheckState.Unchecked) Then
                TBEstado.Text = ("Cerrando válvula Pinch 1")
                wait(2000)
                CBPinch1.CheckState = CheckState.Indeterminate
            End If
        ElseIf (pos = 2) Then
            If (CBPinch2.CheckState = CheckState.Unchecked) Then
                TBEstado.Text = ("Cerrando válvula Pinch 2")
                wait(2000)
                CBPinch2.CheckState = CheckState.Indeterminate
            End If
        ElseIf (pos = 3) Then
            If (CBPinch3.CheckState = CheckState.Unchecked) Then
                TBEstado.Text = ("Cerrando válvula Pinch 3")
                wait(2000)
                CBPinch3.CheckState = CheckState.Indeterminate
            End If
        ElseIf (pos = 4) Then
            If (CBPinch4.CheckState = CheckState.Unchecked) Then
                TBEstado.Text = ("Cerrando válvula Pinch 4")
                wait(2000)
                CBPinch4.CheckState = CheckState.Indeterminate
            End If
            Return 0
        End If
        Return 0
    End Function

    Public Function pasarSolucionDeSistemaHastaCeldaDeMedicion()
        LSensGota1.BackColor = Color.Blue
        wait(1000)
        LValvSelect.BackColor = Color.Blue
        wait(1000)
        LPinch3.BackColor = Color.Blue
        wait(1000)
        LSensColor.BackColor = Color.Blue
        wait(1000)
        LCeldaMedicion.BackColor = Color.Blue
        wait(1000)
        LValvPinch4.BackColor = Color.Blue
        wait(1000)
        TBEstado.Text = ("Solución de sistema en celda de medición")
        Return 0
    End Function

    Public Function pasarAirePorElSistema()
        TBEstado.Text = ("Pasando aire por el sistema")
        wait(1000)
        LValvSelect.BackColor = Color.Pink
        wait(1000)
        LPinch3.BackColor = Color.Pink
        wait(1000)
        LSensColor.BackColor = Color.Pink
        wait(1000)
        LCeldaMedicion.BackColor = Color.Pink
        wait(1000)
        LValvPinch4.BackColor = Color.Pink
        wait(1000)
        'cambiar imagen de depósito de desechos
        Return 0
    End Function

    Public Function retenerSolucionDeSistemaEnCeldaDeMedicion()
        LSensGota1.BackColor = SystemColors.ButtonFace
        wait(1000)
        LValvSelect.BackColor = SystemColors.ButtonFace
        wait(1000)
        LPinch3.BackColor = SystemColors.ButtonFace
        wait(1000)
        LSensColor.BackColor = Color.Blue
        wait(1000)
        LCeldaMedicion.BackColor = Color.Blue
        TBEstado.Text = ("Reteniendo solución en celda de medición")
        Return 0
    End Function

    Public Function retenerAireEnCelda()
        LValvSelect.BackColor = SystemColors.ButtonFace
        wait(1000)
        LPinch3.BackColor = SystemColors.ButtonFace
        wait(1000)
        LSensColor.BackColor = Color.Pink
        wait(1000)
        LCeldaMedicion.BackColor = Color.Pink
        wait(1000)
        TBEstado.Text = ("Reteniendo aire en la celda de medición")
        Return 0
    End Function

    Public Function pasarSolucionDeCalibracion()
        TBEstado.Text = ("Pasando solución de calibración hasta celda de medición")
        wait(1000)
        LSensGota2.BackColor = Color.Yellow
        wait(1000)
        LValvSelect.BackColor = Color.Yellow
        wait(1000)
        LPinch3.BackColor = Color.Yellow
        wait(1000)
        LSensColor.BackColor = Color.Yellow
        wait(1000)
        LCeldaMedicion.BackColor = Color.Yellow
        wait(1000)
        LValvPinch4.BackColor = Color.Yellow
        wait(1000)
        Return 0
    End Function

    Public Function retenerSolucionDeCalibracion()
        LValvSelect.BackColor = SystemColors.ButtonFace
        wait(1000)
        LPinch3.BackColor = SystemColors.ButtonFace
        wait(1000)
        LSensGota2.BackColor = SystemColors.ButtonFace
        wait(1000)
        LSensColor.BackColor = Color.Yellow
        wait(1000)
        LCeldaMedicion.BackColor = Color.Yellow
        wait(1000)
        TBEstado.Text = ("Reteniendo solución de calibración")
        Return 0
    End Function

    Public Function pasarMuestraDeSangre()
        TBEstado.Text = ("Pasando muestra de sangre hasta celda de medición")
        wait(1000)
        LSensGota3.BackColor = Color.Firebrick
        wait(1000)
        LValvSelect.BackColor = Color.Firebrick
        wait(1000)
        LPinch3.BackColor = Color.Firebrick
        wait(1000)
        LSensColor.BackColor = Color.Firebrick
        wait(1000)
        LCeldaMedicion.BackColor = Color.Firebrick
        wait(1000)
        Return 0
    End Function

    Public Function retenerMuestraDeSangre()
        LValvSelect.BackColor = SystemColors.ButtonFace
        wait(1000)
        LPinch3.BackColor = SystemColors.ButtonFace
        wait(1000)
        LSensColor.BackColor = Color.Firebrick
        wait(1000)
        LCeldaMedicion.BackColor = Color.Firebrick
        wait(1000)
        Console.WriteLine("Reteniendo muestra de sangre")
        wait(1000)
        Return 0
    End Function

    Public Function limpiarCamaraDeMuestra()
        LPinch1.BackColor = Color.Blue
        wait(1000)
        LMuestraSangre.BackColor = Color.Blue
        wait(1000)
        LValvSelect.BackColor = Color.Blue
        wait(1000)
        LPinch2.BackColor = Color.Blue
        wait(1000)
        LSensGota3.BackColor = Color.Blue
        wait(1000)
        Return 0
    End Function

    Private Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            ' Allows UI to remain responsive
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub

    Public Function Paso1()
        abrirValvulaSelectoraEnPos(2)
        wait(4000)
        abrirValvulaPinch(3)
        wait(4000)
        abrirValvulaPinch(4)
        wait(4000)
        pasarSolucionDeSistemaHastaCeldaDeMedicion()
        wait(4000)
        Return 0
    End Function

    Public Function Paso2()
        TBEstado.Text = ("Se detecta el paso de la solución flush por la celda de medición por 1 segundo")
        wait(4000)
        Return 0
    End Function

    Public Function Paso3()
        cerrarValvulaSelectoraEnPos(2)
        wait(4000)
        cerrarValvulaPinch(3)
        wait(4000)
        cerrarValvulaPinch(4)
        wait(4000)
        retenerSolucionDeSistemaEnCeldaDeMedicion()
        wait(4000)
        Return 0
    End Function

    Public Function Paso4()
        abrirValvulaSelectoraEnPos(4)
        wait(4000)
        abrirValvulaPinch(3)
        wait(4000)
        abrirValvulaPinch(4)
        wait(4000)
        pasarAirePorElSistema()
        wait(4000)
        Return 0
    End Function

    Public Function Paso5()
        cerrarValvulaSelectoraEnPos(4)
        wait(4000)
        cerrarValvulaPinch(3)
        wait(4000)
        cerrarValvulaPinch(4)
        wait(4000)
        retenerAireEnCelda()
        wait(4000)
        Return 0
    End Function

    Public Function Paso6()
        abrirValvulaSelectoraEnPos(3)
        wait(4000)
        abrirValvulaPinch(3)
        wait(4000)
        abrirValvulaPinch(4)
        wait(4000)
        pasarSolucionDeCalibracion()
        wait(4000)
        Return 0
    End Function

    Public Function Paso7()
        TBEstado.Text = ("Se detecta el paso de la solución de calibración por la celda de medición por 1 segundo")
        wait(4000)
        Return 0
    End Function

    Public Function Paso8()
        cerrarValvulaSelectoraEnPos(3)
        wait(4000)
        cerrarValvulaPinch(3)
        wait(4000)
        cerrarValvulaPinch(4)
        wait(4000)
        retenerSolucionDeCalibracion()
        wait(4000)
        Return 0
    End Function

    Public Function Paso9()
        TBEstado.Text = ("Se mide el valor de glucosa de la solución de calibración para calibrar el instrumento")
        wait(4000)
        Return 0
    End Function

    Public Function Paso10()
        abrirValvulaSelectoraEnPos(4)
        wait(4000)
        abrirValvulaPinch(3)
        wait(4000)
        abrirValvulaPinch(4)
        wait(4000)
        pasarAirePorElSistema()
        wait(4000)
        Return 0
    End Function

    Public Function Paso11()
        cerrarValvulaPinch(4)
        wait(4000)
        cerrarValvulaPinch(3)
        wait(4000)
        cerrarValvulaSelectoraEnPos(4)
        wait(4000)
        retenerAireEnCelda()
        wait(4000)
        Return 0
    End Function

    Public Function Paso12()
        abrirValvulaSelectoraEnPos(1)
        wait(4000)
        abrirValvulaPinch(3)
        wait(4000)
        pasarMuestraDeSangre()
        wait(4000)
        Return 0
    End Function

    Public Function Paso13()
        TBEstado.Text = ("Se detecta el paso de la muestra por la celda de medición por un segundo")
        wait(4000)
        Return 0
    End Function

    Public Function Paso14()
        cerrarValvulaPinch(3)
        wait(4000)
        cerrarValvulaSelectoraEnPos(1)
        wait(4000)
        retenerMuestraDeSangre()
        wait(4000)
        Return 0
    End Function

    Public Function Paso15()
        TBEstado.Text = ("Se mide el color de la muestra mediante el sensor de color.")
        wait(4000)
        If (LSensColor.BackColor = Color.Firebrick) Then
            TBEstado.Text = ("La muestra corresponde a sangre arterial")
            TBEstado.Text = ("Se mide la concentración de glucosa de la muestra con la celda de medición durante diez segundos")
            wait(4000)
        Else
            TBEstado.Text = ("Muestra no válida")
            wait(4000)
        End If
        Return 0
    End Function

    Public Function Paso17()
        TBEstado.Text = ("Se mide la concentración de glucosa de la muestra con la celda de medición durante diez segundos")
        wait(4000)
        Return 0
    End Function

    Public Function Paso18()
        abrirValvulaSelectoraEnPos(4)
        wait(4000)
        abrirValvulaPinch(3)
        wait(4000)
        abrirValvulaPinch(4)
        wait(4000)
        pasarAirePorElSistema()
        wait(4000)
        Return 0
    End Function

    Public Function Paso19()
        cerrarValvulaSelectoraEnPos(4)
        wait(4000)
        cerrarValvulaPinch(3)
        wait(4000)
        cerrarValvulaPinch(4)
        wait(4000)
        retenerAireEnCelda()
        wait(4000)
        Return 0
    End Function

    Public Function Paso20()
        abrirValvulaSelectoraEnPos(2)
        wait(4000)
        abrirValvulaPinch(3)
        wait(4000)
        abrirValvulaPinch(4)
        wait(4000)
        pasarSolucionDeSistemaHastaCeldaDeMedicion()
        wait(4000)
        Return 0
    End Function

    Public Function Paso21()
        TBEstado.Text = ("Se detecta el paso de la solución flush con la celda de medición por un segundo")
        wait(4000)
        Return 0
    End Function

    Public Function Paso22()
        cerrarValvulaPinch(4)
        wait(4000)
        cerrarValvulaPinch(3)
        wait(4000)
        cerrarValvulaSelectoraEnPos(2)
        wait(4000)
        retenerSolucionDeSistemaEnCeldaDeMedicion()
        wait(4000)
        Return 0
    End Function

    Public Function Paso23()
        abrirValvulaSelectoraEnPos(1)
        wait(4000)
        abrirValvulaPinch(1)
        wait(4000)
        abrirValvulaPinch(2)
        wait(4000)
        limpiarCamaraDeMuestra()
        wait(4000)
        Return 0
    End Function

    Public Function Paso24()
        cerrarValvulaSelectoraEnPos(1)
        wait(4000)
        cerrarValvulaPinch(1)
        wait(4000)
        cerrarValvulaPinch(2)
        wait(4000)
        LMuestraSangre.BackColor = SystemColors.ButtonFace
        wait(4000)
        LPinch1.BackColor = SystemColors.ButtonFace
        wait(4000)
        LPinch2.BackColor = SystemColors.ButtonFace
        wait(4000)
        Return 0
    End Function

    Public Function Paso25()
        abrirValvulaSelectoraEnPos(4)
        wait(4000)
        abrirValvulaPinch(3)
        wait(4000)
        abrirValvulaPinch(4)
        wait(4000)
        pasarAirePorElSistema()
        wait(4000)
        Return 0
    End Function

    Public Function Paso26()
        cerrarValvulaSelectoraEnPos(4)
        wait(4000)
        cerrarValvulaPinch(3)
        wait(4000)
        cerrarValvulaPinch(4)
        wait(4000)
        retenerAireEnCelda()
        wait(4000)
        TBEstado.Text = ("El sistema está listo para otra medición")
        Return 0
    End Function

    Private Sub BComienzo_Click(sender As Object, e As EventArgs) Handles BComienzo.Click
        If (LMuestraSangre.BackColor = Color.Firebrick) Then
            TBEstado.Text = ("Hay muestra de sangre en el depósito")
            'LSensGota3.BackColor = Color.Firebrick
            Paso1()
            Paso2()
            Paso3()
            Paso4()
            Paso5()
            Paso6()
            Paso7()
            Paso8()
            Paso9()
            Paso10()
            Paso11()
            Paso12()
            Paso13()
            Paso14()
            Paso15()
            Paso18()
            Paso19()
            Paso20()
            Paso21()
            Paso22()
            Paso23()
            Paso24()
            Paso25()
            Paso26()
            If (LSensColor.BackColor = Color.Firebrick) Then

            End If
        ElseIf (LMuestraSangre.BackColor = SystemColors.ButtonFace) Then
            MessageBox.Show("Ingresar una muestra de sangre")
        End If

    End Sub

    Private Sub BAgregarMuestra_Click(sender As Object, e As EventArgs) Handles BAgregarMuestra.Click
        LMuestraSangre.BackColor = Color.Firebrick
        TBEstado.Text = ("Se ingresó una muestra de sangre en el sistema")
    End Sub

    Private Sub BDetener_Click(sender As Object, e As EventArgs) Handles BDetener.Click
        'stopclick = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
